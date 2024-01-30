// Decompiled with JetBrains decompiler
// Type: UTO.ImportacionExportacion.CertificacionesBuscar
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using AjaxControlToolkit;
using NE.CLib;
using NE.CLib.Linq;
using Seguridad.Servicio;
using System;
using System.Data.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UTO.ImportacionExportacion
{
  public class CertificacionesBuscar : BaseModulo
  {
    protected ToolkitScriptManager ToolkitScriptManager1;
    protected Label labelBusquedaCertificaciones;
    protected ControlError ControlError1;
    protected Label labelparametros;
    protected Label labelNumeroRadicado;
    protected TextBox textNumeroRadicado;
    protected Label labelRadicado;
    protected TextBox textRadicadopor;
    protected Label labelfechaRadicado;
    protected TextBox textFechaRadicadoDesde;
    protected CalendarExtender calendarFechaRadicado;
    protected Label labelfechaRadicadoHasta;
    protected TextBox textFechaRadicadoHasta;
    protected CalendarExtender textFechaRadicadoHasta_CalendarExtender;
    protected Label labelImportador;
    protected TextBox textImportador;
    protected Button buttonBuscar;
    protected Button buttonAdicionar;
    protected GridView gridBuscarCertificados;
    protected SqlDataSource certificacionesBuscarDataSource;

    protected new void Page_Load(object sender, EventArgs e)
    {
      this.ControlError1.Hide();
      if (this.IsPostBack)
        return;
      this.buttonBuscar.Enabled = this.Usuario.permiteOperacion(EPermiso.BuscarCertificaciones);
      this.buttonAdicionar.Enabled = this.Usuario.permiteOperacion(EPermiso.AdicionarCertificaciones);
      this.gridBuscarCertificados.Columns[0].Visible = this.Usuario.permiteOperacion(EPermiso.BuscarCertificaciones);
      this.gridBuscarCertificados.Columns[1].Visible = this.Usuario.permiteOperacion(EPermiso.ModificarCertificaciones);
      this.gridBuscarCertificados.Columns[2].Visible = this.Usuario.permiteOperacion(EPermiso.EliminarCertificaciones);
      this.InitData();
    }

    public void InitData()
    {
    }

    protected void buttonAdicionar_Click(object sender, EventArgs e)
    {
      this.SendParams = (object) new BaseModulo.strSendParam()
      {
        id = 0,
        tipo = ""
      };
      this.Server.Transfer("~/ImportacionExportacion/CertificacionesRegistrar.aspx");
    }

    protected void gridBuscarCertificados_RowCommand(object sender, GridViewCommandEventArgs e)
    {
      if (e.CommandName.Equals("Modificar"))
      {
        this.SendParams = (object) new BaseModulo.strSendParam()
        {
          id = int.Parse(this.gridBuscarCertificados.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString()),
          tipo = "Modificar"
        };
        this.Server.Transfer("~/ImportacionExportacion/CertificacionesRegistrar.aspx");
      }
      if (e.CommandName.Equals("Ver"))
      {
        this.SendParams = (object) new BaseModulo.strSendParam()
        {
          id = int.Parse(this.gridBuscarCertificados.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString()),
          tipo = "Ver"
        };
        this.Server.Transfer("~/ImportacionExportacion/CertificacionesRegistrar.aspx");
      }
      if (!e.CommandName.Equals("Eliminar"))
        return;
      this.ControlError1.Visible = false;
      try
      {
        int pageIndex = this.gridBuscarCertificados.PageIndex;
        int pageSize = this.gridBuscarCertificados.PageSize;
        int keyValue = int.Parse(this.gridBuscarCertificados.DataKeys[int.Parse((string) e.CommandArgument) - pageIndex * pageSize].Value.ToString());
        this.MyDataContext.cim_CertificacionImportadors.DeleteOnSubmit(CLinq.FindByKey<cim_CertificacionImportador>((DataContext) this.MyDataContext, (object) keyValue));
        this.MyDataContext.SubmitChanges();
        this.gridBuscarCertificados.DataSource = (object) null;
        this.gridBuscarCertificados.DataBind();
        foreach (DataControlField column in (StateManagedCollection) this.gridBuscarCertificados.Columns)
        {
          if (column.HeaderText == "Id")
            column.Visible = false;
        }
        CAuditoria.log(EPermiso.EliminarCertificaciones, keyValue.ToString(), "", "", "", "", this.Usuario.id);
      }
      catch (Exception ex)
      {
        this.ControlError1.Visible = true;
        this.ControlError1.Show(ex);
      }
    }

    protected void buttonBuscar_Click(object sender, EventArgs e)
    {
      this.ControlError1.Visible = false;
      try
      {
        this.Validar();
        DateTime date1 = DateTime.Parse("1/1/1900");
        DateTime date2 = DateTime.Parse("1/1/2111");
        if (this.textFechaRadicadoDesde.Text != "")
          CValidator.isDate(this.textFechaRadicadoDesde.Text, ref date1);
        if (this.textFechaRadicadoHasta.Text != "")
          CValidator.isDate(this.textFechaRadicadoHasta.Text, ref date2);
        this.certificacionesBuscarDataSource.SelectParameters["radicado"].DefaultValue = this.textNumeroRadicado.Text != "" ? this.textNumeroRadicado.Text : "%";
        this.certificacionesBuscarDataSource.SelectParameters["fechaInicial"].DefaultValue = date1.ToString("yyyy/MM/dd");
        this.certificacionesBuscarDataSource.SelectParameters["fechaFinal"].DefaultValue = date2.ToString("yyyy/MM/dd");
        this.certificacionesBuscarDataSource.SelectParameters["radicadopor"].DefaultValue = this.textRadicadopor.Text != "" ? this.textRadicadopor.Text : "%";
        this.certificacionesBuscarDataSource.SelectParameters["importador"].DefaultValue = this.textImportador.Text != "" ? this.textImportador.Text : "%";
      }
      catch (Exception ex)
      {
        this.ControlError1.Visible = true;
        this.ControlError1.Show(ex);
      }
    }

    private void Validar()
    {
      string message = "";
      bool flag = true;
      DateTime date = DateTime.Parse("1/1/1900");
      if (this.textFechaRadicadoDesde.Text != "" && !CValidator.isDate(this.textFechaRadicadoDesde.Text, ref date))
      {
        message = "La fecha inicial no tiene un formato válido <br/>";
        flag = false;
      }
      if (this.textFechaRadicadoHasta.Text != "" && !CValidator.isDate(this.textFechaRadicadoHasta.Text, ref date))
      {
        message += "La fecha final no tiene un formato válido <br/>";
        flag = false;
      }
      if (!flag)
        throw new Exception(message);
    }

    protected void textFechaRadicado0_TextChanged(object sender, EventArgs e)
    {
    }
  }
}
