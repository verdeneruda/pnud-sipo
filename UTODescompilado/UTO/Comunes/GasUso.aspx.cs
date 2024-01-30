// Decompiled with JetBrains decompiler
// Type: UTO.Comunes.GasUso
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using AjaxControlToolkit;
using System;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace UTO.Comunes
{
  public class GasUso : BaseModulo
  {
    protected ToolkitScriptManager ToolkitScriptManager1;
    protected Label labelPais;
    protected ControlError ControlError1;
    protected GridView gridCatalogo;
    protected SqlDataSource SqlDataCatalogo;

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

    protected void LinkNuevo_Click(object sender, EventArgs e)
    {
      try
      {
        this.ControlError1.Hide();
        SqlCommand sqlCommand = new SqlCommand();
        sqlCommand.Connection = new SqlConnection(this.SqlDataCatalogo.ConnectionString);
        sqlCommand.CommandText = "select max(gus_Id) from [Rrr].[gus_GasUso]";
        sqlCommand.Connection.Open();
        this.SqlDataCatalogo.InsertParameters["gus_Id"].DefaultValue = ((int) sqlCommand.ExecuteScalar() + 1).ToString();
        this.SqlDataCatalogo.InsertParameters["gus_Descripcion"].DefaultValue = "Nueva descripcion";
        this.SqlDataCatalogo.Insert();
        this.gridCatalogo.DataBind();
      }
      catch (Exception ex)
      {
        this.ControlError1.Visible = true;
        this.ControlError1.Show(new Exception("Error al Insertar", ex));
      }
    }

    protected void gridCatalogo_PreRender(object sender, EventArgs e)
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
        this.SqlDataCatalogo.DeleteParameters["gus_Id"].DefaultValue = int.Parse(this.gridCatalogo.DataKeys[int.Parse((string) e.CommandArgument) - pageIndex * pageSize].Value.ToString()).ToString();
        this.SqlDataCatalogo.Delete();
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
