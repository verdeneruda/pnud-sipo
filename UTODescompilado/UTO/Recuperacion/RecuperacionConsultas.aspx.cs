// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.RecuperacionConsultas
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using AjaxControlToolkit;
using NE.CLib.Linq;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Web.UI.WebControls;

namespace UTO.Recuperacion
{
  public class RecuperacionConsultas : BaseModulo
  {
    protected Label labelConsultas;
    protected Label labelReporteUso;
    protected Label labelBeneficiario0;
    protected DropDownList comboTipoConsulta;
    protected Label labelRegional;
    protected DropDownList comboRegional;
    protected Label labelPeriodo;
    protected DropDownList comboPeriodo;
    protected Label labelDepartamento;
    protected DropDownList comboDepartamento;
    protected Label labelCiudad;
    protected DropDownList comboCiudad;
    protected Label labelFechaInicial;
    protected TextBox textFechaInicial;
    protected CalendarExtender calendarfecha;
    protected CalendarExtender CalendarExtender2;
    protected Label label1;
    protected TextBox textFechaFinal;
    protected CalendarExtender CalendarExtender1;
    protected CalendarExtender CalendarExtender3;
    protected Label labelBeneficiario;
    protected TextBox textNombreBeneficiario;
    protected Label labelAno;
    protected DropDownList comboAno;
    protected Button buttonBuscarReporteUso;
    protected Button buttonExportar;
    protected Button buttonCancelar;
    protected Panel panelReporteUso;
    protected GridView gridReporteUso;
    protected SqlDataSource SqlDataSourceReporteUso;
    protected Panel panelCentroRegeneracion;
    protected GridView gridCentroRegeneracion;
    protected SqlDataSource SqlDataSourceCentroRegeneracion;
    protected Panel panelNovedades;
    protected GridView gridNovedades;
    protected SqlDataSource SqlDataSourceNovedades;
    protected Panel panelPolizas;
    protected GridView gridPolizas;
    protected SqlDataSource SqlDataSourcePolizas;
    protected Panel panelConsolidadoRegeneracion;
    protected GridView gridConsolidadoRegeneracion;
    protected SqlDataSource SqlDataSourceConsolidadoRegeneracion;
    protected ToolkitScriptManager ToolkitScriptManager1;

    protected new void Page_Load(object sender, EventArgs e)
    {
      if (this.IsPostBack)
        return;
      this.InitData();
    }

    public void InitData()
    {
      this.comboTipoConsulta.DataSource = (object) CLinq.ListAll<cre_ConsultaRecuperacion>((DataContext) this.MyDataContext);
      this.comboTipoConsulta.DataBind();
      this.comboTipoConsulta.Items.Insert(0, "");
      this.comboDepartamento.DataSource = (object) CLinq.ListAll<dep_Departamento>((DataContext) this.MyDataContext);
      this.comboDepartamento.DataBind();
      this.comboDepartamento.Items.Insert(0, "");
      this.comboRegional.DataSource = (object) CLinq.ListAll<reg_Regional>((DataContext) this.MyDataContext);
      this.comboRegional.DataBind();
      this.comboRegional.Items.Insert(0, "");
      this.comboPeriodo.DataSource = this.cargarPeriodo();
      this.comboPeriodo.DataBind();
      this.comboPeriodo.Items.Insert(0, "");
      this.comboAno.DataSource = (object) this.MyDataContext.spComboAno(new int?(5), new int?(1)).ToList<spComboAnoResult>();
      this.comboAno.DataBind();
      this.comboAno.Items.Insert(0, "");
      this.panelCentroRegeneracion.Visible = false;
      this.panelConsolidadoRegeneracion.Visible = false;
      this.panelNovedades.Visible = false;
      this.panelPolizas.Visible = false;
      this.panelReporteUso.Visible = false;
    }

    private object cargarPeriodo() => (object) new List<string>()
    {
      "Primer trimestre",
      "Segundo trimestre",
      "Tercero trimestre",
      "Cuarto trimestre"
    };

    protected void comboDepartamento_SelectedIndexChanged(object sender, EventArgs e) => this.listarMunicipio(this.comboDepartamento.SelectedValue);

    protected void listarMunicipio(string departamento)
    {
      List<mun_Municipio> munMunicipioList = CLinq.ListByProperty<mun_Municipio>((DataContext) this.MyDataContext, "dep_Id", (object) departamento);
      this.comboCiudad.SelectedValue = (string) null;
      if (munMunicipioList.Count > 0)
      {
        this.comboCiudad.DataSource = (object) munMunicipioList;
        this.comboCiudad.DataBind();
        this.comboCiudad.Items.Insert(0, "");
      }
      else
        this.comboCiudad.Items.Insert(0, "");
    }

    protected void buttonBuscarReporteUso_Click(object sender, EventArgs e)
    {
      DateTime dateTime1 = DateTime.Parse("1900-01-01");
      DateTime dateTime2 = DateTime.Parse("2111-01-01");
      if (this.textFechaInicial.Text != "" && this.textFechaInicial.Text != null)
        dateTime1 = DateTime.Parse(this.textFechaInicial.Text);
      if (this.textFechaFinal.Text != "" && this.textFechaFinal.Text != null)
        dateTime2 = DateTime.Parse(this.textFechaFinal.Text);
      if (this.comboTipoConsulta.SelectedIndex == 1 || this.comboTipoConsulta.SelectedValue == "" || this.comboTipoConsulta.SelectedValue == null)
      {
        this.panelReporteUso.Visible = true;
        this.panelCentroRegeneracion.Visible = false;
        this.panelConsolidadoRegeneracion.Visible = false;
        this.panelNovedades.Visible = false;
        this.panelPolizas.Visible = false;
        this.SqlDataSourceReporteUso.SelectParameters["departamento"].DefaultValue = string.IsNullOrEmpty(this.comboDepartamento.SelectedValue) ? "%" : this.comboDepartamento.SelectedValue;
        this.SqlDataSourceReporteUso.SelectParameters["municipio"].DefaultValue = string.IsNullOrEmpty(this.comboCiudad.SelectedValue) ? "%" : this.comboCiudad.SelectedValue;
        this.SqlDataSourceReporteUso.SelectParameters["regional"].DefaultValue = string.IsNullOrEmpty(this.comboRegional.SelectedValue) ? "0" : this.comboRegional.SelectedValue;
        this.SqlDataSourceReporteUso.SelectParameters["beneficiario"].DefaultValue = string.IsNullOrEmpty(this.textNombreBeneficiario.Text) ? "%" : this.textNombreBeneficiario.Text;
        this.SqlDataSourceReporteUso.SelectParameters["fechaInicial"].DefaultValue = dateTime1.ToString("yyyy/MM/dd");
        this.SqlDataSourceReporteUso.SelectParameters["fechaFinal"].DefaultValue = dateTime2.ToString("yyyy/MM/dd");
        this.SqlDataSourceReporteUso.SelectParameters["anno"].DefaultValue = string.IsNullOrEmpty(this.comboAno.SelectedValue) ? "0" : this.comboAno.SelectedValue;
        this.SqlDataSourceReporteUso.SelectParameters["periodo"].DefaultValue = string.IsNullOrEmpty(this.comboPeriodo.SelectedValue) ? "%" : this.comboPeriodo.SelectedValue;
        this.LocalInfo.SetData("consulta", (object) this.gridReporteUso);
      }
      if (this.comboTipoConsulta.SelectedIndex == 2)
      {
        this.panelReporteUso.Visible = false;
        this.panelCentroRegeneracion.Visible = true;
        this.panelConsolidadoRegeneracion.Visible = false;
        this.panelNovedades.Visible = false;
        this.panelPolizas.Visible = false;
        this.SqlDataSourceCentroRegeneracion.SelectParameters["beneficiario"].DefaultValue = string.IsNullOrEmpty(this.textNombreBeneficiario.Text) ? "%" : this.textNombreBeneficiario.Text;
        this.SqlDataSourceCentroRegeneracion.SelectParameters["fechaInicial"].DefaultValue = dateTime1.ToString("yyyy/MM/dd");
        this.SqlDataSourceCentroRegeneracion.SelectParameters["fechaFinal"].DefaultValue = dateTime2.ToString("yyyy/MM/dd");
        this.LocalInfo.SetData("consulta", (object) this.gridCentroRegeneracion);
      }
      if (this.comboTipoConsulta.SelectedIndex == 3)
      {
        this.panelReporteUso.Visible = false;
        this.panelCentroRegeneracion.Visible = false;
        this.panelConsolidadoRegeneracion.Visible = false;
        this.panelNovedades.Visible = true;
        this.panelPolizas.Visible = false;
        this.SqlDataSourceNovedades.SelectParameters["departamento"].DefaultValue = string.IsNullOrEmpty(this.comboDepartamento.SelectedValue) ? "%" : this.comboDepartamento.SelectedValue;
        this.SqlDataSourceNovedades.SelectParameters["municipio"].DefaultValue = string.IsNullOrEmpty(this.comboCiudad.SelectedValue) ? "%" : this.comboCiudad.SelectedValue;
        this.SqlDataSourceNovedades.SelectParameters["regional"].DefaultValue = string.IsNullOrEmpty(this.comboRegional.SelectedValue) ? "0" : this.comboRegional.SelectedValue;
        this.SqlDataSourceNovedades.SelectParameters["beneficiario"].DefaultValue = string.IsNullOrEmpty(this.textNombreBeneficiario.Text) ? "%" : this.textNombreBeneficiario.Text;
        this.SqlDataSourceNovedades.SelectParameters["fechaInicial"].DefaultValue = dateTime1.ToString("yyyy/MM/dd");
        this.SqlDataSourceNovedades.SelectParameters["fechaFinal"].DefaultValue = dateTime2.ToString("yyyy/MM/dd");
        this.LocalInfo.SetData("consulta", (object) this.gridNovedades);
      }
      else if (this.comboTipoConsulta.SelectedIndex == 4)
      {
        this.panelReporteUso.Visible = false;
        this.panelCentroRegeneracion.Visible = false;
        this.panelConsolidadoRegeneracion.Visible = false;
        this.panelNovedades.Visible = false;
        this.panelPolizas.Visible = true;
        this.SqlDataSourcePolizas.SelectParameters["departamento"].DefaultValue = string.IsNullOrEmpty(this.comboDepartamento.SelectedValue) ? "%" : this.comboDepartamento.SelectedValue;
        this.SqlDataSourcePolizas.SelectParameters["municipio"].DefaultValue = string.IsNullOrEmpty(this.comboCiudad.SelectedValue) ? "%" : this.comboCiudad.SelectedValue;
        this.SqlDataSourcePolizas.SelectParameters["regional"].DefaultValue = string.IsNullOrEmpty(this.comboRegional.SelectedValue) ? "0" : this.comboRegional.SelectedValue;
        this.SqlDataSourcePolizas.SelectParameters["beneficiario"].DefaultValue = string.IsNullOrEmpty(this.textNombreBeneficiario.Text) ? "%" : this.textNombreBeneficiario.Text;
        this.SqlDataSourcePolizas.SelectParameters["fechaInicial"].DefaultValue = dateTime1.ToString("yyyy/MM/dd");
        this.SqlDataSourcePolizas.SelectParameters["fechaFinal"].DefaultValue = dateTime2.ToString("yyyy/MM/dd");
        this.LocalInfo.SetData("consulta", (object) this.gridPolizas);
      }
      if (this.comboTipoConsulta.SelectedIndex != 5)
        return;
      this.panelReporteUso.Visible = false;
      this.panelCentroRegeneracion.Visible = false;
      this.panelConsolidadoRegeneracion.Visible = true;
      this.panelNovedades.Visible = false;
      this.panelPolizas.Visible = false;
      this.labelPeriodo.Visible = false;
      this.comboPeriodo.Visible = false;
      this.labelAno.Visible = false;
      this.comboAno.Visible = false;
      this.labelDepartamento.Visible = false;
      this.comboDepartamento.Visible = false;
      this.labelCiudad.Visible = false;
      this.comboCiudad.Visible = false;
      this.labelRegional.Visible = false;
      this.comboRegional.Visible = false;
      this.textNombreBeneficiario.Visible = false;
      this.SqlDataSourceConsolidadoRegeneracion.SelectParameters["fechaInicial"].DefaultValue = dateTime1.ToString("yyyy/MM/dd");
      this.SqlDataSourceConsolidadoRegeneracion.SelectParameters["fechaFinal"].DefaultValue = dateTime2.ToString("yyyy/MM/dd");
      this.LocalInfo.SetData("consulta", (object) this.gridConsolidadoRegeneracion);
    }

    protected void buttonCancelar_Click(object sender, EventArgs e) => this.limpiarCampos();

    protected void limpiarCampos()
    {
      this.comboTipoConsulta.SelectedValue = "";
      this.comboPeriodo.SelectedValue = "";
      this.comboAno.SelectedValue = "";
      this.comboCiudad.SelectedValue = "";
      this.comboDepartamento.SelectedValue = "";
      this.textFechaInicial.Text = "";
      this.textFechaFinal.Text = "";
      this.textNombreBeneficiario.Text = "";
      this.comboRegional.SelectedValue = "";
    }

    protected void buttonExportar_Click(object sender, EventArgs e)
    {
      if (this.comboTipoConsulta.SelectedValue == "1")
        this.Exportar(this.gridReporteUso);
      if (this.comboTipoConsulta.SelectedValue == "2")
        this.Exportar(this.gridCentroRegeneracion);
      if (this.comboTipoConsulta.SelectedValue == "3")
        this.Exportar(this.gridNovedades);
      if (this.comboTipoConsulta.SelectedValue == "4")
        this.Exportar(this.gridPolizas);
      if (!(this.comboTipoConsulta.SelectedValue == "5"))
        return;
      this.Exportar(this.gridConsolidadoRegeneracion);
    }

    protected void comboDepartamento_SelectedIndexChanged1(object sender, EventArgs e) => this.listarMunicipio(this.comboDepartamento.SelectedValue);
  }
}
