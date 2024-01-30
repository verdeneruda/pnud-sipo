<%@ Page Language="C#" MasterPageFile="~/MPMain.Master"  AutoEventWireup="true" CodeBehind="ReporteRegeneracionBuscar.aspx.cs" Inherits="UTO.Recuperacion.ReporteRegeneracionBuscar" %>

    <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

    <%@ Register src="../Comunes/ControlError.ascx" tagname="ControlError" tagprefix="uc1" %>

    <asp:Content  ID="contentSolicitudEquiposBuscar" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
        <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </cc1:ToolkitScriptManager>
    <div class="divwithoutgrid">
    <table class="titulo" >
        <tr><td>
        <asp:Label ID="labelBusquedaSolicitudesEquipos" runat="server" Text="Proyectos de dotación de equipos y herramientas  para el sector de refrigeración y aire acondicionado - Buscar reporte regeneración" CssClass="subtitulo"></asp:Label>
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
    <tr>
        <th colspan="4">   
        <asp:Label ID="labelparametros" runat="server" Text="Parámetros Búsqueda" CssClass="subtitulo"></asp:Label>
        </th>
    </tr>
    <tr>
    <td>
    <asp:Label ID="labelRegional" runat="server" Text="Centro Regeneración" 
            CssClass="label"></asp:Label>
    </td>
    <td colspan="3">
        <asp:DropDownList ID="comboCentroRegeneracion" runat="server" CssClass="combo" 
            DataTextField="cre_Descripcion" DataValueField="cre_Id">
        </asp:DropDownList>
    </td>
    </tr>
    <tr>
    <td>
        <asp:Label ID="labelNombreBeneficiario" runat="server" Text="Nombre beneficiario" CssClass="label"></asp:Label>
    </td>
    <td colspan="3">
        <asp:TextBox ID="textNombreBeneficiario" runat="server"  CssClass="texto2" 
            Width="518px"></asp:TextBox>
    </td>
    </tr>
    <tr>
        <td style="width:20%">
            <asp:Label ID="labelFechaInicial" runat="server" Text="Fecha inicial" CssClass="label"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="textFechaInicial" runat="server"  CssClass="texto2"></asp:TextBox>
            <cc1:CalendarExtender ID="calendarfecha" Format="dd/MM/yyyy"  runat="server" CssClass="calendar" TargetControlID="textFechaInicial">
            </cc1:CalendarExtender>
        </td>
        <td style="width:20%">
            <asp:Label ID="label1" runat="server" Text="Fecha final" CssClass="label"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="textFechaFinal" runat="server"  CssClass="texto2"></asp:TextBox>
            <cc1:CalendarExtender ID="CalendarExtender1" Format="dd/MM/yyyy"  runat="server" CssClass="calendar" TargetControlID="textFechaFinal">
            </cc1:CalendarExtender>
        </td>
     </tr>
    <tr>
    <td class="separador"></td>
    </tr>
    <tr>
    <td colspan="4">
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
    <asp:GridView ID="gridBuscarReporteUso" runat="server" CssClass="grilla" 
    HeaderStyle-CssClass="headergrilla" RowStyle-CssClass="rowgrilla" 
    SelectedRowStyle-CssClass="selectedgrilla" 
    FooterStyle-CssClass="footergrilla" onrowcommand="gridBuscarReporteUso_RowCommand" 
            DataKeyNames="Id" AllowPaging="True" 
            DataSourceID="reporteRegeneracionBuscarDataSource" PageSize="15" 
            AutoGenerateColumns="False">
    <RowStyle CssClass="rowgrilla"></RowStyle>

        <Columns>
            <asp:ButtonField ButtonType="Button" CommandName="Modificar" Text="Modificar">
            <ControlStyle CssClass="buttongrilla" />
            </asp:ButtonField>
            <asp:ButtonField ButtonType="Button" CommandName="Eliminar" Text="Eliminar">
            <ControlStyle CssClass="buttongrilla" />
            </asp:ButtonField>
            <asp:ButtonField ButtonType="Button" CommandName="Ver" Text="Ver">
            <ControlStyle CssClass="buttongrilla" />
            </asp:ButtonField>
        
            <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" 
                ReadOnly="True" SortExpression="Id" Visible="False" />
            <asp:BoundField DataField="Fecha" HeaderText="Fecha" SortExpression="Fecha" 
                DataFormatString="{0:dd/MM/yyyy}" />
            <asp:BoundField DataField="Beneficiario" HeaderText="Beneficiario" 
                SortExpression="Beneficiario" />
            <asp:BoundField DataField="Tipo gas" HeaderText="Tipo gas" 
                SortExpression="Tipo gas" />
            <asp:BoundField DataField="Cantidad entregada" HeaderText="Cantidad entregada" 
                SortExpression="Cantidad entregada (Kg)" DataFormatString="{0:#,##0.00}" >
            <ItemStyle HorizontalAlign="Right" />
            </asp:BoundField>
            <asp:BoundField DataField="Cantidad regenerada" 
                HeaderText="Cantidad regenerada" SortExpression="Cantidad regenerada" 
                DataFormatString="{0:#,##0.00}" >
            <ItemStyle HorizontalAlign="Right" />
            </asp:BoundField>
            <asp:BoundField DataField="Cantidad rechazada" HeaderText="Cantidad rechazada" 
                SortExpression="Cantidad rechazada" DataFormatString="{0:#,##0.00}" >
            <ItemStyle HorizontalAlign="Right" />
            </asp:BoundField>
        </Columns>

    <FooterStyle CssClass="footergrilla"></FooterStyle>

    <SelectedRowStyle CssClass="selectedgrilla"></SelectedRowStyle>

    <HeaderStyle CssClass="headergrilla"></HeaderStyle>
    </asp:GridView>
        <asp:SqlDataSource ID="reporteRegeneracionBuscarDataSource" runat="server" 
            ConnectionString="<%$ ConnectionStrings:BDUTOConnectionString %>" 
            SelectCommand="exec [Rrr].[spReporteCentroBuscar] @centro,@beneficiario,@fechaInicial,@fechaFinal">
            <SelectParameters>
                <asp:Parameter Name="centro" />
                <asp:Parameter Name="beneficiario" />
                <asp:Parameter Name="fechaInicial" />
                <asp:Parameter Name="fechaFinal" />
            </SelectParameters>
        </asp:SqlDataSource>
    </div>
    <br />
    </asp:Content>
