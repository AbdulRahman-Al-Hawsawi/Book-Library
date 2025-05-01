namespace Book_Library.People
{
    partial class frmAddUpdatePerson
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
            this.ctrAddUpdatePerson1 = new Book_Library.People.ctrAddUpdatePerson();
            this.SuspendLayout();
            // 
            // ctrAddUpdatePerson1
            // 
            this.ctrAddUpdatePerson1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrAddUpdatePerson1.Location = new System.Drawing.Point(0, 0);
            this.ctrAddUpdatePerson1.Name = "ctrAddUpdatePerson1";
            this.ctrAddUpdatePerson1.Size = new System.Drawing.Size(1081, 604);
            this.ctrAddUpdatePerson1.TabIndex = 0;
            this.ctrAddUpdatePerson1.Load += new System.EventHandler(this.ctrAddUpdatePerson1_Load);
            // 
            // frmAddUpdatePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1081, 604);
            this.Controls.Add(this.ctrAddUpdatePerson1);
            this.Name = "frmAddUpdatePerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Update Person";
            this.Load += new System.EventHandler(this.frmAddUpdatePerson_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrAddUpdatePerson ctrAddUpdatePerson1;
    }
}