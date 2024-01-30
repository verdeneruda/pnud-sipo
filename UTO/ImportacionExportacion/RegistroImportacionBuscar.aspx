    <%@ Page Language="C#" MasterPageFile="~/MPMain.Master" AutoEventWireup="true" CodeBehind="RegistroImportacionBuscar.aspx.cs" Inherits="UTO.ImportacionExportacion.RegistroImportacionBuscar" %>

    <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

    <%@ Register src="../Comunes/ControlError.ascx" tagname="ControlError" tagprefix="uc1" %>

    <asp:Content ID="contentImportacionExportacionCertificacionesBuscarHead" ContentPlaceHolderID="head" Runat="Server">
    </asp:Content>
    <asp:Content  ID="contentImportacionExportacionCertificacionesBuscar" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
    <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </cc1:ToolkitScriptManager>
    <asp:XmlDataSource ID="xmlRegistroImportador" runat="server" 
    DataFile="~/App_Data/RegistrosImportadores.xml"></asp:XmlDataSource>
    <asp:XmlDataSource ID="XmlImportadores" runat="server" 
    DataFile="~/App_Data/Importadores.xml"></asp:XmlDataSource>
    <asp:XmlDataSource ID="XmlSustancia" runat="server" 
    DataFile="~/App_Data/Sustancia.xml"></asp:XmlDataSource>   
    <asp:XmlDataSource ID="XmlPaises" runat="server" 
    DataFile="~/App_Data/Paises.xml"></asp:XmlDataSource>      
    <div class="divwithoutgrid">
    <table class="titulo" >
    <tr><td>
    <asp:Label ID="labelBusquedaCertificaciones" runat="server" Text="Mòdulo importación y exportación - Buscar registro importación" CssClass="subtitulo"></asp:Label>
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
    <tr><th colspan="4">
    <asp:Label ID="labelparametros" runat="server" Text="Parámetros búsqueda" CssClass="subtitulo"></asp:Label>
    </th></tr>
    <tr>

    <td colspan="4">
                  <asp:RadioButton ID="RadioSustancia" runat="server" AutoPostBack="True" 
                      oncheckedchanged="RadioSustancia_CheckedChanged" Text="Sustancia" 
                      GroupName="TipoImportacion" />
                  <asp:RadioButton ID="RadioEquipos" runat="server" Text="Equipos" 
                      AutoPostBack="True" GroupName="TipoImportacion" 
                      oncheckedchanged="RadioEquipos_CheckedChanged" />
    </td>
    </tr>
    <tr>

    <td>
    <asp:Label ID="labelLicenciaImportacion" runat="server" Text="Licencia importación" 
            CssClass="label"></asp:Label>
    </td>
    <td>
    <asp:TextBox ID="textLicenciaImportacion" runat="server"  CssClass="texto2"></asp:TextBox>
    </td>
    <td class="separador">
    <asp:Label ID="labelImportador" runat="server" Text="Importador" CssClass="label"></asp:Label>
        </td>
    <td>
    <asp:TextBox ID="textImportador" runat="server"  CssClass="texto2" Width="289px"></asp:TextBox>
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
                 <asp:Label ID="labelSustancia" runat="server" CssClass="label" 
            Text="Sustancia" Visible="False"></asp:Label>
    </td>
    <td>
                 <asp:DropDownList ID="comboSustancia" runat="server" CssClass="combo" 
                     DataTextField="sus_Descripcion" DataValueField="sus_Id" 
                     Width="153px" onselectedindexchanged="RadioSustancia_CheckedChanged" 
                     Visible="False">
                 </asp:DropDownList>
    </td>
    <td class="separador">
                 &nbsp;</td>
    <td>
                 &nbsp;</td>
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
        &nbsp;&nbsp;
    </td>
    </tr>
    </table>
    </td>
    </tr>
    </table>
    </div>
    <br />
    <div class="divgrillas">
    <asp:GridView ID="gridBuscarRegistroImportadores" runat="server" CssClass="grilla" 
    HeaderStyle-CssClass="headergrilla" RowStyle-CssClass="rowgrilla" 
    SelectedRowStyle-CssClass="selectedgrilla" 
    FooterStyle-CssClass="footergrilla" 
            onrowcommand="gridBuscarRegistroImportadores_RowCommand" DataKeyNames="Id" 
            AllowPaging="True" DataSourceID="registroImportacionBuscarDataSource" 
            PageSize="15" AutoGenerateColumns="False">
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
        
            <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" 
                ReadOnly="True" SortExpression="Id" Visible="False" />
            <asp:BoundField DataField="Número registro" HeaderText="Número registro" 
                ReadOnly="True" SortExpression="Número registro" />
            <asp:BoundField DataField="Visto bueno" HeaderText="Visto bueno" 
                ReadOnly="True" SortExpression="Visto bueno" />
            <asp:BoundField DataField="Fecha vigencia" HeaderText="Fecha vigencia" 
                ReadOnly="True" SortExpression="Fecha vigencia" 
                DataFormatString="{0:d/M/yyyy}" />
            <asp:BoundField DataField="Importador" HeaderText="Importador" ReadOnly="True" 
                SortExpression="Importador" />
            <asp:BoundField DataField="Exportador" HeaderText="Exportador" ReadOnly="True" 
                SortExpression="Exportador" />
            <asp:BoundField DataField="Puerto de embarque" HeaderText="Puerto de embarque" 
                ReadOnly="True" SortExpression="Puerto de embarque" />
            <asp:BoundField DataField="Aduana" HeaderText="Aduana" ReadOnly="True" 
                SortExpression="Aduana" />
        </Columns>
    <FooterStyle CssClass="footergrilla"></FooterStyle>
    <SelectedRowStyle CssClass="selectedgrilla"></SelectedRowStyle>
    <HeaderStyle CssClass="headergrilla"></HeaderStyle>
    </asp:GridView>
        <asp:SqlDataSource ID="registroImportacionBuscarDataSource" runat="server" 
            ConnectionString="<%$ ConnectionStrings:BDUTOConnectionString %>" 
            SelectCommand="exec [Iye].[spRegistroImportacionBuscar] @licencia,@importador,@fechaInicial,@fechaFinal,@sustancia,@tipo">
            <SelectParameters>
                <asp:Parameter Name="licencia" />
                <asp:Parameter Name="importador" />
                <asp:Parameter Name="fechaInicial" />
                <asp:Parameter Name="fechaFinal" />
                <asp:Parameter Name="sustancia" />
                <asp:Parameter Name="tipo" />
            </SelectParameters>
        </asp:SqlDataSource>
    </div>
    <br />
    </asp:Content>