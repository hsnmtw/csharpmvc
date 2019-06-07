using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MVCHIS.Common;
using MVCHIS.Tools;
using MVCHIS.Utils;

namespace web.Views.Tools {
    public partial class DictionaryUC : System.Web.UI.UserControl {
        private WordController CntrlDC;
        public WordModel Model {
            get {
                return new WordModel {
                    WordInEnglish=en.Text,
                    //WordInArabic=ar.Text,
                    Id=id.Text.ToInteger()
                };
            }
            set {
                en.Text = value.WordInEnglish;
                //ar.Text = value.WordInArabic;
                id.Text = value.Id.ToString();
                cb.Text = value.CreatedBy;
                co.Text = value.CreatedOn.ToString();
                ub.Text = value.UpdatedBy;
                uo.Text = value.UpdatedOn.ToString();

            }
        }

        protected void Page_Load(object sender, EventArgs e) {
            MVCHISSession.Instance.Initialize();
            CntrlDC = DBControllersFactory.Word();

            foreach(var dm in CntrlDC.Read()) {
                DropDownList1.Items.Add(dm.Id.ToString());
            }

            //DropDownList1.DataSource = CntrlDC.Read();
            //DropDownList1.DataValueField = "Id";
            //DropDownList1.DataTextField = "WordInEnglish";
        }

        protected void Button1_Click(object sender, EventArgs e) {
            Model = new WordModel();
        }

        protected void Button2_Click(object sender, EventArgs e) {
            if (CntrlDC.Save(Model) > 0) {
                Model = CntrlDC.Find(new WordModel { WordInEnglish = Model.WordInEnglish }, "WordInEnglish");
            }
        }

        protected void Button3_Click(object sender, EventArgs e) {
            CntrlDC.Delete(Model);
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e) {
            Model = CntrlDC.Find(new WordModel { Id = DropDownList1.SelectedValue.ToString().ToInteger() }, "Id");
        }

        protected void Button4_Click(object sender, EventArgs e) {
            Model = CntrlDC.Find(new WordModel { Id = DropDownList1.SelectedValue.ToString().ToInteger() }, "Id");
        }
    }
}