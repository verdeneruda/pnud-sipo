// Decompiled with JetBrains decompiler
// Type: UTO.RegistrosUso.ImportadoresRegistrar
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
using System.Web.UI.WebControls;

namespace UTO.RegistrosUso
{
  public class ImportadoresRegistrar : BaseModulo
  {
    protected ToolkitScriptManager ToolkitScriptManager1;
    protected Label labelRegistrarRegistrosUsoImportadores;
    protected ControlError ControlError1;
    protected Label labelDatosGenerales;
    protected Label labelImportador;
    protected DropDownList comboImportador;
    protected Label labelAño;
    protected TextBox textAño;
    protected LinkButton linkEmpresas;
    protected ImageButton imageEmpresas;
    protected CollapsiblePanelExtender colapsibleEmpresas;
    protected Panel panelEmpresas;
    protected Button buttonAgregar;
    protected UpdatePanel UpdatePanel2;
    protected GridView gridDetalle;
    protected Button buttonGuardar;
    protected Button buttoncancelar;
    protected ModalPopupExtender ModalPopupExtender1;
    protected Panel panelAddEmpresas;
    protected UpdatePanel UpdatePanel3;
    protected ControlError ControlError2;
    protected Label labelCliente;
    protected DropDownList comboCliente;
    protected Label labelSustancia;
    protected DropDownList comboSustancia;
    protected Label labelCantidad;
    protected Label Label1;
    protected TextBox textCantidad;
    protected Label labelAplicacion;
    protected DropDownList comboAplicacion;
    protected Label labelDepartamento;
    protected DropDownList comboDepartamento;
    protected Label labelCiudad;
    protected DropDownList comboCiudad;
    protected Button buttonEnviarEmpresa0;
    protected Button buttonCancelarEmpresa;

    protected new void Page_Load(object sender, EventArgs e)
    {
      this.buttonGuardar.Enabled = this.Usuario.permiteOperacion(EPermiso.ModificarRegistrosReportadosPorImportadores) || this.Usuario.permiteOperacion(EPermiso.AdicionarregistrosReportadosPorImportadores);
      this.ControlError1.Visible = false;
      this.ControlError2.Visible = false;
      if (this.IsPostBack)
        return;
      this.InitData();
    }

    private void InitData()
    {
      List<ter_Tercero> terTerceroList = new List<ter_Tercero>();
      List<ttt_TerceroTipoTercero> terceroTipoTerceroList = CLinq.ListByProperty<ttt_TerceroTipoTercero>((DataContext) this.MyDataContext, "tti_Id", (object) 2);
      for (int index = 0; index <= terceroTipoTerceroList.Count - 1; ++index)
      {
        ter_Tercero byKey = CLinq.FindByKey<ter_Tercero>((DataContext) this.MyDataContext, (object) terceroTipoTerceroList[index].ter_Id);
        terTerceroList.Add(byKey);
      }
      this.comboImportador.DataSource = (object) terTerceroList;
      this.comboImportador.DataBind();
      this.comboImportador.Items.Insert(0, "");
      this.comboCliente.DataSource = (object) CLinq.ListAll<ter_Tercero>((DataContext) this.MyDataContext);
      this.comboCliente.DataBind();
      this.comboCliente.Items.Insert(0, "");
      this.comboSustancia.DataSource = (object) CLinq.ListAll<sus_Sustancia>((DataContext) this.MyDataContext);
      this.comboSustancia.DataBind();
      this.comboSustancia.Items.Insert(0, "");
      this.comboAplicacion.DataSource = (object) CLinq.ListAll<apl_Aplicacion>((DataContext) this.MyDataContext);
      this.comboAplicacion.DataBind();
      this.comboAplicacion.Items.Insert(0, "");
      this.comboDepartamento.DataSource = (object) CLinq.ListAll<dep_Departamento>((DataContext) this.MyDataContext);
      this.comboDepartamento.DataBind();
      this.comboDepartamento.Items.Insert(0, "");
      this.LocalInfo.SetData("idImportador", (object) ((BaseModulo.strSendParam) this.LocalInfo.MyParams).id);
      if (((BaseModulo.strSendParam) this.LocalInfo.MyParams).id != 0)
      {
        if (((BaseModulo.strSendParam) this.LocalInfo.MyParams).tipo == "Ver")
        {
          this.buttonGuardar.Enabled = false;
          this.buttonAgregar.Enabled = false;
          this.gridDetalle.Enabled = false;
        }
        this.mostrarDatos(((BaseModulo.strSendParam) this.LocalInfo.MyParams).id);
      }
      else
      {
        this.LocalInfo.MyParams = (object) new rri_RegistroReporteImportador();
        this.LocalInfo.SetData("lista", (object) new EntitySet<rid_RegistroImportadorDetalle>());
      }
    }

    private void mostrarDatos(int idImportador)
    {
      rri_RegistroReporteImportador byKey = CLinq.FindByKey<rri_RegistroReporteImportador>((DataContext) this.MyDataContext, (object) idImportador);
      this.LocalInfo.MyParams = (object) byKey;
      this.comboImportador.SelectedValue = byKey.ter_Id.ToString();
      this.textAño.Text = byKey.rri_Ano.ToString();
      this.LocalInfo.SetData("lista", (object) byKey.rid_RegistroImportadorDetalles);
      this.ActualizaGrilla();
    }

    protected void buttoncancelar_Click(object sender, EventArgs e) => this.Response.Redirect("~/RegistrosUso/ImportadoresBuscar.aspx");

    protected void gridDetalle_RowCommand(object sender, GridViewCommandEventArgs e)
    {
      if (!e.CommandName.Equals("Editar"))
        ;
      if (!e.CommandName.Equals("Eliminar"))
        return;
      EntitySet<rid_RegistroImportadorDetalle> data = (EntitySet<rid_RegistroImportadorDetalle>) this.LocalInfo.GetData("lista");
      rid_RegistroImportadorDetalle entity = data[int.Parse(this.gridDetalle.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString())];
      this.MyDataContext.rid_RegistroImportadorDetalles.DeleteOnSubmit(entity);
      data.Remove(entity);
      this.LocalInfo.SetData("lista", (object) data);
      this.ActualizaGrilla();
    }

    protected void comboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.comboCiudad.DataSource = (object) CLinq.ListByProperty<mun_Municipio>((DataContext) this.MyDataContext, "dep_id", (object) this.comboDepartamento.SelectedValue);
      this.comboCiudad.DataBind();
      this.comboCiudad.Items.Insert(0, "");
    }

    protected void buttonEnviarEmpresa_Click(object sender, EventArgs e)
    {
      try
      {
        this.ValidaDetalle();
        EntitySet<rid_RegistroImportadorDetalle> data = (EntitySet<rid_RegistroImportadorDetalle>) this.LocalInfo.GetData("lista");
        rid_RegistroImportadorDetalle entity = new rid_RegistroImportadorDetalle();
        entity.rid_Creado = DateTime.Now;
        entity.rid_Modificado = DateTime.Now;
        entity.rid_Usuario = "";
        entity.apl_Id = int.Parse(this.comboAplicacion.SelectedValue);
        entity.rid_Cantidad = Decimal.Parse(this.textCantidad.Text);
        entity.dep_Id = this.comboDepartamento.SelectedValue;
        entity.mun_Id = this.comboCiudad.SelectedValue;
        entity.sus_Id = int.Parse(this.comboSustancia.SelectedValue);
        entity.rri_RegistroReporteImportador = (rri_RegistroReporteImportador) this.LocalInfo.MyParams;
        entity.ter_Id = int.Parse(this.comboCliente.SelectedValue);
        this.comboDepartamento.Text = "";
        this.comboCiudad.Text = "";
        this.comboSustancia.Text = "";
        this.comboCliente.Text = "";
        this.textCantidad.Text = "0";
        this.MyDataContext.rid_RegistroImportadorDetalles.InsertOnSubmit(entity);
        data.Add(entity);
        this.LocalInfo.SetData("lista", (object) data);
        this.ActualizaGrilla();
        this.ModalPopupExtender1.Hide();
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
      bool flag = true;
      double number = 0.0;
      if (this.comboCliente.SelectedValue == "")
      {
        errStr += "Seleccione el cliente del importador. <br />";
        flag = false;
      }
      if (this.comboSustancia.SelectedValue == "")
      {
        errStr += "Seleccione la sustancia. <br />";
        flag = false;
      }
      if (this.textCantidad.Text == "")
      {
        errStr += "Escriba la cantidad, en kilogramos. <br />";
        flag = false;
      }
      if (this.comboAplicacion.SelectedValue == "")
      {
        errStr += "Seleccione la aplicación de la sustancia. <br />";
        flag = false;
      }
      if (this.comboDepartamento.SelectedValue == "")
      {
        errStr += "Seleccione el departamento. <br />";
        flag = false;
      }
      if (this.comboCiudad.SelectedValue == "")
      {
        errStr += "Seleccione la ciudad. <br />";
        flag = false;
      }
      if (!(flag & CValidator.isNumeric(this.textCantidad.Text, ref number, "La cantidad debe ser un número. <br />", ref errStr)))
        throw new Exception(errStr);
    }

    protected void buttonCancelarEmpresa_Click(object sender, EventArgs e)
    {
      this.comboDepartamento.Text = "";
      this.comboCiudad.Text = "";
      this.comboSustancia.Text = "";
      this.comboCliente.Text = "";
      this.textCantidad.Text = "0";
      this.ModalPopupExtender1.Hide();
    }

    protected void buttonGuardar_Click(object sender, EventArgs e)
    {
      try
      {
        this.Validar();
        rri_RegistroReporteImportador myParams = (rri_RegistroReporteImportador) this.LocalInfo.MyParams;
        myParams.rri_Ano = int.Parse(this.textAño.Text);
        myParams.rri_Modificado = DateTime.Now;
        myParams.rri_Usuario = "";
        myParams.ter_Id = int.Parse(this.comboImportador.SelectedValue);
        if (myParams.rri_Id == 0)
        {
          myParams.rri_Creado = DateTime.Now;
          this.MyDataContext.rri_RegistroReporteImportadors.InsertOnSubmit(myParams);
        }
        this.MyDataContext.SubmitChanges();
        if (myParams.rri_Id == 0)
          CAuditoria.log(EPermiso.AdicionarregistrosReportadosPorImportadores, myParams.rri_Id.ToString(), myParams.ter_Tercero.ter_NombreCompleto, myParams.rri_Ano.ToString(), "", "", this.Usuario.id);
        else
          CAuditoria.log(EPermiso.ModificarRegistrosReportadosPorImportadores, myParams.rri_Id.ToString(), myParams.ter_Tercero.ter_NombreCompleto, myParams.rri_Ano.ToString(), "", "", this.Usuario.id);
        this.Response.Redirect("~/RegistrosUso/ImportadoresBuscar.aspx");
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
      int number = 0;
      if (this.comboImportador.Text == "")
      {
        message += "Seleccione el importador. <br />";
        flag = false;
      }
      if (this.textAño.Text == "")
      {
        message += "Escriba el año de la importación. <br />";
        flag = false;
      }
      if (this.textAño.Text != "" && !CValidator.isInteger(this.textAño.Text, ref number))
      {
        message += "El año no tiene un formato válido <br/>";
        flag = false;
      }
      if (this.textAño.Text != "" && CValidator.isInteger(this.textAño.Text, ref number) && int.Parse(this.textAño.Text) > DateTime.Today.Year)
      {
        message += "El año del informe no puede ser futuro. <br />";
        flag = false;
      }
      if (!flag)
        throw new Exception(message);
    }

    public void ActualizaGrilla()
    {
      List<ImportadoresRegistrar.strCliente> strClienteList = new List<ImportadoresRegistrar.strCliente>();
      EntitySet<rid_RegistroImportadorDetalle> data = (EntitySet<rid_RegistroImportadorDetalle>) this.LocalInfo.GetData("lista");
      for (int index = 0; index < data.Count; ++index)
        strClienteList.Add(new ImportadoresRegistrar.strCliente()
        {
          id = index,
          cantidad = data[index].rid_Cantidad,
          aplicacion = CLinq.FindByKey<apl_Aplicacion>((DataContext) this.MyDataContext, (object) data[index].apl_Id).apl_Descripcion,
          cliente = CLinq.FindByKey<ter_Tercero>((DataContext) this.MyDataContext, (object) data[index].ter_Id).ter_NombreCompleto,
          sustancia = CLinq.FindByKey<sus_Sustancia>((DataContext) this.MyDataContext, (object) data[index].sus_Id).sus_Descripcion
        });
      this.gridDetalle.DataSource = (object) strClienteList;
      this.gridDetalle.DataBind();
    }

    public class strCliente
    {
      private string _sustancia;
      private string _cliente;
      private string _aplicacion;
      private Decimal _cantidad;
      private int _id;

      public string sustancia
      {
        get => this._sustancia;
        set => this._sustancia = value;
      }

      public string cliente
      {
        get => this._cliente;
        set => this._cliente = value;
      }

      public string aplicacion
      {
        get => this._aplicacion;
        set => this._aplicacion = value;
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
