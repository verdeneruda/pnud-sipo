// Decompiled with JetBrains decompiler
// Type: UTO.Seguridad.BuscarAuditoria
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using AjaxControlToolkit;
using Seguridad.Datos;
using Seguridad.Servicio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web.UI.WebControls;

namespace UTO.Seguridad
{
  public class BuscarAuditoria : BaseSeguridad
  {
    protected ToolkitScriptManager ToolkitScriptManager1;
    protected Label LabelConsultaAuditoria;
    protected Label labelError;
    protected Label labelModulo;
    protected DropDownList comboModulo;
    protected Label labelOperacion;
    protected DropDownList comboOperacion;
    protected Label labelUsuario;
    protected DropDownList comboUsuario;
    protected CalendarExtender CalendarExtender1;
    protected Label labelFechaInicial;
    protected CalendarExtender CalendarExtender3;
    protected TextBox textFechaInicial;
    protected Label labelFechaFinal;
    protected TextBox textFechaFinal;
    protected Label labelKey1;
    protected TextBox textKey1;
    protected Label labelKey2;
    protected TextBox textKey2;
    protected Label labelKey3;
    protected TextBox textKey3;
    protected Label labelKey4;
    protected TextBox textKey4;
    protected Button buttonBuscar;
    protected GridView gridBuscarAuditoria;

    protected void Page_Load(object sender, EventArgs e) => this.buttonBuscar.Enabled = this.Usuario.permiteOperacion(EPermiso.ConsultaAuditoria);

    protected void buttonBuscar_Click(object sender, EventArgs e)
    {
      List<int> modulos = new List<int>();
      List<int> operaciones = new List<int>();
      List<int> usuarios = new List<int>();
      BAuditoria bauditoria = new BAuditoria();
      if (this.textFechaInicial.Text != string.Empty && this.textFechaFinal.Text != string.Empty && Convert.ToDateTime(this.textFechaInicial.Text) > Convert.ToDateTime(this.textFechaFinal.Text))
      {
        this.labelError.Text = "La fecha incicial debe ser menor o igual que la fecha final";
      }
      else
      {
        if (this.comboModulo.SelectedValue == "-1")
          modulos.Clear();
        else if (this.comboModulo.SelectedValue != "-1" || this.comboModulo.SelectedValue != "0")
        {
          modulos.Clear();
          modulos.Add(Convert.ToInt32(this.comboModulo.SelectedValue));
        }
        if (this.comboOperacion.SelectedValue == "-1")
          operaciones.Clear();
        else if (this.comboOperacion.SelectedValue != "-1" || this.comboOperacion.SelectedValue != "0")
        {
          operaciones.Clear();
          operaciones.Add(Convert.ToInt32(this.comboOperacion.SelectedValue));
        }
        if (this.comboUsuario.SelectedValue == "-1")
          usuarios.Clear();
        else if (this.comboUsuario.SelectedValue != "-1" || this.comboUsuario.SelectedValue != "0")
        {
          usuarios.Clear();
          usuarios.Add(Convert.ToInt32(this.comboUsuario.SelectedValue));
        }
        if (this.comboModulo.SelectedValue == "0")
        {
          modulos.Clear();
          foreach (ListItem listItem in this.comboModulo.Items)
          {
            if (!(listItem.Value == "0") && !(listItem.Value == "-1"))
              modulos.Add(Convert.ToInt32(listItem.Value));
          }
        }
        if (this.comboOperacion.SelectedValue == "0")
        {
          operaciones.Clear();
          foreach (ListItem listItem in this.comboOperacion.Items)
          {
            if (!(listItem.Value == "0") && !(listItem.Value == "-1"))
              operaciones.Add(Convert.ToInt32(listItem.Value));
          }
        }
        if (this.comboUsuario.SelectedValue == "0")
        {
          usuarios.Clear();
          foreach (ListItem listItem in this.comboUsuario.Items)
          {
            if (!(listItem.Value == "0") && !(listItem.Value == "-1"))
              usuarios.Add(Convert.ToInt32(listItem.Value));
          }
        }
        try
        {
          DataTable auditoria = bauditoria.getAuditoria(usuarios, modulos, operaciones, this.textFechaInicial.Text.Trim(), this.textFechaFinal.Text.Trim(), this.textKey1.Text.Trim(), this.textKey2.Text.Trim(), this.textKey3.Text.Trim(), this.textKey4.Text.Trim());
          this.gridBuscarAuditoria.DataSource = (object) auditoria;
          this.LocalInfo.SetData("dt", (object) auditoria);
          this.gridBuscarAuditoria.DataBind();
          this.labelError.Text = string.Empty;
        }
        catch (Exception ex)
        {
          this.labelError.Text = ex.Message;
        }
      }
    }

    protected void comboModulo_Init(object sender, EventArgs e)
    {
      this.comboModulo.DataSource = (object) CSeguridad.getModulo();
      this.comboModulo.DataTextField = "MOD_NOMBRE";
      this.comboModulo.DataValueField = "MOD_ID";
      this.comboModulo.DataBind();
      this.comboModulo.Items.Insert(0, "Seleccione...");
      this.comboModulo.Items[0].Value = "-1";
      this.comboModulo.Items.Insert(1, "Todos");
      this.comboModulo.Items[1].Value = "0";
    }

    protected void comboUsuario_Init(object sender, EventArgs e)
    {
      this.comboUsuario.DataSource = (object) CSeguridad.getUsuarios();
      this.comboUsuario.DataTextField = "USU_LOGIN";
      this.comboUsuario.DataValueField = "USU_ID";
      this.comboUsuario.DataBind();
      this.comboUsuario.Items.Insert(0, "Seleccione...");
      this.comboUsuario.Items[0].Value = "-1";
      this.comboUsuario.Items.Insert(1, "Todos");
      this.comboUsuario.Items[1].Value = "0";
    }

    protected void comboOperacion_Init(object sender, EventArgs e)
    {
      this.comboOperacion.DataSource = (object) CSeguridad.getOperacion();
      this.comboOperacion.DataTextField = "OPE_NOMBRE";
      this.comboOperacion.DataValueField = "OPE_ID";
      this.comboOperacion.DataBind();
      this.comboOperacion.Items.Insert(0, "Seleccione...");
      this.comboOperacion.Items[0].Value = "-1";
      this.comboOperacion.Items.Insert(1, "Todos");
      this.comboOperacion.Items[1].Value = "0";
    }

    protected void comboOperacion_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.comboOperacion.SelectedValue != "-1" && this.comboOperacion.SelectedValue != "0")
      {
        DataTable keys = new BAuditoria().getKeys(Convert.ToInt32(this.comboOperacion.SelectedValue));
        int index = 0;
        int num = 1;
        while (index < keys.Rows[0].ItemArray.Length)
        {
          if (keys.Rows[0].ItemArray[index].ToString() != "")
          {
            ((Label) this.Page.Controls[0].Controls[0].FindControl("cphMain").FindControl("labelKey" + Convert.ToString(num))).Text = keys.Rows[0].ItemArray[index].ToString();
          }
          else
          {
            this.Page.Controls[0].Controls[0].FindControl("cphMain").FindControl("labelKey" + Convert.ToString(num)).Visible = false;
            this.Page.Controls[0].Controls[0].FindControl("cphMain").FindControl("textKey" + Convert.ToString(num)).Visible = false;
          }
          ++index;
          ++num;
        }
      }
      if (!(this.comboOperacion.SelectedValue == "-1") && !(this.comboOperacion.SelectedValue == "0"))
        return;
      this.labelKey1.Text = "Key 1";
      this.labelKey2.Text = "Key 2";
      this.labelKey3.Text = "key 3";
      this.labelKey4.Text = "key 4";
      this.labelKey1.Visible = true;
      this.labelKey2.Visible = true;
      this.labelKey3.Visible = true;
      this.labelKey4.Visible = true;
      this.textKey1.Visible = true;
      this.textKey2.Visible = true;
      this.textKey3.Visible = true;
      this.textKey4.Visible = true;
    }

    protected void gridBuscarAuditoria_RowDataBound(object sender, GridViewRowEventArgs e) => e.Row.Cells[0].Visible = false;

    protected void gridBuscarAuditoria_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
      this.gridBuscarAuditoria.PageIndex = e.NewPageIndex;
      this.gridBuscarAuditoria.DataSource = (object) (DataTable) this.LocalInfo.GetData("dt");
      this.gridBuscarAuditoria.DataBind();
    }
  }
}
