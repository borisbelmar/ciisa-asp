<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Vendedores.aspx.cs" Inherits="ProyectoCiisa._Vendedores" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <asp:PlaceHolder runat="server">
        <%: Scripts.Render("~/bundles/modernizr") %>
    </asp:PlaceHolder>

    <webopt:bundlereference runat="server" path="~/Content/css" />
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.5.0/css/all.css" integrity="sha384-B4dIYHKNBt8Bc12p+WXckhzcICo0wtJAoU8YZTY5qE0Id1GSseTk6S+L3BlXeVIU" crossorigin="anonymous">
</head>
<body style="padding-top: 0px; background-color:transparent;">
    <form id="formVendedores" runat="server">
        <asp:ScriptManager runat="server">
            <Scripts>
                <%--To learn more about bundling scripts in ScriptManager see https://go.microsoft.com/fwlink/?LinkID=301884 --%>
                <%--Framework Scripts--%>
                <asp:ScriptReference Name="MsAjaxBundle" />
                <asp:ScriptReference Name="jquery" />
                <asp:ScriptReference Name="bootstrap" />
                <asp:ScriptReference Name="WebForms.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebForms.js" />
                <asp:ScriptReference Name="WebUIValidation.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebUIValidation.js" />
                <asp:ScriptReference Name="MenuStandards.js" Assembly="System.Web" Path="~/Scripts/WebForms/MenuStandards.js" />
                <asp:ScriptReference Name="GridView.js" Assembly="System.Web" Path="~/Scripts/WebForms/GridView.js" />
                <asp:ScriptReference Name="DetailsView.js" Assembly="System.Web" Path="~/Scripts/WebForms/DetailsView.js" />
                <asp:ScriptReference Name="TreeView.js" Assembly="System.Web" Path="~/Scripts/WebForms/TreeView.js" />
                <asp:ScriptReference Name="WebParts.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebParts.js" />
                <asp:ScriptReference Name="Focus.js" Assembly="System.Web" Path="~/Scripts/WebForms/Focus.js" />
                <asp:ScriptReference Name="WebFormsBundle" />
                <%--Site Scripts--%>
            </Scripts>
        </asp:ScriptManager>
        <div class="formulario consultas">
            <h3>Ingreso de Vendedores</h3>

            <asp:TextBox ID="txtID" runat="server" placeholder="ID"></asp:TextBox>
            <%-- <asp:RequiredFieldValidator CssClass="error-validar" ID="validadorID" runat="server" ErrorMessage="Porfavor ingrese ID" ControlToValidate="txtID"></asp:RequiredFieldValidator> --%>

            <asp:TextBox ID="txtUsuario" runat="server" placeholder="Usuario"></asp:TextBox>
            <%-- <asp:RequiredFieldValidator CssClass="error-validar" ID="validadorUsuario" runat="server" ErrorMessage="Porfavor ingrese Usuario" ControlToValidate="txtUsuario"></asp:RequiredFieldValidator> --%>
        
            <asp:TextBox ID="txtPassword" runat="server" placeholder="Contraseña"></asp:TextBox>
            <%-- <asp:RequiredFieldValidator CssClass="error-validar" ID="validadorPassword"  runat="server" ErrorMessage="Porfavor ingrese Contraseña" ControlToValidate="txtPassword"></asp:RequiredFieldValidator> --%>

            <asp:TextBox ID="txtCorreo" runat="server" placeholder="Correo"></asp:TextBox>
            <%-- <asp:RequiredFieldValidator CssClass="error-validar" ID="validadorCorreo" runat="server" ErrorMessage="Porfavor ingrese Correo" ControlToValidate="txtCorreo"></asp:RequiredFieldValidator> --%>

            <asp:TextBox ID="txtFono" runat="server" placeholder="Teléfono"></asp:TextBox>
            <%-- <asp:RequiredFieldValidator CssClass="error-validar" ID="validadorFono" runat="server" ErrorMessage="Porfavor ingrese Teléfono" ControlToValidate="txtFono"></asp:RequiredFieldValidator> --%>

            <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" OnClick="btnIngresar_Click"/>
            <asp:Button CssClass="consultar" ID="btnConsultar" runat="server" Text="Consultar por ID" OnClick="btnConsultar_Click"/>
            <asp:Button CssClass="actualizar" ID="btnActualizar" runat="server" Text="Actualizar por ID" OnClick="btnActualizar_Click"/>
            <asp:Button CssClass="eliminar" ID="btnEliminar" runat="server" Text="Eliminar por ID" OnClick="btnEliminar_Click"/>
        </div>
    </form>
</body>
</html>
