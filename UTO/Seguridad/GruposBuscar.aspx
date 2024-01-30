<%@ Page Language="C#" MasterPageFile="~/MPMain.master" AutoEventWireup="true" CodeBehind="GruposBuscar.aspx.cs" Inherits="UTO.Seguridad.GruposBuscar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="titulo" >
        <tr>
            <td>
                <asp:Label ID="LabelBuscarGrupos" runat="server" Text="Seguridad - Buscar grupos" CssClass="subtitulo"></asp:Label>
            </td>
        </tr>
    </table>

    <table cellspacing="4" class="form" >
    <tr>
    <td>
    <div style="color:Red;">
    <asp:Label ID="labelError" runat="server"></asp:Label> 
    </div>
    </td>
    </tr>
</table>
<br />
<table cellspacing="4" class="form" >
   
    <tr>
        <td >
            <asp:GridView ID="gridBuscarGrupo" runat="server" CssClass="grilla" 
                onrowcommand="gridBuscarGrupo_RowCommand" 
                onrowdatabound="gridBuscarGrupo_RowDataBound" AllowPaging="True" 
                PageSize="15" DataKeyNames="GRU_ID" DataSourceID="SqlDataGrupo">
                <Columns>
                    <asp:ButtonField ButtonType="Button" CommandName="Modificar" Text="Modificar" >
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
           <tr>
    <td>
         <asp:Button ID="buttonBuscarGrupo" runat="server" Text="Buscar " 
             onclick="buttonBuscarGrupo_Click" CssClass="button" />&nbsp;&nbsp;<asp:Button 
             ID="buttonAdicionar" runat="server" Text="Adicionar " 
             onclick="buttonAdicionar_Click" CssClass="button" />
    </td>
    </tr>
        </table>
    <asp:SqlDataSource ID="SqlDataGrupo" runat="server" 
        ConnectionString="<%$ ConnectionStrings:BDUTOSeguridadConnectionString %>" 
        SelectCommand="SELECT GRU_ID,GRU_NOMBRE as GrupoNombre, case GRU_ACTIVO when 1 then 'Si' when 0 then 'No'end as GrupoEstado  FROM SEG_GRU_GRUPO"></asp:SqlDataSource>
</asp:Content>

