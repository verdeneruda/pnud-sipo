<%@ Page Title="" Language="C#" MasterPageFile="~/MPPivot.Master" AutoEventWireup="true" CodeBehind="CuboRegistroUso.aspx.cs" Inherits="UTO.RegistrosUso.CuboRegistroUso" UICulture="es" %>

<%@ Register Assembly="DevExpress.Web.ASPxPivotGrid.v15.1, Version=15.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxPivotGrid" TagPrefix="dx" %>
    
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="divwithoutgrid">
    <table class="titulo" >
    <tr><td>
    <asp:Label ID="labelConsultas" runat="server" 
            Text="Módulo registros de uso SAO - Cubos" 
            CssClass="subtitulo"></asp:Label>
    </td></tr>
    </table>
</div>
<br />
    <dx:ASPxPivotGrid ID="ASPxPivotGrid1" runat="server" 
        DataSourceID="SqlDataSource1">
        <Fields>
            <dx:PivotGridField ID="fieldDepartamento" AreaIndex="0" 
                FieldName="dep_Descripcion" Caption="Departamento">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldCiudad" AreaIndex="1" FieldName="mun_Descripcion" Caption="Municipio">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldYeFecha" AreaIndex="2" FieldName="rri_Ano" Caption="Año">
            </dx:PivotGridField>                        
            <dx:PivotGridField ID="fieldSustancia" AreaIndex="3" FieldName="sus_Descripcion" Caption="Sustancia">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldCantidad" AreaIndex="4" FieldName="Cantidad" AllowedAreas="DataArea" CellFormat-FormatString="#,#00.00">
            </dx:PivotGridField>                        
            <dx:PivotGridField ID="PivotGridField1" AreaIndex="5" FieldName="apl_Descripcion" Caption="Uso">
            </dx:PivotGridField>
            <dx:PivotGridField ID="PivotGridField2" AreaIndex="6" FieldName="Importador">
            </dx:PivotGridField>
            <dx:PivotGridField ID="PivotGridField3" AreaIndex="7" FieldName="Cliente">
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
        <OptionsPager RowsPerPage="50">
        </OptionsPager>
    </dx:ASPxPivotGrid>
      <dx:ASPxPivotGridExporter ID="pivotExport" runat="server" ASPxPivotGridID="ASPxPivotGrid1">
    </dx:ASPxPivotGridExporter>  
    <table>
    <tr>
    <td>
        <asp:Button ID="ButtonVolver" runat="server" Text="Volver" CssClass="button" onclick="ButtonVolver_Click" 
             />
    </td>
<td width="5"></td>
    <td>
        <asp:Button ID="buttonExportar" runat="server" Text="Exportar" 
            CssClass="button" onclick="buttonExportar_Click"  />
    </td>    
    </tr>
    </table>    
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:BDUTOConnectionString %>" 
        SelectCommand="exec  [rus].[spCuboRegistroUso]"></asp:SqlDataSource>
</asp:Content>
