<%@ Page Language="C#" MasterPageFile="~/MPMain.Master"  AutoEventWireup="true" CodeBehind="RecuperacionConsultas.aspx.cs" Inherits="UTO.Recuperacion.RecuperacionConsultas" %>
    <%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
    <asp:Content ID="contentModuloRecuperacionConsultasHead" ContentPlaceHolderID="head" Runat="Server">
        </asp:Content>
    <asp:Content  ID="contentModuloRecuperacion" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
        <div class="divwithoutgrid">
    <table class="titulo" >
    <tr><td>
    <asp:Label ID="labelConsultas" runat="server" 
            Text="Proyectos de dotación de equipos y herramientas  para el sector de refrigeración y aire acondicionado - Consultas" 
            CssClass="subtitulo"></asp:Label>
    </td></tr>
    </table>
    </div>
    <br />
    <div class="divwithoutgrid">
    <table class="form">
    <tr>
    <td>
    <table style="width:100%;"> 
    <tr><th colspan="5">
    <asp:Label ID="labelReporteUso" runat="server" Text="Criterios de búsqueda" 
            CssClass="subtitulo"></asp:Label>
    </th></tr>
    <tr>
    <td style="width:25%">
    <asp:Label ID="labelBeneficiario0" runat="server" Text="Seleccione consulta"></asp:Label>
    </td>
    <td colspan="4">
    <asp:DropDownList ID="comboTipoConsulta" runat="server" 
            DataTextField="cre_Descripcion" DataValueField="cre_Id" 
            AutoPostBack="True" CssClass="combo" 
            Width="503px" >
    </asp:DropDownList>
    <%--onselectedindexchanged="comboTipoConsulta_SelectedIndexChanged"--%>
    </td>
    </tr>
    <tr>
    <td style="width:25%">
    <asp:Label ID="labelRegional" runat="server" Text="Regional"></asp:Label>
    </td>
    <td>
        <asp:DropDownList ID="comboRegional" runat="server" CssClass="combo" DataTextField="reg_Descripcion" 
            DataValueField="reg_Id" Width="247px">
        </asp:DropDownList>
    </td>
    <td class="separador"></td>
    <td> 
        <asp:Label ID="labelPeriodo" runat="server" Text="Periodo"></asp:Label>
    </td>
    <td>
        <asp:DropDownList ID="comboPeriodo" runat="server" CssClass="combo">
        </asp:DropDownList>
    </td>
    </tr>
        <tr>
            <td style="width:25%">
                <asp:Label ID="labelDepartamento" runat="server" CssClass="label" 
                    Text="Departamento"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="comboDepartamento" runat="server" CssClass="combo" DataTextField="dep_Descripcion" 
                    DataValueField="dep_Id" Width="247px" 
                    onselectedindexchanged="comboDepartamento_SelectedIndexChanged1">
                </asp:DropDownList>
            </td>
            <td class="separador">
                &nbsp;</td>
            <td>
                <asp:Label ID="labelCiudad" runat="server" Text="Ciudad"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="comboCiudad" runat="server" CssClass="combo" 
                    DataTextField="mun_Descripcion" DataValueField="mun_Id">
                </asp:DropDownList>
            </td>
        </tr>
    <tr>
    <td>
        <asp:Label ID="labelFechaInicial" runat="server" CssClass="label" 
            Text="Fecha inicial"></asp:Label>
    </td>
    <td>
        <asp:TextBox ID="textFechaInicial" runat="server" CssClass="texto2"></asp:TextBox>
        <cc1:CalendarExtender ID="calendarfecha" runat="server" CssClass="calendar" 
            Format="dd/MM/yyyy" TargetControlID="textFechaInicial">
        </cc1:CalendarExtender>
        <cc1:CalendarExtender ID="CalendarExtender2" runat="server" CssClass="calendar" 
            Format="dd/MM/yyyy" TargetControlID="textFechaInicial">
        </cc1:CalendarExtender>
    </td>
    <td class="separador">
        &nbsp;</td>
    <td>
        <asp:Label ID="label1" runat="server" CssClass="label" Text="Fecha final"></asp:Label>
        </td>
    <td>
        <asp:TextBox ID="textFechaFinal" runat="server" CssClass="texto2"></asp:TextBox>
        <cc1:CalendarExtender ID="CalendarExtender1" runat="server" CssClass="calendar" 
            Format="dd/MM/yyyy" TargetControlID="textFechaFinal">
        </cc1:CalendarExtender>
        <cc1:CalendarExtender ID="CalendarExtender3" runat="server" CssClass="calendar" 
            Format="dd/MM/yyyy" TargetControlID="textFechaFinal">
        </cc1:CalendarExtender>
        </td>
    </tr>
    <tr>
    <td>
    <asp:Label ID="labelBeneficiario" runat="server" Text="Beneficiario"></asp:Label>
    </td>
    <td>
        <asp:TextBox ID="textNombreBeneficiario" runat="server" Width="244px"></asp:TextBox>
    </td>
    <td class="separador">
    </td>
    <td>
        <asp:Label ID="labelAno" runat="server" CssClass="label" Text="Año"></asp:Label>
        </td>
    <td>
        <asp:DropDownList ID="comboAno" runat="server" CssClass="combo" Width="94px" 
            DataTextField="anos" DataValueField="anos">
            <asp:ListItem Value="0">Seleccione...</asp:ListItem>
            <asp:ListItem Value="1">2005</asp:ListItem>
            <asp:ListItem Value="2">2006</asp:ListItem>
            <asp:ListItem Value="3">2007</asp:ListItem>
            <asp:ListItem Value="4">2008</asp:ListItem>
            <asp:ListItem Value="5">2009</asp:ListItem>
            <asp:ListItem Value="6">2010</asp:ListItem>
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
    <td>
        &nbsp;</td>
    </tr>
    <tr>
    <td colspan="5">
    <asp:Button ID="buttonBuscarReporteUso" runat="server" Text="Buscar" 
            CssClass="button" onclick="buttonBuscarReporteUso_Click"/>&nbsp;&nbsp;<asp:Button ID="buttonExportar"
    runat="server" Text="Exportar" CssClass="button" onclick="buttonExportar_Click" />
    &nbsp;<asp:Button ID="buttonCancelar"
    runat="server" Text="Cancelar" CssClass="button" onclick="buttonCancelar_Click" />
    </td>
    </tr>
    <tr>
    <td colspan="5">
        <div class="divgrillassinmargin">
            <asp:Panel ID="panelReporteUso" runat="server">        
            
                <asp:GridView ID="gridReporteUso" runat="server" 
                    CssClass="grilla" 
                    FooterStyle-CssClass="footergrilla" HeaderStyle-CssClass="headergrilla" 
                    RowStyle-CssClass="rowgrilla" SelectedRowStyle-CssClass="selectedgrilla" 
                    AllowPaging="True" PageSize="15" AutoGenerateColumns="False" 
                    DataSourceID="SqlDataSourceReporteUso">
                    <RowStyle CssClass="rowgrilla" />
                    <Columns>
                        <asp:BoundField DataField="Nit" HeaderText="Nit" SortExpression="Nit" />
                        <asp:BoundField DataField="Ciudad" HeaderText="Ciudad" ReadOnly="True" 
                            SortExpression="Ciudad" />
                        <asp:BoundField DataField="Periodo" HeaderText="Periodo" 
                            SortExpression="Periodo" />
                        <asp:BoundField DataField="Empresa" HeaderText="Empresa" ReadOnly="True" 
                            SortExpression="Empresa" />
                        <asp:BoundField DataField="Contacto" HeaderText="Contacto" ReadOnly="True" 
                            SortExpression="Contacto" />
                        <asp:BoundField DataField="Telefono" HeaderText="Telefono" ReadOnly="True" 
                            SortExpression="Telefono" />
                        <asp:BoundField DataField="Direccion" HeaderText="Direccion" ReadOnly="True" 
                            SortExpression="Direccion" />
                        <asp:BoundField DataField="R-12" HeaderText="R-12" ReadOnly="True" 
                            SortExpression="R-12" />
                        <asp:BoundField DataField="R-22" HeaderText="R-22" ReadOnly="True" 
                            SortExpression="R-22" />
                        <asp:BoundField DataField="R-134a" HeaderText="R-134a" ReadOnly="True" 
                            SortExpression="R-134a" />
                        <asp:BoundField DataField="Otro" HeaderText="Otro" ReadOnly="True" 
                            SortExpression="Otro" />
                        <asp:BoundField DataField="UsoR12" HeaderText="UsoR12" ReadOnly="True" 
                            SortExpression="UsoR12" />
                        <asp:BoundField DataField="UsoR22" HeaderText="UsoR22" ReadOnly="True" 
                            SortExpression="UsoR22" />
                        <asp:BoundField DataField="UsoR134A" HeaderText="UsoR134A" ReadOnly="True" 
                            SortExpression="UsoR134A" />
                        <asp:BoundField DataField="UsoOtro" HeaderText="UsoOtro" ReadOnly="True" 
                            SortExpression="UsoOtro" />
                    </Columns>
                    <FooterStyle CssClass="footergrilla" />
                    <SelectedRowStyle CssClass="selectedgrilla" />
                    <HeaderStyle CssClass="headergrilla" />
                </asp:GridView>                            
                <asp:SqlDataSource ID="SqlDataSourceReporteUso" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:BDUTOConnectionString %>" SelectCommand="exec Rrr.spConsultaReporteUso 
@departamento , @municipio , @regional ,
@beneficiario , @fechaInicial , @fechaFinal , @anno , 
@periodo ">
                    <SelectParameters>
                        <asp:Parameter Name="departamento" />
                        <asp:Parameter Name="municipio" />
                        <asp:Parameter Name="regional" />
                        <asp:Parameter Name="beneficiario" />
                        <asp:Parameter Name="fechaInicial" />
                        <asp:Parameter Name="fechaFinal" />
                        <asp:Parameter Name="anno" />
                        <asp:Parameter Name="periodo" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </asp:Panel>
            <asp:Panel ID="panelCentroRegeneracion" runat="server">
                <asp:GridView ID="gridCentroRegeneracion" runat="server" 
                    CssClass="grilla" 
                    FooterStyle-CssClass="footergrilla" HeaderStyle-CssClass="headergrilla" 
                    RowStyle-CssClass="rowgrilla" SelectedRowStyle-CssClass="selectedgrilla" 
                    AllowPaging="True" PageSize="15" 
                    DataSourceID="SqlDataSourceCentroRegeneracion">
                    <RowStyle CssClass="rowgrilla" />
                    <FooterStyle CssClass="footergrilla" />
                    <SelectedRowStyle CssClass="selectedgrilla" />
                    <HeaderStyle CssClass="headergrilla" />
                </asp:GridView>                            
                <asp:SqlDataSource ID="SqlDataSourceCentroRegeneracion" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:BDUTOConnectionString %>" SelectCommand="exec Rrr.spConsultaReporteRegeneracion 
@beneficiario , @fechaInicial , @fechaFinal">
                    <SelectParameters>
                        <asp:Parameter Name="beneficiario" />
                        <asp:Parameter Name="fechaInicial" />
                        <asp:Parameter Name="fechaFinal" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </asp:Panel>
            <asp:Panel ID="panelNovedades" runat="server">
                <asp:GridView ID="gridNovedades" runat="server" 
                    CssClass="grilla" 
                    FooterStyle-CssClass="footergrilla" HeaderStyle-CssClass="headergrilla" 
                    RowStyle-CssClass="rowgrilla" SelectedRowStyle-CssClass="selectedgrilla" 
                    AllowPaging="True" PageSize="15" AutoGenerateColumns="False" 
                    DataKeyNames="Id" DataSourceID="SqlDataSourceNovedades">
                    <RowStyle CssClass="rowgrilla" />
                    <Columns>
                        <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" 
                            ReadOnly="True" SortExpression="Id" />
                        <asp:BoundField DataField="Fecha novedad" HeaderText="Fecha novedad" 
                            SortExpression="Fecha novedad" />
                        <asp:BoundField DataField="Regional" HeaderText="Regional" 
                            SortExpression="Regional" />
                        <asp:BoundField DataField="Beneficiario" HeaderText="Beneficiario" 
                            SortExpression="Beneficiario" />
                        <asp:BoundField DataField="Departamento" HeaderText="Departamento" 
                            SortExpression="Departamento" />
                        <asp:BoundField DataField="Municipio" HeaderText="Municipio" 
                            SortExpression="Municipio" />
                        <asp:BoundField DataField="Novedad" HeaderText="Novedad" 
                            SortExpression="Novedad" />
                        <asp:BoundField DataField="Causa novedad" HeaderText="Causa novedad" 
                            SortExpression="Causa novedad" />
                    </Columns>
                    <FooterStyle CssClass="footergrilla" />
                    <SelectedRowStyle CssClass="selectedgrilla" />
                    <HeaderStyle CssClass="headergrilla" />
                </asp:GridView>                                        
                <asp:SqlDataSource ID="SqlDataSourceNovedades" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:BDUTOConnectionString %>" SelectCommand="exec Rrr.spConsultaNovedad 
@departamento , @municipio , @regional ,
@beneficiario , @fechaInicial , @fechaFinal ,
@comodato ">
                    <SelectParameters>
                        <asp:Parameter Name="departamento" />
                        <asp:Parameter Name="municipio" />
                        <asp:Parameter Name="regional" />
                        <asp:Parameter Name="beneficiario" />
                        <asp:Parameter Name="fechaInicial" />
                        <asp:Parameter Name="fechaFinal" />
                        <asp:Parameter Name="comodato" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </asp:Panel>
            <asp:Panel ID="panelPolizas" runat="server">
                <asp:GridView ID="gridPolizas" runat="server" 
                    CssClass="grilla" 
                    FooterStyle-CssClass="footergrilla" HeaderStyle-CssClass="headergrilla" 
                    RowStyle-CssClass="rowgrilla" SelectedRowStyle-CssClass="selectedgrilla" 
                    AllowPaging="True" PageSize="15" AutoGenerateColumns="False" 
                    DataKeyNames="Id" DataSourceID="SqlDataSourcePolizas">
                    <RowStyle CssClass="rowgrilla" />
                    <Columns>
                        <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" 
                            ReadOnly="True" SortExpression="Id" />
                        <asp:BoundField DataField="Fecha solicitud" HeaderText="Fecha solicitud" 
                            SortExpression="Fecha solicitud" />
                        <asp:BoundField DataField="Regional" HeaderText="Regional" 
                            SortExpression="Regional" />
                        <asp:BoundField DataField="Beneficiario" HeaderText="Beneficiario" 
                            SortExpression="Beneficiario" />
                        <asp:BoundField DataField="Departamento" HeaderText="Departamento" 
                            SortExpression="Departamento" />
                        <asp:BoundField DataField="Municipio" HeaderText="Municipio" 
                            SortExpression="Municipio" />
                        <asp:BoundField DataField="Fecha aprobación poliza" 
                            HeaderText="Fecha aprobación poliza" SortExpression="Fecha aprobación poliza" />
                        <asp:BoundField DataField="Fecha plazo poliza" HeaderText="Fecha plazo poliza" 
                            SortExpression="Fecha plazo poliza" />
                        <asp:BoundField DataField="Fecha vigencia poliza" 
                            HeaderText="Fecha vigencia poliza" SortExpression="Fecha vigencia poliza" />
                    </Columns>
                    <FooterStyle CssClass="footergrilla" />
                    <SelectedRowStyle CssClass="selectedgrilla" />
                    <HeaderStyle CssClass="headergrilla" />
                </asp:GridView>                                        
                <asp:SqlDataSource ID="SqlDataSourcePolizas" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:BDUTOConnectionString %>" SelectCommand="exec Rrr.spConsultaPoliza 
@departamento , @municipio , @regional ,
@beneficiario , @fechaInicial , @fechaFinal ">
                    <SelectParameters>
                        <asp:Parameter Name="departamento" />
                        <asp:Parameter Name="municipio" />
                        <asp:Parameter Name="regional" />
                        <asp:Parameter Name="beneficiario" />
                        <asp:Parameter Name="fechaInicial" />
                        <asp:Parameter Name="fechaFinal" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </asp:Panel>
            <asp:Panel ID="panelConsolidadoRegeneracion" runat="server">
                <asp:GridView ID="gridConsolidadoRegeneracion" runat="server" 
                    CssClass="grilla" 
                    FooterStyle-CssClass="footergrilla" HeaderStyle-CssClass="headergrilla" 
                    RowStyle-CssClass="rowgrilla" SelectedRowStyle-CssClass="selectedgrilla" 
                    AllowPaging="True" PageSize="15" AutoGenerateColumns="False" 
                    DataKeyNames="Id" DataSourceID="SqlDataSourceConsolidadoRegeneracion">
                    <RowStyle CssClass="rowgrilla" />
                    <Columns>
                        <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" 
                            ReadOnly="True" SortExpression="Id" />
                        <asp:BoundField DataField="Mes" HeaderText="Mes" SortExpression="Mes" />
                        <asp:BoundField DataField="Fecha" HeaderText="Fecha" SortExpression="Fecha" />
                    </Columns>
                    <FooterStyle CssClass="footergrilla" />
                    <SelectedRowStyle CssClass="selectedgrilla" />
                    <HeaderStyle CssClass="headergrilla" />
                </asp:GridView>                                        
                <asp:SqlDataSource ID="SqlDataSourceConsolidadoRegeneracion" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:BDUTOConnectionString %>" SelectCommand="Rrr.spConsultaRegeneracionConsolidado 
 @fechaInicial , @fechaFinal">
                    <SelectParameters>
                        <asp:Parameter Name="fechaInicial" />
                        <asp:Parameter Name="fechaFinal" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </asp:Panel>
        </div>
    </td>
    </tr>
    </table>
    </td>
    </tr>
    </table>
    </div>
    <br />
    <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
        </cc1:ToolkitScriptManager>
</asp:Content>

