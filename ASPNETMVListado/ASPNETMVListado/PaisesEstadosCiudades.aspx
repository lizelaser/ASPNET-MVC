<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaisesEstadosCiudades.aspx.cs" Inherits="ASPNETMVListado.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            Pais:</div>
        <asp:DropDownList ID="dropPais" runat="server" AutoPostBack="True" OnSelectedIndexChanged="PaisSeleccionado">
        </asp:DropDownList>
        <p>
            Estado:</p>
        <asp:DropDownList ID="dropEstado" runat="server" AutoPostBack="True" OnSelectedIndexChanged="EstadoSeleccionado">
        </asp:DropDownList>
        <p>
            Ciudad:</p>
        <asp:DropDownList ID="dropCiudad" runat="server" AutoPostBack="True" OnSelectedIndexChanged="CiudadSeleccionado" style="height: 22px">
        </asp:DropDownList>
    </form>
</body>
</html>
