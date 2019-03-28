using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace Salon
{
    public partial class upis : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { 
        string ime = Request.Form["ime"];
        string prezime = Request.Form["prezime"];
       
        string username = Request.Form["username"];
        string password = Request.Form["password"];
        string password2 = Request.Form["password2"];
        string email = Request.Form["email"];
        
        string naredba = "select * FROM Klijent WHERE username='" + username + "'";
        SqlDataAdapter da = new SqlDataAdapter(naredba, Konekcija.Connect());
        DataTable klijent = new DataTable();
        da.Fill(klijent);
            
            
            if (klijent.Rows.Count == 0  )
            {
                //Response.Write("Nema ga");
        
                StringBuilder Naredba = new StringBuilder("INSERT INTO ");
                Naredba.Append(" KLIJENT (");
                Naredba.Append("ime, prezime,username,password,email) ");
                Naredba.Append($" VALUES ( '{ime}','{prezime}','{username}','{password}','{email}')");
                Response.Write(Naredba.ToString());                                                                    

                SqlConnection conn = Konekcija.Connect();
                SqlCommand Komanda = new SqlCommand(Naredba.ToString(), conn);
                conn.Open();
                Komanda.ExecuteNonQuery();
                conn.Close();
               Response.Redirect("Login.aspx");
            }
            else
            {
                Response.Write("Ima ga"+klijent.Rows[0][1]);
            }
            
        }
    }
}