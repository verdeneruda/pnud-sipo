    <%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MPMain.Master" CodeBehind="TecnicosVer.aspx.cs" Inherits="UTO.Certificacion.VerTecnicos" %>

    <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
    <asp:Content ID="contentVerTecnicosHead" ContentPlaceHolderID="head" Runat="Server">
    </asp:Content>
    <asp:Content  ID="contentVerTecnicos" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
    <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </cc1:ToolkitScriptManager>
    <div class="divwithoutgrid">
    <table class="titulo" >
    <tr><td>
    <asp:Label ID="labelVerTecnicos" runat="server" Text="Módulo certificación - Ver técnicos" CssClass="subtitulo"></asp:Label>
    </td></tr>
    </table>
    <br />
    <table class="formver">
    <tr>
    <td>
    <table style="width:100%;">
    <tr><th colspan="4">
    <asp:Label ID="labelDatosGenerales" runat="server" Text="Datos generales" CssClass="subtitulo"></asp:Label>
    </th></tr>  
    <tr>
    <td style="width:25%;">
    <asp:Label ID="labelTipoDocumento" runat="server" Text="Tipo documento" CssClass="label"></asp:Label>
    </td><td>
    &nbsp;
    </td>
    <td>
    <asp:Label ID="labelDocumento" runat="server" Text="Documento" CssClass="label"></asp:Label>
    </td>
    <td>
    &nbsp;
    </td>
    </tr>
    <tr>
    <td><asp:Label ID="labelNombre" runat="server" Text="Nombre" CssClass="label"></asp:Label>
    </td>
    <td>&nbsp;</td>
    <td><asp:Label ID="labelDepartamento" runat="server" Text="Departamento" CssClass="label"></asp:Label></td>
    <td>&nbsp;</td>
    </tr>
    <tr>
    <td><asp:Label ID="labelCiudad" runat="server" Text="Ciudad" CssClass="label"></asp:Label></td>
    <td> &nbsp;</td><td><asp:Label ID="labelDireccion" runat="server" Text="Dirección" CssClass="label"></asp:Label></td>
    <td>&nbsp;</td></tr>
    <tr>
    <td>
    <asp:Label ID="labelTelefono" runat="server" Text="Teléfono" CssClass="label"></asp:Label></td><td>
    &nbsp;
    </td>
    <td>
    <asp:Label ID="labelCelular" runat="server" Text="Celular" CssClass="label"></asp:Label></td><td>
    &nbsp;
    </td>
    </tr><tr>
    <td>
    <asp:Label ID="labelEmail" runat="server" Text="E-Mail" CssClass="label"></asp:Label></td><td>
    &nbsp;
    </td>
    <td>
    <asp:Label ID="labelFax" runat="server" Text="Fax" CssClass="label"></asp:Label></td><td>
    &nbsp;
    </td>
    </tr><tr>
    <td>
    <asp:Label ID="labelCargo" runat="server" Text="Cargo" CssClass="label"></asp:Label></td><td>
    &nbsp;
    </td>
    <td>
    <asp:Label ID="labelEmpresa" runat="server" Text="Empresa" CssClass="label"></asp:Label></td><td>
    &nbsp;
    </td>
    </tr>
    <tr>
    <td>
    <asp:Label ID="labelAreaTrabajo" runat="server" Text="Area trabajo" CssClass="label"></asp:Label>
    </td><td>
    &nbsp;
    </td>
    <td>
    <asp:Label ID="labelCTG" runat="server" CssClass="label" Text="CTG"></asp:Label>
    </td>
    <td>
    &nbsp;
    </td>
    </tr>
    <tr>
    <td><asp:Label ID="labelGrupo" runat="server" Text="Grupo" CssClass="label"></asp:Label></td><td>
    &nbsp;</td>
    <td>
    <asp:Label ID="labelFechaCertificacion" runat="server" Text="Fecha certificacion" 
    CssClass="label"></asp:Label>
    </td>
    <td>
    &nbsp;</td>
    </tr>
    <tr>
    <td>
    <asp:Label ID="labelvigencia" runat="server" Text="Vigencia" CssClass="label"></asp:Label>
    </td><td>
    &nbsp;</td>
    <td>
    <asp:Label ID="labelActualizado" runat="server" Text="Está actualizado" 
    CssClass="label"></asp:Label>
    </td>
    <td>
    &nbsp;</td>
    </tr>
    <tr>
    <td>
    <asp:Label ID="labelCarnetizado" runat="server" Text="Está carnetizado" 
    CssClass="label"></asp:Label>
    </td><td>
    &nbsp;</td>
    <td>
    &nbsp;</td>
    <td>
    &nbsp;</td>
    </tr>
    </table>
    </td>
    </tr>
    </table>
    </div>
    <br />
    </asp:Content>