    <%@ Page Language="C#" MasterPageFile="~/MPMain.Master" AutoEventWireup="true" CodeBehind="EncuestaVer.aspx.cs" Inherits="UTO.Comercializacion.EncuestaVer" %>
    <asp:Content ID="contentEncuestaVerHead" ContentPlaceHolderID="head" Runat="Server">
    </asp:Content>
    <asp:Content  ID="contentEncuestaVer" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >

    <asp:XmlDataSource ID="XmlCollapsibleSustancia" runat="server" 
    DataFile="~/App_Data/McomercializacionCollapsibleSustancia.xml"></asp:XmlDataSource>       
    <div class="divwithoutgrid">
    <table class="titulo" >
    <tr><td>
    <asp:Label ID="labelVerEncuesta" runat="server" Text="Módulo de seguimiento al comercio local de SAO - Ver datos de comercialización" CssClass="subtitulo"></asp:Label>
    </td></tr>
    </table>
    <br />
    <table class="formver">
    <tr>
    <td>
    <table style="width:100%;"> 
    <tr><th colspan="4">
    <asp:Label ID="labelDatosGenerales" runat="server" Text="Datos generales" CssClass="subtitulo"></asp:Label>
    </th></tr>
    <tr><td>
    <asp:Label runat="server" ID="labelfecha" Text="Fecha" CssClass="label"></asp:Label>
    </td>
    <td>
    27/03/2010
    </td>
    <td><asp:Label ID="labelDepartamento" runat="server" Text="Departamento" CssClass="label"></asp:Label></td><td> 
    Meta
    </td>
    </tr> 
    <tr>
    <td><asp:Label ID="labelCiudad" runat="server" Text="Ciudad" CssClass="label"></asp:Label></td>
    <td>Villavicencio</td>
    <td><asp:Label ID="labelEmpresa" runat="server" Text="Razon social" CssClass="label"></asp:Label></td>
    <td> 
    Refrigerar y Accesorios 
    </td>
    </tr>
    <tr>
    <td>
    <asp:Label ID="labelNit" runat="server" Text="Nit" CssClass="label"></asp:Label>
    </td>
    <td>
    1323465879-9

    </td>
    <td>
    <asp:Label ID="labelTelefono" runat="server" Text="Teléfono" CssClass="label"></asp:Label>
    </td>
    <td>
    6826308-3115129419
    </td>
    </tr><tr>
    <td>
    <asp:Label ID="labelEMail" runat="server" Text="E-mail" CssClass="label"></asp:Label>
    </td>
    <td>
    Refrigerar@gmail.com
    </td>
    <td>
    <asp:Label ID="labelDireccion" runat="server" Text="Dirección" CssClass="label"></asp:Label>
    </td>
    <td>
    Carrera 37 No. 25-34 San Benito
    </td>
    </tr>
    <tr>
    <td>
    <asp:Label ID="labelContacto" runat="server" Text="Contacto" CssClass="label"></asp:Label>
    </td>
    <td>
    Gina Paola Isaza Perez
    </td>
    <td>
    <asp:Label ID="labelCargo" runat="server" Text="Cargo" CssClass="label"></asp:Label>
    </td>
    <td>
    Ingeniera ambiental
    </td>
    </tr>
    </table>
    </td>
    </tr>
    </table>
    </div>
    <br />
    <div class="divgrillas">
    <asp:GridView ID="gridDetSustancias" runat="server"  AutoGenerateColumns="False" 
    CssClass="grilla" RowStyle-CssClass="rowgrilla" 
    HeaderStyle-CssClass="headergrilla" FooterStyle-CssClass="footergrilla" 
    DataSourceID="XmlCollapsibleSustancia" AllowPaging="True" PageSize="15">
    <RowStyle CssClass="rowgrilla" />
    <Columns>
    <asp:BoundField DataField="Proveedor" HeaderText="Proveedor" 
    SortExpression="Proveedor" />
    <asp:BoundField DataField="Sustancia" HeaderText="Sustancia" 
    SortExpression="Sustancia" />
    <asp:BoundField DataField="Presentacion" HeaderText="Presentacion" 
    SortExpression="Presentacion" />
    <asp:BoundField DataField="Marca" HeaderText="Marca" SortExpression="Marca" />
    <asp:BoundField DataField="Precio" HeaderText="Precio" 
    SortExpression="Precio" />
    <asp:BoundField DataField="Observacion" HeaderText="Observacion" 
    SortExpression="Observacion" />
    </Columns>
    <FooterStyle CssClass="footergrilla" />
    <HeaderStyle CssClass="headergrilla" />
    </asp:GridView>
    </div>
    <br />
    </asp:Content>