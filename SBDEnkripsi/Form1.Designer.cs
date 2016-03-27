namespace SBDEnkripsi
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
            this.lblFileName = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtKeyString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExec = new System.Windows.Forms.Button();
            this.rdBtnDec = new System.Windows.Forms.RadioButton();
            this.rdBtnEnc = new System.Windows.Forms.RadioButton();
            this.txtMain = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(12, 9);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(122, 19);
            this.lblFileName.TabIndex = 6;
            this.lblFileName.Text = "NO FILE OPENED";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(16, 31);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(99, 23);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "&BROWSE";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtKeyString);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnExec);
            this.groupBox1.Controls.Add(this.rdBtnDec);
            this.groupBox1.Controls.Add(this.rdBtnEnc);
            this.groupBox1.Location = new System.Drawing.Point(16, 261);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 94);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // txtKeyString
            // 
            this.txtKeyString.Location = new System.Drawing.Point(122, 19);
            this.txtKeyString.Name = "txtKeyString";
            this.txtKeyString.PasswordChar = '*';
            this.txtKeyString.Size = new System.Drawing.Size(318, 26);
            this.txtKeyString.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter key string";
            // 
            // btnExec
            // 
            this.btnExec.Location = new System.Drawing.Point(341, 54);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(99, 23);
            this.btnExec.TabIndex = 4;
            this.btnExec.Text = "E&XECUTE";
            this.btnExec.UseVisualStyleBackColor = true;
            this.btnExec.Click += new System.EventHandler(this.btnExec_Click);
            // 
            // rdBtnDec
            // 
            this.rdBtnDec.AutoSize = true;
            this.rdBtnDec.Location = new System.Drawing.Point(92, 54);
            this.rdBtnDec.Name = "rdBtnDec";
            this.rdBtnDec.Size = new System.Drawing.Size(79, 23);
            this.rdBtnDec.TabIndex = 3;
            this.rdBtnDec.TabStop = true;
            this.rdBtnDec.Text = "&Decrypt";
            this.rdBtnDec.UseVisualStyleBackColor = true;
            // 
            // rdBtnEnc
            // 
            this.rdBtnEnc.AutoSize = true;
            this.rdBtnEnc.Location = new System.Drawing.Point(10, 54);
            this.rdBtnEnc.Name = "rdBtnEnc";
            this.rdBtnEnc.Size = new System.Drawing.Size(76, 23);
            this.rdBtnEnc.TabIndex = 2;
            this.rdBtnEnc.TabStop = true;
            this.rdBtnEnc.Text = "&Encrypt";
            this.rdBtnEnc.UseVisualStyleBackColor = true;
            this.rdBtnEnc.CheckedChanged += new System.EventHandler(this.rdBtnEnc_CheckedChanged);
            // 
            // txtMain
            // 
            this.txtMain.Location = new System.Drawing.Point(16, 60);
            this.txtMain.Multiline = true;
            this.txtMain.Name = "txtMain";
            this.txtMain.ReadOnly = true;
            this.txtMain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMain.Size = new System.Drawing.Size(446, 202);
            this.txtMain.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(321, 361);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(143, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "&SAVE TO TXT FILE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 363);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(15, 19);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "-";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 391);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtMain);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.lblFileName);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caesar-XOR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExec;
        private System.Windows.Forms.RadioButton rdBtnDec;
        private System.Windows.Forms.RadioButton rdBtnEnc;
        private System.Windows.Forms.TextBox txtMain;
        private System.Windows.Forms.TextBox txtKeyString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblStatus;
    }
}

