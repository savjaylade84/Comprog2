using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Comprog2Project.Properties; 
namespace Comprog2Project
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
            StartSplashScreen();
        }

        //corousel hover collection of image path
        private readonly Bitmap[] bitmaps = { Resources._587597, Resources._596398, Resources._596859, 
                                              Resources._629544, Resources._727980, Resources._784987, 
                                              Resources._849843, Resources._910148 };
        private int length = 0;
        //---------------------------------------------------------------------------------------------------------------------------------------

        //change color backcolor in a control

        private void ChangeColorMouseOver(Object sender,EventArgs e) =>ChangeColor.BackColor((Button)sender,System.Drawing.Color.CornflowerBlue);

        private void ChangeColorMouseLeave(Object sender, EventArgs e) => ChangeColor.BackColor((Button)sender, System.Drawing.Color.WhiteSmoke);

        //----------------------------------------------------------------------------------------------------------------------------------------

        //close the form 
        private void CloseLbl_Click(object sender, EventArgs e) => Close();

        //---------------------------------------------------------------------------------------------------------------------------------------

        private void CloseLbl_MouseHover(object sender, EventArgs e) => ChangeColor.ForeColor((Label)sender,System.Drawing.Color.Orange);

        private void CloseLbl_MouseLeave(object sender, EventArgs e) => ChangeColor.ForeColor((Label)sender,System.Drawing.Color.Maroon);

        //---------------------------------------------------------------------------------------------------------------------------------------

        private void CouroselSlides(object sender, EventArgs e) {

           

            if(length > bitmaps.Length)
                length = 0;
            else
                ImageCorousel.BackgroundImage = (length <= bitmaps.Length - 1) ? bitmaps[length] : bitmaps[0];

            length++;

        }

        //----------------------------------------------------------------------------------------------------------------------------------------
         //run the splash screen and abort in about 8sec
        private void StartSplashScreen() {

            Thread thread = new Thread(ThreaStart => Application.Run(new StartForm()));
            thread.Start();
            Thread.Sleep(8000);
            thread.Abort();

        }
       //------------------------------------------------------------------------------------------------------------------------------------------
        //validate the login credential 
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UsernameValue.Text == "admin" && PasswordValue.Text == "admin") {

                Thread thread = new Thread(ThreadStart => Application.Run(new Dashboard()));
                thread.Start();
                this.Close();
            }
        }
      //-----------------------------------------------------------------------------------------------------------------------------------------
      //close the this form
        private void CancelBtn_Click(object sender, EventArgs e) => Close();
      //-----------------------------------------------------------------------------------------------------------------------------------------
        //hide and show text form of the password
        private void ShowHideChkbx_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckState.Checked == ShowHideChkbx.CheckState)
            {
                PasswordValue.UseSystemPasswordChar = true;
                ShowHideChkbx.Text = "Show";
            }
            else
            {
                PasswordValue.UseSystemPasswordChar = false;
                ShowHideChkbx.Text = "Hide";
            }
        }
     //----------------------------------------------------------------------------------------------------------------------------------------
        private void PasswordChoose(object sender, EventArgs e)
        {
            var temp = (TextBox)sender;
            temp.UseSystemPasswordChar = true;
            temp.Clear();
        }
    //--------------------------------------------------------------------------------------------------------------------------------------------
    }
}
