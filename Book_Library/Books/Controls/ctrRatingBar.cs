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

namespace Book_Library.Books.Controls
{
    public partial class ctrRatingBar: UserControl
    {
        public ctrRatingBar()
        {
            InitializeComponent();
        }
        //public enum enRating { OneStar = 1, TwoStar = 2, ThreeStar = 3, FourStar = 4, FiveStar = 5 }

        //public enRating Rating
        //{
        //    get { return Rating; }
        //    set
        //    {

        //        switch (value)
        //        {
        //            case enRating.OneStar:
        //                SetFullStarNumber(true);
        //                break;

        //            case enRating.TwoStar:
        //                SetFullStarNumber(true, true);
        //                break;

        //            case enRating.ThreeStar:
        //                SetFullStarNumber(true, true, true);
        //                break;

        //            case enRating.FourStar:
        //                SetFullStarNumber(true, true, true, true);
        //                break;

        //            case enRating.FiveStar:
        //                SetFullStarNumber(true, true, true, true, true);
        //                break;

        //        }
        //    }
        //}

        //public int Num { get { return Num; } set { Num = value; } }

        public void SetRating(int Rating)
        {
            switch (Rating)
            {
                case 1:
                    SetFullStarNumber(true);
                    break;

                case 2:
                    SetFullStarNumber(true, true);
                    break;

                case 3:
                    SetFullStarNumber(true, true, true);
                    break;

                case 4:
                    SetFullStarNumber(true, true, true, true);
                    break;

                case 5:
                    SetFullStarNumber(true, true, true, true, true);
                    break;

            }
        }
        void SetEmptyStarNumber(byte Number)
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

        void SetFullStarNumber(bool One, bool Two =false, bool Three=false, bool Four =false, bool Five =false)
        {
            if (Five)
            {
                pbStarOne.Image = Resources.FullStar;
                pbStarTwo.Image = Resources.FullStar;
                pbStarThree.Image = Resources.FullStar;
                pbStarFour.Image = Resources.FullStar;
                pbStarFive.Image = Resources.FullStar;
            }
            else if (Four)
            {
                pbStarOne.Image = Resources.FullStar;
                pbStarTwo.Image = Resources.FullStar;
                pbStarThree.Image = Resources.FullStar;
                pbStarFour.Image = Resources.FullStar;
                SetEmptyStarNumber(5);
            }
            else if(Three)
            {
                pbStarOne.Image = Resources.FullStar;
                pbStarTwo.Image = Resources.FullStar;
                pbStarThree.Image = Resources.FullStar;
                SetEmptyStarNumber(4);
            }
            else if(Two)
            {
                pbStarOne.Image = Resources.FullStar;
                pbStarTwo.Image = Resources.FullStar;
                SetEmptyStarNumber(3);
            }
            else
            {
                pbStarOne.Image = Resources.FullStar;
                SetEmptyStarNumber(2);
            }
        }

        private void pbStarOne_Click(object sender, EventArgs e)
        {
           
            switch (((PictureBox)sender).Name)
            {
                case "pbStarOne":
                    SetFullStarNumber(true);
                    break;

                case "pbStarTwo":
                    SetFullStarNumber(true, true);
                    break;

                case "pbStarThree":
                    SetFullStarNumber(true, true, true);
                    break;

                case "pbStarFour":
                    SetFullStarNumber(true, true, true, true);
                    break;

                case "pbStarFive":
                    SetFullStarNumber(true, true, true, true, true);
                    break;

            }
        }


    }
}
