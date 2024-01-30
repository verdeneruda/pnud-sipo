    <%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MPMain.Master"  CodeBehind="TecnicosCertificadosVer.aspx.cs" Inherits="UTO.Certificacion.VerTecnicosCertificados" %>
    <asp:Content ID="contentVerTecnicosCertificadosHead" ContentPlaceHolderID="head" Runat="Server">
    </asp:Content>
    <asp:Content  ID="contentVerTecnicosCertificados" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
    <div class="divwithoutgrid">
    <table class="titulo" >
    <tr><td>
    <asp:Label ID="labelVerCertificados" runat="server" Text="Módulo certificación - Ver técnicos certificados" CssClass="subtitulo"></asp:Label>
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
    <tr><td><asp:Label runat="server" ID="labelCU" Text="CU" CssClass="label"></asp:Label></td>
    <td>&nbsp;</td>
    <td><asp:Label runat="server" ID="labelCTG" Text="CTG" CssClass="label"></asp:Label></td><td> 
    &nbsp;</td>
    </tr>    
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
    <td> &nbsp;</td><td><asp:Label ID="labelGrupo" runat="server" Text="Grupo" CssClass="label"></asp:Label></td>
    <td>&nbsp;</td></tr>
    <tr>
    <td><asp:Label ID="labelDireccion" runat="server" Text="Dirección" CssClass="label"></asp:Label></td><td>
    &nbsp;
    </td>
    <td>
    <asp:Label ID="labelTelefono" runat="server" Text="Teléfono" CssClass="label"></asp:Label></td><td>
    &nbsp;
    </td>
    </tr><tr>
    <td><asp:Label ID="labelCelular" runat="server" Text="Celular" CssClass="label"></asp:Label></td><td>
    &nbsp;
    </td>
    <td>
    <asp:Label ID="labelEmail" runat="server" Text="E-Mail" CssClass="label"></asp:Label></td><td>
    &nbsp;
    </td>
    </tr><tr>
    <td>
    <asp:Label ID="labelFax" runat="server" Text="Fax" CssClass="label"></asp:Label></td><td>
    &nbsp;
    </td>
    <td>
    <asp:Label ID="labelCargo" runat="server" Text="Cargo" CssClass="label"></asp:Label></td><td>
    &nbsp;
    </td>
    </tr>
    <tr>
    <td><asp:Label ID="labelEmpresa" runat="server" Text="Empresa" CssClass="label"></asp:Label></td><td>
    &nbsp;
    </td>
    <td>
    <asp:Label ID="labelFecha" runat="server" Text="Fecha" CssClass="label"></asp:Label>
    </td>
    <td>
    &nbsp;
    </td>
    </tr>
    <tr>
    <td>
    <asp:Label ID="labelVigencia" runat="server" Text="Vigencia" CssClass="label"></asp:Label>
    </td>
    <td>
    &nbsp;
    </td>
    <td>
    <asp:Label ID="labelSeActualizado" runat="server" Text="Está actualizado" CssClass="label"></asp:Label>
    </td>
    <td>
    &nbsp;
    </td>
    </tr>
    <tr>
    <td>
    <asp:Label ID="labelCarnetizado" runat="server" Text="Está carnetizado" CssClass="label"></asp:Label>
    </td>
    <td>
    &nbsp;
    </td>
    <td  class="separador" >
    </td>
    <td>
    &nbsp;
    </td>
    </tr>
    </table>
    </td>
    </tr>
    </table>
    </div>
    <br />
    </asp:Content>