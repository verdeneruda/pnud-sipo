    <%@ Page Language="C#" MasterPageFile="~/MPMain.Master"  AutoEventWireup="true" CodeBehind="ProductosConsultas.aspx.cs" Inherits="UTO.DisposicionFinal.ProductosConsultas" %>

    <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
    <%@ Register src="../Comunes/ControlError.ascx" tagname="ControlError" tagprefix="uc1" %>
    <asp:Content ID="contentModuloDisposicionFinalConsultasHead" ContentPlaceHolderID="head" Runat="Server">
    </asp:Content>
    <asp:Content  ID="contentModuloDisposicionFinalConsultas" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
    <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </cc1:ToolkitScriptManager>
    <asp:XmlDataSource ID="xmlTipoConsulta" runat="server" 
    DataFile="~/App_Data/MDisposicionFinalTipoConsulta.xml"></asp:XmlDataSource>
    <div class="divwithoutgrid">
    <table class="titulo" >
    <tr><td>
    <asp:Label ID="labelConsultas" runat="server" Text="Módulo disposición final - Consultas" CssClass="subtitulo"></asp:Label>
    </td></tr>
    </table>
    <table class="form">
        <tr>
            <td>            
                <uc1:ControlError ID="ControlError1" runat="server" />            
            </td>
        </tr>
    </table>      
    <br />
    <table class="consulta">
    <tr>
    <td>
    <table style="width:100%;"> 
    <tr>
    <td>
    <asp:Label ID="labelSeleccioneConsultas" runat="server" Text="Seleccione consulta" CssClass="labelconsulta"></asp:Label>
    </td>
    <td>
    <asp:DropDownList ID="comboTipoConsulta" runat="server" 
    AutoPostBack="True" 
            onselectedindexchanged="comboTipoConsulta_SelectedIndexChanged" 
            CssClass="combo">
    </asp:DropDownList>
    </td>
    </tr>
    </table>
    </td>
    </tr>
    </table>
    </div>
    <br />
    <asp:Panel ID="PanelConsulta" runat="server" Visible="False">
    <div class="divwithoutgrid">
    <table class="form">
    <tr>
    <td>
    <table style="width:100%;"> 
    <tr><th colspan="5">
    <asp:Label ID="labelInventario" runat="server" Text="Inventario" CssClass="subtitulo"></asp:Label>
    </th></tr>
    <tr>
    <td>
    <asp:Label ID="labelFechaInicial" runat="server" Text="Fecha inicial" CssClass="label"></asp:Label>
    </td>
    <td>
    <asp:TextBox ID="textFechaInicial" runat="server"  CssClass="texto2"></asp:TextBox>
    <cc1:CalendarExtender ID="calendarFechaInicial" Format="dd/MM/yyyy"  runat="server" CssClass="calendar" TargetControlID="textFechaInicial">
    </cc1:CalendarExtender>
    </td>
    <td class="separador">
    </td>
    <td>
    <asp:Label ID="labelFechafinal" runat="server" Text="Fecha final" CssClass="label"></asp:Label>
    </td>
    <td>
    <asp:TextBox ID="textFechaFinal" runat="server"  CssClass="texto2"></asp:TextBox>
    <cc1:CalendarExtender ID="calendarFechaFinal" Format="dd/MM/yyyy"  runat="server" CssClass="calendar" TargetControlID="textFechaFinal">
    </cc1:CalendarExtender>
    </td>
    </tr>
    <tr>
    <td style="width:25%">
    <asp:Label ID="labelSustancia" runat="server" Text="Seleccione sustancia" CssClass="label"></asp:Label>
    </td>
    <td>
    <asp:DropDownList ID="comboSustancia" runat="server" CssClass="combo" 
            DataTextField="sus_Descripcion" DataValueField="sus_Id">
    </asp:DropDownList>
    </td>
    <td class="separador"></td>
    <td> 
    <asp:Label ID="labelDepartamento" runat="server" Text="Departamento" CssClass="label"></asp:Label>
    </td>
    <td>
    <asp:DropDownList ID="comboDepartamento" runat="server" CssClass="combo" 
            DataTextField="dep_Descripcion" DataValueField="dep_Id" AutoPostBack="True" 
            onselectedindexchanged="comboDepartamento_SelectedIndexChanged">
    </asp:DropDownList>
    </td>
    </tr>
    <tr>
    <td>
    <asp:Label ID="labelCiudad" runat="server" Text="Ciudad" CssClass="label"></asp:Label>
    </td>
    <td>
    <asp:DropDownList ID="comboCiudad" runat="server" CssClass="combo" 
            DataTextField="mun_Descripcion" DataValueField="mun_Id">
    </asp:DropDownList>
    </td>
    <td class="separador">
    </td>
    <td>
    <asp:Label ID="labelEstado" runat="server" CssClass="label" Text="Estado sustancia"></asp:Label>
    </td>
    <td>
    <asp:DropDownList ID="comboEstado" runat="server" CssClass="combo" 
            DataTextField="des_Descripcion" DataValueField="des_Id">
    </asp:DropDownList>
    </td>
    </tr>
    <tr>
    <td>
    <asp:Label ID="labelEmpresa" runat="server" Text="Seleccione empresa" CssClass="label"></asp:Label>
    </td>
    <td><asp:DropDownList ID="comboEmpresa" runat="server" CssClass="combo" 
            DataTextField="ter_NombreCompleto" DataValueField="ter_Id">
    </asp:DropDownList>
    </td>
    <td class="separador">
    </td>
    <td>
    </td>
    <td>
    </td>
    </tr>
    <tr>
    <td colspan="5">
    <asp:Button ID="buttonBuscar" runat="server" Text="Buscar" CssClass="button" 
    onclick="buttonBuscar_Click"/>&nbsp;&nbsp;<asp:Button ID="buttonExportar"
    runat="server" Text="Exportar" CssClass="button" onclick="buttonExportar_Click" />&nbsp;&nbsp;<asp:Button ID="buttonCancelar"
    runat="server" Text="Cancelar" CssClass="button" />
    </td>
    </tr>
    </table>
    </td>
    </tr>
    </table>
    </div>
    <br />
    <br />
    <div class="divgrillas" runat="server" id="divPublico" visible="false">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
    <asp:GridView ID="gridconsultasMDisposicionFinalPublico" runat="server" HeaderStyle-CssClass="headergrilla" 
    RowStyle-CssClass="rowgrilla" FooterStyle-CssClass="footergrilla" 
    CssClass="grilla"   AutoGenerateColumns="False" 
    SelectedRowStyle-CssClass="selectedgrilla" AllowPaging="True" 
            DataSourceID="productosConsultasDataSource" PageSize="15">
    <RowStyle CssClass="rowgrilla"></RowStyle>
        <Columns>
            <asp:BoundField DataField="Empresa" HeaderText="Empresa" 
                SortExpression="Empresa" />
            <asp:BoundField DataField="Sustancia" HeaderText="Sustancia" 
                SortExpression="Sustancia" />
            <asp:BoundField DataField="Cantidad" HeaderText="Cantidad (Kg)" 
                SortExpression="Cantidad" DataFormatString="{0:#,##0.00}" >
                <ItemStyle HorizontalAlign="Right" />
            </asp:BoundField>
            <asp:BoundField DataField="Estado" HeaderText="Estado" 
                SortExpression="Estado" />
            <asp:BoundField DataField="Departamento" HeaderText="Departamento" 
                SortExpression="Departamento" />
            <asp:BoundField DataField="Ciudad" HeaderText="Ciudad" 
                SortExpression="Ciudad" />
        </Columns>
    <FooterStyle CssClass="footergrilla"></FooterStyle>
    <SelectedRowStyle CssClass="selectedgrilla" />
    <HeaderStyle CssClass="headergrilla"></HeaderStyle>
    </asp:GridView>
    </ContentTemplate>
        </asp:UpdatePanel>
    
        <asp:SqlDataSource ID="productosConsultasDataSource" runat="server" 
            ConnectionString="<%$ ConnectionStrings:BDUTOConnectionString %>" 
            SelectCommand="exec [dis].[spConsultaNacional] @idSustancia,@idEstado,@idDepartamento,@idCiudad,@fechaInicial,@fechaFinal,@idEmpresa">
            <SelectParameters>
                <asp:Parameter Name="idSustancia" />
                <asp:Parameter Name="idEstado" />
                <asp:Parameter Name="idDepartamento" />
                <asp:Parameter Name="idCiudad" />
                <asp:Parameter Name="fechaInicial" />
                <asp:Parameter Name="fechaFinal" />
                <asp:Parameter Name="idEmpresa" />
            </SelectParameters>
        </asp:SqlDataSource>
    </div>
    <br />
    <div class="divgrillas" runat="server" id="divPrivado" visible="false">
        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
        <ContentTemplate>
    <asp:GridView ID="gridconsultasMDisposicionFinalPrivado" runat="server" HeaderStyle-CssClass="headergrilla" 
    RowStyle-CssClass="rowgrilla" FooterStyle-CssClass="footergrilla" 
    CssClass="grilla"   AutoGenerateColumns="False" 
    SelectedRowStyle-CssClass="selectedgrilla" AllowPaging="True" 
            DataSourceID="productosConsultaDataSourcePublico" PageSize="15">
    <RowStyle CssClass="rowgrilla"></RowStyle>
    <Columns>
    <asp:BoundField DataField="Sustancia" HeaderText="Sustancia" 
    SortExpression="Sustancia" />
    <asp:BoundField DataField="Cantidad" HeaderText="Cantidad (Kg)" 
    SortExpression="Cantidad" ReadOnly="True" DataFormatString="{0:#,##0.00}" >
        <ItemStyle HorizontalAlign="Right" />
        </asp:BoundField>
    <asp:BoundField DataField="Estado" HeaderText="Estado" 
    SortExpression="Estado" />
        <asp:BoundField DataField="Departamento" HeaderText="Departamento" 
            SortExpression="Departamento" />
        <asp:BoundField DataField="Ciudad" HeaderText="Ciudad" 
            SortExpression="Ciudad" />
    </Columns>
    <FooterStyle CssClass="footergrilla"></FooterStyle>
    <SelectedRowStyle CssClass="selectedgrilla" />
    <HeaderStyle CssClass="headergrilla"></HeaderStyle>
    </asp:GridView>
    </ContentTemplate>
        </asp:UpdatePanel>
        <asp:SqlDataSource ID="productosConsultaDataSourcePublico" runat="server" 
            ConnectionString="<%$ ConnectionStrings:BDUTOConnectionString %>" 
            SelectCommand="exec [dis].[spConsultaNacionalPublico] @idSustancia,@idEstado,@idDepartamento,@idCiudad,@fechaInicial,@fechaFinal">
            <SelectParameters>
                <asp:Parameter Name="idSustancia" />
                <asp:Parameter Name="idEstado" />
                <asp:Parameter Name="idDepartamento" />
                <asp:Parameter Name="idCiudad" />
                <asp:Parameter Name="fechaInicial" />
                <asp:Parameter Name="fechaFinal" />
            </SelectParameters>
        </asp:SqlDataSource>
    </div>
    </asp:Panel>
    <br />
    </asp:Content>

