<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_79___Squadra_appartenenza_giocatori_sul_Web.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center">
            <asp:Label ID="lblMessaggio" runat="server" Font-Bold="True" Font-Size="X-Large"></asp:Label>
            
            <br />
            <br />
            Nominativo calciatore:
            <asp:TextBox ID="txtNominativo" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="plsRicerca" runat="server" Text="RICERCA SQUADRA APPARTENENZA" OnClick="plsRicerca_Click" />
            <br />
            <br />
            Squadra appartenenza: <asp:Label ID="lblSquadra" runat="server" Text=""></asp:Label>
            
        </div>
    </form>
</body>
</html>
