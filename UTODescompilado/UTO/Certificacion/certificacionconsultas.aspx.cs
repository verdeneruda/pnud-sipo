// Decompiled with JetBrains decompiler
// Type: UTO.Certificacion.certificacionconsultas
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using AjaxControlToolkit;
using NE.CLib.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UTO.Certificacion
{
  public class certificacionconsultas : BaseModulo
  {
    protected Label labelConsultas;
    protected ToolkitScriptManager ToolkitScriptManager1;
    protected Label labelTecnicos;
    protected Label LabelDepartamento;
    protected DropDownList comboDepartamentos;
    protected Label LabelCiudad;
    protected DropDownList comboCiudad;
    protected Label LabelCTG;
    protected DropDownList comboCTG;
    protected Label LabelAreaTrabajo;
    protected DropDownList comboAreaTrabajo;
    protected Label LabelEmpresa;
    protected DropDownList comboEmpresa;
    protected Button buttonBuscar;
    protected Button buttonExportar;
    protected Button buttonCancelar;
    protected GridView gridconsultasCertificacion;
    protected SqlDataSource certificacionConsultasDataSource;

    protected void Page_Load(object sender, EventArgs e)
    {
      if (this.IsPostBack)
        return;
      this.InitData();
    }

    private void InitData()
    {
      this.comboAreaTrabajo.DataSource = (object) CLinq.ListAll<atr_AreaTrabajo>((DataContext) this.MyDataContext);
      this.comboAreaTrabajo.DataBind();
      this.comboAreaTrabajo.Items.Insert(0, "");
      new char[1][0] = "T"[0];
      CLinq.ListAll<cat_Categoria>((DataContext) this.MyDataContext);
      List<cat_Categoria> catCategoriaList = new List<cat_Categoria>();
      this.comboCTG.DataSource = (object) CLinq.ListByProperty<cat_Categoria>((DataContext) this.MyDataContext, "cat_Tipo", (object) "T"[0]);
      this.comboCTG.DataBind();
      this.comboCTG.Items.Insert(0, "");
      this.comboDepartamentos.DataSource = (object) CLinq.ListAll<dep_Departamento>((DataContext) this.MyDataContext);
      this.comboDepartamentos.DataBind();
      this.comboDepartamentos.Items.Insert(0, "");
      List<ter_Tercero> terTerceroList = new List<ter_Tercero>();
      List<ttt_TerceroTipoTercero> terceroTipoTerceroList = CLinq.ListByProperty<ttt_TerceroTipoTercero>((DataContext) this.MyDataContext, "tti_Id", (object) 10);
      for (int index = 0; index <= terceroTipoTerceroList.Count - 1; ++index)
      {
        ter_Tercero byKey = CLinq.FindByKey<ter_Tercero>((DataContext) this.MyDataContext, (object) terceroTipoTerceroList[index].ter_Id);
        terTerceroList.Add(byKey);
      }
      this.comboEmpresa.DataSource = (object) terTerceroList;
      this.comboEmpresa.DataBind();
      this.comboEmpresa.Items.Insert(0, "");
    }

    protected void buttonBuscar_Click(object sender, EventArgs e)
    {
      this.gridconsultasCertificacion.Visible = true;
      this.gridconsultasCertificacion.DataSourceID = "certificacionConsultasDataSource";
      this.certificacionConsultasDataSource.SelectParameters["idDepartamento"].DefaultValue = this.comboDepartamentos.SelectedValue != "" ? this.comboDepartamentos.SelectedValue : "0";
      this.certificacionConsultasDataSource.SelectParameters["IdMunicipio"].DefaultValue = this.comboCiudad.SelectedValue != "" ? this.comboCiudad.SelectedValue : "0";
      this.certificacionConsultasDataSource.SelectParameters["idCategoria"].DefaultValue = this.comboCTG.SelectedValue != "" ? this.comboCTG.SelectedValue : "0";
      this.certificacionConsultasDataSource.SelectParameters["idArea"].DefaultValue = this.comboAreaTrabajo.SelectedValue != "" ? this.comboAreaTrabajo.SelectedValue : "0";
      this.certificacionConsultasDataSource.SelectParameters["idEmpresa"].DefaultValue = this.comboEmpresa.SelectedValue != "" ? this.comboEmpresa.SelectedValue : "0";
      this.Session["dv"] = (object) (DataView) this.certificacionConsultasDataSource.Select(DataSourceSelectArguments.Empty);
    }

    protected void comboDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.comboCiudad.DataSource = (object) CLinq.ListByProperty<mun_Municipio>((DataContext) this.MyDataContext, "dep_id", (object) this.comboDepartamentos.SelectedValue);
      this.comboCiudad.DataBind();
      this.comboCiudad.Items.Insert(0, "");
    }

    protected void buttonExportar_Click(object sender, EventArgs e)
    {
      this.ExportarDv((DataView) this.Session["dv"]);
      this.Session.Remove("dv");
    }

    protected void buttonCancelar_Click(object sender, EventArgs e)
    {
      this.comboAreaTrabajo.Text = "";
      this.comboCiudad.Text = "";
      this.comboCTG.Text = "";
      this.comboDepartamentos.Text = "";
      this.comboEmpresa.Text = "";
      this.gridconsultasCertificacion.DataSourceID = (string) null;
    }
  }
}
