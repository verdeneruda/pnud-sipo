<%@ Page Language="C#" MasterPageFile="~/MPMain.Master"  AutoEventWireup="true" CodeBehind="RegistroImportacionRegistrar.aspx.cs" Inherits="UTO.ImportacionExportacion.RegistroImportacionRegistrar" %>

    <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

    <%@ Register src="~/Comunes/DocumentosVarios.ascx" tagname="DocumentosVarios" tagprefix="uc1" %>

    <%@ Register src="../Comunes/ControlError.ascx" tagname="ControlError" tagprefix="uc1" %>
        
    <asp:Content  ID="contentSolicitudEquiposBuscar" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
       
        <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </cc1:ToolkitScriptManager>
    <div class="divwithoutgrid">
    <table class="titulo" >
        <tr><td>
        <asp:Label ID="labelRegistroExportar" runat="server" 
                Text="Módulo importación y exportación - Registro importación" 
                CssClass="subtitulo"></asp:Label>
        </td></tr>
    </table>
    </div>
    
    <div class = "divwithoutgrid">    
    <table class = "form">
    <tr>
        <td>     
            <uc1:ControlError ID="ControlError1" runat="server" />
     </td>
    </tr>
    </table>
    </div>
    
    <div class = "divwithoutgrid">
        <table class="form">
        <tr>
         <td>
            <asp:Panel ID="PanelRegistroImportacion" runat="server">
              <table class = "form">
                 <tr>
                    <th>   
                    <asp:Label ID="label1" runat="server" Text="Datos importador" 
                            CssClass="subtitulo"></asp:Label>
                    </th>
                  </tr>
              </table>
              <asp:Panel ID="PanelBusqueda" runat="server">
                  <table class= "form">
                      <tr>   
                      <td colspan="2">                      
                          <asp:RadioButton ID="RadioSustancia" runat="server" AutoPostBack="True" 
                              GroupName="TipoImportacion" oncheckedchanged="RadioSustancia_CheckedChanged" 
                              Text="Sustancia" />
                          <asp:RadioButton ID="RadioEquipos" runat="server" Text="Equipos" 
                              AutoPostBack="True" GroupName="TipoImportacion" 
                              oncheckedchanged="RadioEquipos_CheckedChanged" />
                     </td>
                     </tr>
                      <tr>
                         <td>
                             <asp:Label ID="labelImportador" runat="server" CssClass="label" 
                                 Text="Importador" Visible="False"></asp:Label>
                         </td>
                         <td>
                             <asp:DropDownList ID="comboImportador" runat="server" CssClass="combo" 
                                 DataTextField="ter_NombreCompleto" DataValueField="ter_Id" 
                                 Width="425px" 
                                 onselectedindexchanged="comboImportador_SelectedIndexChanged" 
                                 AutoPostBack="True" Visible="False">
                             </asp:DropDownList>
                             &nbsp;</td>
                     </tr>
                      <tr>
                         <td>
                             <asp:Label ID="labelSustanciaBusqueda" runat="server" CssClass="label" 
                                 Text="Sustancia" Visible="False"></asp:Label>
                         </td>
                         <td>
                             <asp:Panel ID="PanelSustanciaBuscar" runat="server" Width="416px" 
                                 Visible = "False">
                                 <div class="divsustancia">
                                     <asp:GridView ID="gridSustancia" runat="server" AutoGenerateColumns="False" 
                                         CssClass="grilla" FooterStyle-CssClass="footergrilla" 
                                         HeaderStyle-CssClass="headergrilla" RowStyle-CssClass="rowgrilla" 
                                         SelectedRowStyle-CssClass="selectedgrilla" Width="369px" 
                                         DataKeyNames="sus_Id">
                                         <RowStyle CssClass="rowgrilla" />
                                         <Columns>
                                             <asp:TemplateField>
                                                 <ItemTemplate>
                                                     <asp:CheckBox ID="CheckSustancia" runat="server" />
                                                 </ItemTemplate>
                                             </asp:TemplateField>
                                             <asp:BoundField DataField="sus_Descripcion" HeaderText="Sustancia" />
                                         </Columns>
                                         <FooterStyle CssClass="footergrilla" />
                                         <SelectedRowStyle CssClass="selectedgrilla" />
                                         <HeaderStyle CssClass="headergrilla" />
                                     </asp:GridView>
                                 </div>
                             </asp:Panel>
                         </td>
                     </tr>
                      <tr>
                         <td colspan="2">
                             <asp:Button ID="buttonBuscarLicencias" runat="server" CssClass="button" 
                                 Height="29px" onclick="buttonBuscarLicencias_Click" Text="Buscar licencias" 
                                 Visible="False" Width="117px" />
                         </td>
                     </tr> 
                  </table>   
              </asp:Panel>     
              <table class="form"         
                 <tr>
                     <tr>
                         <td>
                             <asp:Panel ID="PanelCertificacion" runat="server" Visible="False">
                                 <div class="divgrillasscrollcollapsible">
                                     <asp:GridView ID="gridCertificado" runat="server" AutoGenerateColumns="False" 
                                         CssClass="grilla" FooterStyle-CssClass="footergrilla" 
                                         HeaderStyle-CssClass="headergrilla" RowStyle-CssClass="rowgrilla" 
                                         Width="623px">
                                         <RowStyle CssClass="rowgrilla" />
                                         <Columns>
                                             <asp:BoundField DataField="estadoCertificacion" 
                                                 HeaderText="Estado certificación" />
                                             <asp:BoundField DataField="radicado" HeaderText="Radicado" />
                                             <asp:BoundField DataField="importador" HeaderText="Importador" />
                                             <asp:BoundField DataField="fabricante" HeaderText="Fabricante" />
                                             <asp:BoundField DataField="pais" HeaderText="Pais" />
                                             <asp:BoundField DataField="descripcion" HeaderText="Descripción" />
                                         </Columns>
                                         <FooterStyle CssClass="footergrilla" />
                                         <HeaderStyle CssClass="headergrilla" />
                                     </asp:GridView>
                                 </div>
                             </asp:Panel>
                         </td>
                         <tr>
                             <td>
                                 <asp:Panel ID="PanelLicencias" runat="server" Visible="False">
                                     <div class="divgrillasscrollcollapsible">
                                         <asp:GridView ID="gridLicencias" runat="server" AutoGenerateColumns="False" 
                                             CssClass="grilla" FooterStyle-CssClass="footergrilla" 
                                             HeaderStyle-CssClass="headergrilla" RowStyle-CssClass="rowgrilla" Width="648px">
                                             <RowStyle CssClass="rowgrilla" />
                                             <Columns>
                                                 <asp:BoundField DataField="proveedor" HeaderText="Proveedor" />
                                                 <asp:BoundField DataField="pais" HeaderText="Pais" />
                                             </Columns>
                                             <FooterStyle CssClass="footergrilla" />
                                             <HeaderStyle CssClass="headergrilla" />
                                         </asp:GridView>
                                     </div>
                                 </asp:Panel>
                             </td>
                         </tr>
                     </tr>
              </table>
              <asp:Panel ID="PanelDatoGeneral" runat="server" Visible="false">
                <table class = "form">          
                 <tr>
                     <td>
                         <asp:Label ID="labelImportador0" runat="server" CssClass="label" 
                             Text="Importador"></asp:Label>
                     </td>
                     <td class="style4" colspan="3">
                         <asp:DropDownList ID="comboImportadorRegistro" runat="server" 
                             AutoPostBack="True" CssClass="combo" DataTextField="ter_NombreCompleto" 
                             DataValueField="ter_Id" Enabled="False" 
                             onselectedindexchanged="comboImportador_SelectedIndexChanged" Width="472px">
                         </asp:DropDownList>
                     </td>
                 </tr>
                    <tr>
                        <td>
                            <asp:Label ID="labelNumeroRegistro" runat="server" CssClass="label" 
                                Text="Número registro importación"></asp:Label>
                        </td>
                        <td class="style4">
                            <asp:TextBox ID="textNumeroRegistro" runat="server" CssClass="texto2" 
                                Width="171px"></asp:TextBox>
                        </td>
                        <td>
                            <asp:Label ID="label11" runat="server" CssClass="label" Text="País Compra"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="comboPaisCompra" runat="server" CssClass="combo" 
                                DataTextField="pas_Descripcion" DataValueField="pas_Id" Width="171px">
                            </asp:DropDownList>
                        </td>
                    </tr>
                 <tr>
                     <td>
                         <asp:Label ID="label12" runat="server" CssClass="label" Text="Puerto embarque"></asp:Label>
                     </td>
                     <td class="style4">
                         <asp:TextBox ID="textPuertoEmbargue" runat="server" CssClass="texto2" 
                             Width="171px"></asp:TextBox>
                     </td>
                     <td>
                         <asp:Label ID="label13" runat="server" CssClass="label" Text="Aduana"></asp:Label>
                     </td>
                     <td>
                         <asp:DropDownList ID="comboAduana" runat="server" CssClass="combo" 
                             DataTextField="adu_Descripcion" DataValueField="adu_Id" 
                             Width="171px">
                         </asp:DropDownList>
                     </td>
                   </tr>
                 <tr>
                     <td>
                         <asp:Label ID="labelExportador" runat="server" CssClass="label" 
                             Text="Exportador"></asp:Label>&nbsp
                         <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>   
                     </td>
                     <td class="style4">
                         <asp:DropDownList ID="comboExportador" runat="server" CssClass="combo" 
                             DataTextField="ter_NombreCompleto" DataValueField="ter_Id">
                         </asp:DropDownList>
                     </td>
                     <td>
                        <asp:Label ID="label2" runat="server" CssClass="label" 
                             Text="Estado"></asp:Label></td>&nbsp
                     <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>    
                     <td>
                         <asp:DropDownList ID="comboEstado" runat="server" CssClass="combo" 
                             DataTextField="rit_Descripcion" DataValueField="rit_Id">
                         </asp:DropDownList>
                     </td>
                 </tr>
                 <tr>
                    <th colspan="4">   
                    <asp:Label ID="label4" runat="server" Text="Cantidad importada" 
                            CssClass="subtitulo"></asp:Label>
                    </th>
                </tr>
                </table> 
              </asp:Panel>
              <asp:Panel ID="PanelSustancias" runat="server" Visible="false">
              <table>         
                 <tr>
                     <td>
                         <table class="formColapsableSinMargen">
                             <tr>
                                 <td class="tdCollap">
                                     <!-- panel colapsable de compras uno-->
                                    <asp:LinkButton ID="linkImportacionSustancias" runat="server" CssClass="lnbCollap" > <div>
                                    <div style="float:left">Registro importación</div><div style="float: right; vertical-align: middle;">
                                    <asp:ImageButton ID="imageImportacionSustancia" runat="server" 
                                            ImageUrl="~/images/fl_abajo.jpg" AlternateText="Mostrar detalles" />

                                    </div>
                                    </div></asp:LinkButton>
                                 </td>
                             </tr>
                             <tr>
                                 <td>
                                     <asp:Panel ID="panelImportacionSustancias" runat="server" Height="179px">
                                     <table >
                                          <tr>
                                              <td>
                                                  <asp:Label ID="labelSustancia" runat="server" CssClass="label" Text="Sustancia"></asp:Label>&nbsp
                                                  <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>
                                              </td>
                                              <td>
                                                  <asp:DropDownList ID="comboSustancia" runat="server" AutoPostBack="True" 
                                                      CssClass="combo" DataTextField="sus_Descripcion" DataValueField="sus_Id" 
                                                      onselectedindexchanged="comboSustancia_SelectedIndexChanged" Width="169px">
                                                  </asp:DropDownList>
                                              </td>
                                              <td>
                                                  <asp:Label ID="labelArancel" runat="server" CssClass="label" 
                                                      Text="Subpartida arancelaria"></asp:Label>
                                              </td>
                                              <td>
                                                  <asp:TextBox ID="TextArancel" runat="server" CssClass="texto2" Enabled="False" 
                                                      Width="169px"></asp:TextBox>
                                              </td>
                                          </tr>
                                         <tr>
                                             <td>
                                                 <asp:Label ID="labelCantidadImportada" runat="server" CssClass="label" 
                                                     Text="Cantidad importada"></asp:Label>&nbsp
                                                 <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>   
                                             </td>
                                             <td>
                                                 <asp:TextBox ID="TextCantidadImportada" runat="server" CssClass="texto2" 
                                                     Width="169px"></asp:TextBox>
                                             </td>
                                             <td>
                                                 <asp:Label ID="label5" runat="server" CssClass="label" 
                                                     Text="Unidad"></asp:Label>&nbsp
                                                 <asp:Label ID="Label7" runat="server" Text="(*)" Font-Bold="true"></asp:Label>   
                                             </td>
                                             <td>
                                                 <asp:DropDownList ID="comboUnidad" runat="server" DataValueField="uni_Id" DataTextField="uni_Descripcion" CssClass="combo">
                                                 </asp:DropDownList>
                                             </td>
                                         </tr>
                                         <tr>
                                             <td>
                                                 <asp:Label ID="labelMarca" runat="server" CssClass="label" 
                                                     Text="Marca comercial"></asp:Label>
                                             </td>
                                             <td>
                                                 <asp:DropDownList ID="comboMarca" runat="server" CssClass="combo" 
                                                     DataTextField="mar_Descripcion" DataValueField="mar_Id">
                                                 </asp:DropDownList>
                                             </td>                                         
                                             <td>
                                                 <asp:Label ID="labelPresentacion" runat="server" CssClass="label" Text="Presentación"></asp:Label>&nbsp
                                                 <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>
                                             </td>
                                             <td>
                                                 <asp:DropDownList ID="comboPresentacion" runat="server" CssClass="combo" DataTextField="psu_Descripcion" 
                                                     DataValueField="psu_Id" Width="169px">
                                                 </asp:DropDownList>
                                             </td>

                                         </tr>
                                         <tr>
                                             <td>
                                                 <asp:Label ID="labelPrecioUnitario" runat="server" CssClass="label" 
                                                     Text="Precio unitario"></asp:Label>&nbsp
                                                 <asp:Label ID="Label3" runat="server" Text="(*)" Font-Bold="true"></asp:Label>   
                                             </td>
                                             <td>
                                                 <asp:TextBox ID="TextPrecioUnitario" runat="server" CssClass="texto2" 
                                                     Width="169px"></asp:TextBox>
                                             </td>                                         
                                             <td>
                                                 <asp:Label ID="labelOrigen" runat="server" CssClass="label" Text="País Origen"></asp:Label>&nbsp
                                                 <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>
                                             </td>
                                             <td>
                                                 <asp:DropDownList ID="comboOrigen" runat="server" CssClass="combo" 
                                                     DataTextField="pas_Descripcion" DataValueField="pas_Id" 
                                                     Width="168px">
                                                 </asp:DropDownList>
                                             </td>

                                         </tr>
                                         <tr>
                                             <td>
                                                 <asp:TextBox ID="textIdSustancia" runat="server" Height="21px" Visible="False" 
                                                     Width="35px"></asp:TextBox>
                                             </td>
                                             <td>
                                                 &nbsp;</td>                                         
                                         </tr>
                                         <tr>
                                             <td class="style3" colspan="4">
                                                 &nbsp;<asp:Button ID="buttonAdicionar" runat="server" CssClass="button" 
                                                     onclick="buttonAdicionar_Click" Text="Adicionar" />
                                                 &nbsp;<asp:Button ID="buttonExportar" runat="server" CssClass="button" 
                                                     Text="Exportar Excel" Width="107px" />
                                             </td>
                                         </tr>
                                     </table>
                                       <table>
                                       <tr>
                                       <td>
                                           <div class="divgrillassinmargin">
                                           <asp:GridView ID="gridImportacionSustancia" runat="server" 
                                                           DataKeyNames="idProvisional,id" FooterStyle-CssClass="footergrilla" 
                                                           HeaderStyle-CssClass="headergrilla" 
                                                           onrowcommand="gridImportacionSustancia_RowCommand" 
                                                           RowStyle-CssClass="rowgrilla" Width="750px">
                                                           <RowStyle CssClass="rowgrilla" />
                                                           <Columns>
                                                               <asp:ButtonField ButtonType="Button" CommandName="Modificar" Text="Modificar">
                                                                   <ControlStyle CssClass="buttongrilla" />
                                                               </asp:ButtonField>
                                                               <asp:ButtonField ButtonType="Button" CommandName="Eliminar" Text="Eliminar">
                                                                   <ControlStyle CssClass="buttongrilla" />
                                                               </asp:ButtonField>
                                                           </Columns>
                                                           <Columns>
                                                               <asp:ButtonField ButtonType="Button" CommandName="Eliminar" Text="Eliminar">
                                                                   <ControlStyle CssClass="buttongrilla" />
                                                               </asp:ButtonField>
                                                           </Columns>
                                                           <FooterStyle CssClass="footergrilla" />
                                                           <HeaderStyle CssClass="headergrilla" />
                                                       </asp:GridView>
                                           </div>                                       
                                       </td>
                                       </tr>
                                       </table>                                     
                                         
                                     </asp:Panel>
                                     <cc1:CollapsiblePanelExtender ID="colapsibleImportacionSustancias" runat="server" 
                                         CollapseControlID="linkImportacionSustancias" Collapsed="true" 
                                         CollapsedImage="~/images/fl_abajo.jpg" CollapsedSize="0"
                                         ExpandControlID="linkImportacionSustancias" ExpandedImage="~/images/fl_arriba.jpg" 
                                         ImageControlID="imageImportacionSustancia" SuppressPostBack="true" 
                                         TargetControlID="panelImportacionSustancias">
                                     </cc1:CollapsiblePanelExtender>
                                 </td>
                             </tr>
                         </table>
                     </td>
                 </tr>
              </table>    
               </asp:Panel>
              <asp:Panel ID="PanelEquipos" runat="server" Visible="False">
              <table>         
                 <tr>
                     <td>
                         <table class="formColapsableSinMargen">
                             <tr>
                                 <td class="tdCollap">
                                     <!-- panel colapsable de compras uno-->
                                    <asp:LinkButton ID="LinkImportacionEquipos" runat="server" CssClass="lnbCollap" > <div>
                                    <div style="float:left">Registro importación</div><div style="float: right; vertical-align: middle;">
                                    <asp:ImageButton ID="imageImportacionEquipos" runat="server" 
                                            ImageUrl="~/images/fl_abajo.jpg" AlternateText="Mostrar detalles" />

                                    </div>
                                    </div></asp:LinkButton>
                                 </td>
                             </tr>
                             <tr>
                                 <td>
                                     <asp:Panel ID="panelImportacionEquipos" runat="server" Height="121px">
                                     <table >
                                               <tr>
                                                   <td>
                                                       <asp:Label ID="labelArancelEquipos" runat="server" CssClass="label" 
                                                           Text="Arancel"></asp:Label>
                                                   </td>
                                                   <td>
                                                       <asp:DropDownList ID="comboArancelEquipo" runat="server" CssClass="combo" 
                                                           DataTextField="ear_Descripcion" DataValueField="ear_Id">
                                                       </asp:DropDownList>
                                                       
                                                   </td>
                                                   <td>
                                                       <asp:Label ID="label6" runat="server" CssClass="label" Text="Marca comercial"></asp:Label>
                                                   </td>
                                                   <td>
                                                       <asp:DropDownList ID="comboMarcaEquipo" runat="server" CssClass="combo" 
                                                           DataTextField="meq_Descripcion" DataValueField="meq_Id">
                                                       </asp:DropDownList>
                                                   </td>
                                               </tr>
                                               <tr>
                                                 <td>
                                                     <asp:Label ID="labelCantidadEquipos" runat="server" CssClass="label" 
                                                         Text="Unidades importadas"></asp:Label>&nbsp
                                                     <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>    
                                                 </td>
                                                 <td>
                                                     <asp:TextBox ID="TextCantidadEquipos" runat="server" CssClass="texto2" 
                                                         Width="169px"></asp:TextBox>
                                                 </td>
                                                 <td>
                                                     <asp:Label ID="labelReferencia" runat="server" CssClass="label" 
                                                         Text="Descripción"></asp:Label>
                                                 </td>
                                                 <td>
                                                     <asp:TextBox ID="TextReferenciaEquipos" runat="server" 
                                                         CssClass="texto2" Width="247px"></asp:TextBox>
                                                 </td>
                                             </tr>
                                               <tr>
                                                   <td>
                                                       <asp:TextBox ID="textIdEquipos" runat="server" Height="21px" Visible="False" 
                                                           Width="35px"></asp:TextBox>
                                                   </td>
                                                   <td>
                                                       &nbsp;</td>
                                                   <td>
                                                       &nbsp;</td>
                                                   <td>
                                                       &nbsp;</td>
                                               </tr>
                                             <tr>
                                                 <td class="style3" colspan="4">
                                                     &nbsp;<asp:Button ID="buttonAdicionarEquipos" runat="server" CssClass="button" 
                                                         onclick="buttonAdicionarEquipos_Click" Text="Adicionar" />
                                                     &nbsp;<asp:Button ID="button2" runat="server" CssClass="button" 
                                                         Text="Exportar Excel" Width="107px" />
                                                 </td>
                                             </tr>
                                     </table>
                                       <table>
                                       <tr>
                                       <td>
                                           <div class="divgrillassinmargin">
                                                <asp:GridView ID="GridImportarEquipos" runat="server" 
                                                             DataKeyNames="idProvisional,id" FooterStyle-CssClass="footergrilla" 
                                                             HeaderStyle-CssClass="headergrilla" 
                                                             onrowcommand="GridImportarEquipos_RowCommand" RowStyle-CssClass="rowgrilla" 
                                                             Width="750px">
                                                             <RowStyle CssClass="rowgrilla" />
                                                             <Columns>
                                                                 <asp:ButtonField ButtonType="Button" CommandName="Modificar" Text="Modificar">
                                                                     <ControlStyle CssClass="buttongrilla" />
                                                                 </asp:ButtonField>
                                                                 <asp:ButtonField ButtonType="Button" CommandName="Eliminar" Text="Eliminar">
                                                                     <ControlStyle CssClass="buttongrilla" />
                                                                 </asp:ButtonField>
                                                             </Columns>
                                                             <Columns>
                                                                 <asp:ButtonField ButtonType="Button" CommandName="Eliminar" Text="Eliminar">
                                                                     <ControlStyle CssClass="buttongrilla" />
                                                                 </asp:ButtonField>
                                                             </Columns>
                                                             <FooterStyle CssClass="footergrilla" />
                                                             <HeaderStyle CssClass="headergrilla" />
                                                </asp:GridView>                                           
                                           </div>
                                       
                                       </td>
                                       </tr>
                                       </table>                                     
                                     </asp:Panel>
                                     <cc1:CollapsiblePanelExtender ID="colapsibleImportacionEquipos" runat="server" 
                                         CollapseControlID="LinkImportacionEquipos" Collapsed="true" 
                                         CollapsedImage="~/images/fl_abajo.jpg" CollapsedSize="0" 
                                         ExpandControlID="LinkImportacionEquipos" ExpandedImage="~/images/fl_arriba.jpg" 
                                         ImageControlID="imageImportacionEquipos" SuppressPostBack="true" 
                                         TargetControlID="panelImportacionEquipos">
                                     </cc1:CollapsiblePanelExtender>
                                 </td>
                             </tr>
                         </table>
                     </td>
                 </tr>
              </table>    
               </asp:Panel>  
                <asp:Panel ID="PanelConcepto" runat="server" Visible="False">
                   <table>
                       <tr>
                       <td>
                       
                           <asp:Label ID="labelConcepto" runat="server" CssClass="label" Text="Concepto"></asp:Label>
                         
                       </td>    
                           <td>
                               <asp:DropDownList ID="comboconcepto" runat="server" AutoPostBack="True" 
                                   CssClass="combo" DataTextField="cvb_Descripcion" 
                                   DataValueField="cvb_Id" 
                                   onselectedindexchanged="comboconcepto_SelectedIndexChanged">
                               </asp:DropDownList>
                           </td>
                           <td>
                               <asp:Label ID="labelFechaInicio" runat="server" CssClass="label" 
                                   Text="Fecha registro importación"></asp:Label>&nbsp
                               <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>    
                           </td>
                           <td>
                               <asp:TextBox ID="textFechaInicio" runat="server" CssClass="texto2" 
                                   Width="152px"></asp:TextBox>
                               <cc1:CalendarExtender ID="textFechaInicio_CalendarExtender" runat="server" 
                                   CssClass="calendar" Format="dd/MM/yyyy" TargetControlID="textFechaInicio">
                               </cc1:CalendarExtender>
                           </td>
                       </tr>
                       <tr>
                           <td>
                               <asp:Label ID="labelFechaVigencia" runat="server" CssClass="label" 
                                   Text="Fecha vigencia" Visible="False"></asp:Label>
                           </td>
                           <td>
                               <asp:TextBox ID="textFechaVigencia" runat="server" CssClass="texto2" 
                                   Visible="False" Width="152px"></asp:TextBox>
                               <cc1:CalendarExtender ID="textFechaVigencia_CalendarExtender" runat="server" 
                                   CssClass="calendar" Format="dd/MM/yyyy" TargetControlID="textFechaVigencia">
                               </cc1:CalendarExtender>
                           </td>
                           <td>
                               <asp:Label ID="labelFechaRequerimiento" runat="server" CssClass="label" 
                                   Text="Fecha solicitud requerimiento" Visible="False"></asp:Label>
                           </td>
                           <td>
                               <asp:TextBox ID="textFechaRequerimiento" runat="server" CssClass="texto2" 
                                   Visible="False" Width="152px"></asp:TextBox>
                               <cc1:CalendarExtender ID="textFechaRequerimiento_CalendarExtender" 
                                   runat="server" CssClass="calendar" Format="dd/MM/yyyy" 
                                   TargetControlID="textFechaRequerimiento">
                               </cc1:CalendarExtender>
                           </td>
                       </tr>
                       <tr>
                           <td>
                               <asp:Label ID="labelVistoBueno" runat="server" CssClass="label" 
                                   Text="Visto Bueno" Visible="False"></asp:Label>
                           </td>
                           <td>
                               <asp:TextBox ID="textVistoBueno" runat="server" CssClass="texto2" Width="158px" 
                                   Visible="False"></asp:TextBox>
                           </td>
                           <td>
                               <asp:Label ID="labelFechaVistoBueno" runat="server" CssClass="label" 
                                   Text="Fecha visto bueno" Visible="False"></asp:Label>&nbsp
                               <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>  
                           </td>
                           <td>
                               <asp:TextBox ID="textFechaVistoBueno" runat="server" CssClass="texto2" 
                                   Width="152px" Visible="False"></asp:TextBox>
                               <cc1:CalendarExtender ID="calendarFecha" runat="server" CssClass="calendar" 
                                   Format="dd/MM/yyyy" TargetControlID="textFechaVistoBueno">
                               </cc1:CalendarExtender>
                           </td>
                       </tr>
                       <tr>
                           <td>
                               &nbsp;</td>
                           <td>
                               &nbsp;</td>
                           <td>
                               <asp:Label ID="labelFechaRespuesta" runat="server" 
                                   Text="Fecha respuesta requerimiento" Visible="False"></asp:Label>
                           </td>
                           <td>
                                <asp:TextBox ID="textFechaRespuesta" runat="server" CssClass="texto2" 
                                   Width="152px" Visible="False"></asp:TextBox>
                               <cc1:CalendarExtender ID="CalendarExtender1" runat="server" CssClass="calendar" 
                                   Format="dd/MM/yyyy" TargetControlID="textFechaRespuesta">
                               </cc1:CalendarExtender>
                           </td>
                       </tr>                 
                  </table>       
                </asp:Panel>                  
            </asp:Panel>            
            <table>
                <tr>
                    <td colspan="2">
                        &nbsp;&nbsp;<asp:Button ID="buttonGuardar" runat="server" Text="Guardar"  
                            CssClass="button" onclick="buttonGuardar_Click"/>
                        &nbsp;<asp:Button ID="buttonCancelar" runat="server" CssClass="button" 
                            onclick="buttonCancelar_Click" Text="Cancelar" />
                    </td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>               
        </table>
        </td>
        </tr>
        </table>
    </div>
    </asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="head">

    <style type="text/css">
        .style3
        {
            height: 36px;
        }
        .style4
        {
        }
        </style>

</asp:Content>

