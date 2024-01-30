// Decompiled with JetBrains decompiler
// Type: UTO.Comunes.Sustancia
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using AjaxControlToolkit;
using System;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace UTO.Comunes
{
  public class Sustancia : BaseModulo
  {
    protected ToolkitScriptManager ToolkitScriptManager1;
    protected Label labelSustancia;
    protected ControlError ControlError1;
    protected GridView gridCatalogo;
    protected SqlDataSource SqlDataSustancia;

    protected new void Page_Load(object sender, EventArgs e)
    {
      this.ControlError1.Hide();
      if (this.IsPostBack)
        return;
      this.InitData();
    }

    public void InitData()
    {
    }

    protected void gridAduana_PreRender(object sender, EventArgs e)
    {
    }

    protected void LinkNuevo_Click(object sender, EventArgs e)
    {
      try
      {
        this.ControlError1.Hide();
        SqlCommand sqlCommand = new SqlCommand();
        sqlCommand.Connection = new SqlConnection(this.SqlDataSustancia.ConnectionString);
        sqlCommand.CommandText = "select max(sus_Id) from uto.sus_sustancia";
        sqlCommand.Connection.Open();
        sus_Sustancia susSustancia = new sus_Sustancia()
        {
          sus_Id = 0,
          sus_Arancel = "",
          sus_Descripcion = ""
        };
        lock (this)
        {
          this.SqlDataSustancia.InsertParameters["sus_Id"].DefaultValue = ((int) sqlCommand.ExecuteScalar() + 1).ToString();
          this.SqlDataSustancia.InsertParameters["sus_Arancel"].DefaultValue = "Nuevo arancel";
          this.SqlDataSustancia.InsertParameters["sus_Descripcion"].DefaultValue = "Nueva descripción";
          this.SqlDataSustancia.Insert();
        }
        this.gridCatalogo.DataBind();
      }
      catch (Exception ex)
      {
        this.ControlError1.Visible = true;
        this.ControlError1.Show(new Exception("Error al Insertar", ex));
      }
    }

    protected void gridSustancia_PreRender(object sender, EventArgs e)
    {
      for (int index = 0; index < this.gridCatalogo.Rows.Count - 1; ++index)
        this.gridCatalogo.Rows[index].Cells[2].Controls[1].Visible = false;
    }

    protected void gridCatalogo_RowCommand(object sender, GridViewCommandEventArgs e)
    {
      if (!e.CommandName.Equals("Eliminar"))
        return;
      try
      {
        this.ControlError1.Hide();
        int pageIndex = this.gridCatalogo.PageIndex;
        int pageSize = this.gridCatalogo.PageSize;
        this.SqlDataSustancia.DeleteParameters["sus_Id"].DefaultValue = int.Parse(this.gridCatalogo.DataKeys[int.Parse((string) e.CommandArgument) - pageIndex * pageSize].Value.ToString()).ToString();
        this.SqlDataSustancia.Delete();
        this.gridCatalogo.DataBind();
      }
      catch (Exception ex)
      {
        this.ControlError1.Visible = true;
        this.ControlError1.Show(new Exception("No se puede eliminar el registro porque se está usando. </br>" + ex.Message));
      }
    }
  }
}
