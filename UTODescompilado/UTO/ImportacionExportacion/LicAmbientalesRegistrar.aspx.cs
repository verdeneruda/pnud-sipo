// Decompiled with JetBrains decompiler
// Type: UTO.ImportacionExportacion.LicAmbientalesRegistrar
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using AjaxControlToolkit;
using NE.CLib.Linq;
using Seguridad.Servicio;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Web.UI.WebControls;

namespace UTO.ImportacionExportacion
{
  public class LicAmbientalesRegistrar : BaseModulo
  {
    private EntitySet<lmd_LicenciaMedioAmbientalDetalle> listaLicencia = new EntitySet<lmd_LicenciaMedioAmbientalDetalle>();
    private List<LicAmbientalesRegistrar.strLicenciaAsignado> listaLicenciaGrilla = new List<LicAmbientalesRegistrar.strLicenciaAsignado>();
    protected ToolkitScriptManager ToolkitScriptManager1;
    protected Label labelRegistarLicenciasAmbientales;
    protected ControlError ControlError1;
    protected Panel PanelLicencia;
    protected Label labelDatosGenerales;
    protected Label labelEmpresa;
    protected DropDownList comboEmpresa;
    protected Button buttonAdicionarTercero;
    protected Panel PanelDatosTercero;
    protected ControlError ControlError2;
    protected Label label1;
    protected Label labelNombreBeneficiario0;
    protected TextBox textNombreBeneficiario;
    protected Label labelDepartamento;
    protected Label Label2;
    protected DropDownList comboDepartamento;
    protected Label labelMunicipio;
    protected Label Label3;
    protected DropDownList comboCiudad;
    protected Label labelTipoDocumento;
    protected DropDownList comboTipoDocumento;
    protected Label labelDocumento;
    protected TextBox textDocumento;
    protected Button buttonGuardarTercero;
    protected Button buttonCancelarTercero;
    protected Label labelResolucion;
    protected TextBox textResolucion;
    protected Label labelfecha;
    protected TextBox textFecha;
    protected CalendarExtender calendarFecha;
    protected Label labelObservaciones;
    protected TextBox textObservaciones;
    protected Label label4;
    protected Panel PanelSustancias;
    protected LinkButton linkImportacionSustancias;
    protected ImageButton imageImportacionSustancia;
    protected Panel panelImportacionSustancias;
    protected Label labelProveedor;
    protected DropDownList comboProveedor;
    protected Label label11;
    protected DropDownList comboPais;
    protected Label labelSustancia;
    protected DropDownList comboSustancia;
    protected Button buttonAdicionar;
    protected CollapsiblePanelExtender colapsibleImportacionSustancias;
    protected GridView gridImportacionSustancia;
    protected Button buttonGuardar;
    protected Button buttonCancelar;

    protected new void Page_Load(object sender, EventArgs e)
    {
      this.ControlError1.Hide();
      this.ControlError2.Hide();
      if (this.IsPostBack)
        return;
      this.buttonGuardar.Enabled = this.Usuario.permiteOperacion(EPermiso.ModificarLicenciasMedioAmbientales) || this.Usuario.permiteOperacion(EPermiso.AdicionarLicenciasMedioAmbientales);
      this.InitData();
    }

    public void InitData()
    {
      this.comboSustancia.DataSource = (object) CLinq.ListAll<sus_Sustancia>((DataContext) this.MyDataContext);
      this.comboSustancia.DataBind();
      this.comboSustancia.Items.Insert(0, "");
      this.cargarComboTercero(this.comboEmpresa, 2, 0);
      this.cargarComboTercero(this.comboProveedor, 8, 0);
      this.comboPais.DataSource = (object) CLinq.ListAll<pas_Pai>((DataContext) this.MyDataContext);
      this.comboPais.DataBind();
      this.comboPais.Items.Insert(0, "");
      this.comboTipoDocumento.DataSource = (object) CLinq.ListAll<dti_DocumentoTipo>((DataContext) this.MyDataContext);
      this.comboTipoDocumento.DataBind();
      this.comboTipoDocumento.Items.Insert(0, "");
      this.comboDepartamento.DataSource = (object) CLinq.ListAll<dep_Departamento>((DataContext) this.MyDataContext);
      this.comboDepartamento.DataBind();
      this.comboDepartamento.Items.Insert(0, "");
      this.LocalInfo.SetData("idLicencia", (object) ((BaseModulo.strSendParam) this.LocalInfo.MyParams).id);
      if (((BaseModulo.strSendParam) this.LocalInfo.MyParams).id != 0)
      {
        BaseModulo.strSendParam myParams = (BaseModulo.strSendParam) this.LocalInfo.MyParams;
        if (myParams.tipo == "Ver")
        {
          this.PanelLicencia.Enabled = false;
          this.buttonGuardar.Enabled = false;
        }
        myParams = (BaseModulo.strSendParam) this.LocalInfo.MyParams;
        this.mostrarDatos(myParams.id);
      }
      else
      {
        this.LocalInfo.MyParams = (object) new lma_LicenciaMedioAmbiental();
        this.LocalInfo.SetData("listaLicencia", (object) this.listaLicencia);
        this.LocalInfo.SetData("listaLicenciaGrilla", (object) this.listaLicenciaGrilla);
        this.LocalInfo.SetData("idProvisional", (object) null);
      }
    }

    private void cargarComboTercero(DropDownList combo, int tipo, int tipo2)
    {
      List<ter_Tercero> terTerceroList = new List<ter_Tercero>();
      List<ttt_TerceroTipoTercero> terceroTipoTerceroList1 = CLinq.ListByProperty<ttt_TerceroTipoTercero>((DataContext) this.MyDataContext, "tti_Id", (object) tipo);
      for (int index = 0; index <= terceroTipoTerceroList1.Count - 1; ++index)
      {
        ter_Tercero byKey = CLinq.FindByKey<ter_Tercero>((DataContext) this.MyDataContext, (object) terceroTipoTerceroList1[index].ter_Id);
        terTerceroList.Add(byKey);
      }
      if (tipo2 > 0)
      {
        List<ttt_TerceroTipoTercero> terceroTipoTerceroList2 = CLinq.ListByProperty<ttt_TerceroTipoTercero>((DataContext) this.MyDataContext, "tti_Id", (object) tipo2);
        for (int index = 0; index <= terceroTipoTerceroList2.Count - 1; ++index)
        {
          ter_Tercero byKey = CLinq.FindByKey<ter_Tercero>((DataContext) this.MyDataContext, (object) terceroTipoTerceroList2[index].ter_Id);
          terTerceroList.Add(byKey);
        }
      }
      combo.DataSource = (object) terTerceroList;
      combo.DataBind();
      combo.Items.Insert(0, "");
    }

    private void mostrarDatos(int id)
    {
      lma_LicenciaMedioAmbiental byKey = CLinq.FindByKey<lma_LicenciaMedioAmbiental>((DataContext) this.MyDataContext, (object) id);
      this.LocalInfo.MyParams = (object) byKey;
      CLinq.ListByProperty<lmd_LicenciaMedioAmbientalDetalle>((DataContext) this.MyDataContext, "lma_Id", (object) byKey.lma_Id);
      this.comboEmpresa.SelectedValue = byKey.ter_IdEmpresa.ToString();
      this.textResolucion.Text = byKey.lma_Resolucion;
      this.textFecha.Text = byKey.lma_FechaLicencia.ToShortDateString();
      this.textObservaciones.Text = byKey.lma_Observacion.ToString();
      this.LocalInfo.SetData("listaLicencia", (object) byKey.lmd_LicenciaMedioAmbientalDetalles);
      this.ActualizarDatosGrilla(byKey.lmd_LicenciaMedioAmbientalDetalles);
    }

    private void ActualizarDatosGrilla(
      EntitySet<lmd_LicenciaMedioAmbientalDetalle> listaLicencia)
    {
      List<LicAmbientalesRegistrar.strLicenciaAsignado> licenciaAsignadoList = new List<LicAmbientalesRegistrar.strLicenciaAsignado>();
      for (int index = 0; index < listaLicencia.Count; ++index)
      {
        LicAmbientalesRegistrar.strLicenciaAsignado licenciaAsignado = new LicAmbientalesRegistrar.strLicenciaAsignado();
        pas_Pai byKey1 = CLinq.FindByKey<pas_Pai>((DataContext) this.MyDataContext, (object) listaLicencia[index].pas_Id);
        licenciaAsignado.pais = byKey1.pas_Descripcion;
        ter_Tercero byKey2 = CLinq.FindByKey<ter_Tercero>((DataContext) this.MyDataContext, (object) listaLicencia[index].ter_IdProveedor);
        licenciaAsignado.proveedor = byKey2.ter_NombreCompleto;
        sus_Sustancia byKey3 = CLinq.FindByKey<sus_Sustancia>((DataContext) this.MyDataContext, (object) listaLicencia[index].sus_Id);
        licenciaAsignado.sustancia = byKey3.sus_Descripcion;
        int lmdId = listaLicencia[index].lmd_Id;
        licenciaAsignado.id = listaLicencia[index].lmd_Id;
        licenciaAsignado.idProvisional = index;
        licenciaAsignadoList.Add(licenciaAsignado);
      }
      this.LocalInfo.SetData("listaLicenciaGrilla", (object) licenciaAsignadoList);
      if (licenciaAsignadoList.Count > 0)
      {
        this.gridImportacionSustancia.DataSource = (object) licenciaAsignadoList;
        this.gridImportacionSustancia.DataBind();
      }
      else
      {
        this.gridImportacionSustancia.DataSource = (object) null;
        this.gridImportacionSustancia.DataBind();
      }
    }

    protected void buttonAdicionar_Click2(object sender, EventArgs e)
    {
      this.listaLicencia = (EntitySet<lmd_LicenciaMedioAmbientalDetalle>) this.LocalInfo.GetData("listaLicencia");
      try
      {
        this.ValidarDetalle();
        this.ControlError1.Visible = false;
        lmd_LicenciaMedioAmbientalDetalle entity = new lmd_LicenciaMedioAmbientalDetalle();
        entity.lma_LicenciaMedioAmbiental = (lma_LicenciaMedioAmbiental) this.LocalInfo.MyParams;
        entity.pas_Id = int.Parse(this.comboPais.SelectedValue);
        entity.ter_IdProveedor = int.Parse(this.comboProveedor.SelectedValue);
        entity.sus_Id = new int?(int.Parse(this.comboSustancia.SelectedValue));
        this.MyDataContext.lmd_LicenciaMedioAmbientalDetalles.InsertOnSubmit(entity);
        this.listaLicencia.Add(entity);
        this.LocalInfo.SetData("listaLicencia", (object) this.listaLicencia);
        this.ActualizarDatosGrilla(this.listaLicencia);
        this.comboPais.SelectedValue = "";
        this.comboProveedor.SelectedValue = "";
        this.comboSustancia.SelectedValue = "";
      }
      catch (Exception ex)
      {
        this.ControlError1.Visible = true;
        this.ControlError1.Show(ex);
      }
    }

    private void ValidarDetalle()
    {
      string message = "";
      bool flag = true;
      if (this.comboProveedor.SelectedValue == "")
      {
        flag = false;
        message += "El proveedor es un campo obligatorio. <br />";
      }
      if (this.comboPais.SelectedValue == "")
      {
        flag = false;
        message += "El país es un campo obligatorio. <br />";
      }
      if (this.comboSustancia.SelectedValue == "")
      {
        flag = false;
        message += "La sustancia es un campo obligatorio. <br />";
      }
      if (!flag)
        throw new Exception(message);
    }

    protected void buttonGuardar_Click(object sender, EventArgs e)
    {
      try
      {
        this.Validar();
        this.ControlError1.Visible = false;
        lma_LicenciaMedioAmbiental myParams = (lma_LicenciaMedioAmbiental) this.LocalInfo.MyParams;
        myParams.ter_IdEmpresa = int.Parse(this.comboEmpresa.SelectedValue);
        myParams.lma_Resolucion = this.textResolucion.Text.ToUpper();
        myParams.lma_Observacion = this.textObservaciones.Text.ToUpper();
        myParams.lma_FechaLicencia = DateTime.Parse(this.textFecha.Text);
        myParams.lma_Usuario = "";
        myParams.lma_Modificado = DateTime.Now;
        if ((int) this.LocalInfo.GetData("idLicencia") == 0)
        {
          myParams.lma_Creado = DateTime.Now;
          this.MyDataContext.lma_LicenciaMedioAmbientals.InsertOnSubmit(myParams);
        }
        this.MyDataContext.SubmitChanges();
        if ((int) this.LocalInfo.GetData("idLicencia") == 0)
          CAuditoria.log(EPermiso.AdicionarLicenciasMedioAmbientales, myParams.lma_Id.ToString(), myParams.ter_Tercero.ter_NombreCompleto, myParams.lma_Resolucion, "", "", this.Usuario.id);
        else
          CAuditoria.log(EPermiso.ModificarLicenciasMedioAmbientales, myParams.lma_Id.ToString(), myParams.ter_Tercero.ter_NombreCompleto, myParams.lma_Resolucion, "", "", this.Usuario.id);
        this.Server.Transfer("~/ImportacionExportacion/LicAmbientalesBuscar.aspx");
      }
      catch (Exception ex)
      {
        this.ControlError1.Visible = true;
        this.ControlError1.Show(ex);
      }
    }

    private void Validar()
    {
      string message = "";
      bool flag = true;
      if (this.textFecha.Text == "")
      {
        flag = false;
        message += "La fecha de radicación es un campo obligatorio. <br />";
      }
      else
      {
        try
        {
          if (DateTime.Parse(this.textFecha.Text) > DateTime.Today)
          {
            flag = false;
            message += "La fecha de radicación no puede ser futura. <br />";
          }
        }
        catch
        {
          flag = false;
          message += "La fecha de radicación debe ser válida. <br />";
        }
      }
      if (this.textResolucion.Text == "")
      {
        flag = false;
        message += "El número de resolución es un campo obligatorio. <br />";
      }
      if (this.comboEmpresa.SelectedValue == "")
      {
        flag = false;
        message += "La empresa es un campo obligatorio. <br />";
      }
      if (!flag)
        throw new Exception(message);
    }

    protected void buttonCancelar_Click1(object sender, EventArgs e) => this.Response.Redirect("~/ImportacionExportacion/LicAmbientalesBuscar.aspx");

    protected void gridImportacionSustancia_RowCommand(object sender, GridViewCommandEventArgs e)
    {
      int index = int.Parse(this.gridImportacionSustancia.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString());
      this.listaLicencia = (EntitySet<lmd_LicenciaMedioAmbientalDetalle>) this.LocalInfo.GetData("listaLicencia");
      this.listaLicenciaGrilla = (List<LicAmbientalesRegistrar.strLicenciaAsignado>) this.LocalInfo.GetData("listaLicenciaGrilla");
      if (!e.CommandName.Equals("Eliminar"))
        return;
      this.MyDataContext.lmd_LicenciaMedioAmbientalDetalles.DeleteOnSubmit(this.listaLicencia[index]);
      this.listaLicencia.Remove(this.listaLicencia[index]);
      this.listaLicenciaGrilla.Remove(this.listaLicenciaGrilla[index]);
      this.LocalInfo.SetData("listaLicenciaGrilla", (object) this.listaLicenciaGrilla);
      this.ActualizarDatosGrilla(this.listaLicencia);
    }

    protected void buttonAdicionarTercero_Click(object sender, EventArgs e) => this.PanelDatosTercero.Visible = true;

    protected void buttonGuardarTercero_Click(object sender, EventArgs e)
    {
      try
      {
        this.ValidarTercero();
        ter_Tercero entity = new ter_Tercero();
        entity.ter_NombreCompleto = this.textNombreBeneficiario.Text.ToUpper();
        if (this.comboTipoDocumento.SelectedValue != "")
        {
          if (this.comboTipoDocumento.SelectedValue != "0")
          {
            entity.dti_Id = int.Parse(this.comboTipoDocumento.SelectedValue);
            entity.ter_NumeroDocumento = this.textDocumento.Text.ToUpper();
          }
          else
          {
            entity.dti_Id = 0;
            entity.ter_NumeroDocumento = "";
          }
        }
        else
        {
          entity.dti_Id = 0;
          entity.ter_NumeroDocumento = "";
        }
        entity.dep_Id = this.comboDepartamento.SelectedValue;
        entity.mun_Id = this.comboCiudad.SelectedValue;
        entity.ter_Tefono = "";
        entity.ter_Direccion = "";
        entity.ter_Correo = "";
        entity.ter_Celular = "";
        entity.ter_Fax = "";
        entity.bti_Id = 2;
        this.MyDataContext.ttt_TerceroTipoTerceros.InsertOnSubmit(new ttt_TerceroTipoTercero()
        {
          ter_Tercero = entity,
          tti_Id = 2
        });
        this.MyDataContext.ter_Terceros.InsertOnSubmit(entity);
        this.MyDataContext.SubmitChanges();
        this.cargarComboTercero(this.comboEmpresa, 2, 3);
        this.comboEmpresa.SelectedValue = entity.ter_Id.ToString();
        this.PanelDatosTercero.Visible = false;
      }
      catch (Exception ex)
      {
        this.ControlError1.Visible = true;
        this.ControlError1.Show(ex);
      }
    }

    protected void buttonCancelarTercero_Click(object sender, EventArgs e) => this.PanelDatosTercero.Visible = false;

    private void ValidarTercero()
    {
      string message = "";
      bool flag = true;
      List<ter_Tercero> terTerceroList = CLinq.ListByProperties<ter_Tercero>((DataContext) this.MyDataContext, (object) "ter_NombreCompleto", (object) this.textNombreBeneficiario.Text.ToUpper(), (object) "mun_Id", (object) this.comboCiudad.SelectedValue);
      if (terTerceroList.Count > 0)
      {
        for (int index = 0; index < terTerceroList.Count; ++index)
        {
          if (terTerceroList[index].ter_NumeroDocumento == this.textDocumento.Text)
          {
            flag = false;
            message += "El tercero ya se encuentra registrado. <br />";
          }
        }
      }
      if (this.textNombreBeneficiario.Text == "")
      {
        flag = false;
        message += "El nombre del tercero o la razón social es un campo obligatorio. <br />";
      }
      if (this.comboDepartamento.SelectedValue == "")
      {
        flag = false;
        message += "El departamento del tercero es un campo obligatorio. <br />";
      }
      if (this.comboCiudad.SelectedValue == "")
      {
        flag = false;
        message += "La ciudad del tercero es un campo obligatorio. <br />";
      }
      if (!flag)
        throw new Exception(message);
    }

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

    protected void comboTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.comboTipoDocumento.SelectedValue == "0")
      {
        this.textDocumento.Text = "";
        this.textDocumento.ReadOnly = true;
      }
      else
        this.textDocumento.ReadOnly = false;
    }

    public class strLicenciaAsignado
    {
      private string _proveedor;
      private string _pais;
      private string _sustancia;
      private int _id;
      private int _idProvisional;

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

      public string sustancia
      {
        get => this._sustancia;
        set => this._sustancia = value;
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
