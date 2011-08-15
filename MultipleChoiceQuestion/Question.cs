using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;

namespace Examinator.plugins {

    [QuestionType("MultipleChoice")]
    public class MultipleChoiceQuestion : IQuestion {
        public event PropertyChangedEventHandler PropertyChanged;

        public MultipleChoiceQuestion()
            : this("") {
        }

        public MultipleChoiceQuestion(String xml) {
            value = "";
            answers = new AnswerList<string>();
            correctAnswerIndex = -1;
            _questionForm = new QuestionForm(this);

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

        internal AnswerList<String> answers;
        private int _correctAnswerIndex;
        internal int correctAnswerIndex {
            get {
                return _correctAnswerIndex;
            }
            set {
                _correctAnswerIndex = value;
                if (PropertyChanged != null) {
                    PropertyChanged(this, new PropertyChangedEventArgs("_correctAnswerIndex"));
                }
            }
        }

        public bool isValidQuestion() {
            return answers.Count >= 2 &&
                correctAnswerIndex >= 0 &&
                correctAnswerIndex < answers.Count &&
                value.Trim().Length > 0;
        }

        private void fromXML(string xml) {
            throw new NotImplementedException("cannot yet parse XML");
        }

        public string toXML() {
            StringBuilder sb = new StringBuilder();
            QuestionTypeAttribute name = (QuestionTypeAttribute)this.GetType().GetCustomAttributes(
                                                                typeof(QuestionTypeAttribute), false).First();
            sb.AppendFormat(@"<Question type=""{0}"" correct=""{1}"">\n", name.type, correctAnswerIndex);
            sb.AppendFormat("\t<Text>{0}</Text>\n", value);
            for (int x = 0; x < answers.Count; x++) {
                sb.AppendFormat("\t<Answer id=\"{0}\">{1}</Answer>\n", x, answers[x]);
            }
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
