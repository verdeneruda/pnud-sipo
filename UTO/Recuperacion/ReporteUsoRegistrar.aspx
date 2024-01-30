<%@ Page Language="C#" MasterPageFile="~/MPMain.Master"  AutoEventWireup="true" CodeBehind="ReporteUsoRegistrar.aspx.cs" Inherits="UTO.Recuperacion.ReporteUsoRegistrar" %>

    <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

    <%@ Register src="~/Comunes/DocumentosVarios.ascx" tagname="DocumentosVarios" tagprefix="uc1" %>

    <%@ Register src="../Comunes/ControlError.ascx" tagname="ControlError" tagprefix="uc2" %>

    <asp:Content  ID="contentSolicitudEquiposBuscar" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
        <link rel="stylesheet" href="//code.jquery.com/ui/1.11.3/themes/smoothness/jquery-ui.css">
    <script src="//code.jquery.com/jquery-1.10.2.js"></script>
    <script src="//code.jquery.com/ui/1.11.3/jquery-ui.js"></script>
<%--    <script>
        $(document).ready(function () {
            var cantidadLb = '#' + '<%= textLb.ClientID %>';
            var cantidadKg = '#' + '<%= textKg.ClientID %>';

            $(cantidadLb).blur(function () {
                var pattern = /^([0-9])*[.,]?[0-9]*$/;
                var count = $(cantidadLb).val().length;
                if (!pattern.test($(cantidadLb).val())) {
                    alert("El valor ingresado no es un número válido");
                    $(cantidadLb).focus();
                }
                else {
                    $(cantidadKg).val(parseFloat($(cantidadLb).val()) / parseFloat(0.45359237));
                }                
            });
        });

    </script>--%>
       
        <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </cc1:ToolkitScriptManager>
    <div class="divwithoutgrid">
    <table class="titulo" >
        <tr><td>
        <asp:Label ID="labelBusquedaSolicitudesEquipos" runat="server" 
                Text="Proyectos de dotación de equipos y herramientas  para el sector de refrigeración y aire acondicionado - Recuperación, reciclaje y regeneración de gases refrigerantes - Reporte de uso" 
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
    <td>
        <table style="width:100%">
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
                            AllowPaging="True" PageSize="15">
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
                <asp:Label ID="label1" runat="server" Text="Datos tercero" 
                        CssClass="subtitulo"></asp:Label>
                </th>
            </tr>
            <tr>
                <td width="160px">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>                
                    <asp:Label ID="labelComodato" runat="server" CssClass="label" Text="Comodato"></asp:Label>
                </td>
                <td>                
                    <asp:TextBox ID="textComodato" runat="server" CssClass="texto2" Enabled="False" 
                        Width="150px"></asp:TextBox>
                </td>
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
                     <asp:Label ID="labelPeriodo" runat="server" CssClass="label" Text="Periodo"></asp:Label>&nbsp
                     <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>
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
             <tr>
                <th>   
                <asp:Label ID="label4" runat="server" Text="Reporte de Uso" 
                        CssClass="subtitulo"></asp:Label>
                </th>
            </tr>
             <tr>
                 <td>
                     <table class="formColapsableSinMargen">
                         <tr>
                             <td class="tdCollap"  Height="16px">
                                 <!-- panel colapsable de compras uno-->
                                <asp:LinkButton ID="linkDatosReporteUso" runat="server" CssClass="lnbCollap" > <div>
                                     
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <div style="float:left">Reporte de uso</div><div style="float: right; vertical-align: middle;">
                                
                                     
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                
                                <asp:ImageButton ID="imageReporteUso" runat="server" 
                                        ImageUrl="~/images/fl_abajo.jpg" AlternateText="Mostrar detalles" />

                                

                                     

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                                

                                </div>
                                     
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                </div></asp:LinkButton>
                             </td>
                         </tr>
                         <tr>
                             <td>
                                 <asp:UpdatePanel ID="UpdatePanelReporteUso" runat="server">
                                 <ContentTemplate>
                                 <asp:Panel ID="panelReporteUso" runat="server" Height="306px" >
                                 <table>
                                 <tr>
                                      <td colspan="6">
                                      
                                          <uc2:ControlError ID="ControlError1" runat="server" />
                                      
                                      </td>
                                 </tr>
                                     <tr>
                                         <td>
                                             <asp:Label ID="labelTipoGas" runat="server" CssClass="label" Text="Sustancia"></asp:Label>&nbsp
                                             <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>
                                         </td>
                                         <td>
                                             <asp:DropDownList ID="comboTipoGas" runat="server" CssClass="combo" 
                                                 DataTextField="gti_Descripcion" DataValueField="gti_Id" >
                                             </asp:DropDownList>
                                         </td>
                                         <td>
                                             <asp:Label ID="labelUso" runat="server" CssClass="label" Text="Uso"></asp:Label>&nbsp
                                             <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>
                                         </td>
                                         <td colspan="3">
                                             <asp:DropDownList ID="comboUso" runat="server" AutoPostBack="True" 
                                                 CssClass="combo" DataTextField="gus_Descripcion" DataValueField="gus_Id" 
                                                 onselectedindexchanged="comboUso_SelectedIndexChanged" Width="212px">
                                             </asp:DropDownList>
                                         </td>
                                     </tr>
                                     <tr>
                                         <td>
                                             <asp:Label ID="labelKg0" runat="server" CssClass="label" Text="Kg"></asp:Label>&nbsp
                                             <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>
                                         </td>
                                         <td>
                                             <asp:TextBox ID="textLb" runat="server" CssClass="texto2" Width="87px" AutoPostBack="True" OnTextChanged="textLb_TextChanged1" ></asp:TextBox>
                                         </td>
                                         <td>
                                             <asp:Label ID="labelLibras0" runat="server" CssClass="label" Text="Lb"></asp:Label>
                                         </td>
                                         <td>
                                             <asp:TextBox ID="textKg" runat="server" CssClass="texto2" Enabled="False" 
                                                 Width="87px"></asp:TextBox>
                                         </td>
                                         <td>
                                             <asp:Label ID="labelPresentacion" runat="server" CssClass="label" 
                                                 Text="Presentación" Visible="False"></asp:Label>&nbsp
                                             <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>
                                         </td>
                                         <td>
                                             <asp:DropDownList ID="comboPresentacion" runat="server" CssClass="combo" DataTextField="psu_Descripcion" 
                                                 DataValueField="psu_Id" Visible="False" Width="211px">
                                             </asp:DropDownList>
                                         </td>
                                     </tr>
                                     <tr>
                                         <td>
                                             &nbsp;</td>
                                         <td>
                                             <asp:TextBox ID="textIdReporte" runat="server" 
                                                 CssClass="texto2" Visible="False" 
                                                 Width="87px"></asp:TextBox>
                                         </td>
                                         <td>
                                             &nbsp;</td>
                                         <td>
                                             &nbsp;</td>
                                         <td>
                                             <asp:Label ID="labelEstado" runat="server" CssClass="label" Text="Estado" 
                                                 Visible="False"></asp:Label>
                                         </td>
                                         <td>
                                             <asp:DropDownList ID="comboeEstado" runat="server" CssClass="combo" 
                                                 Visible="False" Width="211px">
                                             </asp:DropDownList>
                                         </td>
                                     </tr>
                                     <tr>
                                         <td colspan="6">
                                             <asp:Button ID="buttonAdicionar" runat="server" CssClass="button" 
                                                 onclick="buttonAdicionar_Click" Text="Adicionar" />
                                             &nbsp;</td>
                                     </tr>
                                     <tr>
                                         <td colspan="6">
                                             <div class="divgrillassinmargin">
                                                 <asp:GridView ID="gridReporteUso" runat="server" AutoGenerateColumns="False" FooterStyle-CssClass="footergrilla" 
                                                     HeaderStyle-CssClass="headergrilla" RowStyle-CssClass="rowgrilla" 
                                                     Width="640px" DataKeyNames="idProvisional,id" 
                                                     onrowcommand="gridReporteUso_RowCommand">
                                                     <RowStyle CssClass="rowgrilla" />
                                                     <Columns>
                                                         <asp:ButtonField ButtonType="Button" CommandName="Modificar" Text="Modificar">
                                                             <ControlStyle CssClass="buttongrilla" />
                                                         </asp:ButtonField>
                                                         <asp:ButtonField ButtonType="Button" CommandName="Eliminar" Text="Eliminar">
                                                             <ControlStyle CssClass="buttongrilla" />
                                                         </asp:ButtonField>
                                                         <%--<asp:BoundField DataField="mes" HeaderText="Año" />--%>
                                                         <asp:BoundField DataField="tipoGas" HeaderText="Tipo gas" />
                                                         <asp:BoundField DataField="uso" HeaderText="Uso" />
                                                         <asp:BoundField DataField="libra" HeaderText="Lb" />
                                                         <asp:BoundField DataField="kilo" HeaderText="Kg" />
                                                         <%--<asp:BoundField DataField="presentacion" HeaderText="Presentación" />--%>
                                                         <asp:BoundField DataField="id" HeaderText="Id" />
                                                         <asp:BoundField DataField="idProvisional" HeaderText="IdProvisional" />
                                                     </Columns>
                                                     <FooterStyle CssClass="footergrilla" />
                                                     <HeaderStyle CssClass="headergrilla" />
                                                 </asp:GridView>
                                             </div>
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
          <asp:UpdatePanel ID="UpdatePanelCentro" runat="server">
          <ContentTemplate>          
          <table>
            <tr>
                <td>            
                    <asp:CheckBox ID="CheckEnvioRegenerar" runat="server" AutoPostBack="True" 
                        oncheckedchanged="CheckEnvioRegenerar_CheckedChanged" 
                        Text="Se envía a Centro de Regeneración" />            
                </td>
                <td>
                    <asp:Label ID="labelCentroRegeneracion" runat="server" CssClass="label" 
                        Text="Centro de regeneración" Visible="False"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="comboCentroRegeneracion" runat="server" CssClass="combo" DataTextField="cre_Descripcion" 
                        DataValueField="cre_Id" Visible="False" Width="106px">
                    </asp:DropDownList>
                </td>
            </tr>
              <tr>
                  <td colspan="3">
                      <asp:CheckBox ID="CheckManejoEquipos" runat="server" AutoPostBack="True" 
                          oncheckedchanged="CheckManejoEquipos_CheckedChanged" 
                          Text="Reporta algún problema o novedad con el manejo de los equipos" />
                  </td>
              </tr>
              <tr>
                  <td colspan="3">
                      <asp:TextBox ID="textProblemaEquipos" runat="server" CssClass="texto2" 
                          Height="50px" 
                          TextMode="MultiLine" Visible="False" Width="654px"></asp:TextBox>
                  </td>
              </tr>
              <tr>
                  <td colspan="3">
                      <asp:CheckBox ID="CheckSolucion" runat="server" AutoPostBack="True"                           
                          Text="Acción tomada" Visible="False" 
                          oncheckedchanged="CheckSolucion_CheckedChanged"/>
                  </td>
              </tr>
              <tr>
                  <td colspan="3">
                      <asp:TextBox ID="textAccionTomada" runat="server" CssClass="texto2" 
                          Height="50px" 
                          TextMode="MultiLine" Visible="False" Width="654px"></asp:TextBox>
                  </td>
              </tr>              
            </table>
          </ContentTemplate>
              <Triggers>
                  <asp:AsyncPostBackTrigger ControlID="CheckEnvioRegenerar" 
                      EventName="CheckedChanged" />
                  <asp:AsyncPostBackTrigger ControlID="CheckManejoEquipos" 
                      EventName="CheckedChanged" />
              </Triggers>
          </asp:UpdatePanel>
          <table>
              <tr>
                  <th>
                      <asp:Label ID="label2" runat="server" CssClass="subtitulo" Text="Documentos"></asp:Label>
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
                    <asp:Button ID="buttonExportar" runat="server" CssClass="button" 
                                                 Text="Exportar" onclick="buttonExportar_Click" />
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
        </style>

</asp:Content>--%>