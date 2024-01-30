<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DocumentosVarios.ascx.cs" Inherits="UTO.Comunes.DocumentosVarios" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<link rel="stylesheet" href="//code.jquery.com/ui/1.11.3/themes/smoothness/jquery-ui.css">
<script src="//code.jquery.com/jquery-1.10.2.js"></script>
<script src="//code.jquery.com/ui/1.11.3/jquery-ui.js"></script>
<script src="http://jqueryvalidation.org/files/dist/additional-methods.min.js"></script>

<table class="form">
    <tr>
        <td colspan="4">
            <asp:Label ID="labelError" runat="server"
                Text=""></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="labelAsuntoDocumento" runat="server"
                Text="Asunto del documento"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TextAsunto" runat="server" Width="203px" CssClass="texto2"></asp:TextBox>
        </td>
        <td>
            <asp:Label ID="labelFechaDocumento" runat="server" Text="Fecha"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="textFecha" runat="server" CssClass="texto2" Width="96px"></asp:TextBox>
            <cc1:CalendarExtender ID="calendarfecha" Format="dd/MM/yyyy"
                runat="server" CssClass="calendar" TargetControlID="textFecha">
            </cc1:CalendarExtender>
        </td>
    </tr>
</table>

<table class="form">
    <tr>
        <td>
            <asp:FileUpload ID="FileUpload1" runat="server" CssClass="button" />
        </td>
    </tr>
    <tr>
        <td colspan="4">
            <asp:Button ID="buttonAdicionar" runat="server" Text="Agregar"
                OnClick="buttonAdicionar_Click" CssClass="button" />
        </td>
    </tr>
    <tr>
        <td colspan="4">
            <asp:GridView ID="gridDocumentos" runat="server" CssClass="grilla"
                HeaderStyle-CssClass="headergrilla" RowStyle-CssClass="rowgrilla" AutoGenerateColumns="False"
                SelectedRowStyle-CssClass="selectedgrilla"
                FooterStyle-CssClass="footergrilla" Width="531px"
                OnRowCommand="gridDocumentos_RowCommand" AllowPaging="True" PageSize="15"
                DataKeyNames="Id">
                <RowStyle CssClass="rowgrilla"></RowStyle>
                <Columns>
                    <asp:ButtonField ButtonType="Button" CommandName="Eliminar" Text="Eliminar">
                        <ControlStyle CssClass="buttongrilla" />
                    </asp:ButtonField>
                    <asp:ButtonField ButtonType="Button" CommandName="Ver" Text="Ver">
                        <ControlStyle CssClass="buttongrilla" />
                    </asp:ButtonField>
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="Asunto" HeaderText="Asunto" />
                    <asp:BoundField DataField="Fecha" HeaderText="Fecha" />
                    <asp:BoundField DataField="Id" HeaderText="Id" Visible="False" />
                </Columns>

                <FooterStyle CssClass="footergrilla"></FooterStyle>

                <SelectedRowStyle CssClass="selectedgrilla"></SelectedRowStyle>

                <HeaderStyle CssClass="headergrilla"></HeaderStyle>
            </asp:GridView>
        </td>
    </tr>
</table>
