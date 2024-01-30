    <%@ Page Language="C#" MasterPageFile="~/MPMain.Master"  AutoEventWireup="true" CodeBehind="AprobadosEliminacionRegistrar.aspx.cs" Inherits="UTO.Proyectos.AprobadosEliminacionRegistrar" %>

    <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
    
    <%@ Register src="../Comunes/ControlError.ascx" tagname="ControlError" tagprefix="uc1" %>
    <%@ Register src="../Comunes/DocumentosVarios.ascx" tagname="DocumentosVarios" tagprefix="uc2" %>

    <asp:Content  ID="contentProyectosAprobadosRegistrar" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
            <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
        </cc1:ToolkitScriptManager>
    <div class="divwithoutgrid">
    <table class="titulo" >
    <tr><td>
    <asp:Label ID="labelRegistarProyectosAprobados" runat="server" Text="Mòdulo proyectos aprobados de eliminaciòn - Adicionar proyectos aprobados de eliminaciòn" CssClass="subtitulo"></asp:Label>        
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
    <asp:Panel ID="PanelProyecto" runat="server">
        <table class="form">
        <tr>
        <td>
        <table style="width:100%;"> 
        <tr><th colspan="5">
        <asp:Label ID="labelDatosGenerales" runat="server" Text="Datos generales" CssClass="subtitulo"></asp:Label>
        </th></tr>
        <tr>
        <td>
        <asp:Label ID="labelCodigo" runat="server" Text="Código proyecto" CssClass="label"></asp:Label>&nbsp
        <asp:Label  runat="server" Text="(*)" Font-Bold="true"></asp:Label>
        </td>
        <td colspan="2">
        <asp:TextBox ID="textCodigo" runat="server" CssClass="texto2"></asp:TextBox>
        </td>
        <td>
            <asp:Label ID="labelSector" runat="server" CssClass="label" 
                Text="Sector proyecto"></asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="comboSector" runat="server" CssClass="combo" 
                DataTextField="pse_Descripcion" DataValueField="pse_Id">
            </asp:DropDownList>
        </td>
        </tr>
        <tr>
        <td>
        <asp:Label ID="labelNombre" runat="server" Text="Nombre proyecto" CssClass="label"></asp:Label>&nbsp
            <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>
        </td>
        <td colspan="4">
            <asp:TextBox ID="textNombre" runat="server" CssClass="texto2" 
                TextMode="MultiLine" Width="531px"></asp:TextBox>
        </td>
        </tr>
        <tr>
        <td>
        <asp:Label ID="labelTipo" runat="server" Text="Tipo proyecto" CssClass="label"></asp:Label>&nbsp
            <asp:Label ID="Label1" runat="server" Text="(*)" Font-Bold="true"></asp:Label>
        </td>
        <td colspan="4">
            <asp:DropDownList ID="comboTipoProyecto" runat="server" CssClass="combo" 
                DataTextField="pti_Descripcion" DataValueField="pti_Id" Width="531px">
            </asp:DropDownList>
        </td>
        </tr>
        <tr>
        <td>
        <asp:Label ID="labelAgenciaImplementadora" runat="server" 
                Text="Agencia implementadora" CssClass="label"></asp:Label>&nbsp
            <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>    
        </td>
        <td>

            <asp:TextBox ID="textAgenciaImplementadora" runat="server" CssClass="texto2"></asp:TextBox>
        </td>
        <td class="separador">
            <asp:Label ID="labelCompañia" runat="server" CssClass="label" Text="Compañía"></asp:Label>
        </td>
        <td colspan="2">
            <asp:TextBox ID="textCompañia" runat="server" CssClass="texto2" Width="268px"></asp:TextBox>
        </td>
        </tr>
        <tr>
        <td>
        <asp:Label ID="labelDepartamento" runat="server" Text="Departamento" 
                CssClass="label"></asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="comboDepartamento" runat="server" AutoPostBack="True" 
                CssClass="combo" DataTextField="dep_Descripcion" DataValueField="dep_Id" 
                onselectedindexchanged="comboDepartamento_SelectedIndexChanged">
            </asp:DropDownList>
        </td>
        <td class="separador">
            <asp:Label ID="labelCiudad" runat="server" CssClass="label" Text="Ciudad"></asp:Label>
        </td>
        <td colspan="2">
            <asp:DropDownList ID="comboCiudad" runat="server" CssClass="combo" 
                DataTextField="mun_Descripcion" DataValueField="mun_Id" Width="268px" 
                Height="17px">
            </asp:DropDownList>
        </td>
        </tr>
        <tr>
        <td>
        <asp:Label ID="labelAprobado" runat="server" Text="Aprobados FMPM" CssClass="label"></asp:Label>&nbsp
        <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>
        </td>
        <td>
        <asp:TextBox ID="textAprobado" runat="server" CssClass="texto2"></asp:TextBox>
        </td>
        <td class="separador" colspan="2">
            <asp:Label ID="labelDesembolsado" runat="server" CssClass="label" 
                Text="Desembolsados FMPM"></asp:Label>&nbsp
            <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>   
                
        </td>
        <td>
        <asp:TextBox ID="textDesembolsados" runat="server" CssClass="texto2"></asp:TextBox>
        </td>
        </tr>
        <tr>
        <td>
        <asp:Label ID="labelInvertidos" runat="server" Text="US$ Invertidos" 
                CssClass="label"></asp:Label>&nbsp
                
            <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>        
        </td>
        <td>
        <asp:TextBox ID="textInvertidos" runat="server" CssClass="texto2"></asp:TextBox>
        </td>
        <td class="separador" colspan="2">
            <asp:Label ID="labelODPEliminar" runat="server" CssClass="label" 
                Text="Toneladas PAO a Eliminar"></asp:Label>&nbsp
            <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>      
        </td>
        <td>
        <asp:TextBox ID="textODPEliminar" runat="server" CssClass="texto2"></asp:TextBox>
        </td>
        </tr>
        <tr>
        <td>
        <asp:Label ID="labelODPEliminadas" runat="server" Text="Toneladas PAO Eliminadas" 
                CssClass="label"></asp:Label>&nbsp
            <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>
        </td>
        <td>
        <asp:TextBox ID="textODPEliminadas" runat="server" CssClass="texto2"></asp:TextBox>
        </td>
        <td class="separador" colspan="2">
            <asp:Label ID="labelFechaAprobacion" runat="server" CssClass="label" 
                Text="Fecha aprobación"></asp:Label>
        </td>
        <td>
                    <asp:TextBox ID="textFechaAprobacion" runat="server" CssClass="texto2"></asp:TextBox>
                    <cc1:CalendarExtender ID="calendarfechaInicial" runat="server" 
                        CssClass="calendar" Format="dd/MM/yyyy" TargetControlID="textFechaAprobacion">
                    </cc1:CalendarExtender>
        </td>
        </tr>
        <tr>
        <td>
        <asp:Label ID="labelFechaTerminacion" runat="server" Text="Fecha terminación" 
                CssClass="label"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="textFechaTerminacion" runat="server" CssClass="texto2"></asp:TextBox>
            <cc1:CalendarExtender ID="textFechaTerminacion_CalendarExtender" runat="server" 
                CssClass="calendar" Format="dd/MM/yyyy" TargetControlID="textFechaTerminacion">
            </cc1:CalendarExtender>
        </td>
        <td class="separador" colspan="2">
            <asp:Label ID="labelFechaTerminacionReal" runat="server" CssClass="label" 
                Text="Fecha terminación real"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="textFechaTerminacionReal" runat="server" CssClass="texto2"></asp:TextBox>
            <cc1:CalendarExtender ID="textFechaTerminacionReal_CalendarExtender" 
                runat="server" CssClass="calendar" Format="dd/MM/yyyy" 
                TargetControlID="textFechaTerminacionReal">
            </cc1:CalendarExtender>
        </td>
        </tr>
            <tr>
                <td>
                    <asp:Label ID="labelEstado" runat="server" CssClass="label" Text="Estado"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="textEstado" runat="server" CssClass="texto2" Width="89px"></asp:TextBox>
                    <asp:Label ID="labelEstadoPorcentaje" runat="server" CssClass="label" 
                        Text="  %"></asp:Label>
                </td>
                <td class="separador">
                    <asp:Label ID="labelGrupo" runat="server" CssClass="label" 
                        Text="Grupo proyecto"></asp:Label>&nbsp
                    <asp:Label runat="server" Text="(*)" Font-Bold="true"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:DropDownList ID="comboGrupo" runat="server" CssClass="combo" 
                        DataTextField="pyg_Descripcion" DataValueField="pyg_Id" Width="264px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="labelObservaciones" runat="server" CssClass="label" 
                        Text="Observaciones"></asp:Label>
                </td>
                <td colspan="4">
                    <asp:TextBox ID="textObservaciones" runat="server" CssClass="texto2" 
                        Height="63px" TextMode="MultiLine" Width="521px"></asp:TextBox>
                </td>
            </tr>
        </table>
        </td>
        </tr>
        </table>
        <table>
            <tr>
                <td>
                    <uc2:DocumentosVarios ID="DocumentosVarios1" runat="server" />
                </td>
            </tr>
        </table>
    </asp:Panel>
    <table>
        <tr>
        <td colspan="5">
        <asp:Button ID="buttonGuardar" runat="server" Text="Guardar" CssClass="button" 
                onclick="buttonGuardar_Click" />&nbsp;&nbsp;<asp:Button 
        ID="buttoncancelar" runat="server" Text="Cancelar" CssClass="button" 
        onclick="buttoncancelar_Click"/>
        </td>
        </tr>    
    </table>
    </div>
    <br />
    </asp:Content>

