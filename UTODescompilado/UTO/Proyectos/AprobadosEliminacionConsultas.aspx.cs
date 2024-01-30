// Decompiled with JetBrains decompiler
// Type: UTO.Proyectos.AprobadosEliminacionConsultas
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using AjaxControlToolkit;
using NE.CLib.Linq;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Web.UI.WebControls;

namespace UTO.Proyectos
{
  public class AprobadosEliminacionConsultas : BaseModulo
  {
    protected ToolkitScriptManager ToolkitScriptManager1;
    protected Label labelConsultas;
    protected Label labelProyectos;
    protected Label labelTipoProyecto;
    protected DropDownList comboTipoProyecto;
    protected Label labelSectorProyecto;
    protected DropDownList comboSector;
    protected Label labelNombreProyecto;
    protected TextBox textNombreProyecto;
    protected Label labelDepartamento;
    protected DropDownList comboDepartamento;
    protected Label labelCiudad;
    protected DropDownList comboCiudad;
    protected Label labelFechaInicial;
    protected TextBox textFechaInicial;
    protected CalendarExtender calendarfechaInicial;
    protected Label labelFechaFinal;
    protected TextBox textFechaFinal;
    protected CalendarExtender calendarfechafinal;
    protected Button buttonBuscar;
    protected Button buttonExportar;
    protected Button buttonCancelar;
    protected GridView gridConsultasProyectos;
    protected SqlDataSource aprobadosEliminacionConsultasDataSource;

    protected new void Page_Load(object sender, EventArgs e)
    {
      if (this.IsPostBack)
        return;
      this.InitData();
    }

    private void InitData()
    {
      this.comboTipoProyecto.DataSource = (object) CLinq.ListAll<pti_ProyectoTipo>((DataContext) this.MyDataContext);
      this.comboTipoProyecto.DataBind();
      this.comboTipoProyecto.Items.Insert(0, "");
      this.comboSector.DataSource = (object) CLinq.ListAll<pse_ProyectoSector>((DataContext) this.MyDataContext);
      this.comboSector.DataBind();
      this.comboSector.Items.Insert(0, "");
      this.comboDepartamento.DataSource = (object) CLinq.ListAll<dep_Departamento>((DataContext) this.MyDataContext);
      this.comboDepartamento.DataBind();
      this.comboDepartamento.Items.Insert(0, "");
    }

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

    protected void buttonBuscar_Click(object sender, EventArgs e)
    {
      this.aprobadosEliminacionConsultasDataSource.SelectParameters["nombre"].DefaultValue = this.textNombreProyecto.Text != "" ? this.textNombreProyecto.Text : "%";
      this.aprobadosEliminacionConsultasDataSource.SelectParameters["tipo"].DefaultValue = this.comboTipoProyecto.SelectedValue != "" ? this.comboTipoProyecto.SelectedValue : "0";
      this.aprobadosEliminacionConsultasDataSource.SelectParameters["departamento"].DefaultValue = this.comboDepartamento.SelectedValue != "" ? this.comboDepartamento.SelectedValue : "0";
      this.aprobadosEliminacionConsultasDataSource.SelectParameters["municipio"].DefaultValue = this.comboCiudad.SelectedValue != "" ? this.comboCiudad.SelectedValue : "0";
      this.aprobadosEliminacionConsultasDataSource.SelectParameters["sector"].DefaultValue = this.comboSector.SelectedValue != "" ? this.comboSector.SelectedValue : "0";
      if (this.gridConsultasProyectos.Rows.Count > 0)
        this.buttonExportar.Visible = true;
      else
        this.buttonExportar.Visible = false;
    }

    protected void buttonExportar_Click(object sender, EventArgs e) => this.Exportar(this.gridConsultasProyectos);
  }
}
