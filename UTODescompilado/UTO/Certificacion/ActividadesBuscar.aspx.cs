// Decompiled with JetBrains decompiler
// Type: UTO.Certificacion.BuscarActividades
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using AjaxControlToolkit;
using DevExpress.Web;
using NE.CLib;
using NE.CLib.Linq;
using Seguridad.Servicio;
using System;
using System.Data.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UTO.Certificacion
{
  public class BuscarActividades : BaseModulo
  {
    protected ToolkitScriptManager ToolkitScriptManager1;
    protected Label labelBusquedaActividad;
    protected ControlError ControlError1;
    protected Label labelparametros;
    protected Label labelFechaInicio;
    protected TextBox textFechaInicio;
    protected CalendarExtender CalendarExtender3;
    protected Label labelFechaFinal;
    protected TextBox textFechaFinal;
    protected CalendarExtender calendarFechaFinal;
    protected Label labelDepartamento;
    protected DropDownList comboDepartamento;
    protected Label labelCiudad;
    protected DropDownList comboCiudad;
    protected Label label1;
    protected DropDownList comboActividad;
    protected Button buttonBuscar;
    protected Button buttonAdicionar;
    protected HiddenField hiddenConfirma;
    protected Button buttonExportar;
    protected ASPxGridView gvConsulta;
    protected ASPxGridViewExporter exportGrid;
    protected UpdatePanel updateBuscarActividades;
    protected GridView gridBuscarActividades;
    protected SqlDataSource actividadesdatasource;

    protected void Page_Load(object sender, EventArgs e)
    {
      this.buttonBuscar.Enabled = this.Usuario.permiteOperacion(EPermiso.BuscarActividad);
      this.buttonAdicionar.Enabled = this.Usuario.permiteOperacion(EPermiso.AdicionarActividad);
      this.gridBuscarActividades.Columns[0].Visible = this.Usuario.permiteOperacion(EPermiso.BuscarActividad);
      this.gridBuscarActividades.Columns[1].Visible = this.Usuario.permiteOperacion(EPermiso.ModificarActividad);
      this.gridBuscarActividades.Columns[2].Visible = this.Usuario.permiteOperacion(EPermiso.EliminarActividad);
      this.ControlError1.Visible = false;
      if (this.IsPostBack)
        return;
      this.InitData();
    }

    private void InitData()
    {
      this.comboDepartamento.DataSource = (object) CLinq.ListAll<dep_Departamento>((DataContext) this.MyDataContext);
      this.comboDepartamento.DataBind();
      this.comboDepartamento.Items.Insert(0, "");
      this.comboActividad.DataSource = (object) CLinq.ListAll<ati_ActividadTipo>((DataContext) this.MyDataContext);
      this.comboActividad.DataBind();
      this.comboActividad.Items.Insert(0, "");
    }

    protected void buttonAdicionar_Click(object sender, EventArgs e)
    {
      this.SendParams = (object) new BaseModulo.strSendParam()
      {
        id = 0,
        tipo = "Modificar"
      };
      this.Response.Redirect("~/Certificacion/ActividadesRegistrar.aspx");
    }

    protected void gridBuscarActividades_RowCommand(object sender, GridViewCommandEventArgs e)
    {
      if (e.CommandName.Equals("Modificar"))
      {
        this.SendParams = (object) new BaseModulo.strSendParam()
        {
          id = int.Parse(this.gridBuscarActividades.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString()),
          tipo = "Modificar"
        };
        this.Response.Redirect("~/Certificacion/ActividadesRegistrar.aspx");
      }
      if (e.CommandName.Equals("Ver"))
      {
        this.SendParams = (object) new BaseModulo.strSendParam()
        {
          id = int.Parse(this.gridBuscarActividades.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString()),
          tipo = "Ver"
        };
        this.Response.Redirect("~/Certificacion/ActividadesVer.aspx");
      }
      if (!e.CommandName.Equals("Eliminar"))
        return;
      this.ControlError1.Hide();
      try
      {
        int pageIndex = this.gridBuscarActividades.PageIndex;
        int pageSize = this.gridBuscarActividades.PageSize;
        int index = int.Parse((string) e.CommandArgument) - pageIndex * pageSize;
        CCertificacion.EliminarActividad(int.Parse(this.gridBuscarActividades.DataKeys[index].Value.ToString()), this.MyDataContext.Connection.ConnectionString);
        this.gridBuscarActividades.DataSource = (object) null;
        this.gridBuscarActividades.DataBind();
        foreach (DataControlField column in (StateManagedCollection) this.gridBuscarActividades.Columns)
        {
          if (column.HeaderText == "Id")
            column.Visible = false;
        }
        CAuditoria.log(EPermiso.EliminarActividad, index.ToString(), "", "", "", "", this.Usuario.id);
      }
      catch (Exception ex)
      {
        this.ControlError1.Visible = true;
        this.ControlError1.Show(ex);
      }
    }

    protected void buttonBuscar_Click(object sender, EventArgs e)
    {
      try
      {
        this.Validar();
        DateTime date1 = DateTime.Parse("1/1/1900");
        DateTime date2 = DateTime.Parse("1/1/2050");
        if (this.textFechaInicio.Text != "")
          CValidator.isDate(this.textFechaInicio.Text, ref date1);
        if (this.textFechaFinal.Text != "")
          CValidator.isDate(this.textFechaFinal.Text, ref date2);
        this.actividadesdatasource.SelectParameters["fechaIni"].DefaultValue = date1.ToString("yyyy/MM/dd");
        this.actividadesdatasource.SelectParameters["fechaFin"].DefaultValue = date2.ToString("yyyy/MM/dd");
        this.actividadesdatasource.SelectParameters["departamento"].DefaultValue = this.comboDepartamento.SelectedValue != "" ? this.comboDepartamento.SelectedValue : "%";
        this.actividadesdatasource.SelectParameters["municipio"].DefaultValue = this.comboCiudad.SelectedValue != "" ? this.comboCiudad.SelectedValue : "%";
        this.actividadesdatasource.SelectParameters["actividad"].DefaultValue = this.comboActividad.SelectedValue != "" ? this.comboActividad.SelectedValue : "0";
        foreach (DataControlField column in (StateManagedCollection) this.gridBuscarActividades.Columns)
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

    private void Validar()
    {
      bool flag = true;
      DateTime date = DateTime.Parse("1/1/1900");
      string message = "";
      if (this.textFechaInicio.Text != "" && !CValidator.isDate(this.textFechaInicio.Text, ref date))
      {
        message = "La fecha de inicio no tiene un formato válido. <br/>";
        flag = false;
      }
      if (this.textFechaFinal.Text != "" && !CValidator.isDate(this.textFechaFinal.Text, ref date))
      {
        message += "La fecha final no tiene un formato válido. <br/>";
        flag = false;
      }
      if (!flag)
        throw new Exception(message);
    }

    protected void comboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.comboCiudad.DataSource = (object) CLinq.ListByProperty<mun_Municipio>((DataContext) this.MyDataContext, "dep_id", (object) this.comboDepartamento.SelectedValue);
      this.comboCiudad.DataBind();
      this.comboCiudad.Items.Insert(0, "");
    }

    protected void buttonExportar_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.gvConsulta.Selection.Count == 0)
        {
          this.exportGrid.ExportedRowType = GridViewExportedRowType.All;
          this.exportGrid.FileName = "Conusulta_" + DateTime.Now.ToString("ddMMyyyyHHmmss");
        }
        this.exportGrid.WriteXlsxToResponse();
      }
      catch (Exception ex)
      {
      }
    }
  }
}
