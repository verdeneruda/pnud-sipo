    <%@ Page Language="C#" MasterPageFile="~/MPMain.Master"  AutoEventWireup="true" CodeBehind="EncuestaBuscar.aspx.cs" Inherits="UTO.Comercializacion.EncuestaBuscar" %>

    <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
    <%@ Register src="../Comunes/ControlError.ascx" tagname="ControlError" tagprefix="uc1" %>
    <asp:Content ID="contentEncuestaBuscarHead" ContentPlaceHolderID="head" Runat="Server">
    </asp:Content>

    <asp:Content  ID="contentEncuestaBuscar" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
        <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
        </cc1:ToolkitScriptManager>
        
    <div class="divwithoutgrid">
        <table class="titulo" >
            <tr>
                <td>
                    <asp:Label ID="labelBusquedaEmpresas" runat="server" Text="Módulo de seguimiento al comercio local de SAO - Buscar datos de comercialización" CssClass="subtitulo"></asp:Label>
                </td>
            </tr>
        </table>
    <table class="form">
        <tr>
            <td>            
                <uc1:ControlError ID="ControlError1" runat="server" />            
            </td>
        </tr>
    </table>          
    <br />
    
    <table class="form">
        <tr>

                        <th colspan="5">
                            <asp:Label ID="labelparametros" runat="server" Text="Parámetros búsqueda" CssClass="subtitulo"></asp:Label>
                        </th>
                    </tr>
                    <tr>
                        <td style="width:20%">
                            <asp:Label ID="labelNit" runat="server" Text="Nit" CssClass="label"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="textNit" runat="server"  CssClass="texto2"></asp:TextBox>
                        </td>
                        <td class="separador">
                        </td>
                        <td style="width:20%">
                            <asp:Label ID="labelEmpresa" runat="server" Text="Nombre o Razón social" 
                                CssClass="label"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="textEmpresa" runat="server" CssClass="texto2"></asp:TextBox>
                        </td>
                    </tr>
                    
                    <tr>
                        <td>
                            <asp:Label ID="labelFechaInicial" runat="server" Text="Fecha inicial" CssClass="label"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="textfechaInicial" runat="server"  CssClass="texto2"></asp:TextBox>
                            <cc1:CalendarExtender ID="calendarfechaInicial" Format="dd/MM/yyyy"  runat="server" CssClass="calendar" TargetControlID="textfechaInicial">
                            </cc1:CalendarExtender>
                        </td>
                        <td class="separador">
                        </td>
                        <td>
                            <asp:Label ID="labelFechaFinal" runat="server" Text="Fecha final" CssClass="label"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="textFechaFinal" runat="server"  CssClass="texto2"></asp:TextBox>
                            <cc1:CalendarExtender ID="calendarfechaFinal" Format="dd/MM/yyyy"  runat="server" CssClass="calendar" TargetControlID="textFechaFinal">
                            </cc1:CalendarExtender>
                        </td>
                    </tr>
                    
                    <tr>
                        <td>
                            <asp:Label ID="labelDepartamento" runat="server" Text="Departamento visita" CssClass="label"></asp:Label> 
                        </td>
                        <td>
                            <asp:DropDownList ID="comboDepartamento" runat="server" CssClass="combo" DataTextField="dep_Descripcion" 
                                DataValueField="dep_Id" AutoPostBack="True" 
                                onselectedindexchanged="comboDepartamento_SelectedIndexChanged">
                            </asp:DropDownList>
                        </td>
                        <td class="separador">
                        </td>
                        <td>
                            <asp:Label ID="labelCiudad" runat="server" Text="Ciudad visita" CssClass="label"></asp:Label>
                        </td>
                        <td>
                            <asp:UpdatePanel runat="server" UpdateMode="Conditional">
                            <ContentTemplate>
                            <asp:DropDownList ID="comboCiudad" runat="server" CssClass="combo" 
                                DataTextField="mun_Descripcion" DataValueField="mun_Id" 
                                AutoPostBack="True">
                            </asp:DropDownList>
                            </ContentTemplate>
                            <Triggers>
                            <asp:AsyncPostBackTrigger ControlID="comboDepartamento"/>
                            </Triggers>
                            </asp:UpdatePanel>                            
                        </td>
                    </tr>
                        <td colspan="5">
                            <asp:Label ID="labelResultado" runat="server" Text=""></asp:Label>
                        </td>
                    <tr>
                        <td colspan="5">
                            <asp:Button ID="buttonBuscar" runat="server" Text="Buscar" CssClass="button" 
                                onclick="buttonBuscar_Click" />&nbsp;&nbsp;
                            <asp:Button ID="buttonAdicionar" runat="server" Text="Adicionar"  CssClass="button" 
                                onclick="buttonAdicionar_Click"/>
                            <asp:Button ID="buttonImportar" runat="server" Text="Importar"  CssClass="button" OnClientClick="window.open('http://localhost:8275/Comercializacion/EncuestaRegistroCargue.aspx', '_blank');"/>

    </td>
    </tr>
    </table>
    </div>
    
    <br />
    
    <div class="divgrillas">
        <asp:GridView ID="gridBuscarEncuestaComercializacion" runat="server" CssClass="grilla" 
            HeaderStyle-CssClass="headergrilla" RowStyle-CssClass="rowgrilla"  AutoGenerateColumns="False" 
            SelectedRowStyle-CssClass="selectedgrilla" 
            FooterStyle-CssClass="footergrilla" 
            onrowcommand="gridBuscarEncuestaComercializacion_RowCommand" 
            DataKeyNames="Id" AllowPaging="True" DataSourceID="EncuestaBuscarDataSource" 
            PageSize="15">
            <RowStyle CssClass="rowgrilla"></RowStyle>
            <Columns>
                <asp:ButtonField ButtonType="Button" CommandName="Ver" 
                    ShowHeader="True" Text="Ver">
                    <ControlStyle CssClass="buttongrilla" />
                </asp:ButtonField>
                <asp:ButtonField CommandName="Modificar" ShowHeader="True" 
                    Text="Modificar" ButtonType="Button" >
                    <ControlStyle CssClass="buttongrilla" />
                </asp:ButtonField>
                <asp:TemplateField>
    <ItemTemplate>
    <asp:Button runat="server" ID="buttonEliminar" Text="Eliminar" CommandName="Eliminar" CommandArgument="<%# Container.DataItemIndex %>" OnClientClick="return confirm('Este registro se eliminará, desea continuar?')" CssClass="buttongrilla"/>
    </ItemTemplate>    
    </asp:TemplateField>                
                <asp:BoundField DataField="Fecha" HeaderText="Fecha" 
                    SortExpression="Fecha" DataFormatString="{0:dd/MM/yyyy}"/>
                <asp:BoundField DataField="Departamento" HeaderText="Departamento" 
                    SortExpression="Departamento" />
                <asp:BoundField DataField="Ciudad" HeaderText="Ciudad" 
                    SortExpression="Ciudad" />
                <asp:BoundField DataField="Empresa" HeaderText="Empresa" 
                    SortExpression="Empresa" />
                <asp:BoundField DataField="Direccion" HeaderText="Dirección" 
                    SortExpression="Direccion" />
                <asp:BoundField DataField="Contacto" HeaderText="Contacto" 
                    SortExpression="Contacto" />
                <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" 
                    Visible="False" />
            </Columns>
            <FooterStyle CssClass="footergrilla"></FooterStyle>
            <SelectedRowStyle CssClass="selectedgrilla"></SelectedRowStyle>
            <HeaderStyle CssClass="headergrilla"></HeaderStyle>
        </asp:GridView>
        <asp:SqlDataSource ID="EncuestaBuscarDataSource" runat="server" 
            ConnectionString="<%$ ConnectionStrings:BDUTOConnectionString %>" 
            SelectCommand="exec [Com].[spEncuestaBuscar] @nit,@idEmpresa,@fechaInicial,@fechaFinal,@departamento,@municipio">
            <SelectParameters>
                <asp:Parameter Name="nit" />
                <asp:Parameter Name="idEmpresa" />
                <asp:Parameter Name="fechaInicial" />
                <asp:Parameter Name="fechaFinal" />
                <asp:Parameter Name="departamento" />
                <asp:Parameter Name="municipio" />
            </SelectParameters>
        </asp:SqlDataSource>
    </div>   
    </asp:Content>