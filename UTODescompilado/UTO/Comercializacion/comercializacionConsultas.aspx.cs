// Decompiled with JetBrains decompiler
// Type: UTO.Comercializacion.comercializacionConsultas
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using AjaxControlToolkit;
using NE.CLib;
using NE.CLib.Linq;
using NE.CLib.Web;
using System;
using System.Data;
using System.Data.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UTO.Comercializacion
{
  public class comercializacionConsultas : BaseModulo
  {
    protected XmlDataSource xmlConsultas;
    protected XmlDataSource XmlSustancia;
    protected XmlDataSource XmlPresentacion;
    protected XmlDataSource XmlMarcaConsulta;
    protected XmlDataSource xmlCiudad;
    protected XmlDataSource xmlDepartamento;
    protected XmlDataSource XmlConsultaPrecio;
    protected ToolkitScriptManager ToolkitScriptManager1;
    protected Label labelConsultas;
    protected ControlError ControlError1;
    protected Label labelSeleccioneConsultas;
    protected DropDownList comboTipoConsulta;
    protected MultiView multiviewConsultas;
    protected View viewMarcas;
    protected Label labelMarcascomerciales;
    protected Label labelSustanciaMarca;
    protected DropDownList comboSustanciaMarca;
    protected Label labelPresentacionMarca;
    protected DropDownList comboPresentacionMarca;
    protected Label labelDepartamentoMarca;
    protected DropDownList comboDepartamentoMarca;
    protected Label labelCiudadMarca;
    protected DropDownList comboCiudadMarca;
    protected Label labelFechaInicialMarca;
    protected TextBox textFechaInicialMarca;
    protected CalendarExtender calendarFechaInicialMarca;
    protected Label labelFechaFinalMarca;
    protected TextBox textFechaFinalMarca;
    protected CalendarExtender calendarFechafinalMarca;
    protected Button buttonBuscar;
    protected Button buttonExportar;
    protected Button buttonCancelar;
    protected GridView gridconsultasMarcasComercializacion;
    protected SqlDataSource comercializacionConsultasDataSource;
    protected View ViewPrecio;
    protected Label labelPrecioPromedio;
    protected Label labelPrecioSustancia;
    protected DropDownList comboPrecioSustancia;
    protected Label labelPrecioPresentacion;
    protected DropDownList comboPrecioPresentacion;
    protected Label labelDepartamentoPrecio;
    protected DropDownList comboDepartamentoPrecio;
    protected Label labelCiudadPrecio;
    protected DropDownList comboCiudadPrecio;
    protected Label labelFechaInicialPrecio;
    protected TextBox textFechaInicialPrecio;
    protected CalendarExtender calendarFecha;
    protected Label labelFechaFinalPrecio;
    protected TextBox textFechaFinalPrecio;
    protected CalendarExtender calendarFechaFinalPrecio;
    protected Button buttonBuscarPrecio;
    protected Button buttonExportar2;
    protected Button buttonCancelarPrecio;
    protected GridView GridPrecio;
    protected SqlDataSource comercializacionConsultasDataSourcePrecio;

    protected new void Page_Load(object sender, EventArgs e)
    {
      this.ControlError1.Visible = false;
      if (this.IsPostBack)
        return;
      this.InitData();
    }

    private void InitData()
    {
      this.comboPrecioSustancia.DataSource = (object) CLinq.ListAll<sus_Sustancia>((DataContext) this.MyDataContext);
      this.comboPrecioSustancia.DataBind();
      this.comboPrecioSustancia.Items.Insert(0, "");
      this.comboCiudadPrecio.DataSource = (object) CLinq.ListAll<mun_Municipio>((DataContext) this.MyDataContext);
      this.comboCiudadPrecio.DataBind();
      this.comboCiudadPrecio.Items.Insert(0, "");
      this.comboPrecioPresentacion.DataSource = (object) CLinq.ListAll<psu_PresentacionSustancia>((DataContext) this.MyDataContext);
      this.comboPrecioPresentacion.DataBind();
      this.comboPrecioPresentacion.Items.Insert(0, "");
      this.comboDepartamentoPrecio.DataSource = (object) CLinq.ListAll<dep_Departamento>((DataContext) this.MyDataContext);
      this.comboDepartamentoPrecio.DataBind();
      this.comboDepartamentoPrecio.Items.Insert(0, "");
      this.comboSustanciaMarca.DataSource = (object) CLinq.ListAll<sus_Sustancia>((DataContext) this.MyDataContext);
      this.comboSustanciaMarca.DataBind();
      this.comboSustanciaMarca.Items.Insert(0, "");
      this.comboCiudadMarca.DataSource = (object) CLinq.ListAll<mun_Municipio>((DataContext) this.MyDataContext);
      this.comboCiudadMarca.DataBind();
      this.comboCiudadMarca.Items.Insert(0, "");
      this.comboPresentacionMarca.DataSource = (object) CLinq.ListAll<psu_PresentacionSustancia>((DataContext) this.MyDataContext);
      this.comboPresentacionMarca.DataBind();
      this.comboPresentacionMarca.Items.Insert(0, "");
      this.comboDepartamentoMarca.DataSource = (object) CLinq.ListAll<dep_Departamento>((DataContext) this.MyDataContext);
      this.comboDepartamentoMarca.DataBind();
      this.comboDepartamentoMarca.Items.Insert(0, "");
      TextBox fechaInicialPrecio = this.textFechaInicialPrecio;
      DateTime dateTime = DateTime.Today;
      dateTime = dateTime.AddMonths(-1);
      string shortDateString = dateTime.ToShortDateString();
      fechaInicialPrecio.Text = shortDateString;
      this.textFechaFinalPrecio.Text = DateTime.Today.ToShortDateString();
    }

    protected void buttonBuscar_Click(object sender, EventArgs e)
    {
      this.gridconsultasMarcasComercializacion.Visible = true;
      try
      {
        this.Validar();
        DateTime dateTime1 = this.textFechaInicialMarca.Text != "" ? DateTime.Parse(this.textFechaInicialMarca.Text) : DateTime.Parse("1/1/1900");
        DateTime dateTime2 = this.textFechaFinalMarca.Text != "" ? DateTime.Parse(this.textFechaFinalMarca.Text) : DateTime.Parse("1/1/2050");
        this.comercializacionConsultasDataSource.SelectParameters["idSustancia"].DefaultValue = this.comboSustanciaMarca.SelectedValue != "" ? this.comboSustanciaMarca.SelectedValue : "0";
        this.comercializacionConsultasDataSource.SelectParameters["idPresentacion"].DefaultValue = this.comboPresentacionMarca.SelectedValue != "" ? this.comboPresentacionMarca.SelectedValue : "0";
        this.comercializacionConsultasDataSource.SelectParameters["idDepartamento"].DefaultValue = this.comboDepartamentoMarca.SelectedValue != "" ? this.comboDepartamentoMarca.SelectedValue : "0";
        this.comercializacionConsultasDataSource.SelectParameters["idCiudad"].DefaultValue = this.comboCiudadMarca.SelectedValue != "" ? this.comboCiudadMarca.SelectedValue : "0";
        this.comercializacionConsultasDataSource.SelectParameters["fechaInicial"].DefaultValue = dateTime1.ToString("yyyy/MM/dd");
        this.comercializacionConsultasDataSource.SelectParameters["fechaFinal"].DefaultValue = dateTime2.ToString("yyyy/MM/dd");
        this.Session["dv"] = (object) (DataView) this.comercializacionConsultasDataSource.Select(DataSourceSelectArguments.Empty);
      }
      catch (Exception ex)
      {
        this.ControlError1.Visible = true;
        this.ControlError1.Show(ex);
      }
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.comboTipoConsulta.SelectedIndex == 0)
        this.multiviewConsultas.Visible = false;
      if (this.comboTipoConsulta.SelectedIndex == 1)
      {
        this.multiviewConsultas.Visible = true;
        this.multiviewConsultas.ActiveViewIndex = 0;
      }
      if (this.comboTipoConsulta.SelectedIndex != 2)
        return;
      this.multiviewConsultas.Visible = true;
      this.multiviewConsultas.SetActiveView(this.ViewPrecio);
    }

    protected void buttonBuscarPrecio_Click(object sender, EventArgs e)
    {
      this.GridPrecio.Visible = true;
      try
      {
        this.Validar();
        DateTime dateTime1 = this.textFechaInicialPrecio.Text != "" ? DateTime.Parse(this.textFechaInicialPrecio.Text) : DateTime.Parse("1/1/1900");
        DateTime dateTime2 = this.textFechaFinalPrecio.Text != "" ? DateTime.Parse(this.textFechaFinalPrecio.Text) : DateTime.Parse("1/1/2050");
        this.comercializacionConsultasDataSourcePrecio.SelectParameters["idSustancia"].DefaultValue = this.comboPrecioSustancia.SelectedValue != "" ? this.comboPrecioSustancia.SelectedValue : "0";
        this.comercializacionConsultasDataSourcePrecio.SelectParameters["idPresentacion"].DefaultValue = this.comboPrecioPresentacion.SelectedValue != "" ? this.comboPrecioPresentacion.SelectedValue : "0";
        this.comercializacionConsultasDataSourcePrecio.SelectParameters["idDepartamento"].DefaultValue = this.comboDepartamentoPrecio.SelectedValue != "" ? this.comboDepartamentoPrecio.SelectedValue : "0";
        this.comercializacionConsultasDataSourcePrecio.SelectParameters["idCiudad"].DefaultValue = this.comboCiudadPrecio.SelectedValue != "" ? this.comboCiudadPrecio.SelectedValue : "0";
        this.comercializacionConsultasDataSourcePrecio.SelectParameters["fechaInicial"].DefaultValue = dateTime1.ToString("yyyy/MM/dd");
        this.comercializacionConsultasDataSourcePrecio.SelectParameters["fechaFinal"].DefaultValue = dateTime2.ToString("yyyy/MM/dd");
        this.Session["dv"] = (object) (DataView) this.comercializacionConsultasDataSourcePrecio.Select(DataSourceSelectArguments.Empty);
        CGridView.FormatCurrencyColumn(this.GridPrecio, "precioPromedio");
      }
      catch (Exception ex)
      {
        this.ControlError1.Visible = true;
        this.ControlError1.Show(ex);
      }
    }

    protected void comboDepartamentoMarca_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.comboCiudadMarca.DataSource = (object) CLinq.ListByProperty<mun_Municipio>((DataContext) this.MyDataContext, "dep_id", (object) this.comboDepartamentoMarca.SelectedValue);
      this.comboCiudadMarca.DataBind();
      this.comboCiudadMarca.Items.Insert(0, "");
    }

    protected void comboDepartamentoPrecio_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.comboCiudadPrecio.DataSource = (object) CLinq.ListByProperty<mun_Municipio>((DataContext) this.MyDataContext, "dep_id", (object) this.comboDepartamentoPrecio.SelectedValue);
      this.comboCiudadPrecio.DataBind();
      this.comboCiudadPrecio.Items.Insert(0, "");
    }

    protected void buttonExportar_Click(object sender, EventArgs e)
    {
      this.ExportarDv((DataView) this.Session["dv"]);
      this.Session.Remove("dv");
    }

    protected void buttonExportar2_Click(object sender, EventArgs e)
    {
      this.ExportarDv((DataView) this.Session["dv"]);
      this.Session.Remove("dv");
    }

    private void Validar()
    {
      string message = "";
      bool flag = true;
      DateTime date = DateTime.Parse("1/1/1900");
      if (this.textFechaInicialMarca.Text != "" && !CValidator.isDate(this.textFechaInicialMarca.Text, ref date))
      {
        message += "La fecha inicial no tiene un formato válido. <br/>";
        flag = false;
      }
      if (this.textFechaFinalMarca.Text != "" && !CValidator.isDate(this.textFechaFinalMarca.Text, ref date))
      {
        message += "La fecha final no tiene un formato válido. <br/>";
        flag = false;
      }
      if (this.textFechaInicialPrecio.Text != "" && !CValidator.isDate(this.textFechaInicialPrecio.Text, ref date))
      {
        message += "La fecha inicial no tiene un formato válido. <br/>";
        flag = false;
      }
      if (this.textFechaFinalPrecio.Text != "" && !CValidator.isDate(this.textFechaFinalPrecio.Text, ref date))
      {
        message += "La fecha final no tiene un formato válido. <br/>";
        flag = false;
      }
      if (!flag)
        throw new Exception(message);
    }
  }
}
