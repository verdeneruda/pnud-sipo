// Decompiled with JetBrains decompiler
// Type: UTO.ImportacionExportacion.RegistroExportacionBuscar
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
using UTO.ImportacionExportacion;


//namespace UTO.ImportacionExportacion
//{
public partial class ImportacionExportacion_RegistroExportacionBuscar : BaseModulo
  {
    //protected ToolkitScriptManager ToolkitScriptManager1;
    //protected Label labelBusquedaCertificaciones;
    //protected ControlError ControlError1;
    //protected Label labelparametros;
    //protected Label labelLicenciaExportacion;
    //protected TextBox textLicenciaExportacion;
    //protected Label labelExportador;
    //protected TextBox textExportador;
    //protected Label labelfechaLicenciaInicial;
    //protected TextBox textFechaInicial;
    //protected CalendarExtender calendarfecha;
    //protected Label labelfechaLicenciaFinal;
    //protected TextBox textFechaFinal;
    //protected CalendarExtender CalendarExtender1;
    //protected Label labelOrigen;
    //protected DropDownList comboOrigen;
    //protected Label labelSustancia;
    //protected DropDownList comboSustancia;
    //protected Button buttonBuscar;
    //protected Button buttonAdicionar;
    //protected GridView gridBuscarRegistroExportadores;
    //protected SqlDataSource registroExportacionBuscarDataSource;

    protected new void Page_Load(object sender, EventArgs e)
    {
      this.ControlError1.Hide();
      if (this.IsPostBack)
        return;
      this.buttonBuscar.Enabled = this.Usuario.permiteOperacion(EPermiso.BuscarRegistroDeExportacion);
      this.buttonAdicionar.Enabled = this.Usuario.permiteOperacion(EPermiso.AdicionarRegistroDeExportacion);
      this.gridBuscarRegistroExportadores.Columns[0].Visible = this.Usuario.permiteOperacion(EPermiso.BuscarRegistroDeExportacion);
      this.gridBuscarRegistroExportadores.Columns[1].Visible = this.Usuario.permiteOperacion(EPermiso.ModificarRegistroDeExportacion);
      this.gridBuscarRegistroExportadores.Columns[2].Visible = this.Usuario.permiteOperacion(EPermiso.EliminarRegistroDeExportacion);
      this.InitData();
    }

    public void InitData()
    {
      this.comboOrigen.DataSource = (object) CLinq.ListAll<pas_Pai>((DataContext) this.MyDataContext);
      this.comboOrigen.DataBind();
      this.comboOrigen.Items.Insert(0, "");
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
      this.Server.Transfer("~/ImportacionExportacion/RegistroExportacionRegistrar.aspx");
    }

    protected void buttonBuscar_Click(object sender, EventArgs e)
    {
      DateTime date1 = DateTime.Parse("1900-01-01");
      DateTime date2 = DateTime.Parse("2111-01-01");
      if (this.textFechaInicial.Text != "")
        CValidator.isDate(this.textFechaInicial.Text, ref date1);
      if (this.textFechaFinal.Text != "")
        CValidator.isDate(this.textFechaFinal.Text, ref date2);
      this.registroExportacionBuscarDataSource.SelectParameters["licencia"].DefaultValue = this.textLicenciaExportacion.Text != "" ? this.textLicenciaExportacion.Text : "%";
      this.registroExportacionBuscarDataSource.SelectParameters["importador"].DefaultValue = this.textExportador.Text != "" ? this.textExportador.Text : "%";
      this.registroExportacionBuscarDataSource.SelectParameters["fechaInicial"].DefaultValue = date1.ToString("yyyy/MM/dd");
      this.registroExportacionBuscarDataSource.SelectParameters["fechaFinal"].DefaultValue = date2.ToString("yyyy/MM/dd");
      this.registroExportacionBuscarDataSource.SelectParameters["sustancia"].DefaultValue = this.comboSustancia.SelectedValue != "" ? this.comboSustancia.SelectedValue : "0";
      this.registroExportacionBuscarDataSource.SelectParameters["pais"].DefaultValue = this.comboOrigen.SelectedValue != "" ? this.comboOrigen.SelectedValue : "0";
      foreach (DataControlField column in (StateManagedCollection) this.gridBuscarRegistroExportadores.Columns)
      {
        if (column.HeaderText == "Id")
          column.Visible = false;
      }
    }

    protected void textImportador_TextChanged(object sender, EventArgs e)
    {
    }

    protected void gridBuscarRegistroExportadores_RowCommand(
      object sender,
      GridViewCommandEventArgs e)
    {
      if (e.CommandName.Equals("Modificar"))
      {
        this.SendParams = (object) new BaseModulo.strSendParam()
        {
          id = int.Parse(this.gridBuscarRegistroExportadores.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString()),
          tipo = "Modificar"
        };
        this.Server.Transfer("~/ImportacionExportacion/RegistroExportacionRegistrar.aspx");
      }
      if (e.CommandName.Equals("Ver"))
      {
        this.SendParams = (object) new BaseModulo.strSendParam()
        {
          id = int.Parse(this.gridBuscarRegistroExportadores.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString()),
          tipo = "Ver"
        };
        this.Server.Transfer("~/ImportacionExportacion/RegistroExportacionRegistrar.aspx");
      }
      if (!e.CommandName.Equals("Eliminar"))
        return;
      try
      {
        int pageIndex = this.gridBuscarRegistroExportadores.PageIndex;
        int pageSize = this.gridBuscarRegistroExportadores.PageSize;
        int num = int.Parse(this.gridBuscarRegistroExportadores.DataKeys[int.Parse((string) e.CommandArgument) - pageIndex * pageSize].Value.ToString());
        List<res_RegistroExportacionSustancia> exportacionSustanciaList = CLinq.ListByProperty<res_RegistroExportacionSustancia>((DataContext) this.MyDataContext, "rex_Id", (object) num);
        for (int index = 0; index <= exportacionSustanciaList.Count - 1; ++index)
          this.MyDataContext.res_RegistroExportacionSustancias.DeleteOnSubmit(exportacionSustanciaList[index]);
        this.MyDataContext.rex_RegistroExportacions.DeleteOnSubmit(CLinq.FindByKey<rex_RegistroExportacion>((DataContext) this.MyDataContext, (object) num));
        this.MyDataContext.SubmitChanges();
        this.gridBuscarRegistroExportadores.DataSource = (object) null;
        this.gridBuscarRegistroExportadores.DataBind();
        foreach (DataControlField column in (StateManagedCollection) this.gridBuscarRegistroExportadores.Columns)
        {
          if (column.HeaderText == "Id")
            column.Visible = false;
        }
        CAuditoria.log(EPermiso.EliminarRegistroDeExportacion, num.ToString(), "", "", "", "", this.Usuario.id);
      }
      catch (Exception ex)
      {
        this.ControlError1.Visible = true;
        this.ControlError1.Show(ex);
      }
    }

    protected void buttonImportar_Click(object sender, EventArgs e)
    {
        Response.Redirect("RegistroExportacionCargue.aspx", false);
    }
}
//
