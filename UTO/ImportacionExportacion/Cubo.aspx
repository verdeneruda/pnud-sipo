<%@ Page Language="C#" MasterPageFile="~/MPPivot.Master" AutoEventWireup="true" CodeBehind="Cubo.aspx.cs" Inherits="UTO.ImportacionExportacion.Cubo" Title="Untitled Page" UICulture="es" %>
<%@ Register assembly="DevExpress.Web.ASPxPivotGrid.v15.1, Version=15.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxPivotGrid" tagprefix="dx" %>
    
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="divwithoutgrid">
    <table class="titulo" >
    <tr><td>
    <asp:Label ID="labelConsultas" runat="server" 
            Text="Módulo Importación y Exportación - Cubos" 
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
                        <asp:ListItem Value="1">Registro importación</asp:ListItem>
                        <asp:ListItem Value="2">Declaración importación</asp:ListItem>
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
                    <dx:PivotGridField ID="fieldImportador" AreaIndex="0" FieldName="Importador">
                    </dx:PivotGridField>
                    <dx:PivotGridField ID="fieldExportador" AreaIndex="1" FieldName="Exportador">
                    </dx:PivotGridField>
                    <dx:PivotGridField ID="fieldAovistobueno" AreaIndex="2" FieldName="Año visto bueno">
                    </dx:PivotGridField>
                    <dx:PivotGridField ID="fieldAovigencia" AreaIndex="3" FieldName="Año vigencia">
                    </dx:PivotGridField>
                    <dx:PivotGridField ID="fieldPais" AreaIndex="4" FieldName="Pais">
                    </dx:PivotGridField>
                    <dx:PivotGridField ID="fieldAduana" AreaIndex="5" FieldName="Aduana">
                    </dx:PivotGridField>
                    <dx:PivotGridField ID="fieldPuertodeembargue" AreaIndex="6" FieldName="Puerto de embargue">
                    </dx:PivotGridField>
                    <dx:PivotGridField ID="fieldEquipo" AreaIndex="7" FieldName="Equipo">
                    </dx:PivotGridField>
                    <dx:PivotGridField ID="fieldCantidadequipo" AreaIndex="8" FieldName="Cantidad equipo">
                    </dx:PivotGridField>
                    <dx:PivotGridField ID="fieldSustancia" AreaIndex="9" FieldName="Sustancia">
                    </dx:PivotGridField>
                    <dx:PivotGridField ID="fieldArancel" AreaIndex="10" FieldName="Arancel">
                    </dx:PivotGridField>
                    <dx:PivotGridField ID="fieldCantidadimportada" AreaIndex="11" FieldName="Cantidad importada" ValueFormat-FormatType="Numeric" CellFormat-FormatType="Numeric" GrandTotalCellFormat-FormatType="Numeric" Options-AllowDrag="Default" CellFormat-FormatString="#,##0.00" GrandTotalCellFormat-FormatString="#,##0.00" TotalCellFormat-FormatString="#,##0.00" TotalValueFormat-FormatString="#,##0.00">
                    </dx:PivotGridField>
                    <dx:PivotGridField ID="fieldPreciounitariosustancia" FieldName="Precio unitario sustancia" GroupIntervalNumericRange="12">
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
                SelectCommand="Exec Iye.spCuboImportacion"></asp:SqlDataSource>

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
                    <dx:PivotGridField ID="fieldImportadorDeclaracion" AreaIndex="0" FieldName="Importador">
                    </dx:PivotGridField>
                    <dx:PivotGridField ID="fieldAnoDeclaracion" AreaIndex="1" FieldName="Año declaración">
                    </dx:PivotGridField>
                    <dx:PivotGridField ID="fieldPaisDeclaracion" AreaIndex="2" FieldName="Pais">
                    </dx:PivotGridField>
                    <dx:PivotGridField ID="fieldMarcaComercial" AreaIndex="3" FieldName="Marca Comercial">
                    </dx:PivotGridField>
                    <dx:PivotGridField ID="fieldCantidad" AreaIndex="4" FieldName="Cantidad" ValueFormat-FormatType="Numeric" CellFormat-FormatType="Numeric" GrandTotalCellFormat-FormatType="Numeric" Options-AllowDrag="Default" CellFormat-FormatString="#,##0.00" GrandTotalCellFormat-FormatString="#,##0.00" TotalCellFormat-FormatString="#,##0.00" TotalValueFormat-FormatString="#,##0.00">
                    </dx:PivotGridField>
                    <dx:PivotGridField ID="fieldValorFOB" AreaIndex="5" FieldName="ValorFOB">
                    </dx:PivotGridField>
                    <dx:PivotGridField ID="fieldPesoNeto" AreaIndex="6" FieldName="Peso neto">
                    </dx:PivotGridField>
                    <dx:PivotGridField ID="fieldNumeroItems" AreaIndex="7" FieldName="Número items">
                    </dx:PivotGridField>
                    <dx:PivotGridField ID="fieldSustanciaDeclaracion" AreaIndex="8" FieldName="Sustancia">
                    </dx:PivotGridField>     
                    <dx:PivotGridField ID="fieldDeclaracion" AreaIndex="9" FieldName="Arancel">
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
                SelectCommand="Exec Iye.spCuboImportacion"></asp:SqlDataSource>

        </td>
    </tr>
  </table>
  <dx:ASPxPivotGridExporter ID="pivotExport" runat="server" ASPxPivotGridID="ASPxPivotGrid3">
    </dx:ASPxPivotGridExporter>  
      <dx:ASPxPivotGridExporter ID="pivotExport2" runat="server" ASPxPivotGridID="ASPxPivotGrid1">
    </dx:ASPxPivotGridExporter>  
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
            CssClass="button" onclick="buttonExportar_Click" />
    </td>
</tr>
</table>
</asp:Content>
