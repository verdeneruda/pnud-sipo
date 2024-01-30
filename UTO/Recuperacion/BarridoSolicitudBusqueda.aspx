<%@ Page Language="C#" MasterPageFile="~/MPMain.Master" AutoEventWireup="true" CodeBehind="BarridoSolicitudBusqueda.aspx.cs" Inherits="UTO.Recuperacion.BarridoSolicitudBusqueda" %>
    <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

    <%@ Register src="../Comunes/ControlError.ascx" tagname="ControlError" tagprefix="uc1" %>

    <asp:Content  ID="contentSolicitudEquiposBuscar" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
    <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </cc1:ToolkitScriptManager>
        <div class="divwithoutgrid">
    <table class="titulo" >
        <tr><td>
        <asp:Label ID="labelBusquedaSolicitudesEquipos" runat="server" Text="Kit de Barrido y Limpieza con Nitrógeno y Filtros de Alto Rendimiento - Eliminación del R-141b en Actividades de Limpieza  - Buscar solicitud equipos" CssClass="subtitulo"></asp:Label>
        </td></tr>
    </table>
    </div>
    </asp:Content>