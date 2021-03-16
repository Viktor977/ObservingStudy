using System;

namespace ObservingStudy.Events {
    public class StringEventArgs : EventArgs {

        public readonly string Value;

        public StringEventArgs(string value) {
            this.Value = value;
        }
    }
}
