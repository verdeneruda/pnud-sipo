    <%@ Page Language="C#" MasterPageFile="~/MPMain.Master" AutoEventWireup="true" CodeBehind="CertificacionesBuscar.aspx.cs" Inherits="UTO.ImportacionExportacion.CertificacionesBuscar" %>

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
    <asp:Label ID="labelBusquedaCertificaciones" runat="server" Text="Mòdulo importación y exportación - Buscar certificaciones" CssClass="subtitulo"></asp:Label>
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
    <asp:Label ID="labelNumeroRadicado" runat="server" Text="Número radicado" CssClass="label"></asp:Label>
    </td>
    <td>
    <asp:TextBox ID="textNumeroRadicado" runat="server"  CssClass="texto2"></asp:TextBox>
    </td>
    <td class="separador">
    <asp:Label ID="labelRadicado" runat="server" Text="Radicado por" CssClass="label"></asp:Label>
        </td>
    <td>
                                             <asp:TextBox ID="textRadicadopor" 
            runat="server" AutoPostBack="True" 
                                                 CssClass="texto2"></asp:TextBox>
    </td>
    <td>
        &nbsp;</td>
    </tr>
    <tr>

    <td>
    <asp:Label ID="labelfechaRadicado" runat="server" Text="Fecha radicado desde:" 
            CssClass="label"></asp:Label>
    </td>
    <td>
    <asp:TextBox ID="textFechaRadicadoDesde" runat="server" CssClass="texto2"></asp:TextBox>
    <cc1:CalendarExtender ID="calendarFechaRadicado" runat="server" 
            TargetControlID="textFechaRadicadoDesde" CssClass="calendar" 
            Format="dd/MM/yyyy">
    </cc1:CalendarExtender>
    </td>
    <td class="separador">
    <asp:Label ID="labelfechaRadicadoHasta" runat="server" Text="Hasta:" 
            CssClass="label"></asp:Label>
        </td>
    <td colspan="2">
    <asp:TextBox ID="textFechaRadicadoHasta" runat="server" CssClass="texto2"></asp:TextBox>
    <cc1:CalendarExtender ID="textFechaRadicadoHasta_CalendarExtender" runat="server" 
            TargetControlID="textFechaRadicadoHasta" CssClass="calendar" 
            Format="dd/MM/yyyy">
    </cc1:CalendarExtender>
    </td>
    </tr>
    <tr>
    <td>
    <asp:Label ID="labelImportador" runat="server" Text="Importador" CssClass="label"></asp:Label>
    </td>
    <td colspan="3">
                                             <asp:TextBox ID="textImportador" 
            runat="server" AutoPostBack="True" 
                                                 CssClass="texto2" Width="465px"></asp:TextBox>
    </td>
    <td>
                                             &nbsp;</td>
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
    <asp:GridView ID="gridBuscarCertificados" runat="server" CssClass="grilla" 
    HeaderStyle-CssClass="headergrilla" RowStyle-CssClass="rowgrilla" 
    SelectedRowStyle-CssClass="selectedgrilla" 
    FooterStyle-CssClass="footergrilla" 
    onrowcommand="gridBuscarCertificados_RowCommand" Width="649px" DataKeyNames="Id" 
            AllowPaging="True" DataSourceID="certificacionesBuscarDataSource" 
            PageSize="15" AutoGenerateColumns="False">
    <RowStyle CssClass="rowgrilla"></RowStyle>
        <Columns>
            <asp:ButtonField ButtonType="Button" CommandName="Ver" Text="Ver">
            <ControlStyle CssClass="buttongrilla" />
            </asp:ButtonField>
            <asp:ButtonField ButtonType="Button" CommandName="Modificar" Text="Modificar">
            <ControlStyle CssClass="buttongrilla" />
            </asp:ButtonField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button runat="server" ID="buttonEliminar" Text="Eliminar" CommandName="Eliminar" CommandArgument="<%# Container.DataItemIndex %>" OnClientClick="return confirm('Este registro se eliminará, desea continuar?')" CssClass="buttongrilla"/>
                </ItemTemplate>             
            </asp:TemplateField>
        
            <asp:BoundField DataField="Número radicado" HeaderText="Número radicado" 
                SortExpression="Número radicado" />
            <asp:BoundField DataField="Vigente" HeaderText="Vigente" ReadOnly="True" 
                SortExpression="Vigente" />
            <asp:BoundField DataField="Origen" HeaderText="Origen" 
                SortExpression="Origen" />
            <asp:BoundField DataField="Importador" HeaderText="Importador" 
                SortExpression="Importador" />
            <asp:BoundField DataField="Radicado por" HeaderText="Radicado por" 
                SortExpression="Radicado por" />
            <asp:BoundField DataField="Empresa" HeaderText="Empresa" 
                SortExpression="Empresa" />
            <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" 
                ReadOnly="True" SortExpression="Id" Visible="False" />
        </Columns>
    <FooterStyle CssClass="footergrilla"></FooterStyle>
    <SelectedRowStyle CssClass="selectedgrilla"></SelectedRowStyle>
    <HeaderStyle CssClass="headergrilla"></HeaderStyle>
    </asp:GridView>
        <asp:SqlDataSource ID="certificacionesBuscarDataSource" runat="server" 
            ConnectionString="<%$ ConnectionStrings:BDUTOConnectionString %>" 
            SelectCommand="exec [Iye].[spCertificacionBuscar] @radicado,@fechaInicial,@fechaFinal,@radicadopor,@importador">
            <SelectParameters>
                <asp:Parameter Name="radicado" />
                <asp:Parameter Name="fechaInicial" />
                <asp:Parameter Name="fechaFinal" />
                <asp:Parameter Name="radicadopor" />
                <asp:Parameter Name="importador" />
            </SelectParameters>
        </asp:SqlDataSource>
    </div>
    <br />
    </asp:Content>