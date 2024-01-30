// Decompiled with JetBrains decompiler
// Type: UTO.Comunes.Aduana
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using AjaxControlToolkit;
using System;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace UTO.Comunes
{
  public class Aduana : BaseModulo
  {
    protected ToolkitScriptManager ToolkitScriptManager1;
    protected Label labelAduana;
    protected ControlError ControlError1;
    protected GridView gridAduana;
    protected SqlDataSource SqlDataAduana;

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
        sqlCommand.Connection = new SqlConnection(this.SqlDataAduana.ConnectionString);
        sqlCommand.CommandText = "select max(adu_Id) from [Uto].[adu_Aduana]";
        sqlCommand.Connection.Open();
        this.SqlDataAduana.InsertParameters["adu_Id"].DefaultValue = ((int) sqlCommand.ExecuteScalar() + 1).ToString();
        this.SqlDataAduana.InsertParameters["adu_Descripcion"].DefaultValue = "Nueva descripcion";
        this.SqlDataAduana.Insert();
        this.gridAduana.DataBind();
      }
      catch (Exception ex)
      {
        this.ControlError1.Show(new Exception("Error al Insertar", ex));
      }
    }

    protected void gridAduana_PreRender(object sender, EventArgs e)
    {
      for (int index = 0; index < this.gridAduana.Rows.Count - 1; ++index)
        this.gridAduana.Rows[index].Cells[2].Controls[1].Visible = false;
    }

    protected void gridAduana_RowCommand(object sender, GridViewCommandEventArgs e)
    {
      if (!e.CommandName.Equals("Eliminar"))
        return;
      try
      {
        this.ControlError1.Hide();
        int pageIndex = this.gridAduana.PageIndex;
        int pageSize = this.gridAduana.PageSize;
        this.SqlDataAduana.DeleteParameters["adu_Id"].DefaultValue = int.Parse(this.gridAduana.DataKeys[int.Parse((string) e.CommandArgument) - pageIndex * pageSize].Value.ToString()).ToString();
        this.SqlDataAduana.Delete();
        this.SqlDataAduana.DataBind();
      }
      catch (Exception ex)
      {
        this.ControlError1.Visible = true;
        this.ControlError1.Show(new Exception("No se puede eliminar el registro porque se está usando. </br>" + ex.Message));
      }
    }
  }
}
