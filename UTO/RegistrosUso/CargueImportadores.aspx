<%@ Page MasterPageFile="~/MPMain.Master" Language="C#" AutoEventWireup="true" CodeBehind="CargueImportadores.aspx.cs" Inherits="UTO.RegistrosUso.CargueImportadores" %>

<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
 <%@ Register src="../Comunes/ControlError.ascx" tagname="ControlError" tagprefix="uc1" %>
 <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

    <asp:Content  ID="RegistroUsoCargueImportadores" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    <asp:XmlDataSource ID="xmlArchivos" runat="server" 
    DataFile="~/App_Data/MImportacionExportacionCargueImpo.xml"></asp:XmlDataSource>
    <div class="divwithoutgrid"> 
    <table class="titulo" >
    <tr><td>
    <asp:Label ID="labelCargueImportadores" runat="server" Text="Módulo registro de usos - Adicionar cargue de información de importadores" CssClass="subtitulo"></asp:Label>
    </td></tr>
    </table>
    <table class="form">
    <tr>
    <td>
    
        <uc1:controlerror ID="ControlError1" runat="server" />
    
    </td>
    </tr>
    </table>       
    <br />
    <table class="form">
    <tr>
    <td>
    <table style="width:100%;"> 
        <tr>
            <th colspan="5">
                <asp:Label ID="labelDatosGenerales" runat="server" Text="Datos generales" CssClass="subtitulo"></asp:Label>
            </th>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="labelAño" Text="Año" CssClass="label"></asp:Label>&nbsp;
                <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="textAño" runat="server"  CssClass="texto5"></asp:TextBox>
            </td>
            <td class="separador"></td>
            <td>
                <asp:Label runat="server" ID="labelArchivo" Text="Seleccione archivo para subir" CssClass="label"></asp:Label>
            </td>
            <td> 
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </td>
        </tr> 
        <tr>
            <td>
            <asp:Button ID="buttonprocesar" runat="server" Text="Procesar" CssClass="button" 
                    onclick="buttonprocesar_Click" />
            </td>
            <td>
                <asp:Button ID="buttonDescargar" runat="server" Text="Descargar resultado" 
                    CssClass="button" onclick="buttonDescargar_Click" 
                     />
            </td>
        </tr>
        <tr>
            <td colspan="5">
                El archivo debe ser en formato csv y el delimitador de campos es punto y coma (;).  
                <br/>
                Los campos son los siguientes:
                <br/>
                <li>CLIENTE: El nombre del cliente relacionado por el importador.</li>
                <br />
                <li>CIUDAD: Nombre de la ciudad.</li>    
                <br />
                <li>DIRECCIÓN: Dirección de la importación.</li>
                <br />
                <li>SUSTANCIA: Nombre de la sustancia importada.</li>
                <br />
                <li>KILOS: Cantidad importada.</li>
                <br />
                <li>PROVEEDOR: Nombre del proveedor o el importador.</li>
                <br />
                <li>APLICACIÓN: Aplicación que se le va a dar a la sustancia importa.</li>
                <br />
                <li>ATENCIÓN: Si se intenta cargar un año que ya ha sido cargado con anterioridad, se borrarán previamente los registros cargados y se reemplazaron por los del nuevo archivo.</li>
            </td>
        </tr>
    </table>
    </table>
    </div>
    <br />
    <div class="divgrillas">
        <dx:ASPxGridView ID="gvResultados" runat="server" CssClass="grilla" >
            <SettingsPager PageSize="20">
            </SettingsPager>
            <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
            <Styles>
                <Header CssClass="headergrilla">
                </Header>
                <Row CssClass="rowgrilla"></Row>
                <Footer CssClass ="footergrilla"></Footer>
            </Styles>

        </dx:ASPxGridView>
<dx:ASPxGridViewExporter ID="exportGrid" ExportedRowType="All" GridViewID="gvResultados"
                            runat="server">
                        </dx:ASPxGridViewExporter>

        <asp:GridView ID="gridResultado" runat="server" 
    CssClass="grilla" RowStyle-CssClass="rowgrilla" 
    HeaderStyle-CssClass="headergrilla" FooterStyle-CssClass="footergrilla" 
            AllowPaging="True" PageSize="15" 
            onpageindexchanging="gridResultado_PageIndexChanging" Visible="False">
    <RowStyle CssClass="rowgrilla" />
    <FooterStyle CssClass="footergrilla" />
    <HeaderStyle CssClass="headergrilla" />
    </asp:GridView>
    </div>
    <br />
    </asp:Content>
