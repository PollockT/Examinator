using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;
using Examinator;

namespace Examinator.plugins {

    [QuestionType("ShortAnswer")]
    public class Question : IQuestion {
        public event PropertyChangedEventHandler PropertyChanged;
        string _question;
        List<string> keywords;

        Question() : this(""){
        }

        Question(string xml) {
            _question = "";
            keywords = new List<string>();
            if (!String.IsNullOrEmpty(xml)) {
                fromXML(xml);
            }
        }

        public string question {
            get { return this.value; }
        }

        private Form _questionForm;
        public Form questionForm {
            get { return this._questionForm; }
        }

        private String _value;
        internal String value {
            get {
                return _value;
            }
            set {
                _value = value;
                if (PropertyChanged != null) {
                    PropertyChanged(this, new PropertyChangedEventArgs("_value"));
                }
            }
        }

        public bool isValidQuestion() {
            return value.Trim().Length > 0;
        }

        private bool fromXML(string xml) {
            return false;
        }

        public string toXML() {
            StringBuilder sb = new StringBuilder();
            //sb.AppendFormat(@"<Question type=""{0}"">\n", name);
            sb.AppendFormat("\t<Text>{0}</Text>\n", value);
            sb.AppendLine("\t<Keywords>");
            foreach(string keyword in keywords){
                sb.AppendFormat("\t\t<Keyword>{0}</Keyword>\n", keyword);
            }
            sb.AppendLine("\t</Keywords>");
            sb.Append("</Question>");
            return sb.ToString();
        }

        public string toLatex() {
            throw new NotImplementedException("Latex creation not available yet.");
        }

        public override String ToString() {
            return value;
        }
    }
}
