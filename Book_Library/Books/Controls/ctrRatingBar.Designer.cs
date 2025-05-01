namespace Book_Library.Books.Controls
{
    partial class ctrRatingBar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbStarFour = new System.Windows.Forms.PictureBox();
            this.pbStarFive = new System.Windows.Forms.PictureBox();
            this.pbStarThree = new System.Windows.Forms.PictureBox();
            this.pbStarTwo = new System.Windows.Forms.PictureBox();
            this.pbStarOne = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbStarFour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStarFive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStarThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStarTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStarOne)).BeginInit();
            this.SuspendLayout();
            // 
            // pbStarFour
            // 
            this.pbStarFour.Image = global::Book_Library.Properties.Resources.EmptyStar;
            this.pbStarFour.Location = new System.Drawing.Point(174, 0);
            this.pbStarFour.Name = "pbStarFour";
            this.pbStarFour.Size = new System.Drawing.Size(51, 53);
            this.pbStarFour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStarFour.TabIndex = 4;
            this.pbStarFour.TabStop = false;
            this.pbStarFour.Click += new System.EventHandler(this.pbStarOne_Click);
            // 
            // pbStarFive
            // 
            this.pbStarFive.Image = global::Book_Library.Properties.Resources.EmptyStar;
            this.pbStarFive.Location = new System.Drawing.Point(231, 0);
            this.pbStarFive.Name = "pbStarFive";
            this.pbStarFive.Size = new System.Drawing.Size(51, 53);
            this.pbStarFive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStarFive.TabIndex = 3;
            this.pbStarFive.TabStop = false;
            this.pbStarFive.Click += new System.EventHandler(this.pbStarOne_Click);
            // 
            // pbStarThree
            // 
            this.pbStarThree.Image = global::Book_Library.Properties.Resources.EmptyStar;
            this.pbStarThree.Location = new System.Drawing.Point(117, 0);
            this.pbStarThree.Name = "pbStarThree";
            this.pbStarThree.Size = new System.Drawing.Size(51, 53);
            this.pbStarThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStarThree.TabIndex = 2;
            this.pbStarThree.TabStop = false;
            this.pbStarThree.Click += new System.EventHandler(this.pbStarOne_Click);
            // 
            // pbStarTwo
            // 
            this.pbStarTwo.Image = global::Book_Library.Properties.Resources.EmptyStar;
            this.pbStarTwo.Location = new System.Drawing.Point(60, 0);
            this.pbStarTwo.Name = "pbStarTwo";
            this.pbStarTwo.Size = new System.Drawing.Size(51, 53);
            this.pbStarTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStarTwo.TabIndex = 1;
            this.pbStarTwo.TabStop = false;
            this.pbStarTwo.Click += new System.EventHandler(this.pbStarOne_Click);
            // 
            // pbStarOne
            // 
            this.pbStarOne.Image = global::Book_Library.Properties.Resources.EmptyStar;
            this.pbStarOne.Location = new System.Drawing.Point(3, 0);
            this.pbStarOne.Name = "pbStarOne";
            this.pbStarOne.Size = new System.Drawing.Size(51, 53);
            this.pbStarOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStarOne.TabIndex = 0;
            this.pbStarOne.TabStop = false;
            this.pbStarOne.Click += new System.EventHandler(this.pbStarOne_Click);
            // 
            // ctrRatingBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbStarFour);
            this.Controls.Add(this.pbStarFive);
            this.Controls.Add(this.pbStarThree);
            this.Controls.Add(this.pbStarTwo);
            this.Controls.Add(this.pbStarOne);
            this.Name = "ctrRatingBar";
            this.Size = new System.Drawing.Size(287, 58);
            ((System.ComponentModel.ISupportInitialize)(this.pbStarFour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStarFive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStarThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStarTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStarOne)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbStarOne;
        private System.Windows.Forms.PictureBox pbStarTwo;
        private System.Windows.Forms.PictureBox pbStarThree;
        private System.Windows.Forms.PictureBox pbStarFive;
        private System.Windows.Forms.PictureBox pbStarFour;
    }
}
