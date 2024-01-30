// Decompiled with JetBrains decompiler
// Type: UTO.Comunes.TerceroRegistrar
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using AjaxControlToolkit;
using NE.CLib.Linq;
using Seguridad.Servicio;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UTO.Comunes
{
  public class TerceroRegistrar : BaseModulo
  {
    protected ToolkitScriptManager ToolkitScriptManager1;
    protected Label labelComunesTercero;
    protected ControlError ControlError1;
    protected Panel PanelDatosTercero;
    protected Label labelparametros;
    protected Label labelNombreBeneficiario;
    protected TextBox TextRazonSocial;
    protected Label labelTipoDocumento;
    protected DropDownList comboTipoDocumento;
    protected Label labelDocumento;
    protected TextBox textDocumento;
    protected Label labelRegional;
    protected DropDownList comboRegional;
    protected Label labelDepartamento;
    protected DropDownList comboDepartamento;
    protected Label labelCiudad;
    protected DropDownList comboCiudad;
    protected Label labelTelefono;
    protected TextBox textTelefono;
    protected Label labeldireccion;
    protected TextBox textDireccion;
    protected Label labelCorreo;
    protected TextBox textCorreo;
    protected GridView gridTipoTercero;
    protected Label labelTipoBeneficiario;
    protected RadioButton RadioPersonaNatural;
    protected RadioButton RadioPersonaJuridica;
    protected Panel PanelPersonaJuridica;
    protected Label labelEstablecimiento;
    protected TextBox textEstablecimientoComercio;
    protected Label labelRepresentanteLegal0;
    protected TextBox textNombreRepresentante;
    protected Label labelTipoDocumentoRL0;
    protected DropDownList comboTipoDocumentoRL;
    protected Label labelDocumentoRL0;
    protected TextBox textDocumentoRL;
    protected Label labelDe;
    protected TextBox textDe;
    protected GridView gridGrupoProyecto;
    protected Panel panelDuplicado;
    protected Label label1;
    protected Label label2;
    protected TextBox textBeneficiarioBuscar;
    protected Label label3;
    protected DropDownList comboTipo;
    protected Label labelNumeroDocumento;
    protected TextBox textNumeroDocumneto;
    protected Button buttonBuscarTercero;
    protected GridView gridTerceroBuscar;
    protected SqlDataSource terceroBuscarDataSource;
    protected Button buttonGuardar;
    protected Button buttonCancelar;

    protected new void Page_Load(object sender, EventArgs e)
    {
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
      this.comboTipoDocumentoRL.DataSource = (object) CLinq.ListAll<dti_DocumentoTipo>((DataContext) this.MyDataContext);
      this.comboTipoDocumentoRL.DataBind();
      this.comboTipoDocumentoRL.Items.Insert(0, "");
      this.comboDepartamento.DataSource = (object) CLinq.ListAll<dep_Departamento>((DataContext) this.MyDataContext);
      this.comboDepartamento.DataBind();
      this.comboDepartamento.Items.Insert(0, "");
      this.comboRegional.DataSource = (object) CLinq.ListAll<reg_Regional>((DataContext) this.MyDataContext);
      this.comboRegional.DataBind();
      this.comboRegional.Items.Insert(0, "");
      this.LocalInfo.SetData("idTercero", (object) ((BaseModulo.strSendParam) this.LocalInfo.MyParams).id);
      if (((BaseModulo.strSendParam) this.LocalInfo.MyParams).id != 0)
      {
        BaseModulo.strSendParam myParams = (BaseModulo.strSendParam) this.LocalInfo.MyParams;
        if (myParams.tipo == "Ver")
        {
          this.panelDuplicado.Style["display"] = "none";
          this.PanelDatosTercero.Enabled = false;
          this.buttonGuardar.Enabled = false;
        }
        else
          this.panelDuplicado.Style["display"] = "";
        myParams = (BaseModulo.strSendParam) this.LocalInfo.MyParams;
        this.mostrarDatos(myParams.id);
      }
      else
      {
        this.panelDuplicado.Style["display"] = "none";
        this.LocalInfo.MyParams = (object) new ter_Tercero();
        this.LocalInfo.SetData("idProvisional", (object) null);
        this.gridGrupoProyecto.DataSource = (object) CLinq.ListAll<pyg_ProyectoGrupo>((DataContext) this.MyDataContext);
        this.gridGrupoProyecto.DataBind();
        this.gridTipoTercero.DataSource = (object) CLinq.ListAll<tti_terceroTipo>((DataContext) this.MyDataContext);
        this.gridTipoTercero.DataBind();
      }
    }

    private void mostrarDatos(int id)
    {
      ter_Tercero byKey = CLinq.FindByKey<ter_Tercero>((DataContext) this.MyDataContext, (object) id);
      this.TextRazonSocial.Text = byKey.ter_NombreCompleto;
      this.comboTipoDocumento.SelectedValue = byKey.dti_Id.ToString();
      this.textDocumento.Text = byKey.ter_NumeroDocumento;
      this.textCorreo.Text = byKey.ter_Correo;
      this.textDireccion.Text = byKey.ter_Direccion;
      this.comboDepartamento.SelectedValue = byKey.dep_Id.ToString();
      this.comboRegional.SelectedValue = byKey.reg_Id.ToString();
      this.listarMunicipio(this.comboDepartamento.SelectedValue);
      this.comboCiudad.SelectedValue = byKey.mun_Id.ToString();
      this.textTelefono.Text = byKey.ter_Tefono;
      if (byKey.bti_beneficiarioTipo.bti_Id == 1)
        this.RadioPersonaNatural.Checked = true;
      else if (byKey.bti_beneficiarioTipo.bti_Id == 2)
      {
        this.RadioPersonaJuridica.Checked = true;
        this.PanelPersonaJuridica.Visible = true;
        this.textNombreRepresentante.Text = byKey.ter_RepresentanteLegal;
        this.comboTipoDocumentoRL.SelectedValue = byKey.dti_IdRepresentante.ToString();
        this.textDocumentoRL.Text = byKey.ter_NumeroDocumentoRepresentante;
        this.textEstablecimientoComercio.Text = byKey.ter_EstablacimientoComercio;
      }
      List<tgr_TerceroGrupo> tgrTerceroGrupoList = CLinq.ListByProperty<tgr_TerceroGrupo>((DataContext) this.MyDataContext, "ter_Id", (object) byKey.ter_Id);
      this.gridGrupoProyecto.DataSource = (object) CLinq.ListAll<pyg_ProyectoGrupo>((DataContext) this.MyDataContext);
      this.gridGrupoProyecto.DataBind();
      if (tgrTerceroGrupoList.Count > 0)
        this.mostrarVerificaProyectos(byKey);
      List<ttt_TerceroTipoTercero> terceroTipoTerceroList = CLinq.ListByProperty<ttt_TerceroTipoTercero>((DataContext) this.MyDataContext, "ter_Id", (object) byKey.ter_Id);
      this.gridTipoTercero.DataSource = (object) CLinq.ListAll<tti_terceroTipo>((DataContext) this.MyDataContext);
      this.gridTipoTercero.DataBind();
      if (terceroTipoTerceroList.Count > 0)
        this.mostrarVerificaTipo(byKey);
      this.LocalInfo.MyParams = (object) byKey;
    }

    private void mostrarVerificaTipo(ter_Tercero tercero)
    {
      int index = 0;
      foreach (Control row in this.gridTipoTercero.Rows)
      {
        CheckBox control = row.FindControl("CheckTipo") as CheckBox;
        int num = int.Parse(this.gridTipoTercero.DataKeys[index].Value.ToString());
        ComunesDataContext myDataContext = this.MyDataContext;
        object[] objArray = new object[4]
        {
          (object) "ter_id",
          (object) tercero.ter_Id,
          (object) "tti_Id",
          (object) num
        };
        control.Checked = CLinq.ListByProperties<ttt_TerceroTipoTercero>((DataContext) myDataContext, objArray).Count > 0;
        ++index;
      }
    }

    private void mostrarVerificaProyectos(ter_Tercero tercero)
    {
      int index = 0;
      foreach (Control row in this.gridGrupoProyecto.Rows)
      {
        CheckBox control = row.FindControl("CheckGrupo") as CheckBox;
        int num = int.Parse(this.gridGrupoProyecto.DataKeys[index].Value.ToString());
        ComunesDataContext myDataContext = this.MyDataContext;
        object[] objArray = new object[4]
        {
          (object) "ter_id",
          (object) tercero.ter_Id,
          (object) "pyg_Id",
          (object) num
        };
        control.Checked = CLinq.ListByProperties<tgr_TerceroGrupo>((DataContext) myDataContext, objArray).Count > 0;
        ++index;
      }
    }

    protected void RadioPersonaJuridica_CheckedChanged(object sender, EventArgs e) => this.PanelPersonaJuridica.Visible = true;

    protected void buttonGuardar_Click(object sender, EventArgs e)
    {
      ter_Tercero myParams = (ter_Tercero) this.LocalInfo.MyParams;
      try
      {
        this.Validar();
        myParams.ter_NombreCompleto = this.TextRazonSocial.Text.ToUpper();
        myParams.dti_Id = int.Parse(this.comboTipoDocumento.SelectedValue);
        myParams.ter_NumeroDocumento = this.textDocumento.Text.ToUpper();
        myParams.reg_Id = new int?(int.Parse(this.comboRegional.SelectedValue));
        myParams.dep_Id = this.comboDepartamento.SelectedValue;
        myParams.mun_Id = this.comboCiudad.SelectedValue;
        myParams.ter_Tefono = this.textTelefono.Text.ToUpper();
        myParams.ter_Direccion = this.textDireccion.Text.ToUpper();
        myParams.ter_Correo = this.textCorreo.Text.ToUpper();
        if (this.RadioPersonaNatural.Checked)
          myParams.bti_Id = 1;
        else if (this.RadioPersonaJuridica.Checked)
        {
          myParams.bti_Id = 2;
          myParams.ter_EstablacimientoComercio = this.textEstablecimientoComercio.Text;
          myParams.ter_RepresentanteLegal = this.textNombreRepresentante.Text;
          myParams.dti_IdRepresentante = new int?(int.Parse(this.comboTipoDocumentoRL.SelectedValue));
          myParams.ter_NumeroDocumentoRepresentante = this.textDocumentoRL.Text;
        }
        this.guardarVerificaProyecto(myParams);
        this.guardarVerificaTipo(myParams);
        if ((int) this.LocalInfo.GetData("idTercero") == 0)
          this.MyDataContext.ter_Terceros.InsertOnSubmit(myParams);
        this.MyDataContext.SubmitChanges();
        if ((int) this.LocalInfo.GetData("idTercero") == 0)
          CAuditoria.log(EPermiso.AdicionarTercero, myParams.ter_Id.ToString(), myParams.ter_NombreCompleto, myParams.ter_NumeroDocumento, "", "", this.Usuario.id);
        else
          CAuditoria.log(EPermiso.ModificarTercero, myParams.ter_Id.ToString(), myParams.ter_NombreCompleto, myParams.ter_NumeroDocumento, "", "", this.Usuario.id);
        this.Server.Transfer("~/Comunes/TerceroBuscar.aspx");
      }
      catch (Exception ex)
      {
        this.ControlError1.Visible = true;
        this.ControlError1.Show(ex);
      }
    }

    private void guardarVerificaTipo(ter_Tercero tercero)
    {
      int index = 0;
      foreach (Control row in this.gridTipoTercero.Rows)
      {
        CheckBox control = row.FindControl("CheckTipo") as CheckBox;
        if (control.Checked)
        {
          ttt_TerceroTipoTercero terceroTipoTercero = (ttt_TerceroTipoTercero) null;
          int num = int.Parse(this.gridTipoTercero.DataKeys[index].Value.ToString());
          List<ttt_TerceroTipoTercero> terceroTipoTerceroList = CLinq.ListByProperties<ttt_TerceroTipoTercero>((DataContext) this.MyDataContext, (object) "ter_id", (object) tercero.ter_Id, (object) "tti_Id", (object) num);
          if (terceroTipoTerceroList.Count == 0)
            this.MyDataContext.ttt_TerceroTipoTerceros.InsertOnSubmit(new ttt_TerceroTipoTercero()
            {
              ter_Tercero = tercero,
              tti_Id = num
            });
          else
            terceroTipoTercero = terceroTipoTerceroList[0];
          ++index;
        }
        else if (!control.Checked)
        {
          int num = int.Parse(this.gridTipoTercero.DataKeys[index].Value.ToString());
          List<ttt_TerceroTipoTercero> terceroTipoTerceroList = CLinq.ListByProperties<ttt_TerceroTipoTercero>((DataContext) this.MyDataContext, (object) "ter_id", (object) tercero.ter_Id, (object) "tti_Id", (object) num);
          if (terceroTipoTerceroList.Count > 0)
            this.MyDataContext.ttt_TerceroTipoTerceros.DeleteOnSubmit(terceroTipoTerceroList[0]);
          ++index;
        }
      }
    }

    private void guardarVerificaProyecto(ter_Tercero tercero)
    {
      int index = 0;
      foreach (Control row in this.gridGrupoProyecto.Rows)
      {
        CheckBox control = row.FindControl("CheckGrupo") as CheckBox;
        if (control.Checked)
        {
          tgr_TerceroGrupo tgrTerceroGrupo = (tgr_TerceroGrupo) null;
          int num = int.Parse(this.gridGrupoProyecto.DataKeys[index].Value.ToString());
          List<tgr_TerceroGrupo> tgrTerceroGrupoList = CLinq.ListByProperties<tgr_TerceroGrupo>((DataContext) this.MyDataContext, (object) "ter_id", (object) tercero.ter_Id, (object) "pyg_Id", (object) num);
          if (tgrTerceroGrupoList.Count == 0)
            this.MyDataContext.tgr_TerceroGrupos.InsertOnSubmit(new tgr_TerceroGrupo()
            {
              ter_Tercero = tercero,
              pyg_Id = num
            });
          else
            tgrTerceroGrupo = tgrTerceroGrupoList[0];
          ++index;
        }
        else if (!control.Checked)
        {
          int num = int.Parse(this.gridGrupoProyecto.DataKeys[index].Value.ToString());
          List<tgr_TerceroGrupo> tgrTerceroGrupoList = CLinq.ListByProperties<tgr_TerceroGrupo>((DataContext) this.MyDataContext, (object) "ter_id", (object) tercero.ter_Id, (object) "pyg_Id", (object) num);
          if (tgrTerceroGrupoList.Count > 0)
            this.MyDataContext.tgr_TerceroGrupos.DeleteOnSubmit(tgrTerceroGrupoList[0]);
          ++index;
        }
      }
    }

    private void Validar()
    {
      string message = "";
      bool flag = true;
      int data = (int) this.LocalInfo.GetData("idTercero");
      if (this.comboDepartamento.SelectedValue == "")
      {
        flag = false;
        message += "El departamento del tercero es un campo obligatorio. <br/>";
      }
      if (this.comboCiudad.SelectedValue == "")
      {
        flag = false;
        message += "La ciudad del tercero es un campo obligatorio. <br/>";
      }
      if (CLinq.ListByProperties<ter_Tercero>((DataContext) this.MyDataContext, (object) "ter_NumeroDocumento", (object) this.textDocumento.Text, (object) "mun_Id", (object) this.comboCiudad.SelectedValue).Count > 0 && data == 0)
      {
        flag = false;
        message += "Este tercero ya existe. <br/>";
      }
      if (this.TextRazonSocial.Text == "")
      {
        flag = false;
        message += "El nombre del tercero o la razón social es un campo obligatorio. <br/>";
      }
      if (this.comboTipoDocumento.SelectedValue == "")
      {
        flag = false;
        message += "El tipo de documento del tercero es un campo obligatorio. <br/>";
      }
      if (this.textDocumento.Text == "")
      {
        flag = false;
        message += "El número de documento del tercero es un campo obligatorio. <br/>";
      }
      if (!flag)
        throw new Exception(message);
    }

    protected void buttonCancelar_Click(object sender, EventArgs e) => this.Server.Transfer("~/Comunes/TerceroBuscar.aspx");

    protected void RadioPersonaNatural_CheckedChanged(object sender, EventArgs e) => this.PanelPersonaJuridica.Visible = false;

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

    protected void buttonBuscarTercero_Click(object sender, EventArgs e)
    {
      object data = this.LocalInfo.GetData("idTercero");
      this.gridTerceroBuscar.DataSource = (object) CTerceroDocumento.LeerTercero(this.textBeneficiarioBuscar.Text != "" ? this.textBeneficiarioBuscar.Text : "%", this.textNumeroDocumneto.Text != "" ? this.textNumeroDocumneto.Text : "%", this.comboTipo.SelectedValue != "" ? this.comboTipo.SelectedValue : "0", (int) data);
      this.gridTerceroBuscar.DataBind();
    }

    protected void GridViewTerceroBuscar_RowCommand(object sender, GridViewCommandEventArgs e)
    {
      if (!e.CommandName.Equals("Unificar"))
        return;
      object data = this.LocalInfo.GetData("idTercero");
      int idOld = int.Parse(this.gridTerceroBuscar.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString());
      CTerceroDocumento.UnificaTercero((int) data, idOld);
      ter_Tercero byKey = CLinq.FindByKey<ter_Tercero>((DataContext) this.MyDataContext, data);
      List<ttt_TerceroTipoTercero> terceroTipoTerceroList = CLinq.ListByProperty<ttt_TerceroTipoTercero>((DataContext) this.MyDataContext, "ter_Id", (object) byKey.ter_Id);
      this.gridTipoTercero.DataSource = (object) CLinq.ListAll<tti_terceroTipo>((DataContext) this.MyDataContext);
      this.gridTipoTercero.DataBind();
      if (terceroTipoTerceroList.Count > 0)
        this.mostrarVerificaTipo(byKey);
      List<tgr_TerceroGrupo> tgrTerceroGrupoList = CLinq.ListByProperty<tgr_TerceroGrupo>((DataContext) this.MyDataContext, "ter_Id", (object) byKey.ter_Id);
      this.gridGrupoProyecto.DataSource = (object) CLinq.ListAll<pyg_ProyectoGrupo>((DataContext) this.MyDataContext);
      this.gridGrupoProyecto.DataBind();
      if (tgrTerceroGrupoList.Count > 0)
        this.mostrarVerificaProyectos(byKey);
      this.gridTerceroBuscar.DataSource = (object) CTerceroDocumento.LeerTercero(this.textBeneficiarioBuscar.Text != "" ? this.textBeneficiarioBuscar.Text : "%", this.textNumeroDocumneto.Text != "" ? this.textNumeroDocumneto.Text : "%", this.comboTipo.SelectedValue != "" ? this.comboTipo.SelectedValue : "0", (int) data);
      this.gridTerceroBuscar.DataBind();
    }
  }
}
