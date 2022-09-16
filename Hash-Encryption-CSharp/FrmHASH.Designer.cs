namespace Hash_Encryption_CSharp
{
    partial class FrmHASH
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
            this.BtnMD5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TbxHASH = new System.Windows.Forms.TextBox();
            this.TbxData = new System.Windows.Forms.TextBox();
            this.BtnSHA1 = new System.Windows.Forms.Button();
            this.BtnSHA256 = new System.Windows.Forms.Button();
            this.BtnSHA384 = new System.Windows.Forms.Button();
            this.BtnSHA512 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LblCharactersLength = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnMD5
            // 
            this.BtnMD5.Location = new System.Drawing.Point(234, 126);
            this.BtnMD5.Name = "BtnMD5";
            this.BtnMD5.Size = new System.Drawing.Size(80, 23);
            this.BtnMD5.TabIndex = 25;
            this.BtnMD5.Text = "MD5";
            this.BtnMD5.UseVisualStyleBackColor = true;
            this.BtnMD5.Click += new System.EventHandler(this.BtnMD5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 24F);
            this.label4.Location = new System.Drawing.Point(377, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 39);
            this.label4.TabIndex = 23;
            this.label4.Text = "HASHING";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(18, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "HASH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(28, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "Data";
            // 
            // TbxHASH
            // 
            this.TbxHASH.BackColor = System.Drawing.Color.White;
            this.TbxHASH.Location = new System.Drawing.Point(75, 100);
            this.TbxHASH.Name = "TbxHASH";
            this.TbxHASH.ReadOnly = true;
            this.TbxHASH.Size = new System.Drawing.Size(817, 20);
            this.TbxHASH.TabIndex = 13;
            // 
            // TbxData
            // 
            this.TbxData.Location = new System.Drawing.Point(75, 72);
            this.TbxData.Name = "TbxData";
            this.TbxData.Size = new System.Drawing.Size(817, 20);
            this.TbxData.TabIndex = 0;
            // 
            // BtnSHA1
            // 
            this.BtnSHA1.Location = new System.Drawing.Point(320, 126);
            this.BtnSHA1.Name = "BtnSHA1";
            this.BtnSHA1.Size = new System.Drawing.Size(80, 23);
            this.BtnSHA1.TabIndex = 25;
            this.BtnSHA1.Text = "SHA1";
            this.BtnSHA1.UseVisualStyleBackColor = true;
            this.BtnSHA1.Click += new System.EventHandler(this.BtnSHA1_Click);
            // 
            // BtnSHA256
            // 
            this.BtnSHA256.Location = new System.Drawing.Point(406, 126);
            this.BtnSHA256.Name = "BtnSHA256";
            this.BtnSHA256.Size = new System.Drawing.Size(80, 23);
            this.BtnSHA256.TabIndex = 25;
            this.BtnSHA256.Text = "SHA256";
            this.BtnSHA256.UseVisualStyleBackColor = true;
            this.BtnSHA256.Click += new System.EventHandler(this.BtnSHA256_Click);
            // 
            // BtnSHA384
            // 
            this.BtnSHA384.Location = new System.Drawing.Point(492, 126);
            this.BtnSHA384.Name = "BtnSHA384";
            this.BtnSHA384.Size = new System.Drawing.Size(80, 23);
            this.BtnSHA384.TabIndex = 25;
            this.BtnSHA384.Text = "SHA384";
            this.BtnSHA384.UseVisualStyleBackColor = true;
            this.BtnSHA384.Click += new System.EventHandler(this.BtnSHA384_Click);
            // 
            // BtnSHA512
            // 
            this.BtnSHA512.Location = new System.Drawing.Point(578, 126);
            this.BtnSHA512.Name = "BtnSHA512";
            this.BtnSHA512.Size = new System.Drawing.Size(80, 23);
            this.BtnSHA512.TabIndex = 25;
            this.BtnSHA512.Text = "SHA512";
            this.BtnSHA512.UseVisualStyleBackColor = true;
            this.BtnSHA512.Click += new System.EventHandler(this.BtnSHA512_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(71, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Characters Length";
            // 
            // LblCharactersLength
            // 
            this.LblCharactersLength.AutoSize = true;
            this.LblCharactersLength.Font = new System.Drawing.Font("Tahoma", 12F);
            this.LblCharactersLength.Location = new System.Drawing.Point(213, 168);
            this.LblCharactersLength.Name = "LblCharactersLength";
            this.LblCharactersLength.Size = new System.Drawing.Size(18, 19);
            this.LblCharactersLength.TabIndex = 18;
            this.LblCharactersLength.Text = "0";
            // 
            // FrmHASH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 196);
            this.Controls.Add(this.BtnSHA512);
            this.Controls.Add(this.BtnSHA384);
            this.Controls.Add(this.BtnSHA256);
            this.Controls.Add(this.BtnSHA1);
            this.Controls.Add(this.BtnMD5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblCharactersLength);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbxHASH);
            this.Controls.Add(this.TbxData);
            this.Name = "FrmHASH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HASHING";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnMD5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbxHASH;
        private System.Windows.Forms.TextBox TbxData;
        private System.Windows.Forms.Button BtnSHA1;
        private System.Windows.Forms.Button BtnSHA256;
        private System.Windows.Forms.Button BtnSHA384;
        private System.Windows.Forms.Button BtnSHA512;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblCharactersLength;
    }
}

