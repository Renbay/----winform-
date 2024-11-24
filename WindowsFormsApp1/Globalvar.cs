using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Globalvar
    {
        public static DataTable Housetable { get; set; } = new DataTable();

        public static string LoginAccount { get; set; }
        public static string LogName { get; set; }
    }
}
