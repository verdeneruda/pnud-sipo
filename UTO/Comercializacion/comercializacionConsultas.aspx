    <%@ Page Language="C#" MasterPageFile="~/MPMain.Master" AutoEventWireup="true" CodeBehind="comercializacionConsultas.aspx.cs" Inherits="UTO.Comercializacion.comercializacionConsultas" %>

    <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
    <%@ Register src="../Comunes/ControlError.ascx" tagname="ControlError" tagprefix="uc1" %>
    <asp:Content ID="contentComercializacionConsultasHead" ContentPlaceHolderID="head" Runat="Server">
    </asp:Content>
    <asp:Content  ID="contentComercializacionConsultas" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
    <asp:XmlDataSource ID="xmlConsultas" runat="server" 
    DataFile="~/App_Data/MComercializacionTipoConsulta.xml"></asp:XmlDataSource>
    <asp:XmlDataSource ID="XmlSustancia" runat="server" 
    DataFile="~/App_Data/MComercializacionConSustancia.xml"></asp:XmlDataSource>
    <asp:XmlDataSource ID="XmlPresentacion" runat="server" 
    DataFile="~/App_Data/MComercializacionConPresentacion.xml"></asp:XmlDataSource>
    <asp:XmlDataSource ID="XmlMarcaConsulta" runat="server" 
    DataFile="~/App_Data/MComercializacionConMarca.xml"></asp:XmlDataSource> 
    <asp:XmlDataSource ID="xmlCiudad" runat="server" 
    DataFile="~/App_Data/ciudades.xml"></asp:XmlDataSource>
    <asp:XmlDataSource ID="xmlDepartamento" runat="server" 
    DataFile="~/App_Data/departamento.xml"></asp:XmlDataSource>
    <asp:XmlDataSource ID="XmlConsultaPrecio" runat="server" 
    DataFile="~/App_Data/MComercializacionConsPrecio.xml"></asp:XmlDataSource>

    <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </cc1:ToolkitScriptManager>       

    <div class="divwithoutgrid">
        <table class="titulo" >
            <tr>
                <td>
                    <asp:Label ID="labelConsultas" runat="server" Text="Módulo de seguimiento al comercio local de SAO - Consultas" CssClass="subtitulo"></asp:Label>
                </td>
            </tr>
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
                                <asp:DropDownList ID="comboTipoConsulta" runat="server" DataSourceID="xmlConsultas" 
                                    DataTextField="descripcion" DataValueField="value" 
                                    onselectedindexchanged="DropDownList1_SelectedIndexChanged" AutoPostBack="true" CssClass="combo">
                                </asp:DropDownList>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </div>
    
    <br />

    <asp:MultiView ID="multiviewConsultas" runat="server" Visible="False">
    <asp:View ID="viewMarcas" runat="server">
        <div class="divwithoutgrid">
        <table class="form">
            <tr>
                <td>
                    <table style="width:100%;">
                        <tr>
                            <th colspan="5">
                                <asp:Label ID="labelMarcascomerciales" runat="server" Text="Consulta marcas comerciales" CssClass="subtitulo"></asp:Label>
                            </th>
                        </tr>
                        <tr>
                            <td style="width:25%">
                                <asp:Label ID="labelSustanciaMarca" runat="server" Text="Seleccione sustancia"></asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="comboSustanciaMarca" runat="server" CssClass="combo" 
                                    DataTextField="sus_Descripcion" DataValueField="sus_Id">
                                </asp:DropDownList>
                            </td>
                            <td class="separador">
                            </td>
                            <td> 
                                <asp:Label ID="labelPresentacionMarca" runat="server" Text="Seleccione presentación"></asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="comboPresentacionMarca" runat="server" CssClass="combo" DataTextField="psu_Descripcion" 
                                    DataValueField="psu_Id">
                                </asp:DropDownList>
                            </td>
                         </tr>
                         
                        <tr>
                            <td>
                                <asp:Label ID="labelDepartamentoMarca" runat="server" Text="Seleccione departamento"></asp:Label>
                            </td>
                            <td>  
                                <asp:DropDownList ID="comboDepartamentoMarca" runat="server" CssClass="combo" DataTextField="dep_Descripcion" 
                                    DataValueField="dep_Id" AutoPostBack="True" 
                                    onselectedindexchanged="comboDepartamentoMarca_SelectedIndexChanged">
                                </asp:DropDownList>
                            </td>
                            <td class="separador">
                            </td>
                            <td>
                                <asp:Label ID="labelCiudadMarca" runat="server" Text="Seleccione ciudad" CssClass="label"></asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="comboCiudadMarca" runat="server" CssClass="combo" 
                                    DataTextField="mun_Descripcion" DataValueField="mun_Id">
                                </asp:DropDownList>
                            </td>
                         </tr>
                         
                        <tr>
                            <td>
                                <asp:Label ID="labelFechaInicialMarca" runat="server" Text="Seleccione fecha inicial" CssClass="label"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="textFechaInicialMarca" runat="server"  CssClass="texto2"></asp:TextBox>
                                <cc1:CalendarExtender ID="calendarFechaInicialMarca" Format="dd/MM/yyyy"  runat="server" CssClass="calendar" TargetControlID="textFechaInicialMarca">
                                </cc1:CalendarExtender>
                            </td>
                            <td class="separador">
                            </td>
                            <td>
                                <asp:Label ID="labelFechaFinalMarca" runat="server" Text="Seleccione fecha final" CssClass="label"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="textFechaFinalMarca" runat="server"  CssClass="texto2"></asp:TextBox>
                                <cc1:CalendarExtender ID="calendarFechafinalMarca" Format="dd/MM/yyyy"  runat="server" CssClass="calendar" TargetControlID="textFechaFinalMarca">
                                </cc1:CalendarExtender>
                            </td>
                         </tr>
                         
                        <tr>
                            <td colspan="5">
                                <asp:Button ID="buttonBuscar" runat="server" Text="Buscar" CssClass="button" 
                                    onclick="buttonBuscar_Click" />&nbsp;&nbsp;<asp:Button ID="buttonExportar"
                                    runat="server" Text="Exportar" CssClass="button" 
                                    onclick="buttonExportar_Click" />&nbsp;&nbsp;<asp:Button ID="buttonCancelar"
                                    runat="server" Text="Cancelar" CssClass="button" />
                            </td>
                         </tr>
                    </table>
                </td>
            </tr>
        </table>
    </div>
    
    <br />
    
        <div class="divgrillas">
        <asp:GridView ID="gridconsultasMarcasComercializacion" runat="server" HeaderStyle-CssClass="headergrilla" 
            RowStyle-CssClass="rowgrilla" FooterStyle-CssClass="footergrilla" 
            CssClass="grilla" AutoGenerateColumns="False" 
            SelectedRowStyle-CssClass="selectedgrilla" Visible="False" AllowPaging="True" 
                DataSourceID="comercializacionConsultasDataSource" PageSize="15">
            <RowStyle CssClass="rowgrilla"></RowStyle>
            <Columns>
                <asp:BoundField DataField="Sustancia" HeaderText="Sustancia" 
                    SortExpression="Sustancia" />
                <asp:BoundField DataField="Presentacion" HeaderText="Presentación" 
                    SortExpression="Presentacion" />
                <asp:BoundField DataField="Marca" HeaderText="Marca" SortExpression="Marca" />
                <asp:BoundField DataField="Departamento" HeaderText="Departamento" 
                    SortExpression="Departamento" />
                <asp:BoundField DataField="Ciudad" HeaderText="Ciudad" 
                    SortExpression="Ciudad" />
            </Columns>
            <FooterStyle CssClass="footergrilla"></FooterStyle>
            <SelectedRowStyle CssClass="selectedgrilla" />
            <HeaderStyle CssClass="headergrilla"></HeaderStyle>
        </asp:GridView>
            <asp:SqlDataSource ID="comercializacionConsultasDataSource" runat="server" 
                ConnectionString="<%$ ConnectionStrings:BDUTOConnectionString %>" 
                SelectCommand="exec [com].[spConsultaSustancia]@idSustancia,@idPresentacion,@idDepartamento,@idCiudad,@fechaInicial,@fechaFinal">
                <SelectParameters>
                    <asp:Parameter Name="idSustancia" />
                    <asp:Parameter Name="idPresentacion" />
                    <asp:Parameter Name="idDepartamento" />
                    <asp:Parameter Name="idCiudad" />
                    <asp:Parameter Name="fechaInicial" />
                    <asp:Parameter Name="fechaFinal" />
                </SelectParameters>
            </asp:SqlDataSource>
    </div>
    
    <br />
    
    </asp:View>

    <asp:View ID="ViewPrecio" runat="server">
        <div class="divwithoutgrid">
            <table class="form">
                <tr>
                    <td>
                        <table style="width:100%;"> 
                            <tr>
                                <th colspan="5">
                                    <asp:Label ID="labelPrecioPromedio" runat="server" Text="Consulta precio promedio" CssClass="subtitulo"></asp:Label>
                                </th>
                            </tr>
                            
                            <tr>
                                <td style="width:25%">
                                    <asp:Label ID="labelPrecioSustancia" runat="server" Text="Seleccione sustancia"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="comboPrecioSustancia" runat="server" CssClass="combo" 
                                        DataTextField="sus_Descripcion" DataValueField="sus_Id">
                                    </asp:DropDownList>
                                </td>
                                <td class="separador">
                                </td>
                                <td> 
                                    <asp:Label ID="labelPrecioPresentacion" runat="server" Text="Seleccione presentación"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="comboPrecioPresentacion" runat="server" CssClass="combo" DataTextField="psu_Descripcion" 
                                        DataValueField="psu_Id">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            
                            <tr>
                                <td>
                                    <asp:Label ID="labelDepartamentoPrecio" runat="server" Text="Seleccione departamento"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="comboDepartamentoPrecio" runat="server" CssClass="combo" DataTextField="dep_Descripcion" 
                                        DataValueField="dep_Id" AutoPostBack="True" 
                                        onselectedindexchanged="comboDepartamentoPrecio_SelectedIndexChanged">
                                    </asp:DropDownList>
                                </td>
                                <td class="separador">
                                </td>
                                <td>
                                    <asp:Label ID="labelCiudadPrecio" runat="server" Text="Seleccione ciudad" CssClass="label"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="comboCiudadPrecio" runat="server" CssClass="combo" 
                                        DataTextField="mun_Descripcion" DataValueField="mun_Id">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            
                            <tr>
                                <td>
                                    <asp:Label ID="labelFechaInicialPrecio" runat="server" Text="Seleccione fecha inicial" CssClass="label"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="textFechaInicialPrecio" runat="server"  CssClass="texto2"></asp:TextBox>
                                    <cc1:CalendarExtender ID="calendarFecha" Format="dd/MM/yyyy"  runat="server" CssClass="calendar" TargetControlID="textFechaInicialPrecio">
                                    </cc1:CalendarExtender>
                                </td>
                                <td class="separador">
                                </td>
                                <td>
                                    <asp:Label ID="labelFechaFinalPrecio" runat="server" Text="Seleccione fecha final" CssClass="label"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="textFechaFinalPrecio" runat="server"  CssClass="texto2"></asp:TextBox>
                                    <cc1:CalendarExtender ID="calendarFechaFinalPrecio" Format="dd/MM/yyyy"  runat="server" CssClass="calendar" TargetControlID="textFechaFinalPrecio">
                                    </cc1:CalendarExtender>
                                </td>
                            </tr>
                            
                            <tr>
                                <td colspan="5">
                                    <asp:Button ID="buttonBuscarPrecio" runat="server" Text="Buscar" CssClass="button" 
                                        onclick="buttonBuscarPrecio_Click" />&nbsp;&nbsp;<asp:Button ID="buttonExportar2"
                                        runat="server" Text="Exportar" CssClass="button" 
                                        onclick="buttonExportar2_Click" />&nbsp;&nbsp;<asp:Button ID="buttonCancelarPrecio"
                                        runat="server" Text="Cancelar" CssClass="button" />
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </div>
        
    <br />
    
    <div class="divgrillas">
        <asp:GridView ID="GridPrecio" runat="server" HeaderStyle-CssClass="headergrilla" 
            RowStyle-CssClass="rowgrilla" FooterStyle-CssClass="footergrilla" CssClass="grilla" 
            AutoGenerateColumns="False" 
            SelectedRowStyle-CssClass="selectedgrilla" Visible="False" 
            AllowPaging="True" DataSourceID="comercializacionConsultasDataSourcePrecio" 
            PageSize="15">
            <RowStyle CssClass="rowgrilla"></RowStyle>
            <Columns>
                <asp:BoundField DataField="Sustancia" HeaderText="Sustancia" 
                    SortExpression="Sustancia" />
                <asp:BoundField DataField="Presentacion" HeaderText="Presentación" 
                    SortExpression="Presentacion" />
                <asp:BoundField DataField="Departamento" HeaderText="Departamento" 
                    SortExpression="Departamento" />
                <asp:BoundField DataField="Ciudad" HeaderText="Ciudad" 
                    SortExpression="Ciudad" />
                <asp:BoundField DataField="FechaInicial" HeaderText="Fecha inicial" 
                    SortExpression="FechaInicial" DataFormatString="{0:dd/MM/yyyy}"/>
                    <asp:BoundField DataField="FechaFinal" HeaderText="Fecha final" 
                    SortExpression="FechaFinal" DataFormatString="{0:dd/MM/yyyy}"/>
                <asp:BoundField DataField="PrecioPromedio" HeaderText="Precio promedio" 
                    SortExpression="PrecioPromedio" />
             </Columns>
                <FooterStyle CssClass="footergrilla"></FooterStyle>
                <SelectedRowStyle CssClass="selectedgrilla" />
                <HeaderStyle CssClass="headergrilla"></HeaderStyle>
        </asp:GridView>
    
        <asp:SqlDataSource ID="comercializacionConsultasDataSourcePrecio" 
            runat="server" 
            ConnectionString="<%$ ConnectionStrings:BDUTOConnectionString %>" 
            SelectCommand="exec [com].[spConsultaPromedio] @idSustancia,@idPresentacion,@idDepartamento,@idCiudad,@fechaInicial,@fechaFinal">
            <SelectParameters>
                <asp:Parameter Name="idSustancia" />
                <asp:Parameter Name="idPresentacion" />
                <asp:Parameter Name="idDepartamento" />
                <asp:Parameter Name="idCiudad" />
                <asp:Parameter Name="fechaInicial" />
                <asp:Parameter Name="fechaFinal" />
            </SelectParameters>
        </asp:SqlDataSource>    
    </div>    
    <br />    
    </asp:View>
    </asp:MultiView>   
    </asp:Content>
