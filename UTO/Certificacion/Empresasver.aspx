    <%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MPMain.Master" CodeBehind="Empresasver.aspx.cs" Inherits="UTO.Certificacion.verEmpresas" %>
    <asp:Content ID="contentVerEmpresasHead" ContentPlaceHolderID="head" Runat="Server">
    </asp:Content>
    <asp:Content  ID="contentVerEmpresas" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
        <div class="divwithoutgrid">
    <table class="titulo" >
    <tr><td>
    <asp:Label ID="labelVerEmpresas" runat="server" Text="Módulo certificación - Ver empresas" CssClass="subtitulo"></asp:Label>
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
    <tr><td><asp:Label runat="server" ID="labelCTG" Text="CTG" CssClass="label"></asp:Label></td>
    <td>&nbsp;</td>
    <td>
    <asp:Label ID="labelNit" runat="server" Text="Nit" CssClass="label"></asp:Label>
        </td><td> 
    &nbsp;</td>
    </tr> 
    <tr>
    <td>
        <asp:Label ID="labelNombre" runat="server" Text="Nombre o razon social" CssClass="label"></asp:Label>
    </td>
    <td>
    &nbsp;
    </td>
    <td><asp:Label ID="labelDepartamento" runat="server" Text="Departamento" CssClass="label"></asp:Label></td>
    <td>&nbsp;</td>
    </tr><tr>
    <td><asp:Label ID="labelCiudad" runat="server" Text="Ciudad" CssClass="label"></asp:Label></td>
    <td>&nbsp;</td>
    <td><asp:Label ID="labelDireccion" runat="server" Text="Dirección" CssClass="label"></asp:Label> </td>
    <td> 
    &nbsp;</td>
    </tr><tr>
    <td>
    <asp:Label ID="labelTelefono" runat="server" Text="Teléfono" CssClass="label"></asp:Label>
            </td>
    <td> &nbsp; </td>
    <td>
    <asp:Label ID="labelFax" runat="server" Text="Fax" CssClass="label"></asp:Label>
    </td>
    <td>
    &nbsp;
    </td>
    </tr><tr>
    <td>
    <asp:Label ID="labelEmail" runat="server" Text="E-Mail" CssClass="label"></asp:Label>
            </td>
    <td>&nbsp;</td>
    <td>
    <asp:Label ID="labelNumeroEstimado" runat="server" Text="Número estimado" CssClass="label"></asp:Label>
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

    </asp:Content>