// Decompiled with JetBrains decompiler
// Type: UTO.ControlError
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UTO
{
  public class ControlError : UserControl
  {
    protected Panel panelError;
    protected Label labelError;
    protected Button buttonMasInfo;
    protected UpdatePanel UpdatePanel1;
    protected Panel panelException;
    protected Label labelException;
    protected Button buttonOcultar;

    protected void Page_Load(object sender, EventArgs e)
    {
    }

    public void Show(string message, string extraInfo)
    {
      this.panelError.Visible = true;
      this.labelError.Text = message;
      this.labelException.Text = extraInfo;
    }

    public void Show(Exception ex)
    {
      this.panelError.Visible = true;
      this.labelError.Text = ex.Message;
      this.labelException.Text = this.innerText(ex.InnerException);
    }

    private string innerText(Exception exception) => exception == null ? "" : exception.Message + "<br />" + this.innerText(exception.InnerException);

    public void Hide()
    {
      this.panelException.Visible = false;
      this.labelException.Text = "";
      this.panelError.Visible = false;
      this.labelError.Text = "";
    }

    protected void buttonMasInfo_Click(object sender, EventArgs e)
    {
      this.panelException.Visible = true;
      this.buttonOcultar.Visible = true;
    }

    protected void buttonOcultar_Click(object sender, EventArgs e)
    {
      this.panelException.Visible = false;
      this.buttonOcultar.Visible = false;
    }
  }
}
