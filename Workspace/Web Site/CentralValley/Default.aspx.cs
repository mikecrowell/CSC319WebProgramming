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
            Page.Validate();
            if (Page.IsValid)
            {
                SqlConnection dbConnection = new SqlConnection("Data Source=cscsql2.carrollu.edu;Initial Catalog=csc319mcrowell;Persist Security Info=True;User ID=csc319mcrowell;Password=393160");
                try
                {
                    dbConnection.Open();
                    string SQLString = "SELECT * FROM students WHERE studentID=" + studentID.Text;
                    SqlCommand checkIDTable = new SqlCommand(SQLString, dbConnection);
                    SqlDataReader idRecords = checkIDTable.ExecuteReader();
                    if (idRecords.Read())
                    {
                        Response.Redirect("ReturningStudent.aspx?studentID=" + studentID.Text);
                        idRecords.Close();
                    }
                    else
                    {
                        validateMessage.Text = "<p>**Invalid student ID**</P>";
                        idRecords.Close();
                    }
                }
                catch (SqlException exception)
                {
                    Response.Write("<p>Error code " + exception.Number + ": " + exception.Message + "</p>");
                }
            }
        }
    }
}
