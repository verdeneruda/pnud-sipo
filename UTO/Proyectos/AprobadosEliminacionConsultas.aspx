    <%@ Page Language="C#" MasterPageFile="~/MPMain.Master"  AutoEventWireup="true" CodeBehind="AprobadosEliminacionConsultas.aspx.cs" Inherits="UTO.Proyectos.AprobadosEliminacionConsultas" %>

    <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
    <asp:Content ID="contentProyectosAprobadosConsultasHead" ContentPlaceHolderID="head" Runat="Server">
    </asp:Content>
    <asp:Content  ID="contentProyectosAprobadosConsultas" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
        <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
        </cc1:ToolkitScriptManager>
    <div class="divwithoutgrid">
    <table class="titulo" >
    <tr><td>
    <asp:Label ID="labelConsultas" runat="server" 
            Text="Módulo proyectos aprobados de eliminación - Consultas" 
            CssClass="subtitulo"></asp:Label>
    </td></tr>
    </table>
    <br />
    <table class="form">
    <tr>
    <td>
    <table style="width:100%;"> 
    <tr><th colspan="5">
    <asp:Label ID="labelProyectos" runat="server" Text="Proyectos" CssClass="subtitulo"></asp:Label>
    </th></tr>
    <tr>
    <td style="width:25%">
    <asp:Label ID="labelTipoProyecto" runat="server" Text="Tipo proyecto"></asp:Label>
    </td>
    <td>
    <asp:DropDownList ID="comboTipoProyecto" runat="server" CssClass="combo" DataTextField="pti_Descripcion" 
    DataValueField="pti_Id">
    </asp:DropDownList>
    </td>
    <td class="separador"></td>
    <td> 
    <asp:Label ID="labelSectorProyecto" runat="server" Text="Sector proyecto"></asp:Label>
    </td>
    <td>
    <asp:DropDownList ID="comboSector" runat="server" CssClass="combo" DataTextField="pse_Descripcion" 
    DataValueField="pse_Id">
    </asp:DropDownList>
    </td>
    </tr>
    <tr>
    <td style="width:25%">
    <asp:Label ID="labelNombreProyecto" runat="server" Text="Nombre proyecto" CssClass="label"></asp:Label>
    </td>
    <td colspan="4">
    <asp:TextBox ID="textNombreProyecto" runat="server" CssClass="texto2" Height="21px" 
            Width="487px"></asp:TextBox>
    </td>
    </tr>
    <tr>
    <td>
    <asp:Label ID="labelDepartamento" runat="server" Text="Departamento"></asp:Label>
    </td>
    <td>
    <asp:DropDownList ID="comboDepartamento" runat="server" CssClass="combo" DataTextField="dep_Descripcion" 
    DataValueField="dep_Id" AutoPostBack="True" 
            onselectedindexchanged="comboDepartamento_SelectedIndexChanged">
    </asp:DropDownList>
    </td>
    <td class="separador">
    </td>
    <td>
    <asp:Label ID="labelCiudad" runat="server" Text="Ciudad"></asp:Label>
    </td>
    <td>
    <asp:DropDownList ID="comboCiudad" runat="server" CssClass="combo" 
            DataTextField="mun_Descripcion" DataValueField="mun_Id">
    </asp:DropDownList>
    </td>
    </tr>
    <tr>
    <td>
    <asp:Label ID="labelFechaInicial" runat="server" Text="Fecha Inicial"></asp:Label>
    </td>
    <td>
    <asp:TextBox ID="textFechaInicial" runat="server" CssClass="texto2"></asp:TextBox>
    <cc1:CalendarExtender ID="calendarfechaInicial" Format="dd/MM/yyyy" runat="server" TargetControlID="textFechaInicial" CssClass="calendar">
    </cc1:CalendarExtender>
    </td>
    <td class="separador">
    </td>
    <td>
    <asp:Label ID="labelFechaFinal" runat="server" Text="Fecha final"></asp:Label>
    </td>
    <td>
    <asp:TextBox ID="textFechaFinal" runat="server" CssClass="texto2"></asp:TextBox>
    <cc1:CalendarExtender ID="calendarfechafinal" runat="server" TargetControlID="textfechafinal" Format="dd/MM/yyyy" CssClass="calendar">
    </cc1:CalendarExtender>
    </td>
    </tr>
    <tr>
    <td colspan="5">
    <asp:Button ID="buttonBuscar" runat="server" Text="Buscar" CssClass="button" 
            onclick="buttonBuscar_Click"/>&nbsp;&nbsp;<asp:Button ID="buttonExportar"
    runat="server" Text="Exportar" CssClass="button" onclick="buttonExportar_Click" 
            Visible="False" />&nbsp;&nbsp;<asp:Button ID="buttonCancelar"
    runat="server" Text="Cancelar" CssClass="button" />
    </td>
    </tr>
    </table>
    </td>
    </tr>
    </table>
    </div>
    <br />
    <div class="divgrillas">
    <asp:GridView ID="gridConsultasProyectos" runat="server" HeaderStyle-CssClass="headergrilla" 
    RowStyle-CssClass="rowgrilla" FooterStyle-CssClass="footergrilla" 
    CssClass="grilla" 
    SelectedRowStyle-CssClass="selectedgrilla" AutoGenerateColumns="False" 
            DataKeyNames="Id" DataSourceID="aprobadosEliminacionConsultasDataSource">
    <RowStyle CssClass="rowgrilla"></RowStyle>
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" 
                ReadOnly="True" SortExpression="Id" />
            <asp:BoundField DataField="Sector" HeaderText="Sector" 
                SortExpression="Sector" />
            <asp:BoundField DataField="Tipo" HeaderText="Tipo" SortExpression="Tipo" />
            <asp:BoundField DataField="Agencia" HeaderText="Agencia" 
                SortExpression="Agencia" />
            <asp:BoundField DataField="Compañía" HeaderText="Compañía" 
                SortExpression="Compañía" />
            <asp:BoundField DataField="Nombre del proyecto" 
                HeaderText="Nombre del proyecto" SortExpression="Nombre del proyecto" />
            <asp:BoundField DataField="Código" HeaderText="Código" 
                SortExpression="Código" />
            <asp:BoundField DataField="Aprobados FMPM (US$)" 
                HeaderText="Aprobados FMPM (US$)" SortExpression="Aprobados FMPM (US$)" />
            <asp:BoundField DataField="Desembolsados FMPM (US$)" 
                HeaderText="Desembolsados FMPM (US$)" 
                SortExpression="Desembolsados FMPM (US$)" />
            <asp:BoundField DataField="US$ invertidos" HeaderText="US$ invertidos" 
                SortExpression="US$ invertidos" />
            <asp:BoundField DataField="Departamento" HeaderText="Departamento" 
                SortExpression="Departamento" />
            <asp:BoundField DataField="Municipio" HeaderText="Municipio" 
                SortExpression="Municipio" />
            <asp:BoundField DataField="ODP a eliminar" HeaderText="ODP a eliminar" 
                SortExpression="ODP a eliminar" />
            <asp:BoundField DataField="ODP eliminadas" HeaderText="ODP eliminadas" 
                SortExpression="ODP eliminadas" />
            <asp:BoundField DataField="Fecha aprobación" HeaderText="Fecha aprobación" 
                SortExpression="Fecha aprobación" />
            <asp:BoundField DataField="Fecha terminación" HeaderText="Fecha terminación" 
                SortExpression="Fecha terminación" />
            <asp:BoundField DataField="Fecha terminación real" 
                HeaderText="Fecha terminación real" SortExpression="Fecha terminación real" />
            <asp:BoundField DataField="Estado actual" HeaderText="Estado actual" 
                SortExpression="Estado actual" />
            <asp:BoundField DataField="Observaciones del proyecto" 
                HeaderText="Observaciones del proyecto" 
                SortExpression="Observaciones del proyecto" />
        </Columns>
    <FooterStyle CssClass="footergrilla"></FooterStyle>
    <SelectedRowStyle CssClass="selectedgrilla" />
    <HeaderStyle CssClass="headergrilla"></HeaderStyle>
    </asp:GridView>
        <asp:SqlDataSource ID="aprobadosEliminacionConsultasDataSource" runat="server" 
            ConnectionString="<%$ ConnectionStrings:BDUTOConnectionString %>" 
            SelectCommand="exec [Pro].[spProyectoConsulta] @nombre,@tipo,@departamento,@municipio,@sector">
            <SelectParameters>
                <asp:Parameter Name="nombre" />
                <asp:Parameter Name="tipo" />
                <asp:Parameter Name="departamento" />
                <asp:Parameter Name="municipio" />
                <asp:Parameter Name="sector" />
            </SelectParameters>
        </asp:SqlDataSource>
    </div>
    <br />
    </asp:Content>
