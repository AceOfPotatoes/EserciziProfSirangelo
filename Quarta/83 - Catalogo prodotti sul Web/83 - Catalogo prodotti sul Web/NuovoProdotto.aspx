<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NuovoProdotto.aspx.cs" Inherits="_83___Catalogo_prodotti_sul_Web.NuovoProdotto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2 style="color:blueviolet">Aggiungi un nuovo prodotto nella categoria:
                <asp:Label ID="lblCategoria" runat="server" ForeColor="#009900" Text=""></asp:Label>
            </h2>
            PRODOTTO:
            <asp:TextBox ID="txtProdotto" runat="server"></asp:TextBox>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;PREZZO:
            <asp:TextBox ID="txtPrezzo" runat="server"></asp:TextBox>
            <br />
            <br />
            PASSWORD:
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="plsAggiungi" runat="server" Text="AGGIUNGI" Width="219px" OnClick="plsAggiungi_Click" />
            <br />
            <br />
            Esito richiesta:
            <asp:Label ID="lblEsito" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:LinkButton ID="lnkHomepage" runat="server" OnClick="lnkHomepage_Click">TORNA ALLA HOMEPAGE</asp:LinkButton>
        </div>
    </form>
</body>
</html>
