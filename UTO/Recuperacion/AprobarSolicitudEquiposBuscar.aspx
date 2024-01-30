<%@ Page Language="C#" MasterPageFile="~/MPMain.Master"  AutoEventWireup="true" CodeBehind="AprobarSolicitudEquiposBuscar.aspx.cs" Inherits="UTO.Recuperacion.AprobarSolicitudEquiposBuscar" %>

    <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

    <%@ Register src="../Comunes/ControlError.ascx" tagname="ControlError" tagprefix="uc1" %>

    <asp:Content  ID="contentSolicitudEquiposBuscar" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
        
        <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </cc1:ToolkitScriptManager>
    <div class="divwithoutgrid">
    <table class="titulo" >
        <tr><td>
        <asp:Label ID="labelBusquedaSolicitudesEquipos" runat="server" Text="Proyectos de dotación de equipos y herramientas  para el sector de refrigeración y aire acondicionado - Buscar solicitud equipos" CssClass="subtitulo"></asp:Label>
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
    <asp:Label ID="labelDepartamento" runat="server" CssClass="label" 
    Text="Departamento"></asp:Label>
    </td>
    <td>
    <asp:DropDownList ID="comboDepartamento" runat="server" CssClass="combo" DataTextField="dep_Descripcion" 
    DataValueField="dep_Id" Width="172px">
    </asp:DropDownList>
    </td>
    <td style="width:20%">
    <asp:Label ID="labelCiudad" runat="server" CssClass="label" Text="Ciudad"></asp:Label>
    </td>
    <td>
    <asp:DropDownList ID="comboCiudad" runat="server" CssClass="combo" 
            DataTextField="mun_Descripcion" DataValueField="mun_Id" 
            Width="301px">
    </asp:DropDownList>
    </td>
    <td class="separador">&nbsp;</td>
    </tr>
    <tr>
    <td>
    <asp:Label ID="labelRegional" runat="server" Text="Regional" CssClass="label"></asp:Label>
    </td>
    <td>
        <asp:DropDownList ID="comboRegional" runat="server" CssClass="combo" 
            DataTextField="reg_descripcion" DataValueField="reg_Id">
        </asp:DropDownList>
    </td>
    <td style="width:20%">
        <asp:Label ID="labelNombreBeneficiario" runat="server" Text="Nombre beneficiario" CssClass="label"></asp:Label>
    </td>
    <td>
        <asp:TextBox ID="textNombreBeneficiario" runat="server"  CssClass="texto2" 
            Width="300px"></asp:TextBox>
    </td>
    <td class="separador"></td>
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
        <td>
            <asp:Label ID="label2" runat="server" Text="Estado" CssClass="label"></asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="comboEstado" runat="server" CssClass="combo" 
                DataTextField="ses_Descripcion" DataValueField="ses_Id">
            </asp:DropDownList>
        </td>        
        <td>
            <asp:Label ID="label3" runat="server" Text="Tipo de solicitud" CssClass="label"></asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="comboTipo" runat="server" CssClass="combo">
                <asp:ListItem Value="2">Todos</asp:ListItem>
                <asp:ListItem Value="0">Local</asp:ListItem>
                <asp:ListItem Value="1">Nacional</asp:ListItem>
            </asp:DropDownList>
        </td>                
    </tr>
     <tr ID="proyecto" runat="server">
        <td>
            <asp:Label ID="label4" runat="server" Text="Proyecto" CssClass="label"></asp:Label>
        </td>
        <td colspan="3">
            <asp:DropDownList ID="comboProyecto" runat="server" CssClass="combo" 
                DataTextField="pre_Descripcion" DataValueField="pre_Id" width="400px" onselectedindexchanged="comboProyecto_SelectedIndexChanged"
                >
            </asp:DropDownList>
        </td>        
    </tr>        
    <tr>
    <td class="separador"></td>
    </tr>
    <tr>
    <td colspan="5">
    <asp:Button ID="buttonBuscar" runat="server" Text="Buscar" CssClass="button" 
            onclick="buttonBuscar_Click" />&nbsp;</td>
    </tr>
    </table>
    </td>
    </tr>
    </table>
    </div>
    <br />
    <div class="divgrillas">
    <asp:GridView ID="gridBuscarSolicitudEquipos" runat="server" CssClass="grilla" 
    HeaderStyle-CssClass="headergrilla" RowStyle-CssClass="rowgrilla" 
    SelectedRowStyle-CssClass="selectedgrilla" 
    FooterStyle-CssClass="footergrilla" 
            onrowcommand="gridBuscarSolicitudEquipos_RowCommand" DataKeyNames="Id" 
            AllowPaging="True" DataSourceID="aprobarSolicitudEquiposBuscarDataSource" 
            PageSize="15" AutoGenerateColumns="False">
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
            <asp:BoundField DataField="Fecha solicitud" HeaderText="Fecha solicitud" 
                SortExpression="Fecha solicitud" DataFormatString="{0:d/M/yyyy}" />
            <asp:BoundField DataField="Regional" HeaderText="Regional" 
                SortExpression="Regional" />
            <asp:BoundField DataField="Beneficiario" HeaderText="Beneficiario" 
                SortExpression="Beneficiario" />
            <asp:BoundField DataField="Departamento" HeaderText="Departamento" 
                SortExpression="Departamento" />
            <asp:BoundField DataField="Municipio" HeaderText="Municipio" 
                SortExpression="Municipio" />
            <asp:BoundField DataField="Estado" HeaderText="Estado" 
                SortExpression="Estado" />
        </Columns>

    <FooterStyle CssClass="footergrilla"></FooterStyle>

    <SelectedRowStyle CssClass="selectedgrilla"></SelectedRowStyle>

    <HeaderStyle CssClass="headergrilla"></HeaderStyle>
    </asp:GridView>
        <asp:SqlDataSource ID="aprobarSolicitudEquiposBuscarDataSource" runat="server" 
            ConnectionString="<%$ ConnectionStrings:BDUTOConnectionString %>" 
            
            SelectCommand="exec [Rrr].[spSolicitudEquipoBuscar] @departamento,@municipio,@regional,@beneficiario,@fechaInicial,@fechaFinal,@estado,@tipo,@proyecto">
            <SelectParameters>
                <asp:Parameter Name="departamento" />
                <asp:Parameter Name="municipio" />
                <asp:Parameter Name="regional" />
                <asp:Parameter Name="beneficiario" />
                <asp:Parameter Name="fechaInicial" />
                <asp:Parameter Name="fechaFinal" />
                <asp:Parameter Name="estado" />
                <asp:Parameter Name="tipo" />
                <asp:Parameter Name="proyecto" />
            </SelectParameters>
        </asp:SqlDataSource>
    </div>
    <br />
    </asp:Content>
