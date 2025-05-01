namespace Book_Library.Users
{
    partial class frmConfirmEmail
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
            this.components = new System.ComponentModel.Container();
            this.tbSentCode = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnResend = new System.Windows.Forms.Button();
            this.btnCheckEmail = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSentCode
            // 
            this.tbSentCode.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSentCode.Location = new System.Drawing.Point(241, 25);
            this.tbSentCode.Multiline = true;
            this.tbSentCode.Name = "tbSentCode";
            this.tbSentCode.Size = new System.Drawing.Size(316, 55);
            this.tbSentCode.TabIndex = 0;
            this.tbSentCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSentCode.Enter += new System.EventHandler(this.tbSentCode_Enter);
            this.tbSentCode.Leave += new System.EventHandler(this.tbSentCode_Leave);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(322, 95);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(172, 40);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnResend
            // 
            this.btnResend.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResend.Location = new System.Drawing.Point(322, 150);
            this.btnResend.Name = "btnResend";
            this.btnResend.Size = new System.Drawing.Size(172, 40);
            this.btnResend.TabIndex = 2;
            this.btnResend.Text = "Resend";
            this.btnResend.UseVisualStyleBackColor = true;
            this.btnResend.Click += new System.EventHandler(this.btnResend_Click);
            // 
            // btnCheckEmail
            // 
            this.btnCheckEmail.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCheckEmail.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckEmail.Location = new System.Drawing.Point(322, 207);
            this.btnCheckEmail.Name = "btnCheckEmail";
            this.btnCheckEmail.Size = new System.Drawing.Size(172, 40);
            this.btnCheckEmail.TabIndex = 3;
            this.btnCheckEmail.Text = "Check Email";
            this.btnCheckEmail.UseVisualStyleBackColor = true;
            this.btnCheckEmail.Click += new System.EventHandler(this.btnCheckEmail_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Book_Library.Properties.Resources.gmail_ios__1_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 270);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmConfirmEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnCheckEmail;
            this.ClientSize = new System.Drawing.Size(800, 270);
            this.Controls.Add(this.btnCheckEmail);
            this.Controls.Add(this.btnResend);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.tbSentCode);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "frmConfirmEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Email Verification";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConfirmEmail_FormClosing);
            this.Load += new System.EventHandler(this.frmConfirmEmail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSentCode;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnResend;
        private System.Windows.Forms.Button btnCheckEmail;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}