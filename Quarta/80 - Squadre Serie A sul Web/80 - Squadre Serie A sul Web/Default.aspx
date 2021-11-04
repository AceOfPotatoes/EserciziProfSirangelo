<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_80___Squadre_Serie_A_sul_Web.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:center">
            <h1 style="color:orangered"">FORMAZIONI SERIE A SUL WEB</h1>
            <asp:DropDownList ID="ddlSquadre" runat="server" Width="216px"></asp:DropDownList>
            <br /> <br />
            <asp:Button ID="plsVisualizza" runat="server" Text="VISUALIZZA" OnClick="plsVisualizza_Click" Width="213px" />
            <br />
            <br />
            <asp:ListBox ID="lstFormazione" runat="server" Height="150px" Width="211px"></asp:ListBox>
            <br />
            <br />
            <br />
            Cognome<br />
            <asp:TextBox ID="txtCognome" runat="server" style="margin-left: 0px" Width="198px"></asp:TextBox>
            <br />
            <br />
            Nome<br />
            <asp:TextBox ID="txtNome" runat="server" style="margin-left: 0px" Width="198px"></asp:TextBox>
            <br />
            <br />
            Numero<br />
            <asp:TextBox ID="txtNumero" runat="server" style="margin-left: 0px" Width="198px"></asp:TextBox>
            <br />
            <br />
            Squadra<br />
            <asp:TextBox ID="txtSquadra" runat="server" style="margin-left: 0px" Width="198px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="plsAggiungi" runat="server" Text="AGGIUNGI" Width="213px" OnClick="plsAggiungi_Click" />
        </div>
        
    </form>
</body>
</html>
