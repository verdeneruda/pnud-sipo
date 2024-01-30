<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MPMain.Master" CodeBehind="ActividadesVer.aspx.cs" Inherits="UTO.Certificacion.VerActividades" %>

<%@ Register Src="../Comunes/DocumentosVarios.ascx" TagName="DocumentosVarios" TagPrefix="uc1" %>
<asp:Content ID="contentVerActividadesHead" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="contentVerActividades" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="divwithoutgrid">
        <table class="titulo">
            <tr>
                <td>
                    <asp:Label ID="labelRegistarActividades" runat="server" Text="Módulo certificación - Ver actividades" CssClass="subtitulo"></asp:Label>
                </td>
            </tr>
        </table>

        <br />
        <asp:Button ID="buttonVolver" runat="server" Text="Volver" OnClick="buttonVolver_Click" CssClass="button"/>
        <table class="formver">
            <tr>
                <td>
                    <table style="width: 100%;">
                        <tr>
                            <th colspan="4">
                                <asp:Label ID="labelDatosGenerales" runat="server" Text="Datos generales" CssClass="subtitulo"></asp:Label>
                            </th>
                        </tr>
                        <tr>
                            <td style="width: 25%;">
                                <asp:Label ID="labelFechaActividad" runat="server" Text="Fecha" CssClass="label"></asp:Label>
                            </td>
                            <td>
                                <asp:Literal ID="LiteralFechaActividad" runat="server"></asp:Literal>
                            </td>
                            <td>
                                <asp:Label ID="labelActividad" runat="server" Text="Actividad" CssClass="label"></asp:Label>
                            </td>
                            <td>
                                <asp:Literal ID="LiteralActividad" runat="server"></asp:Literal>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="labelEntidad" runat="server" Text="Número personas impactadas"
                                    CssClass="label"></asp:Label>
                            </td>
                            <td>
                                <asp:Literal ID="LiteralPersonas" runat="server"></asp:Literal>
                            </td>
                            <td>
                                <asp:Label ID="labelNumeroPersonasimpactadas" runat="server"
                                    Text="Entidades Involucradas" CssClass="label"></asp:Label>
                            </td>
                            <td>
                                <asp:Literal ID="LiteralEntidades" runat="server"></asp:Literal>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="labelMaterialEntregado" runat="server"
                                    Text="Departamento actividad" CssClass="label"></asp:Label>
                            </td>
                            <td>
                                <asp:Literal ID="LiteralDepartamento" runat="server"></asp:Literal>
                            </td>
                            <td>
                                <asp:Label ID="label1" runat="server"
                                    Text="Ciudad actividad" CssClass="label"></asp:Label>
                            </td>
                            <td>
                                <asp:Literal ID="LiteralCiudad" runat="server"></asp:Literal>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="label3" runat="server"
                                    Text="Material entregado" CssClass="label"></asp:Label>
                            </td>
                            <td>
                                <asp:Literal ID="LiteralMaterial" runat="server"></asp:Literal>
                            </td>
                            <td></td>
                            <td></td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    <div class="divsingrilla2">
                        <table class="form">
                            <tr>
                                <th>
                                    <asp:Label ID="label2" runat="server" Text="Documentos" CssClass="subtitulo"></asp:Label></th>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Repeater ID="ListaEnlaces" runat="server" OnItemDataBound="ListaEnlaces_ItemDataBound">
                                        <HeaderTemplate>
                                            <table width="100%">
                                        </HeaderTemplate>
                                        <ItemTemplate>
                                            <tr>
                                                <td align="left">
                                                    <div>
                                                        <asp:Button Text='<%# Eval("doc_Ruta") %>' runat="server" ID="buttonDescargaDocumento" CssClass="button" 
                                                            CommandArgument='<%# Eval("doc_Id") %>' OnClick="buttonDescargaDocumento_Click" />
                                                    </div>
                                                </td>
                                            </tr>
                                        </ItemTemplate>
                                        <FooterTemplate>
                                            </table>
                                        </FooterTemplate>
                                    </asp:Repeater>
                                    <asp:Label ID="lblEmptyData" Text="No hay datos para mostrar" runat="server" Visible="False"></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </div>
                </td>
            </tr>
        </table>
    </div>

</asp:Content>
