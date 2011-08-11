using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Examinator.plugins {
    internal partial class QuestionForm : Form {

        private MultipleChoiceQuestion question;
        // Temporary question text stored in questionValue.Text
        // Temporary answers stored in answers
        // Temporary correct index stored in correctAnswer
        private AnswerList<String> answers;
        private int correctAnswer;

        public QuestionForm(MultipleChoiceQuestion question) {
            InitializeComponent();
            this.question = question;
            questionValue.Text = question.question;
            answers = new AnswerList<String>(question.answers);
            correctAnswer = question.correctAnswerIndex;
            Choices.DataSource = answers;
            if (correctAnswer >= 0) {
                Choices.SetItemChecked(correctAnswer, true);
            }
            Choices.ItemCheck += new ItemCheckEventHandler(Choices_ItemCheck);
        }

        #region EventHandlers

        // Ensures that only one answer can be checked at a time.
        private void Choices_ItemCheck(object sender, ItemCheckEventArgs e) {
            if (e.NewValue == CheckState.Checked) {
                IEnumerator iter = Choices.CheckedIndices.GetEnumerator();
                while (iter.MoveNext()) {
                    Choices.SetItemChecked((int)iter.Current, false);
                }
            }
            correctAnswer = e.Index;
        }

        private void Save_Click(object sender, EventArgs e) {
            if (questionValue.Text.Trim().Length == 0) {
                MessageBox.Show("Please provide a question.");
            }
            else if (answers.Count < 2) {
                MessageBox.Show("Please provide at least two answers.");
            }
            else if (correctAnswer < 0) {
                MessageBox.Show("Please select the correct answer.");
            }
            else {
                question.value = questionValue.Text;
                question.answers = answers;
                question.correctAnswerIndex = correctAnswer;
                this.Close();
            }
        }

        private void Cancel_Click(object sender, EventArgs e) {
            question.value = "";
            this.Close();
        }

        private void AddAnswer_Click(object sender, EventArgs e) {
            StringBuilder ans = new StringBuilder();
            AnswerForm a = new AnswerForm(ans);
            a.ShowDialog();
            if (ans.Length > 0) {
                answers.Add(ans.ToString());
            }
            if (correctAnswer >= 0) {
                Choices.SetItemChecked(correctAnswer, true);
            }
        }

        private void RemoveAnswer_Click(object sender, EventArgs e) {
            int ix = Choices.SelectedIndex;
            if (ix != -1) {
                answers.RemoveAt(ix);
                if (ix == correctAnswer) {
                    correctAnswer = -1;
                }
                else if (correctAnswer >= 0) {
                    if (ix < correctAnswer) {
                        correctAnswer--;
                    }
                    Choices.SetItemChecked(correctAnswer, true);
                }
            }
        }

        private void MoveUp_Click(object sender, EventArgs e) {
            int ix = Choices.SelectedIndex;
            if (answers.MoveUp(ix)) {
                if (correctAnswer >= 0) {
                    if (ix == correctAnswer) {
                        correctAnswer--;
                    }
                    else if (ix - 1 == correctAnswer) {
                        correctAnswer++;
                    }
                    Choices.SetItemChecked(correctAnswer, true);
                }
                ix--;
            }
            Choices.SelectedIndex = ix;
        }

        private void MoveDown_Click(object sender, EventArgs e) {
            if (answers.MoveDown(Choices.SelectedIndex)) {
                if (correctAnswer >= 0) {
                    if (Choices.SelectedIndex == correctAnswer) {
                        correctAnswer++;
                    }
                    else if (Choices.SelectedIndex + 1 == correctAnswer) {
                        correctAnswer--;
                    }
                    Choices.SetItemChecked(correctAnswer, true);
                }
                Choices.SelectedIndex++;
            }

        }

        private void Edit_Click(object sender, EventArgs e) {
            StringBuilder ans = new StringBuilder(Choices.SelectedItem.ToString());
            AnswerForm a = new AnswerForm(ans);
            a.ShowDialog();
            if (ans.Length > 0) {
                answers[Choices.SelectedIndex] = (ans.ToString());
            }
            /*if (correctAnswer >= 0) {
                Choices.SetItemChecked(correctAnswer, true);
            }*/
        }

        #endregion
    }
}
