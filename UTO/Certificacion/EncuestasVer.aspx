    <%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MPMain.Master" CodeBehind="EncuestasVer.aspx.cs" Inherits="UTO.Certificacion.VerEncuestas" %>
    <asp:Content ID="contentVerEncuestaHead" ContentPlaceHolderID="head" Runat="Server">
    </asp:Content>
    <asp:Content  ID="contentVerEncuesta" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
    <div class="divwithoutgrid">
    <table class="titulo" >
    <tr><td>
    <asp:Label ID="labelVerEncuesta" runat="server" Text="Módulo certificación - Ver encuesta" CssClass="subtitulo"></asp:Label>
    </td></tr>
    </table>
    <br />
    <table class="formver">
    <tr>
    <td>
    <table style="width:100%;">
    <tr><th colspan="5">
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
    &nbsp;
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
