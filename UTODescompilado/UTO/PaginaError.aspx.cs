// Decompiled with JetBrains decompiler
// Type: UTO.PaginaError
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UTO
{
  public class PaginaError : Page
  {
    protected Label Label1;
    protected Label labelError;

    protected void Page_Load(object sender, EventArgs e)
    {
      if (this.IsPostBack || this.Session["PaginaError.MensajeError"] == null)
        return;
      this.labelError.Text = this.Session["PaginaError.MensajeError"].ToString();
      this.Session["PaginaError.MensajeError"] = (object) null;
      this.Session.Remove("PaginaError.MensajeError");
    }

    protected void Page_Error(object sender, EventArgs e)
    {
    }
  }
}
