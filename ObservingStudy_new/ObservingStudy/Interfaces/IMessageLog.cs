using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservingStudy.Interfaces {
    public interface IMessageLog {
        void Info(string message);
        void Debug(string message);
    }
}
