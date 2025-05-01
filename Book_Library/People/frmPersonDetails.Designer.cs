namespace Book_Library.People
{
    partial class frmPersonDetails
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
            this.ctrPersonDetails1 = new Book_Library.People.ctrPersonDetails();
            this.SuspendLayout();
            // 
            // ctrPersonDetails1
            // 
            this.ctrPersonDetails1.Location = new System.Drawing.Point(2, 2);
            this.ctrPersonDetails1.Name = "ctrPersonDetails1";
            this.ctrPersonDetails1.Size = new System.Drawing.Size(1180, 427);
            this.ctrPersonDetails1.TabIndex = 0;
            // 
            // frmPersonDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 432);
            this.Controls.Add(this.ctrPersonDetails1);
            this.Name = "frmPersonDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPersonDetails";
            this.Load += new System.EventHandler(this.frmPersonDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrPersonDetails ctrPersonDetails1;
    }
}