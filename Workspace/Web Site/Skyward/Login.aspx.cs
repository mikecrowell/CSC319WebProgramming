using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {
            SqlConnection dbConnection = new SqlConnection("Data Source=cscsql2.carrollu.edu;Initial Catalog=csc319mcrowell;Persist Security Info=True;User ID=csc319mcrowell;Password=393160");
            try
            {
                dbConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT flyerID, first, last, password FROM FrequentFlyers WHERE flyerID = " + Convert.ToInt16(account.Text) + "AND password = '" + password.Text + "'", dbConnection);
                SqlDataReader curUser = sqlCommand.ExecuteReader();
                if (curUser.Read())
                {
                    Response.Redirect("ffClubPage.aspx?flyerID=" + curUser["flyerID"]);
                }
                else
                {
                    badLogin.Text = "<p Style='color:red'><strong>Incorrect ID or password.</strong></p>";
                }
            }
            catch (SqlException exception)
            {
                Response.Write("<p>Error code " + exception.Number + ": " + exception.Message + "</p>");
            }
            dbConnection.Close();
        }
    }
}
