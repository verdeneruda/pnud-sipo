// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.ReporteRegeneracionRegistrar
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using AjaxControlToolkit;
using NE.CLib;
using NE.CLib.Linq;
using NE.CLib.Web;
using Seguridad.Servicio;
using System;
using System.Data.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using UTO.Comunes;

namespace UTO.Recuperacion
{
  public class ReporteRegeneracionRegistrar : BaseModulo
  {
    protected ToolkitScriptManager ToolkitScriptManager1;
    protected Label labelBusquedaSolicitudesEquipos;
    protected ControlError ControlError1;
    protected Panel PanelDatosTercero;
    protected Label labelNombreCentro;
    protected DropDownList comboCentroRegeneracion;
    protected UpdatePanel UpdatePanelTercero;
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
    protected UpdatePanel UpdatePanelReporte;
    protected Label label1;
    protected Label labelBeneficiario;
    protected TextBox textBeneficiario;
    protected Label labelTipoGas;
    protected DropDownList comboTipoGas;
    protected Label labelFecha;
    protected TextBox textFecha;
    protected CalendarExtender CalendarExtender1;
    protected Label labelCantidadEntregadaKg;
    protected TextBox textUsoCantidadEntregada;
    protected Label labelCantidadEntregada;
    protected TextBox textUsoCantidadEntregadaKg;
    protected Label labelCantidadRegeneradaKg;
    protected TextBox textUsoCantidadRegenerada;
    protected Label labelCantidadRegenerada;
    protected TextBox textUsoCantidadRegeneradaKg;
    protected Label labelCantidadRechazadaKg;
    protected TextBox textUsoCantidadRechazada;
    protected Label labelCantidadRechazada;
    protected TextBox textUsoCantidadRechazadaKg;
    protected Label labelDestino;
    protected DropDownList comboDestino;
    protected Label labelCantidad;
    protected TextBox textCantidad;
    protected Label labelPorciento;
    protected TextBox textPorciento;
    protected Label label4;
    protected TextBox textObservaciones;
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
      this.comboTipoGas.DataSource = (object) CLinq.ListAll<gti_GasTipo>((DataContext) this.MyDataContext);
      this.comboTipoGas.DataBind();
      this.comboTipoGas.Items.Insert(0, "");
      this.comboCentroRegeneracion.DataSource = (object) CLinq.ListAll<cre_CentroRegeneracion>((DataContext) this.MyDataContext);
      this.comboCentroRegeneracion.DataBind();
      this.comboCentroRegeneracion.Items.Insert(0, "");
      this.comboDestino.DataSource = (object) CLinq.ListAll<gde_GasDestino>((DataContext) this.MyDataContext);
      this.comboDestino.DataBind();
      this.comboDestino.Items.Insert(0, "");
      this.LocalInfo.SetData("idReporte", (object) ((BaseModulo.strSendParam) this.LocalInfo.MyParams).id);
      if (((BaseModulo.strSendParam) this.LocalInfo.MyParams).id != 0)
      {
        BaseModulo.strSendParam myParams = (BaseModulo.strSendParam) this.LocalInfo.MyParams;
        if (myParams.tipo == "Ver")
        {
          CControl.Enable((Control) this.PanelDatosTercero, false);
          this.buttonGuardar.Enabled = false;
        }
        myParams = (BaseModulo.strSendParam) this.LocalInfo.MyParams;
        this.mostrarDatos(myParams.id);
      }
      else
      {
        this.LocalInfo.MyParams = (object) new rre_ReporteRegeneracion();
        this.LocalInfo.SetData("idProvisional", (object) null);
        this.textFecha.Text = DateTime.Today.ToShortDateString();
      }
    }

    private void mostrarDatos(int id)
    {
      rre_ReporteRegeneracion byKey1 = CLinq.FindByKey<rre_ReporteRegeneracion>((DataContext) this.MyDataContext, (object) id);
      ter_Tercero byKey2 = CLinq.FindByKey<ter_Tercero>((DataContext) this.MyDataContext, (object) byKey1.ter_Id);
      this.PanelDatosTercero.Visible = true;
      this.PanelBuscarTercero.Visible = false;
      this.LocalInfo.MyParams = (object) byKey1;
      this.comboTipoGas.SelectedValue = byKey1.gti_Id.ToString();
      this.textFecha.Text = byKey1.rre_Fecha.ToString();
      this.textBeneficiario.Text = byKey2.ter_NombreCompleto;
      this.textUsoCantidadEntregada.Text = byKey1.rre_CantidadEntregada.ToString();
      this.textUsoCantidadEntregadaKg.Text = (byKey1.rre_CantidadEntregada / Decimal.Parse("0,45359237")).ToString();
      this.textUsoCantidadRechazada.Text = byKey1.rre_CantidadRechazada.ToString();
      this.textUsoCantidadRechazadaKg.Text = (byKey1.rre_CantidadRechazada / Decimal.Parse("0,45359237")).ToString();
      this.textUsoCantidadRegenerada.Text = byKey1.rre_CantidadRegenerada.ToString();
      this.textUsoCantidadRegeneradaKg.Text = (byKey1.rre_CantidadRegenerada / Decimal.Parse("0,45359237")).ToString();
      this.textObservaciones.Text = byKey1.rre_Observacion;
      this.comboDestino.SelectedValue = byKey1.gde_Id.ToString();
      this.textCantidad.Text = byKey1.rre_Cantidad.ToString();
      this.textPorciento.Text = byKey1.rre_Porciento.ToString();
      this.comboCentroRegeneracion.SelectedValue = byKey1.cre_Id.ToString();
      this.LocalInfo.SetData("idTercero", (object) byKey2.ter_Id);
      this.DocumentosVarios1.Init("Rrr.rrd_ReporteRegeneracionDocumento", "rre_Id", byKey1.rre_Id.ToString(), this.MyDataContext.Connection.ConnectionString);
    }

    protected void buttonGuardar_Click(object sender, EventArgs e)
    {
      try
      {
        this.Validar();
        this.ControlError1.Visible = false;
        rre_ReporteRegeneracion myParams = (rre_ReporteRegeneracion) this.LocalInfo.MyParams;
        myParams.gti_Id = int.Parse(this.comboTipoGas.SelectedValue);
        myParams.rre_Fecha = DateTime.Parse(this.textFecha.Text);
        myParams.rre_CantidadEntregada = Decimal.Parse(this.textUsoCantidadEntregada.Text);
        myParams.rre_CantidadRechazada = Decimal.Parse(this.textUsoCantidadRechazada.Text);
        myParams.rre_CantidadRegenerada = Decimal.Parse(this.textUsoCantidadRegenerada.Text);
        myParams.cre_Id = int.Parse(this.comboCentroRegeneracion.SelectedValue);
        myParams.ter_Id = (int) this.LocalInfo.GetData("idTercero");
        myParams.rre_Observacion = this.textObservaciones.Text.ToUpper();
        if (this.comboDestino.SelectedValue != "")
          myParams.gde_Id = new int?(int.Parse(this.comboDestino.SelectedValue));
        if (this.comboDestino.SelectedValue == "1")
        {
          myParams.rre_Cantidad = new int?(int.Parse(this.textCantidad.Text));
          myParams.rre_Porciento = new Decimal?(Decimal.Parse(this.textPorciento.Text));
        }
        if ((int) this.LocalInfo.GetData("idReporte") == 0)
          this.MyDataContext.rre_ReporteRegeneracions.InsertOnSubmit(myParams);
        this.DocumentosVarios1.Init("Rrr.rrd_ReporteRegeneracionDocumento", "rre_Id", myParams.rre_Id.ToString(), this.MyDataContext.Connection.ConnectionString);
        this.MyDataContext.SubmitChanges();
        if ((int) this.LocalInfo.GetData("idReporte") == 0)
          CAuditoria.log(EPermiso.AdicionarReportesCentroDeRegeneracion, myParams.rre_Id.ToString(), myParams.ter_Tercero.ter_NombreCompleto, myParams.cre_CentroRegeneracion.cre_Descripcion, "", "", this.Usuario.id);
        else
          CAuditoria.log(EPermiso.ModificarReportesCentroDeRegeneracion, myParams.rre_Id.ToString(), myParams.ter_Tercero.ter_NombreCompleto, myParams.cre_CentroRegeneracion.cre_Descripcion, "", "", this.Usuario.id);
        this.Server.Transfer("~/Recuperacion/ReporteRegeneracionBuscar.aspx");
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
      bool flag = true & CValidator.isNumeric(this.textUsoCantidadEntregada.Text, ref number, "La cantidad entregada en libras debe ser un número. <br />", ref errStr) & CValidator.isNumeric(this.textUsoCantidadRechazada.Text, ref number, "La cantidad rechazada en libras debe ser un número. <br />", ref errStr) & CValidator.isNumeric(this.textUsoCantidadRegenerada.Text, ref number, "La cantidad regenerada en libras debe ser un número. <br />", ref errStr);
      if (this.comboTipoGas.SelectedValue == "")
      {
        flag = false;
        errStr += "El tipo de gas es un campo obligatorio";
      }
      if (this.comboDestino.SelectedValue == "1")
        flag &= CValidator.isNumeric(this.textCantidad.Text, ref number, "La cantidad entregada al beneficiario en libras debe ser un número. <br />", ref errStr);
      if (this.comboCentroRegeneracion.SelectedValue == "")
      {
        flag = false;
        errStr += "El centro de regeneracion es un campo obligatorio";
      }
      if (this.textBeneficiario.Text == "")
      {
        flag = false;
        errStr += "El usuario es un campo obligatorio";
      }
      if (!flag)
        throw new Exception(errStr);
    }

    protected void buttonCancelar_Click(object sender, EventArgs e) => this.Server.Transfer("~/Recuperacion/ReporteRegeneracionBuscar.aspx");

    protected void comboDestino_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.comboDestino.SelectedValue == "1")
      {
        this.labelCantidad.Visible = true;
        this.textCantidad.Visible = true;
        this.labelPorciento.Visible = true;
        this.textPorciento.Visible = true;
      }
      else
      {
        this.labelCantidad.Visible = false;
        this.textCantidad.Visible = false;
        this.labelPorciento.Visible = false;
        this.textPorciento.Visible = false;
      }
    }

    protected void buttonBuscarTercero_Click(object sender, EventArgs e)
    {
      this.dsBuscarTercero.SelectParameters["beneficiario"].DefaultValue = this.textNombreBeneficiarioBuscar.Text == "" ? "%" : this.textNombreBeneficiarioBuscar.Text;
      this.dsBuscarTercero.SelectParameters["documento"].DefaultValue = this.textNumeroDocumentoBuscar.Text == "" ? "%" : this.textNumeroDocumentoBuscar.Text;
      this.dsBuscarTercero.SelectParameters["tipoDocumento"].DefaultValue = this.comboTipoDocumentoBuscar.SelectedValue == "" ? "0" : this.comboTipoDocumentoBuscar.SelectedValue;
    }

    protected void GridViewTerceroBuscar_RowCommand(object sender, GridViewCommandEventArgs e)
    {
      if (!e.CommandName.Equals("Seleccionar"))
        return;
      this.PanelBuscarTercero.Visible = false;
      int keyValue = int.Parse(this.GridViewTerceroBuscar.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString());
      this.textBeneficiario.Text = CLinq.FindByKey<ter_Tercero>((DataContext) this.MyDataContext, (object) keyValue).ter_NombreCompleto;
      this.LocalInfo.SetData("idTercero", (object) keyValue);
    }

    protected void textUsoCantidadEntregada_TextChanged(object sender, EventArgs e)
    {
      Decimal num = Decimal.Parse(this.textUsoCantidadEntregada.Text);
      num = Decimal.Parse("0,45359237");
      this.textUsoCantidadEntregadaKg.Text = (Decimal.Parse(this.textUsoCantidadEntregada.Text) / Decimal.Parse("0,45359237")).ToString();
    }

    protected void textUsoCantidadRegenerada_TextChanged(object sender, EventArgs e)
    {
      this.textUsoCantidadRegeneradaKg.Text = (Decimal.Parse(this.textUsoCantidadRegenerada.Text) / Decimal.Parse("0,45359237")).ToString();
      this.textUsoCantidadRechazada.Text = (Decimal.Parse(this.textUsoCantidadEntregada.Text) - Decimal.Parse(this.textUsoCantidadRegenerada.Text)).ToString();
      this.textUsoCantidadRechazadaKg.Text = (Decimal.Parse(this.textUsoCantidadRechazada.Text) / Decimal.Parse("0,45359237")).ToString();
    }

    protected void textCantidad_TextChanged(object sender, EventArgs e) => this.textPorciento.Text = ((Decimal) int.Parse(this.textCantidad.Text) / (Decimal) int.Parse(this.textUsoCantidadRegenerada.Text) * 100M).ToString();
  }
}
