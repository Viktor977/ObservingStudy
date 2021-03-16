
using Common.Collections.Types;
using System;

namespace Common.Collections.Events {
    public class EditedEventArgs : EventArgs {
        public readonly object Item;
        public readonly EditingAction Action;
        public readonly int? Index;

        public EditedEventArgs(EditingAction action, 
                object item, int? index = null) {
            Item = item;
            Action = action;
            Index = index;
        }
    }
}
