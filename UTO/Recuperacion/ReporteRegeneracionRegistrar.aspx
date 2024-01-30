<%@ Page Language="C#" MasterPageFile="~/MPMain.Master"  AutoEventWireup="true" CodeBehind="ReporteRegeneracionRegistrar.aspx.cs" Inherits="UTO.Recuperacion.ReporteRegeneracionRegistrar" %>

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
                Text="Proyectos de dotación de equipos y herramientas  para el sector de refrigeración y aire acondicionado - Reporte recuperación" 
                CssClass="subtitulo"></asp:Label>
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
        <asp:Panel ID="PanelDatosTercero" runat="server" Width="716px">
             <table>
             <tr>
                 <td>
                     <table style="width: 688px">
                         <tr>
                             <td class="style3">
                                 <asp:Label ID="labelNombreCentro" runat="server" CssClass="label" 
                                     Text="Centro regeneración"></asp:Label>
                             </td>
                             <td colspan="5">
                                 <asp:DropDownList ID="comboCentroRegeneracion" runat="server" CssClass="combo" 
                                     DataTextField="cre_Descripcion" DataValueField="cre_Id">
                                 </asp:DropDownList>
                             </td>
                         </tr>
                         </table>
                         <table>
                         <tr>
                             <td colspan="6">
                                 <asp:UpdatePanel ID="UpdatePanelTercero" runat="server">
                                 <ContentTemplate>
                                    <asp:Panel ID="PanelBuscarTercero" runat="server" Width="671px">
                                     <table>
                                         <tr>
                                             <th colspan="5">
                                                 <asp:Label ID="labelparametros" runat="server" CssClass="subtitulo" 
                                                     Text="Buscar usuario"></asp:Label>
                                             </th>
                                         </tr>
                                         <tr>
                                             <td>
                                                 <asp:Label ID="labelNombreBeneficiario" runat="server" CssClass="label" 
                                                     Text="Nombre usuario"></asp:Label>
                                             </td>
                                             <td colspan="4">
                                                 <asp:TextBox ID="textNombreBeneficiarioBuscar" runat="server" CssClass="texto2" 
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
                                                     onclick="buttonBuscarTercero_Click" Text="Buscar" />
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
                                 </ContentTemplate>
                                     <Triggers>
                                         <asp:AsyncPostBackTrigger ControlID="buttonBuscarTercero" EventName="Click" />
                                         <asp:AsyncPostBackTrigger ControlID="GridViewTerceroBuscar" />
                                     </Triggers>
                                 </asp:UpdatePanel>                                 
                             </td>
                         </tr>
                         </table>
                         <asp:UpdatePanel ID="UpdatePanelReporte" runat="server">
                         <ContentTemplate>
                         <table>
                         <tr>
                                 <th colspan="6">
                                     <asp:Label ID="label1" runat="server" CssClass="subtitulo" 
                                         Text="Datos guardar aptos para regenerar"></asp:Label>
                                 </th>
                         </tr>
                             <tr>
                                 <td>
                                     <asp:Label ID="labelBeneficiario" runat="server" CssClass="label" 
                                         Text="Usuario"></asp:Label>&nbsp
                                     <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>   
                                 </td>
                                 <td colspan="5">
                                     <asp:TextBox ID="textBeneficiario" runat="server" CssClass="texto2" 
                                         Enabled="False" Width="577px"></asp:TextBox>
                                 </td>
                             </tr>
                         <tr>
                             <td>
                                 <asp:Label ID="labelTipoGas" runat="server" CssClass="label" Text="Sustancia"></asp:Label>&nbsp
                                 <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>
                             </td>
                             <td>
                                 <asp:DropDownList ID="comboTipoGas" runat="server" CssClass="combo" 
                                     Width="106px" DataTextField="gti_Descripcion" DataValueField="gti_Id">
                                 </asp:DropDownList>
                             </td>
                             <td>
                                 <asp:Label ID="labelFecha" runat="server" CssClass="label" Text="Fecha"></asp:Label>
                             </td>
                             <td colspan="3">
                                 <asp:TextBox ID="textFecha" runat="server" CssClass="texto2"></asp:TextBox>
                                 <cc1:CalendarExtender ID="CalendarExtender1" runat="server" CssClass="calendar" 
                                     Format="dd/MM/yyyy" TargetControlID="textFecha">
                                 </cc1:CalendarExtender>
                             </td>
                         </tr>
                             <tr>
                                 <td>
                                     <asp:Label ID="labelCantidadEntregadaKg" runat="server" CssClass="label" 
                                         Text="Cantidad recibida (kg)"></asp:Label>&nbsp
                                     <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>   
                                 </td>
                                 <td>
                                     <asp:TextBox ID="textUsoCantidadEntregada" runat="server" AutoPostBack="True" 
                                         CssClass="texto2" ontextchanged="textUsoCantidadEntregada_TextChanged" 
                                         Width="65px"></asp:TextBox>
                                 </td>
                                 <td>
                                     <asp:Label ID="labelCantidadEntregada" runat="server" CssClass="label" 
                                         Text="Cantidad recibida (lb)"></asp:Label>
                                 </td>
                                 <td colspan="3">
                                     <asp:TextBox ID="textUsoCantidadEntregadaKg" runat="server" CssClass="texto2" 
                                         Enabled="False" Width="103px"></asp:TextBox>
                                 </td>
                             </tr>
                         <tr>
                             <td>
                                 <asp:Label ID="labelCantidadRegeneradaKg" runat="server" CssClass="label" 
                                     Text="Cantidad regenerada (kg)"></asp:Label>&nbsp
                                 <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>   
                             </td>
                             <td>
                                 <asp:TextBox ID="textUsoCantidadRegenerada" runat="server" CssClass="texto2" 
                                     Width="64px" AutoPostBack="True" 
                                     ontextchanged="textUsoCantidadRegenerada_TextChanged"></asp:TextBox>
                             </td>
                             <td>
                                 <asp:Label ID="labelCantidadRegenerada" runat="server" CssClass="label" 
                                     Text="Cantidad regenerada (lb)"></asp:Label>
                             </td>
                             <td colspan="3">
                                 <asp:TextBox ID="textUsoCantidadRegeneradaKg" runat="server" CssClass="texto2" 
                                     Enabled="False" Width="103px"></asp:TextBox>
                             </td>
                         </tr>
                         <tr>
                             <td>
                                 <asp:Label ID="labelCantidadRechazadaKg" runat="server" CssClass="label" 
                                     Text="Cantidad rechazada (kg)" Visible="False"></asp:Label>
                                 <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>   
                             </td>
                             <td>
                                 <asp:TextBox ID="textUsoCantidadRechazada" runat="server" CssClass="texto2" 
                                     Width="64px" AutoPostBack="True" Enabled="False" Visible="False"></asp:TextBox>
                             </td>
                             <td>
                                 <asp:Label ID="labelCantidadRechazada" runat="server" CssClass="label" 
                                     Text="Cantidad rechazada (lb)" Visible="False"></asp:Label>
                             </td>
                             <td colspan="3">
                                 <asp:TextBox ID="textUsoCantidadRechazadaKg" runat="server" CssClass="texto2" 
                                     Enabled="False" Width="103px" Visible="False"></asp:TextBox>
                             </td>
                         </tr>
                         <tr>
                             <td>
                                 <asp:Label ID="labelDestino" runat="server" CssClass="label" 
                                     Text="Destino del gas regenerado"></asp:Label>&nbsp
                                 <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>   
                             </td>
                             <td>
                                 <asp:DropDownList ID="comboDestino" runat="server" AutoPostBack="True" 
                                     CssClass="combo" DataTextField="gde_Descripcion" 
                                     DataValueField="gde_Id" 
                                     onselectedindexchanged="comboDestino_SelectedIndexChanged" Width="195px">
                                 </asp:DropDownList>
                             </td>
                             <td>
                                 <asp:Label ID="labelCantidad" runat="server" CssClass="label" Text="Cantidad" 
                                     Visible="False"></asp:Label>
                             </td>
                             <td>
                                 <asp:TextBox ID="textCantidad" runat="server" CssClass="texto2" Visible="False" 
                                     Width="103px" AutoPostBack="True" ontextchanged="textCantidad_TextChanged"></asp:TextBox>
                             </td>
                             <td class="style2">
                                 <asp:Label ID="labelPorciento" runat="server" CssClass="label" Text="Porciento" 
                                     Visible="False"></asp:Label>
                             </td>
                             <td>
                                 <asp:TextBox ID="textPorciento" runat="server" CssClass="texto2" 
                                     Enabled="False" Visible="False" Width="64px"></asp:TextBox>
                             </td>
                         </tr>
                     </table>
                     <table>
                        <tr>
                            <td>
                                <asp:Label ID="label4" runat="server" CssClass="label" Text="Observaciones" 
                                     Visible="False"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>    
                                 <asp:TextBox ID="textObservaciones" runat="server" CssClass="texto2" 
                                     Height="55px" TextMode="MultiLine" Width="579px"></asp:TextBox>                                
                            </td>
                        </tr>
                     </table>
                         </ContentTemplate>
                             <Triggers>
                                 <asp:AsyncPostBackTrigger ControlID="textUsoCantidadEntregada" 
                                     EventName="TextChanged" />
                                 <asp:AsyncPostBackTrigger ControlID="textUsoCantidadRechazada" 
                                     EventName="TextChanged" />
                                 <asp:AsyncPostBackTrigger ControlID="textUsoCantidadRegenerada" 
                                     EventName="TextChanged" />
                                 <asp:AsyncPostBackTrigger ControlID="comboDestino" />
                                 <asp:AsyncPostBackTrigger ControlID="textCantidad" EventName="TextChanged" />
                             </Triggers>
                         </asp:UpdatePanel>
                     
                 </td>
             </tr>
          </table>    
          <table>
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
      </td>
    </tr>
    </table>
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
    </td>
    </tr>
    </table>
    </div>
    <br />
    <br />
    </asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="head">

    <style type="text/css">
        .style1
        {
            width: 131px;
        }
        .style2
        {
            width: 60px;
        }
        .style3
        {
            width: 130px;
        }
        </style>

</asp:Content>

