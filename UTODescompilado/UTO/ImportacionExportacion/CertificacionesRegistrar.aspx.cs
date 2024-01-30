// Decompiled with JetBrains decompiler
// Type: UTO.ImportacionExportacion.CertificacionesRegistrar
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
  public class CertificacionesRegistrar : BaseModulo
  {
    protected ToolkitScriptManager ToolkitScriptManager1;
    protected Label labelRegistarCertificaciones;
    protected ControlError ControlError1;
    protected Panel PanelCertificaciones;
    protected Label labelDatosGenerales;
    protected Label labelNumeroRadicado;
    protected TextBox textNumeroRadicado;
    protected Label labelfechaRadicado;
    protected TextBox textFechaRadicado;
    protected CalendarExtender calendarfechaInicial;
    protected Label labelRadicado;
    protected DropDownList comboRadicado;
    protected Label label8;
    protected TextBox textAutorizaNumero;
    protected Button buttonBuscarRadicado;
    protected Label labelImportador;
    protected DropDownList comboImportador;
    protected Button buttonAdicionarTercero;
    protected Panel PanelDatosTercero;
    protected ControlError ControlError2;
    protected Label label12;
    protected Label labelNombreBeneficiario0;
    protected TextBox textNombreBeneficiario;
    protected Label labelDepartamento;
    protected Label Label4;
    protected DropDownList comboDepartamento;
    protected Label labelMunicipio;
    protected Label Label7;
    protected DropDownList comboCiudad;
    protected Label labelTipoDocumento;
    protected DropDownList comboTipoDocumento;
    protected Label labelDocumento;
    protected TextBox textDocumento;
    protected Button buttonGuardarTercero;
    protected Button buttonCancelarTercero;
    protected Label Label1;
    protected DropDownList comboProcedencia;
    protected Label label3;
    protected DropDownList comboMarca;
    protected Label label2;
    protected DropDownList comboEmpresa;
    protected Button buttonAgregarEmpresa;
    protected Panel panelEmpresa;
    protected ControlError ControlError3;
    protected Label label9;
    protected Label label13;
    protected Label Label14;
    protected TextBox textNombreEmpresa;
    protected Button buttonGuardarEmpresa;
    protected Button buttonCancelarEmpresa;
    protected RadioButton RadioFuncionario;
    protected RadioButton RadioDistribuidor;
    protected Label label5;
    protected TextBox TextDescripcion;
    protected Label label6;
    protected TextBox textFechaCertificacion;
    protected CalendarExtender calendarfechaInicial0;
    protected Panel PanelRadicadoHijo;
    protected Label label10;
    protected TextBox textNumeroRadicadoHijo;
    protected Label label11;
    protected TextBox textFechaRadicacionHijo;
    protected CalendarExtender calendarfechaInicial1;
    protected Button buttonGuardar;
    protected Button buttoncancelar;

    protected new void Page_Load(object sender, EventArgs e)
    {
      this.ControlError1.Hide();
      this.ControlError2.Hide();
      if (this.IsPostBack)
        return;
      this.buttonGuardar.Enabled = this.Usuario.permiteOperacion(EPermiso.ModificarCertificaciones) || this.Usuario.permiteOperacion(EPermiso.AdicionarCertificaciones);
      this.InitData();
    }

    private void InitData()
    {
      this.cargarComboTercero(this.comboRadicado, 2, 0);
      this.cargarComboTercero(this.comboImportador, 2, 0);
      this.cargarComboTercero(this.comboEmpresa, 9, 0);
      this.comboMarca.DataSource = (object) CLinq.ListAll<meq_MarcaEquipo>((DataContext) this.MyDataContext);
      this.comboMarca.DataBind();
      this.comboMarca.Items.Insert(0, "");
      this.comboProcedencia.DataSource = (object) CLinq.ListAll<pas_Pai>((DataContext) this.MyDataContext);
      this.comboProcedencia.DataBind();
      this.comboProcedencia.Items.Insert(0, "");
      this.comboTipoDocumento.DataSource = (object) CLinq.ListAll<dti_DocumentoTipo>((DataContext) this.MyDataContext);
      this.comboTipoDocumento.DataBind();
      this.comboTipoDocumento.Items.Insert(0, "");
      this.comboDepartamento.DataSource = (object) CLinq.ListAll<dep_Departamento>((DataContext) this.MyDataContext);
      this.comboDepartamento.DataBind();
      this.comboDepartamento.Items.Insert(0, "");
      this.LocalInfo.SetData("idProyecto", (object) ((BaseModulo.strSendParam) this.LocalInfo.MyParams).id);
      if (((BaseModulo.strSendParam) this.LocalInfo.MyParams).id != 0)
      {
        BaseModulo.strSendParam myParams = (BaseModulo.strSendParam) this.LocalInfo.MyParams;
        if (myParams.tipo == "Ver")
        {
          this.PanelCertificaciones.Enabled = false;
          this.buttonGuardar.Enabled = false;
        }
        myParams = (BaseModulo.strSendParam) this.LocalInfo.MyParams;
        this.mostrarDatos(myParams.id);
      }
      else
      {
        this.LocalInfo.MyParams = (object) new cim_CertificacionImportador();
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
      cim_CertificacionImportador byKey = CLinq.FindByKey<cim_CertificacionImportador>((DataContext) this.MyDataContext, (object) id);
      this.LocalInfo.MyParams = (object) byKey;
      this.textNumeroRadicado.Text = byKey.cim_NumeroRadicado;
      this.textFechaRadicado.Text = byKey.cim_FechaRadicado.ToShortDateString();
      this.comboRadicado.SelectedValue = byKey.ter_IdRadicadoPor.ToString();
      this.comboImportador.SelectedValue = byKey.ter_IdImportador.ToString();
      this.comboProcedencia.SelectedValue = byKey.pas_IdProcedencia.ToString();
      this.comboEmpresa.SelectedValue = byKey.ter_IdEmpresa.ToString();
      this.comboMarca.SelectedValue = byKey.meq_Id.ToString();
      if (byKey.cim_Fabricante.Value)
        this.RadioFuncionario.Checked = true;
      if (byKey.cim_Distribuidor.Value)
        this.RadioDistribuidor.Checked = true;
      this.textFechaCertificacion.Text = byKey.cim_FechaCertificado.ToShortDateString();
      if (byKey.cim_NumeroRadicadoUtilizado != null)
      {
        this.PanelRadicadoHijo.Visible = true;
        this.textNumeroRadicadoHijo.Text = byKey.cim_NumeroRadicadoUtilizado;
        this.textFechaRadicacionHijo.Text = byKey.cim_FechaRadicadoUtilizado.ToString();
      }
      this.TextDescripcion.Text = byKey.cim_Descripcion;
    }

    protected void buttoncancelar_Click(object sender, EventArgs e) => this.Server.Transfer("~/ImportacionExportacion/CertificacionesBuscar.aspx");

    protected void buttonBuscarRadicado_Click(object sender, EventArgs e)
    {
      try
      {
        bool flag = true;
        string message = "";
        List<cim_CertificacionImportador> certificacionImportadorList = CLinq.ListByProperty<cim_CertificacionImportador>((DataContext) this.MyDataContext, "cim_NumeroRadicado", (object) this.textAutorizaNumero.Text);
        if (certificacionImportadorList.Count > 0)
        {
          this.PanelRadicadoHijo.Visible = true;
          TextBox fechaRadicacionHijo = this.textFechaRadicacionHijo;
          DateTime dateTime = certificacionImportadorList[0].cim_FechaRadicado;
          string str = dateTime.ToString();
          fechaRadicacionHijo.Text = str;
          this.textNumeroRadicadoHijo.Text = certificacionImportadorList[0].cim_NumeroRadicado;
          this.comboImportador.SelectedValue = certificacionImportadorList[0].ter_IdImportador.ToString();
          this.comboProcedencia.SelectedValue = certificacionImportadorList[0].pas_IdProcedencia.ToString();
          this.comboEmpresa.SelectedValue = certificacionImportadorList[0].ter_IdEmpresa.ToString();
          this.comboMarca.SelectedValue = certificacionImportadorList[0].meq_Id.ToString();
          if (certificacionImportadorList[0].cim_Fabricante.Value)
            this.RadioFuncionario.Checked = true;
          if (certificacionImportadorList[0].cim_Distribuidor.Value)
            this.RadioDistribuidor.Checked = true;
          TextBox fechaCertificacion = this.textFechaCertificacion;
          dateTime = certificacionImportadorList[0].cim_FechaCertificado;
          string shortDateString = dateTime.ToShortDateString();
          fechaCertificacion.Text = shortDateString;
          if (certificacionImportadorList[0].cim_NumeroRadicadoUtilizado != null)
          {
            this.PanelRadicadoHijo.Visible = true;
            this.textNumeroRadicadoHijo.Text = certificacionImportadorList[0].cim_NumeroRadicadoUtilizado;
            this.textFechaRadicacionHijo.Text = certificacionImportadorList[0].cim_FechaRadicadoUtilizado.ToString();
          }
          this.TextDescripcion.Text = certificacionImportadorList[0].cim_Descripcion;
          this.comboImportador.Enabled = false;
          this.comboProcedencia.Enabled = false;
          this.comboEmpresa.Enabled = false;
          this.comboMarca.Enabled = false;
          this.RadioFuncionario.Enabled = false;
          this.RadioDistribuidor.Enabled = false;
          this.textFechaCertificacion.Enabled = false;
          if (certificacionImportadorList[0].cim_NumeroRadicadoUtilizado != null)
          {
            this.PanelRadicadoHijo.Visible = true;
            this.textNumeroRadicadoHijo.Enabled = false;
            this.textFechaRadicacionHijo.Enabled = false;
          }
          this.TextDescripcion.Enabled = false;
        }
        else
        {
          flag = false;
          message += "Este número de radicado no existe";
        }
        if (!flag)
          throw new Exception(message);
      }
      catch (Exception ex)
      {
        this.ControlError1.Show(ex);
      }
    }

    protected void buttonGuardar_Click(object sender, EventArgs e)
    {
      try
      {
        this.Validar();
        this.ControlError1.Visible = false;
        cim_CertificacionImportador myParams = (cim_CertificacionImportador) this.LocalInfo.MyParams;
        myParams.cim_NumeroRadicado = this.textNumeroRadicado.Text;
        myParams.cim_FechaRadicado = DateTime.Parse(this.textFechaRadicado.Text);
        myParams.ter_IdRadicadoPor = int.Parse(this.comboRadicado.SelectedValue);
        myParams.ter_IdImportador = int.Parse(this.comboImportador.SelectedValue);
        myParams.ter_IdEmpresa = int.Parse(this.comboEmpresa.SelectedValue);
        myParams.pas_IdProcedencia = int.Parse(this.comboProcedencia.SelectedValue);
        myParams.meq_Id = int.Parse(this.comboMarca.SelectedValue);
        myParams.cim_Usuario = "";
        myParams.cim_Modificado = DateTime.Now;
        myParams.cim_Fabricante = !this.RadioFuncionario.Checked ? new bool?(false) : new bool?(true);
        myParams.cim_Distribuidor = !this.RadioDistribuidor.Checked ? new bool?(false) : new bool?(true);
        myParams.cim_Descripcion = this.TextDescripcion.Text;
        myParams.cim_FechaCertificado = DateTime.Parse(this.textFechaCertificacion.Text);
        if (this.textNumeroRadicadoHijo.Text != "")
        {
          myParams.cim_NumeroRadicadoUtilizado = this.textNumeroRadicadoHijo.Text;
          myParams.cim_FechaRadicadoUtilizado = new DateTime?(DateTime.Parse(this.textFechaRadicacionHijo.Text));
        }
        if (myParams.cim_Id == 0)
        {
          myParams.cim_Creado = DateTime.Now;
          this.MyDataContext.cim_CertificacionImportadors.InsertOnSubmit(myParams);
        }
        this.MyDataContext.SubmitChanges();
        if ((int) this.LocalInfo.GetData("idProyecto") == 0)
          CAuditoria.log(EPermiso.AdicionarCertificaciones, myParams.cim_Id.ToString(), myParams.cim_NumeroRadicado, myParams.cim_FechaRadicado.ToShortDateString(), "", "", this.Usuario.id);
        else
          CAuditoria.log(EPermiso.ModificarCertificaciones, myParams.cim_Id.ToString(), myParams.cim_NumeroRadicado, myParams.cim_FechaRadicado.ToShortDateString(), "", "", this.Usuario.id);
        this.Server.Transfer("~/ImportacionExportacion/CertificacionesBuscar.aspx");
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
      if (this.textNumeroRadicado.Text == "")
      {
        flag = false;
        message += "El número de radicado es un campo obligatorio. <br />";
      }
      if (this.textFechaRadicado.Text == "")
      {
        flag = false;
        message += " La fecha de radicado es un campo obligatorio. <br />";
      }
      if (this.comboEmpresa.SelectedValue == "")
      {
        flag = false;
        message += " La empresa es un campo obligatorio. <br />";
      }
      if (this.comboImportador.SelectedValue == "")
      {
        flag = false;
        message += " El importador es un campo obligatorio. <br />";
      }
      if (this.comboMarca.SelectedValue == "")
      {
        flag = false;
        message += " La marca es un campo obligatorio. <br />";
      }
      if (this.comboProcedencia.SelectedValue == "")
      {
        flag = false;
        message += " La procedencia es un campo obligatorio. <br />";
      }
      if (this.textFechaCertificacion.Text == "")
      {
        flag = false;
        message += " La fecha de certificado es un campo obligatorio. <br />";
      }
      if (!flag)
        throw new Exception(message);
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
        this.cargarComboTercero(this.comboImportador, 2, 0);
        this.comboImportador.SelectedValue = entity.ter_Id.ToString();
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
            throw new Exception("El tercero ya se encuentra registrado");
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

    protected void comboMarca_SelectedIndexChanged(object sender, EventArgs e)
    {
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

    protected void buttonGuardarEmpresa_Click(object sender, EventArgs e)
    {
      this.ControlError3.Visible = true;
      try
      {
        this.ValidarEmpresa();
        ter_Tercero entity = new ter_Tercero();
        entity.ter_NombreCompleto = this.textNombreEmpresa.Text.ToUpper();
        entity.dti_Id = 0;
        entity.ter_NumeroDocumento = "";
        entity.dep_Id = "02";
        entity.mun_Id = "02999";
        entity.ter_Tefono = "";
        entity.ter_Direccion = "";
        entity.ter_Correo = "";
        entity.ter_Celular = "";
        entity.ter_Fax = "";
        entity.bti_Id = 2;
        this.MyDataContext.ttt_TerceroTipoTerceros.InsertOnSubmit(new ttt_TerceroTipoTercero()
        {
          ter_Tercero = entity,
          tti_Id = 8
        });
        this.MyDataContext.ter_Terceros.InsertOnSubmit(entity);
        this.MyDataContext.SubmitChanges();
        this.cargarComboTercero(this.comboEmpresa, 9, 0);
        this.comboEmpresa.SelectedValue = entity.ter_Id.ToString();
        this.panelEmpresa.Visible = false;
      }
      catch (Exception ex)
      {
        this.ControlError3.Visible = true;
        this.ControlError3.Show(ex);
      }
    }

    private void ValidarEmpresa()
    {
      string message = "";
      bool flag = true;
      if (CLinq.ListByProperties<ter_Tercero>((DataContext) this.MyDataContext, (object) "ter_NombreCompleto", (object) this.textNombreEmpresa.Text.ToUpper(), (object) "mun_Id", (object) "02999").Count > 0)
        throw new Exception("El tercero ya se encuentra registrado");
      if (this.textNombreEmpresa.Text == "")
      {
        flag = false;
        message += "El nombre del tercero o la razón social es un campo obligatorio. <br />";
      }
      if (!flag)
        throw new Exception(message);
    }

    protected void buttonCancelarEmpresa_Click(object sender, EventArgs e) => this.panelEmpresa.Visible = false;

    protected void comboDepartamentoEmpresa_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    protected void buttonAgregarEmpresa_Click(object sender, EventArgs e) => this.panelEmpresa.Visible = true;
  }
}
