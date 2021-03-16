using System;

namespace ObservingStudy.Interfaces {
    public interface IEditingInitiator {
        event EventHandler<EventArgs> CommandEditingSelected;
    }
}
