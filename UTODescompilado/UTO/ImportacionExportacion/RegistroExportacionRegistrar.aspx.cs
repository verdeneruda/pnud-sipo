// Decompiled with JetBrains decompiler
// Type: UTO.ImportacionExportacion.RegistroExportacionRegistrar
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

namespace UTO.ImportacionExportacion
{
  public class RegistroExportacionRegistrar : BaseModulo
  {
    private EntitySet<res_RegistroExportacionSustancia> listaRegistroSustancia = new EntitySet<res_RegistroExportacionSustancia>();
    private List<RegistroExportacionRegistrar.srtRegistroSustancia> listaSustanciaGrilla = new List<RegistroExportacionRegistrar.srtRegistroSustancia>();
    protected ToolkitScriptManager ToolkitScriptManager1;
    protected Label labelRegistroExportar;
    protected ControlError ControlError1;
    protected Panel PanelDatosExportador;
    protected Label label1;
    protected Panel PanelBusqueda;
    protected Label labelImportador;
    protected DropDownList comboExportador;
    protected Panel PanelLicencias;
    protected GridView gridLicencias;
    protected Panel PanelDatoGeneral;
    protected Label labelImportador0;
    protected DropDownList comboExportadorRegistro;
    protected Label labelNumeroRegistro;
    protected TextBox textNumeroRegistro;
    protected Label label11;
    protected DropDownList comboPaisCompra;
    protected Label label12;
    protected TextBox textPuertoEmbargue;
    protected Label label13;
    protected DropDownList comboAduana;
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
    protected Label label6;
    protected Label Label7;
    protected DropDownList comboUnidad;
    protected Label labelPresentacion;
    protected Label Label5;
    protected DropDownList comboPresentacion;
    protected Label labelPrecioUnitario;
    protected Label Label2;
    protected TextBox TextPrecioUnitario;
    protected Label labelMarca;
    protected Label Label3;
    protected DropDownList comboMarca;
    protected TextBox textId;
    protected Button buttonAdicionar;
    protected Button buttonExportar;
    protected GridView gridImportacionSustancia;
    protected CollapsiblePanelExtender colapsibleImportacionSustancias;
    protected Panel PanelConcepto;
    protected Label labelConcepto;
    protected DropDownList comboconcepto;
    protected Label labelFechaVigencia;
    protected TextBox textFechaVigencia;
    protected CalendarExtender textFechaVigencia_CalendarExtender;
    protected Label labelVistoBueno;
    protected TextBox textVistoBueno;
    protected Label labelFechaVistoBueno;
    protected TextBox textFechaVistoBueno;
    protected CalendarExtender calendarFecha;
    protected Label labelFechaRequerimiento;
    protected TextBox textFechaRequerimiento;
    protected CalendarExtender textFechaRequerimiento_CalendarExtender;
    protected Button buttonGuardar;
    protected Button buttonCancelar;

    protected new void Page_Load(object sender, EventArgs e)
    {
      this.ControlError1.Hide();
      if (this.IsPostBack)
        return;
      this.buttonGuardar.Enabled = this.Usuario.permiteOperacion(EPermiso.ModificarRegistroDeExportacion) || this.Usuario.permiteOperacion(EPermiso.AdicionarRegistroDeExportacion);
      this.InitData();
    }

    public void InitData()
    {
      this.comboSustancia.DataSource = (object) CLinq.ListAll<sus_Sustancia>((DataContext) this.MyDataContext);
      this.comboSustancia.DataBind();
      this.comboSustancia.Items.Insert(0, "");
      this.comboMarca.DataSource = (object) CLinq.ListAll<mar_Marca>((DataContext) this.MyDataContext);
      this.comboMarca.DataBind();
      this.comboMarca.Items.Insert(0, "");
      this.comboUnidad.DataSource = (object) CLinq.ListAll<uni_Unidad>((DataContext) this.MyDataContext);
      this.comboUnidad.DataBind();
      this.comboUnidad.Items.Insert(0, "");
      this.comboAduana.DataSource = (object) CLinq.ListAll<adu_Aduana>((DataContext) this.MyDataContext);
      this.comboAduana.DataBind();
      this.comboAduana.Items.Insert(0, "");
      this.comboPaisCompra.DataSource = (object) CLinq.ListAll<pas_Pai>((DataContext) this.MyDataContext);
      this.comboPaisCompra.DataBind();
      this.comboPaisCompra.Items.Insert(0, "");
      this.comboPresentacion.DataSource = (object) CLinq.ListAll<psu_PresentacionSustancia>((DataContext) this.MyDataContext);
      this.comboPresentacion.DataBind();
      this.comboPresentacion.Items.Insert(0, "");
      this.comboconcepto.DataSource = (object) CLinq.ListAll<cvb_ConceptoVistoBueno>((DataContext) this.MyDataContext);
      this.comboconcepto.DataBind();
      this.comboconcepto.Items.Insert(0, "");
      this.cargarComboTercero(this.comboExportador, 3);
      this.cargarComboTercero(this.comboExportadorRegistro, 3);
      this.LocalInfo.SetData("idRegistro", (object) ((BaseModulo.strSendParam) this.LocalInfo.MyParams).id);
      if (((BaseModulo.strSendParam) this.LocalInfo.MyParams).id != 0)
      {
        BaseModulo.strSendParam myParams = (BaseModulo.strSendParam) this.LocalInfo.MyParams;
        if (myParams.tipo == "Ver")
        {
          this.colapsibleImportacionSustancias.Collapsed = false;
          CControl.Enable((Control) this.PanelDatosExportador, false);
          this.buttonGuardar.Enabled = false;
        }
        myParams = (BaseModulo.strSendParam) this.LocalInfo.MyParams;
        this.mostrarDatos(myParams.id);
      }
      else
      {
        this.LocalInfo.MyParams = (object) new rex_RegistroExportacion();
        this.LocalInfo.SetData("listaRegistroSustancia", (object) this.listaRegistroSustancia);
        this.LocalInfo.SetData("listaSustanciaGrilla", (object) this.listaSustanciaGrilla);
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
      rex_RegistroExportacion byKey = CLinq.FindByKey<rex_RegistroExportacion>((DataContext) this.MyDataContext, (object) id);
      this.LocalInfo.MyParams = (object) byKey;
      CLinq.ListByProperty<res_RegistroExportacionSustancia>((DataContext) this.MyDataContext, "rex_Id", (object) byKey.rex_Id);
      this.textNumeroRegistro.Text = byKey.rex_NumeroRegistro;
      this.comboPaisCompra.SelectedValue = byKey.pas_Id.ToString();
      this.textPuertoEmbargue.Text = byKey.rex_PuertoEmbargue;
      this.comboAduana.SelectedValue = byKey.adu_Id.ToString();
      this.comboExportadorRegistro.SelectedValue = byKey.ter_Id.ToString();
      this.comboconcepto.SelectedValue = byKey.cvb_Id.ToString();
      int? cvbId = byKey.cvb_Id;
      if ((cvbId.GetValueOrDefault() != 1 ? 0 : (cvbId.HasValue ? 1 : 0)) != 0)
      {
        this.labelVistoBueno.Visible = true;
        this.textVistoBueno.Visible = true;
        this.labelFechaVistoBueno.Visible = true;
        this.textFechaVistoBueno.Visible = true;
        this.labelFechaRequerimiento.Visible = false;
        this.textFechaRequerimiento.Visible = false;
        this.textVistoBueno.Text = byKey.rex_NumeroVistoBueno;
        DateTime? nullable = byKey.rex_FechaVistoBueno;
        if (nullable.HasValue)
        {
          TextBox textFechaVistoBueno = this.textFechaVistoBueno;
          nullable = byKey.rex_FechaVistoBueno;
          string str = nullable.ToString();
          textFechaVistoBueno.Text = str;
        }
        nullable = byKey.rex_FechaVigencia;
        if (nullable.HasValue)
        {
          TextBox textFechaVigencia = this.textFechaVigencia;
          nullable = byKey.rex_FechaVigencia;
          string str = nullable.ToString();
          textFechaVigencia.Text = str;
        }
      }
      else
      {
        cvbId = byKey.cvb_Id;
        if ((cvbId.GetValueOrDefault() != 2 ? 0 : (cvbId.HasValue ? 1 : 0)) != 0)
        {
          this.labelFechaRequerimiento.Visible = true;
          this.textFechaRequerimiento.Visible = true;
          this.labelVistoBueno.Visible = false;
          this.textVistoBueno.Visible = false;
          this.labelFechaVistoBueno.Visible = false;
          this.textFechaVistoBueno.Visible = false;
          this.textFechaRequerimiento.Text = byKey.rex_FechaRequerimiento.ToString();
          this.textFechaVistoBueno.Text = byKey.rex_FechaVistoBueno.ToString();
          this.textVistoBueno.Text = byKey.rex_NumeroVistoBueno;
        }
        else
        {
          this.labelVistoBueno.Visible = false;
          this.textVistoBueno.Visible = false;
          this.labelFechaVistoBueno.Visible = false;
          this.textFechaVistoBueno.Visible = false;
          this.labelFechaRequerimiento.Visible = false;
          this.textFechaRequerimiento.Visible = false;
        }
      }
      this.PanelDatoGeneral.Visible = true;
      this.LocalInfo.SetData("listaRegistroSustancia", (object) byKey.res_RegistroExportacionSustancias);
      this.PanelSustancias.Visible = true;
      this.PanelConcepto.Visible = true;
      this.alimentarGrillaSustancia(byKey.res_RegistroExportacionSustancias);
    }

    private void alimentarGrillaSustancia(
      EntitySet<res_RegistroExportacionSustancia> listaRegistroSustancia)
    {
      List<RegistroExportacionRegistrar.srtRegistroSustancia> registroSustanciaList = new List<RegistroExportacionRegistrar.srtRegistroSustancia>();
      for (int index = 0; index < listaRegistroSustancia.Count; ++index)
      {
        RegistroExportacionRegistrar.srtRegistroSustancia registroSustancia = new RegistroExportacionRegistrar.srtRegistroSustancia();
        registroSustancia.arancel = listaRegistroSustancia[index].res_Arancel;
        registroSustancia.cantidad = (int) listaRegistroSustancia[index].res_CantidadExportada.Value;
        registroSustancia.marca = CLinq.FindByKey<mar_Marca>((DataContext) this.MyDataContext, (object) listaRegistroSustancia[index].mar_Id).mar_Descripcion;
        registroSustancia.precio = listaRegistroSustancia[index].res_PrecioUnitario.Value;
        psu_PresentacionSustancia byKey1 = CLinq.FindByKey<psu_PresentacionSustancia>((DataContext) this.MyDataContext, (object) listaRegistroSustancia[index].psu_Id);
        registroSustancia.presentacion = byKey1.psu_Descripcion;
        sus_Sustancia byKey2 = CLinq.FindByKey<sus_Sustancia>((DataContext) this.MyDataContext, (object) listaRegistroSustancia[index].sus_Id);
        registroSustancia.sustancia = byKey2.sus_Descripcion;
        registroSustancia.id = listaRegistroSustancia[index].res_Id == 0 ? index : listaRegistroSustancia[index].res_Id;
        registroSustancia.idProvisional = index;
        registroSustanciaList.Add(registroSustancia);
      }
      this.gridImportacionSustancia.DataSource = (object) registroSustanciaList;
      this.gridImportacionSustancia.DataBind();
      this.LocalInfo.SetData("listaSustanciaGrilla", (object) registroSustanciaList);
    }

    protected void buttonGuardar_Click(object sender, EventArgs e)
    {
      try
      {
        this.ValidarRegistro();
        rex_RegistroExportacion myParams = (rex_RegistroExportacion) this.LocalInfo.MyParams;
        myParams.adu_Id = new int?(int.Parse(this.comboAduana.SelectedValue));
        myParams.cvb_Id = new int?(int.Parse(this.comboconcepto.SelectedValue));
        myParams.pas_Id = new int?(int.Parse(this.comboPaisCompra.SelectedValue));
        myParams.rex_Creado = new DateTime?(DateTime.Now);
        myParams.ter_Id = int.Parse(this.comboExportadorRegistro.SelectedValue);
        if (this.textFechaRequerimiento.Text != "")
          myParams.rex_FechaRequerimiento = new DateTime?(DateTime.Parse(this.textFechaRequerimiento.Text));
        if (this.textFechaVigencia.Text != "")
          myParams.rex_FechaVigencia = new DateTime?(DateTime.Parse(this.textFechaVigencia.Text));
        if (this.textFechaVistoBueno.Text != "")
          myParams.rex_FechaVistoBueno = new DateTime?(DateTime.Parse(this.textFechaVistoBueno.Text));
        myParams.rex_NumeroRegistro = this.textNumeroRegistro.Text;
        myParams.rex_NumeroVistoBueno = this.textVistoBueno.Text;
        myParams.rex_PuertoEmbargue = this.textPuertoEmbargue.Text;
        myParams.pas_Id = new int?(int.Parse(this.comboPaisCompra.SelectedValue));
        myParams.rex_Usuario = "";
        myParams.rex_Modificado = new DateTime?(DateTime.Now);
        if ((int) this.LocalInfo.GetData("idRegistro") == 0)
        {
          myParams.rex_Creado = new DateTime?(DateTime.Now);
          this.MyDataContext.rex_RegistroExportacions.InsertOnSubmit(myParams);
        }
        this.MyDataContext.SubmitChanges();
        if ((int) this.LocalInfo.GetData("idRegistro") == 0)
          CAuditoria.log(EPermiso.AdicionarRegistroDeExportacion, myParams.rex_Id.ToString(), myParams.rex_NumeroRegistro, myParams.ter_Tercero.ter_NombreCompleto, "", "", this.Usuario.id);
        else
          CAuditoria.log(EPermiso.ModificarRegistroDeExportacion, myParams.rex_Id.ToString(), myParams.rex_NumeroRegistro, myParams.ter_Tercero.ter_NombreCompleto, "", "", this.Usuario.id);
        this.Response.Redirect("~/ImportacionExportacion/RegistroExportacionBuscar.aspx");
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
      if (CLinq.ListByProperty<rex_RegistroExportacion>((DataContext) this.MyDataContext, "rex_NumeroRegistro", (object) this.textNumeroRegistro.Text).Count > 0 && (int) this.LocalInfo.GetData("idRegistro") == 0)
      {
        flag = false;
        message += " Este número de registro de exportación ya existe";
      }
      if (this.comboconcepto.SelectedValue == "1" && this.textFechaVistoBueno.Text == "")
      {
        flag = false;
        message += " La fecha de visto bueno es obligatorio si el concepto es Visto Bueno";
      }
      if (!flag)
        throw new Exception(message);
    }

    protected void buttonCancelar_Click(object sender, EventArgs e) => this.Response.Redirect("~/ImportacionExportacion/RegistroExportacionBuscar.aspx");

    protected void buttonAdicionar_Click(object sender, EventArgs e)
    {
      this.listaRegistroSustancia = (EntitySet<res_RegistroExportacionSustancia>) this.LocalInfo.GetData("listaRegistroSustancia");
      try
      {
        this.Validar();
        this.ControlError1.Visible = false;
        res_RegistroExportacionSustancia entity = (!(this.textId.Text == "") ? CLinq.FindByKey<res_RegistroExportacionSustancia>((DataContext) this.MyDataContext, (object) int.Parse(this.textId.Text)) : new res_RegistroExportacionSustancia()) ?? new res_RegistroExportacionSustancia();
        entity.rex_RegistroExportacion = (rex_RegistroExportacion) this.LocalInfo.MyParams;
        entity.sus_Id = int.Parse(this.comboSustancia.SelectedValue);
        entity.res_Arancel = this.TextArancel.Text;
        entity.res_CantidadExportada = new Decimal?(Decimal.Parse(this.TextCantidadImportada.Text));
        entity.psu_Id = int.Parse(this.comboPresentacion.SelectedValue);
        entity.res_PrecioUnitario = new Decimal?(Decimal.Parse(this.TextPrecioUnitario.Text));
        entity.res_Creado = new DateTime?(DateTime.Now);
        entity.res_Modificado = new DateTime?(DateTime.Now);
        entity.res_Usuario = "";
        entity.mar_Id = int.Parse(this.comboMarca.SelectedValue);
        entity.uni_Id = int.Parse(this.comboUnidad.SelectedValue);
        if (this.textId.Text == "")
          this.MyDataContext.res_RegistroExportacionSustancias.InsertOnSubmit(entity);
        this.listaRegistroSustancia.Add(entity);
        this.LocalInfo.SetData("listaRegistroSustancia", (object) this.listaRegistroSustancia);
        this.alimentarGrillaSustancia(this.listaRegistroSustancia);
        this.comboUnidad.SelectedValue = "";
        this.comboMarca.SelectedValue = "";
        this.comboSustancia.SelectedValue = "";
        this.TextArancel.Text = "";
        this.TextCantidadImportada.Text = "";
        this.comboPresentacion.SelectedValue = "";
        this.TextPrecioUnitario.Text = "";
        this.buttonAdicionar.Text = "Adicionar";
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
      bool flag = true & CValidator.isNumeric(this.TextCantidadImportada.Text, ref number, "La cantidad importadora debe ser un número. <br />", ref errStr) & CValidator.isNumeric(this.TextPrecioUnitario.Text, ref number, "La precio unitario debe ser un número. <br />", ref errStr);
      if (this.comboSustancia.SelectedValue == "")
      {
        flag = false;
        errStr += " La sustancia es un campo obligatorio";
      }
      if (this.comboPresentacion.SelectedValue == "")
      {
        flag = false;
        errStr += " La presentación es un campo obligatorio";
      }
      if (this.comboMarca.SelectedValue == "")
      {
        flag = false;
        errStr += " La marca es un campo obligatorio";
      }
      if (this.comboUnidad.SelectedValue == "")
      {
        flag = false;
        errStr += " La unidad es un campo obligatorio";
      }
      if (!flag)
        throw new Exception(errStr);
    }

    protected void comboSustancia_SelectedIndexChanged(object sender, EventArgs e) => this.TextArancel.Text = CLinq.FindByKey<sus_Sustancia>((DataContext) this.MyDataContext, (object) int.Parse(this.comboSustancia.SelectedValue)).sus_Arancel;

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
      }
      else if (this.comboconcepto.SelectedValue == "2")
      {
        this.labelFechaRequerimiento.Visible = true;
        this.textFechaRequerimiento.Visible = true;
        this.labelVistoBueno.Visible = false;
        this.textVistoBueno.Visible = false;
        this.labelFechaVistoBueno.Visible = false;
        this.textFechaVistoBueno.Visible = false;
      }
      else
      {
        this.labelVistoBueno.Visible = false;
        this.textVistoBueno.Visible = false;
        this.labelFechaVistoBueno.Visible = false;
        this.textFechaVistoBueno.Visible = false;
        this.labelFechaRequerimiento.Visible = false;
        this.textFechaRequerimiento.Visible = false;
      }
    }

    protected void comboExportador_SelectedIndexChanged(object sender, EventArgs e)
    {
      try
      {
        this.PanelLicencias.Visible = true;
        CLinq.ListByProperty<lma_LicenciaMedioAmbiental>((DataContext) this.MyDataContext, "ter_IdEmpresa", (object) int.Parse(this.comboExportador.SelectedValue));
        this.PanelBusqueda.Visible = false;
        this.PanelDatoGeneral.Visible = true;
        this.ControlError1.Visible = false;
        this.PanelSustancias.Visible = true;
        this.PanelConcepto.Visible = true;
        this.comboExportadorRegistro.SelectedValue = this.comboExportador.SelectedValue;
      }
      catch (Exception ex)
      {
        this.ControlError1.Visible = true;
        this.ControlError1.Show(ex);
      }
    }

    private void actualizarGrilla(
      List<lmd_LicenciaMedioAmbientalDetalle> licenciaImportacion)
    {
      List<RegistroExportacionRegistrar.srtLicencia> srtLicenciaList = new List<RegistroExportacionRegistrar.srtLicencia>();
      for (int index = 0; index <= licenciaImportacion.Count - 1; ++index)
        srtLicenciaList.Add(new RegistroExportacionRegistrar.srtLicencia()
        {
          pais = licenciaImportacion[index].pas_Pai.pas_Descripcion,
          proveedor = licenciaImportacion[index].ter_Tercero.ter_NombreCompleto
        });
      this.gridLicencias.DataSource = (object) srtLicenciaList;
      this.gridLicencias.DataBind();
    }

    protected void gridImportacionSustancia_RowCommand(object sender, GridViewCommandEventArgs e)
    {
      int index = int.Parse(this.gridImportacionSustancia.DataKeys[int.Parse((string) e.CommandArgument)].Values[0].ToString());
      int num = int.Parse(this.gridImportacionSustancia.DataKeys[int.Parse((string) e.CommandArgument)].Values[1].ToString());
      this.listaRegistroSustancia = (EntitySet<res_RegistroExportacionSustancia>) this.LocalInfo.GetData("listaRegistroSustancia");
      this.listaSustanciaGrilla = (List<RegistroExportacionRegistrar.srtRegistroSustancia>) this.LocalInfo.GetData("listaSustanciaGrilla");
      if (e.CommandName.Equals("Modificar"))
      {
        this.comboSustancia.SelectedValue = this.listaRegistroSustancia[index].sus_Id.ToString();
        this.TextArancel.Text = this.listaRegistroSustancia[index].res_Arancel;
        this.TextCantidadImportada.Text = this.listaRegistroSustancia[index].res_CantidadExportada.ToString();
        this.comboPresentacion.SelectedValue = this.listaRegistroSustancia[index].psu_Id.ToString();
        this.TextPrecioUnitario.Text = this.listaRegistroSustancia[index].res_PrecioUnitario.ToString();
        this.comboMarca.SelectedValue = this.listaRegistroSustancia[index].mar_Id.ToString();
        this.comboUnidad.SelectedValue = this.listaRegistroSustancia[index].uni_Id.ToString();
        this.textId.Text = this.listaRegistroSustancia[index].res_Id.ToString();
        if (num == 0)
          this.MyDataContext.res_RegistroExportacionSustancias.DeleteOnSubmit(this.listaRegistroSustancia[index]);
        this.listaRegistroSustancia.Remove(this.listaRegistroSustancia[index]);
        this.listaSustanciaGrilla.Remove(this.listaSustanciaGrilla[index]);
        this.LocalInfo.SetData("listaSustanciaGrilla", (object) this.listaSustanciaGrilla);
        this.alimentarGrillaSustancia(this.listaRegistroSustancia);
        this.buttonAdicionar.Text = "Guardar";
      }
      if (!e.CommandName.Equals("Eliminar"))
        return;
      if (this.listaRegistroSustancia[index].res_Id > 0)
        this.MyDataContext.res_RegistroExportacionSustancias.DeleteOnSubmit(this.listaRegistroSustancia[index]);
      this.listaRegistroSustancia.Remove(this.listaRegistroSustancia[index]);
      this.listaSustanciaGrilla.Remove(this.listaSustanciaGrilla[index]);
      this.LocalInfo.SetData("listaSustanciaGrilla", (object) this.listaSustanciaGrilla);
      this.alimentarGrillaSustancia(this.listaRegistroSustancia);
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

    public class srtRegistroSustancia
    {
      private string _sustancia;
      private string _arancel;
      private int _cantidad;
      private string _marca;
      private string _presentacion;
      private Decimal _precio;
      private string _pais;
      private int _id;
      private int _idProvisional;

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

      public int cantidad
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
    }
  }
}
