<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModificaPunteggio.aspx.cs" Inherits="_84___Classifica_tennisti_sul_Web.ModificaPunteggio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>STAI MODIFICANDO IL TENNISTA: 
            <asp:Label ID="lblNominativo" runat="server" ForeColor="#6600CC"></asp:Label></h2>
            Nuovo punteggio:
            <asp:TextBox ID="txtNuovoPunteggio" runat="server"></asp:TextBox>
            <br />
            <br />
            Password:
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="plsModifica" runat="server" Text="MODIFICA TENNISTA" OnClick="plsModifica_Click" />
            <asp:Button ID="plsAnnulla" runat="server" Text="ANNULLA" OnClick="plsAnnulla_Click" />
            <br />
            <br />
            Esito richiesta:
            <asp:Label ID="lblEsito" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
