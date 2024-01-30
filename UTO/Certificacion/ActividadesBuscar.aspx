<%@ Page Language="C#" MasterPageFile="~/MPMain.Master" AutoEventWireup="true" CodeBehind="ActividadesBuscar.aspx.cs" Inherits="UTO.Certificacion.BuscarActividades" %>

<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Src="../Comunes/ControlError.ascx" TagName="ControlError" TagPrefix="uc1" %>
<asp:Content ID="contentBuscarActividadesHead" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .ajax__calendar_container {
            padding: 4px;
            position: absolute;
            cursor: default;
            width: 270px;
            font-size: 11px;
            text-align: center;
            font-family: tahoma,verdana,helvetica;
        }

        .ajax__calendar_body {
            height: 139px;
            width: 270px;
            position: relative;
            overflow: hidden;
            margin: auto;
        }

        .ajax__calendar_days, .ajax__calendar_months, .ajax__calendar_years {
            top: 0px;
            left: 0px;
            height: 139px;
            width: 270px;
            position: absolute;
            text-align: center;
            margin: auto;
        }

        .ajax__calendar_container TABLE {
            font-size: 11px;
        }

        .ajax__calendar_header {
            height: 20px;
            width: 100%;
        }

        .ajax__calendar_prev {
            cursor: pointer;
            width: 15px;
            height: 15px;
            float: left;
            background-repeat: no-repeat;
            background-position: 50% 50%;
            background-image: url(WebResource.axd?d=vuxhVfo1YLyjqq0iGRXgQLQX43rVnAr0061zfFv0yrJptA2vlKQIjqV6bQH7kcz62NSlNo4XlKkgaWR89p2wWS0-_eYynob71_2kyJ_BbCehN90iBwIVlHvOujE4LEMnC_XgRxhDLUgjt5q6z-RyhBJEqA0I88WHStYXd8XDskQ1&t=633885366380000000);
        }

        .ajax__calendar_next {
            cursor: pointer;
            width: 15px;
            height: 15px;
            float: right;
            background-repeat: no-repeat;
            background-position: 50% 50%;
            background-image: url(WebResource.axd?d=1vEP8Pv3XMqD6PfaIev5s6qGIqSFwx2eI9GjFosFKgLLJo8GkIOA59ujgqiG0gCg8XxgaPKCBQazTqQPIxNumjgdpN7yZMBP2ZzOnYX70AkEhvKWlRzNTNKTKL36xKq8nFeBI-IuZ7k4FJoWSKj4oxp2Bnx546ji6VGnO1TwPsM1&t=633885366380000000);
        }

        .ajax__calendar_title {
            cursor: pointer;
            font-weight: bold;
        }

        .ajax__calendar_footer {
            height: 15px;
        }

        .ajax__calendar_today {
            cursor: pointer;
            padding-top: 3px;
        }

        .ajax__calendar_dayname {
            height: 17px;
            width: 17px;
            text-align: right;
            padding: 0 2px;
        }

        .ajax__calendar_day {
            height: 17px;
            width: 18px;
            text-align: right;
            padding: 0 2px;
            cursor: pointer;
        }

        .ajax__calendar_month {
            height: 44px;
            width: 40px;
            text-align: center;
            cursor: pointer;
            overflow: hidden;
        }

        .ajax__calendar_year {
            height: 44px;
            width: 40px;
            text-align: center;
            cursor: pointer;
            overflow: hidden;
        }

        .ajax__calendar .ajax__calendar_container {
            border: 1px solid #646464;
            background-color: #ffffff;
            color: #000000;
        }

        .ajax__calendar .ajax__calendar_footer {
            border-top: 1px solid #f5f5f5;
        }

        .ajax__calendar .ajax__calendar_dayname {
            border-bottom: 1px solid #f5f5f5;
        }

        .ajax__calendar .ajax__calendar_day {
            border: 1px solid #ffffff;
        }

        .ajax__calendar .ajax__calendar_month {
            border: 1px solid #ffffff;
        }

        .ajax__calendar .ajax__calendar_year {
            border: 1px solid #ffffff;
        }

        .ajax__calendar .ajax__calendar_active .ajax__calendar_day {
            background-color: #edf9ff;
            border-color: #0066cc;
            color: #0066cc;
        }

        .ajax__calendar .ajax__calendar_active .ajax__calendar_month {
            background-color: #edf9ff;
            border-color: #0066cc;
            color: #0066cc;
        }

        .ajax__calendar .ajax__calendar_active .ajax__calendar_year {
            background-color: #edf9ff;
            border-color: #0066cc;
            color: #0066cc;
        }

        .ajax__calendar .ajax__calendar_other .ajax__calendar_day {
            background-color: #ffffff;
            border-color: #ffffff;
            color: #646464;
        }

        .ajax__calendar .ajax__calendar_other .ajax__calendar_year {
            background-color: #ffffff;
            border-color: #ffffff;
            color: #646464;
        }

        .ajax__calendar .ajax__calendar_hover .ajax__calendar_day {
            background-color: #edf9ff;
            border-color: #daf2fc;
            color: #0066cc;
        }

        .ajax__calendar .ajax__calendar_hover .ajax__calendar_month {
            background-color: #edf9ff;
            border-color: #daf2fc;
            color: #0066cc;
        }

        .ajax__calendar .ajax__calendar_hover .ajax__calendar_year {
            background-color: #edf9ff;
            border-color: #daf2fc;
            color: #0066cc;
        }

        .ajax__calendar .ajax__calendar_hover .ajax__calendar_title {
            color: #0066cc;
        }

        .ajax__calendar .ajax__calendar_hover .ajax__calendar_today {
            color: #0066cc;
        }
    </style>
    <script type="text/javascript">

        function exportar() {
            window.open('data:application/vnd.ms-excel,' + document.getElementById("<% =gridBuscarActividades.ClientID %>").innerHTML);
        }

    </script>
</asp:Content>
<asp:Content ID="contentBuscarActividades" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="divwithoutgrid">
        <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
        </cc1:ToolkitScriptManager>
        <table class="titulo">
            <tr>
                <td>
                    <asp:Label ID="labelBusquedaActividad" runat="server" Text="Módulo actividades - Buscar actividades" CssClass="subtitulo"></asp:Label>
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
                    <table style="width: 100%">
                        <tr>
                            <th colspan="5">
                                <asp:Label ID="labelparametros" runat="server" Text="Parámetros búsqueda" CssClass="subtitulo"></asp:Label>
                            </th>
                        </tr>

                        <tr>
                            <td style="width: 20%">
                                <asp:Label ID="labelFechaInicio" runat="server" Text="Fecha inicio" CssClass="label"></asp:Label>
                            </td>
                            <td class="style1">
                                <asp:TextBox ID="textFechaInicio" runat="server" CssClass="texto2"></asp:TextBox>
                                <%--                <cc1:CalendarExtender ID="calendarFechaInicios" Format="dd/MM/yyyy" runat="server" Enabled="true" CssClass="calendar" TargetControlID="textFechaInicio">
                </cc1:CalendarExtender>--%>
                                <cc1:CalendarExtender ID="CalendarExtender3" runat="server" Format="dd/MM/yyyy" TargetControlID="textFechaInicio" Enabled="True" DefaultView="Days" PopupPosition="BottomLeft">
                                </cc1:CalendarExtender>
                            </td>
                            <%--            <td class="separador">
            </td>--%>
                            <td style="width: 20%">
                                <asp:Label ID="labelFechaFinal" runat="server" Text="Fecha final" CssClass="label"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="textFechaFinal" runat="server" CssClass="texto2"></asp:TextBox>
                                <cc1:CalendarExtender ID="calendarFechaFinal" Format="dd/MM/yyyy" runat="server" Enabled="true" CssClass="calendar" TargetControlID="textFechaFinal">
                                </cc1:CalendarExtender>
                            </td>
                        </tr>

                        <tr>
                            <td>
                                <asp:Label ID="labelDepartamento" runat="server" Text="Departamento" CssClass="label"></asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="comboDepartamento" runat="server"
                                    CssClass="combo" AutoPostBack="True" DataTextField="dep_Descripcion"
                                    DataValueField="dep_Id"
                                    OnSelectedIndexChanged="comboDepartamento_SelectedIndexChanged">
                                </asp:DropDownList>
                            </td>
                            <%--            <td class="separador">
            </td>--%>
                            <td>
                                <asp:Label ID="labelCiudad" runat="server" Text="Municipio" CssClass="label"></asp:Label>
                            </td>
                            <td>
                                <asp:UpdatePanel runat="server" UpdateMode="Conditional">
                                    <ContentTemplate>
                                        <asp:DropDownList ID="comboCiudad" runat="server"
                                            CssClass="combo" AutoPostBack="True" DataTextField="mun_Descripcion"
                                            DataValueField="mun_Id">
                                        </asp:DropDownList>
                                    </ContentTemplate>
                                    <Triggers>
                                        <asp:AsyncPostBackTrigger ControlID="comboDepartamento" />
                                    </Triggers>
                                </asp:UpdatePanel>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="label1" runat="server" Text="Actividad" CssClass="label"></asp:Label>
                            </td>
                            <td colspan="3">
                                <asp:DropDownList ID="comboActividad" runat="server" CssClass="combo"
                                    DataTextField="ati_Descripcion" DataValueField="ati_Id">
                                </asp:DropDownList>
                            </td>
                        </tr>

                        <tr>
                            <td colspan="4">
                                <asp:Button ID="buttonBuscar" runat="server" Text="Buscar" CssClass="button"
                                    OnClick="buttonBuscar_Click" />&nbsp;&nbsp;<asp:Button
                                        ID="buttonAdicionar" runat="server" Text="Adicionar" CssClass="button"
                                        OnClick="buttonAdicionar_Click" /><asp:HiddenField runat="server" ID="hiddenConfirma" />
                                <asp:Button ID="buttonExportar" runat="server" Text="Exportar" OnClick="buttonExportar_Click" CssClass="button" />
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </div>
    <div>
        <dx:ASPxGridView ID="gvConsulta" runat="server" DataSourceID="actividadesdatasource" SettingsPager-PageSize="20" Width="500px" Visible="False">
        </dx:ASPxGridView>
        <dx:ASPxGridViewExporter ID="exportGrid" ExportedRowType="All" GridViewID="gvConsulta"
            runat="server">
        </dx:ASPxGridViewExporter>
    </div>
    <br />
    <asp:UpdatePanel runat="server" UpdateMode="Conditional" ID="updateBuscarActividades">
        <ContentTemplate>
            <asp:GridView ID="gridBuscarActividades" runat="server" CssClass="grilla"
                HeaderStyle-CssClass="headergrilla" RowStyle-CssClass="rowgrilla" AutoGenerateColumns="False"
                SelectedRowStyle-CssClass="selectedgrilla" FooterStyle-CssClass="footergrilla"
                OnRowCommand="gridBuscarActividades_RowCommand" DataKeyNames="Id"
                AllowPaging="True" DataSourceID="actividadesdatasource" PageSize="15">
                <RowStyle CssClass="rowgrilla"></RowStyle>
                <Columns>
                    <asp:ButtonField ButtonType="Button" CommandName="Ver"
                        ShowHeader="True" Text="Ver">
                        <ControlStyle CssClass="buttongrilla" />
                    </asp:ButtonField>
                    <asp:ButtonField CommandName="Modificar" ShowHeader="True"
                        Text="Modificar" ButtonType="Button">
                        <ControlStyle CssClass="buttongrilla" />
                    </asp:ButtonField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button runat="server" ID="buttonEliminar" Text="Eliminar" CommandName="Eliminar" CommandArgument="<%# Container.DataItemIndex %>" OnClientClick="return confirm('Este registro se eliminará, desea continuar?')" CssClass="buttongrilla" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="Fecha" HeaderText="Fecha"
                        SortExpression="Fecha" DataFormatString="{0:dd/MM/yyyy}" />
                    <asp:BoundField DataField="Tipo_Actividad" HeaderText="Tipo de actividad"
                        SortExpression="Tipo_Actividad" />
                    <asp:BoundField DataField="Actividad" HeaderText="Actividad"
                        SortExpression="Actividad" />
                    <asp:BoundField DataField="Entidades_Involucradas"
                        HeaderText="Entidades involucradas"
                        SortExpression="Entidades_Involucradas" />
                    <asp:BoundField DataField="Personas_Impactadas"
                        HeaderText="Personas impactadas" SortExpression="Personas_Impactadas" />
                    <asp:BoundField DataField="Modificado" HeaderText="Modificado"
                        SortExpression="Modificado" DataFormatString="{0:dd/MM/yyyy}" />
                    <asp:BoundField DataField="Id" HeaderText="Id" />
                    <asp:BoundField DataField="Departamento" HeaderText="Departamento"
                        SortExpression="Departamento" />
                    <asp:BoundField DataField="Municipio" HeaderText="Municipio"
                        SortExpression="Municipio" />
                </Columns>

                <FooterStyle CssClass="footergrilla"></FooterStyle>

                <SelectedRowStyle CssClass="selectedgrilla"></SelectedRowStyle>

                <HeaderStyle CssClass="headergrilla"></HeaderStyle>
            </asp:GridView>
        </ContentTemplate>
    </asp:UpdatePanel>

    <asp:SqlDataSource ID="actividadesdatasource" runat="server"
        ConnectionString="<%$ ConnectionStrings:BDUTOConnectionString %>" SelectCommand="exec [cer].[spActividadesBuscar]
@fechaIni, @fechaFin, @departamento , @municipio ,@actividad">
        <SelectParameters>
            <asp:Parameter Name="fechaIni" />
            <asp:Parameter Name="fechaFin" />
            <asp:Parameter Name="departamento" />
            <asp:Parameter Name="municipio" />
            <asp:Parameter Name="actividad" />
        </SelectParameters>
    </asp:SqlDataSource>
</asp:Content>
