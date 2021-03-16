using Common.Collections.Interfaces;
using ObservingStudy.Interfaces;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ObservingStudy.Editors {
    public partial class FEditor : Form, IEditor {

        public string Title { set => this.Text = value; }
        public string Header { set => labelHeader.Text = value; }

        private IObservableCollection<string> collection;

        public FEditor(IObservableCollection<string> collection) {
            this.collection = collection ?? throw new ArgumentNullException();
            InitializeComponent();
        }

        private void FDataEditor_Load(object sender, EventArgs e) {
            listBoxData.AllowDrop = true;
            ShowData();
            SetControlsState();
        }

        private void SetControlsState() {
            buttonRemove.Enabled = listBoxData.SelectedIndex >= 0;
            buttonAdd.Enabled = !String.IsNullOrWhiteSpace(textBoxData.Text);
        }

        private void ShowData() {
            listBoxData.Items.Clear();
            listBoxData.Items.AddRange(collection.ToArray());
        }

        private void listBoxData_SelectedIndexChanged(object sender, EventArgs e) {
            SetControlsState();
        }

        private void textBoxNew_TextChanged(object sender, EventArgs e) {
            SetControlsState();
        }

        private void buttonAdd_Click(object sender, EventArgs e) {
            if (String.IsNullOrWhiteSpace(textBoxData.Text))
                return;
            collection.Add(textBoxData.Text.Trim());
            ShowData();
            SetControlsState();
        }

        private void buttonRemove_Click(object sender, EventArgs e) {
            if (listBoxData.SelectedIndex < 0)
                return;
            string s = (string)listBoxData.SelectedItem;
            collection.Remove(s);
            ShowData();
            SetControlsState();
        }

    }
}
