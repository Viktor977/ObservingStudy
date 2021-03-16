using Common.Collections.Events;
using Common.Collections.Interfaces;
using ObservingStudy.Events;
using System;
using System.Linq;

namespace ObservingStudy.Selectors {
    //public partial class FListSelector : Form {
    public partial class FListSelector : FSelector {

        public FListSelector(IObservableCollection<string> collection) 
            : base(collection) {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
            OnStringSelected(new StringEventArgs(listBox1.SelectedItem.ToString()));
        }

        protected override void Collection_Edited(object sender, EditedEventArgs e) {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(collection.ToArray());
        }

    }
}
