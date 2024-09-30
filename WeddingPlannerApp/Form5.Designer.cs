namespace WeddingPlannerApp
{
    partial class Form5
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
            this.label5 = new System.Windows.Forms.Label();
            this.lblDateandTime = new System.Windows.Forms.Label();
            this.lblModeofConsultation = new System.Windows.Forms.Label();
            this.lblNotesforConsultation = new System.Windows.Forms.Label();
            this.comboBoxConsultationMode = new System.Windows.Forms.ComboBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.SeaShell;
            this.label5.Font = new System.Drawing.Font("Microsoft Uighur", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Tomato;
            this.label5.Location = new System.Drawing.Point(184, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(298, 57);
            this.label5.TabIndex = 5;
            this.label5.Text = "Book Consultation";
            // 
            // lblDateandTime
            // 
            this.lblDateandTime.AutoSize = true;
            this.lblDateandTime.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateandTime.Location = new System.Drawing.Point(9, 96);
            this.lblDateandTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateandTime.Name = "lblDateandTime";
            this.lblDateandTime.Size = new System.Drawing.Size(126, 31);
            this.lblDateandTime.TabIndex = 6;
            this.lblDateandTime.Text = "Preffered Date:";
            // 
            // lblModeofConsultation
            // 
            this.lblModeofConsultation.AutoSize = true;
            this.lblModeofConsultation.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModeofConsultation.Location = new System.Drawing.Point(3, 193);
            this.lblModeofConsultation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModeofConsultation.Name = "lblModeofConsultation";
            this.lblModeofConsultation.Size = new System.Drawing.Size(248, 31);
            this.lblModeofConsultation.TabIndex = 8;
            this.lblModeofConsultation.Text = "Preffered Mode of Consultation";
            this.lblModeofConsultation.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblNotesforConsultation
            // 
            this.lblNotesforConsultation.AutoSize = true;
            this.lblNotesforConsultation.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotesforConsultation.Location = new System.Drawing.Point(3, 244);
            this.lblNotesforConsultation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNotesforConsultation.Name = "lblNotesforConsultation";
            this.lblNotesforConsultation.Size = new System.Drawing.Size(224, 31);
            this.lblNotesforConsultation.TabIndex = 11;
            this.lblNotesforConsultation.Text = "Add Notes For Consultation:";
            this.lblNotesforConsultation.Click += new System.EventHandler(this.lblNotesforConsultation_Click);
            // 
            // comboBoxConsultationMode
            // 
            this.comboBoxConsultationMode.FormattingEnabled = true;
            this.comboBoxConsultationMode.Location = new System.Drawing.Point(292, 203);
            this.comboBoxConsultationMode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxConsultationMode.Name = "comboBoxConsultationMode";
            this.comboBoxConsultationMode.Size = new System.Drawing.Size(276, 21);
            this.comboBoxConsultationMode.TabIndex = 7;
            this.comboBoxConsultationMode.SelectedIndexChanged += new System.EventHandler(this.comboBoxConsultationMode_SelectedIndexChanged);
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(292, 255);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(276, 20);
            this.txtNotes.TabIndex = 12;
            this.txtNotes.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.SeaShell;
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.ForeColor = System.Drawing.Color.Tomato;
            this.submitButton.Location = new System.Drawing.Point(221, 306);
            this.submitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(128, 37);
            this.submitButton.TabIndex = 13;
            this.submitButton.Text = "SUBMIT";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SeaShell;
            this.button2.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Tomato;
            this.button2.Location = new System.Drawing.Point(511, 10);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 36);
            this.button2.TabIndex = 14;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.SeaShell;
            this.backButton.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.Tomato;
            this.backButton.Location = new System.Drawing.Point(9, 10);
            this.backButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(80, 36);
            this.backButton.TabIndex = 15;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(292, 99);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(276, 20);
            this.dtpDate.TabIndex = 16;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "Preffered Time:";
            // 
            // dtpTime
            // 
            this.dtpTime.Location = new System.Drawing.Point(292, 145);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(276, 20);
            this.dtpTime.TabIndex = 18;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(607, 370);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.lblNotesforConsultation);
            this.Controls.Add(this.lblModeofConsultation);
            this.Controls.Add(this.comboBoxConsultationMode);
            this.Controls.Add(this.lblDateandTime);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDateandTime;
        private System.Windows.Forms.Label lblModeofConsultation;
        private System.Windows.Forms.Label lblNotesforConsultation;
        private System.Windows.Forms.ComboBox comboBoxConsultationMode;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTime;
    }
}