    <%@ Page Language="C#" MasterPageFile="~/MPMain.Master" AutoEventWireup="true" CodeBehind="ImportadoresRegistrar.aspx.cs" Inherits="UTO.RegistrosUso.ImportadoresRegistrar" %>

    <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
    <%@ Register src="../Comunes/ControlError.ascx" tagname="ControlError" tagprefix="uc2" %>
    <asp:Content ID="contentRegistrarRegistroUsoImportadoresHead" ContentPlaceHolderID="head" Runat="Server">
    </asp:Content>
    <asp:Content  ID="contentRegistrarRegistroUsoImportadores" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
    <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </cc1:ToolkitScriptManager>
    <div class="divwithoutgrid">
    <table class="titulo" >
    <tr><td>
    <asp:Label ID="labelRegistrarRegistrosUsoImportadores" runat="server" Text="Módulo registro de usos - Adicionar registros reportados por importadores" CssClass="subtitulo"></asp:Label>
    </td></tr>
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
    <td><table style="width:100%">
    <tr><th colspan="5">
     <asp:Label ID="labelDatosGenerales" runat="server" Text="Datos generales" CssClass="subtitulo"></asp:Label>
    </th></tr>
    <tr>
    <td>
    <asp:Label ID="labelImportador" runat="server" Text="Importador" CssClass="label"></asp:Label>&nbsp
        <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>
    </td>
    <td>
    <asp:DropDownList ID="comboImportador" runat="server"  CssClass="combo"
            DataTextField="ter_NombreCompleto" DataValueField="ter_Id">
    </asp:DropDownList>
    </td>
    <td class="separador">
    </td>
    <td>
    <asp:Label ID="labelAño" runat="server" Text="Año" CssClass="label"></asp:Label>&nbsp
        <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>
    </td>
    <td>
    <asp:TextBox ID="textAño" runat="server" CssClass="texto2"></asp:TextBox>
    </td>
    </tr>
    </table>
    </td>
    </tr>
    </table>
    </div>
    <br />
    <!--table collapsible -->
    <div class="divwithoutgrid">
    <table class="formColapsable" >
    <tr>
    <td class="tdCollap">
    <!-- panel colapsable de contactos -->
    <asp:LinkButton ID="linkEmpresas" runat="server" CssClass="lnbCollap" Height="18px">
     <div>
    <div style="float:left">Clientes</div>
    <div style="float: right; vertical-align: middle;">
    <asp:ImageButton ID="imageEmpresas" runat="server" ImageUrl="~/images/fl_abajo.jpg" AlternateText="Mostrar detalles" />
    </div>
    </div>
    </asp:LinkButton> 
    <cc1:CollapsiblePanelExtender ExpandedImage="~/images/fl_arriba.jpg"  CollapsedImage="~/images/fl_abajo.jpg" ImageControlID="imageSustancias" ID="colapsibleEmpresas" SuppressPostBack="true" ExpandControlID="linkEmpresas" runat="server" TargetControlID="panelEmpresas" CollapseControlID="linkEmpresas" Collapsed="true" >
    </cc1:CollapsiblePanelExtender>   
    </td>
    </tr>
    <tr>
    <td>
    <asp:Panel runat="server" ID="panelEmpresas">           
    <asp:Button ID="buttonAgregar" runat="server" Text="Adicionar" CssClass="button" />       
    <div class="divgrillasscrollcollapsible" style="max-height:400px;">
        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
        <ContentTemplate>
    <asp:GridView ID="gridDetalle" runat="server"  AutoGenerateColumns="False" 
    CssClass="grilla" RowStyle-CssClass="rowgrilla" 
    HeaderStyle-CssClass="headergrilla" FooterStyle-CssClass="footergrilla" 
            onrowcommand="gridDetalle_RowCommand" DataKeyNames="id">
    <RowStyle CssClass="rowgrilla" />
    <Columns>
    <asp:ButtonField ButtonType="Button" CommandName="Eliminar" 
            ControlStyle-CssClass="buttongrilla" Text="Eliminar" >
        <ControlStyle CssClass="buttongrilla" />
        </asp:ButtonField>
    <asp:BoundField DataField="cliente" HeaderText="Cliente" 
    SortExpression="cliente" />
    <asp:BoundField DataField="sustancia" HeaderText="Sustancia" 
    SortExpression="sustancia" />
    <asp:BoundField DataField="cantidad" HeaderText="Cantidad (kg)" 
    SortExpression="cantidad" />
    <asp:BoundField DataField="aplicacion" HeaderText="Aplicación" 
    SortExpression="aplicacion" />
        <asp:BoundField DataField="id" HeaderText="Id" SortExpression="id" />
    </Columns>
    <FooterStyle CssClass="footergrilla" />
    <HeaderStyle CssClass="headergrilla" />
    </asp:GridView>
    </ContentTemplate>
        </asp:UpdatePanel>
    </div>
    </asp:Panel>
    </td>    
    </tr>
    </table>
    </div> 
    <br />
    <table>
    <tr>
    <td>
    &nbsp;&nbsp;&nbsp;<asp:Button ID="buttonGuardar" runat="server" Text="Guardar" 
            CssClass="button" onclick="buttonGuardar_Click" />&nbsp;&nbsp;<asp:Button 
    ID="buttoncancelar" runat="server" Text="Cancelar"  CssClass="button" 
    onclick="buttoncancelar_Click"/>
    </td>
    </tr>
    </table>   
        <cc1:ModalPopupExtender ID="ModalPopupExtender1" runat="server"
        TargetControlID="buttonAgregar"
        BackgroundCssClass="FondoAplicacion"
        PopupControlID="panelAddEmpresas"
        CancelControlID="buttonCancelarEmpresa"
        />        
    <asp:Panel ID="panelAddEmpresas" runat="server" style="display:none">
        <asp:UpdatePanel ID="UpdatePanel3" runat="server" >
        <ContentTemplate>
    <table class="form" >
        <tr>
            <td>
                <uc2:ControlError ID="ControlError2" runat="server" />
            </td>
        </tr>
    </table>           
        <table class="form" >
        <tr>
            <th colspan="2">Cliente
            </th>
        </tr>
        <tr>
            <td colspan="2">&nbsp;
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="labelCliente" runat="server" Text="Cliente" CssClass="label"></asp:Label>&nbsp;
                <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>
            </td>
            <td>
                 <asp:DropDownList ID="comboCliente" CssClass="combo" runat="server" 
                    DataTextField="ter_NombreCompleto" DataValueField="ter_Id">
                 </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="labelSustancia" runat="server" Text="Sustancia" 
                    CssClass="label"></asp:Label>&nbsp;
                <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>  
            </td>
            <td>
                <asp:DropDownList ID="comboSustancia" CssClass="combo" runat="server" 
                    DataTextField="sus_Descripcion" DataValueField="sus_Id">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="labelCantidad" runat="server" Text="Cantidad (kg)" 
                    CssClass="label"></asp:Label>&nbsp
                    <asp:Label ID="Label1" runat="server" Text="(*)" Font-Bold="true"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="textCantidad" runat="server" CssClass="texto2"></asp:TextBox>
                
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="labelAplicacion" runat="server" Text="Aplicación" 
                    CssClass="label"></asp:Label>&nbsp
                <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>  
            </td>
            <td>
                <asp:DropDownList ID="comboAplicacion" CssClass="combo" runat="server" 
                    DataTextField="apl_Descripcion" DataValueField="apl_Id">
                </asp:DropDownList>
            </td>
        </tr>    
        <tr>
            <td>
                <asp:Label ID="labelDepartamento" runat="server" Text="Departamento" 
                    CssClass="label"></asp:Label>&nbsp
                <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label> 
            </td>
            <td>
                 <asp:DropDownList ID="comboDepartamento" runat="server" CssClass="combo" DataTextField="dep_Descripcion" 
                    DataValueField="dep_Id" AutoPostBack="True" 
                    onselectedindexchanged="comboDepartamento_SelectedIndexChanged">
                 </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="labelCiudad" runat="server" Text="Ciudad" CssClass="label"></asp:Label>&nbsp
                <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="comboCiudad" runat="server" CssClass="combo" 
                    DataTextField="mun_Descripcion" DataValueField="mun_Id">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="buttonEnviarEmpresa0" runat="server" Text="Guardar" 
                    CssClass="button" onclick="buttonEnviarEmpresa_Click" />&nbsp;&nbsp;<asp:Button 
                    ID="buttonCancelarEmpresa" runat="server" Text="Cancelar"  CssClass="button" 
                    onclick="buttonCancelarEmpresa_Click"  />
            </td>
        </tr>
    </table>
        </ContentTemplate>
        </asp:UpdatePanel>
    </asp:Panel>
   
    </asp:Content>