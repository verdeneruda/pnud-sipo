<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ControlError.ascx.cs" Inherits="UTO.ControlError" %>

    <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
   
    
<asp:Panel ID="panelError" runat="server" CssClass="errorVisible" 
    Visible="False">
    <div>
        <asp:Label ID="labelError" runat="server" Text=""></asp:Label>
    </div>
    <asp:Button ID="buttonMasInfo" runat="server" Text="Más información..." 
        onclick="buttonMasInfo_Click" />
</asp:Panel>
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
        <asp:Panel ID="panelException" runat="server" CssClass="ErrorVisible" 
    Visible="False">
            <div>
                <asp:Label ID="labelException" runat="server" Text=""></asp:Label>
            </div>
        </asp:Panel>
        <asp:Button ID="buttonOcultar" runat="server" Text="Ocultar" 
            onclick="buttonOcultar_Click" Visible="False" />
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="buttonMasInfo" EventName="Click" />
    </Triggers>
</asp:UpdatePanel>


