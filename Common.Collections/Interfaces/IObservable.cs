using Common.Collections.Events;
using System;

namespace Common.Collections.Interfaces {
    public interface IObservable {
        event EventHandler<EditedEventArgs> Edited;
    }
}
