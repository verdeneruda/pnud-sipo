    <%@ Page Language="C#" MasterPageFile="~/MPMain.Master" AutoEventWireup="true" CodeBehind="UsuariosBuscar.aspx.cs" Inherits="UTO.RegistrosUso.UsuariosBuscar" %>
    <%@ Register src="../Comunes/ControlError.ascx" tagname="ControlError" tagprefix="uc1" %>
    <asp:Content ID="contentBuscarRegistroUsoUsuariosHead" ContentPlaceHolderID="head" Runat="Server">
    </asp:Content>
    <asp:Content  ID="contentBuscarRegistroUsoUsuarios" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
        <asp:XmlDataSource ID="xmlEmpresa" runat="server" 
    DataFile="~/App_Data/empresas.xml"></asp:XmlDataSource>
    <asp:XmlDataSource ID="xmlBusqueda" runat="server" 
    DataFile="~/App_Data/MRegistrosUsoUsuariosConsulta.xml"></asp:XmlDataSource>
    <asp:XmlDataSource ID="xmlCiudad" runat="server" 
    DataFile="~/App_Data/ciudades.xml"></asp:XmlDataSource>
    <asp:XmlDataSource ID="xmlDepartamento" runat="server" 
    DataFile="~/App_Data/departamento.xml"></asp:XmlDataSource>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    <div class="divwithoutgrid">
    <table class="titulo" >
    <tr><td>
    <asp:Label ID="labelBusquedaRegistrosUsoUsuarios" runat="server" Text="Módulo registro de usos - Buscar usuarios finales" CssClass="subtitulo"></asp:Label>
    </td></tr>
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
    <td><table style="width:100%">
    <tr><th colspan="5">
    <asp:Label ID="labelparametros" runat="server" Text="Parámetros búsqueda" CssClass="subtitulo"></asp:Label>
    </th></tr>
    <tr>
    <td style="width:20%">
    <asp:Label ID="labelNit" runat="server" Text="Nit" CssClass="label"></asp:Label>
    </td>
    <td>
    <asp:TextBox runat="server" CssClass="texto2" ID="textNit"></asp:TextBox>
    </td>
    <td class="separador"></td>
    <td style="width:20%">
    <asp:Label ID="labelEmpresa" runat="server" Text="Empresa" CssClass="label"></asp:Label>
    </td>
    <td>
    <asp:DropDownList ID="ComboEmpresa" runat="server" CssClass="combo" 
            DataTextField="ter_NombreCompleto" DataValueField="ter_Id">
    </asp:DropDownList>
    </td>
    </tr>
    <tr>
    <td>
    <asp:Label ID="labelDepartamento" runat="server" Text="Departamento" CssClass="label"></asp:Label>
    </td>
    <td>
    <asp:DropDownList ID="comboDepartamento" runat="server" CssClass="combo" 
            DataTextField="dep_Descripcion" DataValueField="dep_Id" AutoPostBack="True" 
            onselectedindexchanged="comboDepartamento_SelectedIndexChanged">
    </asp:DropDownList>
    </td>
    <td class="separador">
    </td>
    <td>
    <asp:Label ID="labelCiudad" runat="server" Text="Ciudad" CssClass="label"></asp:Label>
    </td>
    <td>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
    <ContentTemplate>
    <asp:DropDownList ID="comboCiudad" runat="server" CssClass="combo" 
            DataTextField="mun_Descripcion" DataValueField="mun_Id">
    </asp:DropDownList>
    </ContentTemplate>
    <Triggers>
    <asp:AsyncPostBackTrigger ControlID="comboDepartamento" />
    </Triggers>
    </asp:UpdatePanel>    
    </td>
    </tr>
    <tr>
    <td colspan="5">    
    <asp:Button ID="buttonBuscar" runat="server" Text="Buscar" CssClass="button" 
            onclick="buttonBuscar_Click" />&nbsp;&nbsp;
    <asp:Button ID="buttonAdicionar" runat="server" Text="Adicionar"  CssClass="button" 
    onclick="buttonAdicionar_Click"/>
    </td>
    </tr>
    </table>
    </td>
    </tr>
    </table>
    </div>
    <br />
    <div class="divgrillas">
    <asp:GridView ID="gridBuscarSustanciasReportadasUsuarios" runat="server" CssClass="grilla" 
    HeaderStyle-CssClass="headergrilla" RowStyle-CssClass="rowgrilla"  AutoGenerateColumns="False" 
    SelectedRowStyle-CssClass="selectedgrilla" 
    FooterStyle-CssClass="footergrilla" 
    onrowcommand="gridBuscarSustanciasReportadasUsuarios_RowCommand" DataKeyNames="Id" 
            AllowPaging="True" DataSourceID="usuariosBuscarDataSource" PageSize="15">
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
        <asp:BoundField DataField="Empresa" HeaderText="Empresa" 
            SortExpression="Empresa" />
    <asp:BoundField DataField="TipoUsuario" HeaderText="Tipo de usuario" 
    SortExpression="TipoUsuario" />
    <asp:BoundField DataField="Sector" HeaderText="Sector" 
    SortExpression="Sector" />
    <asp:BoundField DataField="Fecha" HeaderText="Fecha" 
    SortExpression="Fecha" DataFormatString="{0:dd/MM/yyyy}" />
    <asp:BoundField DataField="Departamento" HeaderText="Departamento" 
    SortExpression="Departamento" />
    <asp:BoundField DataField="Ciudad" HeaderText="Ciudad" 
    SortExpression="Ciudad" />
    <asp:BoundField DataField="Sustancia" 
    HeaderText="Sustancia" 
    SortExpression="Sustancia" />
    <asp:BoundField DataField="Cantidad" 
    HeaderText="Cantidad (Kg)" 
    SortExpression="Cantidad" DataFormatString="{0:#,##0.00}" >
        <ItemStyle HorizontalAlign="Right" />
        </asp:BoundField>
    <asp:BoundField DataField="Id" 
    HeaderText="Id" 
    SortExpression="Id" Visible="False" />
    </Columns>
    <FooterStyle CssClass="footergrilla"></FooterStyle>
    <SelectedRowStyle CssClass="selectedgrilla"></SelectedRowStyle>
    <HeaderStyle CssClass="headergrilla"></HeaderStyle>
    </asp:GridView>
        <asp:SqlDataSource ID="usuariosBuscarDataSource" runat="server" 
            ConnectionString="<%$ ConnectionStrings:BDUTOConnectionString %>" 
            SelectCommand="exec [Rus].[spUsuariosBuscar] @nit,@idEmpresa,@idDepartamento,@idCiudad">
            <SelectParameters>
                <asp:Parameter Name="nit" />
                <asp:Parameter Name="idEmpresa" />
                <asp:Parameter Name="idDepartamento" />
                <asp:Parameter Name="idCiudad" />
            </SelectParameters>
        </asp:SqlDataSource>
    </div>
    <br />
    </asp:Content>