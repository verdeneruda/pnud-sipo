    <%@ Page Language="C#" MasterPageFile="~/MPMain.Master" AutoEventWireup="true" CodeBehind="ImportadoresConsultas.aspx.cs" Inherits="UTO.RegistrosUso.ImportadoresConsultas" %>

    <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
    <asp:Content ID="contentConsultasRegistroUsoUsuariosHead" ContentPlaceHolderID="head" Runat="Server">
    </asp:Content>
    <asp:Content  ID="contentConsultasRegistroUsoUsuarios" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
    <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </cc1:ToolkitScriptManager>
    <div class="divwithoutgrid">
    <table class="titulo" >
    <tr><td>
    <asp:Label ID="labelConsultas" runat="server" Text="Módulo registro de usos - Consultas" CssClass="subtitulo"></asp:Label>
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
    <asp:DropDownList ID="comboTipoConsulta" runat="server" AutoPostBack="True" 
    CssClass="combo" 
    onselectedindexchanged="comboTipoConsulta_SelectedIndexChanged">
    </asp:DropDownList>
    </td>
    </tr>
    </table>
    </td>
    </tr>
    </table>
    </div>
    <br /> 
    <asp:MultiView runat="server" ID="multiviewConsulta" Visible="False">
    <asp:View ID="viewImportadores" runat="server"> 
    <div class="divwithoutgrid">
    <table class="form">
    <tr>
    <td>
    <table style="width:100%;"> 
    <tr><th colspan="5">
    <asp:Label ID="labelUsuariosFinales" runat="server" Text="Consulta importadores" CssClass="subtitulo"></asp:Label>
    </th></tr>
    <tr>
    <td style="width:25%">
    <asp:Label ID="labelCliente" runat="server" Text="Importador" CssClass="label"></asp:Label>
    </td>
    <td>
    <asp:DropDownList ID="comboCliente" runat="server" CssClass="combo" 
            DataTextField="ter_NombreCompleto" DataValueField="ter_Id">
    </asp:DropDownList>
    </td>
    <td class="separador"></td>
    <td> 
    <asp:Label ID="labelSustancia" runat="server" Text="Sustancia" CssClass="label"></asp:Label>
    </td>
    <td>
    <asp:DropDownList ID="comboSustancia" runat="server" CssClass="combo" 
            DataTextField="sus_Descripcion" DataValueField="sus_Id">
    </asp:DropDownList>
    </td>
    </tr>
    <tr>
    <td>
    <asp:Label ID="labelDepartamento" runat="server" Text="Departamento" CssClass="label"></asp:Label>
    </td>
    <td>
    <asp:DropDownList ID="comboDepartamento" runat="server" CssClass="combo" DataTextField="dep_Descripcion" 
    DataValueField="dep_Id">
    </asp:DropDownList>
    </td>
    <td class="separador">
    </td>
    <td>
    <asp:Label ID="labelCiudad" runat="server" Text="Ciudad" CssClass="label"></asp:Label>
    </td>
    <td>
    <asp:DropDownList ID="comboCiudad" runat="server" CssClass="combo" 
            DataTextField="mun_Descripcion" DataValueField="mun_Id">
    </asp:DropDownList>
    </td>
    </tr>
    <tr>
    <td>
    <asp:Label ID="labelAplicacion" runat="server" Text="Aplicación" CssClass="label"></asp:Label>
    </td>
    <td>
    <asp:DropDownList ID="comboAplicacion" runat="server" CssClass="combo" 
            DataTextField="apl_Descripcion" DataValueField="apl_Id">
    </asp:DropDownList>
    </td>
    <td class="separador">
    </td>
    <td>
    <asp:Label ID="labelAño" runat="server" Text="Año" CssClass="label"></asp:Label>
    </td>
    <td>
    <asp:TextBox ID="textAño" runat="server" CssClass="texto2"></asp:TextBox>
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
    <br />
    <div style="margin-left:17px; overflow:scroll;width:662px; z-index:2;">
    <asp:GridView ID="gridconsultasMRegistrosUso" runat="server" HeaderStyle-CssClass="headergrilla" 
    RowStyle-CssClass="rowgrilla" FooterStyle-CssClass="footergrilla" 
    CssClass="grilla"   AutoGenerateColumns="False" 
    SelectedRowStyle-CssClass="selectedgrilla" Visible="False" AllowPaging="True" 
            DataSourceID="importadoresConsultasDataSource" PageSize="15">
    <RowStyle CssClass="rowgrilla"></RowStyle>
        <Columns>
            <asp:BoundField DataField="Año" HeaderText="Año" SortExpression="Año" />
            <asp:BoundField DataField="Importador" HeaderText="Importador" 
                SortExpression="Importador" />
            <asp:BoundField DataField="Cliente" HeaderText="Cliente" 
                SortExpression="Cliente" />
            <asp:BoundField DataField="Sustancia" HeaderText="Sustancia" 
                SortExpression="Sustancia" />            
            <asp:BoundField DataField="Cantidad" HeaderText="Cantidad (kg)" 
                SortExpression="Cantidad" />
            <asp:BoundField DataField="Aplicación" HeaderText="Aplicación" 
                SortExpression="Aplicación" />
        </Columns>
    <FooterStyle CssClass="footergrilla"></FooterStyle>
    <SelectedRowStyle CssClass="selectedgrilla" />
    <HeaderStyle CssClass="headergrilla"></HeaderStyle>
    </asp:GridView>
        <asp:SqlDataSource ID="importadoresConsultasDataSource" runat="server" 
            ConnectionString="<%$ ConnectionStrings:BDUTOConnectionString %>" 
            SelectCommand="exec [rus].[spConsultaImportadores] @idImportador,@idSustancia,@idDepartamento,@idCiudad,@idAplicacion,@anno">
            <SelectParameters>
                <asp:Parameter Name="idImportador" />
                <asp:Parameter Name="idSustancia" />
                <asp:Parameter Name="idDepartamento" />
                <asp:Parameter Name="idCiudad" />
                <asp:Parameter Name="idAplicacion" />
                <asp:Parameter Name="anno" />
            </SelectParameters>
        </asp:SqlDataSource>
    </div>
    </div></asp:View>
    <asp:View runat="server" ID="viewUsuariosFinales">
    <div class="divwithoutgrid">
    <table class="form">
    <tr>
    <td>
    <table style="width:100%;"> 
    <tr><th colspan="5">
    <asp:Label ID="labelUsuariosFinales2" runat="server" Text="Consulta usuarios finales" CssClass="subtitulo"></asp:Label>
    </th></tr>
    <tr>
    <td style="width:25%">
    <asp:Label ID="labelfechaInicio" runat="server" Text="Fecha inicio" CssClass="label"></asp:Label>
    </td>
    <td>
    <asp:TextBox ID="textfechaInicio" runat="server" CssClass="texto2"></asp:TextBox><cc1:CalendarExtender ID="calendarFechaInicio"
    CssClass="calendar" TargetControlID="textfechaInicio" Format="dd/MM/yyyy" runat="server">
    </cc1:CalendarExtender>
    </td>
    <td class="separador"></td>
    <td> 
    <asp:Label ID="labelFechaFinal" runat="server" Text="Fecha final" CssClass="label"></asp:Label>
    </td>
    <td>
    <asp:TextBox ID="textFechaFinal" runat="server" CssClass="texto2"></asp:TextBox><cc1:CalendarExtender ID="calendarFechaFinal"
    CssClass="calendar" TargetControlID="textFechaFinal" Format="dd/MM/yyyy" runat="server">
    </cc1:CalendarExtender>
    </td>
    </tr>
    <tr>
    <td>
    <asp:Label ID="labelDepartamentoUsuario" runat="server" Text="Departamento" CssClass="label"></asp:Label>
    </td>
    <td>
    <asp:DropDownList ID="comboDepartamentoUsuarios" runat="server" CssClass="combo" DataTextField="dep_Descripcion" 
    DataValueField="dep_Id">
    </asp:DropDownList>
    </td>
    <td class="separador">
    </td>
    <td>
    <asp:Label ID="labelCiudadUsarios" runat="server" Text="Ciudad" CssClass="label"></asp:Label>
    </td>
    <td>
    <asp:DropDownList ID="comboCiudadUsuario" runat="server" CssClass="combo" 
            DataTextField="mun_Descripcion" DataValueField="mun_Id">
    </asp:DropDownList>
    </td>
    </tr>
    <tr>
    <td>
        <asp:Label ID="labelSector" runat="server" CssClass="label" Text="Sector"></asp:Label>
    </td>
    <td>
        <asp:DropDownList ID="comboSector" runat="server" CssClass="combo" 
            DataTextField="sec_Descripcion" DataValueField="sec_Id">
        </asp:DropDownList>
    </td>
    <td class="separador">
    </td>
    <td>
        <asp:Label ID="labelSustanciaUsuarios" runat="server" CssClass="label" 
            Text="Sustancia"></asp:Label>
    </td>
    <td>
        <asp:DropDownList ID="comboSustanciaUsuario" runat="server" CssClass="combo" 
            DataTextField="sus_Descripcion" DataValueField="sus_Id">
        </asp:DropDownList>
    </td>
    </tr>
    <tr>
    <td colspan="5">
    <asp:Button ID="buttonGenerarUsuariosFinales" runat="server" Text="Buscar" 
    CssClass="button" onclick="buttonGenerarUsuariosFinales_Click"/>&nbsp;&nbsp;<asp:Button ID="button1"
    runat="server" Text="Exportar" CssClass="button" onclick="button1_Click" />&nbsp;&nbsp;<asp:Button ID="buttonCancelarUsuariosFinales"
    runat="server" Text="Cancelar" CssClass="button" />
    </td>
    </tr>
    </table>
    </td>
    </tr>
    </table>
    <br />
    <div style="margin-left:17px;width:662px; z-index:2; overflow:scroll;">
    <asp:GridView ID="gridConsultaUsuariosFinales" runat="server" HeaderStyle-CssClass="headergrilla" 
    RowStyle-CssClass="rowgrilla" FooterStyle-CssClass="footergrilla" 
    CssClass="grilla"   AutoGenerateColumns="False" 
    SelectedRowStyle-CssClass="selectedgrilla" Visible="False" AllowPaging="True" 
            DataSourceID="importadoresConsultasDataSourceUsuariosFinales" PageSize="15">
    <RowStyle CssClass="rowgrilla"></RowStyle>
        <Columns>
            <asp:BoundField DataField="TipoUsuario" HeaderText="TipoUsuario" 
                SortExpression="TipoUsuario" />
            <asp:BoundField DataField="Sector" HeaderText="Sector" 
                SortExpression="Sector" />
            <asp:BoundField DataField="Empresa" HeaderText="Empresa" 
                SortExpression="Empresa" />
            <asp:BoundField DataField="Cantidad" HeaderText="Cantidad (kg)" ReadOnly="True" 
                SortExpression="Cantidad" DataFormatString="{0:#,##0.00}" >
                <ItemStyle HorizontalAlign="Right" />
            </asp:BoundField>
            <asp:BoundField DataField="Sustancia" HeaderText="Sustancia" 
                SortExpression="Sustancia" />
            <asp:BoundField DataField="CategoriaEquipo" HeaderText="CategoriaEquipo" 
                SortExpression="CategoriaEquipo" />
            <asp:BoundField DataField="TipoEquipo" HeaderText="TipoEquipo" 
                SortExpression="TipoEquipo" />
        </Columns>
    <FooterStyle CssClass="footergrilla"></FooterStyle>
    <SelectedRowStyle CssClass="selectedgrilla" />
    <HeaderStyle CssClass="headergrilla"></HeaderStyle>
    </asp:GridView>
        <asp:SqlDataSource ID="importadoresConsultasDataSourceUsuariosFinales" 
            runat="server" 
            ConnectionString="<%$ ConnectionStrings:BDUTOConnectionString %>" 
            SelectCommand="exec [rus].[spConsultaUsuarioFinal] @fechaInicio,@fechaFinal,@idDepartamento,@idCiudad,@idSector,@idSustancia">
            <SelectParameters>
                <asp:Parameter Name="fechaInicio" />
                <asp:Parameter Name="fechaFinal" />
                <asp:Parameter Name="idDepartamento" />
                <asp:Parameter Name="idCiudad" />
                <asp:Parameter Name="idSector" />
                <asp:Parameter Name="idSustancia" />
            </SelectParameters>
        </asp:SqlDataSource>
    </div>
    </div>
    </asp:View>
        <asp:View ID="viewImportadoresPublico" runat="server" >
            <div class="divwithoutgrid">
                <table style="width:100%;" class="form"> 
                    <tr><th colspan="5">
                    <asp:Label ID="label1" runat="server" Text="Consulta importadores" CssClass="subtitulo"></asp:Label>
                    </th></tr>
                    <tr>
                        <td>
                            <asp:Label ID="label4" runat="server" Text="Departamento" CssClass="label"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="comboDepartamentoPublico" runat="server" CssClass="combo" DataTextField="dep_Descripcion" 
                            DataValueField="dep_Id">
                        </asp:DropDownList>
                        </td>
                        <td class="separador">
                        </td>
                        <td>
                            <asp:Label ID="label5" runat="server" Text="Ciudad" CssClass="label"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="comboCiudadPublico" runat="server" CssClass="combo" 
                                    DataTextField="mun_Descripcion" DataValueField="mun_Id">
                        </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="label6" runat="server" Text="Aplicación" CssClass="label"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="comboAplicacionPublico" runat="server" CssClass="combo" 
                                DataTextField="apl_Descripcion" DataValueField="apl_Id">
                        </asp:DropDownList>
                        </td>
                        <td class="separador">
                        </td>
                        <td>
                            <asp:Label ID="label7" runat="server" Text="Año" CssClass="label"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="textAñoPublico" runat="server" CssClass="texto2"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td> 
                            <asp:Label ID="label3" runat="server" Text="Sustancia" CssClass="label"></asp:Label>
                        </td>
                        <td colspan="4">
                            <asp:DropDownList ID="comboSustanciaPublico" runat="server" CssClass="combo" 
                                DataTextField="sus_Descripcion" DataValueField="sus_Id">
                            </asp:DropDownList>
                        </td>
                    </tr>                    
                    <tr>
                    <td colspan="5">
                    <asp:Button ID="button2" runat="server" Text="Buscar" CssClass="button" onclick="button2_Click" 
                    />&nbsp;&nbsp;<asp:Button ID="button3"
                    runat="server" Text="Exportar" CssClass="button" onclick="buttonExportar_Click" />&nbsp;&nbsp;<asp:Button ID="button4"
                    runat="server" Text="Cancelar" CssClass="button" />
                    </td>
                    </tr>
                    </table>
            </div> 
            <br /> 
            <div style="margin-left:17px; overflow:scroll;width:662px; z-index:2;">
                <asp:GridView ID="gridImportadorPublico" runat="server" CssClass="grilla" HeaderStyle-CssClass="headergrilla" 
                    RowStyle-CssClass="rowgrilla" FooterStyle-CssClass="footergrilla" 
                    AllowPaging="True" AutoGenerateColumns="False" 
                    DataSourceID="SqlDataSourceImportadorPublico" PageSize="15" >
                    <RowStyle CssClass="rowgrilla" />
                    <Columns>
                        <asp:BoundField DataField="Año" HeaderText="Año" SortExpression="Año" />
                        <asp:BoundField DataField="Sustancia" HeaderText="Sustancia" 
                            SortExpression="Sustancia" />
                        <asp:BoundField DataField="Cantidad" HeaderText="Cantidad (kg)" ReadOnly="True" 
                            SortExpression="Cantidad" DataFormatString="{0:#,##0.00}" >
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Aplicación" HeaderText="Aplicación" 
                            SortExpression="Aplicación" />
                        <asp:BoundField DataField="Departamento" HeaderText="Departamento" 
                            SortExpression="Departamento" />
                        <asp:BoundField DataField="Ciudad" HeaderText="Ciudad" 
                            SortExpression="Ciudad" />
                    </Columns>
                    <FooterStyle CssClass="footergrilla" />
                    <HeaderStyle CssClass="headergrilla" />
                </asp:GridView>
            </div> 
            <asp:SqlDataSource ID="SqlDataSourceImportadorPublico" runat="server" 
                ConnectionString="<%$ ConnectionStrings:BDUTOConnectionString %>" SelectCommand="exec [rus].[spConsultaImportadoresPublico]
 @idSustancia, @idDepartamento 
,@idCiudad , @idAplicacion , @anno ">
                <SelectParameters>
                    <asp:Parameter Name="idSustancia" />
                    <asp:Parameter Name="idDepartamento" />
                    <asp:Parameter Name="idCiudad" />
                    <asp:Parameter Name="idAplicacion" />
                    <asp:Parameter Name="anno" />
                </SelectParameters>
            </asp:SqlDataSource>         
        </asp:View>
        <asp:View ID="viewUsusarioFinalPublico" runat="server" >
            <div class="divwithoutgrid">
                <table class="form">
                    <tr>
                    <td>
                    <table style="width:100%;"> 
                    <tr><th colspan="5">
                    <asp:Label ID="label2" runat="server" Text="Consulta usuarios finales" CssClass="subtitulo"></asp:Label>
                    </th>
                    </tr>
                    <tr>
                    <td style="width:25%">
                    <asp:Label ID="label8" runat="server" Text="Fecha inicio" CssClass="label"></asp:Label>
                    </td>
                    <td>
                    <asp:TextBox ID="textfechaInicioPublico" runat="server" CssClass="texto2"></asp:TextBox><cc1:CalendarExtender ID="CalendarExtender1"
                    CssClass="calendar" TargetControlID="textfechaInicio" Format="dd/MM/yyyy" runat="server">
                    </cc1:CalendarExtender>
                    </td>
                    <td class="separador"></td>
                    <td> 
                    <asp:Label ID="label9" runat="server" Text="Fecha final" CssClass="label"></asp:Label>
                    </td>
                    <td>
                    <asp:TextBox ID="textFechaFinalPublico" runat="server" CssClass="texto2"></asp:TextBox><cc1:CalendarExtender ID="CalendarExtender2"
                    CssClass="calendar" TargetControlID="textFechaFinal" Format="dd/MM/yyyy" runat="server">
                    </cc1:CalendarExtender>
                    </td>
                    </tr>
                    <tr>
                    <td>
                    <asp:Label ID="label10" runat="server" Text="Departamento" CssClass="label"></asp:Label>
                    </td>
                    <td>
                    <asp:DropDownList ID="comboDepartamentoUsuariosPublico" runat="server" 
                            CssClass="combo" DataTextField="dep_Descripcion" 
                    DataValueField="dep_Id">
                    </asp:DropDownList>
                    </td>
                    <td class="separador">
                    </td>
                    <td>
                    <asp:Label ID="label11" runat="server" Text="Ciudad" CssClass="label"></asp:Label>
                    </td>
                    <td>
                    <asp:DropDownList ID="comboCiudadUsuarioPublico" runat="server" CssClass="combo" 
                            DataTextField="mun_Descripcion" DataValueField="mun_Id">
                    </asp:DropDownList>
                    </td>
                    </tr>
                    <tr>
                    <td>
                        <asp:Label ID="label12" runat="server" CssClass="label" Text="Sector"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="comboSectorPublico" runat="server" CssClass="combo" 
                            DataTextField="sec_Descripcion" DataValueField="sec_Id">
                        </asp:DropDownList>
                    </td>
                    <td class="separador">
                    </td>
                    <td>
                        <asp:Label ID="label13" runat="server" CssClass="label" 
                            Text="Sustancia"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="comboSustanciaUsuarioPublico" runat="server" CssClass="combo" 
                            DataTextField="sus_Descripcion" DataValueField="sus_Id">
                        </asp:DropDownList>
                    </td>
                    </tr>
                    <tr>
                    <td colspan="5">
                    <asp:Button ID="button5" runat="server" Text="Buscar" 
                    CssClass="button" onclick="button5_Click"/>&nbsp;&nbsp;<asp:Button ID="button6"
                    runat="server" Text="Exportar" CssClass="button" onclick="button1_Click" />&nbsp;&nbsp;<asp:Button ID="button7"
                    runat="server" Text="Cancelar" CssClass="button" />
                    </td>
                    </tr>
                    </table>
                    </td>
                    </tr>
                    </table>
            
            </div>        
            <br />
            <div style="margin-left:17px;width:662px; z-index:2; overflow:scroll;">
                <asp:GridView ID="gridusuarioPublico" runat="server" CssClass="grilla" HeaderStyle-CssClass="headergrilla" 
                    RowStyle-CssClass="rowgrilla" FooterStyle-CssClass="footergrilla" 
                    AllowPaging="True" AutoGenerateColumns="False" 
                    DataSourceID="SqlDataSourceUsuarioPublico" PageSize="15" >
                    <RowStyle CssClass="rowgrilla" />
                    <Columns>
                        <asp:BoundField DataField="TipoUsuario" HeaderText="TipoUsuario" 
                            SortExpression="TipoUsuario" />
                        <asp:BoundField DataField="Sector" HeaderText="Sector" 
                            SortExpression="Sector" />
                        <asp:BoundField DataField="Departamento" HeaderText="Departamento" 
                            SortExpression="Departamento" />
                        <asp:BoundField DataField="Municipio" HeaderText="Municipio" 
                            SortExpression="Municipio" />
                        <asp:BoundField DataField="Cantidad" HeaderText="Cantidad (Kg)" ReadOnly="True" 
                            SortExpression="Cantidad" DataFormatString="{0:#,##0.00}" >
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Sustancia" HeaderText="Sustancia" 
                            SortExpression="Sustancia" />
                        <asp:BoundField DataField="CategoriaEquipo" HeaderText="CategoriaEquipo" 
                            SortExpression="CategoriaEquipo" />
                        <asp:BoundField DataField="TipoEquipo" HeaderText="TipoEquipo" 
                            SortExpression="TipoEquipo" />
                    </Columns>
                    <FooterStyle CssClass="footergrilla" />
                    <HeaderStyle CssClass="headergrilla" />
                </asp:GridView>
            </div>
            <asp:SqlDataSource ID="SqlDataSourceUsuarioPublico" runat="server" 
                ConnectionString="<%$ ConnectionStrings:BDUTOConnectionString %>" SelectCommand="exec [rus].[spConsultaUsuarioFinalPublico]
@fechaInicio, @fechaFinal, @idDepartamento 
,@idCiudad , @idSector , @idSustancia">
                <SelectParameters>
                    <asp:Parameter Name="fechaInicio" />
                    <asp:Parameter Name="fechaFinal" />
                    <asp:Parameter Name="idDepartamento" />
                    <asp:Parameter Name="idCiudad" />
                    <asp:Parameter Name="idSector" />
                    <asp:Parameter Name="idSustancia" />
                </SelectParameters>
            </asp:SqlDataSource>
        </asp:View>
    </asp:MultiView>
    <br />
    </asp:Content>
