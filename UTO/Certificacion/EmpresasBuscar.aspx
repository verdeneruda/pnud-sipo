    <%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MPMain.Master" CodeBehind="EmpresasBuscar.aspx.cs" Inherits="UTO.Certificacion.BuscarEmpresas" %>
<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

    <%@ Register src="../Comunes/ControlError.ascx" tagname="ControlError" tagprefix="uc1" %>
    <asp:Content ID="contentBuscarEmpresasHead" ContentPlaceHolderID="head" Runat="Server">
    </asp:Content>
    <asp:Content  ID="contentBuscarEmpresas" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    <div class="divwithoutgrid">
    <table class="titulo" >
        <tr>
            <td>
                <asp:Label ID="labelBusquedaEmpresas" runat="server" Text="Módulo certificación - Buscar empresas" 
                    CssClass="subtitulo"></asp:Label>
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
    <th colspan="5">
    <asp:Label ID="labelparametros" runat="server" Text="Parámetros búsqueda" CssClass="subtitulo"></asp:Label>
    </th>
    </tr>
    <tr>
    <td style="width:20%">
    <asp:Label ID="labelNit" runat="server" Text="Nit" CssClass="label"></asp:Label>
    </td>
    <td>
    <asp:TextBox ID="textNit" runat="server"  CssClass="texto2"></asp:TextBox>
    </td>
    <td class="separador"></td>
    <td style="width:20%">
    <asp:Label ID="labelNombre" runat="server" Text="Nombre o Razón Social" CssClass="label"></asp:Label>
    </td>
    <td>
    <asp:TextBox ID="textNombre" runat="server"  CssClass="texto2"></asp:TextBox>
    </td>
    </tr>
    <tr>
    <td colspan="5">
    <asp:Button ID="buttonBuscar" runat="server" Text="Buscar" CssClass="button" 
            onclick="buttonBuscar_Click" />&nbsp;&nbsp;
    <asp:Button ID="buttonAdicionar" runat="server" Text="Adicionar"  CssClass="button" 
    onclick="buttonAdicionar_Click"/>&nbsp;&nbsp;<asp:Button ID="buttonExportar" runat="server" Text="Exportar" CssClass="button" OnClick="buttonExportar_Click" />
        </td>
    </tr>
    </table>
    </div>    
        <div>
                        <dx:ASPxGridView ID="gvConsulta" runat="server" DataSourceID="empresaBuscarDataSource" SettingsPager-PageSize="20"  Width="500px" Visible="False">
                            <Columns>                               
                                <dx:GridViewDataColumn Caption="CTG" FieldName="CTG" >
                                </dx:GridViewDataColumn>
                                <dx:GridViewDataColumn Caption="Nit" FieldName="Nit" >
                                </dx:GridViewDataColumn>
                                <dx:GridViewDataColumn Caption="Razón social" FieldName="RazonSocial" >
                                </dx:GridViewDataColumn>
                                <dx:GridViewDataColumn Caption="Departamento" FieldName="Departamento" >
                                </dx:GridViewDataColumn>
                                <dx:GridViewDataColumn Caption="Ciudad" FieldName="Ciudad" >
                                </dx:GridViewDataColumn>
                                <dx:GridViewDataColumn Caption="Dirección" FieldName="Direccion" >
                                </dx:GridViewDataColumn>
                                <dx:GridViewDataColumn Caption="Teléfono" FieldName="Telefono" >
                                </dx:GridViewDataColumn>
                                <dx:GridViewDataColumn Caption="Fax" FieldName="Fax" >
                                </dx:GridViewDataColumn>
                                <dx:GridViewDataColumn Caption="Email" FieldName="Email" >
                                </dx:GridViewDataColumn>                   
                            </Columns>
                        </dx:ASPxGridView>
<dx:ASPxGridViewExporter ID="exportGrid" ExportedRowType="All" GridViewID="gvConsulta"
                            runat="server">
                        </dx:ASPxGridViewExporter>
            </div>
    <div class="divgrillas">
        <asp:GridView ID="gridBuscarEmpresa" runat="server" CssClass="grilla" 
        HeaderStyle-CssClass="headergrilla" RowStyle-CssClass="rowgrilla"  AutoGenerateColumns="False" 
        SelectedRowStyle-CssClass="selectedgrilla" 
        FooterStyle-CssClass="footergrilla" 
        onrowcommand="gridBuscarEmpresa_RowCommand" DataKeyNames="Id" 
            AllowPaging="True" DataSourceID="empresaBuscarDataSource" PageSize="15">
        <RowStyle CssClass="rowgrilla"></RowStyle>
        <Columns>
        <asp:ButtonField ButtonType="Button" CommandName="Ver" 
        ShowHeader="True" Text="Ver">
        <ControlStyle CssClass="buttongrilla" />
        </asp:ButtonField>
        <asp:ButtonField CommandName="Modificar" ShowHeader="True" 
        Text="Modificar" ButtonType="Button" >
        <ControlStyle CssClass="buttongrilla" />
        </asp:ButtonField>
        <asp:TemplateField>
            <ItemTemplate>
                <asp:Button runat="server" ID="buttonEliminar" Text="Eliminar" CommandName="Eliminar" CommandArgument="<%# Container.DataItemIndex %>" OnClientClick="return confirm('Este registro se eliminará, desea continuar?')" CssClass="buttongrilla"/>
            </ItemTemplate>
        </asp:TemplateField>                        
            <asp:BoundField DataField="CTG" HeaderText="CTG" SortExpression="CTG" />
        <asp:BoundField DataField="Nit" HeaderText="Nit" SortExpression="Nit" />
        <asp:BoundField DataField="RazonSocial" HeaderText="Razón social" 
        SortExpression="RazonSocial" />
        <asp:BoundField DataField="Departamento" HeaderText="Departamento" 
        SortExpression="Departamento" />
        <asp:BoundField DataField="Ciudad" HeaderText="Ciudad" 
        SortExpression="Ciudad" />
        <asp:BoundField DataField="Direccion" HeaderText="Dirección" 
        SortExpression="Direccion" />
        <asp:BoundField DataField="Telefono" HeaderText="Teléfono" 
        SortExpression="Telefono" />
        <asp:BoundField DataField="Fax" HeaderText="Fax" 
        SortExpression="Fax" />
        <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
        <asp:BoundField DataField="Id" HeaderText="Id" 
        SortExpression="Id" />
        </Columns>

        <FooterStyle CssClass="footergrilla"></FooterStyle>

        <SelectedRowStyle CssClass="selectedgrilla"></SelectedRowStyle>

        <HeaderStyle CssClass="headergrilla"></HeaderStyle>
        </asp:GridView>
        <asp:SqlDataSource ID="empresaBuscarDataSource" runat="server" 
            ConnectionString="<%$ ConnectionStrings:BDUTOConnectionString %>" SelectCommand="exec [Cer].[spEmpresaBuscar] 
@documento,@nombre">
            <SelectParameters>
                <asp:Parameter Name="documento" />
                <asp:Parameter Name="nombre" />
            </SelectParameters>
        </asp:SqlDataSource>
    </div>
    </asp:Content>