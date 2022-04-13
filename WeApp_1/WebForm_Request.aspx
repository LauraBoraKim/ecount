<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm_Request.aspx.cs" Inherits="WeApp_1.WebForm_Request" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            아이디:<asp:TextBox ID="userid" runat="server"></asp:TextBox><br />

            암호:<asp:TextBox ID="password" runat="server"></asp:TextBox><br />

            이름:<asp:TextBox ID="name" runat="server"></asp:TextBox><br />

            나이:<asp:TextBox ID="age" runat="server"></asp:TextBox><br />

            <asp:Button ID="btnsubmit" runat="server" Text="전송" OnClick="btnsubmit_Click"  />
        </div>
    </form>
    <asp:Label ID="userdata" runat="server" Text="Label"></asp:Label><br />
    <asp:Label ID="userdata2" runat="server" Text="Label"></asp:Label>
</body>
</html>
