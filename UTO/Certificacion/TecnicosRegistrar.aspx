    <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TecnicosRegistrar.aspx.cs" MasterPageFile="~/MPMain.Master" Inherits="UTO.Certificacion.Registrartecnicos" %>

    <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
    <%@ Register src="../Comunes/ControlError.ascx" tagname="ControlError" tagprefix="uc2" %>
    <asp:Content ID="contentRegistrarTecnicosHead" ContentPlaceHolderID="head" Runat="Server">

        <script type="text/javascript" language="javascript">
    function calendarShown(sender, args) {
    sender._popupBehavior._element.style.zIndex = 10005;
    }
    </script>
    </asp:Content>
    <asp:Content  ID="contentRegistrarTecnicos" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >

    <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </cc1:ToolkitScriptManager>  
    <div class="divwithoutgrid">
    <table class="titulo" >
        <tr>
            <td>
                <asp:Label ID="labelRegistarTecnicos" runat="server" Text="Módulo certificación - Adicionar técnicos" CssClass="subtitulo"></asp:Label>
            </td>
        </tr>
    </table>
    <table class="form">
    <tr>
    <td>        
        <uc2:ControlError ID="ControlError1" runat="server" />        
    </td>
    </tr>
    </table>
    <br />        
            <table class="form">
        <tr>
            <td>
                <table style="width:100%;"> 
        <tr>
        <th colspan="5">
        <asp:Label ID="labelDatosGenerales" runat="server" Text="Datos generales" CssClass="subtitulo"></asp:Label>
        </th>
        </tr>
        <tr>
    <td>
    <asp:Label ID="labelTipoDocumento" runat="server" Text="Tipo documento" CssClass="label"></asp:Label>
        <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>
    </td><td >
    <asp:DropDownList ID="comboTipoDocumento" runat="server"  CssClass="combo" DataTextField="dti_Descripcion" 
    DataValueField="dti_Id"></asp:DropDownList>
    </td>
    <td class="separador"></td>
    <td>
    <asp:Label ID="labelDocumento" runat="server" Text="Documento" CssClass="label"> 
         </asp:Label>&nbsp 
        <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>
    </td>
    <td>
    <asp:TextBox ID="textDocumento" runat="server"  CssClass="texto2"></asp:TextBox>
    </td>
    </tr><tr>
    <td><asp:Label ID="labelNombre" runat="server" Text="Nombre" CssClass="label"></asp:Label>&nbsp 
        <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label></td>
    <td><asp:TextBox ID="textNombre" runat="server"  CssClass="texto2" 
            Width="171px"></asp:TextBox></td>
    <td class="separador"></td>
    <td>
        <asp:Label ID="labelRegional" runat="server" Text="Regional" CssClass="label"></asp:Label>&nbsp
        <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>
    </td>
    <td>
        <asp:DropDownList ID="comboRegional" runat="server" CssClass="combo" DataTextField="reg_Descripcion" 
            DataValueField="reg_Id" AutoPostBack="true"
            onselectedindexchanged="comboRegional_SelectedIndexChanged">
    </asp:DropDownList>
    </td>
    </tr><tr>
    <td><asp:Label ID="labelDepartamento" runat="server" Text="Departamento" CssClass="label"></asp:Label> &nbsp 
        <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label></td>
    <td> 
        <asp:UpdatePanel runat="server" UpdateMode="Conditional">
        <ContentTemplate>
        <asp:DropDownList ID="comboDepartamento" runat="server" CssClass="combo" DataTextField="dep_Descripcion" DataValueField="dep_Id" AutoPostBack="True" 
            onselectedindexchanged="comboDepartamento_SelectedIndexChanged">
    </asp:DropDownList>
        </ContentTemplate>
        <Triggers>
        <asp:AsyncPostBackTrigger ControlID="comboRegional"/>
        </Triggers>
        </asp:UpdatePanel>
        </td>
    <td class="separador"></td>
    <td><asp:Label ID="labelCiudad" runat="server" Text="Ciudad" CssClass="label"></asp:Label>&nbsp  
        <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label></td>
    <td>
    <asp:UpdatePanel runat="server" UpdateMode="Conditional" ID="updateCiudad">
    <ContentTemplate>
    <asp:DropDownList ID="comboCiudad" runat="server" CssClass="combo" 
            DataTextField="mun_Descripcion" DataValueField="mun_Id">
    </asp:DropDownList>
    </ContentTemplate>
    <Triggers>
    <asp:AsyncPostBackTrigger ControlID="comboDepartamento"/>
    </Triggers>
    </asp:UpdatePanel>
    </td>
    </tr><tr>
    <td>
    <asp:Label ID="labelDireccion" runat="server" Text="Dirección" CssClass="label"></asp:Label> 
    </td>
    <td>
    <asp:TextBox ID="textDireccion" runat="server" CssClass="texto2"></asp:TextBox> 
    </td>
    <td class="separador"></td>
    <td>
    <asp:Label ID="labelTelefono" runat="server" Text="Teléfono" CssClass="label"></asp:Label>
    </td>
    <td>
    <asp:TextBox ID="textTelefono" runat="server" CssClass="texto2"></asp:TextBox>
    </td>
    </tr><tr>
    <td>
    <asp:Label ID="labelCelular" runat="server" Text="Celular" CssClass="label"></asp:Label>
    </td>
    <td>
    <asp:TextBox ID="textCelular" runat="server" CssClass="texto2"></asp:TextBox>
    </td>
    <td class="separador"></td>
    <td>
    <asp:Label ID="labelEmail" runat="server" Text="E-Mail" CssClass="label"></asp:Label>
    </td>
    <td>
    <asp:TextBox ID="textEmail" runat="server" CssClass="texto2"></asp:TextBox>
    </td>
    </tr><tr>
    <td>
        <asp:Label ID="labelFax" runat="server" Text="Fax" CssClass="label"></asp:Label>
    </td>
    <td>
    <asp:TextBox ID="textFax" runat="server" CssClass="texto2"></asp:TextBox>
    </td>
    <td class="separador"></td>
        <td>
            <asp:Label ID="labelTipo" runat="server" Text="Tipo" CssClass="label" 
                Visible="False"></asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="comboTipo" runat="server" CssClass="combo" 
                DataTextField="tti_Descripcion" DataValueField="tti_Id" Visible="False" >
            </asp:DropDownList>
        </td>
    </tr>  
    <tr>
        <td>
            <asp:Label ID="labelArea" runat="server" Text="Área de trabajo" CssClass="label"></asp:Label>&nbsp
            <asp:Label ID="Label1" runat="server" Text="(*)" Font-Bold="true"></asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="comboAreaTrabajo" runat="server" CssClass="combo" 
                    DataTextField="atr_Des" DataValueField="atr_Id">
            </asp:DropDownList>
        </td>
    <td class="separador">
        <br />
    </td>
                            <td>
                                <asp:Label ID="labelEmpresa" runat="server" Text="Empresa" CssClass="label"></asp:Label>&nbsp
                                <asp:Label ID="Label2" runat="server" Text="(*)" Font-Bold="true"></asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="comboEmpresa" runat="server" CssClass="combo" DataTextField="ter_NombreCompleto" DataValueField="ter_Id">
                                </asp:DropDownList>
                            </td>
    </tr>
    <tr><td>
    <asp:Label runat="server" ID="labelCTG" Text="CTG" CssClass="label"></asp:Label>&nbsp;
    <asp:Label ID="Label3" runat="server" Text="(*)" Font-Bold="true"></asp:Label>
    </td>
    <td colspan="4">
    <asp:GridView ID="gridCTG" runat="server" AutoGenerateColumns="False" 
            HeaderStyle-CssClass="headergrilla" CssClass="grilla" 
            RowStyle-CssClass="rowgrilla" FooterStyle-CssClass="footergrilla" DataKeyNames="cat_Id" 
              >
        <RowStyle CssClass="rowgrilla" />
        <Columns>
            <asp:TemplateField>
            <ItemTemplate>
            <asp:CheckBox ID="checCTG" runat="server" CssClass="check" 
            AutoPostBack="false"  />
            </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="cat_Descripcion" HeaderText="CTG" />
            <asp:TemplateField HeaderText="Fecha"></asp:TemplateField>
            <asp:BoundField DataField="cat_Id" HeaderText="Id" Visible="False" />
        </Columns>
        <FooterStyle CssClass="footergrilla" />
        <HeaderStyle CssClass="headergrilla" />
    </asp:GridView>
    </td>
    </tr>
    </table>
    </td>
    </tr>

    </table>        
    </div>
    <div class="divsingrilla2">
    <table  class="formColapsable">
    <tr>
    <td class="tdCollap">
    <!-- collpasible certificaciones-->
    <asp:LinkButton ID="linkCertificaciones" runat="server" CssClass="lnbCollap"> <div>
    <div style="float: left;">Certificaciones</div><div style="float: right; vertical-align: middle;">
    <asp:ImageButton ID="imageCertificaciones" runat="server" ImageUrl="~/images/fl_abajo.jpg" AlternateText="Mostrar detalles" />
    </div>
    </div>
    </asp:LinkButton> 
    <cc1:CollapsiblePanelExtender ExpandedImage="~/images/fl_arriba.jpg"  CollapsedImage="~/images/fl_abajo.jpg" ImageControlID="imageCertificaciones" ID="colapsibleCertificaciones" SuppressPostBack="true" CollapsedSize="0" ExpandedSize="150" ExpandControlID="linkCertificaciones" runat="server" TargetControlID="panelCertificaciones" CollapseControlID="linkCertificaciones" Collapsed="true" >
    </cc1:CollapsiblePanelExtender> 
    </td>
    </tr>
    <tr>
        <td>    
            <asp:Panel ID="panelCertificaciones" runat="server">
                <asp:Button ID="buttonAgregar" runat="server" Text="Adicionar" CssClass="button"/>                
                <asp:UpdatePanel ID="UpdatePanel3" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                <asp:GridView ID="gridCertificaciones" runat="server"  AutoGenerateColumns="False" 
                CssClass="grilla" RowStyle-CssClass="rowgrilla" 
                HeaderStyle-CssClass="headergrilla" FooterStyle-CssClass="footergrilla" 
                onrowcommand="gridCertificaciones_RowCommand" DataKeyNames="id">
                <RowStyle CssClass="rowgrilla" />
                    <Columns>
                        <asp:ButtonField ButtonType="Button" CommandName="Modificar" Text="Modificar" 
                            Visible="False">
                        <ControlStyle CssClass="buttongrilla" />
                        </asp:ButtonField>
                        <asp:ButtonField ButtonType="Button" CommandName="Eliminar" Text="Eliminar">
                        <ControlStyle CssClass="buttongrilla" />
                        </asp:ButtonField>
                        <asp:BoundField DataField="certificacion" HeaderText="Fecha certificación" DataFormatString="{0:dd/MM/yyyy}"/>
                        <asp:BoundField DataField="vigencia" HeaderText="Vigencia" DataFormatString="{0:dd/MM/yyyy}"/>
                        <asp:BoundField DataField="id" HeaderText="Id" Visible="False" />
                    </Columns>
                <FooterStyle CssClass="footergrilla" />
                <HeaderStyle CssClass="headergrilla" />
                </asp:GridView>
                </ContentTemplate>
                <Triggers>
                <asp:AsyncPostBackTrigger ControlID="buttonEnviarCertificacion" />
                </Triggers>
                </asp:UpdatePanel>
            </asp:Panel>
        </td>
    </tr>   
    </table>
    </div>   
    <div class="divsingrillas3">
    <table>
    <tr>
    <td>
    <asp:Label ID="labelActividades" runat="server" Text="Actividades" CssClass="label"></asp:Label>
    </td>
    <td colspan="4">
    <asp:ListBox ID="listboxActividad" runat="server" 
            DataTextField="act_Actividad" DataValueField="act_Actividad" 
            CssClass="listcheck"></asp:ListBox>
    </td>
    </tr>

    </table>
    </div>
    <div class="divsingrillas3">
    <table>
    <tr>
    <td>
    <asp:Button ID="buttonGuardar" runat="server" Text="Guardar" CssClass="button" 
            onclick="buttonGuardar_Click" />&nbsp;&nbsp;<asp:Button ID="buttoncancelar" runat="server" Text="Cancelar"  CssClass="button" onclick="buttoncancelar_Click"/>
    </td>
    </tr>
    </table>
    </div>
    <!-- modal de certificaciones-->   
        <cc1:ModalPopupExtender ID="modalAddCertificaciones" runat="server"
        TargetControlID="buttonAgregar"
        BackgroundCssClass="FondoAplicacion"
        PopupControlID="panelAddCertificaciones"        
        CancelControlID="buttonCancelarCertificacion"
       />        
        <asp:Panel ID="panelAddCertificaciones" runat="server" style="display:none">
            <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
            <ContentTemplate>    
         <table class="form">
                        <tr>
                            <th colspan="2">Certificaciones</th>
                        </tr>
                        <tr>
                        <td colspan="2">                        
                            <uc2:ControlError ID="ControlError2" runat="server" />                        
                        </td>
                        </tr>
                        <tr>
                            <td>
                               <asp:Label ID="labelFechaCertificacion" runat="server" CssClass="label" 
                                    Text="Fecha certificación"></asp:Label>&nbsp;
                                    <asp:Label runat="server" Font-Bold="true" Text="(*)"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="textFecha" runat="server" CssClass="texto2"></asp:TextBox>
                                    <cc1:CalendarExtender ID="calendarextender1" runat="server" CssClass="calendar" 
                                    Enabled="True" Format="dd/MM/yyyy" TargetControlID="textFecha" 
                                    OnClientShown="calendarShown">
                                    </cc1:CalendarExtender>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="labelvigencia" runat="server" CssClass="label" 
                                    Text="Vigencia (años)"></asp:Label>&nbsp
                                <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>  
                            </td>
                            <td>
                                <asp:TextBox ID="textvigencia" runat="server" CssClass="texto2"></asp:TextBox>                               
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="labelCarnetizado" runat="server" Text="Está carnetizado" 
                                    CssClass="label"></asp:Label>
                            </td>
                            <td>
                                <asp:Panel ID="PanelCarnetizado" runat="server">
                                    <asp:RadioButton ID="radioSiCarnetizado0" runat="server" Text="Si" 
                                    GroupName="Carnetizado" />
                                    <asp:RadioButton ID="radioNoCarnetizado" runat="server" Text="No" 
                                    GroupName="Carnetizado"/>  
                                </asp:Panel>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="labelNúmeroCarnet" runat="server" Text="Número carnet" 
                                    CssClass="label"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="textNúmeroCarnet" runat="server" CssClass="texto2"></asp:TextBox>
                            </td>
                        </tr>
                   <tr>
                    <td colspan="2">
                    <asp:Button ID="buttonEnviarCertificacion" runat="server" Text="Guardar" 
                    CssClass="button" onclick="buttonEnviarCertificacion_Click"  />&nbsp;&nbsp;
                    <asp:Button ID="buttonCancelarCertificacion" runat="server" Text="Cancelar" CssClass="button" OnClick="CancelarAddCertificacion"/>
                    </td>
                    </tr>
                    </table>
          </ContentTemplate>
            </asp:UpdatePanel>             
        </asp:Panel>    
    </asp:Content>
