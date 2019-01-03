namespace YoutubeDL_UI
{
    partial class DLType
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RBA = new System.Windows.Forms.RadioButton();
            this.RBV = new System.Windows.Forms.RadioButton();
            this.BAcc = new System.Windows.Forms.Button();
            this.BCan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RBV);
            this.groupBox1.Controls.Add(this.RBA);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 68);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Download Type";
            // 
            // RBA
            // 
            this.RBA.AutoSize = true;
            this.RBA.Location = new System.Drawing.Point(6, 19);
            this.RBA.Name = "RBA";
            this.RBA.Size = new System.Drawing.Size(52, 17);
            this.RBA.TabIndex = 0;
            this.RBA.TabStop = true;
            this.RBA.Text = "Audio";
            this.RBA.UseVisualStyleBackColor = true;
            // 
            // RBV
            // 
            this.RBV.AutoSize = true;
            this.RBV.Location = new System.Drawing.Point(6, 42);
            this.RBV.Name = "RBV";
            this.RBV.Size = new System.Drawing.Size(52, 17);
            this.RBV.TabIndex = 1;
            this.RBV.TabStop = true;
            this.RBV.Text = "Video";
            this.RBV.UseVisualStyleBackColor = true;
            // 
            // BAcc
            // 
            this.BAcc.Location = new System.Drawing.Point(12, 86);
            this.BAcc.Name = "BAcc";
            this.BAcc.Size = new System.Drawing.Size(75, 23);
            this.BAcc.TabIndex = 1;
            this.BAcc.Text = "Accept";
            this.BAcc.UseVisualStyleBackColor = true;
            this.BAcc.Click += new System.EventHandler(this.BAcc_Click);
            // 
            // BCan
            // 
            this.BCan.Location = new System.Drawing.Point(93, 86);
            this.BCan.Name = "BCan";
            this.BCan.Size = new System.Drawing.Size(75, 23);
            this.BCan.TabIndex = 2;
            this.BCan.Text = "Cancel";
            this.BCan.UseVisualStyleBackColor = true;
            this.BCan.Click += new System.EventHandler(this.BCan_Click);
            // 
            // DLType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(177, 124);
            this.Controls.Add(this.BCan);
            this.Controls.Add(this.BAcc);
            this.Controls.Add(this.groupBox1);
            this.Name = "DLType";
            this.Text = "Download Type";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RBV;
        private System.Windows.Forms.RadioButton RBA;
        private System.Windows.Forms.Button BAcc;
        private System.Windows.Forms.Button BCan;
    }
}