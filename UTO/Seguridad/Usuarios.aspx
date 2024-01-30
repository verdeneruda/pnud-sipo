<%@ Page Language="C#" MasterPageFile="~/MPMain.master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="UTO.Seguridad.Usuarios" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="titulo" >
        <tr>
            <td>
                <asp:Label ID="labelUsuarios" runat="server" Text="Seguridad - Usuarios" CssClass="subtitulo"></asp:Label>
            </td>
        </tr>
    </table>

    <table cellspacing="4" class="form">
    <tr>
    <td>
    <div style="color:Red;">
    <asp:Label ID="labelError" runat="server"></asp:Label>
    </div>
    </td>
    </tr>
</table>
<br />
<table cellspacing="4" class="form">
    <tr>
        <td >
            <asp:Label ID="labelNombre" runat="server" Text="Nombres" ></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="textNombre" runat="server" CssClass="texto1"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td >
            <asp:Label ID="labelLogin" runat="server" Text="Login" ></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="textLogin" runat="server" CssClass="texto2"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="labelPassword" runat="server" Text="Contraseña" ></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="textPassword" runat="server" CssClass="texto2" 
                TextMode="Password"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="labelPassword2" runat="server" Text="Confirmar contraseña" ></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="textPassword2" runat="server" CssClass="texto2" 
                TextMode="Password"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="labelUnidad" runat="server" Text="UTO / Regional" ></asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="comboUnidad" runat="server" CssClass="combo">
            </asp:DropDownList>
            
        </td>
    </tr>
   
    <tr>
        <td >
            <asp:Label ID="labelActivo" runat="server" Text="Activo" ></asp:Label>
        </td>
        <td>
            <asp:CheckBox ID="checkActivo" runat="server" />
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="labelGrupo" runat="server" Text="Grupos" ></asp:Label>
            </td>
        <td>
            <asp:CheckBoxList ID="checkboxlistGrupos" runat="server">
            </asp:CheckBoxList>
          </td>
      
    </tr>
   
        <tr>
        <td colspan="2" align="left">
            <asp:Button ID="buttonGuardar" runat="server" Text="Guardar" 
                onclick="buttonGuardar_Click" CssClass="button" /> &nbsp;&nbsp; 
            <asp:Button ID="ButtonCancelar" runat="server" Text="Cancelar" 
                onclick="ButtonCancelar_Click" CssClass="button" />
        </td>
    </tr>
    </table>
</asp:Content>

