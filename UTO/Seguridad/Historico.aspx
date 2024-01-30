<%@ Page Language="C#" MasterPageFile="~/MPMain.master" AutoEventWireup="true" CodeBehind="Historico.aspx.cs" Inherits="UTO.Seguridad.Historico" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </cc1:ToolkitScriptManager>
    <table class="titulo" >
        <tr>
            <td>
                <asp:Label ID="LabelHistorico" runat="server" Text="Seguridad - Historico" CssClass="subtitulo"></asp:Label>
            </td>
        </tr>
    </table>
    
    <table cellspacing="4" class="form" >
    <tr>
    <td>
    <div style="color:Red;">
    <asp:Label ID="labelError" runat="server"></asp:Label>
    </div>
    </td>
    </tr>
</table>
<br />
<table cellspacing="4" class="form" >
    <tr>
        <td>
            <asp:Label ID="LabelFechaCorte" runat="server" Text="Fecha de corte"></asp:Label>
</td>
<td>
      <asp:TextBox ID="textFechaCorte" runat="server" CssClass="texto2"></asp:TextBox>
        <asp:ImageButton runat="server" ID="ImageFechaCorte" ImageUrl="~/imagenes/boton-calendario.png" />
        <cc1:calendarextender ID="CalendarExtender3" TargetControlID="textFechaCorte" 
                PopupButtonID="ImageFechaCorte" Format="dd/MM/yyyy" runat="server">
        </cc1:calendarextender>
</td>
</tr>
<tr>
<td colspan="2">
    <asp:Button ID="buttonEnviarHistorico" runat="server" 
        Text="Enviar a históricos" onclick="buttonEnviarHistorico_Click" 
        CssClass="button2" />
</td>
</tr>
<tr>
<td colspan="2">
<asp:Label ID="labelmensaje" runat="server"></asp:Label>
</td>
</tr>
</table>
</asp:Content>



