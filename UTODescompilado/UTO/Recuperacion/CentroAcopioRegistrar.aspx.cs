// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.CentroAcopioRegistrar
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
  public class CentroAcopioRegistrar : BaseModulo
  {
    private EntitySet<rad_ReporteCentroAcopioDetalle> listaReporteConsolidado = new EntitySet<rad_ReporteCentroAcopioDetalle>();
    private List<CentroAcopioRegistrar.strReporteConsolidado> listaReporteGrilla = new List<CentroAcopioRegistrar.strReporteConsolidado>();
    private List<CentroAcopioRegistrar.strReporteConsolidado> listaReporteGrillaCom = new List<CentroAcopioRegistrar.strReporteConsolidado>();
    private List<CentroAcopioRegistrar.strReporteConsolidado> listaReporteGrillaDisp = new List<CentroAcopioRegistrar.strReporteConsolidado>();
    protected ToolkitScriptManager ToolkitScriptManager1;
    protected Label labelBusquedaSolicitudesEquipos;
    protected ControlError ControlError2;
    protected Label labelNombreCentro;
    protected Label Label1;
    protected DropDownList comboCentroAcopio;
    protected Label labelPeriodo;
    protected Label Label2;
    protected DropDownList comboPeriodo;
    protected Label labelAnno;
    protected Label Label11;
    protected DropDownList comboAnno;
    protected Panel PanelDatosTercero;
    protected Label label5;
    protected Label labelBeneficiario;
    protected Label Label6;
    protected TextBox textBeneficiario;
    protected Label labelTipoGas;
    protected Label Label7;
    protected DropDownList comboTipoGas;
    protected Label labelFecha;
    protected Label Label9;
    protected TextBox textFecha;
    protected CalendarExtender CalendarExtender1;
    protected Label labelDestino;
    protected Label Label10;
    protected DropDownList comboDestino;
    protected Label labelCantidad;
    protected Label Label8;
    protected TextBox textCantidad;
    protected Button buttonAgregar;
    protected Button buttonCancelarDetalle;
    protected GridView gridDetalle;
    protected Label label3;
    protected Label label4;
    protected Label Label12;
    protected TextBox textTerceroCom;
    protected Label label13;
    protected Label Label14;
    protected DropDownList comboSustanciaCom;
    protected Label label15;
    protected Label Label16;
    protected TextBox textFechaCom;
    protected CalendarExtender CalendarExtender2;
    protected Label label19;
    protected Label Label20;
    protected TextBox textCantidadCom;
    protected Button buttonAgregarCom;
    protected Button buttonCancelarCom;
    protected GridView gridComercializado;
    protected Label label17;
    protected Label label18;
    protected Label Label21;
    protected TextBox textTerceroDisp;
    protected Label label22;
    protected Label Label23;
    protected DropDownList comboSustanciaDisp;
    protected Label label24;
    protected Label Label25;
    protected TextBox textFechaDisp;
    protected CalendarExtender CalendarExtender3;
    protected Label label26;
    protected Label Label27;
    protected TextBox textCantidadDisp;
    protected Button buttonAgregarDisp;
    protected Button buttonCancelarDisp;
    protected GridView gridDisp;
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
      this.comboAnno.DataSource = (object) this.MyDataContext.spComboAno(new int?(5), new int?(1)).ToList<spComboAnoResult>();
      this.comboAnno.DataBind();
      this.comboAnno.Items.Insert(0, "");
      this.comboPeriodo.DataSource = this.cargarPeriodo();
      this.comboPeriodo.DataBind();
      this.comboPeriodo.Items.Insert(0, "");
      this.comboCentroAcopio.DataSource = (object) CLinq.ListAll<cea_CentroAcopio>((DataContext) this.MyDataContext);
      this.comboCentroAcopio.DataBind();
      this.comboCentroAcopio.Items.Insert(0, "");
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
        this.LocalInfo.MyParams = (object) new rca_ReporteCentroAcopio();
        this.LocalInfo.SetData("idProvisional", (object) null);
        this.LocalInfo.SetData("listaReporteConsolidado", (object) this.listaReporteConsolidado);
        this.LocalInfo.SetData("listaReporteGrilla", (object) this.listaReporteGrilla);
        this.LocalInfo.SetData("listaReporteGrillaCom", (object) this.listaReporteGrillaCom);
        this.LocalInfo.SetData("listaReporteGrillaDisp", (object) this.listaReporteGrillaDisp);
      }
    }

    private void mostrarDatos(int id)
    {
      rca_ReporteCentroAcopio byKey = CLinq.FindByKey<rca_ReporteCentroAcopio>((DataContext) this.MyDataContext, (object) id);
      this.LocalInfo.MyParams = (object) byKey;
      this.comboAnno.SelectedValue = byKey.rca_Ano.ToString();
      this.comboCentroAcopio.SelectedValue = byKey.rca_Id.ToString();
      switch (byKey.rca_Periodo)
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
      this.LocalInfo.SetData("listaReporteConsolidado", (object) byKey.rad_ReporteCentroAcopioDetalles);
      this.ActualizarDatosGrilla(byKey.rad_ReporteCentroAcopioDetalles);
      this.ActualizarDatosGrillaCom(byKey.rad_ReporteCentroAcopioDetalles);
      this.ActualizarDatosGrillaDisp(byKey.rad_ReporteCentroAcopioDetalles);
    }

    private void ActualizarDatosGrillaDisp(
      EntitySet<rad_ReporteCentroAcopioDetalle> entitySet)
    {
      this.listaReporteConsolidado = (EntitySet<rad_ReporteCentroAcopioDetalle>) this.LocalInfo.GetData("listaReporteConsolidado");
      List<CentroAcopioRegistrar.strReporteConsolidado> reporteConsolidadoList = new List<CentroAcopioRegistrar.strReporteConsolidado>();
      for (int index = 0; index < this.listaReporteConsolidado.Count; ++index)
      {
        if (this.listaReporteConsolidado[index].gde_Id == 4)
        {
          CentroAcopioRegistrar.strReporteConsolidado reporteConsolidado = new CentroAcopioRegistrar.strReporteConsolidado();
          gti_GasTipo byKey1 = CLinq.FindByKey<gti_GasTipo>((DataContext) this.MyDataContext, (object) this.listaReporteConsolidado[index].gti_Id);
          gde_GasDestino byKey2 = CLinq.FindByKey<gde_GasDestino>((DataContext) this.MyDataContext, (object) this.listaReporteConsolidado[index].gde_Id);
          reporteConsolidado.sustancia = byKey1.gti_Descripcion;
          reporteConsolidado.cantidad = this.listaReporteConsolidado[index].rad_Cantidad;
          reporteConsolidado.destino = byKey2.gde_Descripcion;
          reporteConsolidado.nombre = this.listaReporteConsolidado[index].rad_Tercero;
          reporteConsolidado.id = this.listaReporteConsolidado[index].rad_Id == 0 ? index : this.listaReporteConsolidado[index].rad_Id;
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
      EntitySet<rad_ReporteCentroAcopioDetalle> entitySet)
    {
      this.listaReporteConsolidado = (EntitySet<rad_ReporteCentroAcopioDetalle>) this.LocalInfo.GetData("listaReporteConsolidado");
      List<CentroAcopioRegistrar.strReporteConsolidado> reporteConsolidadoList = new List<CentroAcopioRegistrar.strReporteConsolidado>();
      for (int index = 0; index < this.listaReporteConsolidado.Count; ++index)
      {
        if (this.listaReporteConsolidado[index].gde_Id == 3)
        {
          CentroAcopioRegistrar.strReporteConsolidado reporteConsolidado = new CentroAcopioRegistrar.strReporteConsolidado();
          gti_GasTipo byKey1 = CLinq.FindByKey<gti_GasTipo>((DataContext) this.MyDataContext, (object) this.listaReporteConsolidado[index].gti_Id);
          gde_GasDestino byKey2 = CLinq.FindByKey<gde_GasDestino>((DataContext) this.MyDataContext, (object) this.listaReporteConsolidado[index].gde_Id);
          reporteConsolidado.sustancia = byKey1.gti_Descripcion;
          reporteConsolidado.cantidad = this.listaReporteConsolidado[index].rad_Cantidad;
          reporteConsolidado.destino = byKey2.gde_Descripcion;
          reporteConsolidado.nombre = this.listaReporteConsolidado[index].rad_Tercero;
          reporteConsolidado.id = this.listaReporteConsolidado[index].rad_Id == 0 ? index : this.listaReporteConsolidado[index].rad_Id;
          reporteConsolidado.idProvisional = index;
          reporteConsolidadoList.Add(reporteConsolidado);
        }
      }
      this.LocalInfo.SetData("listaReporteGrillaCom", (object) reporteConsolidadoList);
      if (reporteConsolidadoList.Count > 0)
      {
        this.gridComercializado.DataSource = (object) reporteConsolidadoList;
        this.gridComercializado.DataBind();
      }
      else
      {
        this.gridComercializado.DataSource = (object) null;
        this.gridComercializado.DataBind();
      }
    }

    private void ActualizarDatosGrilla(
      EntitySet<rad_ReporteCentroAcopioDetalle> entitySet)
    {
      this.listaReporteConsolidado = (EntitySet<rad_ReporteCentroAcopioDetalle>) this.LocalInfo.GetData("listaReporteConsolidado");
      List<CentroAcopioRegistrar.strReporteConsolidado> reporteConsolidadoList = new List<CentroAcopioRegistrar.strReporteConsolidado>();
      for (int index = 0; index < this.listaReporteConsolidado.Count; ++index)
      {
        if (this.listaReporteConsolidado[index].gde_Id < 3)
        {
          CentroAcopioRegistrar.strReporteConsolidado reporteConsolidado = new CentroAcopioRegistrar.strReporteConsolidado();
          gti_GasTipo byKey1 = CLinq.FindByKey<gti_GasTipo>((DataContext) this.MyDataContext, (object) this.listaReporteConsolidado[index].gti_Id);
          gde_GasDestino byKey2 = CLinq.FindByKey<gde_GasDestino>((DataContext) this.MyDataContext, (object) this.listaReporteConsolidado[index].gde_Id);
          reporteConsolidado.sustancia = byKey1.gti_Descripcion;
          reporteConsolidado.cantidad = this.listaReporteConsolidado[index].rad_Cantidad;
          reporteConsolidado.destino = byKey2.gde_Descripcion;
          reporteConsolidado.nombre = this.listaReporteConsolidado[index].rad_Tercero.ToUpper();
          reporteConsolidado.id = this.listaReporteConsolidado[index].rad_Id == 0 ? index : this.listaReporteConsolidado[index].rad_Id;
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

    private object cargarPeriodo() => (object) new List<string>()
    {
      "PRIMERO",
      "SEGUNDO",
      "TERCERO",
      "CUARTO"
    };

    protected void buttonCancelar_Click(object sender, EventArgs e) => this.Server.Transfer("~/Recuperacion/CentroAcopioBuscar.aspx");

    protected void buttonGuardar_Click(object sender, EventArgs e)
    {
      try
      {
        this.Validar();
        this.ControlError2.Visible = false;
        rca_ReporteCentroAcopio myParams = (rca_ReporteCentroAcopio) this.LocalInfo.MyParams;
        myParams.rca_Ano = int.Parse(this.comboAnno.SelectedValue);
        myParams.cea_Id = int.Parse(this.comboCentroAcopio.SelectedValue);
        switch (this.comboPeriodo.SelectedValue)
        {
          case "PRIMERO":
            myParams.rca_Periodo = 1;
            break;
          case "SEGUNDO":
            myParams.rca_Periodo = 2;
            break;
          case "TERCERO":
            myParams.rca_Periodo = 3;
            break;
          case "CUARTO":
            myParams.rca_Periodo = 4;
            break;
        }
        if ((int) this.LocalInfo.GetData("idReporte") == 0)
          this.MyDataContext.rca_ReporteCentroAcopios.InsertOnSubmit(myParams);
        this.MyDataContext.SubmitChanges();
        this.Server.Transfer("~/Recuperacion/CentroAcopioBuscar.aspx");
      }
      catch (Exception ex)
      {
        this.ControlError2.Visible = true;
        this.ControlError2.Show(ex);
      }
    }

    private void Validar()
    {
      string message = "";
      bool flag = true;
      if (this.comboCentroAcopio.SelectedValue == "")
      {
        flag = false;
        message += "El centro de acopio es un campo obligatorio. <br />";
      }
      if (this.comboPeriodo.SelectedValue == "")
      {
        flag = false;
        message += "El periodo es un campo obligatorio. <br />";
      }
      if (this.comboAnno.SelectedValue == "")
      {
        flag = false;
        message += "El año es un campo obligatorio. <br />";
      }
      if (!flag)
        throw new Exception(message);
    }

    private void ActualizarDatosTercero(ter_Tercero tercero)
    {
      this.textBeneficiario.Text = tercero.ter_NombreCompleto;
      this.LocalInfo.SetData("idTercero", (object) tercero.ter_Id);
    }

    protected void buttonAgregar_Click(object sender, EventArgs e)
    {
      try
      {
        this.listaReporteConsolidado = (EntitySet<rad_ReporteCentroAcopioDetalle>) this.LocalInfo.GetData("listaReporteConsolidado");
        this.ValidarDetalle();
        rad_ReporteCentroAcopioDetalle entity = new rad_ReporteCentroAcopioDetalle();
        entity.gde_Id = int.Parse(this.comboDestino.SelectedValue);
        entity.gti_Id = int.Parse(this.comboTipoGas.SelectedValue);
        entity.rad_Cantidad = Decimal.Parse(this.textCantidad.Text);
        entity.rad_Fecha = DateTime.ParseExact(this.textFecha.Text, "dd/mm/yyyy", (IFormatProvider) null);
        entity.rad_Tercero = this.textBeneficiario.Text.ToUpper();
        entity.rca_ReporteCentroAcopio = (rca_ReporteCentroAcopio) this.LocalInfo.MyParams;
        this.ControlError2.Visible = false;
        this.MyDataContext.rad_ReporteCentroAcopioDetalles.InsertOnSubmit(entity);
        this.listaReporteConsolidado.Add(entity);
        this.LocalInfo.SetData("listaReporteConsolidado", (object) this.listaReporteConsolidado);
        this.ActualizarDatosGrillaCom(this.listaReporteConsolidado);
        this.ActualizarDatosGrillaDisp(this.listaReporteConsolidado);
        this.ActualizarDatosGrilla(this.listaReporteConsolidado);
        this.limpiar();
      }
      catch (Exception ex)
      {
        this.ControlError2.Visible = true;
        this.ControlError2.Show(ex);
      }
    }

    private void limpiar()
    {
      this.textBeneficiario.Text = "";
      this.textFecha.Text = "";
      this.textCantidad.Text = "";
      this.comboDestino.SelectedIndex = -1;
      this.comboTipoGas.SelectedIndex = -1;
      this.LocalInfo.SetData("idTercero", (object) 0);
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

    protected void buttonCancelarDetalle_Click(object sender, EventArgs e) => this.limpiar();

    protected void buttonAgregarCom_Click(object sender, EventArgs e)
    {
      try
      {
        this.listaReporteConsolidado = (EntitySet<rad_ReporteCentroAcopioDetalle>) this.LocalInfo.GetData("listaReporteConsolidado");
        this.ValidarDetalleCom();
        rad_ReporteCentroAcopioDetalle entity = new rad_ReporteCentroAcopioDetalle();
        entity.gde_Id = 3;
        entity.gti_Id = int.Parse(this.comboSustanciaCom.SelectedValue);
        entity.rad_Cantidad = Decimal.Parse(this.textCantidadCom.Text);
        entity.rad_Fecha = DateTime.ParseExact(this.textFechaCom.Text, "dd/mm/yyyy", (IFormatProvider) null);
        entity.rad_Tercero = this.textTerceroCom.Text.ToUpper();
        entity.rca_ReporteCentroAcopio = (rca_ReporteCentroAcopio) this.LocalInfo.MyParams;
        this.ControlError2.Visible = false;
        this.MyDataContext.rad_ReporteCentroAcopioDetalles.InsertOnSubmit(entity);
        this.listaReporteConsolidado.Add(entity);
        this.LocalInfo.SetData("listaReporteConsolidado", (object) this.listaReporteConsolidado);
        this.ActualizarDatosGrillaCom(this.listaReporteConsolidado);
        this.ActualizarDatosGrillaDisp(this.listaReporteConsolidado);
        this.ActualizarDatosGrilla(this.listaReporteConsolidado);
        this.limpiarCom();
      }
      catch (Exception ex)
      {
        this.ControlError2.Visible = true;
        this.ControlError2.Show(ex);
      }
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
      int num = -1;
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
      num = (int) this.LocalInfo.GetData("idTercero");
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
        this.listaReporteConsolidado = (EntitySet<rad_ReporteCentroAcopioDetalle>) this.LocalInfo.GetData("listaReporteConsolidado");
        this.ValidarDetalleDisp();
        rad_ReporteCentroAcopioDetalle entity = new rad_ReporteCentroAcopioDetalle();
        entity.gde_Id = 4;
        entity.gti_Id = int.Parse(this.comboSustanciaDisp.SelectedValue);
        entity.rad_Cantidad = Decimal.Parse(this.textCantidadDisp.Text);
        entity.rad_Fecha = DateTime.ParseExact(this.textFechaDisp.Text, "dd/mm/yyyy", (IFormatProvider) null);
        entity.rad_Tercero = this.textTerceroDisp.Text.ToUpper();
        entity.rca_ReporteCentroAcopio = (rca_ReporteCentroAcopio) this.LocalInfo.MyParams;
        this.ControlError2.Visible = false;
        this.MyDataContext.rad_ReporteCentroAcopioDetalles.InsertOnSubmit(entity);
        this.listaReporteConsolidado.Add(entity);
        this.LocalInfo.SetData("listaReporteConsolidado", (object) this.listaReporteConsolidado);
        this.ActualizarDatosGrillaCom(this.listaReporteConsolidado);
        this.ActualizarDatosGrillaDisp(this.listaReporteConsolidado);
        this.ActualizarDatosGrilla(this.listaReporteConsolidado);
        this.limpiarDisp();
      }
      catch (Exception ex)
      {
        this.ControlError2.Visible = true;
        this.ControlError2.Show(ex);
      }
    }

    private void limpiarDisp()
    {
      this.textTerceroDisp.Text = "";
      this.textFechaDisp.Text = "";
      this.textCantidadDisp.Text = "";
      this.comboSustanciaDisp.SelectedIndex = -1;
      this.LocalInfo.SetData("idTercero", (object) 0);
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

    protected void buttonCancelarDisp_Click(object sender, EventArgs e) => this.limpiarDisp();

    protected void gridDisp_RowCommand(object sender, GridViewCommandEventArgs e)
    {
      int index1 = int.Parse(this.gridDisp.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString());
      this.listaReporteGrillaDisp = (List<CentroAcopioRegistrar.strReporteConsolidado>) this.LocalInfo.GetData("listaReporteGrillaDisp");
      this.listaReporteConsolidado = (EntitySet<rad_ReporteCentroAcopioDetalle>) this.LocalInfo.GetData("listaReporteConsolidado");
      if (!e.CommandName.Equals("Eliminar"))
        return;
      this.MyDataContext.rad_ReporteCentroAcopioDetalles.DeleteOnSubmit(this.listaReporteConsolidado[index1]);
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
      this.ActualizarDatosGrillaCom(this.listaReporteConsolidado);
      this.ActualizarDatosGrillaDisp(this.listaReporteConsolidado);
      this.ActualizarDatosGrilla(this.listaReporteConsolidado);
    }

    protected void gridComercializado_RowCommand(object sender, GridViewCommandEventArgs e)
    {
      int index1 = int.Parse(this.gridComercializado.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString());
      this.listaReporteConsolidado = (EntitySet<rad_ReporteCentroAcopioDetalle>) this.LocalInfo.GetData("listaReporteConsolidado");
      this.listaReporteGrillaCom = (List<CentroAcopioRegistrar.strReporteConsolidado>) this.LocalInfo.GetData("listaReporteGrillaCom");
      if (!e.CommandName.Equals("Eliminar"))
        return;
      this.MyDataContext.rad_ReporteCentroAcopioDetalles.DeleteOnSubmit(this.listaReporteConsolidado[index1]);
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
      this.ActualizarDatosGrillaCom(this.listaReporteConsolidado);
      this.ActualizarDatosGrillaDisp(this.listaReporteConsolidado);
      this.ActualizarDatosGrilla(this.listaReporteConsolidado);
    }

    protected void gridDetalle_RowCommand(object sender, GridViewCommandEventArgs e)
    {
      int index1 = int.Parse(this.gridDetalle.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString());
      this.listaReporteConsolidado = (EntitySet<rad_ReporteCentroAcopioDetalle>) this.LocalInfo.GetData("listaReporteConsolidado");
      this.listaReporteGrilla = (List<CentroAcopioRegistrar.strReporteConsolidado>) this.LocalInfo.GetData("listaReporteGrilla");
      if (!e.CommandName.Equals("Eliminar"))
        return;
      this.MyDataContext.rad_ReporteCentroAcopioDetalles.DeleteOnSubmit(this.listaReporteConsolidado[index1]);
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
      this.ActualizarDatosGrillaCom(this.listaReporteConsolidado);
      this.ActualizarDatosGrillaDisp(this.listaReporteConsolidado);
      this.ActualizarDatosGrilla(this.listaReporteConsolidado);
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
