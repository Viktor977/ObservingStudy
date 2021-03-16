using Common.Collections.Events;
using Common.Collections.Interfaces;
using Common.Collections.Types;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Common.Collections {
    public class CollectionObservableWrapper<T> : IObservableCollection<T> {

        protected readonly ICollection<T> collection;

        public CollectionObservableWrapper(ICollection<T> collection) {
            this.collection = collection;
        }

        public int Count => collection.Count;

        public bool IsReadOnly => collection.IsReadOnly;

        public void Add(T item) {
            collection.Add(item);
            OnEdited(new EditedEventArgs(EditingAction.Add, item));
        }

        public void Clear() {
            collection.Clear();
            OnEdited(new EditedEventArgs(EditingAction.Reset, default(T)));
        }

        public bool Contains(T item) {
            return collection.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex) {
            collection.CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator() {
            return collection.GetEnumerator();
        }

        public bool Remove(T item) {
            bool result = collection.Remove(item);
            OnEdited(new EditedEventArgs(EditingAction.Remove, item));
            return result;
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return ((IEnumerable)collection).GetEnumerator();
        }

        public event EventHandler<EditedEventArgs> Edited;

        protected virtual void OnEdited(EditedEventArgs eventArgs) {
            Edited?.Invoke(this, eventArgs);
        }
    }
}
