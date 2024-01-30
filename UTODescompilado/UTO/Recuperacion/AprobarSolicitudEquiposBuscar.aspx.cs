﻿// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.AprobarSolicitudEquiposBuscar
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using AjaxControlToolkit;
using NE.CLib.Linq;
using Seguridad.Servicio;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace UTO.Recuperacion
{
  public class AprobarSolicitudEquiposBuscar : BaseModulo
  {
    protected ToolkitScriptManager ToolkitScriptManager1;
    protected Label labelBusquedaSolicitudesEquipos;
    protected ControlError ControlError1;
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
    protected Label label2;
    protected DropDownList comboEstado;
    protected Label label3;
    protected DropDownList comboTipo;
    protected HtmlTableRow proyecto;
    protected Label label4;
    protected DropDownList comboProyecto;
    protected Button buttonBuscar;
    protected GridView gridBuscarSolicitudEquipos;
    protected SqlDataSource aprobarSolicitudEquiposBuscarDataSource;

    private int proyectoId
    {
      get => Convert.ToInt32(this.ViewState["SolicitudEquipo.Tipo"] ?? (object) 0);
      set => this.ViewState["SolicitudEquipo.Tipo"] = (object) value;
    }

    protected new void Page_Load(object sender, EventArgs e)
    {
      if (this.IsPostBack)
        return;
      this.proyectoId = this.Request.QueryString["tipo"] == null ? 1 : Convert.ToInt32(this.Request.QueryString["tipo"]);
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
      this.comboEstado.DataSource = (object) CLinq.ListAll<ses_SolicitudEstado>((DataContext) this.MyDataContext);
      this.comboEstado.DataBind();
      this.comboEstado.Items.Insert(0, "");
      if (this.proyectoId == 1)
      {
        this.proyecto.Style["display"] = "none";
      }
      else
      {
        this.proyecto.Style["display"] = "";
        List<pre_ProyectoRecuperacion> proyectoRecuperacionList1 = CLinq.ListAll<pre_ProyectoRecuperacion>((DataContext) this.MyDataContext);
        List<pre_ProyectoRecuperacion> proyectoRecuperacionList2 = new List<pre_ProyectoRecuperacion>();
        for (int index = 0; index < proyectoRecuperacionList1.Count; ++index)
        {
          if (proyectoRecuperacionList1[index].pre_Id != 1)
            proyectoRecuperacionList2.Add(proyectoRecuperacionList1[index]);
        }
        this.comboProyecto.DataSource = (object) proyectoRecuperacionList2;
        this.comboProyecto.DataBind();
        this.comboProyecto.Items.Insert(0, "");
      }
    }

    protected void buttonBuscar_Click(object sender, EventArgs e)
    {
      this.aprobarSolicitudEquiposBuscarDataSource.SelectParameters["departamento"].DefaultValue = this.comboDepartamento.SelectedValue != "" ? this.comboDepartamento.SelectedValue : "0";
      this.aprobarSolicitudEquiposBuscarDataSource.SelectParameters["municipio"].DefaultValue = this.comboCiudad.SelectedValue != "" ? this.comboCiudad.SelectedValue : "0";
      this.aprobarSolicitudEquiposBuscarDataSource.SelectParameters["regional"].DefaultValue = this.comboRegional.SelectedValue != "" ? this.comboRegional.SelectedValue : "0";
      this.aprobarSolicitudEquiposBuscarDataSource.SelectParameters["beneficiario"].DefaultValue = this.textNombreBeneficiario.Text != "" ? this.textNombreBeneficiario.Text : "%";
      this.aprobarSolicitudEquiposBuscarDataSource.SelectParameters["fechaInicial"].DefaultValue = this.textFechaInicial.Text != "" ? this.textFechaInicial.Text : "1/1/1900";
      this.aprobarSolicitudEquiposBuscarDataSource.SelectParameters["fechaFinal"].DefaultValue = this.textFechaFinal.Text != "" ? this.textFechaFinal.Text : "1/1/2111";
      this.aprobarSolicitudEquiposBuscarDataSource.SelectParameters["estado"].DefaultValue = this.comboEstado.SelectedValue != "" ? this.comboEstado.SelectedValue : "0";
      this.aprobarSolicitudEquiposBuscarDataSource.SelectParameters["tipo"].DefaultValue = this.comboTipo.SelectedValue;
      this.aprobarSolicitudEquiposBuscarDataSource.SelectParameters["proyecto"].DefaultValue = this.proyectoId.ToString();
    }

    protected void buttonAdicionar_Click(object sender, EventArgs e) => this.Server.Transfer("~/Recuperacion/AprobarSolicitudEquiposRegistrar.aspx");

    protected void gridBuscarSolicitudEquipos_RowCommand(object sender, GridViewRowEventArgs e)
    {
    }

    protected void gridBuscarSolicitudEquipos_RowCommand(object sender, GridViewCommandEventArgs e)
    {
      if (e.CommandName.Equals("Modificar"))
      {
        this.SendParams = (object) new BaseModulo.strSendParam()
        {
          id = int.Parse(this.gridBuscarSolicitudEquipos.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString()),
          tipo = "Modificar"
        };
        this.Server.Transfer("~/Recuperacion/AprobarSolicitudEquiposRegistrar.aspx");
      }
      if (e.CommandName.Equals("Ver"))
      {
        this.SendParams = (object) new BaseModulo.strSendParam()
        {
          id = int.Parse(this.gridBuscarSolicitudEquipos.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString()),
          tipo = "Ver"
        };
        this.Server.Transfer("~/Recuperacion/AprobarSolicitudEquiposRegistrar.aspx");
      }
      if (!e.CommandName.Equals("Eliminar"))
        return;
      int num = int.Parse(this.gridBuscarSolicitudEquipos.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString());
      List<dvs_DocumentoVerificarSolicitud> verificarSolicitudList = CLinq.ListByProperty<dvs_DocumentoVerificarSolicitud>((DataContext) this.MyDataContext, "seq_Id", (object) num);
      for (int index = 0; index <= verificarSolicitudList.Count - 1; ++index)
        this.MyDataContext.dvs_DocumentoVerificarSolicituds.DeleteOnSubmit(verificarSolicitudList[index]);
      List<sdo_SolicitudDocumento> solicitudDocumentoList = CLinq.ListByProperty<sdo_SolicitudDocumento>((DataContext) this.MyDataContext, "seq_Id", (object) num);
      for (int index = 0; index <= solicitudDocumentoList.Count - 1; ++index)
        this.MyDataContext.sdo_SolicitudDocumentos.DeleteOnSubmit(solicitudDocumentoList[index]);
      List<sea_SolicitudEquiposAsignado> solicitudEquiposAsignadoList = CLinq.ListByProperty<sea_SolicitudEquiposAsignado>((DataContext) this.MyDataContext, "seq_id", (object) num);
      for (int index = 0; index <= solicitudEquiposAsignadoList.Count - 1; ++index)
        this.MyDataContext.sea_SolicitudEquiposAsignados.DeleteOnSubmit(solicitudEquiposAsignadoList[index]);
      seq_SolicitudEquipo byKey = CLinq.FindByKey<seq_SolicitudEquipo>((DataContext) this.MyDataContext, (object) num);
      try
      {
        if (byKey.ses_Id == 6)
          throw new Exception("" + "No puede eliminar esta solicitud porque ya está aprobada. <br />");
        this.MyDataContext.seq_SolicitudEquipos.DeleteOnSubmit(byKey);
        this.MyDataContext.SubmitChanges();
        this.gridBuscarSolicitudEquipos.DataSource = (object) null;
        this.gridBuscarSolicitudEquipos.DataBind();
        foreach (DataControlField column in (StateManagedCollection) this.gridBuscarSolicitudEquipos.Columns)
        {
          if (column.HeaderText == "Id")
            column.Visible = false;
        }
        CAuditoria.log(EPermiso.EliminarSolicitudEquipos, num.ToString(), "", "", "", "", this.Usuario.id);
      }
      catch (Exception ex)
      {
        this.ControlError1.Visible = true;
        this.ControlError1.Show(ex);
      }
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

    protected void comboProyecto_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.comboProyecto.SelectedIndex <= -1 || !(this.comboProyecto.Text != ""))
        return;
      this.proyectoId = Convert.ToInt32(this.comboProyecto.SelectedValue);
    }
  }
}
