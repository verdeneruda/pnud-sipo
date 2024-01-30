<%@ Page Language="C#" MasterPageFile="~/MPMain.Master"  AutoEventWireup="true" CodeBehind="AprobarSolicitudEquiposRegistrar.aspx.cs" Inherits="UTO.Recuperacion.AprobarSolicitudEquiposRegistrar" %>

    <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

    <%@ Register src="~/Comunes/DocumentosVarios.ascx" tagname="DocumentosVarios" tagprefix="uc1" %>

    <%@ Register src="../Comunes/ControlError.ascx" tagname="ControlError" tagprefix="uc2" %>

    <asp:Content  ID="contentSolicitudEquiposBuscar" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
            
    <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </cc1:ToolkitScriptManager>
    <div class="divwithoutgrid">
    <table class="titulo" >
        <tr><td>
        <asp:Label ID="labelBusquedaSolicitudesEquipos" runat="server" Text="Proyectos de dotación de equipos y herramientas  para el sector de refrigeración y aire acondicionado - Solicitud equipos" CssClass="subtitulo"></asp:Label>
        </td>
        </tr>
    </table>
    <table style="width:100%">
    <tr>
    <td>
    
        <uc2:ControlError ID="ControlError1" runat="server" />
    
    </td>
    </tr>
    </table>
    <table class="form">
        <tr>
    <td><table style="width:100%">
    <tr>
    <td colspan="2">
        <asp:Panel ID="PanelCancelar" runat="server">
         <table style="width: 676px">
             <tr>
                <th colspan="4">   
                <asp:Label ID="label5" runat="server" Text="Cancelación" 
                        CssClass="subtitulo"></asp:Label>
                </th>
            </tr>
            <tr>
                <td width="160px">
                    <asp:Label ID="label6" runat="server" CssClass="label" 
                        Text="Cancelar solicitud?"></asp:Label>
                </td>
                <td>
                    <asp:CheckBox ID="checkCancelar" runat="server" 
                        oncheckedchanged="checkCancelar_CheckedChanged" />
                </td>
                <td>                
                    <asp:Label ID="labelFechaCancelar" runat="server" CssClass="label" Text="Fecha"></asp:Label>                
                </td>
                <td>                
                    <asp:TextBox ID="textFechaCancelar" runat="server" CssClass="texto2"></asp:TextBox>
                                             <cc1:CalendarExtender ID="CalendarExtender3" runat="server" 
                                                 CssClass="calendar" Format="dd/MM/yyyy"                                                  
                        TargetControlID="textFechaCancelar">
                                             </cc1:CalendarExtender>
                                         
                </td>
            </tr>
            </table>        
        </asp:Panel>
        <asp:Panel ID="PanelDatosTercero" runat="server" Width="716px">
         <table style="width: 676px">
             <tr>
                <th colspan="4">   
                <asp:Label ID="label1" runat="server" Text="Datos beneficiario" 
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
                        Width="190px" Enabled="False" ></asp:TextBox>
                </td>
                <td>                
                    <asp:Label ID="labelTipoDocumento" runat="server" CssClass="label" Text="Tipo documento"></asp:Label>                
                </td>
                <td>                
                    <asp:TextBox ID="textTipoDocumento" runat="server" CssClass="texto2" 
                        Width="150px" Enabled="False"></asp:TextBox>
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
                         Enabled="False" Width="488px"></asp:TextBox>
                 </td>
             </tr>
             <tr>
                 <td>
                     <asp:Label ID="labelDepartamento" runat="server" CssClass="label" 
                         Text="Departamento"></asp:Label>
                 </td>
                 <td>
                     <asp:TextBox ID="textDepartamento" runat="server" CssClass="texto2" 
                         Width="190px" Enabled="False"></asp:TextBox>
                 </td>
                 <td>
                     <asp:Label ID="labelMunicipio" runat="server" CssClass="label" Text="Municipio"></asp:Label>
                 </td>
                 <td>
                     <asp:TextBox ID="textMunicipio" runat="server" CssClass="texto2" 
                         Width="150px" Enabled="False"></asp:TextBox>
                 </td>
             </tr>
             <tr>
                 <td>
                     <asp:Label ID="labelTipoBeneficiario" runat="server" CssClass="label" 
                         Text="Tipo beneficiario"></asp:Label>
                 </td>
                 <td>
                     <asp:TextBox ID="textTipoBeneficiario" runat="server" CssClass="texto2" 
                         Height="22px" Width="190px" Enabled="False"></asp:TextBox>
                 </td>
                 <td>
                     <asp:Label ID="labelTelefono" runat="server" CssClass="label" Text="Teléfono"></asp:Label>
                 </td>
                 <td>
                     <asp:TextBox ID="textTelefono" runat="server" CssClass="texto2" Enabled="False" 
                         Width="150px"></asp:TextBox>
                 </td>
             </tr>  
             </table>             
             <table>           
             <tr>
                 <td>
                    <div class="divgrillasscrollcollapsible">
                     <asp:GridView ID="gridProyectoTercero" runat="server" CssClass="grilla" 
                         FooterStyle-CssClass="footergrilla" HeaderStyle-CssClass="headergrilla" 
                         RowStyle-CssClass="rowgrilla" SelectedRowStyle-CssClass="selectedgrilla" 
                         Width="655px" AutoGenerateColumns="False">
                         <RowStyle CssClass="rowgrilla" />
                         <Columns>
                             <asp:BoundField DataField="grupo" HeaderText="Proyecto grupo" />
                         </Columns>
                         <FooterStyle CssClass="footergrilla" />
                         <SelectedRowStyle CssClass="selectedgrilla" />
                         <HeaderStyle CssClass="headergrilla" />
                     </asp:GridView>
                     </div>
                 </td>
             </tr>
             <tr>
                <th>   
                <asp:Label ID="label4" runat="server" Text="Equipos a asignar" 
                        CssClass="subtitulo"></asp:Label>
                </th>
            </tr>
             <tr ID="trCompraUno" runat="server">
                 <td>
                     <table class="formColapsableSinMargen">
                         <tr>
                             <td class="tdCollap" Height="16px" >
                                 <!-- panel colapsable de compras uno-->
                                 <asp:LinkButton ID="linkCompraUno" runat="server" CssClass="lnbCollap"> <div>
                                <div style="float:left">Equipos</div>
                                <div style="float: right; vertical-align: middle;">
                                <asp:ImageButton ID="imageCompraUno" runat="server" 
                                        ImageUrl="~/images/fl_abajo.jpg" AlternateText="Mostrar detalles" />
                                </div>
                                </div></asp:LinkButton>
                             </td>
                         </tr>
                         <tr>
                             <td>
                               <asp:UpdatePanel ID="UpdatePanelAprobacionInicial" runat="server">
                                 <ContentTemplate>
                                 <asp:Panel ID="panelCompraUno" runat="server" Height="281px" Width="665px">
                                     <div class="divgrillasscrollcollapsible">
                                         <asp:GridView ID="gridSolicitudEquipos" runat="server" 
                                             AutoGenerateColumns="False" CssClass="grilla" 
                                             FooterStyle-CssClass="footergrilla" HeaderStyle-CssClass="headergrilla" 
                                             RowStyle-CssClass="rowgrilla" SelectedRowStyle-CssClass="selectedgrilla" 
                                             Width="650px">
                                             <RowStyle CssClass="rowgrilla" />
                                             <Columns>
                                                 <asp:BoundField DataField="equipo" HeaderText="Equipo" />
                                                 <asp:BoundField DataField="cantidad" HeaderText="Cantidad" />
                                                 <asp:BoundField DataField="costo" HeaderText="Costo" />
                                                 <asp:BoundField DataField="id" HeaderText="Id" />
                                                 <asp:BoundField DataField="idProvisional" HeaderText="idProvisional" />
                                             </Columns>
                                             <FooterStyle CssClass="footergrilla" />
                                             <SelectedRowStyle CssClass="selectedgrilla" />
                                             <HeaderStyle CssClass="headergrilla" />
                                         </asp:GridView>
                                     </div>
                                     <table>
                                         <tr>
                                             <td>
                                                 <asp:Label ID="label3" runat="server" Font-Bold="True" 
                                                     Font-Size="Medium" Text="Valor total: "></asp:Label>
                                             </td>
                                             <td>
                                                 <asp:TextBox ID="TextValorTotalSolicitud" runat="server" Enabled="False" 
                                                     Width="128px"></asp:TextBox>
                                             </td>
                                         </tr>                   
                                         <tr>
                                             <td>
                                                 <asp:Label ID="labelObservacionesInicial" runat="server" CssClass="label" 
                                                     Text="Observaciones"></asp:Label>
                                             </td>
                                             <td>
                                                 <asp:TextBox ID="textObservacionesInicial" runat="server" CssClass="texto2" 
                                                     EnableTheming="True" Height="50px" TextMode="MultiLine" Width="524px"></asp:TextBox>
                                             </td>
                                         </tr>                                     
                                         <tr>
                                             <td>
                                                 <asp:CheckBox ID="CheckEtapaInicialAprobada" runat="server" AutoPostBack="True" 
                                                     oncheckedchanged="CheckEtapaInicialAprobada_CheckedChanged" 
                                                     Text="Etapa aprobada" />
                                             </td>
                                             <td>
                                                 &nbsp;</td>
                                         </tr>
                                     </table>
                                 </asp:Panel>
                                 <cc1:CollapsiblePanelExtender ID="colapsibleCompraUno" runat="server" 
                                     CollapseControlID="linkCompraUno" Collapsed="true" 
                                     CollapsedImage="~/images/fl_abajo.jpg" CollapsedSize="0" 
                                     ExpandControlID="linkCompraUno" ExpandedImage="~/images/fl_arriba.jpg" 
                                     ImageControlID="imageCompraUno" SuppressPostBack="true" 
                                     TargetControlID="panelCompraUno">
                                 </cc1:CollapsiblePanelExtender>
                                </ContentTemplate>
                                     <Triggers>
                                         <asp:AsyncPostBackTrigger ControlID="CheckEtapaInicialAprobada" 
                                             EventName="CheckedChanged" />
                                     </Triggers>
                                 </asp:UpdatePanel>
                              </td>
                         </tr> 
                     </table>
                 </td>
             </tr>            
             <tr ID="trEstudiosPrevios" runat="server">
                <td>
                     <table class="formColapsableSinMargen">
                         <tr>
                             <td class="tdCollap" Height="16px">
                                 <!-- panel colapsable de documentos -->
                                 <asp:LinkButton ID="LinkEstudiosPrevios" runat="server" CssClass="lnbCollap">
                                 <div>
                                <div style="float:left">Estudios previos</div>
                                <div style="float: right; vertical-align: middle;">
                                <asp:ImageButton ID="ImageEstudiosPrevios" runat="server" 
                                        ImageUrl="~/images/fl_abajo.jpg" AlternateText="Mostrar detalles" />
                                </div>
                                </div></asp:LinkButton>
                             </td>
                         </tr>
                         <tr>
                             <td>
                                 <asp:UpdatePanel ID="UpdatePanelEstudiosPrevios" runat="server">
                                 <ContentTemplate>                             
                                 <asp:Panel ID="panelEstudiosPrevios" runat="server">
                                     <div class="divgrillassinmargin">
                                         <asp:GridView ID="GridEstudiosPrevios" runat="server" 
                                             AutoGenerateColumns="False" CssClass="grilla" FooterStyle-CssClass="footergrilla" 
                                             HeaderStyle-CssClass="headergrilla" RowStyle-CssClass="rowgrilla" 
                                             Width="653px" DataKeyNames="dve_Id">
                                             <RowStyle CssClass="rowgrilla" />
                                             <Columns>
                                                 <asp:TemplateField HeaderText="Verificado">
                                                     <ItemTemplate>
                                                         <asp:CheckBox ID="CheckDocumento" runat="server" />
                                                     </ItemTemplate>
                                                 </asp:TemplateField>
                                                 <asp:BoundField DataField="dve_Descripcion" HeaderText="Descripción" />
                                                 <asp:BoundField DataField="dve_Id" HeaderText="Id" Visible="False" />
                                             </Columns>
                                             <FooterStyle CssClass="footergrilla" />
                                             <HeaderStyle CssClass="headergrilla" />
                                         </asp:GridView>
                                     </div>
                                     <table>
                                     <tr>
                                         <td>
                                             <asp:Label ID="labelObservaciones" runat="server" CssClass="label" 
                                                 Text="Observaciones"></asp:Label>
                                         </td>
                                         <td colspan="3">
                                             <asp:TextBox ID="textObservacionesEstudiosPrevios" runat="server" CssClass="texto2" 
                                                 EnableTheming="True" Height="50px" TextMode="MultiLine" Width="524px"></asp:TextBox>
                                         </td>
                                     </tr>
                                         <tr>
                                             <td>
                                                 <asp:CheckBox ID="CheckCertificacion" runat="server" 
                                                     Text="Tiene certificación" AutoPostBack="True" 
                                                     oncheckedchanged="CheckCertificacion_CheckedChanged" />
                                             </td>
                                             <td>
                                                 <asp:Label ID="labelFechaCertificación" runat="server" CssClass="label" 
                                                     Text="Fecha certificación" Visible="False"></asp:Label>
                                             </td>
                                             <td>
                                                 <asp:TextBox ID="textFechaCertificacion" runat="server" CssClass="texto2" 
                                                     Visible="False"></asp:TextBox>
                                                 <cc1:CalendarExtender ID="calendarfecha" runat="server" CssClass="calendar" 
                                                     Format="dd/MM/yyyy" TargetControlID="textFechaCertificacion">
                                                 </cc1:CalendarExtender>
                                             </td>
                                             <td>
                                                 <asp:CheckBox ID="CheckEtapaEstudioAprobado" runat="server" 
                                                     Text="Etapa aprobada" 
                                                     oncheckedchanged="CheckEtapaEstudioAprobado_CheckedChanged" 
                                                     AutoPostBack="True" />
                                             </td>
                                         </tr>
                                     </table>                                                                    
                                 </asp:Panel>
                                 <cc1:CollapsiblePanelExtender ID="collapsibleEstudiosPrevios" runat="server" 
                                     CollapseControlID="linkEstudiosPrevios" Collapsed="true" 
                                     CollapsedImage="~/images/fl_abajo.jpg" CollapsedSize="0" 
                                     ExpandControlID="linkEstudiosPrevios" ExpandedImage="~/images/fl_arriba.jpg" 
                                     ImageControlID="imageEstudiosPrevios" 
                                     SuppressPostBack="true" TargetControlID="panelEstudiosPrevios">
                                 </cc1:CollapsiblePanelExtender>
                                 </ContentTemplate>
                                     <Triggers>
                                         <asp:AsyncPostBackTrigger ControlID="CheckEtapaEstudioAprobado" 
                                             EventName="CheckedChanged" />
                                     </Triggers>
                                 </asp:UpdatePanel>                                                           
                             </td>
                         </tr>
                     </table>
                </td>
             </tr>
             <tr ID="trElaboracionMinutas" runat="server">
                <td>
                     <table class="formColapsableSinMargen">
                         <tr>
                             <td class="tdCollap" style="height: 16px" >
                                 <!-- panel colapsable de documentos -->
                                <asp:LinkButton ID="LinkElaboracionMinutas" runat="server" CssClass="lnbCollap" >
                                 <div>
                                <div style="float:left">Elaboración minutas</div>
                                <div style="float: right; vertical-align: middle;">
                                <asp:ImageButton ID="ImageElaboracionMinutas" runat="server" 
                                        ImageUrl="~/images/fl_abajo.jpg" AlternateText="Mostrar detalles" />
                                </div>
                                </div></asp:LinkButton>
                             </td>
                         </tr>
                         <tr>
                             <td>
                                 <asp:UpdatePanel ID="UpdatePanelElaboracionMinuta" runat="server">
                                 <ContentTemplate>                                   
                                 <asp:Panel ID="panelElaboracionMinutas" runat="server">
                                 <table style="width: 681px">
                                 <tr>
                                     <td colspan="4">
                                        
                                         <asp:GridView ID="GridDocumentosMinuta" runat="server" 
                                             AutoGenerateColumns="False" CssClass="grilla" 
                                             FooterStyle-CssClass="footergrilla" HeaderStyle-CssClass="headergrilla" 
                                             RowStyle-CssClass="rowgrilla" Width="653px" DataKeyNames="dve_Id">
                                             <RowStyle CssClass="rowgrilla" />
                                             <Columns>
                                                 <asp:TemplateField HeaderText="Verificado">
                                                     <ItemTemplate>
                                                         <asp:CheckBox ID="CheckDocumento" runat="server" />
                                                     </ItemTemplate>
                                                 </asp:TemplateField>
                                                 <asp:BoundField DataField="dve_Descripcion" HeaderText="Descripción" />
                                                 <asp:BoundField DataField="dve_Id" HeaderText="Id" Visible="False" />
                                             </Columns>
                                             <FooterStyle CssClass="footergrilla" />
                                             <HeaderStyle CssClass="headergrilla" />
                                         </asp:GridView>
                                        
                                     </td>
                                 </tr>                                 
                                     <tr>
                                         <td>
                                             <asp:Label ID="labelFechaElaboracion" runat="server" CssClass="label" 
                                                 Text="Fecha elaboración"></asp:Label>
                                         </td>
                                         <td>
                                             <asp:TextBox ID="textFechaElaboracion" runat="server" CssClass="texto2"></asp:TextBox>
                                             <cc1:CalendarExtender ID="CalendarExtender1" runat="server" CssClass="calendar" 
                                                 Format="dd/MM/yyyy" TargetControlID="textFechaElaboracion">
                                             </cc1:CalendarExtender>
                                         </td>
                                         <td>
                                             <asp:Label ID="labelFechaFirmaMinutas" runat="server" CssClass="label" 
                                                 Text="Fecha firma minuta"></asp:Label>
                                         </td>
                                         <td>
                                             <asp:TextBox ID="textFechaFirmaPoliza" runat="server" CssClass="texto2"></asp:TextBox>
                                             <cc1:CalendarExtender ID="textFechaFirmaPoliza_CalendarExtender" runat="server" 
                                                 CssClass="calendar" Format="dd/MM/yyyy" 
                                                 TargetControlID="textFechaFirmaPoliza">
                                             </cc1:CalendarExtender>
                                         </td>
                                     </tr>
                                     <tr>
                                         <td>
                                             <asp:Label ID="labelObservaciones0" runat="server" CssClass="label" 
                                                 Text="Observaciones"></asp:Label>
                                         </td>
                                         <td colspan="3">
                                             <asp:TextBox ID="textObservacionesMinutas" runat="server" CssClass="texto2" 
                                                 EnableTheming="True" Height="50px" TextMode="MultiLine" Width="524px"></asp:TextBox>
                                         </td>
                                     </tr>
                                     <tr>
                                         <td colspan="4">
                                             <asp:CheckBox ID="CheckEtapaMinutaAprobado" runat="server" 
                                                 Text="Etapa aprobada" 
                                                 oncheckedchanged="CheckEtapaMinutaAprobado_CheckedChanged" 
                                                 AutoPostBack="True" />
                                         </td>
                                     </tr>
                                 </table>
                                 </asp:Panel>
                                 <cc1:CollapsiblePanelExtender ID="CollapsibleElaboracionMinutas" runat="server" 
                                     CollapseControlID="LinkElaboracionMinutas" Collapsed="true" 
                                     CollapsedImage="~/images/fl_abajo.jpg" CollapsedSize="0" 
                                     ExpandControlID="LinkElaboracionMinutas" ExpandedImage="~/images/fl_arriba.jpg" 
                                     ExpandedSize="200" ImageControlID="imageElaboracionMinutas" SuppressPostBack="true" 
                                     TargetControlID="panelElaboracionMinutas">
                                 </cc1:CollapsiblePanelExtender>
                                 </ContentTemplate>
                                     <Triggers>
                                         <asp:AsyncPostBackTrigger ControlID="CheckEtapaMinutaAprobado" 
                                             EventName="CheckedChanged" />
                                     </Triggers>
                                 </asp:UpdatePanel>                                                                
                             </td>
                         </tr>
                     </table>                
                </td>
             </tr>
             <tr ID="trTramitePoliza" runat="server">
                <td>
                     <table class="formColapsableSinMargen">
                         <tr>
                             <td class="tdCollap" style="height: 16px" >
                                 <!-- panel colapsable de documentos -->
                                <asp:LinkButton ID="LinkTramitePoliza" runat="server" CssClass="lnbCollap" >
                                 <div>
                                <div style="float:left">Trámite poliza</div>
                                <div style="float: right; vertical-align: middle;">
                                <asp:ImageButton ID="ImageTramitePoliza" runat="server" 
                                        ImageUrl="~/images/fl_abajo.jpg" AlternateText="Mostrar detalles" />
                                </div>
                                </div></asp:LinkButton>
                             </td>
                         </tr>
                         <tr>
                             <td>
<%--                              <asp:UpdatePanel ID="UpdatePanelTramitePoliza" runat="server">
                                 <ContentTemplate>    --%>                         
                                 <asp:Panel ID="panelTramitePoliza" runat="server">
                                 <table style="width: 679px">
                                 <tr>
                                     <td colspan="4">
                                        
                                         <asp:GridView ID="GridDocumentosPoliza" runat="server" 
                                             AutoGenerateColumns="False" CssClass="grilla" 
                                             FooterStyle-CssClass="footergrilla" HeaderStyle-CssClass="headergrilla" 
                                             RowStyle-CssClass="rowgrilla" Width="653px" DataKeyNames="dve_Id">
                                             <RowStyle CssClass="rowgrilla" />
                                             <Columns>
                                                 <asp:TemplateField HeaderText="Verificado">
                                                     <ItemTemplate>
                                                         <asp:CheckBox ID="CheckDocumento" runat="server" />
                                                     </ItemTemplate>
                                                 </asp:TemplateField>
                                                 <asp:BoundField DataField="dve_Descripcion" HeaderText="Descripción" />
                                                 <asp:BoundField DataField="dve_Id" HeaderText="Id" Visible="False" />
                                             </Columns>
                                             <FooterStyle CssClass="footergrilla" />
                                             <HeaderStyle CssClass="headergrilla" />
                                         </asp:GridView>
                                        
                                     </td>
                                 </tr>                                 
                                     <tr>
                                         <td>
                                             <asp:Label ID="labelObservacionesPoliza" runat="server" CssClass="label" 
                                                 Text="Observaciones"></asp:Label>
                                         </td>
                                         <td colspan="3">
                                             <asp:TextBox ID="textObservacionesPoliza" runat="server" CssClass="texto2" 
                                                 EnableTheming="True" Height="50px" TextMode="MultiLine" Width="524px"></asp:TextBox>
                                         </td>
                                     </tr>
                                     <tr>
                                         <td>
                                             <asp:Label ID="labelFechaVigencia" runat="server" CssClass="label" 
                                                 Text="Fecha vigencia póliza"></asp:Label>
                                         </td>
                                         <td>
                                             <asp:TextBox ID="textFechaVigencia" runat="server" CssClass="texto2"></asp:TextBox>
                                             <cc1:CalendarExtender ID="textFechaVigencia_CalendarExtender" runat="server" 
                                                 CssClass="calendar" Format="dd/MM/yyyy" TargetControlID="textFechaVigencia">
                                             </cc1:CalendarExtender>
                                         </td>
                                         <td>
                                             <asp:Label ID="labelPlazo" runat="server" CssClass="label" Text="Plazo póliza"></asp:Label>
                                         </td>
                                         <td>
                                             <asp:TextBox ID="textFechaPlazoPoliza" runat="server" CssClass="texto2"></asp:TextBox>
                                             <cc1:CalendarExtender ID="textFechaPlazoPoliza_CalendarExtender" runat="server" 
                                                 CssClass="calendar" Format="dd/MM/yyyy" TargetControlID="textFechaPlazoPoliza">
                                             </cc1:CalendarExtender>
                                         </td>
                                     </tr>
                                     <tr>
                                         <td>
                                             <asp:Label ID="labelFechaPublicacion" runat="server" CssClass="label" 
                                                 Text="Fecha publicación"></asp:Label>
                                         </td>
                                         <td>
                                             <asp:TextBox ID="textFechaPublicacion" runat="server" CssClass="texto2"></asp:TextBox>
                                             <cc1:CalendarExtender ID="textFechaPublicacion_CalendarExtender" runat="server" 
                                                 CssClass="calendar" Format="dd/MM/yyyy" TargetControlID="textFechaPublicacion">
                                             </cc1:CalendarExtender>
                                         </td>
                                         <td>
                                             <asp:Label ID="labelFechaAprobacionPoliza" runat="server" CssClass="label" 
                                                 Text="Fecha aprobación póliza"></asp:Label>
                                         </td>
                                         <td>
                                             <asp:TextBox ID="textFechaAprobacionPoliza" runat="server" CssClass="texto2"></asp:TextBox>
                                             <cc1:CalendarExtender ID="textFechaAprobacionPoliza_CalendarExtender" 
                                                 runat="server" CssClass="calendar" Format="dd/MM/yyyy" 
                                                 TargetControlID="textFechaAprobacionPoliza">
                                             </cc1:CalendarExtender>
                                         </td>
                                     </tr>
                                     <tr>
                                         <td colspan="4">
                                             <asp:CheckBox ID="CheckEtapaPolizaAprobado" runat="server" 
                                                 Text="Etapa aprobada" 
                                                 oncheckedchanged="CheckEtapaPolizaAprobado_CheckedChanged" 
                                                 AutoPostBack="True" />
                                         </td>
                                     </tr>
                                 </table>
                                 </asp:Panel>
                                 <cc1:CollapsiblePanelExtender ID="CollapsibleTramitePoliza" runat="server" 
                                     CollapseControlID="LinkTramitePoliza" Collapsed="true" 
                                     CollapsedImage="~/images/fl_abajo.jpg" CollapsedSize="0" 
                                     ExpandControlID="LinkTramitePoliza" ExpandedImage="~/images/fl_arriba.jpg" 
                                     ImageControlID="imageTramitePoliza" SuppressPostBack="true" 
                                     TargetControlID="panelTramitePoliza">
                                 </cc1:CollapsiblePanelExtender>
                                 </ContentTemplate>
<%--                                     <Triggers>
                                         <asp:AsyncPostBackTrigger ControlID="CheckEtapaPolizaAprobado" 
                                             EventName="CheckedChanged" />
                                     </Triggers> --%> 
                                 </asp:UpdatePanel>                                                              
                             </td>
                         </tr>
                     </table>                
                </td>
             </tr>      
             <tr>
                 <td>
                     
                     <table class="formColapsableSinMargen">
                         <tr>
                             <td class="tdCollap" Height="16px">
                                 <!-- panel colapsable de documentos -->
                                 <asp:LinkButton ID="LinkEnvioEquipos" runat="server" CssClass="lnbCollap">
                                 <div>
                                <div style="float:left">Envío Equipos</div>
                                <div style="float: right; vertical-align: middle;">
                                <asp:ImageButton ID="ImageEnvioEquipos" runat="server" 
                                        ImageUrl="~/images/fl_abajo.jpg" AlternateText="Mostrar detalles" />
                                </div>
                                </div></asp:LinkButton>
                             </td>
                         </tr>
                         <tr>
                             <td>
<%--                                <asp:UpdatePanel ID="UpdatePanelEnvioEquipos" runat="server">
                                 <ContentTemplate>--%>
                                 <asp:Panel ID="panelEnvioEquipos" runat="server">
                                     <table style="width: 681px">
                                         <tr>
                                             <td colspan="5">
                                                 <div class="divgrillasscrollcollapsible">
                                                     <asp:GridView ID="gridEquiposAsignados" runat="server" 
                                                         AutoGenerateColumns="False" CssClass="grilla" DataKeyNames="Id" 
                                                         FooterStyle-CssClass="footergrilla" HeaderStyle-CssClass="headergrilla" 
                                                         RowStyle-CssClass="rowgrilla" SelectedRowStyle-CssClass="selectedgrilla" 
                                                         Width="650px">
                                                         <RowStyle CssClass="rowgrilla" />
                                                         <Columns>
                                                             <asp:BoundField DataField="equipo" HeaderText="Equipo" />
                                                             <asp:BoundField DataField="cantidad" HeaderText="Cantidad" />
                                                             <asp:BoundField DataField="costo" HeaderText="Costo" />
                                                             <asp:BoundField DataField="id" HeaderText="Id" Visible="False" />
                                                             <asp:TemplateField HeaderText="Serie">
                                                                 <ItemTemplate>
                                                                     <asp:TextBox ID="TextSerie" runat="server" Width="75px"></asp:TextBox>
                                                                 </ItemTemplate>
                                                             </asp:TemplateField>
                                                             <asp:TemplateField HeaderText="Placa">
                                                                 <ItemTemplate>
                                                                     <asp:TextBox ID="TextPlaca" runat="server" Width="75px"></asp:TextBox>
                                                                 </ItemTemplate>
                                                             </asp:TemplateField>
                                                         </Columns>
                                                         <FooterStyle CssClass="footergrilla" />
                                                         <SelectedRowStyle CssClass="selectedgrilla" />
                                                         <HeaderStyle CssClass="headergrilla" />
                                                     </asp:GridView>
                                                 </div>
                                             </td>
                                         </tr>
                                         <tr>
                                             <td colspan="2">
                                                 <asp:Label ID="labelValorTotal" runat="server" Font-Bold="True" 
                                                     Font-Size="Medium" Text="Valor total: "></asp:Label>
                                             </td>
                                             <td colspan="3">
                                                 <asp:TextBox ID="textValorTotalAsignado" runat="server" Enabled="False"></asp:TextBox>
                                             </td>
                                         </tr>
                                         <tr>
                                             <td colspan="5">
                                                 <asp:GridView ID="GridDocumentosEntrega" runat="server" 
                                                     AutoGenerateColumns="False" CssClass="grilla" DataKeyNames="dve_Id" 
                                                     FooterStyle-CssClass="footergrilla" HeaderStyle-CssClass="headergrilla" 
                                                     RowStyle-CssClass="rowgrilla" Width="653px">
                                                     <RowStyle CssClass="rowgrilla" />
                                                     <Columns>
                                                         <asp:TemplateField HeaderText="Verificado">
                                                             <ItemTemplate>
                                                                 <asp:CheckBox ID="CheckDocumento" runat="server" />
                                                             </ItemTemplate>
                                                         </asp:TemplateField>
                                                         <asp:BoundField DataField="dve_Descripcion" HeaderText="Descripción" />
                                                         <asp:BoundField DataField="dve_Id" HeaderText="Id" Visible="False" />
                                                     </Columns>
                                                     <FooterStyle CssClass="footergrilla" />
                                                     <HeaderStyle CssClass="headergrilla" />
                                                 </asp:GridView>
                                             </td>
                                         </tr>
                                         <tr>
                                             <td>
                                                 <asp:Label ID="labelFechaEntrega" runat="server" CssClass="label" 
                                                     Text="Fecha entrega"></asp:Label>
                                             </td>
                                             <td>
                                                 <cc1:CalendarExtender ID="CalendarExtender2" runat="server" CssClass="calendar" 
                                                     Format="dd/MM/yyyy" TargetControlID="textFechaVigencia">
                                                 </cc1:CalendarExtender>
                                                 <asp:TextBox ID="textFechaEntrega" runat="server" CssClass="texto2"></asp:TextBox>
                                                 <cc1:CalendarExtender ID="textFechaEntrega_CalendarExtender" runat="server" 
                                                     CssClass="calendar" Format="dd/MM/yyyy" TargetControlID="textFechaEntrega">
                                                 </cc1:CalendarExtender>
                                                 <cc1:CalendarExtender ID="textFechaEntrega_CalendarExtender2" runat="server" 
                                                     CssClass="calendar" Format="dd/MM/yyyy" TargetControlID="textFechaEntrega">
                                                 </cc1:CalendarExtender>
                                             </td>
                                             <td>
                                                 <asp:Label ID="labelLugarEntrega" runat="server" CssClass="label" 
                                                     Text="Lugar entrega"></asp:Label>
                                             </td>
                                             <td colspan="2">
                                                 <cc1:CalendarExtender ID="CalendarExtender5" runat="server" CssClass="calendar" 
                                                     Format="dd/MM/yyyy" TargetControlID="textFechaPlazoPoliza">
                                                 </cc1:CalendarExtender>
                                                 <cc1:CalendarExtender ID="CalendarExtender4" runat="server" CssClass="calendar" 
                                                     Format="dd/MM/yyyy" TargetControlID="textFechaPublicacion">
                                                 </cc1:CalendarExtender>
                                                 <asp:TextBox ID="textLugarEntrega" runat="server" CssClass="texto2" 
                                                     Height="20px" Width="255px"></asp:TextBox>
                                             </td>
                                         </tr>
                                         <tr>
                                             <td class="style3">
                                                 <asp:Label ID="labelComodato" runat="server" CssClass="label" 
                                                     Text="Comodato No"></asp:Label>
                                             </td>
                                             <td class="style3">
                                                 <asp:TextBox ID="textComodato" runat="server" CssClass="texto2" Width="151px"></asp:TextBox>
                                             </td>
                                             <td class="style3">
                                                 <asp:Label ID="labelActaEntrega" runat="server" CssClass="label" 
                                                     Text="Número acta entrega"></asp:Label>
                                             </td>
                                             <td class="style3">
                                                 <asp:TextBox ID="textNumeroActa" runat="server" CssClass="texto2" 
                                                     Width="109px"></asp:TextBox>
                                             </td>
                                             <td class="style3">
                                                 <asp:CheckBox ID="CheckEtapaEntregaAprobado" runat="server" AutoPostBack="True" 
                                                     oncheckedchanged="CheckEtapaEntregaAprobado_CheckedChanged" 
                                                     Text="Etapa aprobada" />
                                             </td>
                                         </tr>
                                     </table>
                                 </asp:Panel>
                                 <cc1:CollapsiblePanelExtender ID="CollapsibleEnvioEquipos" runat="server" 
                                     CollapseControlID="LinkEnvioEquipos" Collapsed="true" 
                                     CollapsedImage="~/images/fl_abajo.jpg" CollapsedSize="0" 
                                     ExpandControlID="LinkEnvioEquipos" ExpandedImage="~/images/fl_arriba.jpg" 
                                     ImageControlID="imageEnvioEquipos" SuppressPostBack="true" 
                                     TargetControlID="panelEnvioEquipos">
                                 </cc1:CollapsiblePanelExtender>                                 
<%--                                 </ContentTemplate>
                                     <Triggers>
                                         <asp:AsyncPostBackTrigger ControlID="CheckEtapaEntregaAprobado" 
                                             EventName="CheckedChanged" />
                                         <asp:AsyncPostBackTrigger ControlID="buttonExportar" EventName="Click" />
                                     </Triggers>
                                 </asp:UpdatePanel>--%>
                             </td>
                         </tr>
                     </table>
                     
                 </td>
             </tr>                         
          </table>       
        </asp:Panel>
      </td>
    </tr>
    <tr>
                <th>   
                <asp:Label ID="label2" runat="server" Text="Documentos" 
                        CssClass="subtitulo"></asp:Label>
                </th>
            </tr>
    <tr>
        <td>
            <uc1:DocumentosVarios ID="DocumentosVarios1" runat="server" />
        </td>
        <td>
            &nbsp;</td>
     </tr>
    <tr>
    <td colspan="2">
        &nbsp;&nbsp;
    <asp:Button ID="buttonGuardar" runat="server" Text="Guardar"  
            CssClass="button" onclick="buttonGuardar_Click"/>
    &nbsp;<asp:Button ID="buttonExportar" runat="server" CssClass="button" 
                                                     onclick="buttonExportar_Click" Text="Exportar lista equipos" 
                                                     Width="147px" />
                                             &nbsp;<asp:Button ID="buttonCancelar" runat="server" Text="Cancelar"  
            CssClass="button" onclick="buttonCancelar_Click"/>
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
        .style2
        {
            width: 112px;
        }
        .style3
        {
            height: 42px;
        }
    </style>

</asp:Content>

