<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_78___Numero_in_lettere_WEB.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <h1 style ="color:red">Numero in lettere Web</h1>
            <h3><asp:Label ID="lblMessaggio" runat="server" Text=""></asp:Label></h3>
            <p>N:
                <asp:TextBox ID="txtN" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="plsLettere" runat="server" Text="NUMERO IN LETTERE" OnClick="plsLettere_Click" />
            </p>
            <p>
                RISULTATO:
                <asp:Label ID="lblRisultato" runat="server" Text=""></asp:Label>
            </p>

        </div>
    </form>
</body>
</html>
