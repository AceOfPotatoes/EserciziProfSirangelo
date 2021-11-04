<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_76___Calcolatrice_Web.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblMessaggio" runat="server" Text=""></asp:Label>
            <br />
            <br />

            A:
            <asp:TextBox ID="txtA" runat="server"></asp:TextBox><br />
            B:
            <asp:TextBox ID="txtB" runat="server"></asp:TextBox><br />
            <br />
            <asp:Button ID="plsSomma" runat="server" Text="Somma" OnClick="plsSomma_Click" />
            <asp:Button ID="plsSottrazione" runat="server" Text="Sottrazione" OnClick="plsSottrazione_Click" />
            <asp:Button ID="plsMoltiplicazione" runat="server" Text="Moltiplicazione" OnClick="plsMoltiplicazione_Click" />
            <asp:Button ID="plsDivisione" runat="server" Text="Divisione" OnClick="plsDivisione_Click" />
            <asp:Button ID="plsPotenza" runat="server" Text="Elevamento a potenza" OnClick="plsPotenza_Click" />
            <br />
            <br />

            Risultato: 
            <asp:Label ID="lblRisultato" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:Button ID="plsReset" runat="server" Text="RESET" OnClick="plsReset_Click" />
            <br />
        </div>
    </form>
</body>
</html>
