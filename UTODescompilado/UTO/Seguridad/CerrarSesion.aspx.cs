// Decompiled with JetBrains decompiler
// Type: UTO.Seguridad.CerrarSesion
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using Seguridad.Servicio;
using System;
using System.Web.UI;
using System.Web.UI.HtmlControls;

namespace UTO.Seguridad
{
  public class CerrarSesion : Page
  {
    protected HtmlForm form1;

    protected void Page_Load(object sender, EventArgs e)
    {
      if (this.Session["Usuario"] is CUsuario cusuario)
        CAuditoria.log(EPermiso.CerrarSesion, cusuario.id.ToString(), cusuario.login, "", "", "", cusuario.id);
      this.Session.Clear();
      this.Session.Abandon();
      this.Response.Redirect("~/Default.aspx");
    }
  }
}
