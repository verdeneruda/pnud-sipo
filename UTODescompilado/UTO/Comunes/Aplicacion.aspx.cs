// Decompiled with JetBrains decompiler
// Type: UTO.Comunes.Aplicacion
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using AjaxControlToolkit;
using System;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace UTO.Comunes
{
  public class Aplicacion : BaseModulo
  {
    protected ToolkitScriptManager ToolkitScriptManager1;
    protected Label labelAduana;
    protected ControlError ControlError1;
    protected GridView gridAplicacion;
    protected SqlDataSource SqlDataAduana;

    protected new void Page_Load(object sender, EventArgs e)
    {
      this.ControlError1.Hide();
      if (this.IsPostBack)
        return;
      this.InitData();
    }

    private void InitData()
    {
    }

    protected void LinkNuevo_Click(object sender, EventArgs e)
    {
      try
      {
        this.ControlError1.Hide();
        SqlCommand sqlCommand = new SqlCommand();
        sqlCommand.Connection = new SqlConnection(this.SqlDataAduana.ConnectionString);
        sqlCommand.CommandText = "select max(apl_Id) from [Rus].[apl_Aplicacion]";
        sqlCommand.Connection.Open();
        this.SqlDataAduana.InsertParameters["apl_Id"].DefaultValue = ((int) sqlCommand.ExecuteScalar() + 1).ToString();
        this.SqlDataAduana.InsertParameters["apl_Descripcion"].DefaultValue = "Nueva descripcion";
        this.SqlDataAduana.Insert();
        this.gridAplicacion.DataBind();
      }
      catch (Exception ex)
      {
        this.ControlError1.Show(new Exception("Error al Insertar", ex));
      }
    }

    protected void gridAplicacion_PreRender(object sender, EventArgs e)
    {
      for (int index = 0; index < this.gridAplicacion.Rows.Count - 1; ++index)
        this.gridAplicacion.Rows[index].Cells[2].Controls[1].Visible = false;
    }

    protected void gridAplicacion_RowCommand(object sender, GridViewCommandEventArgs e)
    {
      if (!e.CommandName.Equals("Eliminar"))
        return;
      try
      {
        this.ControlError1.Hide();
        int pageIndex = this.gridAplicacion.PageIndex;
        int pageSize = this.gridAplicacion.PageSize;
        this.SqlDataAduana.DeleteParameters["apl_Id"].DefaultValue = int.Parse(this.gridAplicacion.DataKeys[int.Parse((string) e.CommandArgument) - pageIndex * pageSize].Value.ToString()).ToString();
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
