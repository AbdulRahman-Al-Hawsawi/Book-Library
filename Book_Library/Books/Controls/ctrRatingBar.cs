using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Book_Library.Properties;
using System.Diagnostics.Eventing.Reader;
using Guna.UI2.WinForms;
using BookLibrary_Business;
using Book_Library.GlobalClasses;

namespace Book_Library.Books.Controls
{
    public partial class ctrRatingBar: UserControl
    {
        public ctrRatingBar()
        {
            InitializeComponent();
            
        }
        public enum enRating { OneStar = 1, TwoStar = 2, ThreeStar = 3, FourStar = 4, FiveStar = 5 }    

        public int BookID 
        {
            get;
            set;
        }

        public void SetBookRating(float BookRating)
        {

             if (BookRating > 0 && BookRating < 2)
                SetFullStarNumber(enRating.OneStar);
             else if ( BookRating >= 2 && BookRating < 3)
                SetFullStarNumber(enRating.TwoStar);
             else if (BookRating >= 3 && BookRating < 4)
                SetFullStarNumber(enRating.ThreeStar);
             else if ( BookRating >= 4 && BookRating < 5)
                SetFullStarNumber(enRating.FourStar);
             else if (BookRating >= 5)
                SetFullStarNumber(enRating.FiveStar);
        }
      
        private void SetEmptyStarNumber(byte Number)
        {

            switch (Number)
            {
                case 1:
                    pbStarOne.Image = Resources.EmptyStar;
                    pbStarTwo.Image = Resources.EmptyStar;
                    pbStarThree.Image = Resources.EmptyStar;
                    pbStarFour.Image = Resources.EmptyStar;
                    pbStarFive.Image = Resources.EmptyStar;
                    break;
                case 2:
                    pbStarTwo.Image = Resources.EmptyStar;
                    pbStarThree.Image = Resources.EmptyStar;
                    pbStarFour.Image = Resources.EmptyStar;
                    pbStarFive.Image = Resources.EmptyStar;
                    break;
                case 3:
                    pbStarThree.Image = Resources.EmptyStar;
                    pbStarFour.Image = Resources.EmptyStar;
                    pbStarFive.Image = Resources.EmptyStar;
                    break;
                case 4:
                    pbStarFour.Image = Resources.EmptyStar;
                    pbStarFive.Image = Resources.EmptyStar;
                    break;
                case 5:
                    pbStarFive.Image = Resources.EmptyStar;
                    break;
            }
           
        }
      
        private void SetFullStarNumber(enRating rate)
        {
            switch(rate)
            {
                case enRating.FiveStar:
                    pbStarOne.Image = Resources.FullStar;
                    pbStarTwo.Image = Resources.FullStar;
                    pbStarThree.Image = Resources.FullStar;
                    pbStarFour.Image = Resources.FullStar;
                    pbStarFive.Image = Resources.FullStar;
                    break;

                case enRating.FourStar:
                    pbStarOne.Image = Resources.FullStar;
                    pbStarTwo.Image = Resources.FullStar;
                    pbStarThree.Image = Resources.FullStar;
                    pbStarFour.Image = Resources.FullStar;
                    SetEmptyStarNumber(5);
                    break;

                case enRating.ThreeStar:
                    pbStarOne.Image = Resources.FullStar;
                    pbStarTwo.Image = Resources.FullStar;
                    pbStarThree.Image = Resources.FullStar;
                    SetEmptyStarNumber(4);
                    break;

                case enRating.TwoStar:
                    pbStarOne.Image = Resources.FullStar;
                    pbStarTwo.Image = Resources.FullStar;
                    SetEmptyStarNumber(3);
                    break;

                case enRating.OneStar:
                    pbStarOne.Image = Resources.FullStar;
                    SetEmptyStarNumber(2);
                    break;

            }
            
        }

        private void Star_Click(object sender, EventArgs e)
        {
            clsRating NewRting = new clsRating();
            NewRting.UserID = clsGlobal.CurrentUser.UserID;
            NewRting.BookID = BookID;
            
            switch (((PictureBox)sender).Name)
            {
                case "pbStarOne":
                    if (MessageBox.Show("Are you want to rate this book with a star?", "Rate book", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        SetFullStarNumber(enRating.OneStar);
                        NewRting.Rating = 1;
                    break;

                case "pbStarTwo":
                    if (MessageBox.Show("Are you want to rate this book with two stars?", "Rate book", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        SetFullStarNumber(enRating.TwoStar);
                        NewRting.Rating = 2;
                    break;

                case "pbStarThree":
                    if (MessageBox.Show("Are you want to rate this book with three stars?", "Rate book", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        SetFullStarNumber(enRating.ThreeStar);
                        NewRting.Rating = 3;
                    break;

                case "pbStarFour":
                    if (MessageBox.Show("Are you want to rate this book with four stars?", "Rate book", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        SetFullStarNumber(enRating.FourStar);
                        NewRting.Rating = 4;
                    break;

                case "pbStarFive":
                    if (MessageBox.Show("Are you want to rate this book with five stars?", "Rate book", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        SetFullStarNumber(enRating.FiveStar);
                        NewRting.Rating = 5;
                    break;

            }
            if (NewRting.Save())
                MessageBox.Show($"Done, rating book with {NewRting.Rating} star(s)");
        }


    }
}
