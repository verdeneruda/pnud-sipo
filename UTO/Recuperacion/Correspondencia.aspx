<%@ Page Language="C#" MasterPageFile="~/MPMain.Master"  AutoEventWireup="true" CodeBehind="Correspondencia.aspx.cs" Inherits="UTO.Recuperacion.Correspondencia" %>

    <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

    <asp:Content  ID="contentSolicitudEquiposBuscar" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
    <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </cc1:ToolkitScriptManager>
    <div class="divwithoutgrid">
    <table class="titulo" >
        <tr><td>
        <asp:Label ID="labelBusquedaSolicitudesEquipos" runat="server" Text="Proyectos de dotación de equipos y herramientas  para el sector de refrigeración y aire acondicionado - Correspondencia" CssClass="subtitulo"></asp:Label>
        </td></tr>
    </table>
    <table class="form">
        <tr>
    <td><table style="width:100%">
    <tr>
        <th colspan="4">   
        <asp:Label ID="labelparametros" runat="server" Text="Parámetros Búsqueda" CssClass="subtitulo"></asp:Label>
        </th>
    </tr>
    <tr>
    <td>
    <asp:Label ID="labelRegional" runat="server" Text="Regional" CssClass="label"></asp:Label>
    </td>
    <td>
        <asp:DropDownList ID="comboRegional" runat="server" CssClass="combo" 
            DataTextField="reg_Descripcion" DataValueField="reg_Id">
        </asp:DropDownList>
    </td>
    <td style="width:20%">
        <asp:Label ID="labelNombreBeneficiario" runat="server" Text="Nombre beneficiario" CssClass="label"></asp:Label>
    </td>
    <td>
        <asp:TextBox ID="textNombreBeneficiario" runat="server"  CssClass="texto2" 
            Width="248px"></asp:TextBox>
    </td>
    </tr>
    <tr>
        <td style="width:20%">
            <asp:Label ID="labelDepartamento" runat="server" Text="Departamento" 
                CssClass="label"></asp:Label>
        </td>
        <td>
        <asp:DropDownList ID="comboDepartamento" runat="server" CssClass="combo" 
                DataTextField="dep_Descripcion" DataValueField="dep_Id" 
                onselectedindexchanged="comboDepartamento_SelectedIndexChanged" 
                AutoPostBack="True">
        </asp:DropDownList>
        </td>
        <td style="width:20%">
            <asp:Label ID="labelCiudad" runat="server" Text="Ciudad" CssClass="label"></asp:Label>
        </td>
        <td>
        <asp:DropDownList ID="comboCiudad" runat="server" CssClass="combo" 
                DataTextField="mun_Descripcion" DataValueField="mun_Id">
        </asp:DropDownList>
        </td>
     </tr>
    <tr>
        <td style="width:20%">
    <asp:Button ID="buttonBuscar" runat="server" Text="Buscar" CssClass="button" 
            onclick="buttonBuscar_Click" />
        </td>
        <td>
            <asp:CheckBox ID="CheckSeleccionarTodos" runat="server" 
                Text="Seleccionar todos" AutoPostBack="True" 
                oncheckedchanged="CheckSeleccionarTodos_CheckedChanged" />
        </td>
        <td colspan="2">
            &nbsp;</td>
     </tr>
    <tr>
        <td colspan="4">
                                         <asp:GridView ID="gridCorrespondencia" runat="server" 
                                             AutoGenerateColumns="False" 
                                             FooterStyle-CssClass="footergrilla" HeaderStyle-CssClass="headergrilla" 
                                             RowStyle-CssClass="rowgrilla" Width="667px" 
                                             DataKeyNames="tipoDocumento,ter_NumeroDocumento,ter_NombreCompleto,dep_descripcion,mun_Descripcion,ter_Correo,ter_Celular,ter_Tefono">
                                             <RowStyle CssClass="rowgrilla" />
                                             <Columns>
                                                 <asp:TemplateField>
                                                 <ItemTemplate>
                                                     <asp:CheckBox ID="CheckBeneficiario" runat="server" />
                                                 </ItemTemplate>
                                                 </asp:TemplateField>
                                                 <asp:BoundField DataField="TipoDocumento" HeaderText="Tipo documento" />
                                                 <asp:BoundField DataField="ter_NumeroDocumento" HeaderText="Documento" />
                                                 <asp:BoundField DataField="ter_NombreCompleto" 
                                                     HeaderText="Nombre del beneficiario" />
                                                 <asp:BoundField DataField="dep_descripcion" HeaderText="Departamento" />
                                                 <asp:BoundField DataField="mun_Descripcion" HeaderText="Municipio" />
                                                 <asp:BoundField DataField="ter_Correo" HeaderText="Correo" />
                                                 <asp:BoundField DataField="ter_Celular" HeaderText="Celular" />
                                                 <asp:BoundField DataField="ter_Tefono" HeaderText="Teléfono" />
                                             </Columns>
                                             <FooterStyle CssClass="footergrilla" />
                                             <HeaderStyle CssClass="headergrilla" />
                                         </asp:GridView>
        </td>
     </tr>
    <tr>
    <td colspan="4">
                                         <asp:GridView ID="gridExportar" runat="server" 
                                             AutoGenerateColumns="False" 
                                             FooterStyle-CssClass="footergrilla" HeaderStyle-CssClass="headergrilla" 
                                             RowStyle-CssClass="rowgrilla" 
            Width="667px">
                                             <RowStyle CssClass="rowgrilla" />
                                             <Columns>
                                                 <asp:BoundField DataField="tipoDocumento" HeaderText="Tipo documento" />
                                                 <asp:BoundField DataField="documento" HeaderText="Documento" />
                                                 <asp:BoundField DataField="nombreBeneficiario" 
                                                     HeaderText="Nombre del beneficiario" />
                                                 <asp:BoundField DataField="departamento" HeaderText="Departamento" />
                                                 <asp:BoundField DataField="municipio" HeaderText="Municipio" />
                                                 <asp:BoundField DataField="correo" HeaderText="Correo" />
                                                 <asp:BoundField DataField="celular" HeaderText="Celular" />
                                                 <asp:BoundField DataField="telefono" HeaderText="Teléfono" />
                                             </Columns>
                                             <FooterStyle CssClass="footergrilla" />
                                             <HeaderStyle CssClass="headergrilla" />
                                         </asp:GridView>
        </td>
    </tr>
    <tr>
    <td colspan="4">
    <asp:Button ID="buttonExportar" runat="server" Text="Exportar" CssClass="button" 
            onclick="buttonExportar_Click" />&nbsp;&nbsp;
    <asp:Button ID="buttonCancelar" runat="server" Text="Cancelar"  
            CssClass="button" onclick="buttonCancelar_Click"/>
    </td>
    </tr>
    </table>
    </td>
    </tr>
        <tr>
    <td>&nbsp;</td>
    </tr>
    </table>
    </div>
    <br />
    <div class="divgrillas">
    </div>
    <br />
    </asp:Content>
