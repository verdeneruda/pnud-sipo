<%@ Page Title="" Language="C#" MasterPageFile="~/MPMain.Master" AutoEventWireup="true" CodeBehind="Subpartidas.aspx.cs" Inherits="UTO.Comunes.Subpartidas" %>

    <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

    <%@ Register src="~/Comunes/DocumentosVarios.ascx" tagname="DocumentosVarios" tagprefix="uc1" %>
    <%@ Register src="ControlError.ascx" tagname="ControlError" tagprefix="uc1" %>
    
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </cc1:ToolkitScriptManager>
    <div class="divwithoutgrid">
        <table class="titulo" >
            <tr>
                <td>
                    <asp:Label ID="labelPais" runat="server" Text="Subpartidas arancelarias" CssClass="subtitulo"></asp:Label>
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
    </div>    
    <div class="divgrillas">    
        <asp:GridView ID="gridCatalogo" runat="server" 
                                    AutoGenerateColumns="False" CssClass="grilla" 
                                                    DataKeyNames="ear_Id" DataSourceID="SqlDataCatalogo" 
                                                    
            FooterStyle-CssClass="footergrilla" HeaderStyle-CssClass="headergrilla" 
                                                    RowStyle-CssClass="rowgrilla" SelectedRowStyle-CssClass="selectedgrilla" 
                                                    Width="649px" onprerender="gridCatalogo_PreRender" 
                                    AllowPaging="True" PageSize="15" 
            onrowcommand="gridCatalogo_RowCommand">
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
                                                        <asp:BoundField DataField="ear_Id" HeaderText="Id" ReadOnly="True" 
                                                            SortExpression="ear_Id" />
                                                        <asp:BoundField DataField="ear_Descripcion" HeaderText="Partida" 
                                                            SortExpression="ear_Descripcion" />
                                                    </Columns>
                                                    <FooterStyle CssClass="footergrilla" />
                                                    <SelectedRowStyle CssClass="selectedgrilla" />
                                                    <HeaderStyle CssClass="headergrilla" />
            </asp:GridView>    
            <asp:SqlDataSource ID="SqlDataCatalogo" runat="server" 
                                                    ConnectionString="<%$ ConnectionStrings:BDUTOConnectionString %>" 
                                                    DeleteCommand="DELETE FROM [Uto].[ear_EquipoArancel] WHERE [ear_Id] = @ear_Id" 
                                                    InsertCommand="INSERT INTO [Uto].[ear_EquipoArancel] ([ear_Id], [ear_Descripcion]) VALUES (@ear_Id, upper(@ear_Descripcion))" 
                                                    SelectCommand="SELECT ear_Id, ear_Descripcion FROM [Uto].ear_EquipoArancel" 
                                                    UpdateCommand="UPDATE [Uto].[ear_EquipoArancel] SET [ear_Descripcion] = upper(@ear_Descripcion) WHERE [ear_Id] = @ear_Id">
                                                    <DeleteParameters>
                                                        <asp:Parameter Name="ear_Id" Type="Int32" />
                                                    </DeleteParameters>
                                                    <UpdateParameters>
                                                        <asp:Parameter Name="ear_Descripcion" Type="String" />
                                                        <asp:Parameter Name="ear_Id" Type="Int32" />
                                                    </UpdateParameters>
                                                    <InsertParameters>
                                                        <asp:Parameter Name="ear_Id" Type="Int32" />
                                                        <asp:Parameter Name="ear_Descripcion" Type="String" />
                                                    </InsertParameters>
                                                </asp:SqlDataSource>        
    </div>
</asp:Content>
