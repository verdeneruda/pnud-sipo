// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.ReporteRegeneracionBuscar
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using AjaxControlToolkit;
using NE.CLib.Linq;
using Seguridad.Servicio;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Web.UI.WebControls;

namespace UTO.Recuperacion
{
  public class ReporteRegeneracionBuscar : BaseModulo
  {
    protected ToolkitScriptManager ToolkitScriptManager1;
    protected Label labelBusquedaSolicitudesEquipos;
    protected ControlError ControlError1;
    protected Label labelparametros;
    protected Label labelRegional;
    protected DropDownList comboCentroRegeneracion;
    protected Label labelNombreBeneficiario;
    protected TextBox textNombreBeneficiario;
    protected Label labelFechaInicial;
    protected TextBox textFechaInicial;
    protected CalendarExtender calendarfecha;
    protected Label label1;
    protected TextBox textFechaFinal;
    protected CalendarExtender CalendarExtender1;
    protected Button buttonBuscar;
    protected Button buttonAdicionar;
    protected GridView gridBuscarReporteUso;
    protected SqlDataSource reporteRegeneracionBuscarDataSource;

    protected new void Page_Load(object sender, EventArgs e)
    {
      if (this.IsPostBack)
        return;
      this.InitData();
    }

    public void InitData()
    {
      this.comboCentroRegeneracion.DataSource = (object) CLinq.ListAll<cre_CentroRegeneracion>((DataContext) this.MyDataContext);
      this.comboCentroRegeneracion.DataBind();
      this.comboCentroRegeneracion.Items.Insert(0, "");
    }

    protected void buttonBuscar_Click(object sender, EventArgs e)
    {
      this.reporteRegeneracionBuscarDataSource.SelectParameters["centro"].DefaultValue = this.comboCentroRegeneracion.SelectedValue != "" ? this.comboCentroRegeneracion.SelectedValue : "0";
      this.reporteRegeneracionBuscarDataSource.SelectParameters["beneficiario"].DefaultValue = this.textNombreBeneficiario.Text != "" ? this.textNombreBeneficiario.Text : "%";
      this.reporteRegeneracionBuscarDataSource.SelectParameters["fechaInicial"].DefaultValue = this.textNombreBeneficiario.Text != "" ? this.textNombreBeneficiario.Text : "1/1/1900";
      this.reporteRegeneracionBuscarDataSource.SelectParameters["fechaFinal"].DefaultValue = this.textNombreBeneficiario.Text != "" ? this.textNombreBeneficiario.Text : "1/1/2111";
    }

    protected void buttonAdicionar_Click(object sender, EventArgs e)
    {
      this.SendParams = (object) new BaseModulo.strSendParam()
      {
        id = 0,
        tipo = ""
      };
      this.Server.Transfer("~/Recuperacion/CentrosRegeneracionRegistrar.aspx");
    }

    protected void gridBuscarReporteUso_RowCommand(object sender, GridViewCommandEventArgs e)
    {
      if (e.CommandName.Equals("Modificar"))
      {
        this.SendParams = (object) new BaseModulo.strSendParam()
        {
          id = int.Parse(this.gridBuscarReporteUso.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString()),
          tipo = "Modificar"
        };
        this.Server.Transfer("~/Recuperacion/CentrosRegeneracionRegistrar.aspx");
      }
      if (e.CommandName.Equals("Ver"))
      {
        this.SendParams = (object) new BaseModulo.strSendParam()
        {
          id = int.Parse(this.gridBuscarReporteUso.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString()),
          tipo = "Ver"
        };
        this.Server.Transfer("~/Recuperacion/ReporteRegeneracionRegistrar.aspx");
      }
      if (!e.CommandName.Equals("Eliminar"))
        return;
      int num = int.Parse(this.gridBuscarReporteUso.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString());
      List<rrd_ReporteRegeneracionDocumento> regeneracionDocumentoList = CLinq.ListByProperty<rrd_ReporteRegeneracionDocumento>((DataContext) this.MyDataContext, "rrd_Id", (object) num);
      for (int index = 0; index <= regeneracionDocumentoList.Count - 1; ++index)
        this.MyDataContext.rrd_ReporteRegeneracionDocumentos.DeleteOnSubmit(regeneracionDocumentoList[index]);
      rre_ReporteRegeneracion byKey = CLinq.FindByKey<rre_ReporteRegeneracion>((DataContext) this.MyDataContext, (object) num);
      try
      {
        this.MyDataContext.rre_ReporteRegeneracions.DeleteOnSubmit(byKey);
        this.MyDataContext.SubmitChanges();
        this.gridBuscarReporteUso.DataSource = (object) null;
        this.gridBuscarReporteUso.DataBind();
        CAuditoria.log(EPermiso.EliminarReportesCentroDeRegeneracion, num.ToString(), "", "", "", "", this.Usuario.id);
      }
      catch (Exception ex)
      {
        this.ControlError1.Visible = true;
        this.ControlError1.Show(ex);
      }
    }
  }
}
