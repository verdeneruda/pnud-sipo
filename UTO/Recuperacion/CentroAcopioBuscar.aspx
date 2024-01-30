<%@ Page Language="C#" MasterPageFile="~/MPMain.Master"  AutoEventWireup="true" CodeBehind="CentroAcopioBuscar.aspx.cs" Inherits="UTO.Recuperacion.CentroAcopioBuscar" %>

    <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
    <%@ Register src="../Comunes/ControlError.ascx" tagname="ControlError" tagprefix="uc1" %>
    
    <asp:Content  ID="contentSolicitudEquiposBuscar" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
        <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </cc1:ToolkitScriptManager>
    <div class="divwithoutgrid">
    <table class="titulo" >
        <tr><td>
        <asp:Label ID="labelBusquedaSolicitudesEquipos" runat="server" Text="Proyectos de dotación de equipos y herramientas  para el sector de refrigeración y aire acondicionado - Centros de acopio - Buscar centros de acopio" CssClass="subtitulo"></asp:Label>
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
        <th colspan="5">   
        <asp:Label ID="labelparametros" runat="server" Text="Parámetros Búsqueda" CssClass="subtitulo"></asp:Label>
        </th>
    </tr>
    <tr>
    <td>
    <asp:Label ID="labelRegional" runat="server" Text="Centro de acopio" 
            CssClass="label"></asp:Label>
    </td>
    <td colspan="3">
        <asp:DropDownList ID="comboCentroAcopio" runat="server" CssClass="combo" 
            DataTextField="cea_Descripcion" DataValueField="cea_Id">
        </asp:DropDownList>
    </td>
    </tr>
    <tr>
        <td style="width:20%">
            <asp:Label ID="labelFechaInicial" runat="server" Text="Fecha inicial" CssClass="label"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="textFechaInicial" runat="server"  CssClass="texto2"></asp:TextBox>
            <cc1:CalendarExtender ID="calendarfecha" Format="dd/MM/yyyy"  runat="server" CssClass="calendar" TargetControlID="textFechaInicial">
            </cc1:CalendarExtender>
        </td>
        <td style="width:20%">
            <asp:Label ID="label1" runat="server" Text="Fecha final" CssClass="label"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="textFechaFinal" runat="server"  CssClass="texto2"></asp:TextBox>
            <cc1:CalendarExtender ID="CalendarExtender1" Format="dd/MM/yyyy"  runat="server" CssClass="calendar" TargetControlID="textFechaFinal">
            </cc1:CalendarExtender>
        </td>
     </tr>
    <tr>
    <td class="separador"></td>
    </tr>    
    <tr>
    <td colspan="5">
    <asp:Button ID="buttonBuscar" runat="server" Text="Buscar" CssClass="button" onclick="buttonBuscar_Click" 
             />&nbsp;&nbsp;
    <asp:Button ID="buttonAdicionar" runat="server" Text="Adicionar"  
            CssClass="button" onclick="buttonAdicionar_Click"/>
    </td>
    </tr>
<tr>
    <td colspan="5">
    <div class="divgrillassinmargin">
    <asp:GridView ID="gridBuscar" runat="server" CssClass="grilla" 
    HeaderStyle-CssClass="headergrilla" RowStyle-CssClass="rowgrilla" 
    SelectedRowStyle-CssClass="selectedgrilla" 
    FooterStyle-CssClass="footergrilla" 
            onrowcommand="gridBuscarSolicitudEquipos_RowCommand" DataKeyNames="Id" 
            AllowPaging="True" DataSourceID="CentroAcopioBuscarDataSource" 
            PageSize="15" AutoGenerateColumns="False" 
            EmptyDataText="La búsqueda no arrojó resultados">
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
            <asp:BoundField DataField="Centro" HeaderText="Centro" SortExpression="Centro" />
            <asp:BoundField DataField="Periodo" HeaderText="Periodo" SortExpression="Periodo" 
                 />
        </Columns>

    <FooterStyle CssClass="footergrilla"></FooterStyle>

    <SelectedRowStyle CssClass="selectedgrilla"></SelectedRowStyle>

    <HeaderStyle CssClass="headergrilla"></HeaderStyle>
    </asp:GridView>
        <asp:SqlDataSource ID="CentroAcopioBuscarDataSource" runat="server" 
            ConnectionString="<%$ ConnectionStrings:BDUTOConnectionString %>" 
            SelectCommand="exec [Rrr].[spReporteCentroAcopioBuscar] @centro,@fechaInicial,@fechaFinal">
            <SelectParameters>
                <asp:Parameter Name="centro" />
                <asp:Parameter Name="fechaInicial" />
                <asp:Parameter Name="fechaFinal" />
            </SelectParameters>
        </asp:SqlDataSource>
    </div>
    </td>
    </tr>    
    </table>    
    </td>
    </tr>
    </table>      
    </asp:Content>