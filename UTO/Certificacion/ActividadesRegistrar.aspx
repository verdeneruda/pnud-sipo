    <%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/MPMain.Master"  CodeBehind="ActividadesRegistrar.aspx.cs" Inherits="UTO.Certificacion.RegistrarActividades" %>

    <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>


    <%@ Register src="../Comunes/DocumentosVarios.ascx" tagname="DocumentosVarios" tagprefix="uc1" %>
    
     <%@ Register src="../Comunes/ControlError.ascx" tagname="ControlError" tagprefix="uc2" %>


    <asp:Content ID="contentRegistrarActividadesHead" ContentPlaceHolderID="head" Runat="Server">
        <style type="text/css">
            .style1
            {
                height: 26px;
            }
        </style>
    </asp:Content>
    <asp:Content  ID="contentRegistrarActividades" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >

        <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </cc1:ToolkitScriptManager>
    
    <div class="divwithoutgrid">
    
        <table class="titulo" >
            <tr>
                <td>
                    <asp:Label ID="labelRegistarActividades" runat="server" Text="Módulo actividades - Adicionar actividades de divulgación" CssClass="subtitulo"></asp:Label>
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
                                <asp:Label ID="labelFechaActividad" runat="server" Text="Fecha de la actividad" 
                                    CssClass="label"></asp:Label>&nbsp
                                <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="textfecha" runat="server" CssClass="texto2"></asp:TextBox><cc1:CalendarExtender
                                    ID="calendarextender" runat="server" CssClass="calendar" Format="dd/MM/yyyy" TargetControlID="textfecha" Enabled="true" >
                                    </cc1:CalendarExtender>
                           </td>
                                                          
                            <%--    <td colspan="3"></td>--%>
                        </tr>
                            
                            
                                <tr>
                                    <td>
                                    <asp:Label ID="labelDepartamento" runat="server" CssClass="label" 
                                        Text="Departamento de la actividad"></asp:Label>&nbsp
                                        <asp:Label ID="Label4" runat="server" Text="(*)" Font-Bold="true"></asp:Label></td><td>
                                        <asp:DropDownList ID="comboDepartamento" runat="server"
                                            CssClass="combo" AutoPostBack="True" DataTextField="dep_Descripcion" 
                                            DataValueField="dep_Id" 
                                            onselectedindexchanged="comboDepartamento_SelectedIndexChanged">
                                        </asp:DropDownList>
                                    </td>
                                    <td>
                                        <asp:Label runat="server" ID="labelCiudad" Text="Ciudad de la actividad" CssClass="label"></asp:Label>&nbsp
                                        <asp:Label ID="Label5" runat="server" Text="(*)" Font-Bold="true"></asp:Label></td><td>
                                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                                        <asp:DropDownList ID="comboCiudad" runat="server" CssClass="combo" 
                                            DataTextField="mun_Descripcion" DataValueField="mun_Id" >
                                        </asp:DropDownList>
                                        </ContentTemplate>
                                        <Triggers>
                                        <asp:AsyncPostBackTrigger ControlID="comboDepartamento"/>
                                        </Triggers>
                    </asp:UpdatePanel>    
                                    </td>            
                                </tr>
                                
                                <tr>
                                    <td>
                                        <asp:Label ID="labelTipo" runat="server" CssClass="label" 
                                            Text="Tipo de la actividad"></asp:Label>&nbsp
                                        <asp:Label ID="Label2" runat="server" Text="(*)" Font-Bold="true"></asp:Label></td>
                                    <td colspan="3">
                                        <asp:DropDownList ID="comboTipoActividad" runat="server"
                                            CssClass="combo" DataTextField="ati_Descripcion" 
                                            DataValueField="ati_Id" Width="475px" AutoPostBack="True" 
                                            onselectedindexchanged="comboTipoActividad_SelectedIndexChanged" >
                                        </asp:DropDownList>
                                    </td>  
        </tr>                        
                                                                                      
                        <tr>
                            <td>
                                <asp:Label ID="labelActividad" runat="server" 
                                    Text="Descripción de la actividad" CssClass="label"></asp:Label>
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="textActividad" runat="server" CssClass="texto4" TextMode="MultiLine"></asp:TextBox>
                            </td>
                            <%--    <td colspan="3">
                                </td>--%>
                        </tr>
                        <tr> 
                            <td>
                                <asp:Label ID="labelEntidades" runat="server" Text="Entidades involucradas" 
                                    CssClass="label"></asp:Label>
                            </td>
                            <td colspan="3"> 
                                <asp:TextBox ID="textEntidades" runat="server" CssClass="texto4" 
                                    TextMode="MultiLine"></asp:TextBox>
                            </td>
                        </tr>

                        <tr>
                            <td>
                                <asp:Label ID="labelNumeroPersonasimpactadas" runat="server" CssClass="label" 
                                    Text="Número personas impactadas"></asp:Label>&nbsp
                                <asp:Label runat="server" Text="(*)" Font-Bold="True" ID="labelAsterisco"></asp:Label>   
                            </td>
                            <td colspan="4">
                                <asp:TextBox ID="textoNumeroPersonasImpactadas" runat="server" CssClass="texto2">0</asp:TextBox>
                                </td></tr>
                         </table>

                </td>
            </tr>
       </table>
       
    </div>
    
        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
            <ContentTemplate>
                <!--table collapsible -->
                <div class="divwithoutgrid">
                    <table class="formColapsable" >
                       <tr>
                            <td>
                                <asp:Panel ID="panelCollPersonas" runat="server"> 
                                    <table class="form">
                                       <tr>
                                             <th colspan="4"> 
                                                <asp:Label ID="label3" runat="server" Text="Buscar persona" 
                                                    CssClass="subtitulo"></asp:Label>
                                            </th>
                                        </tr>                                       
                                        <tr>
                                            <td>
                                                <asp:Label ID="labelNombreBuscar" runat="server" Text="Nombre" CssClass="label"></asp:Label></td><td colspan="3">
                                                <asp:TextBox ID="textNombreBuscar" runat="server"  CssClass="texto2" 
                                                    Width="99%"></asp:TextBox></td></tr><tr>
                                            <td class="style1">
                                                <asp:Label ID="labelTipoDocumento" runat="server" CssClass="label" 
                                                    Text="Tipo documento"></asp:Label></td><td class="style1">
                                                <asp:DropDownList ID="comboTipoDocumento" runat="server" CssClass="combo" DataTextField="dti_Descripcion" 
                                                    DataValueField="dti_Id">
                                                </asp:DropDownList>
                                            </td>
                                            <td class="style1">
                                                <asp:Label ID="labelNumeroDocumento" runat="server" CssClass="label" 
                                                    Text="Número de documento"></asp:Label></td><td class="style1">
                                                <asp:TextBox ID="textNumeroDocumento" runat="server" CssClass="texto2"></asp:TextBox></td></tr>
                                                </table>
                                                <table class="form">        
                <tr>
                    <td>
                        <asp:Button ID="buttonBuscarPersona" runat="server" CssClass="button" 
                        Text="Buscar" onclick="buttonBuscarPersona_Click" />&nbsp;&nbsp;
                        <asp:Button ID="buttonAdicionar" runat="server" Text="Adicionar" 
                            CssClass="button" onclick="buttonAdicionar_Click" />
                    </td>
                </tr>
            </table>
            
     <asp:Panel ID="PanelTercero" runat="server" Visible="False">
            
           <table class="formModal">
                 
                <tr>
                    <th colspan="5"> 
                        <asp:Label ID="labelDatosEmpresa" runat="server" Text="Datos persona" 
                            CssClass="subtitulo"></asp:Label>
                    </th>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="labelRazonSocial" runat="server" Text="Nombre"
                        CssClass="label"></asp:Label>
                        &nbsp<asp:Label runat="server" Text="(*)" Font-Bold="True" ID="label7"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="textRazonsocial" runat="server"  CssClass="texto1"></asp:TextBox></td><td class="separador">
                    </td>       
                    <td>
                        <asp:Label ID="labelNit" runat="server" Text="Tipo de documento"
                            CssClass="label"></asp:Label></td><td>
                        <asp:DropDownList ID="comboDocumentoTipo" runat="server" CssClass="combo" 
                        DataTextField="dti_Descripcion" DataValueField="dti_Id" >
                        </asp:DropDownList>                    
                    </td>
                </tr>
                
                <tr>
                    <td>
                        <asp:Label runat="server" Text="Documento" CssClass="label" ID="labelDocumento"></asp:Label></td><td>
                        <asp:TextBox ID="textDocumento" runat="server"  CssClass="texto2"></asp:TextBox></td><td class="separador">
                    </td>
                    <td>
                        <asp:Label ID="labelEmail" runat="server" Text="E mail"
                            CssClass="label"></asp:Label></td><td>
                        <asp:TextBox ID="textEmail" runat="server"  CssClass="texto2"></asp:TextBox></td></tr><tr>
                    <td>
                        <asp:Label ID="labelDireccion" runat="server" Text="Dirección"
                         CssClass="label"></asp:Label></td><td>
                        <asp:TextBox ID="textDireccion" runat="server"  CssClass="texto2"></asp:TextBox></td><td class="separador">
                    </td>
                    <td>
                        <asp:Label ID="labelTeléfono" runat="server" Text="Teléfono"
                            CssClass="label"></asp:Label></td><td>
                        <asp:TextBox ID="textTelefono" runat="server"  CssClass="texto2"></asp:TextBox></td>
                    </tr>
                <tr>
                    <td colspan="5">
                        &nbsp;&nbsp;
                        <asp:Button ID="buttonGuardarTercero" runat="server" CssClass="button" 
                        Text="Guardar" onclick="buttonGuardarTercero_Click"  />&nbsp;&nbsp;
                        <asp:Button ID="buttonCancelarTercero" runat="server" Text="Cancelar" 
                            CssClass="button" onclick="buttonCancelarTercero_Click" />
                    </td>
                </tr>
            </table> 
                           
                                </asp:Panel>

                                <div class="divgrillassinmargin" runat="server" id="divgrillabusqueda" visible="false">
                                    <asp:GridView ID="GridViewPersonaBuscar" runat="server" AutoGenerateColumns="False" 
                                         CssClass="grilla"  
                                         FooterStyle-CssClass="footergrilla" HeaderStyle-CssClass="headergrilla" 
                                         RowStyle-CssClass="rowgrilla" SelectedRowStyle-CssClass="selectedgrilla"
                                         Width="649px" 
                                         onrowcommand="GridViewPersonaBuscar_RowCommand" DataKeyNames="Id" 
                                        AllowPaging="True" PageSize="15" 
                                        DataSourceID="actividadesRegistrarDataSourcePersonaBuscar">
                                         <RowStyle CssClass="rowgrilla" />
                                         <Columns>
                                         <asp:ButtonField ButtonType="Button" CommandName="Seleccionar" ShowHeader="True" 
                                         Text="Seleccionar">
                                        <ControlStyle CssClass="buttongrilla" Width="100px" />
                                        </asp:ButtonField>
                                        <asp:BoundField DataField="TipoDocumento" HeaderText="Tipo documento" 
                                        SortExpression="TipoDocumento" />
                                        <asp:BoundField DataField="NumeroDocumento" HeaderText="Número documento" 
                                        SortExpression="NumeroDocumento" />
                                        <asp:BoundField DataField="Nombre" HeaderText="Nombre" 
                                        SortExpression="Nombre" />
                                        <asp:BoundField DataField="Email" HeaderText="Email" 
                                        SortExpression="Email" />
                                        <asp:BoundField DataField="Id" HeaderText="Id" />
                                        </Columns>
                                        <FooterStyle CssClass="footergrilla" />
                                        <SelectedRowStyle CssClass="selectedgrilla" />
                                        <HeaderStyle CssClass="headergrilla" />
                                        </asp:GridView>
                                    <asp:SqlDataSource ID="actividadesRegistrarDataSourcePersonaBuscar" 
                                        runat="server" 
                                        ConnectionString="<%$ ConnectionStrings:BDUTOConnectionString %>" 
                                        SelectCommand="exec [cer].[spTecnicosBuscarActividad] @documento,@nombre,@tipoDocumento">
                                        <SelectParameters>
                                            <asp:Parameter Name="documento" />
                                            <asp:Parameter Name="nombre" />
                                            <asp:Parameter Name="tipoDocumento" />
                                        </SelectParameters>
                                    </asp:SqlDataSource>
                                </div>
    
                                <br />
    
                                    <table runat="server" id="tablePersonasAgregadas" visible="false">
        <tr>
            <th class="subtitulo2">
                <asp:Label ID="labelPersonasAgregadas" runat="server" Text="Personas adicionadas" CssClass="subtitulo" ></asp:Label></th></tr><tr>
            <td>
                <div class="divgrillassinmargin">
                    <asp:GridView ID="GridViewPersonasAdicionadas" runat="server" AutoGenerateColumns="False" 
                        CssClass="grilla"  
                        FooterStyle-CssClass="footergrilla" HeaderStyle-CssClass="headergrilla" 
                        RowStyle-CssClass="rowgrilla" SelectedRowStyle-CssClass="selectedgrilla"
                        Width="649px" DataKeyNames="ter_Id" 
                        onrowcommand="GridViewPersonasAdicionadas_RowCommand" AllowPaging="True" 
                        PageSize="15">
                        <RowStyle CssClass="rowgrilla" />
                        <Columns>
                        <asp:ButtonField ButtonType="Button" Text="Eliminar" 
                        ControlStyle-CssClass="buttongrilla" CommandName="Eliminar" >
                        <ControlStyle CssClass="buttongrilla" />
                        </asp:ButtonField>
                        <asp:BoundField DataField="ter_NumeroDocumento" HeaderText="Documento" 
                        SortExpression="ter_NumeroDocumento" />
                        <asp:BoundField DataField="ter_NombreCompleto" HeaderText="Nombre" 
                        SortExpression="ter_NombreCompleto" />
                        <asp:BoundField DataField="ter_Correo" HeaderText="Email" 
                        SortExpression="ter_Correo" />
                        <asp:BoundField DataField="ter_Id" HeaderText="Id" SortExpression="ter_Id" />
                        </Columns>
                        <FooterStyle CssClass="footergrilla" />
                        <SelectedRowStyle CssClass="selectedgrilla" />
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
                </div>
            </ContentTemplate>
        </asp:UpdatePanel> 
    <div class="divwithoutgrid">        

                <table class="form">
                    <tr>
                        <th colspan="4"> 
                            <asp:Label ID="label6" runat="server" Text="Material entregado" 
                            CssClass="subtitulo"></asp:Label>
                        </th>
                    </tr> 
                    <tr>
                        <td class="style1">
                            <asp:Label ID="label8" runat="server" CssClass="label" 
                                Text="Tipo de material"></asp:Label>
                        </td>
                        <td class="style1">
                            <asp:DropDownList ID="comboMaterial" runat="server" CssClass="combo" DataTextField="acm_Descripcion" 
                                DataValueField="acm_Id" Height="16px" Width="239px">
                            </asp:DropDownList>
                        </td>
                        <td class="style1">
                            <asp:Label ID="label9" runat="server" CssClass="label" 
                                Text="Cantidad"></asp:Label></td><td class="style1">
                            <asp:TextBox ID="textCantidad" runat="server" CssClass="texto2"></asp:TextBox>
                        </td>
                    </tr>                    
                </table>
                <table class="form">        
                <tr>
                    <td>
                        <asp:Button ID="buttonAdicionarmaterial" runat="server" Text="Adicionar" 
                            CssClass="button" onclick="buttonAdicionarmaterial_Click"  />
                    </td>
                </tr>
            </table> 
            </div>
<%--        <asp:UpdatePanel ID="UpdatePanel3" runat="server">
            <ContentTemplate>            --%>
            <div class="divgrillassinmargin">
                <asp:GridView ID="gridMaterial" runat="server" AutoGenerateColumns="False" 
                        CssClass="grilla"  
                        FooterStyle-CssClass="footergrilla" HeaderStyle-CssClass="headergrilla" 
                        RowStyle-CssClass="rowgrilla" SelectedRowStyle-CssClass="selectedgrilla"
                        Width="649px" 
                         AllowPaging="True" 
                        PageSize="15" DataKeyNames="Id" onrowcommand="gridMaterial_RowCommand">
                        <RowStyle CssClass="rowgrilla" />
                        <Columns>
                        <asp:ButtonField ButtonType="Button" Text="Eliminar" 
                        ControlStyle-CssClass="buttongrilla" CommandName="Eliminar" >
                        <ControlStyle CssClass="buttongrilla" />
                        </asp:ButtonField>
                        <asp:BoundField DataField="Material" HeaderText="Material entregado" />
                        <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" />
                        <asp:BoundField DataField="Id" HeaderText="Id" />
                        </Columns>
                        <FooterStyle CssClass="footergrilla" />
                        <SelectedRowStyle CssClass="selectedgrilla" />
                        <HeaderStyle CssClass="headergrilla" />
                     </asp:GridView>            
            </div>                           
<%--            </ContentTemplate>
        </asp:UpdatePanel>--%>
    
    <div class="divsingrilla2">
        <table  class="form">
            <tr>
                <th>
                    <asp:Label ID="label1" runat="server" Text="Documentos" CssClass="subtitulo"></asp:Label></th></tr><tr>
                <td>
                    <uc1:DocumentosVarios ID="DocumentosVarios1" runat="server" />
                </td>
            </tr>
        </table>
    </div>
    
    <div class="divsingrillas3">
        <table>
            <tr>
              <td colspan="5">
                <asp:Button ID="buttonGuardar" runat="server" Text="Guardar" CssClass="button" 
                    onclick="buttonGuardar_Click" />&nbsp;&nbsp;<asp:Button 
                    ID="buttoncancelar" runat="server" Text="Cancelar"  CssClass="button" 
                    onclick="buttoncancelar_Click" />
              </td>
            </tr>
       </table>
    </div>
    
    
    </asp:Content>