<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SecondaPagina.aspx.cs" Inherits="_82___Dati_studenti_sul_Web.SecondaPagina" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    </head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3 style="color: blueviolet">In questa pagina verranno visualizzati gli alunni della classe: <asp:Label ID="lblClasse" runat="server" Text=""></asp:Label></h3>             

        </div>
        
        <asp:ListBox ID="lstAlunni" runat="server" Height="124px" Width="255px"></asp:ListBox>
        
    </form>
</body>
</html>
