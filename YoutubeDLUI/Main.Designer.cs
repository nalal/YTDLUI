namespace YoutubeDL_UI
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
            this.LBURLs = new System.Windows.Forms.ListBox();
            this.BAdd = new System.Windows.Forms.Button();
            this.BRem = new System.Windows.Forms.Button();
            this.BDL = new System.Windows.Forms.Button();
            this.BDLType = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LBDLT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBURLs
            // 
            this.LBURLs.FormattingEnabled = true;
            this.LBURLs.Location = new System.Drawing.Point(12, 12);
            this.LBURLs.Name = "LBURLs";
            this.LBURLs.Size = new System.Drawing.Size(256, 407);
            this.LBURLs.TabIndex = 0;
            this.LBURLs.SelectedIndexChanged += new System.EventHandler(this.LBURLs_SelectedIndexChanged);
            // 
            // BAdd
            // 
            this.BAdd.Location = new System.Drawing.Point(274, 12);
            this.BAdd.Name = "BAdd";
            this.BAdd.Size = new System.Drawing.Size(75, 23);
            this.BAdd.TabIndex = 1;
            this.BAdd.Text = "Add";
            this.BAdd.UseVisualStyleBackColor = true;
            this.BAdd.Click += new System.EventHandler(this.BAdd_Click);
            // 
            // BRem
            // 
            this.BRem.Location = new System.Drawing.Point(274, 41);
            this.BRem.Name = "BRem";
            this.BRem.Size = new System.Drawing.Size(75, 23);
            this.BRem.TabIndex = 2;
            this.BRem.Text = "Remove";
            this.BRem.UseVisualStyleBackColor = true;
            this.BRem.Click += new System.EventHandler(this.BRem_Click);
            // 
            // BDL
            // 
            this.BDL.Location = new System.Drawing.Point(274, 380);
            this.BDL.Name = "BDL";
            this.BDL.Size = new System.Drawing.Size(75, 39);
            this.BDL.TabIndex = 3;
            this.BDL.Text = "Download All";
            this.BDL.UseVisualStyleBackColor = true;
            this.BDL.Click += new System.EventHandler(this.BDL_Click);
            // 
            // BDLType
            // 
            this.BDLType.Location = new System.Drawing.Point(274, 96);
            this.BDLType.Name = "BDLType";
            this.BDLType.Size = new System.Drawing.Size(75, 39);
            this.BDLType.TabIndex = 4;
            this.BDLType.Text = "Download Type";
            this.BDLType.UseVisualStyleBackColor = true;
            this.BDLType.Click += new System.EventHandler(this.BDLType_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Download Type:";
            // 
            // LBDLT
            // 
            this.LBDLT.AutoSize = true;
            this.LBDLT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LBDLT.Location = new System.Drawing.Point(274, 80);
            this.LBDLT.Name = "LBDLT";
            this.LBDLT.Size = new System.Drawing.Size(37, 15);
            this.LBDLT.TabIndex = 6;
            this.LBDLT.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 430);
            this.Controls.Add(this.LBDLT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BDLType);
            this.Controls.Add(this.BDL);
            this.Controls.Add(this.BRem);
            this.Controls.Add(this.BAdd);
            this.Controls.Add(this.LBURLs);
            this.Name = "Form1";
            this.Text = "Youtube DL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LBURLs;
        private System.Windows.Forms.Button BAdd;
        private System.Windows.Forms.Button BRem;
        private System.Windows.Forms.Button BDL;
        private System.Windows.Forms.Button BDLType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBDLT;
    }
}

