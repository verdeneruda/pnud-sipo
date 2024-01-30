// Decompiled with JetBrains decompiler
// Type: UTO.Seguridad.Historico
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using AjaxControlToolkit;
using Seguridad.Datos;
using Seguridad.Servicio;
using System;
using System.Web.UI.WebControls;

namespace UTO.Seguridad
{
  public class Historico : BaseSeguridad
  {
    protected ToolkitScriptManager ToolkitScriptManager1;
    protected Label LabelHistorico;
    protected Label labelError;
    protected Label LabelFechaCorte;
    protected TextBox textFechaCorte;
    protected ImageButton ImageFechaCorte;
    protected CalendarExtender CalendarExtender3;
    protected Button buttonEnviarHistorico;
    protected Label labelmensaje;

    protected void Page_Load(object sender, EventArgs e) => this.buttonEnviarHistorico.Enabled = this.Usuario.permiteOperacion(EPermiso.HistoricoAuditoria);

    protected void buttonEnviarHistorico_Click(object sender, EventArgs e)
    {
      if (this.textFechaCorte.Text == string.Empty)
      {
        this.labelError.Text = "Es requerida la fecha de corte para enviar el o los registros de auditoría al histórico";
      }
      else
      {
        BAuditoriaHistorico bauditoriaHistorico = new BAuditoriaHistorico();
        try
        {
          bauditoriaHistorico.enviarHistoricoAuditoria(this.textFechaCorte.Text);
          this.labelError.Text = string.Empty;
          this.labelmensaje.Text = "Los registros de auditoría hasta la fecha " + this.textFechaCorte.Text + " han sido movidos al histórico con éxito";
        }
        catch (Exception ex)
        {
          this.labelError.Text = ex.Message;
        }
      }
    }
  }
}
