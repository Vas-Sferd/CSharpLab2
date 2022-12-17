namespace CSharpLaba2
{
    partial class EditGradeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label MarkLabel;
            System.Windows.Forms.Label SubjectLabel;
            System.Windows.Forms.Label DateLabel;
            this.MarkComboBox = new System.Windows.Forms.ComboBox();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.SubjectComboBox = new System.Windows.Forms.ComboBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            MarkLabel = new System.Windows.Forms.Label();
            SubjectLabel = new System.Windows.Forms.Label();
            DateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MarkLabel
            // 
            MarkLabel.AutoSize = true;
            MarkLabel.Location = new System.Drawing.Point(39, 50);
            MarkLabel.Name = "MarkLabel";
            MarkLabel.Size = new System.Drawing.Size(45, 13);
            MarkLabel.TabIndex = 0;
            MarkLabel.Text = "Оценка";
            // 
            // SubjectLabel
            // 
            SubjectLabel.AutoSize = true;
            SubjectLabel.Location = new System.Drawing.Point(39, 90);
            SubjectLabel.Name = "SubjectLabel";
            SubjectLabel.Size = new System.Drawing.Size(70, 13);
            SubjectLabel.TabIndex = 1;
            SubjectLabel.Text = "Дисциплина";
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Location = new System.Drawing.Point(39, 134);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new System.Drawing.Size(33, 13);
            DateLabel.TabIndex = 2;
            DateLabel.Text = "Дата";
            // 
            // MarkComboBox
            // 
            this.MarkComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MarkComboBox.FormattingEnabled = true;
            this.MarkComboBox.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5"});
            this.MarkComboBox.Location = new System.Drawing.Point(169, 47);
            this.MarkComboBox.Name = "MarkComboBox";
            this.MarkComboBox.Size = new System.Drawing.Size(71, 21);
            this.MarkComboBox.TabIndex = 4;
            // 
            // TimePicker
            // 
            this.TimePicker.Location = new System.Drawing.Point(169, 134);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.Size = new System.Drawing.Size(200, 20);
            this.TimePicker.TabIndex = 5;
            // 
            // SubjectComboBox
            // 
            this.SubjectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubjectComboBox.FormattingEnabled = true;
            this.SubjectComboBox.Items.AddRange(new object[] {
            "Алгебра",
            "Биология",
            "География",
            "Геометрия",
            "Химия",
            "Русский язык",
            "Физика",
            "Физическая культура"});
            this.SubjectComboBox.Location = new System.Drawing.Point(169, 87);
            this.SubjectComboBox.Name = "SubjectComboBox";
            this.SubjectComboBox.Size = new System.Drawing.Size(200, 21);
            this.SubjectComboBox.TabIndex = 6;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(277, 201);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 7;
            this.OkButton.Text = "Ок";
            this.OkButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(358, 201);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // EditGradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 236);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.SubjectComboBox);
            this.Controls.Add(this.TimePicker);
            this.Controls.Add(this.MarkComboBox);
            this.Controls.Add(DateLabel);
            this.Controls.Add(SubjectLabel);
            this.Controls.Add(MarkLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditGradeForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AddGradeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox MarkComboBox;
        private System.Windows.Forms.DateTimePicker TimePicker;
        private System.Windows.Forms.ComboBox SubjectComboBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
    }
}