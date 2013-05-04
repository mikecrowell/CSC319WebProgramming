<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Airline Surveys</title>
    <link href="Styles/Site.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="surveyForm" runat="server">
		<div id="header"> <!-- begin header -->
			<h1 style="left: 20px; top: 22px"><span>CSC </span>319</h1>
			<h2>Mike Crowell</h2>
		</div> <!-- end header -->

		<div id="splash"> <!-- begin outer splash -->
			<br />
			<div id="innersplash"> <!-- begin inner splash -->
				Airline Survey
			</div> <!-- end inner splash -->
		</div> <!-- end outer splash -->


		<div id="primarycontent">  <!-- primary content begin -->


		    <br />
            <h1 style='text-align:center; color:Blue; font-weight:bold'>Airline survey</h1>
            <h3 style='text-align:center; color:Blue; font-weight:bold'>Please complete the following survey.</h3>
            <br />
            <table>
                <tr>
                    <td><asp:Label ID="Label11" runat="server" Text="Label">Flight Number: </asp:Label>&nbsp;<asp:RequiredFieldValidator ID="firstNameValidate" runat="server"
                     ControlToValidate="txtFlightNum" Text="**Required field**" /></td>
                    <td><asp:TextBox ID="txtFlightNum" runat="server" BorderStyle="Inset" ReadOnly="False"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label12" runat="server" Text="Label">Flight Date: </asp:Label>&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                     ControlToValidate="txtDate" Text="**Required field**" /></td>
                    <td><asp:TextBox ID="txtDate" runat="server" BorderStyle="Inset" ReadOnly="False"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label13" runat="server" Text="Label">Flight Time: </asp:Label>&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                     ControlToValidate="txtTime" Text="**Required field**" /></td>
                    <td><asp:TextBox ID="txtTime" runat="server" BorderStyle="Inset" ReadOnly="False"></asp:TextBox></td>
                </tr>
            </table>
            <p>Rate your experience with this airline.</p>
            <ul>
                <li>Frienliness of customer staff<br />
                    <asp:RadioButton ID="RadioBQ1No" runat="server" GroupName = "question1"  Text = "No Opinion"/> 
                    &nbsp&nbsp
                    <asp:RadioButton ID="RadioBQ1Poor" runat="server"  GroupName = "question1" Text = "Poor"/> 
                    &nbsp&nbsp
                    <asp:RadioButton ID="RadioBQ1Fair" runat="server"  GroupName = "question1" Text = "Fair"/>        
                    &nbsp&nbsp
                    <asp:RadioButton ID="RadioBQ1Good" runat="server"  GroupName = "question1" Text = "Good"/>
                    &nbsp&nbsp
                    <asp:RadioButton ID="RadioBQ1Ex" runat="server"  GroupName = "question1" Text = "Excellent"/>                                        
                    <br />   
                    <br />              
                </li>
                <li>Space for luggage storage<br />
                    <asp:RadioButton ID="RadioBQ2No" runat="server" GroupName = "question2"  Text = "No Opinion"/> 
                    &nbsp&nbsp
                    <asp:RadioButton ID="RadioBQ2Poor" runat="server"  GroupName = "question2" Text = "Poor"/> 
                    &nbsp&nbsp
                    <asp:RadioButton ID="RadioBQ2Fair" runat="server"  GroupName = "question2" Text = "Fair"/>        
                    &nbsp&nbsp
                    <asp:RadioButton ID="RadioBQ2Good" runat="server"  GroupName = "question2" Text = "Good"/>
                    &nbsp&nbsp
                    <asp:RadioButton ID="RadioBQ2Ex" runat="server"  GroupName = "question2" Text = "Excellent"/>                                        
                    <br />   
                    <br />                 
                </li>
                <li>Comfort of seating<br />
                    <asp:RadioButton ID="RadioBQ3No" runat="server" GroupName = "question3"  Text = "No Opinion"/> 
                    &nbsp&nbsp
                    <asp:RadioButton ID="RadioBQ3Poor" runat="server"  GroupName = "question3" Text = "Poor"/> 
                    &nbsp&nbsp
                    <asp:RadioButton ID="RadioBQ3Fair" runat="server"  GroupName = "question3" Text = "Fair"/>        
                    &nbsp&nbsp
                    <asp:RadioButton ID="RadioBQ3Good" runat="server"  GroupName = "question3" Text = "Good"/>
                    &nbsp&nbsp
                    <asp:RadioButton ID="RadioBQ3Ex" runat="server"  GroupName = "question3" Text = "Excellent"/>                                        
                    <br />   
                    <br />                 
                </li>
                <li>Cleanliness of aircraft<br />
                    <asp:RadioButton ID="RadioBQ4No" runat="server" GroupName = "question4"  Text = "No Opinion"/> 
                    &nbsp&nbsp
                    <asp:RadioButton ID="RadioBQ4Poor" runat="server"  GroupName = "question4" Text = "Poor"/> 
                    &nbsp&nbsp
                    <asp:RadioButton ID="RadioBQ4Fair" runat="server"  GroupName = "question4" Text = "Fair"/>        
                    &nbsp&nbsp
                    <asp:RadioButton ID="RadioBQ4Good" runat="server"  GroupName = "question4" Text = "Good"/>
                    &nbsp&nbsp
                    <asp:RadioButton ID="RadioBQ4Ex" runat="server"  GroupName = "question4" Text = "Excellent"/>                                        
                    <br />   
                    <br />                 
                </li>
                <li>Noise level of aircraft<br />
                    <asp:RadioButton ID="RadioBQ5No" runat="server" GroupName = "question5"  Text = "No Opinion"/> 
                    &nbsp&nbsp
                    <asp:RadioButton ID="RadioBQ5Poor" runat="server"  GroupName = "question5" Text = "Poor"/> 
                    &nbsp&nbsp
                    <asp:RadioButton ID="RadioBQ5Fair" runat="server"  GroupName = "question5" Text = "Fair"/>        
                    &nbsp&nbsp
                    <asp:RadioButton ID="RadioBQ5Good" runat="server"  GroupName = "question5" Text = "Good"/>
                    &nbsp&nbsp
                    <asp:RadioButton ID="RadioBQ5Ex" runat="server"  GroupName = "question5" Text = "Excellent"/>                                        
                    <br />   
                    <br />                 
                </li>
            </ul>
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Submit" UseSubmitBehavior="True" />
            </div>  <!-- primary content end -->
    </form>
    <h3 style="color:White;"><asp:Literal ID="regMessage" runat="server" Visible="False" /></h3>
</body>
</html>

