// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.AprobarNovedadEquiposBuscar
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
  public class AprobarNovedadEquiposBuscar : BaseModulo
  {
    protected ToolkitScriptManager ToolkitScriptManager1;
    protected Label labelNovedadEquiposBuscar;
    protected Label labelparametros;
    protected Label labelDepartamento;
    protected DropDownList comboDepartamento;
    protected Label labelCiudad;
    protected DropDownList comboCiudad;
    protected Label labelRegional;
    protected DropDownList comboRegional;
    protected Label labelNombreBeneficiario;
    protected TextBox textNombreBeneficiario;
    protected Label labelFechaInicial;
    protected TextBox textFechaInicial;
    protected CalendarExtender calendarfecha;
    protected Label label1;
    protected TextBox textFechaFinal;
    protected CalendarExtender CalendarExtender1;
    protected Label labelTipoNovedad;
    protected DropDownList comboTipoNovedad;
    protected Label label2;
    protected TextBox textComodato;
    protected Button buttonBuscar;
    protected GridView gridBuscarNovedadesEquipos;
    protected SqlDataSource aprobarNovedadEquiposBuscarDataSource;

    protected new void Page_Load(object sender, EventArgs e)
    {
      if (this.IsPostBack)
        return;
      this.InitData();
    }

    public void InitData()
    {
      this.comboDepartamento.DataSource = (object) CLinq.ListAll<dep_Departamento>((DataContext) this.MyDataContext);
      this.comboDepartamento.DataBind();
      this.comboDepartamento.Items.Insert(0, "");
      this.comboRegional.DataSource = (object) CLinq.ListAll<reg_Regional>((DataContext) this.MyDataContext);
      this.comboRegional.DataBind();
      this.comboRegional.Items.Insert(0, "");
      this.comboTipoNovedad.DataSource = (object) CLinq.ListAll<nti_NovedadTipo>((DataContext) this.MyDataContext);
      this.comboTipoNovedad.DataBind();
      this.comboTipoNovedad.Items.Insert(0, "");
    }

    protected void buttonBuscar_Click(object sender, EventArgs e)
    {
      this.aprobarNovedadEquiposBuscarDataSource.SelectParameters["departamento"].DefaultValue = this.comboDepartamento.SelectedValue != "" ? this.comboDepartamento.SelectedValue : "0";
      this.aprobarNovedadEquiposBuscarDataSource.SelectParameters["municipio"].DefaultValue = this.comboCiudad.SelectedValue != "" ? this.comboCiudad.SelectedValue : "0";
      this.aprobarNovedadEquiposBuscarDataSource.SelectParameters["regional"].DefaultValue = this.comboRegional.SelectedValue != "" ? this.comboRegional.SelectedValue : "0";
      this.aprobarNovedadEquiposBuscarDataSource.SelectParameters["beneficiario"].DefaultValue = this.textNombreBeneficiario.Text != "" ? this.textNombreBeneficiario.Text : "%";
      this.aprobarNovedadEquiposBuscarDataSource.SelectParameters["fechaInicial"].DefaultValue = this.textFechaInicial.Text != "" ? this.textFechaInicial.Text : "1/1/1900";
      this.aprobarNovedadEquiposBuscarDataSource.SelectParameters["fechaFinal"].DefaultValue = this.textFechaFinal.Text != "" ? this.textFechaFinal.Text : "1/1/2111";
      this.aprobarNovedadEquiposBuscarDataSource.SelectParameters["tipoNovedad"].DefaultValue = this.comboTipoNovedad.SelectedValue != "" ? this.comboTipoNovedad.SelectedValue : "0";
      this.aprobarNovedadEquiposBuscarDataSource.SelectParameters["comodato"].DefaultValue = this.textComodato.Text != "" ? this.textComodato.Text : "%";
    }

    protected void buttonAdicionar_Click(object sender, EventArgs e)
    {
      this.SendParams = (object) new BaseModulo.strSendParam()
      {
        id = 0,
        tipo = ""
      };
      this.Response.Redirect("~/Recuperacion/AprobarNovedadEquiposRegistrar.aspx");
    }

    protected void gridBuscarNovedadesEquipos_RowCommand(object sender, GridViewCommandEventArgs e)
    {
      if (e.CommandName.Equals("Modificar"))
      {
        this.SendParams = (object) new BaseModulo.strSendParam()
        {
          id = int.Parse(this.gridBuscarNovedadesEquipos.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString()),
          tipo = "Modificar"
        };
        this.Server.Transfer("~/Recuperacion/AprobarNovedadEquiposRegistrar.aspx");
      }
      if (!e.CommandName.Equals("Ver"))
        return;
      this.SendParams = (object) new BaseModulo.strSendParam()
      {
        id = int.Parse(this.gridBuscarNovedadesEquipos.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString()),
        tipo = "Ver"
      };
      this.Server.Transfer("~/Recuperacion/AprobarNovedadEquiposRegistrar.aspx");
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

    protected void comboDepartamento_SelectedIndexChanged1(object sender, EventArgs e) => this.listarMunicipio(this.comboDepartamento.SelectedValue);
  }
}
