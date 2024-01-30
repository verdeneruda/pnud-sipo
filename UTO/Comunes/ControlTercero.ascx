<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ControlTercero.ascx.cs" Inherits="UTO.Comunes.ControlTercero" %>   
    <asp:Panel ID="PanelDatosTercero" runat="server"> 
        
        <table class="form">
            <tr>
                <td>
                    <table style="width:100%">
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
                            <td>
                                <asp:TextBox ID="textCorreo" runat="server" CssClass="texto2" Width="200px"></asp:TextBox>
                            </td>
                            <td>
                            <asp:Label ID="labelTipoTercero" runat="server" CssClass="label" 
                                Text="Tipo tercero"></asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="comboTerceroTipo" runat="server" CssClass="combo" DataTextField="tti_Descripcion" 
                                    DataValueField="tti_Id" Width="140px">
                                </asp:DropDownList>
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