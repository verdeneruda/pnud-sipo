// Decompiled with JetBrains decompiler
// Type: UTO.Proyectos.AprobadosEliminacionBuscar
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using AjaxControlToolkit;
using NE.CLib.Linq;
using Seguridad.Servicio;
using System;
using System.Data;
using System.Data.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UTO.Proyectos
{
  public class AprobadosEliminacionBuscar : BaseModulo
  {
    protected ToolkitScriptManager ToolkitScriptManager1;
    protected Label labelBusquedaProyectosAprobados;
    protected ControlError ControlError1;
    protected Label labelparametros;
    protected Label labelCodigo;
    protected TextBox textCodigo;
    protected Label labelNombreProyecto;
    protected TextBox textNombreProyecto;
    protected Label labelTipoProyecto;
    protected DropDownList comboTipoProyecto;
    protected Button buttonBuscar;
    protected Button buttonAdicionar;
    protected Button buttonExportar;
    protected GridView gridBuscarProyectos;
    protected SqlDataSource aprobadosEliminacionBuscarDataSource;

    protected new void Page_Load(object sender, EventArgs e)
    {
      if (this.IsPostBack)
        return;
      this.InitData();
    }

    public void InitData()
    {
      this.comboTipoProyecto.DataSource = (object) CLinq.ListAll<pti_ProyectoTipo>((DataContext) this.MyDataContext);
      this.comboTipoProyecto.DataBind();
      this.comboTipoProyecto.Items.Insert(0, "");
    }

    protected void buttonAdicionar_Click(object sender, EventArgs e)
    {
      this.SendParams = (object) new BaseModulo.strSendParam()
      {
        id = 0,
        tipo = ""
      };
      this.Server.Transfer("~/Proyectos/AprobadosEliminacionRegistrar.aspx");
    }

    protected void buttonBuscar_Click(object sender, EventArgs e)
    {
      this.aprobadosEliminacionBuscarDataSource.SelectParameters["codigo"].DefaultValue = this.textCodigo.Text != "" ? this.textCodigo.Text : "%";
      this.aprobadosEliminacionBuscarDataSource.SelectParameters["nombre"].DefaultValue = this.textNombreProyecto.Text != "" ? this.textNombreProyecto.Text : "%";
      this.aprobadosEliminacionBuscarDataSource.SelectParameters["tipo"].DefaultValue = this.comboTipoProyecto.SelectedValue != "" ? this.comboTipoProyecto.SelectedValue : "0";
      this.Session["dv"] = (object) (DataView) this.aprobadosEliminacionBuscarDataSource.Select(DataSourceSelectArguments.Empty);
    }

    protected void gridBuscarProyectos_RowCommand(object sender, GridViewCommandEventArgs e)
    {
      if (e.CommandName.Equals("Modificar"))
      {
        this.SendParams = (object) new BaseModulo.strSendParam()
        {
          id = int.Parse(this.gridBuscarProyectos.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString()),
          tipo = "Modificar"
        };
        this.Response.Redirect("~/Proyectos/AprobadosEliminacionRegistrar.aspx");
      }
      if (e.CommandName.Equals("Ver"))
      {
        this.SendParams = (object) new BaseModulo.strSendParam()
        {
          id = int.Parse(this.gridBuscarProyectos.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString()),
          tipo = "Ver"
        };
        this.Response.Redirect("~/Proyectos/AprobadosEliminacionRegistrar.aspx");
      }
      if (!e.CommandName.Equals("Eliminar"))
        return;
      try
      {
        int pageIndex = this.gridBuscarProyectos.PageIndex;
        int pageSize = this.gridBuscarProyectos.PageSize;
        int keyValue = int.Parse(this.gridBuscarProyectos.DataKeys[int.Parse((string) e.CommandArgument) - pageIndex * pageSize].Value.ToString());
        this.MyDataContext.pap_ProyectoAprobados.DeleteOnSubmit(CLinq.FindByKey<pap_ProyectoAprobado>((DataContext) this.MyDataContext, (object) keyValue));
        this.MyDataContext.SubmitChanges();
        this.gridBuscarProyectos.DataSource = (object) null;
        this.gridBuscarProyectos.DataBind();
        foreach (DataControlField column in (StateManagedCollection) this.gridBuscarProyectos.Columns)
        {
          if (column.HeaderText == "Id")
            column.Visible = false;
        }
        CAuditoria.log(EPermiso.EliminarProyecto, keyValue.ToString(), "", "", "", "", this.Usuario.id);
      }
      catch (Exception ex)
      {
        this.ControlError1.Visible = true;
        this.ControlError1.Show(ex);
      }
    }

    protected void buttonExportar_Click(object sender, EventArgs e)
    {
      this.ExportarDv((DataView) this.Session["dv"]);
      this.Session.Remove("dv");
    }
  }
}
