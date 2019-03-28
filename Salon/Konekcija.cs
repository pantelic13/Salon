using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Text;
using System.Data;


namespace Salon
{
    public class Konekcija
    {
        static string myServer = Environment.MachineName;
        static string CS = ("Data Source= " + myServer + " ;Initial Catalog=Salon ;Integrated Security=True;MultipleActiveResultSets=True");
        static public SqlConnection Connect()
        {
            SqlConnection conn = new SqlConnection(CS);
            return conn;
        }
    }
}