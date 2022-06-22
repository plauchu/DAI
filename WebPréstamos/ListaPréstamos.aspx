<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListaPréstamos.aspx.cs" Inherits="WebPréstamos.ListaPréstamos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Lista de préstamos</title>
    <style type="text/css">
        #form1 {
            height: 381px;
        }
        .auto-style1 {
            width: 92%;
            z-index: 1;
            left: 42px;
            top: 213px;
            position: absolute;
            height: 62px;
        }
        .auto-style2 {
            width: 480px;
        }
        .auto-style3 {
            z-index: 1;
            left: 648px;
            top: 135px;
            position: absolute;
            height: 48px;
            width: 197px;
        }
        .auto-style4 {
            z-index: 1;
            left: 56px;
            top: 36px;
            position: absolute;
            height: 39px;
        }
        .auto-style5 {
            z-index: 1;
            left: 611px;
            top: 27px;
            position: absolute;
            height: 66px;
            width: 288px;
        }
        .auto-style6 {
            z-index: 1;
            left: 73px;
            top: 87px;
            position: absolute;
        }
        .auto-style7 {
            z-index: 1;
            top: 98px;
            position: absolute;
            left: 188px;
            height: 15px;
            width: 123px;
        }
        .auto-style8 {
            z-index: 1;
            left: 14px;
            top: 356px;
            position: absolute;
            width: 117px;
            height: 22px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" style="background-color: #FFFF00">
        <div style="background-color: #FF9900; height: 367px;">
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx" BackColor="#33CC33" CssClass="auto-style8">Página principal</asp:HyperLink>
            <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Text="Información de los préstamos de un cliente" BackColor="#9933FF" BorderColor="#6600CC" CssClass="auto-style4"></asp:Label>
            <asp:Table ID="TblCliente" runat="server" BorderStyle="Double" GridLines="Both" BackColor="#666699" CssClass="auto-style5">
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">RFC</asp:TableCell>
                    <asp:TableCell runat="server">Nombre</asp:TableCell>
                    <asp:TableCell runat="server">Domicilio</asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server"></asp:TableCell>
                    <asp:TableCell runat="server"></asp:TableCell>
                    <asp:TableCell runat="server"></asp:TableCell>
                </asp:TableRow>
            </asp:Table>
            <asp:DropDownList ID="DdlPréstamos" runat="server" AutoPostBack="True" BackColor="#FF3399" OnSelectedIndexChanged="DdlPréstamos_SelectedIndexChanged" CssClass="auto-style7">
            </asp:DropDownList>
            <asp:Label ID="Label2" runat="server" BackColor="White" style="margin-top: 13px" Text="Préstamos" CssClass="auto-style6"></asp:Label>
            <asp:Table ID="TblPréstamo" runat="server" BackColor="#99FF33" BorderStyle="Double" GridLines="Both" CssClass="auto-style3" HorizontalAlign="Justify">
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">Folio</asp:TableCell>
                    <asp:TableCell runat="server">Fecha</asp:TableCell>
                    <asp:TableCell runat="server">Monto</asp:TableCell>
                    <asp:TableCell runat="server">Total</asp:TableCell>
                    <asp:TableCell runat="server">Saldo</asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server"></asp:TableCell>
                    <asp:TableCell runat="server"></asp:TableCell>
                    <asp:TableCell runat="server"></asp:TableCell>
                    <asp:TableCell runat="server"></asp:TableCell>
                    <asp:TableCell runat="server"></asp:TableCell>
                </asp:TableRow>
            </asp:Table>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2" style="background-color: #00FFFF">
                        <asp:GridView ID="GrdAvales" runat="server" BackColor="Silver" EmptyDataText="Este préstamo no tiene aváles">
                        </asp:GridView>
                    </td>
                    <td style="background-color: #00FFFF">
                        <asp:GridView ID="GrdPagos" runat="server" BackColor="Silver" EmptyDataText="Este préstamo no tiene pagos">
                        </asp:GridView>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
