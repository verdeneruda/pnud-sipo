<%@ Page Language="C#" MasterPageFile="~/MPMain.Master"  AutoEventWireup="true" CodeBehind="KitCompra.aspx.cs" Inherits="UTO.Comunes.KitCompra" %>

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
                    <asp:Label ID="labelPais" runat="server" Text="Kit compra" CssClass="subtitulo"></asp:Label>
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
                                <%--<asp:Panel ID="PanelBuscarTercero" runat="server" Width="671px">
                                    <table>
                                        <tr>
                                            <td>--%>
                                                <asp:GridView ID="gridCatalogo" runat="server" 
                                    AutoGenerateColumns="False" CssClass="grilla" 
                                                    DataKeyNames="kco_Id" DataSourceID="SqlDataCatalogo" 
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
                                                        <asp:BoundField DataField="kco_Id" HeaderText="Id" ReadOnly="True" 
                                                            SortExpression="kco_Id" />
                                                        <asp:BoundField DataField="kco_Descripcion" HeaderText="Kits" 
                                                            SortExpression="kco_Descripcion" />
                                                        <asp:BoundField DataField="lco_Id" HeaderText="Id licitación" 
                                                            SortExpression="lco-Id" />                                                                                                             
                                                    </Columns>
                                                    <FooterStyle CssClass="footergrilla" />
                                                    <SelectedRowStyle CssClass="selectedgrilla" />
                                                    <HeaderStyle CssClass="headergrilla" />
                                                </asp:GridView>
                                                
                                                <asp:SqlDataSource ID="SqlDataCatalogo" runat="server" 
                                                    ConnectionString="<%$ ConnectionStrings:BDUTOConnectionString %>" 
                                                    DeleteCommand="DELETE FROM [Rrr].[kco_KitCompra] WHERE [kco_Id] = @kco_Id" 
                                                    InsertCommand="INSERT INTO [Rrr].[kco_KitCompra] ([kco_Id], [kco_Descripcion], [lco_Id]) VALUES (@kco_Id, upper(@kco_Descripcion),@lco_Id)" 
                                                    SelectCommand="SELECT kco_Id, kco_Descripcion,lco_Id  FROM [Rrr].kco_KitCompra" 
                                                    UpdateCommand="UPDATE [Rrr].[kco_KitCompra] SET [kco_Descripcion] =upper(@kco_Descripcion),  [lco_Id] =@lco_Id WHERE [kco_Id] = @kco_Id">
                                                    <DeleteParameters>
                                                        <asp:Parameter Name="kco_Id" Type="Int32" />
                                                    </DeleteParameters>
                                                    <UpdateParameters>
                                                        <asp:Parameter Name="kco_Descripcion" Type="String" />
                                                        <asp:Parameter Name="kco_Id" Type="Int32" />
                                                        <asp:Parameter Name="lco_Id" Type="Int32" />
                                                    </UpdateParameters>
                                                    <InsertParameters>
                                                        <asp:Parameter Name="kco_Id" Type="Int32" />
                                                        <asp:Parameter Name="kco_Descripcion" Type="String" />
                                                        <asp:Parameter Name="lco_Id" Type="Int32" />                                                                                        
                                                    </InsertParameters>
                                                </asp:SqlDataSource>
                                                
                                         <%--   </td>
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


