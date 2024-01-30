<%@ Page Language="C#" MasterPageFile="~/MPMain.Master" AutoEventWireup="true" CodeBehind="ConsultaFicha.aspx.cs" Inherits="UTO.Recuperacion.ConsultaFicha" %>

<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

    <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
    <%@ Register src="../Comunes/ControlError.ascx" tagname="ControlError" tagprefix="uc1" %>
    
    <asp:Content  ID="contentSolicitudEquiposBuscar" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
        <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </cc1:ToolkitScriptManager>
   
    <div class="divwithoutgrid">
    <table class="titulo" >
        <tr><td>
        <asp:Label ID="labelBusquedaSolicitudesEquipos" runat="server" Text="Consulta" CssClass="subtitulo"></asp:Label>
        </td></tr>
    </table>
    <table class="form">
    <tr>
        <td>     
         <uc1:ControlError ID="ControlError1" runat="server" />     
     </td>
    </tr>
    </table>        
        <table style="width:100%">
    <tr>
    <td>
        <asp:Panel ID="PanelBuscarTercero" runat="server" Width="671px">
            <table class="form">
                 <tr>
                    <th colspan="5">   
                    <asp:Label ID="labelparametros" runat="server" Text="Buscar tercero" 
                            CssClass="subtitulo"></asp:Label>
                    </th>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="labelNombreBeneficiario" runat="server" Text="Nombre tercero" 
                            CssClass="label"></asp:Label>
                    </td>
                    <td colspan="4">
                        <asp:TextBox ID="textNombreBeneficiarioBuscar" runat="server"  CssClass="texto2" 
                            Width="449px"></asp:TextBox>
                    </td>
                    <td class="separador">
                        &nbsp;</td>
                </tr>
                 <tr>
                     <td>
                         <asp:Label ID="label3" runat="server" CssClass="label" Text="Tipo documento"></asp:Label>
                     </td>
                     <td>
                         <asp:DropDownList ID="comboTipoDocumentoBuscar" runat="server" CssClass="combo" DataTextField="dti_Descripcion" 
                             DataValueField="dti_Id" Width="106px">
                         </asp:DropDownList>
                     </td>
                     <td>
                         <asp:Label ID="labelNumeroDocumento" runat="server" CssClass="label" 
                             Text="Número documento"></asp:Label>
                     </td>
                     <td>
                         <asp:TextBox ID="textNumeroDocumentoBuscar" runat="server" CssClass="texto2" 
                             Width="127px"></asp:TextBox>
                     </td>
                     <td class="style1">
                         &nbsp;</td>
                     <td class="separador">
                         &nbsp;</td>
                 </tr>
                <tr>
                    <td colspan="6">
                        <asp:Button ID="buttonBuscarTercero" runat="server" CssClass="button" 
                            Text="Buscar" onclick="buttonBuscarTercero_Click" />
                        <asp:Button ID="buttonExportar" runat="server" Text="Exportar consulta" CssClass="button" OnClick="buttonExportar_Click"/>
                    </td>
                </tr>
                <tr>
                    <td colspan="6">
                        <dx:ASPxGridView ID="gvConsulta" runat="server" DataSourceID="dsBuscarTercero" SettingsPager-PageSize="20" KeyFieldName="ter_Id" Width="500px" Visible="False">
                            <Columns>                               
                                <dx:GridViewDataColumn Caption="Tipo de documento" FieldName="TipoDocumento" >
                                </dx:GridViewDataColumn>
                                <dx:GridViewDataColumn Caption="Número de documento" FieldName="ter_NumeroDocumento" >
                                </dx:GridViewDataColumn>
                                <dx:GridViewDataColumn Caption="Nombre completo" FieldName="ter_NombreCompleto" >
                                </dx:GridViewDataColumn>
                                <dx:GridViewDataColumn Caption="Teléfono" FieldName="ter_Tefono" >
                                </dx:GridViewDataColumn>
                                <dx:GridViewDataColumn Caption="Dirección" FieldName="ter_Direccion" >
                                </dx:GridViewDataColumn>
                                <dx:GridViewDataColumn Caption="Región" FieldName="reg_descripcion" >
                                </dx:GridViewDataColumn>
                                <dx:GridViewDataColumn Caption="Departamento" FieldName="dep_descripcion" >
                                </dx:GridViewDataColumn>
                                <dx:GridViewDataColumn Caption="Municipio" FieldName="mun_descripcion" >
                                </dx:GridViewDataColumn>
                            </Columns>
                        </dx:ASPxGridView>
<dx:ASPxGridViewExporter ID="exportGrid" ExportedRowType="All" GridViewID="gvConsulta"
                            runat="server">
                        </dx:ASPxGridViewExporter>
                        <asp:GridView ID="GridViewTerceroBuscar" runat="server" 
                            AutoGenerateColumns="False" CssClass="grilla" DataKeyNames="ter_id" 
                            DataSourceID="dsBuscarTercero" FooterStyle-CssClass="footergrilla" 
                            HeaderStyle-CssClass="headergrilla" 
                            onrowcommand="GridViewTerceroBuscar_RowCommand" RowStyle-CssClass="rowgrilla" 
                            SelectedRowStyle-CssClass="selectedgrilla" Width="649px" 
                            AllowPaging="True" PageSize="15" 
                            EmptyDataText="La búsqueda no encontró resultados">
                            <RowStyle CssClass="rowgrilla" />
                            <Columns>
                                <asp:ButtonField ButtonType="Button" CommandName="Seleccionar" 
                                    Text="Seleccionar">
                                    <ControlStyle CssClass="button" />
                                </asp:ButtonField>
                                <asp:BoundField DataField="ter_id" HeaderText="ter_id" InsertVisible="False" 
                                    ReadOnly="True" SortExpression="ter_id" />
                                <asp:BoundField DataField="TipoDocumento" HeaderText="TipoDocumento" 
                                    SortExpression="TipoDocumento" />
                                <asp:BoundField DataField="ter_NumeroDocumento" 
                                    HeaderText="ter_NumeroDocumento" SortExpression="ter_NumeroDocumento" />
                                <asp:BoundField DataField="ter_NombreCompleto" HeaderText="ter_NombreCompleto" 
                                    SortExpression="ter_NombreCompleto" />
                                <asp:BoundField DataField="reg_descripcion" HeaderText="reg_descripcion" 
                                    SortExpression="reg_descripcion" Visible="False" />
                                <asp:BoundField DataField="dep_descripcion" HeaderText="dep_descripcion" 
                                    SortExpression="dep_descripcion" Visible="False" />
                                <asp:BoundField DataField="mun_descripcion" HeaderText="mun_descripcion" 
                                    SortExpression="mun_descripcion" Visible="False" />
                                <asp:BoundField DataField="ter_Tefono" HeaderText="ter_Tefono" 
                                    SortExpression="ter_Tefono" Visible="False" />
                                <asp:BoundField DataField="ter_Direccion" HeaderText="ter_Direccion" 
                                    SortExpression="ter_Direccion" Visible="False" />
                                <asp:BoundField DataField="ter_Correo" HeaderText="ter_Correo" 
                                    SortExpression="ter_Correo" Visible="False" />
                                <asp:BoundField DataField="ter_Celular" HeaderText="ter_Celular" 
                                    SortExpression="ter_Celular" Visible="False" />
                                <asp:BoundField DataField="tpj_EstablecimientoComercio" 
                                    HeaderText="tpj_EstablecimientoComercio" 
                                    SortExpression="tpj_EstablecimientoComercio" Visible="False" />
                                <asp:BoundField DataField="tpj_RepresentanteLegal" 
                                    HeaderText="tpj_RepresentanteLegal" SortExpression="tpj_RepresentanteLegal" 
                                    Visible="False" />
                                <asp:BoundField DataField="tpj_NumeroDocumento" 
                                    HeaderText="tpj_NumeroDocumento" SortExpression="tpj_NumeroDocumento" 
                                    Visible="False" />
                            </Columns>
                            <FooterStyle CssClass="footergrilla" />
                            <SelectedRowStyle CssClass="selectedgrilla" />
                            <HeaderStyle CssClass="headergrilla" />
                        </asp:GridView>
                    </td>
                </tr>
                 <tr>
                     <td colspan="6">
                         <asp:SqlDataSource ID="dsBuscarTercero" runat="server" 
                             ConnectionString="<%$ ConnectionStrings:BDUTOConnectionString %>" SelectCommand="exec Rrr.spBeneficiarioBuscar @beneficiario, @documento, @tipoDocumento, @tipo
">
                             <SelectParameters>
                                 <asp:Parameter Name="beneficiario" />
                                 <asp:Parameter Name="documento" />
                                 <asp:Parameter Name="tipoDocumento" />
                                 <asp:Parameter Name="tipo" />
                             </SelectParameters>
                         </asp:SqlDataSource>
                     </td>
                 </tr>
            </table>
        </asp:Panel>
    </td>
    </tr>
    </table>    
    <table  >        
        <tr>
            <th>&nbsp</th>
        </tr>
    </table>
    <table>
        <tr>
            <td>
                <asp:Button ID="buttonVolver" runat="server" Text="Volver" CssClass="button" OnClick="buttonVolver_Click" Visible="False" />
            </td>
        </tr>
            <td>
                <asp:Literal ID="literalHTML" runat="server"></asp:Literal>
            </td>
        </tr>
    </table>    
    </div>
        
    </asp:Content>