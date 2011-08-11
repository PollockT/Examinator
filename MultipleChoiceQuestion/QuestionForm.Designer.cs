namespace Examinator.plugins {
    partial class QuestionForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.AddAnswer = new System.Windows.Forms.Button();
            this.RemoveAnswer = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Choices = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.questionValue = new System.Windows.Forms.TextBox();
            this.MoveDown = new System.Windows.Forms.Button();
            this.MoveUp = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddAnswer
            // 
            this.AddAnswer.Location = new System.Drawing.Point(205, 103);
            this.AddAnswer.Name = "AddAnswer";
            this.AddAnswer.Size = new System.Drawing.Size(75, 23);
            this.AddAnswer.TabIndex = 2;
            this.AddAnswer.Text = "Add";
            this.AddAnswer.UseVisualStyleBackColor = true;
            this.AddAnswer.Click += new System.EventHandler(this.AddAnswer_Click);
            // 
            // RemoveAnswer
            // 
            this.RemoveAnswer.Location = new System.Drawing.Point(206, 162);
            this.RemoveAnswer.Name = "RemoveAnswer";
            this.RemoveAnswer.Size = new System.Drawing.Size(75, 23);
            this.RemoveAnswer.TabIndex = 3;
            this.RemoveAnswer.Text = "Remove";
            this.RemoveAnswer.UseVisualStyleBackColor = true;
            this.RemoveAnswer.Click += new System.EventHandler(this.RemoveAnswer_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(124, 320);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 6;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(205, 320);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 7;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Choices
            // 
            this.Choices.FormattingEnabled = true;
            this.Choices.Location = new System.Drawing.Point(12, 103);
            this.Choices.Name = "Choices";
            this.Choices.Size = new System.Drawing.Size(187, 199);
            this.Choices.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Answer Choices";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Question:";
            // 
            // questionValue
            // 
            this.questionValue.Location = new System.Drawing.Point(16, 30);
            this.questionValue.Multiline = true;
            this.questionValue.Name = "questionValue";
            this.questionValue.Size = new System.Drawing.Size(264, 51);
            this.questionValue.TabIndex = 0;
            // 
            // MoveDown
            // 
            this.MoveDown.Location = new System.Drawing.Point(206, 222);
            this.MoveDown.Name = "MoveDown";
            this.MoveDown.Size = new System.Drawing.Size(75, 23);
            this.MoveDown.TabIndex = 5;
            this.MoveDown.Text = "Move Down";
            this.MoveDown.UseVisualStyleBackColor = true;
            this.MoveDown.Click += new System.EventHandler(this.MoveDown_Click);
            // 
            // MoveUp
            // 
            this.MoveUp.Location = new System.Drawing.Point(206, 192);
            this.MoveUp.Name = "MoveUp";
            this.MoveUp.Size = new System.Drawing.Size(75, 23);
            this.MoveUp.TabIndex = 4;
            this.MoveUp.Text = "Move Up";
            this.MoveUp.UseVisualStyleBackColor = true;
            this.MoveUp.Click += new System.EventHandler(this.MoveUp_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(206, 133);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(75, 23);
            this.Edit.TabIndex = 10;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 355);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.questionValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Choices);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.MoveDown);
            this.Controls.Add(this.MoveUp);
            this.Controls.Add(this.RemoveAnswer);
            this.Controls.Add(this.AddAnswer);
            this.Name = "QuestionForm";
            this.Text = "Edit Question";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddAnswer;
        private System.Windows.Forms.Button RemoveAnswer;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.CheckedListBox Choices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox questionValue;
        private System.Windows.Forms.Button MoveDown;
        private System.Windows.Forms.Button MoveUp;
        private System.Windows.Forms.Button Edit;

    }
}