using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comprog2Project
{
    class Teacher : ITeacher
    {
        public string ProfessorID { get; set; } = "";
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string MiddleName { get; set; } = "";
        public string FullName { get { return LastName + "," + FirstName + MiddleName[0]; } }
        public string Email { get; set; } = "";
        public string Contact { get; set; } = "";

        public void AddStudent(IStudent student) {

            ConnectionDb.QueryCommand = @"INSERT INTO ClassroomAttendance()VALUES(@studentid,@fname,@mname,@lname,@email,@contact)";

            using (ConnectionDb.Connection = new SqlConnection(ConnectionString.ConnectionStrings))
            using (ConnectionDb.Command = new SqlCommand(ConnectionDb.QueryCommand, ConnectionDb.Connection))
            using (ConnectionDb.Adapter = new SqlDataAdapter(ConnectionDb.Command))
            {
                ConnectionDb.Command.CommandType = CommandType.Text;                    //determine the type of command that will execute
               // ConnectionDb.Command.Parameters.AddWithValue("@studentid",StudentID.Text);
               //ConnectionDb.Command.Parameters.AddWithValue("@fname",FisrtName.Text);

            }

        }

    }
}
