// Decompiled with JetBrains decompiler
// Type: UTO.Seguridad.MiCuenta
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.Web.UI.HtmlControls;

namespace UTO.Seguridad
{
  public class MiCuenta : BaseSeguridad
  {
    protected HtmlForm form1;

    protected void Page_Load(object sender, EventArgs e)
    {
      this.Session["Usuarios.Tipo"] = (object) "2";
      this.Session["Usuarios.IdUsuario"] = (object) this.Usuario.id;
      this.Response.Redirect("~/Seguridad/Usuarios.aspx");
    }
  }
}
