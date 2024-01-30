<%@ Page Language="C#" MasterPageFile="~/MPMain.Master"  AutoEventWireup="true" CodeBehind="ConsolidadoRegeneracionRegistrar.aspx.cs" Inherits="UTO.Recuperacion.ConsolidadoRegeneracionRegistrar" %>

    <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
    <%@ Register src="../Comunes/ControlError.ascx" tagname="ControlError" tagprefix="uc2" %>
    <%@ Register src="~/Comunes/DocumentosVarios.ascx" tagname="DocumentosVarios" tagprefix="uc1" %>

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
            <table style="width: 706px">
             <tr>
                 <td class="style4">
                     <asp:Label ID="labelNombreCentro" runat="server" CssClass="label" 
                         Text="Centro regeneración"></asp:Label>&nbsp
                     <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>     
                 </td>
                 <td>
                     <asp:DropDownList ID="comboCentroRegeneracion" runat="server" CssClass="combo" 
                         DataTextField="cre_Descripcion" DataValueField="cre_Id">
                     </asp:DropDownList>
                 </td>
                 <td class="style4">
                     <asp:Label ID="labelFecha0" runat="server" CssClass="label" Text="Mes"></asp:Label>&nbsp
                     <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label> 
                 </td>
                 <td class="style4">
                     <asp:DropDownList ID="comboMes" runat="server" CssClass="combo" Width="105px">
                         <asp:ListItem>Seleccione...</asp:ListItem>
                         <asp:ListItem Value="1">Enero</asp:ListItem>
                         <asp:ListItem Value="2">Febrero</asp:ListItem>
                         <asp:ListItem Value="3">Marzo</asp:ListItem>
                         <asp:ListItem Value="4">Abril</asp:ListItem>
                         <asp:ListItem Value="5">Mayo</asp:ListItem>
                         <asp:ListItem Value="6">Junio</asp:ListItem>
                         <asp:ListItem Value="7">Julio</asp:ListItem>
                         <asp:ListItem Value="8">Agosto</asp:ListItem>
                         <asp:ListItem Value="9">Septiembre</asp:ListItem>
                         <asp:ListItem Value="10">Octubre</asp:ListItem>
                         <asp:ListItem Value="11">Noviembre</asp:ListItem>
                         <asp:ListItem Value="12">Diciembre</asp:ListItem>
                     </asp:DropDownList>
                 </td>
             </tr> 
             </table>       
             <table>
             <tr>
                <th>   
                <asp:Label ID="label4" runat="server" Text="Reporte consolidado de centros regeneración" 
                        CssClass="subtitulo"></asp:Label>
                </th>
            </tr>
             <tr>
                 <td>
                     <table style="width: 656px; height: 270px">
                         <tr>
                             <td class="style4">
                                 <asp:Label ID="labelTipoGas" runat="server" CssClass="label" Text="Sustancia"></asp:Label>&nbsp
                                 <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>
                             </td>
                             <td>
                                 <asp:DropDownList ID="comboTipoGas" runat="server" CssClass="combo" 
                                     Width="106px" DataTextField="gti_Descripcion" DataValueField="gti_Id">
                                 </asp:DropDownList>
                             </td>
                             <td class="style4">
                                 <asp:Label ID="labelPrecioPromedio" runat="server" CssClass="label" 
                                     Text="Precio de comercialización"></asp:Label>
                             </td>
                             <td class="style4">
                                 <asp:TextBox ID="textPrecioPromedio" runat="server" CssClass="texto2" 
                                     Width="64px"></asp:TextBox>
                             </td>
                         </tr>
                         <tr>
                             <td class="style5">
                                 <asp:Label ID="labelCantidadVendidaKg" runat="server" CssClass="label" 
                                     Text="Cantidad vendida (kg)"></asp:Label>&nbsp
                                 <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>  
                             </td>
                             <td class="style5">
                                 <asp:TextBox ID="textUsoCantidadVendida" runat="server" CssClass="texto2" 
                                     Width="65px" AutoPostBack="True" 
                                     ontextchanged="textUsoCantidadVendida_TextChanged"></asp:TextBox>
                             </td>
                             <td class="style5">
                                 <asp:Label ID="labelCantidadVendida" runat="server" CssClass="label" 
                                     Text="Cantidad vendida (lb)"></asp:Label>
                             </td>
                             <td class="style5">
                                 <asp:TextBox ID="textUsoCantidadEntregadaKg" runat="server" CssClass="texto2" 
                                     Enabled="False" Width="64px"></asp:TextBox>
                             </td>
                         </tr>
                         <tr>
                             <td colspan="4" class="style9">
                                 <asp:Button ID="buttonAdicionar" runat="server" CssClass="button" 
                                     onclick="buttonAdicionar_Click" Text="Adicionar" />
                                 &nbsp;</td>
                         </tr>
                         <tr>
                             <td class="style7" colspan="4">
                                 <div class="divgrillassinmargin">
                                     <asp:GridView ID="gridReporteRecuperacion" runat="server" 
                                         AutoGenerateColumns="False" CssClass="grilla" FooterStyle-CssClass="footergrilla" 
                                         HeaderStyle-CssClass="headergrilla" Height="79px" 
                                         RowStyle-CssClass="rowgrilla" Width="648px" DataKeyNames="idProvisional" 
                                         onrowcommand="gridReporteRecuperacion_RowCommand" AllowPaging="True" 
                                         PageSize="15">
                                         <RowStyle CssClass="rowgrilla" />
                                         <Columns>
                                             <asp:ButtonField ButtonType="Button" CommandName="Eliminar" Text="Eliminar">
                                                 <ControlStyle CssClass="buttongrilla" />
                                             </asp:ButtonField>
                                             <asp:BoundField DataField="tipoGas" HeaderText="Tipo gas" />
                                             <asp:BoundField DataField="precio" HeaderText="Precio promedio" />
                                             <asp:BoundField DataField="libra" HeaderText="Lb" />
                                             <asp:BoundField DataField="kilo" HeaderText="Kg" />
                                             <asp:BoundField DataField="id" HeaderText="Id" />
                                             <asp:BoundField DataField="idProvisional" HeaderText="Id provisional" />
                                         </Columns>
                                         <FooterStyle CssClass="footergrilla" />
                                         <HeaderStyle CssClass="headergrilla" />
                                     </asp:GridView>
                                 </div>
                             </td>
                         </tr>
                     </table>
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
        <table>
        <tr>
            <td>
                &nbsp;&nbsp;
            <asp:Button ID="buttonGuardar" runat="server" Text="Guardar"  
                    CssClass="button" onclick="buttonGuardar_Click"/>
            &nbsp;<asp:Button ID="buttonExportar" runat="server" CssClass="button" 
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
<asp:Content ID="Content1" runat="server" contentplaceholderid="head">

    <style type="text/css">
        .style4
        {
            height: 22px;
        }
        .style5
        {
            height: 29px;
        }
        .style7
        {
            height: 158px;
        }
        .style9
        {
            height: 14px;
        }
        </style>

</asp:Content>

