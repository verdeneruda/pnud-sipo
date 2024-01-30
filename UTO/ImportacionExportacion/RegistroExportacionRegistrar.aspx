<%@ Page Language="C#" MasterPageFile="~/MPMain.Master"  AutoEventWireup="true" CodeBehind="RegistroExportacionRegistrar.aspx.cs" Inherits="UTO.ImportacionExportacion.RegistroExportacionRegistrar" %>

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
                Text="Módulo importación y exportación - Registro exportación" 
                CssClass="subtitulo"></asp:Label>
        </td></tr>
    </table>
    </div>
    
    <div class = "divwithoutgrid">    
    <table class = "form">
    <tr>
        <td>     
            <uc1:controlerror ID="ControlError1" runat="server" />
     </td>
    </tr>
    </table>
    </div>
    
    <div class = "divwithoutgrid"> 
    <table class="form">
        <tr>
    <td><table style="width:100%">
    <tr>
    <td>
        <asp:Panel ID="PanelDatosExportador" runat="server" Width="716px">
         <table style="width: 100%">
             <tr>
                <th>   
                <asp:Label ID="label1" runat="server" Text="Datos exportador" 
                        CssClass="subtitulo"></asp:Label>
                </th>
            </tr>
         </table>   
         <asp:Panel ID="PanelBusqueda" runat="server">
             <table style="width: 100%">
                 <tr>
                     <td>
                         <asp:Label ID="labelImportador" runat="server" CssClass="label" 
                             Text="Exportador"></asp:Label>
                     </td>
                     <td>
                         <asp:DropDownList ID="comboExportador" runat="server" CssClass="combo" 
                             DataTextField="ter_NombreCompleto" DataValueField="ter_Id" 
                             Width="460px" 
                             AutoPostBack="True" 
                             onselectedindexchanged="comboExportador_SelectedIndexChanged">
                         </asp:DropDownList>
                         &nbsp;</td>
                 </tr>
                 <tr>
                     <td colspan="2">
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
             </table>    
         </asp:Panel>
          <asp:Panel ID="PanelDatoGeneral" runat="server" Visible="False">         
           <table  style="width: 100%">         
         <tr>
             <td>
                 <asp:Label ID="labelImportador0" runat="server" CssClass="label" 
                     Text="Exportador"></asp:Label>
             </td>
             <td class="style4" colspan="3">
                 <asp:DropDownList ID="comboExportadorRegistro" runat="server" CssClass="combo" 
                     DataTextField="ter_NombreCompleto" DataValueField="ter_Id" Enabled="False" 
                     Width="483px">
                 </asp:DropDownList>
             </td>
         </tr>
             <tr>
                 <td>
                     <asp:Label ID="labelNumeroRegistro" runat="server" CssClass="label" 
                         Text="Número registro exportación"></asp:Label>
                 </td>
                 <td class="style4">
                     <asp:TextBox ID="textNumeroRegistro" runat="server" CssClass="texto2" 
                         Width="171px"></asp:TextBox>
                 </td>
                 <td>
                     <asp:Label ID="label11" runat="server" CssClass="label" Text="País Destino"></asp:Label>
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
                <th colspan="4">   
                <asp:Label ID="label4" runat="server" Text="Registro exportación" 
                        CssClass="subtitulo"></asp:Label>
                </th>
            </tr>
          </table> 
         </asp:Panel>
          <asp:Panel ID="PanelSustancias" runat="server" Visible="False">
          <table>         
             <tr>
                 <td>
                     <table class="formColapsableSinMargen">
                         <tr>
                             <td class="tdCollap">
                                 <!-- panel colapsable de compras uno-->
                                <asp:LinkButton ID="linkImportacionSustancias" runat="server" CssClass="lnbCollap" > <div>
                                <div style="float:left">Registro exportación</div>
                                <div style="float: right; vertical-align: middle;">
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
                                             <asp:DropDownList ID="comboSustancia" runat="server" CssClass="combo" 
                                                 DataTextField="sus_Descripcion" DataValueField="sus_Id" 
                                                 onselectedindexchanged="comboSustancia_SelectedIndexChanged" Width="169px" 
                                                 AutoPostBack="True">
                                             </asp:DropDownList>
                                         </td>
                                         <td>
                                             <asp:Label ID="labelArancel" runat="server" CssClass="label" 
                                                 Text="Subpartida arancelaria"></asp:Label>
                                         </td>
                                         <td>
                                             <asp:TextBox ID="TextArancel" runat="server" AutoPostBack="True" 
                                                 CssClass="texto2" Enabled="False" Width="169px"></asp:TextBox>
                                         </td>
                                    </tr>
                                     <tr>
                                         <td>
                                             <asp:Label ID="labelCantidadImportada" runat="server" CssClass="label" 
                                                 Text="Cantidad exportada"></asp:Label>&nbsp
                                             <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>   
                                         </td>
                                         <td>
                                             <asp:TextBox ID="TextCantidadImportada" runat="server" CssClass="texto2" 
                                                 Width="169px"></asp:TextBox>
                                         </td>
                                         <td>
                                             <asp:Label ID="label6" runat="server" CssClass="label" 
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
                                             <asp:Label ID="labelPresentacion" runat="server" CssClass="label" 
                                                 Text="Presentación"></asp:Label>&nbsp
                                             <asp:Label ID="Label5" runat="server" Text="(*)" Font-Bold="true"></asp:Label> 
                                               
                                         </td>
                                         <td>
                                             <asp:DropDownList ID="comboPresentacion" runat="server" CssClass="combo" DataTextField="psu_Descripcion" 
                                                 DataValueField="psu_Id" Width="169px">
                                             </asp:DropDownList>
                                         </td>                                     
                                         <td>
                                             <asp:Label ID="labelPrecioUnitario" runat="server" CssClass="label" 
                                                 Text="Precio unitario"></asp:Label>&nbsp
                                                 <asp:Label ID="Label2" runat="server" Text="(*)" Font-Bold="true"></asp:Label>
                                         </td>
                                         <td>
                                             <asp:TextBox ID="TextPrecioUnitario" runat="server" CssClass="texto2" 
                                                 Width="169px"></asp:TextBox>&nbsp
                                                
                                         </td>

                                     </tr>
                                     <tr>
                                         <td>
                                             <asp:Label ID="labelMarca" runat="server" CssClass="label" 
                                                 Text="Marca comercial"></asp:Label>&nbsp
                                                 <asp:Label ID="Label3" runat="server" Text="(*)" Font-Bold="true"></asp:Label>
                                         </td>
                                         <td>
                                             <asp:DropDownList ID="comboMarca" runat="server" CssClass="combo" 
                                                 DataTextField="mar_Descripcion" DataValueField="mar_Id">
                                             </asp:DropDownList>
                                         </td>
                                         <td>
                                             <asp:TextBox ID="textId" runat="server" Visible="False"></asp:TextBox>
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
                                       <asp:GridView ID="gridImportacionSustancia" runat="server" FooterStyle-CssClass="footergrilla" 
                                           HeaderStyle-CssClass="headergrilla" RowStyle-CssClass="rowgrilla" 
                                           Width="750px" DataKeyNames="idProvisional,id" 
                                           onrowcommand="gridImportacionSustancia_RowCommand">
                                           <RowStyle CssClass="rowgrilla" />
                                           <Columns>
                                               <asp:ButtonField ButtonType="Button" CommandName="Eliminar" Text="Eliminar">
                                                   <ControlStyle CssClass="buttongrilla" />
                                               </asp:ButtonField>
                                               <asp:ButtonField ButtonType="Button" CommandName="Modificar" Text="Modificar">
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
                       <asp:Label ID="labelFechaVigencia" runat="server" CssClass="label" 
                           Text="Fecha vigencia"></asp:Label>
                   </td>
                   <td>
                       <asp:TextBox ID="textFechaVigencia" runat="server" CssClass="texto2" 
                           Width="152px"></asp:TextBox>
                       <cc1:CalendarExtender ID="textFechaVigencia_CalendarExtender" runat="server" 
                           CssClass="calendar" Format="dd/MM/yyyy" TargetControlID="textFechaVigencia">
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
                           <asp:Label ID="labelFechaRequerimiento" runat="server" CssClass="label" 
                               Text="Fecha respuesta requerimiento" Visible="False"></asp:Label>
                       </td>
                       <td>
                           <asp:TextBox ID="textFechaRequerimiento" runat="server" CssClass="texto2" 
                               Visible="False" Width="152px"></asp:TextBox>
                           <cc1:CalendarExtender ID="textFechaRequerimiento_CalendarExtender" 
                               runat="server" CssClass="calendar" Format="dd/MM/yyyy" 
                               TargetControlID="textFechaRequerimiento">
                           </cc1:CalendarExtender>
                       </td>
                       <td colspan="2">
                           &nbsp;</td>
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
    </td>
    </tr>
    </table>
    </div>
    <br />
    <br />
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

