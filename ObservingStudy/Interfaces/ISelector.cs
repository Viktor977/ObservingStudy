using ObservingStudy.Events;
using System;

namespace ObservingStudy.Interfaces {
    public interface ISelector {
        event EventHandler<StringEventArgs> Selected;
        event EventHandler<EventArgs> CommandEditingSelected;
        //void SetData(IEnumerable<string> strings);
    }
}
