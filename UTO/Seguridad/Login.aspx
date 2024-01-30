<%@ Page Title="" Language="C#" MasterPageFile="~/MPMain.master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="UTO.Seguridad.Login" %>

<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../App_Themes/login.css" type="text/css" />
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="loginBody">
        <div id="loginBox">
            <h1 id="logo"><a href="http://www.minambiente.gov.co">Unidad Técnica de Ozono</a></h1>
            <h1>Ingreso al sistema</h1>
            <br />
            <asp:Label ID="labelError" runat="server" Text="" class="error"></asp:Label>
            <table border="0" align="center">
                <tr>
                    <td width="100px" align="right"><b>Usuario</b>:</td>
                    <td>
                        <asp:TextBox ID="textName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="right"><b>Contraseña</b>:</td>
                    <td>
                        <asp:TextBox ID="textPassword" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="right"><b>Código de validación</b>:</td>
                    <td >
                        <dx:ASPxCaptcha ID="Captcha" runat="server" CodeLength="7">
                            <ValidationSettings SetFocusOnError="true" ErrorDisplayMode="Text" ErrorText="Error al validar el código" />
                            <RefreshButton Text="Refrescar">
                            </RefreshButton>
                            <TextBox LabelText="Digitar el código:" Position="Bottom" />

                            <ChallengeImage ForegroundColor="White" BackgroundColor="#3C9900" BorderColor="White">
                                <BackgroundImage HorizontalPosition="center" VerticalPosition="top" />
                            </ChallengeImage>
                        </dx:ASPxCaptcha>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;&nbsp;<asp:Button ID="buttonLogin" runat="server" Text="Ingresar"
                        class="submit" OnClick="buttonLogin_Click" />
                    </td>
                </tr>
            </table>
        </div>
        <div id="copyRights">Todos los derechos reservados &copy; <a href='http://www.minambiente.gov.co' target="_blank">www.minambiente.gov.co</a></div>
    </div>
</asp:Content>
