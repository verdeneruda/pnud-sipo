// Decompiled with JetBrains decompiler
// Type: UTO.RegistrosUso.ImportadoresConsultas
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

namespace UTO.RegistrosUso
{
  public class ImportadoresConsultas : BaseModulo
  {
    protected ToolkitScriptManager ToolkitScriptManager1;
    protected Label labelConsultas;
    protected Label labelSeleccioneConsultas;
    protected DropDownList comboTipoConsulta;
    protected MultiView multiviewConsulta;
    protected View viewImportadores;
    protected Label labelUsuariosFinales;
    protected Label labelCliente;
    protected DropDownList comboCliente;
    protected Label labelSustancia;
    protected DropDownList comboSustancia;
    protected Label labelDepartamento;
    protected DropDownList comboDepartamento;
    protected Label labelCiudad;
    protected DropDownList comboCiudad;
    protected Label labelAplicacion;
    protected DropDownList comboAplicacion;
    protected Label labelAño;
    protected TextBox textAño;
    protected Button buttonBuscar;
    protected Button buttonExportar;
    protected Button buttonCancelar;
    protected GridView gridconsultasMRegistrosUso;
    protected SqlDataSource importadoresConsultasDataSource;
    protected View viewUsuariosFinales;
    protected Label labelUsuariosFinales2;
    protected Label labelfechaInicio;
    protected TextBox textfechaInicio;
    protected CalendarExtender calendarFechaInicio;
    protected Label labelFechaFinal;
    protected TextBox textFechaFinal;
    protected CalendarExtender calendarFechaFinal;
    protected Label labelDepartamentoUsuario;
    protected DropDownList comboDepartamentoUsuarios;
    protected Label labelCiudadUsarios;
    protected DropDownList comboCiudadUsuario;
    protected Label labelSector;
    protected DropDownList comboSector;
    protected Label labelSustanciaUsuarios;
    protected DropDownList comboSustanciaUsuario;
    protected Button buttonGenerarUsuariosFinales;
    protected Button button1;
    protected Button buttonCancelarUsuariosFinales;
    protected GridView gridConsultaUsuariosFinales;
    protected SqlDataSource importadoresConsultasDataSourceUsuariosFinales;
    protected View viewImportadoresPublico;
    protected Label label1;
    protected Label label4;
    protected DropDownList comboDepartamentoPublico;
    protected Label label5;
    protected DropDownList comboCiudadPublico;
    protected Label label6;
    protected DropDownList comboAplicacionPublico;
    protected Label label7;
    protected TextBox textAñoPublico;
    protected Label label3;
    protected DropDownList comboSustanciaPublico;
    protected Button button2;
    protected Button button3;
    protected Button button4;
    protected GridView gridImportadorPublico;
    protected SqlDataSource SqlDataSourceImportadorPublico;
    protected View viewUsusarioFinalPublico;
    protected Label label2;
    protected Label label8;
    protected TextBox textfechaInicioPublico;
    protected CalendarExtender CalendarExtender1;
    protected Label label9;
    protected TextBox textFechaFinalPublico;
    protected CalendarExtender CalendarExtender2;
    protected Label label10;
    protected DropDownList comboDepartamentoUsuariosPublico;
    protected Label label11;
    protected DropDownList comboCiudadUsuarioPublico;
    protected Label label12;
    protected DropDownList comboSectorPublico;
    protected Label label13;
    protected DropDownList comboSustanciaUsuarioPublico;
    protected Button button5;
    protected Button button6;
    protected Button button7;
    protected GridView gridusuarioPublico;
    protected SqlDataSource SqlDataSourceUsuarioPublico;

    protected new void Page_Load(object sender, EventArgs e)
    {
      if (this.IsPostBack)
        return;
      this.InitData();
    }

    private void InitData()
    {
      this.comboDepartamentoUsuarios.DataSource = (object) CLinq.ListAll<dep_Departamento>((DataContext) this.MyDataContext);
      this.comboDepartamentoUsuarios.DataBind();
      this.comboDepartamentoUsuarios.Items.Insert(0, "");
      this.comboCiudadUsuario.DataSource = (object) CLinq.ListAll<mun_Municipio>((DataContext) this.MyDataContext);
      this.comboCiudadUsuario.DataBind();
      this.comboCiudadUsuario.Items.Insert(0, "");
      this.comboSustanciaUsuario.DataSource = (object) CLinq.ListAll<sus_Sustancia>((DataContext) this.MyDataContext);
      this.comboSustanciaUsuario.DataBind();
      this.comboSustanciaUsuario.Items.Insert(0, "");
      this.comboSector.DataSource = (object) CLinq.ListAll<sec_Sector>((DataContext) this.MyDataContext);
      this.comboSector.DataBind();
      this.comboSector.Items.Insert(0, "");
      this.comboDepartamentoUsuariosPublico.DataSource = (object) CLinq.ListAll<dep_Departamento>((DataContext) this.MyDataContext);
      this.comboDepartamentoUsuariosPublico.DataBind();
      this.comboDepartamentoUsuariosPublico.Items.Insert(0, "");
      this.comboCiudadUsuarioPublico.DataSource = (object) CLinq.ListAll<mun_Municipio>((DataContext) this.MyDataContext);
      this.comboCiudadUsuarioPublico.DataBind();
      this.comboCiudadUsuarioPublico.Items.Insert(0, "");
      this.comboSustanciaUsuarioPublico.DataSource = (object) CLinq.ListAll<sus_Sustancia>((DataContext) this.MyDataContext);
      this.comboSustanciaUsuarioPublico.DataBind();
      this.comboSustanciaUsuarioPublico.Items.Insert(0, "");
      this.comboSectorPublico.DataSource = (object) CLinq.ListAll<sec_Sector>((DataContext) this.MyDataContext);
      this.comboSectorPublico.DataBind();
      this.comboSectorPublico.Items.Insert(0, "");
      this.comboSustancia.DataSource = (object) CLinq.ListAll<sus_Sustancia>((DataContext) this.MyDataContext);
      this.comboSustancia.DataBind();
      this.comboSustancia.Items.Insert(0, "");
      List<ter_Tercero> terTerceroList = new List<ter_Tercero>();
      List<ttt_TerceroTipoTercero> terceroTipoTerceroList = CLinq.ListByProperty<ttt_TerceroTipoTercero>((DataContext) this.MyDataContext, "tti_Id", (object) 2);
      for (int index = 0; index <= terceroTipoTerceroList.Count - 1; ++index)
      {
        ter_Tercero byKey = CLinq.FindByKey<ter_Tercero>((DataContext) this.MyDataContext, (object) terceroTipoTerceroList[index].ter_Id);
        terTerceroList.Add(byKey);
      }
      this.comboCliente.DataSource = (object) terTerceroList;
      this.comboCliente.DataBind();
      this.comboCliente.Items.Insert(0, "");
      this.comboDepartamento.DataSource = (object) CLinq.ListAll<dep_Departamento>((DataContext) this.MyDataContext);
      this.comboDepartamento.DataBind();
      this.comboDepartamento.Items.Insert(0, "");
      this.comboCiudad.DataSource = (object) CLinq.ListAll<mun_Municipio>((DataContext) this.MyDataContext);
      this.comboCiudad.DataBind();
      this.comboCiudad.Items.Insert(0, "");
      this.comboAplicacion.DataSource = (object) CLinq.ListAll<apl_Aplicacion>((DataContext) this.MyDataContext);
      this.comboAplicacion.DataBind();
      this.comboAplicacion.Items.Insert(0, "");
      this.comboDepartamentoPublico.DataSource = (object) CLinq.ListAll<dep_Departamento>((DataContext) this.MyDataContext);
      this.comboDepartamentoPublico.DataBind();
      this.comboDepartamentoPublico.Items.Insert(0, "");
      this.comboCiudadPublico.DataSource = (object) CLinq.ListAll<mun_Municipio>((DataContext) this.MyDataContext);
      this.comboCiudadPublico.DataBind();
      this.comboCiudadPublico.Items.Insert(0, "");
      this.comboAplicacionPublico.DataSource = (object) CLinq.ListAll<apl_Aplicacion>((DataContext) this.MyDataContext);
      this.comboAplicacionPublico.DataBind();
      this.comboAplicacionPublico.Items.Insert(0, "");
      this.comboSustanciaPublico.DataSource = (object) CLinq.ListAll<sus_Sustancia>((DataContext) this.MyDataContext);
      this.comboSustanciaPublico.DataBind();
      this.comboSustanciaPublico.Items.Insert(0, "");
      this.comboTipoConsulta.Items.Add(new ListItem("Seleccionar", "-1"));
      if (!(this.Usuario.login == "publico"))
      {
        this.comboTipoConsulta.Items.Add(new ListItem("Importadores", "0"));
        this.comboTipoConsulta.Items.Add(new ListItem("Usuarios Finales", "1"));
      }
      else
      {
        this.comboTipoConsulta.Items.Add(new ListItem("Importadores", "2"));
        this.comboTipoConsulta.Items.Add(new ListItem("Usuarios Finales", "3"));
      }
    }

    protected void buttonBuscar_Click(object sender, EventArgs e)
    {
      if (this.comboTipoConsulta.SelectedValue.Equals("0"))
        this.gridconsultasMRegistrosUso.Visible = true;
      if (this.comboTipoConsulta.SelectedValue.Equals("1"))
        this.gridConsultaUsuariosFinales.Visible = true;
      if (this.comboTipoConsulta.SelectedValue.Equals("2"))
        this.gridImportadorPublico.Visible = true;
      this.importadoresConsultasDataSource.SelectParameters["idImportador"].DefaultValue = this.comboCliente.SelectedValue != "" ? this.comboCliente.SelectedValue : "0";
      this.importadoresConsultasDataSource.SelectParameters["idSustancia"].DefaultValue = this.comboSustancia.SelectedValue != "" ? this.comboSustancia.SelectedValue : "0";
      this.importadoresConsultasDataSource.SelectParameters["idDepartamento"].DefaultValue = this.comboDepartamento.SelectedValue != "" ? this.comboDepartamento.SelectedValue : "0";
      this.importadoresConsultasDataSource.SelectParameters["idCiudad"].DefaultValue = this.comboCiudad.SelectedValue != "" ? this.comboCiudad.SelectedValue : "0";
      this.importadoresConsultasDataSource.SelectParameters["idAplicacion"].DefaultValue = this.comboAplicacion.SelectedValue != "" ? this.comboAplicacion.SelectedValue : "0";
      this.importadoresConsultasDataSource.SelectParameters["anno"].DefaultValue = this.textAño.Text != "" ? this.textAño.Text : "0";
      this.Session["dv"] = (object) (DataView) this.importadoresConsultasDataSource.Select(DataSourceSelectArguments.Empty);
    }

    protected void buttonGenerarUsuariosFinales_Click(object sender, EventArgs e)
    {
      this.gridConsultaUsuariosFinales.Visible = true;
      this.importadoresConsultasDataSourceUsuariosFinales.SelectParameters["fechaInicio"].DefaultValue = this.textfechaInicio.Text != "" ? this.textfechaInicio.Text : "1/1/1900";
      this.importadoresConsultasDataSourceUsuariosFinales.SelectParameters["fechaFinal"].DefaultValue = this.textFechaFinal.Text != "" ? this.textFechaFinal.Text : "1/1/2111";
      this.importadoresConsultasDataSourceUsuariosFinales.SelectParameters["idDepartamento"].DefaultValue = this.comboDepartamentoUsuarios.SelectedValue != "" ? this.comboDepartamentoUsuarios.SelectedValue : "0";
      this.importadoresConsultasDataSourceUsuariosFinales.SelectParameters["idCiudad"].DefaultValue = this.comboCiudadUsuario.SelectedValue != "" ? this.comboCiudadUsuario.SelectedValue : "0";
      this.importadoresConsultasDataSourceUsuariosFinales.SelectParameters["idSector"].DefaultValue = this.comboSector.SelectedValue != "" ? this.comboSector.SelectedValue : "0";
      this.importadoresConsultasDataSourceUsuariosFinales.SelectParameters["idSustancia"].DefaultValue = this.comboSustanciaUsuario.SelectedValue != "" ? this.comboSustanciaUsuario.SelectedValue : "0";
      this.Session["dv"] = (object) (DataView) this.importadoresConsultasDataSourceUsuariosFinales.Select(DataSourceSelectArguments.Empty);
    }

    protected void comboTipoConsulta_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.comboTipoConsulta.SelectedValue.Equals("-1"))
      {
        this.multiviewConsulta.Visible = false;
        this.gridconsultasMRegistrosUso.Visible = false;
        this.gridConsultaUsuariosFinales.Visible = false;
      }
      if (this.comboTipoConsulta.SelectedValue.Equals("0"))
      {
        this.multiviewConsulta.Visible = true;
        this.multiviewConsulta.SetActiveView(this.viewImportadores);
        this.gridconsultasMRegistrosUso.Visible = false;
        this.gridConsultaUsuariosFinales.Visible = false;
        this.gridusuarioPublico.Visible = false;
        this.gridImportadorPublico.Visible = false;
      }
      if (this.comboTipoConsulta.SelectedValue.Equals("1"))
      {
        this.multiviewConsulta.Visible = true;
        this.multiviewConsulta.SetActiveView(this.viewUsuariosFinales);
        this.gridconsultasMRegistrosUso.Visible = false;
        this.gridConsultaUsuariosFinales.Visible = false;
        this.gridImportadorPublico.Visible = false;
        this.gridusuarioPublico.Visible = false;
      }
      if (this.comboTipoConsulta.SelectedValue.Equals("2"))
      {
        this.multiviewConsulta.Visible = true;
        this.multiviewConsulta.SetActiveView(this.viewImportadoresPublico);
        this.gridconsultasMRegistrosUso.Visible = false;
        this.gridConsultaUsuariosFinales.Visible = false;
        this.gridImportadorPublico.Visible = false;
        this.gridusuarioPublico.Visible = false;
      }
      if (!this.comboTipoConsulta.SelectedValue.Equals("3"))
        return;
      this.multiviewConsulta.Visible = true;
      this.multiviewConsulta.SetActiveView(this.viewUsusarioFinalPublico);
      this.gridconsultasMRegistrosUso.Visible = false;
      this.gridConsultaUsuariosFinales.Visible = false;
      this.gridImportadorPublico.Visible = false;
      this.gridusuarioPublico.Visible = false;
    }

    protected void buttonExportar_Click(object sender, EventArgs e)
    {
      this.ExportarDv((DataView) this.Session["dv"]);
      this.Session.Remove("dv");
    }

    protected void button1_Click(object sender, EventArgs e)
    {
      this.ExportarDv((DataView) this.Session["dv"]);
      this.Session.Remove("dv");
    }

    protected void button2_Click(object sender, EventArgs e)
    {
      this.gridImportadorPublico.Visible = true;
      this.SqlDataSourceImportadorPublico.SelectParameters["idSustancia"].DefaultValue = this.comboSustanciaPublico.SelectedValue != "" ? this.comboSustancia.SelectedValue : "0";
      this.SqlDataSourceImportadorPublico.SelectParameters["idDepartamento"].DefaultValue = this.comboDepartamentoPublico.SelectedValue != "" ? this.comboDepartamento.SelectedValue : "0";
      this.SqlDataSourceImportadorPublico.SelectParameters["idCiudad"].DefaultValue = this.comboCiudadPublico.SelectedValue != "" ? this.comboCiudad.SelectedValue : "0";
      this.SqlDataSourceImportadorPublico.SelectParameters["idAplicacion"].DefaultValue = this.comboAplicacionPublico.SelectedValue != "" ? this.comboAplicacion.SelectedValue : "0";
      this.SqlDataSourceImportadorPublico.SelectParameters["anno"].DefaultValue = this.textAñoPublico.Text != "" ? this.textAño.Text : "0";
      this.Session["dv"] = (object) (DataView) this.SqlDataSourceImportadorPublico.Select(DataSourceSelectArguments.Empty);
    }

    protected void button5_Click(object sender, EventArgs e)
    {
      this.gridusuarioPublico.Visible = true;
      this.SqlDataSourceUsuarioPublico.SelectParameters["fechaInicio"].DefaultValue = this.textfechaInicioPublico.Text != "" ? this.textfechaInicio.Text : "1/1/1900";
      this.SqlDataSourceUsuarioPublico.SelectParameters["fechaFinal"].DefaultValue = this.textFechaFinalPublico.Text != "" ? this.textFechaFinal.Text : "1/1/2111";
      this.SqlDataSourceUsuarioPublico.SelectParameters["idDepartamento"].DefaultValue = this.comboDepartamentoUsuariosPublico.SelectedValue != "" ? this.comboDepartamentoUsuarios.SelectedValue : "0";
      this.SqlDataSourceUsuarioPublico.SelectParameters["idCiudad"].DefaultValue = this.comboCiudadUsuarioPublico.SelectedValue != "" ? this.comboCiudadUsuario.SelectedValue : "0";
      this.SqlDataSourceUsuarioPublico.SelectParameters["idSector"].DefaultValue = this.comboSectorPublico.SelectedValue != "" ? this.comboSector.SelectedValue : "0";
      this.SqlDataSourceUsuarioPublico.SelectParameters["idSustancia"].DefaultValue = this.comboSustanciaUsuarioPublico.SelectedValue != "" ? this.comboSustanciaUsuario.SelectedValue : "0";
      this.Session["dv"] = (object) (DataView) this.SqlDataSourceUsuarioPublico.Select(DataSourceSelectArguments.Empty);
    }
  }
}
