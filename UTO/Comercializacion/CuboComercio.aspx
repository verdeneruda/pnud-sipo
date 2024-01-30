<%@ Page Title="" Language="C#" MasterPageFile="~/MPPivot.Master" AutoEventWireup="true" CodeBehind="CuboComercio.aspx.cs" Inherits="UTO.Comercializacion.CuboComercio" %>
<%@ Register Assembly="DevExpress.Web.ASPxPivotGrid.v15.1, Version=15.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxPivotGrid" TagPrefix="dx" %>
    
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="divwithoutgrid">
    <table class="titulo" >
        <tr><td>
        <asp:Label ID="labelConsultas" runat="server" 
                Text="Módulo comercialización - Cubos" 
                CssClass="subtitulo"></asp:Label>
        </td></tr>
    </table>
    </div>    
    <br />    
   <dx:ASPxPivotGrid ID="ASPxPivotGrid1" runat="server" 
        DataSourceID="dsComercio">
        <Fields>
            <dx:PivotGridField ID="fieldSustancia" AreaIndex="0" FieldName="Sustancia">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldPresentacion" AreaIndex="1" 
                FieldName="Presentacion">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldDepartamento" AreaIndex="2" 
                FieldName="Departamento">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldCiudad" AreaIndex="3" FieldName="Ciudad">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldPrecioPromedio" AreaIndex="4" 
                FieldName="PrecioPromedio" SummaryType="Average">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldAo" AreaIndex="5" FieldName="Año">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldComerciante" AreaIndex="6" FieldName="Comerciante">
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
        <OptionsPager RowsPerPage="25">
        </OptionsPager>
    </dx:ASPxPivotGrid>        
    <table>
    <tr>
    <td>
        <asp:Button ID="ButtonVolver" runat="server" Text="Volver" CssClass="button" onclick="ButtonVolver_Click" 
             />
    </td>
    <td width="5"></td>
    <td>
        <asp:Button ID="buttonExportar" runat="server" Text="Exportar" 
            CssClass="button" onclick="buttonExportar_Click"  /></td>
    </tr>
    </table>     
    <asp:SqlDataSource ID="dsComercio" runat="server" 
        ConnectionString="<%$ ConnectionStrings:BDUTOConnectionString %>" 
        SelectCommand="exec [com].[spCuboComercializacion]"></asp:SqlDataSource>
  <dx:ASPxPivotGridExporter ID="pivotExport" runat="server" ASPxPivotGridID="ASPxPivotGrid1">
    </dx:ASPxPivotGridExporter>    
</asp:Content>
