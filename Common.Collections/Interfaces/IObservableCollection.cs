using System.Collections.Generic;

namespace Common.Collections.Interfaces {
    public interface IObservableCollection<T> : ICollection<T>, IObservable {
    }
}
