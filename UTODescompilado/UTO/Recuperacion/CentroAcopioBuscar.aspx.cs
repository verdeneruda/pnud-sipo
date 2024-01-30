// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.CentroAcopioBuscar
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using AjaxControlToolkit;
using NE.CLib.Linq;
using Seguridad.Servicio;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UTO.Recuperacion
{
  public class CentroAcopioBuscar : BaseModulo
  {
    protected ToolkitScriptManager ToolkitScriptManager1;
    protected Label labelBusquedaSolicitudesEquipos;
    protected ControlError ControlError1;
    protected Label labelparametros;
    protected Label labelRegional;
    protected DropDownList comboCentroAcopio;
    protected Label labelFechaInicial;
    protected TextBox textFechaInicial;
    protected CalendarExtender calendarfecha;
    protected Label label1;
    protected TextBox textFechaFinal;
    protected CalendarExtender CalendarExtender1;
    protected Button buttonBuscar;
    protected Button buttonAdicionar;
    protected GridView gridBuscar;
    protected SqlDataSource CentroAcopioBuscarDataSource;

    protected new void Page_Load(object sender, EventArgs e)
    {
      this.buttonAdicionar.Visible = this.Usuario.permiteOperacion(EPermiso.AdicionarReportesCentroAcopio);
      this.gridBuscar.Columns[0].Visible = this.Usuario.permiteOperacion(EPermiso.ModificarReportesCentroAcopio);
      this.gridBuscar.Columns[1].Visible = this.Usuario.permiteOperacion(EPermiso.EliminarReportesCentroAcopio);
      this.gridBuscar.Columns[2].Visible = this.Usuario.permiteOperacion(EPermiso.BuscarReportesCentroAcopio);
      if (this.IsPostBack)
        return;
      this.InitData();
    }

    private void InitData()
    {
      this.comboCentroAcopio.DataSource = (object) CLinq.ListAll<cea_CentroAcopio>((DataContext) this.MyDataContext);
      this.comboCentroAcopio.DataBind();
      this.comboCentroAcopio.Items.Insert(0, "");
    }

    protected void gridBuscarSolicitudEquipos_RowCommand(object sender, GridViewCommandEventArgs e)
    {
      if (e.CommandName.Equals("Modificar"))
      {
        this.SendParams = (object) new BaseModulo.strSendParam()
        {
          id = int.Parse(this.gridBuscar.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString()),
          tipo = "Modificar"
        };
        this.Server.Transfer("~/Recuperacion/CentroAcopioRegistrar.aspx");
      }
      if (e.CommandName.Equals("Ver"))
      {
        this.SendParams = (object) new BaseModulo.strSendParam()
        {
          id = int.Parse(this.gridBuscar.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString()),
          tipo = "Ver"
        };
        this.Server.Transfer("~/Recuperacion/CentroAcopioRegistrar.aspx");
      }
      if (!e.CommandName.Equals("Eliminar"))
        return;
      int num = int.Parse(this.gridBuscar.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString());
      List<rad_ReporteCentroAcopioDetalle> centroAcopioDetalleList = CLinq.ListByProperty<rad_ReporteCentroAcopioDetalle>((DataContext) this.MyDataContext, "rca_Id", (object) num);
      for (int index = 0; index <= centroAcopioDetalleList.Count - 1; ++index)
        this.MyDataContext.rad_ReporteCentroAcopioDetalles.DeleteOnSubmit(centroAcopioDetalleList[index]);
      rca_ReporteCentroAcopio byKey = CLinq.FindByKey<rca_ReporteCentroAcopio>((DataContext) this.MyDataContext, (object) num);
      try
      {
        this.MyDataContext.rca_ReporteCentroAcopios.DeleteOnSubmit(byKey);
        this.MyDataContext.SubmitChanges();
        this.gridBuscar.DataSource = (object) null;
        this.gridBuscar.DataBind();
        foreach (DataControlField column in (StateManagedCollection) this.gridBuscar.Columns)
        {
          if (column.HeaderText == "Id")
            column.Visible = false;
        }
      }
      catch (Exception ex)
      {
        this.ControlError1.Visible = true;
        this.ControlError1.Show(ex);
      }
    }

    protected void buttonAdicionar_Click(object sender, EventArgs e)
    {
      this.SendParams = (object) new BaseModulo.strSendParam()
      {
        id = 0,
        tipo = ""
      };
      this.Server.Transfer("~/Recuperacion/CentroAcopioRegistrar.aspx");
    }

    protected void buttonBuscar_Click(object sender, EventArgs e)
    {
      this.CentroAcopioBuscarDataSource.SelectParameters["centro"].DefaultValue = this.comboCentroAcopio.SelectedValue != "" ? this.comboCentroAcopio.SelectedValue : "0";
      this.CentroAcopioBuscarDataSource.SelectParameters["fechaInicial"].DefaultValue = this.textFechaInicial.Text != "" ? this.textFechaInicial.Text : "1/1/1900";
      this.CentroAcopioBuscarDataSource.SelectParameters["fechaFinal"].DefaultValue = this.textFechaFinal.Text != "" ? this.textFechaFinal.Text : "1/1/2111";
    }
  }
}
