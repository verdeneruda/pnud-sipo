// Decompiled with JetBrains decompiler
// Type: UTO.Comercializacion.Encuestaregistro
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
using UTO;
using UTO.Comercializacion;


public partial class Comercializacion_Encuestaregistro : BaseModulo
  {
    //protected ToolkitScriptManager ToolkitScriptManager1;
    //protected Label labelAdicionarEncuesta;
    //protected ControlError ControlError1;
    //protected Label labelDatosGenerales;
    //protected Panel PanelBuscarTercero;
    //protected Label labelBuscarEmpresa;
    //protected Label labelRazonSocialBusqueda;
    //protected TextBox textRazonSocialBusqueda;
    //protected Label labelNitBusqueda;
    //protected TextBox textNitBusqueda;
    //protected Button buttonBuscarTercero;
    //protected Button buttonAdicionarTercero;
    //protected GridView gridTerceroBuscar;
    //protected SqlDataSource encuestaRegistroDataSourceBuscarEmpresa;
    //protected Panel panelDatosVisita;
    //protected Label labelfecha;
    //protected TextBox textFecha;
    //protected CalendarExtender calendarFecha;
    //protected Label label1;
    //protected TextBox textContacto;
    //protected Label labelDepartamentoEncuesta;
    //protected Label Label4;
    //protected DropDownList comboDepartamentoEncuesta;
    //protected Label labelCiudadEncuesta;
    //protected Label Label5;
    //protected UpdatePanel updateCiudadEncuesta;
    //protected DropDownList comboCiudadEncuesta;
    //protected TextBox textDirEncuesta;
    //protected Label Label12;
    //protected TextBox textTelEncuesta;
    //protected Panel PanelAdicionarEncuesta;
    //protected Label labelDatosEmpresa;
    //protected Label labelRazonSocial;
    //protected Label Label6;
    //protected TextBox textRazonsocial;
    //protected Label labelNit;
    //protected Label Label7;
    //protected TextBox textNit;
    //protected Label labelTelefono;
    //protected TextBox textTelefono;
    //protected Label labelEmail;
    //protected TextBox textEmail;
    //protected Label labelDireccion;
    //protected TextBox textDireccion;
    //protected Label labelRegional;
    //protected DropDownList comboRegional;
    //protected Label labelDepartamento;
    //protected Label Label8;
    //protected UpdatePanel updateDepartamento;
    //protected DropDownList comboDepartamento;
    //protected Label labelCiudad;
    //protected Label Label9;
    //protected UpdatePanel updateCiudad;
    //protected DropDownList comboCiudad;
    //protected HtmlGenericControl divProveedorAgregar;
    //protected LinkButton LinkProveedores;
    //protected ImageButton imageProveedores;
    //protected CollapsiblePanelExtender colapsibleProveedores;
    //protected Panel panelAddProveedores;
    //protected Button buttonAddProveedores;
    //protected GridView gridProveedor;
    //protected HtmlGenericControl divSustanciasAgregar;
    //protected LinkButton linkSustancias;
    //protected ImageButton imageSustancias;
    //protected CollapsiblePanelExtender colapsibleSustancias;
    //protected Panel panelSustancias;
    //protected Button buttonAddSustancias;
    //protected GridView gridSustancias;
    //protected Panel panelGuardar;
    //protected Button buttonGuardar;
    //protected Button buttonCancelar;
    //protected ModalPopupExtender modalAddSustancias;
    //protected Panel panelAddSustanciasM;
    //protected Label label2;
    //protected ControlError ControlError2;
    //protected Label label10;
    //protected Label Label13;
    //protected DropDownList comboFabricante;
    //protected Label label11;
    //protected Label Label14;
    //protected DropDownList comboSustancia;
    //protected Label labelPresentacion;
    //protected Label Label15;
    //protected DropDownList comboPresentacion;
    //protected Label labelMarca;
    //protected Label Label16;
    //protected DropDownList combomarca;
    //protected Label labelPrecio;
    //protected TextBox textprecio;
    //protected Label labelObservaciones;
    //protected TextBox textObservaciones;
    //protected Button buttonGuardarSustanciaM;
    //protected Button buttonCancelarSustanciaM;
    //protected ModalPopupExtender modalAddProveedores;
    //protected Panel panelAddProveedoresM;
    //protected DropDownList comboProveedor;
    //protected Button buttonEnviarProveedoresM;
    //protected Button buttonCancelarProveedoresM;

    protected new void Page_Load(object sender, EventArgs e)
    {
      this.buttonGuardar.Enabled = this.Usuario.permiteOperacion(EPermiso.ModificarDatosDeComercializacion) || this.Usuario.permiteOperacion(EPermiso.AdicionarDatosDeComercializacion);
      this.ControlError1.Visible = false;
      this.ControlError2.Visible = false;
      if (this.Session["entrada"] == (object) "Modificar")
        this.panelGuardar.Visible = true;
      this.Session.Remove("Entrada");
      if (this.IsPostBack)
        return;
      this.InitData();
    }

    private void InitData()
    {
      this.comboDepartamentoEncuesta.DataSource = (object) CLinq.ListAll<dep_Departamento>((DataContext) this.MyDataContext);
      this.comboDepartamentoEncuesta.DataBind();
      this.comboDepartamentoEncuesta.Items.Insert(0, "");
      this.comboDepartamento.DataSource = (object) CLinq.ListAll<dep_Departamento>((DataContext) this.MyDataContext);
      this.comboDepartamento.DataBind();
      this.comboDepartamento.Items.Insert(0, "");
      this.comboRegional.DataSource = (object) CLinq.ListAll<reg_Regional>((DataContext) this.MyDataContext);
      this.comboRegional.DataBind();
      this.comboRegional.Items.Insert(0, "");
      List<ttt_TerceroTipoTercero> terceroTipoTerceroList1 = CLinq.ListByProperty<ttt_TerceroTipoTercero>((DataContext) this.MyDataContext, "tti_Id", (object) 8);
      List<ter_Tercero> terTerceroList1 = new List<ter_Tercero>();
      for (int index = 0; index < terceroTipoTerceroList1.Count; ++index)
        terTerceroList1.Add(terceroTipoTerceroList1[index].ter_Tercero);
      this.comboFabricante.DataSource = (object) terTerceroList1;
      this.comboFabricante.DataBind();
      this.comboFabricante.Items.Insert(0, "");
      this.comboSustancia.DataSource = (object) CLinq.ListAll<sus_Sustancia>((DataContext) this.MyDataContext);
      this.comboSustancia.DataBind();
      this.comboSustancia.Items.Insert(0, "");
      this.comboPresentacion.DataSource = (object) CLinq.ListAll<psu_PresentacionSustancia>((DataContext) this.MyDataContext);
      this.comboPresentacion.DataBind();
      this.comboPresentacion.Items.Insert(0, "");
      this.combomarca.DataSource = (object) CLinq.ListAll<mar_Marca>((DataContext) this.MyDataContext);
      this.combomarca.DataBind();
      this.combomarca.Items.Insert(0, "");
      List<ttt_TerceroTipoTercero> terceroTipoTerceroList2 = CLinq.ListByProperty<ttt_TerceroTipoTercero>((DataContext) this.MyDataContext, "tti_Id", (object) 7);
      List<ter_Tercero> terTerceroList2 = new List<ter_Tercero>();
      for (int index = 0; index < terceroTipoTerceroList2.Count; ++index)
        terTerceroList2.Add(terceroTipoTerceroList2[index].ter_Tercero);
      this.comboProveedor.DataSource = (object) terTerceroList2;
      this.comboProveedor.DataBind();
      this.comboProveedor.Items.Insert(0, "");
      this.textFecha.Text = DateTime.Today.ToShortDateString();
      this.LocalInfo.SetData("idComercio", (object) ((BaseModulo.strSendParam) this.LocalInfo.MyParams).id);
      this.LocalInfo.SetData("tipoDetalle", (object) "Nuevo");
      if (((BaseModulo.strSendParam) this.LocalInfo.MyParams).id != 0)
      {
        BaseModulo.strSendParam myParams = (BaseModulo.strSendParam) this.LocalInfo.MyParams;
        if (myParams.tipo == "Ver")
        {
          this.panelAddProveedores.Enabled = false;
          this.panelSustancias.Enabled = false;
          this.panelDatosVisita.Enabled = false;
          this.buttonGuardar.Enabled = false;
          this.colapsibleSustancias.Collapsed = false;
          this.gridSustancias.Enabled = false;
          this.gridProveedor.Enabled = false;
          this.buttonCancelar.Enabled = true;
        }
        this.Session["modo"] = (object) "Modificar";
        myParams = (BaseModulo.strSendParam) this.LocalInfo.MyParams;
        this.mostrarDatos(myParams.id);
      }
      else
      {
        this.Session["modo"] = (object) "Adicionar";
        this.LocalInfo.MyParams = (object) new cda_ComercializacionDato();
        this.LocalInfo.SetData("listaSustancias", (object) new EntitySet<cdd_ComercializacionDatosDetalle>());
        this.LocalInfo.SetData("listaProveedor", (object) new List<cpr_ComercializacionProveedor>());
      }
    }

    private void mostrarDatos(int idComercio)
    {
      cda_ComercializacionDato byKey = CLinq.FindByKey<cda_ComercializacionDato>((DataContext) this.MyDataContext, (object) idComercio);
      List<cpr_ComercializacionProveedor> comercializacionProveedorList = CLinq.ListByProperty<cpr_ComercializacionProveedor>((DataContext) this.MyDataContext, "cda_Id", (object) byKey.cda_Id);
      ter_Tercero terTercero = byKey.ter_Tercero;
      this.LocalInfo.SetData("listaSustancias", (object) byKey.cdd_ComercializacionDatosDetalles);
      this.LocalInfo.SetData("listaProveedor", (object) comercializacionProveedorList);
      this.PanelBuscarTercero.Visible = false;
      this.PanelAdicionarEncuesta.Enabled = true;
      this.PanelAdicionarEncuesta.Visible = true;
      this.panelDatosVisita.Visible = true;
      this.divSustanciasAgregar.Visible = true;
      this.panelAddProveedores.Visible = true;
      this.textRazonsocial.Text = terTercero.ter_NombreCompleto;
      this.textNit.Text = terTercero.ter_NumeroDocumento;
      this.textDireccion.Text = terTercero.ter_Direccion;
      this.textTelefono.Text = terTercero.ter_Tefono;
      this.textEmail.Text = terTercero.ter_Correo;
      this.LocalInfo.SetData("tercero", (object) terTercero);
      this.comboDepartamentoEncuesta.Items.FindByValue(byKey.dep_Id).Selected = true;
      this.LoadCiudadEncuestaxDepto(byKey.dep_Id);
      this.comboCiudadEncuesta.Items.FindByValue(byKey.mun_Id).Selected = true;
      this.comboRegional.Items.FindByValue(terTercero.reg_Id.ToString()).Selected = true;
      int? regId;
      int num;
      if (terTercero.reg_Id.HasValue)
      {
        regId = terTercero.reg_Id;
        num = (regId.GetValueOrDefault() != 0 ? 0 : (regId.HasValue ? 1 : 0)) == 0 ? 1 : 0;
      }
      else
        num = 0;
      if (num == 0)
      {
        this.LoadDepartamento();
      }
      else
      {
        regId = terTercero.reg_Id;
        this.LoadDeptoxRegional(regId.Value);
      }
      this.comboDepartamento.Items.FindByValue(terTercero.dep_Id).Selected = true;
      this.LoadCiudadxDepto(terTercero.dep_Id);
      this.comboCiudad.Items.FindByValue(terTercero.mun_Id).Selected = true;
      this.textContacto.Text = byKey.cda_Contacto;
      this.textFecha.Text = byKey.cda_Fecha.ToShortDateString();
      this.textDirEncuesta.Text = byKey.cda_Direccion;
      this.textTelEncuesta.Text = byKey.cda_Telefono;
      this.LocalInfo.MyParams = (object) byKey;
      this.LocalInfo.SetData("listaSustancias", (object) byKey.cdd_ComercializacionDatosDetalles);
      this.ActualizaGrilla();
      this.ActualizaGrillaproveedor();
    }

    protected void buttoncancelar_Click(object sender, EventArgs e) { this.Response.Redirect("~/Comercializacion/EncuestaBuscar.aspx"); }

    protected void gridSustancias_RowCommand(object sender, GridViewCommandEventArgs e)
    {
      if (e.CommandName.Equals("Editar"))
      {
        this.LocalInfo.SetData("tipoDetalle", (object) "Editar");
        cdd_ComercializacionDatosDetalle byKey = CLinq.FindByKey<cdd_ComercializacionDatosDetalle>((DataContext) this.MyDataContext, (object) int.Parse(this.gridSustancias.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString()));
        this.comboFabricante.SelectedValue = byKey.ter_Tercero.ter_Id.ToString();
        this.comboSustancia.SelectedValue = byKey.sus_Sustancia.sus_Id.ToString();
        this.comboPresentacion.SelectedValue = byKey.psu_PresentacionSustancia.psu_Id.ToString();
        this.combomarca.SelectedValue = byKey.mar_Marca.mar_Id.ToString();
        this.textprecio.Text = byKey.cdd_Precio.ToString();
        this.textObservaciones.Text = byKey.cdd_Observaciones.ToString();
        this.LocalInfo.SetData("detalleId", (object) byKey.cdd_Id);
      }
      if (!e.CommandName.Equals("Eliminar"))
        return;
      EntitySet<cdd_ComercializacionDatosDetalle> data = (EntitySet<cdd_ComercializacionDatosDetalle>) this.LocalInfo.GetData("listaSustancias");
      cdd_ComercializacionDatosDetalle entity = data[int.Parse(this.gridSustancias.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString())];
      this.MyDataContext.cdd_ComercializacionDatosDetalles.DeleteOnSubmit(entity);
      data.Remove(entity);
      this.LocalInfo.SetData("listaSustancias", (object) data);
      this.ActualizaGrilla();
    }

    protected void buttonAdicionarTercero_Click(object sender, EventArgs e)
    {
    }

    protected void GridViewTerceroBuscar_RowCommand(object sender, GridViewCommandEventArgs e)
    {
      if (!(e.CommandName == "Seleccionar"))
        return;
      ter_Tercero byKey = CLinq.FindByKey<ter_Tercero>((DataContext) this.MyDataContext, (object) int.Parse(this.gridTerceroBuscar.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString()));
      this.LocalInfo.SetData("tercero", (object) byKey);
      this.PanelBuscarTercero.Visible = false;
      this.PanelAdicionarEncuesta.Enabled = false;
      this.PanelAdicionarEncuesta.Visible = true;
      this.panelDatosVisita.Visible = true;
      this.panelAddProveedores.Visible = true;
      this.divSustanciasAgregar.Visible = true;
      this.textRazonsocial.Text = byKey.ter_NombreCompleto;
      this.textNit.Text = byKey.ter_NumeroDocumento;
      this.textDireccion.Text = byKey.ter_Direccion;
      this.textTelefono.Text = byKey.ter_Tefono;
      this.textEmail.Text = byKey.ter_Correo;
      this.comboRegional.SelectedValue = byKey.reg_Id.ToString();
      this.comboDepartamento.SelectedValue = byKey.dep_Id;
      this.LoadCiudadxDepto(byKey.dep_Id);
      this.comboCiudad.SelectedValue = byKey.mun_Id;
      this.panelGuardar.Visible = true;
      this.comboRegional.Enabled = true;
      this.comboDepartamento.Enabled = true;
      this.comboCiudad.Enabled = true;
    }

    protected void buttonBuscarTercero_Click(object sender, EventArgs e)
    {
      this.gridTerceroBuscar.Visible = true;
      this.encuestaRegistroDataSourceBuscarEmpresa.SelectParameters["nit"].DefaultValue = this.textNitBusqueda.Text != "" ? this.textNitBusqueda.Text : "%";
      this.encuestaRegistroDataSourceBuscarEmpresa.SelectParameters["nombre"].DefaultValue = this.textRazonSocialBusqueda.Text != "" ? this.textRazonSocialBusqueda.Text : "%";
    }

    protected void buttonCancelarSustancia_Click(object sender, EventArgs e)
    {
    }

    protected void buttonEnviarSustancia_Click(object sender, EventArgs e)
    {
    }

    protected void GuardarSustanciaM(object sender, EventArgs e)
    {
      EntitySet<cdd_ComercializacionDatosDetalle> data = (EntitySet<cdd_ComercializacionDatosDetalle>) this.LocalInfo.GetData("listaSustancias");
      cdd_ComercializacionDatosDetalle entity = new cdd_ComercializacionDatosDetalle();
      if ((string) this.LocalInfo.GetData("tipoDetalle") == "Nuevo")
      {
        try
        {
          this.ValidaDetalle();
          entity.cdd_Creado = DateTime.Now;
          entity.cdd_Modificado = DateTime.Now;
          entity.cdd_Observaciones = this.textObservaciones.Text;
          entity.cdd_Precio = Decimal.Parse(this.textprecio.Text);
          entity.cdd_Usuario = "";
          entity.mar_Id = int.Parse(this.combomarca.SelectedValue);
          entity.psu_Id = int.Parse(this.comboPresentacion.SelectedValue);
          entity.sus_Id = int.Parse(this.comboSustancia.SelectedValue);
          entity.ter_IdFabricante = int.Parse(this.comboFabricante.SelectedValue);
          entity.cda_ComercializacionDato = (cda_ComercializacionDato) this.LocalInfo.MyParams;
          this.MyDataContext.cdd_ComercializacionDatosDetalles.InsertOnSubmit(entity);
          data.Add(entity);
          this.LocalInfo.SetData("listaSustancias", (object) data);
          this.ActualizaGrilla();
          this.combomarca.SelectedIndex = -1;
          this.comboPresentacion.SelectedIndex = -1;
          this.comboSustancia.SelectedIndex = -1;
          this.comboFabricante.SelectedIndex = -1;
          this.textObservaciones.Text = "";
          this.textprecio.Text = "";
        }
        catch (Exception ex)
        {
          this.ControlError2.Visible = true;
          this.ControlError2.Show(ex);
        }
      }
      if (!((string) this.LocalInfo.GetData("tipoDetalle") == "Editar"))
        return;
      try
      {
        this.ValidaDetalle();
        cdd_ComercializacionDatosDetalle byKey = CLinq.FindByKey<cdd_ComercializacionDatosDetalle>((DataContext) this.MyDataContext, (object) (int) this.LocalInfo.GetData("detalleId"));
        byKey.cdd_Modificado = DateTime.Now;
        byKey.cdd_Observaciones = this.textObservaciones.Text;
        byKey.cdd_Precio = Decimal.Parse(this.textprecio.Text);
        byKey.cdd_Usuario = "";
        byKey.mar_Id = int.Parse(this.combomarca.SelectedValue);
        byKey.psu_Id = int.Parse(this.comboPresentacion.SelectedValue);
        byKey.sus_Id = int.Parse(this.comboSustancia.SelectedValue);
        byKey.ter_IdFabricante = int.Parse(this.comboFabricante.SelectedValue);
        this.MyDataContext.SubmitChanges();
        this.combomarca.SelectedIndex = -1;
        this.comboPresentacion.SelectedIndex = -1;
        this.comboSustancia.SelectedIndex = -1;
        this.comboFabricante.SelectedIndex = -1;
        this.textObservaciones.Text = "";
        this.textprecio.Text = "";
      }
      catch (Exception ex)
      {
        this.ControlError2.Visible = true;
        this.ControlError2.Show(ex);
      }
    }

    private void ValidaDetalle()
    {
      string errStr = "";
      bool flag1 = true;
      double number = 0.0;
      bool flag2 = flag1 & CValidator.isNumeric(this.textprecio.Text, ref number, "El precio debe ser un número. <br />", ref errStr);
      if (this.comboSustancia.SelectedValue == "")
      {
        errStr += "Seleccionar la sustancia. <br />";
        flag2 = false;
      }
      if (this.combomarca.SelectedValue == "")
      {
        errStr += "Seleccione la marca de la sustancia. <br />";
        flag2 = false;
      }
      if (this.comboPresentacion.SelectedValue == "")
      {
        errStr += "Seleccione la presentación de la sustancia. <br />";
        flag2 = false;
      }
      if (this.comboFabricante.SelectedValue == "")
      {
        errStr += "Se debe seleccionar el fabricante de la sustancia. <br />";
        flag2 = false;
      }
      if (!flag2)
        throw new Exception(errStr);
    }

    protected void buttonAdicionarTercero_Click1(object sender, EventArgs e)
    {
      this.panelGuardar.Visible = true;
      this.PanelBuscarTercero.Visible = false;
      this.PanelAdicionarEncuesta.Enabled = true;
      this.PanelAdicionarEncuesta.Visible = true;
      this.panelDatosVisita.Visible = true;
      this.divSustanciasAgregar.Visible = true;
      this.textRazonsocial.Enabled = true;
      this.panelAddProveedores.Visible = true;
      this.textNit.Enabled = true;
      this.textDireccion.Enabled = true;
      this.textTelefono.Enabled = true;
      this.textEmail.Enabled = true;
      this.comboRegional.Enabled = true;
      this.comboDepartamento.Enabled = true;
      this.comboCiudad.Enabled = true;
      this.LocalInfo.SetData("tercero", (object) new ter_Tercero());
    }

    protected void buttonAgregar_Click(object sender, EventArgs e) { this.LocalInfo.SetData("tipoDetalle", (object)"Nuevo"); }

    protected void comboDepartamento_SelectedIndexChanged(object sender, EventArgs e) { this.LoadCiudadxDepto(this.comboDepartamento.SelectedValue); }

    protected void buttonGuardar_Click(object sender, EventArgs e)
    {
      try
      {
        this.Validar();
        int data1 = (int) this.LocalInfo.GetData("idComercio");
        cda_ComercializacionDato myParams = (cda_ComercializacionDato) this.LocalInfo.MyParams;
        ter_Tercero data2 = (ter_Tercero) this.LocalInfo.GetData("tercero");
        EntitySet<cdd_ComercializacionDatosDetalle> data3 = (EntitySet<cdd_ComercializacionDatosDetalle>) this.LocalInfo.GetData("listaSustancias");
        if (this.Session["modo"] == (object) "Adicionar")
        {
          List<ter_Tercero> terTerceroList = CLinq.ListByProperties<ter_Tercero>((DataContext) this.MyDataContext, (object) "ter_NumeroDocumento", (object) this.textNit.Text.ToUpper(), (object) "mun_Id", (object) this.comboCiudad.SelectedValue);
          if (terTerceroList.Count > 0)
          {
            for (int index = 0; index < terTerceroList.Count; ++index)
            {
              if (data2.ter_Id != terTerceroList[index].ter_Id && terTerceroList[index].ter_NombreCompleto.ToUpper() == this.textRazonsocial.Text.ToUpper())
                throw new Exception("El tercero ya se encuentra registrado");
            }
          }
        }
        if (data2.ter_Id == 0)
        {
          data2.ter_NombreCompleto = this.textRazonsocial.Text;
          data2.ter_NumeroDocumento = this.textNit.Text;
          data2.ter_Direccion = this.textDireccion.Text;
          data2.ter_Tefono = this.textTelefono.Text;
          data2.ter_Correo = this.textEmail.Text;
          data2.reg_Id = !(this.comboRegional.SelectedValue == "") ? new int?(int.Parse(this.comboRegional.SelectedValue)) : new int?(0);
          data2.dep_Id = this.comboDepartamento.SelectedValue;
          data2.mun_Id = this.comboCiudad.SelectedValue;
          ttt_TerceroTipoTercero entity = new ttt_TerceroTipoTercero();
          entity.tti_Id = 4;
          data2.bti_Id = 2;
          data2.dti_Id = 1;
          entity.ter_Tercero = data2;
          this.MyDataContext.ter_Terceros.InsertOnSubmit(data2);
          this.MyDataContext.ttt_TerceroTipoTerceros.InsertOnSubmit(entity);
        }
        else if (CLinq.ListByProperties<ttt_TerceroTipoTercero>((DataContext) this.MyDataContext, (object) "tti_Id", (object) 4, (object) "ter_Id", (object) data2.ter_Id).Count == 0)
          this.MyDataContext.ttt_TerceroTipoTerceros.InsertOnSubmit(new ttt_TerceroTipoTercero()
          {
            ter_Tercero = data2,
            tti_Id = 4
          });
        myParams.cda_Fecha = DateTime.Parse(this.textFecha.Text);
        myParams.cda_Contacto = this.textContacto.Text;
        myParams.cda_Direccion = this.textDirEncuesta.Text;
        myParams.cda_Telefono = this.textTelEncuesta.Text;
        myParams.cda_Usuario = this.Usuario.login;
        myParams.cda_Modificado = DateTime.Now;
        myParams.dep_Id = this.comboDepartamentoEncuesta.SelectedValue;
        myParams.mun_Id = this.comboCiudadEncuesta.SelectedValue;
        if (myParams.cda_Id == 0)
        {
          myParams.cda_Creado = DateTime.Now;
          myParams.ter_Tercero = data2;
          this.MyDataContext.cda_ComercializacionDatos.InsertOnSubmit(myParams);
        }
        for (int index = 0; index < data3.Count; ++index)
        {
          if (data3[index].cdd_Id == 0)
          {
            data3[index].cda_ComercializacionDato = myParams;
            this.MyDataContext.cdd_ComercializacionDatosDetalles.InsertOnSubmit(data3[index]);
          }
        }
        data2.ter_NombreCompleto = this.textRazonsocial.Text;
        data2.ter_NumeroDocumento = this.textNit.Text;
        data2.ter_Direccion = this.textDireccion.Text;
        data2.ter_Tefono = this.textTelefono.Text;
        data2.ter_Correo = this.textEmail.Text;
        data2.reg_Id = !(this.comboRegional.SelectedValue == "") ? new int?(int.Parse(this.comboRegional.SelectedValue)) : new int?(0);
        data2.dep_Id = this.comboDepartamento.SelectedValue;
        data2.mun_Id = this.comboCiudad.SelectedValue;
        this.MyDataContext.SubmitChanges();
        if ((int) this.LocalInfo.GetData("idComercio") == 0)
          CAuditoria.log(EPermiso.AdicionarDatosDeComercializacion, myParams.cda_Id.ToString(), myParams.ter_Tercero.ter_NumeroDocumento, myParams.ter_Tercero.ter_NombreCompleto, "", "", this.Usuario.id);
        else
          CAuditoria.log(EPermiso.ModificarDatosDeComercializacion, myParams.cda_Id.ToString(), myParams.ter_Tercero.ter_NumeroDocumento, myParams.ter_Tercero.ter_NombreCompleto, "", "", this.Usuario.id);
        this.Session.Remove("modo");
        this.Response.Redirect("~/Comercializacion/EncuestaBuscar.aspx");
      }
      catch (Exception ex)
      {
        this.Session.Remove("modo");
        this.ControlError1.Visible = true;
        this.ControlError1.Show(ex);
      }
    }

    private void Validar()
    {
      string message = "";
      bool flag = true;
      ter_Tercero data1 = (ter_Tercero) this.LocalInfo.GetData("tercero");
      int data2 = (int) this.LocalInfo.GetData("idComercio");
      if (this.textFecha.Text == "")
      {
        message += "Se debe seleccionar una fecha de visita. <br />";
        flag = false;
      }
      if (this.textFecha.Text != "" && DateTime.Parse(this.textFecha.Text) > DateTime.Today)
      {
        message += "La fecha de la visita no puede ser futura. <br />";
        flag = false;
      }
      if (this.comboDepartamentoEncuesta.Text == "")
      {
        message += "Se debe seleccionar el departamento de la encuesta. <br />";
        flag = false;
      }
      if (this.comboCiudadEncuesta.Text == "")
      {
        message += "Se debe seleccionar la ciudad de la encuesta. <br />";
        flag = false;
      }
      if (data2 == 0 && data1.ter_Id == 0)
      {
        if (!CValidaEspeciales.VRequerido(this.textRazonsocial.Text))
        {
          message += "Escriba la razón social. <br />";
          flag = false;
        }
        if (!CValidaEspeciales.VRequerido(this.textNit.Text))
        {
          message += "Escriba el NIT. <br />";
          flag = false;
        }
        if (!CValidaEspeciales.VRequerido(this.comboDepartamento.SelectedItem.Text))
        {
          message += "Seleccione el departamento. <br />";
          flag = false;
        }
        if (this.comboCiudad.SelectedItem == null || !CValidaEspeciales.VRequerido(this.comboCiudad.SelectedItem.Text))
        {
          message += "Seleccione la ciudad. <br />";
          flag = false;
        }
      }
      if (!flag)
        throw new Exception(message);
    }

    protected void comboDepartamentoEncuesta_SelectedIndexChanged(object sender, EventArgs e) { this.LoadCiudadEncuestaxDepto(this.comboDepartamentoEncuesta.SelectedValue); }

    public void ActualizaGrilla()
    {
      List<Encuestaregistro.strComercio> strComercioList = new List<Encuestaregistro.strComercio>();
      EntitySet<cdd_ComercializacionDatosDetalle> data = (EntitySet<cdd_ComercializacionDatosDetalle>) this.LocalInfo.GetData("listaSustancias");
      for (int index = 0; index < data.Count; ++index)
        strComercioList.Add(new Encuestaregistro.strComercio()
        {
          id = index,
          marca = CLinq.FindByKey<mar_Marca>((DataContext) this.MyDataContext, (object) data[index].mar_Id).mar_Descripcion,
          observaciones = data[index].cdd_Observaciones,
          precio = data[index].cdd_Precio,
          presentacion = CLinq.FindByKey<psu_PresentacionSustancia>((DataContext) this.MyDataContext, (object) data[index].psu_Id).psu_Descripcion,
          sustancia = CLinq.FindByKey<sus_Sustancia>((DataContext) this.MyDataContext, (object) data[index].sus_Id).sus_Descripcion
        });
      this.gridSustancias.DataSource = (object) strComercioList;
      this.gridSustancias.DataBind();
    }

    private void ActualizaGrillaproveedor()
    {
      List<Encuestaregistro.strProveedor> strProveedorList = new List<Encuestaregistro.strProveedor>();
      List<cpr_ComercializacionProveedor> data = (List<cpr_ComercializacionProveedor>) this.LocalInfo.GetData("listaProveedor");
      for (int index = 0; index < data.Count; ++index)
        strProveedorList.Add(new Encuestaregistro.strProveedor()
        {
          id = index,
          empresa = CLinq.FindByKey<ter_Tercero>((DataContext) this.MyDataContext, (object) data[index].ter_Id).ter_NombreCompleto,
          documento = CLinq.FindByKey<ter_Tercero>((DataContext) this.MyDataContext, (object) data[index].ter_Id).ter_NumeroDocumento,
          direccion = CLinq.FindByKey<ter_Tercero>((DataContext) this.MyDataContext, (object) data[index].ter_Id).ter_Direccion,
          telefono = CLinq.FindByKey<ter_Tercero>((DataContext) this.MyDataContext, (object) data[index].ter_Id).ter_Tefono
        });
      this.gridProveedor.DataSource = (object) strProveedorList;
      this.gridProveedor.DataBind();
    }

    protected void gridProveedor_RowCommand(object sender, GridViewCommandEventArgs e)
    {
      int index = int.Parse(this.gridProveedor.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString());
      if (!e.CommandName.Equals("Eliminar"))
        return;
      List<cpr_ComercializacionProveedor> data = (List<cpr_ComercializacionProveedor>) this.LocalInfo.GetData("listaProveedor");
      cpr_ComercializacionProveedor entity = data[index];
      this.MyDataContext.cpr_ComercializacionProveedors.DeleteOnSubmit(entity);
      data.Remove(entity);
      this.LocalInfo.SetData("listaProveedor", (object) data);
      this.ActualizaGrillaproveedor();
    }

    protected void buttonAdicionar_Click(object sender, EventArgs e)
    {
      cda_ComercializacionDato myParams = (cda_ComercializacionDato) this.LocalInfo.MyParams;
      cpr_ComercializacionProveedor entity = new cpr_ComercializacionProveedor();
      int data1 = (int) this.LocalInfo.GetData("idComercio");
      List<cpr_ComercializacionProveedor> data2 = (List<cpr_ComercializacionProveedor>) this.LocalInfo.GetData("listaProveedor");
      entity.ter_Tercero = CLinq.FindByKey<ter_Tercero>((DataContext) this.MyDataContext, (object) int.Parse(this.comboProveedor.SelectedValue));
      entity.cda_ComercializacionDato = myParams;
      this.MyDataContext.cpr_ComercializacionProveedors.InsertOnSubmit(entity);
      data2.Add(entity);
      this.LocalInfo.SetData("listaProveedor", (object) data2);
      this.ActualizaGrillaproveedor();
    }

    private void LoadCiudadEncuestaxDepto(string depto)
    {
      this.comboCiudadEncuesta.DataSource = (object) CLinq.ListByProperty<mun_Municipio>((DataContext) this.MyDataContext, "dep_id", (object) depto);
      this.comboCiudadEncuesta.DataBind();
      this.comboCiudadEncuesta.Items.Insert(0, "");
    }

    protected void SelectRegional(object sender, EventArgs e)
    {
      this.LoadDeptoxRegional(Convert.ToInt32(this.comboRegional.SelectedValue));
      this.LoadCiudadxDepto("00");
      this.updateCiudad.Update();
    }

    private void LoadDeptoxRegional(int regional)
    {
      this.comboDepartamento.DataSource = (object) CLinq.ListByProperty<dep_Departamento>((DataContext) this.MyDataContext, "reg_Id", (object) regional);
      this.comboDepartamento.DataBind();
      this.comboDepartamento.Items.Insert(0, "");
    }

    private void LoadCiudadxDepto(string depto)
    {
      this.comboCiudad.DataSource = (object) CLinq.ListByProperty<mun_Municipio>((DataContext) this.MyDataContext, "dep_id", (object) depto);
      this.comboCiudad.DataBind();
      this.comboCiudad.Items.Insert(0, "");
    }

    private void LoadDepartamento()
    {
      this.comboDepartamento.DataSource = (object) CLinq.ListAll<dep_Departamento>((DataContext) this.MyDataContext);
      this.comboDepartamento.DataBind();
      this.comboDepartamento.Items.Insert(0, "");
    }

    protected void buttonEnviarProveedoresM_Click(object sender, EventArgs e)
    {
      cda_ComercializacionDato myParams = (cda_ComercializacionDato) this.LocalInfo.MyParams;
      cpr_ComercializacionProveedor entity = new cpr_ComercializacionProveedor();
      int data1 = (int) this.LocalInfo.GetData("idComercio");
      List<cpr_ComercializacionProveedor> data2 = (List<cpr_ComercializacionProveedor>) this.LocalInfo.GetData("listaProveedor");
      entity.ter_Tercero = CLinq.FindByKey<ter_Tercero>((DataContext) this.MyDataContext, (object) int.Parse(this.comboProveedor.SelectedValue));
      entity.cda_ComercializacionDato = myParams;
      this.MyDataContext.cpr_ComercializacionProveedors.InsertOnSubmit(entity);
      data2.Add(entity);
      this.LocalInfo.SetData("listaProveedor", (object) data2);
      this.ActualizaGrillaproveedor();
      this.modalAddProveedores.Hide();
    }

    protected void buttonAddProveedores_Click(object sender, EventArgs e)
    {
    }

    public class strComercio
    {
      private string _sustancia;
      private string _presentacion;
      private string _marca;
      private string _observaciones;
      private Decimal _precio;
      private int _id;

      public string sustancia
      {
            get { return this._sustancia; }
            set { this._sustancia = value; }
      }

      public string presentacion
      {
            get { return this._presentacion; }
            set { this._presentacion = value; }
      }

      public string marca
      {
            get { return this._marca; }
            set { this._marca = value; }
      }

      public string observaciones
      {
            get { return this._observaciones; }
            set { this._observaciones = value; }
      }

      public int id
      {
            get { return this._id; }
            set { this._id = value; }
      }

      public Decimal precio
      {
            get { return this._precio; }
            set { this._precio = value; }
      }
    }

    public class strProveedor
    {
      private string _empresa;
      private string _documento;
      private string _direccion;
      private string _telefono;
      private int _id;

      public string empresa
      {
            get { return this._empresa; }
            set { this._empresa = value; }
      }

      public string documento
      {
            get { return this._documento; }
            set { this._documento = value; }
      }

      public string direccion
      {
            get { return this._direccion; }
            set { this._direccion = value; }
      }

      public string telefono
      {
            get { return this._telefono; }
            set { this._telefono = value; }
      }

      public int id
      {
            get { return this._id; }
            set { this._id = value; }
      }
    }
  }

