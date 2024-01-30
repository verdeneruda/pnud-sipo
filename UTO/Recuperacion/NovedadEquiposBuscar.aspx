<%@ Page Language="C#" MasterPageFile="~/MPMain.Master"  AutoEventWireup="true" CodeBehind="NovedadEquiposBuscar.aspx.cs" Inherits="UTO.Recuperacion.NovedadEquiposBuscar" %>

    <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

    <%@ Register src="../Comunes/ControlError.ascx" tagname="ControlError" tagprefix="uc1" %>

    <asp:Content  ID="contentNovedadEquiposBuscar" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
           
    <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </cc1:ToolkitScriptManager>
    <div class="divwithoutgrid">
    
    <table class="titulo" >
        <tr><td>
        <asp:Label ID="labelNovedadEquiposBuscar" runat="server" Text="Proyectos de dotación de equipos y herramientas  para el sector de refrigeración y aire acondicionado - Buscar novedades equipos" CssClass="subtitulo"></asp:Label>
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
    DataValueField="dep_Id" Width="172px" AutoPostBack="True" 
            onselectedindexchanged="comboDepartamento_SelectedIndexChanged">
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
            DataTextField="reg_Descripcion" DataValueField="reg_Id">
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
            <asp:Label ID="labelTipoNovedad" runat="server" Text="Tipo novedad" 
                CssClass="label"></asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="comboTipoNovedad" runat="server" CssClass="combo" DataTextField="nti_Descripcion" 
                DataValueField="nti_Id">
            </asp:DropDownList>
        </td>        
                <td>
            <asp:Label ID="label2" runat="server" Text="Número de comodato" 
                CssClass="label"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="textComodato" runat="server"  CssClass="texto2" MaxLength="30"></asp:TextBox>
        </td> 
    </tr>
    <tr>
    <td class="separador"></td>
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
    <asp:GridView ID="gridBuscarNovedadesEquipos" runat="server" CssClass="grilla" 
    HeaderStyle-CssClass="headergrilla" RowStyle-CssClass="rowgrilla" 
    SelectedRowStyle-CssClass="selectedgrilla" 
    FooterStyle-CssClass="footergrilla" 
            onrowcommand="gridBuscarNovedadesEquipos_RowCommand" DataKeyNames="Id" 
            AllowPaging="True" DataSourceID="novedadEquiposBuscarDataSource" 
            PageSize="15" AutoGenerateColumns="False">
    <RowStyle CssClass="rowgrilla"></RowStyle>
        <Columns>
            <asp:ButtonField CommandName="Modificar" ShowHeader="True" 
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
        
            <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" 
                ReadOnly="True" SortExpression="Id" Visible="False" />
            <asp:BoundField DataField="Fecha novedad" HeaderText="Fecha novedad" 
                SortExpression="Fecha novedad" DataFormatString="{0:dd/MM/yyyy}" />
            <asp:BoundField DataField="Regional" HeaderText="Regional" 
                SortExpression="Regional" />
            <asp:BoundField DataField="Beneficiario" HeaderText="Beneficiario" 
                SortExpression="Beneficiario" />
            <asp:BoundField DataField="Departamento" HeaderText="Departamento" 
                SortExpression="Departamento" />
            <asp:BoundField DataField="Municipio" HeaderText="Municipio" 
                SortExpression="Municipio" />
            <asp:BoundField DataField="Novedad" HeaderText="Novedad" 
                SortExpression="Novedad" />
        </Columns>

    <FooterStyle CssClass="footergrilla"></FooterStyle>

    <SelectedRowStyle CssClass="selectedgrilla"></SelectedRowStyle>

    <HeaderStyle CssClass="headergrilla"></HeaderStyle>
    </asp:GridView>
        <asp:SqlDataSource ID="novedadEquiposBuscarDataSource" runat="server" 
            ConnectionString="<%$ ConnectionStrings:BDUTOConnectionString %>" 
            
            SelectCommand="exec [Rrr].[spNovedadEquipoBuscar] @departamento,@municipio,@regional,@beneficiario,@fechaInicial,@fechaFinal,@tipoNovedad,@comodato">
            <SelectParameters>
                <asp:Parameter Name="departamento" />
                <asp:Parameter Name="municipio" />
                <asp:Parameter Name="regional" />
                <asp:Parameter Name="beneficiario" />
                <asp:Parameter Name="fechaInicial" />
                <asp:Parameter Name="fechaFinal" />
                <asp:Parameter Name="tipoNovedad" />
                <asp:Parameter Name="comodato" />
            </SelectParameters>
        </asp:SqlDataSource>
    </div>
    <br />
    </asp:Content>
