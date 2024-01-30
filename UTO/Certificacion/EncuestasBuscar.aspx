    <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EncuestasBuscar.aspx.cs" MasterPageFile="~/MPMain.Master" Inherits="UTO.Certificacion.BuscarEncuesta" %>

    <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
    <asp:Content ID="contentBuscarEncuestaHead" ContentPlaceHolderID="head" Runat="Server">
    </asp:Content>
    <asp:Content  ID="contentBuscarEncuesta" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
        <asp:XmlDataSource ID="xmlEncuesta" runat="server" 
    DataFile="~/App_Data/MCertificacionEncuesta.xml"></asp:XmlDataSource>

    <div class="divwithoutgrid">
    <table class="titulo" >
    <tr><td>
    <asp:Label ID="labelBusquedaEncuesta" runat="server" Text="Módulo certificación - Buscar encuesta" CssClass="subtitulo"></asp:Label>
    </td></tr>
    </table>
    <br />
    <table class="form">
    <tr>
    <th colspan="5">
    <asp:Label ID="labelparametros" runat="server" Text="Parámetros búsqueda" CssClass="subtitulo"></asp:Label>
    </th></tr>
    <tr>
    <td style="width:20%">
    <asp:Label ID="labelDocumento" runat="server" Text="Documento" CssClass="label"></asp:Label>
    </td>
    <td>
    <asp:TextBox ID="textDocumento" runat="server"  CssClass="texto2"></asp:TextBox>
    </td>
    <td class="separador"></td>
    <td style="width:20%">
    <asp:Label ID="labelNombre" runat="server" Text="Nombre" CssClass="label"></asp:Label>
    </td>
    <td>
    <asp:TextBox ID="textNombre" runat="server"  CssClass="texto2"></asp:TextBox>
    </td>
    </tr>
    <tr>
    <td colspan="5">
    <asp:Button ID="buttonBuscar" runat="server" Text="Buscar" CssClass="button" />&nbsp;&nbsp;
    <asp:Button ID="buttonAdicionar" runat="server" Text="Adicionar"  CssClass="button"  onclick="buttonAdicionar_Click" />
    </td>
    </tr>
    </table>
    </div>
    <br />
    <div class="divgrillas">
    <asp:GridView ID="gridBuscarEncuesta" runat="server" CssClass="grilla" 
    HeaderStyle-CssClass="headergrilla" RowStyle-CssClass="rowgrilla"  AutoGenerateColumns="False" 
    SelectedRowStyle-CssClass="selectedgrilla" 
    FooterStyle-CssClass="footergrilla" 
    onrowcommand="gridBuscarEncuesta_RowCommand" >
    <RowStyle CssClass="rowgrilla"></RowStyle>
    <Columns>
    
<asp:ButtonField ButtonType="Button" CommandName="Modificar" 
    ShowHeader="True" Text="Modificar" 
    ControlStyle-CssClass="buttongrilla" >
    <ControlStyle CssClass="buttongrilla"></ControlStyle>
    </asp:ButtonField>
    <asp:ButtonField ButtonType="Button" CommandName="Eliminar" 
    ShowHeader="True" Text="Eliminar"  ControlStyle-CssClass="buttongrilla" >
    <ControlStyle CssClass="buttongrilla"></ControlStyle>
    </asp:ButtonField>
    <asp:ButtonField ButtonType="Button" CommandName="Ver" 
    ShowHeader="True" Text="Ver" ControlStyle-CssClass="buttongrilla" >
    <ControlStyle CssClass="buttongrilla"></ControlStyle>
    </asp:ButtonField>
    <asp:BoundField DataField="CU" HeaderText="CU" 
    SortExpression="CU" />
    <asp:BoundField DataField="CTG" HeaderText="CTG" 
    SortExpression="CTG" />
    <asp:BoundField DataField="TipoDocumento" HeaderText="TipoDocumento" 
    SortExpression="TipoDocumento" />
    <asp:BoundField DataField="Documento" HeaderText="Documento" 
    SortExpression="Documento" />
    <asp:BoundField DataField="Nombre" HeaderText="Nombre" 
    SortExpression="Nombre" />
    <asp:BoundField DataField="Departamento" HeaderText="Departamento" 
    SortExpression="Departamento" />
    <asp:BoundField DataField="Ciudad" HeaderText="Ciudad" 
    SortExpression="Ciudad" />
    <asp:BoundField DataField="Grupo" HeaderText="Grupo" 
    SortExpression="Grupo" />
    <asp:BoundField DataField="Dirección" HeaderText="Dirección" 
    SortExpression="Dirección" />
    <asp:BoundField DataField="Teléfono" HeaderText="Teléfono" 
    SortExpression="Teléfono" />
    <asp:BoundField DataField="Celular" HeaderText="Celular" 
    SortExpression="Celular" />
    <asp:BoundField DataField="Email" HeaderText="Email" 
    SortExpression="Email" />
    <asp:BoundField DataField="Fax" HeaderText="Fax" SortExpression="Fax" />
        <asp:BoundField DataField="Cargo" HeaderText="Cargo" SortExpression="Cargo" />
        <asp:BoundField DataField="Empresa" HeaderText="Empresa" 
            SortExpression="Empresa" />
    </Columns>

    <FooterStyle CssClass="footergrilla"></FooterStyle>

    <SelectedRowStyle CssClass="selectedgrilla"></SelectedRowStyle>

    <HeaderStyle CssClass="headergrilla"></HeaderStyle>
    </asp:GridView>
    </div>
    <br />
    </asp:Content>