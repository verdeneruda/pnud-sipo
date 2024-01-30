<%@ Page Title="" Language="C#" MasterPageFile="~/MPPivot.Master" AutoEventWireup="true" CodeBehind="CuboCertificacion.aspx.cs" Inherits="UTO.Certificacion.CuboCertificacion" UICulture="es" %>

<%@ Register Assembly="DevExpress.Web.ASPxPivotGrid.v15.1, Version=15.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxPivotGrid" TagPrefix="dx" %>
    
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="divwithoutgrid">
    <table class="titulo" >
    <tr><td>
    <asp:Label ID="labelConsultas" runat="server" 
            Text="Módulo certificación - Cubos" 
            CssClass="subtitulo"></asp:Label>
    </td></tr>
    </table>
</div>
<br />
    <dx:ASPxPivotGrid ID="ASPxPivotGrid1" runat="server" 
        DataSourceID="dsCertificacion">
        <Fields>
            <dx:PivotGridField ID="fieldRegional" FieldName="Regional" AreaIndex="4">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldDepartamento" FieldName="Departamento" 
                AreaIndex="5">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldCiudad" FieldName="Ciudad" AreaIndex="6">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldrea" FieldName="Área" AreaIndex="3">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldTcnicos" FieldName="Técnicos" AreaIndex="0">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldCategora" FieldName="Categoría" AreaIndex="1">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldEmpresa" FieldName="Empresa" AreaIndex="2">
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
            CssClass="button" onclick="buttonExportar_Click" /></td>
    </tr>
    </table>    
    <asp:SqlDataSource ID="dsCertificacion" runat="server" 
        ConnectionString="<%$ ConnectionStrings:BDUTOConnectionString %>" 
        SelectCommand="exec [cer].[spCuboCertificacion]"></asp:SqlDataSource>
  <dx:ASPxPivotGridExporter ID="pivotExport" runat="server" ASPxPivotGridID="ASPxPivotGrid1">
    </dx:ASPxPivotGridExporter>
</asp:Content>
