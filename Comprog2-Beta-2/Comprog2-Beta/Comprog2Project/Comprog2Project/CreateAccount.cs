using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Comprog2Project
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        //---------------------------------------------------------------------------------------------------------------------------------------

        //change the font color in the closing form logo
        private void CloseLbl_MouseHover(object sender, EventArgs e) => ChangeColor.ForeColor((Label)sender, System.Drawing.Color.Orange);

        private void CloseLbl_MouseLeave(object sender, EventArgs e) => ChangeColor.ForeColor((Label)sender, System.Drawing.Color.Maroon);

        //---------------------------------------------------------------------------------------------------------------------------------------

        //change color backcolor in a control

        private void ChangeColorMouseOver(Object sender, EventArgs e) => ChangeColor.BackColor((Button)sender, System.Drawing.Color.CornflowerBlue);

        private void ChangeColorMouseLeave(Object sender, EventArgs e) => ChangeColor.BackColor((Button)sender, System.Drawing.Color.WhiteSmoke);

        //----------------------------------------------------------------------------------------------------------------------------------------

        private void EnabledEdit(object sender, EventArgs e)
        {

            var temp = (Control)sender;
            temp.Select();
            temp.Focus();

        }
        //--------------------------------------------------------------------------------------------------------------------------------------
        private void LeaveForm(object sender, EventArgs e) => Close();      //close the form
        //----------------------------------------------------------------------------------------------------------------------------------------
        private void AccountTypeSwitch(object sender, EventArgs e)
        {
            var temp = (ComboBox)sender;    //capture the control that trigger this event

            //determine the account type and show the correspond textbox will show 
            //to the user
            if (temp.SelectedItem.ToString() == "Teacher")
            {

                AccountNoValue.Text = "(Teacher No.)";
                AccCredentialPanel.Visible = true;

            }
            if (temp.SelectedItem.ToString() == "Student")
            {
                AccountNoValue.Text = "(Student NO.)";
                AccCredentialPanel.Visible = false;

            }
            //----------------------------------------------------------------------------------------------------------------------------------
            //enabled some common textbox to the account
            List<Control> controls = new List<Control>(new TextBox[]{

                fnameValue,mnameValue,lnameValue,contactValue,emailValue,
                addressValue,bdateValue

            });

            EnableControl.ControlEnable(controls,true);

        }
        //-------------------------------------------------------------------------------------------------------------------------------------
    }
}
