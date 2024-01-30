    <%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MPMain.Master" CodeBehind="Pendientes.aspx.cs" Inherits="UTO.Comunes.PendientesCertificacion" %>
    <%@ Register src="ControlError.ascx" tagname="ControlError" tagprefix="uc2" %>
    <asp:Content ID="contentPendientesCertificacionHead" ContentPlaceHolderID="head" Runat="Server">
    </asp:Content>
    <asp:Content  ID="contentPendientesCertificacion" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
        <asp:XmlDataSource ID="xmlpendientes" runat="server" 
    DataFile="~/App_Data/MCertificacionPendientes.xml"></asp:XmlDataSource>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
   
    <div class="divwithoutgrid">
    
        <table class="titulo" >
            <tr>
                <td>
                    <asp:Label ID="labelPendientes" runat="server" Text="Pendientes" CssClass="subtitulo"></asp:Label>
                </td>
            </tr>
        </table>
        
        <table style="width:100%;">    
            <tr>
                <td>
                    <uc2:ControlError ID="ControlError1" runat="server" />
                </td>
            </tr>
        </table>
        
        <table class="form">
            <tr>
                <td>
                    <table style="width:100%;"> 
                        <tr>
                            <th colspan="4">
                                <asp:Label ID="labelAlertas" runat="server" Text="Alertas" CssClass="subtitulo"></asp:Label>
                            </th>
                        </tr>
                        
                        <tr>
                            <td> 
                                <asp:CheckBox ID="checkTodo" runat="server" Text="Todo" CssClass="check" />
                            </td>
                            <td>
                                <asp:CheckBox ID="checkVerde" runat="server" Text="Verde" CssClass="check" />
                            </td>
                            <td>
                                <asp:CheckBox ID="checkAmarillo" runat="server" Text="Amarillo" CssClass="check" />
                            </td>
                            <td>
                                <asp:CheckBox ID="checkRojo" runat="server" Text="Rojo" CssClass="check" />
                            </td>
                        </tr>
                        
                        <tr>
                            <td colspan="4">
                                <asp:Button ID="buttonBuscar" runat="server" Text="Buscar" CssClass="button" 
                                    onclick="buttonBuscar_Click" />&nbsp;&nbsp;<asp:Button ID="buttonCancelar"
                                    runat="server" Text="Cancelar" CssClass="button" />
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
        
    </div>
    
    <br />
    
    <div class="divgrillas">
        <asp:GridView ID="gridPendientes" runat="server" HeaderStyle-CssClass="headergrilla" 
            RowStyle-CssClass="rowgrilla" FooterStyle-CssClass="footergrilla" 
            CssClass="grilla" AutoGenerateColumns="False" 
            SelectedRowStyle-CssClass="selectedgrilla" 
            onrowdatabound="gridPendientes_RowDataBound" DataKeyNames="ID_Registro" 
            onrowcommand="gridPendientes_RowCommand" AllowPaging="True" PageSize="15">
            <RowStyle CssClass="rowgrilla"></RowStyle>
            <Columns>
                <asp:ButtonField ButtonType="Button" CommandName="Ver" Text="Ver" 
                        ControlStyle-CssClass="buttongrilla" >
                    <ControlStyle CssClass="buttongrilla"></ControlStyle>
                </asp:ButtonField>
                <asp:TemplateField HeaderText="Estado">
                    <ItemTemplate>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Dias" HeaderText="Días" SortExpression="Dias" />
                <asp:BoundField DataField="TipoAlerta" HeaderText="Tipo alerta" 
                SortExpression="TipoAlerta" />
                <asp:BoundField DataField="DescripcionAlerta" HeaderText="Descripción alerta" 
                SortExpression="DescripcionAlerta" />
                <asp:BoundField DataField="ID_Registro" HeaderText="ID_Registro" 
                SortExpression="ID_Registro" />
                <asp:BoundField DataField="Parametro1" HeaderText="Parametro1" 
                SortExpression="Parametro1" />
            </Columns>

                <FooterStyle CssClass="footergrilla"></FooterStyle>

                <SelectedRowStyle CssClass="selectedgrilla" />

                <HeaderStyle CssClass="headergrilla"></HeaderStyle>

        </asp:GridView>
    </div>
    <br />
    </asp:Content>
