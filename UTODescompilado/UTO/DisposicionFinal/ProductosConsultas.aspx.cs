// Decompiled with JetBrains decompiler
// Type: UTO.DisposicionFinal.ProductosConsultas
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using AjaxControlToolkit;
using NE.CLib.Linq;
using System;
using System.Data;
using System.Data.Linq;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace UTO.DisposicionFinal
{
  public class ProductosConsultas : BaseModulo
  {
    protected ToolkitScriptManager ToolkitScriptManager1;
    protected XmlDataSource xmlTipoConsulta;
    protected Label labelConsultas;
    protected ControlError ControlError1;
    protected Label labelSeleccioneConsultas;
    protected DropDownList comboTipoConsulta;
    protected Panel PanelConsulta;
    protected Label labelInventario;
    protected Label labelFechaInicial;
    protected TextBox textFechaInicial;
    protected CalendarExtender calendarFechaInicial;
    protected Label labelFechafinal;
    protected TextBox textFechaFinal;
    protected CalendarExtender calendarFechaFinal;
    protected Label labelSustancia;
    protected DropDownList comboSustancia;
    protected Label labelDepartamento;
    protected DropDownList comboDepartamento;
    protected Label labelCiudad;
    protected DropDownList comboCiudad;
    protected Label labelEstado;
    protected DropDownList comboEstado;
    protected Label labelEmpresa;
    protected DropDownList comboEmpresa;
    protected Button buttonBuscar;
    protected Button buttonExportar;
    protected Button buttonCancelar;
    protected HtmlGenericControl divPublico;
    protected UpdatePanel UpdatePanel1;
    protected GridView gridconsultasMDisposicionFinalPublico;
    protected SqlDataSource productosConsultasDataSource;
    protected HtmlGenericControl divPrivado;
    protected UpdatePanel UpdatePanel2;
    protected GridView gridconsultasMDisposicionFinalPrivado;
    protected SqlDataSource productosConsultaDataSourcePublico;

    protected new void Page_Load(object sender, EventArgs e)
    {
      if (this.IsPostBack)
        return;
      this.InitData();
    }

    private void InitData()
    {
      this.comboDepartamento.DataSource = (object) CLinq.ListAll<dep_Departamento>((DataContext) this.MyDataContext);
      this.comboDepartamento.DataBind();
      this.comboDepartamento.Items.Insert(0, "");
      this.comboSustancia.DataSource = (object) CLinq.ListAll<sus_Sustancia>((DataContext) this.MyDataContext);
      this.comboSustancia.DataBind();
      this.comboSustancia.Items.Insert(0, "");
      this.comboCiudad.DataSource = (object) CLinq.ListAll<mun_Municipio>((DataContext) this.MyDataContext);
      this.comboCiudad.DataBind();
      this.comboCiudad.Items.Insert(0, "");
      this.comboEstado.DataSource = (object) CLinq.ListAll<des_DisposicionEstado>((DataContext) this.MyDataContext);
      this.comboEstado.DataBind();
      this.comboEstado.Items.Insert(0, "");
      this.comboEmpresa.DataSource = (object) CLinq.ListAll<ter_Tercero>((DataContext) this.MyDataContext);
      this.comboEmpresa.DataBind();
      this.comboEmpresa.Items.Insert(0, "");
      this.comboTipoConsulta.Items.Add(new ListItem("Seleccionar", "-1"));
      if (!(this.Usuario.login == "publico"))
        this.comboTipoConsulta.Items.Add(new ListItem("Inventario Nacional-UTO", "0"));
      this.comboTipoConsulta.Items.Add(new ListItem("Inventario Nacional-Público", "1"));
    }

    protected void comboTipoConsulta_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.comboTipoConsulta.SelectedValue.ToString() == "-1")
        this.PanelConsulta.Visible = false;
      if (this.comboTipoConsulta.SelectedValue.ToString() == "0")
      {
        this.PanelConsulta.Visible = true;
        this.comboEmpresa.Visible = true;
        this.labelEmpresa.Visible = true;
        this.textFechaFinal.Text = string.Empty;
        this.textFechaInicial.Text = string.Empty;
        this.divPrivado.Visible = false;
        this.divPublico.Visible = false;
        this.comboDepartamento.Text = "";
        this.comboSustancia.Text = "";
        this.comboCiudad.Text = "";
        this.comboEstado.Text = "";
        this.comboEmpresa.Text = "";
      }
      if (!(this.comboTipoConsulta.SelectedValue.ToString() == "1"))
        return;
      this.PanelConsulta.Visible = true;
      this.comboEmpresa.Visible = true;
      this.labelEmpresa.Visible = true;
      this.textFechaFinal.Text = string.Empty;
      this.textFechaInicial.Text = string.Empty;
      this.comboEmpresa.Visible = false;
      this.labelEmpresa.Visible = false;
      this.divPrivado.Visible = false;
      this.divPublico.Visible = false;
      this.comboDepartamento.Text = "";
      this.comboSustancia.Text = "";
      this.comboCiudad.Text = "";
      this.comboEstado.Text = "";
      this.comboEmpresa.Text = "";
    }

    protected void buttonBuscar_Click(object sender, EventArgs e)
    {
      this.ControlError1.Visible = false;
      DateTime dateTime1 = this.textFechaInicial.Text != "" ? DateTime.Parse(this.textFechaInicial.Text) : DateTime.Parse("1/1/1900");
      DateTime dateTime2 = this.textFechaFinal.Text != "" ? DateTime.Parse(this.textFechaFinal.Text) : DateTime.Parse("1/1/2050");
      try
      {
        if (this.comboTipoConsulta.SelectedValue == "0")
        {
          this.divPublico.Visible = true;
          this.productosConsultasDataSource.SelectParameters["idSustancia"].DefaultValue = this.comboSustancia.SelectedValue != "" ? this.comboSustancia.SelectedValue : "0";
          this.productosConsultasDataSource.SelectParameters["idEstado"].DefaultValue = this.comboEstado.SelectedValue != "" ? this.comboEstado.SelectedValue : "0";
          this.productosConsultasDataSource.SelectParameters["idDepartamento"].DefaultValue = this.comboDepartamento.SelectedValue != "" ? this.comboDepartamento.SelectedValue : "0";
          this.productosConsultasDataSource.SelectParameters["idCiudad"].DefaultValue = this.comboCiudad.SelectedValue != "" ? this.comboCiudad.SelectedValue : "0";
          this.productosConsultasDataSource.SelectParameters["fechaInicial"].DefaultValue = dateTime1.ToString("yyyy/MM/dd");
          this.productosConsultasDataSource.SelectParameters["fechaFinal"].DefaultValue = dateTime2.ToString("yyyy/MM/dd");
          this.productosConsultasDataSource.SelectParameters["idEmpresa"].DefaultValue = this.comboEmpresa.SelectedValue != "" ? this.comboEmpresa.SelectedValue : "0";
          this.Session["dv"] = (object) (DataView) this.productosConsultasDataSource.Select(DataSourceSelectArguments.Empty);
        }
        if (!(this.comboTipoConsulta.SelectedValue == "1"))
          return;
        this.divPrivado.Visible = true;
        this.productosConsultaDataSourcePublico.SelectParameters["idSustancia"].DefaultValue = this.comboSustancia.SelectedValue != "" ? this.comboSustancia.SelectedValue : "0";
        this.productosConsultaDataSourcePublico.SelectParameters["idEstado"].DefaultValue = this.comboEstado.SelectedValue != "" ? this.comboEstado.SelectedValue : "0";
        this.productosConsultaDataSourcePublico.SelectParameters["idDepartamento"].DefaultValue = this.comboDepartamento.SelectedValue != "" ? this.comboDepartamento.SelectedValue : "0";
        this.productosConsultaDataSourcePublico.SelectParameters["idCiudad"].DefaultValue = this.comboCiudad.SelectedValue != "" ? this.comboCiudad.SelectedValue : "0";
        this.productosConsultaDataSourcePublico.SelectParameters["fechaInicial"].DefaultValue = dateTime1.ToString("yyyy/MM/dd");
        this.productosConsultaDataSourcePublico.SelectParameters["fechaFinal"].DefaultValue = dateTime2.ToString("yyyy/MM/dd");
        this.Session["dv"] = (object) (DataView) this.productosConsultaDataSourcePublico.Select(DataSourceSelectArguments.Empty);
      }
      catch (Exception ex)
      {
        this.ControlError1.Visible = true;
        this.ControlError1.Show(ex);
      }
    }

    protected void comboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.comboCiudad.DataSource = (object) CLinq.ListByProperty<mun_Municipio>((DataContext) this.MyDataContext, "dep_id", (object) this.comboDepartamento.SelectedValue);
      this.comboCiudad.DataBind();
      this.comboCiudad.Items.Insert(0, "");
    }

    protected void buttonExportar_Click(object sender, EventArgs e)
    {
      this.ExportarDv((DataView) this.Session["dv"]);
      this.Session.Remove("dv");
    }
  }
}
