// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.ReporteUsoBarridoRegistrar
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
  public class ReporteUsoBarridoRegistrar : BaseModulo
  {
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
    protected Label label11;
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
    protected Label Label1;
    protected DropDownList comboPeriodo;
    protected Label labelAno;
    protected DropDownList comboAno;
    protected LinkButton linkDatosReporteUso;
    protected ImageButton imageReporteUso;
    protected UpdatePanel UpdatePanelReporteUso;
    protected Panel panelReporteUso;
    protected Label label2;
    protected Label label4;
    protected TextBox txtCilindros;
    protected Label label5;
    protected TextBox txtCilindroKg;
    protected Label label7;
    protected DropDownList comboNitrogeno;
    protected Label label8;
    protected TextBox textObservacionNitrogeno;
    protected Label label9;
    protected Label label10;
    protected TextBox textUnidadesFiltro;
    protected Label label12;
    protected DropDownList comboFiltro;
    protected Label label13;
    protected TextBox textObservacionFiltro;
    protected Label label14;
    protected Label label15;
    protected TextBox textUnidadAcidez;
    protected Label label16;
    protected DropDownList comboAcidez;
    protected Label label17;
    protected TextBox textObservacionAcidez;
    protected CollapsiblePanelExtender colapsibleCompraUno;
    protected Label label6;
    protected DocumentosVarios DocumentosVarios;
    protected Button buttonGuardar;
    protected Button buttonCancelar;

    protected new void Page_Load(object sender, EventArgs e)
    {
      this.ControlError2.Visible = false;
      if (this.IsPostBack)
        return;
      this.InitData();
    }

    private void InitData()
    {
      this.comboTipoDocumentoBuscar.DataSource = (object) CLinq.ListAll<dti_DocumentoTipo>((DataContext) this.MyDataContext);
      this.comboTipoDocumentoBuscar.DataBind();
      this.comboTipoDocumentoBuscar.Items.Insert(0, "");
      this.comboNitrogeno.DataSource = (object) CLinq.ListByProperty<tim_TipoMantenimiento>((DataContext) this.MyDataContext, "tim_Tipo", (object) 1);
      this.comboNitrogeno.DataBind();
      this.comboNitrogeno.Items.Insert(0, "");
      this.comboNitrogeno.SelectedValue = "12";
      this.comboFiltro.DataSource = (object) CLinq.ListByProperty<tim_TipoMantenimiento>((DataContext) this.MyDataContext, "tim_Tipo", (object) 2);
      this.comboFiltro.DataBind();
      this.comboFiltro.Items.Insert(0, "");
      this.comboFiltro.SelectedValue = "13";
      this.comboAcidez.DataSource = (object) CLinq.ListByProperty<tim_TipoMantenimiento>((DataContext) this.MyDataContext, "tim_Tipo", (object) 3);
      this.comboAcidez.DataBind();
      this.comboAcidez.Items.Insert(0, "");
      this.comboAcidez.SelectedValue = "14";
      this.comboAno.DataSource = (object) this.MyDataContext.spComboAno(new int?(5), new int?(1)).ToList<spComboAnoResult>();
      this.comboAno.DataBind();
      this.comboAno.Items.Insert(0, "");
      this.comboPeriodo.DataSource = this.cargarPeriodo();
      this.comboPeriodo.DataBind();
      this.comboPeriodo.Items.Insert(0, "");
      this.txtCilindroKg.Text = "0";
      this.txtCilindros.Text = "0";
      this.textUnidadesFiltro.Text = "0";
      this.textUnidadAcidez.Text = "0";
      this.LocalInfo.SetData("idReporte", (object) ((BaseModulo.strSendParam) this.LocalInfo.MyParams).id);
      if (((BaseModulo.strSendParam) this.LocalInfo.MyParams).id != 0)
      {
        this.colapsibleCompraUno.Collapsed = false;
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
        this.LocalInfo.MyParams = (object) new rdb_ReporteUsoBarrido();
        this.LocalInfo.SetData("idProvisional", (object) null);
        this.LocalInfo.SetData("valorTotal", (object) "0");
      }
    }

    private void mostrarDatos(int id)
    {
      rdb_ReporteUsoBarrido byKey1 = CLinq.FindByKey<rdb_ReporteUsoBarrido>((DataContext) this.MyDataContext, (object) id);
      ter_Tercero byKey2 = CLinq.FindByKey<ter_Tercero>((DataContext) this.MyDataContext, (object) byKey1.ter_Id);
      this.PanelDatosTercero.Visible = true;
      this.PanelBuscarTercero.Visible = false;
      this.ActualizarDatosTercero(byKey2);
      this.LocalInfo.MyParams = (object) byKey1;
      this.comboPeriodo.SelectedValue = byKey1.rdb_Periodo;
      this.comboAno.SelectedValue = byKey1.rdb_Ano.ToString();
      this.textObservacionNitrogeno.Text = byKey1.rdb_NitrogenoObservacion.ToUpper();
      this.textObservacionFiltro.Text = byKey1.rdb_FiltroObservacion.ToUpper();
      this.textObservacionAcidez.Text = byKey1.rdb_AcidezObservacion.ToUpper();
      this.txtCilindroKg.Text = byKey1.rdb_NitrogenoKilo.ToString();
      this.txtCilindros.Text = byKey1.rdb_NitrogenoCilindro.ToString();
      this.textUnidadesFiltro.Text = byKey1.rdb_FiltroUnidad.ToString();
      this.textUnidadAcidez.Text = byKey1.rdb_AcidezUnidad.ToString();
      this.comboNitrogeno.SelectedValue = byKey1.tim_IdNitrogeno.ToString();
      this.comboFiltro.SelectedValue = byKey1.tim_IdFiltro.ToString();
      this.comboAcidez.SelectedValue = byKey1.tim_IdAcidez.ToString();
      this.DocumentosVarios.Init("Rrr.rbd_ReporteUsoBarridoDocumento", "rdb_Id", byKey1.rdb_Id.ToString(), this.MyDataContext.Connection.ConnectionString);
    }

    private object cargarPeriodo() => (object) new List<string>()
    {
      "PRIMERO",
      "SEGUNDO",
      "TERCERO",
      "CUARTO"
    };

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

    protected void GridViewTerceroBuscar_RowCommand(object sender, GridViewCommandEventArgs e)
    {
      try
      {
        if (!e.CommandName.Equals("Seleccionar"))
          return;
        this.PanelDatosTercero.Visible = true;
        this.PanelBuscarTercero.Visible = false;
        ter_Tercero byKey = CLinq.FindByKey<ter_Tercero>((DataContext) this.MyDataContext, (object) int.Parse(this.GridViewTerceroBuscar.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString()));
        this.buttonGuardar.Enabled = true;
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
      }
      catch (Exception ex)
      {
        this.ControlError2.Visible = true;
        this.ControlError2.Show(ex);
      }
    }

    protected void buttonGuardar_Click(object sender, EventArgs e)
    {
      try
      {
        this.Validar();
        rdb_ReporteUsoBarrido myParams = (rdb_ReporteUsoBarrido) this.LocalInfo.MyParams;
        myParams.rdb_Periodo = this.comboPeriodo.SelectedItem.ToString().ToUpper();
        myParams.rdb_Ano = int.Parse(this.comboAno.SelectedValue);
        myParams.ter_Id = (int) this.LocalInfo.GetData("idTercero");
        myParams.rdb_NitrogenoObservacion = this.textObservacionNitrogeno.Text.ToUpper();
        myParams.rdb_FiltroObservacion = this.textObservacionFiltro.Text.ToUpper();
        myParams.rdb_AcidezObservacion = this.textObservacionAcidez.Text.ToUpper();
        myParams.rdb_NitrogenoKilo = Decimal.Parse(this.txtCilindroKg.Text);
        myParams.rdb_NitrogenoCilindro = int.Parse(this.txtCilindros.Text);
        myParams.rdb_FiltroUnidad = int.Parse(this.textUnidadesFiltro.Text);
        myParams.rdb_AcidezUnidad = int.Parse(this.textUnidadAcidez.Text);
        int result = -1;
        myParams.tim_IdNitrogeno = !int.TryParse(this.comboNitrogeno.SelectedValue, out result) ? 12 : (result <= 0 ? 12 : result);
        myParams.tim_IdFiltro = !int.TryParse(this.comboFiltro.SelectedValue, out result) ? 13 : (result <= 0 ? 13 : result);
        if (int.TryParse(this.comboAcidez.SelectedValue, out result))
          myParams.tim_IdAcidez = result <= 0 ? 14 : result;
        else
          myParams.tim_IdNitrogeno = 14;
        if ((int) this.LocalInfo.GetData("idReporte") == 0)
          this.MyDataContext.rdb_ReporteUsoBarridos.InsertOnSubmit(myParams);
        this.DocumentosVarios.Init("Rrr.rbd_ReporteUsoBarridoDocumento", "rdb_Id", myParams.rdb_Id.ToString(), this.MyDataContext.Connection.ConnectionString);
        this.MyDataContext.SubmitChanges();
        if ((int) this.LocalInfo.GetData("idReporte") == 0)
          CAuditoria.log(EPermiso.AdicionarReporteDeUso, myParams.rdb_Id.ToString(), myParams.ter_Tercero.ter_NombreCompleto, myParams.ter_Tercero.ter_NumeroDocumento, "", "", this.Usuario.id);
        else
          CAuditoria.log(EPermiso.ModificarReporteDeUso, myParams.rdb_Id.ToString(), myParams.ter_Tercero.ter_NombreCompleto, myParams.ter_Tercero.ter_NumeroDocumento, "", "", this.Usuario.id);
        this.Server.Transfer("~/Recuperacion/ReporteUsoBuscar.aspx?tipo=0");
      }
      catch (Exception ex)
      {
        this.ControlError2.Visible = true;
        this.ControlError2.Show(ex);
      }
    }

    private void Validar()
    {
      string errStr = "";
      double number1 = 0.0;
      int number2 = -1;
      bool flag = true & CValidator.isInteger(this.txtCilindros.Text, ref number2, "La cantidad unidades cilindros debe ser un número entero. <br />", ref errStr) & CValidator.isNumeric(this.txtCilindroKg.Text, ref number1, "La cantidad de Kg debe ser un número. <br />", ref errStr) & CValidator.isInteger(this.textUnidadesFiltro.Text, ref number2, "La cantidad de filtros debe ser un número entero. <br />", ref errStr) & CValidator.isInteger(this.textUnidadAcidez.Text, ref number2, "La cantidad de test de acidez debe ser un número entero. <br />", ref errStr) & CValidator.isInteger(this.comboAno.SelectedValue, ref number2, "Debe seleccionar un año. <br />", ref errStr);
      if (this.comboPeriodo.SelectedValue == "")
      {
        flag = false;
        errStr += "Debe seleccionar un periodo. <br />";
      }
      if (!flag)
        throw new Exception(errStr);
    }

    protected void buttonCancelar_Click(object sender, EventArgs e) => this.Server.Transfer("~/Recuperacion/ReporteUsoBuscar.aspx?tipo=0");

    protected void buttonExportar_Click(object sender, EventArgs e)
    {
    }
  }
}
