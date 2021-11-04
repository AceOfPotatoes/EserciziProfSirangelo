<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NuovoTennista.aspx.cs" Inherits="_84___Classifica_tennisti_sul_Web.NuovoTennista" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style="color: darkred">NUOVO TENNISTA</h1>
            Nominativo: 
            <asp:TextBox ID="txtNominativo" runat="server"></asp:TextBox>
            <br />
&nbsp;&nbsp; Punteggio:
            <asp:TextBox ID="txtPunteggio" runat="server"></asp:TextBox>
            <br />
            <br />
            Password:
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="plsAggiungi" runat="server" Text="AGGIUNGI NUOVO TENNISTA" OnClick="plsAggiungi_Click" />
            <asp:Button ID="plsAnnulla" runat="server" Text="ANNULLA" OnClick="plsAnnulla_Click" />
            <br />
            <br />
            Esito richiesta:
            <asp:Label ID="lblEsito" runat="server" Text=""></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
