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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(Session["Klijent"]);
        }

     

        protected void Button1_Click1(object sender, EventArgs e)
        {
            string Username = TextBox1.Text;
            string FRMpass = TextBox2.Text;

            string naredba = "select * FROM Klijent WHERE Username='" + Username + "'";
            SqlDataAdapter da = new SqlDataAdapter(naredba, Konekcija.Connect());
            DataTable Klijent = new DataTable();
            da.Fill(Klijent);
            if (Klijent.Rows.Count == 0)
            {
                Response.Write("Nema ga");
            }
            else
            {
                string DBpass = Klijent.Rows[0]["Password"].ToString();
                if (!FRMpass.Equals(DBpass))
                {
                    Response.Write("Los password");
                }
                else
                {
                    Session["Klijent"] = Username;
                    //Session["tip"] = Klijent.Rows[0]["tip_korisnika"].ToString();
                    Session["Ime"] = Klijent.Rows[0][3].ToString();
                    SqlConnection conn = Konekcija.Connect();
                    //SqlCommand komanda = new SqlCommand("update Klijent set Username where Username = '" + TextBox1.Text + "'", conn);
                    SqlCommand Komanda = new SqlCommand(naredba.ToString(), conn);
                    conn.Open();
                    Komanda.ExecuteNonQuery();
                    conn.Close();
                    Response.Redirect("Zakazivanje.aspx");
                }
            }
        }
    }
}

        
    
