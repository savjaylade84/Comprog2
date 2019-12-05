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
    public partial class HoverForm : Form
    {
        public HoverForm()
        {
            InitializeComponent();
        }

        private readonly Point point = new Point(Cursor.Position.X, Cursor.Position.Y);   //get the location of the cursor of the mouse
        private void HoverOverPanel(object sender, EventArgs e) => this.Location = point;  //set the location of this form near the cursor of the mouse
        private void DisposeResource(object sender, EventArgs e) => this.Dispose(true);

    }
}
