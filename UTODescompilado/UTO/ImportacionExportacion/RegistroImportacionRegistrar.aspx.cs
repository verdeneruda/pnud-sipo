// Decompiled with JetBrains decompiler
// Type: UTO.ImportacionExportacion.RegistroImportacionRegistrar
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
  public class RegistroImportacionRegistrar : BaseModulo
  {
    private EntitySet<ris_RegistroImportacionSustancia> listaRegistroSustancia = new EntitySet<ris_RegistroImportacionSustancia>();
    private EntitySet<rie_RegistroImportacionEquipo> listaRegistroEquipos = new EntitySet<rie_RegistroImportacionEquipo>();
    private List<RegistroImportacionRegistrar.srtRegistroSustancia> listaSustanciaGrilla = new List<RegistroImportacionRegistrar.srtRegistroSustancia>();
    private List<RegistroImportacionRegistrar.srtRegistroEquipo> listaEquipoGrilla = new List<RegistroImportacionRegistrar.srtRegistroEquipo>();
    private List<RegistroImportacionRegistrar.srtCertificacion> listaCertificacion = new List<RegistroImportacionRegistrar.srtCertificacion>();
    private List<RegistroImportacionRegistrar.srtLicencia> listaLicencia = new List<RegistroImportacionRegistrar.srtLicencia>();
    protected ToolkitScriptManager ToolkitScriptManager1;
    protected Label labelRegistroExportar;
    protected ControlError ControlError1;
    protected Panel PanelRegistroImportacion;
    protected Label label1;
    protected Panel PanelBusqueda;
    protected RadioButton RadioSustancia;
    protected RadioButton RadioEquipos;
    protected Label labelImportador;
    protected DropDownList comboImportador;
    protected Label labelSustanciaBusqueda;
    protected Panel PanelSustanciaBuscar;
    protected GridView gridSustancia;
    protected Button buttonBuscarLicencias;
    protected Panel PanelCertificacion;
    protected GridView gridCertificado;
    protected Panel PanelLicencias;
    protected GridView gridLicencias;
    protected Panel PanelDatoGeneral;
    protected Label labelImportador0;
    protected DropDownList comboImportadorRegistro;
    protected Label labelNumeroRegistro;
    protected TextBox textNumeroRegistro;
    protected Label label11;
    protected DropDownList comboPaisCompra;
    protected Label label12;
    protected TextBox textPuertoEmbargue;
    protected Label label13;
    protected DropDownList comboAduana;
    protected Label labelExportador;
    protected DropDownList comboExportador;
    protected Label label2;
    protected DropDownList comboEstado;
    protected Label label4;
    protected Panel PanelSustancias;
    protected LinkButton linkImportacionSustancias;
    protected ImageButton imageImportacionSustancia;
    protected Panel panelImportacionSustancias;
    protected Label labelSustancia;
    protected DropDownList comboSustancia;
    protected Label labelArancel;
    protected TextBox TextArancel;
    protected Label labelCantidadImportada;
    protected TextBox TextCantidadImportada;
    protected Label label5;
    protected Label Label7;
    protected DropDownList comboUnidad;
    protected Label labelMarca;
    protected DropDownList comboMarca;
    protected Label labelPresentacion;
    protected DropDownList comboPresentacion;
    protected Label labelPrecioUnitario;
    protected Label Label3;
    protected TextBox TextPrecioUnitario;
    protected Label labelOrigen;
    protected DropDownList comboOrigen;
    protected TextBox textIdSustancia;
    protected Button buttonAdicionar;
    protected Button buttonExportar;
    protected GridView gridImportacionSustancia;
    protected CollapsiblePanelExtender colapsibleImportacionSustancias;
    protected Panel PanelEquipos;
    protected LinkButton LinkImportacionEquipos;
    protected ImageButton imageImportacionEquipos;
    protected Panel panelImportacionEquipos;
    protected Label labelArancelEquipos;
    protected DropDownList comboArancelEquipo;
    protected Label label6;
    protected DropDownList comboMarcaEquipo;
    protected Label labelCantidadEquipos;
    protected TextBox TextCantidadEquipos;
    protected Label labelReferencia;
    protected TextBox TextReferenciaEquipos;
    protected TextBox textIdEquipos;
    protected Button buttonAdicionarEquipos;
    protected Button button2;
    protected GridView GridImportarEquipos;
    protected CollapsiblePanelExtender colapsibleImportacionEquipos;
    protected Panel PanelConcepto;
    protected Label labelConcepto;
    protected DropDownList comboconcepto;
    protected Label labelFechaInicio;
    protected TextBox textFechaInicio;
    protected CalendarExtender textFechaInicio_CalendarExtender;
    protected Label labelFechaVigencia;
    protected TextBox textFechaVigencia;
    protected CalendarExtender textFechaVigencia_CalendarExtender;
    protected Label labelFechaRequerimiento;
    protected TextBox textFechaRequerimiento;
    protected CalendarExtender textFechaRequerimiento_CalendarExtender;
    protected Label labelVistoBueno;
    protected TextBox textVistoBueno;
    protected Label labelFechaVistoBueno;
    protected TextBox textFechaVistoBueno;
    protected CalendarExtender calendarFecha;
    protected Label labelFechaRespuesta;
    protected TextBox textFechaRespuesta;
    protected CalendarExtender CalendarExtender1;
    protected Button buttonGuardar;
    protected Button buttonCancelar;

    protected new void Page_Load(object sender, EventArgs e)
    {
      this.ControlError1.Hide();
      if (this.IsPostBack)
        return;
      this.buttonGuardar.Enabled = this.Usuario.permiteOperacion(EPermiso.ModificarRegistroImportacion) || this.Usuario.permiteOperacion(EPermiso.AdicionarRegistroImportacion);
      this.InitData();
    }

    public void InitData()
    {
      this.comboMarca.DataSource = (object) CLinq.ListAll<mar_Marca>((DataContext) this.MyDataContext);
      this.comboMarca.DataBind();
      this.comboMarca.Items.Insert(0, "");
      this.comboArancelEquipo.DataSource = (object) CLinq.ListAll<ear_EquipoArancel>((DataContext) this.MyDataContext);
      this.comboArancelEquipo.DataBind();
      this.comboArancelEquipo.Items.Insert(0, "");
      this.comboUnidad.DataSource = (object) CLinq.ListAll<uni_Unidad>((DataContext) this.MyDataContext);
      this.comboUnidad.DataBind();
      this.comboUnidad.Items.Insert(0, "");
      this.comboMarcaEquipo.DataSource = (object) CLinq.ListAll<meq_MarcaEquipo>((DataContext) this.MyDataContext);
      this.comboMarcaEquipo.DataBind();
      this.comboMarcaEquipo.Items.Insert(0, "");
      this.comboSustancia.DataSource = (object) CLinq.ListAll<sus_Sustancia>((DataContext) this.MyDataContext);
      this.comboSustancia.DataBind();
      this.comboSustancia.Items.Insert(0, "");
      this.comboAduana.DataSource = (object) CLinq.ListAll<adu_Aduana>((DataContext) this.MyDataContext);
      this.comboAduana.DataBind();
      this.comboAduana.Items.Insert(0, "");
      this.comboPaisCompra.DataSource = (object) CLinq.ListAll<pas_Pai>((DataContext) this.MyDataContext);
      this.comboPaisCompra.DataBind();
      this.comboPaisCompra.Items.Insert(0, "");
      this.comboPresentacion.DataSource = (object) CLinq.ListAll<psu_PresentacionSustancia>((DataContext) this.MyDataContext);
      this.comboPresentacion.DataBind();
      this.comboPresentacion.Items.Insert(0, "");
      this.comboOrigen.DataSource = (object) CLinq.ListAll<pas_Pai>((DataContext) this.MyDataContext);
      this.comboOrigen.DataBind();
      this.comboOrigen.Items.Insert(0, "");
      this.comboconcepto.DataSource = (object) CLinq.ListAll<cvb_ConceptoVistoBueno>((DataContext) this.MyDataContext);
      this.comboconcepto.DataBind();
      this.comboconcepto.Items.Insert(0, "");
      this.cargarComboTercero(this.comboImportador, 2);
      this.cargarComboTercero(this.comboImportadorRegistro, 2);
      this.cargarComboTercero(this.comboExportador, 8);
      this.comboEstado.DataSource = (object) CLinq.ListAll<rit_RegistroImportacionEstado>((DataContext) this.MyDataContext);
      this.comboEstado.DataBind();
      this.comboEstado.Items.Insert(0, "");
      this.LocalInfo.SetData("idRegistro", (object) ((BaseModulo.strSendParam) this.LocalInfo.MyParams).id);
      if (((BaseModulo.strSendParam) this.LocalInfo.MyParams).id != 0)
      {
        BaseModulo.strSendParam myParams = (BaseModulo.strSendParam) this.LocalInfo.MyParams;
        if (myParams.tipo == "Ver")
        {
          this.colapsibleImportacionEquipos.Collapsed = false;
          this.colapsibleImportacionSustancias.Collapsed = false;
          this.PanelRegistroImportacion.Enabled = false;
          this.buttonGuardar.Enabled = false;
        }
        myParams = (BaseModulo.strSendParam) this.LocalInfo.MyParams;
        this.mostrarDatos(myParams.id);
      }
      else
      {
        this.LocalInfo.MyParams = (object) new rim_RegistroImportacion();
        this.LocalInfo.SetData("listaRegistroSustancia", (object) this.listaRegistroSustancia);
        this.LocalInfo.SetData("listaRegistroEquipos", (object) this.listaRegistroEquipos);
        this.LocalInfo.SetData("listaSustanciaGrilla", (object) this.listaSustanciaGrilla);
        this.LocalInfo.SetData("listaEquipoGrilla", (object) this.listaEquipoGrilla);
        this.LocalInfo.SetData("idProvisional", (object) null);
      }
    }

    private void cargarComboTercero(DropDownList combo, int tipo)
    {
      List<ter_Tercero> terTerceroList = new List<ter_Tercero>();
      List<ttt_TerceroTipoTercero> terceroTipoTerceroList = CLinq.ListByProperty<ttt_TerceroTipoTercero>((DataContext) this.MyDataContext, "tti_Id", (object) tipo);
      for (int index = 0; index <= terceroTipoTerceroList.Count - 1; ++index)
      {
        ter_Tercero byKey = CLinq.FindByKey<ter_Tercero>((DataContext) this.MyDataContext, (object) terceroTipoTerceroList[index].ter_Id);
        terTerceroList.Add(byKey);
      }
      combo.DataSource = (object) terTerceroList;
      combo.DataBind();
      combo.Items.Insert(0, "");
    }

    private void mostrarDatos(int id)
    {
      this.PanelBusqueda.Visible = false;
      this.PanelDatoGeneral.Visible = true;
      rim_RegistroImportacion byKey = CLinq.FindByKey<rim_RegistroImportacion>((DataContext) this.MyDataContext, (object) id);
      this.LocalInfo.MyParams = (object) byKey;
      CLinq.ListByProperty<ris_RegistroImportacionSustancia>((DataContext) this.MyDataContext, "rim_Id", (object) byKey.rim_Id);
      CLinq.ListByProperty<rie_RegistroImportacionEquipo>((DataContext) this.MyDataContext, "rim_Id", (object) id);
      this.textNumeroRegistro.Text = byKey.rim_NumeroRegistro;
      this.comboPaisCompra.SelectedValue = byKey.pas_Id.ToString();
      this.textPuertoEmbargue.Text = byKey.rim_PuertoEmbargue;
      this.comboAduana.SelectedValue = byKey.adu_Id.ToString();
      this.comboExportador.SelectedValue = byKey.ter_idExportador.ToString();
      this.comboconcepto.SelectedValue = byKey.cvb_Id.ToString();
      this.comboEstado.SelectedValue = byKey.rit_Id.ToString();
      DateTime dateTime;
      if (byKey.rim_FechaInicio.HasValue)
      {
        TextBox textFechaInicio = this.textFechaInicio;
        dateTime = byKey.rim_FechaInicio.Value;
        string shortDateString = dateTime.ToShortDateString();
        textFechaInicio.Text = shortDateString;
      }
      if (byKey.cvb_Id == 1)
      {
        this.labelVistoBueno.Visible = true;
        this.textVistoBueno.Visible = true;
        this.labelFechaVistoBueno.Visible = true;
        this.textFechaVistoBueno.Visible = true;
        this.labelFechaRequerimiento.Visible = false;
        this.textFechaRequerimiento.Visible = false;
        this.textVistoBueno.Text = byKey.rim_NumeroVistoBueno;
        if (byKey.rim_FechaVistoBueno.HasValue)
        {
          TextBox textFechaVistoBueno = this.textFechaVistoBueno;
          dateTime = byKey.rim_FechaVistoBueno.Value;
          string shortDateString = dateTime.ToShortDateString();
          textFechaVistoBueno.Text = shortDateString;
        }
      }
      else if (byKey.cvb_Id == 3)
      {
        this.labelFechaRequerimiento.Visible = true;
        this.textFechaRequerimiento.Visible = true;
        this.labelVistoBueno.Visible = false;
        this.textVistoBueno.Visible = false;
        this.labelFechaVistoBueno.Visible = false;
        this.textFechaVistoBueno.Visible = false;
        if (byKey.rim_FechaSolicitudRequerimiento.HasValue)
        {
          TextBox fechaRequerimiento = this.textFechaRequerimiento;
          dateTime = byKey.rim_FechaSolicitudRequerimiento.Value;
          string shortDateString = dateTime.ToShortDateString();
          fechaRequerimiento.Text = shortDateString;
        }
        if (byKey.rim_FechaVistoBueno.HasValue)
        {
          TextBox textFechaVistoBueno = this.textFechaVistoBueno;
          dateTime = byKey.rim_FechaVistoBueno.Value;
          string shortDateString = dateTime.ToShortDateString();
          textFechaVistoBueno.Text = shortDateString;
        }
        this.textVistoBueno.Text = byKey.rim_NumeroVistoBueno;
      }
      else if (byKey.cvb_Id == 5)
      {
        this.labelFechaRequerimiento.Visible = true;
        this.textFechaRequerimiento.Visible = true;
        this.labelVistoBueno.Visible = false;
        this.textVistoBueno.Visible = false;
        this.labelFechaVistoBueno.Visible = false;
        this.textFechaVistoBueno.Visible = false;
        this.labelFechaRespuesta.Visible = true;
        this.textFechaRespuesta.Visible = true;
        if (byKey.rim_FechaSolicitudRequerimiento.HasValue)
        {
          TextBox fechaRequerimiento = this.textFechaRequerimiento;
          dateTime = byKey.rim_FechaSolicitudRequerimiento.Value;
          string shortDateString = dateTime.ToShortDateString();
          fechaRequerimiento.Text = shortDateString;
        }
        if (byKey.rim_FechaVistoBueno.HasValue)
        {
          TextBox textFechaVistoBueno = this.textFechaVistoBueno;
          dateTime = byKey.rim_FechaVistoBueno.Value;
          string shortDateString = dateTime.ToShortDateString();
          textFechaVistoBueno.Text = shortDateString;
        }
        if (byKey.rim_FechaRequerimiento.HasValue)
        {
          TextBox textFechaRespuesta = this.textFechaRespuesta;
          dateTime = byKey.rim_FechaRequerimiento.Value;
          string shortDateString = dateTime.ToShortDateString();
          textFechaRespuesta.Text = shortDateString;
        }
        this.textVistoBueno.Text = byKey.rim_NumeroVistoBueno;
      }
      else
      {
        this.labelVistoBueno.Visible = false;
        this.textVistoBueno.Visible = false;
        this.labelFechaVistoBueno.Visible = false;
        this.textFechaVistoBueno.Visible = false;
        this.labelFechaRequerimiento.Visible = false;
        this.textFechaRequerimiento.Visible = false;
        this.labelFechaRespuesta.Visible = false;
        this.textFechaRespuesta.Visible = false;
      }
      if (byKey.rim_Tipo == "SUSTANCIA")
      {
        this.LocalInfo.SetData("listaRegistroSustancia", (object) byKey.ris_RegistroImportacionSustancias);
        this.PanelSustancias.Visible = true;
        this.alimentarGrillaSustancia(byKey.ris_RegistroImportacionSustancias);
        this.comboImportadorRegistro.SelectedValue = byKey.ter_Id.ToString();
        this.PanelConcepto.Visible = true;
      }
      if (!(byKey.rim_Tipo == "EQUIPO"))
        return;
      this.PanelEquipos.Visible = true;
      this.LocalInfo.SetData("listaRegistroEquipos", (object) byKey.rie_RegistroImportacionEquipos);
      this.alimentarGrillaEquipo(byKey.rie_RegistroImportacionEquipos);
      this.comboImportadorRegistro.SelectedValue = byKey.ter_Id.ToString();
      this.PanelConcepto.Visible = true;
    }

    protected void buttonAdicionar_Click(object sender, EventArgs e)
    {
      this.listaRegistroSustancia = (EntitySet<ris_RegistroImportacionSustancia>) this.LocalInfo.GetData("listaRegistroSustancia");
      try
      {
        this.Validar();
        this.ControlError1.Visible = false;
        ris_RegistroImportacionSustancia entity = (!(this.textIdSustancia.Text == "") ? CLinq.FindByKey<ris_RegistroImportacionSustancia>((DataContext) this.MyDataContext, (object) int.Parse(this.textIdSustancia.Text)) : new ris_RegistroImportacionSustancia()) ?? new ris_RegistroImportacionSustancia();
        entity.rim_RegistroImportacion = (rim_RegistroImportacion) this.LocalInfo.MyParams;
        entity.sus_Id = int.Parse(this.comboSustancia.SelectedValue);
        entity.ris_Arancel = this.TextArancel.Text.ToUpper();
        entity.ris_CantidadImportada = new Decimal?(Decimal.Parse(this.TextCantidadImportada.Text));
        entity.mar_Id = int.Parse(this.comboMarca.SelectedValue);
        entity.psu_Id = int.Parse(this.comboPresentacion.SelectedValue);
        entity.ris_PrecioUnitario = Decimal.Parse(this.TextPrecioUnitario.Text);
        entity.pas_Id = int.Parse(this.comboOrigen.SelectedValue);
        entity.ris_Creado = DateTime.Now;
        entity.ris_Modificado = DateTime.Now;
        entity.ris_Usuario = "";
        entity.uni_Id = int.Parse(this.comboUnidad.SelectedValue);
        if (this.textIdSustancia.Text == "")
          this.MyDataContext.ris_RegistroImportacionSustancias.InsertOnSubmit(entity);
        else
          this.buttonAdicionar.Text = "Adicionar";
        this.listaRegistroSustancia.Add(entity);
        this.LocalInfo.SetData("listaRegistroSustancia", (object) this.listaRegistroSustancia);
        this.alimentarGrillaSustancia(this.listaRegistroSustancia);
        this.comboUnidad.SelectedValue = "";
        this.comboSustancia.SelectedValue = "";
        this.TextArancel.Text = "";
        this.TextCantidadImportada.Text = "";
        this.comboMarca.Text = "";
        this.comboPresentacion.SelectedValue = "";
        this.TextPrecioUnitario.Text = "";
        this.comboOrigen.SelectedValue = "";
      }
      catch (Exception ex)
      {
        this.ControlError1.Visible = true;
        this.ControlError1.Show(ex);
      }
    }

    private void alimentarGrillaSustancia(
      EntitySet<ris_RegistroImportacionSustancia> listaRegistroSustancia)
    {
      List<RegistroImportacionRegistrar.srtRegistroSustancia> registroSustanciaList = new List<RegistroImportacionRegistrar.srtRegistroSustancia>();
      for (int index = 0; index < listaRegistroSustancia.Count; ++index)
      {
        RegistroImportacionRegistrar.srtRegistroSustancia registroSustancia = new RegistroImportacionRegistrar.srtRegistroSustancia();
        registroSustancia.arancel = listaRegistroSustancia[index].ris_Arancel;
        registroSustancia.cantidad = listaRegistroSustancia[index].ris_CantidadImportada.Value;
        registroSustancia.marca = CLinq.FindByKey<mar_Marca>((DataContext) this.MyDataContext, (object) listaRegistroSustancia[index].mar_Id).mar_Descripcion;
        pas_Pai byKey1 = CLinq.FindByKey<pas_Pai>((DataContext) this.MyDataContext, (object) listaRegistroSustancia[index].pas_Id);
        registroSustancia.pais = byKey1.pas_Descripcion;
        registroSustancia.precio = listaRegistroSustancia[index].ris_PrecioUnitario;
        psu_PresentacionSustancia byKey2 = CLinq.FindByKey<psu_PresentacionSustancia>((DataContext) this.MyDataContext, (object) listaRegistroSustancia[index].psu_Id);
        registroSustancia.presentacion = byKey2.psu_Descripcion;
        sus_Sustancia byKey3 = CLinq.FindByKey<sus_Sustancia>((DataContext) this.MyDataContext, (object) listaRegistroSustancia[index].sus_Id);
        registroSustancia.sustancia = byKey3.sus_Descripcion;
        registroSustancia.idUnidad = listaRegistroSustancia[index].uni_Id;
        registroSustancia.id = listaRegistroSustancia[index].ris_Id == 0 ? index : listaRegistroSustancia[index].ris_Id;
        registroSustancia.idProvisional = index;
        registroSustanciaList.Add(registroSustancia);
      }
      this.gridImportacionSustancia.DataSource = (object) registroSustanciaList;
      this.gridImportacionSustancia.DataBind();
      foreach (DataControlField column in (StateManagedCollection) this.gridImportacionSustancia.Columns)
      {
        if (column.HeaderText == "id")
          column.Visible = false;
      }
      foreach (DataControlField column in (StateManagedCollection) this.gridImportacionSustancia.Columns)
      {
        if (column.HeaderText == "idProvisional")
          column.Visible = false;
      }
      this.LocalInfo.SetData("listaSustanciaGrilla", (object) registroSustanciaList);
    }

    private void alimentarGrillaEquipo(
      EntitySet<rie_RegistroImportacionEquipo> listaRegistroEquipo)
    {
      List<RegistroImportacionRegistrar.srtRegistroEquipo> srtRegistroEquipoList = new List<RegistroImportacionRegistrar.srtRegistroEquipo>();
      for (int index = 0; index <= listaRegistroEquipo.Count - 1; ++index)
        srtRegistroEquipoList.Add(new RegistroImportacionRegistrar.srtRegistroEquipo()
        {
          idArancel = listaRegistroEquipo[index].ear_Id.ToString(),
          arancel = CLinq.FindByKey<ear_EquipoArancel>((DataContext) this.MyDataContext, (object) listaRegistroEquipo[index].ear_Id).ear_Descripcion,
          descripcion = listaRegistroEquipo[index].rie_Referencia,
          marca = CLinq.FindByKey<meq_MarcaEquipo>((DataContext) this.MyDataContext, (object) listaRegistroEquipo[index].meq_Id).meq_Descripcion,
          unidad = listaRegistroEquipo[index].rie_CantidadImportada.Value,
          id = listaRegistroEquipo[index].rie_Id == 0 ? index : listaRegistroEquipo[index].rie_Id,
          idProvisional = index
        });
      this.GridImportarEquipos.DataSource = (object) srtRegistroEquipoList;
      this.GridImportarEquipos.DataBind();
      foreach (DataControlField column in (StateManagedCollection) this.GridImportarEquipos.Columns)
      {
        if (column.HeaderText == "id")
          column.Visible = false;
      }
      foreach (DataControlField column in (StateManagedCollection) this.GridImportarEquipos.Columns)
      {
        if (column.HeaderText == "idProvisional")
          column.Visible = false;
      }
      this.LocalInfo.SetData("listaEquipoGrilla", (object) srtRegistroEquipoList);
    }

    private void Validar()
    {
      string errStr = "";
      double number = 0.0;
      bool flag = true & CValidator.isNumeric(this.TextCantidadImportada.Text, ref number, "La cantidad importadora debe ser un número. <br />", ref errStr) & CValidator.isNumeric(this.TextPrecioUnitario.Text, ref number, "La precio unitario debe ser un número. <br />", ref errStr);
      if (this.comboSustancia.SelectedValue == "")
      {
        flag = false;
        errStr += " La sustancia es un campo obligatorio. <br />";
      }
      if (this.comboPresentacion.SelectedValue == "")
      {
        flag = false;
        errStr += " La presentación es un campo obligatorio. <br />";
      }
      if (this.comboUnidad.SelectedValue == "")
      {
        flag = false;
        errStr += " La unidad es un campo obligatorio. <br />";
      }
      if (this.comboOrigen.SelectedValue == "")
      {
        flag = false;
        errStr += " La pais de compra es un campo obligatorio. <br />";
      }
      if (!flag)
        throw new Exception(errStr);
    }

    protected void buttonGuardar_Click(object sender, EventArgs e)
    {
      try
      {
        this.ValidarRegistro();
        rim_RegistroImportacion myParams = (rim_RegistroImportacion) this.LocalInfo.MyParams;
        myParams.adu_Id = new int?(int.Parse(this.comboAduana.SelectedValue));
        myParams.cvb_Id = int.Parse(this.comboconcepto.SelectedValue);
        myParams.pas_Id = int.Parse(this.comboPaisCompra.SelectedValue);
        myParams.rim_Creado = DateTime.Now;
        myParams.ter_idExportador = int.Parse(this.comboExportador.SelectedValue);
        myParams.rit_Id = int.Parse(this.comboEstado.SelectedValue);
        if (this.RadioSustancia.Checked)
        {
          myParams.rim_Tipo = "SUSTANCIA";
          myParams.ter_Id = int.Parse(this.comboImportadorRegistro.SelectedValue);
        }
        if (this.RadioEquipos.Checked)
        {
          myParams.rim_Tipo = "EQUIPO";
          myParams.ter_Id = int.Parse(this.comboImportadorRegistro.SelectedValue);
        }
        if (this.textFechaRequerimiento.Text != "")
          myParams.rim_FechaSolicitudRequerimiento = new DateTime?(DateTime.Parse(this.textFechaRequerimiento.Text));
        if (this.textFechaRespuesta.Text != "")
          myParams.rim_FechaRequerimiento = new DateTime?(DateTime.Parse(this.textFechaRespuesta.Text));
        if (this.textFechaVigencia.Text != "")
          myParams.rim_FechaVigencia = new DateTime?(DateTime.Parse(this.textFechaVigencia.Text));
        if (this.textFechaVistoBueno.Text != "")
          myParams.rim_FechaVistoBueno = new DateTime?(DateTime.Parse(this.textFechaVistoBueno.Text));
        if (this.textFechaInicio.Text != "")
          myParams.rim_FechaInicio = new DateTime?(DateTime.Parse(this.textFechaInicio.Text));
        myParams.rim_NumeroRegistro = this.textNumeroRegistro.Text.ToUpper();
        myParams.rim_NumeroVistoBueno = this.textVistoBueno.Text.ToUpper();
        myParams.rim_PuertoEmbargue = this.textPuertoEmbargue.Text.ToUpper();
        myParams.pas_Id = int.Parse(this.comboPaisCompra.SelectedValue);
        myParams.rim_Usuario = "";
        myParams.rim_Modificado = DateTime.Now;
        if ((int) this.LocalInfo.GetData("idRegistro") == 0)
        {
          myParams.rim_Creado = DateTime.Now;
          this.MyDataContext.rim_RegistroImportacions.InsertOnSubmit(myParams);
        }
        this.MyDataContext.SubmitChanges();
        if ((int) this.LocalInfo.GetData("idRegistro") == 0)
          CAuditoria.log(EPermiso.AdicionarRegistroImportacion, myParams.rim_Id.ToString(), myParams.rim_NumeroRegistro, myParams.ter_Tercero.ter_NombreCompleto, "", "", this.Usuario.id);
        else
          CAuditoria.log(EPermiso.ModificarRegistroImportacion, myParams.rim_Id.ToString(), myParams.rim_NumeroRegistro, myParams.ter_Tercero.ter_NombreCompleto, "", "", this.Usuario.id);
        this.Response.Redirect("~/ImportacionExportacion/RegistroImportacionBuscar.aspx");
      }
      catch (Exception ex)
      {
        this.ControlError1.Visible = true;
        this.ControlError1.Show(ex);
      }
    }

    private void ValidarRegistro()
    {
      string message = "";
      bool flag = true;
      if (this.textNumeroRegistro.Text != "" && CLinq.ListByProperty<rim_RegistroImportacion>((DataContext) this.MyDataContext, "rim_NumeroRegistro", (object) this.textNumeroRegistro.Text).Count > 0 && (int) this.LocalInfo.GetData("idRegistro") == 0)
      {
        flag = false;
        message += " Este número de registro de importación ya existe. <br />";
      }
      if (this.comboconcepto.SelectedValue == "1")
      {
        if (this.textFechaVistoBueno.Text == "")
        {
          flag = false;
          message += " La fecha de visto bueno es obligatorio si el concepto es Visto Bueno. <br />";
        }
        else if (DateTime.Parse(this.textFechaVistoBueno.Text) > DateTime.Today)
        {
          flag = false;
          message += " La fecha de visto bueno no puede ser futura. <br />";
        }
        if (this.textFechaInicio.Text == "")
        {
          flag = false;
          message += " La fecha de inicio es obligatorio si el concepto es Visto Bueno. <br />";
        }
        else if (DateTime.Parse(this.textFechaInicio.Text) > DateTime.Today)
        {
          flag = false;
          message += " La fecha de inicio no puede ser futura. </br>";
        }
      }
      if (this.comboconcepto.SelectedValue == "3")
      {
        if (this.textFechaInicio.Text == "")
        {
          flag = false;
          message += " La fecha de inicio es obligatorio. </br>";
        }
        else if (DateTime.Parse(this.textFechaInicio.Text) > DateTime.Today)
        {
          flag = false;
          message += " La fecha de inicio no puede ser futura. </br>";
        }
        if (this.textFechaRequerimiento.Text == "")
        {
          flag = false;
          message += " La fecha del requerimiento debe ser ingresada. </br>";
        }
        else if (DateTime.Parse(this.textFechaRequerimiento.Text) > DateTime.Today)
        {
          flag = false;
          message += " La fecha del requerimiento no puede ser futura. </br>";
        }
      }
      if (this.comboconcepto.SelectedValue == "5")
      {
        if (this.textFechaInicio.Text == "")
        {
          flag = false;
          message += " La fecha de inicio es obligatorio. </br>";
        }
        else if (DateTime.Parse(this.textFechaInicio.Text) > DateTime.Today)
        {
          flag = false;
          message += " La fecha de inicio no puede ser futura. </br>";
        }
        if (this.textFechaRequerimiento.Text == "")
        {
          flag = false;
          message += " La fecha del requerimiento debe ser ingresada. </br>";
        }
        else if (DateTime.Parse(this.textFechaRequerimiento.Text) > DateTime.Today)
        {
          flag = false;
          message += " La fecha del requerimiento no puede ser futura. </br>";
        }
        if (this.textFechaRespuesta.Text == "")
        {
          flag = false;
          message += " La fecha de respuesta al requerimiento debe ser ingresada. </br>";
        }
        else if (DateTime.Parse(this.textFechaRespuesta.Text) > DateTime.Today)
        {
          flag = false;
          message += " La fecha de respuesta al requerimiento no puede ser futura. </br>";
        }
      }
      if (this.comboExportador.SelectedValue == "")
      {
        flag = false;
        message += " Se debe seleccionar el exportador. </br>";
      }
      if (this.comboEstado.SelectedValue == "")
      {
        flag = false;
        message += " Se debe seleccionar el estado. </br>";
      }
      if (!flag)
        throw new Exception(message);
    }

    protected void buttonCancelar_Click(object sender, EventArgs e) => this.Response.Redirect("~/ImportacionExportacion/RegistroImportacionBuscar.aspx");

    protected void comboconcepto_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.comboconcepto.SelectedValue == "1")
      {
        this.labelVistoBueno.Visible = true;
        this.textVistoBueno.Visible = true;
        this.labelFechaVistoBueno.Visible = true;
        this.textFechaVistoBueno.Visible = true;
        this.labelFechaRequerimiento.Visible = false;
        this.textFechaRequerimiento.Visible = false;
        this.labelFechaRespuesta.Visible = false;
        this.textFechaRespuesta.Visible = false;
      }
      else if (this.comboconcepto.SelectedValue == "3")
      {
        this.labelFechaRequerimiento.Visible = true;
        this.textFechaRequerimiento.Visible = true;
        this.labelVistoBueno.Visible = false;
        this.textVistoBueno.Visible = false;
        this.labelFechaVistoBueno.Visible = false;
        this.textFechaVistoBueno.Visible = false;
        this.labelFechaRespuesta.Visible = false;
        this.textFechaRespuesta.Visible = false;
      }
      else if (this.comboconcepto.SelectedValue == "5")
      {
        this.labelFechaRequerimiento.Visible = true;
        this.textFechaRequerimiento.Visible = true;
        this.labelVistoBueno.Visible = false;
        this.textVistoBueno.Visible = false;
        this.labelFechaVistoBueno.Visible = false;
        this.textFechaVistoBueno.Visible = false;
        this.labelFechaRespuesta.Visible = true;
        this.textFechaRespuesta.Visible = true;
      }
      else
      {
        this.labelVistoBueno.Visible = false;
        this.textVistoBueno.Visible = false;
        this.labelFechaVistoBueno.Visible = false;
        this.textFechaVistoBueno.Visible = false;
        this.labelFechaRequerimiento.Visible = false;
        this.textFechaRequerimiento.Visible = false;
        this.labelFechaRespuesta.Visible = false;
        this.textFechaRespuesta.Visible = false;
      }
    }

    protected void comboImportador_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.comboImportador.SelectedValue == "-1")
      {
        this.PanelLicencias.Visible = false;
        this.PanelCertificacion.Visible = false;
      }
      else
      {
        if (!this.RadioEquipos.Checked)
          return;
        try
        {
          this.PanelCertificacion.Visible = true;
          List<cim_CertificacionImportador> certificadosImportacion = CLinq.ListByProperty<cim_CertificacionImportador>((DataContext) this.MyDataContext, "ter_IdImportador", (object) int.Parse(this.comboImportador.SelectedValue));
          this.actualizarGrilla(certificadosImportacion);
          if (certificadosImportacion.Count <= 0)
            throw new Exception("Este importador no tiene ninguna certificación. <br />");
          this.PanelBusqueda.Visible = false;
          this.PanelDatoGeneral.Visible = true;
          this.ControlError1.Visible = false;
          this.PanelEquipos.Visible = true;
          this.PanelConcepto.Visible = true;
          this.comboImportadorRegistro.SelectedValue = this.comboImportador.SelectedValue;
        }
        catch (Exception ex)
        {
          this.ControlError1.Visible = true;
          this.ControlError1.Show(ex);
        }
      }
    }

    private void actualizarGrilla(
      List<cim_CertificacionImportador> certificadosImportacion)
    {
      List<RegistroImportacionRegistrar.srtCertificacion> srtCertificacionList = new List<RegistroImportacionRegistrar.srtCertificacion>();
      for (int index = 0; index <= certificadosImportacion.Count - 1; ++index)
        srtCertificacionList.Add(new RegistroImportacionRegistrar.srtCertificacion()
        {
          fabricante = certificadosImportacion[index].ter_Tercero.ter_NombreCompleto,
          pais = certificadosImportacion[index].pas_Pai.pas_Descripcion,
          radicado = certificadosImportacion[index].cim_NumeroRadicado,
          importador = certificadosImportacion[index].ter_Tercero1.ter_NombreCompleto,
          estadoCertificacion = !(certificadosImportacion[index].cim_FechaCertificado >= DateTime.Now) ? "Vencido" : "Vigente"
        });
      this.gridCertificado.DataSource = (object) srtCertificacionList;
      this.gridCertificado.DataBind();
    }

    protected void RadioSustancia_CheckedChanged(object sender, EventArgs e)
    {
      if (this.RadioSustancia.Checked)
      {
        this.cargarComboTercero(this.comboExportador, 8);
        this.labelSustanciaBusqueda.Visible = true;
        this.gridSustancia.Visible = true;
        this.labelFechaVigencia.Visible = true;
        this.textFechaVigencia.Visible = true;
        this.buttonBuscarLicencias.Visible = true;
        this.labelImportador.Visible = true;
        this.comboImportador.Visible = true;
        this.PanelEquipos.Visible = false;
        this.PanelSustanciaBuscar.Visible = true;
        this.PanelLicencias.Visible = false;
        this.PanelCertificacion.Visible = false;
        this.gridSustancia.DataSource = (object) CLinq.ListAll<sus_Sustancia>((DataContext) this.MyDataContext);
        this.gridSustancia.DataBind();
      }
      else
      {
        this.labelSustanciaBusqueda.Visible = false;
        this.gridSustancia.Visible = false;
        this.buttonBuscarLicencias.Visible = false;
        this.PanelSustanciaBuscar.Visible = false;
      }
    }

    protected void RadioEquipos_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.RadioEquipos.Checked)
        return;
      this.cargarComboTercero(this.comboExportador, 9);
      this.labelImportador.Visible = true;
      this.comboImportador.Visible = true;
      this.labelSustanciaBusqueda.Visible = false;
      this.gridSustancia.Visible = false;
      this.labelFechaVigencia.Visible = false;
      this.textFechaVigencia.Visible = false;
      this.buttonBuscarLicencias.Visible = false;
      this.PanelSustancias.Visible = false;
      this.PanelLicencias.Visible = false;
      this.PanelCertificacion.Visible = false;
      this.PanelSustanciaBuscar.Visible = false;
    }

    protected void comboSustancia_SelectedIndexChanged(object sender, EventArgs e) => this.TextArancel.Text = CLinq.FindByKey<sus_Sustancia>((DataContext) this.MyDataContext, (object) int.Parse(this.comboSustancia.SelectedValue)).sus_Arancel;

    protected void buttonBuscarLicencias_Click(object sender, EventArgs e)
    {
      try
      {
        this.PanelLicencias.Visible = true;
        int index = 0;
        List<RegistroImportacionRegistrar.srtLicencia> srtLicenciaList = new List<RegistroImportacionRegistrar.srtLicencia>();
        foreach (Control row in this.gridSustancia.Rows)
        {
          CheckBox control = row.FindControl("CheckSustancia") as CheckBox;
          if (control.Checked)
          {
            List<lmd_LicenciaMedioAmbientalDetalle> ambientalDetalleList = CLinq.ListByProperty<lmd_LicenciaMedioAmbientalDetalle>((DataContext) this.MyDataContext, "sus_Id", (object) int.Parse(this.gridSustancia.DataKeys[index].Value.ToString()));
            if (ambientalDetalleList.Count > 0)
              srtLicenciaList.Add(new RegistroImportacionRegistrar.srtLicencia()
              {
                pais = ambientalDetalleList[0].pas_Pai.pas_Descripcion,
                proveedor = ambientalDetalleList[0].ter_Tercero.ter_NombreCompleto
              });
            ++index;
          }
          else if (!control.Checked)
            ++index;
        }
        this.gridLicencias.DataSource = (object) srtLicenciaList;
        this.gridLicencias.DataBind();
        if (this.gridLicencias.Rows.Count <= 0)
          throw new Exception("Este importador no tiene ninguna licencia para está sustancia. <br />");
        this.PanelBusqueda.Visible = false;
        this.PanelDatoGeneral.Visible = true;
        this.ControlError1.Visible = false;
        this.PanelSustancias.Visible = true;
        this.PanelConcepto.Visible = true;
        this.comboImportadorRegistro.SelectedValue = this.comboImportador.SelectedValue;
      }
      catch (Exception ex)
      {
        this.ControlError1.Visible = true;
        this.ControlError1.Show(ex);
      }
    }

    protected void buttonAdicionarEquipos_Click(object sender, EventArgs e)
    {
      this.listaRegistroEquipos = (EntitySet<rie_RegistroImportacionEquipo>) this.LocalInfo.GetData("listaRegistroEquipos");
      try
      {
        this.ValidarEquipo();
        this.ControlError1.Visible = false;
        rie_RegistroImportacionEquipo entity = (!(this.textIdEquipos.Text == "") ? CLinq.FindByKey<rie_RegistroImportacionEquipo>((DataContext) this.MyDataContext, (object) int.Parse(this.textIdEquipos.Text)) : new rie_RegistroImportacionEquipo()) ?? new rie_RegistroImportacionEquipo();
        entity.rim_RegistroImportacion = (rim_RegistroImportacion) this.LocalInfo.MyParams;
        entity.ear_Id = int.Parse(this.comboArancelEquipo.SelectedValue);
        entity.rie_CantidadImportada = new Decimal?(Decimal.Parse(this.TextCantidadEquipos.Text));
        entity.meq_Id = int.Parse(this.comboMarcaEquipo.SelectedValue);
        entity.rie_Referencia = this.TextReferenciaEquipos.Text;
        entity.rie_Creado = DateTime.Now;
        entity.rie_Modificado = DateTime.Now;
        entity.rie_Usuario = "";
        if (this.textIdEquipos.Text == "")
          this.MyDataContext.rie_RegistroImportacionEquipos.InsertOnSubmit(entity);
        else
          this.buttonAdicionarEquipos.Text = "Guardar";
        this.listaRegistroEquipos.Add(entity);
        this.LocalInfo.SetData("listaRegistroEquipos", (object) this.listaRegistroEquipos);
        this.alimentarGrillaEquipo(this.listaRegistroEquipos);
        this.comboArancelEquipo.Text = "";
        this.TextCantidadEquipos.Text = "";
        this.comboMarcaEquipo.Text = "";
        this.TextReferenciaEquipos.Text = "";
      }
      catch (Exception ex)
      {
        this.ControlError1.Visible = true;
        this.ControlError1.Show(ex);
      }
    }

    protected void ValidarEquipo()
    {
      string errStr = "";
      double number = 0.0;
      bool flag = true & CValidator.isNumeric(this.TextCantidadEquipos.Text, ref number, "La cantidad de equipos debe ser un número. <br />", ref errStr);
      if (this.comboArancelEquipo.SelectedValue == "")
      {
        flag = false;
        errStr += " El arancel del equipo es un campo obligatorio. <br />";
      }
      if (!flag)
        throw new Exception(errStr);
    }

    protected void buttonAdicionarEmpresas_Click(object sender, EventArgs e) => this.Response.Redirect("~/Comunes/TerceroRegistrar.aspx?url=" + this.Page.Request.Url.LocalPath);

    protected void GridImportarEquipos_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.gridCertificado.DataSource = (object) CLinq.ListByProperty<cim_CertificacionImportador>((DataContext) this.MyDataContext, "ter_IdImportador", (object) int.Parse(this.comboImportador.SelectedValue));
      this.gridCertificado.DataBind();
    }

    protected void gridImportacionSustancia_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    protected void gridImportacionSustancia_RowCommand(object sender, GridViewCommandEventArgs e)
    {
      int index = int.Parse(this.gridImportacionSustancia.DataKeys[int.Parse((string) e.CommandArgument)].Values[0].ToString());
      int num = int.Parse(this.gridImportacionSustancia.DataKeys[int.Parse((string) e.CommandArgument)].Values[1].ToString());
      this.listaRegistroSustancia = (EntitySet<ris_RegistroImportacionSustancia>) this.LocalInfo.GetData("listaRegistroSustancia");
      this.listaSustanciaGrilla = (List<RegistroImportacionRegistrar.srtRegistroSustancia>) this.LocalInfo.GetData("listaSustanciaGrilla");
      if (e.CommandName.Equals("Modificar"))
      {
        this.comboSustancia.SelectedValue = this.listaRegistroSustancia[index].sus_Id.ToString();
        this.TextArancel.Text = this.listaRegistroSustancia[index].ris_Arancel;
        this.TextCantidadImportada.Text = this.listaRegistroSustancia[index].ris_CantidadImportada.ToString();
        this.comboPresentacion.SelectedValue = this.listaRegistroSustancia[index].psu_Id.ToString();
        this.TextPrecioUnitario.Text = this.listaRegistroSustancia[index].ris_PrecioUnitario.ToString();
        this.comboMarca.SelectedValue = this.listaRegistroSustancia[index].mar_Id.ToString();
        this.comboOrigen.SelectedValue = this.listaRegistroSustancia[index].pas_Id.ToString();
        this.comboUnidad.SelectedValue = this.listaRegistroSustancia[index].uni_Id.ToString();
        this.textIdSustancia.Text = this.listaRegistroSustancia[index].ris_Id.ToString();
        if (num == 0)
          this.MyDataContext.ris_RegistroImportacionSustancias.DeleteOnSubmit(this.listaRegistroSustancia[index]);
        this.listaRegistroSustancia.Remove(this.listaRegistroSustancia[index]);
        this.listaSustanciaGrilla.Remove(this.listaSustanciaGrilla[index]);
        this.LocalInfo.SetData("listaSustanciaGrilla", (object) this.listaSustanciaGrilla);
        this.alimentarGrillaSustancia(this.listaRegistroSustancia);
        this.buttonAdicionar.Text = "Guardar";
      }
      if (!e.CommandName.Equals("Eliminar"))
        return;
      if (this.listaRegistroSustancia[index].ris_Id > 0)
        this.MyDataContext.ris_RegistroImportacionSustancias.DeleteOnSubmit(this.listaRegistroSustancia[index]);
      this.listaRegistroSustancia.Remove(this.listaRegistroSustancia[index]);
      this.listaSustanciaGrilla.Remove(this.listaSustanciaGrilla[index]);
      this.LocalInfo.SetData("listaSustanciaGrilla", (object) this.listaSustanciaGrilla);
      this.alimentarGrillaSustancia(this.listaRegistroSustancia);
    }

    protected void GridImportarEquipos_RowCommand(object sender, GridViewCommandEventArgs e)
    {
      int index = int.Parse(this.GridImportarEquipos.DataKeys[int.Parse((string) e.CommandArgument)].Values[0].ToString());
      int num = int.Parse(this.GridImportarEquipos.DataKeys[int.Parse((string) e.CommandArgument)].Values[1].ToString());
      this.listaRegistroEquipos = (EntitySet<rie_RegistroImportacionEquipo>) this.LocalInfo.GetData("listaRegistroEquipos");
      this.listaEquipoGrilla = (List<RegistroImportacionRegistrar.srtRegistroEquipo>) this.LocalInfo.GetData("listaEquipoGrilla");
      if (e.CommandName.Equals("Modificar"))
      {
        this.comboArancelEquipo.SelectedValue = this.listaRegistroEquipos[index].ear_Id.ToString();
        this.comboMarcaEquipo.SelectedValue = this.listaRegistroEquipos[index].meq_Id.ToString();
        this.TextCantidadEquipos.Text = this.listaRegistroEquipos[index].rie_CantidadImportada.ToString();
        this.TextReferenciaEquipos.Text = this.listaRegistroEquipos[index].rie_Referencia;
        this.textIdEquipos.Text = this.listaRegistroEquipos[index].rie_Id.ToString();
        if (num == 0)
          this.MyDataContext.rie_RegistroImportacionEquipos.DeleteOnSubmit(this.listaRegistroEquipos[index]);
        this.listaRegistroEquipos.Remove(this.listaRegistroEquipos[index]);
        this.listaEquipoGrilla.Remove(this.listaEquipoGrilla[index]);
        this.LocalInfo.SetData("listaEquipoGrilla", (object) this.listaEquipoGrilla);
        this.alimentarGrillaEquipo(this.listaRegistroEquipos);
        this.buttonAdicionarEquipos.Text = "Guardar";
      }
      if (!e.CommandName.Equals("Eliminar"))
        return;
      if (this.listaRegistroEquipos[index].rie_Id > 0)
        this.MyDataContext.rie_RegistroImportacionEquipos.DeleteOnSubmit(this.listaRegistroEquipos[index]);
      this.listaRegistroEquipos.Remove(this.listaRegistroEquipos[index]);
      this.listaEquipoGrilla.Remove(this.listaEquipoGrilla[index]);
      this.LocalInfo.SetData("listaEquipoGrilla", (object) this.listaEquipoGrilla);
      this.alimentarGrillaEquipo(this.listaRegistroEquipos);
    }

    public class srtLicencia
    {
      private string _proveedor;
      private string _pais;

      public string proveedor
      {
        get => this._proveedor;
        set => this._proveedor = value;
      }

      public string pais
      {
        get => this._pais;
        set => this._pais = value;
      }
    }

    public class srtCertificacion
    {
      private string _estadoCertificacion;
      private string _radicado;
      private string _importador;
      private string _fabricante;
      private string _pais;
      private string _descripcion;

      public string estadoCertificacion
      {
        get => this._estadoCertificacion;
        set => this._estadoCertificacion = value;
      }

      public string radicado
      {
        get => this._radicado;
        set => this._radicado = value;
      }

      public string fabricante
      {
        get => this._fabricante;
        set => this._fabricante = value;
      }

      public string pais
      {
        get => this._pais;
        set => this._pais = value;
      }

      public string importador
      {
        get => this._importador;
        set => this._importador = value;
      }

      public string descripcion
      {
        get => this._descripcion;
        set => this._descripcion = value;
      }
    }

    public class srtRegistroEquipo
    {
      private string _marca;
      private string _arancel;
      private string _idArancel;
      private Decimal _unidad;
      private string _descripcion;
      private int _id;
      private int _idProvisional;

      public string marca
      {
        get => this._marca;
        set => this._marca = value;
      }

      public string arancel
      {
        get => this._arancel;
        set => this._arancel = value;
      }

      public string descripcion
      {
        get => this._descripcion;
        set => this._descripcion = value;
      }

      public Decimal unidad
      {
        get => this._unidad;
        set => this._unidad = value;
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

      public string idArancel
      {
        get => this._idArancel;
        set => this._idArancel = value;
      }
    }

    public class srtRegistroSustancia
    {
      private string _sustancia;
      private string _arancel;
      private Decimal _cantidad;
      private string _marca;
      private string _presentacion;
      private Decimal _precio;
      private string _pais;
      private int _id;
      private int _idProvisional;
      private int _idUnidad;

      public string sustancia
      {
        get => this._sustancia;
        set => this._sustancia = value;
      }

      public string arancel
      {
        get => this._arancel;
        set => this._arancel = value;
      }

      public Decimal cantidad
      {
        get => this._cantidad;
        set => this._cantidad = value;
      }

      public string marca
      {
        get => this._marca;
        set => this._marca = value;
      }

      public string presentacion
      {
        get => this._presentacion;
        set => this._presentacion = value;
      }

      public string pais
      {
        get => this._pais;
        set => this._pais = value;
      }

      public Decimal precio
      {
        get => this._precio;
        set => this._precio = value;
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

      public int idUnidad
      {
        get => this._idUnidad;
        set => this._idUnidad = value;
      }
    }
  }
}
