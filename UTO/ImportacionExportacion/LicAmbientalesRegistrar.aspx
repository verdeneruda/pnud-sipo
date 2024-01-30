    <%@ Page Language="C#" MasterPageFile="~/MPMain.Master" AutoEventWireup="true" CodeBehind="LicAmbientalesRegistrar.aspx.cs" Inherits="UTO.ImportacionExportacion.LicAmbientalesRegistrar" %>

    <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
    <%@ Register src="../Comunes/ControlError.ascx" tagname="ControlError" tagprefix="uc1" %>
    <%@ Register src="../Comunes/ControlError.ascx" tagname="controlerror" tagprefix="uc2" %>
    <asp:Content ID="contentImportacionExportacionLicAmbientalesRegistrarHead" ContentPlaceHolderID="head" Runat="Server">
        </asp:Content>
    <asp:Content  ID="contentImportacionExportacionLicAmbientalesRegistrar" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
    <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </cc1:ToolkitScriptManager>
    <div class="divwithoutgrid">
    <table class="titulo" >
    <tr><td>
    <asp:Label ID="labelRegistarLicenciasAmbientales" runat="server" Text="Mòdulo importación y exportación - Adicionar licencias medio ambientales" CssClass="subtitulo"></asp:Label>
    </td></tr>
    </table>
    <br />
    <table class="form">
    <tr>
    <td>
    
        <uc1:ControlError ID="ControlError1" runat="server" />
    
    </td>
    </tr>    
    </table>
    <table class="form">
    <tr>
    <td>
    <asp:Panel ID="PanelLicencia" runat="server">    
        <table style="width:100%;"> 
        <tr><th colspan="6">
        <asp:Label ID="labelDatosGenerales" runat="server" Text="Datos generales" CssClass="subtitulo"></asp:Label>
        </th></tr>
        <tr>
        <td>
        <asp:Label ID="labelEmpresa" runat="server" Text="Empresa" CssClass="label"></asp:Label>&nbsp
        <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>
        </td>
        <td colspan="5">
        <asp:DropDownList ID="comboEmpresa" runat="server" CssClass="combo" 
                DataTextField="ter_NombreCompleto" DataValueField="ter_Id" 
                Width="491px">
        </asp:DropDownList>
        &nbsp;
            <asp:Button ID="buttonAdicionarTercero" runat="server" CssClass="button" 
                onclick="buttonAdicionarTercero_Click" Text="Adicionar" />
            </td>
        </tr>
            <tr>
                <td colspan="6">
                    <asp:Panel ID="PanelDatosTercero" runat="server" Visible="False" Width="716px">
                        <table class="form">
                            <tr>
                                <td>
                                    <uc2:ControlError ID="ControlError2" runat="server" />
                                </td>
                            </tr>
                        </table>
                        <table class="formModal">
                            <tr>
                                <th colspan="4">
                                    <asp:Label ID="label1" runat="server" CssClass="subtitulo" 
                                        Text="Datos empresa"></asp:Label>
                                </th>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="labelNombreBeneficiario0" runat="server" CssClass="label" 
                                        Text="Nombre"></asp:Label>&nbsp
                                    <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>   
                                </td>
                                <td colspan="3">
                                    <asp:TextBox ID="textNombreBeneficiario" runat="server" CssClass="texto2" 
                                        Width="528px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="labelDepartamento" runat="server" CssClass="label" 
                                        Text="Departamento"></asp:Label>&nbsp
                                    <asp:Label ID="Label2" runat="server" Text="(*)" Font-Bold="true"></asp:Label>  
                                </td>
                                <td>
                                    <asp:DropDownList ID="comboDepartamento" runat="server" AutoPostBack="True" 
                                        CssClass="combo" DataTextField="dep_Descripcion" DataValueField="dep_Id" onselectedindexchanged="comboDepartamento_SelectedIndexChanged" 
                                        Width="198px">
                                    </asp:DropDownList>
                                </td>
                                <td>
                                    <asp:Label ID="labelMunicipio" runat="server" CssClass="label" Text="Municipio"></asp:Label>&nbsp
                                    <asp:Label ID="Label3" runat="server" Text="(*)" Font-Bold="true"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="comboCiudad" runat="server" CssClass="combo" 
                                        DataTextField="mun_Descripcion" DataValueField="mun_Id" 
                                        Width="200px">
                                    </asp:DropDownList>
                                </td>
                            </tr>                            
                            <tr>
                                <td>
                                    <asp:Label ID="labelTipoDocumento" runat="server" CssClass="label" 
                                        Text="Tipo documento"></asp:Label>&nbsp                                    
                                </td>
                                <td>
                                    <asp:DropDownList ID="comboTipoDocumento" runat="server" CssClass="combo" 
                                        DataTextField="dti_Descripcion" DataValueField="dti_Id" Width="200px" 
                                        onselectedindexchanged="comboTipoDocumento_SelectedIndexChanged">
                                    </asp:DropDownList>
                                </td>
                                <td>
                                    <asp:Label ID="labelDocumento" runat="server" CssClass="label" Text="Documento"></asp:Label>&nbsp                                    
                                </td>
                                <td>
                                    <asp:TextBox ID="textDocumento" runat="server" AutoCompleteType="Disabled" 
                                        CssClass="texto2" Width="198px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="4">
                                    <asp:Button ID="buttonGuardarTercero" runat="server" CssClass="button" 
                                        onclick="buttonGuardarTercero_Click" Text="Guardar" />
                                    &nbsp;<asp:Button ID="buttonCancelarTercero" runat="server" CssClass="button" 
                                        onclick="buttonCancelarTercero_Click" Text="Cancelar" />
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
            </tr>
        <tr>
        <td>
                             <asp:Label ID="labelResolucion" runat="server" CssClass="label" 
                                 Text="Resolución"></asp:Label>&nbsp
                            <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>   
        </td>
        <td colspan="3">
                             <asp:TextBox ID="textResolucion" runat="server" CssClass="texto2" Width="100px"></asp:TextBox>
            </td>

        <td>
                       <asp:Label ID="labelfecha" runat="server" CssClass="label" 
                        Text="Fecha"></asp:Label>&nbsp
                        <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>
        </td>
        <td>
                       <asp:TextBox ID="textFecha" runat="server" CssClass="texto2" 
                           Width="118px"></asp:TextBox>
                       <cc1:CalendarExtender ID="calendarFecha" runat="server" CssClass="calendar" 
                           Format="dd/MM/yyyy" TargetControlID="textFecha">
                       </cc1:CalendarExtender>
        </td>
        </tr>
        <tr>
        <td>
                        <asp:Label ID="labelObservaciones" runat="server" CssClass="label" 
                            Text="Observaciones"></asp:Label>
        </td>
        <td colspan="5">
                        <asp:TextBox ID="textObservaciones" runat="server" CssClass="texto2" 
                            Height="55px" TextMode="MultiLine" Width="579px"></asp:TextBox>
            </td>
        </tr>
        <tr>
        <th colspan="6">
            <asp:Label ID="label4" runat="server" Text="Registro licencia" 
                    CssClass="subtitulo"></asp:Label>    
        </th>                   
        </tr>
        <tr>
        <td colspan="6">
          <asp:Panel ID="PanelSustancias" runat="server">
          <table>         
             <tr>
                 <td>
                     <table class="formColapsableSinMargen">
                         <tr>
                             <td class="tdCollap">
                                 <!-- panel colapsable de compras uno-->
                                <asp:LinkButton ID="linkImportacionSustancias" runat="server" CssClass="lnbCollap" > <div>
                                <div style="float:left">Registro licencia</div>
                                <div style="float: right; vertical-align: middle;">
                                <asp:ImageButton ID="imageImportacionSustancia" runat="server" 
                                        ImageUrl="~/images/fl_abajo.jpg" AlternateText="Mostrar detalles" />

                                </div>
                                </div></asp:LinkButton>
                             </td>
                         </tr>
                         <tr>
                             <td>
                                 <asp:Panel ID="panelImportacionSustancias" runat="server" Height="101px">
                                 <table >
                                      <tr>   
                                          <td>                      
                                              <asp:Label ID="labelProveedor" runat="server" CssClass="label" Text="Proveedor"></asp:Label>&nbsp
                                              <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>
                                         </td>
                                         <td>
                                             <asp:DropDownList ID="comboProveedor" runat="server" CssClass="combo" 
                                                 DataTextField="ter_NombreCompleto" DataValueField="ter_Id" Width="380px">
                                             </asp:DropDownList>
                                         </td>
                                         <td>
                                             <asp:Label ID="label11" runat="server" CssClass="label" Text="País"></asp:Label>&nbsp
                                             <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>
                                         </td>
                                         <td>
                                             <asp:DropDownList ID="comboPais" runat="server" CssClass="combo" 
                                                 DataTextField="pas_Descripcion" DataValueField="pas_Id" 
                                                 Width="166px">
                                             </asp:DropDownList>
                                         </td>
                                    </tr>
                                     <tr>
                                         <td>
                                             <asp:Label ID="labelSustancia" runat="server" CssClass="label" Text="Sustancia"></asp:Label>&nbsp
                                             <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>
                                         </td>
                                         <td colspan="3">
                                            <asp:DropDownList ID="comboSustancia" runat="server" CssClass="combo" 
                                                DataTextField="sus_Descripcion" DataValueField="sus_Id" Width="148px">
                                            </asp:DropDownList>
                                         </td>

                                     </tr>
                                     <tr>
                                         <td class="style3" colspan="4">
                                             &nbsp;<asp:Button ID="buttonAdicionar" runat="server" CssClass="button" 
                                                 onclick="buttonAdicionar_Click2" Text="Adicionar" />
                                             &nbsp;</td>
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
           <table>
           <tr>
           <td>
               <div class="divgrillassinmargin">
                   <asp:GridView ID="gridImportacionSustancia" runat="server" 
                       AutoGenerateColumns="False" FooterStyle-CssClass="footergrilla" 
                       HeaderStyle-CssClass="headergrilla" RowStyle-CssClass="rowgrilla" 
                       Width="672px" DataKeyNames="idProvisional" 
                       onrowcommand="gridImportacionSustancia_RowCommand">
                       <RowStyle CssClass="rowgrilla" />
                       <Columns>
                           <asp:ButtonField ButtonType="Button" CommandName="Eliminar" Text="Eliminar">
                               <ControlStyle CssClass="buttongrilla" />
                           </asp:ButtonField>
                           <asp:BoundField DataField="proveedor" HeaderText="Proveedor" />
                           <asp:BoundField DataField="pais" HeaderText="País" />
                           <asp:BoundField DataField="sustancia" HeaderText="Sustancia" 
                               SortExpression="sustancia" />
                           <asp:BoundField DataField="Id" HeaderText="Id" Visible="False" />
                           <asp:BoundField DataField="idProvisional" HeaderText="idProvisional" 
                               Visible="False" />
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
    </asp:Panel>
    <table>
    <tr>
    <td>
        &nbsp;</td>
    <td>
        &nbsp;</td>
    </tr>
    <tr>
    <td colspan="2">
    &nbsp;&nbsp;&nbsp;<asp:Button ID="buttonGuardar" runat="server" Text="Guardar" 
            CssClass="button" onclick="buttonGuardar_Click" />&nbsp;&nbsp;<asp:Button 
    ID="buttonCancelar" runat="server" Text="Cancelar"  CssClass="button" 
    onclick="buttonCancelar_Click1"/>
    </td>
    </tr>
    </table>
    </td>
    </tr>
    </table>
    </div>
    <br />
    </asp:Content>
