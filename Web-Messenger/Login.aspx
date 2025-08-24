<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Kabindra_Project_Web_III.Login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Log In</title>
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
            width: 99%;
            padding: 10px;
        }
        img{
            width: 20px;
        }
        #txtUsername,#txtPassword{
            padding: 5px 0px 5px 5px;
        }
        #btnLogIn{
            padding: 10px 40px 10px 40px;
            background-color: rebeccapurple;
            color: white;
            border: none;
        }
        #btnRegister{
            border:none;
            text-decoration: none;
            color: white;
            padding: 10px 60px 10px 60px;
            background-color: red;
            color: white;
        }
    </style>
</head>
<body>
    <br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/>
    <div class="center">
    <form id="form1" runat="server"  style="background-color: #aadd45;">
        
        <h2>Log In</h2>
        <br /><br />
        <div>
            <img src="./image/user.png" alt=""/>
            <asp:TextBox ID="txtUsername" runat="server" placeholder="Username"/>
            <asp:Label ID="errUsername" runat="server" />
        </div>
        <br />
        <div>
            <img src="./image/padlock.png" alt=""/>
            <asp:TextBox ID="txtPassword" runat="server" placeholder="********"/>
            <asp:Label ID="errPassword" runat="server" />
        </div>
        <br />
        <div>
            <asp:Button Text="Log In" ID="btnLogIn" OnClick="btnLogIn_Click" runat="server" />
            <asp:Label ID="lblResult" runat="server" />
            <br/><br/>
            
            Forgot Password? <a href="#">Click Here</a>
            <br>

            ________________
            <br/><br/><br/>
            <asp:Button Text="Register" ID="btnRegister" OnClick="btnRegister_Click" runat="server" />
            <br /><br />
        </div>
    </form>
        </div>
</body>
</html>
