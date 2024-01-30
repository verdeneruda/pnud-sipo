// Decompiled with JetBrains decompiler
// Type: UTO.Seguridad.Grupos
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using Seguridad.Datos;
using Seguridad.Servicio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web.UI.WebControls;

namespace UTO.Seguridad
{
  public class Grupos : BaseSeguridad
  {
    protected Label LabelGrupos;
    protected Label labelError;
    protected Label labelNombreGrupo;
    protected TextBox textNombreGrupo;
    protected Label labelActivo;
    protected CheckBox checkActivo;
    protected Label labelUsuariosDisponibles;
    protected Label labelUsuarioGrupos;
    protected ListBox listboxUsuariosDisponibles;
    protected Button buttonAdicionar;
    protected Button buttonEliminar;
    protected ListBox listboxGrupos;
    protected Label labelPermisos;
    protected TreeView treeviewPermisos;
    protected Button buttonGuardar;
    protected Button ButtonCancelar;

    protected void Page_Load(object sender, EventArgs e)
    {
      this.buttonGuardar.Enabled = this.Usuario.permiteOperacion(EPermiso.AdicionarGrupos) || this.Usuario.permiteOperacion(EPermiso.ModificarGrupos);
      if (this.Page.IsPostBack)
        return;
      if (this.Session["Grupos.Tipo"].ToString() == "1" || this.Session["Grupos.Tipo"].ToString() == "3")
      {
        BGrupos bgrupos = new BGrupos();
        DataTable dataTable = bgrupos.getgrupo(Convert.ToInt32(this.Session["Grupos.idGrupo"]));
        this.ViewState["Grupoid"] = (object) Convert.ToInt32(dataTable.Rows[0].ItemArray[0]);
        bool flag = (bool) dataTable.Rows[0].ItemArray[2];
        this.textNombreGrupo.Text = dataTable.Rows[0].ItemArray[1].ToString();
        this.checkActivo.Checked = flag;
        this.listboxGrupos.DataSource = (object) bgrupos.getUsuariosGrupos(Convert.ToInt32(dataTable.Rows[0].ItemArray[0]));
        this.listboxGrupos.DataTextField = "USU_LOGIN";
        this.listboxGrupos.DataValueField = "USU_ID";
        this.listboxGrupos.DataBind();
        for (int index1 = 0; index1 < this.listboxGrupos.Items.Count; ++index1)
        {
          for (int index2 = 0; index2 < this.listboxUsuariosDisponibles.Items.Count; ++index2)
          {
            if (this.listboxUsuariosDisponibles.Items[index2].Value == this.listboxGrupos.Items[index1].Value)
            {
              this.listboxUsuariosDisponibles.Items.Remove(this.listboxUsuariosDisponibles.Items[index2]);
              break;
            }
          }
        }
        foreach (DataRow row in (InternalDataCollectionBase) bgrupos.PermisosGrupo((int) this.ViewState["Grupoid"]).Rows)
        {
          foreach (TreeNode node in this.treeviewPermisos.Nodes)
          {
            foreach (TreeNode childNode in node.ChildNodes)
            {
              if (Convert.ToInt32(row.ItemArray[0]) == Convert.ToInt32(node.Value) && Convert.ToInt32(row.ItemArray[2]) == Convert.ToInt32(childNode.Value))
              {
                childNode.Checked = true;
                goto label_26;
              }
            }
          }
label_26:;
        }
      }
      if (this.Session["Grupos.Tipo"].ToString() == "3")
      {
        this.textNombreGrupo.Enabled = false;
        this.checkActivo.Enabled = false;
        this.listboxUsuariosDisponibles.Enabled = false;
        this.buttonAdicionar.Enabled = false;
        this.buttonEliminar.Enabled = false;
        this.treeviewPermisos.Enabled = false;
      }
    }

    protected void listboxUsuariosDisponibles_Init(object sender, EventArgs e)
    {
      this.listboxUsuariosDisponibles.DataSource = (object) new BGrupos().todosUsuarios();
      this.listboxUsuariosDisponibles.DataTextField = "USU_LOGIN";
      this.listboxUsuariosDisponibles.DataValueField = "USU_ID";
      this.listboxUsuariosDisponibles.DataBind();
    }

    protected void buttonAdicionar_Click(object sender, EventArgs e)
    {
      if (this.listboxUsuariosDisponibles.SelectedItem == null)
        return;
      this.listboxGrupos.Items.Add(this.listboxUsuariosDisponibles.SelectedItem);
      this.listboxUsuariosDisponibles.Items.Remove(this.listboxUsuariosDisponibles.SelectedItem);
      foreach (ListItem listItem in this.listboxGrupos.Items)
        listItem.Selected = false;
    }

    protected void buttonEliminar_Click(object sender, EventArgs e)
    {
      if (this.listboxGrupos.SelectedItem == null)
        return;
      this.listboxUsuariosDisponibles.Items.Add(this.listboxGrupos.SelectedItem);
      this.listboxGrupos.Items.Remove(this.listboxGrupos.SelectedItem);
      foreach (ListItem listItem in this.listboxUsuariosDisponibles.Items)
        listItem.Selected = false;
    }

    protected void treeviewPermisos_Init(object sender, EventArgs e)
    {
      DataTable dataTable = new BGrupos().todosPermisos();
      string str = "";
      bool flag = false;
      int index = 0;
      foreach (DataRow row in (InternalDataCollectionBase) dataTable.Rows)
      {
        if (!flag)
        {
          str = row[1].ToString().Trim();
          this.treeviewPermisos.Nodes.Add(new TreeNode(row[1].ToString().Trim(), row[0].ToString().Trim()));
          this.treeviewPermisos.Nodes[index].ChildNodes.Add(new TreeNode(row[3].ToString().Trim(), row[2].ToString().Trim()));
          flag = true;
        }
        else if (flag && str == row[1].ToString().Trim())
        {
          str = row[1].ToString().Trim();
          this.treeviewPermisos.Nodes[index].ChildNodes.Add(new TreeNode(row[3].ToString().Trim(), row[2].ToString().Trim()));
        }
        else if (flag && str != row[1].ToString().Trim())
        {
          ++index;
          str = row[1].ToString().Trim();
          this.treeviewPermisos.Nodes.Add(new TreeNode(row[1].ToString().Trim(), row[0].ToString().Trim()));
          this.treeviewPermisos.Nodes[index].ChildNodes.Add(new TreeNode(row[3].ToString().Trim(), row[2].ToString().Trim()));
        }
      }
    }

    protected void buttonGuardar_Click(object sender, EventArgs e)
    {
      if (this.textNombreGrupo.Text == string.Empty)
      {
        this.labelError.Text = "El campo Nombre del grupo es obligatorio";
      }
      else
      {
        if (this.Session["Grupos.Tipo"].ToString() == "0")
        {
          BGrupos bgrupos = new BGrupos();
          List<int> usuarios = new List<int>();
          List<int> operaciones = new List<int>();
          foreach (ListItem listItem in this.listboxGrupos.Items)
            usuarios.Add(Convert.ToInt32(listItem.Value));
          foreach (TreeNode node in this.treeviewPermisos.Nodes)
          {
            foreach (TreeNode childNode in node.ChildNodes)
            {
              if (childNode.Checked)
                operaciones.Add(Convert.ToInt32(childNode.Value));
            }
          }
          try
          {
            bgrupos.setGrupo(this.textNombreGrupo.Text.Trim(), this.checkActivo.Checked ? 1 : 0, usuarios, operaciones);
            this.labelError.Text = string.Empty;
            this.Response.Redirect("~/Seguridad/GruposBuscar.aspx");
          }
          catch (Exception ex)
          {
            this.labelError.Text = ex.Message;
          }
        }
        if (this.Session["Grupos.Tipo"].ToString() == "1")
        {
          List<int> usuarios = new List<int>();
          List<int> Permisos = new List<int>();
          BGrupos bgrupos = new BGrupos();
          foreach (ListItem listItem in this.listboxGrupos.Items)
            usuarios.Add(Convert.ToInt32(listItem.Value));
          foreach (TreeNode node in this.treeviewPermisos.Nodes)
          {
            foreach (TreeNode childNode in node.ChildNodes)
            {
              if (childNode.Checked)
                Permisos.Add(Convert.ToInt32(childNode.Value));
            }
          }
          try
          {
            bgrupos.actualizarGrupo((int) this.ViewState["Grupoid"], this.textNombreGrupo.Text, this.checkActivo.Checked ? 1 : 0, usuarios, Permisos);
            this.labelError.Text = string.Empty;
            this.Response.Redirect("~/Seguridad/GruposBuscar.aspx");
          }
          catch (Exception ex)
          {
            this.labelError.Text = ex.Message;
          }
        }
        if (!(this.Session["Grupos.Tipo"].ToString() == "3"))
          return;
        this.Response.Redirect("~/Seguridad/GruposBuscar.aspx");
      }
    }

    protected void ButtonCancelar_Click(object sender, EventArgs e) => this.Response.Redirect("~/Seguridad/GruposBuscar.aspx");
  }
}
