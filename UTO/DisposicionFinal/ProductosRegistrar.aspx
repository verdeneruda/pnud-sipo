    <%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MPMain.Master"  CodeBehind="ProductosRegistrar.aspx.cs" Inherits="UTO.DisposicionFinal.ProductosRegistrar" %>

    <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
    <%@ Register src="../Comunes/ControlError.ascx" tagname="ControlError" tagprefix="uc2" %>
    <asp:Content ID="contentProductosDisposicionFinalRegistrarHead" ContentPlaceHolderID="head" Runat="Server">

        <script language="javascript" type="text/javascript">
    function calendarShown(sender, args)
    {
    sender._popupBehavior._element.style.zIndex = 10005;
    }
    </script>
    </asp:Content>
    
    <asp:Content  ID="contentProductosDisposicionFinalRegistrar" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
        <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
        </cc1:ToolkitScriptManager>
        <asp:Panel ID="panelForma" runat="server">
        
    <div class="divwithoutgrid">
        <table class="titulo" >
            <tr>
                <td>
                    <asp:Label ID="labelAdicionarProductosDisposicionfinal" runat="server" Text="Módulo disposición final - Adicionar sustancias disposición final" CssClass="subtitulo"></asp:Label>
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
                <td>
                    <table style="width:100%;"> 
                        <tr>
                            <th>
                                <asp:Label ID="labelDatosGenerales" runat="server" Text="Datos generales" CssClass="subtitulo"></asp:Label>
                            </th>
                        </tr>
                        
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
                                            <%--<td>
                                            </td>--%>
                                        </tr>
                                        <tr>
                                            <td colspan="2">
                                                <asp:Button ID="buttonBuscarTercero" runat="server" CssClass="button" 
                                                    Text="Buscar empresa" onclick="buttonBuscarTercero_Click" />
                                                <asp:Button ID="buttonAdicionarTercero" runat="server" CssClass="button" 
                                                    Text="Adicionar empresa" onclick="buttonAdicionarTercero_Click"/>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="2">
                                                <asp:GridView ID="GridViewTerceroBuscar" runat="server" AutoGenerateColumns="False" 
                                                    CssClass="grilla" 
                                                    FooterStyle-CssClass="footergrilla" HeaderStyle-CssClass="headergrilla" 
                                                    RowStyle-CssClass="rowgrilla" SelectedRowStyle-CssClass="selectedgrilla" 
                                                    Visible="False" 
                                                    Width="649px" onrowcommand="GridViewTerceroBuscar_RowCommand" 
                                                    DataKeyNames="Id" AllowPaging="True" DataSourceID="productoRegistrarDataSource" 
                                                    PageSize="15">
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
                                                        <asp:BoundField DataField="Id" SortExpression="Id" />
                                                    </Columns>
                                                <FooterStyle CssClass="footergrilla" />
                                                <SelectedRowStyle CssClass="selectedgrilla" />
                                                <HeaderStyle CssClass="headergrilla" />
                                                </asp:GridView>
                                                <asp:SqlDataSource ID="productoRegistrarDataSource" runat="server" 
                                                    ConnectionString="<%$ ConnectionStrings:BDUTOConnectionString %>" 
                                                    SelectCommand="exec [dis].[spSustanciaEmpresaBuscar] @nit,@nombre">
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
                                <asp:Panel ID="panelAdicionarDisposicionfinal" runat="server">
                                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                        <ContentTemplate>
                                            <table>
                                                <tr>
                                        <td>
                                            <asp:Label runat="server" ID="labelfecha" Text="Fecha" CssClass="label"></asp:Label>&nbsp
                                            <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>
                                        </td>
                                        <td> 
                                            <asp:TextBox ID="textFecha" runat="server"  CssClass="texto2"></asp:TextBox>
                                            <cc1:CalendarExtender ID="calendarFecha" Format="dd/MM/yyyy"  runat="server" CssClass="calendar" TargetControlID="textFecha">
                                            </cc1:CalendarExtender>
                                        </td>
                                        <td class="separador"></td>
                                        <td>
                                            <asp:Label ID="labelDepartamento" runat="server" Text="Departamento" CssClass="label"></asp:Label>&nbsp
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
                                            <asp:Label ID="labelCiudad" runat="server" Text="Ciudad" CssClass="label"></asp:Label>&nbsp
                                            <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:DropDownList ID="comboCiudad" runat="server" CssClass="combo" 
                                                    DataTextField="mun_Descripcion" DataValueField="mun_Id">
                                            </asp:DropDownList>
                                        </td>
                                        <%--<td class="separador"></td>
                                        <td>
                                        </td>
                                        <td>
                                        </td>--%>
                                    </tr>
                                            </table>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </asp:Panel>
                            </td>
                        </tr>
                        
                        <tr>
                            <td>
                                <asp:Panel ID="panelDatosTercero" runat="server" 
                                    Visible="False">
                                    <table>
                                        <tr>
                                            <th colspan="5"> 
                                                <asp:Label ID="labelDatosEmpresa" runat="server" Text="Empresa" 
                                                CssClass="subtitulo"></asp:Label>
                                            </th>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:Label ID="labelRazonSocial" runat="server" Text="Razón social"
                                                CssClass="label"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="textRazonsocial" runat="server"  CssClass="texto1"></asp:TextBox>
                                            </td>
                                            <td class="separador">
                                            </td>                                            
                                            <td>
                                                <asp:Label ID="label4" runat="server" Text="Tipo de documento"
                                                CssClass="label"></asp:Label>                                                                                      
                                            </td>
                                            <td>
                                                <asp:DropDownList ID="comboTipoDocumento" runat="server" CssClass="combo" 
                                                    DataTextField="dti_Descripcion" DataValueField="dti_Id" 
                                                    AutoPostBack="True" 
                                                    onselectedindexchanged="comboTipoDocumento_SelectedIndexChanged">
                                                </asp:DropDownList>
                                            </td>

                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:Label ID="labelNit" runat="server" Text="Documento"
                                                CssClass="label"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="textNit" runat="server"  CssClass="texto2"></asp:TextBox>
                                            </td>
                                        <td class="separador">
                                        </td>
                                        <td>
                                            <asp:Label runat="server" Text="Teléfono" CssClass="label" ID="labelTelefono"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="textTelefono" runat="server"  CssClass="texto2"></asp:TextBox>
                                        </td>


                                    </tr>
                                        <tr>
                                        <td>
                                            <asp:Label ID="labelEmail" runat="server" Text="E mail"
                                            CssClass="label"></asp:Label>    
                                        </td>
                                        <td>
                                            <asp:TextBox ID="textEmail" runat="server"  CssClass="texto2"></asp:TextBox>
                                        </td>
                                        <td class="separador">
                                        </td>                                                                                
                                        <td>
                                            <asp:Label ID="labelDireccion" runat="server" Text="Dirección"
                                            CssClass="label"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="textDireccion" runat="server"  CssClass="texto2"></asp:TextBox>
                                        </td>

                                    </tr>
                                        <tr>
                                        <td>
                                            <asp:Label ID="label3" runat="server" CssClass="label" 
                                                Text="Regional"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:DropDownList ID="comboRegional" runat="server" CssClass="combo" 
                                                DataTextField="reg_Descripcion" DataValueField="reg_Id" >
                                            </asp:DropDownList>
                                        </td>                  
                                        <td class="separador">
                                        </td>                                                              
                                        <td>
                                            <asp:Label ID="label1" runat="server" CssClass="label" 
                                                Text="Departamento"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:DropDownList ID="comboDepartamentoTercero" runat="server" CssClass="combo" 
                                                DataTextField="dep_Descripcion" DataValueField="dep_Id" 
                                                AutoPostBack="True" onselectedindexchanged="comboDepartamentoTercero_SelectedIndexChanged" 
                                                 >
                                            </asp:DropDownList>
                                        </td>



                                    </tr>   
                                    <tr>
                                        <td>
                                            <asp:Label ID="label2" runat="server" CssClass="label" Text="Ciudad"></asp:Label>
                                        </td>                                    
                                        <td>
                                            <asp:DropDownList ID="comboCiudadTercero" runat="server" CssClass="combo" 
                                                DataTextField="mun_Descripcion" DataValueField="mun_Id" >
                                            </asp:DropDownList>
                                        </td>
                                        <td class="separador">
                                        </td>  
                                        <td>
                                        </td>
                                        <td>
                                        </td>
                                    </tr> 
                                    </table>
                                </asp:Panel>
                            </td>
                        </tr>    
                    </table>
             
            
     </div>
     
    <br />
    
    <!--table collapsible -->
    <div class="divwithoutgrid" id="divDisposicionfinal" runat="server" visible="False">
        <table class="formColapsable" >
            <tr>
                <td class="tdCollap">
                    <!-- panel colapsable de contactos -->
                        <asp:LinkButton ID="linkProductosDisposicion" runat="server" CssClass="lnbCollap">
                            <div>
                                <div style="float:left">Sustancias disposición final</div><div style="float: right; vertical-align: middle;">
                                    <asp:ImageButton ID="imageSustancias" runat="server" ImageUrl="~/images/fl_abajo.jpg" AlternateText="Mostrar detalles" />
                                </div>
                            </div>
                        </asp:LinkButton> 
                        
                        <cc1:CollapsiblePanelExtender ExpandedImage="~/images/fl_arriba.jpg"  CollapsedImage="~/images/fl_abajo.jpg" ImageControlID="imageSustancias" ID="colapsibleproductosDisposicionFinal" SuppressPostBack="true" CollapsedSize="0"  ExpandControlID="linkProductosDisposicion" runat="server" TargetControlID="panelProductosDisposicion" CollapseControlID="linkProductosDisposicion" Collapsed="true" >
                        </cc1:CollapsiblePanelExtender>
                </td>
            </tr>
            
            <tr>
                <td>
                    <asp:Panel runat="server" ID="panelProductosDisposicion">
                        <asp:Button ID="buttonAgregar" runat="server" Text="Agregar" CssClass="button" 
                            onclick="buttonAgregar_Click"/>
                        
                        <asp:Panel runat="server" ID="panelAddProductosdisposicion" Visible="false">
                            <table class="formModal">
                                <tr>
                                    <th colspan="5">Adicionar sustancia
                                    </th>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="labelSustanciaDisposicion" runat="server" Text="Sustancia" CssClass="label"></asp:Label>&nbsp
                                        <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>
                                        
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="comboSustancia" runat="server" 
                                            CssClass="combo" DataTextField="sus_Descripcion" 
                                            DataValueField="sus_Id" >
                                        </asp:DropDownList>
                                    </td>
                                    <td >
                                    &nbsp;
                                    </td>
                                    <td>
                                        <asp:Label ID="labelPresentacionDisposicion" 
                                            runat="server" Text="Presentación" CssClass="label"></asp:Label>&nbsp
                                        <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>   
                                    </td>
                                    <td>    
                                        <asp:DropDownList ID="comboPresentacion" runat="server" 
                                            CssClass="combo" 
                                            DataValueField="psu_Id" DataTextField="psu_Descripcion" ></asp:DropDownList>
                                    </td>
                                </tr>                                
                                <tr>
                                    <td>
                                        <asp:Label ID="labelCantidad0" runat="server" CssClass="label" Text="Cantidad (kg)"></asp:Label>&nbsp
                                        <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="textCantidadMaestro" runat="server" CssClass="texto2"></asp:TextBox>
                                    </td>
                                    <td >
                                    &nbsp;
                                    </td>
                                    <td>
                                        <asp:Label ID="labelEstado" runat="server" Text="Estado" CssClass="label"></asp:Label>&nbsp
                                        <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="comboestado" runat="server" CssClass="combo" DataTextField="des_Descripcion" 
                                            DataValueField="des_Id"></asp:DropDownList>
                                    </td>
                               </tr>
                               
                                <tr>
                                    <td>
                                        <asp:Label ID="labelObservaciones" runat="server" Text="Observaciones" 
                                            CssClass="label"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="textObservaciones" runat="server" CssClass="texto2" 
                                            TextMode="MultiLine"></asp:TextBox>
                                    </td>
                                    <td >
                                        &nbsp;
                                    </td>
                                    <td>
                                        <asp:Label ID="labelfechaDetalle" runat="server" CssClass="label" Text="Fecha"></asp:Label>&nbsp                    
                                    </td>
                                    <td>
                                        <asp:TextBox ID="textFechaRegistro" runat="server" CssClass="texto2"></asp:TextBox>
                                        <cc1:CalendarExtender ID="CalendarExtender1" Format="dd/MM/yyyy"  runat="server" CssClass="calendar" TargetControlID="textFechaRegistro" OnClientShown="calendarShown">
                                        </cc1:CalendarExtender>
                                    </td>
                                </tr>
                                
                                <tr>
                                    <td colspan="5">
                                        <asp:Button ID="buttonAdicionarActualizacion_" runat="server" 
                                            Text="Adicionar actualización" class="button2" 
                                            onclick="buttonAdicionarActualizacion_Click1" Visible="False"/>
                                        <asp:GridView ID="gridActualizacion" runat="server"  AutoGenerateColumns="False" 
                                                CssClass="grilla" RowStyle-CssClass="rowgrilla" 
                                                HeaderStyle-CssClass="headergrilla" FooterStyle-CssClass="footergrilla" 
                                                onrowcommand="gridActualizacion_RowCommand" DataKeyNames="id">
                                            <RowStyle CssClass="rowgrilla" />
                                                <Columns>
                                                    <asp:ButtonField ButtonType="Button" Text="Eliminar" 
                                                        ControlStyle-CssClass="buttongrilla" >
                                                        <ControlStyle CssClass="buttongrilla" />
                                                    </asp:ButtonField>
                                                    <asp:BoundField DataField="Fecha" HeaderText="Fecha" SortExpression="Fecha" />
                                                    <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" 
                                                    SortExpression="Cantidad" />
                                                    <asp:BoundField DataField="Observación" HeaderText="Observación" 
                                                    SortExpression="Observación" />
                                                </Columns>
                                            <FooterStyle CssClass="footergrilla" />
                                            <HeaderStyle CssClass="headergrilla" />
                                        </asp:GridView>
                                    </td>
                                </tr>
                                
                                <tr>
                                    <td>
                                        <asp:Button ID="buttonEnviarProducto" runat="server" Text="Guardar sustancia" 
                                            class="button2" onclick="buttonEnviarProducto_Click" />
                                    </td>
                                    <td colspan="4">
                                        <asp:Button ID="buttonCancelarProducto" runat="server" Text="Cancelar sustancia" 
                                        class="button2" onclick="buttonCancelarProducto_Click" />
                                    </td>
<%--                                    <td class="separador">
                                    &nbsp;
                                    </td>
                                    <td>
                                    &nbsp;
                                    </td>
                                    <td>
                                    &nbsp;
                                    </td>--%>
                                </tr>
                            </table>
                        </asp:Panel>
                        
                        <div class="divgrillasscrollcollapsible" id="divProductosGrilla" runat="server" visible="false">
                            <asp:GridView ID="gridProductosSustanciasSao" runat="server"  AutoGenerateColumns="False" 
                                CssClass="grilla" RowStyle-CssClass="rowgrilla" 
                                HeaderStyle-CssClass="headergrilla" FooterStyle-CssClass="footergrilla" 
                                onrowcommand="gridProductosSustanciasSao_RowCommand" DataKeyNames="id">
                                <RowStyle CssClass="rowgrilla" />
                                <Columns>
                                    <asp:ButtonField ButtonType="Button" CommandName="Modificar" Text="Modificar" 
                                        ControlStyle-CssClass="buttongrilla">
                                        <ControlStyle CssClass="buttongrilla" />
                                    </asp:ButtonField>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:Button runat="server" ID="buttonEliminar" Text="Eliminar" CommandName="Eliminar" CommandArgument="<%# Container.DataItemIndex %>" OnClientClick="return confirm('Este registro se eliminará, desea continuar?')" CssClass="buttongrilla"/>
                                        </ItemTemplate> 
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="sustancia" HeaderText="Sustancia" 
                                        SortExpression="sustancia" />
                                    <asp:BoundField DataField="presentacion" HeaderText="Presentación" 
                                        SortExpression="presentacion" />
                                    <asp:BoundField DataField="cantidad" HeaderText="Cantidad (kg)" 
                                        SortExpression="cantidad" />
                                    <asp:BoundField DataField="estado" HeaderText="Estado" 
                                        SortExpression="estado" />
                                    <asp:BoundField DataField="observaciones" HeaderText="Observación" 
                                        SortExpression="observaciones" />
                                    <asp:BoundField DataField="id" HeaderText="id" SortExpression="id" 
                                        Visible="False" />
                                    <asp:BoundField DataField="ddd_Actualizacion" HeaderText="Actualización" 
                                    SortExpression="ddd_Actualizacion" Visible="False" />
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
    
 <%--       <table>
        <tr>
            <td>
                &nbsp;&nbsp;&nbsp;
            </td>
        </tr>
    </table>--%>
    
    </div>
    
    <table>
        <tr>
            <td>
                <asp:Button ID="buttonGuardar" runat="server" Text="Guardar" CssClass="button" 
                    onclick="buttonGuardar_Click" />&nbsp;&nbsp;<asp:Button 
                    ID="buttonCancelar" runat="server" Text="Cancelar"  CssClass="button" 
                    onclick="buttonCancelar_Click"/>
            </td>
        </tr>
    </table> 
      
    <br />
    
    <!-- modal de contactos -->
  <%--      <cc1:ModalPopupExtender ID="popupActualizacion" runat="server" TargetControlID="buttonAgregar" PopupControlID="panelAddActualizacion" OkControlID="buttonEnviarActualizacion" CancelControlID="buttonCancelarActualizacion" BackgroundCssClass="FondoAplicacion">
        </cc1:ModalPopupExtender> --%>
    
    <asp:Panel ID="panelAddActualizacion" runat="server" 
            style="   overflow:auto; height:400px" Visible="False">
        <table class="formModal">
            <tr>
                <th colspan="2">Actualización
                </th>
            </tr>
            <tr>
                <td colspan="2">
                &nbsp;
                </td>
            </tr>
            
            <tr>
                <td>
                    <asp:Label ID="labelCantidadDetalle" runat="server" CssClass="label" Text="Cantidad"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="textCantidadDetalle" runat="server" CssClass="texto2"></asp:TextBox>
                </td>
            </tr>
            
            <tr>
                <td>
                    <asp:Label ID="labelObservacionDetalle" runat="server" CssClass="label" 
                        Text="Observación"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="textObservacionDetalle" runat="server" CssClass="texto2" 
                        TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            
            <tr>
                <td colspan="2">
                    <asp:Button ID="buttonAdicionarActualizacion" runat="server" Text="Guardar" 
                        CssClass="button" onclick="buttonEnviarActualizacion_Click" />&nbsp;&nbsp;<asp:Button 
                        ID="buttonCancelarActualizacion" runat="server" Text="Cancelar"  CssClass="button"  />
                </td>
            </tr>
        </table>
    </asp:Panel>
   </asp:Panel>
     
    
       
    </asp:Content>