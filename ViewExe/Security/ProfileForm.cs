using MVCHIS.Common;
using MVCHIS.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MVCHIS.Security {
    //[ForModel(Common.MODELS.Profile)]
    public partial class ProfileForm: ProfileView {

        private List<EntitlementModel> entitlements;
        private List<ProfileEntitlementModel> profileEntitlements;
        
        public ProfileForm() {
            InitializeComponent(); if (DesignMode||(Site!=null && Site.DesignMode)) return;
            //template
            Mapper["Id"] = PickList[btnPLProfile] = txtId;
            Mapper["CreatedBy"] = txtCreatedBy;
            Mapper["CreatedOn"] = txtCreatedOn;
            Mapper["UpdatedBy"] = txtUpdatedBy;
            Mapper["UpdatedOn"] = txtUpdatedOn;
            Mapper["ReadOnly"] = chkReadOnly;
            //data
            Mapper["ProfileName"] = txtProfileName;
            Mapper["ProfileDesc"] = txtProfileDesc;
            //actions
            SaveButton = btnSave;
            DeleteButton = btnDelete;
            NewButton = btnNew;
            //pick lists
            PickList[btnPLEntitlementGroup] = txtEntitlementGroupId;

            entitlements = DBControllersFactory.Entitlement().Read().ToList();
        }        

        private void ProfileFormLoad(object sender, EventArgs e) { if (DesignMode||(Site!=null && Site.DesignMode)) return;
        }

        private void TxtId_TextChanged(object sender, EventArgs e) {
            profileEntitlements = DBControllersFactory.ProfileEntitlement().Read(new ProfileEntitlementModel() {ProfileId = Model.Id}, "ProfileId").ToList();
            txtEntitlementGroupId.Text = "";
            RequeryEntitlements();
            RequeryUsers();
        }

        private void RequeryUsers() {
            lstUsers.LoadData("", DBControllersFactory.User().Select(new UserModel { ProfileId=Model.Id }, "UserName,FullName",false,"ProfileId"),"UserName","FullName");
        }

        private void TxtEntitlementGroupId_TextChanged(object sender, EventArgs e) {
            txtEntitlementGroupName.Text = DBControllersFactory.FK(MODELS.EntitlementGroup, txtEntitlementGroupId.Text);
            RequeryEntitlements();
        }

        private void RequeryEntitlements() {
            btnAddPE.Enabled = btnEditPE.Enabled = btnDeletePE.Enabled = false;
            var ents = from x in entitlements where x.EntitlementGroupId == txtEntitlementGroupId.Text.ToInteger() select x.Id;
            lstProfileEntitlements.LoadData("", profileEntitlements.Where(pe => "" == txtEntitlementGroupId.Text || ents.Contains(pe.EntitlementId))
                , "Id"
                , "EntitlementId"
                , "AllowCreate"
                , "AllowRead"
                , "AllowUpdate"
                , "AllowDelete");
            foreach(ColumnHeader c in lstProfileEntitlements.Columns) { c.Text = c.Text.Replace("Allow","").Trim(); }
            btnAddPE.Enabled = Model.Id > 0;
            lstProfileEntitlements.AutoFitColumns();
        }

        private void LstProfileEntitlements_SelectedIndexChanged(object sender, EventArgs e) {
            btnEditPE.Enabled = Model.Id > 0 && lstProfileEntitlements.SelectedIndices.Count > 0;
            btnDeletePE.Enabled = Model.Id > 0 && lstProfileEntitlements.SelectedIndices.Count > 0;
        }

        private void BtnDeletePE_Click(object sender, EventArgs e) {
            DBControllersFactory.ProfileEntitlement().Delete(new ProfileEntitlementModel { Id = lstProfileEntitlements.SelectedValue.ToInteger() });
        }

        private void BtnAddPE_Click(object sender, EventArgs e) {
            OpenProfileEntitlement(new ProfileEntitlementModel { });
        }

        private void BtnEditPE_Click(object sender, EventArgs e) {
            var model = new ProfileEntitlementModel { Id = lstProfileEntitlements.SelectedValue.ToInteger() };
            OpenProfileEntitlement(model).SetModel(DBControllersFactory.ProfileEntitlement().Find(model, "Id"));
        }

        private ProfileEntitlementView OpenProfileEntitlement(ProfileEntitlementModel pe) {
            var form = new Form();
            var view = (ProfileEntitlementForm)DBViewsFactory.GetView(MODELS.ProfileEntitlement);
            pe.ProfileId = Model.Id;
            view.SetModel(pe);
            view.Dock = DockStyle.Fill;
            form.Controls.Add(view);
            form.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Size = new System.Drawing.Size(430, 430);
            view.SetNewButtonEnabled(false);
            view.SetDeleteButtonEnabled(false);
            view.DisableChangeProfile();
            bool isnew = pe.Id == 0;
            view.AfterSave += (b) => {
                
                if (isnew) {
                    profileEntitlements.Add(view.Model);
                } else {
                    profileEntitlements[profileEntitlements.IndexOf(profileEntitlements.Where(x => x.Id == pe.Id).First())]=view.Model;
                }
                RequeryEntitlements();
                form.Close();
            };
            form.Show();
            return view;
        }
    }
    
}
