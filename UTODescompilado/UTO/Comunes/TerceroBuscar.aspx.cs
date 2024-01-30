// Decompiled with JetBrains decompiler
// Type: UTO.Comunes.TerceroBuscar
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using AjaxControlToolkit;
using NE.CLib.Linq;
using Seguridad.Servicio;
using System;
using System.Data.Linq;
using System.Web.UI.WebControls;

namespace UTO.Comunes
{
  public class TerceroBuscar : BaseModulo
  {
    protected ToolkitScriptManager ToolkitScriptManager1;
    protected Label labelBusquedaSolicitudesEquipos;
    protected ControlError ControlError1;
    protected Panel PanelBuscarTercero;
    protected Label labelparametros;
    protected Label labelNombreBeneficiario;
    protected TextBox textBeneficiarioBuscar;
    protected Label label3;
    protected DropDownList comboTipoDocumento;
    protected Label labelNumeroDocumento;
    protected TextBox textNumeroDocumneto;
    protected Button buttonBuscarTercero;
    protected Button buttonAdicionarTercero;
    protected GridView gridTerceroBuscar;
    protected SqlDataSource terceroBuscarDataSource;

    protected new void Page_Load(object sender, EventArgs e)
    {
      this.ControlError1.Hide();
      if (this.IsPostBack)
        return;
      this.InitData();
    }

    public void InitData()
    {
      this.comboTipoDocumento.DataSource = (object) CLinq.ListAll<dti_DocumentoTipo>((DataContext) this.MyDataContext);
      this.comboTipoDocumento.DataBind();
      this.comboTipoDocumento.Items.Insert(0, "");
    }

    protected void buttonBuscarTercero_Click(object sender, EventArgs e)
    {
      this.terceroBuscarDataSource.SelectParameters["beneficiario"].DefaultValue = this.textBeneficiarioBuscar.Text != "" ? this.textBeneficiarioBuscar.Text : "%";
      this.terceroBuscarDataSource.SelectParameters["documento"].DefaultValue = this.textNumeroDocumneto.Text != "" ? this.textNumeroDocumneto.Text : "%";
      this.terceroBuscarDataSource.SelectParameters["tipoDocumento"].DefaultValue = this.comboTipoDocumento.SelectedValue != "" ? this.comboTipoDocumento.SelectedValue : "0";
    }

    protected void buttonAdicionarTercero_Click(object sender, EventArgs e)
    {
      this.SendParams = (object) new BaseModulo.strSendParam()
      {
        id = 0,
        tipo = "Adicionar",
        pagina = "~/Comunes/TerceroBuscar.aspx"
      };
      this.Response.Redirect("~/Comunes/TerceroRegistrar.aspx");
    }

    protected void GridViewTerceroBuscar_RowCommand(object sender, GridViewCommandEventArgs e)
    {
      if (e.CommandName.Equals("Modificar"))
      {
        this.SendParams = (object) new BaseModulo.strSendParam()
        {
          id = int.Parse(this.gridTerceroBuscar.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString()),
          tipo = "Modificar"
        };
        this.Server.Transfer("~/Comunes/TerceroRegistrar.aspx");
      }
      if (e.CommandName.Equals("Ver"))
      {
        this.SendParams = (object) new BaseModulo.strSendParam()
        {
          id = int.Parse(this.gridTerceroBuscar.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString()),
          tipo = "Ver"
        };
        this.Server.Transfer("~/Comunes/TerceroRegistrar.aspx");
      }
      if (!e.CommandName.Equals("Eliminar"))
        return;
      int keyValue = int.Parse(this.gridTerceroBuscar.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString());
      ter_Tercero byKey = CLinq.FindByKey<ter_Tercero>((DataContext) this.MyDataContext, (object) keyValue);
      CAuditoria.log(EPermiso.EliminarTercero, keyValue.ToString(), "", "", "", "", this.Usuario.id);
      try
      {
        this.MyDataContext.ter_Terceros.DeleteOnSubmit(byKey);
        this.MyDataContext.SubmitChanges();
        this.gridTerceroBuscar.DataSource = (object) null;
        this.gridTerceroBuscar.DataBind();
      }
      catch (Exception ex)
      {
        this.ControlError1.Visible = true;
        this.ControlError1.Show(ex);
      }
    }
  }
}
