<%@ Page Title="" Language="C#" MasterPageFile="~/MPMain.Master" AutoEventWireup="true" CodeFile="RegistroExportacionCargue.aspx.cs" Inherits="ImportacionExportacion_RegistroExportacionCargue" %>

 <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
 <%@ Register src="../Comunes/ControlError.ascx" tagname="ControlError" tagprefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></cc1:ToolkitScriptManager>
  <div class="divwithoutgrid">
      <table class="titulo">
          <tr>
              <td>
                  <asp:Label ID="labelAdicionarEncuesta" runat="server" Text="Módulo de seguimiento al comercio local de SAO - Impotar datos de registro de exportación" CssClass="subtitulo"></asp:Label>
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
              <th colspan="5">
                  <asp:Label ID="labelDatosGenerales" runat="server" Text="Archivo para Importar Datos" CssClass="subtitulo"></asp:Label>
              </th>
          </tr>
          <tr>
              <td style="width: 20%">
                  <asp:Label ID="labelNit" runat="server" Text="Seleccione el archivo" CssClass="label"></asp:Label>
              </td>
              <td>
                  <asp:FileUpload ID="fluArchivoCargue" runat="server" />
              </td>
          </tr>
          <tr>
              <td colspan="2">
                  <asp:Label ID="labelResult" runat="server" CssClass="label"></asp:Label>
              </td>
          </tr>
          <tr>
              <td colspan="5">
                  <asp:Button ID="buttonProcesarArchivo" runat="server" Text="Procesar" CssClass="button" OnClick="buttonProcesarArchivo_Click" />&nbsp;&nbsp;
                  <asp:Button ID="buttonCancelar" runat="server" Text="Cancelar" CssClass="button" OnClick="buttonCancelar_Click" />&nbsp;&nbsp;
                  
              </td>
          </tr>
      </table>  
      </div>
</asp:Content>

