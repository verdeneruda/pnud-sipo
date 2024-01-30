    <%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MPMain.Master" CodeBehind="TecnicosBuscar.aspx.cs" Inherits="UTO.Certificacion.BuscarTecnicos" %>

    <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
    <%@ Register src="../Comunes/ControlError.ascx" tagname="ControlError" tagprefix="uc1" %>
    <asp:Content ID="contentBuscarTecnicoHead" ContentPlaceHolderID="head" Runat="Server">
    </asp:Content>
    <asp:Content  ID="contentBuscarTecnico" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
        <div class="divwithoutgrid">
    <asp:XmlDataSource ID="xmlTecnicos" runat="server" 
    DataFile="~/App_Data/MCertificacionTecnicosCertificados.xml"></asp:XmlDataSource>

    <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </cc1:ToolkitScriptManager>

    <table class="titulo" >
        <tr>
            <td>
                <asp:Label ID="labelBusquedaTecnico" runat="server" Text="Módulo certificación - Buscar técnico" CssClass="subtitulo"></asp:Label>
            </td>
        </tr>
    </table>
    <table class="form">
        <tr>
            <td>            
                <uc1:ControlError ID="ControlError1" runat="server" />            
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
                            <asp:Label ID="labelparametros" runat="server" Text="Parámetros Búsqueda" CssClass="subtitulo"></asp:Label>
                        </th>
                    </tr>
                    
                    <tr>
                        <td >
                            <asp:Label ID="labelDocumento" runat="server" Text="Documento" CssClass="label"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="textDocumento" runat="server"  CssClass="texto2"></asp:TextBox>
                        </td>
                       <td class="separador">
                        </td>
                        <td >
                            <asp:Label ID="labelNombre" runat="server" Text="Nombre" CssClass="label"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="textNombre" runat="server"  CssClass="texto2"></asp:TextBox>
                        </td>
                    </tr>
                    
                    <tr>
                        <td colspan="5">
                            <asp:Button ID="buttonBuscar" runat="server" Text="Buscar" CssClass="button" 
                                onclick="buttonBuscar_Click1" />&nbsp;&nbsp;<asp:Button 
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
        <asp:GridView ID="gridBuscarTecnicos" runat="server" CssClass="grilla" 
            HeaderStyle-CssClass="headergrilla" RowStyle-CssClass="rowgrilla" 
            SelectedRowStyle-CssClass="selectedgrilla" FooterStyle-CssClass="footergrilla" 
            onrowcommand="gridBuscarTecnicos_RowCommand" DataKeyNames="Id" 
            AllowPaging="True" DataSourceID="tecnicosBuscarDataSource" PageSize="15" 
            AutoGenerateColumns="False">
            <RowStyle CssClass="rowgrilla"></RowStyle>
            <Columns>
                <asp:ButtonField ButtonType="Button" CommandName="Ver" Text="Ver">
                    <ControlStyle CssClass="buttongrilla" />
                </asp:ButtonField>
                <asp:ButtonField ButtonType="Button" CommandName="Modificar" Text="Modificar">
                    <ControlStyle CssClass="buttongrilla" />
                </asp:ButtonField>
                <asp:TemplateField>
                <ItemTemplate>
                <asp:Button runat="server" ID="buttonEliminar" Text="Eliminar" CommandName="Eliminar" CommandArgument="<%# Container.DataItemIndex %>" OnClientClick="return confirm('Este registro se eliminará, desea continuar?')" CssClass="buttongrilla"/>
                </ItemTemplate>
                </asp:TemplateField>                
            
                <asp:BoundField DataField="CTG" HeaderText="CTG" ReadOnly="True" 
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
                <asp:BoundField DataField="Direccion" HeaderText="Direccion" 
                    SortExpression="Direccion" />
                <asp:BoundField DataField="Telefono" HeaderText="Telefono" 
                    SortExpression="Telefono" />
                <asp:BoundField DataField="Celular" HeaderText="Celular" 
                    SortExpression="Celular" />
                <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                <asp:BoundField DataField="Empresa" HeaderText="Empresa" ReadOnly="True" 
                    SortExpression="Empresa" />
                <asp:BoundField DataField="AreaTrabajo" HeaderText="AreaTrabajo" 
                    ReadOnly="True" SortExpression="AreaTrabajo" />
                <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" 
                    ReadOnly="True" SortExpression="Id" Visible="False" />
            </Columns>

            <FooterStyle CssClass="footergrilla"></FooterStyle>

            <SelectedRowStyle CssClass="selectedgrilla"></SelectedRowStyle>

            <HeaderStyle CssClass="headergrilla"></HeaderStyle>
        </asp:GridView>
        
        <asp:SqlDataSource ID="tecnicosBuscarDataSource" runat="server" 
            ConnectionString="<%$ ConnectionStrings:BDUTOConnectionString %>" 
            SelectCommand="exec [Cer].[spTecnicosBuscar] @documento,@nombre">
            <SelectParameters>
                <asp:Parameter Name="documento" />
                <asp:Parameter Name="nombre" />
            </SelectParameters>
        </asp:SqlDataSource>
        
    </div>
    
    <br />
    
    </asp:Content>