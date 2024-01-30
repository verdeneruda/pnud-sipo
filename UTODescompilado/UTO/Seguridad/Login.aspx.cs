// Decompiled with JetBrains decompiler
// Type: UTO.Seguridad.Login
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using DevExpress.Web;
using NE.CLib;
using Seguridad.Servicio;
using System;
using System.Web.UI.WebControls;

namespace UTO.Seguridad
{
  public class Login : BaseSeguridad
  {
    protected Label labelError;
    protected TextBox textName;
    protected TextBox textPassword;
    protected ASPxCaptcha Captcha;
    protected Button buttonLogin;

    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void buttonLogin_Click(object sender, EventArgs e)
    {
      if (!this.Captcha.IsValid)
        return;
      try
      {
        if (string.IsNullOrEmpty(this.textName.Text))
          throw new Exception("Debe ingresar el nombre de usuario");
        CUsuario cusuario = new CUsuario();
        cusuario.autenticar(this.textName.Text, this.textPassword.Text, true);
        if (this.Session["Usuario"] != null)
          this.Session.Remove("Usuario");
        this.Session["Usuario"] = (object) cusuario;
        CAuditoria.log(EPermiso.IniciarSesion, cusuario.id.ToString(), cusuario.login, "", "", "", cusuario.id);
        this.Response.Redirect("~/Default.aspx");
      }
      catch (Exception ex)
      {
        this.labelError.Text = CException.getWebMessage(ex);
      }
    }
  }
}
