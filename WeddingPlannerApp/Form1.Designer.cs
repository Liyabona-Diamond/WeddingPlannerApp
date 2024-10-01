namespace WeddingPlannerApp
{
    partial class Form1
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
            this.lblAppsname = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AboutUsButoon = new System.Windows.Forms.Button();
            this.servicebutton = new System.Windows.Forms.Button();
            this.profileButton = new System.Windows.Forms.Button();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAppsname
            // 
            this.lblAppsname.AutoSize = true;
            this.lblAppsname.Font = new System.Drawing.Font("Vladimir Script", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppsname.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblAppsname.Location = new System.Drawing.Point(48, 72);
            this.lblAppsname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAppsname.Name = "lblAppsname";
            this.lblAppsname.Size = new System.Drawing.Size(483, 58);
            this.lblAppsname.TabIndex = 0;
            this.lblAppsname.Text = "A Journey To The Aisle ";
            this.lblAppsname.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AboutUsButoon);
            this.panel1.Controls.Add(this.servicebutton);
            this.panel1.Controls.Add(this.profileButton);
            this.panel1.Location = new System.Drawing.Point(58, 276);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 49);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // AboutUsButoon
            // 
            this.AboutUsButoon.BackColor = System.Drawing.Color.BurlyWood;
            this.AboutUsButoon.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutUsButoon.ForeColor = System.Drawing.Color.Ivory;
            this.AboutUsButoon.Location = new System.Drawing.Point(373, 0);
            this.AboutUsButoon.Margin = new System.Windows.Forms.Padding(2);
            this.AboutUsButoon.Name = "AboutUsButoon";
            this.AboutUsButoon.Size = new System.Drawing.Size(100, 48);
            this.AboutUsButoon.TabIndex = 2;
            this.AboutUsButoon.Text = "About Us";
            this.AboutUsButoon.UseVisualStyleBackColor = false;
            this.AboutUsButoon.Click += new System.EventHandler(this.AboutUsButoon_Click);
            // 
            // servicebutton
            // 
            this.servicebutton.BackColor = System.Drawing.Color.BurlyWood;
            this.servicebutton.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicebutton.ForeColor = System.Drawing.Color.Ivory;
            this.servicebutton.Location = new System.Drawing.Point(190, 0);
            this.servicebutton.Margin = new System.Windows.Forms.Padding(2);
            this.servicebutton.Name = "servicebutton";
            this.servicebutton.Size = new System.Drawing.Size(100, 49);
            this.servicebutton.TabIndex = 1;
            this.servicebutton.Text = "Services";
            this.servicebutton.UseVisualStyleBackColor = false;
            this.servicebutton.Click += new System.EventHandler(this.servicebutton_Click);
            // 
            // profileButton
            // 
            this.profileButton.BackColor = System.Drawing.Color.BurlyWood;
            this.profileButton.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileButton.ForeColor = System.Drawing.Color.Ivory;
            this.profileButton.Location = new System.Drawing.Point(0, 0);
            this.profileButton.Margin = new System.Windows.Forms.Padding(2);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(100, 48);
            this.profileButton.TabIndex = 0;
            this.profileButton.Text = "Profile";
            this.profileButton.UseVisualStyleBackColor = false;
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.Location = new System.Drawing.Point(150, 131);
            this.lblLogo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(298, 27);
            this.lblLogo.TabIndex = 3;
            this.lblLogo.Text = "\"Simplify your dream day\"";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WeddingPlannerApp.Properties.Resources.silhouette_3754208_1920;
            this.pictureBox2.Location = new System.Drawing.Point(202, 172);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(165, 99);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WeddingPlannerApp.Properties.Resources.alphabet_word_images_1295152_1920;
            this.pictureBox1.Location = new System.Drawing.Point(9, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(955, 346);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.SeaShell;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.Tomato;
            this.backButton.Location = new System.Drawing.Point(533, 0);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(56, 28);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "X";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblAppsname);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAppsname;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AboutUsButoon;
        private System.Windows.Forms.Button servicebutton;
        private System.Windows.Forms.Button profileButton;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button backButton;
    }
}

