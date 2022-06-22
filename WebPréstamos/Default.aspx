<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebPréstamos.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Aplicación de préstamos</title>
    <style type="text/css">
        #form1 {
            height: 381px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" style="background-color: #FFFF00">
        <div style="background-color: #C0C0C0; height: 363px;">
            <asp:Login ID="Login1" runat="server" LoginButtonText="Ingresar" OnAuthenticate="Login1_Authenticate" PasswordLabelText="Contraseña" RememberMeText="Recordarme." style="z-index: 1; left: 406px; top: 68px; position: absolute; height: 195px; width: 232px" TitleText="Ingreso" UserNameLabelText="Usuario:" BackColor="Yellow">
                <FailureTextStyle BackColor="#FF0066" BorderColor="#996600" BorderStyle="Double" />
                <TextBoxStyle BackColor="#CC33FF" />
            </asp:Login>
        </div>
    </form>
</body>
</html>
