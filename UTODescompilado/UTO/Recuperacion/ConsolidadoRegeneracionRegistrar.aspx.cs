// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.ConsolidadoRegeneracionRegistrar
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
using System.Web.UI.WebControls;
using UTO.Comunes;

namespace UTO.Recuperacion
{
  public class ConsolidadoRegeneracionRegistrar : BaseModulo
  {
    private EntitySet<rcd_ReporteConsolidadoDetalle> listaReporteConsolidado = new EntitySet<rcd_ReporteConsolidadoDetalle>();
    private List<ConsolidadoRegeneracionRegistrar.strReporteConsolidado> listaReporteGrilla = new List<ConsolidadoRegeneracionRegistrar.strReporteConsolidado>();
    protected ToolkitScriptManager ToolkitScriptManager1;
    protected Label labelBusquedaSolicitudesEquipos;
    protected ControlError ControlError1;
    protected Panel PanelDatosTercero;
    protected Label labelNombreCentro;
    protected DropDownList comboCentroRegeneracion;
    protected Label labelFecha0;
    protected DropDownList comboMes;
    protected Label label4;
    protected Label labelTipoGas;
    protected DropDownList comboTipoGas;
    protected Label labelPrecioPromedio;
    protected TextBox textPrecioPromedio;
    protected Label labelCantidadVendidaKg;
    protected TextBox textUsoCantidadVendida;
    protected Label labelCantidadVendida;
    protected TextBox textUsoCantidadEntregadaKg;
    protected Button buttonAdicionar;
    protected GridView gridReporteRecuperacion;
    protected Label label2;
    protected DocumentosVarios DocumentosVarios1;
    protected Button buttonGuardar;
    protected Button buttonExportar;
    protected Button buttonCancelar;

    protected new void Page_Load(object sender, EventArgs e)
    {
      this.buttonGuardar.Enabled = this.Usuario.permiteOperacion(EPermiso.ModificarReporteConsolidadoDeRegeneracion) || this.Usuario.permiteOperacion(EPermiso.AdicionarReporteConsolidadoRegeneracion);
      this.ControlError1.Visible = false;
      if (this.IsPostBack)
        return;
      this.InitData();
    }

    private void InitData()
    {
      this.comboTipoGas.DataSource = (object) CLinq.ListAll<gti_GasTipo>((DataContext) this.MyDataContext);
      this.comboTipoGas.DataBind();
      this.comboTipoGas.Items.Insert(0, "");
      this.comboCentroRegeneracion.DataSource = (object) CLinq.ListAll<cre_CentroRegeneracion>((DataContext) this.MyDataContext);
      this.comboCentroRegeneracion.DataBind();
      this.comboCentroRegeneracion.Items.Insert(0, "");
      this.LocalInfo.SetData("idReporte", (object) ((BaseModulo.strSendParam) this.LocalInfo.MyParams).id);
      if (((BaseModulo.strSendParam) this.LocalInfo.MyParams).id != 0)
      {
        BaseModulo.strSendParam myParams = (BaseModulo.strSendParam) this.LocalInfo.MyParams;
        if (myParams.tipo == "Ver")
        {
          this.PanelDatosTercero.Enabled = false;
          this.buttonGuardar.Enabled = false;
        }
        myParams = (BaseModulo.strSendParam) this.LocalInfo.MyParams;
        this.mostrarDatos(myParams.id);
      }
      else
      {
        this.LocalInfo.MyParams = (object) new rrc_ReporteRegeneracionConsolidado();
        this.LocalInfo.SetData("idProvisional", (object) null);
        this.LocalInfo.SetData("listaReporteConsolidado", (object) this.listaReporteConsolidado);
        this.LocalInfo.SetData("listaReporteGrilla", (object) this.listaReporteGrilla);
      }
    }

    private void mostrarDatos(int id)
    {
      rrc_ReporteRegeneracionConsolidado byKey = CLinq.FindByKey<rrc_ReporteRegeneracionConsolidado>((DataContext) this.MyDataContext, (object) id);
      this.LocalInfo.MyParams = (object) byKey;
      this.comboMes.SelectedValue = byKey.rrc_Mes.ToString();
      this.comboCentroRegeneracion.SelectedValue = byKey.cre_Id.ToString();
      this.ActualizarDatosGrilla(byKey.rcd_ReporteConsolidadoDetalles);
      this.LocalInfo.SetData("listaReporteConsolidado", (object) byKey.rcd_ReporteConsolidadoDetalles);
      this.DocumentosVarios1.Init("Rrr.rco_ReporteConsolidadoDocumento", "rrc_Id", byKey.rrc_Id.ToString(), this.MyDataContext.Connection.ConnectionString);
    }

    private void ActualizarDatosGrilla(
      EntitySet<rcd_ReporteConsolidadoDetalle> listaReporteConsolidado)
    {
      List<ConsolidadoRegeneracionRegistrar.strReporteConsolidado> reporteConsolidadoList = new List<ConsolidadoRegeneracionRegistrar.strReporteConsolidado>();
      for (int index = 0; index < listaReporteConsolidado.Count; ++index)
      {
        ConsolidadoRegeneracionRegistrar.strReporteConsolidado reporteConsolidado = new ConsolidadoRegeneracionRegistrar.strReporteConsolidado();
        gti_GasTipo byKey = CLinq.FindByKey<gti_GasTipo>((DataContext) this.MyDataContext, (object) listaReporteConsolidado[index].gti_Id);
        reporteConsolidado.tipoGas = byKey.gti_Descripcion;
        reporteConsolidado.libra = listaReporteConsolidado[index].rcd_CantidadVendida;
        reporteConsolidado.kilo = (Decimal) ((double) (int) reporteConsolidado.libra / 0.45359237);
        reporteConsolidado.precio = listaReporteConsolidado[index].rcd_PrecioPromedio;
        reporteConsolidado.id = listaReporteConsolidado[index].rcd_Id == 0 ? index : listaReporteConsolidado[index].rcd_Id;
        reporteConsolidado.idProvisional = index;
        reporteConsolidadoList.Add(reporteConsolidado);
      }
      if (reporteConsolidadoList.Count > 0)
      {
        this.gridReporteRecuperacion.DataSource = (object) reporteConsolidadoList;
        this.gridReporteRecuperacion.DataBind();
        this.LocalInfo.SetData("listaReporteGrilla", (object) reporteConsolidadoList);
      }
      else
      {
        this.gridReporteRecuperacion.DataSource = (object) null;
        this.gridReporteRecuperacion.DataBind();
      }
    }

    protected void buttonAdicionar_Click(object sender, EventArgs e)
    {
      this.listaReporteConsolidado = (EntitySet<rcd_ReporteConsolidadoDetalle>) this.LocalInfo.GetData("listaReporteConsolidado");
      try
      {
        this.Validar();
        this.ControlError1.Visible = false;
        rcd_ReporteConsolidadoDetalle entity = new rcd_ReporteConsolidadoDetalle();
        entity.rrc_ReporteRegeneracionConsolidado = (rrc_ReporteRegeneracionConsolidado) this.LocalInfo.MyParams;
        entity.gti_Id = int.Parse(this.comboTipoGas.SelectedValue);
        entity.rcd_CantidadVendida = Decimal.Parse(this.textUsoCantidadVendida.Text);
        entity.rcd_PrecioPromedio = Decimal.Parse(this.textPrecioPromedio.Text);
        this.MyDataContext.rcd_ReporteConsolidadoDetalles.InsertOnSubmit(entity);
        this.listaReporteConsolidado.Add(entity);
        this.LocalInfo.SetData("listaReporteConsolidado", (object) this.listaReporteConsolidado);
        this.ActualizarDatosGrilla(this.listaReporteConsolidado);
        this.comboMes.SelectedValue = "";
        this.comboTipoGas.SelectedValue = "";
        this.textPrecioPromedio.Text = "";
        this.textUsoCantidadVendida.Text = "";
        this.textUsoCantidadEntregadaKg.Text = "";
      }
      catch (Exception ex)
      {
        this.ControlError1.Visible = true;
        this.ControlError1.Show(ex);
      }
    }

    private void Validar()
    {
      string errStr = "";
      double number = 0.0;
      bool flag = true & CValidator.isNumeric(this.textUsoCantidadVendida.Text, ref number, "La cantidad vendida en libras debe ser un número. <br />", ref errStr);
      if (this.comboTipoGas.SelectedValue == "")
      {
        flag = false;
        errStr += "El tipo de gas es un campo obligatorio";
      }
      if (this.comboCentroRegeneracion.SelectedValue == "")
      {
        flag = false;
        errStr += "El centro de regeneracion es un campo obligatorio";
      }
      if (this.comboMes.SelectedValue == "")
      {
        flag = false;
        errStr += "El mes es un campo obligatorio";
      }
      if (!flag)
        throw new Exception(errStr);
    }

    protected void buttonGuardar_Click(object sender, EventArgs e)
    {
      rrc_ReporteRegeneracionConsolidado myParams = (rrc_ReporteRegeneracionConsolidado) this.LocalInfo.MyParams;
      myParams.rrc_Fecha = DateTime.Now;
      myParams.cre_Id = int.Parse(this.comboCentroRegeneracion.SelectedValue);
      myParams.rrc_Mes = int.Parse(this.comboMes.SelectedValue);
      if ((int) this.LocalInfo.GetData("idReporte") == 0)
        this.MyDataContext.rrc_ReporteRegeneracionConsolidados.InsertOnSubmit(myParams);
      this.DocumentosVarios1.Init("Rrr.rco_ReporteConsolidadoDocumento", "rrc_Id", myParams.rrc_Id.ToString(), this.MyDataContext.Connection.ConnectionString);
      this.MyDataContext.SubmitChanges();
      if ((int) this.LocalInfo.GetData("idReporte") == 0)
      {
        int num = myParams.rrc_Id;
        string key1 = num.ToString();
        string creDescripcion = myParams.cre_CentroRegeneracion.cre_Descripcion;
        num = myParams.rrc_Mes;
        string key3 = num.ToString();
        int id = this.Usuario.id;
        CAuditoria.log(EPermiso.AdicionarReporteConsolidadoRegeneracion, key1, creDescripcion, key3, "", "", id);
      }
      else
      {
        int num = myParams.rrc_Id;
        string key1 = num.ToString();
        string creDescripcion = myParams.cre_CentroRegeneracion.cre_Descripcion;
        num = myParams.rrc_Mes;
        string key3 = num.ToString();
        int id = this.Usuario.id;
        CAuditoria.log(EPermiso.ModificarReporteConsolidadoDeRegeneracion, key1, creDescripcion, key3, "", "", id);
      }
      this.Server.Transfer("~/Recuperacion/ConsolidadoRegeneracionBuscar.aspx");
    }

    protected void buttonCancelar_Click(object sender, EventArgs e) => this.Response.Redirect("~/Recuperacion/ConsolidadoRegeneracionBuscar.aspx");

    protected void textUsoCantidadVendida_TextChanged(object sender, EventArgs e) => this.textUsoCantidadEntregadaKg.Text = (Decimal.Parse(this.textUsoCantidadVendida.Text) / Decimal.Parse("0,45359237")).ToString();

    protected void buttonExportar_Click(object sender, EventArgs e) => this.Exportar(this.gridReporteRecuperacion);

    protected void gridReporteRecuperacion_RowCommand(object sender, GridViewCommandEventArgs e)
    {
      int index = int.Parse(this.gridReporteRecuperacion.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString());
      this.listaReporteConsolidado = (EntitySet<rcd_ReporteConsolidadoDetalle>) this.LocalInfo.GetData("listaReporteConsolidado");
      this.listaReporteGrilla = (List<ConsolidadoRegeneracionRegistrar.strReporteConsolidado>) this.LocalInfo.GetData("listaReporteGrilla");
      if (!e.CommandName.Equals("Eliminar"))
        return;
      this.MyDataContext.rcd_ReporteConsolidadoDetalles.DeleteOnSubmit(this.listaReporteConsolidado[index]);
      this.listaReporteConsolidado.Remove(this.listaReporteConsolidado[index]);
      this.listaReporteGrilla.Remove(this.listaReporteGrilla[index]);
      this.LocalInfo.SetData("listaReporteGrilla", (object) this.listaReporteGrilla);
      this.ActualizarDatosGrilla(this.listaReporteConsolidado);
    }

    public class strReporteConsolidado
    {
      private string _mes;
      private string _tipoGas;
      private Decimal _precio;
      private Decimal _libra;
      private Decimal _kilo;
      private int _id;
      private int _idProvisional;

      public string mes
      {
        get => this._mes;
        set => this._mes = value;
      }

      public string tipoGas
      {
        get => this._tipoGas;
        set => this._tipoGas = value;
      }

      public Decimal precio
      {
        get => this._precio;
        set => this._precio = value;
      }

      public Decimal libra
      {
        get => this._libra;
        set => this._libra = value;
      }

      public Decimal kilo
      {
        get => this._kilo;
        set => this._kilo = value;
      }

      public int id
      {
        get => this._id;
        set => this._id = value;
      }

      public int idProvisional
      {
        get => this._idProvisional;
        set => this._idProvisional = value;
      }
    }
  }
}
