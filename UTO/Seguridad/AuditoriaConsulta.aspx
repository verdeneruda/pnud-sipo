    <%@ Page Language="C#" MasterPageFile="~/MPMain.master" AutoEventWireup="true" CodeBehind="AuditoriaConsulta.aspx.cs" Inherits="UTO.Seguridad.BuscarAuditoria" %>

    <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

    <asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </cc1:ToolkitScriptManager>
    <table class="titulo" >
        <tr>
            <td>
                <asp:Label ID="LabelConsultaAuditoria" runat="server" Text="Seguridad - Consulta auditoria" CssClass="subtitulo"></asp:Label>
            </td>
        </tr>
    </table>
    
    <table cellspacing="4" class="form" >
    <tr>
    <td>
    <div style="color:Red;">
    <asp:Label runat="server" ID="labelError"></asp:Label>
    </div>
    </td>
    </tr>
    </table>
    <br />
    <table cellspacing="4" class="form" >
    <tr>
    <td class="style5">

    <asp:Label ID="labelModulo" runat="server" Text="Módulo"  ></asp:Label>

    </td>
    <td class="style5">

    <asp:DropDownList ID="comboModulo" runat="server" CssClass="texto2" 
            oninit="comboModulo_Init">
    </asp:DropDownList>

    </td>
    <td class="style5">

    <asp:Label ID="labelOperacion" runat="server" Text="Operación"  ></asp:Label>

    </td>
    <td class="style5">

    <asp:DropDownList ID="comboOperacion" runat="server" CssClass="texto2" 
            oninit="comboOperacion_Init" AutoPostBack="True" 
            onselectedindexchanged="comboOperacion_SelectedIndexChanged">
    </asp:DropDownList>

    </td>
    </tr>
    <tr>
    <td>

    <asp:Label ID="labelUsuario" runat="server" Text="Usuario"  ></asp:Label>

    </td>
    <td>

    <asp:DropDownList ID="comboUsuario" runat="server" CssClass="texto2" 
            oninit="comboUsuario_Init">
    </asp:DropDownList>

    </td>
    <td>

        &nbsp;</td>
    <td> 

    <cc1:calendarextender ID="CalendarExtender1" TargetControlID="textFechaInicial" 
    Format="dd/MM/yyyy" runat="server">
    </cc1:calendarextender>
    </td>
    </tr>
 


    <tr>
    <td>

    <asp:Label ID="labelFechaInicial" runat="server" Text="Fecha inicial"  ></asp:Label>

    </td>
    <td>

    <cc1:calendarextender ID="CalendarExtender3" TargetControlID="textFechaFinal" 
        Format="dd/MM/yyyy" runat="server">
    </cc1:calendarextender> 

    <asp:TextBox ID="textFechaInicial" runat="server" CssClass="texto2"></asp:TextBox>
<%--    <asp:ImageButton runat="server" ID="imageFechaInicial" ImageUrl="~/imagenes/boton-calendario.png" />--%>
        </td>
    <td>

    <asp:Label ID="labelFechaFinal" runat="server" Text="Fecha final"  ></asp:Label>

    </td>
    <td> 

    <asp:TextBox ID="textFechaFinal" runat="server" CssClass="texto2"></asp:TextBox>
    <%--<asp:ImageButton runat="server" ID="ImageFechaFinal" ImageUrl="~/imagenes/boton-calendario.png" />--%>

    </td>
    </tr>



    <tr>
    <td>

    <asp:Label ID="labelKey1" runat="server" Text="Key 1"  ></asp:Label>

    </td>
    <td>

    <asp:TextBox ID="textKey1" runat="server" CssClass="texto2"></asp:TextBox>

    </td>
    <td>

    <asp:Label ID="labelKey2" runat="server" Text="Key 2"  ></asp:Label>

    </td>
    <td> 

    <asp:TextBox ID="textKey2" runat="server" CssClass="texto2"></asp:TextBox>

    </td>
    </tr>






    <tr>
    <td>

    <asp:Label ID="labelKey3" runat="server" Text="key 3"  ></asp:Label>

    </td>
    <td>

    <asp:TextBox ID="textKey3" runat="server" CssClass="texto2"></asp:TextBox>

    </td>
    <td>



    <asp:Label ID="labelKey4" runat="server" Text="Key 4"  ></asp:Label>



    </td>
    <td> 



    <asp:TextBox ID="textKey4" runat="server" CssClass="texto2"></asp:TextBox>



    </td>
    </tr>



    <tr>
    <td colspan="4">
    <asp:Button ID="buttonBuscar" runat="server" Text="Buscar" 
            onclick="buttonBuscar_Click" CssClass="button" /></td>
    </tr>
    </table>
    <div class="divgrillas">
        <asp:GridView ID="gridBuscarAuditoria" runat="server" CssClass="grilla" 
            HeaderStyle-CssClass="headergrilla" RowStyle-CssClass="rowgrilla" 
            SelectedRowStyle-CssClass="selectedgrilla" 
            FooterStyle-CssClass="footergrilla"         
            onrowdatabound="gridBuscarAuditoria_RowDataBound" 
            onpageindexchanging="gridBuscarAuditoria_PageIndexChanging" PageSize="50" 
            AllowPaging="True">
            <RowStyle CssClass="rowgrilla"></RowStyle>
            <FooterStyle CssClass="footergrilla"></FooterStyle>
            <SelectedRowStyle CssClass="selectedgrilla"></SelectedRowStyle>
            <HeaderStyle CssClass="headergrilla"></HeaderStyle>            
        </asp:GridView>
<br />
<br />
</div>


<br />
    </asp:Content>
    <asp:Content ID="Content2" runat="server" contentplaceholderid="head">

        <style type="text/css">
            .style5
            {
                height: 30px;
            }
        </style>

    </asp:Content>

