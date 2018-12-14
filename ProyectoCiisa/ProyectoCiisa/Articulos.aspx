<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Articulos.aspx.cs" Inherits="ProyectoCiisa._Articulos" %>

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
        <div class="formulario">
            <h3>Ingreso de Articulos</h3>
            <asp:TextBox ID="txtNombreArticulo" runat="server" placeholder="Nombre del Artículo"></asp:TextBox>
            <asp:RequiredFieldValidator CssClass="error-validar" ID="validadorNombreArticulo" runat="server" ErrorMessage="Porfavor ingrese Nombre de Artículo" ControlToValidate="txtNombreArticulo"></asp:RequiredFieldValidator>
        
            <asp:TextBox ID="txtSKU" runat="server" placeholder="SKU"></asp:TextBox>
            <asp:RequiredFieldValidator CssClass="error-validar" ID="validadorSKU"  runat="server" ErrorMessage="Porfavor ingrese SKU" ControlToValidate="txtSKU"></asp:RequiredFieldValidator>

            <asp:Button ID="btnArticulo" runat="server" Text="Ingresar"/>
        </div>
    </form>
</body>
</html>
