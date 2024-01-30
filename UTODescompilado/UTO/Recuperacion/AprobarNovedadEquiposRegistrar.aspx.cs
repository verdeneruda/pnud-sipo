// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.AprobarNovedadEquiposRegistrar
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
using System.Web.UI.WebControls;
using UTO.Comunes;

namespace UTO.Recuperacion
{
  public class AprobarNovedadEquiposRegistrar : BaseModulo
  {
    private EntitySet<nea_NovedadEquiposAsignado> listaEquiposSolicitados = new EntitySet<nea_NovedadEquiposAsignado>();
    private List<AprobarNovedadEquiposRegistrar.strSolicitudAsignado> listaSolicitudGrilla = new List<AprobarNovedadEquiposRegistrar.strSolicitudAsignado>();
    protected ToolkitScriptManager ToolkitScriptManager1;
    protected Label labelBusquedaSolicitudesEquipos;
    protected ControlError ControlError1;
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
    protected Label labelTipoNovedad;
    protected RadioButton RadioOtroSi;
    protected RadioButton RadioTerminacion;
    protected Label labelFechaNovedad;
    protected TextBox dateFechaNovedad;
    protected CalendarExtender dateFechaNovedad_CalendarExtender;
    protected CalendarExtender CalendarExtender3;
    protected LinkButton linkNovedad;
    protected ImageButton ImageButton1;
    protected CollapsiblePanelExtender CollapsibleNovedad;
    protected Panel PanelNovedad;
    protected Panel PanelOtroSi;
    protected Label label3;
    protected Panel PanelCambioDirección;
    protected CheckBox CheckCambioDirección;
    protected Label labelCambioDireccion;
    protected Label labelCambioDepartamento;
    protected Label labelCambioMunicipio;
    protected TextBox textCambioDireccion;
    protected DropDownList comboCambioDepartamento;
    protected DropDownList comboCambioCiudad;
    protected Panel PanelCambioRazonSocial;
    protected CheckBox CheckCambioRazonSocial;
    protected TextBox textCambioRazonSocial;
    protected Panel PanelRepresentanteLegal;
    protected CheckBox CheckRepresentanteLegal;
    protected Label labelCambioRepresentanteLegal;
    protected Label labelCambioTipoDocumentoRL;
    protected Label labelCambioDocumentoRL;
    protected TextBox textCambioRepresentanteLegal;
    protected DropDownList comboCambioTipoDocumentoRL;
    protected TextBox textCambioDocumentoRL;
    protected Panel PanelOtros;
    protected CheckBox CheckOtros;
    protected TextBox textOtros;
    protected Panel PanelEquipoAdicional;
    protected CheckBox CheckEquipoAdicional;
    protected Panel PanelEquipoReasignar;
    protected Label label6;
    protected Panel PanelEquipos;
    protected GridView gridSolicitudEquipos;
    protected Label label5;
    protected TextBox textValorTotal;
    protected Panel PanelTerminacion;
    protected Label label7;
    protected Label labelMotivo;
    protected TextBox textMotivoTerminacion;
    protected LinkButton LinkEstudiosPrevios;
    protected ImageButton ImageEstudiosPrevios;
    protected UpdatePanel UpdatePanelEstudiosPrevios;
    protected Panel panelEstudiosPrevios;
    protected GridView GridEstudiosPrevios;
    protected Label labelObservaciones;
    protected TextBox textObservacionesEstudiosPrevios;
    protected CheckBox CheckEtapaEstudioAprobado;
    protected CollapsiblePanelExtender collapsibleEstudiosPrevios;
    protected LinkButton LinkElaboracionMinutas;
    protected ImageButton ImageElaboracionMinutas;
    protected UpdatePanel UpdatePanelElaboracionMinuta;
    protected Panel panelElaboracionMinutas;
    protected GridView GridDocumentosMinuta;
    protected Label labelFechaElaboracion;
    protected TextBox textFechaElaboracion;
    protected CalendarExtender CalendarExtender1;
    protected Label labelFechaFirmadaMinuta;
    protected TextBox textFechaFirmaMinuta;
    protected CalendarExtender textFechaFirmaMinuta_CalendarExtender;
    protected Label labelObservaciones0;
    protected TextBox textObservacionesMinutas;
    protected Label labelNumeroOtroSi;
    protected TextBox textNumeroOtroSi;
    protected CheckBox CheckEtapaMinutaAprobado;
    protected CollapsiblePanelExtender CollapsibleElaboracionMinutas;
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
    protected Button buttonExportar;
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
    protected TextBox textActaEntrega;
    protected CheckBox CheckEtapaEntregaAprobado;
    protected CollapsiblePanelExtender CollapsibleEnvioEquipos;
    protected Label label2;
    protected DocumentosVarios DocumentosVarios1;
    protected Button buttonGuardar;
    protected Button buttonCancelar;

    protected new void Page_Load(object sender, EventArgs e)
    {
      this.ControlError1.Visible = false;
      if (this.IsPostBack)
        return;
      this.InitData();
    }

    private void InitData()
    {
      this.LocalInfo.SetData("idSolicitud", (object) ((BaseModulo.strSendParam) this.LocalInfo.MyParams).id);
      this.GridEstudiosPrevios.DataSource = (object) CLinq.ListByProperty<dve_DocumentoVerificar>((DataContext) this.MyDataContext, "dve_Estado", (object) 3);
      this.GridEstudiosPrevios.DataBind();
      this.GridDocumentosMinuta.DataSource = (object) CLinq.ListByProperty<dve_DocumentoVerificar>((DataContext) this.MyDataContext, "dve_Estado", (object) 4);
      this.GridDocumentosMinuta.DataBind();
      this.GridDocumentosPoliza.DataSource = (object) CLinq.ListByProperty<dve_DocumentoVerificar>((DataContext) this.MyDataContext, "dve_Estado", (object) 5);
      this.GridDocumentosPoliza.DataBind();
      this.GridDocumentosEntrega.DataSource = (object) CLinq.ListByProperty<dve_DocumentoVerificar>((DataContext) this.MyDataContext, "dve_Estado", (object) 6);
      this.GridDocumentosEntrega.DataBind();
      this.comboCambioDepartamento.DataSource = (object) CLinq.ListAll<dep_Departamento>((DataContext) this.MyDataContext);
      this.comboCambioDepartamento.Items.Insert(0, "");
      this.comboCambioDepartamento.DataBind();
      this.comboCambioTipoDocumentoRL.DataSource = (object) CLinq.ListAll<dti_DocumentoTipo>((DataContext) this.MyDataContext);
      this.comboCambioTipoDocumentoRL.Items.Insert(0, "");
      this.comboCambioTipoDocumentoRL.DataBind();
      if (((BaseModulo.strSendParam) this.LocalInfo.MyParams).id == 0)
        return;
      if (((BaseModulo.strSendParam) this.LocalInfo.MyParams).tipo == "Ver")
      {
        this.CollapsibleElaboracionMinutas.Collapsed = false;
        this.CollapsibleEnvioEquipos.Collapsed = false;
        this.collapsibleEstudiosPrevios.Collapsed = false;
        this.CollapsibleNovedad.Collapsed = false;
        this.CollapsibleTramitePoliza.Collapsed = false;
        CControl.Enable((Control) this.PanelDatosTercero, false);
        this.buttonGuardar.Enabled = false;
      }
      this.mostrarDatos(((BaseModulo.strSendParam) this.LocalInfo.MyParams).id);
      if ((int) this.LocalInfo.GetData("estado") == 1)
      {
        CControl.Enable((Control) this.panelElaboracionMinutas, false);
        CControl.Enable((Control) this.panelTramitePoliza, false);
        CControl.Enable((Control) this.panelEnvioEquipos, false);
      }
      if ((int) this.LocalInfo.GetData("estado") == 2)
      {
        CControl.Enable((Control) this.panelElaboracionMinutas, false);
        CControl.Enable((Control) this.panelTramitePoliza, false);
        CControl.Enable((Control) this.panelEnvioEquipos, false);
      }
      if ((int) this.LocalInfo.GetData("estado") == 3)
      {
        this.CheckEtapaEstudioAprobado.Enabled = false;
        this.CheckEtapaEstudioAprobado.Checked = true;
        CControl.Enable((Control) this.panelTramitePoliza, false);
        CControl.Enable((Control) this.panelEnvioEquipos, false);
      }
      if ((int) this.LocalInfo.GetData("estado") == 4)
      {
        this.CheckEtapaEstudioAprobado.Enabled = false;
        this.CheckEtapaMinutaAprobado.Enabled = false;
        this.CheckEtapaEstudioAprobado.Checked = true;
        this.CheckEtapaMinutaAprobado.Checked = true;
        CControl.Enable((Control) this.panelEnvioEquipos, false);
      }
      if ((int) this.LocalInfo.GetData("estado") == 5)
      {
        this.CheckEtapaEstudioAprobado.Enabled = false;
        this.CheckEtapaMinutaAprobado.Enabled = false;
        this.CheckEtapaEstudioAprobado.Checked = true;
        this.CheckEtapaMinutaAprobado.Checked = true;
        this.CheckEtapaPolizaAprobado.Checked = true;
      }
      if ((int) this.LocalInfo.GetData("estado") == 6)
      {
        this.CheckEtapaEstudioAprobado.Enabled = false;
        this.CheckEtapaMinutaAprobado.Enabled = false;
        this.CheckEtapaPolizaAprobado.Enabled = false;
        this.CheckEtapaEstudioAprobado.Checked = true;
        this.CheckEtapaMinutaAprobado.Checked = true;
        this.CheckEtapaPolizaAprobado.Checked = true;
        this.CheckEtapaEntregaAprobado.Checked = true;
      }
      if ((int) this.LocalInfo.GetData("estado") == 7)
      {
        this.CheckEtapaEstudioAprobado.Checked = true;
        this.CheckEtapaMinutaAprobado.Checked = true;
        this.CheckEtapaPolizaAprobado.Checked = true;
        this.CheckEtapaEntregaAprobado.Checked = true;
        CControl.Enable((Control) this.panelElaboracionMinutas, false);
        CControl.Enable((Control) this.panelEstudiosPrevios, false);
        CControl.Enable((Control) this.panelTramitePoliza, false);
        CControl.Enable((Control) this.panelEnvioEquipos, false);
      }
      this.mostrarVerificaDocumentos(this.GridEstudiosPrevios, (neq_NovedadEquipo) this.LocalInfo.MyParams);
      this.mostrarVerificaDocumentos(this.GridDocumentosEntrega, (neq_NovedadEquipo) this.LocalInfo.MyParams);
      this.mostrarVerificaDocumentos(this.GridDocumentosMinuta, (neq_NovedadEquipo) this.LocalInfo.MyParams);
      this.mostrarVerificaDocumentos(this.GridDocumentosPoliza, (neq_NovedadEquipo) this.LocalInfo.MyParams);
    }

    private void guardarVerificaDocumentos(GridView grid, neq_NovedadEquipo solicitudEquipo)
    {
      int index = 0;
      foreach (Control row in grid.Rows)
      {
        CheckBox control = row.FindControl("CheckDocumento") as CheckBox;
        if (control.Checked)
        {
          dvn_DocumentoVerificarNovedad verificarNovedad = (dvn_DocumentoVerificarNovedad) null;
          int num = int.Parse(grid.DataKeys[index].Value.ToString());
          List<dvn_DocumentoVerificarNovedad> verificarNovedadList = CLinq.ListByProperties<dvn_DocumentoVerificarNovedad>((DataContext) this.MyDataContext, (object) "neq_id", (object) solicitudEquipo.neq_Id, (object) "dve_id", (object) num);
          if (verificarNovedadList.Count == 0)
            this.MyDataContext.dvn_DocumentoVerificarNovedads.InsertOnSubmit(new dvn_DocumentoVerificarNovedad()
            {
              neq_Id = solicitudEquipo.neq_Id,
              dve_Id = num
            });
          else
            verificarNovedad = verificarNovedadList[0];
          ++index;
        }
        else if (!control.Checked)
        {
          int num = int.Parse(grid.DataKeys[index].Value.ToString());
          List<dvn_DocumentoVerificarNovedad> verificarNovedadList = CLinq.ListByProperties<dvn_DocumentoVerificarNovedad>((DataContext) this.MyDataContext, (object) "neq_id", (object) solicitudEquipo.neq_Id, (object) "dve_id", (object) num);
          if (verificarNovedadList.Count > 0)
            this.MyDataContext.dvn_DocumentoVerificarNovedads.DeleteOnSubmit(verificarNovedadList[0]);
          ++index;
        }
      }
    }

    private void mostrarVerificaDocumentos(GridView grid, neq_NovedadEquipo solicitudEquipo)
    {
      int index = 0;
      foreach (Control row in grid.Rows)
      {
        CheckBox control = row.FindControl("CheckDocumento") as CheckBox;
        if (CLinq.ListByProperties<dvn_DocumentoVerificarNovedad>((DataContext) this.MyDataContext, (object) "dve_id", (object) int.Parse(grid.DataKeys[index].Value.ToString()), (object) "neq_Id", (object) solicitudEquipo.neq_Id).Count > 0)
          control.Checked = true;
        else if (control != null)
          control.Checked = false;
        ++index;
      }
    }

    private void mostrarDatos(int id)
    {
      neq_NovedadEquipo byKey = CLinq.FindByKey<neq_NovedadEquipo>((DataContext) this.MyDataContext, (object) id);
      this.ActualizarDatosTercero(CLinq.FindByKey<ter_Tercero>((DataContext) this.MyDataContext, (object) byKey.seq_SolicitudEquipo.ter_Id));
      this.dateFechaNovedad.Text = byKey.neq_FechaNovedad.ToString();
      if (byKey.nti_Id == 2)
      {
        this.RadioOtroSi.Checked = true;
        this.PanelOtroSi.Visible = true;
        if (byKey.neq_Direccion != null)
        {
          this.CheckCambioDirección.Visible = true;
          this.CheckCambioDirección.Checked = true;
          this.textCambioDireccion.Visible = true;
          this.comboCambioDepartamento.Visible = true;
          this.comboCambioCiudad.Visible = true;
          this.labelCambioDireccion.Visible = true;
          this.labelCambioDepartamento.Visible = true;
          this.labelCambioMunicipio.Visible = true;
          this.PanelCambioDirección.Visible = true;
          this.textCambioDireccion.Text = byKey.neq_Direccion;
          this.comboCambioDepartamento.SelectedValue = byKey.dep_Id;
          this.listarMunicipio(this.comboCambioDepartamento.SelectedValue);
          this.comboCambioCiudad.SelectedValue = byKey.mun_Id;
          this.panelTramitePoliza.Visible = false;
          this.panelEnvioEquipos.Visible = false;
        }
        if (byKey.neq_RazonSocial != null)
        {
          this.CheckCambioRazonSocial.Visible = true;
          this.CheckCambioRazonSocial.Checked = true;
          this.textCambioRazonSocial.Visible = true;
          this.PanelCambioRazonSocial.Visible = true;
          this.textCambioRazonSocial.Text = byKey.neq_RazonSocial;
          this.panelTramitePoliza.Visible = false;
          this.panelEnvioEquipos.Visible = false;
        }
        if (byKey.neq_RepresentanteLegal != null)
        {
          this.CheckRepresentanteLegal.Visible = true;
          this.CheckRepresentanteLegal.Checked = true;
          this.PanelRepresentanteLegal.Visible = true;
          this.textCambioRepresentanteLegal.Visible = true;
          this.textCambioDocumentoRL.Visible = true;
          this.comboCambioTipoDocumentoRL.Visible = true;
          this.labelCambioDocumentoRL.Visible = true;
          this.labelCambioTipoDocumentoRL.Visible = true;
          this.labelCambioRepresentanteLegal.Visible = true;
          this.textCambioRepresentanteLegal.Text = byKey.neq_RepresentanteLegal;
          this.comboCambioTipoDocumentoRL.SelectedValue = byKey.dti_Id.ToString();
          this.textCambioDocumentoRL.Text = byKey.neq_NumeroDocumento;
          this.panelTramitePoliza.Visible = false;
          this.panelEnvioEquipos.Visible = false;
        }
        if (byKey.neq_Otros != null)
        {
          this.CheckOtros.Visible = true;
          this.CheckOtros.Checked = true;
          this.textOtros.Visible = true;
          this.PanelOtros.Visible = true;
          this.textOtros.Text = byKey.neq_Otros;
          this.panelTramitePoliza.Visible = false;
          this.panelEnvioEquipos.Visible = false;
        }
        if (byKey.nea_NovedadEquiposAsignados.Count > 0)
        {
          this.CheckEquipoAdicional.Visible = true;
          this.CheckEquipoAdicional.Checked = true;
          this.PanelEquipoReasignar.Visible = true;
          this.PanelEquipoAdicional.Visible = true;
          this.textValorTotal.Text = byKey.neq_ValorTotal.ToString();
          this.textValorTotalAsignado.Text = byKey.neq_ValorTotal.ToString();
          this.ActualizarDatosGrilla(byKey.nea_NovedadEquiposAsignados, this.gridSolicitudEquipos);
          this.CargarGrillaAsignados(byKey.neq_Id);
          this.LocalInfo.SetData("listaEquiposSolicitados", (object) byKey.nea_NovedadEquiposAsignados);
          this.ActualizarDatosEquipos(this.gridEquiposAsignados);
        }
      }
      else if (byKey.nti_Id == 3)
      {
        this.RadioTerminacion.Checked = true;
        this.PanelTerminacion.Visible = true;
        this.textMotivoTerminacion.Text = byKey.neq_MotivoTerminacion;
        this.panelTramitePoliza.Visible = false;
        this.panelEnvioEquipos.Visible = false;
      }
      this.LocalInfo.SetData("estado", (object) byKey.nes_Id);
      this.textObservacionesEstudiosPrevios.Text = byKey.neq_ObservacionEstudioPrevio;
      this.textFechaElaboracion.Text = byKey.neq_FechaElaboracionMinuta.ToString();
      this.textFechaFirmaMinuta.Text = byKey.neq_FechaFirmaMinuta.ToString();
      this.textObservacionesPoliza.Text = byKey.neq_ObservacionPoliza;
      this.textFechaAprobacionPoliza.Text = byKey.neq_FechaAprobacionPoliza.ToString();
      TextBox textFechaVigencia = this.textFechaVigencia;
      DateTime? nullable = byKey.neq_FechaVigenciaPoliza;
      string str1 = nullable.ToString();
      textFechaVigencia.Text = str1;
      TextBox fechaPlazoPoliza = this.textFechaPlazoPoliza;
      nullable = byKey.neq_FechaPlazoPoliza;
      string str2 = nullable.ToString();
      fechaPlazoPoliza.Text = str2;
      TextBox fechaPublicacion = this.textFechaPublicacion;
      nullable = byKey.neq_FechaPublicacion;
      string str3 = nullable.ToString();
      fechaPublicacion.Text = str3;
      TextBox aprobacionPoliza = this.textFechaAprobacionPoliza;
      nullable = byKey.neq_FechaAprobacionPoliza;
      string str4 = nullable.ToString();
      aprobacionPoliza.Text = str4;
      this.textNumeroOtroSi.Text = byKey.neq_NumeroOtroSi;
      this.textComodato.Text = byKey.neq_Comodato;
      TextBox textFechaEntrega = this.textFechaEntrega;
      nullable = byKey.neq_FechaEntrega;
      string str5 = nullable.ToString();
      textFechaEntrega.Text = str5;
      this.textLugarEntrega.Text = byKey.neq_LugarEntrega;
      this.textObservacionesMinutas.Text = byKey.neq_ObservacionMinuta;
      this.textNumeroOtroSi.Text = byKey.neq_NumeroOtroSi;
      this.textActaEntrega.Text = byKey.neq_NumeroActa;
      this.LocalInfo.MyParams = (object) byKey;
      if (byKey.nes_Id == 7)
        CControl.Enable((Control) this.panelEstudiosPrevios, false);
      this.DocumentosVarios1.Init("Rrr.ndo_NovedadDocumento", "neq_Id", byKey.neq_Id.ToString(), this.MyDataContext.Connection.ConnectionString);
    }

    private void ActualizarDatosGrilla(
      EntitySet<nea_NovedadEquiposAsignado> listaEquiposAsignado,
      GridView grid)
    {
      int num1 = 0;
      for (int index = 0; index < listaEquiposAsignado.Count; ++index)
      {
        AprobarNovedadEquiposRegistrar.strSolicitudAsignado solicitudAsignado1 = new AprobarNovedadEquiposRegistrar.strSolicitudAsignado();
        if (num1 != listaEquiposAsignado[index].eki_EquipoKit.kco_Id)
        {
          solicitudAsignado1.equipo = listaEquiposAsignado[index].eki_EquipoKit.kco_Id != 1 ? listaEquiposAsignado[index].eki_EquipoKit.kco_KitCompra.kco_Descripcion : listaEquiposAsignado[index].eki_EquipoKit.eki_Descripcion;
          solicitudAsignado1.costo = listaEquiposAsignado[index].eki_EquipoKit.eki_costo.Value;
          AprobarNovedadEquiposRegistrar.strSolicitudAsignado solicitudAsignado2 = solicitudAsignado1;
          int? nullable = listaEquiposAsignado[index].eki_EquipoKit.eki_Disponible;
          int num2 = nullable.Value;
          solicitudAsignado2.disponible = num2;
          AprobarNovedadEquiposRegistrar.strSolicitudAsignado solicitudAsignado3 = solicitudAsignado1;
          nullable = listaEquiposAsignado[index].nea_Cantidad;
          int num3 = nullable.Value;
          solicitudAsignado3.cantidad = num3;
          solicitudAsignado1.id = listaEquiposAsignado[index].eki_EquipoKit.kco_Id;
          solicitudAsignado1.idProvisional = index;
          num1 = listaEquiposAsignado[index].eki_EquipoKit.kco_Id;
          this.listaSolicitudGrilla.Add(solicitudAsignado1);
        }
      }
      if (this.listaSolicitudGrilla.Count <= 0)
        return;
      grid.DataSource = (object) this.listaSolicitudGrilla;
      grid.DataBind();
      this.LocalInfo.SetData("listaSolicitudGrilla", (object) this.listaSolicitudGrilla);
    }

    private void CargarGrillaAsignados(int id)
    {
      List<nea_NovedadEquiposAsignado> novedadEquiposAsignadoList = CLinq.ListByProperty<nea_NovedadEquiposAsignado>((DataContext) this.MyDataContext, "neq_id", (object) id);
      List<AprobarNovedadEquiposRegistrar.strSolicitudAsignado> solicitudAsignadoList = new List<AprobarNovedadEquiposRegistrar.strSolicitudAsignado>();
      for (int index = 0; index <= novedadEquiposAsignadoList.Count - 1; ++index)
        solicitudAsignadoList.Add(new AprobarNovedadEquiposRegistrar.strSolicitudAsignado()
        {
          equipo = novedadEquiposAsignadoList[index].eki_EquipoKit.eki_Descripcion,
          costo = novedadEquiposAsignadoList[index].eki_EquipoKit.eki_costo.Value,
          cantidad = novedadEquiposAsignadoList[index].nea_Cantidad.Value,
          id = novedadEquiposAsignadoList[index].nea_Id
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
      CLinq.ListByProperty<tpr_TerceroProyecto>((DataContext) this.MyDataContext, "ter_id", (object) tercero.ter_Id);
    }

    protected void buttonGuardar_Click(object sender, EventArgs e)
    {
      try
      {
        this.ControlError1.Visible = false;
        neq_NovedadEquipo myParams = (neq_NovedadEquipo) this.LocalInfo.MyParams;
        myParams.neq_ObservacionEstudioPrevio = this.textObservacionesEstudiosPrevios.Text;
        myParams.neq_ObservacionMinuta = this.textObservacionesMinutas.Text;
        if ((int) this.LocalInfo.GetData("estado") == 3 && this.CheckEtapaEstudioAprobado.Checked)
          this.guardarVerificaDocumentos(this.GridEstudiosPrevios, myParams);
        if ((int) this.LocalInfo.GetData("estado") == 4 && this.CheckEtapaMinutaAprobado.Checked)
        {
          myParams.neq_FechaElaboracionMinuta = this.textFechaElaboracion.Text != "" ? new DateTime?(DateTime.Parse(this.textFechaElaboracion.Text)) : throw new Exception("La fecha de elaboración de la minuta es obligatoria. <br />");
          myParams.neq_FechaFirmaMinuta = this.textFechaFirmaMinuta.Text != "" ? new DateTime?(DateTime.Parse(this.textFechaFirmaMinuta.Text)) : throw new Exception("La fecha de firma de la minuta es obligatoria. <br />");
          myParams.neq_NumeroOtroSi = this.textNumeroOtroSi.Text != "" ? this.textNumeroOtroSi.Text : throw new Exception("El número del OtroSi es un campo obligatorio. <br />");
          this.guardarVerificaDocumentos(this.GridDocumentosMinuta, myParams);
          if (myParams.nea_NovedadEquiposAsignados.Count == 0)
          {
            myParams.nes_Id = 7;
            this.LocalInfo.SetData("estado", (object) myParams.nes_Id);
            this.ActualizarNovedad(myParams);
          }
        }
        myParams.neq_ObservacionPoliza = this.textObservacionesPoliza.Text;
        if ((int) this.LocalInfo.GetData("estado") == 5 && this.CheckEtapaPolizaAprobado.Checked)
        {
          myParams.neq_FechaAprobacionPoliza = this.textFechaAprobacionPoliza.Text != "" ? new DateTime?(DateTime.Parse(this.textFechaAprobacionPoliza.Text)) : throw new Exception("La fecha de firma de la poliza es obligatoria. <br />");
          myParams.neq_FechaVigenciaPoliza = this.textFechaVigencia.Text != "" ? new DateTime?(DateTime.Parse(this.textFechaVigencia.Text)) : throw new Exception("La fecha de vigencia de la poliza es obligatoria. <br />");
          myParams.neq_FechaPlazoPoliza = this.textFechaPlazoPoliza.Text != "" ? new DateTime?(DateTime.Parse(this.textFechaPlazoPoliza.Text)) : throw new Exception("La fecha de plazo de la poliza es obligatoria. <br />");
          myParams.neq_FechaPublicacion = this.textFechaPublicacion.Text != "" ? new DateTime?(DateTime.Parse(this.textFechaPublicacion.Text)) : throw new Exception("La fecha de plazo de la publicación es obligatoria. <br />");
          this.guardarVerificaDocumentos(this.GridDocumentosPoliza, myParams);
        }
        if ((int) this.LocalInfo.GetData("estado") == 6)
          this.guardarDatosEquipos(this.gridEquiposAsignados, myParams);
        if ((int) this.LocalInfo.GetData("estado") == 6 && this.CheckEtapaEntregaAprobado.Checked)
        {
          myParams.neq_FechaEntrega = this.textFechaEntrega.Text != "" ? new DateTime?(DateTime.Parse(this.textFechaEntrega.Text)) : throw new Exception("La fecha de entrega de los equipos es obligatoria. <br />");
          myParams.nes_Id = 7;
          this.LocalInfo.SetData("estado", (object) myParams.nes_Id);
          this.ActualizarNovedad(myParams);
          myParams.neq_Comodato = this.textComodato.Text;
          myParams.neq_LugarEntrega = this.textLugarEntrega.Text;
          myParams.neq_NumeroActa = this.textActaEntrega.Text;
          this.guardarVerificaDocumentos(this.GridDocumentosEntrega, myParams);
        }
        myParams.nes_Id = (int) this.LocalInfo.GetData("estado");
        this.DocumentosVarios1.Init("Rrr.ndo_NovedadDocumento", "neq_Id", myParams.neq_Id.ToString(), this.MyDataContext.Connection.ConnectionString);
        this.MyDataContext.SubmitChanges();
        CAuditoria.log(EPermiso.AprobarNovedadesDeEquipos, myParams.neq_Id.ToString(), myParams.neq_Usuario, myParams.neq_NumeroDocumento == null ? "" : myParams.neq_NumeroDocumento, "", "", this.Usuario.id);
        this.Response.Redirect("~/Recuperacion/AprobarNovedadEquiposBuscar.aspx");
      }
      catch (Exception ex)
      {
        this.ControlError1.Visible = true;
        this.ControlError1.Show(ex);
      }
    }

    private void ActualizarNovedad(neq_NovedadEquipo NovedadEquipo)
    {
      seq_SolicitudEquipo byKey1 = CLinq.FindByKey<seq_SolicitudEquipo>((DataContext) this.MyDataContext, (object) NovedadEquipo.seq_Id);
      ter_Tercero byKey2 = CLinq.FindByKey<ter_Tercero>((DataContext) this.MyDataContext, (object) byKey1.ter_Id);
      if (NovedadEquipo.neq_Direccion != null)
      {
        byKey2.ter_Direccion = this.textDireccion.Text;
        dep_Departamento byKey3 = CLinq.FindByKey<dep_Departamento>((DataContext) this.MyDataContext, (object) this.comboCambioDepartamento.SelectedValue);
        byKey2.dep_Departamento = byKey3;
        mun_Municipio byKey4 = CLinq.FindByKey<mun_Municipio>((DataContext) this.MyDataContext, (object) this.comboCambioCiudad.SelectedValue);
        byKey2.mun_Municipio = byKey4;
      }
      if (NovedadEquipo.neq_RazonSocial != null)
        byKey2.ter_NombreCompleto = this.textCambioRazonSocial.Text;
      if (NovedadEquipo.neq_RepresentanteLegal != null)
      {
        byKey2.ter_RepresentanteLegal = this.textCambioRepresentanteLegal.Text;
        byKey2.ter_NumeroDocumentoRepresentante = this.textCambioDocumentoRL.Text;
        byKey2.dti_IdRepresentante = new int?(int.Parse(this.comboCambioTipoDocumentoRL.SelectedValue));
      }
      if (NovedadEquipo.neq_Otros == null)
        ;
      if (NovedadEquipo.nea_NovedadEquiposAsignados.Count > 0)
      {
        for (int index = 0; index <= NovedadEquipo.nea_NovedadEquiposAsignados.Count - 1; ++index)
          this.MyDataContext.sea_SolicitudEquiposAsignados.InsertOnSubmit(new sea_SolicitudEquiposAsignado()
          {
            seq_Id = NovedadEquipo.seq_Id,
            eki_Id = new int?(NovedadEquipo.nea_NovedadEquiposAsignados[index].eki_Id),
            sea_Cantidad = NovedadEquipo.nea_NovedadEquiposAsignados[index].nea_Cantidad,
            sea_Placa = NovedadEquipo.nea_NovedadEquiposAsignados[index].nea_Placa,
            sea_Serie = NovedadEquipo.nea_NovedadEquiposAsignados[index].nea_Serie
          });
      }
      else
      {
        if (NovedadEquipo.nti_Id != 3)
          return;
        byKey1.seq_Activo = new bool?(false);
      }
    }

    protected void buttonCancelar_Click(object sender, EventArgs e) => this.Response.Redirect("~/Recuperacion/AprobarNovedadEquiposBuscar.aspx");

    protected void listarMunicipio(string departamento)
    {
      List<mun_Municipio> munMunicipioList = CLinq.ListByProperty<mun_Municipio>((DataContext) this.MyDataContext, "dep_Id", (object) departamento);
      this.comboCambioCiudad.SelectedValue = (string) null;
      if (munMunicipioList.Count > 0)
      {
        this.comboCambioCiudad.DataSource = (object) munMunicipioList;
        this.comboCambioCiudad.DataBind();
        this.comboCambioCiudad.Items.Insert(0, "");
      }
      else
        this.comboCambioCiudad.Items.Insert(0, "");
    }

    private void ActualizarDatosEquipos(GridView gridEquiposAsignados)
    {
      int index = 0;
      foreach (GridViewRow row in gridEquiposAsignados.Rows)
      {
        TextBox control1 = row.FindControl("TextSerie") as TextBox;
        TextBox control2 = row.FindControl("TextPlaca") as TextBox;
        nea_NovedadEquiposAsignado byKey = CLinq.FindByKey<nea_NovedadEquiposAsignado>((DataContext) this.MyDataContext, (object) int.Parse(gridEquiposAsignados.DataKeys[index].Value.ToString()));
        if (byKey.nea_Serie != "")
          control1.Text = byKey.nea_Serie;
        if (byKey.nea_Placa != "")
          control2.Text = byKey.nea_Placa;
        ++index;
      }
    }

    private void guardarDatosEquipos(GridView gridEquiposAsignados, neq_NovedadEquipo novedadEquipo)
    {
      int index = 0;
      string message = "";
      bool flag = true;
      foreach (GridViewRow row in gridEquiposAsignados.Rows)
      {
        TextBox control1 = row.FindControl("TextSerie") as TextBox;
        nea_NovedadEquiposAsignado byKey = CLinq.FindByKey<nea_NovedadEquiposAsignado>((DataContext) this.MyDataContext, (object) int.Parse(gridEquiposAsignados.DataKeys[index].Value.ToString()));
        if (control1.Text != "")
        {
          byKey.nea_Serie = control1.Text;
        }
        else
        {
          message += "El número de serie es obligatorio. <br />";
          flag = false;
        }
        TextBox control2 = row.FindControl("TextPlaca") as TextBox;
        if (control2.Text != "")
        {
          byKey.nea_Placa = control2.Text;
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

    protected void buttonExportar_Click(object sender, EventArgs e) => this.Exportar(this.gridEquiposAsignados);

    public class strSolicitudAsignado
    {
      private string _equipo;
      private int _disponible;
      private int _cantidad;
      private Decimal _costo;
      private int _id;
      private int _idProvisional;

      public string equipo
      {
        get => this._equipo;
        set => this._equipo = value;
      }

      public int disponible
      {
        get => this._disponible;
        set => this._disponible = value;
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
