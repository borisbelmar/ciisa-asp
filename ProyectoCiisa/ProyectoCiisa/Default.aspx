<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ProyectoCiisa._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <section class="ciisa-body">
        <div class="container">
            <div class="row">
                <div class="col-md-4 col-md-offset-4 formulario">
                    <h3>Ingresar a CIISA TECH</h3>
                    <asp:TextBox ID="txtUsuario" runat="server" placeholder="Usuario"></asp:TextBox>
                    <asp:RequiredFieldValidator CssClass="error-validar" ID="validadorUsuario" runat="server" ErrorMessage="Porfavor ingrese Usuario" ControlToValidate="txtUsuario"></asp:RequiredFieldValidator>
        
                    <asp:TextBox ID="txtPassword" runat="server" placeholder="Contraseña" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator CssClass="error-validar" ID="validadorPassword"  runat="server" ErrorMessage="Porfavor ingrese Contraseña" ControlToValidate="txtPassword"></asp:RequiredFieldValidator>

                    <asp:Button ID="btnLogin" runat="server" Text="Ingresar" OnClick="btnLogin_Click" />
                </div>
            </div>
        </div>
    </section>
</asp:Content>