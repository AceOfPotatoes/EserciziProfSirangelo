<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_82___Dati_studenti_sul_Web.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style="color: firebrick">Visualizzatore alunni di una determinata classe</h1>
            Classe: <asp:TextBox ID="txtClasse" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="plsInvia" runat="server" Text="INVIA PARAMETRO E FAMMI VISUALIZZARE GLI ALUNNI" OnClick="plsInvia_Click" />
        </div>
    </form>
</body>
</html>
