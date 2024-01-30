﻿<%@ Page Language="C#" MasterPageFile="~/MPMain.Master"  AutoEventWireup="true" CodeBehind="TipoProyecto.aspx.cs" Inherits="UTO.Comunes.TipoProyecto" %>

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
                    <asp:Label ID="labelPais" runat="server" Text="Tipo proyecto" CssClass="subtitulo"></asp:Label>
                </td>
            </tr>
        </table>
        
        <table class = "form">
            <tr>
                <td>
                    <uc1:ControlError ID="ControlError1" runat="server" />
                </td>
            </tr>
        </table>
        
        <table class="form">
            <tr>
                <td>
                    <table style="width:100%">
                        <tr>
                            <td>
                               <%-- <asp:Panel ID="PanelBuscarTercero" runat="server" Width="671px">
                                    <table>
                                        <tr>
                                            <td>--%>
                                                <asp:GridView ID="gridCatalogo" runat="server" 
                                    AutoGenerateColumns="False" CssClass="grilla" 
                                                    DataKeyNames="pti_Id" DataSourceID="SqlDataCatalogo" 
                                                    FooterStyle-CssClass="footergrilla" HeaderStyle-CssClass="headergrilla" 
                                                    RowStyle-CssClass="rowgrilla" SelectedRowStyle-CssClass="selectedgrilla" 
                                                    Width="649px" onprerender="gridCatalogo_PreRender" 
                                    AllowPaging="True" PageSize="15" onrowcommand="gridCatalogo_RowCommand">
                                                    <RowStyle CssClass="rowgrilla" />
                                                    <Columns>
                                                        <asp:CommandField ButtonType="Button" ShowEditButton="True" EditText="Modificar" UpdateText="Aceptar" CancelText="Cancelar">
                                                            <ControlStyle CssClass="buttongrilla" />
                                                        </asp:CommandField>                                                 
                                                       <asp:TemplateField>
                                                            <ItemTemplate>
                                                                <asp:Button ID="ButtonEliminar" runat="server" Text="Eliminar" CommandName="Eliminar" CommandArgument="<%# Container.DataItemIndex %>" CssClass="buttongrilla" OnClientClick="return confirm('Este registro se eliminará, desea continuar?')"/>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>   
                                                        <asp:TemplateField>
                                                            <ItemTemplate>
                                                                <asp:Button ID="ButtonNuevo" runat="server" Text="Nuevo" onclick="LinkNuevo_Click" CssClass="buttongrilla" />
                                                            </ItemTemplate>
                                                        </asp:TemplateField>                                       
                                                        <asp:BoundField DataField="pti_Id" HeaderText="Id" ReadOnly="True" 
                                                            SortExpression="pti_Id" />
                                                        <asp:BoundField DataField="pti_Descripcion" HeaderText="Tipo proyecto" 
                                                            SortExpression="pti_Descripcion" />
                                                    </Columns>
                                                    <FooterStyle CssClass="footergrilla" />
                                                    <SelectedRowStyle CssClass="selectedgrilla" />
                                                    <HeaderStyle CssClass="headergrilla" />
                                                </asp:GridView>
                                                
                                                <asp:SqlDataSource ID="SqlDataCatalogo" runat="server" 
                                                    ConnectionString="<%$ ConnectionStrings:BDUTOConnectionString %>" 
                                                    DeleteCommand="DELETE FROM [Pro].[pti_ProyectoTipo] WHERE [pti_Id] = @pti_Id" 
                                                    InsertCommand="INSERT INTO [Pro].[pti_ProyectoTipo] ([pti_Id], [pti_Descripcion]) VALUES (@pti_Id, upper(@pti_Descripcion))" 
                                                    SelectCommand="SELECT pti_Id, pti_Descripcion FROM [Pro].pti_ProyectoTipo" 
                                                    UpdateCommand="UPDATE [Pro].[pti_ProyectoTipo] SET [pti_Descripcion] = upper(@pti_Descripcion) WHERE [pti_Id] = @pti_Id">
                                                    <DeleteParameters>
                                                        <asp:Parameter Name="pti_Id" Type="Int32" />
                                                    </DeleteParameters>
                                                    <UpdateParameters>
                                                        <asp:Parameter Name="pti_Descripcion" Type="String" />
                                                        <asp:Parameter Name="pti_Id" Type="Int32" />
                                                    </UpdateParameters>
                                                    <InsertParameters>
                                                        <asp:Parameter Name="pti_Id" Type="Int32" />
                                                        <asp:Parameter Name="pti_Descripcion" Type="String" />
                                                    </InsertParameters>
                                                </asp:SqlDataSource>
                                           <%-- </td>
                                            <td class="separador">
                                                &nbsp;
                                            </td>
                                        </tr>
                                    </table>
                                </asp:Panel>--%>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
        
    </div>
    
    <br />
    <br />
    
    </asp:Content>

