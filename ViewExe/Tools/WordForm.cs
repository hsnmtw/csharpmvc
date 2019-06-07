using MVCHIS.Common;
using MVCHIS.Utils;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace MVCHIS.Tools {
    //[ForModel(Common.MODELS.Dictionary)]
    public partial class WordForm: WordView {

        private List<WordLanguageModel> WordLanguages;

        public WordForm() : base() {
            InitializeComponent(); if (DesignMode||(Site!=null && Site.DesignMode)) return;
            //template
            Mapper["Id"] = txtId;
            Mapper["CreatedBy"] = txtCreatedBy;
            Mapper["CreatedOn"] = txtCreatedOn;
            Mapper["UpdatedBy"] = txtUpdatedBy;
            Mapper["UpdatedOn"] = txtUpdatedOn;
            //data
            Mapper["WordInEnglish"] = txtWordInEnglish;
            //actions
            SaveButton = btnSave;
            DeleteButton = btnDelete;
            NewButton = btnNew;
            //pick list
            PickList[btnPLWord] = txtId;

            WordLanguages = new List<WordLanguageModel>();
        }


        private WordLanguageView OpenWordLanguage(WordLanguageModel wordLanguageModel) {
            var form = new Form();
            var view = (WordLanguageForm)DBViewsFactory.GetView(MODELS.WordLanguage);
            wordLanguageModel.WordId = Model.Id;
            view.SetModel(wordLanguageModel);
            view.Dock = DockStyle.Fill;
            form.Controls.Add(view);
            form.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Size = new System.Drawing.Size(430, 430);
            view.SetNewButtonEnabled    ( false );
            view.SetDeleteButtonEnabled ( false );
            view.DisableChangeWord();
            view.AfterNew = delegate (bool status) {
                view.SetModel(new WordLanguageModel() { WordId = Model.Id });
            };
            view.AfterSave += delegate(bool status) {
                if (status) form.Close();
            };
            form.Show();
            return view;
        }

        

        private void TxtId_TextChanged(object sender, EventArgs e) {
            WordLanguages = Controller.GetWordInLanguages(Model.Id).ToList();
            lstWordInLanguages.LoadData("", WordLanguages,"Id","LanguageId","WordInLanguage");
            btnAddWordInLanguage.Enabled = txtId.Text.ToInteger() > 0;
            btnDeleteWordInLanguage.Enabled = btnEditWordInLanguage.Enabled = lstWordInLanguages.SelectedValue != null;
        }

        private void BtnDeleteWordInLanguage_Click(object sender, EventArgs e) {
            if (lstWordInLanguages.SelectedIndices.Count > 0) {
                if (Controller.DeleteWordInLanguage(lstWordInLanguages.SelectedValue.ToInteger()) > 0) {
                    lstWordInLanguages.Items.RemoveAt(lstWordInLanguages.SelectedIndices[0]);
                }
            }
        }

        private void BtnEditWordInLanguage_Click(object sender, EventArgs e) {
            if (lstWordInLanguages.SelectedIndices.Count > 0) {
                int index = lstWordInLanguages.SelectedIndices[0];
                WordLanguageView view = OpenWordLanguage(WordLanguages[index]);
                view.AfterSave += delegate (bool status) {
                    if (status) {
                        WordLanguages[index] = view.Model;
                        ListViewItem item = new ListViewItem();
                        item.SubItems[0].Text = view.Model.Id.ToString();
                        item.SubItems[1].Text = DBControllersFactory.FK(MODELS.Language, view.Model.LanguageId);
                        item.SubItems[2].Text = view.Model.WordInLanguage;
                        lstWordInLanguages.Items[index] = item;
                    }
                };
            }
        }

        private void AddWordLanguage(int languageId) {
            
            WordLanguageView view = OpenWordLanguage(new WordLanguageModel { LanguageId = languageId });
            view.AfterSave += delegate (bool status) {
                if (status) {
                    WordLanguages.Add(view.Model);
                    lstWordInLanguages.AddRowFromModel(view.Model);
                }
            };
        }

        private void BtnAddWordInLanguage_Click(object sender, EventArgs e) {
            if (txtId.Text.ToInteger() == 0) return;
            contextMenuStripLanguage.Items.Clear();

            foreach (var kv in Controller.GetLanguagesNotEnteredForWord(Model.Id)) {
                contextMenuStripLanguage.Items.Add(kv.Value).Click += (xs, xe) => {
                    AddWordLanguage(kv.Key);
                };
            }

            contextMenuStripLanguage.Show(FormsHelper.GetRelativePoint(btnAddWordInLanguage));
        }



        private void LstWordInLanguages_SelectedIndexChanged(object sender, EventArgs e) {
            btnEditWordInLanguage.Enabled = btnDeleteWordInLanguage.Enabled = lstWordInLanguages.SelectedIndices.Count > 0;  
        }

        private void DictionaryFormLoad(object sender, EventArgs e) {

        }
    }
    
}
