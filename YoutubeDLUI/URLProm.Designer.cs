namespace YoutubeDL_UI
{
    partial class URLProm
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
            this.TBURL = new System.Windows.Forms.TextBox();
            this.BAcc = new System.Windows.Forms.Button();
            this.BCan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBURL
            // 
            this.TBURL.Location = new System.Drawing.Point(12, 12);
            this.TBURL.Name = "TBURL";
            this.TBURL.Size = new System.Drawing.Size(274, 20);
            this.TBURL.TabIndex = 0;
            // 
            // BAcc
            // 
            this.BAcc.Location = new System.Drawing.Point(12, 38);
            this.BAcc.Name = "BAcc";
            this.BAcc.Size = new System.Drawing.Size(126, 26);
            this.BAcc.TabIndex = 1;
            this.BAcc.Text = "Accept";
            this.BAcc.UseVisualStyleBackColor = true;
            this.BAcc.Click += new System.EventHandler(this.BAcc_Click);
            // 
            // BCan
            // 
            this.BCan.Location = new System.Drawing.Point(160, 38);
            this.BCan.Name = "BCan";
            this.BCan.Size = new System.Drawing.Size(126, 26);
            this.BCan.TabIndex = 2;
            this.BCan.Text = "Cancel";
            this.BCan.UseVisualStyleBackColor = true;
            this.BCan.Click += new System.EventHandler(this.BCan_Click);
            // 
            // URLProm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 81);
            this.Controls.Add(this.BCan);
            this.Controls.Add(this.BAcc);
            this.Controls.Add(this.TBURL);
            this.Name = "URLProm";
            this.Text = "URL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBURL;
        private System.Windows.Forms.Button BAcc;
        private System.Windows.Forms.Button BCan;
    }
}