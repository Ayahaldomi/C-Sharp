<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="calculater.aspx.cs" Inherits="WebApplication2.calculater" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Result: "></asp:Label>
            <asp:Label ID="Result" runat="server" Text=" "></asp:Label><br />
            <asp:Label ID="Label3" runat="server" Text="Input Number 1: "></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Input Number 2: "></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />

            <asp:Button ID="Button1" runat="server" Text="+" Height="95px" Width="95px" OnClick="Button1_Click" BackColor="Lime" Font-Size="XX-Large" />
            &nbsp;
            <asp:Button ID="Button2" runat="server" Text="-" Height="95px" Width="95px" BackColor="#0066FF" Font-Size="XX-Large" OnClick="Button2_Click" />
            &nbsp;
            <asp:Button ID="Button3" runat="server" Text="*" Height="95px" Width="95px" BackColor="Red" Font-Size="XX-Large" OnClick="Button3_Click" />
        </div>
    </form>
</body>
</html>
