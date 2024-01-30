// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.CentrosRegeneracionRegistrar
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using AjaxControlToolkit;
using NE.CLib;
using NE.CLib.Linq;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Web.UI.WebControls;

namespace UTO.Recuperacion
{
  public class CentrosRegeneracionRegistrar : BaseModulo
  {
    private EntitySet<rcd_ReporteCentroRegeneracionDetalle> listaReporteConsolidado = new EntitySet<rcd_ReporteCentroRegeneracionDetalle>();
    private List<CentrosRegeneracionRegistrar.strReporteConsolidado> listaReporteGrilla = new List<CentrosRegeneracionRegistrar.strReporteConsolidado>();
    private List<CentrosRegeneracionRegistrar.strReporteConsolidado> listaReporteGrillaCom = new List<CentrosRegeneracionRegistrar.strReporteConsolidado>();
    private List<CentrosRegeneracionRegistrar.strReporteConsolidado> listaReporteGrillaDisp = new List<CentrosRegeneracionRegistrar.strReporteConsolidado>();
    protected ToolkitScriptManager ToolkitScriptManager1;
    protected Label labelBusquedaSolicitudesEquipos;
    protected ControlError ControlError1;
    protected Label labelNombreCentro;
    protected Label Label1;
    protected DropDownList comboCentroRegeneracion;
    protected Label labelPeriodo;
    protected Label Label2;
    protected DropDownList comboPeriodo;
    protected Label labelAno;
    protected Label Label11;
    protected DropDownList comboAno;
    protected Label label4;
    protected Label labelBeneficiario;
    protected Label Label5;
    protected TextBox textBeneficiario;
    protected Label labelTipoGas;
    protected Label Label6;
    protected DropDownList comboTipoGas;
    protected Label labelFecha;
    protected Label Label9;
    protected TextBox textFecha;
    protected CalendarExtender CalendarExtender1;
    protected Label labelDestino;
    protected Label Label10;
    protected DropDownList comboDestino;
    protected Label labelCantidad;
    protected Label Label7;
    protected TextBox textCantidad;
    protected Button buttonAgregar;
    protected Button buttonCancelarDetalle;
    protected GridView gridDetalle;
    protected Label label3;
    protected Label label12;
    protected Label Label13;
    protected TextBox textTerceroCom;
    protected Label label14;
    protected Label Label15;
    protected DropDownList comboSustanciaCom;
    protected Label label16;
    protected Label Label17;
    protected TextBox textFechaCom;
    protected CalendarExtender CalendarExtender2;
    protected Label label20;
    protected Label Label21;
    protected TextBox textCantidadCom;
    protected Button buttonAgregarCom;
    protected Button buttonCancelarCom;
    protected GridView gridCom;
    protected Label label18;
    protected Label label19;
    protected Label Label22;
    protected TextBox textTerceroDisp;
    protected Label label23;
    protected Label Label24;
    protected DropDownList comboSustanciaDisp;
    protected Label label25;
    protected Label Label26;
    protected TextBox textFechaDisp;
    protected CalendarExtender CalendarExtender3;
    protected Label label27;
    protected Label Label28;
    protected TextBox textCantidadDisp;
    protected Button buttonAgregarDisp;
    protected Button buttonCancelarDisp;
    protected GridView gridDisp;
    protected Panel panelBotones;
    protected Button buttonGuardar;
    protected Button buttonCancelar;

    protected new void Page_Load(object sender, EventArgs e)
    {
      if (this.IsPostBack)
        return;
      this.InitData();
    }

    private void InitData()
    {
      this.comboAno.DataSource = (object) this.MyDataContext.spComboAno(new int?(5), new int?(1)).ToList<spComboAnoResult>();
      this.comboAno.DataBind();
      this.comboAno.Items.Insert(0, "");
      this.comboPeriodo.DataSource = this.cargarPeriodo();
      this.comboPeriodo.DataBind();
      this.comboPeriodo.Items.Insert(0, "");
      this.comboCentroRegeneracion.DataSource = (object) CLinq.ListAll<cre_CentroRegeneracion>((DataContext) this.MyDataContext);
      this.comboCentroRegeneracion.DataBind();
      this.comboCentroRegeneracion.Items.Insert(0, "");
      this.comboDestino.DataSource = (object) CLinq.ListAll<gde_GasDestino>((DataContext) this.MyDataContext).Where<gde_GasDestino>((Func<gde_GasDestino, bool>) (x => x.gde_Id < 3)).ToList<gde_GasDestino>();
      this.comboDestino.DataBind();
      this.comboDestino.Items.Insert(0, "");
      this.comboTipoGas.DataSource = (object) CLinq.ListAll<gti_GasTipo>((DataContext) this.MyDataContext);
      this.comboTipoGas.DataBind();
      this.comboTipoGas.Items.Insert(0, "");
      this.comboSustanciaCom.DataSource = (object) CLinq.ListAll<gti_GasTipo>((DataContext) this.MyDataContext);
      this.comboSustanciaCom.DataBind();
      this.comboSustanciaCom.Items.Insert(0, "");
      this.comboSustanciaDisp.DataSource = (object) CLinq.ListAll<gti_GasTipo>((DataContext) this.MyDataContext);
      this.comboSustanciaDisp.DataBind();
      this.comboSustanciaDisp.Items.Insert(0, "");
      LocalInformation localInfo = this.LocalInfo;
      BaseModulo.strSendParam myParams = (BaseModulo.strSendParam) this.LocalInfo.MyParams;
      // ISSUE: variable of a boxed type
      __Boxed<int> id = (ValueType) myParams.id;
      localInfo.SetData("idReporte", (object) id);
      this.LocalInfo.SetData("idTercero", (object) 0);
      myParams = (BaseModulo.strSendParam) this.LocalInfo.MyParams;
      if (myParams.id != 0)
      {
        myParams = (BaseModulo.strSendParam) this.LocalInfo.MyParams;
        if (myParams.tipo == "Ver")
          this.buttonGuardar.Enabled = false;
        myParams = (BaseModulo.strSendParam) this.LocalInfo.MyParams;
        this.mostrarDatos(myParams.id);
      }
      else
      {
        this.LocalInfo.MyParams = (object) new rcr_ReporteCentroRegeneracion();
        this.LocalInfo.SetData("idProvisional", (object) null);
        this.LocalInfo.SetData("listaReporteConsolidado", (object) this.listaReporteConsolidado);
        this.LocalInfo.SetData("listaReporteGrilla", (object) this.listaReporteGrilla);
        this.LocalInfo.SetData("listaReporteGrillaCom", (object) this.listaReporteGrillaCom);
        this.LocalInfo.SetData("listaReporteGrillaDisp", (object) this.listaReporteGrillaDisp);
      }
    }

    private void mostrarDatos(int id)
    {
      rcr_ReporteCentroRegeneracion byKey = CLinq.FindByKey<rcr_ReporteCentroRegeneracion>((DataContext) this.MyDataContext, (object) id);
      this.LocalInfo.MyParams = (object) byKey;
      this.comboAno.SelectedValue = byKey.rcr_Ano.ToString();
      this.comboCentroRegeneracion.SelectedValue = byKey.cre_Id.ToString();
      switch (byKey.rcr_Periodo)
      {
        case 1:
          this.comboPeriodo.SelectedValue = "PRIMERO";
          break;
        case 2:
          this.comboPeriodo.SelectedValue = "SEGUNDO";
          break;
        case 3:
          this.comboPeriodo.SelectedValue = "TERCERO";
          break;
        case 4:
          this.comboPeriodo.SelectedValue = "CUARTO";
          break;
      }
      this.LocalInfo.SetData("listaReporteConsolidado", (object) byKey.rcd_ReporteCentroRegeneracionDetalles);
      this.ActualizarDatosGrilla(byKey.rcd_ReporteCentroRegeneracionDetalles);
      this.ActualizarDatosGrillaCom(byKey.rcd_ReporteCentroRegeneracionDetalles);
      this.ActualizarDatosGrillaDisp(byKey.rcd_ReporteCentroRegeneracionDetalles);
    }

    private void ActualizarDatosGrillaDisp(
      EntitySet<rcd_ReporteCentroRegeneracionDetalle> entitySet)
    {
      this.listaReporteConsolidado = (EntitySet<rcd_ReporteCentroRegeneracionDetalle>) this.LocalInfo.GetData("listaReporteConsolidado");
      List<CentrosRegeneracionRegistrar.strReporteConsolidado> reporteConsolidadoList = new List<CentrosRegeneracionRegistrar.strReporteConsolidado>();
      for (int index = 0; index < this.listaReporteConsolidado.Count; ++index)
      {
        if (this.listaReporteConsolidado[index].gde_Id == 4)
        {
          CentrosRegeneracionRegistrar.strReporteConsolidado reporteConsolidado = new CentrosRegeneracionRegistrar.strReporteConsolidado();
          gti_GasTipo byKey1 = CLinq.FindByKey<gti_GasTipo>((DataContext) this.MyDataContext, (object) this.listaReporteConsolidado[index].gti_Id);
          gde_GasDestino byKey2 = CLinq.FindByKey<gde_GasDestino>((DataContext) this.MyDataContext, (object) this.listaReporteConsolidado[index].gde_Id);
          reporteConsolidado.sustancia = byKey1.gti_Descripcion;
          reporteConsolidado.cantidad = this.listaReporteConsolidado[index].rcd_Cantidad;
          reporteConsolidado.destino = byKey2.gde_Descripcion;
          reporteConsolidado.nombre = this.listaReporteConsolidado[index].rcd_Tercero;
          reporteConsolidado.id = this.listaReporteConsolidado[index].rcd_Id == 0 ? index : this.listaReporteConsolidado[index].rcd_Id;
          reporteConsolidado.idProvisional = index;
          reporteConsolidadoList.Add(reporteConsolidado);
        }
      }
      this.LocalInfo.SetData("listaReporteGrillaDisp", (object) reporteConsolidadoList);
      if (reporteConsolidadoList.Count > 0)
      {
        this.gridDisp.DataSource = (object) reporteConsolidadoList;
        this.gridDisp.DataBind();
      }
      else
      {
        this.gridDisp.DataSource = (object) null;
        this.gridDisp.DataBind();
      }
    }

    private void ActualizarDatosGrillaCom(
      EntitySet<rcd_ReporteCentroRegeneracionDetalle> entitySet)
    {
      this.listaReporteConsolidado = (EntitySet<rcd_ReporteCentroRegeneracionDetalle>) this.LocalInfo.GetData("listaReporteConsolidado");
      List<CentrosRegeneracionRegistrar.strReporteConsolidado> reporteConsolidadoList = new List<CentrosRegeneracionRegistrar.strReporteConsolidado>();
      for (int index = 0; index < this.listaReporteConsolidado.Count; ++index)
      {
        if (this.listaReporteConsolidado[index].gde_Id == 3)
        {
          CentrosRegeneracionRegistrar.strReporteConsolidado reporteConsolidado = new CentrosRegeneracionRegistrar.strReporteConsolidado();
          gti_GasTipo byKey1 = CLinq.FindByKey<gti_GasTipo>((DataContext) this.MyDataContext, (object) this.listaReporteConsolidado[index].gti_Id);
          gde_GasDestino byKey2 = CLinq.FindByKey<gde_GasDestino>((DataContext) this.MyDataContext, (object) this.listaReporteConsolidado[index].gde_Id);
          reporteConsolidado.sustancia = byKey1.gti_Descripcion;
          reporteConsolidado.cantidad = this.listaReporteConsolidado[index].rcd_Cantidad;
          reporteConsolidado.destino = byKey2.gde_Descripcion;
          reporteConsolidado.nombre = this.listaReporteConsolidado[index].rcd_Tercero;
          reporteConsolidado.id = this.listaReporteConsolidado[index].rcd_Id == 0 ? index : this.listaReporteConsolidado[index].rcd_Id;
          reporteConsolidado.idProvisional = index;
          reporteConsolidadoList.Add(reporteConsolidado);
        }
      }
      this.LocalInfo.SetData("listaReporteGrillaCom", (object) reporteConsolidadoList);
      if (reporteConsolidadoList.Count > 0)
      {
        this.gridCom.DataSource = (object) reporteConsolidadoList;
        this.gridCom.DataBind();
      }
      else
      {
        this.gridCom.DataSource = (object) null;
        this.gridCom.DataBind();
      }
    }

    private object cargarPeriodo() => (object) new List<string>()
    {
      "PRIMERO",
      "SEGUNDO",
      "TERCERO",
      "CUARTO"
    };

    protected void buttonCancelarDetalle_Click(object sender, EventArgs e) => this.limpiar();

    private void limpiar()
    {
      this.textBeneficiario.Text = "";
      this.textFecha.Text = "";
      this.textCantidad.Text = "";
      this.comboDestino.SelectedIndex = -1;
      this.comboTipoGas.SelectedIndex = -1;
      this.LocalInfo.SetData("idTercero", (object) 0);
    }

    protected void buttonCancelar_Click(object sender, EventArgs e) => this.Server.Transfer("~/Recuperacion/ConsolidadoRegeneracionBuscar.aspx");

    protected void buttonAgregar_Click(object sender, EventArgs e)
    {
      try
      {
        this.ValidarDetalle();
        rcd_ReporteCentroRegeneracionDetalle entity = new rcd_ReporteCentroRegeneracionDetalle();
        entity.gde_Id = int.Parse(this.comboDestino.SelectedValue);
        entity.gti_Id = int.Parse(this.comboTipoGas.SelectedValue);
        entity.rcd_Cantidad = Decimal.Parse(this.textCantidad.Text);
        entity.rcd_Fecha = DateTime.ParseExact(this.textFecha.Text, "dd/MM/yyyy", (IFormatProvider) null);
        entity.rcd_Tercero = this.textBeneficiario.Text.ToUpper();
        entity.rcr_ReporteCentroRegeneracion = (rcr_ReporteCentroRegeneracion) this.LocalInfo.MyParams;
        this.ControlError1.Visible = false;
        this.MyDataContext.rcd_ReporteCentroRegeneracionDetalles.InsertOnSubmit(entity);
        this.listaReporteConsolidado = (EntitySet<rcd_ReporteCentroRegeneracionDetalle>) this.LocalInfo.GetData("listaReporteConsolidado");
        this.listaReporteConsolidado.Add(entity);
        this.LocalInfo.SetData("listaReporteConsolidado", (object) this.listaReporteConsolidado);
        this.ActualizarDatosGrilla(this.listaReporteConsolidado);
        this.ActualizarDatosGrillaCom(this.listaReporteConsolidado);
        this.ActualizarDatosGrillaDisp(this.listaReporteConsolidado);
        this.limpiar();
      }
      catch (Exception ex)
      {
        this.ControlError1.Visible = true;
        this.ControlError1.Show(ex);
      }
    }

    private void ActualizarDatosGrilla(
      EntitySet<rcd_ReporteCentroRegeneracionDetalle> listaReporteConsolidado)
    {
      listaReporteConsolidado = (EntitySet<rcd_ReporteCentroRegeneracionDetalle>) this.LocalInfo.GetData(nameof (listaReporteConsolidado));
      List<CentrosRegeneracionRegistrar.strReporteConsolidado> reporteConsolidadoList = new List<CentrosRegeneracionRegistrar.strReporteConsolidado>();
      for (int index = 0; index < listaReporteConsolidado.Count; ++index)
      {
        if (listaReporteConsolidado[index].gde_Id < 3)
        {
          CentrosRegeneracionRegistrar.strReporteConsolidado reporteConsolidado = new CentrosRegeneracionRegistrar.strReporteConsolidado();
          gti_GasTipo byKey1 = CLinq.FindByKey<gti_GasTipo>((DataContext) this.MyDataContext, (object) listaReporteConsolidado[index].gti_Id);
          gde_GasDestino byKey2 = CLinq.FindByKey<gde_GasDestino>((DataContext) this.MyDataContext, (object) listaReporteConsolidado[index].gde_Id);
          reporteConsolidado.sustancia = byKey1.gti_Descripcion;
          reporteConsolidado.cantidad = listaReporteConsolidado[index].rcd_Cantidad;
          reporteConsolidado.destino = byKey2.gde_Descripcion;
          reporteConsolidado.nombre = listaReporteConsolidado[index].rcd_Tercero;
          reporteConsolidado.id = listaReporteConsolidado[index].rcd_Id == 0 ? index : listaReporteConsolidado[index].rcd_Id;
          reporteConsolidado.idProvisional = index;
          reporteConsolidadoList.Add(reporteConsolidado);
        }
      }
      this.LocalInfo.SetData("listaReporteGrilla", (object) reporteConsolidadoList);
      if (reporteConsolidadoList.Count > 0)
      {
        this.gridDetalle.DataSource = (object) reporteConsolidadoList;
        this.gridDetalle.DataBind();
      }
      else
      {
        this.gridDetalle.DataSource = (object) null;
        this.gridDetalle.DataBind();
      }
    }

    private void ValidarDetalle()
    {
      string errStr = "";
      double number = 0.0;
      TimeSpan timeSpan = new TimeSpan();
      bool flag1 = true;
      int num = -1;
      if (this.comboTipoGas.SelectedValue == "")
      {
        flag1 = false;
        errStr += "El tipo de refrigerante es un campo obligatorio. <br />";
      }
      if (this.comboDestino.SelectedValue == "")
      {
        flag1 = false;
        errStr += "El destino es un campo obligatorio. <br />";
      }
      bool flag2 = flag1 & CValidator.isNumeric(this.textCantidad.Text, ref number, "La cantidad debe ser un número. <br />", ref errStr);
      if (this.textFecha.Text == "")
      {
        flag2 = false;
        errStr += "La fecha es un campo obligatorio. <br />";
      }
      num = (int) this.LocalInfo.GetData("idTercero");
      if (this.textBeneficiario.Text.Trim() == "")
      {
        flag2 = false;
        errStr += "Se debe digitar un tercero. <br />";
      }
      if (!flag2)
        throw new Exception(errStr);
    }

    private void Validar()
    {
      string message = "";
      bool flag = true;
      if (this.comboCentroRegeneracion.SelectedValue == "")
      {
        flag = false;
        message += "El centro de regeneracion es un campo obligatorio. <br />";
      }
      if (this.comboPeriodo.SelectedValue == "")
      {
        flag = false;
        message += "El periodo es un campo obligatorio. <br />";
      }
      if (this.comboAno.SelectedValue == "")
      {
        flag = false;
        message += "El año es un campo obligatorio. <br />";
      }
      if (!flag)
        throw new Exception(message);
    }

    protected void gridDetalle_RowCommand(object sender, GridViewCommandEventArgs e)
    {
      int index1 = int.Parse(this.gridDetalle.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString());
      this.listaReporteConsolidado = (EntitySet<rcd_ReporteCentroRegeneracionDetalle>) this.LocalInfo.GetData("listaReporteConsolidado");
      this.listaReporteGrilla = (List<CentrosRegeneracionRegistrar.strReporteConsolidado>) this.LocalInfo.GetData("listaReporteGrilla");
      if (!e.CommandName.Equals("Eliminar"))
        return;
      this.MyDataContext.rcd_ReporteCentroRegeneracionDetalles.DeleteOnSubmit(this.listaReporteConsolidado[index1]);
      this.listaReporteConsolidado.Remove(this.listaReporteConsolidado[index1]);
      for (int index2 = 0; index2 < this.listaReporteGrilla.Count; ++index2)
      {
        if (this.listaReporteGrilla[index2].idProvisional == index1)
        {
          this.listaReporteGrilla.Remove(this.listaReporteGrilla[index2]);
          break;
        }
      }
      this.LocalInfo.SetData("listaReporteGrilla", (object) this.listaReporteGrilla);
      this.LocalInfo.SetData("listaReporteConsolidado", (object) this.listaReporteConsolidado);
      this.ActualizarDatosGrilla(this.listaReporteConsolidado);
      this.ActualizarDatosGrillaCom(this.listaReporteConsolidado);
      this.ActualizarDatosGrillaDisp(this.listaReporteConsolidado);
    }

    protected void buttonGuardar_Click(object sender, EventArgs e)
    {
      try
      {
        this.Validar();
        this.ControlError1.Visible = false;
        rcr_ReporteCentroRegeneracion myParams = (rcr_ReporteCentroRegeneracion) this.LocalInfo.MyParams;
        myParams.rcr_Ano = int.Parse(this.comboAno.SelectedValue);
        myParams.cre_Id = int.Parse(this.comboCentroRegeneracion.SelectedValue);
        switch (this.comboPeriodo.SelectedValue)
        {
          case "PRIMERO":
            myParams.rcr_Periodo = 1;
            break;
          case "SEGUNDO":
            myParams.rcr_Periodo = 2;
            break;
          case "TERCERO":
            myParams.rcr_Periodo = 3;
            break;
          case "CUARTO":
            myParams.rcr_Periodo = 4;
            break;
        }
        if ((int) this.LocalInfo.GetData("idReporte") == 0)
          this.MyDataContext.rcr_ReporteCentroRegeneracions.InsertOnSubmit(myParams);
        this.MyDataContext.SubmitChanges();
        this.Server.Transfer("~/Recuperacion/ConsolidadoRegeneracionBuscar.aspx");
      }
      catch (Exception ex)
      {
        this.ControlError1.Visible = true;
        this.ControlError1.Show(ex);
      }
    }

    protected void buttonAgregarCom_Click(object sender, EventArgs e)
    {
      try
      {
        this.ValidarDetalleCom();
        rcd_ReporteCentroRegeneracionDetalle entity = new rcd_ReporteCentroRegeneracionDetalle();
        entity.gde_Id = 3;
        entity.gti_Id = int.Parse(this.comboSustanciaCom.SelectedValue);
        entity.rcd_Cantidad = Decimal.Parse(this.textCantidadCom.Text);
        entity.rcd_Fecha = DateTime.ParseExact(this.textFechaCom.Text, "dd/MM/yyyy", (IFormatProvider) null);
        entity.rcd_Tercero = this.textTerceroCom.Text.ToUpper();
        entity.rcr_ReporteCentroRegeneracion = (rcr_ReporteCentroRegeneracion) this.LocalInfo.MyParams;
        this.ControlError1.Visible = false;
        this.MyDataContext.rcd_ReporteCentroRegeneracionDetalles.InsertOnSubmit(entity);
        this.listaReporteConsolidado = (EntitySet<rcd_ReporteCentroRegeneracionDetalle>) this.LocalInfo.GetData("listaReporteConsolidado");
        this.listaReporteConsolidado.Add(entity);
        this.LocalInfo.SetData("listaReporteConsolidado", (object) this.listaReporteConsolidado);
        this.ActualizarDatosGrilla(this.listaReporteConsolidado);
        this.ActualizarDatosGrillaCom(this.listaReporteConsolidado);
        this.ActualizarDatosGrillaDisp(this.listaReporteConsolidado);
        this.limpiarCom();
      }
      catch (Exception ex)
      {
        this.ControlError1.Visible = true;
        this.ControlError1.Show(ex);
      }
    }

    protected void gridCom_RowCommand(object sender, GridViewCommandEventArgs e)
    {
      int index1 = int.Parse(this.gridCom.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString());
      this.listaReporteConsolidado = (EntitySet<rcd_ReporteCentroRegeneracionDetalle>) this.LocalInfo.GetData("listaReporteConsolidado");
      this.listaReporteGrillaCom = (List<CentrosRegeneracionRegistrar.strReporteConsolidado>) this.LocalInfo.GetData("listaReporteGrillaCom");
      if (!e.CommandName.Equals("Eliminar"))
        return;
      this.MyDataContext.rcd_ReporteCentroRegeneracionDetalles.DeleteOnSubmit(this.listaReporteConsolidado[index1]);
      this.listaReporteConsolidado.Remove(this.listaReporteConsolidado[index1]);
      for (int index2 = 0; index2 < this.listaReporteGrillaCom.Count; ++index2)
      {
        if (this.listaReporteGrillaCom[index2].idProvisional == index1)
        {
          this.listaReporteGrillaCom.Remove(this.listaReporteGrillaCom[index2]);
          break;
        }
      }
      this.LocalInfo.SetData("listaReporteGrillaCom", (object) this.listaReporteGrillaCom);
      this.LocalInfo.SetData("listaReporteConsolidado", (object) this.listaReporteConsolidado);
      this.ActualizarDatosGrilla(this.listaReporteConsolidado);
      this.ActualizarDatosGrillaCom(this.listaReporteConsolidado);
      this.ActualizarDatosGrillaDisp(this.listaReporteConsolidado);
    }

    private void limpiarCom()
    {
      this.textTerceroCom.Text = "";
      this.textFechaCom.Text = "";
      this.textCantidadCom.Text = "";
      this.comboSustanciaCom.SelectedIndex = -1;
      this.LocalInfo.SetData("idTercero", (object) 0);
    }

    private void ValidarDetalleCom()
    {
      string errStr = "";
      double number = 0.0;
      TimeSpan timeSpan = new TimeSpan();
      bool flag1 = true;
      if (this.comboSustanciaCom.SelectedValue == "")
      {
        flag1 = false;
        errStr += "El tipo de refrigerante es un campo obligatorio. <br />";
      }
      bool flag2 = flag1 & CValidator.isNumeric(this.textCantidadCom.Text, ref number, "La cantidad debe ser un número. <br />", ref errStr);
      if (this.textFechaCom.Text == "")
      {
        flag2 = false;
        errStr += "La fecha es un campo obligatorio. <br />";
      }
      if (this.textTerceroCom.Text.Trim() == "")
      {
        flag2 = false;
        errStr += "Se debe digitar un tercero. <br />";
      }
      if (!flag2)
        throw new Exception(errStr);
    }

    protected void buttonCancelarCom_Click(object sender, EventArgs e) => this.limpiarCom();

    protected void buttonAgregarDisp_Click(object sender, EventArgs e)
    {
      try
      {
        this.ValidarDetalleDisp();
        rcd_ReporteCentroRegeneracionDetalle entity = new rcd_ReporteCentroRegeneracionDetalle();
        entity.gde_Id = 4;
        entity.gti_Id = int.Parse(this.comboSustanciaDisp.SelectedValue);
        entity.rcd_Cantidad = Decimal.Parse(this.textCantidadDisp.Text);
        entity.rcd_Fecha = DateTime.ParseExact(this.textFechaDisp.Text, "dd/MM/yyyy", (IFormatProvider) null);
        entity.rcd_Tercero = this.textTerceroDisp.Text.ToUpper();
        entity.rcr_ReporteCentroRegeneracion = (rcr_ReporteCentroRegeneracion) this.LocalInfo.MyParams;
        this.ControlError1.Visible = false;
        this.MyDataContext.rcd_ReporteCentroRegeneracionDetalles.InsertOnSubmit(entity);
        this.listaReporteConsolidado = (EntitySet<rcd_ReporteCentroRegeneracionDetalle>) this.LocalInfo.GetData("listaReporteConsolidado");
        this.listaReporteConsolidado.Add(entity);
        this.LocalInfo.SetData("listaReporteConsolidado", (object) this.listaReporteConsolidado);
        this.ActualizarDatosGrilla(this.listaReporteConsolidado);
        this.ActualizarDatosGrillaCom(this.listaReporteConsolidado);
        this.ActualizarDatosGrillaDisp(this.listaReporteConsolidado);
        this.limpiarDisp();
      }
      catch (Exception ex)
      {
        this.ControlError1.Visible = true;
        this.ControlError1.Show(ex);
      }
    }

    private void ValidarDetalleDisp()
    {
      string errStr = "";
      double number = 0.0;
      TimeSpan timeSpan = new TimeSpan();
      bool flag1 = true;
      if (this.comboSustanciaDisp.SelectedValue == "")
      {
        flag1 = false;
        errStr += "El tipo de refrigerante es un campo obligatorio. <br />";
      }
      bool flag2 = flag1 & CValidator.isNumeric(this.textCantidadDisp.Text, ref number, "La cantidad debe ser un número. <br />", ref errStr);
      if (this.textFechaDisp.Text == "")
      {
        flag2 = false;
        errStr += "La fecha es un campo obligatorio. <br />";
      }
      if (this.textTerceroDisp.Text.Trim() == "")
      {
        flag2 = false;
        errStr += "Se debe digitar un tercero. <br />";
      }
      if (!flag2)
        throw new Exception(errStr);
    }

    private void limpiarDisp()
    {
      this.textTerceroDisp.Text = "";
      this.textFechaDisp.Text = "";
      this.textCantidadDisp.Text = "";
      this.comboSustanciaDisp.SelectedIndex = -1;
      this.LocalInfo.SetData("idTercero", (object) 0);
    }

    protected void buttonCancelarDisp_Click(object sender, EventArgs e) => this.limpiarDisp();

    protected void gridDisp_RowCommand(object sender, GridViewCommandEventArgs e)
    {
      int index1 = int.Parse(this.gridDisp.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString());
      this.listaReporteConsolidado = (EntitySet<rcd_ReporteCentroRegeneracionDetalle>) this.LocalInfo.GetData("listaReporteConsolidado");
      this.listaReporteGrillaDisp = (List<CentrosRegeneracionRegistrar.strReporteConsolidado>) this.LocalInfo.GetData("listaReporteGrillaDisp");
      if (!e.CommandName.Equals("Eliminar"))
        return;
      this.MyDataContext.rcd_ReporteCentroRegeneracionDetalles.DeleteOnSubmit(this.listaReporteConsolidado[index1]);
      this.listaReporteConsolidado.Remove(this.listaReporteConsolidado[index1]);
      for (int index2 = 0; index2 < this.listaReporteGrillaDisp.Count; ++index2)
      {
        if (this.listaReporteGrillaDisp[index2].idProvisional == index1)
        {
          this.listaReporteGrillaDisp.Remove(this.listaReporteGrillaDisp[index2]);
          break;
        }
      }
      this.LocalInfo.SetData("listaReporteGrillaDisp", (object) this.listaReporteGrillaDisp);
      this.LocalInfo.SetData("listaReporteConsolidado", (object) this.listaReporteConsolidado);
      this.ActualizarDatosGrilla(this.listaReporteConsolidado);
      this.ActualizarDatosGrillaCom(this.listaReporteConsolidado);
      this.ActualizarDatosGrillaDisp(this.listaReporteConsolidado);
    }

    public class strReporteConsolidado
    {
      private string _sustancia;
      private Decimal _cantidad;
      private string _destino;
      private string _nombre;
      private int _id;
      private int _idProvisional;

      public string sustancia
      {
        get => this._sustancia;
        set => this._sustancia = value;
      }

      public Decimal cantidad
      {
        get => this._cantidad;
        set => this._cantidad = value;
      }

      public string destino
      {
        get => this._destino;
        set => this._destino = value;
      }

      public string nombre
      {
        get => this._nombre;
        set => this._nombre = value;
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
