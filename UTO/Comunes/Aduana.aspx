<%@ Page Language="C#" MasterPageFile="~/MPMain.Master"  AutoEventWireup="true" CodeBehind="Aduana.aspx.cs" Inherits="UTO.Comunes.Aduana" %>

    <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

    <%@ Register src="~/Comunes/DocumentosVarios.ascx" tagname="DocumentosVarios" tagprefix="uc1" %>
    <%@ Register src="ControlError.ascx" tagname="ControlError" tagprefix="uc1" %>
    
    <asp:Content  ID="contentSolicitudEquiposBuscar" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
        <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
        </cc1:ToolkitScriptManager>    
    
    <%--<div class="divwithoutgrid">--%>
        <table class="titulo" >
            <tr>
                <td>
                    <asp:Label ID="labelAduana" runat="server" Text="Aduana" CssClass="subtitulo"></asp:Label>
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
                  <%--<table style="width:100%">--%>
                       <%-- <tr>
                            <td>--%>
                                <%--<asp:Panel ID="PanelBuscarTercero" runat="server" Width="671px">--%>
                                    <table>
                                        <tr>
                                        <td>
                                            <asp:GridView ID="gridAduana" runat="server" AutoGenerateColumns="False" CssClass="grilla" 
                                                DataKeyNames="adu_Id" DataSourceID="SqlDataAduana" 
                                                FooterStyle-CssClass="footergrilla" HeaderStyle-CssClass="headergrilla" 
                                                RowStyle-CssClass="rowgrilla" SelectedRowStyle-CssClass="selectedgrilla" 
                                                Width="649px" onprerender="gridAduana_PreRender" AllowPaging="True" 
                                                PageSize="15" onrowcommand="gridAduana_RowCommand">
                                                <RowStyle CssClass="rowgrilla" />
                                                <Columns>
                                                <asp:CommandField ShowEditButton="True" ButtonType="Button" EditText="Modificar" UpdateText="Aceptar" CancelText="Cancelar">
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
                                                <asp:BoundField DataField="adu_Id" HeaderText="adu_Id" ReadOnly="True" 
                                                    SortExpression="adu_Id" />
                                                <asp:BoundField DataField="adu_Descripcion" HeaderText="adu_Descripcion" 
                                                    SortExpression="adu_Descripcion" />
                                                </Columns>
                                                <FooterStyle CssClass="footergrilla" />
                                                <SelectedRowStyle CssClass="selectedgrilla" />
                                                <HeaderStyle CssClass="headergrilla" />
                                             </asp:GridView>
                                             
                                             <asp:SqlDataSource ID="SqlDataAduana" runat="server" 
                                                ConnectionString="<%$ ConnectionStrings:BDUTOConnectionString %>" 
                                                DeleteCommand="DELETE FROM [Uto].[adu_Aduana] WHERE [adu_Id] = @adu_Id" 
                                                InsertCommand="INSERT INTO [Uto].[adu_Aduana] ([adu_Id], [adu_Descripcion]) VALUES (@adu_Id,upper(@adu_Descripcion))" 
                                                SelectCommand="SELECT adu_Id, adu_Descripcion FROM [Uto].adu_Aduana" 
                                                UpdateCommand="UPDATE [Uto].[adu_Aduana] SET [adu_Descripcion] =upper(@adu_Descripcion) WHERE [adu_Id] = @adu_Id">
                                                <DeleteParameters>
                                                    <asp:Parameter Name="adu_Id" Type="Int32" />
                                                </DeleteParameters>
                                                <UpdateParameters>
                                                    <asp:Parameter Name="adu_Descripcion" Type="String" />
                                                    <asp:Parameter Name="adu_Id" Type="Int32" />
                                                </UpdateParameters>
                                                <InsertParameters>
                                                    <asp:Parameter Name="adu_Id" Type="Int32" />
                                                <asp:Parameter Name="adu_Descripcion" Type="String" />
                                                </InsertParameters>
                                             </asp:SqlDataSource>
                                        </td>
                                       <%-- <td class="separador">
                                            &nbsp;
                                        </td>--%>
                                    </tr>
                                    </table>
                                <%--</asp:Panel>--%>
                          <%-- </td>
                       </tr>--%>
                <%--   </table>--%>
               </td>
          </tr>
       </table>
    <%--</div>--%>
    
    <br />
    <br />
    
 </asp:Content>


