// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.ReporteUsoRegistrar
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using AjaxControlToolkit;
using NE.CLib;
using NE.CLib.Linq;
using Seguridad.Servicio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using UTO.Comunes;

namespace UTO.Recuperacion
{
  public class ReporteUsoRegistrar : BaseModulo
  {
    private EntitySet<rdt_ReporteUsoDetalle> listaReporteUso = new EntitySet<rdt_ReporteUsoDetalle>();
    private List<ReporteUsoRegistrar.strReporteUso> listaReporteGrilla = new List<ReporteUsoRegistrar.strReporteUso>();
    protected ToolkitScriptManager ToolkitScriptManager1;
    protected Label labelBusquedaSolicitudesEquipos;
    protected ControlError ControlError2;
    protected Panel PanelBuscarTercero;
    protected Label labelparametros;
    protected Label labelNombreBeneficiario;
    protected TextBox textNombreBeneficiarioBuscar;
    protected Label label3;
    protected DropDownList comboTipoDocumentoBuscar;
    protected Label labelNumeroDocumento;
    protected TextBox textNumeroDocumentoBuscar;
    protected Button buttonBuscarTercero;
    protected GridView GridViewTerceroBuscar;
    protected SqlDataSource dsBuscarTercero;
    protected Panel PanelDatosTercero;
    protected Label label1;
    protected Label labelComodato;
    protected TextBox textComodato;
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
    protected Label labelTelefono;
    protected TextBox textTelefono;
    protected Label labelTipoBeneficiario;
    protected TextBox textTipoBeneficiario;
    protected Label labelPeriodo;
    protected DropDownList comboPeriodo;
    protected Label labelAno;
    protected DropDownList comboAno;
    protected Label label4;
    protected LinkButton linkDatosReporteUso;
    protected ImageButton imageReporteUso;
    protected UpdatePanel UpdatePanelReporteUso;
    protected Panel panelReporteUso;
    protected ControlError ControlError1;
    protected Label labelTipoGas;
    protected DropDownList comboTipoGas;
    protected Label labelUso;
    protected DropDownList comboUso;
    protected Label labelKg0;
    protected TextBox textLb;
    protected Label labelLibras0;
    protected TextBox textKg;
    protected Label labelPresentacion;
    protected DropDownList comboPresentacion;
    protected TextBox textIdReporte;
    protected Label labelEstado;
    protected DropDownList comboeEstado;
    protected Button buttonAdicionar;
    protected GridView gridReporteUso;
    protected CollapsiblePanelExtender colapsibleCompraUno;
    protected UpdatePanel UpdatePanelCentro;
    protected CheckBox CheckEnvioRegenerar;
    protected Label labelCentroRegeneracion;
    protected DropDownList comboCentroRegeneracion;
    protected CheckBox CheckManejoEquipos;
    protected TextBox textProblemaEquipos;
    protected CheckBox CheckSolucion;
    protected TextBox textAccionTomada;
    protected Label label2;
    protected DocumentosVarios DocumentosVarios;
    protected Button buttonGuardar;
    protected Button buttonExportar;
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
      this.comboTipoDocumentoBuscar.DataSource = (object) CLinq.ListAll<dti_DocumentoTipo>((DataContext) this.MyDataContext);
      this.comboTipoDocumentoBuscar.DataBind();
      this.comboTipoDocumentoBuscar.Items.Insert(0, "");
      this.comboTipoGas.DataSource = (object) CLinq.ListAll<gti_GasTipo>((DataContext) this.MyDataContext);
      this.comboTipoGas.DataBind();
      this.comboTipoGas.Items.Insert(0, "");
      this.comboUso.DataSource = (object) CLinq.ListAll<gus_GasUso>((DataContext) this.MyDataContext);
      this.comboUso.DataBind();
      this.comboUso.Items.Insert(0, "");
      this.comboPresentacion.DataSource = (object) CLinq.ListAll<psu_PresentacionSustancia>((DataContext) this.MyDataContext);
      this.comboPresentacion.DataBind();
      this.comboPresentacion.Items.Insert(0, "");
      this.comboAno.DataSource = (object) this.MyDataContext.spComboAno(new int?(5), new int?(1)).ToList<spComboAnoResult>();
      this.comboAno.DataBind();
      this.comboAno.Items.Insert(0, "");
      this.comboCentroRegeneracion.DataSource = (object) CLinq.ListAll<cre_CentroRegeneracion>((DataContext) this.MyDataContext);
      this.comboCentroRegeneracion.DataBind();
      this.comboCentroRegeneracion.Items.Insert(0, "");
      this.comboPeriodo.DataSource = this.cargarPeriodo();
      this.comboPeriodo.DataBind();
      this.comboPeriodo.Items.Insert(0, "");
      this.LocalInfo.SetData("idReporte", (object) ((BaseModulo.strSendParam) this.LocalInfo.MyParams).id);
      if (((BaseModulo.strSendParam) this.LocalInfo.MyParams).id != 0)
      {
        BaseModulo.strSendParam myParams = (BaseModulo.strSendParam) this.LocalInfo.MyParams;
        if (myParams.tipo == "Ver")
        {
          this.colapsibleCompraUno.Collapsed = false;
          this.PanelDatosTercero.Enabled = false;
          this.buttonGuardar.Enabled = false;
        }
        myParams = (BaseModulo.strSendParam) this.LocalInfo.MyParams;
        this.mostrarDatos(myParams.id);
      }
      else
      {
        this.LocalInfo.MyParams = (object) new rdu_ReporteUso();
        this.LocalInfo.SetData("listaReporteUso", (object) this.listaReporteUso);
        this.LocalInfo.SetData("listaReporteGrilla", (object) this.listaReporteGrilla);
        this.LocalInfo.SetData("idProvisional", (object) null);
        this.LocalInfo.SetData("valorTotal", (object) "0");
      }
    }

    private object cargarPeriodo() => (object) new List<string>()
    {
      "PRIMERO",
      "SEGUNDO",
      "TERCERO",
      "CUARTO"
    };

    private void mostrarDatos(int id)
    {
      rdu_ReporteUso byKey1 = CLinq.FindByKey<rdu_ReporteUso>((DataContext) this.MyDataContext, (object) id);
      ter_Tercero byKey2 = CLinq.FindByKey<ter_Tercero>((DataContext) this.MyDataContext, (object) byKey1.ter_Id);
      this.PanelDatosTercero.Visible = true;
      this.PanelBuscarTercero.Visible = false;
      this.ActualizarDatosTercero(byKey2);
      this.ActualizarDatosGrilla(byKey1.rdt_ReporteUsoDetalles);
      this.LocalInfo.SetData("listaReporteUso", (object) byKey1.rdt_ReporteUsoDetalles);
      this.LocalInfo.MyParams = (object) byKey1;
      this.comboPeriodo.SelectedValue = byKey1.rdu_Periodo.ToUpper();
      this.comboAno.SelectedValue = byKey1.rdu_Ano.ToString();
      List<seq_SolicitudEquipo> seqSolicitudEquipoList = CLinq.ListByProperty<seq_SolicitudEquipo>((DataContext) this.MyDataContext, "ter_Id", (object) byKey1.ter_Id);
      this.textComodato.Text = seqSolicitudEquipoList[0].seq_Comodato;
      int num;
      string str1;
      if (seqSolicitudEquipoList[0].seq_FechaElaboracionMinuta.HasValue)
      {
        num = seqSolicitudEquipoList[0].seq_FechaElaboracionMinuta.Value.Year;
        str1 = "/" + num.ToString();
      }
      else
        str1 = "";
      string str2 = str1;
      this.textComodato.Text = seqSolicitudEquipoList[0].seq_Comodato + str2;
      if (byKey1.rdu_EnvioCentroRegeneracion)
      {
        this.comboCentroRegeneracion.SelectedValue = byKey1.cre_Id.ToString();
        this.CheckEnvioRegenerar.Checked = true;
        this.comboCentroRegeneracion.Visible = true;
        this.labelCentroRegeneracion.Visible = true;
      }
      if (byKey1.rdu_ReportaProblemas)
      {
        this.textProblemaEquipos.Text = byKey1.rdu_Observaciones;
        this.CheckManejoEquipos.Checked = true;
        this.textProblemaEquipos.Visible = true;
        this.CheckSolucion.Visible = true;
        this.CheckSolucion.Checked = byKey1.rdu_ReportaProblemas;
      }
      if (byKey1.rdu_ReportaProblemas)
      {
        this.textAccionTomada.Visible = true;
        this.textAccionTomada.Text = byKey1.rdu_AccionRealizada;
      }
      DocumentosVarios documentosVarios = this.DocumentosVarios;
      num = byKey1.rdu_Id;
      string relationId = num.ToString();
      string connectionString = this.MyDataContext.Connection.ConnectionString;
      documentosVarios.Init("Rrr.rud_ReporteUsoDocumento", "rdu_Id", relationId, connectionString);
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

    private void ActualizarDatosGrilla(EntitySet<rdt_ReporteUsoDetalle> listaReporteUso)
    {
      List<ReporteUsoRegistrar.strReporteUso> strReporteUsoList = new List<ReporteUsoRegistrar.strReporteUso>();
      for (int index = 0; index < listaReporteUso.Count; ++index)
      {
        ReporteUsoRegistrar.strReporteUso strReporteUso = new ReporteUsoRegistrar.strReporteUso()
        {
          mes = listaReporteUso[index].rdu_ReporteUso.rdu_Ano.ToString(),
          periodo = listaReporteUso[index].rdu_ReporteUso.rdu_Periodo,
          tipoGas = listaReporteUso[index].gti_GasTipo.gti_Descripcion,
          uso = listaReporteUso[index].gus_GasUso.gus_Descripcion
        };
        strReporteUso.libra = (Decimal) ((double) (int) strReporteUso.libra / 0.45359237);
        strReporteUso.kilo = listaReporteUso[index].rdt_Cantidad;
        if (listaReporteUso[index].psu_Id.HasValue)
          strReporteUso.presentacion = listaReporteUso[index].psu_PresentacionSustancia.psu_Descripcion;
        int rdtId = listaReporteUso[index].rdt_Id;
        strReporteUso.id = listaReporteUso[index].rdt_Id;
        strReporteUso.idProvisional = index;
        strReporteUsoList.Add(strReporteUso);
      }
      if (strReporteUsoList.Count > 0)
      {
        this.gridReporteUso.DataSource = (object) strReporteUsoList;
        this.gridReporteUso.DataBind();
        this.LocalInfo.SetData("listaReporteGrilla", (object) strReporteUsoList);
      }
      else
      {
        this.gridReporteUso.DataSource = (object) null;
        this.gridReporteUso.DataBind();
      }
    }

    protected void buttonAdicionarTercero_Click(object sender, EventArgs e) => this.Response.Redirect("~/Comunes/TerceroRegistrar.aspx");

    protected void GridViewTerceroBuscar_RowCommand(object sender, GridViewCommandEventArgs e)
    {
      try
      {
        if (!e.CommandName.Equals("Seleccionar"))
          return;
        this.PanelDatosTercero.Visible = true;
        this.PanelBuscarTercero.Visible = false;
        ter_Tercero byKey = CLinq.FindByKey<ter_Tercero>((DataContext) this.MyDataContext, (object) int.Parse(this.GridViewTerceroBuscar.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString()));
        List<seq_SolicitudEquipo> seqSolicitudEquipoList = CLinq.ListByProperty<seq_SolicitudEquipo>((DataContext) this.MyDataContext, "ter_Id", (object) byKey.ter_Id);
        if (seqSolicitudEquipoList.Count == 0)
        {
          this.buttonGuardar.Enabled = false;
          this.buttonExportar.Enabled = false;
          string message = "" + "Este tercero no tiene ningún equipo asignado. <br />";
          this.PanelDatosTercero.Visible = false;
          this.PanelBuscarTercero.Visible = true;
          throw new Exception(message);
        }
        this.buttonGuardar.Enabled = true;
        this.textComodato.Text = seqSolicitudEquipoList[0].seq_Comodato;
        this.ActualizarDatosTercero(byKey);
      }
      catch (Exception ex)
      {
        this.ControlError2.Visible = true;
        this.ControlError2.Show(ex);
      }
    }

    protected void buttonBuscarTercero_Click(object sender, EventArgs e)
    {
      DataView dataView = new DataView();
      try
      {
        this.dsBuscarTercero.SelectParameters["beneficiario"].DefaultValue = this.textNombreBeneficiarioBuscar.Text == "" ? "%" : this.textNombreBeneficiarioBuscar.Text;
        this.dsBuscarTercero.SelectParameters["documento"].DefaultValue = this.textNumeroDocumentoBuscar.Text == "" ? "%" : this.textNumeroDocumentoBuscar.Text;
        this.dsBuscarTercero.SelectParameters["tipoDocumento"].DefaultValue = this.comboTipoDocumentoBuscar.SelectedValue == "" ? "0" : this.comboTipoDocumentoBuscar.SelectedValue;
        if (((DataView) this.dsBuscarTercero.Select((DataSourceSelectArguments) null)).Count == 0)
          throw new Exception("La búsqueda no encontró resultados.");
      }
      catch (Exception ex)
      {
        this.ControlError1.Visible = true;
        this.ControlError1.Show(ex);
      }
    }

    protected void buttonGuardar_Click(object sender, EventArgs e)
    {
      rdu_ReporteUso myParams = (rdu_ReporteUso) this.LocalInfo.MyParams;
      myParams.rdu_Periodo = this.comboPeriodo.SelectedItem.ToString();
      myParams.rdu_Ano = int.Parse(this.comboAno.SelectedValue);
      myParams.rdu_EnvioCentroRegeneracion = this.CheckEnvioRegenerar.Checked;
      myParams.rdu_ReportaProblemas = this.CheckManejoEquipos.Checked;
      myParams.ter_Id = (int) this.LocalInfo.GetData("idTercero");
      myParams.rdu_SolucionProblema = this.CheckSolucion.Checked;
      if (this.CheckEnvioRegenerar.Checked)
      {
        cre_CentroRegeneracion byKey = CLinq.FindByKey<cre_CentroRegeneracion>((DataContext) this.MyDataContext, (object) int.Parse(this.comboCentroRegeneracion.SelectedValue));
        myParams.cre_CentroRegeneracion = byKey;
      }
      myParams.rdu_Observaciones = !myParams.rdu_ReportaProblemas ? "" : this.textProblemaEquipos.Text.ToUpper();
      myParams.rdu_AccionRealizada = !myParams.rdu_SolucionProblema ? "" : this.textAccionTomada.Text.ToUpper();
      if ((int) this.LocalInfo.GetData("idReporte") == 0)
        this.MyDataContext.rdu_ReporteUsos.InsertOnSubmit(myParams);
      this.DocumentosVarios.Init("Rrr.rud_ReporteUsoDocumento", "rdu_Id", myParams.rdu_Id.ToString(), this.MyDataContext.Connection.ConnectionString);
      this.MyDataContext.SubmitChanges();
      if ((int) this.LocalInfo.GetData("idReporte") == 0)
        CAuditoria.log(EPermiso.AdicionarReporteDeUso, myParams.rdu_Id.ToString(), myParams.ter_Tercero.ter_NombreCompleto, myParams.ter_Tercero.ter_NumeroDocumento, "", "", this.Usuario.id);
      else
        CAuditoria.log(EPermiso.ModificarReporteDeUso, myParams.rdu_Id.ToString(), myParams.ter_Tercero.ter_NombreCompleto, myParams.ter_Tercero.ter_NumeroDocumento, "", "", this.Usuario.id);
      this.Server.Transfer("~/Recuperacion/ReporteUsoBuscar.aspx");
    }

    protected void buttonCancelar_Click(object sender, EventArgs e) => this.Server.Transfer("~/Recuperacion/ReporteUsoBuscar.aspx");

    protected void buttonAdicionar_Click(object sender, EventArgs e)
    {
      rdt_ReporteUsoDetalle entity = (rdt_ReporteUsoDetalle) null;
      this.listaReporteUso = (EntitySet<rdt_ReporteUsoDetalle>) this.LocalInfo.GetData("listaReporteUso");
      try
      {
        this.Validar();
        this.ControlError1.Visible = false;
        if (this.textIdReporte.Text == "")
          entity = new rdt_ReporteUsoDetalle();
        else if (this.textIdReporte.Text != "")
          entity = CLinq.FindByKey<rdt_ReporteUsoDetalle>((DataContext) this.MyDataContext, (object) int.Parse(this.textIdReporte.Text));
        if (entity == null)
          entity = new rdt_ReporteUsoDetalle();
        entity.rdu_ReporteUso = (rdu_ReporteUso) this.LocalInfo.MyParams;
        gti_GasTipo byKey1 = CLinq.FindByKey<gti_GasTipo>((DataContext) this.MyDataContext, (object) int.Parse(this.comboTipoGas.SelectedValue));
        entity.gti_GasTipo = byKey1;
        gus_GasUso byKey2 = CLinq.FindByKey<gus_GasUso>((DataContext) this.MyDataContext, (object) int.Parse(this.comboUso.SelectedValue));
        entity.gus_GasUso = byKey2;
        entity.rdt_Cantidad = Decimal.Parse(this.textLb.Text);
        if (this.comboPresentacion.SelectedValue != "")
        {
          psu_PresentacionSustancia byKey3 = CLinq.FindByKey<psu_PresentacionSustancia>((DataContext) this.MyDataContext, (object) int.Parse(this.comboPresentacion.SelectedValue));
          entity.psu_PresentacionSustancia = byKey3;
        }
        if (this.textIdReporte.Text == "")
          this.MyDataContext.rdt_ReporteUsoDetalles.InsertOnSubmit(entity);
        this.listaReporteUso.Add(entity);
        this.LocalInfo.SetData("listaReporteUso", (object) this.listaReporteUso);
        this.ActualizarDatosGrilla(this.listaReporteUso);
        this.comboTipoGas.SelectedValue = "";
        this.comboUso.SelectedValue = "";
        this.textLb.Text = "";
        this.textKg.Text = "";
        this.comboPresentacion.SelectedValue = "";
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
      bool flag = true & CValidator.isNumeric(this.textLb.Text, ref number, "La cantidad en libras debe ser un número. <br />", ref errStr);
      if (this.comboPeriodo.SelectedValue == "")
      {
        flag = false;
        errStr += "El periodo es un campo obligatorio";
      }
      if (this.comboAno.SelectedValue == "")
      {
        flag = false;
        errStr += "El año es un campo obligatorio";
      }
      if (this.comboTipoGas.SelectedValue == "")
      {
        flag = false;
        errStr += "El tipo de gas es un campo obligatorio";
      }
      if (this.comboUso.SelectedValue == "")
      {
        flag = false;
        errStr += "El uso de gas es un campo obligatorio";
      }
      if (this.comboUso.SelectedValue == "3" && this.comboPresentacion.SelectedValue == "")
      {
        flag = false;
        errStr += "La presentación del gas es un campo obligatorio";
      }
      if (!flag)
        throw new Exception(errStr);
    }

    protected void CheckEnvioRegenerar_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckEnvioRegenerar.Checked)
      {
        this.labelCentroRegeneracion.Visible = true;
        this.comboCentroRegeneracion.Visible = true;
      }
      else
      {
        this.labelCentroRegeneracion.Visible = false;
        this.comboCentroRegeneracion.Visible = false;
      }
    }

    protected void CheckManejoEquipos_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckManejoEquipos.Checked)
      {
        this.textProblemaEquipos.Visible = true;
        this.CheckSolucion.Visible = true;
        this.CheckSolucion.Checked = false;
      }
      else
      {
        this.textProblemaEquipos.Visible = false;
        this.CheckSolucion.Visible = false;
        this.CheckSolucion.Checked = false;
      }
    }

    protected void comboUso_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.comboUso.SelectedValue == "3")
      {
        this.labelPresentacion.Visible = true;
        this.comboPresentacion.Visible = true;
        this.labelEstado.Visible = true;
        this.comboeEstado.Visible = true;
      }
      else
      {
        this.labelPresentacion.Visible = false;
        this.comboPresentacion.Visible = false;
        this.labelEstado.Visible = false;
        this.comboeEstado.Visible = false;
      }
    }

    protected void textLb_TextChanged(object sender, EventArgs e) => this.textKg.Text = (Convert.ToDecimal(this.textLb.Text) / 0.45359237M).ToString();

    protected void comboPeriodo_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    protected void gridReporteUso_RowCommand(object sender, GridViewCommandEventArgs e)
    {
      int index = int.Parse(this.gridReporteUso.DataKeys[int.Parse((string) e.CommandArgument)].Values[0].ToString());
      int num = int.Parse(this.gridReporteUso.DataKeys[int.Parse((string) e.CommandArgument)].Values[1].ToString());
      this.listaReporteUso = (EntitySet<rdt_ReporteUsoDetalle>) this.LocalInfo.GetData("listaReporteUso");
      this.listaReporteGrilla = (List<ReporteUsoRegistrar.strReporteUso>) this.LocalInfo.GetData("listaReporteGrilla");
      if (e.CommandName.Equals("Modificar"))
      {
        this.comboTipoGas.SelectedValue = this.listaReporteUso[index].gti_Id.ToString();
        this.comboUso.SelectedValue = this.listaReporteUso[index].gus_Id.ToString();
        this.textLb.Text = this.listaReporteUso[index].rdt_Cantidad.ToString();
        this.textKg.Text = ((double) (int) Decimal.Parse(this.textLb.Text) / 0.45359237).ToString();
        this.comboPresentacion.SelectedValue = this.listaReporteUso[index].psu_Id.ToString();
        this.textIdReporte.Text = this.listaReporteUso[index].rdt_Id.ToString();
        if (num == 0)
          this.MyDataContext.rdt_ReporteUsoDetalles.DeleteOnSubmit(this.listaReporteUso[index]);
        this.listaReporteUso.Remove(this.listaReporteUso[index]);
        this.listaReporteGrilla.Remove(this.listaReporteGrilla[index]);
        this.LocalInfo.SetData("listaReporteGrilla", (object) this.listaReporteGrilla);
        this.ActualizarDatosGrilla(this.listaReporteUso);
        this.buttonAdicionar.Text = "Guardar";
      }
      if (!e.CommandName.Equals("Eliminar"))
        return;
      this.MyDataContext.rdt_ReporteUsoDetalles.DeleteOnSubmit(this.listaReporteUso[index]);
      this.listaReporteUso.Remove(this.listaReporteUso[index]);
      this.listaReporteGrilla.Remove(this.listaReporteGrilla[index]);
      this.LocalInfo.SetData("listaReporteGrilla", (object) this.listaReporteGrilla);
      this.ActualizarDatosGrilla(this.listaReporteUso);
    }

    protected void buttonExportar_Click(object sender, EventArgs e) => this.Exportar(this.gridReporteUso);

    protected void CheckSolucion_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckSolucion.Checked)
      {
        this.textAccionTomada.Visible = true;
        this.textAccionTomada.Text = "";
      }
      else
      {
        this.textAccionTomada.Visible = true;
        this.textAccionTomada.Text = "";
      }
    }

    protected void textLb_TextChanged1(object sender, EventArgs e)
    {
      try
      {
        this.textKg.Text = (Convert.ToDecimal(this.textLb.Text) / 0.45359237M).ToString();
      }
      catch (Exception ex)
      {
        this.ControlError1.Visible = true;
        this.ControlError1.Show(new Exception("No es un valor numérico válido"));
      }
    }

    public class strReporteUso
    {
      private string _mes;
      private string _periodo;
      private string _tipoGas;
      private string _uso;
      private Decimal _libra;
      private Decimal _kilo;
      private string _presentacion;
      private string _estado;
      private int _id;
      private int _idProvisional;

      public string mes
      {
        get => this._mes;
        set => this._mes = value;
      }

      public string periodo
      {
        get => this._periodo;
        set => this._periodo = value;
      }

      public string tipoGas
      {
        get => this._tipoGas;
        set => this._tipoGas = value;
      }

      public string uso
      {
        get => this._uso;
        set => this._uso = value;
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

      public string presentacion
      {
        get => this._presentacion;
        set => this._presentacion = value;
      }

      public string estado
      {
        get => this._estado;
        set => this._estado = value;
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

    public class strMes
    {
      private string _mes;

      public string mes
      {
        get => this._mes;
        set => this._mes = value;
      }
    }
  }
}
