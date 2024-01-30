    <%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MPMain.Master" CodeBehind="TecnicosCertificadosBuscar.aspx.cs" Inherits="UTO.Certificacion.BuscarTecnicosCertificados" %>
    <asp:Content ID="contentBuscarCertificadosHead" ContentPlaceHolderID="head" Runat="Server">
    </asp:Content>
    <asp:Content  ID="contentBuscarCertificados" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
   
    <div class="divwithoutgrid">
    <asp:XmlDataSource ID="xmlCertificados" runat="server" 
    DataFile="~/App_Data/MCertificacionTecnicosCertificados.xml"></asp:XmlDataSource>

    <table class="titulo" >
        <tr>
            <td>
                <asp:Label ID="labelBusquedaTecnicoCertificados" runat="server" Text="Módulo certificación - Buscar técnicos certificados" CssClass="subtitulo"></asp:Label>
            </td>
        </tr>
    </table>
    
    <br />
    
    <table class="form">
        <tr>
            <td>
                <table style="width:100%">
                    <tr>
                        <th colspan="5">
                            <asp:Label ID="labelparametros" runat="server" Text="Parámetros búsqueda" CssClass="subtitulo"></asp:Label>
                        </th>
                    </tr>
                    
                    <tr>
                        <td style="width:20%">
                            <asp:Label ID="labelDocumento" runat="server" Text="Documento" CssClass="label"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="textDocumento" runat="server"  CssClass="texto2"></asp:TextBox>
                        </td>
                        <td class="separador">
                        </td>
                        <td style="width:20%">
                            <asp:Label ID="labelNombre" runat="server" Text="Nombre" CssClass="label"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="textNombre" runat="server"  CssClass="texto2"></asp:TextBox>
                        </td>
                    </tr>
                
                    <tr>
                        <td colspan="5">
                            <asp:Button ID="buttonBuscar" runat="server" Text="Buscar" CssClass="button" />&nbsp;&nbsp;<asp:Button 
                            ID="buttonAdicionar" runat="server" Text="Adicionar"  CssClass="button" 
                            onclick="buttonAdicionar_Click" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
    </div>
    
    <br />
    
    <div class="divgrillas">
        <asp:GridView ID="gridBuscarCertificados" runat="server" CssClass="grilla" 
            HeaderStyle-CssClass="headergrilla" RowStyle-CssClass="rowgrilla" 
            DataSourceID="xmlCertificados" AutoGenerateColumns="False" 
            SelectedRowStyle-CssClass="selectedgrilla" FooterStyle-CssClass="footergrilla" 
            onrowcommand="gridBuscarCertificados_RowCommand" >
            <RowStyle CssClass="rowgrilla"></RowStyle>
            <Columns>
                <asp:ButtonField CommandName="Modificar"  ShowHeader="True" 
                    Text="Modificar" ButtonType="Button" >
                <ControlStyle CssClass="buttongrilla" />
                </asp:ButtonField>
                <asp:ButtonField ButtonType="Button" CommandName="Eliminar" 
                    ShowHeader="True" Text="Eliminar">
                <ControlStyle CssClass="buttongrilla" />
                </asp:ButtonField>
                <asp:ButtonField ButtonType="Button" CommandName="Ver" 
                    ShowHeader="True" Text="Ver">
                <ControlStyle CssClass="buttongrilla" />
                </asp:ButtonField>
                <asp:BoundField DataField="CU" HeaderText="CU" SortExpression="CU" />
                <asp:BoundField DataField="CTG" HeaderText="CTG" SortExpression="CTG" />
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
                <asp:BoundField DataField="Grupo" HeaderText="Grupo" SortExpression="Grupo" />
                <asp:BoundField DataField="Dirección" HeaderText="Dirección" 
                    SortExpression="Dirección" />
                <asp:BoundField DataField="Teléfono" HeaderText="Teléfono" 
                    SortExpression="Teléfono" />
                <asp:BoundField DataField="Celular" HeaderText="Celular" 
                    SortExpression="Celular" />
                <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                <asp:BoundField DataField="Fax" HeaderText="Fax" SortExpression="Fax" />
                <asp:BoundField DataField="Cargo" HeaderText="Cargo" SortExpression="Cargo" />
                <asp:BoundField DataField="Empresa" HeaderText="Empresa" 
                    SortExpression="Empresa" />
                <asp:BoundField DataField="Fecha" HeaderText="Fecha" SortExpression="Fecha" />
                <asp:BoundField DataField="Vigencia" HeaderText="Vigencia" 
                    SortExpression="Vigencia" />
            </Columns>

            <FooterStyle CssClass="footergrilla"></FooterStyle>

            <SelectedRowStyle CssClass="selectedgrilla"></SelectedRowStyle>

            <HeaderStyle CssClass="headergrilla"></HeaderStyle>
        </asp:GridView>
   </div>
   
    <br />
    
    </asp:Content>