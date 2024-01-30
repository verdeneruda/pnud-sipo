// Decompiled with JetBrains decompiler
// Type: UTO.ImportacionExportacion.Consulta
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using AjaxControlToolkit;
using NE.CLib.Linq;
using System;
using System.Data.Linq;
using System.Web.UI.WebControls;

namespace UTO.ImportacionExportacion
{
  public class Consulta : BaseModulo
  {
    protected Label labelConsultas;
    protected Label labelSeleccioneConsultas;
    protected DropDownList comboTipoConsulta;
    protected Panel PanelVistoBuenoIndicadores;
    protected Label labelVistoBueno;
    protected Label labelMesInicial;
    protected DropDownList comboMesInicial;
    protected Label labelannoInicial;
    protected DropDownList comboAnnoInicial;
    protected Label label1;
    protected DropDownList comboMesFinal;
    protected Label label11;
    protected DropDownList comboAnnoFinal;
    protected Button buttonBuscar;
    protected Button buttonExportarVB;
    protected Button buttonCancelar;
    protected GridView gridConsultaVistosBuenos;
    protected Panel PanelVistoBuenoRegistro;
    protected Label label2;
    protected RadioButton RadioSustancia;
    protected RadioButton RadioEquipos;
    protected Label label8;
    protected TextBox textNumeroVB;
    protected Label label9;
    protected TextBox textNumeroLicencia;
    protected Label label10;
    protected TextBox textImportador;
    protected Label label3;
    protected TextBox TextFechaInicialRegistroImportacion;
    protected CalendarExtender CalendarExtender4;
    protected Label label4;
    protected TextBox TextFechaFinalRegistroImportacion;
    protected CalendarExtender CalendarExtender6;
    protected Label labelSustancia;
    protected DropDownList comboSustancia;
    protected Label labelMarcaEquipos;
    protected TextBox textMarcaEquipos;
    protected Button buttonVBRegistro;
    protected Button button2;
    protected Button button3;
    protected GridView GridViewVBRegistro;
    protected SqlDataSource consultaDataSourceVBRegistroImportacion;
    protected SqlDataSource consultaDataSource;
    protected Panel PanelVBDeclaracion;
    protected Label label5;
    protected RadioButton RadioSustanciaDeclaracion;
    protected RadioButton RadioEquipoDeclaracion;
    protected Label label12;
    protected TextBox textNumeroLicenciaDeclaracion;
    protected Label label13;
    protected TextBox textImportadorDeclaracion;
    protected Label label6;
    protected TextBox TextFechaInicialDeclaracion;
    protected CalendarExtender CalendarExtender8;
    protected Label label7;
    protected TextBox TextFechaFinalDeclaracion;
    protected CalendarExtender CalendarExtender10;
    protected Label labelSustanciaDeclaracion;
    protected DropDownList comboSustanciaDeclaracion;
    protected Label labelEquiposDeclaracion;
    protected TextBox TextEquipoDeclaracion;
    protected Button buttonVBDeclaracion;
    protected Button button5;
    protected Button button6;
    protected GridView GridViewVBDeclaracion;
    protected SqlDataSource consultaDataSourceVBDeclaracionImportacion;
    protected Panel PanelRegistroExportacion;
    protected Label label14;
    protected Label label15;
    protected TextBox TextVBExportacion;
    protected Label label16;
    protected TextBox TextLicenciaExportacion;
    protected Label label17;
    protected TextBox TextExportador;
    protected Label label18;
    protected TextBox TextFechaInicialExportacion;
    protected CalendarExtender CalendarExtender12;
    protected Label label19;
    protected TextBox TextFechaFinalExportacion;
    protected CalendarExtender CalendarExtender14;
    protected Label label20;
    protected DropDownList comboRegistroExportacion;
    protected Button buttonRegistroExportacion;
    protected Button button4;
    protected Button button7;
    protected GridView GridRegistroExportacion;
    protected SqlDataSource consultaDataSourceVistoBuenoExpor;
    protected Panel PanelDeclaracionExportacion;
    protected Label label22;
    protected Label label24;
    protected TextBox TextLicenciaDeclaracionExportacion;
    protected Label label25;
    protected TextBox TextExportadorDeclaracion;
    protected Label label26;
    protected TextBox TextFechaInicialDeclaracionExportacion;
    protected CalendarExtender CalendarExtender16;
    protected Label label27;
    protected TextBox TextFechaFinalDeclaracionExportacion;
    protected CalendarExtender CalendarExtender18;
    protected Label label28;
    protected DropDownList comboSustanciaDeclaracionExportacion;
    protected Button buttonDeclaracionExportacion;
    protected Button button9;
    protected Button button10;
    protected GridView GridDeclaracionExportacion;
    protected SqlDataSource consultaDataSourceDeclaracionExportacion;
    protected ToolkitScriptManager ToolkitScriptManager1;

    protected new void Page_Load(object sender, EventArgs e)
    {
      if (this.IsPostBack)
        return;
      this.InitData();
    }

    public void InitData()
    {
      this.comboSustancia.DataSource = (object) CLinq.ListAll<sus_Sustancia>((DataContext) this.MyDataContext);
      this.comboSustancia.DataBind();
      this.comboSustancia.Items.Insert(0, "");
      this.comboSustanciaDeclaracion.DataSource = (object) CLinq.ListAll<sus_Sustancia>((DataContext) this.MyDataContext);
      this.comboSustanciaDeclaracion.DataBind();
      this.comboSustanciaDeclaracion.Items.Insert(0, "");
      this.comboSustanciaDeclaracionExportacion.DataSource = (object) CLinq.ListAll<sus_Sustancia>((DataContext) this.MyDataContext);
      this.comboSustanciaDeclaracionExportacion.DataBind();
      this.comboSustanciaDeclaracionExportacion.Items.Insert(0, "");
      this.comboRegistroExportacion.DataSource = (object) CLinq.ListAll<sus_Sustancia>((DataContext) this.MyDataContext);
      this.comboRegistroExportacion.DataBind();
      this.comboRegistroExportacion.Items.Insert(0, "");
      this.comboTipoConsulta.DataSource = (object) CLinq.ListAll<cip_ConsultaImportacion>((DataContext) this.MyDataContext);
      this.comboTipoConsulta.DataBind();
      this.comboTipoConsulta.Items.Insert(0, "");
      this.comboAnnoInicial.DataSource = (object) this.MyDataContext.spComboAno(new int?(5), new int?(0)).ToList<spComboAnoResult>();
      this.comboAnnoInicial.DataBind();
      this.comboMesInicial.Items.Add(new ListItem("Enero", "1"));
      this.comboMesInicial.Items.Add(new ListItem("Febrero", "2"));
      this.comboMesInicial.Items.Add(new ListItem("Marzo", "3"));
      this.comboMesInicial.Items.Add(new ListItem("Abril", "4"));
      this.comboMesInicial.Items.Add(new ListItem("Mayo", "5"));
      this.comboMesInicial.Items.Add(new ListItem("Junio", "6"));
      this.comboMesInicial.Items.Add(new ListItem("Julio", "7"));
      this.comboMesInicial.Items.Add(new ListItem("Agosto", "8"));
      this.comboMesInicial.Items.Add(new ListItem("Septiembre", "9"));
      this.comboMesInicial.Items.Add(new ListItem("Octubre", "10"));
      this.comboMesInicial.Items.Add(new ListItem("Noviembre", "11"));
      this.comboMesInicial.Items.Add(new ListItem("Diciembre", "12"));
      this.comboAnnoFinal.DataSource = (object) this.MyDataContext.spComboAno(new int?(5), new int?(0)).ToList<spComboAnoResult>();
      this.comboAnnoFinal.DataBind();
      this.comboMesFinal.Items.Add(new ListItem("Enero", "1"));
      this.comboMesFinal.Items.Add(new ListItem("Febrero", "2"));
      this.comboMesFinal.Items.Add(new ListItem("Marzo", "3"));
      this.comboMesFinal.Items.Add(new ListItem("Abril", "4"));
      this.comboMesFinal.Items.Add(new ListItem("Mayo", "5"));
      this.comboMesFinal.Items.Add(new ListItem("Junio", "6"));
      this.comboMesFinal.Items.Add(new ListItem("Julio", "7"));
      this.comboMesFinal.Items.Add(new ListItem("Agosto", "8"));
      this.comboMesFinal.Items.Add(new ListItem("Septiembre", "9"));
      this.comboMesFinal.Items.Add(new ListItem("Octubre", "10"));
      this.comboMesFinal.Items.Add(new ListItem("Noviembre", "11"));
      this.comboMesFinal.Items.Add(new ListItem("Diciembre", "12"));
    }

    protected void buttonBuscar_Click(object sender, EventArgs e)
    {
      this.gridConsultaVistosBuenos.Visible = true;
      this.gridConsultaVistosBuenos.DataSource = (object) CConsultaImportacion.ConsultaIndicadoresGestion((DataContext) this.MyDataContext, DateTime.Parse(this.comboAnnoInicial.SelectedValue + "-" + this.comboMesInicial.SelectedValue + "-01"), DateTime.Parse(this.comboAnnoFinal.SelectedValue + "-" + this.comboMesFinal.SelectedValue + "-01"));
      this.gridConsultaVistosBuenos.DataBind();
    }

    protected void comboTipoConsulta_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.comboTipoConsulta.SelectedValue.ToString() == "0")
      {
        this.PanelVistoBuenoIndicadores.Visible = false;
        this.PanelVistoBuenoRegistro.Visible = false;
        this.PanelVBDeclaracion.Visible = false;
        this.PanelRegistroExportacion.Visible = false;
        this.PanelDeclaracionExportacion.Visible = false;
      }
      if (this.comboTipoConsulta.SelectedValue.ToString() == "1")
      {
        this.PanelVistoBuenoIndicadores.Visible = true;
        this.PanelVistoBuenoRegistro.Visible = false;
        this.PanelVBDeclaracion.Visible = false;
        this.PanelRegistroExportacion.Visible = false;
        this.PanelDeclaracionExportacion.Visible = false;
      }
      if (this.comboTipoConsulta.SelectedValue.ToString() == "2")
      {
        this.PanelVistoBuenoRegistro.Visible = true;
        this.PanelVistoBuenoIndicadores.Visible = false;
        this.PanelVBDeclaracion.Visible = false;
        this.PanelRegistroExportacion.Visible = false;
        this.PanelDeclaracionExportacion.Visible = false;
      }
      if (this.comboTipoConsulta.SelectedValue.ToString() == "3")
      {
        this.PanelVBDeclaracion.Visible = true;
        this.PanelVistoBuenoIndicadores.Visible = false;
        this.PanelVistoBuenoRegistro.Visible = false;
        this.PanelRegistroExportacion.Visible = false;
        this.PanelDeclaracionExportacion.Visible = false;
      }
      if (this.comboTipoConsulta.SelectedValue.ToString() == "4")
      {
        this.PanelVistoBuenoRegistro.Visible = false;
        this.PanelVistoBuenoIndicadores.Visible = false;
        this.PanelVBDeclaracion.Visible = false;
        this.PanelRegistroExportacion.Visible = true;
        this.PanelDeclaracionExportacion.Visible = false;
      }
      if (!(this.comboTipoConsulta.SelectedValue.ToString() == "5"))
        return;
      this.PanelVBDeclaracion.Visible = false;
      this.PanelVistoBuenoIndicadores.Visible = false;
      this.PanelVistoBuenoRegistro.Visible = false;
      this.PanelRegistroExportacion.Visible = false;
      this.PanelDeclaracionExportacion.Visible = true;
    }

    protected void buttonConsultaImportacion_Click(object sender, EventArgs e) => this.GridViewVBRegistro.Visible = true;

    protected void buttonConsultaExportadores_Click(object sender, EventArgs e) => this.GridViewVBDeclaracion.Visible = true;

    protected void PanelVistoBuenoIndicadores_DataBinding(object sender, EventArgs e)
    {
    }

    protected void buttonCancelarImportaciones_Click(object sender, EventArgs e) => this.PanelVistoBuenoRegistro.Visible = false;

    protected void buttonCancelarExportaciones_Click(object sender, EventArgs e) => this.PanelVBDeclaracion.Visible = false;

    protected void buttonCancelar_Click(object sender, EventArgs e) => this.PanelVistoBuenoIndicadores.Visible = false;

    protected void buttonVistoBuenoConsulta_Click(object sender, EventArgs e)
    {
    }

    protected void buttonCancelarVBConsulta_Click(object sender, EventArgs e)
    {
    }

    protected void RadioSustancia_CheckedChanged(object sender, EventArgs e)
    {
      if (this.RadioSustancia.Checked)
      {
        this.labelSustancia.Visible = true;
        this.comboSustancia.Visible = true;
        this.labelMarcaEquipos.Visible = false;
        this.textMarcaEquipos.Visible = false;
      }
      else
      {
        this.labelSustancia.Visible = false;
        this.comboSustancia.Visible = false;
      }
    }

    protected void RadioEquipos_CheckedChanged(object sender, EventArgs e)
    {
      if (this.RadioEquipos.Checked)
      {
        this.labelMarcaEquipos.Visible = true;
        this.textMarcaEquipos.Visible = true;
        this.labelSustancia.Visible = false;
        this.comboSustancia.Visible = false;
      }
      else
      {
        this.labelMarcaEquipos.Visible = false;
        this.textMarcaEquipos.Visible = false;
      }
    }

    protected void RadioEquipoDeclaracion_CheckedChanged(object sender, EventArgs e)
    {
      if (this.RadioEquipoDeclaracion.Checked)
      {
        this.labelEquiposDeclaracion.Visible = true;
        this.TextEquipoDeclaracion.Visible = true;
        this.labelSustanciaDeclaracion.Visible = false;
        this.comboSustanciaDeclaracion.Visible = false;
      }
      else
      {
        this.labelEquiposDeclaracion.Visible = false;
        this.TextEquipoDeclaracion.Visible = false;
      }
    }

    protected void RadioSustanciaDeclaracion_CheckedChanged(object sender, EventArgs e)
    {
      if (this.RadioSustanciaDeclaracion.Checked)
      {
        this.labelSustanciaDeclaracion.Visible = true;
        this.comboSustanciaDeclaracion.Visible = true;
        this.labelEquiposDeclaracion.Visible = false;
        this.TextEquipoDeclaracion.Visible = false;
      }
      else
      {
        this.labelSustanciaDeclaracion.Visible = false;
        this.comboSustanciaDeclaracion.Visible = false;
      }
    }

    protected void buttonVBRegistro_Click(object sender, EventArgs e)
    {
      DateTime dateTime1 = DateTime.Parse("1900-01-01");
      DateTime dateTime2 = DateTime.Parse("2111-01-01");
      if (this.TextFechaInicialRegistroImportacion.Text != "")
        dateTime1 = DateTime.Parse(this.TextFechaInicialRegistroImportacion.Text);
      if (this.TextFechaFinalRegistroImportacion.Text != "")
        dateTime2 = DateTime.Parse(this.TextFechaFinalRegistroImportacion.Text);
      this.GridViewVBRegistro.Visible = true;
      this.consultaDataSource.SelectParameters["vistoBueno"].DefaultValue = this.textNumeroVB.Text != "" ? this.textNumeroVB.Text : "%";
      this.consultaDataSource.SelectParameters["licencia"].DefaultValue = this.textNumeroLicencia.Text != "" ? this.textNumeroLicencia.Text : "%";
      this.consultaDataSource.SelectParameters["importador"].DefaultValue = this.textImportador.Text != "" ? this.textImportador.Text : "%";
      this.consultaDataSource.SelectParameters["fechaInicial"].DefaultValue = dateTime1.ToString("yyyy/MM/dd");
      this.consultaDataSource.SelectParameters["fechaFinal"].DefaultValue = dateTime2.ToString("yyyy/MM/dd");
      this.consultaDataSource.SelectParameters["sustancia"].DefaultValue = string.IsNullOrEmpty(this.comboSustancia.SelectedValue) ? "0" : this.comboSustancia.SelectedValue;
      this.consultaDataSource.SelectParameters["marca"].DefaultValue = this.textMarcaEquipos.Text != "" ? this.textMarcaEquipos.Text : "%";
    }

    protected void buttonVBDeclaracion_Click(object sender, EventArgs e)
    {
      DateTime dateTime1 = DateTime.Parse("1900-01-01");
      DateTime dateTime2 = DateTime.Parse("2111-01-01");
      if (this.TextFechaInicialDeclaracion.Text != "")
        dateTime1 = DateTime.Parse(this.TextFechaInicialDeclaracion.Text);
      if (this.TextFechaFinalDeclaracion.Text != "")
        dateTime2 = DateTime.Parse(this.TextFechaFinalDeclaracion.Text);
      this.GridViewVBDeclaracion.Visible = true;
      this.consultaDataSourceVBDeclaracionImportacion.SelectParameters["licencia"].DefaultValue = this.textNumeroLicenciaDeclaracion.Text != "" ? this.textNumeroLicenciaDeclaracion.Text : "%";
      this.consultaDataSourceVBDeclaracionImportacion.SelectParameters["importador"].DefaultValue = this.textImportadorDeclaracion.Text != "" ? this.textImportadorDeclaracion.Text : "%";
      this.consultaDataSourceVBDeclaracionImportacion.SelectParameters["fechaInicial"].DefaultValue = dateTime1.ToString("yyyy/MM/dd");
      this.consultaDataSourceVBDeclaracionImportacion.SelectParameters["fechaFinal"].DefaultValue = dateTime2.ToString("yyyy/MM/dd");
      this.consultaDataSourceVBDeclaracionImportacion.SelectParameters["sustancia"].DefaultValue = string.IsNullOrEmpty(this.comboSustanciaDeclaracion.SelectedValue) ? "0" : this.comboSustanciaDeclaracion.SelectedValue;
      this.consultaDataSourceVBDeclaracionImportacion.SelectParameters["marca"].DefaultValue = this.TextEquipoDeclaracion.Text != "" ? this.TextEquipoDeclaracion.Text : "%";
    }

    protected void buttonRegistroExportacion_Click(object sender, EventArgs e)
    {
      DateTime dateTime1 = DateTime.Parse("1900-01-01");
      DateTime dateTime2 = DateTime.Parse("2111-01-01");
      if (this.TextFechaInicialExportacion.Text != "")
        dateTime1 = DateTime.Parse(this.TextFechaInicialExportacion.Text);
      if (this.TextFechaFinalExportacion.Text != "")
        dateTime2 = DateTime.Parse(this.TextFechaFinalExportacion.Text);
      this.GridRegistroExportacion.Visible = true;
      this.consultaDataSourceVistoBuenoExpor.SelectParameters["vistoBueno"].DefaultValue = this.TextVBExportacion.Text != "" ? this.TextVBExportacion.Text : "%";
      this.consultaDataSourceVistoBuenoExpor.SelectParameters["licencia"].DefaultValue = this.TextLicenciaExportacion.Text != "" ? this.TextLicenciaExportacion.Text : "%";
      this.consultaDataSourceVistoBuenoExpor.SelectParameters["importador"].DefaultValue = this.TextExportador.Text != "" ? this.TextExportador.Text : "%";
      this.consultaDataSourceVistoBuenoExpor.SelectParameters["fechaInicial"].DefaultValue = dateTime1.ToString("yyyy/MM/dd");
      this.consultaDataSourceVistoBuenoExpor.SelectParameters["fechaFinal"].DefaultValue = dateTime2.ToString("yyyy/MM/dd");
      this.consultaDataSourceVistoBuenoExpor.SelectParameters["sustancia"].DefaultValue = this.comboRegistroExportacion.SelectedValue != "" ? this.comboRegistroExportacion.SelectedValue : "0";
    }

    protected void buttonDeclaracionExportacion_Click(object sender, EventArgs e)
    {
      DateTime dateTime1 = DateTime.Parse("1900-01-01");
      DateTime dateTime2 = DateTime.Parse("2111-01-01");
      if (this.TextFechaInicialDeclaracionExportacion.Text != "")
        dateTime1 = DateTime.Parse(this.TextFechaInicialDeclaracionExportacion.Text);
      if (this.TextFechaFinalDeclaracionExportacion.Text != "")
        dateTime2 = DateTime.Parse(this.TextFechaFinalDeclaracionExportacion.Text);
      this.GridDeclaracionExportacion.Visible = true;
      this.consultaDataSourceDeclaracionExportacion.SelectParameters["licencia"].DefaultValue = this.TextLicenciaDeclaracionExportacion.Text != "" ? this.TextLicenciaDeclaracionExportacion.Text : "%";
      this.consultaDataSourceDeclaracionExportacion.SelectParameters["importador"].DefaultValue = this.TextExportadorDeclaracion.Text != "" ? this.TextExportadorDeclaracion.Text : "%";
      this.consultaDataSourceDeclaracionExportacion.SelectParameters["fechaInicial"].DefaultValue = dateTime1.ToString("yyyy/MM/dd");
      this.consultaDataSourceDeclaracionExportacion.SelectParameters["fechaFinal"].DefaultValue = dateTime2.ToString("yyyy/MM/dd");
      this.consultaDataSourceDeclaracionExportacion.SelectParameters["sustancia"].DefaultValue = this.comboSustanciaDeclaracionExportacion.SelectedValue != "" ? this.comboSustanciaDeclaracionExportacion.SelectedValue : "0";
    }

    protected void buttonExportarVB_Click(object sender, EventArgs e) => this.Exportar(this.gridConsultaVistosBuenos);

    protected void button3_Click(object sender, EventArgs e)
    {
      this.PanelVistoBuenoRegistro.Visible = false;
      this.textNumeroVB.Text = "";
      this.textNumeroLicencia.Text = "";
      this.textImportador.Text = "";
      this.TextFechaInicialRegistroImportacion.Text = "";
      this.TextFechaFinalRegistroImportacion.Text = "";
      this.comboSustancia.SelectedValue = "";
      this.textMarcaEquipos.Text = "";
    }

    protected void button9_Click(object sender, EventArgs e) => this.Exportar(this.GridDeclaracionExportacion);

    protected void button2_Click(object sender, EventArgs e) => this.Exportar(this.GridViewVBRegistro);

    protected void button5_Click(object sender, EventArgs e) => this.Exportar(this.GridViewVBDeclaracion);

    protected void button4_Click(object sender, EventArgs e) => this.Exportar(this.GridRegistroExportacion);
  }
}
