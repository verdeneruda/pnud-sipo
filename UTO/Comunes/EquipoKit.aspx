<%@ Page Language="C#" MasterPageFile="~/MPMain.Master"  AutoEventWireup="true" CodeBehind="EquipoKit.aspx.cs" Inherits="UTO.Comunes.EquipoKit" %>

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
                        <asp:Label ID="labelPais" runat="server" Text="Equipo kit" CssClass="subtitulo"></asp:Label>
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
<%--                        <table style="width:100%">
                            <tr>--%>
                                <td>
                                   <%-- <asp:Panel ID="PanelBuscarTercero" runat="server" Width="671px">--%>
                                        <%--<table>
                                            <tr>
                                                <td>--%>
                                                    <asp:GridView ID="gridCatalogo" runat="server" 
                                        AutoGenerateColumns="False" CssClass="grilla" 
                                                        DataKeyNames="eki_Id" DataSourceID="SqlDataCatalogo" 
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
                                                            <asp:BoundField DataField="eki_Id" HeaderText="Id" ReadOnly="True" 
                                                                SortExpression="eki_Id" />
                                                            <asp:BoundField DataField="eki_Descripcion" HeaderText="Equipo" 
                                                                SortExpression="eki_Descripcion" />
                                                            <asp:BoundField DataField="kco_Id" HeaderText="Id kit" 
                                                                SortExpression="kco-Id" />    
                                                            <asp:BoundField DataField="eki_Costo" HeaderText="Costo" 
                                                                SortExpression="eki_Costo" /> 
                                                            <asp:BoundField DataField="eki_Disponible" HeaderText="Disponible" 
                                                                SortExpression="eki_Disponible" />                                                                                                            
                                                        </Columns>
                                                        <FooterStyle CssClass="footergrilla" />
                                                        <SelectedRowStyle CssClass="selectedgrilla" />
                                                        <HeaderStyle CssClass="headergrilla" />
                                                    </asp:GridView>
                                                    
                                                    <asp:SqlDataSource ID="SqlDataCatalogo" runat="server" 
                                                        ConnectionString="<%$ ConnectionStrings:BDUTOConnectionString %>" 
                                                        DeleteCommand="DELETE FROM [Rrr].[eki_EquipoKit] WHERE [eki_Id] = @eki_Id" 
                                                        InsertCommand="INSERT INTO [Rrr].[eki_EquipoKit] ([eki_Id], [eki_Descripcion], [kco_Id], [eki_Costo], [eki_Disponible]) VALUES (@eki_Id, @eki_Descripcion,@kco_Id, @eki_Costo,@eki_Disponible)" 
                                                        SelectCommand="SELECT eki_Id, eki_Descripcion,kco_Id, eki_Costo, eki_Disponible  FROM [Rrr].eki_EquipoKit" 
                                                        UpdateCommand="UPDATE [Rrr].[eki_EquipoKit] SET [eki_Descripcion] = @eki_Descripcion,  [kco_Id] =@kco_Id , [eki_Costo] = @eki_Costo, [eki_Disponible]=@eki_Disponible WHERE [eki_Id] = @eki_Id">
                                                        <DeleteParameters>
                                                            <asp:Parameter Name="eki_Id" Type="Int32" />
                                                        </DeleteParameters>
                                                        <UpdateParameters>
                                                            <asp:Parameter Name="eki_Descripcion" Type="String" />
                                                            <asp:Parameter Name="eki_Id" Type="Int32" />
                                                            <asp:Parameter Name="kco_Id" Type="Int32" />
                                                            <asp:Parameter Name="eki_Costo" Type="Double" />
                                                            <asp:Parameter Name="eki_Disponible" Type="Int32" />
                                                        </UpdateParameters>
                                                        <InsertParameters>
                                                            <asp:Parameter Name="eki_Id" Type="Int32" />
                                                            <asp:Parameter Name="eki_Descripcion" Type="String" />
                                                            <asp:Parameter Name="kco_Id" Type="Int32" />     
                                                            <asp:Parameter Name="eki_Costo" Type="Double" />   
                                                            <asp:Parameter Name="eki_Disponible" Type="Int32" />                                                                                        
                                                        </InsertParameters>
                                                    </asp:SqlDataSource>
                                                </td>
                                              <%--  <td class="separador">
                                                    &nbsp;
                                                </td>--%>
                                        <%--    </tr>
                                        </table>--%>
                                   <%-- </asp:Panel>--%>
                                </td>
                            </tr>
                        </table>
<%--                    </td>
                </tr>
            </table>--%>
 </div>
 
        <br />
        <br />
        
    </asp:Content>


