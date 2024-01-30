<%@ Page Language="C#" MasterPageFile="~/MPMain.Master"  AutoEventWireup="true" CodeBehind="Sustancia.aspx.cs" Inherits="UTO.Comunes.Sustancia" %>

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
                    <asp:Label ID="labelSustancia" runat="server" Text="Sustancia" CssClass="subtitulo"></asp:Label>
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
                                                    DataKeyNames="sus_Id" DataSourceID="SqlDataSustancia" 
                                                    FooterStyle-CssClass="footergrilla" HeaderStyle-CssClass="headergrilla" 
                                                    RowStyle-CssClass="rowgrilla" SelectedRowStyle-CssClass="selectedgrilla" 
                                                    Width="649px" onprerender="gridSustancia_PreRender" 
                                    AllowPaging="True" PageSize="15" onrowcommand="gridCatalogo_RowCommand">
                                                    <RowStyle CssClass="rowgrilla" />
                                                    <Columns>
                                                        <asp:CommandField ButtonType="Button" ShowEditButton="True" EditText="Modificar" UpdateText="Aceptar" CancelText="Cancelar">
                                                            <ControlStyle CssClass="buttongrilla" />
                                                        </asp:CommandField>
<%--                                                        <asp:CommandField ButtonType="Button" ShowDeleteButton="True" DeleteText="Eliminar">
                                                            <ControlStyle CssClass="buttongrilla" />
                                                        </asp:CommandField>--%>
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
                                                        <asp:BoundField DataField="sus_Id" HeaderText="Id" ReadOnly="True" 
                                                            SortExpression="sus_Id" />
                                                        <asp:BoundField DataField="sus_Descripcion" HeaderText="Sustancia" 
                                                            SortExpression="sus_Descripcion" />
                                                        <asp:BoundField DataField="sus_Arancel" HeaderText="Arancel" 
                                                            SortExpression="sus_Arancel" />
                                                    </Columns>
                                                    <FooterStyle CssClass="footergrilla" />
                                                    <SelectedRowStyle CssClass="selectedgrilla" />
                                                    <HeaderStyle CssClass="headergrilla" />
                                                </asp:GridView>
                                                
                                                <asp:SqlDataSource ID="SqlDataSustancia" runat="server" 
                                                    ConnectionString="<%$ ConnectionStrings:BDUTOConnectionString %>" 
                                                    DeleteCommand="DELETE FROM [Uto].[sus_Sustancia] WHERE [sus_Id] = @sus_Id" 
                                                    InsertCommand="INSERT INTO [Uto].[sus_Sustancia]([sus_Id],[sus_Arancel],[sus_Descripcion])VALUES(@sus_Id, upper(@sus_Arancel), upper(@sus_Descripcion))" 
                                                    SelectCommand="SELECT [sus_Id], [sus_Arancel], [sus_Descripcion] FROM [Uto].[sus_Sustancia] order by sus_id" 
                                                    
                                                    
                                                    
                                    UpdateCommand="UPDATE [Uto].[sus_Sustancia] SET [sus_Arancel] = @sus_Arancel, [sus_Descripcion] = upper(@sus_Descripcion) WHERE [sus_Id] = @sus_Id">
                                                    <DeleteParameters>
                                                        <asp:Parameter Name="sus_Id" Type="Int32" />
                                                    </DeleteParameters>
                                                    <UpdateParameters>
                                                        <asp:Parameter Name="sus_Arancel" Type="String" />
                                                        <asp:Parameter Name="sus_Descripcion" Type="String" />
                                                        <asp:Parameter Name="sus_Id" Type="Int32" />
                                                    </UpdateParameters>
                                                    <InsertParameters>
                                                        <asp:Parameter Name="sus_Id" />
                                                        <asp:Parameter Name="sus_Arancel" />
                                                        <asp:Parameter Name="sus_Descripcion" />
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
<%--<asp:Content ID="Content1" runat="server" contentplaceholderid="head">

    <style type="text/css">
        .style1
        {
            width: 11px;
        }
    </style>

    </asp:Content>--%>