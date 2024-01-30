<%@ Page Language="C#" MasterPageFile="~/MPMain.Master" AutoEventWireup="true" CodeBehind="CargueInformacionExportacion.aspx.cs" Inherits="UTO.ImportacionExportacion.CargueInformacionExportacion" %>
<%@ Register src="../Comunes/ControlError.ascx" tagname="ControlError" tagprefix="uc1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>    
<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<asp:Content ID="ImportacionExportacionCargueExportacionHead" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content  ID="ImportacionExportacionCargueExportacion" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >

<cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
</cc1:ToolkitScriptManager>
<div class="divwithoutgrid"> 
<table class="titulo" >
<tr><td>
<asp:Label ID="labelCargueExportacion" runat="server" Text="Mòdulo importación y exportación - Adicionar cargue información datos consumo exportación " CssClass="subtitulo"></asp:Label>
</td></tr>
</table>
<table class="form">
<tr>
<td>
    <uc1:controlerror ID="ControlError1" runat="server" />
</td>
</tr>
</table>
<table class="form">
<tr>
<td>
<table style="width:100%;"> 
<tr><th colspan="5">
<asp:Label ID="labelDatosGenerales" runat="server" Text="Datos generales" CssClass="subtitulo"></asp:Label>
</th></tr>
<tr>
<td colspan="2">
<asp:Label runat="server" ID="labelAño" Text="Año" CssClass="label"></asp:Label>&nbsp
    <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>
</td>
<td>
        <asp:TextBox ID="textAno" runat="server" CssClass="texto2"></asp:TextBox>
    </td>
<td>
    &nbsp;</td>
<td> 
    &nbsp;</td>
</tr> 
<tr>
<td>
<asp:Label runat="server" ID="labelArchivo" Text="Seleccione archivo para subir" CssClass="label"></asp:Label>&nbsp
    <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>
</td>
<td colspan="4">
<asp:FileUpload ID="FileUpload1" runat="server" Width="457px"/>
</td>
</tr> 
<tr>
<td colspan="5">
<asp:Button ID="buttonProcesar" runat="server" Text="Procesar" CssClass="button" 
        onclick="buttonprocesar_Click" />
&nbsp;<asp:Button ID="buttonExportar" runat="server" Text="Exportar" CssClass="button" 
        onclick="buttonExportar_Click" />
&nbsp;</td>
</tr> 
        <tr>
            <td colspan="5">
                El archivo debe ser en formato csv y el delimitador de campos es punto y coma (;).  
                <br/>
                Los campos son los siguientes:
                <br/>
                <li>NumeroDeclaracion: El número de declaración de la exportación.</li>
                <br />
                <li>ITEM: .</li>    
                <br />
                <li>FechaDeclaracion: Fecha de la declaración de exportación.  En formato dd/mm/aaaaa</li>
                <br />
                <li>Cantidad: Cantidad exportada.</li>
                <br />
                <li>ValorFOB: Valor FOB.</li>
                <br />
                <li>PesoNeto: Peso neto exportado.</li>
                <br />
                <li>NIT: Nit de quien exporta.</li>
                <br />
                <li>RazonSocia: Razón social de quien exporta.</li>
                <br />
                <li>PaisProcedencia: País de destino de la exportación.</li>
                <br />                
                <li>UnidadMedida: Medida usada en la exportación.</li>
                <br />                
                <li>Modalidad: Modalidad de la exportación.</li>
                <br />                
                <li>Sustancia: Sustancia exportada.</li>
                <br />                
                <li>ATENCIÓN: Si se intenta cargar un año que ya ha sido cargado con anterioridad, se borrarán previamente los registros cargados y se reemplazaron por los del nuevo archivo.</li>
            </td>
        </tr>  
<tr>
<td colspan="5">
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
    </div>

<div class="divimportacion">
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
</td>
</tr> 
</table>
</td>
</tr>
</table>
</div>
<br />
<br />
</asp:Content>

