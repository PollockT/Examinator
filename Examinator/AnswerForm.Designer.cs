namespace Examinator {
    partial class AnswerForm {
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
            this.AnswerGroup = new System.Windows.Forms.GroupBox();
            this.AnswerBox = new System.Windows.Forms.TextBox();
            this.Template = new System.Windows.Forms.ComboBox();
            this.TemplateLabel = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.AnswerGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // AnswerGroup
            // 
            this.AnswerGroup.Controls.Add(this.AnswerBox);
            this.AnswerGroup.Location = new System.Drawing.Point(13, 13);
            this.AnswerGroup.Name = "AnswerGroup";
            this.AnswerGroup.Size = new System.Drawing.Size(200, 100);
            this.AnswerGroup.TabIndex = 0;
            this.AnswerGroup.TabStop = false;
            this.AnswerGroup.Text = "Answer";
            // 
            // AnswerBox
            // 
            this.AnswerBox.Location = new System.Drawing.Point(7, 20);
            this.AnswerBox.Multiline = true;
            this.AnswerBox.Name = "AnswerBox";
            this.AnswerBox.Size = new System.Drawing.Size(187, 74);
            this.AnswerBox.TabIndex = 0;
            // 
            // Template
            // 
            this.Template.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Template.FormattingEnabled = true;
            this.Template.Location = new System.Drawing.Point(20, 132);
            this.Template.Name = "Template";
            this.Template.Size = new System.Drawing.Size(187, 21);
            this.Template.TabIndex = 1;
            this.Template.SelectedIndexChanged += new System.EventHandler(this.Template_SelectedIndexChanged);
            // 
            // TemplateLabel
            // 
            this.TemplateLabel.AutoSize = true;
            this.TemplateLabel.Location = new System.Drawing.Point(13, 114);
            this.TemplateLabel.Name = "TemplateLabel";
            this.TemplateLabel.Size = new System.Drawing.Size(51, 13);
            this.TemplateLabel.TabIndex = 2;
            this.TemplateLabel.Text = "Template";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(138, 159);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 3;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(57, 159);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // AnswerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 191);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.TemplateLabel);
            this.Controls.Add(this.Template);
            this.Controls.Add(this.AnswerGroup);
            this.Name = "AnswerForm";
            this.Text = "Edit Answer";
            this.AnswerGroup.ResumeLayout(false);
            this.AnswerGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox AnswerGroup;
        private System.Windows.Forms.TextBox AnswerBox;
        private System.Windows.Forms.ComboBox Template;
        private System.Windows.Forms.Label TemplateLabel;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Cancel;

    }
}