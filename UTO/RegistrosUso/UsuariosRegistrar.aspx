    <%@ Page Language="C#" MasterPageFile="~/MPMain.Master" AutoEventWireup="true" CodeBehind="UsuariosRegistrar.aspx.cs" Inherits="UTO.RegistrosUso.UsuariosRegistrar" %>

    <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
    <%@ Register src="../Comunes/ControlError.ascx" tagname="ControlError" tagprefix="uc2" %>
    <asp:Content ID="contentRegistrarRegistroUsoUsuariosHead" ContentPlaceHolderID="head" Runat="Server">
    </asp:Content>
    <asp:Content  ID="contentRegistrarRegistroUsoUsuarios" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
    <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </cc1:ToolkitScriptManager>
    <div class="divwithoutgrid">
    <table class="titulo" >
    <tr><td>
    <asp:Label ID="labelRegistrarRegistrosUsoUsuarios" runat="server" Text="Módulo registro de usos - Adicionar usuarios finales" CssClass="subtitulo"></asp:Label>
    </td></tr>
    </table>
    <table class="form">
        <tr>
            <td>
                <uc2:ControlError ID="ControlError1" runat="server" />
            </td>
        </tr>
    </table>    
    <br />
    <table class="form">
    <tr>
    <td><table style="width:100%">
    <tr><th colspan="5">
    <asp:Label ID="labelDatosGenerales" runat="server" Text="Datos generales" CssClass="subtitulo"></asp:Label>
    </th></tr>
    <tr>
    <td>
    <asp:Panel ID="PanelBuscarTercero" runat="server">
    <table style="width:685px">
    <tr>
    <th colspan="2">   
    <asp:Label ID="labelBuscarEmpresa" runat="server" Text="Buscar Empresa" 
    CssClass="subtitulo"></asp:Label>
    </th>
    </tr>
    <tr>
    <td>
    <asp:Label ID="labelRazonSocialBusqueda" runat="server" Text="Razón social" CssClass="label"></asp:Label>
    </td>
    <td>
    <asp:TextBox ID="textRazonSocialBusqueda" runat="server"  CssClass="texto2" 
    Width="449px"></asp:TextBox>
    </td>
    </tr>
    <tr>
    <td>
    <asp:Label ID="labelNitBusqueda" runat="server" CssClass="label" 
    Text="Nit"></asp:Label>
    </td>
    <td>
    <asp:TextBox ID="textNitBusqueda" runat="server" CssClass="texto2"></asp:TextBox>
    </td>
    </tr>
    <tr>
    <td colspan="2">
    <asp:Button ID="buttonBuscarTercero" runat="server" CssClass="button" 
    Text="Buscar" onclick="buttonBuscarTercero_Click" />
    <asp:Button ID="buttonAdicionarTercero" runat="server" CssClass="button" 
    Text="Adicionar" onclick="buttonAdicionarTercero_Click"/>
    </td>
    </tr>
    <tr>
    <td colspan="2">
    <asp:GridView ID="GridViewTerceroBuscar" runat="server" AutoGenerateColumns="False" 
    CssClass="grilla" 
    FooterStyle-CssClass="footergrilla" HeaderStyle-CssClass="headergrilla" 
    RowStyle-CssClass="rowgrilla" SelectedRowStyle-CssClass="selectedgrilla" 
    Visible="False" 
    Width="649px" onrowcommand="GridViewTerceroBuscar_RowCommand" DataKeyNames="Id" 
            AllowPaging="True" DataSourceID="usuarioRegistrarDataSource" PageSize="15">
    <RowStyle CssClass="rowgrilla" />
    <Columns>
    <asp:ButtonField ButtonType="Button" CommandName="Seleccionar" ShowHeader="True" 
    Text="Seleccionar">
    <ControlStyle CssClass="buttongrilla" Width="100px" />
    </asp:ButtonField>
    <asp:BoundField DataField="Regional" HeaderText="Regional" 
    SortExpression="Regional" />
    <asp:BoundField DataField="Empresa" HeaderText="Empresa" 
    SortExpression="Empresa" />
    <asp:BoundField DataField="TipoDocumento" HeaderText="TipoDocumento" 
    SortExpression="TipoDocumento" />
    <asp:BoundField DataField="Documento" HeaderText="Documento" 
    SortExpression="Documento" />
        <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
    </Columns>
    <FooterStyle CssClass="footergrilla" />
    <SelectedRowStyle CssClass="selectedgrilla" />
    <HeaderStyle CssClass="headergrilla" />
    </asp:GridView>
        <asp:SqlDataSource ID="usuarioRegistrarDataSource" runat="server" 
            ConnectionString="<%$ ConnectionStrings:BDUTOConnectionString %>" 
            SelectCommand="exec [rus].[spUsuarioEmpresaBuscar] @nit,@nombre">
            <SelectParameters>
                <asp:Parameter Name="nit" />
                <asp:Parameter Name="nombre" />
            </SelectParameters>
        </asp:SqlDataSource>
    </td>
    </tr>
    </table>
        </asp:Panel>
    </td>
    </tr>
    <tr>
    <td>
    <asp:Panel runat="server" ID="panelDatosempresa" Visible="false">
    <table>
    <tr>
    <td>
    <asp:Label ID="labelTipoUsuario" runat="server" Text="Tipo usuario"
    CssClass="label"></asp:Label>&nbsp
    <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>
    </td>
    <td>
    <asp:DropDownList ID="comboTipoUsuario" runat="server" CssClass="combo" DataTextField="utf_Descripcion" 
    DataValueField="utf_Id">
    </asp:DropDownList>
    </td>
    <td class="separador">
    </td>
    <td>
    <asp:Label ID="labelSector" runat="server" Text="Sector"
    CssClass="label"></asp:Label>&nbsp
    <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>
    
    </td>
    <td>
    <asp:DropDownList ID="comboSector" runat="server" CssClass="combo" 
            DataTextField="sec_Descripcion" DataValueField="sec_Id">
    </asp:DropDownList>
    </td>
    </tr>
    <tr>
    <td>
    <asp:Label ID="labelfecha" runat="server" Text="Fecha de la visita"
    CssClass="label"></asp:Label>&nbsp
    <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>
    </td>
    <td>
    <asp:TextBox ID="textFecha" runat="server" CssClass="texto2"></asp:TextBox><cc1:CalendarExtender ID="calendarFecha"
    CssClass="calendar" TargetControlID="textfecha" Format="dd/MM/yyyy" runat="server">
    </cc1:CalendarExtender>

    </td>
    <td class="separador">
    </td>
    <td>
    <asp:Label ID="labelDepartamentoDatosgenerales" runat="server" Text="Departamento de la visita"
    CssClass="label"></asp:Label>&nbsp
    <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>
    </td>
    <td>
    <asp:DropDownList ID="comboDepartamento" runat="server" CssClass="combo" DataTextField="dep_Descripcion" 
    DataValueField="dep_Id" AutoPostBack="True" 
            onselectedindexchanged="comboDepartamento_SelectedIndexChanged">
    </asp:DropDownList>
    </td>
    </tr>
    <tr>
    <td>
    <asp:Label ID="labelciudadDatosgenerales" runat="server" Text="Ciudad de la visita"
    CssClass="label"></asp:Label>
    </td>
    <td>
    <asp:UpdatePanel runat="server" UpdateMode="Conditional">
    <ContentTemplate>
    <asp:DropDownList ID="comboCiudad" runat="server" CssClass="combo" 
            DataTextField="mun_Descripcion" DataValueField="mun_Id">
    </asp:DropDownList>
    </ContentTemplate>
    <Triggers>
    <asp:AsyncPostBackTrigger ControlID="comboDepartamento" />
    </Triggers>
    </asp:UpdatePanel>    
    </td>
    <td class="separador">
    </td>
    <td>
        &nbsp;</td>
    <td>
                            <cc1:CalendarExtender ID="CalendarExtender1" Format="dd/MM/yyyy"  runat="server" CssClass="calendar" TargetControlID="textFecha">
                            </cc1:CalendarExtender>
    </td>
    </tr>
    <tr>
    <th colspan="5"> <asp:Label ID="labelDatosEmpresa" runat="server" Text="Empresa" 
    CssClass="subtitulo"></asp:Label></th>
    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="labelRazonSocial" runat="server" Text="Razón social"
                            CssClass="label"></asp:Label>&nbsp;<asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="textRazonsocial" runat="server"  CssClass="texto1"></asp:TextBox>
                        </td>
                        <td class="separador">
                        </td>
                        <td>
                            <asp:Label ID="labelNit" runat="server" Text="Nit"
                            CssClass="label"></asp:Label>&nbsp;<asp:Label ID="Label17" runat="server" Text="(*)" Font-Bold="true"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="textNit" runat="server"  CssClass="texto2"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" Text="Teléfono" CssClass="label" ID="labelTelefono"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="textTelefono" runat="server"  CssClass="texto2"></asp:TextBox>
                        </td>
                        <td class="separador">
                        </td>
                        <td>
                            <asp:Label ID="labelEmail" runat="server" Text="E-mail"
                            CssClass="label"></asp:Label>    
                        </td>
                        <td>
                            <asp:TextBox ID="textEmail" runat="server"  CssClass="texto2"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="labelDireccion" runat="server" Text="Dirección"
                            CssClass="label"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="textDireccion" runat="server"  CssClass="texto2"></asp:TextBox>
                        </td>
                        <td class="separador">
                        </td>
                        <td>
                            <asp:Label ID="label3" runat="server" CssClass="label" 
                                Text="Regional"></asp:Label>&nbsp;<asp:Label ID="Label18" runat="server" Text="(*)" Font-Bold="true"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="comboRegional" runat="server" CssClass="combo" 
                                DataTextField="reg_Descripcion" DataValueField="reg_Id" AutoPostBack="true" OnSelectedIndexChanged="SelectRegional">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="label1" runat="server" CssClass="label" 
                                Text="Departamento"></asp:Label>&nbsp;<asp:Label ID="Label19" runat="server" Text="(*)" Font-Bold="true"></asp:Label>
                        </td>
                        <td>
                            <asp:UpdatePanel runat="server" UpdateMode="Conditional">
                            <ContentTemplate>
                            <asp:DropDownList ID="comboDepartamentoTercero" runat="server" CssClass="combo" 
                                DataTextField="dep_Descripcion" DataValueField="dep_Id" 
                                AutoPostBack="True" onselectedindexchanged="comboDepartamentoTercero_SelectedIndexChanged"  
                                 >
                            </asp:DropDownList>
                            </ContentTemplate>
                            <Triggers>
                            <asp:AsyncPostBackTrigger ControlID="comboRegional"/>
                            </Triggers>
                            </asp:UpdatePanel>                            
                        </td>
                        <td class="separador">
                        </td>
                        <td>
                            <asp:Label ID="label2" runat="server" CssClass="label" Text="Ciudad"></asp:Label>&nbsp;<asp:Label ID="Label20" runat="server" Text="(*)" Font-Bold="true"></asp:Label>
                        </td>
                        <td>
                        <asp:UpdatePanel runat="server" UpdateMode="Conditional" ID="updateCiudadTercero">
                        <ContentTemplate>
                        <asp:DropDownList ID="comboCiudadTercero" runat="server" CssClass="combo" 
                                DataTextField="mun_Descripcion" DataValueField="mun_Id" >
                            </asp:DropDownList>
                        </ContentTemplate>
                        <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="comboDepartamentoTercero" />
                        </Triggers>
                        </asp:UpdatePanel>                            
                        </td>
                    </tr>    
    </table>
    </asp:Panel>
    </td>
    </tr>
    <tr>
    <td runat="server" id="trColProductos" style="display:none">
    <table class="formColapsable">
    <!-- colaspsable -->
    <tr>
    <td class="tdCollap">
    <asp:LinkButton ID="linkEquipos" runat="server" CssClass="lnbCollap">
    <div>
    <div style="float:left">Sustancias</div>
    <div style="float: right; vertical-align: middle;">
    <asp:ImageButton ID="imageEquipos" runat="server" ImageUrl="~/images/fl_abajo.jpg" AlternateText="Mostrar detalles" />    
    </div>
    </div>
    </asp:LinkButton>
    <cc1:CollapsiblePanelExtender ID="colapsibleProductos" runat="server"
    ExpandedImage="~/images/fl_arriba.jpg"  
    CollapsedImage="~/images/fl_abajo.jpg" 
    ImageControlID="imageEquipos"     
    SuppressPostBack="true" 
    ExpandControlID="linkEquipos" 
    TargetControlID="panelProductos" 
    CollapseControlID="linkEquipos" 
    Collapsed="true" 
    />    
    </td>
    </tr>
    <tr>
    <td>
    <asp:Panel runat="server" ID="panelProductos">
    <table>    
    <tr>
    <td>
    <asp:Button ID="buttonAgregar" runat="server" Text="Adicionar" CssClass="button"/><br />
    <div class="divgrillasscrollcollapsible">
        <asp:GridView ID="gridDetalle" runat="server"  AutoGenerateColumns="False" 
        CssClass="grilla" RowStyle-CssClass="rowgrilla" 
        HeaderStyle-CssClass="headergrilla" FooterStyle-CssClass="footergrilla" 
                onrowcommand="gridDetalle_RowCommand" DataKeyNames="id">
        <RowStyle CssClass="rowgrilla" />
        <Columns>
            <asp:ButtonField ButtonType="Button" CommandName="Eliminar" Text="Eliminar"  
                ControlStyle-CssClass="buttongrilla" >
    <ControlStyle CssClass="buttongrilla"></ControlStyle>
            </asp:ButtonField>
        <asp:BoundField DataField="sustancia" HeaderText="Sustancia_Usada" 
        SortExpression="sustancia" />
        <asp:BoundField DataField="cantidad" HeaderText="Cantidad_Usada_Anual (kg)" 
        SortExpression="sustancia" />
        <asp:BoundField DataField="categoria" HeaderText="Categoria_Equipo" 
        SortExpression="categoria" />
        <asp:BoundField DataField="tipo" HeaderText="Tipo_Equipo" 
        SortExpression="tipo" />
        <asp:BoundField DataField="numero" HeaderText="Num_Unidades" 
        SortExpression="numero" />
            <asp:BoundField DataField="id" HeaderText="Id" SortExpression="id" />
        </Columns>
        <FooterStyle CssClass="footergrilla" />
        <HeaderStyle CssClass="headergrilla" />
        </asp:GridView>
    </div>
    </td>
    </tr>
    </table>
    </asp:Panel>
    </td>
    </tr>
    </table>   
    </td>
    </tr>    
    </table>
    </td>
    </tr>
    </table>
    <br />
     <table>
        <tr>
            <td>
                &nbsp;&nbsp;&nbsp;<asp:Button ID="buttonGuardar" runat="server" Text="Guardar" 
                CssClass="button" onclick="buttonGuardar_Click" />&nbsp;&nbsp;<asp:Button 
                ID="buttoncancelar" runat="server" Text="Cancelar"  CssClass="button" 
                onclick="buttoncancelar_Click"/>
            </td>
        </tr>
    </table>    
    </div>
    <!-- modal productos -->
    <cc1:ModalPopupExtender ID="modalAddProductos" runat="server"
        TargetControlID="buttonAgregar"
        PopupControlID="panelAddProductos"
        BackgroundCssClass="FondoAplicacion"
        CancelControlID="buttonCancelarProducto"
    />
    <asp:Panel runat="server" ID="panelAddProductos">
    <table class="form">
    <tr>
    <th colspan="2">Sustancias</th>
    </tr>
    <tr>
    <td colspan="2">    
        <uc2:ControlError ID="ControlError2" runat="server" />    
    </td>
    </tr>    
    <tr>
            <td>
                <asp:Label ID="labelSustanciaUsada" runat="server" Text="Sustancia usada" CssClass="label"></asp:Label>&nbsp
                <asp:Label ID="Label4" runat="server" Text="(*)" Font-Bold="true"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="comboSustanciaUsada" CssClass="combo" runat="server" DataTextField="sus_Descripcion" 
                    DataValueField="sus_Id">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="LabelCantidadUsadaAnual" runat="server" Text="Cantidad sustancia usada anual Kg" CssClass="label"></asp:Label>&nbsp
                <asp:Label ID="Label7" runat="server" Text="(*)" Font-Bold="true"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="textCantidadUsadaAnual" runat="server" CssClass="texto2"></asp:TextBox>
            </td>
        </tr>        
        <tr>
            <td>
                <asp:Label ID="labeCategoria" runat="server" Text="Categoría equipo" 
                    CssClass="label"></asp:Label>&nbsp
                <asp:Label ID="Label6" runat="server" Text="(*)" Font-Bold="true"></asp:Label>   
            </td>
            <td> 
                <asp:DropDownList ID="comboCategoria" CssClass="combo" runat="server" 
                    DataTextField="ceq_Descripcion" DataValueField="ceq_Id" 
                    AutoPostBack="True" 
                    onselectedindexchanged="comboCategoria_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="labelTipoEquipo" runat="server" Text="Tipo equipo" CssClass="label"></asp:Label>&nbsp
                <asp:Label ID="Label5" runat="server" Text="(*)" Font-Bold="true"></asp:Label>
            </td>
            <td>
                <asp:UpdatePanel runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                <asp:DropDownList ID="comboTipoEuipo" CssClass="combo" runat="server" 
                    DataTextField="eti_Descripcion" DataValueField="eti_Id">
                </asp:DropDownList>
                </ContentTemplate>
                <Triggers>
                <asp:AsyncPostBackTrigger ControlID="comboCategoria" />
                </Triggers>
                </asp:UpdatePanel>                
            </td>
        </tr>
        <tr>
        <td><asp:Label ID="Label8" runat="server" Text="Número unidades" 
                    CssClass="label"></asp:Label></td>
        <td><asp:TextBox runat="server" CssClass="texto2" ID="textNumeroUnidades"></asp:TextBox></td>
        </tr>
        <tr>
        <td><asp:Label ID="Label9" runat="server" Text="Carga promedio instalada" 
                    CssClass="label"></asp:Label></td>
        <td><asp:TextBox runat="server" CssClass="texto2" ID="textcargaPromedioInstalada"></asp:TextBox></td>
        </tr>
        <tr>
        <td><asp:Label ID="Label10" runat="server" Text="Carga promedio por mantenimiento" 
                    CssClass="label"></asp:Label></td>
        <td><asp:TextBox runat="server" CssClass="texto2" ID="textCargaPromedioPorMantenimiento"></asp:TextBox></td>
        </tr>
        <tr>
        <td><asp:Label ID="Label11" runat="server" Text="Consumo energético" 
                    CssClass="label"></asp:Label></td>
        <td><asp:TextBox runat="server" CssClass="texto2" ID="textConsumoEnergetico"></asp:TextBox></td>
        </tr>
        <tr>
        <td><asp:Label ID="Label12" runat="server" Text="Potencia compresor" 
                    CssClass="label"></asp:Label></td>
        <td><asp:TextBox runat="server" CssClass="texto2" ID="textPotenciaCompresor"></asp:TextBox></td>
        </tr>
        <tr>
        <td><asp:Label ID="Label13" runat="server" Text="Volumen útil" 
                    CssClass="label"></asp:Label></td>
        <td><asp:TextBox runat="server" CssClass="texto2" ID="textVolumentUtil"></asp:TextBox></td>
        </tr>
        <tr>
        <td><asp:Label ID="Label14" runat="server" Text="Capacidad enfriamiento" 
                    CssClass="label"></asp:Label></td>
        <td><asp:TextBox runat="server" CssClass="texto2" ID="textCapacidadEnfriamiento"></asp:TextBox></td>
        </tr>
<%--        <tr>
        <td><asp:Label ID="Label16" runat="server" Text="Vigencia" 
                    CssClass="label"></asp:Label></td>
        <td>
        <asp:TextBox runat="server" ID="textVigencia" CssClass="texto2"></asp:TextBox>
        </td>
        </tr>  --%>      
        <tr>
        <td><asp:Label ID="Label15" runat="server" Text="Observaciones" 
                    CssClass="label"></asp:Label></td>
        <td>
        <asp:TextBox runat="server" ID="textObservaciones" TextMode="MultiLine" MaxLength="200" CssClass="texto2"></asp:TextBox>
        </td>
        </tr>        
        <tr>
    <td colspan="2">
    <asp:Button ID="buttonEnviarProducto" runat="server" Text="Guardar" 
                    CssClass="button" onclick="buttonEnviarProducto_Click" />&nbsp;&nbsp;<asp:Button 
                    ID="buttonCancelarProducto" runat="server" Text="Cancelar"  CssClass="button" 
                    onclick="buttonCancelarProducto_Click"  />
    </td>
    </tr>
    </table>
    </asp:Panel>
</asp:Content>
    

