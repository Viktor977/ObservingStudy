using Common.Collections;
using Common.Collections.Events;
using Common.Collections.Interfaces;
using Common.Collections.Types;
using System;
using System.Collections.Generic;

namespace ObservingStudy.Controllers {
    public class EditingController {

        //private readonly ICollection<string> collection;

        private readonly CollectionObservableWrapper<string>
            observableCollection;// = new ObservableCollection<string>();

        public IObservableCollection<string> ObservableCollection {
            get => observableCollection;
        }

        public EditingController(ICollection<string> collection) {
            //
            observableCollection = new CollectionObservableWrapper<string>(collection);
            //this.collection = collection;
            observableCollection = new CollectionObservableWrapper<string>(collection);
            observableCollection.Edited += ObservableCollection_Edited;
        }

        private void ObservableCollection_Edited(object sender, EditedEventArgs e) {
            //switch (e.Action) {
            //    case EditingAction.Add:
            //        collection.Add(e.Item.ToString());
            //        break;
            //    case EditingAction.Remove:
            //        collection.Remove(e.Item.ToString());
            //        break;
            //    default:
            //        //??
            //        break;
            //}
            OnChanged();
        }

        //public event EventHandler Changed;
        public Action Changed;

        protected void OnChanged() {
            //Changed?.Invoke(this, EventArgs.Empty);
            Changed?.Invoke();
        }
    }
}
