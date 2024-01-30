// Decompiled with JetBrains decompiler
// Type: UTO.DisposicionFinal.ProductosRegistrar
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

namespace UTO.DisposicionFinal
{
  public class ProductosRegistrar : BaseModulo
  {
    protected ToolkitScriptManager ToolkitScriptManager1;
    protected Panel panelForma;
    protected Label labelAdicionarProductosDisposicionfinal;
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
    protected SqlDataSource productoRegistrarDataSource;
    protected Panel panelAdicionarDisposicionfinal;
    protected UpdatePanel UpdatePanel1;
    protected Label labelfecha;
    protected TextBox textFecha;
    protected CalendarExtender calendarFecha;
    protected Label labelDepartamento;
    protected DropDownList comboDepartamento;
    protected Label labelCiudad;
    protected DropDownList comboCiudad;
    protected Panel panelDatosTercero;
    protected Label labelDatosEmpresa;
    protected Label labelRazonSocial;
    protected TextBox textRazonsocial;
    protected Label label4;
    protected DropDownList comboTipoDocumento;
    protected Label labelNit;
    protected TextBox textNit;
    protected Label labelTelefono;
    protected TextBox textTelefono;
    protected Label labelEmail;
    protected TextBox textEmail;
    protected Label labelDireccion;
    protected TextBox textDireccion;
    protected Label label3;
    protected DropDownList comboRegional;
    protected Label label1;
    protected DropDownList comboDepartamentoTercero;
    protected Label label2;
    protected DropDownList comboCiudadTercero;
    protected HtmlGenericControl divDisposicionfinal;
    protected LinkButton linkProductosDisposicion;
    protected ImageButton imageSustancias;
    protected CollapsiblePanelExtender colapsibleproductosDisposicionFinal;
    protected Panel panelProductosDisposicion;
    protected Button buttonAgregar;
    protected Panel panelAddProductosdisposicion;
    protected Label labelSustanciaDisposicion;
    protected DropDownList comboSustancia;
    protected Label labelPresentacionDisposicion;
    protected DropDownList comboPresentacion;
    protected Label labelCantidad0;
    protected TextBox textCantidadMaestro;
    protected Label labelEstado;
    protected DropDownList comboestado;
    protected Label labelObservaciones;
    protected TextBox textObservaciones;
    protected Label labelfechaDetalle;
    protected TextBox textFechaRegistro;
    protected CalendarExtender CalendarExtender1;
    protected Button buttonAdicionarActualizacion_;
    protected GridView gridActualizacion;
    protected Button buttonEnviarProducto;
    protected Button buttonCancelarProducto;
    protected HtmlGenericControl divProductosGrilla;
    protected GridView gridProductosSustanciasSao;
    protected Button buttonGuardar;
    protected Button buttonCancelar;
    protected Panel panelAddActualizacion;
    protected Label labelCantidadDetalle;
    protected TextBox textCantidadDetalle;
    protected Label labelObservacionDetalle;
    protected TextBox textObservacionDetalle;
    protected Button buttonAdicionarActualizacion;
    protected Button buttonCancelarActualizacion;

    protected new void Page_Load(object sender, EventArgs e)
    {
      this.ControlError1.Hide();
      this.buttonGuardar.Enabled = this.Usuario.permiteOperacion(EPermiso.ModificarSustanciaDisposicionFinal) || this.Usuario.permiteOperacion(EPermiso.AdicionarSustanciasDisposicionFinal);
      this.buttonAdicionarTercero.Visible = this.Usuario.permiteOperacion(EPermiso.AdicionarTecnico);
      this.ControlError1.Hide();
      if (this.IsPostBack)
        return;
      this.InitData();
    }

    private void InitData()
    {
      this.comboTipoDocumento.DataSource = (object) CLinq.ListAll<dti_DocumentoTipo>((DataContext) this.MyDataContext);
      this.comboTipoDocumento.DataBind();
      this.comboTipoDocumento.Items.Insert(0, "");
      this.comboDepartamento.DataSource = (object) CLinq.ListAll<dep_Departamento>((DataContext) this.MyDataContext);
      this.comboDepartamento.DataBind();
      this.comboDepartamento.Items.Insert(0, "");
      this.comboDepartamentoTercero.DataSource = (object) CLinq.ListAll<dep_Departamento>((DataContext) this.MyDataContext);
      this.comboDepartamentoTercero.DataBind();
      this.comboDepartamentoTercero.Items.Insert(0, "");
      this.comboRegional.DataSource = (object) CLinq.ListAll<reg_Regional>((DataContext) this.MyDataContext);
      this.comboRegional.DataBind();
      this.comboRegional.Items.Insert(0, "");
      this.comboCiudadTercero.DataSource = (object) CLinq.ListAll<mun_Municipio>((DataContext) this.MyDataContext);
      this.comboCiudadTercero.DataBind();
      this.comboCiudadTercero.Items.Insert(0, "");
      this.comboCiudad.DataSource = (object) CLinq.ListAll<mun_Municipio>((DataContext) this.MyDataContext);
      this.comboCiudad.DataBind();
      this.comboCiudad.Items.Insert(0, "");
      this.comboSustancia.DataSource = (object) CLinq.ListAll<sus_Sustancia>((DataContext) this.MyDataContext);
      this.comboSustancia.DataBind();
      this.comboSustancia.Items.Insert(0, "");
      this.comboestado.DataSource = (object) CLinq.ListAll<des_DisposicionEstado>((DataContext) this.MyDataContext);
      this.comboestado.DataBind();
      this.comboestado.Items.Insert(0, "");
      this.comboPresentacion.DataSource = (object) CLinq.ListAll<psu_PresentacionSustancia>((DataContext) this.MyDataContext);
      this.comboPresentacion.DataBind();
      this.comboPresentacion.Items.Insert(0, "");
      this.LocalInfo.SetData("idSustancia", (object) ((BaseModulo.strSendParam) this.LocalInfo.MyParams).id);
      this.textFecha.Text = DateTime.Today.ToShortDateString();
      if (((BaseModulo.strSendParam) this.LocalInfo.MyParams).id != 0)
      {
        BaseModulo.strSendParam myParams = (BaseModulo.strSendParam) this.LocalInfo.MyParams;
        if (myParams.tipo == "Ver")
        {
          this.panelForma.Enabled = false;
          this.buttonGuardar.Enabled = false;
          this.buttonCancelar.Enabled = true;
        }
        myParams = (BaseModulo.strSendParam) this.LocalInfo.MyParams;
        this.mostrarDatos(myParams.id);
      }
      else
      {
        this.LocalInfo.MyParams = (object) new dfd_DisposicionFinalDato();
        this.LocalInfo.SetData("listaSustancias", (object) new EntitySet<ddd_DisposicionDatosDetalle>());
        this.LocalInfo.SetData("tercero", (object) new ter_Tercero());
      }
    }

    private void mostrarDatos(int idSustancia)
    {
      dfd_DisposicionFinalDato byKey = CLinq.FindByKey<dfd_DisposicionFinalDato>((DataContext) this.MyDataContext, (object) idSustancia);
      ter_Tercero terTercero = byKey.ter_Tercero;
      this.LocalInfo.SetData("listaSustancias", (object) byKey.ddd_DisposicionDatosDetalles);
      this.PanelBuscarTercero.Visible = false;
      this.panelDatosTercero.Visible = true;
      this.divDisposicionfinal.Visible = true;
      this.panelDatosTercero.Enabled = false;
      this.panelAdicionarDisposicionfinal.Visible = true;
      this.textRazonsocial.Text = terTercero.ter_NombreCompleto;
      this.textNit.Text = terTercero.ter_NumeroDocumento;
      this.textDireccion.Text = terTercero.ter_Direccion;
      this.textTelefono.Text = terTercero.ter_Tefono;
      this.textEmail.Text = terTercero.ter_Correo;
      this.LocalInfo.SetData("tercero", (object) terTercero);
      this.comboRegional.SelectedValue = terTercero.reg_Id.ToString();
      this.comboDepartamentoTercero.SelectedValue = terTercero.dep_Id;
      this.comboCiudadTercero.SelectedValue = terTercero.mun_Id;
      this.comboTipoDocumento.SelectedValue = terTercero.dti_Id.ToString();
      this.textFecha.Text = byKey.dfd_Fecha.ToShortDateString();
      this.comboCiudad.SelectedValue = byKey.mun_Id;
      this.comboDepartamento.SelectedValue = byKey.dep_Id;
      this.LocalInfo.MyParams = (object) byKey;
      this.ActualizaGrilla();
      this.divProductosGrilla.Visible = true;
    }

    protected void buttonCancelar_Click(object sender, EventArgs e) => this.Response.Redirect("~/DisposicionFinal/ProductosBuscar.aspx");

    protected void gridProductosSustanciasSao_RowCommand(object sender, GridViewCommandEventArgs e)
    {
      if (e.CommandName.Equals("Modificar"))
      {
        this.panelAddProductosdisposicion.Visible = true;
        ddd_DisposicionDatosDetalle disposicionDatosDetalle = ((EntitySet<ddd_DisposicionDatosDetalle>) this.LocalInfo.GetData("listaSustancias"))[int.Parse(this.gridProductosSustanciasSao.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString())];
        this.LocalInfo.SetData("idDetalle", (object) int.Parse(this.gridProductosSustanciasSao.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString()));
        this.textCantidadMaestro.Text = disposicionDatosDetalle.ddd_Cantidad.ToString();
        this.textFechaRegistro.Text = disposicionDatosDetalle.ddd_Creado.ToShortDateString();
        this.textObservaciones.Text = disposicionDatosDetalle.ddd_Observaciones;
        this.comboestado.SelectedValue = disposicionDatosDetalle.des_Id.ToString();
        this.comboPresentacion.SelectedValue = disposicionDatosDetalle.psu_Id.ToString();
        this.comboSustancia.SelectedValue = disposicionDatosDetalle.sus_Id.ToString();
      }
      if (!e.CommandName.Equals("Eliminar"))
        return;
      EntitySet<ddd_DisposicionDatosDetalle> data = (EntitySet<ddd_DisposicionDatosDetalle>) this.LocalInfo.GetData("listaSustancias");
      ddd_DisposicionDatosDetalle entity = data[int.Parse(this.gridProductosSustanciasSao.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString())];
      this.MyDataContext.ddd_DisposicionDatosDetalles.DeleteOnSubmit(entity);
      data.Remove(entity);
      this.LocalInfo.SetData("listaSustancias", (object) data);
      this.ActualizaGrilla();
    }

    protected void buttonBuscarTercero_Click(object sender, EventArgs e)
    {
      this.GridViewTerceroBuscar.Visible = true;
      this.productoRegistrarDataSource.SelectParameters["nit"].DefaultValue = this.textNitBusqueda.Text != "" ? this.textNit.Text : "%";
      this.productoRegistrarDataSource.SelectParameters["nombre"].DefaultValue = this.textRazonSocialBusqueda.Text != "" ? this.textRazonSocialBusqueda.Text : "%";
    }

    protected void buttonAdicionarTercero_Click(object sender, EventArgs e)
    {
      this.PanelBuscarTercero.Visible = false;
      this.panelDatosTercero.Visible = true;
      this.divDisposicionfinal.Visible = true;
      this.panelDatosTercero.Enabled = true;
    }

    protected void GridViewTerceroBuscar_RowCommand(object sender, GridViewCommandEventArgs e)
    {
      if (!e.CommandName.Equals("Seleccionar"))
        return;
      ter_Tercero byKey = CLinq.FindByKey<ter_Tercero>((DataContext) this.MyDataContext, (object) int.Parse(this.GridViewTerceroBuscar.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString()));
      this.LocalInfo.SetData("tercero", (object) byKey);
      this.PanelBuscarTercero.Visible = false;
      this.panelDatosTercero.Visible = true;
      this.divDisposicionfinal.Visible = true;
      this.panelDatosTercero.Enabled = false;
      this.textRazonsocial.Text = byKey.ter_NombreCompleto;
      this.textNit.Text = byKey.ter_NumeroDocumento;
      this.textDireccion.Text = byKey.ter_Direccion;
      this.textTelefono.Text = byKey.ter_Tefono;
      this.textEmail.Text = byKey.ter_Correo;
      this.comboRegional.SelectedValue = byKey.reg_Id.ToString();
      this.comboDepartamentoTercero.SelectedValue = byKey.dep_Id;
      this.comboCiudadTercero.SelectedValue = byKey.mun_Id;
    }

    protected void buttonAgregar_Click(object sender, EventArgs e)
    {
      this.panelAddProductosdisposicion.Visible = true;
      this.LocalInfo.SetData("idDetalle", (object) -1);
    }

    protected void buttonEnviarProducto_Click(object sender, EventArgs e)
    {
      try
      {
        this.ControlError1.Visible = false;
        this.ValidaDetalle();
        this.divProductosGrilla.Visible = true;
        this.panelAddProductosdisposicion.Visible = false;
        int data1 = (int) this.LocalInfo.GetData("idDetalle");
        EntitySet<ddd_DisposicionDatosDetalle> data2 = (EntitySet<ddd_DisposicionDatosDetalle>) this.LocalInfo.GetData("listaSustancias");
        if (data1 == -1)
        {
          ddd_DisposicionDatosDetalle entity = new ddd_DisposicionDatosDetalle();
          entity.ddd_Cantidad = Decimal.Parse(this.textCantidadMaestro.Text);
          entity.ddd_Creado = this.textFechaRegistro.Text == "" ? DateTime.Now : DateTime.Parse(this.textFechaRegistro.Text);
          entity.ddd_Modificado = DateTime.Now;
          entity.ddd_Observaciones = this.textObservaciones.Text.ToUpper();
          entity.ddd_Usuario = this.Usuario.login;
          entity.des_Id = int.Parse(this.comboestado.SelectedValue);
          entity.dfd_DisposicionFinalDato = (dfd_DisposicionFinalDato) this.LocalInfo.MyParams;
          entity.psu_Id = int.Parse(this.comboPresentacion.SelectedValue);
          entity.sus_Id = int.Parse(this.comboSustancia.SelectedValue);
          this.MyDataContext.ddd_DisposicionDatosDetalles.InsertOnSubmit(entity);
          data2.Add(entity);
        }
        else
        {
          data2[data1].ddd_Cantidad = Decimal.Parse(this.textCantidadMaestro.Text);
          data2[data1].ddd_Creado = this.textFechaRegistro.Text == "" ? DateTime.Now : DateTime.Parse(this.textFechaRegistro.Text);
          data2[data1].ddd_Modificado = DateTime.Now;
          data2[data1].ddd_Observaciones = this.textObservaciones.Text.ToUpper();
          data2[data1].ddd_Usuario = "";
          data2[data1].des_Id = int.Parse(this.comboestado.SelectedValue);
          data2[data1].psu_Id = int.Parse(this.comboPresentacion.SelectedValue);
          data2[data1].sus_Id = int.Parse(this.comboSustancia.SelectedValue);
        }
        this.LocalInfo.SetData("listaSustancias", (object) data2);
        this.ActualizaGrilla();
      }
      catch (Exception ex)
      {
        this.ControlError1.Visible = true;
        this.ControlError1.Show(ex);
      }
    }

    private void ValidaDetalle()
    {
      string errStr = "";
      double number = 0.0;
      bool flag = true & CValidator.isNumeric(this.textCantidadMaestro.Text, ref number, "La cantidad debe ser un número. <br />", ref errStr);
      if (this.textFechaRegistro.Text != "")
      {
        try
        {
          DateTime.Parse(this.textFechaRegistro.Text);
        }
        catch
        {
          errStr += "La fecha de registro debe estar en un formato válido. <br />";
          flag = false;
        }
      }
      if (this.comboSustancia.SelectedValue == "")
      {
        errStr += "Se debe seleccionar la sustancia. <br />";
        flag = false;
      }
      if (this.comboestado.SelectedValue == "")
      {
        errStr += "Se debe seleccionar el estado de la sustancia. <br />";
        flag = false;
      }
      if (this.comboPresentacion.SelectedValue == "")
      {
        errStr += "Se debe seleccionar la presentación de la sustancia. <br />";
        flag = false;
      }
      if (!flag)
        throw new Exception(errStr);
    }

    protected void buttonCancelarProducto_Click(object sender, EventArgs e) => this.panelAddProductosdisposicion.Visible = false;

    protected void gridActualizacion_RowCommand(object sender, GridViewCommandEventArgs e)
    {
    }

    protected void buttonAdicionarActualizacion_Click(object sender, EventArgs e)
    {
    }

    protected void buttonAdicionarActualizacion_Click1(object sender, EventArgs e)
    {
    }

    protected void buttonEnviarActualizacion_Click(object sender, EventArgs e)
    {
    }

    protected void comboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.comboCiudad.DataSource = (object) CLinq.ListByProperty<mun_Municipio>((DataContext) this.MyDataContext, "dep_id", (object) this.comboDepartamento.SelectedValue);
      this.comboCiudad.DataBind();
      this.comboCiudad.Items.Insert(0, "");
    }

    protected void comboDepartamentoTercero_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.comboCiudadTercero.DataSource = (object) CLinq.ListByProperty<mun_Municipio>((DataContext) this.MyDataContext, "dep_id", (object) this.comboDepartamentoTercero.SelectedValue);
      this.comboCiudadTercero.DataBind();
      this.comboCiudadTercero.Items.Insert(0, "");
    }

    protected void buttonGuardar_Click(object sender, EventArgs e)
    {
      try
      {
        this.ControlError1.Visible = false;
        this.ValidarTercero();
        this.Validar();
        int data1 = (int) this.LocalInfo.GetData("idSustancia");
        dfd_DisposicionFinalDato myParams = (dfd_DisposicionFinalDato) this.LocalInfo.MyParams;
        ter_Tercero data2 = (ter_Tercero) this.LocalInfo.GetData("tercero");
        EntitySet<ddd_DisposicionDatosDetalle> data3 = (EntitySet<ddd_DisposicionDatosDetalle>) this.LocalInfo.GetData("listaSustancias");
        if (data2.ter_Id == 0)
        {
          data2.ter_NombreCompleto = this.textRazonsocial.Text.ToUpper();
          data2.ter_Direccion = this.textDireccion.Text.ToUpper();
          data2.ter_Tefono = this.textTelefono.Text.ToUpper();
          data2.ter_Correo = this.textEmail.Text.ToUpper();
          data2.reg_Id = new int?(this.comboRegional.SelectedValue != "" ? int.Parse(this.comboRegional.SelectedValue) : 0);
          data2.dep_Id = this.comboDepartamentoTercero.SelectedValue;
          data2.mun_Id = this.comboCiudadTercero.SelectedValue;
          ttt_TerceroTipoTercero entity = new ttt_TerceroTipoTercero();
          entity.tti_Id = 4;
          data2.bti_Id = 2;
          if (this.comboTipoDocumento.SelectedValue != "")
          {
            if (this.comboTipoDocumento.SelectedValue != "0")
            {
              data2.dti_Id = int.Parse(this.comboTipoDocumento.SelectedValue);
              data2.ter_NumeroDocumento = this.textNit.Text.ToUpper();
            }
            else
            {
              data2.dti_Id = 0;
              data2.ter_NumeroDocumento = "";
            }
          }
          else
          {
            data2.dti_Id = 0;
            data2.ter_NumeroDocumento = "";
          }
          entity.ter_Tercero = data2;
          this.MyDataContext.ter_Terceros.InsertOnSubmit(data2);
          this.MyDataContext.ttt_TerceroTipoTerceros.InsertOnSubmit(entity);
        }
        myParams.dfd_Fecha = DateTime.Parse(this.textFecha.Text);
        myParams.dfd_Usuario = this.Usuario.login;
        myParams.dfd_Modificado = DateTime.Now;
        myParams.dep_Id = this.comboDepartamento.SelectedValue;
        myParams.mun_Id = this.comboCiudad.SelectedValue;
        if (myParams.dfd_Id == 0)
        {
          myParams.dfd_Creado = DateTime.Now;
          myParams.ter_Tercero = data2;
          this.MyDataContext.dfd_DisposicionFinalDatos.InsertOnSubmit(myParams);
        }
        this.MyDataContext.SubmitChanges();
        if ((int) this.LocalInfo.GetData("idSustancia") == 0)
          CAuditoria.log(EPermiso.AdicionarSustanciasDisposicionFinal, myParams.dfd_Id.ToString(), myParams.ter_Tercero.ter_NumeroDocumento, myParams.dfd_Fecha.ToShortDateString(), "", "", this.Usuario.id);
        else
          CAuditoria.log(EPermiso.ModificarSustanciaDisposicionFinal, myParams.dfd_Id.ToString(), myParams.ter_Tercero.ter_NumeroDocumento, myParams.dfd_Fecha.ToShortDateString(), "", "", this.Usuario.id);
        this.Response.Redirect("~/DisposicionFinal/ProductosBuscar.aspx");
      }
      catch (Exception ex)
      {
        this.ControlError1.Visible = true;
        this.ControlError1.Show(ex);
      }
    }

    private void ValidarTercero()
    {
      string str = "";
      ter_Tercero data = (ter_Tercero) this.LocalInfo.GetData("tercero");
      bool flag = true;
      List<ter_Tercero> terTerceroList = CLinq.ListByProperties<ter_Tercero>((DataContext) this.MyDataContext, (object) "ter_NombreCompleto", (object) this.textRazonsocial.Text.ToUpper(), (object) "mun_Id", (object) this.comboCiudad.SelectedValue);
      if (terTerceroList.Count > 0)
      {
        for (int index = 0; index < terTerceroList.Count; ++index)
        {
          if (data.ter_Id != terTerceroList[index].ter_Id && terTerceroList[index].ter_NumeroDocumento.ToUpper() == this.textNit.Text.ToUpper())
            throw new Exception("El tercero ya se encuentra registrado");
        }
      }
      if (this.textRazonsocial.Text == "")
      {
        str += "Se debe digitar la razón social de la empresa. <br />";
        flag = false;
      }
      if (this.comboDepartamentoTercero.SelectedValue == "")
      {
        str += "Se debe seleccionar el departamento de la empresa. <br />";
        flag = false;
      }
      if (this.comboCiudadTercero.SelectedValue == "")
      {
        str += "Se debe seleccionar la ciudad de la empresa. <br />";
        flag = false;
      }
      if (!flag)
        throw new Exception(str + "Se puede seleccionar una empresa con el botón \"Buscar empresa\". <br />" + "Se puede adicionar una empresa con el botón \"Adicionar empresa\". <br />");
    }

    private void Validar()
    {
      string message = "";
      bool flag = true;
      if (this.textFecha.Text == "")
      {
        message += "Se debe seleccionar una fecha. <br />";
        flag = false;
      }
      else
      {
        try
        {
          DateTime.Parse(this.textFecha.Text);
        }
        catch
        {
          message += "Se debe ingresar una fecha válida. <br />";
          flag = false;
        }
        if (flag && this.textFecha.Text != "" && DateTime.Parse(this.textFecha.Text) > DateTime.Today)
        {
          message += "La fecha del informe no puede ser futura. <br />";
          flag = false;
        }
      }
      if (this.comboDepartamento.Text == "")
      {
        message += "Se debe seleccionar el departamento del informe. <br />";
        flag = false;
      }
      if (this.comboCiudad.Text == "")
      {
        message += "Se debe seleccionar la ciudad del informe. <br />";
        flag = false;
      }
      if (!flag)
        throw new Exception(message);
    }

    public void ActualizaGrilla()
    {
      List<ProductosRegistrar.strDisposicion> strDisposicionList = new List<ProductosRegistrar.strDisposicion>();
      EntitySet<ddd_DisposicionDatosDetalle> data = (EntitySet<ddd_DisposicionDatosDetalle>) this.LocalInfo.GetData("listaSustancias");
      for (int index = 0; index < data.Count; ++index)
        strDisposicionList.Add(new ProductosRegistrar.strDisposicion()
        {
          id = index,
          cantidad = data[index].ddd_Cantidad,
          estado = CLinq.FindByKey<des_DisposicionEstado>((DataContext) this.MyDataContext, (object) data[index].des_Id).des_Descripcion,
          observaciones = data[index].ddd_Observaciones,
          presentacion = CLinq.FindByKey<psu_PresentacionSustancia>((DataContext) this.MyDataContext, (object) data[index].psu_Id).psu_Descripcion,
          sustancia = CLinq.FindByKey<sus_Sustancia>((DataContext) this.MyDataContext, (object) data[index].sus_Id).sus_Descripcion
        });
      this.gridProductosSustanciasSao.DataSource = (object) strDisposicionList;
      this.gridProductosSustanciasSao.DataBind();
    }

    protected void comboTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.comboTipoDocumento.SelectedValue == "0")
      {
        this.textNit.Text = "";
        this.textNit.ReadOnly = true;
      }
      else
        this.textNit.ReadOnly = false;
    }

    public class strDisposicion
    {
      private string _sustancia;
      private string _presentacion;
      private string _estado;
      private string _observaciones;
      private Decimal _cantidad;
      private int _id;

      public string sustancia
      {
        get => this._sustancia;
        set => this._sustancia = value;
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

      public string observaciones
      {
        get => this._observaciones;
        set => this._observaciones = value;
      }

      public int id
      {
        get => this._id;
        set => this._id = value;
      }

      public Decimal cantidad
      {
        get => this._cantidad;
        set => this._cantidad = value;
      }
    }
  }
}
