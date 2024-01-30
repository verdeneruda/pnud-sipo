// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.AprobarSolicitudEquiposRegistrar
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using AjaxControlToolkit;
using NE.CLib.Linq;
using NE.CLib.Web;
using Seguridad.Servicio;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using UTO.Comunes;

namespace UTO.Recuperacion
{
  public class AprobarSolicitudEquiposRegistrar : BaseModulo
  {
    private EntitySet<sea_SolicitudEquiposAsignado> listaEquiposSolicitados = new EntitySet<sea_SolicitudEquiposAsignado>();
    private List<AprobarSolicitudEquiposRegistrar.strSolicitudAsignado> listaSolicitudGrilla = new List<AprobarSolicitudEquiposRegistrar.strSolicitudAsignado>();
    protected ToolkitScriptManager ToolkitScriptManager1;
    protected Label labelBusquedaSolicitudesEquipos;
    protected ControlError ControlError1;
    protected Panel PanelCancelar;
    protected Label label5;
    protected Label label6;
    protected CheckBox checkCancelar;
    protected Label labelFechaCancelar;
    protected TextBox textFechaCancelar;
    protected CalendarExtender CalendarExtender3;
    protected Panel PanelDatosTercero;
    protected Label label1;
    protected Label labelNombreBeneficiario0;
    protected TextBox textNombreBeneficiario;
    protected Label labelTipoDocumento;
    protected TextBox textTipoDocumento;
    protected Label labelDocumento;
    protected TextBox textDocumento;
    protected Label labelRut;
    protected TextBox textRut;
    protected Label labelRepresentanteLegal;
    protected TextBox textNombreRepresentante;
    protected Label labelRegional0;
    protected TextBox textRegional;
    protected Label labelTipoDocumentoRL;
    protected TextBox textTipoDocumentoRL;
    protected Label labelDocumentoRL;
    protected TextBox textDocumentoRL;
    protected Label labelDe;
    protected TextBox textDe;
    protected Label labelCorreo;
    protected TextBox textCorreo;
    protected Label labelDireccion;
    protected TextBox textDireccion;
    protected Label labelDepartamento;
    protected TextBox textDepartamento;
    protected Label labelMunicipio;
    protected TextBox textMunicipio;
    protected Label labelTipoBeneficiario;
    protected TextBox textTipoBeneficiario;
    protected Label labelTelefono;
    protected TextBox textTelefono;
    protected GridView gridProyectoTercero;
    protected Label label4;
    protected HtmlTableRow trCompraUno;
    protected LinkButton linkCompraUno;
    protected ImageButton imageCompraUno;
    protected UpdatePanel UpdatePanelAprobacionInicial;
    protected Panel panelCompraUno;
    protected GridView gridSolicitudEquipos;
    protected Label label3;
    protected TextBox TextValorTotalSolicitud;
    protected Label labelObservacionesInicial;
    protected TextBox textObservacionesInicial;
    protected CheckBox CheckEtapaInicialAprobada;
    protected CollapsiblePanelExtender colapsibleCompraUno;
    protected HtmlTableRow trEstudiosPrevios;
    protected LinkButton LinkEstudiosPrevios;
    protected ImageButton ImageEstudiosPrevios;
    protected UpdatePanel UpdatePanelEstudiosPrevios;
    protected Panel panelEstudiosPrevios;
    protected GridView GridEstudiosPrevios;
    protected Label labelObservaciones;
    protected TextBox textObservacionesEstudiosPrevios;
    protected CheckBox CheckCertificacion;
    protected Label labelFechaCertificación;
    protected TextBox textFechaCertificacion;
    protected CalendarExtender calendarfecha;
    protected CheckBox CheckEtapaEstudioAprobado;
    protected CollapsiblePanelExtender collapsibleEstudiosPrevios;
    protected HtmlTableRow trElaboracionMinutas;
    protected LinkButton LinkElaboracionMinutas;
    protected ImageButton ImageElaboracionMinutas;
    protected UpdatePanel UpdatePanelElaboracionMinuta;
    protected Panel panelElaboracionMinutas;
    protected GridView GridDocumentosMinuta;
    protected Label labelFechaElaboracion;
    protected TextBox textFechaElaboracion;
    protected CalendarExtender CalendarExtender1;
    protected Label labelFechaFirmaMinutas;
    protected TextBox textFechaFirmaPoliza;
    protected CalendarExtender textFechaFirmaPoliza_CalendarExtender;
    protected Label labelObservaciones0;
    protected TextBox textObservacionesMinutas;
    protected CheckBox CheckEtapaMinutaAprobado;
    protected CollapsiblePanelExtender CollapsibleElaboracionMinutas;
    protected HtmlTableRow trTramitePoliza;
    protected LinkButton LinkTramitePoliza;
    protected ImageButton ImageTramitePoliza;
    protected Panel panelTramitePoliza;
    protected GridView GridDocumentosPoliza;
    protected Label labelObservacionesPoliza;
    protected TextBox textObservacionesPoliza;
    protected Label labelFechaVigencia;
    protected TextBox textFechaVigencia;
    protected CalendarExtender textFechaVigencia_CalendarExtender;
    protected Label labelPlazo;
    protected TextBox textFechaPlazoPoliza;
    protected CalendarExtender textFechaPlazoPoliza_CalendarExtender;
    protected Label labelFechaPublicacion;
    protected TextBox textFechaPublicacion;
    protected CalendarExtender textFechaPublicacion_CalendarExtender;
    protected Label labelFechaAprobacionPoliza;
    protected TextBox textFechaAprobacionPoliza;
    protected CalendarExtender textFechaAprobacionPoliza_CalendarExtender;
    protected CheckBox CheckEtapaPolizaAprobado;
    protected CollapsiblePanelExtender CollapsibleTramitePoliza;
    protected LinkButton LinkEnvioEquipos;
    protected ImageButton ImageEnvioEquipos;
    protected Panel panelEnvioEquipos;
    protected GridView gridEquiposAsignados;
    protected Label labelValorTotal;
    protected TextBox textValorTotalAsignado;
    protected GridView GridDocumentosEntrega;
    protected Label labelFechaEntrega;
    protected CalendarExtender CalendarExtender2;
    protected TextBox textFechaEntrega;
    protected CalendarExtender textFechaEntrega_CalendarExtender;
    protected CalendarExtender textFechaEntrega_CalendarExtender2;
    protected Label labelLugarEntrega;
    protected CalendarExtender CalendarExtender5;
    protected CalendarExtender CalendarExtender4;
    protected TextBox textLugarEntrega;
    protected Label labelComodato;
    protected TextBox textComodato;
    protected Label labelActaEntrega;
    protected TextBox textNumeroActa;
    protected CheckBox CheckEtapaEntregaAprobado;
    protected CollapsiblePanelExtender CollapsibleEnvioEquipos;
    protected Label label2;
    protected DocumentosVarios DocumentosVarios1;
    protected Button buttonGuardar;
    protected Button buttonExportar;
    protected Button buttonCancelar;

    private int tipo
    {
      get => Convert.ToInt32(this.ViewState["SolicitudEquipo.Tipo"] ?? (object) 0);
      set => this.ViewState["SolicitudEquipo.Tipo"] = (object) value;
    }

    protected new void Page_Load(object sender, EventArgs e)
    {
      this.ControlError1.Visible = false;
      if (this.IsPostBack)
        return;
      this.tipo = this.Request.QueryString["tipo"] == null ? 1 : Convert.ToInt32(this.Request.QueryString["tipo"]);
      this.InitData();
    }

    private void InitData()
    {
      this.labelFechaCancelar.Visible = false;
      this.textFechaCancelar.Visible = false;
      this.LocalInfo.SetData("idSolicitud", (object) ((BaseModulo.strSendParam) this.LocalInfo.MyParams).id);
      this.GridEstudiosPrevios.DataSource = (object) CLinq.ListByProperty<dve_DocumentoVerificar>((DataContext) this.MyDataContext, "dve_Estado", (object) 3);
      this.GridEstudiosPrevios.DataBind();
      this.GridDocumentosMinuta.DataSource = (object) CLinq.ListByProperty<dve_DocumentoVerificar>((DataContext) this.MyDataContext, "dve_Estado", (object) 4);
      this.GridDocumentosMinuta.DataBind();
      this.GridDocumentosPoliza.DataSource = (object) CLinq.ListByProperty<dve_DocumentoVerificar>((DataContext) this.MyDataContext, "dve_Estado", (object) 5);
      this.GridDocumentosPoliza.DataBind();
      this.GridDocumentosEntrega.DataSource = (object) CLinq.ListByProperty<dve_DocumentoVerificar>((DataContext) this.MyDataContext, "dve_Estado", (object) 6);
      this.GridDocumentosEntrega.DataBind();
      if (((BaseModulo.strSendParam) this.LocalInfo.MyParams).id == 0)
        return;
      if (((BaseModulo.strSendParam) this.LocalInfo.MyParams).tipo == "Ver")
      {
        this.colapsibleCompraUno.Collapsed = false;
        this.CollapsibleElaboracionMinutas.Collapsed = false;
        this.CollapsibleEnvioEquipos.Collapsed = false;
        this.collapsibleEstudiosPrevios.Collapsed = false;
        this.CollapsibleTramitePoliza.Collapsed = false;
        CControl.Enable((Control) this.PanelDatosTercero, false);
        this.buttonGuardar.Enabled = false;
      }
      this.mostrarDatos(((BaseModulo.strSendParam) this.LocalInfo.MyParams).id);
      if ((int) this.LocalInfo.GetData("estado") == 1)
      {
        CControl.Enable(this.panelElaboracionMinutas.Controls, false);
        CControl.Enable(this.panelEstudiosPrevios.Controls, false);
        CControl.Enable(this.panelEnvioEquipos.Controls, false);
        CControl.Enable(this.panelTramitePoliza.Controls, false);
      }
      if ((int) this.LocalInfo.GetData("estado") == 2)
      {
        CControl.Enable(this.panelElaboracionMinutas.Controls, false);
        CControl.Enable(this.panelTramitePoliza.Controls, false);
        CControl.Enable(this.panelEnvioEquipos.Controls, false);
        this.CheckEtapaInicialAprobada.Checked = true;
      }
      if ((int) this.LocalInfo.GetData("estado") == 3)
      {
        CControl.Enable(this.panelTramitePoliza.Controls, false);
        CControl.Enable(this.panelEnvioEquipos.Controls, false);
        this.CheckEtapaInicialAprobada.Enabled = false;
        this.CheckEtapaEstudioAprobado.Enabled = false;
        this.CheckEtapaInicialAprobada.Checked = true;
      }
      if ((int) this.LocalInfo.GetData("estado") == 4)
      {
        CControl.Enable(this.panelEnvioEquipos.Controls, false);
        this.CheckEtapaInicialAprobada.Enabled = false;
        this.CheckEtapaEstudioAprobado.Enabled = false;
        this.CheckEtapaMinutaAprobado.Enabled = false;
        this.CheckEtapaInicialAprobada.Checked = true;
        this.CheckEtapaEstudioAprobado.Checked = true;
        this.CheckEtapaMinutaAprobado.Checked = true;
      }
      if ((int) this.LocalInfo.GetData("estado") == 5)
      {
        this.CheckEtapaInicialAprobada.Enabled = false;
        this.CheckEtapaEstudioAprobado.Enabled = false;
        this.CheckEtapaMinutaAprobado.Enabled = false;
        this.CheckEtapaInicialAprobada.Checked = true;
        this.CheckEtapaEstudioAprobado.Checked = true;
        this.CheckEtapaMinutaAprobado.Checked = true;
        this.CheckEtapaPolizaAprobado.Checked = true;
      }
      if ((int) this.LocalInfo.GetData("estado") == 6)
      {
        this.CheckEtapaInicialAprobada.Enabled = false;
        this.CheckEtapaEstudioAprobado.Enabled = false;
        this.CheckEtapaMinutaAprobado.Enabled = false;
        this.CheckEtapaPolizaAprobado.Enabled = false;
        this.CheckEtapaInicialAprobada.Checked = true;
        this.CheckEtapaEstudioAprobado.Checked = true;
        this.CheckEtapaMinutaAprobado.Checked = true;
        this.CheckEtapaPolizaAprobado.Checked = true;
        this.CheckEtapaEntregaAprobado.Checked = true;
      }
      if ((int) this.LocalInfo.GetData("estado") == 7)
      {
        this.CheckEtapaInicialAprobada.Enabled = false;
        this.CheckEtapaEstudioAprobado.Enabled = false;
        this.CheckEtapaMinutaAprobado.Enabled = false;
        this.CheckEtapaPolizaAprobado.Enabled = false;
        this.CheckEtapaInicialAprobada.Checked = true;
        this.CheckEtapaEstudioAprobado.Checked = true;
        this.CheckEtapaMinutaAprobado.Checked = true;
        this.CheckEtapaPolizaAprobado.Checked = true;
        this.CheckEtapaEntregaAprobado.Checked = true;
      }
      if ((int) this.LocalInfo.GetData("estado") == 8)
      {
        this.CheckEtapaInicialAprobada.Enabled = false;
        this.CheckEtapaEstudioAprobado.Enabled = false;
        this.CheckEtapaMinutaAprobado.Enabled = false;
        this.CheckEtapaPolizaAprobado.Enabled = false;
        this.CheckEtapaEntregaAprobado.Enabled = false;
        this.checkCancelar.Checked = true;
        this.checkCancelar.Enabled = false;
        this.buttonGuardar.Enabled = false;
      }
      this.mostrarVerificaDocumentos(this.GridEstudiosPrevios, (seq_SolicitudEquipo) this.LocalInfo.MyParams);
      this.mostrarVerificaDocumentos(this.GridDocumentosEntrega, (seq_SolicitudEquipo) this.LocalInfo.MyParams);
      this.mostrarVerificaDocumentos(this.GridDocumentosMinuta, (seq_SolicitudEquipo) this.LocalInfo.MyParams);
      this.mostrarVerificaDocumentos(this.GridDocumentosPoliza, (seq_SolicitudEquipo) this.LocalInfo.MyParams);
    }

    private void mostrarDatos(int id)
    {
      seq_SolicitudEquipo byKey1 = CLinq.FindByKey<seq_SolicitudEquipo>((DataContext) this.MyDataContext, (object) id);
      ter_Tercero byKey2 = CLinq.FindByKey<ter_Tercero>((DataContext) this.MyDataContext, (object) byKey1.ter_Id);
      if (byKey1.seq_ActaTransferencia.Value)
      {
        this.trCompraUno.Style["display"] = "none";
        this.trEstudiosPrevios.Style["display"] = "none";
        this.trElaboracionMinutas.Style["display"] = "none";
        this.trTramitePoliza.Style["display"] = "none";
        this.labelComodato.Text = "Acta de transferencia";
      }
      this.TextValorTotalSolicitud.Text = byKey1.seq_ValorTotal.ToString();
      this.textValorTotalAsignado.Text = byKey1.seq_ValorTotal.ToString();
      this.LocalInfo.SetData("valorTotal", (object) this.TextValorTotalSolicitud.Text);
      this.ActualizarDatosTercero(byKey2);
      this.ActualizarDatosGrilla(byKey1.sea_SolicitudEquiposAsignados);
      this.LocalInfo.SetData("listaEquiposSolicitados", (object) byKey1.sea_SolicitudEquiposAsignados);
      this.LocalInfo.MyParams = (object) byKey1;
      this.LocalInfo.SetData("estado", (object) byKey1.ses_Id);
      this.textObservacionesInicial.Text = byKey1.seq_ObservacionIncial;
      this.textObservacionesEstudiosPrevios.Text = byKey1.seq_ObservacionEstudioPrevio;
      if (byKey1.seq_TieneCertificacion.HasValue)
        this.CheckCertificacion.Checked = byKey1.seq_TieneCertificacion.Value;
      this.textFechaCertificacion.Text = byKey1.seq_FechaCertificacion.ToString();
      this.textFechaElaboracion.Text = byKey1.seq_FechaElaboracionMinuta.ToString();
      this.textFechaFirmaPoliza.Text = byKey1.seq_FechaFirmaMinuta.ToString();
      this.textObservacionesPoliza.Text = byKey1.seq_ObservacionPoliza;
      this.textFechaAprobacionPoliza.Text = byKey1.seq_FechaAprobacionPoliza.ToString();
      TextBox textFechaVigencia = this.textFechaVigencia;
      DateTime? nullable = byKey1.seq_FechaVigenciaPoliza;
      string str1 = nullable.ToString();
      textFechaVigencia.Text = str1;
      TextBox fechaPlazoPoliza = this.textFechaPlazoPoliza;
      nullable = byKey1.seq_FechaPlazoPoliza;
      string str2 = nullable.ToString();
      fechaPlazoPoliza.Text = str2;
      TextBox fechaPublicacion = this.textFechaPublicacion;
      nullable = byKey1.seq_FechaPublicacion;
      string str3 = nullable.ToString();
      fechaPublicacion.Text = str3;
      TextBox aprobacionPoliza = this.textFechaAprobacionPoliza;
      nullable = byKey1.seq_FechaAprobacionPoliza;
      string str4 = nullable.ToString();
      aprobacionPoliza.Text = str4;
      this.textComodato.Text = byKey1.seq_Comodato;
      TextBox textFechaEntrega = this.textFechaEntrega;
      nullable = byKey1.seq_FechaEntrega;
      string str5 = nullable.ToString();
      textFechaEntrega.Text = str5;
      this.textLugarEntrega.Text = byKey1.seq_LugarEntrega;
      this.textObservacionesMinutas.Text = byKey1.seq_ObservacionMinuta;
      this.textNumeroActa.Text = byKey1.seq_NumeroActa;
      this.CargarGrillaAsignados(byKey1.seq_Id);
      this.ActualizarDatosEquipos(this.gridEquiposAsignados);
      this.DocumentosVarios1.Init("Rrr.sdo_SolicitudDocumento", "seq_Id", byKey1.seq_Id.ToString(), this.MyDataContext.Connection.ConnectionString);
    }

    private void CargarGrillaAsignados(int id)
    {
      List<sea_SolicitudEquiposAsignado> solicitudEquiposAsignadoList = CLinq.ListByProperty<sea_SolicitudEquiposAsignado>((DataContext) this.MyDataContext, "seq_id", (object) id);
      List<AprobarSolicitudEquiposRegistrar.strSolicitudAsignado> solicitudAsignadoList = new List<AprobarSolicitudEquiposRegistrar.strSolicitudAsignado>();
      for (int index = 0; index <= solicitudEquiposAsignadoList.Count - 1; ++index)
        solicitudAsignadoList.Add(new AprobarSolicitudEquiposRegistrar.strSolicitudAsignado()
        {
          equipo = solicitudEquiposAsignadoList[index].eki_EquipoKit.eki_Descripcion,
          costo = solicitudEquiposAsignadoList[index].eki_EquipoKit.eki_costo.Value,
          cantidad = solicitudEquiposAsignadoList[index].sea_Cantidad.Value,
          id = solicitudEquiposAsignadoList[index].sea_Id
        });
      this.gridEquiposAsignados.DataSource = (object) solicitudAsignadoList;
      this.gridEquiposAsignados.DataBind();
    }

    private void ActualizarDatosTercero(ter_Tercero tercero)
    {
      this.LocalInfo.SetData("idTercero", (object) tercero.ter_Id);
      this.textNombreBeneficiario.Text = tercero.ter_NombreCompleto;
      this.textTipoDocumento.Text = tercero.dti_DocumentoTipo.dti_Descripcion;
      this.textDocumento.Text = tercero.ter_NumeroDocumento;
      this.textCorreo.Text = tercero.ter_Correo;
      this.textDireccion.Text = tercero.ter_Direccion;
      this.textDepartamento.Text = tercero.dep_Departamento.dep_Descripcion;
      this.textMunicipio.Text = tercero.mun_Municipio.mun_Descripcion;
      this.textTelefono.Text = tercero.ter_Tefono;
      this.textTipoBeneficiario.Text = tercero.bti_beneficiarioTipo.bti_Descripcion;
      this.textNombreRepresentante.Text = string.IsNullOrEmpty(tercero.ter_RepresentanteLegal) ? "" : tercero.ter_RepresentanteLegal;
      this.textTipoDocumentoRL.Text = tercero.dti_DocumentoTipo1 == null ? "" : tercero.dti_DocumentoTipo1.dti_Descripcion;
      this.textDocumentoRL.Text = string.IsNullOrEmpty(tercero.ter_NumeroDocumentoRepresentante) ? "" : tercero.ter_NumeroDocumentoRepresentante;
      this.MostrarDatosProyecto(CLinq.ListByProperty<tgr_TerceroGrupo>((DataContext) this.MyDataContext, "ter_id", (object) tercero.ter_Id));
    }

    private void MostrarDatosProyecto(List<tgr_TerceroGrupo> terceroGrupo)
    {
      List<AprobarSolicitudEquiposRegistrar.strGrupo> strGrupoList = new List<AprobarSolicitudEquiposRegistrar.strGrupo>();
      for (int index = 0; index <= terceroGrupo.Count - 1; ++index)
      {
        AprobarSolicitudEquiposRegistrar.strGrupo strGrupo = new AprobarSolicitudEquiposRegistrar.strGrupo();
        List<pyg_ProyectoGrupo> pygProyectoGrupoList = CLinq.ListByProperty<pyg_ProyectoGrupo>((DataContext) this.MyDataContext, "pyg_Id", (object) terceroGrupo[index].pyg_Id);
        strGrupo.grupo = pygProyectoGrupoList[0].pyg_Descripcion;
        strGrupoList.Add(strGrupo);
      }
      this.gridProyectoTercero.DataSource = (object) strGrupoList;
      this.gridProyectoTercero.DataBind();
    }

    private void ActualizarDatosGrilla(
      EntitySet<sea_SolicitudEquiposAsignado> listaEquiposAsignado)
    {
      int num = 0;
      for (int index = 0; index < listaEquiposAsignado.Count; ++index)
      {
        AprobarSolicitudEquiposRegistrar.strSolicitudAsignado solicitudAsignado = new AprobarSolicitudEquiposRegistrar.strSolicitudAsignado();
        solicitudAsignado.equipo = listaEquiposAsignado[index].eki_EquipoKit.eki_Descripcion;
        solicitudAsignado.costo = listaEquiposAsignado[index].eki_EquipoKit.eki_costo.Value;
        solicitudAsignado.cantidad = listaEquiposAsignado[index].sea_Cantidad.Value;
        solicitudAsignado.id = listaEquiposAsignado[index].eki_EquipoKit.kco_Id;
        solicitudAsignado.idProvisional = index;
        num = listaEquiposAsignado[index].eki_EquipoKit.kco_Id;
        this.listaSolicitudGrilla.Add(solicitudAsignado);
      }
      if (this.listaSolicitudGrilla.Count <= 0)
        return;
      this.gridSolicitudEquipos.DataSource = (object) this.listaSolicitudGrilla;
      this.gridSolicitudEquipos.DataBind();
      this.LocalInfo.SetData("listaSolicitudGrilla", (object) this.listaSolicitudGrilla);
    }

    protected void buttonGuardar_Click(object sender, EventArgs e)
    {
      try
      {
        this.ControlError1.Visible = false;
        seq_SolicitudEquipo myParams = (seq_SolicitudEquipo) this.LocalInfo.MyParams;
        int seqId;
        if (!this.checkCancelar.Checked)
        {
          myParams.seq_ObservacionIncial = this.textObservacionesInicial.Text.ToUpper();
          myParams.seq_ObservacionEstudioPrevio = this.textObservacionesEstudiosPrevios.Text.ToUpper();
          myParams.seq_ObservacionMinuta = this.textObservacionesMinutas.Text.ToUpper();
          if ((int) this.LocalInfo.GetData("estado") == 3 && this.CheckEtapaEstudioAprobado.Checked)
          {
            myParams.seq_TieneCertificacion = new bool?(this.CheckCertificacion.Checked);
            if (this.textFechaCertificacion.Text != "")
              myParams.seq_FechaCertificacion = new DateTime?(DateTime.Parse(this.textFechaCertificacion.Text));
            this.guardarVerificaDocumentos(this.GridEstudiosPrevios, myParams);
          }
          if ((int) this.LocalInfo.GetData("estado") == 2)
            this.guardarVerificaDocumentos(this.GridEstudiosPrevios, myParams);
          if ((int) this.LocalInfo.GetData("estado") == 4 && this.CheckEtapaMinutaAprobado.Checked)
          {
            myParams.seq_FechaElaboracionMinuta = this.textFechaElaboracion.Text != "" ? new DateTime?(DateTime.Parse(this.textFechaElaboracion.Text)) : throw new Exception("La fecha de elaboración de la minuta es obligatoria. <br />");
            myParams.seq_FechaFirmaMinuta = this.textFechaFirmaPoliza.Text != "" ? new DateTime?(DateTime.Parse(this.textFechaFirmaPoliza.Text)) : throw new Exception("La fecha de firma de la minuta es obligatoria. <br />");
            this.guardarVerificaDocumentos(this.GridDocumentosMinuta, myParams);
          }
          myParams.seq_ObservacionPoliza = this.textObservacionesPoliza.Text.ToUpper();
          if ((int) this.LocalInfo.GetData("estado") == 5 && this.CheckEtapaPolizaAprobado.Checked)
          {
            myParams.seq_FechaAprobacionPoliza = this.textFechaAprobacionPoliza.Text != "" ? new DateTime?(DateTime.Parse(this.textFechaAprobacionPoliza.Text)) : throw new Exception("La fecha de firma de la poliza es obligatoria. <br />");
            myParams.seq_FechaVigenciaPoliza = this.textFechaVigencia.Text != "" ? new DateTime?(DateTime.Parse(this.textFechaVigencia.Text)) : throw new Exception("La fecha de vigencia de la poliza es obligatoria. <br />");
            myParams.seq_FechaPlazoPoliza = this.textFechaPlazoPoliza.Text != "" ? new DateTime?(DateTime.Parse(this.textFechaPlazoPoliza.Text)) : throw new Exception("La fecha de plazo de la poliza es obligatoria. <br />");
            myParams.seq_FechaPublicacion = this.textFechaPublicacion.Text != "" ? new DateTime?(DateTime.Parse(this.textFechaPublicacion.Text)) : throw new Exception("La fecha de plazo de la publicación es obligatoria. <br />");
            this.guardarVerificaDocumentos(this.GridDocumentosPoliza, myParams);
          }
          if ((int) this.LocalInfo.GetData("estado") == 6)
            this.guardarDatosEquipos(this.gridEquiposAsignados, myParams);
          if ((int) this.LocalInfo.GetData("estado") == 6 && this.CheckEtapaEntregaAprobado.Checked)
          {
            myParams.seq_FechaEntrega = this.textFechaEntrega.Text != "" ? new DateTime?(DateTime.Parse(this.textFechaEntrega.Text)) : throw new Exception("La fecha de entrega de los equipos es obligatoria. <br />");
            myParams.seq_Comodato = this.textComodato.Text.ToUpper();
            myParams.seq_LugarEntrega = this.textLugarEntrega.Text.ToUpper();
            myParams.seq_NumeroActa = this.textNumeroActa.Text.ToUpper();
            this.guardarVerificaDocumentos(this.GridDocumentosEntrega, myParams);
          }
          myParams.ses_Id = 7;
          DocumentosVarios documentosVarios1 = this.DocumentosVarios1;
          seqId = myParams.seq_Id;
          string relationId = seqId.ToString();
          string connectionString = this.MyDataContext.Connection.ConnectionString;
          documentosVarios1.Init("Rrr.sdo_SolicitudDocumento", "seq_Id", relationId, connectionString);
        }
        else
        {
          int sesId = myParams.ses_Id;
          myParams.ses_Id = 8;
          if (sesId != 8)
          {
            for (int index = 0; index < myParams.sea_SolicitudEquiposAsignados.Count; ++index)
            {
              eki_EquipoKit ekiEquipoKit = myParams.sea_SolicitudEquiposAsignados[index].eki_EquipoKit;
              int? ekiDisponible = myParams.sea_SolicitudEquiposAsignados[index].eki_EquipoKit.eki_Disponible;
              int? seaCantidad = myParams.sea_SolicitudEquiposAsignados[index].sea_Cantidad;
              int? nullable = ekiDisponible.HasValue & seaCantidad.HasValue ? new int?(ekiDisponible.GetValueOrDefault() + seaCantidad.GetValueOrDefault()) : new int?();
              ekiEquipoKit.eki_Disponible = nullable;
            }
          }
        }
        this.MyDataContext.SubmitChanges();
        if ((int) this.LocalInfo.GetData("estado") == 0)
        {
          seqId = myParams.seq_Id;
          CAuditoria.log(EPermiso.AprobarSolicitudDeEquipos, seqId.ToString(), myParams.seq_Usuario, myParams.seq_FechaSolicitud.ToShortDateString(), "", "", this.Usuario.id);
        }
        else
        {
          seqId = myParams.seq_Id;
          CAuditoria.log(EPermiso.AprobarSolicitudDeEquipos, seqId.ToString(), myParams.seq_Usuario, myParams.seq_FechaSolicitud.ToShortDateString(), "", "", this.Usuario.id);
        }
        if (this.tipo == 1)
          this.Response.Redirect("~/Recuperacion/AprobarSolicitudEquiposBuscar.aspx");
        else
          this.Response.Redirect("~/Recuperacion/AprobarSolicitudEquiposBuscar.aspx?tipo=0");
      }
      catch (Exception ex)
      {
        this.ControlError1.Visible = true;
        this.ControlError1.Show(ex);
      }
    }

    private void ActualizarDatosEquipos(GridView gridEquiposAsignados)
    {
      int index = 0;
      foreach (GridViewRow row in gridEquiposAsignados.Rows)
      {
        TextBox control1 = row.FindControl("TextSerie") as TextBox;
        TextBox control2 = row.FindControl("TextPlaca") as TextBox;
        sea_SolicitudEquiposAsignado byKey = CLinq.FindByKey<sea_SolicitudEquiposAsignado>((DataContext) this.MyDataContext, (object) int.Parse(gridEquiposAsignados.DataKeys[index].Value.ToString()));
        if (byKey.sea_Serie != "")
          control1.Text = byKey.sea_Serie;
        if (byKey.sea_Placa != "")
          control2.Text = byKey.sea_Placa;
        ++index;
      }
    }

    private void guardarDatosEquipos(
      GridView gridEquiposAsignados,
      seq_SolicitudEquipo solicitudEquipo)
    {
      int index = 0;
      string message = "";
      bool flag = true;
      foreach (GridViewRow row in gridEquiposAsignados.Rows)
      {
        TextBox control1 = row.FindControl("TextSerie") as TextBox;
        sea_SolicitudEquiposAsignado byKey = CLinq.FindByKey<sea_SolicitudEquiposAsignado>((DataContext) this.MyDataContext, (object) int.Parse(gridEquiposAsignados.DataKeys[index].Value.ToString()));
        if (control1.Text != "")
        {
          byKey.sea_Serie = control1.Text;
        }
        else
        {
          message += "El número de serie es obligatorio. <br />";
          flag = false;
        }
        TextBox control2 = row.FindControl("TextPlaca") as TextBox;
        if (control2.Text != "")
        {
          byKey.sea_Placa = control2.Text;
        }
        else
        {
          message += "El número de placa es obligatorio. <br />";
          flag = false;
        }
        if (!flag)
          throw new Exception(message);
        ++index;
      }
    }

    private void guardarVerificaDocumentos(GridView grid, seq_SolicitudEquipo solicitudEquipo)
    {
      int index = 0;
      foreach (Control row in grid.Rows)
      {
        CheckBox control = row.FindControl("CheckDocumento") as CheckBox;
        if (control.Checked)
        {
          dvs_DocumentoVerificarSolicitud verificarSolicitud = (dvs_DocumentoVerificarSolicitud) null;
          int num = int.Parse(grid.DataKeys[index].Value.ToString());
          List<dvs_DocumentoVerificarSolicitud> verificarSolicitudList = CLinq.ListByProperties<dvs_DocumentoVerificarSolicitud>((DataContext) this.MyDataContext, (object) "seq_id", (object) solicitudEquipo.seq_Id, (object) "dve_id", (object) num);
          if (verificarSolicitudList.Count == 0)
            this.MyDataContext.dvs_DocumentoVerificarSolicituds.InsertOnSubmit(new dvs_DocumentoVerificarSolicitud()
            {
              seq_Id = solicitudEquipo.seq_Id,
              dve_Id = num
            });
          else
            verificarSolicitud = verificarSolicitudList[0];
          ++index;
        }
        else if (!control.Checked)
        {
          int num = int.Parse(grid.DataKeys[index].Value.ToString());
          List<dvs_DocumentoVerificarSolicitud> verificarSolicitudList = CLinq.ListByProperties<dvs_DocumentoVerificarSolicitud>((DataContext) this.MyDataContext, (object) "seq_id", (object) solicitudEquipo.seq_Id, (object) "dve_id", (object) num);
          if (verificarSolicitudList.Count > 0)
            this.MyDataContext.dvs_DocumentoVerificarSolicituds.DeleteOnSubmit(verificarSolicitudList[0]);
          ++index;
        }
      }
    }

    private void mostrarVerificaDocumentos(GridView grid, seq_SolicitudEquipo solicitudEquipo)
    {
      int index = 0;
      foreach (Control row in grid.Rows)
      {
        CheckBox control = row.FindControl("CheckDocumento") as CheckBox;
        int num = int.Parse(grid.DataKeys[index].Value.ToString());
        RecuperacionDataContext myDataContext = this.MyDataContext;
        object[] objArray = new object[4]
        {
          (object) "dve_id",
          (object) num,
          (object) "seq_Id",
          (object) solicitudEquipo.seq_Id
        };
        control.Checked = CLinq.ListByProperties<dvs_DocumentoVerificarSolicitud>((DataContext) myDataContext, objArray).Count > 0;
        ++index;
      }
    }

    protected void buttonCancelar_Click(object sender, EventArgs e)
    {
      if (this.tipo == 1)
        this.Response.Redirect("~/Recuperacion/AprobarSolicitudEquiposBuscar.aspx");
      else
        this.Response.Redirect("~/Recuperacion/AprobarSolicitudEquiposBuscar.aspx?tipo=0");
    }

    protected void CheckCertificacion_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckCertificacion.Checked)
      {
        this.labelFechaCertificación.Visible = true;
        this.textFechaCertificacion.Visible = true;
      }
      else
      {
        this.labelFechaCertificación.Visible = false;
        this.textFechaCertificacion.Visible = false;
      }
    }

    protected void CheckEtapaInicialAprobada_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckEtapaInicialAprobada.Checked)
        this.LocalInfo.SetData("estado", (object) 2);
      else
        this.LocalInfo.SetData("estado", (object) 1);
    }

    protected void CheckEtapaEstudioAprobado_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckEtapaEstudioAprobado.Checked)
        this.LocalInfo.SetData("estado", (object) 3);
      else
        this.LocalInfo.SetData("estado", (object) 2);
    }

    protected void CheckEtapaMinutaAprobado_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckEtapaMinutaAprobado.Checked)
        this.LocalInfo.SetData("estado", (object) 4);
      else
        this.LocalInfo.SetData("estado", (object) 3);
    }

    protected void CheckEtapaPolizaAprobado_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckEtapaPolizaAprobado.Checked)
        this.LocalInfo.SetData("estado", (object) 5);
      else
        this.LocalInfo.SetData("estado", (object) 4);
    }

    protected void CheckEtapaEntregaAprobado_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckEtapaEntregaAprobado.Checked)
        this.LocalInfo.SetData("estado", (object) 6);
      else
        this.LocalInfo.SetData("estado", (object) 5);
    }

    protected void buttonExportar0_Click(object sender, EventArgs e) => this.Exportar(this.gridSolicitudEquipos);

    protected void buttonExportar_Click(object sender, EventArgs e) => this.Exportar(this.gridEquiposAsignados);

    protected void checkCancelar_CheckedChanged(object sender, EventArgs e)
    {
      if (this.checkCancelar.Checked)
      {
        this.labelFechaCancelar.Visible = true;
        this.textFechaCancelar.Visible = true;
      }
      else
      {
        this.labelFechaCancelar.Visible = false;
        this.textFechaCancelar.Visible = false;
      }
    }

    public class strGrupo
    {
      private string _grupo;

      public string grupo
      {
        get => this._grupo;
        set => this._grupo = value;
      }
    }

    public class strSolicitudAsignado
    {
      private string _equipo;
      private int _cantidad;
      private Decimal _costo;
      private int _id;
      private int _idProvisional;

      public string equipo
      {
        get => this._equipo;
        set => this._equipo = value;
      }

      public int cantidad
      {
        get => this._cantidad;
        set => this._cantidad = value;
      }

      public Decimal costo
      {
        get => this._costo;
        set => this._costo = value;
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
