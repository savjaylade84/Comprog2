using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comprog2Project
{
    public partial class SearchAndFindFrm : Form
    {
        public SearchAndFindFrm()
        {
            InitializeComponent();
        }

        private void HoverLeaveForm(object sender, EventArgs e) => ChangeColor.ForeColor((Control)sender, System.Drawing.Color.Orange);
        private void NotHoverLeaveForm(object sender, EventArgs e) => ChangeColor.ForeColor((Control)sender, System.Drawing.Color.Red);

        private void SelectSection(object sender, EventArgs e)
        {
            ConnectionDb.QueryCommand = "SELECT class_section FROM Classroom";
            List<object> list = new List<object>();
            //this will use those things to connect database then close and dispose the resources
            using (ConnectionDb.Connection = new SqlConnection(ConnectionString.ConnectionStrings))
            using (ConnectionDb.Command = new SqlCommand(ConnectionDb.QueryCommand, ConnectionDb.Connection))
            using (ConnectionDb.Adapter = new SqlDataAdapter(ConnectionDb.Command))
            {

                ConnectionDb.Command.CommandType = CommandType.Text;                    //determine the type of command that will execute
                ConnectionDb.Adapter.Fill(ConnectionDb.dataSet, "Classroom");           //fill the data in the dataset

                for (int x = 0; x < ConnectionDb.dataSet.Tables[0].Rows.Count; x++)      //search the whole value in the system
                {
                    if (!SectionCodeCmb.Items.Contains(ConnectionDb.dataSet.Tables[0].Rows[x][0]))
                    {
                        SectionCodeCmb.Items.Add(ConnectionDb.dataSet.Tables[0].Rows[x][0]);   //then put those data in the combobox
                    }
                    SectionCodeCmb.Items.RemoveAt(x);
                    SectionCodeCmb.Items.AddRange(list.ToArray());

                }

            }


        }
        private void CloseForm(object sender, EventArgs e) => Close();

        delegate void InvokeCrossThread(Control control);
    }
}
