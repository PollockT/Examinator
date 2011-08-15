using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Examinator.plugins
{
    public partial class QuestionForm : Form
    {
        ShortAnswerQuestion question;

        public QuestionForm(ShortAnswerQuestion q)
        {
            InitializeComponent();
            question = q;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(question.value))
            {
                MessageBox.Show("Cannot have an empty question.");
            }
            else
            {
                question.keywords = Regex.Split(keywordTextBox.Text, @"\s*,\s*").ToList();
                DialogResult = DialogResult.OK;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            question.value = "";
            question.keywords.Clear();
            DialogResult = DialogResult.Cancel;
        }
    }
}
