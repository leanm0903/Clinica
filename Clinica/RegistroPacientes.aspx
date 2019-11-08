<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="RegistroPacientes.aspx.cs" Inherits="Clinica.Contacto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="jumbotron col-8 mx-auto pt-0 text-center">
        <form>
            <label>DNI</label>
            <asp:TextBox runat="server" ID="DNI" CssClass="form-control"> </asp:TextBox>
            <label>Nombre</label>
            <asp:TextBox runat="server" ID="Nombre" CssClass="form-control"></asp:TextBox>
            <label>Apellido</label>
            <asp:TextBox runat="server" ID="Apellido" CssClass="form-control"></asp:TextBox>
            <label>Edad</label>
            <asp:TextBox runat="server" ID="Edad" CssClass="form-control"></asp:TextBox>
            <label>Telefono</label>
            <asp:TextBox runat="server" ID="Telefono" CssClass="form-control"></asp:TextBox>
            <label>Direccion</label>
            <asp:TextBox runat="server" ID="Direccion" CssClass="form-control"></asp:TextBox>
            <asp:Button Text="Registrar" runat="server" CssClass="col-6  btn btn-success mt-3" OnClick="Btn_registrar" />   
        </form>
        </div>
    
</asp:Content>
