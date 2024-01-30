    <%@ Page Language="C#" MasterPageFile="~/MPMain.Master" AutoEventWireup="true" CodeFile="RegistroExportacionBuscar.aspx.cs" Inherits="ImportacionExportacion_RegistroExportacionBuscar" %>

    <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

    <%@ Register src="../Comunes/ControlError.ascx" tagname="ControlError" tagprefix="uc1" %>

    <asp:Content ID="contentImportacionExportacionCertificacionesBuscarHead" ContentPlaceHolderID="head" Runat="Server">
    </asp:Content>
    <asp:Content  ID="contentImportacionExportacionCertificacionesBuscar" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
    <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </cc1:ToolkitScriptManager>
    <div class="divwithoutgrid">
    <table class="titulo" >
    <tr><td>
    <asp:Label ID="labelBusquedaCertificaciones" runat="server" Text="Módulo importación y exportación - Buscar registro exportación" CssClass="subtitulo"></asp:Label>
    </td></tr>
    </table>    
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
    <tr><th colspan="4">
    <asp:Label ID="labelparametros" runat="server" Text="Parámetros búsqueda" CssClass="subtitulo"></asp:Label>
    </th></tr>
    <tr>
    <td>
    <asp:Label ID="labelLicenciaExportacion" runat="server" Text="Licencia exportación" 
            CssClass="label"></asp:Label>
    </td>
    <td>
    <asp:TextBox ID="textLicenciaExportacion" runat="server"  CssClass="texto2"></asp:TextBox>
    </td>
    <td class="separador">
    <asp:Label ID="labelExportador" runat="server" Text="Exportador" CssClass="label"></asp:Label>
        </td>
    <td>
    <asp:TextBox ID="textExportador" runat="server"  CssClass="texto2" Width="289px" 
            ontextchanged="textImportador_TextChanged"></asp:TextBox>
        </td>
    </tr>
    <tr>

    <td>
    <asp:Label ID="labelfechaLicenciaInicial" runat="server" Text="Fecha inicial licencia" 
            CssClass="label"></asp:Label>
    </td>
    <td>
            <asp:TextBox ID="textFechaInicial" runat="server"  CssClass="texto2"></asp:TextBox>
            <cc1:CalendarExtender ID="calendarfecha" Format="dd/MM/yyyy"  runat="server" CssClass="calendar" TargetControlID="textFechaInicial">
            </cc1:CalendarExtender>
    </td>
    <td class="separador">
    <asp:Label ID="labelfechaLicenciaFinal" runat="server" Text="Fecha final licencia" 
            CssClass="label"></asp:Label>
        </td>
    <td>
            <asp:TextBox ID="textFechaFinal" runat="server"  CssClass="texto2"></asp:TextBox>
            <cc1:CalendarExtender ID="CalendarExtender1" Format="dd/MM/yyyy"  runat="server" CssClass="calendar" TargetControlID="textFechaFinal">
            </cc1:CalendarExtender>
    </td>
    </tr>
    <tr>
    <td>
                 <asp:Label ID="labelOrigen" runat="server" CssClass="label" 
                Text="País origen"></asp:Label>
    </td>
    <td>
                 <asp:DropDownList ID="comboOrigen" runat="server" CssClass="combo" 
                     DataTextField="pas_Descripcion" DataValueField="pas_Id" 
                     Width="169px">
                 </asp:DropDownList>
    </td>
    <td class="separador">
                 <asp:Label ID="labelSustancia" runat="server" CssClass="label" 
            Text="Sustancia"></asp:Label>
    </td>
    <td>
                 <asp:DropDownList ID="comboSustancia" runat="server" CssClass="combo" 
                     DataTextField="sus_Descripcion" DataValueField="sus_Id" 
                     Width="169px">
                 </asp:DropDownList>
        </td>
    </tr>
    <tr>
    <td>
                 &nbsp;</td>
    <td>
                 &nbsp;</td>
    <td class="separador">
            &nbsp;</td>
    <td>
            &nbsp;</td>
    </tr>
    <tr>
    <td colspan="4">
    <asp:Button ID="buttonBuscar" runat="server" Text="Buscar" CssClass="button" 
            onclick="buttonBuscar_Click" />&nbsp;<asp:Button ID="buttonAdicionar" runat="server" Text="Adicionar"  
    CssClass="button" onclick="buttonAdicionar_Click"/>
        &nbsp;
        <asp:Button ID="buttonImportar" runat="server" Text="Importar"  
    CssClass="button" OnClick="buttonImportar_Click"/>
    </td>
    </tr>
    </table>
    </td>
    </tr>
    </table>
    </div>
    <div class="divgrillas">
    <asp:GridView ID="gridBuscarRegistroExportadores" runat="server" CssClass="grilla" 
    HeaderStyle-CssClass="headergrilla" RowStyle-CssClass="rowgrilla" 
    SelectedRowStyle-CssClass="selectedgrilla" 
    FooterStyle-CssClass="footergrilla" 
            onrowcommand="gridBuscarRegistroExportadores_RowCommand" DataKeyNames="Id" 
            AllowPaging="True" DataSourceID="registroExportacionBuscarDataSource" 
            PageSize="15">
    <RowStyle CssClass="rowgrilla"></RowStyle>
        <Columns>
            <asp:ButtonField ButtonType="Button" CommandName="Modificar" ShowHeader="True" 
                Text="Modificar">
            <ControlStyle CssClass="buttongrilla" />
            </asp:ButtonField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button runat="server" ID="buttonEliminar" Text="Eliminar" CommandName="Eliminar" CommandArgument="<%# Container.DataItemIndex %>" OnClientClick="return confirm('Este registro se eliminará, desea continuar?')" CssClass="buttongrilla"/>
                </ItemTemplate>             
            </asp:TemplateField>
            <asp:ButtonField ButtonType="Button" CommandName="Ver" Text="Ver">
            <ControlStyle CssClass="buttongrilla" />
            </asp:ButtonField>
        </Columns>
    <FooterStyle CssClass="footergrilla"></FooterStyle>
    <SelectedRowStyle CssClass="selectedgrilla"></SelectedRowStyle>
    <HeaderStyle CssClass="headergrilla"></HeaderStyle>
    </asp:GridView>
        <asp:SqlDataSource ID="registroExportacionBuscarDataSource" runat="server" 
            ConnectionString="<%$ ConnectionStrings:BDUTOConnectionString %>" 
            SelectCommand="exec [Iye].[spRegistroExportacionBuscar] @licencia,@importador,@fechaInicial,@fechaFinal,@sustancia,@pais">
            <SelectParameters>
                <asp:Parameter Name="licencia" />
                <asp:Parameter Name="importador" />
                <asp:Parameter Name="fechaInicial" />
                <asp:Parameter Name="fechaFinal" />
                <asp:Parameter Name="sustancia" />
                <asp:Parameter Name="pais" />
            </SelectParameters>
        </asp:SqlDataSource>
    </div>
    </asp:Content>