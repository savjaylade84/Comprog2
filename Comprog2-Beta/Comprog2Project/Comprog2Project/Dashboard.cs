using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comprog2Project
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void LeaveForm(object sender, EventArgs e) => Close();
        private void ShowTotal(object sender, EventArgs e) {

            var tempPanel = (Panel)sender;           //capture the control being triggered by this event 
         

            HoverForm hoverForm = new HoverForm();   //form that show the name of the student in the hoverform

            //automacally close that form when the mouse leave from 
            //those panel in this form and determine the backcolor
            //of the hoverform
            tempPanel.MouseLeave += (x, y) => hoverForm.Close();
            if (tempPanel == AbsentPanel )
                hoverForm.BackColor = System.Drawing.Color.Red;
            if (tempPanel == PresentPanel )
                hoverForm.BackColor = System.Drawing.Color.Lime;
            if (tempPanel == LateComerPanel )
                hoverForm.BackColor = System.Drawing.Color.Orange;
            if (tempPanel == ExcusePanel )
                hoverForm.BackColor = System.Drawing.Color.MediumSpringGreen;
            hoverForm.Visible = true;
            hoverForm.Show();

        }

        private void ShowTotalLabel(object sender,EventArgs e) {

            var tempLabel = (Label)sender;
            HoverForm hoverForm = new HoverForm();   //form that show the name of the student in the hoverform

            //automacally close that form when the mouse leave from 
            //those panel in this form and determine the backcolor
            //of the hoverform
            tempLabel.MouseLeave += (x, y) => hoverForm.Close();
            if (tempLabel == AbsentLabel || tempLabel == AbsentNumLabel)
                hoverForm.BackColor = System.Drawing.Color.Red;
            if (tempLabel == PresentNumLabel || tempLabel == PresentLabel)
                hoverForm.BackColor = System.Drawing.Color.Lime;
            if (tempLabel == LateLabel || tempLabel == LateNumLabel)
                hoverForm.BackColor = System.Drawing.Color.Orange;
            if (tempLabel == ExcuseLabel || tempLabel == ExcuseNumLabel)
                hoverForm.BackColor = System.Drawing.Color.MediumSpringGreen;
            hoverForm.Visible = true;
            hoverForm.Show();


        }

        private void HoverNavBar(object sender, EventArgs e) {

            PictureBox pic = (PictureBox)sender;
            Panel tempPanel = (Panel)pic.Parent;
            tempPanel.BackColor = System.Drawing.Color.LightGray;

        }

        private void NotHoverNavBar(object sender, EventArgs e) {

            PictureBox pic = (PictureBox)sender;
            Panel tempPanel = (Panel)pic.Parent;
            tempPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;

        }

    }
}
