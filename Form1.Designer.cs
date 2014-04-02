namespace CraigslistSpammer
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
            this.btnSpam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSpam
            // 
            this.btnSpam.Location = new System.Drawing.Point(105, 97);
            this.btnSpam.Name = "btnSpam";
            this.btnSpam.Size = new System.Drawing.Size(75, 23);
            this.btnSpam.TabIndex = 0;
            this.btnSpam.Text = "Spam Now!";
            this.btnSpam.UseVisualStyleBackColor = true;
            this.btnSpam.Click += new System.EventHandler(this.btnSpam_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnSpam);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSpam;
    }
}

