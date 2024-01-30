// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.Correspondencia
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
  public class Correspondencia : BaseModulo
  {
    protected ToolkitScriptManager ToolkitScriptManager1;
    protected Label labelBusquedaSolicitudesEquipos;
    protected Label labelparametros;
    protected Label labelRegional;
    protected DropDownList comboRegional;
    protected Label labelNombreBeneficiario;
    protected TextBox textNombreBeneficiario;
    protected Label labelDepartamento;
    protected DropDownList comboDepartamento;
    protected Label labelCiudad;
    protected DropDownList comboCiudad;
    protected Button buttonBuscar;
    protected CheckBox CheckSeleccionarTodos;
    protected GridView gridCorrespondencia;
    protected GridView gridExportar;
    protected Button buttonExportar;
    protected Button buttonCancelar;

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
      this.comboRegional.DataSource = (object) CLinq.ListAll<reg_Regional>((DataContext) this.MyDataContext);
      this.comboRegional.DataBind();
      this.comboRegional.Items.Insert(0, "");
    }

    protected void buttonBuscar_Click(object sender, EventArgs e)
    {
      this.gridCorrespondencia.DataSource = (object) this.MyDataContext.spBeneficiarioBuscarCorrespondencia(this.textNombreBeneficiario.Text, "", new int?(0), string.IsNullOrEmpty(this.comboDepartamento.SelectedValue) ? "" : this.comboDepartamento.SelectedValue, string.IsNullOrEmpty(this.comboCiudad.SelectedValue) ? "" : this.comboCiudad.SelectedValue, new int?(string.IsNullOrEmpty(this.comboRegional.SelectedValue) ? 0 : this.comboRegional.SelectedIndex)).ToList<spBeneficiarioBuscarCorrespondenciaResult>();
      this.gridCorrespondencia.DataBind();
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

    protected void CheckSeleccionarTodos_CheckedChanged(object sender, EventArgs e)
    {
      foreach (GridViewRow row in this.gridCorrespondencia.Rows)
      {
        if (this.CheckSeleccionarTodos.Checked)
          (row.FindControl("CheckBeneficiario") as CheckBox).Checked = true;
        else
          (row.FindControl("CheckBeneficiario") as CheckBox).Checked = false;
      }
    }

    protected void buttonCancelar_Click(object sender, EventArgs e)
    {
      this.gridCorrespondencia.DataSource = (object) null;
      this.gridCorrespondencia.DataBind();
      this.comboRegional.SelectedValue = "";
      this.comboDepartamento.SelectedValue = "";
      this.comboCiudad.SelectedValue = "";
      this.textNombreBeneficiario.Text = "";
      this.CheckSeleccionarTodos.Checked = false;
    }

    protected void buttonExportar_Click(object sender, EventArgs e) => this.ActualizarGrilla();

    private void ActualizarGrilla()
    {
      List<Correspondencia.strCorrespondencia> strCorrespondenciaList = new List<Correspondencia.strCorrespondencia>();
      foreach (GridViewRow row in this.gridCorrespondencia.Rows)
      {
        if ((row.FindControl("CheckBeneficiario") as CheckBox).Checked)
          strCorrespondenciaList.Add(new Correspondencia.strCorrespondencia()
          {
            tipoDocumento = this.gridCorrespondencia.DataKeys[row.RowIndex].Values[0].ToString(),
            documento = this.gridCorrespondencia.DataKeys[row.RowIndex].Values[1].ToString(),
            nombreBeneficiario = this.gridCorrespondencia.DataKeys[row.RowIndex].Values[2].ToString(),
            departamento = this.gridCorrespondencia.DataKeys[row.RowIndex].Values[3].ToString(),
            municipio = this.gridCorrespondencia.DataKeys[row.RowIndex].Values[4].ToString(),
            correo = this.gridCorrespondencia.DataKeys[row.RowIndex].Values[5].ToString(),
            celular = this.gridCorrespondencia.DataKeys[row.RowIndex].Values[6].ToString(),
            telefono = this.gridCorrespondencia.DataKeys[row.RowIndex].Values[7].ToString()
          });
      }
      this.gridExportar.DataSource = (object) strCorrespondenciaList;
      this.gridExportar.DataBind();
    }

    public class strCorrespondencia
    {
      private string _tipoDocumento;
      private string _documento;
      private string _nombreBeneficiario;
      private string _departamento;
      private string _municipio;
      private string _correo;
      private string _celular;
      private string _telefono;

      public string tipoDocumento
      {
        get => this._tipoDocumento;
        set => this._tipoDocumento = value;
      }

      public string documento
      {
        get => this._documento;
        set => this._documento = value;
      }

      public string nombreBeneficiario
      {
        get => this._nombreBeneficiario;
        set => this._nombreBeneficiario = value;
      }

      public string departamento
      {
        get => this._departamento;
        set => this._departamento = value;
      }

      public string municipio
      {
        get => this._municipio;
        set => this._municipio = value;
      }

      public string correo
      {
        get => this._correo;
        set => this._correo = value;
      }

      public string celular
      {
        get => this._celular;
        set => this._celular = value;
      }

      public string telefono
      {
        get => this._telefono;
        set => this._telefono = value;
      }
    }
  }
}
