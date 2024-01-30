<%@ Page Language="C#" MasterPageFile="~/MPMain.Master" AutoEventWireup="true" CodeBehind="Aplicacion.aspx.cs" Inherits="UTO.Comunes.Aplicacion" %>

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
                    <asp:Label ID="labelAduana" runat="server" Text="Aplicación" CssClass="subtitulo"></asp:Label>
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
                                            <asp:GridView ID="gridAplicacion" runat="server" AutoGenerateColumns="False" CssClass="grilla" 
                                                DataKeyNames="apl_Id" DataSourceID="SqlDataAduana" 
                                                FooterStyle-CssClass="footergrilla" HeaderStyle-CssClass="headergrilla" 
                                                RowStyle-CssClass="rowgrilla" SelectedRowStyle-CssClass="selectedgrilla" 
                                                Width="649px" onprerender="gridAplicacion_PreRender" AllowPaging="True" 
                                                PageSize="15" onrowcommand="gridAplicacion_RowCommand">
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
                                                <asp:BoundField DataField="apl_Id" HeaderText="apl_Id" ReadOnly="True" 
                                                    SortExpression="apl_Id" />
                                                <asp:BoundField DataField="apl_Descripcion" HeaderText="apl_Descripcion" 
                                                    SortExpression="apl_Descripcion" />
                                                </Columns>
                                                <FooterStyle CssClass="footergrilla" />
                                                <SelectedRowStyle CssClass="selectedgrilla" />
                                                <HeaderStyle CssClass="headergrilla" />
                                             </asp:GridView>
                                             
                                             <asp:SqlDataSource ID="SqlDataAduana" runat="server" 
                                                ConnectionString="<%$ ConnectionStrings:BDUTOConnectionString %>" 
                                                DeleteCommand="DELETE FROM [Rus].[apl_Aplicacion] WHERE [apl_Id] = @apl_Id" 
                                                InsertCommand="INSERT INTO [Rus].[apl_Aplicacion] ([apl_Id], [apl_Descripcion]) VALUES (@apl_Id,upper(@apl_Descripcion))" 
                                                SelectCommand="SELECT apl_Id, apl_Descripcion FROM [Rus].[apl_Aplicacion]" 
                                                UpdateCommand="UPDATE [Rus].[apl_Aplicacion] SET [apl_Descripcion] =upper(@apl_Descripcion) WHERE [apl_Id] = @apl_Id">
                                                <DeleteParameters>
                                                    <asp:Parameter Name="apl_Id" Type="Int32" />
                                                </DeleteParameters>
                                                <UpdateParameters>
                                                    <asp:Parameter Name="apl_Descripcion" Type="String" />
                                                    <asp:Parameter Name="apl_Id" Type="Int32" />
                                                </UpdateParameters>
                                                <InsertParameters>
                                                    <asp:Parameter Name="apl_Id" Type="Int32" />
                                                <asp:Parameter Name="apl_Descripcion" Type="String" />
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
