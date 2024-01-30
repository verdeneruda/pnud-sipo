<%@ Page Language="C#" MasterPageFile="~/MPMain.master" AutoEventWireup="true" CodeBehind="Grupos.aspx.cs" Inherits="UTO.Seguridad.Grupos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="titulo" >
        <tr>
            <td>
                <asp:Label ID="LabelGrupos" runat="server" Text="Seguridad - Grupos" CssClass="subtitulo"></asp:Label>
            </td>
        </tr>
    </table>

    <table cellspacing="4" class="form" >
    <tr>
    <td>
    <div style="color:Red">
    <asp:Label runat="server" ID="labelError"></asp:Label>
    </div>
    </td>
    </tr>
</table>
<br />
<table cellspacing="4" class="form" >
    <tr>
        <td >
            <asp:Label ID="labelNombreGrupo" runat="server" Text="Nombre del grupo" ></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="textNombreGrupo" runat="server" CssClass="texto2"></asp:TextBox>
        </td>
    
        <td>
            <asp:Label ID="labelActivo" runat="server" Text="Activo" ></asp:Label>
        </td>
        <td>
            <asp:CheckBox ID="checkActivo" runat="server" />
        </td>
    </tr>
    <tr>
    <td colspan="2">
    <asp:Label ID="labelUsuariosDisponibles" runat="server" Text="Usuarios disponibles" ></asp:Label>
    </td>
    <td>
    
    </td>
    <td>
    <asp:Label ID="labelUsuarioGrupos" runat="server" Text="Usuarios del grupo" ></asp:Label>
    </td>
    </tr>
    </table>
    
    <table cellspacing="4" class="form" width="700px">
    <tr>
    <td>
        <asp:ListBox ID="listboxUsuariosDisponibles" runat="server" 
            oninit="listboxUsuariosDisponibles_Init" ></asp:ListBox>
    </td>
    <td >
    <table><tr><td >  
        <asp:Button  ID="buttonAdicionar" runat="server" Text="Adicionar" 
            Width="82px" onclick="buttonAdicionar_Click" CssClass="button" /></td></tr><tr>
    <td>  
        <asp:Button ID="buttonEliminar" runat="server" Text="Eliminar" Width="82px" 
            onclick="buttonEliminar_Click" CssClass="button" /></td></tr></table>
      
    </td>
    <td>
        <asp:ListBox ID="listboxGrupos" runat="server"></asp:ListBox> 
    </td>
    </tr>
    <tr>
    <td colspan="3">
     <asp:Label ID="labelPermisos" runat="server" Text="Permisos" ></asp:Label>
    </td>
    </tr>
    <tr>
    <td colspan="3">
        <asp:TreeView ID="treeviewPermisos" runat="server" ShowCheckBoxes="Leaf" 
            oninit="treeviewPermisos_Init">
        </asp:TreeView>
    </td>
    </tr>
        <tr>
        <td colspan="3" align="left">
            <asp:Button ID="buttonGuardar" runat="server" Text="Guardar" 
                onclick="buttonGuardar_Click" CssClass="button" /> &nbsp;&nbsp; 
            <asp:Button ID="ButtonCancelar" runat="server" Text="Cancelar" 
                onclick="ButtonCancelar_Click" CssClass="button" />
        </td>
    </tr>
    </table>
</asp:Content>

<asp:Content ID="Content2" runat="server" contentplaceholderid="head">

    
</asp:Content>


