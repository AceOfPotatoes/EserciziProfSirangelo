<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_81___Frasi_simpatiche_sul_Web.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:center">
            <h2 style="color:mediumvioletred">ARCHIVIO FRASI SIMPATICISSIME ASSOLUTAMENTE DA LEGGERE!!!!!!!!</h2>
            <br />
            FILTRO FRASI
            <br />
            <asp:TextBox ID="txtFiltro" runat="server" Width="574px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="plsFiltra" runat="server" Text="VISUALIZZA SOLO FRASI CONTENENTI FILTRO" Width="577px" OnClick="plsFiltra_Click" />
            <br />
            <br />
            <asp:ListBox ID="lstFrasi" runat="server" style="margin-left: 0px" Width="1165px" Height="237px"></asp:ListBox>
            <br />
            <br />
            <asp:Button ID="plsElimina" runat="server" Text="ELIMINA FRASE" OnClick="plsElimina_Click" />
            <br />
            <br />
            NUOVA FRASE<br />
            <asp:TextBox ID="txtFrase" runat="server" Width="574px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="plsAggiungi" runat="server" Text="AGGIUNGI AL FANTASTICO ARCHIVIO" Width="577px" OnClick="plsAggiungi_Click" />
            <br />
            <br />
            </div>
    </form>
</body>
</html>
