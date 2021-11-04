<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_84___Classifica_tennisti_sul_Web.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2 style="color: #008000">BENVENUTI NELLA CLASSIFICA INTERGALATTICISSIMA DEL TENNIS</h2>
            
            <asp:ListBox ID="lstTennisti" runat="server" Height="150px" Width="297px"></asp:ListBox>
            <br />
            <br />
            <asp:LinkButton ID="lnkModifica" runat="server" OnClick="lnkModifica_Click">MODIFICA TENNISTA
            </asp:LinkButton>
            <br />
            <asp:LinkButton ID="lnkRimuovi" runat="server" OnClick="lnkRimuovi_Click">RIMOZIONE TENNISTA</asp:LinkButton>
            <br />
            <br />
            <asp:LinkButton ID="lnkNuovo" runat="server" OnClick="lnkNuovo_Click">AGGIUNTA NUOVO TENNISTA</asp:LinkButton>
            <br />
        </div>
    </form>
</body>
</html>
