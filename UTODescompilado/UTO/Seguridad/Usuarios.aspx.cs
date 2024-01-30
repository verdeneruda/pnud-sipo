// Decompiled with JetBrains decompiler
// Type: UTO.Seguridad.Usuarios
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using NE.CLib;
using Seguridad.Datos;
using Seguridad.Servicio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web.UI.WebControls;

namespace UTO.Seguridad
{
  public class Usuarios : BaseSeguridad
  {
    protected Label labelUsuarios;
    protected Label labelError;
    protected Label labelNombre;
    protected TextBox textNombre;
    protected Label labelLogin;
    protected TextBox textLogin;
    protected Label labelPassword;
    protected TextBox textPassword;
    protected Label labelPassword2;
    protected TextBox textPassword2;
    protected Label labelUnidad;
    protected DropDownList comboUnidad;
    protected Label labelActivo;
    protected CheckBox checkActivo;
    protected Label labelGrupo;
    protected CheckBoxList checkboxlistGrupos;
    protected Button buttonGuardar;
    protected Button ButtonCancelar;

    protected void Page_Load(object sender, EventArgs e)
    {
      this.buttonGuardar.Enabled = this.Usuario.permiteOperacion(EPermiso.AdicionarUsuarios) || this.Usuario.permiteOperacion(EPermiso.ModificarUsuarios) || this.Session["Usuarios.Tipo"].ToString() == "2";
      this.labelError.Text = string.Empty;
      if (this.Page.IsPostBack)
        return;
      this.checkboxlistGrupos.DataSource = (object) CSeguridad.getGrupos();
      this.checkboxlistGrupos.DataValueField = "GRU_ID";
      this.checkboxlistGrupos.DataTextField = "GRU_NOMBRE";
      this.checkboxlistGrupos.DataBind();
      this.comboUnidad.Items.Add(new ListItem("Seleccione...", "-1"));
      this.comboUnidad.DataSource = (object) CSeguridad.getUnidades();
      this.comboUnidad.DataTextField = "UNI_NOMBRE";
      this.comboUnidad.DataValueField = "UNI_ID";
      this.comboUnidad.DataBind();
      if ((string) this.Session["Usuarios.Tipo"] == "1" || (string) this.Session["Usuarios.Tipo"] == "2" || (string) this.Session["Usuarios.Tipo"] == "3")
      {
        BUsuarios busuarios = new BUsuarios();
        DataTable dataTable = busuarios.leerUsuario(Convert.ToInt32(this.Session["Usuarios.IdUsuario"]));
        this.ViewState["Usuarios.idusuario"] = (object) Convert.ToInt32(dataTable.Rows[0][0]);
        this.textLogin.Text = dataTable.Rows[0]["usu_Login"].ToString();
        this.textNombre.Text = dataTable.Rows[0]["usu_Nombres"].ToString();
        string Source = dataTable.Rows[0]["usu_Password"].ToString();
        this.Session["Usuarios.Password"] = (object) CCryptor.Decrypt(Source, CSeguridad.key);
        this.textPassword.Text = CCryptor.Decrypt(Source, CSeguridad.key);
        this.textPassword2.Text = CCryptor.Decrypt(Source, CSeguridad.key);
        this.comboUnidad.SelectedValue = dataTable.Rows[0]["usu_unidad"].ToString();
        this.checkActivo.Checked = false;
        if ((bool) dataTable.Rows[0]["usu_activo"])
          this.checkActivo.Checked = true;
        foreach (DataRow row in (InternalDataCollectionBase) busuarios.leerUsuarioGrupos(Convert.ToInt64(dataTable.Rows[0][0])).Rows)
        {
          foreach (ListItem listItem in this.checkboxlistGrupos.Items)
          {
            if (Convert.ToInt64(row[1]) == Convert.ToInt64(listItem.Value))
              listItem.Selected = true;
          }
        }
        if ((string) this.Session["Usuarios.Tipo"] == "2")
        {
          this.textLogin.Enabled = false;
          this.comboUnidad.Enabled = false;
          this.checkActivo.Enabled = false;
          this.checkboxlistGrupos.Enabled = false;
        }
        if ((string) this.Session["Usuarios.Tipo"] == "3")
        {
          this.textLogin.Enabled = false;
          this.textNombre.Enabled = false;
          this.textPassword.Enabled = false;
          this.checkActivo.Enabled = false;
          this.checkboxlistGrupos.Enabled = false;
        }
      }
    }

    private void validate()
    {
      if (this.textNombre.Text == string.Empty)
        throw new Exception("El campo nombre es obligatorio");
      if (this.textLogin.Text == string.Empty)
        throw new Exception("El campo login es obligatorio");
      if (this.textPassword.Text != string.Empty || !((string) this.Session["Usuarios.Tipo"] == "1") && !((string) this.Session["Usuarios.Tipo"] == "2") && !((string) this.Session["Usuarios.Tipo"] == "3"))
      {
        if (this.textPassword.Text == string.Empty)
          throw new Exception("El campo password es obligatorio");
        if (this.textPassword.Text.Length < 8)
          throw new Exception("La longitud de la contraseña debe ser de al menos 8 caracteres");
        bool flag1 = false;
        bool flag2 = false;
        bool flag3 = false;
        foreach (char ch in this.textPassword.Text)
        {
          if (!flag1)
            flag1 = ch >= 'a' && ch <= 'z';
          if (!flag2)
            flag2 = ch >= 'A' && ch <= 'Z';
          if (!flag3)
            flag3 = ch >= '0' && ch <= '9';
        }
        if (!flag1 || !flag2 || !flag3)
          throw new Exception("La contraseña debe contener al menos una letra mayúscula, una letra minúscula y un dígito");
        if (this.textPassword.Text != this.textPassword2.Text)
          throw new Exception("La confirmación de la contraseña no coincide");
      }
      if (this.comboUnidad.SelectedValue == "-1")
        throw new Exception("Debe seleccionar la unidad: UTO o una regional");
    }

    protected void buttonGuardar_Click(object sender, EventArgs e)
    {
      try
      {
        this.validate();
        string password = CCryptor.Encrypt(!string.IsNullOrEmpty(this.textPassword.Text) ? this.textPassword.Text : (this.Session["Usuarios.Password"] == null ? "" : this.Session["Usuarios.Password"].ToString()), CSeguridad.key);
        BUsuarios busuarios = new BUsuarios();
        List<int> grupos = new List<int>();
        foreach (ListItem listItem in this.checkboxlistGrupos.Items)
        {
          if (listItem.Selected)
            grupos.Add(Convert.ToInt32(listItem.Value));
        }
        if (this.Session["Usuarios.Tipo"].ToString() == "0")
          busuarios.crearUsuario(this.textLogin.Text.Trim(), this.textNombre.Text.Trim(), password, int.Parse(this.comboUnidad.SelectedValue), this.checkActivo.Checked ? 1 : 0, grupos, this.Usuario.id);
        if (this.Session["Usuarios.Tipo"].ToString() == "1" || this.Session["Usuarios.Tipo"].ToString() == "2")
          busuarios.actualizarUsuario((int) this.ViewState["Usuarios.idusuario"], this.textLogin.Text, this.textNombre.Text, password, int.Parse(this.comboUnidad.SelectedValue), this.checkActivo.Checked ? 1 : 0, grupos, this.Usuario.id);
        if (this.Session["Usuarios.Tipo"].ToString() == "2")
          this.Response.Redirect("~/Default.aspx");
        else
          this.Response.Redirect("~/Seguridad/UsuariosBuscar.aspx");
      }
      catch (Exception ex)
      {
        this.labelError.Text = CException.getWebMessage(ex);
      }
    }

    protected void ButtonCancelar_Click(object sender, EventArgs e)
    {
      if (this.Session["Usuarios.Tipo"].ToString() == "2")
        this.Response.Redirect("~/Default.aspx");
      else
        this.Response.Redirect("~/Seguridad/UsuariosBuscar.aspx");
    }
  }
}
