<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_77___Tabellina_Web.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Tabellina WEB<br />
            <asp:Label ID="lblMessaggio" runat="server" Text=""></asp:Label>
            <br />
            <br />
            Numero:
            <asp:TextBox ID="txtN" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="plsMostra" runat="server" Text="MOSTRA TABELLINA" BackColor="#FF3300" ForeColor="White" OnClick="plsMostra_Click" />
            <br />
            <br />
            Tabellina:
            <asp:Label ID="lblTabellina" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
