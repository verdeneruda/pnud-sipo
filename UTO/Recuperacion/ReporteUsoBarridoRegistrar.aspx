<%@ Page Language="C#" MasterPageFile="~/MPMain.Master" AutoEventWireup="true" CodeBehind="ReporteUsoBarridoRegistrar.aspx.cs" Inherits="UTO.Recuperacion.ReporteUsoBarridoRegistrar" %>
    <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

    <%@ Register src="~/Comunes/DocumentosVarios.ascx" tagname="DocumentosVarios" tagprefix="uc1" %>

    <%@ Register src="../Comunes/ControlError.ascx" tagname="ControlError" tagprefix="uc2" %>
    
    <asp:Content  ID="contentSolicitudEquiposBuscar" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
       
        <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </cc1:ToolkitScriptManager>
    <div class="divwithoutgrid">
    <table class="titulo" >
        <tr><td>
        <asp:Label ID="labelBusquedaSolicitudesEquipos" runat="server" 
                Text="Proyectos de dotación de equipos y herramientas  para el sector de refrigeración y aire acondicionado - Kit de barrido y limpieza con nitrógeno y filtros de alto rendimiento - Eliminación del R-141b en Actividades de Limpieza - Reporte de uso" 
                CssClass="subtitulo"></asp:Label>
        </td></tr>
    </table>
    <table class = "form">
    <tr>
    <td>
    
        <uc2:ControlError ID="ControlError2" runat="server" />
    
    </td>    
    </tr>
    </table>    
    <table class="form">
        <tr>
    <td><table style="width:100%">
    <tr>
    <td>
        <asp:Panel ID="PanelBuscarTercero" runat="server" Width="671px">
            <table>
                 <tr>
                    <th colspan="5">   
                    <asp:Label ID="labelparametros" runat="server" Text="Buscar tercero" 
                            CssClass="subtitulo"></asp:Label>
                    </th>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="labelNombreBeneficiario" runat="server" Text="Nombre tercero" 
                            CssClass="label"></asp:Label>
                    </td>
                    <td colspan="4">
                        <asp:TextBox ID="textNombreBeneficiarioBuscar" runat="server"  CssClass="texto2" 
                            Width="449px"></asp:TextBox>
                    </td>
                    <td class="separador">
                        &nbsp;</td>
                </tr>
                 <tr>
                     <td>
                         <asp:Label ID="label3" runat="server" CssClass="label" Text="Tipo documento"></asp:Label>
                     </td>
                     <td>
                         <asp:DropDownList ID="comboTipoDocumentoBuscar" runat="server" CssClass="combo" DataTextField="dti_Descripcion" 
                             DataValueField="dti_Id" Width="106px">
                         </asp:DropDownList>
                     </td>
                     <td>
                         <asp:Label ID="labelNumeroDocumento" runat="server" CssClass="label" 
                             Text="Número documento"></asp:Label>
                     </td>
                     <td>
                         <asp:TextBox ID="textNumeroDocumentoBuscar" runat="server" CssClass="texto2" 
                             Width="127px"></asp:TextBox>
                     </td>
                     <td class="style1">
                         &nbsp;</td>
                     <td class="separador">
                         &nbsp;</td>
                 </tr>
                <tr>
                    <td colspan="6">
                        <asp:Button ID="buttonBuscarTercero" runat="server" CssClass="button" 
                            Text="Buscar" onclick="buttonBuscarTercero_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="6">
                        <asp:GridView ID="GridViewTerceroBuscar" runat="server" 
                            AutoGenerateColumns="False" CssClass="grilla" DataKeyNames="ter_id" 
                            DataSourceID="dsBuscarTercero" FooterStyle-CssClass="footergrilla" 
                            HeaderStyle-CssClass="headergrilla" 
                            onrowcommand="GridViewTerceroBuscar_RowCommand" RowStyle-CssClass="rowgrilla" 
                            SelectedRowStyle-CssClass="selectedgrilla" Width="649px" 
                            AllowPaging="True" PageSize="15" 
                            EmptyDataText="La búsqueda no encontró resultados.">
                            <RowStyle CssClass="rowgrilla" />
                            <Columns>
                                <asp:ButtonField ButtonType="Button" CommandName="Seleccionar" 
                                    Text="Seleccionar">
                                    <ControlStyle CssClass="button" />
                                </asp:ButtonField>
                                <asp:BoundField DataField="ter_id" HeaderText="ter_id" InsertVisible="False" 
                                    ReadOnly="True" SortExpression="ter_id" />
                                <asp:BoundField DataField="TipoDocumento" HeaderText="TipoDocumento" 
                                    SortExpression="TipoDocumento" />
                                <asp:BoundField DataField="ter_NumeroDocumento" 
                                    HeaderText="ter_NumeroDocumento" SortExpression="ter_NumeroDocumento" />
                                <asp:BoundField DataField="ter_NombreCompleto" HeaderText="ter_NombreCompleto" 
                                    SortExpression="ter_NombreCompleto" />
                                <asp:BoundField DataField="reg_descripcion" HeaderText="reg_descripcion" 
                                    SortExpression="reg_descripcion" Visible="False" />
                                <asp:BoundField DataField="dep_descripcion" HeaderText="dep_descripcion" 
                                    SortExpression="dep_descripcion" Visible="False" />
                                <asp:BoundField DataField="mun_descripcion" HeaderText="mun_descripcion" 
                                    SortExpression="mun_descripcion" Visible="False" />
                                <asp:BoundField DataField="ter_Tefono" HeaderText="ter_Tefono" 
                                    SortExpression="ter_Tefono" Visible="False" />
                                <asp:BoundField DataField="ter_Direccion" HeaderText="ter_Direccion" 
                                    SortExpression="ter_Direccion" Visible="False" />
                                <asp:BoundField DataField="ter_Correo" HeaderText="ter_Correo" 
                                    SortExpression="ter_Correo" Visible="False" />
                                <asp:BoundField DataField="ter_Celular" HeaderText="ter_Celular" 
                                    SortExpression="ter_Celular" Visible="False" />
                                <asp:BoundField DataField="tpj_EstablecimientoComercio" 
                                    HeaderText="tpj_EstablecimientoComercio" 
                                    SortExpression="tpj_EstablecimientoComercio" Visible="False" />
                                <asp:BoundField DataField="tpj_RepresentanteLegal" 
                                    HeaderText="tpj_RepresentanteLegal" SortExpression="tpj_RepresentanteLegal" 
                                    Visible="False" />
                                <asp:BoundField DataField="tpj_NumeroDocumento" 
                                    HeaderText="tpj_NumeroDocumento" SortExpression="tpj_NumeroDocumento" 
                                    Visible="False" />
                            </Columns>
                            <FooterStyle CssClass="footergrilla" />
                            <SelectedRowStyle CssClass="selectedgrilla" />
                            <HeaderStyle CssClass="headergrilla" />
                        </asp:GridView>
                    </td>
                </tr>
                 <tr>
                     <td colspan="6">
                         <asp:SqlDataSource ID="dsBuscarTercero" runat="server" 
                             ConnectionString="<%$ ConnectionStrings:BDUTOConnectionString %>" SelectCommand="exec Rrr.spBeneficiarioBuscar @beneficiario, @documento, @tipoDocumento
">
                             <SelectParameters>
                                 <asp:Parameter Name="beneficiario" />
                                 <asp:Parameter Name="documento" />
                                 <asp:Parameter Name="tipoDocumento" />
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
        <asp:Panel ID="PanelDatosTercero" runat="server" Visible="False" Width="716px">
         <table>
             <tr>
                <th colspan="4">   
                <asp:Label ID="label11" runat="server" Text="Datos tercero" 
                        CssClass="subtitulo"></asp:Label>
                </th>
            </tr>
             <tr>
                 <td width="160px">
                     <asp:Label ID="labelNombreBeneficiario0" runat="server" CssClass="label" 
                         Text="Nombre beneficiario"></asp:Label>
                 </td>
                 <td>
                     <asp:TextBox ID="textNombreBeneficiario" runat="server" CssClass="texto2" 
                         Enabled="False" Width="190px"></asp:TextBox>
                 </td>
                 <td>
                     <asp:Label ID="labelTipoDocumento" runat="server" CssClass="label" 
                         Text="Tipo documento"></asp:Label>
                 </td>
                 <td>
                     <asp:TextBox ID="textTipoDocumento" runat="server" CssClass="texto2" 
                         Enabled="False" Width="150px"></asp:TextBox>
                 </td>
             </tr>
             <tr>
                 <td>
                     <asp:Label ID="labelDocumento" runat="server" CssClass="label" Text="Documento"></asp:Label>
                 </td>
                 <td>
                     <asp:TextBox ID="textDocumento" runat="server" AutoCompleteType="Disabled" 
                         CssClass="texto2"
                         Width="190px" Enabled="False"></asp:TextBox>
                 </td>
                 <td>
                     <asp:Label ID="labelRut" runat="server" CssClass="label" Text="Rut"></asp:Label>
                 </td>
                 <td>
                     <asp:TextBox ID="textRut" runat="server" CssClass="texto2" Width="150px" 
                         Enabled="False"></asp:TextBox>
                 </td>
             </tr>
             <tr>
                 <td>
                     <asp:Label ID="labelRepresentanteLegal" runat="server" CssClass="label" 
                         Text="Representante legal"></asp:Label>
                 </td>
                 <td>
                     <asp:TextBox ID="textNombreRepresentante" runat="server" CssClass="texto2" 
                         Width="190px" Enabled="False"></asp:TextBox>
                 </td>
                 <td class="style2">
                     <asp:Label ID="labelRegional0" runat="server" CssClass="label" Text="Regional"></asp:Label>
                 </td>
                 <td>
                     <asp:TextBox ID="textRegional" runat="server" CssClass="texto2" 
                         Width="150px" Enabled="False"></asp:TextBox>
                 </td>
             </tr>
             <tr>
                 <td>
                     <asp:Label ID="labelTipoDocumentoRL" runat="server" CssClass="label" 
                         Text="Tipo documento"></asp:Label>
                 </td>
                 <td>
                     <asp:TextBox ID="textTipoDocumentoRL" runat="server" CssClass="texto2" 
                         Width="190px" Enabled="False"></asp:TextBox>
                 </td>
                 <td>
                     <asp:Label ID="labelDocumentoRL" runat="server" CssClass="label" 
                         Text="Documento"></asp:Label>
                 </td>
                 <td>
                     <asp:TextBox ID="textDocumentoRL" runat="server" CssClass="texto2" 
                         Width="150px" Enabled="False"></asp:TextBox>
                 </td>
             </tr>
             <tr>
                 <td>
                     <asp:Label ID="labelDe" runat="server" CssClass="label" Text="De"></asp:Label>
                 </td>
                 <td>
                     <asp:TextBox ID="textDe" runat="server" CssClass="texto2" 
                         Width="190px" Enabled="False"></asp:TextBox>
                 </td>
                 <td>
                     <asp:Label ID="labelCorreo" runat="server" CssClass="label" Text="Correo"></asp:Label>
                 </td>
                 <td>
                     <asp:TextBox ID="textCorreo" runat="server" CssClass="texto2" Enabled="False" 
                         Width="150px"></asp:TextBox>
                 </td>
             </tr>
             <tr>
                 <td>
                     <asp:Label ID="labelDireccion" runat="server" CssClass="label" Text="Dirección"></asp:Label>
                 </td>
                 <td colspan="3">
                     <asp:TextBox ID="textDireccion" runat="server" CssClass="texto2" 
                         Enabled="False" Width="499px"></asp:TextBox>
                 </td>
             </tr>
             <tr>
                 <td>
                     <asp:Label ID="labelDepartamento" runat="server" CssClass="label" 
                         Text="Departamento"></asp:Label>
                 </td>
                 <td>
                     <asp:TextBox ID="textDepartamento" runat="server" CssClass="texto2" 
                         Enabled="False" Width="190px"></asp:TextBox>
                 </td>
                 <td>
                     <asp:Label ID="labelMunicipio" runat="server" CssClass="label" Text="Municipio"></asp:Label>
                 </td>
                 <td>
                     <asp:TextBox ID="textMunicipio" runat="server" CssClass="texto2" 
                         Enabled="False" Width="150px"></asp:TextBox>
                 </td>
             </tr>
             <tr>
                 <td>
                     <asp:Label ID="labelTelefono" runat="server" CssClass="label" Text="Teléfono"></asp:Label>
                 </td>
                 <td>
                     <asp:TextBox ID="textTelefono" runat="server" CssClass="texto2" Enabled="False" 
                         Width="190px"></asp:TextBox>
                 </td>
                 <td>
                     <asp:Label ID="labelTipoBeneficiario" runat="server" CssClass="label" 
                         Text="Tipo beneficiario"></asp:Label>
                 </td>
                 <td>
                     <asp:TextBox ID="textTipoBeneficiario" runat="server" CssClass="texto2" 
                         Enabled="False" Height="22px" Width="150px"></asp:TextBox>
                 </td>
             </tr>
             <tr>
                 <td>
                     <asp:Label ID="labelPeriodo" runat="server" CssClass="label" Text="Trimestre"></asp:Label>&nbsp
                     <asp:Label ID="Label1" runat="server" Text="(*)" Font-Bold="true"></asp:Label>
                 </td>
                 <td>
                     <asp:DropDownList ID="comboPeriodo" runat="server" CssClass="combo">
                     </asp:DropDownList>
                 </td>
                 <td>
                     <asp:Label ID="labelAno" runat="server" CssClass="label" Text="Año"></asp:Label>
                 </td>
                 <td>
                     <asp:DropDownList ID="comboAno" runat="server" CssClass="combo" Width="94px" 
                         DataTextField="anos" DataValueField="anos">
                     </asp:DropDownList>
                 </td>
             </tr>  
             </table>           
             <table>
<%--             <tr>
                <th>   
                <asp:Label ID="label44" runat="server" Text="Reporte de Uso" 
                        CssClass="subtitulo"></asp:Label>
                </th>
            </tr>--%>
             <tr>
                 <td>
                     <table class="formColapsableSinMargen">
                         <tr>
                             <td class="tdCollap"  Height="16px">
                                 <!-- panel colapsable de compras uno-->
                                <asp:LinkButton ID="linkDatosReporteUso" runat="server" CssClass="lnbCollap" > <div>
                                <div style="float:left">Reporte de uso</div><div style="float: right; vertical-align: middle;">
                                
                                <asp:ImageButton ID="imageReporteUso" runat="server" 
                                        ImageUrl="~/images/fl_abajo.jpg" AlternateText="Mostrar detalles" />

                                

                                </div>
                                </div></asp:LinkButton>
                             </td>
                         </tr>
                         <tr>
                             <td>
                                 <asp:UpdatePanel ID="UpdatePanelReporteUso" runat="server">
                                 <ContentTemplate>
                                 <asp:Panel ID="panelReporteUso" runat="server"  >
                                    <table width="100%">
                                        <tr>
                                            <th colspan="4">   
                                            <asp:Label ID="label2" runat="server" Text="Nitrógeno utilizado" 
                                                    CssClass="subtitulo"></asp:Label>
                                            </th>
                                        </tr>
                                        <tr>
                                             <td>
                                                 <asp:Label ID="label4" runat="server" CssClass="label" 
                                                     Text="Unidades cilindros"></asp:Label>
                                             </td>
                                             <td>
                                                 <asp:TextBox ID="txtCilindros" runat="server" CssClass="texto2" 
                                                      >0</asp:TextBox>
                                             </td>
                                             <td>
                                                 <asp:Label ID="label5" runat="server" CssClass="label" 
                                                     Text="Kg."></asp:Label>
                                             </td>
                                             <td>
                                                 <asp:TextBox ID="txtCilindroKg" runat="server" CssClass="texto2" 
                                                     ></asp:TextBox>
                                             </td>                
                                        </tr>                        
                                        <tr>
                                             <td>
                                                 <asp:Label ID="label7" runat="server" CssClass="label" 
                                                     Text="Tipo de mantenimiento"></asp:Label>
                                             </td>
                                             <td>
                                                 <asp:DropDownList ID="comboNitrogeno" runat="server" Width="250px" 
                                                     DataTextField="tim_Descripcion" DataValueField="tim_Id" 
                                                     >
                                                 </asp:DropDownList>
                                             </td>            
                                             <td>&nbsp;</td>
                                             <td>&nbsp;</td>
                                        </tr>                                        
                                        <tr>
                                             <td>
                                                 <asp:Label ID="label8" runat="server" CssClass="label" 
                                                     Text="Observaciones"></asp:Label>
                                             </td>
                                             <td colspan="3">
                                                <asp:TextBox ID="textObservacionNitrogeno" runat="server" CssClass="texto2" 
                                                Height="50px" 
                                                TextMode="MultiLine" Width="560px"></asp:TextBox>
                                             </td>            
                                        </tr>     
                                        <tr>
                                            <th colspan="4">   
                                            <asp:Label ID="label9" runat="server" Text="Filtros de alto rendimiento utilizados" 
                                                    CssClass="subtitulo"></asp:Label>
                                            </th>
                                        </tr>     
                                        <tr>
                                             <td>
                                                 <asp:Label ID="label10" runat="server" CssClass="label" 
                                                     Text="Unidades"></asp:Label>
                                             </td>
                                             <td>
                                                 <asp:TextBox ID="textUnidadesFiltro" runat="server" CssClass="texto2" 
                                                      ></asp:TextBox>
                                             </td>
                                             <td>
                                                 <asp:Label ID="label12" runat="server" CssClass="label" 
                                                     Text="Tipo de mantenimiento"></asp:Label>
                                             </td>
                                             <td>
                                                 <asp:DropDownList ID="comboFiltro" runat="server" Height="16px" Width="171px" 
                                                     DataTextField="tim_Descripcion" DataValueField="tim_Id" >
                                                 </asp:DropDownList>
                                             </td>                
                                        </tr>             
                                        <tr>
                                             <td>
                                                 <asp:Label ID="label13" runat="server" CssClass="label" 
                                                     Text="Observaciones"></asp:Label>
                                             </td>
                                             <td colspan="3">
                                                <asp:TextBox ID="textObservacionFiltro" runat="server" CssClass="texto2" 
                                                Height="50px" 
                                                TextMode="MultiLine" Width="560px"></asp:TextBox>
                                             </td>            
                                        </tr>        
                                        <tr>
                                            <th colspan="4">   
                                            <asp:Label ID="label14" runat="server" Text="Test de acidez utilizados" 
                                                    CssClass="subtitulo"></asp:Label>
                                            </th>
                                        </tr>
                                        <tr>
                                             <td>
                                                 <asp:Label ID="label15" runat="server" CssClass="label" 
                                                     Text="Unidades"></asp:Label>
                                             </td>
                                             <td>
                                                 <asp:TextBox ID="textUnidadAcidez" runat="server" CssClass="texto2" 
                                                      ></asp:TextBox>
                                             </td>
                                             <td>
                                                 <asp:Label ID="label16" runat="server" CssClass="label" 
                                                     Text="Tipo de mantenimiento"></asp:Label>
                                             </td>
                                             <td>
                                                 <asp:DropDownList ID="comboAcidez" runat="server" Height="16px" Width="171px" 
                                                     DataTextField="tim_Descripcion" DataValueField="tim_Id">
                                                 </asp:DropDownList>
                                             </td>                
                                        </tr>             
                                        <tr>
                                             <td>
                                                 <asp:Label ID="label17" runat="server" CssClass="label" 
                                                     Text="Observaciones"></asp:Label>
                                             </td>
                                             <td colspan="3">
                                                <asp:TextBox ID="textObservacionAcidez" runat="server" CssClass="texto2" 
                                                Height="50px" 
                                                TextMode="MultiLine" Width="560px"></asp:TextBox>
                                             </td>            
                                        </tr>                                                                                                                                                                                                                      
                                    </table>
                                 </asp:Panel>
                                 <cc1:CollapsiblePanelExtender ID="colapsibleCompraUno" runat="server" 
                                     CollapseControlID="linkDatosReporteUso" Collapsed="true" 
                                     CollapsedImage="~/images/fl_abajo.jpg" CollapsedSize="0" 
                                     ExpandControlID="linkDatosReporteUso" ExpandedImage="~/images/fl_arriba.jpg" 
                                     ImageControlID="imageReporteUso" SuppressPostBack="true" 
                                     TargetControlID="panelReporteUso">
                                 </cc1:CollapsiblePanelExtender>
                                 </ContentTemplate>
                                 </asp:UpdatePanel>                                 
                             </td>
                         </tr>
                     </table>
                 </td>
             </tr>
          </table>    
          <table>
              <tr>
                  <th>
                      <asp:Label ID="label6" runat="server" CssClass="subtitulo" Text="Documentos"></asp:Label>
                  </th>
              </tr>
            <tr>
                <td>
                    <uc1:DocumentosVarios ID="DocumentosVarios" runat="server" />
                </td>
             </tr>              
           </table>     
        </asp:Panel>
           <table style="width: 711px">   
            <tr>
                <td>
                    &nbsp;&nbsp;
                <asp:Button ID="buttonGuardar" runat="server" Text="Guardar"  
                        CssClass="button" onclick="buttonGuardar_Click"/>
                &nbsp;
                                         &nbsp;<asp:Button ID="buttonCancelar" runat="server" Text="Cancelar"  
                        CssClass="button" onclick="buttonCancelar_Click"/>
                </td>
            </tr>                    
          </table>             
      </td>
    </tr>
    </table>
    </td>
    </tr>
    </table>
    </div>
    <br />
    <br />
    </asp:Content>