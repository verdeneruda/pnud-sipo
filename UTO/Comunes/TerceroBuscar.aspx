<%@ Page Language="C#" MasterPageFile="~/MPMain.Master"  AutoEventWireup="true" CodeBehind="TerceroBuscar.aspx.cs" Inherits="UTO.Comunes.TerceroBuscar" %>

    <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

    <%@ Register src="~/Comunes/DocumentosVarios.ascx" tagname="DocumentosVarios" tagprefix="uc1" %>
    <%@ Register src="ControlError.ascx" tagname="ControlError" tagprefix="uc1" %>
    
    <asp:Content  ID="contentSolicitudEquiposBuscar" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
        <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
        </cc1:ToolkitScriptManager>    
    
    <div class="divwithoutgrid">
        <table class="titulo" >
            <tr>
                <td>
                    <asp:Label ID="labelBusquedaSolicitudesEquipos" runat="server" Text="Técnicos - Empresas" CssClass="subtitulo"></asp:Label>
                </td>
            </tr>
        </table>
        
    <table class="form">
        <tr>
            <td>     
                <uc1:controlerror ID="ControlError1" runat="server" />     
            </td>
        </tr>
    </table>    
    
    <table class="form">
        <tr>
            <td>
                <%--<table style="width:100%">--%>
                    <%--<tr>
                        <td>--%>
                            <asp:Panel ID="PanelBuscarTercero" runat="server" Width="671px">
                                <table>
                                    <tr>
                                        <th colspan="5">
                                            <asp:Label ID="labelparametros" runat="server" Text="Buscar beneficiario" 
                                                CssClass="subtitulo"></asp:Label>
                                        </th>
                                    </tr>
                                    
                                    <tr>
                                        <td>
                                            <asp:Label ID="labelNombreBeneficiario" runat="server" Text="Nombre beneficiario" CssClass="label"></asp:Label>
                                        </td>
                                        <td colspan="4">
                                            <asp:TextBox ID="textBeneficiarioBuscar" runat="server"  CssClass="texto2" 
                                                Width="449px"></asp:TextBox>
                                        </td>
                                        <%--<td class="separador">
                                            &nbsp;
                                        </td>--%>
                                    </tr>
                                    
                                    <tr>
                                        <td>
                                            <asp:Label ID="label3" runat="server" CssClass="label" Text="Tipo documento"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:DropDownList ID="comboTipoDocumento" runat="server" CssClass="combo" DataTextField="dti_Descripcion" 
                                                DataValueField="dti_Id" Width="106px">
                                            </asp:DropDownList>
                                        </td>
                                        <td>
                                            <asp:Label ID="labelNumeroDocumento" runat="server" CssClass="label" 
                                                Text="Número documento"></asp:Label>
                                        </td>
                                        <td>
                                             <asp:TextBox ID="textNumeroDocumneto" runat="server" CssClass="texto2" 
                                                 Width="127px"></asp:TextBox>
                                         </td>
                                        <%--<td class="style1">
                                             &nbsp;
                                        </td>
                                        <td class="separador">
                                             &nbsp;
                                        </td>--%>
                                    </tr>
                                    
                                    <tr>
                                        <td colspan="6">
                                            <asp:Button ID="buttonBuscarTercero" runat="server" CssClass="button" 
                                                Text="Buscar" onclick="buttonBuscarTercero_Click" />
                                            <asp:Button ID="buttonAdicionarTercero" runat="server" CssClass="button" 
                                                Text="Adicionar" onclick="buttonAdicionarTercero_Click" />
                                        </td>
                                    </tr>
                                    
                                    <tr>
                                        <td colspan="6">
                                            <asp:GridView ID="gridTerceroBuscar" runat="server" 
                                                CssClass="grilla" 
                                                FooterStyle-CssClass="footergrilla" HeaderStyle-CssClass="headergrilla" 
                                                RowStyle-CssClass="rowgrilla" SelectedRowStyle-CssClass="selectedgrilla" 
                                                onrowcommand="GridViewTerceroBuscar_RowCommand" 
                                                Width="649px" DataKeyNames="Id" AutoGenerateColumns="False" 
                                                AllowPaging="True" DataSourceID="terceroBuscarDataSource" PageSize="15">
                                                <RowStyle CssClass="rowgrilla" />
                                                <Columns>
                                                    <asp:ButtonField ButtonType="Button" CommandName="Modificar" 
                                                        Text="Modificar">
                                                        <ControlStyle CssClass="buttongrilla" />
                                                    </asp:ButtonField>
                                                    <asp:ButtonField ButtonType="Button" CommandName="Eliminar" Text="Eliminar">
                                                        <ControlStyle CssClass="buttongrilla" />
                                                    </asp:ButtonField>
                                                    <asp:ButtonField ButtonType="Button" CommandName="Ver" Text="Ver">
                                                        <ControlStyle CssClass="buttongrilla" />
                                                    </asp:ButtonField>
                                                    <asp:BoundField DataField="TipoDocumento" HeaderText="Tipo documento" />
                                                    <asp:BoundField DataField="ter_NumeroDocumento" HeaderText="Número documento" />
                                                    <asp:BoundField DataField="ter_NombreCompleto" 
                                                        HeaderText="Nombre y apellidos" />
                                                    <asp:BoundField DataField="dep_descripcion" HeaderText="Departamento" />
                                                    <asp:BoundField DataField="mun_descripcion" HeaderText="Ciudad" />
                                                </Columns>
                                                <FooterStyle CssClass="footergrilla" />
                                                <SelectedRowStyle CssClass="selectedgrilla" />
                                                <HeaderStyle CssClass="headergrilla" />
                                            </asp:GridView>
                                            <asp:SqlDataSource ID="terceroBuscarDataSource" runat="server" 
                                                ConnectionString="<%$ ConnectionStrings:BDUTOConnectionString %>" 
                                                SelectCommand="exec [Uto].[spBeneficiarioBuscar] @beneficiario,@documento,@tipoDocumento">
                                                <SelectParameters>
                                                    <asp:Parameter Name="beneficiario" />
                                                    <asp:Parameter Name="documento" />
                                                    <asp:Parameter Name="tipoDocumento" />
                                                </SelectParameters>
                                            </asp:SqlDataSource>
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                      <%--  </td>
                    </tr>--%>
                <%--</table>--%>
            </td>
        </tr>
    </table>
    
    </div>
    
    <br />
    <br />
    
    </asp:Content>
    

