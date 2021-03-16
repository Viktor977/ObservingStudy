using Common.Collections.Events;
using Common.Collections.Interfaces;
using ObservingStudy.Events;
using System.Linq;
using System.Windows.Forms;

namespace ObservingStudy.Selectors {
    public partial class FRadioSelector : FSelector {

        public FRadioSelector(IObservableCollection<string> collection)
            : base(collection) { 
            InitializeComponent();
            //this.StartPosition = FormStartPosition.Manual;
        }

        int m_left = 10;
        int m_top = 5;
        int m_space = 0;

        protected override void Collection_Edited(object sender, EditedEventArgs e) {
            string[] dataStringsArray = collection.ToArray();
            panelSelection.Controls.Clear();
            for (int i = 0; i < dataStringsArray.Length; i++) {
                RadioButton radioButton = new RadioButton();
                panelSelection.Controls.Add(radioButton);
                radioButton.Left = m_left;
                radioButton.Top = m_top + (m_space + radioButton.Height) * i;
                radioButton.Text = dataStringsArray[i];
                radioButton.Click += RadioButton_Click;
            }
        }

        private void RadioButton_Click(object sender, System.EventArgs e) {
            OnStringSelected(new StringEventArgs(((Control)sender).Text));
        }
    }
}
