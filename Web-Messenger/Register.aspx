<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Kabindra_Project_Web_III.Register" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title>Register</title>
	<style>
        body{
            background-color: #40f9f9;
        }
		.center{
            background-color: #aadd45;
            width: 60%;
            border-radius: 10px;
            display: flex;
            justify-content: center;
            text-align: center;
            margin: 0 auto; 
        }
		h2{
            background-color: #40f96f;
            border-radius: 10px;
            width: 100%;
            padding: 10px;
        }
		img{
            width: 20px;
        }
		#txtName,#txtUsername,#txtPassword,#txtFaculty,#txtSemister,#txtRoll,#txtEmail,#txtPhone,#txtGender,#txtDob{
			padding: 5px 0px 5px 10px;
		}
		#btnRegister{
			padding: 10px 40px 10px 40px;
            background-color: rebeccapurple;
            color: white;
			border: none;
		}
		#btnLogin{
            text-decoration: none;
            color: white;
            padding: 10px 60px 10px 60px;
            background-color: red;
            color: white;
            border-radius: 5px;
			border: none;
        }
	</style>
</head>
<body>
	<br /><br /><br />
	<div class="center">

	<form id="form1" runat="server">
		<br /><h2>Register</h2>
		<div>
			<img src="./image/Fname.png" alt=""/>
			<asp:TextBox runat="server" placeholder="Full Name" ID="txtName"  />
			<asp:Label ID="errName" runat="server" />
		</div>
		<br />
		<div>
			<img src="./image/user.png" alt=""/>
			<asp:TextBox runat="server" placeholder="Username" ID="txtUsername"  />
			<asp:Label ID="errUsername" runat="server" />
		</div>
		<br />
		<div>
			<img src="./image/padlock.png" alt=""/>
			<asp:TextBox runat="server" placeholder="********" ID="txtPassword"  />
			<asp:Label ID="errPassword" runat="server" />
		</div>
		<br />
		<div>
			<img src="./image/faculty.png" alt=""/>
			<asp:TextBox runat="server" placeholder="Faculty" ID="txtFaculty"  />
			<asp:Label ID="errFaculty" runat="server" />
		</div>
		<br />
		<div>
			<img src="./image/semister.png" alt=""/>
			<asp:TextBox runat="server" placeholder="Semister" ID="txtSemister"  />
			<asp:Label ID="Label1" runat="server" />
		</div>
		<br />
		<div>
			<img src="./image/rank.png" alt=""/>
			<asp:TextBox runat="server" placeholder="Roll" ID="txtRoll"  />
		</div>
		<br />
		<div>
			<img src="./image/email.png" alt=""/>
			<asp:TextBox runat="server" placeholder="Email" ID="txtEmail"  />
			<asp:Label ID="errEmail" runat="server" />
		</div>
		<br />
		<div>
			<img src="./image/phone.png" alt=""/>
			<asp:TextBox runat="server" placeholder="Phone Number" ID="txtPhone"  />
			<asp:Label ID="errPhone" runat="server" />
		</div>
		<br />
		<div>
			<img src="./image/gender.png" alt=""/>
			<asp:TextBox runat="server" placeholder="Gender" ID="txtGender"  />
			<asp:Label ID="errGender" runat="server" />
		</div>
		<br />
		<div>
			<img src="./image/calendar.png" alt=""/>
			<asp:TextBox runat="server" placeholder="Dob" ID="txtDob"  />
			<asp:Label ID="Label2" runat="server" />
		</div>
		<br />
		<div>
			<asp:Button Text="Register" ID="btnRegister" OnClick="btnRegister_Click" runat="server" />
			<br />
			<asp:Label ID="lblResult" runat="server" />
			<br />
			_____________________
			<br /><br />
			
			<asp:Button Text="Login" ID="btnLogin" OnClick="btnLogin_Click" runat="server" />
			
		</div>
		<br /><br />
	</form>
	</div>
</body>
</html>
