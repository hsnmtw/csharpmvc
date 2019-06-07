using MVCHIS.Utils;
using System;
using MVCHIS.Common;
using MVCHIS.Tools;

namespace MVCHIS.Common {
    //[ForModel(Common.MODELS.DictionaryLanguage)]
    public partial class WordLanguageForm: WordLanguageView {
        
        public WordLanguageForm() {
            InitializeComponent(); if (DesignMode||(Site!=null && Site.DesignMode)) return;
            //template
            Mapper["Id"] = txtId;
            Mapper["CreatedBy"] = txtCreatedBy;
            Mapper["CreatedOn"] = txtCreatedOn;
            Mapper["UpdatedBy"] = txtUpdatedBy;
            Mapper["UpdatedOn"] = txtUpdatedOn;
            Mapper["ReadOnly"]  = chkReadOnly;
            //data
            Mapper["WordInLanguage"] = txtWordInLanguage;
            Mapper["WordId"]         = txtWordId;
            Mapper["LanguageId"]     = txtLanguageId;
            //actions
            SaveButton = btnSave;
            DeleteButton = btnDelete;
            NewButton = btnNew;
            //pick lists
            PickList[btnPLWord] = txtWordId;
            PickList[btnPLLanguage] = txtLanguageId;
            PickList[btnPLWordLanguage] = txtId;
        }

        private void DictionaryLanguageFormLoad(object sender, EventArgs e) { if (DesignMode||(Site!=null && Site.DesignMode)) return;
        }

        

        private void TxtWordId_TextChanged(object sender, EventArgs e) {
            txtWordInEnglish.Text = DBControllersFactory.FK(MODELS.Word, txtWordId.Text);
        }

        private void TxtLanguageId_TextChanged(object sender, EventArgs e) {
            txtLanguageName.Text = DBControllersFactory.FK(MODELS.Language, txtLanguageId.Text);
        }

        private void PickListButtonWord_LookUpSelected(int obj) {
            txtWordId.Text = obj.ToString();
        }

        internal void DisableChangeWord() {
            btnPLWord.Enabled = false;
            btnPLWordLanguage.Enabled = false;
            btnPLLanguage.Enabled = false;
            txtWordId.Enabled = false;
            txtWordInEnglish.Enabled = false;
            txtLanguageId.Enabled = false;
            txtLanguageName.Enabled = false;
        }

        private void PickListButtonLanguage_LookUpSelected(int obj) {
            txtLanguageId.Text = obj.ToString();
        }
    }
    
}
