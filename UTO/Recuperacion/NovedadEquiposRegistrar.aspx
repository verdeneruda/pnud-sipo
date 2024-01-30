<%@ Page Language="C#" MasterPageFile="~/MPMain.Master"  AutoEventWireup="true" CodeBehind="NovedadEquiposRegistrar.aspx.cs" Inherits="UTO.Recuperacion.NovedadEquiposRegistrar" %>

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
    <td><table style="width:100%">
    <tr>
    <td>
        <asp:Panel ID="PanelBuscarTercero" runat="server" Width="671px">
            <table>
                 <tr>
                    <th colspan="5">   
                    <asp:Label ID="labelparametros" runat="server" Text="Buscar beneficiario" 
                            CssClass="subtitulo"></asp:Label>
                    </th>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="labelNombreBeneficiario" runat="server" Text="Nombre beneficiario" CssClass="label"></asp:Label>
                    </td>
                    <td colspan="4">
                        <asp:TextBox ID="textBeneficiarioBuscar" runat="server"  CssClass="texto2" 
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
                         <asp:TextBox ID="textNumeroDocumnetoBuscar" runat="server" CssClass="texto2" 
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
                        <asp:GridView ID="GridViewTerceroBuscar" runat="server" AutoGenerateColumns="False" 
                            CssClass="grilla" DataSourceID="dsBuscarTercero" 
                            FooterStyle-CssClass="footergrilla" HeaderStyle-CssClass="headergrilla" 
                            RowStyle-CssClass="rowgrilla" SelectedRowStyle-CssClass="selectedgrilla" 
                            onrowcommand="GridViewTerceroBuscar_RowCommand" 
                            Width="649px" DataKeyNames="ter_id" AllowPaging="True" PageSize="15">
                            <RowStyle CssClass="rowgrilla" />
                            <Columns>
                                <asp:ButtonField ButtonType="Button" CommandName="Seleccionar" 
                                    Text="Seleccionar">
                                    <ControlStyle CssClass="button" />
                                </asp:ButtonField>
                                <asp:BoundField DataField="ter_id" HeaderText="ter_id" 
                                    SortExpression="ter_id" InsertVisible="False" ReadOnly="True" />
                                <asp:BoundField DataField="TipoDocumento" HeaderText="TipoDocumento" 
                                    SortExpression="TipoDocumento" />
                                <asp:BoundField DataField="ter_NumeroDocumento" HeaderText="ter_NumeroDocumento" 
                                    SortExpression="ter_NumeroDocumento" />
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
                        <br />
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
        <asp:Panel ID="PanelDatosTercero" runat="server" Visible="False" Width="742px">
         <table style="width: 706px">
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
                         Enabled="False" Width="498px"></asp:TextBox>
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
             <tr>
                 <td>
                     <asp:Label ID="labelTipoNovedad" runat="server" CssClass="label" 
                         Text="Tipo novedad"></asp:Label>
                 </td>
                 <td>
                     <asp:RadioButton ID="RadioOtroSi" runat="server" AutoPostBack="True" 
                         GroupName="tipoNovedad" oncheckedchanged="RadioOtroSi_CheckedChanged" 
                         Text="OtroSi" />
                     <asp:RadioButton ID="RadioTerminacion" runat="server" AutoPostBack="True" 
                         GroupName="tipoNovedad" oncheckedchanged="RadioTerminacion_CheckedChanged" 
                         Text="Terminación" />
                 </td>
                 <td>
                     <asp:Label ID="labelFechaNovedad" runat="server" CssClass="label" 
                         Text="Fecha novedad"></asp:Label>
                 </td>
                 <td>
                     <asp:TextBox ID="dateFechaNovedad" runat="server" CssClass="texto2"></asp:TextBox>
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
                     <asp:Panel ID="PanelOtroSi" runat="server" Width="720px" Visible="False">
                     
                         <table style="width: 702px">
                             <tr>
                                 <th colspan="3">
                                     <asp:Label ID="label4" runat="server" CssClass="subtitulo" Text="OtroSi"></asp:Label>
                                 </th>
                             </tr>
                             <tr>
                                 <td class="style3" colspan="3">
                                     <asp:CheckBox ID="CheckCambioDirección" runat="server" AutoPostBack="True" 
                                         oncheckedchanged="CheckCambioDirección_CheckedChanged" 
                                         Text="Cambio dirección" />
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
                                         EnableTheming="True" Visible="False" Width="314px"></asp:TextBox>
                                 </td>
                                 <td>
                                     <asp:DropDownList ID="comboCambioDepartamento" runat="server" CssClass="combo" DataTextField="dep_Descripcion" 
                                         DataValueField="dep_Id" Visible="False" Width="144px" AutoPostBack="True" 
                                         onselectedindexchanged="comboDepartamento_SelectedIndexChanged">
                                     </asp:DropDownList>
                                 </td>
                                 <td>
                                     <asp:DropDownList ID="comboCambioCiudad" runat="server" CssClass="combo" 
                                         DataTextField="mun_Descripcion" DataValueField="mun_Id" 
                                         Visible="False" Width="119px">
                                     </asp:DropDownList>
                                 </td>
                             </tr>
                             <tr>
                                 <td class="style3" colspan="3">
                                     <asp:CheckBox ID="CheckCambioRazonSocial" runat="server" AutoPostBack="True" 
                                         oncheckedchanged="CheckCambioRazonSocial_CheckedChanged" 
                                         Text="Cambio razón social" />
                                 </td>
                             </tr>
                             <tr>
                                 <td class="style3" colspan="3">
                                     <asp:TextBox ID="textCambioRazonSocial" runat="server" CssClass="texto2" 
                                         Visible="False" Width="690px"></asp:TextBox>
                                 </td>
                             </tr>
                             <tr>
                                 <td class="style3" colspan="3">
                                     <asp:CheckBox ID="CheckRepresentanteLegal" runat="server" AutoPostBack="True" 
                                         Text="Cambio representante legal" 
                                         oncheckedchanged="CheckRepresentanteLegal_CheckedChanged" />
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
                                         Visible="False" Width="316px"></asp:TextBox>
                                 </td>
                                 <td>
                                     <asp:DropDownList ID="comboCambioTipoDocumentoRL" runat="server" 
                                         AutoPostBack="True" CssClass="combo" 
                                         DataTextField="dti_Descripcion" DataValueField="dti_Id" Visible="False" 
                                         Width="144px">
                                     </asp:DropDownList>
                                 </td>
                                 <td>
                                     <asp:TextBox ID="textCambioDocumentoRL" runat="server" CssClass="texto2" 
                                         Visible="False" Width="111px"></asp:TextBox>
                                 </td>
                             </tr>
                             <tr>
                                 <td class="style3">
                                     <asp:CheckBox ID="CheckOtros" runat="server" AutoPostBack="True" 
                                         oncheckedchanged="CheckOtros_CheckedChanged" Text="Otros" />
                                 </td>
                                 <td>
                                     &nbsp;</td>
                                 <td>
                                     &nbsp;</td>
                             </tr>
                             <tr>
                                 <td class="style3" colspan="3">
                                     <asp:TextBox ID="textOtros" runat="server" CssClass="texto2" Visible="False" 
                                         Width="689px" Height="51px" TextMode="MultiLine"></asp:TextBox>
                                 </td>
                             </tr>
                             <tr>
                                 <td class="style3">
                                     <asp:CheckBox ID="CheckEquipoAdicional" runat="server" AutoPostBack="True" 
                                         oncheckedchanged="CheckEquipoAdicional_CheckedChanged" 
                                         Text="Equipo adicional" />
                                 </td>
                                 <td>
                                     &nbsp;</td>
                                 <td>
                                     &nbsp;</td>
                             </tr>
                             <tr>
                                 <td class="style3" colspan="3">
                                     <asp:Panel ID="PanelEquipoReasignar" runat="server" Visible="False" 
                                         Width="705px">
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
                                                                 <td colspan="6">
                                                                     <uc2:ControlError ID="ControlError" runat="server" Visible="False" />
                                                                 </td>
                                                             </tr>
                                                             <tr>
                                                                 <td>
                                                                     <asp:Label ID="labelLicitacion" runat="server" CssClass="label" 
                                                                         Text="Licitación"></asp:Label>
                                                                 </td>
                                                                 <td>
                                                                     <asp:DropDownList ID="comboLicitacion" runat="server" AutoPostBack="True" 
                                                                         CssClass="combo" DataTextField="lco_descripcion" DataValueField="lco_id" 
                                                                         onselectedindexchanged="comboLicitacion_SelectedIndexChanged" Width="228px">
                                                                     </asp:DropDownList>
                                                                 </td>
                                                                 <td>
                                                                     <asp:Label ID="labelKit" runat="server" CssClass="label" Text="Kit"></asp:Label>
                                                                 </td>
                                                                 <td colspan="3">
                                                                     <asp:DropDownList ID="comboKit" runat="server" AutoPostBack="True" 
                                                                         CssClass="combo" DataTextField="kco_descripcion" DataValueField="kco_id" 
                                                                         onselectedindexchanged="comboKit_SelectedIndexChanged" Width="228px">
                                                                     </asp:DropDownList>
                                                                 </td>
                                                             </tr>
                                                             <tr>
                                                                 <td>
                                                                     <asp:Label ID="labelEquipo" runat="server" CssClass="label" Text="Equipo"></asp:Label>
                                                                 </td>
                                                                 <td colspan="5">
                                                                     <asp:DropDownList ID="comboEquipo" runat="server" AutoPostBack="True" 
                                                                         CssClass="combo" DataTextField="eki_Nombre" DataValueField="eki_id" 
                                                                         onselectedindexchanged="comboEquipo_SelectedIndexChanged" Width="593px">
                                                                     </asp:DropDownList>
                                                                 </td>
                                                             </tr>
                                                             <tr>
                                                                 <td>
                                                                     <asp:Label ID="labelCosto" runat="server" CssClass="label" Text="Costo"></asp:Label>
                                                                 </td>
                                                                 <td>
                                                                     <asp:TextBox ID="textCosto" runat="server" CssClass="texto2" Enabled="False" 
                                                                         Width="150px"></asp:TextBox>
                                                                 </td>
                                                                 <td>
                                                                     <asp:Label ID="labelDisponible" runat="server" CssClass="label" 
                                                                         Text="Disponible"></asp:Label>
                                                                 </td>
                                                                 <td>
                                                                     <asp:TextBox ID="textDisponible" runat="server" CssClass="texto2" 
                                                                         Enabled="False" Width="80px"></asp:TextBox>
                                                                 </td>
                                                                 <td>
                                                                     <asp:Label ID="labelCantidad" runat="server" CssClass="label" Text="Cantidad"></asp:Label>&nbsp
                                                                     <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>
                                                                 </td>
                                                                 <td>
                                                                     <asp:TextBox ID="textCantidad" runat="server" CssClass="texto2" Width="80px"></asp:TextBox>
                                                                 </td>
                                                             </tr>
                                                             <tr>
                                                                 <td>
                                                                     &nbsp;</td>
                                                                 <td>
                                                                     &nbsp;</td>
                                                                 <td>
                                                                     &nbsp;</td>
                                                                 <td>
                                                                     &nbsp;</td>
                                                                 <td>
                                                                     &nbsp;</td>
                                                                 <td>
                                                                     &nbsp;</td>
                                                             </tr>
                                                             <tr>
                                                                 <td colspan="6">
                                                                     <asp:Button ID="buttonAdicionar" runat="server" CssClass="button" 
                                                                         onclick="buttonAdicionar_Click" Text="Adicionar" />
                                                                     &nbsp;<asp:Button ID="buttonCancelarEquipos" runat="server" CssClass="button" 
                                                                         onclick="buttonCancelarEquipos_Click" Text="Cancelar" />
                                                                 </td>
                                                             </tr>
                                                             <tr>
                                                                 <td colspan="6">
                                                                     <asp:GridView ID="gridSolicitudEquipos" runat="server" 
                                                                         AutoGenerateColumns="False" CssClass="grilla" 
                                                                         FooterStyle-CssClass="footergrilla" HeaderStyle-CssClass="headergrilla" 
                                                                         onrowcommand="gridSolicitudEquipos_RowCommand" RowStyle-CssClass="rowgrilla" 
                                                                         SelectedRowStyle-CssClass="selectedgrilla" Width="650px" 
                                                                         AllowPaging="True" PageSize="15">
                                                                         <RowStyle CssClass="rowgrilla" />
                                                                         <Columns>
                                                                             <asp:ButtonField ButtonType="Button" CommandName="Eliminar" Text="Eliminar">
                                                                                 <ControlStyle CssClass="button" />
                                                                             </asp:ButtonField>
                                                                             <asp:BoundField DataField="equipo" HeaderText="Equipo"></asp:BoundField>
                                                                             <asp:BoundField DataField="cantidad" HeaderText="Cantidad" />
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
                                                                     &nbsp;</td>
                                                                 <td>
                                                                     &nbsp;</td>
                                                                 <td>
                                                                     &nbsp;</td>
                                                                 <td>
                                                                     &nbsp;</td>
                                                                 <td>
                                                                     &nbsp;</td>
                                                                 <td>
                                                                     &nbsp;</td>
                                                             </tr>
                                                             <tr>
                                                                 <td>
                                                                     <asp:Label ID="label5" runat="server" Font-Bold="True" 
                                                                         Font-Size="Medium" Text="Valor total: "></asp:Label>
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
             <tr>
                 <td>
                     <asp:Panel ID="PanelTerminacion" runat="server" Width="720px" Visible="False">
                         <table style="width: 702px">
                             <tr>
                                 <th>
                                     <asp:Label ID="label7" runat="server" CssClass="subtitulo" Text="Terminacion"></asp:Label>
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
                                         EnableTheming="True" Height="109px" TextMode="MultiLine" Width="685px"></asp:TextBox>
                                 </td>
                             </tr>
                         </table>
                     </asp:Panel>
                 </td>
             </tr>
          </table>    
          <table style="width: 705px">
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
             </table>
            </asp:Panel>             
        <asp:Panel ID="panelBotones" runat="server" Visible="false">
            <table>
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
<%--<asp:Content ID="Content1" runat="server" contentplaceholderid="head">

    <style type="text/css">
        .style1
        {
            width: 131px;
        }
        .style2
        {
            width: 112px;
        }
        .style3
        {
            width: 165px;
        }
        </style>

</asp:Content>
--%>