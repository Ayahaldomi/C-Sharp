<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 1098px;
            margin-left: 115px;
        }
        .auto-style2 {
            width: 1097px;
            margin-left: 116px;
        }
    </style>
</head>
<body>
   
    <form id="form1" runat="server">
       
        <div class="auto-style2" style="padding: 10px; margin: 10px; border: 1px solid black">
            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>  
            &nbsp;  
            &nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="ID"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label10" runat="server" Text="Gender: "></asp:Label>
            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="gender" Text="Female" Val />
            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="gender" Text="Male" />
            <br />
            <asp:Label ID="Label13" runat="server" Text="Courses: "></asp:Label>
            <asp:CheckBox ID="CheckBox1" runat="server" Text="C" />
            <asp:CheckBox ID="CheckBox2" runat="server" Text="C++" />
            <asp:CheckBox ID="CheckBox3" runat="server" Text="C#" />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
            <br />
        </div>
<%--        <div id="help" style="margin: 10px; padding: 10px; border: 1px solid black;" class="auto-style1">
            <asp:Label ID="Label16" runat="server" Text="Personal Info"></asp:Label><br />
            <asp:Label ID="Label5" runat="server" Text="Name: "></asp:Label>
            <asp:Label ID="Label2" runat="server" Text=" "></asp:Label><br />
            <asp:Label ID="Label6" runat="server" Text="Email: "></asp:Label>
            <asp:Label ID="Label7" runat="server" Text=" "></asp:Label><br />
            <asp:Label ID="Label8" runat="server" Text="ID: "></asp:Label>
            <asp:Label ID="Label9" runat="server" Text=" "></asp:Label><br />
            <asp:Label ID="Label11" runat="server" Text="Gender: "></asp:Label>
            <asp:Label ID="Label12" runat="server" Text=" "></asp:Label><br />
            <asp:Label ID="Label14" runat="server" Text="Courses: "></asp:Label>
            <asp:Label ID="Label15" runat="server" Text=" "></asp:Label><br />
        </div>--%>

     
        
    </form>
</body>
</html>
