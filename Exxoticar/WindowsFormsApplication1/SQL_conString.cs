using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class SQL_conString
    {
        private static string conString = "Data Source=ERWINPASCUAL;Initial Catalog=SpringProject;Integrated Security=True";

        public static string connection_String
        {
            get { return conString; }
        }
    }
}
