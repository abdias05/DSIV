<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="frmProductos.aspx.cs"
    Inherits="Laboratorio203.frmProductos" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Productos</title>
</head>
<body>
    <form id="form1" runat="server">

        <asp:Label ID="lblMensaje" runat="server" ForeColor="Green"></asp:Label>
        <br /><br />

        <asp:Label Text="ID:" runat="server" />
        <asp:TextBox ID="txtId" runat="server" Enabled="false"></asp:TextBox>
        <br />

        <asp:Label Text="Nombre:" runat="server" />
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <br />

        <asp:Label Text="Precio:" runat="server" />
        <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox>
        <br />

        <asp:Label Text="Stock:" runat="server" />
        <asp:TextBox ID="txtStock" runat="server"></asp:TextBox>
        <br /><br />

        <asp:Label Text="Buscar por ID:" runat="server" />
        <asp:TextBox ID="txtBuscarId" runat="server"></asp:TextBox>
        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
        <br /><br />

        <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" OnClick="btnNuevo_Click" />
        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />

    </form>
</body>
</html>
