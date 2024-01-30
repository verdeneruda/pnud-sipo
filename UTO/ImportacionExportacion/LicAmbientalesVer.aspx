    <%@ Page Language="C#" MasterPageFile="~/MPMain.Master" AutoEventWireup="true" CodeBehind="LicAmbientalesVer.aspx.cs" Inherits="UTO.ImportacionExportacion.LicAmbientalesVer" %>
    <asp:Content ID="contentImportacionExportacionLicAmbientalesVerHead" ContentPlaceHolderID="head" Runat="Server">
    </asp:Content>
    <asp:Content  ID="contentImportacionExportacionLicAmbientalesVer" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
    <div class="divwithoutgrid">
    <table class="titulo" >
    <tr><td>
    <asp:Label ID="labelVerLicenciasAmbientales" runat="server" Text="Mòdulo importación y exportación - Ver licencias medio ambientales" CssClass="subtitulo"></asp:Label>
    </td></tr>
    </table>
    <br />
    <table class="formver">
    <tr>
    <td><table style="width:100%">
    <tr><th colspan="5">
    <asp:Label ID="labelparametros" runat="server" Text="Datos generales" CssClass="subtitulo"></asp:Label>
    </th></tr>
    <tr>
    <td>
    <asp:Label ID="labelEmpresa" runat="server" Text="Empresa" CssClass="label"></asp:Label>
    </td>
    <td>
    Aireflex de Colombia Ltda.
    </td>
    <td>
    <asp:Label ID="labelfecha" runat="server" Text="Fecha" CssClass="label"></asp:Label>
    </td>
    <td>
    08/09/2010
    </td>
    </tr>
    <tr>
    <td>
    <asp:Label ID="labelImportaHCFC" runat="server" Text="Importa HCFC" CssClass="label"></asp:Label>
    </td>
    <td>
    Si
    </td>
    <td>
    <asp:Label ID="labelImportaHFC" runat="server" Text="Importa HFC" CssClass="label"></asp:Label>
    </td>
    <td>
    Si
    </td>
    </tr>
    <tr>
    <td>
    <asp:Label ID="labelResolucion" runat="server" Text="Resolución" CssClass="label"></asp:Label>
    </td>
    <td>
    15854
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