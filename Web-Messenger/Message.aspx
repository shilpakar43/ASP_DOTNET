<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Message.aspx.cs" Inherits="Kabindra_Project_Web_III.Message" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Message</title>
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
        #lblUsername{
            font-size:60px;
            padding-right:50%
        }
        #btnLogOut{
            padding:10px 20px 10px 20px;
            background-color:yellow;
            border:none;
            border-radius:4px;
        }
        .divMessanger{
            width:70%;
            height:900px;
            background-color:deeppink;
            float:left;
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
            text-align:center;
        }
        #lblChattingWith{
            text-align:center;
            color:aqua;
            font-size:30px;
        }
        #txtsearchUsername,#txtMessage{
            padding: 10px 30px 10px 30px;
        }
        #btnSearchUsername,#btnSend,#btnRefresh{
            padding: 10px 40px 10px 40px;
            background-color: rebeccapurple;
            color: white;
            border:none;
            border-radius:8px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        

        <div class="divDashboard" >
            <a href="Dashboard.aspx"><img src="./image/userprofile.png" /></a>            
            <asp:Label ID="lblUsername" runat="server" />
            <asp:Button Text="Log Out" ID="btnLogOut" OnClick="btnLogOut_Click" runat="server" />

        </div>

        <div class="divMessanger">
            <div class="divSendMessage">
                <center>
                    <p class="pChatWith">MESSANGER</p>
                    <br /><br />
                    
                    <asp:Label ID="lblChattingWith" runat="server" />
                    <br />
                    <asp:TextBox ID="txtMessage" placeholder="Type Message" runat="server" />
                    &nbsp;&nbsp;&nbsp;
                    <asp:Button Text="Refresh" ID="btnRefresh" OnClick="btnRefresh_Click" runat="server" />
                    <br /><br />
                    <asp:Button Text="Send" ID="btnSend" OnClick="btnSend_Click" runat="server" />
                    <br />
                    <asp:Label ID="lblResult" runat="server" />
                </center>
            </div>
            <br /><br /><br />

            <div class="divReadMessage">
                <center>
                    <asp:GridView runat="server" AutoGenerateColumns="false" ID="gridBookList">
                        <Columns>
                            <asp:BoundField DataField="sender" HeaderText="SEnder" />
                            <asp:BoundField DataField="txtmessage" HeaderText="Message" />
                        </Columns>
                    </asp:GridView>
                </center>
            </div>
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
