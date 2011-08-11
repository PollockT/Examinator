using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Examinator {
    public partial class AnswerForm : Form {

        StringBuilder text;

        public AnswerForm(StringBuilder text) {
            InitializeComponent();
            this.text = text;
            SetupTemplate();
        }

        private void SetupTemplate() {
            Template.Items.Add("All of the above.");
            Template.Items.Add("None of the above.");
        }

        private void Template_SelectedIndexChanged(object sender, EventArgs e) {
            AnswerBox.Text = ((ComboBox)sender).SelectedItem.ToString();
        }

        private void Cancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Save_Click(object sender, EventArgs e) {
            if (AnswerBox.Text.Trim().Length == 0) {
                MessageBox.Show("Please provide an answer.");
            }
            else {
                text.Clear();
                text.Append(AnswerBox.Text);
                this.Close();
            }
        }
    }
}
