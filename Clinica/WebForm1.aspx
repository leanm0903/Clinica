<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Clinica.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <title></title>
   
</head>
<body >
   
        <div class="col-8  mx-auto">
            <div class="bg-dark col-10 mx-auto">
                <form runat="server">
                    <label class="text-light">Usuario</label>
                    <asp:TextBox runat="server" id="txtUsuario" CssClass="form-control" />  
                    <label class="text-light">Contraseña</label>
                    <asp:TextBox runat="server" id="txtPassword" CssClass="form-control" />  
                    <asp:Button Text="Aceptar" runat="server" CssClass="btn btn-primary" ID="btnAceptar" OnClick="btnAceptar_Click"/>

                </form>                    
            </div>
        </div>
    
</body>
</html>
