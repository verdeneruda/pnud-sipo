    <%@ Page Language="C#" MasterPageFile="~/MPMain.Master"  AutoEventWireup="true" CodeBehind="TerceroRegistrar.aspx.cs" Inherits="UTO.Comunes.TerceroRegistrar" %>

    <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

    
    <%@ Register assembly="DevExpress.Web.v15.1, Version=15.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
    <%@ Register src="ControlError.ascx" tagname="ControlError" tagprefix="uc1" %>
    <asp:Content ID="Content1" runat="server" contentplaceholderid="head">
        </asp:Content>
    <asp:Content  ID="contentSolicitudEquiposBuscar" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
        <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </cc1:ToolkitScriptManager>
    <div class="divwithoutgrid">    
    <table class="titulo" >
    <tr><td>
    <asp:Label ID="labelComunesTercero" runat="server" Text="Módulo comunes" 
    CssClass="subtitulo"></asp:Label>
    </td></tr>
    </table>
     <table class="form">
     <tr>
         <td>         
             <uc1:ControlError ID="ControlError1" runat="server" />         
         </td>
     </tr>
     </table>
    <asp:Panel ID="PanelDatosTercero" runat="server"> 
        <table class="form">
        <tr>
        <td><table style="width:100%">
        <tr>
        <th colspan="4">   
        <asp:Label ID="labelparametros" runat="server" Text="Registrar terceros" 
        CssClass="subtitulo"></asp:Label>
        </th>
        </tr>
        <tr>
        <td>
        <asp:Label ID="labelNombreBeneficiario" runat="server" CssClass="label" 
        Text="Nombre del beneficiario / Razón social"></asp:Label>
        </td>
        <td colspan="3">
        <asp:TextBox ID="TextRazonSocial" runat="server" CssClass="texto2" 
        Width="450px" ></asp:TextBox>
        </td>
        </tr>
        <tr>
        <td>
        <asp:Label ID="labelTipoDocumento" runat="server" CssClass="label" Text="Tipo documento"></asp:Label>                
        </td>
        <td>
        <asp:DropDownList ID="comboTipoDocumento" runat="server" CssClass="combo" DataTextField="dti_Descripcion" 
        DataValueField="dti_Id" Width="200px">
        </asp:DropDownList>
        </td>
        <td>                
        <asp:Label ID="labelDocumento" runat="server" CssClass="label" Text="Documento"></asp:Label>
        </td>
        <td>                
        <asp:TextBox ID="textDocumento" runat="server" AutoCompleteType="Disabled" 
        CssClass="texto2" 
        Width="135px"></asp:TextBox>
        </td>
        </tr>
        <tr>
        <td>
        <asp:Label ID="labelRegional" runat="server" CssClass="label" Text="Regional"></asp:Label>
        </td>
        <td>
        <asp:DropDownList ID="comboRegional" runat="server" CssClass="combo" 
                DataTextField="reg_Descripcion" DataValueField="reg_Id" Width="200px">
        </asp:DropDownList>
        </td>
        <td>
        <asp:Label ID="labelDepartamento" runat="server" CssClass="label" 
        Text="Departamento"></asp:Label>
        </td>
        <td>
        <asp:DropDownList ID="comboDepartamento" runat="server" CssClass="combo" DataTextField="dep_Descripcion" 
        DataValueField="dep_Id" Width="136px" 
                onselectedindexchanged="comboDepartamento_SelectedIndexChanged" 
                AutoPostBack="True">
        </asp:DropDownList>
        </td>
        </tr>
        <tr>
        <td>
        <asp:Label ID="labelCiudad" runat="server" CssClass="label" Text="Ciudad"></asp:Label>
        </td>
        <td>
        <asp:DropDownList ID="comboCiudad" runat="server" CssClass="combo" 
                DataTextField="mun_Descripcion" DataValueField="mun_Id" Width="200px">
        </asp:DropDownList>
        </td>
        <td>
        <asp:Label ID="labelTelefono" runat="server" CssClass="label" Text="Teléfono"></asp:Label>
        </td>
        <td>
        <asp:TextBox ID="textTelefono" runat="server" CssClass="texto2" 
        Width="137px"></asp:TextBox>
        </td>
        </tr>
        <tr>
        <td>
        <asp:Label ID="labeldireccion" runat="server" CssClass="label" Text="Dirección"></asp:Label>
        </td>
        <td colspan="3">
        <asp:TextBox ID="textDireccion" runat="server" CssClass="texto2" 
        Width="450px"></asp:TextBox>
        </td>
        </tr>
        <tr>
        <td>
        <asp:Label ID="labelCorreo" runat="server" CssClass="label" Text="Correo"></asp:Label>
        </td>
        <td colspan="3">
        <asp:TextBox ID="textCorreo" runat="server" CssClass="texto2" Width="200px"></asp:TextBox>
        </td>
        </tr>
            <tr>
                <td colspan="4">
                    <div class="divgrillassinmargin">
                        <asp:GridView ID="gridTipoTercero" runat="server" AutoGenerateColumns="False" 
                            CssClass="grilla" DataKeyNames="tti_Id" FooterStyle-CssClass="footergrilla" 
                            HeaderStyle-CssClass="headergrilla" RowStyle-CssClass="rowgrilla" 
                            SelectedRowStyle-CssClass="selectedgrilla" Width="442px">
                            <RowStyle CssClass="rowgrilla" />
                            <Columns>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:CheckBox ID="CheckTipo" runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="tti_Id" HeaderText="Id Tipo" Visible="False" />
                                <asp:BoundField DataField="tti_descripcion" HeaderText="Tipo tercero" />
                            </Columns>
                            <FooterStyle CssClass="footergrilla" />
                            <SelectedRowStyle CssClass="selectedgrilla" />
                            <HeaderStyle CssClass="headergrilla" />
                        </asp:GridView>
                    </div>
                </td>
            </tr>
        <tr>
        <td>
        <asp:Label ID="labelTipoBeneficiario" runat="server" CssClass="label" 
        Text="Tipo beneficiario"></asp:Label>
        </td>
        <td colspan="3">
        <asp:RadioButton ID="RadioPersonaNatural" runat="server" CssClass="radio" 
        GroupName="TipoBeneficiario" Text="Persona natural" AutoPostBack="True" 
                Checked="True" oncheckedchanged="RadioPersonaNatural_CheckedChanged" />
        &nbsp;<asp:RadioButton ID="RadioPersonaJuridica" runat="server" CssClass="radio" 
        GroupName="TipoBeneficiario" Text="Persona jurídica" AutoPostBack="True" 
        oncheckedchanged="RadioPersonaJuridica_CheckedChanged" />
        </td>
        </tr>

        <tr>
        <td colspan="4">
        <asp:Panel ID="PanelPersonaJuridica" runat="server" Visible="False">
        <table>
        <tr>
        <td>
        <asp:Label ID="labelEstablecimiento" runat="server" CssClass="label" 
        Text="Establecimiento de comercio"></asp:Label>
        </td>
        <td colspan="5">
        <asp:TextBox ID="textEstablecimientoComercio" runat="server" CssClass="texto2" 
        Width="500px"></asp:TextBox>
        </td>
        </tr>
        <tr>
        <td>
        <asp:Label ID="labelRepresentanteLegal0" runat="server" CssClass="label" 
        Text="Representante legal"></asp:Label>
        </td>
        <td colspan="5">
        <asp:TextBox ID="textNombreRepresentante" runat="server" CssClass="texto2" 
        Width="500px"></asp:TextBox>
        </td>
        </tr>
        <tr>
        <td>
        <asp:Label ID="labelTipoDocumentoRL0" runat="server" CssClass="label" 
        Text="Tipo documento"></asp:Label>
        </td>
        <td >
        <asp:DropDownList ID="comboTipoDocumentoRL" runat="server" CssClass="combo" DataTextField="dti_Descripcion" 
        DataValueField="dti_Id" Width="135px">
        </asp:DropDownList>
        </td>
        <td>
        <asp:Label ID="labelDocumentoRL0" runat="server" CssClass="label" 
        Text="Documento"></asp:Label>
        </td>
            <td>
                <asp:TextBox ID="textDocumentoRL" runat="server" AutoCompleteType="Disabled" 
                    CssClass="texto2" Width="103px"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="labelDe" runat="server" CssClass="label" Text="De"></asp:Label>
            </td>
        <td>
            <asp:TextBox ID="textDe" runat="server" CssClass="texto2" Enabled="False" 
                Height="20px" Width="124px"></asp:TextBox>
        </td>
        </tr>
        </table>
        </asp:Panel>
        </td>
        </tr>

        <tr>
        <td colspan="4">
        <div class="divgrillassinmargin">
        <asp:GridView ID="gridGrupoProyecto" runat="server" AutoGenerateColumns="False" 
        CssClass="grilla" 
        FooterStyle-CssClass="footergrilla" HeaderStyle-CssClass="headergrilla" 
        RowStyle-CssClass="rowgrilla" SelectedRowStyle-CssClass="selectedgrilla" 
                Width="442px" DataKeyNames="pyg_Id">
        <RowStyle CssClass="rowgrilla" />
            <Columns>
                <asp:TemplateField>
                <ItemTemplate>
                    <asp:CheckBox ID="CheckGrupo" runat="server" />
                </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="pyg_Id" HeaderText="Id Grupo" Visible="False" />
                <asp:BoundField DataField="pyg_descripcion" HeaderText="Grupo de proyecto" />
            </Columns>
        <FooterStyle CssClass="footergrilla" />
        <SelectedRowStyle CssClass="selectedgrilla" />
        <HeaderStyle CssClass="headergrilla" />
        </asp:GridView>      
        </div>      
        </td>
        </tr>
        </table>
        </td>
        </tr>
        </table>
        <asp:Panel ID="panelDuplicado" runat="server" style="display:"> 
        <table class="form">
            <tr>
               <td>
                <table style="width:100%">
                    <tr>
                        <th colspan="4">   
                            <asp:Label ID="label1" runat="server" Text="Buscar posibles terceros duplicados" 
                            CssClass="subtitulo"></asp:Label>
                        </th>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="label2" runat="server" Text="Nombre beneficiario" CssClass="label"></asp:Label>
                        </td>
                        <td colspan="3">
                            <asp:TextBox ID="textBeneficiarioBuscar" runat="server"  CssClass="texto2" 
                                Width="449px"></asp:TextBox>
                        </td>
                        <%--<td class="separador">
                            &nbsp;
                        </td>--%>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="label3" runat="server" CssClass="label" Text="Tipo documento"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="comboTipo" runat="server" CssClass="combo" DataTextField="dti_Descripcion" 
                                DataValueField="dti_Id" Width="106px">
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:Label ID="labelNumeroDocumento" runat="server" CssClass="label" 
                                Text="Número documento"></asp:Label>
                        </td>
                        <td>
                                <asp:TextBox ID="textNumeroDocumneto" runat="server" CssClass="texto2" 
                                    Width="127px"></asp:TextBox>
                            </td>
                    </tr>
                    <tr>
                        <td colspan="4">
                            <asp:Button ID="buttonBuscarTercero" runat="server" CssClass="button" 
                                Text="Buscar" OnClick="buttonBuscarTercero_Click" />
                        </td>
                    </tr>
                                    <tr>
                                        <td colspan="4">
                                            <asp:GridView ID="gridTerceroBuscar" runat="server" 
                                                CssClass="grilla" 
                                                FooterStyle-CssClass="footergrilla" HeaderStyle-CssClass="headergrilla" 
                                                RowStyle-CssClass="rowgrilla" SelectedRowStyle-CssClass="selectedgrilla" 
                                                onrowcommand="GridViewTerceroBuscar_RowCommand" 
                                                Width="649px" DataKeyNames="Id" AutoGenerateColumns="False" 
                                                AllowPaging="True" PageSize="15">
                                                <RowStyle CssClass="rowgrilla" />
                                                <Columns>
                                                    <asp:TemplateField>
                                                    <ItemTemplate>
                                                    <asp:Button runat="server" ID="buttonUnificar" Text="Unificar" CommandName="Unificar" CommandArgument="<%# Container.DataItemIndex %>" OnClientClick="return confirm('Este tercero se unificará, desea continuar?')" CssClass="buttongrilla"/>
                                                    </ItemTemplate>    
                                                    </asp:TemplateField>
                                                    <asp:BoundField DataField="TipoDocumento" HeaderText="Tipo documento" />
                                                    <asp:BoundField DataField="ter_NumeroDocumento" HeaderText="Número documento" />
                                                    <asp:BoundField DataField="ter_NombreCompleto" 
                                                        HeaderText="Nombre y apellidos" />
                                                    <asp:BoundField DataField="dep_descripcion" HeaderText="Departamento" />
                                                    <asp:BoundField DataField="mun_descripcion" HeaderText="Ciudad" />
                                                    <asp:BoundField DataField="ter_Direccion" HeaderText="Dirección" />
                                                </Columns>
                                                <FooterStyle CssClass="footergrilla" />
                                                <SelectedRowStyle CssClass="selectedgrilla" />
                                                <HeaderStyle CssClass="headergrilla" />
                                            </asp:GridView>
                                            <asp:SqlDataSource ID="terceroBuscarDataSource" runat="server" 
                                                ConnectionString="<%$ ConnectionStrings:BDUTOConnectionString %>" 
                                                SelectCommand="exec [Uto].[spBeneficiarioBuscar] @beneficiario,@documento,@tipoDocumento,@id">
                                                <SelectParameters>
                                                    <asp:Parameter Name="beneficiario" />
                                                    <asp:Parameter Name="documento" />
                                                    <asp:Parameter Name="tipoDocumento" />
                                                    <asp:Parameter Name="id" />
                                                </SelectParameters>
                                            </asp:SqlDataSource>
                                        </td>
                                    </tr>
                </table>
                </td>
            </tr>
        </table>
            </asp:Panel>
        </asp:Panel>
    <table>
        <tr>
        <td colspan="4">
        &nbsp;<asp:Button ID="buttonGuardar" runat="server" Text="Guardar"  
        CssClass="button" onclick="buttonGuardar_Click"/>
        &nbsp;<asp:Button ID="buttonCancelar" runat="server" Text="Cancelar"  
        CssClass="button" onclick="buttonCancelar_Click"/>
        </td>
        </tr>    
    </table>
    </div>    
    <br /> 
    </asp:Content>


