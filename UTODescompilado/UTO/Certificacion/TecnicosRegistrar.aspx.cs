// Decompiled with JetBrains decompiler
// Type: UTO.Certificacion.Registrartecnicos
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

namespace UTO.Certificacion
{
  public class Registrartecnicos : BaseModulo
  {
    private List<Registrartecnicos.strCertificaciones> listaCertificaciones = new List<Registrartecnicos.strCertificaciones>();
    protected ToolkitScriptManager ToolkitScriptManager1;
    protected Label labelRegistarTecnicos;
    protected ControlError ControlError1;
    protected Label labelDatosGenerales;
    protected Label labelTipoDocumento;
    protected DropDownList comboTipoDocumento;
    protected Label labelDocumento;
    protected TextBox textDocumento;
    protected Label labelNombre;
    protected TextBox textNombre;
    protected Label labelRegional;
    protected DropDownList comboRegional;
    protected Label labelDepartamento;
    protected DropDownList comboDepartamento;
    protected Label labelCiudad;
    protected UpdatePanel updateCiudad;
    protected DropDownList comboCiudad;
    protected Label labelDireccion;
    protected TextBox textDireccion;
    protected Label labelTelefono;
    protected TextBox textTelefono;
    protected Label labelCelular;
    protected TextBox textCelular;
    protected Label labelEmail;
    protected TextBox textEmail;
    protected Label labelFax;
    protected TextBox textFax;
    protected Label labelTipo;
    protected DropDownList comboTipo;
    protected Label labelArea;
    protected Label Label1;
    protected DropDownList comboAreaTrabajo;
    protected Label labelEmpresa;
    protected Label Label2;
    protected DropDownList comboEmpresa;
    protected Label labelCTG;
    protected Label Label3;
    protected GridView gridCTG;
    protected LinkButton linkCertificaciones;
    protected ImageButton imageCertificaciones;
    protected CollapsiblePanelExtender colapsibleCertificaciones;
    protected Panel panelCertificaciones;
    protected Button buttonAgregar;
    protected UpdatePanel UpdatePanel3;
    protected GridView gridCertificaciones;
    protected Label labelActividades;
    protected ListBox listboxActividad;
    protected Button buttonGuardar;
    protected Button buttoncancelar;
    protected ModalPopupExtender modalAddCertificaciones;
    protected Panel panelAddCertificaciones;
    protected UpdatePanel UpdatePanel2;
    protected ControlError ControlError2;
    protected Label labelFechaCertificacion;
    protected TextBox textFecha;
    protected CalendarExtender calendarextender1;
    protected Label labelvigencia;
    protected TextBox textvigencia;
    protected Label labelCarnetizado;
    protected Panel PanelCarnetizado;
    protected RadioButton radioSiCarnetizado0;
    protected RadioButton radioNoCarnetizado;
    protected Label labelNúmeroCarnet;
    protected TextBox textNúmeroCarnet;
    protected Button buttonEnviarCertificacion;
    protected Button buttonCancelarCertificacion;

    protected void Page_Load(object sender, EventArgs e)
    {
      this.buttonGuardar.Enabled = this.Usuario.permiteOperacion(EPermiso.ModificarTecnico) || this.Usuario.permiteOperacion(EPermiso.AdicionarTecnico);
      this.ControlError1.Visible = false;
      this.ControlError2.Visible = false;
      if (this.IsPostBack)
        return;
      this.InitData();
    }

    private void InitData()
    {
      this.comboTipoDocumento.DataSource = (object) CLinq.ListAll<dti_DocumentoTipo>((DataContext) this.MyDataContext);
      this.comboTipoDocumento.DataBind();
      this.comboTipoDocumento.Items.Insert(0, "");
      this.comboAreaTrabajo.DataSource = (object) CLinq.ListAll<atr_AreaTrabajo>((DataContext) this.MyDataContext);
      this.comboAreaTrabajo.DataBind();
      this.comboAreaTrabajo.Items.Insert(0, "");
      this.cargarComboTercero(this.comboEmpresa, 10, 0);
      this.comboRegional.DataSource = (object) CLinq.ListAll<reg_Regional>((DataContext) this.MyDataContext);
      this.comboRegional.DataBind();
      this.comboRegional.Items.Insert(0, "");
      this.comboTipo.DataSource = (object) CLinq.ListAll<tti_terceroTipo>((DataContext) this.MyDataContext);
      this.comboTipo.DataBind();
      this.comboTipo.Items.Insert(0, "");
      this.listboxActividad.DataSource = (object) CCertificacion.BuscaTecnicoActividad(((BaseModulo.strSendParam) this.LocalInfo.MyParams).id, this.MyDataContext.Connection.ConnectionString);
      this.listboxActividad.DataBind();
      this.gridCTG.DataSource = (object) CLinq.ListByProperty<cat_Categoria>((DataContext) this.MyDataContext, "cat_Tipo", (object) "T"[0]);
      this.gridCTG.DataBind();
      this.LocalInfo.SetData("idTercero", (object) ((BaseModulo.strSendParam) this.LocalInfo.MyParams).id);
      if (((BaseModulo.strSendParam) this.LocalInfo.MyParams).id != 0)
      {
        BaseModulo.strSendParam myParams = (BaseModulo.strSendParam) this.LocalInfo.MyParams;
        if (myParams.tipo == "Ver")
        {
          this.buttonGuardar.Enabled = false;
          this.colapsibleCertificaciones.Collapsed = false;
          this.panelCertificaciones.Enabled = false;
          this.buttoncancelar.Enabled = true;
        }
        this.Session["modo"] = (object) "Modificar";
        myParams = (BaseModulo.strSendParam) this.LocalInfo.MyParams;
        this.mostrarDatos(myParams.id);
      }
      else
      {
        this.Session["modo"] = (object) "Adicionar";
        this.LocalInfo.MyParams = (object) new tec_Tecnico();
        this.LocalInfo.SetData("listaCertificados", (object) new EntitySet<ted_TecnicoDetalle>());
        this.LocalInfo.SetData("listaCategoria", (object) new EntitySet<tca_TerceroCategoria>());
        this.LocalInfo.SetData("listaCertificaciones", (object) new List<Registrartecnicos.strCertificaciones>());
      }
    }

    private void mostrarDatos(int id)
    {
      tec_Tecnico byKey1 = CLinq.FindByKey<tec_Tecnico>((DataContext) this.MyDataContext, (object) id);
      ter_Tercero byKey2 = CLinq.FindByKey<ter_Tercero>((DataContext) this.MyDataContext, (object) byKey1.ter_Id);
      this.textNombre.Text = byKey2.ter_NombreCompleto;
      this.textDocumento.Text = byKey2.ter_NumeroDocumento;
      this.textDireccion.Text = byKey2.ter_Direccion;
      this.textTelefono.Text = byKey2.ter_Tefono;
      this.textCelular.Text = byKey2.ter_Celular;
      this.textEmail.Text = byKey2.ter_Correo;
      this.textFax.Text = byKey2.ter_Fax;
      this.comboRegional.Items.FindByValue(byKey2.reg_Id.ToString()).Selected = true;
      int? regId;
      int num1;
      if (byKey2.reg_Id.HasValue)
      {
        regId = byKey2.reg_Id;
        num1 = (regId.GetValueOrDefault() != 0 ? 0 : (regId.HasValue ? 1 : 0)) == 0 ? 1 : 0;
      }
      else
        num1 = 0;
      if (num1 == 0)
      {
        this.LoadDepartamento();
      }
      else
      {
        regId = byKey2.reg_Id;
        this.LoadDepartamentoxReg(regId.Value);
      }
      this.comboDepartamento.Items.FindByValue(byKey2.dep_Id).Selected = true;
      this.LoadMunicipioxDepto(byKey2.dep_Id);
      this.comboCiudad.Items.FindByValue(byKey2.mun_Id).Selected = true;
      this.comboTipoDocumento.SelectedValue = byKey2.dti_Id.ToString();
      DropDownList comboAreaTrabajo = this.comboAreaTrabajo;
      int num2 = byKey1.atr_Id;
      string str1 = num2.ToString();
      comboAreaTrabajo.SelectedValue = str1;
      DropDownList comboEmpresa = this.comboEmpresa;
      num2 = byKey1.ter_IdEmpresa;
      string str2 = num2.ToString();
      comboEmpresa.SelectedValue = str2;
      this.LocalInfo.MyParams = (object) byKey1;
      EntitySet<tca_TerceroCategoria> terceroCategorias = byKey2.tca_TerceroCategorias;
      this.LocalInfo.SetData("listaCertificados", (object) byKey1.ted_TecnicoDetalles);
      this.LocalInfo.SetData("listaCategoria", (object) terceroCategorias);
      this.ActualizaGrilla();
      if (terceroCategorias.Count == 0)
        return;
      for (int index1 = 0; index1 < this.gridCTG.DataKeys.Count; ++index1)
      {
        for (int index2 = 0; index2 < terceroCategorias.Count; ++index2)
        {
          string str3 = this.gridCTG.DataKeys[index1].Value.ToString();
          num2 = terceroCategorias[index2].cat_Id;
          string str4 = num2.ToString();
          if (str3 == str4)
          {
            ((CheckBox) this.gridCTG.Rows[index1].Cells[0].Controls[1]).Checked = true;
            this.gridCTG.Rows[index1].Cells[2].Text = terceroCategorias[index2].tca_Fecha.ToShortDateString();
            break;
          }
        }
      }
    }

    protected void buttoncancelar_Click(object sender, EventArgs e) => this.Response.Redirect("~/Certificacion/TecnicosBuscar.aspx");

    protected void buttonEnviarCertificacion_Click(object sender, EventArgs e)
    {
      try
      {
        this.ValidarTecnico();
        ted_TecnicoDetalle entity = new ted_TecnicoDetalle();
        entity.ted_Creado = DateTime.Now;
        entity.ted_Modificado = DateTime.Now;
        entity.ted_Usuario = this.Usuario.login;
        entity.tec_Tecnico = (tec_Tecnico) this.LocalInfo.MyParams;
        entity.ted_FechaCertificacion = DateTime.Parse(this.textFecha.Text);
        entity.ted_Vigencia = DateTime.Parse(this.textFecha.Text).AddYears(int.Parse(this.textvigencia.Text));
        entity.ted_NumeroCarnet = this.textNúmeroCarnet.Text;
        this.textFecha.Text = DateTime.Today.ToShortDateString();
        this.textvigencia.Text = "";
        this.textNúmeroCarnet.Text = "";
        this.MyDataContext.ted_TecnicoDetalles.InsertOnSubmit(entity);
        EntitySet<ted_TecnicoDetalle> data = (EntitySet<ted_TecnicoDetalle>) this.LocalInfo.GetData("listaCertificados");
        data.Add(entity);
        this.LocalInfo.SetData("listaCertificados", (object) data);
        this.ActualizaGrilla();
        this.modalAddCertificaciones.Hide();
      }
      catch (Exception ex)
      {
        this.ControlError2.Visible = true;
        this.ControlError2.Show(ex);
      }
    }

    private void ValidarTecnico()
    {
      string errStr = "";
      double number = 0.0;
      bool flag1 = true;
      DateTime date = DateTime.Parse("1/1/1900");
      bool flag2 = flag1 & CValidator.isNumeric(this.textvigencia.Text, ref number, "La vigencia debe ser un número. <br />", ref errStr);
      if (flag2 && Decimal.Parse(this.textvigencia.Text) < 1M)
      {
        errStr += "El valor de la vigencia debe ser entero mayor a cero <br />";
        flag2 = false;
      }
      if (!CValidaEspeciales.VRequerido(this.textFecha.Text))
      {
        errStr += "Seleccione la fecha de certificación. <br />";
        flag2 = false;
      }
      if (this.textFecha.Text != "" && !CValidator.isDate(this.textFecha.Text, ref date))
      {
        errStr += "La fecha de certificación no tiene un formato válido. <br />";
        flag2 = false;
      }
      if (this.textFecha.Text != "" && CValidator.isDate(this.textFecha.Text, ref date) && DateTime.Parse(this.textFecha.Text) > DateTime.Today)
      {
        errStr += "La fecha de certificación no puede ser futura. <br />";
        flag2 = false;
      }
      if (!flag2)
        throw new Exception(errStr);
    }

    protected void gridCertificaciones_RowCommand(object sender, GridViewCommandEventArgs e)
    {
      List<Registrartecnicos.strCertificaciones> strCertificacionesList = new List<Registrartecnicos.strCertificaciones>();
      EntitySet<ted_TecnicoDetalle> data = (EntitySet<ted_TecnicoDetalle>) this.LocalInfo.GetData("listaCertificados");
      if (!e.CommandName.Equals("Eliminar"))
        return;
      int index = int.Parse(this.gridCertificaciones.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString());
      ted_TecnicoDetalle entity = data[index];
      this.MyDataContext.ted_TecnicoDetalles.DeleteOnSubmit(entity);
      data.Remove(entity);
      this.LocalInfo.SetData("listaCertificados", (object) data);
      this.ActualizaGrilla();
    }

    protected void comboDepartamento_SelectedIndexChanged(object sender, EventArgs e) => this.LoadMunicipioxDepto(this.comboDepartamento.SelectedValue);

    protected void buttonGuardar_Click(object sender, EventArgs e)
    {
      try
      {
        this.Validar();
        tca_TerceroCategoria terceroCategoria = new tca_TerceroCategoria();
        tec_Tecnico myParams = (tec_Tecnico) this.LocalInfo.MyParams;
        ter_Tercero entity1 = new ter_Tercero();
        if (myParams.tec_Id != 0)
          entity1 = myParams.ter_Tercero;
        EntitySet<tca_TerceroCategoria> data = (EntitySet<tca_TerceroCategoria>) this.LocalInfo.GetData("listaCategoria");
        bool flag = false;
        entity1.dep_Id = this.comboDepartamento.SelectedValue;
        entity1.dti_Id = int.Parse(this.comboTipoDocumento.SelectedValue);
        entity1.mun_Id = this.comboCiudad.SelectedValue;
        entity1.reg_Id = new int?(int.Parse(this.comboRegional.SelectedValue));
        entity1.ter_Celular = this.textCelular.Text.ToUpper();
        entity1.ter_Correo = this.textEmail.Text;
        entity1.ter_Direccion = this.textDireccion.Text.ToUpper();
        entity1.ter_Fax = this.textFax.Text.ToUpper();
        entity1.ter_NombreCompleto = this.textNombre.Text.ToUpper();
        entity1.ter_NumeroDocumento = this.textDocumento.Text.ToUpper();
        entity1.ter_Tefono = this.textTelefono.Text.ToUpper();
        entity1.bti_Id = 1;
        myParams.atr_Id = int.Parse(this.comboAreaTrabajo.SelectedValue);
        myParams.ter_IdEmpresa = int.Parse(this.comboEmpresa.SelectedValue);
        myParams.seq_Usuario = this.Usuario.login;
        myParams.seq_Modificado = DateTime.Now;
        if ((string) this.Session["modo"] == "Adicionar")
        {
          List<ter_Tercero> terTerceroList = CLinq.ListByProperties<ter_Tercero>((DataContext) this.MyDataContext, (object) "ter_NumeroDocumento", (object) this.textDocumento.Text.ToUpper(), (object) "mun_Id", (object) entity1.mun_Id);
          if (terTerceroList.Count > 0)
          {
            for (int index = 0; index < terTerceroList.Count; ++index)
            {
              if (entity1.ter_Id != terTerceroList[index].ter_Id && terTerceroList[index].ter_NombreCompleto.ToUpper() == this.textNombre.Text.ToUpper())
                throw new Exception("El tercero ya se encuentra registrado. <br />");
            }
          }
        }
        int num;
        if (myParams.tec_Id != 0)
        {
          for (int index1 = 0; index1 < this.gridCTG.DataKeys.Count; ++index1)
          {
            if (!((CheckBox) this.gridCTG.Rows[index1].Cells[0].Controls[1]).Checked)
            {
              for (int index2 = 0; index2 < data.Count; ++index2)
              {
                string str1 = this.gridCTG.DataKeys[index1].Value.ToString();
                num = data[index2].cat_Id;
                string str2 = num.ToString();
                if (str1 == str2)
                {
                  this.MyDataContext.tca_TerceroCategorias.DeleteOnSubmit(data[index2]);
                  data.Remove(data[index2]);
                  break;
                }
              }
            }
          }
          for (int index3 = 0; index3 < this.gridCTG.DataKeys.Count; ++index3)
          {
            if (((CheckBox) this.gridCTG.Rows[index3].Cells[0].Controls[1]).Checked)
            {
              for (int index4 = 0; index4 < data.Count; ++index4)
              {
                string str3 = this.gridCTG.DataKeys[index3].Value.ToString();
                num = data[index4].cat_Id;
                string str4 = num.ToString();
                if (str3 == str4)
                {
                  flag = true;
                  break;
                }
                flag = false;
              }
              if (!flag)
              {
                tca_TerceroCategoria entity2 = new tca_TerceroCategoria();
                entity2.cat_Id = int.Parse(this.gridCTG.DataKeys[index3].Value.ToString());
                entity2.ter_Tercero = entity1;
                entity2.tca_Fecha = DateTime.Today;
                this.MyDataContext.tca_TerceroCategorias.InsertOnSubmit(entity2);
                data.Add(entity2);
                flag = false;
              }
            }
          }
        }
        else
        {
          for (int index = 0; index < this.gridCTG.DataKeys.Count; ++index)
          {
            if (((CheckBox) this.gridCTG.Rows[index].Cells[0].Controls[1]).Checked)
            {
              tca_TerceroCategoria entity3 = new tca_TerceroCategoria();
              entity3.cat_Id = int.Parse(this.gridCTG.DataKeys[index].Value.ToString());
              entity3.ter_Tercero = entity1;
              entity3.tca_Fecha = DateTime.Today;
              this.MyDataContext.tca_TerceroCategorias.InsertOnSubmit(entity3);
              data.Add(entity3);
            }
          }
        }
        if ((int) this.LocalInfo.GetData("idTercero") == 0)
        {
          ttt_TerceroTipoTercero entity4 = new ttt_TerceroTipoTercero();
          entity4.ter_Tercero = entity1;
          entity4.tti_Id = 5;
          this.MyDataContext.ter_Terceros.InsertOnSubmit(entity1);
          this.MyDataContext.ttt_TerceroTipoTerceros.InsertOnSubmit(entity4);
          myParams.ter_Tercero = entity1;
          myParams.seq_Creado = DateTime.Now;
          this.MyDataContext.tec_Tecnicos.InsertOnSubmit(myParams);
        }
        this.MyDataContext.SubmitChanges();
        if ((int) this.LocalInfo.GetData("idTercero") == 0)
        {
          num = myParams.tec_Id;
          CAuditoria.log(EPermiso.AdicionarTecnico, num.ToString(), myParams.ter_Tercero.ter_NombreCompleto, myParams.ter_Tercero.ter_NumeroDocumento, "", "", this.Usuario.id);
        }
        else
        {
          num = myParams.tec_Id;
          CAuditoria.log(EPermiso.ModificarTecnico, num.ToString(), myParams.ter_Tercero.ter_NombreCompleto, myParams.ter_Tercero.ter_NumeroDocumento, "", "", this.Usuario.id);
        }
        this.Session.Remove("modo");
        this.Response.Redirect("~/Certificacion/TecnicosBuscar.aspx");
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
      bool flag1 = true;
      bool flag2 = false;
      if (this.comboAreaTrabajo.SelectedValue == "")
      {
        message += "Seleccione el área de trabajo. <br />";
        flag1 = false;
      }
      if (this.comboEmpresa.SelectedValue == "")
      {
        message += "Seleccione la empresa. <br />";
        flag1 = false;
      }
      if (this.comboTipoDocumento.SelectedValue == "")
      {
        message += "Seleccione el tipo de documento. <br />";
        flag1 = false;
      }
      if (this.comboRegional.SelectedValue == "")
      {
        message += "Seleccione la regional. <br />";
        flag1 = false;
      }
      if (this.comboDepartamento.SelectedValue == "")
      {
        message += "Seleccione el departamento. <br />";
        flag1 = false;
      }
      if (this.comboCiudad.SelectedValue == "")
      {
        message += "Seleccione la ciudad. <br />";
        flag1 = false;
      }
      if (this.textNombre.Text == "")
      {
        message += "Escriba el nombre. <br />";
        flag1 = false;
      }
      if (this.textDocumento.Text == "")
      {
        message += "Escriba el documento. <br />";
        flag1 = false;
      }
      if (this.textEmail.Text != "" && !CValidaEspeciales.VEmail(this.textEmail.Text))
      {
        message += "El email no tiene un formato válido. <br/>";
        flag1 = false;
      }
      foreach (TableRow row in this.gridCTG.Rows)
      {
        if (((CheckBox) row.Cells[0].Controls[1]).Checked)
          flag2 = true;
      }
      if (!flag2)
      {
        message += "Debe seleccionar una categoría. <br />";
        flag1 = false;
      }
      if (!flag1)
        throw new Exception(message);
    }

    public void ActualizaGrilla()
    {
      List<Registrartecnicos.strCertificaciones> strCertificacionesList = new List<Registrartecnicos.strCertificaciones>();
      EntitySet<ted_TecnicoDetalle> data = (EntitySet<ted_TecnicoDetalle>) this.LocalInfo.GetData("listaCertificados");
      for (int index = 0; index < data.Count; ++index)
        strCertificacionesList.Add(new Registrartecnicos.strCertificaciones()
        {
          certificacion = data[index].ted_FechaCertificacion,
          vigencia = data[index].ted_Vigencia,
          id = index,
          idProvisional = data[index].ted_Id
        });
      this.gridCertificaciones.DataSource = (object) strCertificacionesList;
      this.gridCertificaciones.DataBind();
    }

    protected void CancelarAddCertificacion(object sender, EventArgs e) => this.modalAddCertificaciones.Hide();

    protected void comboRegional_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.LoadDepartamentoxReg(Convert.ToInt32(this.comboRegional.SelectedValue));
      this.LoadMunicipioxDepto("00");
      this.updateCiudad.Update();
    }

    private void LoadDepartamentoxReg(int idRegional)
    {
      this.comboDepartamento.DataSource = (object) CLinq.ListByProperty<dep_Departamento>((DataContext) this.MyDataContext, "reg_Id", (object) idRegional);
      this.comboDepartamento.DataBind();
      this.comboDepartamento.Items.Insert(0, "");
    }

    private void LoadMunicipioxDepto(string idDepto)
    {
      this.comboCiudad.DataSource = (object) CLinq.ListByProperty<mun_Municipio>((DataContext) this.MyDataContext, "dep_id", (object) idDepto);
      this.comboCiudad.DataBind();
      this.comboCiudad.Items.Insert(0, "");
    }

    private void LoadDepartamento()
    {
      this.comboDepartamento.DataSource = (object) CLinq.ListAll<dep_Departamento>((DataContext) this.MyDataContext);
      this.comboDepartamento.DataBind();
      this.comboDepartamento.Items.Insert(0, "");
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

    public class strCertificaciones
    {
      private DateTime _certificacion;
      private DateTime _vigencia;
      private int _id;
      private int _idProvisional;

      public DateTime certificacion
      {
        get => this._certificacion;
        set => this._certificacion = value;
      }

      public DateTime vigencia
      {
        get => this._vigencia;
        set => this._vigencia = value;
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
