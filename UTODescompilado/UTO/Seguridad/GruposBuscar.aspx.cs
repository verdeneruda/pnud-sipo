// Decompiled with JetBrains decompiler
// Type: UTO.Seguridad.GruposBuscar
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using Seguridad.Datos;
using Seguridad.Servicio;
using System;
using System.Web;
using System.Web.UI.WebControls;

namespace UTO.Seguridad
{
  public class GruposBuscar : BaseSeguridad
  {
    protected Label LabelBuscarGrupos;
    protected Label labelError;
    protected GridView gridBuscarGrupo;
    protected Button buttonBuscarGrupo;
    protected Button buttonAdicionar;
    protected SqlDataSource SqlDataGrupo;

    protected void Page_Load(object sender, EventArgs e)
    {
      this.buttonBuscarGrupo.Enabled = this.Usuario.permiteOperacion(EPermiso.BuscarGrupos);
      this.buttonAdicionar.Enabled = this.Usuario.permiteOperacion(EPermiso.AdicionarGrupos);
      this.gridBuscarGrupo.Columns[0].Visible = this.Usuario.permiteOperacion(EPermiso.ModificarGrupos);
      this.gridBuscarGrupo.Columns[1].Visible = this.Usuario.permiteOperacion(EPermiso.EliminarGrupos);
      this.gridBuscarGrupo.Columns[2].Visible = this.Usuario.permiteOperacion(EPermiso.BuscarGrupos);
    }

    protected void buttonAdicionar_Click(object sender, EventArgs e)
    {
      this.Session["Grupos.Tipo"] = (object) "0";
      this.Response.Redirect("~/Seguridad/Grupos.aspx");
    }

    protected void buttonBuscarGrupo_Click(object sender, EventArgs e)
    {
      this.labelError.Text = string.Empty;
      BGrupos bgrupos = new BGrupos();
      try
      {
        this.SqlDataGrupo.SelectCommand = bgrupos.todosGruposString();
        this.SqlDataGrupo.ConnectionString = CConfig.connectionSecurity().ConnectionString;
        this.gridBuscarGrupo.DataBind();
        this.labelError.Text = string.Empty;
      }
      catch (Exception ex)
      {
        this.labelError.Text = ex.Message;
      }
    }

    protected void gridBuscarGrupo_RowCommand(object sender, GridViewCommandEventArgs e)
    {
      if (e.CommandName.Equals("Modificar"))
      {
        this.Session["Grupos.Tipo"] = (object) "1";
        this.Session["Grupos.idGrupo"] = (object) HttpUtility.HtmlDecode(this.gridBuscarGrupo.Rows[Convert.ToInt32(e.CommandArgument)].Cells[3].Text);
        this.Response.Redirect("~/Seguridad/Grupos.aspx");
      }
      if (e.CommandName.Equals("Eliminar"))
      {
        this.Session["Grupos.Tipo"] = (object) "2";
        BGrupos bgrupos = new BGrupos();
        int int32 = Convert.ToInt32(HttpUtility.HtmlDecode(this.gridBuscarGrupo.Rows[Convert.ToInt32(e.CommandArgument)].Cells[3].Text));
        try
        {
          bgrupos.eliminarGrupos(int32);
          this.SqlDataGrupo.SelectCommand = bgrupos.todosGruposString();
          this.SqlDataGrupo.ConnectionString = CConfig.connectionSecurity().ConnectionString;
          this.gridBuscarGrupo.DataBind();
          this.labelError.Text = string.Empty;
        }
        catch (Exception ex)
        {
          this.labelError.Text = ex.Message;
        }
      }
      if (!e.CommandName.Equals("Ver"))
        return;
      this.Session["Grupos.Tipo"] = (object) "3";
      this.Session["Grupos.idGrupo"] = (object) HttpUtility.HtmlDecode(this.gridBuscarGrupo.Rows[Convert.ToInt32(e.CommandArgument)].Cells[3].Text);
      this.Response.Redirect("~/Seguridad/Grupos.aspx");
    }

    protected void gridBuscarGrupo_RowDataBound(object sender, GridViewRowEventArgs e)
    {
    }
  }
}
