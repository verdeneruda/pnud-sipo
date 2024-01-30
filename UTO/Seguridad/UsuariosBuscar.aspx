<%@ Page Language="C#" MasterPageFile="~/MPMain.master" AutoEventWireup="true" CodeBehind="UsuariosBuscar.aspx.cs" Inherits="UTO.Seguridad.BuscarUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table class="titulo" >
        <tr>
            <td>
                <asp:Label ID="LabelBuscarUsuarios" runat="server" Text="Seguridad - Buscar usuarios" CssClass="subtitulo"></asp:Label>
            </td>
        </tr>
    </table>

    <table class="form">
    <tr>
    <td>
        <div style="color:Red;">
        <asp:Label runat="server" ID="labelError"></asp:Label>
        </div>
    </td>
    </tr>
</table>
<br />
<table class="form">
    <tr>
        <td >
            <asp:Label ID="labelNombreUsuario" runat="server" Text="Login" ></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="textNombreUsuario" runat="server" CssClass="texto2"></asp:TextBox>
        </td>
        <td>
              <asp:Label ID="labelNombres" runat="server" Text="Nombres" ></asp:Label></td>
        <td>
            <asp:TextBox ID="textNombres" runat="server" CssClass="texto2"></asp:TextBox></td>
    
    </tr>
    
   
    <tr>
        <td >
        <asp:Label ID="labelModulo" runat="server" Text="Módulo" ></asp:Label>
        </td>
        <td>
            
            <asp:DropDownList ID="comboModulo" runat="server" CssClass="texto2" 
                oninit="comboModulo_Init">
            </asp:DropDownList>
            
        </td>
        <td>
            <asp:Label ID="labelGrupo" runat="server" Text="Grupo" ></asp:Label>
        </td>
        <td>
            
            <asp:DropDownList ID="comboGrupo" runat="server" CssClass="texto2" 
                oninit="comboGrupo_Init">
            </asp:DropDownList>
            
        </td>
    
    </tr>
    
   
    <tr>
    <td colspan="4">
         <asp:Button ID="buttonBuscar" runat="server" Text="Buscar " 
             onclick="buttonBuscar_Click" CssClass="button" />&nbsp;&nbsp;<asp:Button 
             ID="buttonAdicionar" runat="server" Text="Adicionar " 
             onclick="buttonAdicionar_Click" CssClass="button" />
    </td>
    </tr>
   
    <tr>
        <td colspan="4" >
            <asp:GridView ID="gribuscarusuario" runat="server" CssClass="grilla" 
                onrowcommand="gribuscarusuario_RowCommand" 
                onrowdatabound="gribuscarusuario_RowDataBound" AllowPaging="True" 
                PageSize="15" DataSourceID="SqlDataUsuario">
                <Columns>
                    <asp:ButtonField ButtonType="Button" CommandName="Actualizar" 
                        Text="Modificar" >
                    <ControlStyle CssClass="buttongrilla" />
                    </asp:ButtonField>
                    <asp:ButtonField ButtonType="Button" CommandName="Eliminar" Text="Eliminar" >
                    <ControlStyle CssClass="buttongrilla" />
                    </asp:ButtonField>
                    <asp:ButtonField ButtonType="Button" CommandName="Ver" Text="Ver" >
                    <ControlStyle CssClass="buttongrilla" />
                    </asp:ButtonField>
                </Columns>
            </asp:GridView>
            </td>
       
      
    </tr>
   
        </table>
    <asp:SqlDataSource ID="SqlDataUsuario" runat="server" 
        ConnectionString="<%$ ConnectionStrings:BDUTOSeguridadConnectionString %>" ></asp:SqlDataSource>
</asp:Content>

