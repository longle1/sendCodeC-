namespace Lab2_21520186
{
    partial class Dashboard
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
            this.LabName = new System.Windows.Forms.Label();
            this.Question6 = new System.Windows.Forms.Button();
            this.Question4 = new System.Windows.Forms.Button();
            this.Question5 = new System.Windows.Forms.Button();
            this.Question3 = new System.Windows.Forms.Button();
            this.Question1 = new System.Windows.Forms.Button();
            this.Question2 = new System.Windows.Forms.Button();
            this.LogoPic = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).BeginInit();
            this.SuspendLayout();
            // 
            // LabName
            // 
            this.LabName.AutoSize = true;
            this.LabName.Font = new System.Drawing.Font("Lucida Handwriting", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabName.Location = new System.Drawing.Point(170, 127);
            this.LabName.Name = "LabName";
            this.LabName.Size = new System.Drawing.Size(548, 36);
            this.LabName.TabIndex = 17;
            this.LabName.Text = "Lab2: FIle and Stream I/O in C#";
            this.LabName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Question6
            // 
            this.Question6.BackColor = System.Drawing.Color.LavenderBlush;
            this.Question6.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question6.ForeColor = System.Drawing.Color.Crimson;
            this.Question6.Location = new System.Drawing.Point(540, 299);
            this.Question6.Name = "Question6";
            this.Question6.Size = new System.Drawing.Size(148, 53);
            this.Question6.TabIndex = 16;
            this.Question6.Text = "Question 6";
            this.Question6.UseVisualStyleBackColor = false;
            this.Question6.Click += new System.EventHandler(this.Question6_Click);
            // 
            // Question4
            // 
            this.Question4.BackColor = System.Drawing.Color.LavenderBlush;
            this.Question4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question4.ForeColor = System.Drawing.Color.Crimson;
            this.Question4.Location = new System.Drawing.Point(182, 299);
            this.Question4.Name = "Question4";
            this.Question4.Size = new System.Drawing.Size(148, 53);
            this.Question4.TabIndex = 15;
            this.Question4.Text = "Question 4";
            this.Question4.UseVisualStyleBackColor = false;
            this.Question4.Click += new System.EventHandler(this.Question4_Click);
            // 
            // Question5
            // 
            this.Question5.BackColor = System.Drawing.Color.LavenderBlush;
            this.Question5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question5.ForeColor = System.Drawing.Color.Crimson;
            this.Question5.Location = new System.Drawing.Point(364, 299);
            this.Question5.Name = "Question5";
            this.Question5.Size = new System.Drawing.Size(148, 53);
            this.Question5.TabIndex = 14;
            this.Question5.Text = "Question 5";
            this.Question5.UseVisualStyleBackColor = false;
            this.Question5.Click += new System.EventHandler(this.Question5_Click);
            // 
            // Question3
            // 
            this.Question3.BackColor = System.Drawing.Color.LavenderBlush;
            this.Question3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question3.ForeColor = System.Drawing.Color.Crimson;
            this.Question3.Location = new System.Drawing.Point(540, 214);
            this.Question3.Name = "Question3";
            this.Question3.Size = new System.Drawing.Size(148, 53);
            this.Question3.TabIndex = 13;
            this.Question3.Text = "Question 3";
            this.Question3.UseVisualStyleBackColor = false;
            this.Question3.Click += new System.EventHandler(this.Question3_Click);
            // 
            // Question1
            // 
            this.Question1.BackColor = System.Drawing.Color.LavenderBlush;
            this.Question1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question1.ForeColor = System.Drawing.Color.Crimson;
            this.Question1.Location = new System.Drawing.Point(182, 214);
            this.Question1.Name = "Question1";
            this.Question1.Size = new System.Drawing.Size(148, 53);
            this.Question1.TabIndex = 12;
            this.Question1.Text = "Question 1";
            this.Question1.UseVisualStyleBackColor = false;
            this.Question1.Click += new System.EventHandler(this.Question1_Click);
            // 
            // Question2
            // 
            this.Question2.BackColor = System.Drawing.Color.LavenderBlush;
            this.Question2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question2.ForeColor = System.Drawing.Color.Crimson;
            this.Question2.Location = new System.Drawing.Point(364, 214);
            this.Question2.Name = "Question2";
            this.Question2.Size = new System.Drawing.Size(148, 53);
            this.Question2.TabIndex = 11;
            this.Question2.Text = "Question 2";
            this.Question2.UseVisualStyleBackColor = false;
            this.Question2.Click += new System.EventHandler(this.Question2_Click);
            // 
            // LogoPic
            // 
            this.LogoPic.Image = global::Lab2_21520186.Properties.Resources.logoncuit_2;
            this.LogoPic.Location = new System.Drawing.Point(43, 9);
            this.LogoPic.Name = "LogoPic";
            this.LogoPic.Size = new System.Drawing.Size(141, 53);
            this.LogoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPic.TabIndex = 10;
            this.LogoPic.TabStop = false;
            // 
            // Logo
            // 
            this.Logo.AutoSize = true;
            this.Logo.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logo.Location = new System.Drawing.Point(177, 10);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(581, 52);
            this.Logo.TabIndex = 9;
            this.Logo.Text = "UNIVERSITY OF INFORMATION TECHNOLOGY, VNU-HCM\r\nFaculty of Computer Networks and C" +
    "ommunications";
            this.Logo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabName);
            this.Controls.Add(this.Question6);
            this.Controls.Add(this.Question4);
            this.Controls.Add(this.Question5);
            this.Controls.Add(this.Question3);
            this.Controls.Add(this.Question1);
            this.Controls.Add(this.Question2);
            this.Controls.Add(this.LogoPic);
            this.Controls.Add(this.Logo);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabName;
        private System.Windows.Forms.Button Question6;
        private System.Windows.Forms.Button Question4;
        private System.Windows.Forms.Button Question5;
        private System.Windows.Forms.Button Question3;
        private System.Windows.Forms.Button Question1;
        private System.Windows.Forms.Button Question2;
        private System.Windows.Forms.PictureBox LogoPic;
        private System.Windows.Forms.Label Logo;
    }
}