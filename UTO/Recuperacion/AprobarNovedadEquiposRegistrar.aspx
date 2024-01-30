<%@ Page Language="C#" MasterPageFile="~/MPMain.Master"  AutoEventWireup="true" CodeBehind="AprobarNovedadEquiposRegistrar.aspx.cs" Inherits="UTO.Recuperacion.AprobarNovedadEquiposRegistrar" %>

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
        </td></tr>
    </table>
    <table class="form">
    <tr>
    <td>
    
        <uc2:ControlError ID="ControlError1" runat="server" />
    
    </td>
    </tr>
    </table>
    <table class="form">
        <tr>
    <td>
    <table>
    <tr>
    <td>
        <asp:Panel ID="PanelDatosTercero" runat="server" Width="743px">
         <table style="width: 675px">
             <tr>
                <th colspan="4">   
                <asp:Label ID="label1" runat="server" Text="Datos beneficiario" 
                        CssClass="subtitulo"></asp:Label>
                </th>
            </tr>
            <tr>
                <td class="style7">
                    <asp:Label ID="labelNombreBeneficiario0" runat="server" CssClass="label" 
                        Text="Nombre beneficiario"></asp:Label>
                </td>
                <td class="style6">
                    <asp:TextBox ID="textNombreBeneficiario" runat="server" CssClass="texto2" 
                        Width="190px" Enabled="False" ></asp:TextBox>
                </td>
                <td class="style8">                
                    <asp:Label ID="labelTipoDocumento" runat="server" CssClass="label" Text="Tipo documento"></asp:Label>                
                </td>
                <td>                
                    <asp:TextBox ID="textTipoDocumento" runat="server" CssClass="texto2" 
                        Width="190px" Enabled="False"></asp:TextBox>
                </td>
            </tr>
             <tr>
                 <td class="style7">
                     <asp:Label ID="labelDocumento" runat="server" CssClass="label" Text="Documento"></asp:Label>
                 </td>
                 <td class="style6">
                     <asp:TextBox ID="textDocumento" runat="server" AutoCompleteType="Disabled" 
                         CssClass="texto2"
                         Width="190px" Enabled="False"></asp:TextBox>
                 </td>
                 <td class="style8">
                     <asp:Label ID="labelRut" runat="server" CssClass="label" Text="Rut"></asp:Label>
                 </td>
                 <td>
                     <asp:TextBox ID="textRut" runat="server" CssClass="texto2" Width="190px" 
                         Enabled="False"></asp:TextBox>
                 </td>
             </tr>
             <tr>
                 <td class="style7">
                     <asp:Label ID="labelRepresentanteLegal" runat="server" CssClass="label" 
                         Text="Representante legal"></asp:Label>
                 </td>
                 <td class="style6">
                     <asp:TextBox ID="textNombreRepresentante" runat="server" CssClass="texto2" 
                         Width="190px" Enabled="False"></asp:TextBox>
                 </td>
                 <td class="style8">
                     <asp:Label ID="labelRegional0" runat="server" CssClass="label" Text="Regional"></asp:Label>
                 </td>
                 <td>
                     <asp:TextBox ID="textRegional" runat="server" CssClass="texto2" 
                         Width="190px" Enabled="False"></asp:TextBox>
                 </td>
             </tr>
             <tr>
                 <td class="style7">
                     <asp:Label ID="labelTipoDocumentoRL" runat="server" CssClass="label" 
                         Text="Tipo documento"></asp:Label>
                 </td>
                 <td class="style6">
                     <asp:TextBox ID="textTipoDocumentoRL" runat="server" CssClass="texto2" 
                         Width="190px" Enabled="False"></asp:TextBox>
                 </td>
                 <td class="style8">
                     <asp:Label ID="labelDocumentoRL" runat="server" CssClass="label" 
                         Text="Documento"></asp:Label>
                 </td>
                 <td>
                     <asp:TextBox ID="textDocumentoRL" runat="server" CssClass="texto2" 
                         Width="190px" Enabled="False"></asp:TextBox>
                 </td>
             </tr>
             <tr>
                 <td class="style7">
                     <asp:Label ID="labelDe" runat="server" CssClass="label" Text="De"></asp:Label>
                 </td>
                 <td class="style6">
                     <asp:TextBox ID="textDe" runat="server" CssClass="texto2" 
                         Width="190px" Enabled="False"></asp:TextBox>
                 </td>
                 <td class="style8">
                     <asp:Label ID="labelCorreo" runat="server" CssClass="label" Text="Correo"></asp:Label>
                 </td>
                 <td>
                     <asp:TextBox ID="textCorreo" runat="server" CssClass="texto2" Enabled="False" 
                         Width="190px"></asp:TextBox>
                 </td>
             </tr>
             <tr>
                 <td class="style7">
                     <asp:Label ID="labelDireccion" runat="server" CssClass="label" Text="Dirección"></asp:Label>
                 </td>
                 <td class="style6" colspan="3">
                     <asp:TextBox ID="textDireccion" runat="server" CssClass="texto2" 
                         Enabled="False" Width="492px"></asp:TextBox>
                 </td>
             </tr>
             <tr>
                 <td class="style7">
                     <asp:Label ID="labelDepartamento" runat="server" CssClass="label" 
                         Text="Departamento"></asp:Label>
                 </td>
                 <td class="style6">
                     <asp:TextBox ID="textDepartamento" runat="server" CssClass="texto2" 
                         Width="190px" Enabled="False"></asp:TextBox>
                 </td>
                 <td class="style8">
                     <asp:Label ID="labelMunicipio" runat="server" CssClass="label" Text="Municipio"></asp:Label>
                 </td>
                 <td>
                     <asp:TextBox ID="textMunicipio" runat="server" CssClass="texto2" 
                         Width="190px" Enabled="False"></asp:TextBox>
                 </td>
             </tr>
             <tr>
                 <td class="style7">
                     <asp:Label ID="labelTipoBeneficiario" runat="server" CssClass="label" 
                         Text="Tipo beneficiario"></asp:Label>
                 </td>
                 <td class="style6">
                     <asp:TextBox ID="textTipoBeneficiario" runat="server" CssClass="texto2" 
                         Height="22px" Width="190px" Enabled="False"></asp:TextBox>
                 </td>
                 <td class="style8">
                     <asp:Label ID="labelTelefono" runat="server" CssClass="label" Text="Teléfono"></asp:Label>
                 </td>
                 <td>
                     <asp:TextBox ID="textTelefono" runat="server" CssClass="texto2" Enabled="False" 
                         Width="190px"></asp:TextBox>
                 </td>
             </tr>             
             <tr>
                 <td class="style7">
                     <asp:Label ID="labelTipoNovedad" runat="server" CssClass="label" 
                         Text="Tipo novedad"></asp:Label>
                 </td>
                 <td class="style6">
                     <asp:RadioButton ID="RadioOtroSi" runat="server" AutoPostBack="True" 
                         GroupName="tipoNovedad" 
                         Text="OtroSi" Checked="True" Enabled="False" />
                     <asp:RadioButton ID="RadioTerminacion" runat="server" AutoPostBack="True" 
                         GroupName="tipoNovedad" 
                         Text="Terminación" Enabled="False" />
                 </td>
                 <td class="style8">
                     <asp:Label ID="labelFechaNovedad" runat="server" CssClass="label" 
                         Text="Fecha novedad"></asp:Label>
                 </td>
                 <td>
                     <asp:TextBox ID="dateFechaNovedad" runat="server" CssClass="texto2" 
                         Enabled="False" Width="190px"></asp:TextBox>
                     <cc1:CalendarExtender ID="dateFechaNovedad_CalendarExtender" runat="server" 
                         CssClass="calendar" Format="dd/MM/yyyy" TargetControlID="dateFechaNovedad">
                     </cc1:CalendarExtender>
                     <cc1:CalendarExtender ID="CalendarExtender3" runat="server" CssClass="calendar" 
                         Format="dd/MM/yyyy" TargetControlID="dateFechaNovedad">
                     </cc1:CalendarExtender>
                 </td>
             </tr> 
             </table>            
             <table>
             <tr>
                 <td>
                     <table class="formColapsableSinMargen">
                         <tr>
                             <td class="tdCollap" Height="16px">
                                 <!-- panel colapsable de documentos -->
                                 <asp:LinkButton ID="linkNovedad" runat="server" CssClass="lnbCollap">
                                 <div>
                                <div style="float:left">Novedad</div>
                                <div style="float: right; vertical-align: middle;">
                                <asp:ImageButton ID="ImageButton1" runat="server" 
                                        ImageUrl="~/images/fl_abajo.jpg" AlternateText="Mostrar detalles" />
                                </div>
                                </div></asp:LinkButton>
                             </td>
                         </tr>
                         <tr>
                             <td>
                                 <cc1:CollapsiblePanelExtender ID="CollapsibleNovedad" runat="server" 
                                     CollapseControlID="linkNovedad" Collapsed="true" 
                                     CollapsedImage="~/images/fl_abajo.jpg" CollapsedSize="0" 
                                     ExpandControlID="linkNovedad" ExpandedImage="~/images/fl_arriba.jpg" 
                                     ExpandedSize="300" ImageControlID="imageNovedad" 
                                     SuppressPostBack="true" TargetControlID="panelNovedad">
                                 </cc1:CollapsiblePanelExtender>
                                 <asp:Panel ID="PanelNovedad" runat="server" Width="731px">
                                     <table style="width: 697px">
                                         <tr>
                                             <td>
                                                 <asp:Panel ID="PanelOtroSi" runat="server" Width="720px">
                                                     <table style="width: 702px">
                                                         <tr>
                                                             <th>
                                                                 <asp:Label ID="label3" runat="server" CssClass="subtitulo" Text="OtroSi"></asp:Label>
                                                             </th>
                                                         </tr>
                                                         <tr>
                                                             <td class="style3">
                                                                 <asp:Panel ID="PanelCambioDirección" runat="server" Visible="False">
                                                                     <table>
                                                                         <tr>
                                                                             <td class="style3" colspan="3">
                                                                                 <asp:CheckBox ID="CheckCambioDirección" runat="server" AutoPostBack="True" 
                                                                                     Text="Cambio dirección" Visible="False" />
                                                                             </td>
                                                                         </tr>
                                                                         <tr>
                                                                             <td class="style3">
                                                                                 <asp:Label ID="labelCambioDireccion" runat="server" CssClass="label" 
                                                                                     Text="Dirección" Visible="False"></asp:Label>
                                                                             </td>
                                                                             <td>
                                                                                 <asp:Label ID="labelCambioDepartamento" runat="server" CssClass="label" 
                                                                                     Text="Departamento" Visible="False"></asp:Label>
                                                                             </td>
                                                                             <td>
                                                                                 <asp:Label ID="labelCambioMunicipio" runat="server" CssClass="label" 
                                                                                     Text="Municipio" Visible="False"></asp:Label>
                                                                             </td>
                                                                         </tr>
                                                                         <tr>
                                                                             <td class="style3">
                                                                                 <asp:TextBox ID="textCambioDireccion" runat="server" CssClass="texto2" 
                                                                                     Enabled="False" EnableTheming="True" Visible="False" Width="314px"></asp:TextBox>
                                                                             </td>
                                                                             <td>
                                                                                 <asp:DropDownList ID="comboCambioDepartamento" runat="server" 
                                                                                     AutoPostBack="True" CssClass="combo" DataTextField="dep_Descripcion" 
                                                                                     DataValueField="dep_Id" Enabled="False" Visible="False" Width="144px">
                                                                                 </asp:DropDownList>
                                                                             </td>
                                                                             <td>
                                                                                 <asp:DropDownList ID="comboCambioCiudad" runat="server" CssClass="combo" 
                                                                                     DataTextField="mun_Descripcion" DataValueField="mun_Id" Enabled="False" 
                                                                                     Visible="False" Width="119px">
                                                                                 </asp:DropDownList>
                                                                             </td>
                                                                         </tr>
                                                                     </table>
                                                                 </asp:Panel>
                                                             </td>
                                                         </tr>
                                                         <tr>
                                                             <td class="style3">
                                                                 <asp:Panel ID="PanelCambioRazonSocial" runat="server" Visible="False">
                                                                     <table>
                                                                         <tr>
                                                                             <td class="style3">
                                                                                 <asp:CheckBox ID="CheckCambioRazonSocial" runat="server" AutoPostBack="True" 
                                                                                     Enabled="False" Text="Cambio razón social" Visible="False" />
                                                                             </td>
                                                                         </tr>
                                                                         <tr>
                                                                             <td class="style3">
                                                                                 <asp:TextBox ID="textCambioRazonSocial" runat="server" CssClass="texto2" 
                                                                                     Enabled="False" Visible="False" Width="598px"></asp:TextBox>
                                                                             </td>
                                                                         </tr>
                                                                     </table>
                                                                 </asp:Panel>
                                                             </td>
                                                         </tr>
                                                         <tr>
                                                             <td class="style3">
                                                                 <asp:Panel ID="PanelRepresentanteLegal" runat="server" Visible="False">
                                                                     <table>
                                                                         <tr>
                                                                             <td class="style3" colspan="3">
                                                                                 <asp:CheckBox ID="CheckRepresentanteLegal" runat="server" AutoPostBack="True" 
                                                                                     Enabled="False" Text="Cambio representante legal" Visible="False" />
                                                                             </td>
                                                                         </tr>
                                                                         <tr>
                                                                             <td class="style3">
                                                                                 <asp:Label ID="labelCambioRepresentanteLegal" runat="server" CssClass="label" 
                                                                                     Text="Representante legal" Visible="False"></asp:Label>
                                                                             </td>
                                                                             <td>
                                                                                 <asp:Label ID="labelCambioTipoDocumentoRL" runat="server" CssClass="label" 
                                                                                     Text="Tipo documento" Visible="False"></asp:Label>
                                                                             </td>
                                                                             <td>
                                                                                 <asp:Label ID="labelCambioDocumentoRL" runat="server" CssClass="label" 
                                                                                     Text="Documento" Visible="False"></asp:Label>
                                                                             </td>
                                                                         </tr>
                                                                         <tr>
                                                                             <td class="style3">
                                                                                 <asp:TextBox ID="textCambioRepresentanteLegal" runat="server" CssClass="texto2" 
                                                                                     Enabled="False" Visible="False" Width="316px"></asp:TextBox>
                                                                             </td>
                                                                             <td>
                                                                                 <asp:DropDownList ID="comboCambioTipoDocumentoRL" runat="server" 
                                                                                     AutoPostBack="True" CssClass="combo" DataTextField="dti_Descripcion" 
                                                                                     DataValueField="dti_Id" Visible="False" Width="144px" Enabled="False">
                                                                                 </asp:DropDownList>
                                                                             </td>
                                                                             <td>
                                                                                 <asp:TextBox ID="textCambioDocumentoRL" runat="server" CssClass="texto2" 
                                                                                     Enabled="False" Visible="False" Width="83px"></asp:TextBox>
                                                                             </td>
                                                                         </tr>
                                                                     </table>
                                                                 </asp:Panel>
                                                             </td>
                                                         </tr>
                                                         <tr>
                                                             <td class="style3">
                                                                 <asp:Panel ID="PanelOtros" runat="server" Visible="False">
                                                                     <table>
                                                                         <tr>
                                                                             <td class="style3">
                                                                                 <asp:CheckBox ID="CheckOtros" runat="server" AutoPostBack="True" 
                                                                                     Enabled="False" Text="Otros" Visible="False" />
                                                                             </td>
                                                                         </tr>
                                                                         <tr>
                                                                             <td class="style3">
                                                                                 <asp:TextBox ID="textOtros" runat="server" CssClass="texto2" Enabled="False" 
                                                                                     Height="51px" TextMode="MultiLine" Visible="False" Width="650px"></asp:TextBox>
                                                                             </td>
                                                                         </tr>
                                                                     </table>
                                                                 </asp:Panel>
                                                             </td>
                                                         </tr>
                                                         <tr>
                                                             <td class="style3">
                                                                 <asp:Panel ID="PanelEquipoAdicional" runat="server" Visible="False">
                                                                     <table>
                                                                         <tr>
                                                                             <td class="style3">
                                                                                 <asp:CheckBox ID="CheckEquipoAdicional" runat="server" AutoPostBack="True" 
                                                                                     Enabled="False" Text="Equipo adicional" Visible="False" />
                                                                             </td>
                                                                         </tr>
                                                                         <tr>
                                                                             <td class="style3">
                                                                                 <asp:Panel ID="PanelEquipoReasignar" runat="server" Visible="False">
                                                                                     <table>
                                                                                         <tr>
                                                                                             <th>
                                                                                                 <asp:Label ID="label6" runat="server" CssClass="subtitulo" 
                                                                                                     Text="Seleccione equipos a reasignar"></asp:Label>
                                                                                             </th>
                                                                                         </tr>
                                                                                         <tr>
                                                                                             <td>
                                                                                                 <asp:Panel ID="PanelEquipos" runat="server" Width="708px">
                                                                                                     <table>
                                                                                                         <tr>
                                                                                                             <td class="style9" colspan="6">
                                                                                                                 <asp:GridView ID="gridSolicitudEquipos" runat="server" 
                                                                                                                     AutoGenerateColumns="False" CssClass="grilla" 
                                                                                                                     FooterStyle-CssClass="footergrilla" HeaderStyle-CssClass="headergrilla" 
                                                                                                                     RowStyle-CssClass="rowgrilla" SelectedRowStyle-CssClass="selectedgrilla" 
                                                                                                                     Width="650px">
                                                                                                                     <RowStyle CssClass="rowgrilla" />
                                                                                                                     <Columns>
                                                                                                                         <asp:BoundField DataField="equipo" HeaderText="Equipo" />
                                                                                                                         <asp:BoundField DataField="cantidad" HeaderText="Cantidad" />
                                                                                                                         <asp:BoundField DataField="disponible" HeaderText="Disponible" />
                                                                                                                         <asp:BoundField DataField="costo" HeaderText="Costo" />
                                                                                                                         <asp:BoundField DataField="id" HeaderText="Id" />
                                                                                                                         <asp:BoundField DataField="idProvisional" HeaderText="idProvisional" />
                                                                                                                     </Columns>
                                                                                                                     <FooterStyle CssClass="footergrilla" />
                                                                                                                     <SelectedRowStyle CssClass="selectedgrilla" />
                                                                                                                     <HeaderStyle CssClass="headergrilla" />
                                                                                                                 </asp:GridView>
                                                                                                             </td>
                                                                                                         </tr>
                                                                                                         <tr>
                                                                                                             <td>
                                                                                                                 <asp:Label ID="label5" runat="server" Font-Bold="True" Font-Size="Medium" 
                                                                                                                     Text="Valor total: "></asp:Label>
                                                                                                             </td>
                                                                                                             <td>
                                                                                                                 <asp:TextBox ID="textValorTotal" runat="server" Enabled="False"></asp:TextBox>
                                                                                                             </td>
                                                                                                             <td>
                                                                                                                 &nbsp;</td>
                                                                                                             <td>
                                                                                                                 &nbsp;</td>
                                                                                                             <td>
                                                                                                                 &nbsp;</td>
                                                                                                             <td>
                                                                                                                 &nbsp;</td>
                                                                                                         </tr>
                                                                                                     </table>
                                                                                                 </asp:Panel>
                                                                                             </td>
                                                                                         </tr>
                                                                                     </table>
                                                                                 </asp:Panel>
                                                                             </td>
                                                                         </tr>
                                                                     </table>
                                                                 </asp:Panel>
                                                             </td>
                                                         </tr>
                                                     </table>
                                                 </asp:Panel>
                                             </td>
                                         </tr>
                                         <tr>
                                             <td>
                                                 <asp:Panel ID="PanelTerminacion" runat="server" Visible="False" Width="720px">
                                                     <table style="width: 702px">
                                                         <tr>
                                                             <th>
                                                                 <asp:Label ID="label7" runat="server" CssClass="subtitulo" Text="Terminación"></asp:Label>
                                                             </th>
                                                         </tr>
                                                         <tr>
                                                             <td class="style3">
                                                                 <asp:Label ID="labelMotivo" runat="server" CssClass="label" Text="Motivo"></asp:Label>
                                                             </td>
                                                         </tr>
                                                         <tr>
                                                             <td class="style3">
                                                                 <asp:TextBox ID="textMotivoTerminacion" runat="server" CssClass="texto2" 
                                                                     Enabled="False" EnableTheming="True" Height="109px" TextMode="MultiLine" 
                                                                     Width="685px"></asp:TextBox>
                                                             </td>
                                                         </tr>
                                                     </table>
                                                 </asp:Panel>
                                             </td>
                                         </tr>
                                     </table>
                                 </asp:Panel>
                             </td>
                         </tr>
                     </table>
                 </td>
             </tr>             
             <tr>
                 <td>
                     <table class="formColapsableSinMargen">
                         <tr>
                             <td class="tdCollap" style="height: 16px">
                                 <!-- panel colapsable de documentos -->
                                 <asp:LinkButton ID="LinkEstudiosPrevios" runat="server" CssClass="lnbCollap">
                                 <div>
                                <div style="float:left">Documentos soporte</div>
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
                                     </div>
                                     <table>
                                         <tr>
                                             <td>
                                                 <asp:Label ID="labelObservaciones" runat="server" CssClass="label" 
                                                     Text="Observaciones"></asp:Label>
                                             </td>
                                             <td>
                                                 <asp:TextBox ID="textObservacionesEstudiosPrevios" runat="server" CssClass="texto2" 
                                                     EnableTheming="True" Height="50px" TextMode="MultiLine" Width="559px"></asp:TextBox>
                                             </td>
                                         </tr>
                                         <tr>
                                             <td colspan="2">
                                                 <asp:CheckBox ID="CheckEtapaEstudioAprobado" runat="server" 
                                                     Text="Etapa aprobada" 
                                                     oncheckedchanged="CheckEtapaEstudioAprobado_CheckedChanged" 
                                                     AutoPostBack="True" />
                                                 &nbsp;</td>
                                         </tr>
                                     </table>
                                 </asp:Panel>
                                 <cc1:CollapsiblePanelExtender ID="collapsibleEstudiosPrevios" runat="server" 
                                     CollapseControlID="linkEstudiosPrevios" Collapsed="true" 
                                     CollapsedImage="~/images/fl_abajo.jpg" CollapsedSize="0" 
                                     ExpandControlID="linkEstudiosPrevios" ExpandedImage="~/images/fl_arriba.jpg" 
                                     ExpandedSize="440" ImageControlID="imageEstudiosPrevios" 
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
             <tr>
                 <td>
                     <table class="formColapsableSinMargen">
                         <tr>
                             <td class="tdCollap" Height="16px">
                                 <!-- panel colapsable de documentos -->
                                 <asp:LinkButton ID="LinkElaboracionMinutas" runat="server" CssClass="lnbCollap">
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
                                                     <asp:Label ID="labelFechaFirmadaMinuta" runat="server" CssClass="label" 
                                                         Text="Fecha firma minuta"></asp:Label>
                                                 </td>
                                                 <td>
                                                     <asp:TextBox ID="textFechaFirmaMinuta" runat="server" CssClass="texto2"></asp:TextBox>
                                                     <cc1:CalendarExtender ID="textFechaFirmaMinuta_CalendarExtender" runat="server" 
                                                         CssClass="calendar" Format="dd/MM/yyyy" 
                                                         TargetControlID="textFechaFirmaMinuta">
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
                                                 <td>
                                                     <asp:Label ID="labelNumeroOtroSi" runat="server" CssClass="label" 
                                                         Text="Número OtroSi"></asp:Label>
                                                 </td>
                                                 <td>
                                                     <asp:TextBox ID="textNumeroOtroSi" runat="server" CssClass="texto2" 
                                                         Width="151px"></asp:TextBox>
                                                 </td>
                                                 <td>
                                                     <asp:CheckBox ID="CheckEtapaMinutaAprobado" runat="server" 
                                                         Text="Etapa aprobada" 
                                                         oncheckedchanged="CheckEtapaMinutaAprobado_CheckedChanged" 
                                                         AutoPostBack="True" />
                                                 </td>
                                                 <td>
                                                     &nbsp;</td>
                                             </tr>
                                         </table>
                                     </asp:Panel>
                                     <cc1:CollapsiblePanelExtender ID="CollapsibleElaboracionMinutas" runat="server" 
                                         CollapseControlID="LinkElaboracionMinutas" Collapsed="true" 
                                         CollapsedImage="~/images/fl_abajo.jpg" CollapsedSize="0" 
                                         ExpandControlID="LinkElaboracionMinutas" ExpandedImage="~/images/fl_arriba.jpg" 
                                         ExpandedSize="200" ImageControlID="imageElaboracionMinutas" 
                                         SuppressPostBack="true" TargetControlID="panelElaboracionMinutas">
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
             <tr>
                 <td>
                     <table class="formColapsableSinMargen">
                         <tr>
                             <td class="tdCollap" Height="16px">
                                 <!-- panel colapsable de documentos -->
                                 <asp:LinkButton ID="LinkTramitePoliza" runat="server" CssClass="lnbCollap">
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
                                 <ContentTemplate>--%>
                                 <asp:Panel ID="panelTramitePoliza" runat="server">
                                     <table style="width: 679px">
                                         <tr>
                                             <td colspan="4">
                                                 <asp:GridView ID="GridDocumentosPoliza" runat="server" 
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
                                                 <asp:CheckBox ID="CheckEtapaPolizaAprobado" runat="server" AutoPostBack="True" 
                                                     oncheckedchanged="CheckEtapaPolizaAprobado_CheckedChanged" 
                                                     Text="Etapa aprobada" />
                                             </td>
                                         </tr>
                                     </table>
                                 </asp:Panel>
                                 <cc1:CollapsiblePanelExtender ID="CollapsibleTramitePoliza" runat="server" 
                                     CollapseControlID="LinkTramitePoliza" Collapsed="true" 
                                     CollapsedImage="~/images/fl_abajo.jpg" CollapsedSize="0" 
                                     ExpandControlID="LinkTramitePoliza" ExpandedImage="~/images/fl_arriba.jpg" 
                                     ExpandedSize="350" ImageControlID="imageTramitePoliza" 
                                     SuppressPostBack="true" TargetControlID="panelTramitePoliza">
                                 </cc1:CollapsiblePanelExtender>                                     
<%--                                </ContentTemplate>
                                     <Triggers>
                                         <asp:AsyncPostBackTrigger ControlID="CheckEtapaPolizaAprobado" 
                                             EventName="CheckedChanged" />
                                     </Triggers>
                                 </asp:UpdatePanel>    --%>                       
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
                                                 <asp:Button ID="buttonExportar" runat="server" CssClass="button" 
                                                     onclick="buttonExportar_Click" Text="Exportar lista equipos" 
                                                     Width="147px" />
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
                                                 <asp:TextBox ID="textActaEntrega" runat="server" CssClass="texto2" 
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
                                     </Triggers>
                                 </asp:UpdatePanel>--%>
                             </td>
                         </tr>
                     </table>
                     
                 </td>
             </tr>
          </table>    
          <table style="width: 707px">
            <tr>
                        <th>   
                        <asp:Label ID="label2" runat="server" Text="Documentos" 
                                CssClass="subtitulo"></asp:Label>
                        </th>
            </tr>
            <tr>
                <td style="width:20%">
                    <uc1:DocumentosVarios ID="DocumentosVarios1" runat="server" />
                </td>
             </tr>   
            <tr>
                <td>
                    &nbsp;&nbsp;
                <asp:Button ID="buttonGuardar" runat="server" Text="Guardar"  
                        CssClass="button" onclick="buttonGuardar_Click"/>
                &nbsp;<asp:Button ID="buttonCancelar" runat="server" Text="Cancelar"  
                        CssClass="button" onclick="buttonCancelar_Click"/>
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
    </div>
    <br />
    <br />
    </asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="head">

    <style type="text/css">
        .style3
        {
        }
        .style6
        {
            width: 164px;
        }
        .style7
        {
            width: 62px;
        }
        .style8
        {
            width: 70px;
        }
        .style9
        {
            height: 27px;
        }
        </style>

</asp:Content>

