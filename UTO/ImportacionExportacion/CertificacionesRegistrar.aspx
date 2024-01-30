    <%@ Page Language="C#" MasterPageFile="~/MPMain.Master" AutoEventWireup="true" CodeBehind="CertificacionesRegistrar.aspx.cs" Inherits="UTO.ImportacionExportacion.CertificacionesRegistrar" %>

    <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

    <%--<%@ Register assembly="DevExpress.Web.v15.1, Version=15.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>--%>

    
    <%@ Register src="../Comunes/ControlError.ascx" tagname="ControlError" tagprefix="uc1" %>

    
    <%@ Register src="../Comunes/ControlError.ascx" tagname="controlerror" tagprefix="uc2" %>

    
    <asp:Content  ID="contentImportacionExportacionCertificacionesRegistrar" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
        <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </cc1:ToolkitScriptManager>

    <div class="divwithoutgrid">
    <table class="titulo" >
    <tr><td>
    <asp:Label ID="labelRegistarCertificaciones" runat="server" Text="Mòdulo importación y exportación - Adicionar certificaciones" CssClass="subtitulo"></asp:Label>
    </td></tr>
    </table>
    <br />
    <table class="form">
    <tr>
    <td>    
        <uc1:ControlError ID="ControlError1" runat="server" />    
    </td>
    </tr>
    </table>
    <table class="form">
    <tr>
    <td>
    <asp:Panel ID="PanelCertificaciones" runat="server">
        <table style="width:100%;"> 
            <tr>
                <th colspan="5">
                    <asp:Label ID="labelDatosGenerales" runat="server" Text="Datos generales" CssClass="subtitulo"></asp:Label>
                </th>
            </tr>        
            <tr>
                <td class="style3">
                    <asp:Label ID="labelNumeroRadicado" runat="server" CssClass="label" 
                        Text="Número radicado"></asp:Label>
                    &nbsp;
                    <asp:Label runat="server" Font-Bold="true" Text="(*)"></asp:Label>
                </td>
                <td class="style4">
                    <asp:TextBox ID="textNumeroRadicado" runat="server" CssClass="texto2"></asp:TextBox>
                </td>
                <td class="style3">
                    <asp:Label ID="labelfechaRadicado" runat="server" CssClass="label" 
                        Text="Fecha radicado"></asp:Label>
                    &nbsp;
                    <asp:Label runat="server" Font-Bold="true" Text="(*)"></asp:Label>
                </td>
                <td class="style3" colspan="2">
                    <asp:TextBox ID="textFechaRadicado" runat="server" CssClass="texto2" 
                        Width="218px"></asp:TextBox>
                    <cc1:CalendarExtender ID="calendarfechaInicial" runat="server" 
                        CssClass="calendar" Format="dd/MM/yyyy" TargetControlID="textFechaRadicado">
                    </cc1:CalendarExtender>
                </td>
            </tr>
        <tr>
        <td class="style1">
        <asp:Label ID="labelRadicado" runat="server" Text="Radicado por" CssClass="label"></asp:Label>
        </td>
        <td class="style2" colspan="4">
        <asp:DropDownList ID="comboRadicado" runat="server" CssClass="combo" DataTextField="ter_NombreCompleto" 
        DataValueField="ter_Id" Width="566px">
        </asp:DropDownList>
        </td>
        
        </tr>
        <tr>
                <td>
                <asp:Label ID="label8" runat="server" 
                        Text="Autoriza utilización certificación número:" CssClass="label"></asp:Label>
                </td>
                <td>
                <asp:TextBox ID="textAutorizaNumero" runat="server"  CssClass="texto2"></asp:TextBox>
                </td>
                <td colspan="2">
                    <asp:Button ID="buttonBuscarRadicado" runat="server" CssClass="button" 
                        onclick="buttonBuscarRadicado_Click" Text="Buscar" Width="77px" />
                </td>
        </tr>        
            <tr>
                <td class="style1">
                    <asp:Label ID="labelImportador" runat="server" CssClass="label" 
                        Text="Importador"></asp:Label>&nbsp
                    <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label> 
                </td>
                <td class="style2" colspan="4">
                    <asp:DropDownList ID="comboImportador" runat="server" CssClass="combo" 
                        DataTextField="ter_NombreCompleto" DataValueField="ter_Id" Width="471px">
                    </asp:DropDownList>
                    &nbsp;<asp:Button ID="buttonAdicionarTercero" runat="server" CssClass="button" 
                        onclick="buttonAdicionarTercero_Click" Text="Adicionar" />
                </td>
            </tr>
            <tr>
                <td class="style1" colspan="5">
                    <asp:Panel ID="PanelDatosTercero" runat="server" Visible="False" Width="716px">
                        <table class="form">
                            <tr>
                                <td>
                                    <uc2:ControlError ID="ControlError2" runat="server" />
                                </td>
                            </tr>
                        </table>
                        <table class="formModal">
                            <tr>
                                <th colspan="4">
                                    <asp:Label ID="label12" runat="server" CssClass="subtitulo" 
                                        Text="Datos del importador"></asp:Label>
                                </th>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="labelNombreBeneficiario0" runat="server" CssClass="label" 
                                        Text="Nombre "></asp:Label>&nbsp
                                    <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>  
                                </td>
                                <td colspan="3">
                                    <asp:TextBox ID="textNombreBeneficiario" runat="server" CssClass="texto2" 
                                        Width="528px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="labelDepartamento" runat="server" CssClass="label" 
                                        Text="Departamento"></asp:Label>&nbsp
                                    <asp:Label ID="Label4" runat="server" Text="(*)" Font-Bold="true"></asp:Label>  
                                </td>
                                <td>
                                    <asp:DropDownList ID="comboDepartamento" runat="server" AutoPostBack="True" 
                                        CssClass="combo" DataTextField="dep_Descripcion" DataValueField="dep_Id" 
                                        onselectedindexchanged="comboDepartamento_SelectedIndexChanged" Width="199px">
                                    </asp:DropDownList>
                                </td>
                                <td>
                                    <asp:Label ID="labelMunicipio" runat="server" CssClass="label" Text="Municipio"></asp:Label>&nbsp
                                    <asp:Label ID="Label7" runat="server" Text="(*)" Font-Bold="true"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="comboCiudad" runat="server" CssClass="combo" 
                                        DataTextField="mun_Descripcion" DataValueField="mun_Id" Width="200px">
                                    </asp:DropDownList>
                                </td>
                            </tr>                                                        
                            <tr>
                                <td>
                                    <asp:Label ID="labelTipoDocumento" runat="server" CssClass="label" 
                                        Text="Tipo documento"></asp:Label>&nbsp
                                    </asp:Label>  
                                </td>
                                <td>
                                    <asp:DropDownList ID="comboTipoDocumento" runat="server" CssClass="combo" 
                                        DataTextField="dti_Descripcion" DataValueField="dti_Id" Width="200px" 
                                        onselectedindexchanged="comboTipoDocumento_SelectedIndexChanged">
                                    </asp:DropDownList>
                                </td>
                                <td>
                                    <asp:Label ID="labelDocumento" runat="server" CssClass="label" Text="Documento"></asp:Label>&nbsp
                                    </asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="textDocumento" runat="server" AutoCompleteType="Disabled" 
                                        CssClass="texto2" Width="197px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="4">
                                    <asp:Button ID="buttonGuardarTercero" runat="server" CssClass="button" 
                                        onclick="buttonGuardarTercero_Click" Text="Guardar" />
                                    &nbsp;<asp:Button ID="buttonCancelarTercero" runat="server" CssClass="button" 
                                        onclick="buttonCancelarTercero_Click" Text="Cancelar" />
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
            </tr>
        <tr>
        <td class="style1">
            <asp:Label ID="Label1" 
                runat="server" Text="Procedencia" CssClass="label"></asp:Label>&nbsp
            <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>   
        </td>
        <td class="style2">
            <asp:DropDownList ID="comboProcedencia" CssClass="combo" 
                runat="server" DataTextField="pas_Descripcion" 
                DataValueField="pas_Id">
        </asp:DropDownList>
        </td>
        <td>
            <asp:Label ID="label3" runat="server" CssClass="label" Text="Marca"></asp:Label>&nbsp
            <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>
        </td>
        <td colspan="2">
            <asp:DropDownList ID="comboMarca" runat="server" CssClass="combo" 
                DataTextField="meq_Descripcion" DataValueField="meq_id" Width="245px" 
                onselectedindexchanged="comboMarca_SelectedIndexChanged">
            </asp:DropDownList>
        </td>
        
        </tr>
            <tr>
                <td class="style1">
                    <asp:Label ID="label2" runat="server" CssClass="label" 
                        Text="Empresa fabricante o distribuidor"></asp:Label>&nbsp
                    <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>  
                </td>
                <td class="style2" colspan="4">
                    <asp:DropDownList ID="comboEmpresa" runat="server" CssClass="combo" 
                        DataTextField="ter_NombreCompleto" DataValueField="ter_Id" Width="471px">
                    </asp:DropDownList>&nbsp;<asp:Button ID="buttonAgregarEmpresa" runat="server" 
                        CssClass="button" Text="Adicionar" onclick="buttonAgregarEmpresa_Click" />
                </td>
            </tr>
            <tr>
            <td class="style1" colspan="5">
                <asp:Panel ID="panelEmpresa" runat="server" Visible="False">
                    <table class="form">
                        <tr>
                            <td>
                                <uc2:ControlError ID="ControlError3" runat="server" />
                            </td>
                        </tr>
                    </table>
                    <table class="formModal">
                            <tr>
                                <th colspan="4">
                                    <asp:Label ID="label9" runat="server" CssClass="subtitulo" 
                                        Text="Datos de la empresa"></asp:Label>
                                </th>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="label13" runat="server" CssClass="label" 
                                        Text="Nombre "></asp:Label>&nbsp
                                    <asp:Label ID="Label14" runat="server" Text="(*)" Font-Bold="true"></asp:Label>  
                                </td>
                                <td colspan="3">
                                    <asp:TextBox ID="textNombreEmpresa" runat="server" CssClass="texto2" 
                                        Width="528px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="4">
                                    <asp:Button ID="buttonGuardarEmpresa" runat="server" CssClass="button" 
                                        onclick="buttonGuardarEmpresa_Click" Text="Guardar" />
                                    &nbsp;<asp:Button ID="buttonCancelarEmpresa" runat="server" CssClass="button" 
                                        onclick="buttonCancelarEmpresa_Click" Text="Cancelar" />
                                </td>
                            </tr>
                        </table>                    
                </asp:Panel>
            </td>
            </tr>
        <tr>
        <td class="style1" colspan="2">
            <asp:RadioButton ID="RadioFuncionario" runat="server" 
                GroupName="TipoCertificado" Text="Fabricante" />
            <asp:RadioButton ID="RadioDistribuidor" runat="server" 
                GroupName="TipoCertificado" Text="Distribuidor" />
        </td>
        <td colspan="3">
            &nbsp;</td>
        
        </tr>
        <tr>
        <td class="style1">
        <asp:Label ID="label5" runat="server" Text="Descripción" CssClass="label"></asp:Label>
        </td>
        <td colspan="4">
        <asp:TextBox ID="TextDescripcion" runat="server"  CssClass="texto2" TextMode="MultiLine" 
                Width="569px"></asp:TextBox>
        </td>
        
        </tr>
        <tr>
        <td class="style1">
        <asp:Label ID="label6" runat="server" Text="Fecha certificado" CssClass="label"></asp:Label>&nbsp
        <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>
        </td>
        <td class="style2">
        <asp:TextBox ID="textFechaCertificacion" runat="server"  CssClass="texto2"></asp:TextBox>
        <cc1:CalendarExtender ID="calendarfechaInicial0" runat="server" 
                TargetControlID="textFechaCertificacion" CssClass="calendar" 
                Format="dd/MM/yyyy">
        </cc1:CalendarExtender>
        </td>        
        </tr>
        <tr>
        <td class="style1" colspan="5">

                        <asp:Panel ID="PanelRadicadoHijo" runat="server" Visible="False">
                        <table>
                        <tr>
                        <td>
                            <asp:Label ID="label10" runat="server" Text="Número radicación" 
                                CssClass="label"></asp:Label>        
                        </td>
                         <td>
                        
                             <asp:TextBox ID="textNumeroRadicadoHijo" runat="server" CssClass="texto2" 
                                 Enabled="False"></asp:TextBox>
                        
                        </td>
                            <td>
                                <asp:Label ID="label11" runat="server" CssClass="label" 
                                    Text="Fecha de radicación"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="textFechaRadicacionHijo" runat="server" CssClass="texto2" 
                                    Enabled="False"></asp:TextBox>
                                <cc1:CalendarExtender ID="calendarfechaInicial1" runat="server" 
                                    CssClass="calendar" Format="dd/MM/yyyy" 
                                    TargetControlID="textFechaRadicacionHijo">
                                </cc1:CalendarExtender>
                            </td>
                        </tr>
                        </table>
                        </asp:Panel>                

        </td>
        
        </tr>
        </table>
    </asp:Panel>
    <table>
        <tr>
        <td class="style1">
            <asp:Button ID="buttonGuardar" runat="server" Text="Guardar" 
                CssClass="button" onclick="buttonGuardar_Click" />
        </td>
        <td class="style2">
            <asp:Button 
        ID="buttoncancelar" runat="server" Text="Cancelar"  CssClass="button" 
        onclick="buttoncancelar_Click"/>
        </td>        
        </tr>
    </table>
    </td>
    </tr>
    </table>
    </div>
    <br />
    <!--table collapsible -->
    <br />
    </asp:Content>