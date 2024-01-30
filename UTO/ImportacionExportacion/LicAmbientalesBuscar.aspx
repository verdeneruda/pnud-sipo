    <%@ Page Language="C#" MasterPageFile="~/MPMain.Master" AutoEventWireup="true" CodeBehind="LicAmbientalesBuscar.aspx.cs" Inherits="UTO.ImportacionExportacion.LicAmbientalesBuscar" %>

    <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

    <%@ Register src="../Comunes/ControlError.ascx" tagname="ControlError" tagprefix="uc1" %>

    <asp:Content ID="contentImportacionExportacionLicAmbientalesBuscarHead" ContentPlaceHolderID="head" Runat="Server">
    </asp:Content>
    <asp:Content  ID="contentImportacionExportacionLicAmbientalesBuscar" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
        <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </cc1:ToolkitScriptManager>
    <div class="divwithoutgrid">
    <table class="titulo" >
    <tr><td>
    <asp:Label ID="labelBuscarLicenciasAmbientales" runat="server" Text="Mòdulo importación y exportación - Buscar licencias medio ambientales" CssClass="subtitulo"></asp:Label>
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
    <td>
    <asp:Label ID="labelEmpresa" runat="server" Text="Empresa" CssClass="label"></asp:Label>
    </td>
    <td>
    <asp:TextBox ID="textEmpresa" runat="server" CssClass="texto2" Width="300px"></asp:TextBox>
    </td>
    <td class="separador"></td>
    <td>
    <asp:Label ID="labelNumeroResolucion" runat="server" Text="Resolución" 
            CssClass="label"></asp:Label>
    </td>
    <td>
    <asp:TextBox ID="textnumeroRadicacion" runat="server" CssClass="texto2"></asp:TextBox>
    </td>
    </tr>
    <tr>
    <td>
                 <asp:Label ID="labelSustancia" runat="server" CssClass="label" 
            Text="Sustancia" Visible="False"></asp:Label>
    </td>
    <td colspan="4">
                 <asp:DropDownList ID="comboSustancia" runat="server" CssClass="combo" 
                     DataTextField="sus_Descripcion" DataValueField="sus_Id" 
                     Width="195px" Visible="False">
                 </asp:DropDownList>
    </td>

    </tr>
    <tr>
    <td colspan="5">
    <asp:Button ID="buttonBuscar" runat="server" Text="Buscar" CssClass="button" 
            onclick="buttonBuscar_Click" />&nbsp;&nbsp;
    <asp:Button ID="buttonAdicionar" runat="server" Text="Adicionar"  
    CssClass="button" onclick="buttonAdicionar_Click"/>
    </td>
    </tr>
    </table>
    </td>
    </tr>
    </table>
    </div>
    <br />
    <div class="divgrillas">
    <asp:GridView ID="gridBuscarLicenciasAmbientales" runat="server" CssClass="grilla" 
    HeaderStyle-CssClass="headergrilla" RowStyle-CssClass="rowgrilla" 
    SelectedRowStyle-CssClass="selectedgrilla" 
    FooterStyle-CssClass="footergrilla" 
            onrowcommand="gridBuscarLicenciasAmbientales_RowCommand" DataKeyNames="Id" 
            AllowPaging="True" DataSourceID="licAmbientalesBuscarDataSource" 
            PageSize="15" AutoGenerateColumns="False">
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
    
        <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" 
            ReadOnly="True" SortExpression="Id" Visible="False" />
        <asp:BoundField DataField="Resolucion" HeaderText="Resolucion" 
            SortExpression="Resolucion" />
        <asp:BoundField DataField="Fecha licencia" HeaderText="Fecha licencia" 
            SortExpression="Fecha licencia" DataFormatString="{0:d/M/yyyy}" />
        <asp:BoundField DataField="Empresa" HeaderText="Empresa" 
            SortExpression="Empresa" />
    </Columns>
    <FooterStyle CssClass="footergrilla"></FooterStyle>
    <SelectedRowStyle CssClass="selectedgrilla"></SelectedRowStyle>
    <HeaderStyle CssClass="headergrilla"></HeaderStyle>
    </asp:GridView>
        <asp:SqlDataSource ID="licAmbientalesBuscarDataSource" runat="server" 
            ConnectionString="<%$ ConnectionStrings:BDUTOConnectionString %>" 
            SelectCommand="exec [Iye].[spLicenciaBuscar] @resolucion,@empresa,@sustancia">
            <SelectParameters>
                <asp:Parameter Name="resolucion" />
                <asp:Parameter Name="empresa" />
                <asp:Parameter Name="sustancia" />
            </SelectParameters>
        </asp:SqlDataSource>
    </div>
    <br />
    </asp:Content>