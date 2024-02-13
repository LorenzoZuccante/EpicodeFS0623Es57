<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LoginUtente.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="labels" runat="server" Text="Username"></asp:Label>
            <asp:TextBox ID="loginText" runat="server" placeholder="Inserisci il tuo username"></asp:TextBox>
            <asp:Button ID="loginBtn" runat="server" Text="Login" OnClick="loginBtn_Click" />
        </div>
    </form>
</body>
</html>
