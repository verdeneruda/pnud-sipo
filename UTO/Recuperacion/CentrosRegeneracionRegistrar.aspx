<%@ Page Language="C#" MasterPageFile="~/MPMain.Master" AutoEventWireup="true" CodeBehind="CentrosRegeneracionRegistrar.aspx.cs" Inherits="UTO.Recuperacion.CentrosRegeneracionRegistrar" %>

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
                        Text="Proyectos de dotación de equipos y herramientas  para el sector de refrigeración y aire acondicionado - Centros de regeneración - Reportes centros de regeneración" 
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
                <td>
                    <table style="width:100%">
                        <tr>
                             <td class="style4" >
                                 <asp:Label ID="labelNombreCentro" runat="server" CssClass="label" 
                                     Text="Centro regeneración"></asp:Label>&nbsp
                                 <asp:Label ID="Label1" runat="server" Text="(*)" Font-Bold="true"></asp:Label>     
                             </td>
                             <td colspan="3">
                                 <asp:DropDownList ID="comboCentroRegeneracion" runat="server" CssClass="combo" 
                                     DataTextField="cre_Descripcion" DataValueField="cre_Id">
                                 </asp:DropDownList>
                             </td>
                        </tr>
                         <tr>
                             <td>
                                 <asp:Label ID="labelPeriodo" runat="server" CssClass="label" Text="Periodo"></asp:Label>&nbsp
                                 <asp:Label ID="Label2" runat="server" Text="(*)" Font-Bold="true"></asp:Label>
                             </td>
                             <td>
                                 <asp:DropDownList ID="comboPeriodo" runat="server" CssClass="combo">
                                 </asp:DropDownList>
                             </td>
                             <td>
                                 <asp:Label ID="labelAno" runat="server" CssClass="label" Text="Año"></asp:Label>
                                                                  &nbsp
                                 <asp:Label ID="Label11" runat="server" Text="(*)" Font-Bold="true"></asp:Label>
                             </td>
                             <td>
                                 <asp:DropDownList ID="comboAno" runat="server" CssClass="combo" Width="94px" 
                                     DataTextField="anos" DataValueField="anos">
                                 </asp:DropDownList>
                             </td>
                         </tr>                                                                            
                    </table>
                </td>
            </tr>
    </table>
                    <table class="form">
                         <tr>
                                 <th colspan="6">
                                     <asp:Label ID="label4" runat="server" CssClass="subtitulo" 
                                         Text="Cantidad de gas refrigerante recibido"></asp:Label>
                                 </th>
                         </tr>                       
                             <tr>
                                 <td>
                                     <asp:Label ID="labelBeneficiario" runat="server" CssClass="label" 
                                         Text="Cliente / Empresa"></asp:Label>&nbsp
                                     <asp:Label ID="Label5" runat="server" Text="(*)" Font-Bold="true"></asp:Label>   
                                 </td>
                                 <td colspan="5">
                                     <asp:TextBox ID="textBeneficiario" runat="server" CssClass="texto2" 
                                          Width="577px"></asp:TextBox>
                                 </td>
                             </tr>                                 
                         <tr>
                             <td>
                                 <asp:Label ID="labelTipoGas" runat="server" CssClass="label" Text="Sustancia"></asp:Label>&nbsp
                                 <asp:Label ID="Label6" runat="server" Text="(*)" Font-Bold="true"></asp:Label>
                             </td>
                             <td>
                                 <asp:DropDownList ID="comboTipoGas" runat="server" CssClass="combo" 
                                     Width="106px" DataTextField="gti_Descripcion" DataValueField="gti_Id">
                                 </asp:DropDownList>
                             </td>
                             <td>
                                 <asp:Label ID="labelFecha" runat="server" CssClass="label" Text="Fecha"></asp:Label>
                                 &nbsp
                                 <asp:Label ID="Label9" runat="server" Text="(*)" Font-Bold="true"></asp:Label>
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
                                 <asp:Label ID="labelDestino" runat="server" CssClass="label" 
                                     Text="Destino"></asp:Label>&nbsp
                                 <asp:Label ID="Label10" runat="server" Text="(*)" Font-Bold="true"></asp:Label>   
                             </td>
                             <td>
                                 <asp:DropDownList ID="comboDestino" runat="server" 
                                     CssClass="combo" DataTextField="gde_Descripcion" 
                                     DataValueField="gde_Id" 
                                      Width="195px">
                                 </asp:DropDownList>
                             </td>
                             <td>
                                 <asp:Label ID="labelCantidad" runat="server" CssClass="label" Text="Cantidad" 
                                     ></asp:Label>&nbsp
                                     <asp:Label ID="Label7" runat="server" Text="(*)" Font-Bold="true"></asp:Label></td><td>
                                 <asp:TextBox ID="textCantidad" runat="server" CssClass="texto2"  
                                     Width="103px"  ></asp:TextBox>
                                     </td>
                              </tr>
                              <tr>
                                <td colspan="6">    
                                    <asp:Button ID="buttonAgregar" runat="server" Text="Agregar" CssClass="button" 
                                        onclick="buttonAgregar_Click" />
                                    &nbsp
                                    <asp:Button ID="buttonCancelarDetalle" runat="server" Text="Cancelar" 
                                        CssClass="button" onclick="buttonCancelarDetalle_Click" />
                                </td>
                              </tr>
                              <tr>
                                <td colspan="6">
                                    <asp:GridView ID="gridDetalle" runat="server" 
                                                     AutoGenerateColumns="False" CssClass="grilla" 
                                                      FooterStyle-CssClass="footergrilla" 
                                                     HeaderStyle-CssClass="headergrilla" 
                                                      RowStyle-CssClass="rowgrilla" DataKeyNames="idProvisional" 
                                                     SelectedRowStyle-CssClass="selectedgrilla" Width="649px" 
                                                     AllowPaging="True" PageSize="15" 
                                        onrowcommand="gridDetalle_RowCommand">
                                                     <RowStyle CssClass="rowgrilla" />
                                                     <Columns>
                                                         <asp:ButtonField ButtonType="Button" CommandName="Modificar" Text="Modificar" 
                                                             Visible="False">
                                                             <ControlStyle CssClass="buttongrilla" />                                                     
                                                        </asp:ButtonField>                                                             
                                                         <asp:ButtonField ButtonType="Button" CommandName="Eliminar" 
                                                             Text="Eliminar">
                                                             <ControlStyle CssClass="buttongrilla" />
                                                         </asp:ButtonField>
                                                                 <asp:BoundField DataField="sustancia" HeaderText="Tipo de refrigerante"></asp:BoundField>
                                                                 <asp:BoundField DataField="cantidad" HeaderText="Cantidad (Kg.)" />
                                                                 <asp:BoundField DataField="destino" HeaderText="Destino" />
                                                                 <asp:BoundField DataField="nombre" HeaderText="Tercero" />
                                                                 <asp:BoundField DataField="id" HeaderText="Id" />
                                                                 <asp:BoundField DataField="idProvisional" HeaderText="idProvisional" />
                                                     </Columns>
                                                     <FooterStyle CssClass="footergrilla" />
                                                     <SelectedRowStyle CssClass="selectedgrilla" />
                                                     <HeaderStyle CssClass="headergrilla" />
                                                 </asp:GridView>                                
                                </td>
                              </tr>
             </table>
<table class="form">
                         <tr>
                                 <th colspan="6">
                                     <asp:Label ID="label3" runat="server" CssClass="subtitulo" 
                                         Text="Cantidad de gas regenerado comercializado"></asp:Label>
                                 </th>
                         </tr>                       
                             <tr>
                                 <td>
                                     <asp:Label ID="label12" runat="server" CssClass="label" 
                                         Text="Usuario / Empresa comercializadora"></asp:Label>&nbsp
                                     <asp:Label ID="Label13" runat="server" Text="(*)" Font-Bold="true"></asp:Label>   
                                 </td>
                                 <td colspan="5">
                                     <asp:TextBox ID="textTerceroCom" runat="server" CssClass="texto2" 
                                          Width="577px"></asp:TextBox>
                                 </td>
                             </tr>                                 
                         <tr>
                             <td>
                                 <asp:Label ID="label14" runat="server" CssClass="label" Text="Sustancia"></asp:Label>&nbsp
                                 <asp:Label ID="Label15" runat="server" Text="(*)" Font-Bold="true"></asp:Label>
                             </td>
                             <td>
                                 <asp:DropDownList ID="comboSustanciaCom" runat="server" CssClass="combo" 
                                     Width="106px" DataTextField="gti_Descripcion" DataValueField="gti_Id">
                                 </asp:DropDownList>
                             </td>
                             <td>
                                 <asp:Label ID="label16" runat="server" CssClass="label" Text="Fecha"></asp:Label>
                                 &nbsp
                                 <asp:Label ID="Label17" runat="server" Text="(*)" Font-Bold="true"></asp:Label>
                             </td>
                             <td colspan="3">
                                 <asp:TextBox ID="textFechaCom" runat="server" CssClass="texto2"></asp:TextBox>
                                 <cc1:CalendarExtender ID="CalendarExtender2" runat="server" CssClass="calendar" 
                                     Format="dd/MM/yyyy" TargetControlID="textFechaCom">
                                 </cc1:CalendarExtender>
                             </td>
                         </tr>
                         <tr>
                             <td>
                                 <asp:Label ID="label20" runat="server" CssClass="label" Text="Cantidad" 
                                     ></asp:Label>&nbsp
                                     <asp:Label ID="Label21" runat="server" Text="(*)" Font-Bold="true"></asp:Label></td>
                                     <td colspan="3">
                                 <asp:TextBox ID="textCantidadCom" runat="server" CssClass="texto2"  
                                     Width="103px"  ></asp:TextBox>
                                     </td>
                              </tr>
                              <tr>
                                <td colspan="6">    
                                    <asp:Button ID="buttonAgregarCom" runat="server" Text="Agregar" 
                                        CssClass="button" onclick="buttonAgregarCom_Click" 
                                         />
                                    &nbsp
                                    <asp:Button ID="buttonCancelarCom" runat="server" Text="Cancelar" 
                                        CssClass="button" onclick="buttonCancelarCom_Click"  />
                                </td>
                              </tr>
                              <tr>
                                <td colspan="6">
                                    <asp:GridView ID="gridCom" runat="server" 
                                                     AutoGenerateColumns="False" CssClass="grilla" 
                                                      FooterStyle-CssClass="footergrilla" 
                                                     HeaderStyle-CssClass="headergrilla" 
                                                      RowStyle-CssClass="rowgrilla" DataKeyNames="idProvisional" 
                                                     SelectedRowStyle-CssClass="selectedgrilla" Width="649px" 
                                                     AllowPaging="True" PageSize="15" onrowcommand="gridCom_RowCommand" 
                                        >
                                                     <RowStyle CssClass="rowgrilla" />
                                                     <Columns>
                                                         <asp:ButtonField ButtonType="Button" CommandName="Modificar" Text="Modificar" 
                                                             Visible="False">
                                                             <ControlStyle CssClass="buttongrilla" />                                                     
                                                        </asp:ButtonField>                                                             
                                                         <asp:ButtonField ButtonType="Button" CommandName="Eliminar" 
                                                             Text="Eliminar">
                                                             <ControlStyle CssClass="buttongrilla" />
                                                         </asp:ButtonField>
                                                                 <asp:BoundField DataField="sustancia" HeaderText="Tipo de refrigerante"></asp:BoundField>
                                                                 <asp:BoundField DataField="cantidad" HeaderText="Cantidad (Kg.)" />
                                                                 <asp:BoundField DataField="destino" HeaderText="Destino" />
                                                                 <asp:BoundField DataField="nombre" HeaderText="Tercero" />
                                                                 <asp:BoundField DataField="id" HeaderText="Id" />
                                                                 <asp:BoundField DataField="idProvisional" HeaderText="idProvisional" />
                                                     </Columns>
                                                     <FooterStyle CssClass="footergrilla" />
                                                     <SelectedRowStyle CssClass="selectedgrilla" />
                                                     <HeaderStyle CssClass="headergrilla" />
                                                 </asp:GridView>                                
                                </td>
                              </tr>
             </table>             
    <table class="form">
                         <tr>
                                 <th colspan="6">
                                     <asp:Label ID="label18" runat="server" CssClass="subtitulo" 
                                         Text="Cantidad gas para disposición final"></asp:Label>
                                 </th>
                         </tr>                       
                             <tr>
                                 <td>
                                     <asp:Label ID="label19" runat="server" CssClass="label" 
                                         Text="Empresa gestora"></asp:Label>&nbsp
                                     <asp:Label ID="Label22" runat="server" Text="(*)" Font-Bold="true"></asp:Label>   
                                 </td>
                                 <td colspan="5">
                                     <asp:TextBox ID="textTerceroDisp" runat="server" CssClass="texto2" 
                                          Width="577px"></asp:TextBox>
                                 </td>
                             </tr>                                 
                         <tr>
                             <td>
                                 <asp:Label ID="label23" runat="server" CssClass="label" Text="Sustancia"></asp:Label>&nbsp
                                 <asp:Label ID="Label24" runat="server" Text="(*)" Font-Bold="true"></asp:Label>
                             </td>
                             <td>
                                 <asp:DropDownList ID="comboSustanciaDisp" runat="server" CssClass="combo" 
                                     Width="106px" DataTextField="gti_Descripcion" DataValueField="gti_Id">
                                 </asp:DropDownList>
                             </td>
                             <td>
                                 <asp:Label ID="label25" runat="server" CssClass="label" Text="Fecha"></asp:Label>
                                 &nbsp
                                 <asp:Label ID="Label26" runat="server" Text="(*)" Font-Bold="true"></asp:Label>
                             </td>
                             <td colspan="3">
                                 <asp:TextBox ID="textFechaDisp" runat="server" CssClass="texto2"></asp:TextBox>
                                 <cc1:CalendarExtender ID="CalendarExtender3" runat="server" CssClass="calendar" 
                                     Format="dd/MM/yyyy" TargetControlID="textFechaDisp">
                                 </cc1:CalendarExtender>
                             </td>
                         </tr>
                         <tr>
                             <td>
                                 <asp:Label ID="label27" runat="server" CssClass="label" Text="Cantidad" 
                                     ></asp:Label>&nbsp
                                     <asp:Label ID="Label28" runat="server" Text="(*)" Font-Bold="true"></asp:Label></td>
                                     <td colspan="3">
                                 <asp:TextBox ID="textCantidadDisp" runat="server" CssClass="texto2"  
                                     Width="103px"  ></asp:TextBox>
                                     </td>
                              </tr>
                              <tr>
                                <td colspan="6">    
                                    <asp:Button ID="buttonAgregarDisp" runat="server" Text="Agregar" 
                                        CssClass="button" onclick="buttonAgregarDisp_Click" 
                                         />
                                    &nbsp
                                    <asp:Button ID="buttonCancelarDisp" runat="server" Text="Cancelar" 
                                        CssClass="button" onclick="buttonCancelarDisp_Click"  />
                                </td>
                              </tr>
                              <tr>
                                <td colspan="6">
                                    <asp:GridView ID="gridDisp" runat="server" 
                                                     AutoGenerateColumns="False" CssClass="grilla" 
                                                      FooterStyle-CssClass="footergrilla" 
                                                     HeaderStyle-CssClass="headergrilla" 
                                                      RowStyle-CssClass="rowgrilla" DataKeyNames="idProvisional" 
                                                     SelectedRowStyle-CssClass="selectedgrilla" Width="649px" 
                                                     AllowPaging="True" PageSize="15" onrowcommand="gridDisp_RowCommand" 
                                        >
                                                     <RowStyle CssClass="rowgrilla" />
                                                     <Columns>
                                                         <asp:ButtonField ButtonType="Button" CommandName="Modificar" Text="Modificar" 
                                                             Visible="False">
                                                             <ControlStyle CssClass="buttongrilla" />                                                     
                                                        </asp:ButtonField>                                                             
                                                         <asp:ButtonField ButtonType="Button" CommandName="Eliminar" 
                                                             Text="Eliminar">
                                                             <ControlStyle CssClass="buttongrilla" />
                                                         </asp:ButtonField>
                                                                 <asp:BoundField DataField="sustancia" HeaderText="Tipo de refrigerante"></asp:BoundField>
                                                                 <asp:BoundField DataField="cantidad" HeaderText="Cantidad (Kg.)" />
                                                                 <asp:BoundField DataField="destino" HeaderText="Destino" />
                                                                 <asp:BoundField DataField="nombre" HeaderText="Tercero" />
                                                                 <asp:BoundField DataField="id" HeaderText="Id" />
                                                                 <asp:BoundField DataField="idProvisional" HeaderText="idProvisional" />
                                                     </Columns>
                                                     <FooterStyle CssClass="footergrilla" />
                                                     <SelectedRowStyle CssClass="selectedgrilla" />
                                                     <HeaderStyle CssClass="headergrilla" />
                                                 </asp:GridView>                                
                                </td>
                              </tr>
             </table>               
<%--             <table class="form">
            <tr>
                        <th>   
                        <asp:Label ID="label8" runat="server" Text="Documentos" Visible="false"
                                CssClass="subtitulo"></asp:Label>
                        </th>
            </tr>
            <tr>
                <td style="width:20%">
                    <uc1:DocumentosVarios ID="DocumentosVarios" runat="server" Visible="false"/>
                </td>
             </tr>                
          </table>  --%>  
        <asp:Panel ID="panelBotones" runat="server" >            
            <table>
                <tr>
                    <td>
                        &nbsp;&nbsp;
                    <asp:Button ID="buttonGuardar" runat="server" Text="Guardar"  
                            CssClass="button" onclick="buttonGuardar_Click" />
                    &nbsp;<asp:Button ID="buttonCancelar" runat="server" Text="Cancelar"  
                            CssClass="button" onclick="buttonCancelar_Click" />
                    </td>
                </tr>               
            </table>
    </asp:Panel>                                  
          
                            
                                     </div>
                                     
                                     
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