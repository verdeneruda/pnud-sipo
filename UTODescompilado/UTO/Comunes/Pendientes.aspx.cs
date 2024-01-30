// Decompiled with JetBrains decompiler
// Type: UTO.Comunes.PendientesCertificacion
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.Web.UI.WebControls;

namespace UTO.Comunes
{
  public class PendientesCertificacion : BaseComunes
  {
    protected XmlDataSource xmlpendientes;
    protected System.Web.UI.ScriptManager ScriptManager1;
    protected Label labelPendientes;
    protected ControlError ControlError1;
    protected Label labelAlertas;
    protected CheckBox checkTodo;
    protected CheckBox checkVerde;
    protected CheckBox checkAmarillo;
    protected CheckBox checkRojo;
    protected Button buttonBuscar;
    protected Button buttonCancelar;
    protected GridView gridPendientes;

    protected new void Page_Load(object sender, EventArgs e)
    {
      this.ControlError1.Visible = false;
      if (this.IsPostBack)
        ;
    }

    protected void buttonBuscar_Click(object sender, EventArgs e)
    {
      string user = "";
      int bandera = -1;
      if (this.checkRojo.Checked)
        bandera = 1;
      if (this.checkAmarillo.Checked)
        bandera += 2;
      if (this.checkVerde.Checked)
        bandera += 4;
      if (this.checkTodo.Checked)
        bandera = 0;
      try
      {
        this.gridPendientes.DataSource = CPendiente.BuscarAlerta(bandera, user, CConfig.readConnString());
        this.gridPendientes.DataBind();
      }
      catch (Exception ex)
      {
      }
    }

    protected void gridPendientes_DataBinding(object sender, EventArgs e)
    {
    }

    protected void gridPendientes_RowDataBound(object sender, GridViewRowEventArgs e)
    {
      if (!int.TryParse(e.Row.Cells[2].Text, out int _))
        return;
      if (int.Parse(e.Row.Cells[2].Text) <= 5)
        e.Row.Cells[1].Text = "<img src=\"../images/RojoSencillo.png\" />";
      if (int.Parse(e.Row.Cells[2].Text) >= 6 && int.Parse(e.Row.Cells[2].Text) <= 30)
        e.Row.Cells[1].Text = "<img src=\"../images/NarangaSencillo.png\" />";
      if (int.Parse(e.Row.Cells[2].Text) > 30)
        e.Row.Cells[1].Text = "<img src=\"../images/VerdeSencillo.png\" />";
    }

    protected void gridPendientes_RowCommand(object sender, GridViewCommandEventArgs e)
    {
      if (!e.CommandName.Equals("Ver"))
        return;
      this.SendParams = (object) new PendientesCertificacion.strSendParam()
      {
        id = int.Parse(this.gridPendientes.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString()),
        tipo = "Ver"
      };
      this.Response.Redirect("~/Certificacion/EmpresasRegistrar.aspx");
    }

    public struct strSendParam
    {
      private int _id;
      private string _tipo;

      public int id
      {
        get => this._id;
        set => this._id = value;
      }

      public string tipo
      {
        get => this._tipo;
        set => this._tipo = value;
      }
    }
  }
}
