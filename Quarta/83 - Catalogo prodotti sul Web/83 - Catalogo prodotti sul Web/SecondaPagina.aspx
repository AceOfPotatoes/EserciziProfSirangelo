<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SecondaPagina.aspx.cs" Inherits="_83___Catalogo_prodotti_sul_Web.SecondaPagina" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style="color: #008000">Qui visualizzerai i tuoi prodotti di categoria:
                <asp:Label ID="lblCategoria" runat="server" ForeColor="#CC3300" Text=""></asp:Label>
            </h1>
            <asp:ListBox ID="lstProdotti" runat="server" Height="135px" Width="352px"></asp:ListBox>
            <br />
            <br />
            <asp:LinkButton ID="lnkHomepage" runat="server" OnClick="lnkHomepage_Click">TORNA ALLA HOMEPAGE</asp:LinkButton>
        </div>
    </form>
</body>
</html>
