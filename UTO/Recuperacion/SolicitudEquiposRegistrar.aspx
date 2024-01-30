    <%@ Page Language="C#" MasterPageFile="~/MPMain.Master"  AutoEventWireup="true" CodeBehind="SolicitudEquiposRegistrar.aspx.cs" Inherits="UTO.Recuperacion.SolicitudEquiposRegistrar" %>

    <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

    <%@ Register src="~/Comunes/DocumentosVarios.ascx" tagname="DocumentosVarios" tagprefix="uc1" %>

    <%@ Register src="../Comunes/ControlError.ascx" tagname="ControlError" tagprefix="uc2" %>

    <%@ Register src="../Comunes/ControlTercero.ascx" tagname="ControlTercero" tagprefix="uc3" %>
<asp:Content ID="Content1" runat="server" contentplaceholderid="head">


</asp:Content>
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
    <td><table style="width:100%">
    <tr>
    <td>
        <asp:Panel ID="PanelBuscarTercero" runat="server" Width="671px">
            <table>
                 <tr>
                    <th colspan="4">   
                    <asp:Label ID="labelparametros" runat="server" Text="Buscar beneficiario" 
                            CssClass="subtitulo"></asp:Label>
                    </th>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="labelNombreBeneficiario" runat="server" Text="Nombre beneficiario" CssClass="label"></asp:Label>&nbsp
                        
                    </td>
                    <td colspan="3">
                        <asp:TextBox ID="textNombreBeneficiarioBuscar" runat="server"  CssClass="texto2" 
                            Width="449px"></asp:TextBox>
                    </td>
<%--                    <td class="separador">
                        &nbsp;</td>--%>
                </tr>
                 <tr>
                     <td>
                         <asp:Label ID="label3" runat="server" CssClass="label" Text="Tipo documento"></asp:Label>
                         
                     </td>
                     <td>
                         <asp:DropDownList ID="comboTipoDocumentoBuscar" runat="server" CssClass="combo" DataTextField="dti_Descripcion" 
                             DataValueField="dti_Id" Width="200px">
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
<%--                     <td >
                         &nbsp;</td>
                     <td class="separador">
                         &nbsp;</td>--%>
                 </tr>
                <tr>
                    <td colspan="4">
                        <asp:Button ID="buttonBuscarTercero" runat="server" CssClass="button" 
                            Text="Buscar" onclick="buttonBuscarTercero_Click" />
                        &nbsp;<asp:Button ID="buttonAdicionarTercero" runat="server" CssClass="button" 
                            onclick="buttonAdicionarTercero_Click" Text="Adicionar"  />
                        &nbsp;</td>
                </tr>
                <tr>
                    <td colspan="4">
                        <asp:GridView ID="GridViewTerceroBuscar" runat="server" 
                            CssClass="grilla" 
                            FooterStyle-CssClass="footergrilla" HeaderStyle-CssClass="headergrilla" 
                            RowStyle-CssClass="rowgrilla" SelectedRowStyle-CssClass="selectedgrilla" 
                            onrowcommand="GridViewTerceroBuscar_RowCommand" 
                            Width="649px" DataKeyNames="ter_id" DataSourceID="dsBuscarTercero" 
                            AutoGenerateColumns="False" AllowPaging="True" PageSize="15">
                            <RowStyle CssClass="rowgrilla" />
                            <Columns>
                                <asp:ButtonField ButtonType="Button" CommandName="Seleccionar" 
                                    Text="Seleccionar">
                                    <ControlStyle CssClass="buttongrilla" />
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
         <table class = "form">
        <tr>
        <td>       
            <uc2:ControlError ID="ControlError1" runat="server" />        
        </td>
        </tr>
        </table>        
         <table class = "form">
             <tr>
                <th colspan="4">   
                <asp:Label ID="label1" runat="server" Text="Datos beneficiario" 
                        CssClass="subtitulo"></asp:Label>
                </th>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="labelNombreBeneficiario0" runat="server" CssClass="label" 
                        Text="Nombre beneficiario"></asp:Label>&nbsp
                    <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>    
                </td>
                <td colspan="3">
                    <asp:TextBox ID="textNombreBeneficiario" runat="server" CssClass="texto2" 
                        Width="528px" Enabled="False" ></asp:TextBox>
                </td>
            </tr>
             <tr>
                 <td>
                     <asp:Label ID="labelDocumento" runat="server" CssClass="label" Text="Documento"></asp:Label>&nbsp
                     <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>
                 </td>
                 <td>
                     <asp:TextBox ID="textDocumento" runat="server" AutoCompleteType="Disabled" 
                         CssClass="texto2" Enabled="False" Width="150px"></asp:TextBox>
                 </td>
                 <td>
                     <asp:Label ID="labelTipoDocumento" runat="server" CssClass="label" 
                         Text="Tipo documento"></asp:Label>&nbsp
                     <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>  
                 </td>
                 <td>
                     <asp:DropDownList ID="comboTipoDocumento" runat="server" CssClass="combo" 
                         DataTextField="dti_Descripcion" DataValueField="dti_Id" 
                         Enabled="False">
                     </asp:DropDownList>
                 </td>
             </tr>
             <tr>
                 <td>
                     <asp:Label ID="label12" runat="server" CssClass="label" 
                         Text="Regional"></asp:Label>&nbsp
                     <asp:Label ID="Label13" runat="server" Text="(*)" Font-Bold="true"></asp:Label>    
                 </td>
                 <td>
                     <asp:DropDownList ID="comboRegional" runat="server" AutoPostBack="True" 
                         CssClass="combo" DataTextField="reg_Descripcion" DataValueField="reg_Id" 
                         Enabled="False" 
                         onselectedindexchanged="comboRegional_SelectedIndexChanged">
                     </asp:DropDownList>
                 </td>             
                 <td>
                     <asp:Label ID="labelDepartamento" runat="server" CssClass="label" 
                         Text="Departamento"></asp:Label>&nbsp
                     <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>    
                 </td>
                 <td>
                     <asp:DropDownList ID="comboDepartamento" runat="server" AutoPostBack="True" 
                         CssClass="combo" DataTextField="dep_Descripcion" DataValueField="dep_Id" 
                         onselectedindexchanged="comboDepartamento_SelectedIndexChanged" Enabled="False">
                     </asp:DropDownList>
                 </td>

             </tr>
             <tr>
                 <td>
                     <asp:Label ID="labelMunicipio" runat="server" CssClass="label" Text="Municipio"></asp:Label>&nbsp
                     <asp:Label ID="Label11" runat="server" Text="(*)" Font-Bold="true"></asp:Label>
                 </td>
                 <td>
                     <asp:DropDownList ID="comboCiudad" runat="server" CssClass="combo" 
                         DataTextField="mun_Descripcion" DataValueField="mun_Id" 
                         Enabled="False">
                     </asp:DropDownList>
                 </td>             
                 <td>
                     <asp:Label ID="labelTelefono" runat="server" CssClass="label" Text="Teléfono"></asp:Label>
                 </td>
                 <td>
                     <asp:TextBox ID="textTelefono" runat="server" CssClass="texto2" Enabled="False"></asp:TextBox>
                 </td>

             </tr>
             <tr>
                 <td>
                     <asp:Label ID="labelCorreo" runat="server" CssClass="label" Text="Correo"></asp:Label>
                 </td>
                 <td>
                     <asp:TextBox ID="textCorreo" runat="server" CssClass="texto2" Enabled="False" 
                         Width="199px"></asp:TextBox>
                 </td>
                 <td>
                     <asp:Label ID="labelCelular" runat="server" CssClass="label" Text="Celular"></asp:Label>
                 </td>
                 <td>
                     <asp:TextBox ID="textCelular" runat="server" CssClass="texto2" Enabled="False"></asp:TextBox>
                 </td>
             </tr>
             <tr>
                 <td>
                     <asp:Label ID="labelFax" runat="server" CssClass="label" Text="Fax"></asp:Label>
                 </td>
                 <td>
                     <asp:TextBox ID="textFax" runat="server" CssClass="texto2" Enabled="False" 
                         Width="199px"></asp:TextBox>
                 </td>
                 <td>
                     <asp:Label ID="label14" runat="server" CssClass="label" Text="RUT"></asp:Label>
                 </td>
                 <td>
                     <asp:TextBox ID="textRut" runat="server" CssClass="texto2" 
                         Enabled="False" ></asp:TextBox>
                 </td>                     
             </tr>
             <tr>
                 <td>
                     <asp:Label ID="labelDireccion" runat="server" CssClass="label" Text="Dirección"></asp:Label>
                 </td>
                 <td colspan="3">
                     <asp:TextBox ID="textDireccion" runat="server" CssClass="texto2" 
                         Enabled="False" Width="529px"></asp:TextBox>
                 </td>
             
             </tr>                                                 
             <tr>
                 <td>
                     <asp:Label ID="labelTipoBeneficiario" runat="server" CssClass="label" 
                         Text="Tipo beneficiario"></asp:Label>
                 </td>
                 <td colspan="3">
                     <asp:RadioButton ID="RadioPersonaNatural" runat="server" 
                         Checked="True" CssClass="radio" GroupName="TipoBeneficiario" 
                         Text="Persona natural" AutoPostBack="True" 
                         oncheckedchanged="RadioPersonaNatural_CheckedChanged" />
                     &nbsp;<asp:RadioButton ID="RadioPersonaJuridica" runat="server" 
                         CssClass="radio" GroupName="TipoBeneficiario" 
                         Text="Persona jurídica" AutoPostBack="True" 
                         oncheckedchanged="RadioPersonaJuridica_CheckedChanged" />
                     &nbsp;<asp:RadioButton ID="radioEstablecimiento" runat="server" 
                         CssClass="radio" GroupName="TipoBeneficiario" 
                         Text="Persona natural con establecimiento de comercio" AutoPostBack="True" oncheckedchanged="radioEstablecimiento_CheckedChanged" 
                          />                         
                 </td>
             </tr>
             <tr>
                 <td colspan="4">
                     <asp:Panel ID="PanelPersonaJuridica" runat="server" Visible="False">
                     <table style="width: 696px">
                         <tr>
                             <td>
                                 <asp:Label ID="label15" runat="server" CssClass="label" 
                                     Text="Establecimiento de comercio"></asp:Label>
                             </td>
                             <td colspan="3">
                                 <asp:TextBox ID="textEstablecimiento" runat="server" CssClass="texto2" 
                                     Width="515px" Enabled="False"></asp:TextBox>
                             </td>
                         </tr>
                         <tr>
                             <td>
                                 <asp:Label ID="labelRepresentanteLegal" runat="server" CssClass="label" 
                                     Text="Representante legal"></asp:Label>
                             </td>
                             <td colspan="3">
                                 <asp:TextBox ID="textNombreRepresentante" runat="server" CssClass="texto2" 
                                     Width="515px" Enabled="False"></asp:TextBox>
                             </td>
                         </tr>
                         <tr>
                             <td>
                                 <asp:Label ID="labelTipoDocumentoRL" runat="server" CssClass="label" 
                                     Text="Tipo documento"></asp:Label>
                                  
                             </td>
                             <td>
                                 <asp:DropDownList ID="comboTipoDocumentoRL" runat="server" CssClass="combo" 
                                     DataTextField="dti_Descripcion" DataValueField="dti_Id" 
                                     Enabled="False">
                                 </asp:DropDownList>
                             </td>
                             <td>
                                 <asp:Label ID="labelDocumentoRL" runat="server" CssClass="label" 
                                     Text="Documento"></asp:Label>
                             </td>
                             <td>
                                 <asp:TextBox ID="textDocumentoRL" runat="server" CssClass="texto2" 
                                     Enabled="False"></asp:TextBox>
                             </td>
                         </tr>                     
                     </table>                     
                     </asp:Panel>
                 </td>
             </tr>
             <tr>
                 <td colspan="4">
                     <asp:Button ID="buttonGuardarTercero" runat="server" CssClass="button" 
                         onclick="buttonGuardarTercero_Click" Text="Guardar" Visible="False" />
                     &nbsp;<asp:Button ID="buttonCancelarTercero" runat="server" CssClass="button" 
                         onclick="buttonCancelarTercero_Click" Text="Cancelar" Visible="False" />
                 </td>
             </tr>
             </table>
        </asp:Panel>
        <asp:Panel ID="PanelEntrega" runat="server" Visible="False" Width="716px">
         <table class = "form">
             <tr>
                 <td>
                     <asp:Label ID="label16" runat="server" CssClass="label" Text="Proyecto"></asp:Label>
                     <asp:Label ID="Label24" runat="server" Text="(*)" Font-Bold="true"></asp:Label>
                 </td>
                 <td>
                     <asp:DropDownList ID="comboProyecto" runat="server" AutoPostBack="True" 
                         CssClass="combo" Width="529px" DataTextField="pre_Descripcion" 
                         DataValueField="pre_Id" 
                         onselectedindexchanged="comboProyecto_SelectedIndexChanged">
                     </asp:DropDownList>
                 </td>            
             </tr>    
             <tr>
                 <td>
                     <asp:Label ID="label17" runat="server" CssClass="label" 
                         Text="Entrega por comodato"></asp:Label>
                 </td>
                 <td>
                     <asp:RadioButton ID="radioComodatoSi" runat="server" 
                          CssClass="radio" GroupName="EntregaComodato" 
                         Text="Si" 
                         />
                     &nbsp;<asp:RadioButton ID="radioComodatoNo" runat="server" 
                         CssClass="radio" GroupName="EntregaComodato" Checked="True"
                         Text="No" 
                          />                         
                 </td>
             </tr>                      
             <tr id="rowComodato" runat="server">
                <td>
                    &nbsp;
                </td>
                <td>
                    <table>
                        <tr>
                            <td>
                                <asp:Label ID="Label20" runat="server" Text="Número"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="textNumeroComodato" runat="server"></asp:TextBox>
                            </td> 
                            <td>
                                <asp:Label ID="Label21" runat="server" Text="Fecha"></asp:Label>
                            </td> 
                            <td class="style1">
                                <asp:TextBox ID="textFechaComodato" runat="server"  CssClass="texto2"></asp:TextBox>
                                <cc1:CalendarExtender ID="calendarFechaInicios" Format="dd/MM/yyyy" runat="server" Enabled="true" CssClass="calendar" TargetControlID="textFechaComodato">
                                </cc1:CalendarExtender>
                            </td>                                                                                  
                        </tr>
                    </table>
                </td>
             </tr>
             <tr>
                 <td>
                     <asp:Label ID="label18" runat="server" CssClass="label" 
                         Text="Entrega por acta de transferencia"></asp:Label>
                 </td>
                 <td>
                     <asp:RadioButton ID="radioActaSi" runat="server" 
                          CssClass="radio" GroupName="EntregaActa" 
                         Text="Si" 
                         />
                     &nbsp;<asp:RadioButton ID="radioActaNo" runat="server" 
                         Checked="True" CssClass="radio" GroupName="EntregaActa" 
                         Text="No" 
                          />                         
                 </td>
             </tr>
             <tr id="rowActa" runat="server">
                <td>
                    &nbsp;
                </td>
                <td>
                    <table>
                        <tr> 
                            <td>
                                <asp:Label ID="Label23" runat="server" Text="Fecha"></asp:Label>
                            </td> 
                            <td class="style1">
                                <asp:TextBox ID="textFechaActa" runat="server"  CssClass="texto2"></asp:TextBox>
                                <cc1:CalendarExtender ID="CalendarExtender1" Format="dd/MM/yyyy" runat="server" Enabled="true" CssClass="calendar" TargetControlID="textFechaActa">
                                </cc1:CalendarExtender>
                            </td>                                                                                  
                        </tr>
                    </table>
                </td>
             </tr>                      
             <tr>
                 <td>
                     <asp:Label ID="label19" runat="server" CssClass="label" 
                         Text="Entrega directa"></asp:Label>
                 </td>
                 <td>
                     <asp:RadioButton ID="radioDirectaSi" runat="server" 
                          CssClass="radio" GroupName="EntregaDirecta" 
                         Text="Si" 
                         />
                     &nbsp;<asp:RadioButton ID="radioDirectaNo" runat="server" 
                         Checked="True" CssClass="radio" GroupName="EntregaDirecta" 
                         Text="No" 
                          />                         
                 </td>
             </tr>  
             <tr id="rowDirecta" runat="server">
                <td>
                    &nbsp;
                </td>
                <td>
                    <table>
                        <tr> 
                            <td>
                                <asp:Label ID="Label22" runat="server" Text="Fecha"></asp:Label>
                            </td> 
                            <td class="style1">
                                <asp:TextBox ID="textDirecta" runat="server"  CssClass="texto2"></asp:TextBox>
                                <cc1:CalendarExtender ID="CalendarExtender2" Format="dd/MM/yyyy" runat="server" Enabled="true" CssClass="calendar" TargetControlID="textDirecta">
                                </cc1:CalendarExtender>
                            </td>                                                                                  
                        </tr>
                    </table>
                </td>
             </tr>            
         </table>
         </asp:Panel>        

        <asp:Panel ID="PanelDatosEquipos" runat="server" Visible="False" Width="716px">        
             <table class = "form">
             <tr>
                 <td>
                     <asp:UpdatePanel ID="UpdatePanelEquipos" runat="server">
                         <ContentTemplate>
                            <table >
                                <tr>
                                    <td>
                                        <asp:Label ID="Label10" runat="server" Text="Tipo de solicitud" 
                                            CssClass="label"></asp:Label>
                                    </td>
                                    <td>
                                         <asp:RadioButton ID="radioLocal" runat="server" 
                                             Checked="True" CssClass="radio" GroupName="TipoSolicitud" 
                                             Text="Local" AutoPostBack="True" 
                                             />
                                         &nbsp;<asp:RadioButton ID="radioNacional" runat="server" 
                                             CssClass="radio" GroupName="TipoSolicitud" 
                                             Text="Nacional" AutoPostBack="True" oncheckedchanged="radioNacional_CheckedChanged" 
                                             />
                                     </td>
                                </tr>
                            </table>                         
                             <table>
                                 <tr>
                                     <th>
                                         <asp:Label ID="label4" runat="server" CssClass="subtitulo" 
                                             Text="Seleccione equipos a asignar"></asp:Label>
                                     </th>
                                 </tr>
                                 <tr>
                                     <td>
                                         <asp:Panel ID="PanelEquipos" runat="server" Width="702px">
                                             <table class="form">
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
                                                     <td >
                                                         <asp:Label ID="labelKit" runat="server" CssClass="label" Text="Kit"></asp:Label>
                                                     </td>
                                                     <td colspan="3" >
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
                                                 </table>
                                                 <table class="form">
                                                 <tr>
                                                    <td>
                                                        <asp:Label ID="label8" runat="server" CssClass="label" Text="Sede principal"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:CheckBox ID="checkSede" runat="server" AutoPostBack="True" 
                                                            oncheckedchanged="checkSede_CheckedChanged" />
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="label5" runat="server" CssClass="label" Text="Dirección adicional"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="textDireccionAdicional" runat="server" CssClass="texto2" 
                                                             ></asp:TextBox>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label6" runat="server" Text="Teléfono" CssClass="label"></asp:Label>
                                                     </td>
                                                     <td >
                                                         <asp:TextBox ID="textTelefonoAdicional" runat="server" CssClass="texto2"></asp:TextBox>
                                                     </td>
                                                 </tr>
                                                 <tr>
                                                    <td>
                                                        <asp:Label ID="label7" runat="server" CssClass="label" Text="Departamento"></asp:Label>
                                                    </td>
                                                    <td colspan="2">
                                                        <asp:DropDownList ID="comboDepartamentoAdicional" runat="server" 
                                                            CssClass="combo" AutoPostBack="True" DataTextField="dep_Descripcion" 
                                                            DataValueField="dep_Id" 
                                                            onselectedindexchanged="comboDepartamentoAdicional_SelectedIndexChanged">
                                                        </asp:DropDownList>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="label9" runat="server" CssClass="label" Text="Ciudad"></asp:Label>
                                                    </td>
                                                    <td colspan="2">
                                                        <asp:DropDownList ID="comboCiudadAdicional" runat="server" CssClass="combo" 
                                                            DataTextField="mun_Descripcion" DataValueField="mun_Id">
                                                        </asp:DropDownList>
                                                    </td>
                                                 </tr>
                                                 <tr>                                                 
                                                     <td>
                                                         <asp:TextBox ID="textIdEquipo" runat="server" Height="21px" Visible="False" 
                                                             Width="35px" Wrap="False"></asp:TextBox>
                                                     </td>
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
                                                             AutoGenerateColumns="False" CssClass="grilla" DataKeyNames="idProvisional"
                                                             FooterStyle-CssClass="footergrilla" HeaderStyle-CssClass="headergrilla" 
                                                             onrowcommand="gridSolicitudEquipos_RowCommand" RowStyle-CssClass="rowgrilla" 
                                                             SelectedRowStyle-CssClass="selectedgrilla" Width="650px">
                                                             <RowStyle CssClass="rowgrilla" />
                                                             <Columns>
                                                                 <asp:ButtonField ButtonType="Button" CommandName="Modificar" Text="Modificar" 
                                                                     Visible="False">
                                                                     <ControlStyle CssClass="buttongrilla" />
                                                                 </asp:ButtonField>
                                                                 <asp:ButtonField ButtonType="Button" CommandName="Eliminar" Text="Eliminar">
                                                                     <ControlStyle CssClass="buttongrilla" />
                                                                 </asp:ButtonField>
                                                                 <asp:BoundField DataField="equipo" HeaderText="Kit / Equipo"></asp:BoundField>
                                                                 <asp:BoundField DataField="cantidad" HeaderText="Cantidad" />
                                                                 <asp:BoundField DataField="costo" HeaderText="Costo" />
                                                             <asp:TemplateField HeaderText="Serie">
                                                                 <ItemTemplate>
                                                                     <asp:TextBox ID="TextSerie" runat="server" Width="75px" Text='<%# Bind("Serie")  %>' MaxLength="50"
                                                                        OnTextChanged="TextSerie_TextChanged"></asp:TextBox>
                                                                 </ItemTemplate>
                                                             </asp:TemplateField>
                                                             <asp:TemplateField HeaderText="Placa">
                                                                 <ItemTemplate>
                                                                     <asp:TextBox ID="TextPlaca" runat="server" Width="75px" Text='<%# Bind("Placa")  %>' MaxLength="50"
                                                                        OnTextChanged="TextPlaca_TextChanged"></asp:TextBox>
                                                                 </ItemTemplate>
                                                             </asp:TemplateField>                                                                 
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
                                                         <asp:Label ID="labelValorTotal" runat="server" Font-Bold="True" 
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
                         </ContentTemplate>
                         <Triggers>
                             <asp:AsyncPostBackTrigger ControlID="comboLicitacion" />
                             <asp:AsyncPostBackTrigger ControlID="comboKit" />
                             <asp:AsyncPostBackTrigger ControlID="comboEquipo" />
                             <asp:AsyncPostBackTrigger ControlID="buttonAdicionar" EventName="Click" />
                             <asp:AsyncPostBackTrigger ControlID="buttonCancelarEquipos" EventName="Click" />
                             <asp:AsyncPostBackTrigger ControlID="gridSolicitudEquipos" />
                         </Triggers>
                     </asp:UpdatePanel>
                 </td>
             </tr>
             </table>
             <table style="width: 690px">
            <tr>
                        <th>   
                        <asp:Label ID="label2" runat="server" Text="Documentos" 
                                CssClass="subtitulo"></asp:Label>
                        </th>
            </tr>
            <tr>
                <td style="width:20%">
                    <uc1:DocumentosVarios ID="DocumentosVarios" runat="server" />
                </td>
             </tr>                
          </table>          
        </asp:Panel>
        <asp:Panel ID="panelBotones" runat="server" Visible = "false">            
            <table>
                <tr>
                    <td>
                        &nbsp;&nbsp;
                    <asp:Button ID="buttonGuardar" runat="server" Text="Guardar"  
                            CssClass="button" onclick="buttonGuardar_Click"/>
                    &nbsp;<asp:Button ID="buttonExportar" runat="server" CssClass="button" 
                                                                 onclick="buttonExportar_Click" 
                            Text="Exportar" />
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


