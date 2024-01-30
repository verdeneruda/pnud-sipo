    <%@ Page Language="C#" MasterPageFile="~/MPMain.Master" AutoEventWireup="true" CodeBehind="ImportadoresBuscar.aspx.cs" Inherits="UTO.RegistrosUso.ImportadoresBuscar" %>
    <asp:Content ID="contentBuscarRegistroUsoImportadoresHead" ContentPlaceHolderID="head" Runat="Server">
    </asp:Content>
    <asp:Content  ID="contentBuscarRegistroUsoImportadores" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
        <asp:XmlDataSource ID="xmlCliente" runat="server" 
    DataFile="~/App_Data/empresas.xml"></asp:XmlDataSource>
    <asp:XmlDataSource ID="xmlSustancia" runat="server" 
    DataFile="~/App_Data/Sustancia.xml"></asp:XmlDataSource>
    <asp:XmlDataSource ID="xmlBusqueda" runat="server" 
    DataFile="~/App_Data/MRegistrosUsoImportadoresBusqueda.xml"></asp:XmlDataSource>
    <div class="divwithoutgrid">
    <table class="titulo" >
    <tr><td>
    <asp:Label ID="labelBusquedaRegistrosUsoImportadores" runat="server" Text="Módulo registro de usos - Buscar registros reportados por importadores" CssClass="subtitulo"></asp:Label>
    </td></tr>
    </table>
    <br />
    <table class="form">
    <tr>
    <td><table style="width:100%">
    <tr><th colspan="5">
    <asp:Label ID="labelparametros" runat="server" Text="Parámetros búsqueda" CssClass="subtitulo"></asp:Label>
    </th></tr>
    <tr>
    <td style="width:20%">
    <asp:Label ID="labelcliente" runat="server" Text="Importador" CssClass="label"></asp:Label>
    </td>
    <td>
    <asp:DropDownList ID="Combocliente" runat="server" CssClass="combo" DataTextField="ter_NombreCompleto" 
    DataValueField="ter_Id">
    </asp:DropDownList>
    </td>
    <td class="separador"></td>
    <td style="width:20%">
    <asp:Label ID="labelSustancia" runat="server" Text="Sustancia" CssClass="label"></asp:Label>
    </td>
    <td>
    <asp:DropDownList ID="ComboSustancia" runat="server" CssClass="combo" 
            DataTextField="sus_Descripcion" DataValueField="sus_Id">
    </asp:DropDownList>
    </td>
    </tr>
    <tr>
        <td style="width:20%">
    <asp:Label ID="label1" runat="server" Text="Año" CssClass="label"></asp:Label>
    </td>
    <td colspan="4">
        <asp:TextBox ID="textAnno" runat="server"></asp:TextBox>
    </asp:DropDownList>
    </tr>
    <tr>
    <td colspan="5">
    <asp:Button ID="buttonBuscar" runat="server" Text="Buscar" CssClass="button" 
            onclick="buttonBuscar_Click" />&nbsp;&nbsp;
    <asp:Button ID="buttonAdicionar" runat="server" Text="Adicionar"  CssClass="button" 
            onclick="buttonAdicionar_Click"/>
    </td>
    </tr>
    </table>
    </td>
    </tr>
    </table>
    </div>
    <br />
    <div class="divgrillas">
    <asp:GridView ID="gridBuscarSustanciasReportadasImportadores" runat="server" CssClass="grilla" 
    HeaderStyle-CssClass="headergrilla" RowStyle-CssClass="rowgrilla"  AutoGenerateColumns="False" 
    SelectedRowStyle-CssClass="selectedgrilla" 
    FooterStyle-CssClass="footergrilla" 
            onrowcommand="gridBuscarSustanciasReportadasImportadores_RowCommand" 
            DataKeyNames="Id" AllowPaging="True" 
            DataSourceID="importadoresBuscarDataSource" PageSize="15">
    <RowStyle CssClass="rowgrilla"></RowStyle>
    <Columns>
    <asp:ButtonField ButtonType="Button" CommandName="Ver" 
    ShowHeader="True" Text="Ver">
    <ControlStyle CssClass="buttongrilla" />
    </asp:ButtonField>
    <asp:ButtonField CommandName="Modificar" ShowHeader="True" 
    Text="Modificar" ButtonType="Button" >
    <ControlStyle CssClass="buttongrilla" />
    </asp:ButtonField>
    <asp:TemplateField>
    <ItemTemplate>
    <asp:Button runat="server" ID="buttonEliminar" Text="Eliminar" CommandName="Eliminar" CommandArgument="<%# Container.DataItemIndex %>" OnClientClick="return confirm('Este registro se eliminará, desea continuar?')" CssClass="buttongrilla"/>
    </ItemTemplate>    
    </asp:TemplateField>                
        <asp:BoundField DataField="Año" HeaderText="Año" 
        SortExpression="Cliente" />
    <asp:BoundField DataField="Cliente" HeaderText="Importador" 
    SortExpression="Cliente" />
    <asp:BoundField DataField="Sustancia" HeaderText="Sustancia" 
    SortExpression="Sustancia" />
    <asp:BoundField DataField="Cantidad" HeaderText="Cantidad (Kg)" 
    SortExpression="Cantidad" DataFormatString="{0:#,##0.00}" >
        <ItemStyle HorizontalAlign="Right" />
        </asp:BoundField>
    <asp:BoundField DataField="Aplicacion" HeaderText="Aplicacion" 
    SortExpression="Aplicacion" />
        <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" 
            Visible="False" />
    </Columns>

    <FooterStyle CssClass="footergrilla"></FooterStyle>

    <SelectedRowStyle CssClass="selectedgrilla"></SelectedRowStyle>

    <HeaderStyle CssClass="headergrilla"></HeaderStyle>
    </asp:GridView>
        <asp:SqlDataSource ID="importadoresBuscarDataSource" runat="server" 
            ConnectionString="<%$ ConnectionStrings:BDUTOConnectionString %>" 
            SelectCommand="exec [Rus].[spImportadoresBuscar] @idEmpresa,@idSustancia,@anno">
            <SelectParameters>
                <asp:Parameter Name="idEmpresa" />
                <asp:Parameter Name="idSustancia" />
                <asp:Parameter Name="anno" />
            </SelectParameters>
        </asp:SqlDataSource>
    </div>
    <br />
    </asp:Content>
