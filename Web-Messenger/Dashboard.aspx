<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="Kabindra_Project_Web_III.Dashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Dashboard</title>
    <style>
        *{
            margin:0;
            padding:0;
        }
        .divDashboard{
            width:100%;
            height:220px;
            background-color:red;
        }
        img{
            width:100px;
            padding:50px 100px 20px 50px;
        }
        #lblText{
            font-size:60px;
            padding-right:50%
        }
        #btnLogOut{
            padding:10px 20px 10px 20px;
            background-color:yellow;
            border:none;
            border-radius:4px;
        }
        .divProfile{
            width:70%;
            height:900px;
            background-color:deeppink;
            float:left;
        }
        .h2MyProfile{
            text-align:center;
            color:aqua;
            font-size:30px;
        }
        .divOnline{
            width:29.99%;
            height:900px;
            background-color:blue;
            float:left;
            text-align:center;
        }
        .pChatWith{
            background-color: #aadd45;
            padding:20px 60px 20px 60px;
            font-size:60px;
            color: white;
        }
        #txtsearchUsername{
            padding: 10px 30px 10px 30px;
        }
        #btnSearchUsername{
            padding: 10px 40px 10px 40px;
            background-color: rebeccapurple;
            color: white;
            border:none;
            border-radius:8px;
        }
        .cssOnline{
            padding:90px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        
        <div class="divDashboard" >
            <img src="./image/userprofile.png" />
            <asp:Label ID="lblText" runat="server" />

                <asp:Button Text="Log Out" ID="btnLogOut" OnClick="btnLogOut_Click" runat="server" />

        </div>

        <div class="divProfile" >
            <center>
                <br /><br /><br />
                <h2 class="h2MyProfile">My Profile</h2>
                <br /><br /><br />
                

                <asp:GridView runat="server" AutoGenerateColumns="false" ID="idDisplayProfile">
                    <Columns>
                        <asp:BoundField DataField="name" HeaderText="Name" />
                        <asp:BoundField DataField="username" HeaderText="Username" />
                        <asp:BoundField DataField="faculty" HeaderText="Faculty" />
                        <asp:BoundField DataField="semister" HeaderText="Semister" />
                        <asp:BoundField DataField="roll" HeaderText="Roll" />
                        <asp:BoundField DataField="email" HeaderText="Email" />
                        <asp:BoundField DataField="phone" HeaderText="Phone" />
                        <asp:BoundField DataField="gender" HeaderText="Gender" />
                        <asp:BoundField DataField="dob" HeaderText="DOB" />
                    </Columns>
                </asp:GridView>
            </center>
        </div>
        

        <div class="divOnline">
            
            <p class="pChatWith">CHAT WITH</p>
            <br />
            <asp:TextBox ID="txtsearchUsername" placeholder="Enter Username to Chat" runat="server" />
            <br /><br />
            <asp:Button ID="btnSearchUsername" Text="Message" OnClick="btnSearchUsername_Click" runat="server" />
            <br />
            <asp:Label ID="errSearchUsername" runat="server"/>
            <br />

            <center>
            <asp:GridView runat="server" AutoGenerateColumns="false" ID="idOnline">
                <Columns>
                    <asp:BoundField DataField="username" HeaderText="Online" />
                </Columns>
            </asp:GridView>
            </center>
            <asp:Label ID="errOnline" runat="server" />
        </div>
        


    </form>

    
</body>
</html>