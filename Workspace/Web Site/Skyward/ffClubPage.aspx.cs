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
        if (Request.QueryString["flyerID"] == null)
        {
            Response.Redirect("Login.aspx");
        }
        else
        {
             SqlConnection dbConnection = new SqlConnection("Data Source=cscsql2.carrollu.edu;Initial Catalog=csc319mcrowell;Persist Security Info=True;User ID=csc319mcrowell;Password=393160");
             try
             {
                 dbConnection.Open();
                 SqlCommand sqlCommand = new SqlCommand("SELECT flyerID, first, last FROM FrequentFlyers WHERE flyerID = " + Request.QueryString["flyerID"], dbConnection);
                 SqlDataReader userInfo = sqlCommand.ExecuteReader();
                 if (userInfo.Read())
                 {
                     flyerIDValue.Text = userInfo["flyerID"].ToString();
                     firstName.Text = userInfo["first"].ToString();
                     lastName.Text = userInfo["last"].ToString();
                 }
                 userInfo.Close();
             }
             catch (SqlException exception)
             {
                 Response.Write("<p>Error code " + exception.Number + ": " + exception.Message + "</p>");
             }
             dbConnection.Close();
        }
    }
}
