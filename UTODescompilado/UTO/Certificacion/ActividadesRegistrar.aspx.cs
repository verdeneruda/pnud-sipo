// Decompiled with JetBrains decompiler
// Type: UTO.Certificacion.RegistrarActividades
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
using System.Linq;
using System.Linq.Expressions;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using UTO.Comunes;

namespace UTO.Certificacion
{
  public class RegistrarActividades : BaseModulo
  {
    private CertificacionDataContext terceroDataContext;
    protected ToolkitScriptManager ToolkitScriptManager1;
    protected Label labelRegistarActividades;
    protected ControlError ControlError1;
    protected Label labelDatosGenerales;
    protected Label labelFechaActividad;
    protected TextBox textfecha;
    protected CalendarExtender calendarextender;
    protected Label labelDepartamento;
    protected Label Label4;
    protected DropDownList comboDepartamento;
    protected Label labelCiudad;
    protected Label Label5;
    protected UpdatePanel UpdatePanel1;
    protected DropDownList comboCiudad;
    protected Label labelTipo;
    protected Label Label2;
    protected DropDownList comboTipoActividad;
    protected Label labelActividad;
    protected TextBox textActividad;
    protected Label labelEntidades;
    protected TextBox textEntidades;
    protected Label labelNumeroPersonasimpactadas;
    protected Label labelAsterisco;
    protected TextBox textoNumeroPersonasImpactadas;
    protected UpdatePanel UpdatePanel2;
    protected Panel panelCollPersonas;
    protected Label label3;
    protected Label labelNombreBuscar;
    protected TextBox textNombreBuscar;
    protected Label labelTipoDocumento;
    protected DropDownList comboTipoDocumento;
    protected Label labelNumeroDocumento;
    protected TextBox textNumeroDocumento;
    protected Button buttonBuscarPersona;
    protected Button buttonAdicionar;
    protected Panel PanelTercero;
    protected Label labelDatosEmpresa;
    protected Label labelRazonSocial;
    protected Label label7;
    protected TextBox textRazonsocial;
    protected Label labelNit;
    protected DropDownList comboDocumentoTipo;
    protected Label labelDocumento;
    protected TextBox textDocumento;
    protected Label labelEmail;
    protected TextBox textEmail;
    protected Label labelDireccion;
    protected TextBox textDireccion;
    protected Label labelTeléfono;
    protected TextBox textTelefono;
    protected Button buttonGuardarTercero;
    protected Button buttonCancelarTercero;
    protected HtmlGenericControl divgrillabusqueda;
    protected GridView GridViewPersonaBuscar;
    protected SqlDataSource actividadesRegistrarDataSourcePersonaBuscar;
    protected HtmlTable tablePersonasAgregadas;
    protected Label labelPersonasAgregadas;
    protected GridView GridViewPersonasAdicionadas;
    protected Label label6;
    protected Label label8;
    protected DropDownList comboMaterial;
    protected Label label9;
    protected TextBox textCantidad;
    protected Button buttonAdicionarmaterial;
    protected GridView gridMaterial;
    protected Label label1;
    protected DocumentosVarios DocumentosVarios1;
    protected Button buttonGuardar;
    protected Button buttoncancelar;

    protected void Page_Load(object sender, EventArgs e)
    {
      this.ControlError1.Visible = false;
      if (this.IsPostBack)
        return;
      this.InitData();
    }

    private void InitData()
    {
      this.comboTipoDocumento.DataSource = (object) CLinq.ListAll<dti_DocumentoTipo>((DataContext) this.MyDataContext);
      this.comboTipoDocumento.DataBind();
      this.comboTipoDocumento.Items.Insert(0, "");
      this.comboDocumentoTipo.DataSource = (object) CLinq.ListAll<dti_DocumentoTipo>((DataContext) this.MyDataContext);
      this.comboDocumentoTipo.DataBind();
      this.comboDocumentoTipo.Items.Insert(0, "");
      this.comboDepartamento.DataSource = (object) CLinq.ListAll<dep_Departamento>((DataContext) this.MyDataContext);
      this.comboDepartamento.DataBind();
      this.comboDepartamento.Items.Insert(0, "");
      this.comboTipoActividad.DataSource = (object) CLinq.ListAll<ati_ActividadTipo>((DataContext) this.MyDataContext);
      this.comboTipoActividad.DataBind();
      this.comboTipoActividad.Items.Insert(0, "");
      this.comboMaterial.DataSource = (object) CLinq.ListAll<acm_ActividadMaterial>((DataContext) this.MyDataContext);
      this.comboMaterial.DataBind();
      this.comboMaterial.Items.Insert(0, "");
      this.ControlError1.Visible = false;
      this.LocalInfo.SetData("idActividad", (object) ((BaseModulo.strSendParam) this.LocalInfo.MyParams).id);
      if (((BaseModulo.strSendParam) this.LocalInfo.MyParams).id != 0)
      {
        BaseModulo.strSendParam myParams = (BaseModulo.strSendParam) this.LocalInfo.MyParams;
        if (myParams.tipo == "Ver")
          this.buttonGuardar.Enabled = false;
        myParams = (BaseModulo.strSendParam) this.LocalInfo.MyParams;
        this.mostrarDatos(myParams.id);
      }
      else
      {
        this.LocalInfo.MyParams = (object) new act_Actividad();
        this.LocalInfo.SetData("listaTerceros", (object) new List<ter_Tercero>());
        this.LocalInfo.SetData("listaMaterial", (object) new EntitySet<ame_ActividadmaterialEntregado>());
        this.DocumentosVarios1.Visible = false;
      }
    }

    private void mostrarDatos(int idActividad)
    {
      List<ter_Tercero> terTerceroList = new List<ter_Tercero>();
      DataTable dataTable1 = new DataTable();
      act_Actividad byKey = CLinq.FindByKey<act_Actividad>((DataContext) this.MyDataContext, (object) idActividad);
      this.textfecha.Text = byKey.act_Fecha.ToShortDateString();
      this.textActividad.Text = byKey.act_Actividad1;
      this.textEntidades.Text = byKey.act_EntidadesIvolucradas;
      this.textoNumeroPersonasImpactadas.Text = byKey.act_PersonasImpactadas.ToString();
      this.DocumentosVarios1.Visible = true;
      this.DocumentosVarios1.Init("Cer.ado_ActividadDocumento", "act_id", idActividad.ToString(), this.MyDataContext.Connection.ConnectionString);
      this.tablePersonasAgregadas.Visible = true;
      this.comboDepartamento.SelectedValue = byKey.mun_Municipio.dep_Id;
      this.LoadCiudadxDepto(byKey.mun_Municipio.dep_Id);
      this.comboCiudad.SelectedValue = byKey.mun_Id;
      this.comboTipoActividad.SelectedValue = byKey.ati_Id.ToString();
      this.LocalInfo.MyParams = (object) byKey;
      this.LocalInfo.SetData("listaMaterial", (object) byKey.ame_ActividadmaterialEntregados);
      this.ActualizaGrilla();
      DataTable dataTable2 = CCertificacion.BuscaActividadTercero(byKey.act_Id, this.MyDataContext.Connection.ConnectionString);
      if (dataTable2.Rows.Count > 0)
      {
        for (int index = 0; index < dataTable2.Rows.Count; ++index)
          terTerceroList.Add(CLinq.FindByKey<ter_Tercero>((DataContext) this.MyDataContext, (object) int.Parse(dataTable2.Rows[index][0].ToString())));
        this.GridViewPersonasAdicionadas.DataSource = (object) terTerceroList;
        this.GridViewPersonasAdicionadas.DataBind();
        this.LocalInfo.SetData("listaTerceros", (object) terTerceroList);
      }
      else
        this.LocalInfo.SetData("listaTerceros", (object) new List<ter_Tercero>());
    }

    protected void buttoncancelar_Click(object sender, EventArgs e) => this.Response.Redirect("~/Certificacion/ActividadesBuscar.aspx");

    protected void buttonBuscarPersona_Click(object sender, EventArgs e)
    {
      this.divgrillabusqueda.Visible = true;
      this.actividadesRegistrarDataSourcePersonaBuscar.SelectParameters["documento"].DefaultValue = this.textNumeroDocumento.Text != "" ? this.textNumeroDocumento.Text : "%";
      this.actividadesRegistrarDataSourcePersonaBuscar.SelectParameters["nombre"].DefaultValue = this.textNombreBuscar.Text != "" ? this.textNombreBuscar.Text : "%";
      this.actividadesRegistrarDataSourcePersonaBuscar.SelectParameters["tipoDocumento"].DefaultValue = this.comboTipoDocumento.SelectedValue != "" ? this.comboTipoDocumento.SelectedValue : "0";
      foreach (DataControlField column in (StateManagedCollection) this.GridViewPersonaBuscar.Columns)
      {
        if (column.HeaderText == "Id")
          column.Visible = false;
      }
    }

    protected void GridViewPersonaBuscar_RowCommand(object sender, GridViewCommandEventArgs e)
    {
      bool flag = false;
      if (!e.CommandName.Equals("Seleccionar"))
        return;
      List<ter_Tercero> data = (List<ter_Tercero>) this.LocalInfo.GetData("listaTerceros");
      int keyValue = int.Parse(this.GridViewPersonaBuscar.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString());
      for (int index = 0; index < data.Count; ++index)
      {
        if (data[index].ter_Id == keyValue)
        {
          flag = true;
          break;
        }
      }
      if (!flag)
      {
        data.Add(CLinq.FindByKey<ter_Tercero>((DataContext) this.MyDataContext, (object) keyValue));
        this.GridViewPersonasAdicionadas.DataSource = (object) data;
        this.GridViewPersonasAdicionadas.DataBind();
        foreach (DataControlField column in (StateManagedCollection) this.GridViewPersonasAdicionadas.Columns)
        {
          if (column.HeaderText == "Id")
            column.Visible = false;
        }
        this.LocalInfo.SetData("listaTerceros", (object) data);
      }
      this.tablePersonasAgregadas.Visible = true;
    }

    protected void comboDepartamento_SelectedIndexChanged(object sender, EventArgs e) => this.LoadCiudadxDepto(this.comboDepartamento.SelectedValue);

    protected void buttonGuardar_Click(object sender, EventArgs e)
    {
      try
      {
        this.Validar();
        DateTime date = DateTime.Parse("1/1/1900");
        if (this.textfecha.Text != "")
          CValidator.isDate(this.textfecha.Text, ref date);
        List<ter_Tercero> data1 = (List<ter_Tercero>) this.LocalInfo.GetData("listaTerceros");
        int data2 = (int) this.LocalInfo.GetData("idActividad");
        act_Actividad myParams = (act_Actividad) this.LocalInfo.MyParams;
        myParams.act_Id = data2;
        myParams.act_Actividad1 = this.textActividad.Text.ToUpper();
        myParams.act_Fecha = date;
        myParams.act_EntidadesIvolucradas = this.textEntidades.Text.ToUpper();
        myParams.act_PersonasImpactadas = int.Parse(this.textoNumeroPersonasImpactadas.Text);
        mun_Municipio munMunicipio = this.MyDataContext.mun_Municipios.Where<mun_Municipio>((Expression<System.Func<mun_Municipio, bool>>) (muni => muni.mun_Id == this.comboCiudad.SelectedValue)).Single<mun_Municipio>();
        myParams.mun_Municipio = munMunicipio;
        myParams.mun_Id = this.comboCiudad.SelectedValue;
        myParams.seq_Modificado = DateTime.Now;
        myParams.seq_Usuario = this.Usuario.login;
        myParams.ati_Id = int.Parse(this.comboTipoActividad.SelectedValue);
        if (data2 == 0)
        {
          myParams.seq_Creado = DateTime.Now;
          this.MyDataContext.act_Actividads.InsertOnSubmit(myParams);
        }
        this.MyDataContext.SubmitChanges();
        if ((int) this.LocalInfo.GetData("idActividad") == 0)
          CAuditoria.log(EPermiso.AdicionarActividad, myParams.act_Id.ToString(), myParams.ati_ActividadTipo.ati_Descripcion, myParams.act_Fecha.ToShortDateString(), "", "", this.Usuario.id);
        else
          CAuditoria.log(EPermiso.ModificarActividad, myParams.act_Id.ToString(), myParams.ati_ActividadTipo.ati_Descripcion, myParams.act_Fecha.ToShortDateString(), "", "", this.Usuario.id);
        this.DocumentosVarios1.Visible = true;
        this.DocumentosVarios1.Init("Cer.ado_ActividadDocumento", "act_id", myParams.act_Id.ToString(), this.MyDataContext.Connection.ConnectionString);
        this.LocalInfo.SetData("idActividad", (object) myParams.act_Id);
        for (int index = 0; index < data1.Count; ++index)
          CCertificacion.EliminaActividadTercero(myParams.act_Id, data1[index].ter_Id, this.MyDataContext.Connection.ConnectionString);
        for (int index = 0; index < data1.Count; ++index)
          CCertificacion.AdicionaActividadTercero(myParams.act_Id, data1[index].ter_Id, this.MyDataContext.Connection.ConnectionString);
        if (data2 == 0)
          return;
        this.Response.Redirect("~/Certificacion/ActividadesBuscar.aspx");
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
      DateTime date = DateTime.Parse("1/1/1900");
      List<ter_Tercero> data = (List<ter_Tercero>) this.LocalInfo.GetData("listaTerceros");
      bool flag = true;
      if (this.textfecha.Text == "")
      {
        message += "Se debe seleccionar una fecha de la actividad. <br />";
        flag = false;
      }
      if (!CValidaEspeciales.VRequerido(this.textfecha.Text))
      {
        message += "Seleccione la fecha. <br/>";
        flag = false;
      }
      if (this.textfecha.Text != "" && !CValidator.isDate(this.textfecha.Text, ref date))
      {
        message += "La fecha no tiene un formato válido. <br/>";
        flag = false;
      }
      if (this.textfecha.Text != "" && CValidator.isDate(this.textfecha.Text, ref date) && date > DateTime.Today)
      {
        message += "La fecha de la actividad no puede ser futura. <br />";
        flag = false;
      }
      if (this.comboDepartamento.Text == "")
      {
        message += "Se debe seleccionar el departamento de la actividad. <br />";
        flag = false;
      }
      if (this.comboCiudad.Text == "")
      {
        message += "Se debe seleccionar la ciudad de la actividad. <br />";
        flag = false;
      }
      if (this.comboTipoActividad.Text == "")
      {
        message += "Se debe seleccionar el tipo de la actividad. <br />";
        flag = false;
      }
      if (!flag)
        throw new Exception(message);
    }

    protected void GridViewPersonasAdicionadas_RowCommand(object sender, GridViewCommandEventArgs e)
    {
      int data1 = (int) this.LocalInfo.GetData("idActividad");
      if (!e.CommandName.Equals("Eliminar"))
        return;
      List<ter_Tercero> data2 = (List<ter_Tercero>) this.LocalInfo.GetData("listaTerceros");
      int idTercero = int.Parse(this.GridViewPersonasAdicionadas.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString());
      for (int index = 0; index < data2.Count; ++index)
      {
        if (data2[index].ter_Id == idTercero)
        {
          CCertificacion.EliminaActividadTercero(data1, idTercero, this.MyDataContext.Connection.ConnectionString);
          data2.Remove(data2[index]);
          break;
        }
      }
      this.GridViewPersonasAdicionadas.DataSource = (object) data2;
      this.GridViewPersonasAdicionadas.DataBind();
      foreach (DataControlField column in (StateManagedCollection) this.GridViewPersonasAdicionadas.Columns)
      {
        if (column.HeaderText == "Id")
          column.Visible = false;
      }
      this.LocalInfo.SetData("listaTerceros", (object) data2);
      this.tablePersonasAgregadas.Visible = true;
    }

    protected void buttonAdicionar_Click(object sender, EventArgs e)
    {
      this.textRazonsocial.Text = "";
      this.comboDocumentoTipo.Text = "";
      this.textDocumento.Text = "";
      this.textEmail.Text = "";
      this.textDireccion.Text = "";
      this.textTelefono.Text = "";
      this.PanelTercero.Visible = true;
      this.divgrillabusqueda.Visible = false;
    }

    protected void buttonCancelarTercero_Click(object sender, EventArgs e) => this.PanelTercero.Visible = false;

    protected void buttonGuardarTercero_Click(object sender, EventArgs e)
    {
      try
      {
        this.ControlError1.Hide();
        this.Validartercero();
        this.terceroDataContext = (CertificacionDataContext) this.newDataContext(this.MyDataContext.Connection.ConnectionString);
        ter_Tercero entity = new ter_Tercero();
        entity.ter_NombreCompleto = this.textRazonsocial.Text.ToUpper();
        entity.ter_NumeroDocumento = this.textDocumento.Text.ToUpper();
        entity.ter_Direccion = this.textDireccion.Text.ToUpper();
        entity.ter_Tefono = this.textTelefono.Text.ToUpper();
        entity.ter_Correo = this.textEmail.Text;
        entity.dep_Id = "02";
        entity.mun_Id = "02999";
        entity.bti_Id = 1;
        entity.dti_Id = int.Parse(this.comboDocumentoTipo.SelectedValue);
        this.terceroDataContext.ter_Terceros.InsertOnSubmit(entity);
        this.terceroDataContext.SubmitChanges();
        List<ter_Tercero> data = (List<ter_Tercero>) this.LocalInfo.GetData("listaTerceros");
        data.Add(CLinq.FindByKey<ter_Tercero>((DataContext) this.MyDataContext, (object) entity.ter_Id));
        this.GridViewPersonasAdicionadas.DataSource = (object) data;
        this.GridViewPersonasAdicionadas.DataBind();
        this.LocalInfo.SetData("listaTerceros", (object) data);
        this.PanelTercero.Visible = false;
        this.tablePersonasAgregadas.Visible = true;
      }
      catch (Exception ex)
      {
        this.ControlError1.Visible = true;
        this.ControlError1.Show(ex);
      }
    }

    private void Validartercero()
    {
      string message = "";
      bool flag = true;
      if (this.textRazonsocial.Text == "")
      {
        message += "Se debe digitar el nombre. <br />";
        flag = false;
      }
      if (this.textTelefono.Text == "" && this.textEmail.Text == "")
      {
        message += "Se debe digitar el teléfono ó el correo electrónico. <br />";
        flag = false;
      }
      if (!flag)
        throw new Exception(message);
    }

    private void LoadCiudadxDepto(string depto)
    {
      this.comboCiudad.DataSource = (object) CLinq.ListByProperty<mun_Municipio>((DataContext) this.MyDataContext, "dep_id", (object) depto);
      this.comboCiudad.DataBind();
      this.comboCiudad.Items.Insert(0, "");
    }

    protected void comboTipoActividad_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!(this.comboTipoActividad.SelectedValue == "3") && !(this.comboTipoActividad.SelectedValue == "5") && !(this.comboTipoActividad.SelectedValue == "10") && !(this.comboTipoActividad.SelectedValue == "8") && !(this.comboTipoActividad.SelectedValue == "12") && !(this.comboTipoActividad.SelectedValue == "13") && !(this.comboTipoActividad.SelectedValue == "11"))
        this.labelAsterisco.Visible = false;
      else
        this.labelAsterisco.Visible = true;
    }

    protected void gridMaterial_RowCommand(object sender, GridViewCommandEventArgs e)
    {
      if (!e.CommandName.Equals("Eliminar"))
        return;
      EntitySet<ame_ActividadmaterialEntregado> data = (EntitySet<ame_ActividadmaterialEntregado>) this.LocalInfo.GetData("listaMaterial");
      ame_ActividadmaterialEntregado entity = data[int.Parse(this.gridMaterial.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString())];
      this.MyDataContext.ame_ActividadmaterialEntregados.DeleteOnSubmit(entity);
      data.Remove(entity);
      this.LocalInfo.SetData("listaMaterial", (object) data);
      this.ActualizaGrilla();
    }

    protected void buttonAdicionarmaterial_Click(object sender, EventArgs e)
    {
      try
      {
        this.ControlError1.Hide();
        this.ValidarMaterial();
        ame_ActividadmaterialEntregado entity = new ame_ActividadmaterialEntregado();
        EntitySet<ame_ActividadmaterialEntregado> data = (EntitySet<ame_ActividadmaterialEntregado>) this.LocalInfo.GetData("listaMaterial");
        entity.acm_Id = int.Parse(this.comboMaterial.SelectedValue);
        entity.ame_Cantidad = int.Parse(this.textCantidad.Text);
        entity.ame_Creado = DateTime.Now;
        entity.ame_Modificado = DateTime.Now;
        entity.ame_Usuario = this.Usuario.login;
        entity.act_Actividad = (act_Actividad) this.LocalInfo.MyParams;
        this.MyDataContext.ame_ActividadmaterialEntregados.InsertOnSubmit(entity);
        data.Add(entity);
        this.LocalInfo.SetData("listamaterial", (object) data);
        this.ActualizaGrilla();
        this.comboMaterial.SelectedValue = "";
        this.textCantidad.Text = "";
      }
      catch (Exception ex)
      {
        this.ControlError1.Visible = true;
        this.ControlError1.Show(ex);
      }
    }

    public void ActualizaGrilla()
    {
      List<RegistrarActividades.strMaterial> strMaterialList = new List<RegistrarActividades.strMaterial>();
      EntitySet<ame_ActividadmaterialEntregado> data = (EntitySet<ame_ActividadmaterialEntregado>) this.LocalInfo.GetData("listaMaterial");
      for (int index = 0; index < data.Count; ++index)
        strMaterialList.Add(new RegistrarActividades.strMaterial()
        {
          Id = index,
          Material = CLinq.FindByKey<acm_ActividadMaterial>((DataContext) this.MyDataContext, (object) data[index].acm_Id).acm_Descripcion,
          Cantidad = data[index].ame_Cantidad
        });
      this.gridMaterial.DataSource = (object) strMaterialList;
      this.gridMaterial.DataBind();
      foreach (DataControlField column in (StateManagedCollection) this.gridMaterial.Columns)
      {
        if (column.HeaderText == "Id")
          column.Visible = false;
      }
    }

    private void ValidarMaterial()
    {
      string message = "";
      EntitySet<ame_ActividadmaterialEntregado> data = (EntitySet<ame_ActividadmaterialEntregado>) this.LocalInfo.GetData("listaMaterial");
      bool flag = true;
      if (this.comboMaterial.SelectedValue == "")
      {
        message += "Se debe seleccionar un tipo de material. <br />";
        flag = false;
      }
      if (this.textCantidad.Text == "")
      {
        message += "Debe digitar la cantidad de material entregado. <br/>";
        flag = false;
      }
      else
      {
        try
        {
          if (int.Parse(this.textCantidad.Text) < 1)
          {
            message += "La cantidad debe ser un número positivo. <br/>";
            flag = false;
          }
        }
        catch
        {
          message += "La cantidad debe tener un formato válido. <br/>";
          flag = false;
        }
      }
      for (int index = 0; index < data.Count; ++index)
      {
        if (this.comboMaterial.SelectedValue == data[index].acm_Id.ToString())
        {
          message += "Este material ya se encuentra registrado. <br/>";
          flag = false;
          break;
        }
      }
      if (!flag)
        throw new Exception(message);
    }

    public class strMaterial
    {
      private string _material;
      private int _cantidad;
      private int _id;

      public string Material
      {
        get => this._material;
        set => this._material = value;
      }

      public int Cantidad
      {
        get => this._cantidad;
        set => this._cantidad = value;
      }

      public int Id
      {
        get => this._id;
        set => this._id = value;
      }
    }
  }
}
