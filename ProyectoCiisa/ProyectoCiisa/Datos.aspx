<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Datos.aspx.cs" Inherits="ProyectoCiisa._Datos" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <section class="ciisa-body">
        <div class="container">
            <div class="row">
                <div class="col-md-3">
                    <div class="menu">
                        <h3>Menú</h3>
                        <a class="button" href="Vendedores.aspx" target="formularios"><i class="fas fa-caret-right"></i>  Vendedores</a>
                        <a class="button" href="Articulos.aspx" target="formularios"><i class="fas fa-caret-right"></i>  Artículos</a>
                    </div>
                </div>
                <div class="col-md-4 col-md-offset-3">
                    <iframe name="formularios" onLoad="calcHeight();" allowtransparency="true" id="iframes" width="100%" height="0px"></iframe>
                </div> 
            </div>
        </div>
    </section>
</asp:Content>