// Decompiled with JetBrains decompiler
// Type: UTO.Certificacion.BuscarEmpresas
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using DevExpress.Web;
using Seguridad.Servicio;
using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UTO.Certificacion
{
  public class BuscarEmpresas : BaseModulo
  {
    protected System.Web.UI.ScriptManager ScriptManager1;
    protected Label labelBusquedaEmpresas;
    protected ControlError ControlError1;
    protected Label labelparametros;
    protected Label labelNit;
    protected TextBox textNit;
    protected Label labelNombre;
    protected TextBox textNombre;
    protected Button buttonBuscar;
    protected Button buttonAdicionar;
    protected Button buttonExportar;
    protected ASPxGridView gvConsulta;
    protected ASPxGridViewExporter exportGrid;
    protected GridView gridBuscarEmpresa;
    protected SqlDataSource empresaBuscarDataSource;

    protected void Page_Load(object sender, EventArgs e)
    {
      this.buttonBuscar.Enabled = this.Usuario.permiteOperacion(EPermiso.BuscarEmpresa);
      this.buttonAdicionar.Enabled = this.Usuario.permiteOperacion(EPermiso.AdicionarEmpresa);
      this.gridBuscarEmpresa.Columns[0].Visible = this.Usuario.permiteOperacion(EPermiso.BuscarEmpresa);
      this.gridBuscarEmpresa.Columns[1].Visible = this.Usuario.permiteOperacion(EPermiso.ModificarEmpresa);
      this.gridBuscarEmpresa.Columns[2].Visible = this.Usuario.permiteOperacion(EPermiso.EliminarEmpresa);
      this.ControlError1.Visible = false;
    }

    protected void buttonAdicionar_Click(object sender, EventArgs e)
    {
      this.SendParams = (object) new BaseModulo.strSendParam()
      {
        id = 0,
        tipo = "Modificar"
      };
      this.Response.Redirect("~/Certificacion/EmpresasRegistrar.aspx");
    }

    protected void gridBuscarEmpresa_RowCommand(object sender, GridViewCommandEventArgs e)
    {
      if (e.CommandName.Equals("Ver"))
      {
        this.SendParams = (object) new BaseModulo.strSendParam()
        {
          id = int.Parse(this.gridBuscarEmpresa.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString()),
          tipo = "Ver"
        };
        this.Response.Redirect("~/Certificacion/EmpresasRegistrar.aspx");
      }
      if (e.CommandName.Equals("Modificar"))
      {
        this.SendParams = (object) new BaseModulo.strSendParam()
        {
          id = int.Parse(this.gridBuscarEmpresa.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString()),
          tipo = "Modificar"
        };
        this.Response.Redirect("~/Certificacion/EmpresasRegistrar.aspx");
      }
      if (!e.CommandName.Equals("Eliminar"))
        return;
      try
      {
        int pageIndex = this.gridBuscarEmpresa.PageIndex;
        int pageSize = this.gridBuscarEmpresa.PageSize;
        int idTercero = int.Parse(this.gridBuscarEmpresa.DataKeys[int.Parse((string) e.CommandArgument) - pageIndex * pageSize].Value.ToString());
        if (CCertificacion.EliminarEmpresa(idTercero, this.MyDataContext.Connection.ConnectionString) != 0)
          throw new Exception("No se pudo eliminar la empresa");
        this.gridBuscarEmpresa.DataSource = (object) null;
        this.gridBuscarEmpresa.DataBind();
        foreach (DataControlField column in (StateManagedCollection) this.gridBuscarEmpresa.Columns)
        {
          if (column.HeaderText == "Id")
            column.Visible = false;
        }
        CAuditoria.log(EPermiso.EliminarEmpresa, idTercero.ToString(), "", "", "", "", this.Usuario.id);
      }
      catch (Exception ex)
      {
        this.ControlError1.Visible = true;
        this.ControlError1.Show(ex);
      }
    }

    protected void buttonBuscar_Click(object sender, EventArgs e)
    {
      this.ControlError1.Visible = false;
      try
      {
        this.empresaBuscarDataSource.SelectParameters["documento"].DefaultValue = this.textNit.Text != "" ? this.textNit.Text : "%";
        this.empresaBuscarDataSource.SelectParameters["nombre"].DefaultValue = this.textNombre.Text != "" ? this.textNombre.Text : "%";
        foreach (DataControlField column in (StateManagedCollection) this.gridBuscarEmpresa.Columns)
        {
          if (column.HeaderText == "Id")
            column.Visible = false;
        }
      }
      catch (Exception ex)
      {
        this.ControlError1.Visible = true;
        this.ControlError1.Show(ex);
      }
    }

    protected void buttonExportar_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.gvConsulta.Selection.Count == 0)
        {
          this.exportGrid.ExportedRowType = GridViewExportedRowType.All;
          this.exportGrid.FileName = "Conusulta_" + DateTime.Now.ToString("ddMMyyyyHHmmss");
        }
        this.exportGrid.WriteXlsxToResponse();
      }
      catch (Exception ex)
      {
      }
    }
  }
}
