using Common.Collections.Events;
using Common.Collections.Interfaces;
using Common.Collections.Types;
using ObservingStudy.Events;
using ObservingStudy.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ObservingStudy.Selectors {
    public partial class FSelector : Form, IInfoWindow, 
        ISelector, IEditingInitiator {

        public string Title { set => this.Text = value; }
        public string Header { set => labelHeader.Text = value; }

        protected readonly IObservableCollection<string> collection;

        // необхідний для роботи дизайнера похідних класів форм
        internal FSelector() { InitializeComponent(); }

        public FSelector(IObservableCollection<string> collection) {
            this.collection = collection ?? throw new ArgumentNullException();
            InitializeComponent();
            collection.Edited += Collection_Edited;
        }


        // virtual необхідний для роботи дизайнера базового класу форми
        // (на основі абстрактного класу не можна створити об'єкт)
        protected virtual void Collection_Edited(object sender, EditedEventArgs e) {
            // щоб не забути перевизначити у похідних класах
            throw new NotImplementedException();
        }

        public event EventHandler<StringEventArgs> Selected;

        protected virtual void OnStringSelected(StringEventArgs e) {
            Selected?.Invoke(this, e);
        }

        public event EventHandler<EventArgs> CommandEditingSelected;


        public virtual void SetData(IEnumerable<string> strings) {
            throw new NotImplementedException();
        }

        private void buttonEditing_Click(object sender, EventArgs e) {
            CommandEditingSelected?.Invoke(this, new EventArgs());
        }

        private void FSelector_Load(object sender, EventArgs e) {
            if(this.GetType() != typeof(FSelector)) {
                Collection_Edited(sender, new EditedEventArgs(EditingAction.None, null));
            }
        }
    }
}
