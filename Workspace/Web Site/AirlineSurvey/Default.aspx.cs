using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


public partial class _Default : System.Web.UI.Page
{

    private const string NO = "No Opinion";
    private const string POOR = "Poor";
    private const string FAIR = "Fair";
    private const string GOOD = "Good";
    private const string EX = "Excellent";


    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {
            Page.Validate();
            if (Page.IsValid)
            {
                surveyForm.Visible = false;
                regMessage.Visible = true;
                string studentID = Request.QueryString["studentID"];
                string fNum = txtFlightNum.Text;
                string fDate = txtDate.Text;
                string fTime = txtTime.Text;
                string quest1 = "";
                string quest2 = "";
                string quest3 = "";
                string quest4 = "";
                string quest5 = "";
                if (RadioBQ1No.Checked)
                {
                    quest1 = NO;
                }
                if (RadioBQ1Poor.Checked)
                {
                    quest1 = POOR;
                }
                if (RadioBQ1Fair.Checked)
                {
                    quest1 = FAIR;
                }
                if (RadioBQ1Good.Checked)
                {
                    quest1 = GOOD;
                }
                if (RadioBQ1Ex.Checked)
                {
                    quest1 = EX;
                }
                if (RadioBQ2No.Checked)
                {
                    quest2 = NO;
                }
                if (RadioBQ2Poor.Checked)
                {
                    quest2 = POOR;
                }
                if (RadioBQ2Fair.Checked)
                {
                    quest2 = FAIR;
                }
                if (RadioBQ2Good.Checked)
                {
                    quest2 = GOOD;
                }
                if (RadioBQ2Ex.Checked)
                {
                    quest2 = EX;
                }
                if (RadioBQ3No.Checked)
                {
                    quest3 = NO;
                }
                if (RadioBQ3Poor.Checked)
                {
                    quest3 = POOR;
                }
                if (RadioBQ3Fair.Checked)
                {
                    quest3 = FAIR;
                }
                if (RadioBQ3Good.Checked)
                {
                    quest3 = GOOD;
                }
                if (RadioBQ3Ex.Checked)
                {
                    quest3 = EX;
                }
                if (RadioBQ4No.Checked)
                {
                    quest4 = NO;
                }
                if (RadioBQ4Poor.Checked)
                {
                    quest4 = POOR;
                }
                if (RadioBQ4Fair.Checked)
                {
                    quest4 = FAIR;
                }
                if (RadioBQ4Good.Checked)
                {
                    quest4 = GOOD;
                }
                if (RadioBQ4Ex.Checked)
                {
                    quest4 = EX;
                }
                if (RadioBQ5No.Checked)
                {
                    quest5 = NO;
                }
                if (RadioBQ5Poor.Checked)
                {
                    quest5 = POOR;
                }
                if (RadioBQ5Fair.Checked)
                {
                    quest5 = FAIR;
                }
                if (RadioBQ5Good.Checked)
                {
                    quest5 = GOOD;
                }
                if (RadioBQ5Ex.Checked)
                {
                    quest5 = EX;
                }
                SqlConnection dbConnection = new SqlConnection("Data Source=cscsql2.carrollu.edu;Initial Catalog=csc319mcrowell;Persist Security Info=True;User ID=csc319mcrowell;Password=393160");
                try
                {
                    dbConnection.Open();
                    string classInfo = "INSERT INTO airlinesurvey VALUES('" + fNum + "', '" + fDate + "', '" + fTime + "', '" + quest1 + "', '" + quest2 + "', '" + quest3 + "', '" + quest4 + "', '" + quest5 + "')";
                    SqlCommand sqlCommand = new SqlCommand(classInfo, dbConnection);
                    sqlCommand.ExecuteNonQuery();
                    regMessage.Text += "<p>Thank you for taking the time to complete our survey.</p>";
                }
                catch (SqlException exception)
                {
                    Response.Write("<p>Error code " + exception.Number + ": " + exception.Message + "</p>");
                }
                dbConnection.Close();
            }
        }
    }

}