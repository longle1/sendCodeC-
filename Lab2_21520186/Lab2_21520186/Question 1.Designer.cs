namespace Lab2_21520186
{
    partial class Question1
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
            this.label1 = new System.Windows.Forms.Label();
            this.Read = new System.Windows.Forms.Button();
            this.Write = new System.Windows.Forms.Button();
            this.Content = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(581, 52);
            this.label1.TabIndex = 19;
            this.label1.Text = "UNIVERSITY OF INFORMATION TECHNOLOGY, VNU-HCM\r\nFaculty of Computer Networks and C" +
    "ommunications";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Read
            // 
            this.Read.BackColor = System.Drawing.Color.LavenderBlush;
            this.Read.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Read.ForeColor = System.Drawing.Color.Crimson;
            this.Read.Location = new System.Drawing.Point(141, 154);
            this.Read.Name = "Read";
            this.Read.Size = new System.Drawing.Size(148, 53);
            this.Read.TabIndex = 21;
            this.Read.Text = "READ FROM";
            this.Read.UseVisualStyleBackColor = false;
            this.Read.Click += new System.EventHandler(this.Read_Click);
            // 
            // Write
            // 
            this.Write.BackColor = System.Drawing.Color.LavenderBlush;
            this.Write.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Write.ForeColor = System.Drawing.Color.Crimson;
            this.Write.Location = new System.Drawing.Point(141, 305);
            this.Write.Name = "Write";
            this.Write.Size = new System.Drawing.Size(148, 53);
            this.Write.TabIndex = 22;
            this.Write.Text = "WRITE TO";
            this.Write.UseVisualStyleBackColor = false;
            this.Write.Click += new System.EventHandler(this.Write_Click);
            // 
            // Content
            // 
            this.Content.Location = new System.Drawing.Point(325, 154);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(328, 204);
            this.Content.TabIndex = 23;
            this.Content.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(345, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nội dung được đọc từ input1.txt";
            // 
            // Logo
            // 
            this.Logo.Image = global::Lab2_21520186.Properties.Resources.logoncuit_2;
            this.Logo.Location = new System.Drawing.Point(44, 2);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(114, 59);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 20;
            this.Logo.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LavenderBlush;
            this.button1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Crimson;
            this.button1.Location = new System.Drawing.Point(421, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 53);
            this.button1.TabIndex = 25;
            this.button1.Text = "CLOSE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Close_Click);
            // 
            // Question1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Content);
            this.Controls.Add(this.Write);
            this.Controls.Add(this.Read);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.label1);
            this.Name = "Question1";
            this.Text = "Question 1";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Read;
        private System.Windows.Forms.Button Write;
        private System.Windows.Forms.RichTextBox Content;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}