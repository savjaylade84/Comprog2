using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comprog2Project
{
    internal class Student : IStudent
    {
        public string StudenID { get; set; } = "";
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string MiddleName { get; set; } = "";
        public string FullName { get { return LastName + "," + FirstName + MiddleName[0]; } }
        public string Email { get; set; } = "";
        public string Contact { get; set; } = "";

    }
}
