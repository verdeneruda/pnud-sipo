
    <%@ Page Language="C#"  MasterPageFile="~/MPMain.Master" AutoEventWireup="true" CodeBehind="EmpresasRegistrar.aspx.cs" Inherits="UTO.Certificacion.EmpresasRegistrar" %>
    <%@ Register src="../Comunes/ControlError.ascx" tagname="ControlError" tagprefix="uc2" %>
    <asp:Content ID="contentRegistrarEmpresasHead" ContentPlaceHolderID="head" Runat="Server">
    </asp:Content>
    <asp:Content  ID="contentRegistrarEmpresas" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    <div class="divwithoutgrid">
    <table class="titulo" >
    <tr><td>
    <asp:Label ID="labelRegistarEmpresas" runat="server" Text="Módulo certificación - Adicionar empresas" CssClass="subtitulo"></asp:Label>
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
    <asp:Panel ID="panelEmpresa" runat="server">
        
    <table class="form">
    <tr>
    <th colspan="5">
    <asp:Label ID="labelDatosGenerales" runat="server" Text="Datos generales" CssClass="subtitulo"></asp:Label>
    </th></tr>
    <tr><td>
    <asp:Label ID="labelNit" runat="server" Text="Nit" CssClass="label"></asp:Label>&nbsp
        <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>
    </td>
    <td> 
    <asp:TextBox ID="textNit" runat="server"  CssClass="texto2"></asp:TextBox>
    </td>
    <td class="separador"></td>
    <td>
    <asp:Label ID="labelNombre" runat="server" Text="Nombre o razón social" 
            CssClass="label"></asp:Label>&nbsp
    <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>       
    </td>
    <td> 
    <asp:TextBox ID="textNombre" runat="server"  CssClass="texto2"></asp:TextBox>
    </td>
    </tr> 
    <tr>
    <td>
    <asp:Label ID="labelDepartamento" runat="server" Text="Departamento" CssClass="label"></asp:Label>&nbsp
    <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>
    
    </td>
    <td>
    <asp:DropDownList ID="comboDepartamento" runat="server" CssClass="combo" DataTextField="dep_Descripcion" 
    DataValueField="dep_Id" AutoPostBack="True" 
            onselectedindexchanged="comboDepartamento_SelectedIndexChanged">
    </asp:DropDownList>
    </td>
    <td class="separador"></td>
    <td><asp:Label ID="labelCiudad" runat="server" Text="Ciudad" CssClass="label"></asp:Label>&nbsp;
    <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>
    </td>
    <td>
    <asp:UpdatePanel runat="server" UpdateMode="Conditional" ID="updateCiudad">
    <ContentTemplate>
    <asp:DropDownList ID="comboCiudad" runat="server" CssClass="combo" 
            DataTextField="mun_Descripcion" DataValueField="mun_Id">
    </asp:DropDownList>
    </ContentTemplate>
    <Triggers>
    <asp:AsyncPostBackTrigger ControlID="comboDepartamento" />
    </Triggers>
    </asp:UpdatePanel>     
    </td>
    </tr><tr>
    <td>
        <asp:Label ID="labelDireccion" runat="server" Text="Dirección" CssClass="label"></asp:Label>&nbsp
        <asp:Label ID="Label1" runat="server" Text="(*)" Font-Bold="true"></asp:Label>
    </td>
    <td> 
    <asp:TextBox ID="textDireccion" runat="server" CssClass="texto2"></asp:TextBox> </td>
    <td class="separador">
    </td>
    <td>
        <asp:Label ID="labelTelefono" runat="server" Text="Teléfono" CssClass="label"></asp:Label>&nbsp
        <asp:Label ID="Label2" runat="server" Text="(*)" Font-Bold="true"></asp:Label>
    </td>
    <td> 
    <asp:TextBox ID="textTelefono" runat="server" CssClass="texto2"></asp:TextBox>
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
    <asp:Label ID="labelEmail" runat="server" Text="E-Mail" CssClass="label"></asp:Label>
    </td>
    <td>
    <asp:TextBox ID="textEmail" runat="server" CssClass="texto2"></asp:TextBox>
    </td>
    </tr>
    <tr>
    <td>
        <asp:Label runat="server" ID="labelCTG" Text="CTG" CssClass="label"></asp:Label>&nbsp
        <asp:Label ID="Label3" runat="server" Text="(*)" Font-Bold="true"></asp:Label>
    </td>
    <td colspan="4">
    <asp:CheckBoxList ID="checkboxlistCTG" runat="server" CssClass="listcheck" 
            DataTextField="cat_Descripcion" DataValueField="cat_Id">

    <asp:ListItem></asp:ListItem>

    </asp:CheckBoxList>
    </td>
    </tr>
    <tr>
    <td colspan="5">
            <asp:Button ID="buttonGuardar" runat="server" Text="Guardar" CssClass="button" 
                onclick="buttonGuardar_Click" />&nbsp;&nbsp;<asp:Button 
        ID="buttoncancelar" runat="server" Text="Cancelar"  CssClass="button" 
        onclick="buttoncancelar_Click"/>
    </td>
    </tr>
    </table>
    </asp:Panel>
    </div>
    <br />
    </asp:Content>