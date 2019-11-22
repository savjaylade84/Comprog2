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


        private readonly Bitmap[] bitmaps = {Resources._587597, Resources._596398, Resources._596859, Resources._629544, Resources._727980, Resources._784987, Resources._849843, Resources._910148 };
        private int length = 0;
        //---------------------------------------------------------------------------------------------------------------------------------------

        //change color backcolor in a control

        private void ChangeColorMouseOver(Object sender,EventArgs e) =>ChangeColor.BackColor((Button)sender,System.Drawing.Color.CornflowerBlue);

        private void ChangeColorMouseLeave(Object sender, EventArgs e) => ChangeColor.BackColor((Button)sender, System.Drawing.Color.WhiteSmoke);

        //----------------------------------------------------------------------------------------------------------------------------------------

        //close the form 
        private void CloseLbl_Click(object sender, EventArgs e) => Close();

        //---------------------------------------------------------------------------------------------------------------------------------------

        private void CloseLbl_MouseHover(object sender, EventArgs e) => CloseLbl.ForeColor = System.Drawing.Color.Orange;

        private void CloseLbl_MouseLeave(object sender, EventArgs e) => CloseLbl.ForeColor = System.Drawing.Color.Maroon;

        //---------------------------------------------------------------------------------------------------------------------------------------

        private void CouroselSlides(object sender, EventArgs e) {

           

            if(length > bitmaps.Length)
                length = 0;
            else
                ImageCorousel.BackgroundImage = (length <= bitmaps.Length - 1) ? bitmaps[length] : bitmaps[0];

            length++;

        }

        //----------------------------------------------------------------------------------------------------------------------------------------

        private void SplashScreenShow() => Application.Run(new StartForm());
        private void Dashboard() => Application.Run(new Dashboard());

        private void StartSplashScreen() {

            Thread thread = new Thread(new ThreadStart(SplashScreenShow));
            thread.Start();
            Thread.Sleep(8000);
            thread.Abort();

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UsernameValue.Text == "admin" && PasswordValue.Text == "admin") {

                Thread thread = new Thread(new ThreadStart(Dashboard));
                thread.Start();
                this.Close();
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e) => Close();

        private void ShowHideChkbx_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckState.Checked == ShowHideChkbx.CheckState)
            {
                PasswordValue.UseSystemPasswordChar = true;
                ShowHideChkbx.Text = "Hide";
            }
            else
            {
                PasswordValue.UseSystemPasswordChar = false;
                ShowHideChkbx.Text = "Show";
            }
        }

        private void PasswordChoose(object sender, EventArgs e)
        {
            PasswordValue.UseSystemPasswordChar = true;
            PasswordValue.Clear();
        }
    }
}
