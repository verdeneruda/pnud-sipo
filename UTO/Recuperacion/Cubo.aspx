<%@ Page Language="C#" MasterPageFile="~/MPPivot.Master" AutoEventWireup="true" CodeBehind="Cubo.aspx.cs" Inherits="UTO.Recuperacion.Cubo" Title="Untitled Page" UICulture="es" %>
<%@ Register assembly="DevExpress.Web.ASPxPivotGrid.v15.1, Version=15.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxPivotGrid" tagprefix="dx" %>
    
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="divwithoutgrid">
    <table class="titulo" >
    <tr><td>
    <asp:Label ID="labelConsultas" runat="server" 
            Text="Recuperación, reciclaje y regeneración de gases refrigerantes - Cubos" 
            CssClass="subtitulo"></asp:Label>
    </td></tr>
    </table>
</div>
<br />
<table class="consulta">
    <tr>
        <td>
            <table style="width:100%;"> 
                <tr>
                    <td>
                    <asp:Label ID="labelSeleccioneConsultas" runat="server" Text="Seleccione consulta" CssClass="labelconsulta"></asp:Label>
                    </td>
                    <td>
                    <asp:DropDownList ID="comboTipoConsulta" runat="server" 
                            DataTextField="cip_Descripcion" DataValueField="cip_Id" 
                    AutoPostBack="True" onselectedindexchanged="comboTipoConsulta_SelectedIndexChanged" CssClass="combo" 
                            Width="270px">
                        <asp:ListItem Value="-1">Seleccione...</asp:ListItem>
                        <asp:ListItem Value="2">Reporte de uso</asp:ListItem>
<%--                        <asp:ListItem Value="2">Centro regeneración</asp:ListItem>--%>
                        <asp:ListItem Value="3">Equipos asignados</asp:ListItem>
                    </asp:DropDownList>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
</table>
<asp:Panel ID="PanelCuboImportador" runat="server" Visible="False">
  <table>
    <tr>
        <td>

            <dx:ASPxPivotGrid ID="ASPxPivotGrid3" runat="server" 
                DataSourceID="SqlDataCuboImportacion">
                <Fields>
                    <dx:PivotGridField ID="fieldRegional" AreaIndex="0" FieldName="Regional">
                    </dx:PivotGridField>
                    <dx:PivotGridField ID="fieldBeneficiario" AreaIndex="1" FieldName="Beneficiario">
                    </dx:PivotGridField>
                    <dx:PivotGridField ID="fieldDepartamento" AreaIndex="2" FieldName="Departamento">
                    </dx:PivotGridField>
                    <dx:PivotGridField ID="fieldMunicipio" AreaIndex="3" FieldName="Municipio">
                    </dx:PivotGridField>
                    <dx:PivotGridField ID="fieldCantidadEquipo" AreaIndex="4" FieldName="Cantidad equipo">
                    </dx:PivotGridField>
                    <dx:PivotGridField ID="fieldEquipo" AreaIndex="5" FieldName="Equipo">
                    </dx:PivotGridField>
                    <dx:PivotGridField ID="fieldCostoEquipo" AreaIndex="6" FieldName="Costo Equipo">
                    </dx:PivotGridField>
                    <dx:PivotGridField ID="fieldValorTotalAsignado" AreaIndex="7" FieldName="Valor total asignado">
                    </dx:PivotGridField>
                    <dx:PivotGridField ID="fieldTipoGas" AreaIndex="8" FieldName="Tipo gas">
                    </dx:PivotGridField>
                    <dx:PivotGridField ID="fieldUsoGas" AreaIndex="9" FieldName="Uso gas">
                    </dx:PivotGridField>
                    <dx:PivotGridField ID="fieldCantidadGas" AreaIndex="10" FieldName="Cantidad Gas">
                    </dx:PivotGridField>
                </Fields>
                <Styles CssFilePath="~/App_Themes/Glass/{0}/styles.css" CssPostfix="Glass">
                    <HeaderStyle>
                    <HoverStyle>
                        <BackgroundImage ImageUrl="~/App_Themes/Glass/PivotGrid/pgHeaderBackHot.gif" 
                            Repeat="RepeatX" />
                    </HoverStyle>
                    <BackgroundImage ImageUrl="~/App_Themes/Glass/PivotGrid/pgHeaderBack.gif" 
                        Repeat="RepeatX" />
                    </HeaderStyle>
                    <FilterAreaStyle>
                        <BackgroundImage ImageUrl="~/App_Themes/Glass/PivotGrid/pgFilterAreaBack.gif" 
                            Repeat="RepeatX" />
                    </FilterAreaStyle>
                    <FilterButtonPanelStyle>
                        <BackgroundImage ImageUrl="~/App_Themes/Glass/PivotGrid/pgFilterPanelBack.gif" 
                            Repeat="RepeatX" />
                    </FilterButtonPanelStyle>
                    <MenuStyle GutterWidth="0px" />
                </Styles>
                <Images SpriteCssFilePath="~/App_Themes/Glass/{0}/sprite.css">
                    <CustomizationFieldsBackground Url="~/App_Themes/Glass/PivotGrid/pgCustomizationFormBackground.gif">
                    </CustomizationFieldsBackground>
                    <LoadingPanel Url="~/App_Themes/Glass/Web/Loading.gif">
                    </LoadingPanel>
                </Images>
                <OptionsLoadingPanel>
                    <Image Url="~/App_Themes/Glass/Web/Loading.gif">
                    </Image>
                </OptionsLoadingPanel>
            </dx:ASPxPivotGrid>
            <asp:SqlDataSource ID="SqlDataCuboImportacion" runat="server" 
                ConnectionString="<%$ ConnectionStrings:BDUTOConnectionString %>" 
                SelectCommand="Exec [Rrr].[spCuboReporteUso] "></asp:SqlDataSource>

        </td>
    </tr>
  </table>
</asp:Panel>
<asp:Panel ID="PanelCuboExportador" runat="server" Visible="False">
  <table>
    <tr>
        <td>

            <dx:ASPxPivotGrid ID="ASPxPivotGrid1" runat="server" 
                DataSourceID="SqlDataCuboImportacion">
                <Fields>
                    <dx:PivotGridField ID="fieldNombre" AreaIndex="0" FieldName="Nombre">
                    </dx:PivotGridField>
                    <dx:PivotGridField ID="fieldRUDepartamento" AreaIndex="1" FieldName="Departamento">
                    </dx:PivotGridField>
                    <dx:PivotGridField ID="fieldRUMunicipio" AreaIndex="2" FieldName="Municipio">
                    </dx:PivotGridField>
                    <dx:PivotGridField ID="fieldPeriodo" AreaIndex="3" FieldName="Periodo">
                    </dx:PivotGridField>
                    <dx:PivotGridField ID="fieldSustancia" AreaIndex="4" FieldName="Sustancia">
                    </dx:PivotGridField>
                    <dx:PivotGridField ID="fieldUso" AreaIndex="5" FieldName="Uso">
                    </dx:PivotGridField>
                    <dx:PivotGridField ID="fieldRUCantidad" AreaIndex="6" FieldName="Cantidad" AllowedAreas="DataArea" GrandTotalCellFormat-FormatString="#,##0" TotalValueFormat-FormatType="Numeric" GrandTotalCellFormat-FormatType="Numeric" CellFormat-FormatType="Numeric">
                    </dx:PivotGridField>                                                                
                </Fields>
                <Styles CssFilePath="~/App_Themes/Glass/{0}/styles.css" CssPostfix="Glass">
                    <HeaderStyle>
                    <HoverStyle>
                        <BackgroundImage ImageUrl="~/App_Themes/Glass/PivotGrid/pgHeaderBackHot.gif" 
                            Repeat="RepeatX" />
                    </HoverStyle>
                    <BackgroundImage ImageUrl="~/App_Themes/Glass/PivotGrid/pgHeaderBack.gif" 
                        Repeat="RepeatX" />
                    </HeaderStyle>
                    <FilterAreaStyle>
                        <BackgroundImage ImageUrl="~/App_Themes/Glass/PivotGrid/pgFilterAreaBack.gif" 
                            Repeat="RepeatX" />
                    </FilterAreaStyle>
                    <FilterButtonPanelStyle>
                        <BackgroundImage ImageUrl="~/App_Themes/Glass/PivotGrid/pgFilterPanelBack.gif" 
                            Repeat="RepeatX" />
                    </FilterButtonPanelStyle>
                    <MenuStyle GutterWidth="0px" />
                </Styles>
                <Images SpriteCssFilePath="~/App_Themes/Glass/{0}/sprite.css">
                    <CustomizationFieldsBackground Url="~/App_Themes/Glass/PivotGrid/pgCustomizationFormBackground.gif">
                    </CustomizationFieldsBackground>
                    <LoadingPanel Url="~/App_Themes/Glass/Web/Loading.gif">
                    </LoadingPanel>
                </Images>
                <OptionsLoadingPanel>
                    <Image Url="~/App_Themes/Glass/Web/Loading.gif">
                    </Image>
                </OptionsLoadingPanel>
            </dx:ASPxPivotGrid>
            <asp:SqlDataSource ID="SqlDataDeclaracion" runat="server" 
                ConnectionString="<%$ ConnectionStrings:BDUTOConnectionString %>" 
                SelectCommand="Exec [Rrr].[spCuboRecuperacionCentroRegeneracion]"></asp:SqlDataSource>

        </td>
    </tr>
  </table>
  <dx:ASPxPivotGridExporter ID="pivotExport" runat="server" ASPxPivotGridID="ASPxPivotGrid3">
    </dx:ASPxPivotGridExporter>  
      <dx:ASPxPivotGridExporter ID="pivotExport2" runat="server" ASPxPivotGridID="ASPxPivotGrid1">
    </dx:ASPxPivotGridExporter>    
      <dx:ASPxPivotGridExporter ID="pivotExport3" runat="server" ASPxPivotGridID="ASPxPivotGrid2">
    </dx:ASPxPivotGridExporter> 
</asp:Panel>
    <asp:Panel ID="PanelCuboEquipos" runat="server" Visible="False">
  <table>
    <tr>
        <td>
            <dx:ASPxPivotGrid ID="ASPxPivotGrid2" runat="server" 
                DataSourceID="SqlDataCuboEquipos"  OptionsPager-RowsPerPage="50">
                <Fields>
                    <dx:PivotGridField ID="PivotGridField1" AreaIndex="0" FieldName="Regional" AllowedAreas="RowArea,ColumnArea,FilterArea" Area="RowArea">
                    </dx:PivotGridField>
                    <dx:PivotGridField ID="fieldCompra" AreaIndex="1" FieldName="Proyecto" AllowedAreas="RowArea,ColumnArea,FilterArea" Area="ColumnArea">
                    </dx:PivotGridField>
                    <dx:PivotGridField ID="fieldTipo" AreaIndex="2" FieldName="Tipo" AllowedAreas="RowArea,ColumnArea,FilterArea">
                    </dx:PivotGridField>
                    <dx:PivotGridField ID="PivotGridField2" AreaIndex="3" FieldName="Nombre" AllowedAreas="RowArea,ColumnArea,FilterArea">
                    </dx:PivotGridField>
                    <dx:PivotGridField ID="fieldCantidad" AreaIndex="4" FieldName="Cantidad" AllowedAreas="DataArea" Area="DataArea">
                    </dx:PivotGridField>
                    <dx:PivotGridField ID="fieldEstado" AreaIndex="5" FieldName="Estado" AllowedAreas="RowArea,ColumnArea,FilterArea">
                    </dx:PivotGridField>
                    <dx:PivotGridField ID="fieldTercero" AreaIndex="6" FieldName="Tercero" AllowedAreas="RowArea,ColumnArea,FilterArea">
                    </dx:PivotGridField>
                    <dx:PivotGridField ID="PivotGridField4" AreaIndex="7" FieldName="Departamento" AllowedAreas="RowArea,ColumnArea,FilterArea" >
                    </dx:PivotGridField>
                    <dx:PivotGridField ID="PivotGridField5" AreaIndex="8" FieldName="Municipio" AllowedAreas="RowArea,ColumnArea,FilterArea" >
                    </dx:PivotGridField>
                </Fields>                
                <Styles CssFilePath="~/App_Themes/Glass/{0}/styles.css" CssPostfix="Glass">
                    <HeaderStyle>
                    <HoverStyle>
                        <BackgroundImage ImageUrl="~/App_Themes/Glass/PivotGrid/pgHeaderBackHot.gif" 
                            Repeat="RepeatX" />
                    </HoverStyle>
                    <BackgroundImage ImageUrl="~/App_Themes/Glass/PivotGrid/pgHeaderBack.gif" 
                        Repeat="RepeatX" />
                    </HeaderStyle>
                    <FilterAreaStyle>
                        <BackgroundImage ImageUrl="~/App_Themes/Glass/PivotGrid/pgFilterAreaBack.gif" 
                            Repeat="RepeatX" />
                    </FilterAreaStyle>
                    <FilterButtonPanelStyle>
                        <BackgroundImage ImageUrl="~/App_Themes/Glass/PivotGrid/pgFilterPanelBack.gif" 
                            Repeat="RepeatX" />
                    </FilterButtonPanelStyle>
                    <MenuStyle GutterWidth="0px" />
                </Styles>
                <Images SpriteCssFilePath="~/App_Themes/Glass/{0}/sprite.css">
                    <CustomizationFieldsBackground Url="~/App_Themes/Glass/PivotGrid/pgCustomizationFormBackground.gif">
                    </CustomizationFieldsBackground>
                    <LoadingPanel Url="~/App_Themes/Glass/Web/Loading.gif">
                    </LoadingPanel>
                </Images>
                <OptionsLoadingPanel>
                    <Image Url="~/App_Themes/Glass/Web/Loading.gif">
                    </Image>
                </OptionsLoadingPanel>
            </dx:ASPxPivotGrid>
            <asp:SqlDataSource ID="SqlDataCuboEquipos" runat="server" 
                ConnectionString="<%$ ConnectionStrings:BDUTOConnectionString %>" 
                SelectCommand="Exec [Rrr].[spCuboEquipos] 1"></asp:SqlDataSource>

        </td>
    </tr>
  </table>    
    </asp:Panel>

<table>
<tr>
<td>
    <asp:Button ID="ButtonVolver" runat="server" Text="Volver" CssClass="button" 
        onclick="ButtonVolver_Click" />
</td>
<td width="5"></td>
    <td>
        <asp:Button ID="buttonExportar" runat="server" Text="Exportar" 
            CssClass="button" onclick="buttonExportar_Click"   />
    </td>  
</tr>
</table>
</asp:Content>
