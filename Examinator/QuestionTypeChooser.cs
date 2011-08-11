using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Examinator {
    public partial class QuestionTypeChooser : Form {
        Dictionary<string, Type> questionTypes;
        public Type choice;

        public QuestionTypeChooser(Dictionary<string, Type> questionTypes) {
            InitializeComponent();
            this.questionTypes = questionTypes;
            choice = null;
            questionType.DataSource = questionTypes.Keys.ToList();
        }

        private void questionType_SelectedIndexChanged(object sender, EventArgs e) {
            questionTypes.TryGetValue(Convert.ToString(questionType.SelectedItem), out choice);
        }

        private void okButton_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }
    }
}
