using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class NewStudent : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {
            Page.Validate();
            if (Page.IsValid)
            {
                registrationForm.Visible = false;
                regMessage.Visible = true;
                string first = firstName.Text;
                string last = lastName.Text;
                string phone = telephone.Text;
                string emailAddress = Request.Form["email"];
                SqlConnection dbConnection = new SqlConnection("Data Source=cscsql2.carrollu.edu;Initial Catalog=csc319mcrowell;Persist Security Info=True;User ID=csc319mcrowell;Password=393160");
                try
                {
                    dbConnection.Open();
                    //dbConnection.ChangeDatabase("csc319mcrowell");
                }
                catch (SqlException exception)
                {
                    if (exception.Number == 911)
                    {
                        regMessage.Text = "<p>Can not find database</p>";
                    }
                    else
                    {
                        regMessage.Text += "<p>Error code " + exception.Number + ": " + exception.Message + "</p>";
                    }
                }
                finally
                {
                    regMessage.Text += "<p>Successfully selected the database.</p>";
                }
                try
                {
                    string SQLString = "SELECT * FROM students";
                    SqlCommand checkIDTable = new SqlCommand(SQLString, dbConnection);
                    SqlDataReader idRecords = checkIDTable.ExecuteReader();
                    idRecords.Close();
                }
                catch (SqlException exception)
                {
                    if (exception.Number == 208)
                    {
                        SqlCommand sqlCommand = new SqlCommand("CREATE TABLE students (studentID SMALLINT IDENTITY(100,1) PRIMARY KEY, first VARCHAR(25), last VARCHAR(50), phone VARCHAR(15), email VARCHAR(50))", dbConnection);
                        sqlCommand.ExecuteNonQuery();
                        regMessage.Text += "<p>Successfully created the table.</p>";
                    }
                    else
                    {
                        Response.Write("<p>Error code " + exception.Number + ": " + exception.Message + "</p>");
                    }
                }
                finally
                {
                    string studentInfo = "INSERT INTO students VALUES('" + first + "', '" + last + "', '" + phone + "', '" + emailAddress + "')";
                    SqlCommand sqlCommand = new SqlCommand(studentInfo, dbConnection);
                    sqlCommand.ExecuteNonQuery();
                }
                string idString = "SELECT IDENT_CURRENT('students') AS studentID";
                SqlCommand newID = new SqlCommand(idString, dbConnection);
                SqlDataReader studentRecord = newID.ExecuteReader();
                studentRecord.Read();
                string studentID = Convert.ToString(studentRecord["studentID"]);
                studentRecord.Close();
                regMessage.Text += "<p>Thanks " + first + "! Your new student ID is <strong>" + studentID + "</strong>.</p>";
                regMessage.Text += "<p><a href = 'ReturningStudent.aspx?" + studentID + "'>Register for Classes</a></p>";
                dbConnection.Close();
            }
        }

    }
}