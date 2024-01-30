<%@ Page Title="" Language="C#" MasterPageFile="~/MPMain.Master" AutoEventWireup="true"
    CodeBehind="PaginaError.aspx.cs" Inherits="UTO.PaginaError" %>

<asp:Content  ID="contentSolicitudEquiposBuscar" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
    <script src="Scripts/jquery-1.7.2.min.js" type="text/javascript"></script>
<%--    <script type="text/javascript">
        $(document).ready(function () {
            if (window.validar == null) {
                validar = false;
            }
            $('#<%= linkError.ClientID%>').click(function () {
                if (validar == true) {
                    $('#divError').fadeOut('slow');
                    validar = false;
                } else {
                    $('#divError').fadeIn('slow');
                    validar = true;
                }
                return false;
            });
        });
    </script>--%>
    <table>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Ha ocurrido un error inesperado "></asp:Label>                
                <div id="divError" >
                    <br />
                    <asp:Label ID="labelError" runat="server" Text=""></asp:Label>
                </div>
            </td>
        </tr>
    </table>
</asp:Content>
<%--<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

</asp:Content>--%>