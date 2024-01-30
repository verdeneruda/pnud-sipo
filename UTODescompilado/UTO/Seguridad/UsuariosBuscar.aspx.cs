// Decompiled with JetBrains decompiler
// Type: UTO.Seguridad.BuscarUsuarios
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using Seguridad.Datos;
using Seguridad.Servicio;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI.WebControls;

namespace UTO.Seguridad
{
  public class BuscarUsuarios : BaseSeguridad
  {
    protected Label LabelBuscarUsuarios;
    protected Label labelError;
    protected Label labelNombreUsuario;
    protected TextBox textNombreUsuario;
    protected Label labelNombres;
    protected TextBox textNombres;
    protected Label labelModulo;
    protected DropDownList comboModulo;
    protected Label labelGrupo;
    protected DropDownList comboGrupo;
    protected Button buttonBuscar;
    protected Button buttonAdicionar;
    protected GridView gribuscarusuario;
    protected SqlDataSource SqlDataUsuario;

    protected void Page_Load(object sender, EventArgs e)
    {
      this.buttonBuscar.Enabled = this.Usuario.permiteOperacion(EPermiso.BuscarUsuarios);
      this.buttonAdicionar.Enabled = this.Usuario.permiteOperacion(EPermiso.AdicionarUsuarios);
      this.gribuscarusuario.Columns[0].Visible = this.Usuario.permiteOperacion(EPermiso.ModificarUsuarios);
      this.gribuscarusuario.Columns[1].Visible = this.Usuario.permiteOperacion(EPermiso.EliminarUsuarios);
      this.gribuscarusuario.Columns[2].Visible = this.Usuario.permiteOperacion(EPermiso.BuscarUsuarios);
      if (!this.IsPostBack)
        return;
      this.Buscar();
    }

    protected void Buscar()
    {
      BUsuarios busuarios = new BUsuarios();
      if (this.LocalInfo.GetData("login") == null)
        return;
      this.SqlDataUsuario.SelectCommand = busuarios.buscarUsuariosString((string) this.LocalInfo.GetData("login"), (string) this.LocalInfo.GetData("nombres"), (List<int>) this.LocalInfo.GetData("lModulo"), (List<int>) this.LocalInfo.GetData("lGrupo"));
      if (!string.IsNullOrEmpty((string) this.LocalInfo.GetData("login")))
        this.SqlDataUsuario.SelectParameters.Add("login", (string) this.LocalInfo.GetData("login"));
      if (!string.IsNullOrEmpty((string) this.LocalInfo.GetData("nombres")))
        this.SqlDataUsuario.SelectParameters.Add("nombres", (string) this.LocalInfo.GetData("nombres"));
    }

    protected void buttonBuscar_Click(object sender, EventArgs e)
    {
      this.labelError.Text = string.Empty;
      BUsuarios busuarios = new BUsuarios();
      List<int> grupos = new List<int>();
      List<int> modulos = new List<int>();
      if (this.comboGrupo.SelectedValue == "-1")
        grupos.Clear();
      if (this.comboModulo.SelectedValue == "-1")
        modulos.Clear();
      if (this.comboGrupo.SelectedValue == "0")
      {
        grupos.Clear();
        foreach (ListItem listItem in this.comboGrupo.Items)
          grupos.Add(Convert.ToInt32(listItem.Value));
      }
      else if (this.comboGrupo.SelectedValue != "0" && this.comboGrupo.SelectedValue != "-1")
      {
        grupos.Clear();
        grupos.Add(Convert.ToInt32(this.comboGrupo.SelectedValue));
      }
      if (this.comboModulo.SelectedValue == "0")
      {
        modulos.Clear();
        foreach (ListItem listItem in this.comboModulo.Items)
          modulos.Add(Convert.ToInt32(listItem.Value));
      }
      else if (this.comboModulo.SelectedValue != "0" && this.comboModulo.SelectedValue != "-1")
      {
        modulos.Clear();
        modulos.Add(Convert.ToInt32(this.comboModulo.SelectedValue));
      }
      try
      {
        this.LocalInfo.SetData("login", (object) this.textNombreUsuario.Text.Trim());
        this.LocalInfo.SetData("nombres", (object) this.textNombres.Text.Trim());
        this.LocalInfo.SetData("lModulo", (object) modulos);
        this.LocalInfo.SetData("lGrupo", (object) grupos);
        this.LocalInfo.SetData("SelectCommand", (object) busuarios.buscarUsuariosString(this.textNombreUsuario.Text.Trim(), this.textNombres.Text.Trim(), modulos, grupos));
        this.Buscar();
      }
      catch (Exception ex)
      {
        this.labelError.Text = ex.Message;
      }
    }

    protected void gribuscarusuario_RowCommand(object sender, GridViewCommandEventArgs e)
    {
      BUsuarios busuarios = new BUsuarios();
      if (e.CommandName == "Actualizar")
      {
        this.Session["Usuarios.Tipo"] = (object) "1";
        this.Session["Usuarios.IdUsuario"] = (object) HttpUtility.HtmlDecode(this.gribuscarusuario.Rows[Convert.ToInt32(e.CommandArgument)].Cells[3].Text);
        this.Response.Redirect("~/Seguridad/Usuarios.aspx");
      }
      if (e.CommandName == "Eliminar")
      {
        try
        {
          busuarios.eliminarUsuario(Convert.ToInt32(HttpUtility.HtmlDecode(this.gribuscarusuario.Rows[Convert.ToInt32(e.CommandArgument)].Cells[3].Text)), this.Usuario.id);
          this.labelError.Text = string.Empty;
        }
        catch (Exception ex)
        {
          this.labelError.Text = ex.Message;
        }
      }
      if (!(e.CommandName == "Ver"))
        return;
      this.Session["Usuarios.Tipo"] = (object) "3";
      this.Session["Usuarios.IdUsuario"] = (object) HttpUtility.HtmlDecode(this.gribuscarusuario.Rows[Convert.ToInt32(e.CommandArgument)].Cells[3].Text);
      this.Response.Redirect("~/Seguridad/Usuarios.aspx");
    }

    protected void buttonAdicionar_Click(object sender, EventArgs e)
    {
      this.Session["Usuarios.Tipo"] = (object) "0";
      this.Response.Redirect("~/Seguridad/Usuarios.aspx");
    }

    protected void comboModulo_Init(object sender, EventArgs e)
    {
      this.comboModulo.Items.Clear();
      this.comboModulo.DataSource = (object) CSeguridad.getModulo();
      this.comboModulo.DataValueField = "MOD_ID";
      this.comboModulo.DataTextField = "MOD_NOMBRE";
      this.comboModulo.DataBind();
      this.comboModulo.Items.Insert(0, "Seleccione...");
      this.comboModulo.Items[0].Value = "-1";
      this.comboModulo.Items.Insert(1, "Todos");
      this.comboModulo.Items[1].Value = "0";
    }

    protected void comboGrupo_Init(object sender, EventArgs e)
    {
      this.comboGrupo.Items.Clear();
      this.comboGrupo.DataSource = (object) CSeguridad.getGrupos();
      this.comboGrupo.DataValueField = "GRU_ID";
      this.comboGrupo.DataTextField = "GRU_NOMBRE";
      this.comboGrupo.DataBind();
      this.comboGrupo.Items.Insert(0, "Seleccione...");
      this.comboGrupo.Items[0].Value = "-1";
      this.comboGrupo.Items.Insert(1, "Todos");
      this.comboGrupo.Items[1].Value = "0";
    }

    protected void gribuscarusuario_RowDataBound(object sender, GridViewRowEventArgs e)
    {
    }
  }
}
