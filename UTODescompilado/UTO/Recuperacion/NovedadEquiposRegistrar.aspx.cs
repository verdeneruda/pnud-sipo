// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.NovedadEquiposRegistrar
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
using System.Web.UI.WebControls;
using UTO.Comunes;

namespace UTO.Recuperacion
{
  public class NovedadEquiposRegistrar : BaseModulo
  {
    private EntitySet<nea_NovedadEquiposAsignado> listaEquiposSolicitados = new EntitySet<nea_NovedadEquiposAsignado>();
    private List<NovedadEquiposRegistrar.strSolicitudAsignado> listaSolicitudGrilla = new List<NovedadEquiposRegistrar.strSolicitudAsignado>();
    protected ToolkitScriptManager ToolkitScriptManager1;
    protected Label labelBusquedaSolicitudesEquipos;
    protected ControlError ControlError1;
    protected Panel PanelBuscarTercero;
    protected Label labelparametros;
    protected Label labelNombreBeneficiario;
    protected TextBox textBeneficiarioBuscar;
    protected Label label3;
    protected DropDownList comboTipoDocumentoBuscar;
    protected Label labelNumeroDocumento;
    protected TextBox textNumeroDocumnetoBuscar;
    protected Button buttonBuscarTercero;
    protected GridView GridViewTerceroBuscar;
    protected SqlDataSource dsBuscarTercero;
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
    protected Panel PanelOtroSi;
    protected Label label4;
    protected CheckBox CheckCambioDirección;
    protected Label labelCambioDireccion;
    protected Label labelCambioDepartamento;
    protected Label labelCambioMunicipio;
    protected TextBox textCambioDireccion;
    protected DropDownList comboCambioDepartamento;
    protected DropDownList comboCambioCiudad;
    protected CheckBox CheckCambioRazonSocial;
    protected TextBox textCambioRazonSocial;
    protected CheckBox CheckRepresentanteLegal;
    protected Label labelCambioRepresentanteLegal;
    protected Label labelCambioTipoDocumentoRL;
    protected Label labelCambioDocumentoRL;
    protected TextBox textCambioRepresentanteLegal;
    protected DropDownList comboCambioTipoDocumentoRL;
    protected TextBox textCambioDocumentoRL;
    protected CheckBox CheckOtros;
    protected TextBox textOtros;
    protected CheckBox CheckEquipoAdicional;
    protected Panel PanelEquipoReasignar;
    protected Label label6;
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
    protected Button buttonAdicionar;
    protected Button buttonCancelarEquipos;
    protected GridView gridSolicitudEquipos;
    protected Label label5;
    protected TextBox textValorTotal;
    protected Panel PanelTerminacion;
    protected Label label7;
    protected Label labelMotivo;
    protected TextBox textMotivoTerminacion;
    protected Label label2;
    protected DocumentosVarios DocumentosVarios1;
    protected Panel panelBotones;
    protected Button buttonGuardar;
    protected Button buttonCancelar;

    protected new void Page_Load(object sender, EventArgs e)
    {
      this.buttonGuardar.Enabled = this.Usuario.permiteOperacion(EPermiso.ModificarNovedadesDeEquipos) || this.Usuario.permiteOperacion(EPermiso.AdicionarNovedadesDeEquipos);
      this.ControlError1.Visible = false;
      if (this.IsPostBack)
        return;
      this.InitData();
    }

    private void InitData()
    {
      this.labelKit.Visible = false;
      this.comboKit.Visible = false;
      this.comboTipoDocumentoBuscar.DataSource = (object) CLinq.ListAll<dti_DocumentoTipo>((DataContext) this.MyDataContext);
      this.comboTipoDocumentoBuscar.DataBind();
      this.comboTipoDocumentoBuscar.Items.Insert(0, "");
      this.comboCambioTipoDocumentoRL.DataSource = (object) CLinq.ListAll<dti_DocumentoTipo>((DataContext) this.MyDataContext);
      this.comboCambioTipoDocumentoRL.DataBind();
      this.comboCambioTipoDocumentoRL.Items.Insert(0, "");
      this.comboCambioDepartamento.DataSource = (object) CLinq.ListAll<dep_Departamento>((DataContext) this.MyDataContext);
      this.comboCambioDepartamento.DataBind();
      this.comboCambioDepartamento.Items.Insert(0, "");
      this.comboLicitacion.DataSource = (object) CLinq.ListAll<lco_LicitacionCompra>((DataContext) this.MyDataContext);
      this.comboLicitacion.DataBind();
      this.comboLicitacion.Items.Insert(0, "");
      this.LocalInfo.SetData("idNovedad", (object) ((BaseModulo.strSendParam) this.LocalInfo.MyParams).id);
      this.DocumentosVarios1.Visible = false;
      if (((BaseModulo.strSendParam) this.LocalInfo.MyParams).id != 0)
      {
        if (((BaseModulo.strSendParam) this.LocalInfo.MyParams).tipo == "Ver")
        {
          CControl.Enable((Control) this.PanelDatosTercero, false);
          this.buttonGuardar.Enabled = false;
        }
        this.mostrarDatos(((BaseModulo.strSendParam) this.LocalInfo.MyParams).id);
      }
      else
      {
        this.LocalInfo.MyParams = (object) new neq_NovedadEquipo();
        this.LocalInfo.SetData("listaEquiposSolicitados", (object) this.listaEquiposSolicitados);
        this.LocalInfo.SetData("listaSolicitudGrilla", (object) this.listaSolicitudGrilla);
        this.LocalInfo.SetData("idProvisional", (object) null);
        this.LocalInfo.SetData("valorTotal", (object) "0");
      }
    }

    private void mostrarDatos(int id)
    {
      neq_NovedadEquipo byKey1 = CLinq.FindByKey<neq_NovedadEquipo>((DataContext) this.MyDataContext, (object) id);
      this.LocalInfo.MyParams = (object) byKey1;
      ter_Tercero byKey2 = CLinq.FindByKey<ter_Tercero>((DataContext) this.MyDataContext, (object) byKey1.seq_SolicitudEquipo.ter_Id);
      this.textValorTotal.Text = byKey1.neq_ValorTotal.ToString();
      this.LocalInfo.SetData("valorTotal", (object) this.textValorTotal.Text);
      this.PanelDatosTercero.Visible = true;
      this.PanelBuscarTercero.Visible = false;
      this.panelBotones.Visible = true;
      this.ActualizarDatosTercero(byKey2);
      this.dateFechaNovedad.Text = byKey1.neq_FechaNovedad.ToString();
      if (byKey1.nti_Id == 2)
      {
        this.RadioOtroSi.Checked = true;
        this.PanelOtroSi.Visible = true;
        if (byKey1.neq_Direccion != null)
        {
          this.CheckCambioDirección.Checked = true;
          this.textCambioDireccion.Visible = true;
          this.comboCambioDepartamento.Visible = true;
          this.comboCambioCiudad.Visible = true;
          this.labelCambioDireccion.Visible = true;
          this.labelCambioDepartamento.Visible = true;
          this.labelCambioMunicipio.Visible = true;
          this.textCambioDireccion.Text = byKey1.neq_Direccion;
          this.comboCambioDepartamento.SelectedValue = byKey1.dep_Id.ToString();
          this.listarMunicipio(this.comboCambioDepartamento.SelectedValue);
          this.comboCambioCiudad.SelectedValue = byKey1.mun_Id.ToString();
        }
        if (byKey1.neq_RazonSocial != null)
        {
          this.CheckCambioRazonSocial.Checked = true;
          this.textCambioRazonSocial.Visible = true;
          this.textCambioRazonSocial.Text = byKey1.neq_RazonSocial;
        }
        if (byKey1.neq_RepresentanteLegal != null)
        {
          this.CheckRepresentanteLegal.Checked = true;
          this.textCambioRepresentanteLegal.Visible = true;
          this.textCambioDocumentoRL.Visible = true;
          this.comboCambioTipoDocumentoRL.Visible = true;
          this.labelCambioDocumentoRL.Visible = true;
          this.labelCambioTipoDocumentoRL.Visible = true;
          this.labelCambioRepresentanteLegal.Visible = true;
          this.textCambioRepresentanteLegal.Text = byKey1.neq_RepresentanteLegal;
          this.comboCambioTipoDocumentoRL.SelectedValue = byKey1.dti_Id.ToString();
          this.textCambioDocumentoRL.Text = byKey1.neq_NumeroDocumento;
        }
        if (byKey1.neq_Otros != null)
        {
          this.CheckOtros.Checked = true;
          this.textOtros.Visible = true;
          this.textOtros.Text = byKey1.neq_Otros;
        }
        if (byKey1.nea_NovedadEquiposAsignados.Count > 0)
        {
          this.CheckEquipoAdicional.Checked = true;
          this.PanelEquipoReasignar.Visible = true;
          this.ActualizarDatosGrilla(byKey1.nea_NovedadEquiposAsignados);
          this.LocalInfo.SetData("listaEquiposSolicitados", (object) byKey1.nea_NovedadEquiposAsignados);
          this.LocalInfo.MyParams = (object) byKey1;
        }
      }
      else if (byKey1.nti_Id == 3)
      {
        this.RadioTerminacion.Checked = true;
        this.PanelTerminacion.Visible = true;
        this.textValorTotal.Text = byKey1.neq_ValorTotal.ToString();
        this.textMotivoTerminacion.Text = byKey1.neq_MotivoTerminacion;
      }
      this.DocumentosVarios1.Visible = true;
      this.DocumentosVarios1.Init("Rrr.ndo_NovedadDocumento", "neq_Id", byKey1.neq_Id.ToString(), this.MyDataContext.Connection.ConnectionString);
    }

    private void ActualizarDatosGrilla(
      EntitySet<nea_NovedadEquiposAsignado> listaEquiposAsignado)
    {
      int num = 0;
      for (int index = 0; index < listaEquiposAsignado.Count; ++index)
      {
        NovedadEquiposRegistrar.strSolicitudAsignado solicitudAsignado = new NovedadEquiposRegistrar.strSolicitudAsignado();
        if (num != listaEquiposAsignado[index].eki_EquipoKit.kco_Id)
        {
          solicitudAsignado.equipo = listaEquiposAsignado[index].eki_EquipoKit.kco_Id != 1 ? listaEquiposAsignado[index].eki_EquipoKit.kco_KitCompra.kco_Descripcion : listaEquiposAsignado[index].eki_EquipoKit.eki_Descripcion;
          solicitudAsignado.costo = listaEquiposAsignado[index].eki_EquipoKit.eki_costo.Value;
          solicitudAsignado.id = listaEquiposAsignado[index].eki_EquipoKit.kco_Id;
          solicitudAsignado.cantidad = listaEquiposAsignado[index].nea_Cantidad.Value;
          solicitudAsignado.idProvisional = index;
          num = listaEquiposAsignado[index].eki_EquipoKit.kco_Id;
          this.listaSolicitudGrilla.Add(solicitudAsignado);
        }
      }
      if (this.listaSolicitudGrilla.Count <= 0)
        return;
      this.gridSolicitudEquipos.DataSource = (object) this.listaSolicitudGrilla;
      this.gridSolicitudEquipos.DataBind();
      this.LocalInfo.SetData("listaSolicitudGrilla", (object) this.listaSolicitudGrilla);
    }

    protected void buttonBuscarTercero_Click(object sender, EventArgs e)
    {
      this.dsBuscarTercero.SelectParameters["beneficiario"].DefaultValue = this.textBeneficiarioBuscar.Text == "" ? "%" : this.textBeneficiarioBuscar.Text;
      this.dsBuscarTercero.SelectParameters["documento"].DefaultValue = this.textDocumento.Text == "" ? "%" : this.textDocumento.Text;
      this.dsBuscarTercero.SelectParameters["tipoDocumento"].DefaultValue = this.comboTipoDocumentoBuscar.SelectedValue == "" ? "0" : this.comboTipoDocumentoBuscar.SelectedValue;
    }

    protected void buttonAdicionarTercero_Click(object sender, EventArgs e) => this.Response.Redirect("~/Comunes/TerceroRegistrar.aspx?url=" + this.Page.Request.Url.LocalPath);

    protected void GridViewTerceroBuscar_RowCommand(object sender, GridViewCommandEventArgs e)
    {
      this.ControlError1.Show("", "");
      try
      {
        if (!e.CommandName.Equals("Seleccionar"))
          return;
        this.PanelDatosTercero.Visible = true;
        this.PanelBuscarTercero.Visible = false;
        ter_Tercero byKey = CLinq.FindByKey<ter_Tercero>((DataContext) this.MyDataContext, (object) int.Parse(this.GridViewTerceroBuscar.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString()));
        if (CLinq.ListByProperty<seq_SolicitudEquipo>((DataContext) this.MyDataContext, "ter_Id", (object) byKey.ter_Id).Count == 0)
        {
          this.buttonGuardar.Enabled = false;
          string message = "" + "Este tercero no tiene ningún equipo asignado. <br />";
          this.PanelBuscarTercero.Visible = true;
          this.PanelDatosTercero.Visible = false;
          throw new Exception(message);
        }
        this.buttonGuardar.Enabled = true;
        this.panelBotones.Visible = true;
        this.ActualizarDatosTercero(byKey);
      }
      catch (Exception ex)
      {
        this.ControlError1.Visible = true;
        this.ControlError1.Show(ex);
      }
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
      if (tercero.bti_Id != 2)
        return;
      this.textNombreRepresentante.Text = string.IsNullOrEmpty(tercero.ter_RepresentanteLegal) ? "" : tercero.ter_RepresentanteLegal;
      this.textTipoDocumentoRL.Text = tercero.dti_DocumentoTipo1 == null ? "" : tercero.dti_DocumentoTipo1.dti_Descripcion;
      this.textDocumentoRL.Text = string.IsNullOrEmpty(tercero.ter_NumeroDocumentoRepresentante) ? "" : tercero.ter_NumeroDocumentoRepresentante;
    }

    protected void buttonGuardar_Click(object sender, EventArgs e)
    {
      try
      {
        this.ValidarTodo();
        neq_NovedadEquipo myParams = (neq_NovedadEquipo) this.LocalInfo.MyParams;
        myParams.neq_Usuario = this.Usuario.login;
        if ((int) this.LocalInfo.GetData("idNovedad") == 0)
          myParams.nes_Id = 1;
        myParams.neq_FechaNovedad = DateTime.Today;
        if (this.RadioOtroSi.Checked)
        {
          if (this.CheckCambioDirección.Checked)
          {
            myParams.neq_Direccion = this.textCambioDireccion.Text.ToUpper();
            myParams.dep_Id = this.comboCambioDepartamento.SelectedValue;
            myParams.mun_Id = this.comboCambioCiudad.SelectedValue;
            myParams.neq_CausaNovedad = "Cambio dirección";
          }
          else if (this.CheckCambioRazonSocial.Checked)
          {
            myParams.neq_RazonSocial = this.textCambioRazonSocial.Text.ToUpper();
            myParams.neq_CausaNovedad = "Cambio razón social";
          }
          else if (this.CheckRepresentanteLegal.Checked)
          {
            myParams.neq_RepresentanteLegal = this.textCambioRepresentanteLegal.Text.ToUpper();
            myParams.dti_Id = new int?(int.Parse(this.comboCambioTipoDocumentoRL.SelectedValue));
            myParams.neq_NumeroDocumento = this.textCambioDocumentoRL.Text.ToUpper();
            myParams.neq_CausaNovedad = "Cambio representante legal";
          }
          else if (this.CheckOtros.Checked)
          {
            myParams.neq_Otros = this.textOtros.Text.ToUpper();
            myParams.neq_CausaNovedad = "Otras";
          }
          else if (this.CheckEquipoAdicional.Checked)
          {
            myParams.neq_ValorTotal = new Decimal?(Decimal.Parse(this.textValorTotal.Text));
            myParams.neq_Modificado = new DateTime?(DateTime.Now);
            myParams.neq_CausaNovedad = "Equipo adicional";
          }
          myParams.nti_Id = 2;
        }
        else if (this.RadioTerminacion.Checked)
        {
          myParams.neq_MotivoTerminacion = this.textMotivoTerminacion.Text.ToUpper();
          myParams.nti_Id = 3;
          myParams.neq_CausaNovedad = "Terminación del contrato";
        }
        if ((int) this.LocalInfo.GetData("idNovedad") == 0)
        {
          List<seq_SolicitudEquipo> seqSolicitudEquipoList = CLinq.ListByProperty<seq_SolicitudEquipo>((DataContext) this.MyDataContext, "ter_Id", (object) (int) this.LocalInfo.GetData("idTercero"));
          myParams.seq_SolicitudEquipo = seqSolicitudEquipoList[0];
          myParams.nes_Id = 1;
          this.MyDataContext.neq_NovedadEquipos.InsertOnSubmit(myParams);
        }
        this.MyDataContext.SubmitChanges();
        this.DocumentosVarios1.Visible = true;
        this.DocumentosVarios1.Init("Rrr.ndo_NovedadDocumento", "neq_Id", myParams.neq_Id.ToString(), this.MyDataContext.Connection.ConnectionString);
        if ((int) this.LocalInfo.GetData("idNovedad") == 0)
          CAuditoria.log(EPermiso.AdicionarNovedadesDeEquipos, myParams.neq_Id.ToString(), myParams.seq_SolicitudEquipo.ter_Tercero.ter_NombreCompleto, myParams.seq_SolicitudEquipo.ter_Tercero.ter_NumeroDocumento, "", "", this.Usuario.id);
        else
          CAuditoria.log(EPermiso.ModificarNovedadesDeEquipos, myParams.neq_Id.ToString(), myParams.seq_SolicitudEquipo.ter_Tercero.ter_NombreCompleto, myParams.seq_SolicitudEquipo.ter_Tercero.ter_NumeroDocumento, "", "", this.Usuario.id);
        this.Server.Transfer("~/Recuperacion/NovedadEquiposBuscar.aspx");
      }
      catch (Exception ex)
      {
      }
    }

    private void ValidarTodo()
    {
      string message = "";
      bool flag = true;
      if (!this.RadioOtroSi.Checked && !this.RadioTerminacion.Checked)
      {
        message = message + message + "Debe seleccionar un tipo de novedad. <br />";
        flag = false;
      }
      if (!flag)
        throw new Exception(message);
    }

    protected void buttonCancelar_Click(object sender, EventArgs e) => this.Server.Transfer("~/Recuperacion/NovedadEquiposBuscar.aspx");

    protected void CheckEquipoAdicional_CheckedChanged(object sender, EventArgs e) => this.PanelEquipoReasignar.Visible = true;

    protected void CheckCambioDirección_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckCambioDirección.Checked)
      {
        this.textCambioDireccion.Visible = true;
        this.comboCambioDepartamento.Visible = true;
        this.comboCambioCiudad.Visible = true;
        this.labelCambioDireccion.Visible = true;
        this.labelCambioDepartamento.Visible = true;
        this.labelCambioMunicipio.Visible = true;
      }
      else
      {
        this.textCambioDireccion.Visible = false;
        this.comboCambioDepartamento.Visible = false;
        this.comboCambioCiudad.Visible = false;
        this.labelCambioDireccion.Visible = false;
        this.labelCambioDepartamento.Visible = false;
        this.labelCambioMunicipio.Visible = false;
      }
    }

    protected void CheckCambioRazonSocial_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckCambioRazonSocial.Checked)
        this.textCambioRazonSocial.Visible = true;
      else
        this.textCambioRazonSocial.Visible = false;
    }

    protected void CheckOtros_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckOtros.Checked)
        this.textOtros.Visible = true;
      else
        this.textOtros.Visible = false;
    }

    protected void RadioOtroSi_CheckedChanged(object sender, EventArgs e)
    {
      this.PanelOtroSi.Visible = true;
      this.PanelTerminacion.Visible = false;
    }

    protected void RadioTerminacion_CheckedChanged(object sender, EventArgs e)
    {
      this.PanelOtroSi.Visible = false;
      this.PanelTerminacion.Visible = true;
    }

    protected void CheckRepresentanteLegal_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckRepresentanteLegal.Checked)
      {
        this.textCambioRepresentanteLegal.Visible = true;
        this.textCambioDocumentoRL.Visible = true;
        this.comboCambioTipoDocumentoRL.Visible = true;
        this.labelCambioDocumentoRL.Visible = true;
        this.labelCambioTipoDocumentoRL.Visible = true;
        this.labelCambioRepresentanteLegal.Visible = true;
      }
      else
      {
        this.textCambioRepresentanteLegal.Visible = false;
        this.textCambioDocumentoRL.Visible = false;
        this.comboCambioTipoDocumentoRL.Visible = false;
        this.labelCambioDocumentoRL.Visible = false;
        this.labelCambioTipoDocumentoRL.Visible = false;
        this.labelCambioRepresentanteLegal.Visible = false;
      }
    }

    protected void buttonAdicionar_Click(object sender, EventArgs e)
    {
      this.listaEquiposSolicitados = (EntitySet<nea_NovedadEquiposAsignado>) this.LocalInfo.GetData("listaEquiposSolicitados");
      try
      {
        this.Validar();
        this.ControlError.Visible = false;
        if (this.comboEquipo.SelectedValue != "")
        {
          for (int index = 0; index < int.Parse(this.textCantidad.Text); ++index)
          {
            nea_NovedadEquiposAsignado entity = new nea_NovedadEquiposAsignado();
            entity.eki_EquipoKit = CLinq.FindByKey<eki_EquipoKit>((DataContext) this.MyDataContext, (object) int.Parse(this.comboEquipo.SelectedValue));
            entity.neq_NovedadEquipo = (neq_NovedadEquipo) this.LocalInfo.MyParams;
            entity.nea_Cantidad = new int?(1);
            eki_EquipoKit ekiEquipoKit = entity.eki_EquipoKit;
            int? ekiDisponible = entity.eki_EquipoKit.eki_Disponible;
            int? nullable = ekiDisponible.HasValue ? new int?(ekiDisponible.GetValueOrDefault() - 1) : new int?();
            ekiEquipoKit.eki_Disponible = nullable;
            this.MyDataContext.nea_NovedadEquiposAsignados.InsertOnSubmit(entity);
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
      EntitySet<nea_NovedadEquiposAsignado> listaEquiposSolicitados)
    {
      this.listaSolicitudGrilla = (List<NovedadEquiposRegistrar.strSolicitudAsignado>) this.LocalInfo.GetData("listaSolicitudGrilla");
      if (this.listaSolicitudGrilla.Count > 0 || listaEquiposSolicitados.Count > 0)
      {
        if (this.textCantidad.Text != "0")
        {
          for (int index = 0; index < int.Parse(this.textCantidad.Text); ++index)
          {
            NovedadEquiposRegistrar.strSolicitudAsignado solicitudAsignado = new NovedadEquiposRegistrar.strSolicitudAsignado();
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

    protected void buttonCancelarEquipos_Click(object sender, EventArgs e) => this.PanelEquipos.Visible = false;

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

    protected void comboLicitacion_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.listarEquipos(this.comboLicitacion.SelectedValue);
      this.labelKit.Visible = false;
      this.comboKit.Visible = false;
      this.labelEquipo.Visible = true;
      this.comboEquipo.Visible = true;
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

    protected void comboKit_SelectedIndexChanged(object sender, EventArgs e)
    {
      kco_KitCompra byKey = CLinq.FindByKey<kco_KitCompra>((DataContext) this.MyDataContext, (object) int.Parse(this.comboKit.SelectedValue));
      this.textDisponible.Text = byKey.kco_Disponible.ToString();
      this.textCosto.Text = byKey.kco_costo.ToString();
    }

    protected void comboEquipo_SelectedIndexChanged(object sender, EventArgs e)
    {
      eki_EquipoKit byKey = CLinq.FindByKey<eki_EquipoKit>((DataContext) this.MyDataContext, (object) int.Parse(this.comboEquipo.SelectedValue));
      this.textDisponible.Text = byKey.eki_Disponible.ToString();
      this.textCosto.Text = byKey.eki_costo.ToString();
    }

    protected void gridSolicitudEquipos_RowCommand(object sender, GridViewCommandEventArgs e)
    {
      int num1 = int.Parse(this.gridSolicitudEquipos.Rows[int.Parse((string) e.CommandArgument)].Cells[CGridView.ColIndexByField(this.gridSolicitudEquipos, "id")].Text);
      int index1 = int.Parse(this.gridSolicitudEquipos.Rows[int.Parse((string) e.CommandArgument)].Cells[CGridView.ColIndexByField(this.gridSolicitudEquipos, "idProvisional")].Text);
      this.listaEquiposSolicitados = (EntitySet<nea_NovedadEquiposAsignado>) this.LocalInfo.GetData("listaEquiposSolicitados");
      this.listaSolicitudGrilla = (List<NovedadEquiposRegistrar.strSolicitudAsignado>) this.LocalInfo.GetData("listaSolicitudGrilla");
      int num2 = this.listaEquiposSolicitados.Count - 1;
      if (!e.CommandName.Equals("Eliminar"))
        return;
      for (int index2 = num2; index2 >= 0; --index2)
      {
        if (this.listaEquiposSolicitados[index2].eki_EquipoKit.kco_Id == num1)
        {
          this.MyDataContext.nea_NovedadEquiposAsignados.DeleteOnSubmit(this.listaEquiposSolicitados[index2]);
          this.listaEquiposSolicitados.Remove(this.listaEquiposSolicitados[index2]);
        }
      }
      if (this.listaEquiposSolicitados.Count == 0)
        this.textValorTotal.Text = "0";
      this.textValorTotal.Text = (Decimal.Parse(this.LocalInfo.GetData("valorTotal").ToString()) - (Decimal) this.listaSolicitudGrilla[index1].cantidad * this.listaSolicitudGrilla[index1].costo).ToString();
      this.listaSolicitudGrilla.Remove(this.listaSolicitudGrilla[index1]);
      this.LocalInfo.SetData("listaSolicitudGrilla", (object) this.listaSolicitudGrilla);
      this.alimentarGrilla(this.listaEquiposSolicitados);
    }

    protected void comboDepartamento_SelectedIndexChanged(object sender, EventArgs e) => this.listarMunicipio(this.comboCambioDepartamento.SelectedValue);

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
