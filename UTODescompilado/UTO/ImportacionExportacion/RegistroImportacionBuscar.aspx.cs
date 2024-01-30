// Decompiled with JetBrains decompiler
// Type: UTO.ImportacionExportacion.RegistroImportacionBuscar
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using AjaxControlToolkit;
using NE.CLib;
using NE.CLib.Linq;
using Seguridad.Servicio;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UTO.ImportacionExportacion
{
  public class RegistroImportacionBuscar : BaseModulo
  {
    protected ToolkitScriptManager ToolkitScriptManager1;
    protected XmlDataSource xmlRegistroImportador;
    protected XmlDataSource XmlImportadores;
    protected XmlDataSource XmlSustancia;
    protected XmlDataSource XmlPaises;
    protected Label labelBusquedaCertificaciones;
    protected ControlError ControlError1;
    protected Label labelparametros;
    protected RadioButton RadioSustancia;
    protected RadioButton RadioEquipos;
    protected Label labelLicenciaImportacion;
    protected TextBox textLicenciaImportacion;
    protected Label labelImportador;
    protected TextBox textImportador;
    protected Label labelfechaLicenciaInicial;
    protected TextBox textFechaInicial;
    protected CalendarExtender calendarfecha;
    protected Label labelfechaLicenciaFinal;
    protected TextBox textFechaFinal;
    protected CalendarExtender CalendarExtender1;
    protected Label labelSustancia;
    protected DropDownList comboSustancia;
    protected Button buttonBuscar;
    protected Button buttonAdicionar;
    protected GridView gridBuscarRegistroImportadores;
    protected SqlDataSource registroImportacionBuscarDataSource;

    protected new void Page_Load(object sender, EventArgs e)
    {
      this.ControlError1.Hide();
      if (this.IsPostBack)
        return;
      this.buttonBuscar.Enabled = this.Usuario.permiteOperacion(EPermiso.BuscarRegistroImportacion);
      this.buttonAdicionar.Enabled = this.Usuario.permiteOperacion(EPermiso.AdicionarRegistroImportacion);
      this.gridBuscarRegistroImportadores.Columns[0].Visible = this.Usuario.permiteOperacion(EPermiso.BuscarRegistroImportacion);
      this.gridBuscarRegistroImportadores.Columns[1].Visible = this.Usuario.permiteOperacion(EPermiso.ModificarRegistroImportacion);
      this.gridBuscarRegistroImportadores.Columns[2].Visible = this.Usuario.permiteOperacion(EPermiso.EliminarRegistroImportacion);
      this.InitData();
    }

    public void InitData()
    {
      this.comboSustancia.DataSource = (object) CLinq.ListAll<sus_Sustancia>((DataContext) this.MyDataContext);
      this.comboSustancia.DataBind();
      this.comboSustancia.Items.Insert(0, "");
    }

    protected void buttonAdicionar_Click(object sender, EventArgs e)
    {
      this.SendParams = (object) new BaseModulo.strSendParam()
      {
        id = 0,
        tipo = ""
      };
      this.Server.Transfer("~/ImportacionExportacion/RegistroImportacionRegistrar.aspx");
    }

    protected void buttonBuscar_Click(object sender, EventArgs e)
    {
      try
      {
        string str;
        if (this.RadioSustancia.Checked)
        {
          str = "SUSTANCIA";
        }
        else
        {
          if (!this.RadioEquipos.Checked)
            throw new Exception("Tiene que seleccionar si desea buscar por sustancias o equipos");
          str = "EQUIPO";
        }
        DateTime date1 = DateTime.Parse("1/1/1900");
        DateTime date2 = DateTime.Parse("1/1/2111");
        if (this.textFechaInicial.Text != "")
          CValidator.isDate(this.textFechaInicial.Text, ref date1);
        if (this.textFechaFinal.Text != "")
          CValidator.isDate(this.textFechaFinal.Text, ref date2);
        this.registroImportacionBuscarDataSource.SelectParameters["licencia"].DefaultValue = this.textLicenciaImportacion.Text != "" ? this.textLicenciaImportacion.Text : "%";
        this.registroImportacionBuscarDataSource.SelectParameters["importador"].DefaultValue = this.textImportador.Text != "" ? this.textImportador.Text : "%";
        this.registroImportacionBuscarDataSource.SelectParameters["fechaInicial"].DefaultValue = date1.ToString("yyyy/MM/dd");
        this.registroImportacionBuscarDataSource.SelectParameters["fechaFinal"].DefaultValue = date2.ToString("yyyy/MM/dd");
        this.registroImportacionBuscarDataSource.SelectParameters["sustancia"].DefaultValue = this.comboSustancia.SelectedValue != "" ? this.comboSustancia.SelectedValue : "0";
        this.registroImportacionBuscarDataSource.SelectParameters["tipo"].DefaultValue = str;
      }
      catch (Exception ex)
      {
        this.ControlError1.Visible = true;
        this.ControlError1.Show(ex);
      }
    }

    protected void RadioSustancia_CheckedChanged(object sender, EventArgs e)
    {
      if (this.RadioSustancia.Checked)
      {
        this.labelSustancia.Visible = true;
        this.comboSustancia.Visible = true;
      }
      else
      {
        this.labelSustancia.Visible = false;
        this.comboSustancia.Visible = false;
      }
    }

    protected void RadioEquipos_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.RadioEquipos.Checked)
        return;
      this.labelSustancia.Visible = false;
      this.comboSustancia.Visible = false;
    }

    protected void gridBuscarRegistroImportadores_RowCommand(
      object sender,
      GridViewCommandEventArgs e)
    {
      if (e.CommandName.Equals("Modificar"))
      {
        this.SendParams = (object) new BaseModulo.strSendParam()
        {
          id = int.Parse(this.gridBuscarRegistroImportadores.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString()),
          tipo = "Modificar"
        };
        this.Server.Transfer("~/ImportacionExportacion/RegistroImportacionRegistrar.aspx");
      }
      if (e.CommandName.Equals("Ver"))
      {
        this.SendParams = (object) new BaseModulo.strSendParam()
        {
          id = int.Parse(this.gridBuscarRegistroImportadores.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString()),
          tipo = "Ver"
        };
        this.Server.Transfer("~/ImportacionExportacion/RegistroImportacionRegistrar.aspx");
      }
      if (!e.CommandName.Equals("Eliminar"))
        return;
      try
      {
        int pageIndex = this.gridBuscarRegistroImportadores.PageIndex;
        int pageSize = this.gridBuscarRegistroImportadores.PageSize;
        int num = int.Parse(this.gridBuscarRegistroImportadores.DataKeys[int.Parse((string) e.CommandArgument) - pageIndex * pageSize].Value.ToString());
        List<rie_RegistroImportacionEquipo> importacionEquipoList = CLinq.ListByProperty<rie_RegistroImportacionEquipo>((DataContext) this.MyDataContext, "rim_Id", (object) num);
        for (int index = 0; index <= importacionEquipoList.Count - 1; ++index)
          this.MyDataContext.rie_RegistroImportacionEquipos.DeleteOnSubmit(importacionEquipoList[index]);
        List<ris_RegistroImportacionSustancia> importacionSustanciaList = CLinq.ListByProperty<ris_RegistroImportacionSustancia>((DataContext) this.MyDataContext, "rim_Id", (object) num);
        for (int index = 0; index <= importacionSustanciaList.Count - 1; ++index)
          this.MyDataContext.ris_RegistroImportacionSustancias.DeleteOnSubmit(importacionSustanciaList[index]);
        this.MyDataContext.rim_RegistroImportacions.DeleteOnSubmit(CLinq.FindByKey<rim_RegistroImportacion>((DataContext) this.MyDataContext, (object) num));
        this.MyDataContext.SubmitChanges();
        this.gridBuscarRegistroImportadores.DataSource = (object) null;
        this.gridBuscarRegistroImportadores.DataBind();
        foreach (DataControlField column in (StateManagedCollection) this.gridBuscarRegistroImportadores.Columns)
        {
          if (column.HeaderText == "Id")
            column.Visible = false;
        }
        CAuditoria.log(EPermiso.EliminarRegistroImportacion, num.ToString(), "", "", "", "", this.Usuario.id);
      }
      catch (Exception ex)
      {
        this.ControlError1.Visible = true;
        this.ControlError1.Show(ex);
      }
    }
  }
}
