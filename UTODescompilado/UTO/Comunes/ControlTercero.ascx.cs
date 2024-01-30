// Decompiled with JetBrains decompiler
// Type: UTO.Comunes.ControlTercero
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using NE.CLib.Linq;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UTO.Comunes
{
  public class ControlTercero : UserControl
  {
    private DataContext MyDataContext = (DataContext) null;
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
    protected Label labelTipoTercero;
    protected DropDownList comboTerceroTipo;
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
    protected Button buttonGuardar;
    protected Button buttonCancelar;

    public void InitData(int idTercero, string connetionString)
    {
      DataContext context = new DataContext(connetionString);
      this.comboTipoDocumento.DataSource = (object) CLinq.ListAll<dti_DocumentoTipo>(context);
      this.comboTipoDocumento.DataBind();
      this.comboTipoDocumento.Items.Insert(0, "");
      this.comboTipoDocumentoRL.DataSource = (object) CLinq.ListAll<dti_DocumentoTipo>(context);
      this.comboTipoDocumentoRL.DataBind();
      this.comboTipoDocumentoRL.Items.Insert(0, "");
      this.comboDepartamento.DataSource = (object) CLinq.ListAll<dep_Departamento>(context);
      this.comboDepartamento.DataBind();
      this.comboDepartamento.Items.Insert(0, "");
      this.comboRegional.DataSource = (object) CLinq.ListAll<reg_Regional>(context);
      this.comboRegional.DataBind();
      this.comboRegional.Items.Insert(0, "");
      this.comboTerceroTipo.DataSource = (object) CLinq.ListAll<tti_terceroTipo>(context);
      this.comboTerceroTipo.DataBind();
      this.comboTerceroTipo.Items.Insert(0, "");
      this.ViewState[nameof (idTercero)] = (object) idTercero;
      if (idTercero != 0)
      {
        this.mostrarDatos(idTercero);
      }
      else
      {
        this.ViewState["tercero"] = (object) new ter_Tercero();
        this.ViewState["idProvisional"] = (object) null;
        this.gridGrupoProyecto.DataSource = (object) CLinq.ListAll<pyg_ProyectoGrupo>(context);
        this.gridGrupoProyecto.DataBind();
        this.gridTipoTercero.DataSource = (object) CLinq.ListAll<tti_terceroTipo>(context);
        this.gridTipoTercero.DataBind();
      }
    }

    private void mostrarDatos(int id)
    {
      ter_Tercero byKey = CLinq.FindByKey<ter_Tercero>(this.MyDataContext, (object) id);
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
      List<tgr_TerceroGrupo> tgrTerceroGrupoList = CLinq.ListByProperty<tgr_TerceroGrupo>(this.MyDataContext, "ter_Id", (object) byKey.ter_Id);
      this.gridGrupoProyecto.DataSource = (object) CLinq.ListAll<pyg_ProyectoGrupo>(this.MyDataContext);
      this.gridGrupoProyecto.DataBind();
      if (tgrTerceroGrupoList.Count > 0)
        this.mostrarVerificaProyectos(byKey);
      List<ttt_TerceroTipoTercero> terceroTipoTerceroList = CLinq.ListByProperty<ttt_TerceroTipoTercero>(this.MyDataContext, "ter_Id", (object) byKey.ter_Id);
      this.gridTipoTercero.DataSource = (object) CLinq.ListAll<tti_terceroTipo>(this.MyDataContext);
      this.gridTipoTercero.DataBind();
      if (terceroTipoTerceroList.Count > 0)
        this.mostrarVerificaTipo(byKey);
      this.ViewState["tercero"] = (object) byKey;
    }

    private void mostrarVerificaTipo(ter_Tercero tercero)
    {
      int index = 0;
      foreach (Control row in this.gridTipoTercero.Rows)
      {
        CheckBox control = row.FindControl("CheckTipo") as CheckBox;
        int num = int.Parse(this.gridTipoTercero.DataKeys[index].Value.ToString());
        DataContext dataContext = this.MyDataContext;
        object[] objArray = new object[4]
        {
          (object) "ter_id",
          (object) tercero.ter_Id,
          (object) "tti_Id",
          (object) num
        };
        control.Checked = CLinq.ListByProperties<ttt_TerceroTipoTercero>(dataContext, objArray).Count > 0;
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
        DataContext dataContext = this.MyDataContext;
        object[] objArray = new object[4]
        {
          (object) "ter_id",
          (object) tercero.ter_Id,
          (object) "pyg_Id",
          (object) num
        };
        control.Checked = CLinq.ListByProperties<tgr_TerceroGrupo>(dataContext, objArray).Count > 0;
        ++index;
      }
    }

    protected void RadioPersonaJuridica_CheckedChanged(object sender, EventArgs e) => this.PanelPersonaJuridica.Visible = true;

    protected void buttonGuardar_Click(object sender, EventArgs e)
    {
      ter_Tercero tercero = (ter_Tercero) this.ViewState["tercero"];
      try
      {
        this.Validar();
        tercero.ter_NombreCompleto = this.TextRazonSocial.Text.ToUpper();
        tercero.dti_Id = int.Parse(this.comboTipoDocumento.SelectedValue);
        tercero.ter_NumeroDocumento = this.textDocumento.Text.ToUpper();
        tercero.reg_Id = new int?(int.Parse(this.comboRegional.SelectedValue));
        tercero.dep_Id = this.comboDepartamento.SelectedValue;
        tercero.mun_Id = this.comboCiudad.SelectedValue;
        tercero.ter_Tefono = this.textTelefono.Text.ToUpper();
        tercero.ter_Direccion = this.textDireccion.Text.ToUpper();
        tercero.ter_Correo = this.textCorreo.Text.ToUpper();
        if (this.RadioPersonaNatural.Checked)
          tercero.bti_Id = 1;
        else if (this.RadioPersonaJuridica.Checked)
        {
          tercero.bti_Id = 2;
          tercero.ter_EstablacimientoComercio = this.textEstablecimientoComercio.Text;
          tercero.ter_RepresentanteLegal = this.textNombreRepresentante.Text;
          tercero.dti_IdRepresentante = new int?(int.Parse(this.comboTipoDocumentoRL.SelectedValue));
          tercero.ter_NumeroDocumentoRepresentante = this.textDocumentoRL.Text;
        }
        this.guardarVerificaProyecto(tercero);
        this.guardarVerificaTipo(tercero);
        if ((int) this.ViewState["idTercero"] != 0)
          ;
        this.MyDataContext.SubmitChanges();
      }
      catch (Exception ex)
      {
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
          ttt_TerceroTipoTercero terceroTipoTercero1 = (ttt_TerceroTipoTercero) null;
          int num = int.Parse(this.gridTipoTercero.DataKeys[index].Value.ToString());
          List<ttt_TerceroTipoTercero> terceroTipoTerceroList = CLinq.ListByProperties<ttt_TerceroTipoTercero>(this.MyDataContext, (object) "ter_id", (object) tercero.ter_Id, (object) "tti_Id", (object) num);
          if (terceroTipoTerceroList.Count == 0)
          {
            ttt_TerceroTipoTercero terceroTipoTercero2 = new ttt_TerceroTipoTercero()
            {
              ter_Tercero = tercero,
              tti_Id = num
            };
          }
          else
            terceroTipoTercero1 = terceroTipoTerceroList[0];
          ++index;
        }
        else if (!control.Checked)
        {
          int num = int.Parse(this.gridGrupoProyecto.DataKeys[index].Value.ToString());
          if (CLinq.ListByProperties<tgr_TerceroGrupo>(this.MyDataContext, (object) "ter_id", (object) tercero.ter_Id, (object) "pyg_Id", (object) num).Count <= 0)
            ;
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
          tgr_TerceroGrupo tgrTerceroGrupo1 = (tgr_TerceroGrupo) null;
          int num = int.Parse(this.gridGrupoProyecto.DataKeys[index].Value.ToString());
          List<tgr_TerceroGrupo> tgrTerceroGrupoList = CLinq.ListByProperties<tgr_TerceroGrupo>(this.MyDataContext, (object) "ter_id", (object) tercero.ter_Id, (object) "pyg_Id", (object) num);
          if (tgrTerceroGrupoList.Count == 0)
          {
            tgr_TerceroGrupo tgrTerceroGrupo2 = new tgr_TerceroGrupo()
            {
              ter_Tercero = tercero,
              pyg_Id = num
            };
          }
          else
            tgrTerceroGrupo1 = tgrTerceroGrupoList[0];
          ++index;
        }
        else if (!control.Checked)
        {
          int num = int.Parse(this.gridGrupoProyecto.DataKeys[index].Value.ToString());
          if (CLinq.ListByProperties<tgr_TerceroGrupo>(this.MyDataContext, (object) "ter_id", (object) tercero.ter_Id, (object) "pyg_Id", (object) num).Count <= 0)
            ;
          ++index;
        }
      }
    }

    private void Validar()
    {
      string message = "";
      bool flag = true;
      if (this.TextRazonSocial.Text == "")
      {
        flag = false;
        message += "El nombre del tercero o la razón social es un campo obligatorio";
      }
      if (this.comboTipoDocumento.SelectedValue == "")
      {
        flag = false;
        message += "El tipo de documento del tercero es un campo obligatorio";
      }
      if (this.textDocumento.Text == "")
      {
        flag = false;
        message += "El número de documento del tercero es un campo obligatorio";
      }
      if (this.comboDepartamento.SelectedValue == "")
      {
        flag = false;
        message += "El departamento del tercero es un campo obligatorio";
      }
      if (this.comboCiudad.SelectedValue == "")
      {
        flag = false;
        message += "La ciudad del tercero es un campo obligatorio";
      }
      if (!flag)
        throw new Exception(message);
    }

    protected void buttonCancelar_Click(object sender, EventArgs e)
    {
    }

    protected void RadioPersonaNatural_CheckedChanged(object sender, EventArgs e) => this.PanelPersonaJuridica.Visible = false;

    protected void comboDepartamento_SelectedIndexChanged(object sender, EventArgs e) => this.listarMunicipio(this.comboDepartamento.SelectedValue);

    protected void listarMunicipio(string departamento)
    {
      List<mun_Municipio> munMunicipioList = CLinq.ListByProperty<mun_Municipio>(this.MyDataContext, "dep_Id", (object) departamento);
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
  }
}
