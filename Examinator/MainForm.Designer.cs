namespace Examinator {
    partial class MainForm {
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
            this.QuestionList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddQuestion = new System.Windows.Forms.Button();
            this.RemoveQuestion = new System.Windows.Forms.Button();
            this.generateExam = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.New = new System.Windows.Forms.ToolStripButton();
            this.Open = new System.Windows.Forms.ToolStripButton();
            this.SaveExam = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // QuestionList
            // 
            this.QuestionList.FormattingEnabled = true;
            this.QuestionList.Location = new System.Drawing.Point(13, 52);
            this.QuestionList.Name = "QuestionList";
            this.QuestionList.Size = new System.Drawing.Size(186, 199);
            this.QuestionList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Questions:";
            // 
            // AddQuestion
            // 
            this.AddQuestion.Location = new System.Drawing.Point(205, 52);
            this.AddQuestion.Name = "AddQuestion";
            this.AddQuestion.Size = new System.Drawing.Size(75, 23);
            this.AddQuestion.TabIndex = 1;
            this.AddQuestion.Text = "Add";
            this.AddQuestion.UseVisualStyleBackColor = true;
            this.AddQuestion.Click += new System.EventHandler(this.AddQuestion_Click);
            // 
            // RemoveQuestion
            // 
            this.RemoveQuestion.Location = new System.Drawing.Point(205, 111);
            this.RemoveQuestion.Name = "RemoveQuestion";
            this.RemoveQuestion.Size = new System.Drawing.Size(75, 23);
            this.RemoveQuestion.TabIndex = 2;
            this.RemoveQuestion.Text = "Remove";
            this.RemoveQuestion.UseVisualStyleBackColor = true;
            this.RemoveQuestion.Click += new System.EventHandler(this.RemoveQuestion_Click);
            // 
            // generateExam
            // 
            this.generateExam.Location = new System.Drawing.Point(205, 238);
            this.generateExam.Name = "generateExam";
            this.generateExam.Size = new System.Drawing.Size(75, 23);
            this.generateExam.TabIndex = 4;
            this.generateExam.Text = "Generate";
            this.generateExam.UseVisualStyleBackColor = true;
            this.generateExam.Click += new System.EventHandler(this.generateData_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(205, 82);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 5;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.New,
            this.Open,
            this.SaveExam});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(292, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // New
            // 
            this.New.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.New.Image = global::Examinator.Properties.Resources.NewDocumentHS;
            this.New.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(23, 22);
            this.New.Text = "New";
            this.New.ToolTipText = "Create New File";
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // Open
            // 
            this.Open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Open.Image = global::Examinator.Properties.Resources.openfolderHS;
            this.Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(23, 22);
            this.Open.Text = "Open";
            this.Open.ToolTipText = "Open Existing File";
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // SaveExam
            // 
            this.SaveExam.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveExam.Image = global::Examinator.Properties.Resources.saveHS;
            this.SaveExam.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveExam.Name = "SaveExam";
            this.SaveExam.Size = new System.Drawing.Size(23, 22);
            this.SaveExam.Text = "Save";
            this.SaveExam.ToolTipText = "Save File";
            this.SaveExam.Click += new System.EventHandler(this.Save_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.generateExam);
            this.Controls.Add(this.RemoveQuestion);
            this.Controls.Add(this.AddQuestion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QuestionList);
            this.Name = "MainForm";
            this.Text = "Examinator";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox QuestionList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddQuestion;
        private System.Windows.Forms.Button RemoveQuestion;
        private System.Windows.Forms.Button generateExam;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton New;
        private System.Windows.Forms.ToolStripButton Open;
        private System.Windows.Forms.ToolStripButton SaveExam;
    }
}

