<%@ Page Language="C#" MasterPageFile="~/MPMain.Master"  AutoEventWireup="true" CodeBehind="ReporteUsoBuscar.aspx.cs" Inherits="UTO.Recuperacion.ReporteUsoBuscar" %>

    <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

    <%@ Register src="../Comunes/ControlError.ascx" tagname="ControlError" tagprefix="uc1" %>

    <asp:Content  ID="contentSolicitudEquiposBuscar" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
    
        <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </cc1:ToolkitScriptManager>
    <div class="divwithoutgrid">
    <table class="titulo" >
        <tr><td>
        <asp:Label ID="labelBusquedaSolicitudesEquipos" runat="server" Text="Proyectos de dotación de equipos y herramientas  para el sector de refrigeración y aire acondicionado - Buscar Reporte Uso" CssClass="subtitulo"></asp:Label>
        </td></tr>
    </table>
    <table class="form">
    <tr>
    <td>    
        <uc1:ControlError ID="ControlError1" runat="server" />    
    </td>
    </tr>
    </table>
    <table class="form">
        <tr>
    <td><table style="width:100%">
    <tr>
        <th colspan="6">   
        <asp:Label ID="labelparametros" runat="server" Text="Parámetros Búsqueda" CssClass="subtitulo"></asp:Label>
        </th>
    </tr>
    <tr>
    <td>
    <asp:Label ID="labelDepartamento" runat="server" CssClass="label" 
    Text="Departamento"></asp:Label>
    </td>
    <td>
    <asp:DropDownList ID="comboDepartamento" runat="server" CssClass="combo" DataTextField="dep_Descripcion" 
    DataValueField="dep_Id" Width="172px" 
            onselectedindexchanged="comboDepartamento_SelectedIndexChanged" 
            AutoPostBack="True">
    </asp:DropDownList>
    </td>
    <td style="width:20%">
    <asp:Label ID="labelCiudad" runat="server" CssClass="label" Text="Ciudad"></asp:Label>
    </td>
    <td colspan="3">
    <asp:DropDownList ID="comboCiudad" runat="server" CssClass="combo" 
            DataTextField="mun_Descripcion" DataValueField="mun_Id" 
            Width="301px">
    </asp:DropDownList>
    </td>
    </tr>
    <tr>
    <td>
    <asp:Label ID="labelRegional" runat="server" Text="Regional" CssClass="label"></asp:Label>
    </td>
    <td>
        <asp:DropDownList ID="comboRegional" runat="server" CssClass="combo" 
            DataTextField="reg_Descripcion" DataValueField="reg_Id">
        </asp:DropDownList>
    </td>
    <td style="width:20%">
        <asp:Label ID="labelNombreBeneficiario" runat="server" Text="Nombre beneficiario" CssClass="label"></asp:Label>
    </td>
    <td colspan="3">
        <asp:TextBox ID="textNombreBeneficiario" runat="server"  CssClass="texto2" 
            Width="300px"></asp:TextBox>
    </td>
    </tr>
                 <tr>
                     <td>
                         <asp:Label ID="label3" runat="server" CssClass="label" Text="Tipo documento"></asp:Label>
                     </td>
                     <td>
                         <asp:DropDownList ID="comboTipoDocumentoBuscar" runat="server" CssClass="combo" DataTextField="dti_Descripcion" 
                             DataValueField="dti_Id"  >
                         </asp:DropDownList>
                     </td>
                     <td>
                         <asp:Label ID="labelNumeroDocumento" runat="server" CssClass="label" 
                             Text="Número documento"></asp:Label>
                     </td>
                     <td>
                         <asp:TextBox ID="textNumeroDocumnetoBuscar" runat="server" CssClass="texto2" 
                             ></asp:TextBox>
                     </td>
                 </tr>
    
    <tr>
    <td colspan="6">
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
    <asp:GridView ID="gridBuscarReporteUso" runat="server" CssClass="grilla" 
    HeaderStyle-CssClass="headergrilla" RowStyle-CssClass="rowgrilla" 
    SelectedRowStyle-CssClass="selectedgrilla" 
    FooterStyle-CssClass="footergrilla" onrowcommand="gridBuscarReporteUso_RowCommand" 
            DataKeyNames="Id" AllowPaging="True" 
            DataSourceID="reporteUsoBuscarDataSource" PageSize="15" 
            AutoGenerateColumns="False">
    <RowStyle CssClass="rowgrilla"></RowStyle>

        <Columns>
            <asp:ButtonField ButtonType="Button" CommandName="Modificar" Text="Modificar">
            <ControlStyle CssClass="buttongrilla" />
            </asp:ButtonField>
            <asp:ButtonField ButtonType="Button" CommandName="Eliminar" Text="Eliminar">
            <ControlStyle CssClass="buttongrilla" />
            </asp:ButtonField>
            <asp:ButtonField ButtonType="Button" CommandName="Ver" Text="Ver">
            <ControlStyle CssClass="buttongrilla" />
            </asp:ButtonField>
        
            <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" 
                ReadOnly="True" SortExpression="Id" Visible="False" />
            <asp:BoundField DataField="Periodo" HeaderText="Periodo" 
                SortExpression="Periodo" />
            <asp:BoundField DataField="Año" HeaderText="Año" SortExpression="Año" />
            <asp:BoundField DataField="Regional" HeaderText="Regional" 
                SortExpression="Regional" />
            <asp:BoundField DataField="Beneficiario" HeaderText="Beneficiario" 
                SortExpression="Beneficiario" />
            <asp:BoundField DataField="Departamento" HeaderText="Departamento" 
                SortExpression="Departamento" />
            <asp:BoundField DataField="Municipio" HeaderText="Municipio" 
                SortExpression="Municipio" />
        </Columns>

    <FooterStyle CssClass="footergrilla"></FooterStyle>

    <SelectedRowStyle CssClass="selectedgrilla"></SelectedRowStyle>

    <HeaderStyle CssClass="headergrilla"></HeaderStyle>
    </asp:GridView>
        <asp:SqlDataSource ID="reporteUsoBuscarDataSource" runat="server" 
            ConnectionString="<%$ ConnectionStrings:BDUTOConnectionString %>" 
            SelectCommand="exec [Rrr].[spReporteUsoBuscar] @departamento,@municipio,@regional,@beneficiario,@tipo,@tipoDoc,@numDoc">
            <SelectParameters>
                <asp:Parameter Name="departamento" />
                <asp:Parameter Name="municipio" />
                <asp:Parameter Name="regional" />
                <asp:Parameter Name="beneficiario" />
                <asp:Parameter Name="tipo" />
                <asp:Parameter Name="tipoDoc" />
                <asp:Parameter Name="numDoc" />
            </SelectParameters>
        </asp:SqlDataSource>
    </div>
    <br />
    </asp:Content>
<%--<asp:Content ID="Content1" runat="server" contentplaceholderid="head">

    <style type="text/css">
        .style1
        {
            width: 11px;
        }
    </style>

</asp:Content>--%>