    <%@ Page Language="C#" MasterPageFile="~/MPMain.Master" AutoEventWireup="true" CodeBehind="ProductosBuscar.aspx.cs" Inherits="UTO.DisposicionFinal.ProductosBuscar" %>

    <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
    <%@ Register src="../Comunes/ControlError.ascx" tagname="ControlError" tagprefix="uc1" %>
    <asp:Content ID="contentProductosDisposicionFinalBuscarHead" ContentPlaceHolderID="head" Runat="Server">
    </asp:Content>
    <asp:Content  ID="contentProductosDisposicionFinalBuscar" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
        <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </cc1:ToolkitScriptManager>
    <div class="divwithoutgrid">
    <table class="titulo" >
    <tr><td>
    <asp:Label ID="labelBusquedaPDisposicionFinal" runat="server" Text="Módulo disposición final - Buscar sustancias disposición final" CssClass="subtitulo"></asp:Label>
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
    <td>
    <asp:Label ID="labelNit" runat="server" Text="Nit" CssClass="label"></asp:Label>
    </td>
    <td>
     <asp:TextBox ID="textNit" runat="server"  CssClass="texto2"></asp:TextBox>
    </td>
    <td class="separador">
    </td>
    <td>
     <asp:Label ID="labelEmpresa" runat="server" Text="Empresa" CssClass="label"></asp:Label>
    </td>
    <td>
        <asp:TextBox ID="textEmpresa" runat="server" CssClass="texto2"></asp:TextBox>
    </td>
    </tr>
    <tr>
    <td style="width:20%">
     <asp:Label ID="labelFechaIncial" runat="server" Text="Fecha inicial" CssClass="label"></asp:Label>
    
    </td>
    <td> <asp:TextBox ID="textFechaInicial" runat="server"  CssClass="texto2"></asp:TextBox>
    <cc1:calendarextender ID="calendarfecha" Format="dd/MM/yyyy"  runat="server" 
    CssClass="calendar" TargetControlID="textFechaInicial">
    </cc1:calendarextender>
       </td>
    <td class="separador"></td>
    <td style="width:20%">
  <asp:Label ID="labelFechaFinal" runat="server" Text="Fecha final" CssClass="label"></asp:Label>
    </td>
    <td>
   <asp:TextBox ID="textFechaFinal" runat="server"  CssClass="texto2"></asp:TextBox>
    <cc1:calendarextender ID="calendarFechaFinal" Format="dd/MM/yyyy"  runat="server" 
    CssClass="calendar" TargetControlID="textFechaFinal">
    </cc1:calendarextender>
    </td>
    </tr>
    <tr>
    <td>
       <asp:Label ID="labelSustancia" runat="server" Text="Sustancia" CssClass="label"></asp:Label> 
    </td>
    <td>
      <asp:DropDownList ID="comboSustancia" runat="server" CssClass="combo" 
                DataTextField="sus_Descripcion" DataValueField="sus_Id">
        </asp:DropDownList>
    </td>
    <td class="separador"></td>
    <td>

    </td>
    <td>
   
    </td>

    </tr>
    <tr>
    <td colspan="5">
    <asp:Button ID="buttonBuscar" runat="server" Text="Buscar" CssClass="button" 
            onclick="buttonBuscar_Click" />&nbsp;&nbsp;
    <asp:Button ID="buttonAdicionar" runat="server" Text="Adicionar"  
    CssClass="button" onclick="buttonAdicionar_Click"/>
    </td>
    </tr>
    </table>
    </td>
    </tr>
    </table>
    </div>
    <br />
    <div class="divgrillas">
    <asp:GridView ID="gridBuscarProductosDisposicionFinal" runat="server" CssClass="grilla" 
    HeaderStyle-CssClass="headergrilla" RowStyle-CssClass="rowgrilla"  AutoGenerateColumns="False" 
    SelectedRowStyle-CssClass="selectedgrilla" 
    FooterStyle-CssClass="footergrilla" 
            onrowcommand="gridBuscarProductosDisposicionFinal_RowCommand" 
            DataKeyNames="Id" AllowPaging="True" 
            DataSourceID="productoBuscarDataSource" PageSize="15">
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
    <asp:BoundField DataField="Fecha" HeaderText="Fecha" SortExpression="Fecha" 
            DataFormatString="{0:dd/MM/yyyy}" />
    <asp:BoundField DataField="Empresa" HeaderText="Empresa" 
    SortExpression="Empresa" />
    <asp:BoundField DataField="DireccionAlmacenamiento" HeaderText="Dirección_Almacenamiento" 
    SortExpression="DireccionAlmacenamiento" />
    <asp:BoundField DataField="Telefono" 
    HeaderText="Teléfono" 
    SortExpression="Telefono" />
    <asp:BoundField DataField="Departamento" HeaderText="Departamento" 
    SortExpression="Departamento" />
    <asp:BoundField DataField="Ciudad" HeaderText="Ciudad" 
    SortExpression="Ciudad" />
        <asp:BoundField DataField="Id" SortExpression="Id" Visible="False" />

    </Columns>

    <FooterStyle CssClass="footergrilla"></FooterStyle>

    <SelectedRowStyle CssClass="selectedgrilla"></SelectedRowStyle>

    <HeaderStyle CssClass="headergrilla"></HeaderStyle>
    </asp:GridView>
        <asp:SqlDataSource ID="productoBuscarDataSource" runat="server" 
            ConnectionString="<%$ ConnectionStrings:BDUTOConnectionString %>" 
            SelectCommand="exec [Dis].[spSustanciaBuscar] @nit,@idEmpresa,@fechaInicial,@fechaFinal,@idSustancia">
            <SelectParameters>
                <asp:Parameter Name="nit" />
                <asp:Parameter Name="idEmpresa" />
                <asp:Parameter Name="fechaInicial" />
                <asp:Parameter Name="fechaFinal" />
                <asp:Parameter Name="idSustancia" />
            </SelectParameters>
        </asp:SqlDataSource>
    </div>
    <br />
    </asp:Content>

