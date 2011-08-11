using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Examinator {

    [AttributeUsage(AttributeTargets.Class)]
    public class QuestionTypeAttribute : Attribute {
        public QuestionTypeAttribute(string type) {
            _type = type;  
        }

        private string _type;
        public string type {
            get { return _type; }
        }
    }

    public interface IQuestion : System.ComponentModel.INotifyPropertyChanged {
        string question { get; }
        Form questionForm { get; }
        bool isValidQuestion();
        string toXML();
        string toLatex();
    }
}
