// Decompiled with JetBrains decompiler
// Type: UTO.Proyectos.AprobadosEliminacionRegistrar
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using AjaxControlToolkit;
using NE.CLib;
using NE.CLib.Linq;
using Seguridad.Servicio;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Web.UI.WebControls;
using UTO.Comunes;

namespace UTO.Proyectos
{
  public class AprobadosEliminacionRegistrar : BaseModulo
  {
    protected ToolkitScriptManager ToolkitScriptManager1;
    protected Label labelRegistarProyectosAprobados;
    protected ControlError ControlError1;
    protected Panel PanelProyecto;
    protected Label labelDatosGenerales;
    protected Label labelCodigo;
    protected TextBox textCodigo;
    protected Label labelSector;
    protected DropDownList comboSector;
    protected Label labelNombre;
    protected TextBox textNombre;
    protected Label labelTipo;
    protected Label Label1;
    protected DropDownList comboTipoProyecto;
    protected Label labelAgenciaImplementadora;
    protected TextBox textAgenciaImplementadora;
    protected Label labelCompañia;
    protected TextBox textCompañia;
    protected Label labelDepartamento;
    protected DropDownList comboDepartamento;
    protected Label labelCiudad;
    protected DropDownList comboCiudad;
    protected Label labelAprobado;
    protected TextBox textAprobado;
    protected Label labelDesembolsado;
    protected TextBox textDesembolsados;
    protected Label labelInvertidos;
    protected TextBox textInvertidos;
    protected Label labelODPEliminar;
    protected TextBox textODPEliminar;
    protected Label labelODPEliminadas;
    protected TextBox textODPEliminadas;
    protected Label labelFechaAprobacion;
    protected TextBox textFechaAprobacion;
    protected CalendarExtender calendarfechaInicial;
    protected Label labelFechaTerminacion;
    protected TextBox textFechaTerminacion;
    protected CalendarExtender textFechaTerminacion_CalendarExtender;
    protected Label labelFechaTerminacionReal;
    protected TextBox textFechaTerminacionReal;
    protected CalendarExtender textFechaTerminacionReal_CalendarExtender;
    protected Label labelEstado;
    protected TextBox textEstado;
    protected Label labelEstadoPorcentaje;
    protected Label labelGrupo;
    protected DropDownList comboGrupo;
    protected Label labelObservaciones;
    protected TextBox textObservaciones;
    protected DocumentosVarios DocumentosVarios1;
    protected Button buttonGuardar;
    protected Button buttoncancelar;

    protected new void Page_Load(object sender, EventArgs e)
    {
      if (this.IsPostBack)
        return;
      this.InitData();
    }

    private void InitData()
    {
      this.comboTipoProyecto.DataSource = (object) CLinq.ListAll<pti_ProyectoTipo>((DataContext) this.MyDataContext);
      this.comboTipoProyecto.DataBind();
      this.comboTipoProyecto.Items.Insert(0, "");
      this.comboSector.DataSource = (object) CLinq.ListAll<pse_ProyectoSector>((DataContext) this.MyDataContext);
      this.comboSector.DataBind();
      this.comboSector.Items.Insert(0, "");
      this.comboDepartamento.DataSource = (object) CLinq.ListAll<dep_Departamento>((DataContext) this.MyDataContext);
      this.comboDepartamento.DataBind();
      this.comboDepartamento.Items.Insert(0, "");
      this.comboGrupo.DataSource = (object) CLinq.ListAll<pyg_ProyectoGrupo>((DataContext) this.MyDataContext);
      this.comboGrupo.DataBind();
      this.comboGrupo.Items.Insert(0, "");
      this.LocalInfo.SetData("idProyecto", (object) ((BaseModulo.strSendParam) this.LocalInfo.MyParams).id);
      if (((BaseModulo.strSendParam) this.LocalInfo.MyParams).id != 0)
      {
        BaseModulo.strSendParam myParams = (BaseModulo.strSendParam) this.LocalInfo.MyParams;
        if (myParams.tipo == "Ver")
        {
          this.PanelProyecto.Enabled = false;
          this.buttonGuardar.Enabled = false;
        }
        myParams = (BaseModulo.strSendParam) this.LocalInfo.MyParams;
        this.mostrarDatos(myParams.id);
      }
      else
      {
        this.LocalInfo.MyParams = (object) new pap_ProyectoAprobado();
        this.DocumentosVarios1.Visible = false;
        this.LocalInfo.SetData("idProvisional", (object) null);
      }
    }

    private void mostrarDatos(int id)
    {
      pap_ProyectoAprobado byKey = CLinq.FindByKey<pap_ProyectoAprobado>((DataContext) this.MyDataContext, (object) id);
      this.LocalInfo.MyParams = (object) byKey;
      this.textCodigo.Text = byKey.pap_Codigo;
      this.textNombre.Text = byKey.pap_NombreProyecto;
      this.comboTipoProyecto.SelectedValue = byKey.pti_Id.ToString();
      this.comboSector.SelectedValue = byKey.pse_Id.ToString();
      this.textAgenciaImplementadora.Text = byKey.pap_AgenciaImplementadora;
      this.textCompañia.Text = byKey.pap_Compania;
      this.comboDepartamento.SelectedValue = byKey.dep_Id.ToString();
      this.listarMunicipio(this.comboDepartamento.SelectedValue);
      this.comboCiudad.SelectedValue = byKey.mun_Id.ToString();
      TextBox textAprobado = this.textAprobado;
      Decimal num;
      string str1;
      if (!byKey.pap_AprobadosFMPM.HasValue)
      {
        str1 = byKey.pap_AprobadosFMPM.ToString();
      }
      else
      {
        num = byKey.pap_AprobadosFMPM.Value;
        str1 = num.ToString("#,##0.00");
      }
      textAprobado.Text = str1;
      TextBox textDesembolsados = this.textDesembolsados;
      string str2;
      if (!byKey.pap_DesembolsadosFMPM.HasValue)
      {
        str2 = byKey.pap_DesembolsadosFMPM.ToString();
      }
      else
      {
        num = byKey.pap_DesembolsadosFMPM.Value;
        str2 = num.ToString("#,##0.00");
      }
      textDesembolsados.Text = str2;
      TextBox textInvertidos = this.textInvertidos;
      string str3;
      if (!byKey.pap_PesosInvertidos.HasValue)
      {
        str3 = byKey.pap_PesosInvertidos.ToString();
      }
      else
      {
        num = byKey.pap_PesosInvertidos.Value;
        str3 = num.ToString("#,##0.00");
      }
      textInvertidos.Text = str3;
      TextBox textOdpEliminar = this.textODPEliminar;
      string str4;
      if (!byKey.pap_TonPAOAEliminar.HasValue)
      {
        str4 = byKey.pap_TonPAOAEliminar.ToString();
      }
      else
      {
        num = byKey.pap_TonPAOAEliminar.Value;
        str4 = num.ToString("#,##0.00");
      }
      textOdpEliminar.Text = str4;
      TextBox textOdpEliminadas = this.textODPEliminadas;
      string str5;
      if (!byKey.pap_TonPAOEliminadas.HasValue)
      {
        str5 = byKey.pap_TonPAOEliminadas.ToString();
      }
      else
      {
        num = byKey.pap_TonPAOEliminadas.Value;
        str5 = num.ToString("#,##0.00");
      }
      textOdpEliminadas.Text = str5;
      TextBox textFechaAprobacion = this.textFechaAprobacion;
      DateTime dateTime;
      string str6;
      if (!byKey.pap_FechaAprobacion.HasValue)
      {
        str6 = byKey.pap_FechaAprobacion.ToString();
      }
      else
      {
        dateTime = byKey.pap_FechaAprobacion.Value;
        str6 = dateTime.ToString("dd/MM/yyyy");
      }
      textFechaAprobacion.Text = str6;
      TextBox fechaTerminacion = this.textFechaTerminacion;
      string str7;
      if (!byKey.pap_FechaTerminacion.HasValue)
      {
        str7 = byKey.pap_FechaTerminacion.ToString();
      }
      else
      {
        dateTime = byKey.pap_FechaTerminacion.Value;
        str7 = dateTime.ToString("dd/MM/yyyy");
      }
      fechaTerminacion.Text = str7;
      TextBox fechaTerminacionReal = this.textFechaTerminacionReal;
      string str8;
      if (!byKey.pap_FechaTerminacionReal.HasValue)
      {
        str8 = byKey.pap_FechaTerminacionReal.ToString();
      }
      else
      {
        dateTime = byKey.pap_FechaTerminacionReal.Value;
        str8 = dateTime.ToString("dd/MM/yyyy");
      }
      fechaTerminacionReal.Text = str8;
      this.textEstado.Text = byKey.pap_Estado;
      this.textObservaciones.Text = byKey.pap_Observacion;
      this.comboGrupo.SelectedValue = byKey.pyg_Id.ToString();
      this.DocumentosVarios1.Visible = true;
      this.DocumentosVarios1.Init("Pro.pdo_ProyectoDocumento", "pap_id", byKey.pap_Id.ToString(), this.MyDataContext.Connection.ConnectionString);
    }

    protected void buttoncancelar_Click(object sender, EventArgs e) => this.Server.Transfer("~/Proyectos/AprobadosEliminacionBuscar.aspx");

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

    protected void buttonGuardar_Click(object sender, EventArgs e)
    {
      try
      {
        this.Validar();
        this.ControlError1.Visible = false;
        pap_ProyectoAprobado myParams = (pap_ProyectoAprobado) this.LocalInfo.MyParams;
        DateTime today = DateTime.Today;
        myParams.pap_Codigo = this.textCodigo.Text;
        myParams.pap_NombreProyecto = this.textNombre.Text.ToUpper();
        myParams.pti_Id = int.Parse(this.comboTipoProyecto.SelectedValue);
        myParams.pse_Id = int.Parse(this.comboSector.SelectedValue);
        myParams.pap_AgenciaImplementadora = this.textAgenciaImplementadora.Text.ToUpper();
        myParams.pap_Compania = this.textCompañia.Text.ToUpper();
        myParams.dep_Id = this.comboDepartamento.SelectedValue;
        int num = this.comboCiudad.SelectedValue == "" ? 0 : (this.comboCiudad.SelectedValue != null ? 1 : 0);
        myParams.mun_Id = num != 0 ? this.comboCiudad.SelectedValue : "01999";
        myParams.pap_AprobadosFMPM = new Decimal?(Decimal.Parse(this.textAprobado.Text));
        myParams.pap_DesembolsadosFMPM = new Decimal?(Decimal.Parse(this.textDesembolsados.Text));
        myParams.pap_PesosInvertidos = new Decimal?(Decimal.Parse(this.textInvertidos.Text));
        myParams.pap_TonPAOAEliminar = new Decimal?(Decimal.Parse(this.textODPEliminar.Text));
        myParams.pap_TonPAOEliminadas = new Decimal?(Decimal.Parse(this.textODPEliminadas.Text));
        myParams.pap_FechaAprobacion = CValidator.isDate(this.textFechaAprobacion.Text, ref today) ? new DateTime?(DateTime.ParseExact(this.textFechaAprobacion.Text, "dd/MM/yyyy", (IFormatProvider) null)) : new DateTime?();
        myParams.pap_FechaTerminacion = CValidator.isDate(this.textFechaTerminacion.Text, ref today) ? new DateTime?(DateTime.ParseExact(this.textFechaTerminacion.Text, "dd/MM/yyyy", (IFormatProvider) null)) : new DateTime?();
        myParams.pap_FechaTerminacionReal = CValidator.isDate(this.textFechaTerminacionReal.Text, ref today) ? new DateTime?(DateTime.ParseExact(this.textFechaTerminacionReal.Text, "dd/MM/yyyy", (IFormatProvider) null)) : new DateTime?();
        myParams.pap_Observacion = this.textObservaciones.Text.ToUpper();
        myParams.pap_Estado = this.textEstado.Text.ToUpper();
        myParams.pap_Usuario = "";
        myParams.pap_Modificado = DateTime.Now;
        myParams.pyg_Id = new int?(int.Parse(this.comboGrupo.SelectedValue));
        if (myParams.pap_Id == 0)
        {
          myParams.pap_Creado = DateTime.Now;
          this.MyDataContext.pap_ProyectoAprobados.InsertOnSubmit(myParams);
        }
        this.MyDataContext.SubmitChanges();
        if (myParams.pap_Id == 0)
          CAuditoria.log(EPermiso.AdicionarProyecto, myParams.pap_Id.ToString(), myParams.pap_Codigo, myParams.pap_NombreProyecto, "", "", this.Usuario.id);
        else
          CAuditoria.log(EPermiso.ModificarProyecto, myParams.pap_Id.ToString(), myParams.pap_Codigo, myParams.pap_NombreProyecto, "", "", this.Usuario.id);
        this.DocumentosVarios1.Visible = true;
        this.DocumentosVarios1.Init("Pro.pdo_ProyectoDocumento", "pap_id", myParams.pap_Id.ToString(), this.MyDataContext.Connection.ConnectionString);
        this.Server.Transfer("~/Proyectos/AprobadosEliminacionBuscar.aspx");
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
      bool flag = true & CValidator.isNumeric(this.textAprobado.Text, ref number, "La cantidad aprobado FMPM debe ser un valor númerico. <br />", ref errStr) & CValidator.isNumeric(this.textDesembolsados.Text, ref number, "La cantidad desembolsados FMPM debe ser un valor númerico. <br />", ref errStr) & CValidator.isNumeric(this.textInvertidos.Text, ref number, "Los US invertidos debe ser un valor númerico. <br />", ref errStr) & CValidator.isNumeric(this.textODPEliminar.Text, ref number, "Las toneladas a eliminar debe ser un valor númerico. <br />", ref errStr) & CValidator.isNumeric(this.textODPEliminadas.Text, ref number, "Las toneladas eliminadas debe ser un valor númerico. <br />", ref errStr);
      if (this.textCodigo.Text == "")
      {
        flag = false;
        errStr += "El código es un campo obligatorio. <br/>";
      }
      if (this.textNombre.Text == "")
      {
        flag = false;
        errStr += "El nombre del proyecto es un campo obligatorio. <br/>";
      }
      if (this.textAgenciaImplementadora.Text == "")
      {
        flag = false;
        errStr += "La agencia implementadora es un campo obligatorio. <br/>";
      }
      if (this.comboGrupo.SelectedValue == "")
      {
        flag = false;
        errStr += "El grupo de proyecto es un campo obligatorio. <br/>";
      }
      if (this.comboTipoProyecto.SelectedValue == "")
      {
        flag = false;
        errStr += "El tipo de proyecto es un campo obligatorio. <br/>";
      }
      if (!flag)
        throw new Exception(errStr);
    }
  }
}
