using ObservingStudy.Events;
using ObservingStudy.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ObservingStudy {
    public partial class FManager : Form, IInfoWindow {

        public string Title { set => this.Text = value; }
        public string Header { set => labelHeader.Text = value; }

        public IView View { get; private set; }
        public IEditor Editor { get; private set; }
        public ISelector Selector { get; private set; }
        public IMessageLog MessageLog { get; private set; }

        private List<Form> forms = new List<Form>();

        public FManager(IView view, IEditor editor, 
            ISelector selector, IMessageLog messageLog) {
            //
            View = view;
            //View.UpdateInfo();
            Editor = editor;
            Selector = selector;
            Selector.CommandEditingSelected += buttonEditing_Click;
            Selector.Selected += Selector_Selected;
            MessageLog = messageLog;

            InitializeComponent();

            RegisterForms();
            SetFormsPosition();
        }

        private void Selector_Selected(object sender, StringEventArgs e) {
            AddMessage($"Вибрано елемент {e.Value}\n");
        }

        void AddMessage(string text) {
            MessageLog.Info(text);
        }

        private void SetFormsPosition() {
            if (forms.Count == 0) return;
            forms[0].Top = this.Top;
            forms[0].Left = this.Right;
            forms[0].Height = this.Height;

            if (forms.Count == 1) return;
            forms[1].Top = this.Top;
            forms[1].Left = forms[0].Right;
            forms[1].Height = this.Height;

            if (forms.Count == 2) return;
            forms[2].Top = this.Top;
            forms[2].Left = forms[1].Right;
            forms[2].Height = this.Height;

            if (forms.Count == 3) return;
            forms[3].Top = this.Bottom;
            forms[3].Left = this.Left;
            forms[3].Width = this.Width + 800;
        }

        private void RegisterForms() {
            RegisterForm(View as Form);
            RegisterForm(Editor as Form);
            RegisterForm(Selector as Form);
            RegisterForm(MessageLog as Form);
        }

        private void RegisterForm(Form form) {
            forms.Add(form);
            form.FormClosing += Form_FormClosing;
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = true;
            (sender as Form).Hide();
        }

        //public event EventHandler<EventArgs> CommandEditingSelected;
        //public event EventHandler<EventArgs> CommandSelectionSelected;

        private void buttonView_Click(object sender, EventArgs e) {
            (View as Form).Show();
        }

        private void buttonSelection_Click(object sender, EventArgs e) {
            (Selector as Form).Show();
        }

        private void buttonEditing_Click(object sender, EventArgs e) {
            (Editor as Form).Show();
        }

        private void FManaging_Resize(object sender, EventArgs e) {
            SetFormsPosition();
        }

        private void FManaging_FormClosed(object sender, FormClosedEventArgs e) {
            foreach(Form form in forms) {
                form.Close();
            }
        }

        private void buttonLog_Click(object sender, EventArgs e) {
            (MessageLog as Form).Show();
        }
    }
}
