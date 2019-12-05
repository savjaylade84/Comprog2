using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comprog2Project
{
     internal interface IAccount
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string MiddleName { get; set; }
        string FullName { get; }
        string Email { get; set; }
        string Contact { get; set; }
    }
}
