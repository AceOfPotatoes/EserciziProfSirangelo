<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_83___Catalogo_prodotti_sul_Web.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-weight: bold;
            font-size: x-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        &nbsp;<span class="auto-style1">Benvenuto nel catalogo prodotti di: &quot;Avimu tuttu&quot;</span><br />
            <br />
            Scegli categoria prodotti:
            <asp:DropDownList ID="ddlCategorie" runat="server">
            </asp:DropDownList>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Prezzo limite:
            <asp:TextBox ID="txtLimite" runat="server" Width="99px"></asp:TextBox>

            <br />
            <br />
            <asp:Button ID="plsVisualizza" runat="server" Text="FAMMI VISUALIZZARE I PRODOTTI" Width="261px" OnClick="plsVisualizza_Click" />

            <br />
            <asp:LinkButton ID="lnkNuovoProdotto" runat="server" OnClick="lnkNuovoProdotto_Click">NUOVO PRODOTTO</asp:LinkButton>

            <br />

        </div>
    </form>
</body>
</html>
