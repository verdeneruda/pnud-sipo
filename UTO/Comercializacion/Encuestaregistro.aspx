    <%@ Page Language="C#" MasterPageFile="~/MPMain.Master" AutoEventWireup="true" CodeFile="Encuestaregistro.aspx.cs" Inherits="Comercializacion_Encuestaregistro" %>

    <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
    <%@ Register src="../Comunes/ControlError.ascx" tagname="ControlError" tagprefix="uc2" %>
    <asp:Content ID="contentEncuestaRegistroHead" ContentPlaceHolderID="head" Runat="Server"></asp:Content>
    
    <asp:Content  ID="contentEncuestaRegistro" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
        <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></cc1:ToolkitScriptManager>
    <div class="divwithoutgrid">
        <table class="titulo">
            <tr>
                <td>
                    <asp:Label ID="labelAdicionarEncuesta" runat="server" Text="Módulo de seguimiento al comercio local de SAO - Adicionar datos de comercialización" CssClass="subtitulo"></asp:Label>
                </td>
            </tr>
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
                            <th colspan="5">
                                <asp:Label ID="labelDatosGenerales" runat="server" Text="Datos generales" CssClass="subtitulo"></asp:Label>
                            </th>
                        </tr>
        </table>                        
        <table class="form">
            <tr>
                <td>
                                <asp:Panel ID="PanelBuscarTercero" runat="server">                                
                                    <table class="form">
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
                                                Text="Buscar" onclick="buttonBuscarTercero_Click"/>&nbsp;&nbsp;
                                                <asp:Button ID="buttonAdicionarTercero" runat="server" CssClass="button" 
                                                Text="Adicionar" onclick="buttonAdicionarTercero_Click1"/>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="2">
                                                <asp:GridView ID="gridTerceroBuscar" runat="server" AutoGenerateColumns="False" 
                                                CssClass="grilla" 
                                                FooterStyle-CssClass="footergrilla" HeaderStyle-CssClass="headergrilla" 
                                                RowStyle-CssClass="rowgrilla" SelectedRowStyle-CssClass="selectedgrilla" 
                                                Visible="False" 
                                                Width="649px" onrowcommand="GridViewTerceroBuscar_RowCommand" 
                                                    DataKeyNames="Id" AllowPaging="True" 
                                                    DataSourceID="encuestaRegistroDataSourceBuscarEmpresa" PageSize="5" >
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
                                                    <asp:BoundField DataField="Direccion" HeaderText="Dirección" 
                                                        SortExpression="Direccion" />
                                                    <asp:BoundField DataField="Telefono" HeaderText="Teléfono" 
                                                        SortExpression="Telefono" />
                                                    <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" 
                                                        Visible="False" />
                                                </Columns>
                                                <FooterStyle CssClass="footergrilla" />
                                                <SelectedRowStyle CssClass="selectedgrilla" />
                                                <HeaderStyle CssClass="headergrilla" />
                                                </asp:GridView>
                                                <asp:SqlDataSource ID="encuestaRegistroDataSourceBuscarEmpresa" runat="server" 
                                                    ConnectionString="<%$ ConnectionStrings:BDUTOConnectionString %>" 
                                                    SelectCommand="exec [com].[spEncuestaEmpresaBuscar] @nit,@nombre">
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
                            <asp:Panel ID="panelDatosVisita" runat="server" Visible="False">                                
                                        <table class="form">
                                            <tr>
                                                <td>
                                                    <asp:Label runat="server" ID="labelfecha" Text="Fecha de visita" CssClass="label"></asp:Label>&nbsp;
                                                    <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="textFecha" runat="server"  CssClass="texto2"></asp:TextBox>    
                                                        <cc1:CalendarExtender ID="calendarFecha" Format="dd/MM/yyyy"  runat="server" CssClass="calendar" TargetControlID="textFecha">
                                                        </cc1:CalendarExtender>
                                                </td>
                                                <td class="separador">
                                                </td>
                                                <td>
                                                    <asp:Label ID="label1" runat="server" Text="Contacto" CssClass="label"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="textContacto" runat="server"  CssClass="texto2" ></asp:TextBox>
                                                </td>
                                            </tr>                                            
                                            <tr>
                                                <td>
                                                    <asp:Label runat="server" ID="labelDepartamentoEncuesta" Text="Departamento encuesta" CssClass="label"></asp:Label>&nbsp;
                                                    <asp:Label ID="Label4" runat="server" Text="(*)" Font-Bold="true"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:DropDownList ID="comboDepartamentoEncuesta" runat="server" 
                                                        CssClass="combo" AutoPostBack="True" DataTextField="dep_Descripcion" 
                                                        DataValueField="dep_Id" 
                                                        onselectedindexchanged="comboDepartamentoEncuesta_SelectedIndexChanged" >
                                                    </asp:DropDownList>
                                                </td>
                                                <td class="separador">
                                                </td>
                                                <td>
                                                    <asp:Label runat="server" ID="labelCiudadEncuesta" Text="Ciudad encuesta" CssClass="label"></asp:Label>&nbsp;
                                                    <asp:Label ID="Label5" runat="server" Text="(*)" Font-Bold="true"></asp:Label>
                                                </td>                    
                                                <td>
                                                    <asp:UpdatePanel runat="server" ID="updateCiudadEncuesta" UpdateMode="Conditional">
                                                    <ContentTemplate>
                                                    <asp:DropDownList ID="comboCiudadEncuesta" runat="server" CssClass="combo" 
                                                        DataTextField="mun_Descripcion" DataValueField="mun_Id" >
                                                    </asp:DropDownList>
                                                    </ContentTemplate>
                                                    <Triggers>
                                                    <asp:AsyncPostBackTrigger ControlID="comboDepartamentoEncuesta" />
                                                    </Triggers>
                                                    </asp:UpdatePanel>                                                    
                                                </td>
                                            </tr>
                                            <tr>
                                            <td><asp:Label runat="server" Text="Dirección encuesta" CssClass="label"></asp:Label></td>
                                            <td><asp:TextBox runat="server" ID="textDirEncuesta" CssClass="texto2" MaxLength="128" TextMode="MultiLine"></asp:TextBox></td>
                                            <td class="separador"></td>
                                            <td><asp:Label ID="Label12" runat="server" Text="Teléfono encuesta" CssClass="label"></asp:Label></td>
                                            <td><asp:TextBox runat="server" ID="textTelEncuesta" CssClass="texto2" MaxLength="50"></asp:TextBox></td>
                                            </tr>
                                        </table>                                    
                            </asp:Panel>
                            
    <asp:Panel runat="server" ID="PanelAdicionarEncuesta" Visible="False">        
                    <table class="form">             
                        <tr>
                            <th colspan="5"> <asp:Label ID="labelDatosEmpresa" runat="server" Text="Empresa" 
                                CssClass="subtitulo"></asp:Label>
                            </th>
                        </tr>
                        
                        <tr>
                            <td>
                                <asp:Label ID="labelRazonSocial" runat="server" Text="Razón social" CssClass="label"></asp:Label>&nbsp;
                                <asp:Label ID="Label6" runat="server" Text="(*)" Font-Bold="true"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="textRazonsocial" runat="server"  CssClass="texto1"></asp:TextBox>
                            </td>
                            <td class="separador">
                            </td>
                            <td>
                                <asp:Label ID="labelNit" runat="server" Text="Nit" CssClass="label"></asp:Label>&nbsp;
                                <asp:Label ID="Label7" runat="server" Text="(*)" Font-Bold="true"></asp:Label>
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
                                <asp:Label ID="labelEmail" runat="server" Text="E mail"
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
                                <asp:Label ID="labelRegional" runat="server" Text="Regional"
                                    CssClass="label"></asp:Label>        
                            </td>
                            <td>
                                <asp:DropDownList ID="comboRegional" runat="server" CssClass="combo" 
                                    DataTextField="reg_Descripcion" DataValueField="reg_Id" AutoPostBack="true" OnSelectedIndexChanged="SelectRegional">
                                </asp:DropDownList>
                            </td>
                            </tr>
                            
                            <tr>
                            <td>
                                <asp:Label ID="labelDepartamento" runat="server" CssClass="label" Text="Departamento"></asp:Label>&nbsp;
                                <asp:Label ID="Label8" runat="server" Text="(*)" Font-Bold="true"></asp:Label>
                            </td>
                            <td>
                                <asp:UpdatePanel runat="server" UpdateMode="Conditional" ID="updateDepartamento">
                                <ContentTemplate>
                                <asp:DropDownList ID="comboDepartamento" runat="server" CssClass="combo" 
                                    DataTextField="dep_Descripcion" DataValueField="dep_Id" 
                                    AutoPostBack="True" 
                                    onselectedindexchanged="comboDepartamento_SelectedIndexChanged" >
                                </asp:DropDownList>
                                </ContentTemplate>
                                <Triggers>
                                <asp:AsyncPostBackTrigger ControlID="comboRegional" />
                                </Triggers>
                                </asp:UpdatePanel>                                
                            </td>
                            <td class="separador">
                            </td>
                            <td>
                                <asp:Label ID="labelCiudad" runat="server" CssClass="label" Text="Ciudad"></asp:Label>&nbsp;
                                <asp:Label ID="Label9" runat="server" Text="(*)" Font-Bold="true"></asp:Label>
                            </td>
                            
                            <td>
                            <asp:UpdatePanel runat="server" UpdateMode="Conditional" ID="updateCiudad">
                            <ContentTemplate>
                            <asp:DropDownList ID="comboCiudad" runat="server" CssClass="combo" 
                                    DataTextField="mun_Descripcion" DataValueField="mun_Id" >
                                </asp:DropDownList>
                            </ContentTemplate>
                            <Triggers>
                                <asp:AsyncPostBackTrigger ControlID="comboDepartamento" />
                            </Triggers>
                            </asp:UpdatePanel>                                
                            </td>
                            </tr>
                            </table>                    
   </asp:Panel>

                </td>
            </tr>
        </table>
    </div>    
    <br />
    <div class="divwithoutgrid" runat="server" id="divProveedorAgregar">
    <table class="formColapsable">
    <tr>
    <td class="tdCollap">
    <!--panel colapsable de proveedores -->
    <asp:LinkButton ID="LinkProveedores" runat="server" CssClass="lnbCollap">
                                    <div>
                                        <div style="float:left">Datos proveedores</div>
                                            <div style="float: right; vertical-align: middle;">
                                                <asp:ImageButton ID="imageProveedores" runat="server" ImageUrl="~/images/fl_abajo.jpg" AlternateText="Mostrar detalles" />
                                        </div>
                                    </div>
                                </asp:LinkButton>
        <cc1:CollapsiblePanelExtender ID="colapsibleProveedores" runat="server"
        ExpandedImage="~/images/fl_arriba.jpg"  
        CollapsedImage="~/images/fl_abajo.jpg"
        ImageControlID="imageProveedores"
        SuppressPostBack="true" 
        CollapsedSize="0" 
        ExpandedSize="150" 
        ExpandControlID="linkProveedores"
        TargetControlID="panelAddProveedores" 
        CollapseControlID="linkProveedores" 
        Collapsed="true"
        />        
    </td>
    </tr>
    <tr>
    <td>
    <asp:Panel runat="server" ID="panelAddProveedores">
        <asp:Button ID="buttonAddProveedores" runat="server" Text="Adicionar" 
            CssClass="button2" onclick="buttonAddProveedores_Click"/>
        <div class="divgrillasscrollcollapsible">
        <asp:UpdatePanel runat="server" UpdateMode="Conditional">
        <ContentTemplate>
        
        <asp:GridView ID="gridProveedor" runat="server" CssClass="grilla" 
                FooterStyle-CssClass="footergrilla" HeaderStyle-CssClass="headergrilla" 
                                                RowStyle-CssClass="rowgrilla" 
                SelectedRowStyle-CssClass="selectedgrilla" 
                PageSize="5" AutoGenerateColumns="False" DataKeyNames="id" 
            onrowcommand="gridProveedor_RowCommand" >
                <RowStyle CssClass="rowgrilla" />
                <Columns>
                    <asp:ButtonField ButtonType="Button" CommandName="Eliminar" Text="Eliminar">
                        <ControlStyle CssClass="buttongrilla" />
                    </asp:ButtonField>
                    <asp:BoundField DataField="empresa" HeaderText="Empresa" />
                    <asp:BoundField DataField="documento" HeaderText="Documento" />
                    <asp:BoundField DataField="direccion" HeaderText="Dirección" />
                    <asp:BoundField DataField="telefono" HeaderText="Teléfono" />
                    <asp:BoundField DataField="id" HeaderText="Id" Visible="False" />
                </Columns>
                <FooterStyle CssClass="footergrilla" />
                <SelectedRowStyle CssClass="selectedgrilla" />
                <HeaderStyle CssClass="headergrilla" />
            </asp:GridView>
        </ContentTemplate>
        <Triggers>
        <asp:AsyncPostBackTrigger ControlID="buttonEnviarProveedoresM"/>
        </Triggers>
        </asp:UpdatePanel>        
        </div>          
    </asp:Panel>
    </td>
    </tr>
    </table>
    </div>        
    <!--table collapsible -->
    <div class="divwithoutgrid" runat="server" id="divSustanciasAgregar" 
            visible="False">
                <table class="formColapsable" >
                    <tr>
                        <td class="tdCollap">
                            <!-- panel colapsable de contactos -->
                                <asp:LinkButton ID="linkSustancias" runat="server" CssClass="lnbCollap">
                                    <div>
                                        <div style="float:left">Sustancias</div>
                                            <div style="float: right; vertical-align: middle;">
                                                <asp:ImageButton ID="imageSustancias" runat="server" ImageUrl="~/images/fl_abajo.jpg" AlternateText="Mostrar detalles" />
                                        </div>
                                    </div>
                                </asp:LinkButton>    
                            <cc1:CollapsiblePanelExtender ExpandedImage="~/images/fl_arriba.jpg"  CollapsedImage="~/images/fl_abajo.jpg" ImageControlID="imageSustancias" ID="colapsibleSustancias" SuppressPostBack="true" CollapsedSize="0" ExpandedSize="150" ExpandControlID="linkSustancias" runat="server" TargetControlID="panelSustancias" CollapseControlID="linkSustancias" Collapsed="true" >
                            </cc1:CollapsiblePanelExtender>   
                        </td>
                    </tr>
                    
                    <tr>
                        <td>
                            <asp:Panel runat="server" ID="panelSustancias" >                                
                                <asp:Button runat="server" ID="buttonAddSustancias" Text="Adicionar" CssClass="button"/>    
                                    <div class="divgrillasscrollcollapsible">
                                        <asp:GridView ID="gridSustancias" runat="server"  AutoGenerateColumns="False" 
                                                CssClass="grilla" RowStyle-CssClass="rowgrilla" 
                                                HeaderStyle-CssClass="headergrilla" FooterStyle-CssClass="footergrilla" 
                                                        onrowcommand="gridSustancias_RowCommand" DataKeyNames="id" 
                                            AllowPaging="True" PageSize="15">
                                                <RowStyle CssClass="rowgrilla" />
                                                <Columns>
                                                <asp:ButtonField ButtonType="Button" CommandName="Eliminar" 
                                                        ControlStyle-CssClass="buttongrilla" Text="Eliminar" >
                                                    <ControlStyle CssClass="buttongrilla" />
                                                    </asp:ButtonField>
                                                <asp:BoundField DataField="sustancia" HeaderText="Sustancia" 
                                                SortExpression="sustancia" />
                                                <asp:BoundField DataField="presentacion" HeaderText="Presentación" 
                                                SortExpression="presentacion" />
                                                <asp:BoundField DataField="marca" HeaderText="Marca" 
                                                SortExpression="marca" />
                                                <asp:BoundField DataField="precio" HeaderText="Precio" 
                                                        SortExpression="precio" DataFormatString="{0:c0}" />
                                                <asp:BoundField DataField="observaciones" HeaderText="Observación" 
                                                SortExpression="observaciones" />
                                                    <asp:BoundField DataField="id" Visible="False" />
                                                </Columns>
                                                <FooterStyle CssClass="footergrilla" />
                                                <HeaderStyle CssClass="headergrilla" />
                                        </asp:GridView>
                                    </div>
                            </asp:Panel>
                        </td> 
                    </tr>
                </table>                
    <br />   
    </div>
    <asp:Panel ID="panelGuardar" runat="server" Visible="false">
    <table>
        <tr>
            <td>
            &nbsp;&nbsp;&nbsp;<asp:Button ID="buttonGuardar" runat="server" Text="Guardar" 
                    CssClass="button" onclick="buttonGuardar_Click" />&nbsp;&nbsp;<asp:Button 
            ID="buttonCancelar" runat="server" Text="Cancelar"  CssClass="button" 
            onclick="buttoncancelar_Click"/>
            </td>
        </tr>
    </table>        
    </asp:Panel>
    <!-- modal de agregar sustancias -->
    <cc1:ModalPopupExtender ID="modalAddSustancias" runat="server"
        TargetControlID="buttonAddSustancias"
        PopupControlID="panelAddSustanciasM"
        BackgroundCssClass="FondoAplicacion"
        CancelControlID="buttonCancelarSustanciaM"        
    />
    <asp:Panel runat="server" ID="panelAddSustanciasM" style="display:none">
    <table class="form">
                <tr>
                    <th colspan="5">
                        <asp:Label ID="label2" runat="server" Text="Sustancia" CssClass="subtitulo">
                        </asp:Label>
                    </th>
                </tr>
                <tr>
                <td colspan="5">                
                    <uc2:ControlError ID="ControlError2" runat="server" />                
                </td>
                </tr>
                <tr>
        <td>
            <asp:Label ID="label10" runat="server" CssClass="label" Text="Fabricante"></asp:Label>&nbsp;<asp:Label ID="Label13" runat="server" Text="(*)" Font-Bold="true"></asp:Label>
        </td>
        <td><asp:DropDownList ID="comboFabricante" runat="server" CssClass="combo" DataTextField="ter_NombreCompleto" DataValueField="ter_Id"></asp:DropDownList></td>
        <td class="separador"></td>
       <td>
            <asp:Label ID="label11" runat="server" Text="Sustancia" CssClass="label"></asp:Label>&nbsp;<asp:Label ID="Label14" runat="server" Text="(*)" Font-Bold="true"></asp:Label>
        </td>
        <td><asp:DropDownList ID="comboSustancia" runat="server" CssClass="combo" DataTextField="sus_Descripcion" DataValueField="sus_Id"></asp:DropDownList></td>        
    </tr>
    <tr>
        <td class="style1">
            <asp:Label ID="labelPresentacion" runat="server" CssClass="label" 
                Text="Presentación"></asp:Label>&nbsp;<asp:Label ID="Label15" runat="server" Text="(*)" Font-Bold="true"></asp:Label>
        </td>
        <td class="style1">
            <asp:DropDownList ID="comboPresentacion" runat="server" CssClass="combo" DataTextField="psu_Descripcion" 
                DataValueField="psu_Id">
            </asp:DropDownList>
        </td>         
        <td class="separador"></td>
        <td>
            <asp:Label ID="labelMarca" runat="server" CssClass="label" Text="Marca"></asp:Label>&nbsp;<asp:Label ID="Label16" runat="server" Text="(*)" Font-Bold="true"></asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="combomarca" runat="server" CssClass="combo" 
                DataTextField="mar_Descripcion" DataValueField="mar_Id">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="labelPrecio" runat="server" Text="Precio" CssClass="label"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="textprecio" runat="server" CssClass="texto2"></asp:TextBox>
        </td>
        <td class="separador"></td>
        <td>
            <asp:Label ID="labelObservaciones" runat="server" Text="Observaciones" CssClass="label"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="textObservaciones" runat="server" CssClass="texto2" TextMode="MultiLine"></asp:TextBox>
        </td>
    </tr>    
    <tr>
    <td colspan="5">
    <asp:Button runat="server" ID="buttonGuardarSustanciaM" Text="Guardar" CssClass="button" OnClick="GuardarSustanciaM" />&nbsp;
<asp:Button runat="server" ID="buttonCancelarSustanciaM" Text="Cancelar" CssClass="button" />
    </td>
    </tr>
    </table>
    </asp:Panel>   
    <!-- modal de proveedores -->
    <cc1:ModalPopupExtender ID="modalAddProveedores" runat="server"
    TargetControlID="buttonAddProveedores"
    PopupControlID="panelAddProveedoresM"
    BackgroundCssClass="FondoAplicacion"
    CancelControlID="buttonCancelarProveedoresM"
    />
    <asp:Panel runat="server" ID="panelAddProveedoresM" style="display:none">
    <table class="form">
    <tr>
    <th colspan="2"><asp:Label runat="server" Text="Proveedores"></asp:Label></th>
    </tr>
    <tr>
    <td><asp:Label runat="server" Text="Razón social"></asp:Label></td>
    <td><asp:DropDownList ID="comboProveedor" runat="server" CssClass="combo" 
                        DataTextField="ter_NombreCompleto" DataValueField="ter_Id">
                    </asp:DropDownList></td>
    </tr>
    <tr>
    <td colspan="2">
    <asp:Button runat="server" ID="buttonEnviarProveedoresM" Text="Guardar" 
            CssClass="button2" onclick="buttonEnviarProveedoresM_Click"/>&nbsp;
    <asp:Button runat="server" ID="buttonCancelarProveedoresM" Text="Cancelar" CssClass="button2"/>
    </td>
    </tr>
    </table>
    </asp:Panel>    
    </asp:Content>
