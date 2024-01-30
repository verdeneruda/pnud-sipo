    <%@ Page MasterPageFile="~/MPMain.Master" Language="C#" AutoEventWireup="true" CodeBehind="Consulta.aspx.cs" Inherits="UTO.ImportacionExportacion.Consulta" %>


    <%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>


    <%@ Register assembly="DevExpress.Web.ASPxPivotGrid.v15.1, Version=15.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxPivotGrid" tagprefix="dx" %>

    <asp:Content ID="contentImportacionExportacionConsultasHead" ContentPlaceHolderID="head" Runat="Server">
    </asp:Content>
    <asp:Content  ID="contentImportacionExportacionConsultas" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
        <div class="divwithoutgrid">
    <table class="titulo" >
    <tr><td>
    <asp:Label ID="labelConsultas" runat="server" 
            Text="Módulo Importación y Exportación - Consultas" 
            CssClass="subtitulo"></asp:Label>
    </td></tr>
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
            DataTextField="cip_Descripcion" DataValueField="cip_Id" 
   AutoPostBack="True" onselectedindexchanged="comboTipoConsulta_SelectedIndexChanged" CssClass="combo" 
            Width="270px">
    </asp:DropDownList>
    </td>
    </tr>
    </table>
    </td>
    </tr>
    </table>
    </div>
    <br />
    <div class="divwithoutgrid">
    <table class="form">
    <tr>
    <td>
    <asp:Panel ID="PanelVistoBuenoIndicadores" runat="server" Visible="False" 
            ondatabinding="PanelVistoBuenoIndicadores_DataBinding">
    <table style="height: 195px; width: 692px;"> 
    <tr><th colspan="4" class="form">
    <asp:Label ID="labelVistoBueno" runat="server" Text="Indicadores gestión" 
            CssClass="subtitulo"></asp:Label>
    </th></tr>
<%--    <tr>
    <td style="width:25%">
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
    </tr>--%>
    <tr>
        <td>
            <asp:Label ID="labelMesInicial" runat="server" Text="Mes inicial"></asp:Label>
        </td>
        <td>    
            <asp:DropDownList ID="comboMesInicial" runat="server">
            </asp:DropDownList>
            
        </td>
        <td>
            <asp:Label ID="labelannoInicial" runat="server" Text="Año inicial"></asp:Label>
        </td>
        <td>    
            <asp:DropDownList ID="comboAnnoInicial" runat="server" DataTextField="anos" 
                DataValueField="anos">
            </asp:DropDownList>
        </td>
     </tr>
     <tr>
        <td>
            <asp:Label ID="label1" runat="server" Text="Mes final"></asp:Label>
        </td>
        <td>    
            <asp:DropDownList ID="comboMesFinal" runat="server">
            </asp:DropDownList>
            
        </td>
        <td>
            <asp:Label ID="label11" runat="server" Text="Año final"></asp:Label>
        </td>
        <td>    
            <asp:DropDownList ID="comboAnnoFinal" runat="server" DataTextField="anos" 
                DataValueField="anos">
            </asp:DropDownList>
        </td>        
    </tr>
    <tr>
    <td colspan="4">
    <asp:Button ID="buttonBuscar" runat="server" Text="Buscar" CssClass="button" 
            onclick="buttonBuscar_Click"/>&nbsp;&nbsp;<asp:Button ID="buttonExportarVB"
    runat="server" Text="Exportar" CssClass="button" 
            onclick="buttonExportarVB_Click" />
        &nbsp;<asp:Button ID="buttonCancelar" runat="server" CssClass="button" 
            Text="Cancelar" onclick="buttonCancelar_Click" />
    </td>
    </tr>

        <tr>
            <td colspan="4">
                <div class="divgrillassinmargin">
                    <asp:GridView ID="gridConsultaVistosBuenos" runat="server" CssClass="grilla" 
                        FooterStyle-CssClass="footergrilla" HeaderStyle-CssClass="headergrilla" 
                        RowStyle-CssClass="rowgrilla" SelectedRowStyle-CssClass="selectedgrilla" 
                        Visible="False" AllowPaging="True" PageSize="15">
                        <RowStyle CssClass="rowgrilla" />
                        <FooterStyle CssClass="footergrilla" />
                        <SelectedRowStyle CssClass="selectedgrilla" />
                        <HeaderStyle CssClass="headergrilla" />
                    </asp:GridView>
                </div>
            </td>
        </tr>

    </table>
    </asp:Panel>  
    </td>
    </tr>
    <tr>
    <td>
    <asp:Panel ID="PanelVistoBuenoRegistro" runat="server" Visible="False" 
            ondatabinding="PanelVistoBuenoIndicadores_DataBinding">
    <table style="width:24%;"> 
    <tr><th colspan="4" class="form">
    <asp:Label ID="label2" runat="server" Text="Visto Bueno Registro Importación" 
            CssClass="subtitulo"></asp:Label>
    </th></tr>
    <tr>
    <td colspan="4">
        <asp:RadioButton ID="RadioSustancia" runat="server" AutoPostBack="True" 
            GroupName="TipoImportacion" 
            Text="Sustancia" oncheckedchanged="RadioSustancia_CheckedChanged" />
        <asp:RadioButton ID="RadioEquipos" runat="server" AutoPostBack="True" 
            GroupName="TipoImportacion" 
            Text="Equipos" oncheckedchanged="RadioEquipos_CheckedChanged" />
    </td>
    </tr>
        <tr>
            <td style="width:25%">
                <asp:Label ID="label8" runat="server" CssClass="label" 
                    Text="Número visto bueno"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="textNumeroVB" runat="server" CssClass="texto2"></asp:TextBox>
            </td>
            <td class="separador">
                <asp:Label ID="label9" runat="server" CssClass="label" 
                    Text="Número licencia importación"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="textNumeroLicencia" runat="server" CssClass="texto2"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width:25%">
                <asp:Label ID="label10" runat="server" CssClass="label" Text="Importador"></asp:Label>
            </td>
            <td colspan="3">
                <asp:TextBox ID="textImportador" runat="server" CssClass="texto2" Width="468px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width:25%">
                <asp:Label ID="label3" runat="server" CssClass="label" Text="Fecha inicial"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextFechaInicialRegistroImportacion" runat="server" 
                    CssClass="texto2"></asp:TextBox>
                <cc1:CalendarExtender ID="CalendarExtender4" runat="server" CssClass="calendar" 
                    Format="dd/MM/yyyy" TargetControlID="TextFechaInicialRegistroImportacion">
                </cc1:CalendarExtender>
            </td>
            <td class="separador">
                <asp:Label ID="label4" runat="server" CssClass="label" 
                    Text="Fecha final"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextFechaFinalRegistroImportacion" runat="server" 
                    CssClass="texto2"></asp:TextBox>
                <cc1:CalendarExtender ID="CalendarExtender6" runat="server" CssClass="calendar" 
                    Format="dd/MM/yyyy" TargetControlID="TextFechaFinalRegistroImportacion">
                </cc1:CalendarExtender>
            </td>
        </tr>
    <tr>
    <td style="width:25%">
        <asp:Label ID="labelSustancia" runat="server" CssClass="label" Text="Sustancia" 
            Visible="False"></asp:Label>
    </td>
        <td>
            <asp:DropDownList ID="comboSustancia" runat="server" CssClass="combo" 
                DataTextField="sus_Descripcion" DataValueField="sus_Id" 
                Visible="False" Width="153px">
            </asp:DropDownList>
        </td>
        <td class="separador">
            <asp:Label ID="labelMarcaEquipos" runat="server" CssClass="label" 
                Text="Marca equipos" Visible="False"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="textMarcaEquipos" runat="server" CssClass="texto2" 
                Visible="False"></asp:TextBox>
        </td>
    </tr>
        <tr>
            <td colspan="4">
                <asp:Button ID="buttonVBRegistro" runat="server" CssClass="button" 
                    onclick="buttonVBRegistro_Click" Text="Buscar" />
                &nbsp;&nbsp;<asp:Button ID="button2" runat="server" CssClass="button" 
                    Text="Exportar" onclick="button2_Click" />
                &nbsp;<asp:Button ID="button3" runat="server" CssClass="button" Text="Cancelar" 
                    onclick="button3_Click" />
            </td>
        </tr>
        <tr>
            <td colspan="4">
                <div class="divgrillassinmargin">
                    <asp:GridView ID="GridViewVBRegistro" runat="server" CssClass="grilla" 
                        FooterStyle-CssClass="footergrilla" HeaderStyle-CssClass="headergrilla" 
                        RowStyle-CssClass="rowgrilla" SelectedRowStyle-CssClass="selectedgrilla" 
                        Visible="False" AllowPaging="True" AutoGenerateColumns="False" 
                        DataKeyNames="Id" DataSourceID="consultaDataSource" 
                        PageSize="15">
                        <RowStyle CssClass="rowgrilla" />
                        <Columns>
                            <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" 
                                ReadOnly="True" SortExpression="Id" />
                            <asp:BoundField DataField="Número registro" HeaderText="Número registro" 
                                ReadOnly="True" SortExpression="Número registro" />
                            <asp:BoundField DataField="Visto bueno" HeaderText="Visto bueno" 
                                ReadOnly="True" SortExpression="Visto bueno" />
                            <asp:BoundField DataField="Fecha vigencia" HeaderText="Fecha vigencia" 
                                ReadOnly="True" SortExpression="Fecha vigencia" />
                            <asp:BoundField DataField="Importador" HeaderText="Importador" ReadOnly="True" 
                                SortExpression="Importador" />
                            <asp:BoundField DataField="Exportador" HeaderText="Exportador" ReadOnly="True" 
                                SortExpression="Exportador" />
                            <asp:BoundField DataField="Puerto de embargue" HeaderText="Puerto de embargue" 
                                ReadOnly="True" SortExpression="Puerto de embargue" />
                            <asp:BoundField DataField="Aduana" HeaderText="Aduana" ReadOnly="True" 
                                SortExpression="Aduana" />
                        </Columns>
                        <FooterStyle CssClass="footergrilla" />
                        <SelectedRowStyle CssClass="selectedgrilla" />
                        <HeaderStyle CssClass="headergrilla" />
                    </asp:GridView>
                    <asp:SqlDataSource ID="consultaDataSourceVBRegistroImportacion" runat="server">
                    </asp:SqlDataSource>
                    <asp:SqlDataSource ID="consultaDataSource" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:BDUTOConnectionString %>" 
                        
                        SelectCommand="exec Iye.spConsultaVistoBuenoImportacion @vistoBueno, @licencia,@importador,@fechaInicial,@fechaFinal,@sustancia,@marca">
                        <SelectParameters>
                            <asp:Parameter Name="vistoBueno" />
                            <asp:Parameter Name="licencia" />
                            <asp:Parameter Name="importador" />
                            <asp:Parameter Name="fechaInicial" />
                            <asp:Parameter Name="fechaFinal" />
                            <asp:Parameter Name="sustancia" />
                            <asp:Parameter Name="marca" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                </div>
            </td>
        </tr>
    </table>
    </asp:Panel>  
    </td>
    </tr>     
    <tr>
    <td>
    <asp:Panel ID="PanelVBDeclaracion" runat="server" Visible="False" 
            ondatabinding="PanelVistoBuenoIndicadores_DataBinding">
    <table style="width:24%;"> 
    <tr><th colspan="4" class="form">
    <asp:Label ID="label5" runat="server" Text="Visto Bueno Declaración Importación" 
            CssClass="subtitulo"></asp:Label>
    </th></tr>
    <tr>
    <td colspan="4">
        <asp:RadioButton ID="RadioSustanciaDeclaracion" runat="server" AutoPostBack="True" 
            GroupName="TipoImportacion" 
            Text="Sustancia" 
            oncheckedchanged="RadioSustanciaDeclaracion_CheckedChanged" />
        <asp:RadioButton ID="RadioEquipoDeclaracion" runat="server" AutoPostBack="True" 
            GroupName="TipoImportacion" 
            Text="Equipos" oncheckedchanged="RadioEquipoDeclaracion_CheckedChanged" />
    </td>
    </tr>
        <tr>
            <td style="width:25%">
                <asp:Label ID="label12" runat="server" CssClass="label" 
                    Text="Número licencia importación"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="textNumeroLicenciaDeclaracion" runat="server" 
                    CssClass="texto2"></asp:TextBox>
            </td>
            <td class="separador">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width:25%">
                <asp:Label ID="label13" runat="server" CssClass="label" Text="Importador"></asp:Label>
            </td>
            <td colspan="3">
                <asp:TextBox ID="textImportadorDeclaracion" runat="server" CssClass="texto2" 
                    Width="468px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width:25%">
                <asp:Label ID="label6" runat="server" CssClass="label" Text="Fecha inicial"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextFechaInicialDeclaracion" runat="server" CssClass="texto2"></asp:TextBox>
                <cc1:CalendarExtender ID="CalendarExtender8" runat="server" CssClass="calendar" 
                    Format="dd/MM/yyyy" TargetControlID="TextFechaInicialDeclaracion">
                </cc1:CalendarExtender>
            </td>
            <td class="separador">
                <asp:Label ID="label7" runat="server" CssClass="label" 
                    Text="Fecha final"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextFechaFinalDeclaracion" runat="server" CssClass="texto2"></asp:TextBox>
                <cc1:CalendarExtender ID="CalendarExtender10" runat="server" 
                    CssClass="calendar" Format="dd/MM/yyyy" TargetControlID="TextFechaFinalDeclaracion">
                </cc1:CalendarExtender>
            </td>
        </tr>
    <tr>
    <td style="width:25%">
        <asp:Label ID="labelSustanciaDeclaracion" runat="server" CssClass="label" 
            Text="Sustancia" Visible="False"></asp:Label>
    </td>
        <td>
            <asp:DropDownList ID="comboSustanciaDeclaracion" runat="server" 
                CssClass="combo" DataTextField="sus_Descripcion" 
                DataValueField="sus_Id" Visible="False" Width="153px">
            </asp:DropDownList>
        </td>
        <td class="separador">
            <asp:Label ID="labelEquiposDeclaracion" runat="server" CssClass="label" 
                Text="Marca equipos" Visible="False"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TextEquipoDeclaracion" runat="server" CssClass="texto2" 
                Visible="False"></asp:TextBox>
        </td>
    </tr>
        <tr>
            <td colspan="4">
                <asp:Button ID="buttonVBDeclaracion" runat="server" CssClass="button" 
                    onclick="buttonVBDeclaracion_Click" Text="Buscar" />
                &nbsp;&nbsp;<asp:Button ID="button5" runat="server" CssClass="button" 
                    Text="Exportar" onclick="button5_Click" />
                &nbsp;<asp:Button ID="button6" runat="server" CssClass="button" Text="Cancelar" />
            </td>
        </tr>
        <tr>
            <td colspan="4">
                <div class="divgrillassinmargin">
                    <asp:GridView ID="GridViewVBDeclaracion" runat="server" CssClass="grilla" 
                        FooterStyle-CssClass="footergrilla" HeaderStyle-CssClass="headergrilla" 
                        RowStyle-CssClass="rowgrilla" SelectedRowStyle-CssClass="selectedgrilla" 
                        Visible="False" DataSourceID="consultaDataSourceVBDeclaracionImportacion" 
                        AutoGenerateColumns="False" DataKeyNames="Id">
                        <RowStyle CssClass="rowgrilla" />
                        <Columns>
                            <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" 
                                ReadOnly="True" SortExpression="Id" />
                            <asp:BoundField DataField="Número registro" HeaderText="Número registro" 
                                SortExpression="Número registro" />
                            <asp:BoundField DataField="Sustancia" HeaderText="Sustancia" 
                                SortExpression="Sustancia" />
                            <asp:BoundField DataField="Fecha declaración" HeaderText="Fecha declaración" 
                                SortExpression="Fecha declaración" />
                            <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" 
                                SortExpression="Cantidad" />
                            <asp:BoundField DataField="Valor FOB" HeaderText="Valor FOB" 
                                SortExpression="Valor FOB" />
                            <asp:BoundField DataField="Peso neto" HeaderText="Peso neto" 
                                SortExpression="Peso neto" />
                            <asp:BoundField DataField="Razón social" HeaderText="Razón social" 
                                SortExpression="Razón social" />
                            <asp:BoundField DataField="Tercero" HeaderText="Tercero" 
                                SortExpression="Tercero" />
                        </Columns>
                        <FooterStyle CssClass="footergrilla" />
                        <SelectedRowStyle CssClass="selectedgrilla" />
                        <HeaderStyle CssClass="headergrilla" />
                    </asp:GridView>
                    <asp:SqlDataSource ID="consultaDataSourceVBDeclaracionImportacion" 
                        runat="server" 
                        ConnectionString="<%$ ConnectionStrings:BDUTOConnectionString %>" SelectCommand="exec Iye.spConsultaVBDeclaracionImportacion 
 @licencia , @importador , @fechaInicial , @fechaFinal 
, @sustancia , @marca ">
                        <SelectParameters>
                            <asp:Parameter Name="licencia" />
                            <asp:Parameter Name="importador" />
                            <asp:Parameter Name="fechaInicial" />
                            <asp:Parameter Name="fechaFinal" />
                            <asp:Parameter Name="sustancia" />
                            <asp:Parameter Name="marca" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                </div>
            </td>
        </tr>
    </table>
    </asp:Panel>  
    </td>
    </tr>      
    <tr>
    <td>
    <asp:Panel ID="PanelRegistroExportacion" runat="server" Visible="False" 
            ondatabinding="PanelVistoBuenoIndicadores_DataBinding">
    <table style="width:24%;"> 
    <tr><th colspan="4" class="form">
    <asp:Label ID="label14" runat="server" Text="Visto Bueno Registro Exportación" 
            CssClass="subtitulo"></asp:Label>
    </th></tr>
        <tr>
            <td style="width:25%">
                <asp:Label ID="label15" runat="server" CssClass="label" 
                    Text="Número visto bueno"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextVBExportacion" runat="server" CssClass="texto2"></asp:TextBox>
            </td>
            <td class="separador">
                <asp:Label ID="label16" runat="server" CssClass="label" 
                    Text="Número licencia exportación"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextLicenciaExportacion" runat="server" CssClass="texto2"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width:25%">
                <asp:Label ID="label17" runat="server" CssClass="label" Text="Exportador"></asp:Label>
            </td>
            <td colspan="3">
                <asp:TextBox ID="TextExportador" runat="server" CssClass="texto2" Width="468px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width:25%">
                <asp:Label ID="label18" runat="server" CssClass="label" Text="Fecha inicial"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextFechaInicialExportacion" runat="server" CssClass="texto2"></asp:TextBox>
                <cc1:CalendarExtender ID="CalendarExtender12" runat="server" CssClass="calendar" 
                    Format="dd/MM/yyyy" TargetControlID="TextFechaInicialExportacion">
                </cc1:CalendarExtender>
            </td>
            <td class="separador">
                <asp:Label ID="label19" runat="server" CssClass="label" 
                    Text="Fecha final"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextFechaFinalExportacion" runat="server" CssClass="texto2"></asp:TextBox>
                <cc1:CalendarExtender ID="CalendarExtender14" runat="server" CssClass="calendar" 
                    Format="dd/MM/yyyy" TargetControlID="TextFechaFinalExportacion">
                </cc1:CalendarExtender>
            </td>
        </tr>
    <tr>
    <td style="width:25%">
        <asp:Label ID="label20" runat="server" CssClass="label" Text="Sustancia"></asp:Label>
    </td>
        <td>
            <asp:DropDownList ID="comboRegistroExportacion" runat="server" CssClass="combo" DataTextField="sus_Descripcion" 
                DataValueField="sus_Id" Width="153px">
            </asp:DropDownList>
        </td>
        <td class="separador">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
        <tr>
            <td colspan="4">
                <asp:Button ID="buttonRegistroExportacion" runat="server" CssClass="button" 
                    onclick="buttonRegistroExportacion_Click" Text="Buscar" />
                &nbsp;&nbsp;<asp:Button ID="button4" runat="server" CssClass="button" 
                    Text="Exportar" onclick="button4_Click" />
                &nbsp;<asp:Button ID="button7" runat="server" CssClass="button" Text="Cancelar" />
            </td>
        </tr>
        <tr>
            <td colspan="4">
                <div class="divgrillassinmargin">
                    <asp:GridView ID="GridRegistroExportacion" runat="server" CssClass="grilla" 
                        FooterStyle-CssClass="footergrilla" HeaderStyle-CssClass="headergrilla" 
                        RowStyle-CssClass="rowgrilla" SelectedRowStyle-CssClass="selectedgrilla" 
                        Visible="False" AllowPaging="True" AutoGenerateColumns="False" 
                        DataKeyNames="Id" DataSourceID="consultaDataSourceVistoBuenoExpor" 
                        PageSize="15">
                        <RowStyle CssClass="rowgrilla" />
                        <Columns>
                            <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" 
                                ReadOnly="True" SortExpression="Id" />
                            <asp:BoundField DataField="Número registro" HeaderText="Número registro" 
                                SortExpression="Número registro" />
                            <asp:BoundField DataField="Visto bueno" HeaderText="Visto bueno" 
                                SortExpression="Visto bueno" />
                            <asp:BoundField DataField="Fecha vigencia" HeaderText="Fecha vigencia" 
                                SortExpression="Fecha vigencia" />
                            <asp:BoundField DataField="Exportador" HeaderText="Exportador" 
                                SortExpression="Exportador" />
                            <asp:BoundField DataField="Puerto de embargue" HeaderText="Puerto de embargue" 
                                SortExpression="Puerto de embargue" />
                            <asp:BoundField DataField="Aduana" HeaderText="Aduana" 
                                SortExpression="Aduana" />
                        </Columns>
                        <FooterStyle CssClass="footergrilla" />
                        <SelectedRowStyle CssClass="selectedgrilla" />
                        <HeaderStyle CssClass="headergrilla" />
                    </asp:GridView>
                    <asp:SqlDataSource ID="consultaDataSourceVistoBuenoExpor" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:BDUTOConnectionString %>" 
                        SelectCommand="exec [Iye].[spConsultaVistoBuenoExportacion]@vistoBueno,@licencia,@importador,@fechaInicial,@fechaFinal,@sustancia">
                        <SelectParameters>
                            <asp:Parameter Name="vistoBueno" />
                            <asp:Parameter Name="licencia" />
                            <asp:Parameter Name="importador" />
                            <asp:Parameter Name="fechaInicial" />
                            <asp:Parameter Name="fechaFinal" />
                            <asp:Parameter Name="sustancia" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                </div>
            </td>
        </tr>
    </table>
    </asp:Panel>  
    </td>
    </tr>     
    <tr>
    <td>
    <asp:Panel ID="PanelDeclaracionExportacion" runat="server" Visible="False" 
            ondatabinding="PanelVistoBuenoIndicadores_DataBinding">
    <table style="width:24%;"> 
    <tr><th colspan="4" class="form">
    <asp:Label ID="label22" runat="server" Text="Visto Bueno Declaración Exportación" 
            CssClass="subtitulo"></asp:Label>
    </th></tr>
        <tr>
            <td style="width:25%">
                <asp:Label ID="label24" runat="server" CssClass="label" 
                    Text="Número licencia exportación"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextLicenciaDeclaracionExportacion" runat="server" 
                    CssClass="texto2"></asp:TextBox>
            </td>
            <td class="separador">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width:25%">
                <asp:Label ID="label25" runat="server" CssClass="label" Text="Exportador"></asp:Label>
            </td>
            <td colspan="3">
                <asp:TextBox ID="TextExportadorDeclaracion" runat="server" CssClass="texto2" 
                    Width="468px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width:25%">
                <asp:Label ID="label26" runat="server" CssClass="label" Text="Fecha inicial"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextFechaInicialDeclaracionExportacion" runat="server" 
                    CssClass="texto2"></asp:TextBox>
                <cc1:CalendarExtender ID="CalendarExtender16" runat="server" CssClass="calendar" 
                    Format="dd/MM/yyyy" TargetControlID="TextFechaInicialDeclaracionExportacion">
                </cc1:CalendarExtender>
<%--                <cc1:CalendarExtender ID="CalendarExtender17" runat="server" CssClass="calendar" 
                    Format="dd/MM/yyyy" TargetControlID="textFechaInicial">
                </cc1:CalendarExtender>--%>
            </td>
            <td class="separador">
                <asp:Label ID="label27" runat="server" CssClass="label" 
                    Text="Fecha final"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextFechaFinalDeclaracionExportacion" runat="server" 
                    CssClass="texto2"></asp:TextBox>
                <cc1:CalendarExtender ID="CalendarExtender18" runat="server" 
                    CssClass="calendar" Format="dd/MM/yyyy" TargetControlID="TextFechaFinalDeclaracionExportacion">
                </cc1:CalendarExtender>
<%--                <cc1:CalendarExtender ID="CalendarExtender19" runat="server" 
                    CssClass="calendar" Format="dd/MM/yyyy" TargetControlID="textFechaFinal">
                </cc1:CalendarExtender>--%>
            </td>
        </tr>
    <tr>
    <td style="width:25%">
        <asp:Label ID="label28" runat="server" CssClass="label" 
            Text="Sustancia"></asp:Label>
    </td>
        <td>
            <asp:DropDownList ID="comboSustanciaDeclaracionExportacion" runat="server" 
                CssClass="combo" DataTextField="sus_Descripcion" 
                DataValueField="sus_Id" Width="153px">
            </asp:DropDownList>
        </td>
        <td class="separador">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
        <tr>
            <td colspan="4">
                <asp:Button ID="buttonDeclaracionExportacion" runat="server" CssClass="button" 
                    onclick="buttonDeclaracionExportacion_Click" Text="Buscar" />
                &nbsp;&nbsp;<asp:Button ID="button9" runat="server" CssClass="button" 
                    Text="Exportar" onclick="button9_Click" />
                &nbsp;<asp:Button ID="button10" runat="server" CssClass="button" Text="Cancelar" />
            </td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:GridView ID="GridDeclaracionExportacion" runat="server" CssClass="grilla" 
                    FooterStyle-CssClass="footergrilla" HeaderStyle-CssClass="headergrilla" 
                    RowStyle-CssClass="rowgrilla" SelectedRowStyle-CssClass="selectedgrilla" 
                    Visible="False" AllowPaging="True" AutoGenerateColumns="False" 
                    DataKeyNames="Id" DataSourceID="consultaDataSourceDeclaracionExportacion" 
                    PageSize="15">
                    <RowStyle CssClass="rowgrilla" />
                    <Columns>
                        <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" 
                            ReadOnly="True" SortExpression="Id" />
                        <asp:BoundField DataField="Número registro" HeaderText="Número registro" 
                            SortExpression="Número registro" />
                        <asp:BoundField DataField="Sustancia" HeaderText="Sustancia" 
                            SortExpression="Sustancia" />
                        <asp:BoundField DataField="Fecha declaración" HeaderText="Fecha declaración" 
                            SortExpression="Fecha declaración" />
                        <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" 
                            SortExpression="Cantidad" />
                        <asp:BoundField DataField="Valor FOB" HeaderText="Valor FOB" 
                            SortExpression="Valor FOB" />
                        <asp:BoundField DataField="Peso neto" HeaderText="Peso neto" 
                            SortExpression="Peso neto" />
                        <asp:BoundField DataField="Razón social" HeaderText="Razón social" 
                            SortExpression="Razón social" />
                        <asp:BoundField DataField="Tercero" HeaderText="Tercero" 
                            SortExpression="Tercero" />
                    </Columns>
                    <FooterStyle CssClass="footergrilla" />
                    <SelectedRowStyle CssClass="selectedgrilla" />
                    <HeaderStyle CssClass="headergrilla" />
                </asp:GridView>
                <asp:SqlDataSource ID="consultaDataSourceDeclaracionExportacion" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:BDUTOConnectionString %>" 
                    SelectCommand="exec [Iye].[spConsultaVBDeclaracionExportacion] @licencia,@importador,@fechaInicial,@fechaFinal,@sustancia">
                    <SelectParameters>
                        <asp:Parameter Name="licencia" />
                        <asp:Parameter Name="importador" />
                        <asp:Parameter Name="fechaInicial" />
                        <asp:Parameter Name="fechaFinal" />
                        <asp:Parameter Name="sustancia" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </td>
        </tr>
    </table>
    </asp:Panel>  
    </td>
    </tr>             
    </table>
    </div>
    <br />
    <br />
    <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </cc1:ToolkitScriptManager>
    </asp:Content>
