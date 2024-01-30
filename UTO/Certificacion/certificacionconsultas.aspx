    <%@ Page Language="C#" MasterPageFile="~/MPMain.Master" AutoEventWireup="true" CodeBehind="certificacionconsultas.aspx.cs" Inherits="UTO.Certificacion.certificacionconsultas" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
    <asp:Content ID="contentCertificacionConsultasHead" ContentPlaceHolderID="head" Runat="Server">
    </asp:Content>
    <asp:Content  ID="contentCertificacionConsultas" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >

    <div class="divwithoutgrid">
        <table class="titulo" >
            <tr>
                <td>
                    <asp:Label ID="labelConsultas" runat="server" Text="Módulo certificación - Consultas" CssClass="subtitulo"></asp:Label>
                    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>
                </td>
            </tr>
        </table>
        
    <br />
    
        <table class="form">
            <tr>
                <td>
                    <table style="width:100%;">
                        <tr>
                            <th colspan="5">
                                <asp:Label ID="labelTecnicos" runat="server" Text="Técnicos" CssClass="subtitulo"></asp:Label>
                            </th>
                        </tr>
                        
                        <tr>
                            <td style="width:25%">
                                <asp:Label ID="LabelDepartamento" runat="server" Text="Departamento"></asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="comboDepartamentos" runat="server" 
                                    DataTextField="dep_Descripcion" DataValueField="dep_Id" CssClass="combo" 
                                    AutoPostBack="True" 
                                    onselectedindexchanged="comboDepartamentos_SelectedIndexChanged">
                                </asp:DropDownList>
                            </td>
                            <td class="separador">
                            </td>
                            <td> 
                                <asp:Label ID="LabelCiudad" runat="server" Text="Ciudad"></asp:Label>
                            </td>
                            <td>
                                <asp:UpdatePanel runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                <asp:DropDownList ID="comboCiudad" runat="server" DataTextField="mun_Descripcion" DataValueField="mun_Id" CssClass="combo"></asp:DropDownList>
                                </ContentTemplate>
                                <Triggers>
                                <asp:AsyncPostBackTrigger ControlID="comboDepartamentos"/>
                                </Triggers>
                                </asp:UpdatePanel>                                
                            </td>
                        </tr>                        
                        <tr>
                            <td>
                                <asp:Label ID="LabelCTG" runat="server" Text="CTG"></asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="comboCTG" runat="server" 
                                    CssClass="combo" DataTextField="cat_Descripcion" 
                                    DataValueField="cat_Id">
                                 </asp:DropDownList>
                            </td>
                            <td class="separador">
                            </td>
                            <td>
                                <asp:Label ID="LabelAreaTrabajo" runat="server" Text="Area trabajo"></asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="comboAreaTrabajo" runat="server" 
                                    CssClass="combo" DataTextField="atr_Des" 
                                    DataValueField="atr_Id" >
                                </asp:DropDownList>
                            </td>
                        </tr>                        
                        <tr>
                            <td>
                                <asp:Label ID="LabelEmpresa" runat="server" Text="Empresa"></asp:Label>
                            </td>
                            <td colspan="4">
                                <asp:DropDownList ID="comboEmpresa" runat="server" 
                                    CssClass="combo" DataTextField="ter_NombreCompleto" 
                                    DataValueField="ter_Id" Height="20px" Width="505px">
                                </asp:DropDownList>
                            </td>                            

                        </tr>                        
                        <tr>
                            <td colspan="5">
                                <asp:Button ID="buttonBuscar" runat="server" Text="Buscar" CssClass="button" 
                                    onclick="buttonBuscar_Click" />&nbsp;&nbsp;<asp:Button ID="buttonExportar"
                                    runat="server" Text="Exportar" CssClass="button" onclick="buttonExportar_Click" />&nbsp;&nbsp;<asp:Button ID="buttonCancelar"
                                    runat="server" Text="Cancelar" CssClass="button" onclick="buttonCancelar_Click" />
                            </td>
                        </tr>
    </table>
    </td>
            </tr>
        </table>
    </div>
    
     <br />
     
    <div class="divgrillas">
        <asp:GridView ID="gridconsultasCertificacion" runat="server" HeaderStyle-CssClass="headergrilla" 
            RowStyle-CssClass="rowgrilla" FooterStyle-CssClass="footergrilla" 
            CssClass="grilla" AutoGenerateColumns="False" 
            SelectedRowStyle-CssClass="selectedgrilla" Visible="False" 
            AllowPaging="True" DataSourceID="certificacionConsultasDataSource" 
            PageSize="15">
            <RowStyle CssClass="rowgrilla"></RowStyle>
            <Columns>
                <asp:BoundField DataField="AreaTrabajo" HeaderText="Área de trabajo" 
                    SortExpression="AreaTrabajo" />
                <asp:BoundField DataField="Categoria" HeaderText="Categoría" 
                    SortExpression="Categoria" />
                <asp:BoundField DataField="Empresa" HeaderText="Empresa" 
                    SortExpression="Empresa" />
                <asp:BoundField DataField="TipoDocumento" HeaderText="Tipo de documento" 
                    SortExpression="TipoDocumento" />
                <asp:BoundField DataField="Documento" HeaderText="Documento" 
                    SortExpression="Documento" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" 
                    SortExpression="Nombre" />
                <asp:BoundField DataField="Departamento" HeaderText="Departamento" 
                    SortExpression="Departamento" />
                <asp:BoundField DataField="Ciudad" HeaderText="Ciudad" 
                    SortExpression="Ciudad" />
                <asp:BoundField DataField="Direccion" HeaderText="Dirección" 
                    SortExpression="Direccion" />
                <asp:BoundField DataField="Telefono" HeaderText="Teléfono" 
                    SortExpression="Telefono" />
                <asp:BoundField DataField="Celular" HeaderText="Celular" 
                    SortExpression="Celular" />
                <asp:BoundField DataField="Email" HeaderText="Email" 
                    SortExpression="Email" />
                <asp:BoundField DataField="Fax" HeaderText="Fax" 
                    SortExpression="Fax" />
            </Columns>
            <FooterStyle CssClass="footergrilla"></FooterStyle>
            <SelectedRowStyle CssClass="selectedgrilla" />
            <HeaderStyle CssClass="headergrilla"></HeaderStyle>
        </asp:GridView>
        <asp:SqlDataSource ID="certificacionConsultasDataSource" runat="server" 
            ConnectionString="<%$ ConnectionStrings:BDUTOConnectionString %>" 
            SelectCommand="exec [cer].[spConsultaTecnico] @idDepartamento,@IdMunicipio,@idCategoria,@idArea,@idEmpresa">
            <SelectParameters>
                <asp:Parameter Name="idDepartamento" />
                <asp:Parameter Name="IdMunicipio" />
                <asp:Parameter Name="idCategoria" />
                <asp:Parameter Name="idArea" />
                <asp:Parameter Name="idEmpresa" />
            </SelectParameters>
        </asp:SqlDataSource>
    </div>
    
    <br />
    
    </asp:Content>

