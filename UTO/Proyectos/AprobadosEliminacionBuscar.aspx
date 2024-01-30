    <%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MPMain.Master"  CodeBehind="AprobadosEliminacionBuscar.aspx.cs" Inherits="UTO.Proyectos.AprobadosEliminacionBuscar" %>
  
    
    <%@ Register src="../Comunes/ControlError.ascx" tagname="ControlError" tagprefix="uc1" %>
  
    
    <%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
  
    <asp:Content  ID="contentProyectosAprobadosBuscar" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
    
    <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
        </cc1:ToolkitScriptManager>
        
    <div class="divwithoutgrid">
    <table class="titulo" >
    <tr><td>
    <asp:Label ID="labelBusquedaProyectosAprobados" runat="server" 
            Text="Módulo proyectos aprobados de eliminación - Buscar proyectos aprobados de eliminación" 
            CssClass="subtitulo"></asp:Label>        
    </td></tr>
    </table>
    <br />
    <table class="form">
    <tr>
    <td>
    
        <uc1:ControlError ID="ControlError1" runat="server" />
    
    </td>
    </tr>
    </table>
    <table class="form">
    <tr>
    <td><table style="width:100%">
    <tr><th colspan="5">
    <asp:Label ID="labelparametros" runat="server" Text="Parámetros búsqueda" CssClass="subtitulo"></asp:Label>
    </th></tr>
    <tr>
    <td style="width:20%">
    <asp:Label ID="labelCodigo" runat="server" Text="Código proyecto" CssClass="label"></asp:Label>
    </td>
    <td>
    <asp:TextBox ID="textCodigo" runat="server" CssClass="texto2"></asp:TextBox>
    </td>
    <td class="separador"></td>
    <td style="width:20%">
    <asp:Label ID="labelNombreProyecto" runat="server" Text="Nombre proyecto" CssClass="label"></asp:Label>
    </td>
    <td>
    <asp:TextBox ID="textNombreProyecto" runat="server" CssClass="texto2"></asp:TextBox>
    </td>
    </tr>
    <tr>
    <td>
    <asp:Label ID="labelTipoProyecto" runat="server" Text="Tipo proyecto" CssClass="label"></asp:Label>
    </td>
    <td colspan="4">
    <asp:DropDownList ID="comboTipoProyecto" runat="server" CssClass="combo" DataTextField="pti_Descripcion" 
    DataValueField="pti_Id" Width="530px">
    </asp:DropDownList>
    &nbsp;
    &nbsp;
    </td>
    </tr>
    <tr>
    <td colspan="5">
    <asp:Button ID="buttonBuscar" runat="server" Text="Buscar" CssClass="button" 
            onclick="buttonBuscar_Click" />&nbsp;&nbsp;
    <asp:Button ID="buttonAdicionar" runat="server" Text="Adicionar"  
    CssClass="button" onclick="buttonAdicionar_Click"/>&nbsp;&nbsp;
    <asp:Button ID="buttonExportar" runat="server" Text="Exportar"  
    CssClass="button" onclick="buttonExportar_Click"/>
    </td>
    </tr>
    </table>
    </td>
    </tr>
    </table>
    </div>
    <br />
    <div class="divgrillas">
    <asp:GridView ID="gridBuscarProyectos" runat="server" CssClass="grilla" 
    HeaderStyle-CssClass="headergrilla" RowStyle-CssClass="rowgrilla" 
    SelectedRowStyle-CssClass="selectedgrilla" 
    FooterStyle-CssClass="footergrilla" 
            onrowcommand="gridBuscarProyectos_RowCommand" DataKeyNames="Id" 
            AllowPaging="True" DataSourceID="aprobadosEliminacionBuscarDataSource" 
            PageSize="15" AutoGenerateColumns="False">
    <RowStyle CssClass="rowgrilla"></RowStyle>
        <Columns>
            <asp:ButtonField CommandName="Modificar" ShowHeader="True" 
            Text="Modificar" ButtonType="Button" >
            <ControlStyle CssClass="buttongrilla" />
            </asp:ButtonField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button runat="server" ID="buttonEliminar" Text="Eliminar" CommandName="Eliminar" CommandArgument="<%# Container.DataItemIndex %>" OnClientClick="return confirm('Este registro se eliminará, desea continuar?')" CssClass="buttongrilla"/>
                </ItemTemplate> 
            </asp:TemplateField>
            <asp:ButtonField ButtonType="Button" CommandName="Ver" 
            ShowHeader="True" Text="Ver">
            <ControlStyle CssClass="buttongrilla" />
            </asp:ButtonField>
        
            <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" 
                ReadOnly="True" SortExpression="Id" Visible="False" />
            <asp:BoundField DataField="Nombre del proyecto" 
                HeaderText="Nombre del proyecto" SortExpression="Nombre del proyecto" />
            <asp:BoundField DataField="Código" HeaderText="Código" 
                SortExpression="Código" />
            <asp:BoundField DataField="Agencia" HeaderText="Agencia" 
                SortExpression="Agencia" />
            <asp:BoundField DataField="Compañía" HeaderText="Compañía" 
                SortExpression="Compañía" />
            <asp:BoundField DataField="Departamento" HeaderText="Departamento" 
                SortExpression="Departamento" />
            <asp:BoundField DataField="Municipio" HeaderText="Municipio" 
                SortExpression="Municipio" />
            <asp:BoundField DataField="Fecha aprobación" DataFormatString="{0:d/M/yyyy}" 
                HeaderText="Fecha aprobación" SortExpression="Fecha aprobación" />
            <asp:BoundField DataField="Fecha terminación" DataFormatString="{0:d/M/yyyy}" 
                HeaderText="Fecha terminación" SortExpression="Fecha terminación" />
            <asp:BoundField DataField="Fecha terminación real" 
                DataFormatString="{0:d/M/yyyy}" HeaderText="Fecha terminación real" 
                SortExpression="Fecha terminación real" />
        </Columns>

    <FooterStyle CssClass="footergrilla"></FooterStyle>

    <SelectedRowStyle CssClass="selectedgrilla"></SelectedRowStyle>

    <HeaderStyle CssClass="headergrilla"></HeaderStyle>
    </asp:GridView>
        <asp:SqlDataSource ID="aprobadosEliminacionBuscarDataSource" runat="server" 
            ConnectionString="<%$ ConnectionStrings:BDUTOConnectionString %>" 
            SelectCommand="exec [Pro].[spProyectoBuscar] @codigo,@nombre,@tipo">
            <SelectParameters>
                <asp:Parameter Name="codigo" />
                <asp:Parameter Name="nombre" />
                <asp:Parameter Name="tipo" />
            </SelectParameters>
        </asp:SqlDataSource>
    </div>
    <br />
    </asp:Content>


