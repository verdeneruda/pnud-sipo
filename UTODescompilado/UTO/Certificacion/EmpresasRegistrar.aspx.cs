// Decompiled with JetBrains decompiler
// Type: UTO.Certificacion.EmpresasRegistrar
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using NE.CLib.Linq;
using Seguridad.Servicio;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UTO.Certificacion
{
  public class EmpresasRegistrar : BaseModulo
  {
    protected System.Web.UI.ScriptManager ScriptManager1;
    protected Label labelRegistarEmpresas;
    protected ControlError ControlError1;
    protected Panel panelEmpresa;
    protected Label labelDatosGenerales;
    protected Label labelNit;
    protected TextBox textNit;
    protected Label labelNombre;
    protected TextBox textNombre;
    protected Label labelDepartamento;
    protected DropDownList comboDepartamento;
    protected Label labelCiudad;
    protected UpdatePanel updateCiudad;
    protected DropDownList comboCiudad;
    protected Label labelDireccion;
    protected Label Label1;
    protected TextBox textDireccion;
    protected Label labelTelefono;
    protected Label Label2;
    protected TextBox textTelefono;
    protected Label labelFax;
    protected TextBox textFax;
    protected Label labelEmail;
    protected TextBox textEmail;
    protected Label labelCTG;
    protected Label Label3;
    protected CheckBoxList checkboxlistCTG;
    protected Button buttonGuardar;
    protected Button buttoncancelar;

    protected void Page_Load(object sender, EventArgs e)
    {
      this.buttonGuardar.Enabled = this.Usuario.permiteOperacion(EPermiso.ModificarEmpresa) || this.Usuario.permiteOperacion(EPermiso.AdicionarEmpresa);
      this.ControlError1.Visible = false;
      if (this.IsPostBack)
        return;
      this.InitData();
    }

    private void InitData()
    {
      this.comboDepartamento.DataSource = (object) CLinq.ListAll<dep_Departamento>((DataContext) this.MyDataContext);
      this.comboDepartamento.DataBind();
      this.comboDepartamento.Items.Insert(0, "");
      this.checkboxlistCTG.DataSource = (object) CLinq.ListByProperty<cat_Categoria>((DataContext) this.MyDataContext, "cat_Tipo", (object) "E"[0]);
      this.checkboxlistCTG.DataBind();
      this.LocalInfo.SetData("idTercero", (object) ((BaseModulo.strSendParam) this.LocalInfo.MyParams).id);
      if (((BaseModulo.strSendParam) this.LocalInfo.MyParams).id != 0)
      {
        BaseModulo.strSendParam myParams = (BaseModulo.strSendParam) this.LocalInfo.MyParams;
        if (myParams.tipo == "Ver")
        {
          this.buttonGuardar.Enabled = false;
          this.buttoncancelar.Enabled = true;
        }
        myParams = (BaseModulo.strSendParam) this.LocalInfo.MyParams;
        this.mostrarDatos(myParams.id);
      }
      else
        this.LocalInfo.MyParams = (object) new ter_Tercero();
    }

    private void mostrarDatos(int idTercero)
    {
      ter_Tercero byKey = CLinq.FindByKey<ter_Tercero>((DataContext) this.MyDataContext, (object) idTercero);
      this.textNombre.Text = byKey.ter_NombreCompleto;
      this.textNit.Text = byKey.ter_NumeroDocumento;
      this.textDireccion.Text = byKey.ter_Direccion;
      this.textTelefono.Text = byKey.ter_Tefono;
      this.textEmail.Text = byKey.ter_Correo;
      this.textFax.Text = byKey.ter_Fax;
      this.comboDepartamento.SelectedValue = byKey.dep_Id;
      this.LoadCiudadxDepto(byKey.dep_Id);
      this.comboCiudad.SelectedValue = byKey.mun_Id;
      this.LocalInfo.MyParams = (object) byKey;
      for (int index1 = 0; index1 < this.checkboxlistCTG.Items.Count; ++index1)
      {
        for (int index2 = 0; index2 < byKey.tca_TerceroCategorias.Count; ++index2)
        {
          if (this.checkboxlistCTG.Items[index1].Value == byKey.tca_TerceroCategorias[index2].cat_Id.ToString())
          {
            this.checkboxlistCTG.Items[index1].Selected = true;
            break;
          }
        }
      }
    }

    protected void buttoncancelar_Click(object sender, EventArgs e) => this.Response.Redirect("~/Certificacion/EmpresasBuscar.aspx");

    protected void buttonGuardar_Click(object sender, EventArgs e)
    {
      try
      {
        this.Validar();
        ter_Tercero myParams = (ter_Tercero) this.LocalInfo.MyParams;
        myParams.ter_NombreCompleto = this.textNombre.Text.ToUpper();
        myParams.ter_NumeroDocumento = this.textNit.Text.ToUpper();
        myParams.ter_Direccion = this.textDireccion.Text.ToUpper();
        myParams.ter_Tefono = this.textTelefono.Text.ToUpper();
        myParams.ter_Correo = this.textEmail.Text;
        myParams.ter_Fax = this.textFax.Text.ToUpper();
        myParams.dep_Id = this.comboDepartamento.SelectedValue;
        myParams.mun_Id = this.comboCiudad.SelectedValue;
        myParams.bti_Id = 2;
        List<ter_Tercero> terTerceroList = CLinq.ListByProperties<ter_Tercero>((DataContext) this.MyDataContext, (object) "ter_NumeroDocumento", (object) this.textNit.Text.ToUpper(), (object) "mun_Id", (object) myParams.mun_Id);
        if (terTerceroList.Count > 0)
        {
          for (int index = 0; index < terTerceroList.Count; ++index)
          {
            if (myParams.ter_Id != terTerceroList[index].ter_Id && myParams.ter_NombreCompleto.ToUpper() == this.textNombre.Text.ToUpper())
              throw new Exception("El tercero ya se encuentra registrado");
          }
        }
        if ((int) this.LocalInfo.GetData("idTercero") == 0)
        {
          ttt_TerceroTipoTercero entity = new ttt_TerceroTipoTercero();
          entity.ter_Tercero = myParams;
          entity.tti_Id = 10;
          this.MyDataContext.ter_Terceros.InsertOnSubmit(myParams);
          this.MyDataContext.ttt_TerceroTipoTerceros.InsertOnSubmit(entity);
        }
        else
        {
          for (int index = 0; index < myParams.tca_TerceroCategorias.Count; ++index)
            this.MyDataContext.tca_TerceroCategorias.DeleteOnSubmit(myParams.tca_TerceroCategorias[index]);
        }
        for (int index = 0; index < this.checkboxlistCTG.Items.Count; ++index)
        {
          if (this.checkboxlistCTG.Items[index].Selected)
            this.MyDataContext.tca_TerceroCategorias.InsertOnSubmit(new tca_TerceroCategoria()
            {
              cat_Id = int.Parse(this.checkboxlistCTG.Items[index].Value),
              tca_Fecha = DateTime.Today,
              ter_Tercero = myParams
            });
        }
        this.MyDataContext.SubmitChanges();
        if ((int) this.LocalInfo.GetData("idTercero") == 0)
          CAuditoria.log(EPermiso.AdicionarEmpresa, myParams.ter_Id.ToString(), myParams.ter_NombreCompleto, myParams.ter_NumeroDocumento, "", "", this.Usuario.id);
        else
          CAuditoria.log(EPermiso.ModificarEmpresa, myParams.ter_Id.ToString(), myParams.ter_NombreCompleto, myParams.ter_NumeroDocumento, "", "", this.Usuario.id);
        this.Response.Redirect("~/Certificacion/EmpresasBuscar.aspx");
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
      bool flag1 = true;
      bool flag2 = false;
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
        message += "Escriba el nombre o razón social. <br />";
        flag1 = false;
      }
      if (this.textNit.Text == "")
      {
        message += "Escriba el NIT. <br />";
        flag1 = false;
      }
      if (this.textEmail.Text != "" && !CValidaEspeciales.VEmail(this.textEmail.Text))
      {
        message += "El E-mail no tiene un formato válido. <br/>";
        flag1 = false;
      }
      if (this.textDireccion.Text == "")
      {
        message += "Se debe digitar la dirección. <br/>";
        flag1 = false;
      }
      if (this.textTelefono.Text == "")
      {
        message += "Se debe digitar el teléfono. <br/>";
        flag1 = false;
      }
      for (int index = 0; index < this.checkboxlistCTG.Items.Count; ++index)
      {
        if (this.checkboxlistCTG.Items[index].Selected)
        {
          flag2 = true;
          break;
        }
      }
      if (!flag2)
      {
        message += "Debe seleccionar una categoría. <br />";
        flag1 = false;
      }
      if (!flag1)
        throw new Exception(message);
    }

    protected void comboDepartamento_SelectedIndexChanged(object sender, EventArgs e) => this.LoadCiudadxDepto(this.comboDepartamento.SelectedValue);

    private void LoadCiudadxDepto(string depto)
    {
      this.comboCiudad.DataSource = (object) CLinq.ListByProperty<mun_Municipio>((DataContext) this.MyDataContext, "dep_id", (object) depto);
      this.comboCiudad.DataBind();
      this.comboCiudad.Items.Insert(0, "");
    }
  }
}
