// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.SolicitudEquiposRegistrar
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using AjaxControlToolkit;
using NE.CLib;
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
  public class SolicitudEquiposRegistrar : BaseModulo
  {
    private EntitySet<sea_SolicitudEquiposAsignado> listaEquiposSolicitados = new EntitySet<sea_SolicitudEquiposAsignado>();
    private List<SolicitudEquiposRegistrar.strSolicitudAsignado> listaSolicitudGrilla = new List<SolicitudEquiposRegistrar.strSolicitudAsignado>();
    protected ToolkitScriptManager ToolkitScriptManager1;
    protected Label labelBusquedaSolicitudesEquipos;
    protected Panel PanelBuscarTercero;
    protected Label labelparametros;
    protected Label labelNombreBeneficiario;
    protected TextBox textNombreBeneficiarioBuscar;
    protected Label label3;
    protected DropDownList comboTipoDocumentoBuscar;
    protected Label labelNumeroDocumento;
    protected TextBox textNumeroDocumentoBuscar;
    protected Button buttonBuscarTercero;
    protected Button buttonAdicionarTercero;
    protected GridView GridViewTerceroBuscar;
    protected SqlDataSource dsBuscarTercero;
    protected Panel PanelDatosTercero;
    protected ControlError ControlError1;
    protected Label label1;
    protected Label labelNombreBeneficiario0;
    protected TextBox textNombreBeneficiario;
    protected Label labelDocumento;
    protected TextBox textDocumento;
    protected Label labelTipoDocumento;
    protected DropDownList comboTipoDocumento;
    protected Label label12;
    protected Label Label13;
    protected DropDownList comboRegional;
    protected Label labelDepartamento;
    protected DropDownList comboDepartamento;
    protected Label labelMunicipio;
    protected Label Label11;
    protected DropDownList comboCiudad;
    protected Label labelTelefono;
    protected TextBox textTelefono;
    protected Label labelCorreo;
    protected TextBox textCorreo;
    protected Label labelCelular;
    protected TextBox textCelular;
    protected Label labelFax;
    protected TextBox textFax;
    protected Label label14;
    protected TextBox textRut;
    protected Label labelDireccion;
    protected TextBox textDireccion;
    protected Label labelTipoBeneficiario;
    protected RadioButton RadioPersonaNatural;
    protected RadioButton RadioPersonaJuridica;
    protected RadioButton radioEstablecimiento;
    protected Panel PanelPersonaJuridica;
    protected Label label15;
    protected TextBox textEstablecimiento;
    protected Label labelRepresentanteLegal;
    protected TextBox textNombreRepresentante;
    protected Label labelTipoDocumentoRL;
    protected DropDownList comboTipoDocumentoRL;
    protected Label labelDocumentoRL;
    protected TextBox textDocumentoRL;
    protected Button buttonGuardarTercero;
    protected Button buttonCancelarTercero;
    protected Panel PanelEntrega;
    protected Label label16;
    protected Label Label24;
    protected DropDownList comboProyecto;
    protected Label label17;
    protected RadioButton radioComodatoSi;
    protected RadioButton radioComodatoNo;
    protected HtmlTableRow rowComodato;
    protected Label Label20;
    protected TextBox textNumeroComodato;
    protected Label Label21;
    protected TextBox textFechaComodato;
    protected CalendarExtender calendarFechaInicios;
    protected Label label18;
    protected RadioButton radioActaSi;
    protected RadioButton radioActaNo;
    protected HtmlTableRow rowActa;
    protected Label Label23;
    protected TextBox textFechaActa;
    protected CalendarExtender CalendarExtender1;
    protected Label label19;
    protected RadioButton radioDirectaSi;
    protected RadioButton radioDirectaNo;
    protected HtmlTableRow rowDirecta;
    protected Label Label22;
    protected TextBox textDirecta;
    protected CalendarExtender CalendarExtender2;
    protected Panel PanelDatosEquipos;
    protected UpdatePanel UpdatePanelEquipos;
    protected Label Label10;
    protected RadioButton radioLocal;
    protected RadioButton radioNacional;
    protected Label label4;
    protected Panel PanelEquipos;
    protected ControlError ControlError;
    protected Label labelLicitacion;
    protected DropDownList comboLicitacion;
    protected Label labelKit;
    protected DropDownList comboKit;
    protected Label labelEquipo;
    protected DropDownList comboEquipo;
    protected Label labelCosto;
    protected TextBox textCosto;
    protected Label labelDisponible;
    protected TextBox textDisponible;
    protected Label labelCantidad;
    protected TextBox textCantidad;
    protected Label label8;
    protected CheckBox checkSede;
    protected Label label5;
    protected TextBox textDireccionAdicional;
    protected Label Label6;
    protected TextBox textTelefonoAdicional;
    protected Label label7;
    protected DropDownList comboDepartamentoAdicional;
    protected Label label9;
    protected DropDownList comboCiudadAdicional;
    protected TextBox textIdEquipo;
    protected Button buttonAdicionar;
    protected Button buttonCancelarEquipos;
    protected GridView gridSolicitudEquipos;
    protected Label labelValorTotal;
    protected TextBox textValorTotal;
    protected Label label2;
    protected DocumentosVarios DocumentosVarios;
    protected Panel panelBotones;
    protected Button buttonGuardar;
    protected Button buttonExportar;
    protected Button buttonCancelar;

    private int tipo
    {
      get => Convert.ToInt32(this.ViewState["SolicitudEquipo.Tipo"] ?? (object) 0);
      set => this.ViewState["SolicitudEquipo.Tipo"] = (object) value;
    }

    private int audAdicionar
    {
      get => Convert.ToInt32(this.ViewState["SolicitudEquipo.audAdicionar"] ?? (object) 0);
      set => this.ViewState["SolicitudEquipo.audAdicionar"] = (object) value;
    }

    private int audModificar
    {
      get => Convert.ToInt32(this.ViewState["SolicitudEquipo.audModificar"] ?? (object) 0);
      set => this.ViewState["SolicitudEquipo.audModificar"] = (object) value;
    }

    protected new void Page_Load(object sender, EventArgs e)
    {
      this.ControlError1.Visible = false;
      if (!this.IsPostBack)
      {
        this.tipo = this.Request.QueryString["tipo"] == null ? 1 : Convert.ToInt32(this.Request.QueryString["tipo"]);
        this.InitData();
      }
      switch (this.tipo)
      {
        case 1:
          this.labelBusquedaSolicitudesEquipos.Text = "Proyectos de dotación de equipos y herramientas  para el sector de refrigeración y aire acondicionado - Recuperación, reciclaje y regeneración de gases refrigerantes - Solicitud equipos";
          this.audAdicionar = 802;
          this.audModificar = 803;
          this.buttonAdicionarTercero.Visible = false;
          break;
        case 2:
          this.labelBusquedaSolicitudesEquipos.Text = "Proyectos de dotación de equipos y herramientas  para el sector de refrigeración y aire acondicionado - Kit de barrido y limpieza con nitrógeno y filtros de alto rendimiento - Eliminación del R-141b en Actividades de Limpieza - Solicitud equipos";
          this.audAdicionar = 802;
          this.audModificar = 803;
          this.buttonAdicionarTercero.Visible = false;
          break;
        case 3:
          this.labelBusquedaSolicitudesEquipos.Text = "Proyectos de dotación de equipos y herramientas  para el sector de refrigeración y aire acondicionado - Centros de regeneración - Solicitud equipos";
          this.audAdicionar = 816;
          this.audModificar = 817;
          this.buttonAdicionarTercero.Visible = true;
          break;
        case 4:
          this.labelBusquedaSolicitudesEquipos.Text = "Proyectos de dotación de equipos y herramientas  para el sector de refrigeración y aire acondicionado - Centros de acopio - Solicitud equipos";
          this.audAdicionar = 831;
          this.audModificar = 832;
          this.buttonAdicionarTercero.Visible = true;
          break;
      }
    }

    private void InitData()
    {
      this.labelKit.Visible = false;
      this.comboKit.Visible = false;
      this.comboRegional.DataSource = (object) CLinq.ListAll<reg_Regional>((DataContext) this.MyDataContext);
      this.comboRegional.DataBind();
      this.comboRegional.Items.Insert(0, "");
      this.comboTipoDocumentoBuscar.DataSource = (object) CLinq.ListAll<dti_DocumentoTipo>((DataContext) this.MyDataContext);
      this.comboTipoDocumentoBuscar.DataBind();
      this.comboTipoDocumentoBuscar.Items.Insert(0, "");
      this.comboLicitacion.DataSource = (object) CLinq.ListAll<lco_LicitacionCompra>((DataContext) this.MyDataContext);
      this.comboLicitacion.DataBind();
      this.comboLicitacion.Items.Insert(0, "");
      this.comboProyecto.DataSource = (object) CLinq.ListAll<pre_ProyectoRecuperacion>((DataContext) this.MyDataContext);
      this.comboProyecto.DataBind();
      this.comboProyecto.Items.Insert(0, "");
      this.comboTipoDocumento.DataSource = (object) CLinq.ListAll<dti_DocumentoTipo>((DataContext) this.MyDataContext);
      this.comboTipoDocumento.DataBind();
      this.comboTipoDocumento.Items.Insert(0, "");
      this.comboTipoDocumentoRL.DataSource = (object) CLinq.ListAll<dti_DocumentoTipo>((DataContext) this.MyDataContext);
      this.comboTipoDocumentoRL.DataBind();
      this.comboTipoDocumentoRL.Items.Insert(0, "");
      this.comboDepartamento.DataSource = (object) CLinq.ListAll<dep_Departamento>((DataContext) this.MyDataContext);
      this.comboDepartamento.DataBind();
      this.comboDepartamento.Items.Insert(0, "");
      this.comboCiudad.DataSource = (object) CLinq.ListAll<mun_Municipio>((DataContext) this.MyDataContext);
      this.comboCiudad.DataBind();
      this.comboCiudad.Items.Insert(0, "");
      this.comboDepartamentoAdicional.DataSource = (object) CLinq.ListAll<dep_Departamento>((DataContext) this.MyDataContext);
      this.comboDepartamentoAdicional.DataBind();
      this.comboDepartamentoAdicional.Items.Insert(0, "");
      this.comboCiudadAdicional.DataSource = (object) CLinq.ListAll<mun_Municipio>((DataContext) this.MyDataContext);
      this.comboCiudadAdicional.DataBind();
      this.comboCiudadAdicional.Items.Insert(0, "");
      this.textValorTotal.Text = "0";
      this.LocalInfo.SetData("idSolicitud", (object) ((BaseModulo.strSendParam) this.LocalInfo.MyParams).id);
      if (((BaseModulo.strSendParam) this.LocalInfo.MyParams).id != 0)
      {
        if (((BaseModulo.strSendParam) this.LocalInfo.MyParams).tipo == "Ver")
        {
          this.PanelDatosTercero.Enabled = false;
          this.buttonGuardar.Enabled = false;
        }
        this.mostrarDatos(((BaseModulo.strSendParam) this.LocalInfo.MyParams).id);
      }
      else
      {
        this.LocalInfo.MyParams = (object) new seq_SolicitudEquipo();
        this.LocalInfo.SetData("listaEquiposSolicitados", (object) this.listaEquiposSolicitados);
        this.LocalInfo.SetData("listaSolicitudGrilla", (object) this.listaSolicitudGrilla);
        this.LocalInfo.SetData("idProvisional", (object) null);
        this.LocalInfo.SetData("valorTotal", (object) "0");
      }
    }

    private void mostrarDatos(int id)
    {
      seq_SolicitudEquipo byKey1 = CLinq.FindByKey<seq_SolicitudEquipo>((DataContext) this.MyDataContext, (object) id);
      ter_Tercero byKey2 = CLinq.FindByKey<ter_Tercero>((DataContext) this.MyDataContext, (object) byKey1.ter_Id);
      this.PanelDatosEquipos.Visible = true;
      this.PanelEntrega.Visible = true;
      this.textValorTotal.Text = byKey1.seq_ValorTotal.ToString();
      this.LocalInfo.SetData("valorTotal", (object) this.textValorTotal.Text);
      this.PanelDatosTercero.Visible = true;
      this.PanelBuscarTercero.Visible = false;
      this.panelBotones.Visible = true;
      this.comboProyecto.SelectedValue = byKey1.pre_Id.ToString();
      this.ActualizarDatosTercero(byKey2);
      this.radioLocal.Checked = !byKey1.seq_Nacional;
      this.radioNacional.Checked = byKey1.seq_Nacional;
      this.radioActaSi.Checked = byKey1.seq_ActaTransferencia.Value;
      this.radioDirectaSi.Checked = byKey1.seq_Directa.Value;
      this.radioComodatoSi.Checked = byKey1.seq_PorComodato.Value;
      DateTime dateTime;
      if (byKey1.seq_PorComodato.Value)
      {
        this.textNumeroComodato.Text = byKey1.seq_Comodato;
        if (byKey1.seq_FechaComodato.HasValue)
        {
          TextBox textFechaComodato = this.textFechaComodato;
          dateTime = byKey1.seq_FechaComodato.Value;
          string str = dateTime.ToString("dd/MM/yyyy");
          textFechaComodato.Text = str;
        }
        this.radioComodatoNo.Checked = false;
      }
      if (byKey1.seq_ActaTransferencia.Value)
      {
        if (byKey1.seq_FechaActa.HasValue)
        {
          TextBox textFechaActa = this.textFechaActa;
          dateTime = byKey1.seq_FechaActa.Value;
          string str = dateTime.ToString("dd/MM/yyyy");
          textFechaActa.Text = str;
        }
        this.radioActaNo.Checked = false;
      }
      if (byKey1.seq_Directa.Value)
      {
        if (byKey1.seq_FechaDirecta.HasValue)
        {
          TextBox textDirecta = this.textDirecta;
          dateTime = byKey1.seq_FechaDirecta.Value;
          string str = dateTime.ToString("dd/MM/yyyy");
          textDirecta.Text = str;
        }
        this.radioDirectaNo.Checked = false;
      }
      this.LocalInfo.SetData("idProvisional", (object) (byKey1.sea_SolicitudEquiposAsignados.Count - 1));
      this.ActualizarDatosGrilla(byKey1.sea_SolicitudEquiposAsignados);
      this.LocalInfo.SetData("listaEquiposSolicitados", (object) byKey1.sea_SolicitudEquiposAsignados);
      this.LocalInfo.MyParams = (object) byKey1;
      this.DocumentosVarios.Init("Rrr.sdo_SolicitudDocumento", "seq_Id", byKey1.seq_Id.ToString(), this.MyDataContext.Connection.ConnectionString);
    }

    private void ActualizarDatosGrilla(
      EntitySet<sea_SolicitudEquiposAsignado> listaEquiposAsignado)
    {
      int num = 0;
      for (int index = 0; index < listaEquiposAsignado.Count; ++index)
      {
        SolicitudEquiposRegistrar.strSolicitudAsignado solicitudAsignado = new SolicitudEquiposRegistrar.strSolicitudAsignado();
        solicitudAsignado.equipo = listaEquiposAsignado[index].eki_EquipoKit.eki_Descripcion;
        solicitudAsignado.id = listaEquiposAsignado[index].eki_EquipoKit.kco_Id;
        solicitudAsignado.cantidad = listaEquiposAsignado[index].sea_Cantidad.Value;
        solicitudAsignado.costo = listaEquiposAsignado[index].eki_EquipoKit.eki_costo.Value * (Decimal) listaEquiposAsignado[index].sea_Cantidad.Value;
        solicitudAsignado.idProvisional = index;
        num = listaEquiposAsignado[index].eki_EquipoKit.kco_Id;
        solicitudAsignado.Placa = string.IsNullOrEmpty(listaEquiposAsignado[index].sea_Placa) ? "" : listaEquiposAsignado[index].sea_Placa;
        solicitudAsignado.Serie = string.IsNullOrEmpty(listaEquiposAsignado[index].sea_Serie) ? "" : listaEquiposAsignado[index].sea_Serie;
        this.listaSolicitudGrilla.Add(solicitudAsignado);
      }
      if (this.listaSolicitudGrilla.Count <= 0)
        return;
      this.gridSolicitudEquipos.DataSource = (object) this.listaSolicitudGrilla;
      this.gridSolicitudEquipos.DataBind();
      this.LocalInfo.SetData("listaSolicitudGrilla", (object) this.listaSolicitudGrilla);
    }

    protected void buttonBuscarTercero_Click(object sender, EventArgs e)
    {
      this.dsBuscarTercero.SelectParameters["beneficiario"].DefaultValue = this.textNombreBeneficiarioBuscar.Text == "" ? "%" : this.textNombreBeneficiarioBuscar.Text;
      this.dsBuscarTercero.SelectParameters["documento"].DefaultValue = this.textNumeroDocumentoBuscar.Text == "" ? "%" : this.textNumeroDocumentoBuscar.Text;
      this.dsBuscarTercero.SelectParameters["tipoDocumento"].DefaultValue = this.comboTipoDocumentoBuscar.SelectedValue == "" ? "0" : this.comboTipoDocumentoBuscar.SelectedValue;
    }

    protected void buttonAdicionarTercero_Click(object sender, EventArgs e)
    {
      this.textNombreBeneficiario.Text = "";
      this.comboTipoDocumento.SelectedValue = "";
      this.comboTipoDocumento.SelectedValue = "";
      this.textDocumento.Text = "";
      this.textCorreo.Text = "";
      this.textDireccion.Text = "";
      this.comboRegional.SelectedValue = "";
      this.comboDepartamento.SelectedValue = "";
      this.comboCiudad.SelectedValue = "";
      this.textTelefono.Text = "";
      this.textNombreRepresentante.Text = "";
      this.comboTipoDocumentoRL.SelectedValue = "";
      this.textDocumentoRL.Text = "";
      this.textCorreo.Text = "";
      this.textFax.Text = "";
      this.textRut.Text = "";
      this.textEstablecimiento.Text = "";
      this.textNombreBeneficiario.Enabled = true;
      this.comboTipoDocumento.Enabled = true;
      this.comboTipoDocumento.Enabled = true;
      this.textDocumento.Enabled = true;
      this.textCorreo.Enabled = true;
      this.textDireccion.Enabled = true;
      this.comboRegional.Enabled = true;
      this.comboDepartamento.Enabled = true;
      this.comboCiudad.Enabled = true;
      this.textTelefono.Enabled = true;
      this.textNombreRepresentante.Enabled = true;
      this.comboTipoDocumentoRL.Enabled = true;
      this.textDocumentoRL.Enabled = true;
      this.textCelular.Enabled = true;
      this.textFax.Enabled = true;
      this.textRut.Enabled = true;
      this.textEstablecimiento.Enabled = true;
      this.PanelEntrega.Visible = false;
      this.buttonGuardarTercero.Visible = true;
      this.buttonCancelarTercero.Visible = true;
      this.PanelBuscarTercero.Visible = false;
      this.PanelDatosTercero.Visible = true;
    }

    protected void buttonGuardarTercero_Click(object sender, EventArgs e)
    {
      try
      {
        this.ValidarTercero();
        ter_Tercero terTercero = new ter_Tercero();
        List<ter_Tercero> terTerceroList = CLinq.ListByProperties<ter_Tercero>((DataContext) this.MyDataContext, (object) "ter_NumeroDocumento", (object) this.textDocumento.Text.ToUpper(), (object) "mun_Id", (object) this.comboCiudad.SelectedValue);
        if (terTerceroList.Count > 0)
        {
          for (int index = 0; index < terTerceroList.Count; ++index)
          {
            if (terTerceroList[index].ter_NombreCompleto.ToUpper() == this.textNombreBeneficiario.Text.ToUpper())
              throw new Exception("El tercero ya se encuentra registrado. <br />");
          }
        }
        terTercero.ter_NombreCompleto = this.textNombreBeneficiario.Text.ToUpper();
        terTercero.dti_Id = int.Parse(this.comboTipoDocumento.SelectedValue);
        terTercero.ter_NumeroDocumento = this.textDocumento.Text.ToUpper();
        terTercero.dep_Id = this.comboDepartamento.SelectedValue;
        terTercero.mun_Id = this.comboCiudad.SelectedValue;
        terTercero.reg_Id = new int?(int.Parse(this.comboRegional.SelectedValue));
        terTercero.ter_Tefono = this.textTelefono.Text.ToUpper();
        terTercero.ter_Direccion = this.textDireccion.Text.ToUpper();
        terTercero.ter_Correo = this.textCorreo.Text.ToUpper();
        terTercero.ter_Celular = this.textCelular.Text.ToUpper();
        terTercero.ter_Fax = this.textFax.Text.ToUpper();
        terTercero.ter_Rut = this.textRut.Text.ToUpper();
        if (this.RadioPersonaNatural.Checked)
          terTercero.bti_Id = 1;
        else if (this.RadioPersonaJuridica.Checked)
        {
          terTercero.bti_Id = 2;
          terTercero.ter_RepresentanteLegal = this.textNombreRepresentante.Text.ToUpper();
          terTercero.dti_IdRepresentante = new int?(int.Parse(this.comboTipoDocumentoRL.SelectedValue));
          terTercero.ter_NumeroDocumentoRepresentante = this.textDocumentoRL.Text.ToUpper();
          terTercero.ter_EstablacimientoComercio = this.textEstablecimiento.Text;
        }
        else if (this.radioEstablecimiento.Checked)
        {
          terTercero.bti_Id = 3;
          terTercero.ter_EstablacimientoComercio = this.textEstablecimiento.Text;
        }
        this.MyDataContext.ttt_TerceroTipoTerceros.InsertOnSubmit(new ttt_TerceroTipoTercero()
        {
          ter_Tercero = terTercero,
          tti_Id = 1
        });
        this.MyDataContext.ter_Terceros.InsertOnSubmit(terTercero);
        this.MyDataContext.SubmitChanges();
        this.textNombreBeneficiario.Enabled = false;
        this.comboTipoDocumento.Enabled = false;
        this.comboTipoDocumento.Enabled = false;
        this.textDocumento.Enabled = false;
        this.textCorreo.Enabled = false;
        this.textDireccion.Enabled = false;
        this.comboDepartamento.Enabled = false;
        this.comboCiudad.Enabled = false;
        this.textTelefono.Enabled = false;
        this.textNombreRepresentante.Enabled = false;
        this.comboTipoDocumentoRL.Enabled = false;
        this.textDocumentoRL.Enabled = false;
        this.textCelular.Enabled = false;
        this.textFax.Enabled = false;
        this.buttonGuardarTercero.Visible = false;
        this.buttonCancelarTercero.Visible = false;
        this.ActualizarDatosTercero(terTercero);
        this.PanelDatosEquipos.Visible = true;
        this.PanelEntrega.Visible = true;
        this.panelBotones.Visible = true;
      }
      catch (Exception ex)
      {
        this.ControlError1.Visible = true;
        this.ControlError1.Show(ex);
      }
    }

    private void ValidarTercero()
    {
      string message = "";
      bool flag = true;
      if (this.textNombreBeneficiario.Text == "")
      {
        flag = false;
        message += "El nombre del tercero o la razón social es un campo obligatorio. <br/>";
      }
      if (this.comboTipoDocumento.SelectedValue == "")
      {
        flag = false;
        message += "El tipo de documento del tercero es un campo obligatorio. <br/>";
      }
      if (this.textDocumento.Text == "")
      {
        flag = false;
        message += "El número de documento del tercero es un campo obligatorio. <br/>";
      }
      if (this.comboDepartamento.SelectedValue == "")
      {
        flag = false;
        message += "El departamento del tercero es un campo obligatorio. <br/>";
      }
      if (this.comboCiudad.SelectedValue == "")
      {
        flag = false;
        message += "La ciudad del tercero es un campo obligatorio. <br/>";
      }
      if (!flag)
        throw new Exception(message);
    }

    protected void buttonCancelarTercero_Click(object sender, EventArgs e)
    {
      this.PanelDatosTercero.Visible = false;
      this.PanelBuscarTercero.Visible = true;
      this.PanelEntrega.Visible = false;
      this.textNombreBeneficiario.Enabled = false;
      this.comboTipoDocumento.Enabled = false;
      this.comboTipoDocumento.Enabled = false;
      this.textDocumento.Enabled = false;
      this.textCorreo.Enabled = false;
      this.textDireccion.Enabled = false;
      this.comboRegional.Enabled = false;
      this.comboDepartamento.Enabled = false;
      this.comboCiudad.Enabled = false;
      this.textTelefono.Enabled = false;
      this.textNombreRepresentante.Enabled = false;
      this.comboTipoDocumentoRL.Enabled = false;
      this.textDocumentoRL.Enabled = false;
      this.textCelular.Enabled = false;
      this.textFax.Enabled = false;
      this.textRut.Enabled = false;
      this.textEstablecimiento.Enabled = false;
      this.buttonGuardarTercero.Visible = false;
      this.buttonCancelarTercero.Visible = false;
    }

    protected void GridViewTerceroBuscar_RowCommand(object sender, GridViewCommandEventArgs e)
    {
      if (!e.CommandName.Equals("Seleccionar"))
        return;
      this.PanelDatosTercero.Visible = true;
      this.PanelEntrega.Visible = true;
      this.PanelBuscarTercero.Visible = false;
      this.ActualizarDatosTercero(CLinq.FindByKey<ter_Tercero>((DataContext) this.MyDataContext, (object) int.Parse(this.GridViewTerceroBuscar.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString())));
      this.PanelDatosEquipos.Visible = true;
      this.panelBotones.Visible = true;
    }

    private void ActualizarDatosTercero(ter_Tercero tercero)
    {
      this.LocalInfo.SetData("idTercero", (object) tercero.ter_Id);
      this.textNombreBeneficiario.Text = tercero.ter_NombreCompleto;
      this.comboTipoDocumento.SelectedValue = tercero.dti_Id.ToString();
      this.textDocumento.Text = tercero.ter_NumeroDocumento;
      this.textCorreo.Text = tercero.ter_Correo;
      this.textDireccion.Text = tercero.ter_Direccion;
      this.comboDepartamento.SelectedValue = tercero.dep_Id.ToString();
      this.listarMunicipio(this.comboDepartamento.SelectedValue);
      this.comboCiudad.SelectedValue = tercero.mun_Id.ToString();
      this.textTelefono.Text = tercero.ter_Tefono;
      this.textFax.Text = tercero.ter_Fax;
      this.textCelular.Text = tercero.ter_Celular;
      this.textRut.Text = tercero.ter_Rut;
      if (tercero.bti_beneficiarioTipo.bti_Id == 1)
        this.RadioPersonaNatural.Checked = true;
      else if (tercero.bti_beneficiarioTipo.bti_Id == 2)
      {
        this.RadioPersonaJuridica.Checked = true;
        this.PanelPersonaJuridica.Visible = true;
        this.textNombreRepresentante.Text = string.IsNullOrEmpty(tercero.ter_RepresentanteLegal) ? "" : tercero.ter_RepresentanteLegal;
        DropDownList comboTipoDocumentoRl = this.comboTipoDocumentoRL;
        int? dtiIdRepresentante = tercero.dti_IdRepresentante;
        string str;
        if (dtiIdRepresentante.HasValue)
        {
          dtiIdRepresentante = tercero.dti_IdRepresentante;
          str = dtiIdRepresentante.ToString();
        }
        else
          str = "";
        comboTipoDocumentoRl.SelectedValue = str;
        this.textDocumentoRL.Text = string.IsNullOrEmpty(tercero.ter_NumeroDocumentoRepresentante) ? "" : tercero.ter_NumeroDocumentoRepresentante;
      }
      else
      {
        if (tercero.bti_beneficiarioTipo.bti_Id != 3)
          return;
        this.radioEstablecimiento.Checked = true;
        this.PanelPersonaJuridica.Visible = true;
        this.labelRepresentanteLegal.Visible = false;
        this.textNombreRepresentante.Visible = false;
        this.comboTipoDocumentoRL.Visible = false;
        this.labelTipoDocumentoRL.Visible = false;
        this.labelDocumentoRL.Visible = false;
        this.textDocumentoRL.Visible = false;
        this.textEstablecimiento.Text = string.IsNullOrEmpty(tercero.ter_EstablacimientoComercio) ? "" : tercero.ter_EstablacimientoComercio;
      }
    }

    protected void buttonGuardar_Click(object sender, EventArgs e)
    {
      try
      {
        this.ValidarDatos();
        seq_SolicitudEquipo myParams = (seq_SolicitudEquipo) this.LocalInfo.MyParams;
        if ((int) this.LocalInfo.GetData("idSolicitud") == 0)
        {
          myParams.ses_Id = 1;
          myParams.seq_Creado = DateTime.Now;
          myParams.seq_FechaSolicitud = DateTime.Today;
        }
        myParams.seq_Nacional = !this.radioLocal.Checked;
        myParams.seq_ValorTotal = Decimal.Parse(this.textValorTotal.Text);
        myParams.seq_Activo = new bool?(true);
        myParams.seq_Usuario = this.Usuario.login;
        myParams.seq_Modificado = new DateTime?(DateTime.Now);
        myParams.pre_Id = new int?(int.Parse(this.comboProyecto.SelectedValue));
        myParams.seq_ActaTransferencia = new bool?(this.radioActaSi.Checked);
        if (this.radioComodatoSi.Checked)
        {
          if (this.textFechaComodato.Text != "")
            myParams.seq_FechaComodato = new DateTime?(DateTime.Parse(this.textFechaComodato.Text));
          myParams.seq_Comodato = this.textNumeroComodato.Text;
        }
        if (this.radioActaSi.Checked && this.textFechaActa.Text != "")
          myParams.seq_FechaActa = new DateTime?(DateTime.Parse(this.textFechaActa.Text));
        if (this.radioDirectaSi.Checked && this.textDirecta.Text != "")
          myParams.seq_FechaDirecta = new DateTime?(DateTime.Parse(this.textDirecta.Text));
        myParams.seq_PorComodato = new bool?(this.radioComodatoSi.Checked);
        myParams.seq_Directa = new bool?(this.radioDirectaSi.Checked);
        myParams.seq_Tipo = new int?(this.tipo);
        if (this.radioComodatoSi.Checked || this.radioActaSi.Checked || this.radioDirectaSi.Checked)
          myParams.ses_Id = 2;
        foreach (GridViewRow row in this.gridSolicitudEquipos.Rows)
        {
          Control control1 = (Control) (row.FindControl("TextSerie") as TextBox);
          Control control2 = (Control) (row.FindControl("TextPlaca") as TextBox);
          if (control1 != null)
          {
            TextBox textBox = (TextBox) control1;
            int int32 = Convert.ToInt32(this.gridSolicitudEquipos.DataKeys[Convert.ToInt32(row.DataItemIndex)].Value);
            myParams.sea_SolicitudEquiposAsignados[int32].sea_Serie = textBox.Text;
          }
          if (control2 != null)
          {
            TextBox textBox = (TextBox) control2;
            int int32 = Convert.ToInt32(this.gridSolicitudEquipos.DataKeys[Convert.ToInt32(row.DataItemIndex)].Value);
            myParams.sea_SolicitudEquiposAsignados[int32].sea_Placa = textBox.Text;
          }
        }
        if ((int) this.LocalInfo.GetData("idSolicitud") == 0)
          this.MyDataContext.seq_SolicitudEquipos.InsertOnSubmit(myParams);
        myParams.ter_Id = (int) this.LocalInfo.GetData("idTercero");
        this.DocumentosVarios.Init("Rrr.sdo_SolicitudDocumento", "seq_Id", myParams.seq_Id.ToString(), this.MyDataContext.Connection.ConnectionString);
        this.MyDataContext.SubmitChanges();
        if ((int) this.LocalInfo.GetData("idSolicitud") == 0)
          CAuditoria.log((EPermiso) this.audAdicionar, myParams.seq_Id.ToString(), myParams.ter_Tercero.ter_NombreCompleto, myParams.ter_Tercero.ter_NumeroDocumento, "", "", this.Usuario.id);
        else
          CAuditoria.log((EPermiso) this.audModificar, myParams.seq_Id.ToString(), "", "", "", "", this.Usuario.id);
        this.Server.Transfer("~/Recuperacion/SolicitudEquiposBuscar.aspx");
      }
      catch (Exception ex)
      {
        this.ControlError.Visible = true;
        this.ControlError.Show(ex);
      }
    }

    private void ValidarDatos()
    {
      string message = "";
      bool flag = true;
      if (this.comboProyecto.SelectedValue == "")
      {
        flag = false;
        message += " El proyecto es un campo obligatorio. <br />";
      }
      if (!flag)
        throw new Exception(message);
    }

    protected void buttonCancelar_Click(object sender, EventArgs e) => this.Server.Transfer("~/Recuperacion/SolicitudEquiposBuscar.aspx");

    protected void buttonAdicionar_Click(object sender, EventArgs e)
    {
      this.listaEquiposSolicitados = (EntitySet<sea_SolicitudEquiposAsignado>) this.LocalInfo.GetData("listaEquiposSolicitados");
      try
      {
        this.Validar();
        this.ControlError.Visible = false;
        if (this.comboEquipo.SelectedValue != "")
        {
          for (int index = 0; index < int.Parse(this.textCantidad.Text); ++index)
          {
            sea_SolicitudEquiposAsignado entity = new sea_SolicitudEquiposAsignado();
            entity.eki_EquipoKit = CLinq.FindByKey<eki_EquipoKit>((DataContext) this.MyDataContext, (object) int.Parse(this.comboEquipo.SelectedValue));
            eki_EquipoKit ekiEquipoKit = entity.eki_EquipoKit;
            int? ekiDisponible = entity.eki_EquipoKit.eki_Disponible;
            int? nullable = ekiDisponible.HasValue ? new int?(ekiDisponible.GetValueOrDefault() - 1) : new int?();
            ekiEquipoKit.eki_Disponible = nullable;
            entity.seq_SolicitudEquipo = (seq_SolicitudEquipo) this.LocalInfo.MyParams;
            entity.sea_Cantidad = new int?(1);
            entity.sea_DireccionAdicional = this.textDireccionAdicional.Text;
            entity.sea_TelefonoAdicional = this.textTelefonoAdicional.Text;
            entity.sea_SedePrinciapl = new bool?(this.checkSede.Checked);
            entity.mun_Id = string.IsNullOrEmpty(this.comboCiudadAdicional.SelectedValue) ? (string) null : this.comboCiudadAdicional.SelectedValue;
            this.MyDataContext.sea_SolicitudEquiposAsignados.InsertOnSubmit(entity);
            this.listaEquiposSolicitados.Add(entity);
            this.LocalInfo.SetData("listaEquiposSolicitados", (object) this.listaEquiposSolicitados);
          }
          this.textValorTotal.Text = (Decimal.Parse(this.LocalInfo.GetData("valorTotal").ToString()) + (Decimal) int.Parse(this.textCantidad.Text) * Decimal.Parse(this.textCosto.Text)).ToString();
          this.LocalInfo.SetData("valorTotal", (object) this.textValorTotal.Text);
        }
        this.alimentarGrilla(this.listaEquiposSolicitados);
        this.comboLicitacion.SelectedValue = "";
        this.comboKit.SelectedValue = "";
        this.comboEquipo.SelectedValue = "";
        this.textCantidad.Text = "0";
        this.textDisponible.Text = "0";
        this.textCantidad.Text = "0";
        this.textCosto.Text = "0";
        this.textDireccionAdicional.Text = "";
        this.textTelefonoAdicional.Text = "";
        this.comboDepartamentoAdicional.Text = "";
        this.comboCiudadAdicional.Text = "";
        if (!(this.buttonAdicionar.Text == "Guardar"))
          return;
        this.buttonAdicionar.Text = "Adicionar";
        this.buttonCancelarEquipos.Enabled = true;
      }
      catch (Exception ex)
      {
        this.ControlError.Visible = true;
        this.ControlError.Show(ex);
      }
    }

    private void Validar()
    {
      string errStr = "";
      double number = 0.0;
      bool flag = true & CValidator.isNumeric(this.textCantidad.Text, ref number, "La cantidad debe ser un número. <br />", ref errStr);
      if (flag && int.Parse(this.textCantidad.Text) > int.Parse(this.textDisponible.Text))
      {
        errStr = errStr + errStr + "La cantidad solicitada no puede ser mayor que la disponibilidad existente. <br />";
        flag = false;
      }
      if (!flag)
        throw new Exception(errStr);
    }

    private void alimentarGrilla(
      EntitySet<sea_SolicitudEquiposAsignado> listaEquiposSolicitados)
    {
      this.listaSolicitudGrilla = (List<SolicitudEquiposRegistrar.strSolicitudAsignado>) this.LocalInfo.GetData("listaSolicitudGrilla");
      if (this.listaSolicitudGrilla == null)
        this.listaSolicitudGrilla = new List<SolicitudEquiposRegistrar.strSolicitudAsignado>();
      if (this.listaSolicitudGrilla.Count > 0 || listaEquiposSolicitados.Count > 0)
      {
        if (this.textCantidad.Text != "0")
        {
          for (int index = 0; index < int.Parse(this.textCantidad.Text); ++index)
          {
            SolicitudEquiposRegistrar.strSolicitudAsignado solicitudAsignado = new SolicitudEquiposRegistrar.strSolicitudAsignado();
            if (this.comboEquipo.SelectedValue != "")
            {
              solicitudAsignado.equipo = this.comboEquipo.SelectedItem.ToString();
              solicitudAsignado.id = 1;
            }
            if (this.comboKit.SelectedValue != "")
            {
              solicitudAsignado.equipo = this.comboKit.SelectedItem.ToString();
              solicitudAsignado.id = int.Parse(this.comboKit.SelectedValue);
            }
            solicitudAsignado.costo = Decimal.Parse(this.textCosto.Text);
            solicitudAsignado.cantidad = 1;
            if (this.LocalInfo.GetData("idProvisional") != null)
            {
              solicitudAsignado.idProvisional = (int) this.LocalInfo.GetData("idProvisional") + 1;
              this.LocalInfo.SetData("idProvisional", (object) solicitudAsignado.idProvisional);
            }
            else
            {
              solicitudAsignado.idProvisional = 0;
              this.LocalInfo.SetData("idProvisional", (object) solicitudAsignado.idProvisional);
            }
            this.listaSolicitudGrilla.Add(solicitudAsignado);
            this.LocalInfo.SetData("listaSolicitudGrilla", (object) this.listaSolicitudGrilla);
          }
        }
        this.gridSolicitudEquipos.Visible = true;
        this.gridSolicitudEquipos.DataSource = (object) this.listaSolicitudGrilla;
        this.gridSolicitudEquipos.DataBind();
      }
      else
      {
        this.gridSolicitudEquipos.Visible = true;
        this.gridSolicitudEquipos.DataSource = (object) this.listaSolicitudGrilla;
        this.gridSolicitudEquipos.DataBind();
      }
    }

    protected void buttonCancelarEquipos_Click(object sender, EventArgs e)
    {
      this.comboLicitacion.SelectedValue = "";
      this.comboKit.SelectedValue = "";
      this.comboEquipo.SelectedValue = "";
      this.textCantidad.Text = "0";
      this.textDisponible.Text = "0";
      this.textCantidad.Text = "0";
      this.textCosto.Text = "0";
    }

    protected void comboLicitacion_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.listarEquipos(this.comboLicitacion.SelectedValue);
      this.labelKit.Visible = false;
      this.comboKit.Visible = false;
      this.labelEquipo.Visible = true;
      this.comboEquipo.Visible = true;
    }

    protected void listarKit(string licitacion)
    {
      List<kco_KitCompra> kcoKitCompraList = CLinq.ListByProperty<kco_KitCompra>((DataContext) this.MyDataContext, "lco_Id", (object) int.Parse(licitacion));
      this.comboKit.SelectedValue = (string) null;
      if (kcoKitCompraList.Count > 0)
      {
        this.comboKit.DataSource = (object) kcoKitCompraList;
        this.comboKit.DataBind();
        this.comboKit.Items.Insert(0, "");
      }
      else
        this.comboKit.Items.Insert(0, "");
    }

    protected void comboKit_SelectedIndexChanged(object sender, EventArgs e)
    {
      kco_KitCompra byKey = CLinq.FindByKey<kco_KitCompra>((DataContext) this.MyDataContext, (object) int.Parse(this.comboKit.SelectedValue));
      this.textDisponible.Text = byKey.kco_Disponible.ToString();
      this.textCosto.Text = byKey.kco_costo.ToString();
    }

    protected void listarEquipos(string kit)
    {
      List<eki_EquipoKit> ekiEquipoKitList = CLinq.ListByProperty<eki_EquipoKit>((DataContext) this.MyDataContext, "kco_Id", (object) int.Parse(kit));
      this.comboEquipo.SelectedValue = (string) null;
      if (ekiEquipoKitList.Count > 0)
      {
        this.comboEquipo.DataSource = (object) ekiEquipoKitList;
        this.comboEquipo.DataBind();
        this.comboEquipo.Items.Insert(0, "");
      }
      else
        this.comboEquipo.Items.Insert(0, "");
    }

    protected void comboEquipo_SelectedIndexChanged(object sender, EventArgs e)
    {
      eki_EquipoKit byKey = CLinq.FindByKey<eki_EquipoKit>((DataContext) this.MyDataContext, (object) int.Parse(this.comboEquipo.SelectedValue));
      this.textDisponible.Text = byKey.eki_Disponible.ToString();
      this.textCosto.Text = byKey.eki_costo.ToString();
    }

    protected void gridSolicitudEquipos_RowCommand(object sender, GridViewCommandEventArgs e)
    {
      int.Parse(this.gridSolicitudEquipos.Rows[int.Parse((string) e.CommandArgument)].Cells[CGridView.ColIndexByField(this.gridSolicitudEquipos, "id")].Text);
      int index1 = int.Parse(this.gridSolicitudEquipos.Rows[int.Parse((string) e.CommandArgument)].Cells[CGridView.ColIndexByField(this.gridSolicitudEquipos, "idProvisional")].Text);
      this.listaEquiposSolicitados = (EntitySet<sea_SolicitudEquiposAsignado>) this.LocalInfo.GetData("listaEquiposSolicitados");
      this.listaSolicitudGrilla = (List<SolicitudEquiposRegistrar.strSolicitudAsignado>) this.LocalInfo.GetData("listaSolicitudGrilla");
      int num = this.listaEquiposSolicitados.Count - 1;
      if (e.CommandName.Equals("Modificar"))
      {
        this.comboLicitacion.SelectedValue = this.listaEquiposSolicitados[index1].eki_EquipoKit.kco_KitCompra.lco_Id.ToString();
        this.comboKit.DataSource = (object) CLinq.ListAll<kco_KitCompra>((DataContext) this.MyDataContext);
        if (this.listaEquiposSolicitados[index1].eki_EquipoKit.kco_KitCompra.lco_Id == 1)
        {
          this.comboEquipo.SelectedValue = this.listaEquiposSolicitados[index1].eki_Id.ToString();
          this.comboKit.Visible = false;
          this.textIdEquipo.Text = this.comboEquipo.SelectedValue;
        }
        else
        {
          this.listarKit(this.comboLicitacion.SelectedValue);
          this.comboKit.SelectedValue = this.listaEquiposSolicitados[index1].eki_EquipoKit.kco_Id.ToString();
          this.comboEquipo.Visible = false;
          this.textIdEquipo.Text = this.comboKit.SelectedValue;
        }
        this.textCosto.Text = this.listaEquiposSolicitados[index1].eki_EquipoKit.eki_costo.ToString();
        this.textDisponible.Text = this.listaEquiposSolicitados[index1].eki_EquipoKit.eki_Disponible.ToString();
        this.textCantidad.Text = this.listaEquiposSolicitados[index1].sea_Cantidad.ToString();
        int count = this.listaEquiposSolicitados.Count;
        for (int index2 = 0; index2 <= count - 1; ++index2)
        {
          if (this.listaEquiposSolicitados[0].eki_EquipoKit.kco_Id == int.Parse(this.comboKit.SelectedValue))
          {
            this.MyDataContext.sea_SolicitudEquiposAsignados.DeleteOnSubmit(this.listaEquiposSolicitados[0]);
            this.listaEquiposSolicitados.Remove(this.listaEquiposSolicitados[0]);
          }
        }
        if (this.listaEquiposSolicitados.Count == 0)
          this.textValorTotal.Text = "0";
        this.textValorTotal.Text = (Decimal.Parse(this.LocalInfo.GetData("valorTotal").ToString()) - (Decimal) this.listaSolicitudGrilla[index1].cantidad * this.listaSolicitudGrilla[index1].costo).ToString();
        this.listaSolicitudGrilla.Remove(this.listaSolicitudGrilla[index1]);
        this.LocalInfo.SetData("listaSolicitudGrilla", (object) this.listaSolicitudGrilla);
        this.alimentarGrilla(this.listaEquiposSolicitados);
        this.buttonAdicionar.Text = "Guardar";
        this.buttonCancelarEquipos.Enabled = false;
      }
      if (!e.CommandName.Equals("Eliminar"))
        return;
      this.MyDataContext.sea_SolicitudEquiposAsignados.DeleteOnSubmit(this.listaEquiposSolicitados[index1]);
      this.listaEquiposSolicitados.Remove(this.listaEquiposSolicitados[index1]);
      if (this.listaEquiposSolicitados.Count == 0)
        this.textValorTotal.Text = "0";
      this.textValorTotal.Text = (Decimal.Parse(this.LocalInfo.GetData("valorTotal").ToString()) - (Decimal) this.listaSolicitudGrilla[index1].cantidad * this.listaSolicitudGrilla[index1].costo).ToString();
      this.listaSolicitudGrilla.Remove(this.listaSolicitudGrilla[index1]);
      this.textCantidad.Text = "0";
      this.renumerarListaGrilla(this.listaSolicitudGrilla);
      this.LocalInfo.SetData("listaSolicitudGrilla", (object) this.listaSolicitudGrilla);
      this.LocalInfo.SetData("listaEquiposSolicitados", (object) this.listaEquiposSolicitados);
      this.alimentarGrilla(this.listaEquiposSolicitados);
    }

    private void renumerarListaGrilla(
      List<SolicitudEquiposRegistrar.strSolicitudAsignado> listaSolicitudGrilla)
    {
      for (int index = 0; index < listaSolicitudGrilla.Count; ++index)
      {
        listaSolicitudGrilla[index].idProvisional = index;
        this.LocalInfo.SetData("idProvisional", (object) index);
      }
    }

    protected void buttonExportar_Click(object sender, EventArgs e) => this.Exportar(this.gridSolicitudEquipos);

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

    protected void RadioPersonaJuridica_CheckedChanged(object sender, EventArgs e)
    {
      this.PanelPersonaJuridica.Visible = true;
      this.labelRepresentanteLegal.Visible = true;
      this.comboTipoDocumentoRL.Visible = true;
      this.textNombreRepresentante.Visible = true;
      this.labelTipoDocumentoRL.Visible = true;
      this.labelDocumentoRL.Visible = true;
      this.textDocumentoRL.Visible = true;
    }

    protected void RadioPersonaNatural_CheckedChanged(object sender, EventArgs e) => this.PanelPersonaJuridica.Visible = false;

    protected void comboDepartamentoAdicional_SelectedIndexChanged(object sender, EventArgs e)
    {
      List<mun_Municipio> munMunicipioList = CLinq.ListByProperty<mun_Municipio>((DataContext) this.MyDataContext, "dep_Id", (object) this.comboDepartamentoAdicional.SelectedValue);
      this.comboCiudadAdicional.SelectedValue = (string) null;
      if (munMunicipioList.Count > 0)
      {
        this.comboCiudadAdicional.DataSource = (object) munMunicipioList;
        this.comboCiudadAdicional.DataBind();
        this.comboCiudadAdicional.Items.Insert(0, "");
      }
      else
        this.comboCiudadAdicional.Items.Insert(0, "");
    }

    protected void checkSede_CheckedChanged(object sender, EventArgs e)
    {
      if (this.checkSede.Checked)
      {
        ter_Tercero byKey = CLinq.FindByKey<ter_Tercero>((DataContext) this.MyDataContext, (object) (int) this.LocalInfo.GetData("idTercero"));
        this.comboDepartamentoAdicional.SelectedValue = byKey.dep_Id;
        List<mun_Municipio> munMunicipioList = CLinq.ListByProperty<mun_Municipio>((DataContext) this.MyDataContext, "dep_Id", (object) this.comboDepartamentoAdicional.SelectedValue);
        this.comboCiudadAdicional.SelectedValue = (string) null;
        if (munMunicipioList.Count > 0)
        {
          this.comboCiudadAdicional.DataSource = (object) munMunicipioList;
          this.comboCiudadAdicional.DataBind();
          this.comboCiudadAdicional.Items.Insert(0, "");
        }
        this.comboCiudadAdicional.SelectedValue = byKey.mun_Id;
        this.textDireccionAdicional.Text = string.IsNullOrEmpty(byKey.ter_Direccion) ? "" : byKey.ter_Direccion;
        this.textTelefonoAdicional.Text = string.IsNullOrEmpty(byKey.ter_Tefono) ? "" : byKey.ter_Tefono;
      }
      else
      {
        this.comboDepartamentoAdicional.SelectedValue = "";
        this.comboCiudadAdicional.SelectedValue = "";
        this.textDireccionAdicional.Text = "";
        this.textTelefonoAdicional.Text = "";
      }
    }

    protected void comboRegional_SelectedIndexChanged(object sender, EventArgs e)
    {
      List<dep_Departamento> depDepartamentoList = CLinq.ListByProperty<dep_Departamento>((DataContext) this.MyDataContext, "reg_Id", (object) int.Parse(this.comboRegional.SelectedValue));
      this.comboDepartamento.SelectedValue = (string) null;
      if (depDepartamentoList.Count > 0)
      {
        this.comboDepartamento.DataSource = (object) depDepartamentoList;
        this.comboDepartamento.DataBind();
        this.comboDepartamento.Items.Insert(0, "");
      }
      else
        this.comboDepartamento.Items.Insert(0, "");
    }

    protected void radioEstablecimiento_CheckedChanged(object sender, EventArgs e)
    {
      this.PanelPersonaJuridica.Visible = true;
      this.labelRepresentanteLegal.Visible = false;
      this.textNombreRepresentante.Visible = false;
      this.comboTipoDocumentoRL.Visible = false;
      this.labelTipoDocumentoRL.Visible = false;
      this.labelDocumentoRL.Visible = false;
      this.textDocumentoRL.Visible = false;
    }

    protected void radioNacional_CheckedChanged(object sender, EventArgs e)
    {
      if (this.radioNacional.Checked)
      {
        this.checkSede.Checked = true;
        ter_Tercero byKey = CLinq.FindByKey<ter_Tercero>((DataContext) this.MyDataContext, (object) (int) this.LocalInfo.GetData("idTercero"));
        this.comboDepartamentoAdicional.SelectedValue = byKey.dep_Id;
        List<mun_Municipio> munMunicipioList = CLinq.ListByProperty<mun_Municipio>((DataContext) this.MyDataContext, "dep_Id", (object) this.comboDepartamentoAdicional.SelectedValue);
        this.comboCiudadAdicional.SelectedValue = (string) null;
        if (munMunicipioList.Count > 0)
        {
          this.comboCiudadAdicional.DataSource = (object) munMunicipioList;
          this.comboCiudadAdicional.DataBind();
          this.comboCiudadAdicional.Items.Insert(0, "");
        }
        this.comboCiudadAdicional.SelectedValue = byKey.mun_Id;
        this.textDireccionAdicional.Text = string.IsNullOrEmpty(byKey.ter_Direccion) ? "" : byKey.ter_Direccion;
        this.textTelefonoAdicional.Text = string.IsNullOrEmpty(byKey.ter_Tefono) ? "" : byKey.ter_Tefono;
      }
      else
      {
        this.checkSede.Checked = false;
        this.comboDepartamentoAdicional.SelectedValue = "";
        this.comboCiudadAdicional.SelectedValue = "";
        this.textDireccionAdicional.Text = "";
        this.textTelefonoAdicional.Text = "";
      }
    }

    protected void comboProyecto_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    protected void TextSerie_TextChanged(object sender, EventArgs e)
    {
    }

    protected void TextPlaca_TextChanged(object sender, EventArgs e)
    {
    }

    public class strSolicitudAsignado
    {
      private string _equipo;
      private string _direccion;
      private int _cantidad;
      private Decimal _costo;
      private int _id;
      private int _idProvisional;
      private string _placa;
      private string _serie;

      public string equipo
      {
        get => this._equipo;
        set => this._equipo = value;
      }

      public string direccion
      {
        get => this._direccion;
        set => this._direccion = value;
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

      public string Placa
      {
        get => this._placa;
        set => this._placa = value;
      }

      public string Serie
      {
        get => this._serie;
        set => this._serie = value;
      }
    }
  }
}
