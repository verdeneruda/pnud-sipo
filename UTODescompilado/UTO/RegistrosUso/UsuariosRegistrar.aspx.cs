// Decompiled with JetBrains decompiler
// Type: UTO.RegistrosUso.UsuariosRegistrar
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
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace UTO.RegistrosUso
{
  public class UsuariosRegistrar : BaseModulo
  {
    protected ToolkitScriptManager ToolkitScriptManager1;
    protected Label labelRegistrarRegistrosUsoUsuarios;
    protected ControlError ControlError1;
    protected Label labelDatosGenerales;
    protected Panel PanelBuscarTercero;
    protected Label labelBuscarEmpresa;
    protected Label labelRazonSocialBusqueda;
    protected TextBox textRazonSocialBusqueda;
    protected Label labelNitBusqueda;
    protected TextBox textNitBusqueda;
    protected Button buttonBuscarTercero;
    protected Button buttonAdicionarTercero;
    protected GridView GridViewTerceroBuscar;
    protected SqlDataSource usuarioRegistrarDataSource;
    protected Panel panelDatosempresa;
    protected Label labelTipoUsuario;
    protected DropDownList comboTipoUsuario;
    protected Label labelSector;
    protected DropDownList comboSector;
    protected Label labelfecha;
    protected TextBox textFecha;
    protected CalendarExtender calendarFecha;
    protected Label labelDepartamentoDatosgenerales;
    protected DropDownList comboDepartamento;
    protected Label labelciudadDatosgenerales;
    protected DropDownList comboCiudad;
    protected CalendarExtender CalendarExtender1;
    protected Label labelDatosEmpresa;
    protected Label labelRazonSocial;
    protected TextBox textRazonsocial;
    protected Label labelNit;
    protected Label Label17;
    protected TextBox textNit;
    protected Label labelTelefono;
    protected TextBox textTelefono;
    protected Label labelEmail;
    protected TextBox textEmail;
    protected Label labelDireccion;
    protected TextBox textDireccion;
    protected Label label3;
    protected Label Label18;
    protected DropDownList comboRegional;
    protected Label label1;
    protected Label Label19;
    protected DropDownList comboDepartamentoTercero;
    protected Label label2;
    protected Label Label20;
    protected UpdatePanel updateCiudadTercero;
    protected DropDownList comboCiudadTercero;
    protected HtmlTableCell trColProductos;
    protected LinkButton linkEquipos;
    protected ImageButton imageEquipos;
    protected CollapsiblePanelExtender colapsibleProductos;
    protected Panel panelProductos;
    protected Button buttonAgregar;
    protected GridView gridDetalle;
    protected Button buttonGuardar;
    protected Button buttoncancelar;
    protected ModalPopupExtender modalAddProductos;
    protected Panel panelAddProductos;
    protected ControlError ControlError2;
    protected Label labelSustanciaUsada;
    protected Label Label4;
    protected DropDownList comboSustanciaUsada;
    protected Label LabelCantidadUsadaAnual;
    protected Label Label7;
    protected TextBox textCantidadUsadaAnual;
    protected Label labeCategoria;
    protected Label Label6;
    protected DropDownList comboCategoria;
    protected Label labelTipoEquipo;
    protected Label Label5;
    protected DropDownList comboTipoEuipo;
    protected Label Label8;
    protected TextBox textNumeroUnidades;
    protected Label Label9;
    protected TextBox textcargaPromedioInstalada;
    protected Label Label10;
    protected TextBox textCargaPromedioPorMantenimiento;
    protected Label Label11;
    protected TextBox textConsumoEnergetico;
    protected Label Label12;
    protected TextBox textPotenciaCompresor;
    protected Label Label13;
    protected TextBox textVolumentUtil;
    protected Label Label14;
    protected TextBox textCapacidadEnfriamiento;
    protected Label Label15;
    protected TextBox textObservaciones;
    protected Button buttonEnviarProducto;
    protected Button buttonCancelarProducto;

    protected new void Page_Load(object sender, EventArgs e)
    {
      this.buttonGuardar.Enabled = this.Usuario.permiteOperacion(EPermiso.ModificarUsuariosFinales) || this.Usuario.permiteOperacion(EPermiso.AdicionarUsuariosFinales);
      this.ControlError1.Visible = false;
      this.ControlError2.Visible = false;
      if (this.IsPostBack)
        return;
      this.InitData();
    }

    private void InitData()
    {
      this.comboRegional.DataSource = (object) CLinq.ListAll<reg_Regional>((DataContext) this.MyDataContext);
      this.comboRegional.DataBind();
      this.comboRegional.Items.Insert(0, "");
      this.comboDepartamento.DataSource = (object) CLinq.ListAll<dep_Departamento>((DataContext) this.MyDataContext);
      this.comboDepartamento.DataBind();
      this.comboDepartamento.Items.Insert(0, "");
      this.comboTipoUsuario.DataSource = (object) CLinq.ListAll<utf_UsuarioTipoFinal>((DataContext) this.MyDataContext);
      this.comboTipoUsuario.DataBind();
      this.comboTipoUsuario.Items.Insert(0, "");
      this.comboSector.DataSource = (object) CLinq.ListAll<sec_Sector>((DataContext) this.MyDataContext);
      this.comboSector.DataBind();
      this.comboSector.Items.Insert(0, "");
      this.comboSustanciaUsada.DataSource = (object) CLinq.ListAll<sus_Sustancia>((DataContext) this.MyDataContext);
      this.comboSustanciaUsada.DataBind();
      this.comboSustanciaUsada.Items.Insert(0, "");
      this.comboTipoEuipo.DataSource = (object) CLinq.ListAll<eti_EquipoTipo>((DataContext) this.MyDataContext);
      this.comboTipoEuipo.DataBind();
      this.comboTipoEuipo.Items.Insert(0, "");
      this.comboCategoria.DataSource = (object) CLinq.ListAll<ceq_CategoriaEquipo>((DataContext) this.MyDataContext);
      this.comboCategoria.DataBind();
      this.comboCategoria.Items.Insert(0, "");
      this.textCantidadUsadaAnual.Text = "0";
      this.textCapacidadEnfriamiento.Text = "0";
      this.textcargaPromedioInstalada.Text = "0";
      this.textCargaPromedioPorMantenimiento.Text = "0";
      this.textConsumoEnergetico.Text = "0";
      this.textNumeroUnidades.Text = "0";
      this.textObservaciones.Text = "";
      this.textPotenciaCompresor.Text = "0";
      this.textVolumentUtil.Text = "0";
      this.comboCategoria.Text = "";
      this.comboTipoEuipo.Text = "";
      this.comboSustanciaUsada.Text = "";
      this.LocalInfo.SetData("idUsuario", (object) ((BaseModulo.strSendParam) this.LocalInfo.MyParams).id);
      if (((BaseModulo.strSendParam) this.LocalInfo.MyParams).id != 0)
      {
        BaseModulo.strSendParam myParams = (BaseModulo.strSendParam) this.LocalInfo.MyParams;
        if (myParams.tipo == "Ver")
        {
          this.buttonGuardar.Enabled = false;
          this.gridDetalle.Enabled = false;
        }
        myParams = (BaseModulo.strSendParam) this.LocalInfo.MyParams;
        this.mostrarDatos(myParams.id);
      }
      else
      {
        this.LocalInfo.MyParams = (object) new ufd_UsuarioFinalDato();
        this.LocalInfo.SetData("listaDetalles", (object) new EntitySet<ufe_UsuarioFinalDetalle>());
      }
    }

    private void mostrarDatos(int idUsuario)
    {
      ufd_UsuarioFinalDato byKey = CLinq.FindByKey<ufd_UsuarioFinalDato>((DataContext) this.MyDataContext, (object) idUsuario);
      ter_Tercero terTercero = byKey.ter_Tercero;
      this.LocalInfo.SetData("listaDetalles", (object) byKey.ufe_UsuarioFinalDetalles);
      this.textRazonsocial.Text = terTercero.ter_NombreCompleto;
      this.textNit.Text = terTercero.ter_NumeroDocumento;
      this.textDireccion.Text = terTercero.ter_Direccion;
      this.textTelefono.Text = terTercero.ter_Tefono;
      this.textEmail.Text = terTercero.ter_Correo;
      this.comboRegional.Items.FindByValue(terTercero.reg_Id.ToString()).Selected = true;
      if (terTercero.reg_Id.HasValue)
        this.LoadDeptoTerceroxRegional(terTercero.reg_Id.Value);
      this.LoadCiudadTerceroxDepto(terTercero.dep_Id);
      this.comboCiudadTercero.Items.FindByValue(terTercero.mun_Id).Selected = true;
      this.LocalInfo.SetData("tercero", (object) terTercero);
      this.LocalInfo.MyParams = (object) byKey;
      this.textFecha.Text = byKey.ufd_Fecha.ToShortDateString();
      this.comboDepartamento.Items.FindByValue(byKey.dep_Id).Selected = true;
      this.LoadCiudadxDepto(byKey.dep_Id);
      this.comboCiudad.Items.FindByValue(byKey.mun_Id).Selected = true;
      this.comboTipoUsuario.Items.FindByValue(byKey.utf_Id.ToString()).Selected = true;
      this.comboSector.Items.FindByValue(byKey.sec_Id.ToString()).Selected = true;
      this.ActualizaGrilla();
      this.PanelBuscarTercero.Visible = false;
      this.panelDatosempresa.Visible = true;
      this.trColProductos.Style.Value = "display:";
    }

    protected void buttoncancelar_Click(object sender, EventArgs e) => this.Response.Redirect("~/RegistrosUso/UsuariosBuscar.aspx");

    protected void gridDetalle_RowCommand(object sender, GridViewCommandEventArgs e)
    {
      if (e.CommandName.Equals("Editar"))
      {
        this.comboCategoria.SelectedValue = "0";
        this.comboTipoEuipo.SelectedValue = "0";
        this.comboSustanciaUsada.SelectedValue = "1";
        this.textCantidadUsadaAnual.Text = "50";
        this.textNumeroUnidades.Text = "5";
        this.textcargaPromedioInstalada.Text = "1";
        this.textCargaPromedioPorMantenimiento.Text = "1";
        this.textConsumoEnergetico.Text = string.Empty;
        this.textPotenciaCompresor.Text = string.Empty;
        this.textVolumentUtil.Text = "1";
        this.textCapacidadEnfriamiento.Text = string.Empty;
      }
      if (!e.CommandName.Equals("Eliminar"))
        return;
      EntitySet<ufe_UsuarioFinalDetalle> data = (EntitySet<ufe_UsuarioFinalDetalle>) this.LocalInfo.GetData("listaDetalles");
      ufe_UsuarioFinalDetalle entity = data[int.Parse(this.gridDetalle.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString())];
      this.MyDataContext.ufe_UsuarioFinalDetalles.DeleteOnSubmit(entity);
      data.Remove(entity);
      this.LocalInfo.SetData("listaDetalles", (object) data);
      this.ActualizaGrilla();
    }

    protected void buttonBuscarTercero_Click(object sender, EventArgs e)
    {
      this.GridViewTerceroBuscar.Visible = true;
      this.usuarioRegistrarDataSource.SelectParameters["nit"].DefaultValue = this.textNitBusqueda.Text != "" ? this.textNitBusqueda.Text : "%";
      this.usuarioRegistrarDataSource.SelectParameters["nombre"].DefaultValue = this.textRazonSocialBusqueda.Text != "" ? this.textRazonSocialBusqueda.Text : "%";
    }

    protected void buttonAdicionarTercero_Click(object sender, EventArgs e)
    {
      this.trColProductos.Style.Value = "display:";
      this.PanelBuscarTercero.Visible = false;
      this.panelDatosempresa.Visible = true;
      this.LocalInfo.SetData("tercero", (object) new ter_Tercero());
    }

    protected void GridViewTerceroBuscar_RowCommand(object sender, GridViewCommandEventArgs e)
    {
      if (!e.CommandName.Equals("Seleccionar"))
        return;
      this.PanelBuscarTercero.Visible = false;
      this.panelDatosempresa.Visible = true;
      this.trColProductos.Style.Value = "display:";
      ter_Tercero byKey = CLinq.FindByKey<ter_Tercero>((DataContext) this.MyDataContext, (object) int.Parse(this.GridViewTerceroBuscar.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString()));
      this.textRazonsocial.Text = byKey.ter_NombreCompleto;
      this.textNit.Text = byKey.ter_NumeroDocumento;
      this.textDireccion.Text = byKey.ter_Direccion;
      this.textTelefono.Text = byKey.ter_Tefono;
      this.textEmail.Text = byKey.ter_Correo;
      this.comboRegional.SelectedValue = byKey.reg_Id.ToString();
      this.comboDepartamentoTercero.SelectedValue = byKey.dep_Id;
      this.comboCiudadTercero.SelectedValue = byKey.mun_Id;
      this.LocalInfo.SetData("tercero", (object) byKey);
    }

    protected void comboDepartamentoTercero_SelectedIndexChanged(object sender, EventArgs e) => this.LoadCiudadTerceroxDepto(this.comboDepartamentoTercero.SelectedValue);

    protected void comboDepartamento_SelectedIndexChanged(object sender, EventArgs e) => this.LoadCiudadxDepto(this.comboDepartamento.SelectedValue);

    protected void buttonCancelarProducto_Click(object sender, EventArgs e) => this.modalAddProductos.Hide();

    protected void buttonEnviarProducto_Click(object sender, EventArgs e)
    {
      try
      {
        this.ValidaDetalles();
        EntitySet<ufe_UsuarioFinalDetalle> data = (EntitySet<ufe_UsuarioFinalDetalle>) this.LocalInfo.GetData("listaDetalles");
        ufe_UsuarioFinalDetalle entity = new ufe_UsuarioFinalDetalle();
        entity.ufd_UsuarioFinalDato = (ufd_UsuarioFinalDato) this.LocalInfo.MyParams;
        entity.sus_Id = int.Parse(this.comboSustanciaUsada.Text);
        entity.ufe_CantidadSustanciaUsada = int.Parse(this.textCantidadUsadaAnual.Text);
        entity.ceq_Id = int.Parse(this.comboCategoria.SelectedValue);
        entity.eti_Id = int.Parse(this.comboTipoEuipo.SelectedValue);
        entity.ufe_NumeroUnidades = this.textNumeroUnidades.Text == "" ? 0 : int.Parse(this.textNumeroUnidades.Text);
        entity.ufe_CargaPromedioInstalada = this.textcargaPromedioInstalada.Text == "" ? 0M : Decimal.Parse(this.textcargaPromedioInstalada.Text);
        entity.ufe_CargaPromedioMantenimiento = this.textCargaPromedioPorMantenimiento.Text == "" ? 0M : Decimal.Parse(this.textCargaPromedioPorMantenimiento.Text);
        entity.ufe_ConsumoEnergetico = this.textConsumoEnergetico.Text == "" ? 0M : Decimal.Parse(this.textConsumoEnergetico.Text);
        entity.ufe_PotenciaCompresor = this.textPotenciaCompresor.Text == "" ? 0M : Decimal.Parse(this.textPotenciaCompresor.Text);
        entity.ufe_VolumenUtil = this.textVolumentUtil.Text == "" ? 0 : int.Parse(this.textVolumentUtil.Text);
        entity.ufe_CapacidadEnfriamiento = this.textCapacidadEnfriamiento.Text == "" ? 0M : Decimal.Parse(this.textCapacidadEnfriamiento.Text);
        entity.ufe_Observaciones = this.textObservaciones.Text;
        entity.ufe_Creado = DateTime.Now;
        entity.ufe_Modificado = DateTime.Now;
        entity.ufe_Usuario = this.Usuario.login;
        this.textCantidadUsadaAnual.Text = "0";
        this.textCapacidadEnfriamiento.Text = "0";
        this.textcargaPromedioInstalada.Text = "0";
        this.textCargaPromedioPorMantenimiento.Text = "0";
        this.textConsumoEnergetico.Text = "0";
        this.textNumeroUnidades.Text = "0";
        this.textObservaciones.Text = "";
        this.textPotenciaCompresor.Text = "0";
        this.textVolumentUtil.Text = "0";
        this.comboCategoria.Text = "";
        this.comboTipoEuipo.Text = "";
        this.comboSustanciaUsada.Text = "";
        this.MyDataContext.ufe_UsuarioFinalDetalles.InsertOnSubmit(entity);
        data.Add(entity);
        this.LocalInfo.SetData("listaDetalles", (object) data);
        this.ActualizaGrilla();
        this.modalAddProductos.Hide();
      }
      catch (Exception ex)
      {
        this.modalAddProductos.Show();
        this.ControlError2.Visible = true;
        this.ControlError2.Show(ex);
      }
    }

    private void ValidaDetalles()
    {
      string message = "";
      double number = 0.0;
      bool flag = true;
      if (!CValidaEspeciales.VRequerido(this.comboSustanciaUsada.SelectedValue))
      {
        message += "Seleccione la sustancia usada. <br />";
        flag = false;
      }
      if (!CValidaEspeciales.VRequerido(this.textCantidadUsadaAnual.Text))
      {
        message += "Escriba la cantidad usada en kg. <br/>";
        flag = false;
      }
      if (CValidaEspeciales.VRequerido(this.textCantidadUsadaAnual.Text) && !CValidator.isNumeric(this.textCantidadUsadaAnual.Text, ref number))
      {
        message += "La cantidad debe ser un número. <br/>";
        flag = false;
      }
      if (!CValidaEspeciales.VRequerido(this.comboCategoria.SelectedValue))
      {
        message += "Seleccione la categoría. <br/>";
        flag = false;
      }
      if (!CValidaEspeciales.VRequerido(this.comboTipoEuipo.SelectedValue))
      {
        message += "Seleccione el tipo de equipo. <br/>";
        flag = false;
      }
      if (this.textNumeroUnidades.Text != "0" && !CValidator.isNumeric(this.textNumeroUnidades.Text, ref number))
      {
        message += "El número de unidades debe ser un número. <br/>";
        flag = false;
      }
      if (this.textcargaPromedioInstalada.Text != "0" && !CValidator.isNumeric(this.textcargaPromedioInstalada.Text, ref number))
      {
        message += "La carga promedio instalada debe ser un número. <br/>";
        flag = false;
      }
      if (this.textCargaPromedioPorMantenimiento.Text != "0" && !CValidator.isNumeric(this.textCargaPromedioPorMantenimiento.Text, ref number))
      {
        message += "La carga promedio por mantenimiento debe ser un número. <br/>";
        flag = false;
      }
      if (this.textConsumoEnergetico.Text != "0" && !CValidator.isNumeric(this.textConsumoEnergetico.Text, ref number))
      {
        message += "El consumo energético debe ser un número. <br/>";
        flag = false;
      }
      if (this.textPotenciaCompresor.Text != "0" && !CValidator.isNumeric(this.textPotenciaCompresor.Text, ref number))
      {
        message += "La potencia del compresor debe ser un número. <br/>";
        flag = false;
      }
      if (this.textVolumentUtil.Text != "0" && !CValidator.isNumeric(this.textVolumentUtil.Text, ref number))
      {
        message += "El volumen útil debe ser un número. <br/>";
        flag = false;
      }
      if (this.textCapacidadEnfriamiento.Text != "0" && !CValidator.isNumeric(this.textCapacidadEnfriamiento.Text, ref number))
      {
        message += "la capacidad de enfriamiento debe ser un número. <br/>";
        flag = false;
      }
      if (!flag)
        throw new Exception(message);
    }

    protected void buttonGuardar_Click(object sender, EventArgs e)
    {
      try
      {
        this.Validar();
        int data1 = (int) this.LocalInfo.GetData("idUsuario");
        ufd_UsuarioFinalDato myParams = (ufd_UsuarioFinalDato) this.LocalInfo.MyParams;
        ter_Tercero data2 = (ter_Tercero) this.LocalInfo.GetData("tercero");
        EntitySet<ufe_UsuarioFinalDetalle> data3 = (EntitySet<ufe_UsuarioFinalDetalle>) this.LocalInfo.GetData("listaDetalles");
        if (data2.ter_Id == 0)
        {
          data2.ter_NombreCompleto = this.textRazonsocial.Text.ToUpper();
          data2.ter_NumeroDocumento = this.textNit.Text.ToUpper();
          data2.ter_Direccion = this.textDireccion.Text.ToUpper();
          data2.ter_Tefono = this.textTelefono.Text.ToUpper();
          data2.ter_Correo = this.textEmail.Text.ToUpper();
          data2.reg_Id = new int?(int.Parse(this.comboRegional.SelectedValue));
          data2.dep_Id = this.comboDepartamentoTercero.SelectedValue;
          data2.mun_Id = this.comboCiudadTercero.SelectedValue;
          ttt_TerceroTipoTercero entity = new ttt_TerceroTipoTercero();
          entity.tti_Id = 4;
          data2.bti_Id = 2;
          data2.dti_Id = 1;
          entity.ter_Tercero = data2;
          this.MyDataContext.ter_Terceros.InsertOnSubmit(data2);
          this.MyDataContext.ttt_TerceroTipoTerceros.InsertOnSubmit(entity);
        }
        myParams.dep_Id = this.comboDepartamento.SelectedValue;
        myParams.mun_Id = this.comboCiudad.SelectedValue;
        myParams.rri_Modificado = DateTime.Now;
        myParams.rri_Usuario = "";
        myParams.sec_Id = int.Parse(this.comboSector.SelectedValue);
        myParams.ter_Tercero = data2;
        myParams.ufd_Fecha = DateTime.Parse(this.textFecha.Text);
        myParams.utf_Id = int.Parse(this.comboTipoUsuario.SelectedValue);
        if (myParams.ufd_Id == 0)
        {
          myParams.rri_Creado = DateTime.Now;
          this.MyDataContext.ufd_UsuarioFinalDatos.InsertOnSubmit(myParams);
        }
        this.MyDataContext.SubmitChanges();
        if ((int) this.LocalInfo.GetData("idUsuario") == 0)
          CAuditoria.log(EPermiso.AdicionarUsuariosFinales, myParams.ufd_Id.ToString(), myParams.ter_Tercero.ter_NumeroDocumento, myParams.ter_Tercero.ter_NombreCompleto, "", "", this.Usuario.id);
        else
          CAuditoria.log(EPermiso.ModificarUsuariosFinales, myParams.ufd_Id.ToString(), myParams.ter_Tercero.ter_NumeroDocumento, myParams.ter_Tercero.ter_NombreCompleto, "", "", this.Usuario.id);
        this.Response.Redirect("~/RegistrosUso/UsuariosBuscar.aspx");
      }
      catch (Exception ex)
      {
        this.ControlError1.Visible = true;
        this.ControlError1.Show(ex);
      }
    }

    public void ActualizaGrilla()
    {
      List<UsuariosRegistrar.strRegistro> strRegistroList = new List<UsuariosRegistrar.strRegistro>();
      EntitySet<ufe_UsuarioFinalDetalle> data = (EntitySet<ufe_UsuarioFinalDetalle>) this.LocalInfo.GetData("listaDetalles");
      for (int index = 0; index < data.Count; ++index)
        strRegistroList.Add(new UsuariosRegistrar.strRegistro()
        {
          id = index,
          cantidad = data[index].ufe_CantidadSustanciaUsada,
          categoria = CLinq.FindByKey<ceq_CategoriaEquipo>((DataContext) this.MyDataContext, (object) data[index].ceq_Id).ceq_Descripcion,
          numero = data[index].ufe_NumeroUnidades,
          tipo = CLinq.FindByKey<eti_EquipoTipo>((DataContext) this.MyDataContext, (object) data[index].eti_Id).eti_Descripcion,
          sustancia = CLinq.FindByKey<sus_Sustancia>((DataContext) this.MyDataContext, (object) data[index].sus_Id).sus_Descripcion
        });
      this.gridDetalle.DataSource = (object) strRegistroList;
      this.gridDetalle.DataBind();
    }

    protected void comboCategoria_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.comboTipoEuipo.DataSource = (object) CLinq.FindByProperty<eti_EquipoTipo>((DataContext) this.MyDataContext, "ceq_Id", (object) int.Parse(this.comboCategoria.SelectedValue));
      this.comboTipoEuipo.DataBind();
      this.comboTipoEuipo.Items.Insert(0, "");
    }

    private void Validar()
    {
      bool flag = true;
      string message = "";
      ter_Tercero data = (ter_Tercero) this.LocalInfo.GetData("tercero");
      DateTime date = DateTime.Parse("1/1/1900");
      if (!CValidaEspeciales.VRequerido(this.comboTipoUsuario.SelectedValue))
      {
        message = "Seleccione el tipo de usuario. <br/>";
        flag = false;
      }
      if (!CValidaEspeciales.VRequerido(this.comboSector.SelectedValue))
      {
        message += "Seleccione el sector. <br/>";
        flag = false;
      }
      if (!CValidaEspeciales.VRequerido(this.textFecha.Text))
      {
        message += "Seleccione la fecha de la visita. <br/> ";
        flag = false;
      }
      if (CValidaEspeciales.VRequerido(this.textFecha.Text) && !CValidator.isDate(this.textFecha.Text, ref date))
      {
        message += "La fecha no tiene un formato válido. <br/>";
        flag = false;
      }
      if (!CValidaEspeciales.VRequerido(this.comboDepartamento.SelectedValue))
      {
        message += "Seleccione el departamento. <br/>";
        flag = false;
      }
      if (data.ter_Id == 0)
      {
        if (!CValidaEspeciales.VRequerido(this.textRazonsocial.Text))
        {
          message += "Escriba la razón social. <br/>";
          flag = false;
        }
        if (!CValidaEspeciales.VRequerido(this.textNit.Text))
        {
          message += "Escriba el NIT. <br/>";
          flag = false;
        }
        if (!CValidaEspeciales.VRequerido(this.comboRegional.SelectedValue))
        {
          message += "Seleccione la regional. <br/>";
          flag = false;
        }
        if (!CValidaEspeciales.VRequerido(this.comboDepartamentoTercero.SelectedValue))
        {
          message += "Seleccione el departamento de la empresa. <br/>";
          flag = false;
        }
        if (!CValidaEspeciales.VRequerido(this.comboCiudadTercero.SelectedValue))
        {
          message += "Seleccione la ciudad de la empresa. <br/>";
          flag = false;
        }
      }
      if (!flag)
        throw new Exception(message);
    }

    protected void SelectRegional(object sender, EventArgs e)
    {
      this.LoadDeptoTerceroxRegional(this.comboRegional.SelectedValue == "" ? -1 : Convert.ToInt32(this.comboRegional.SelectedValue));
      this.LoadCiudadTerceroxDepto("00");
      this.updateCiudadTercero.Update();
    }

    private void LoadCiudadxDepto(string depto)
    {
      this.comboCiudad.DataSource = (object) CLinq.ListByProperty<mun_Municipio>((DataContext) this.MyDataContext, "dep_id", (object) depto);
      this.comboCiudad.DataBind();
      this.comboCiudad.Items.Insert(0, "");
    }

    private void LoadDeptoTerceroxRegional(int regional)
    {
      this.comboDepartamentoTercero.DataSource = (object) CLinq.ListByProperty<dep_Departamento>((DataContext) this.MyDataContext, "reg_Id", (object) regional);
      this.comboDepartamentoTercero.DataBind();
      this.comboDepartamentoTercero.Items.Insert(0, "");
    }

    private void LoadCiudadTerceroxDepto(string depto)
    {
      this.comboCiudadTercero.DataSource = (object) CLinq.ListByProperty<mun_Municipio>((DataContext) this.MyDataContext, "dep_id", (object) depto);
      this.comboCiudadTercero.DataBind();
      this.comboCiudadTercero.Items.Insert(0, "");
    }

    public class strRegistro
    {
      private string _sustancia;
      private string _categoria;
      private string _tipo;
      private int _numero;
      private int _cantidad;
      private int _id;

      public string sustancia
      {
        get => this._sustancia;
        set => this._sustancia = value;
      }

      public string categoria
      {
        get => this._categoria;
        set => this._categoria = value;
      }

      public string tipo
      {
        get => this._tipo;
        set => this._tipo = value;
      }

      public int numero
      {
        get => this._numero;
        set => this._numero = value;
      }

      public int id
      {
        get => this._id;
        set => this._id = value;
      }

      public int cantidad
      {
        get => this._cantidad;
        set => this._cantidad = value;
      }
    }
  }
}
