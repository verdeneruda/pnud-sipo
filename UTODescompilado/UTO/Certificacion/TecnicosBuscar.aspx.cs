// Decompiled with JetBrains decompiler
// Type: UTO.Certificacion.BuscarTecnicos
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using AjaxControlToolkit;
using Seguridad.Servicio;
using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UTO.Certificacion
{
  public class BuscarTecnicos : BaseModulo
  {
    protected XmlDataSource xmlTecnicos;
    protected ToolkitScriptManager ToolkitScriptManager1;
    protected Label labelBusquedaTecnico;
    protected ControlError ControlError1;
    protected Label labelparametros;
    protected Label labelDocumento;
    protected TextBox textDocumento;
    protected Label labelNombre;
    protected TextBox textNombre;
    protected Button buttonBuscar;
    protected Button buttonAdicionar;
    protected GridView gridBuscarTecnicos;
    protected SqlDataSource tecnicosBuscarDataSource;

    protected void gridBuscarTecnicos_RowCommand(object sender, GridViewCommandEventArgs e)
    {
      if (e.CommandName.Equals("Modificar"))
      {
        this.SendParams = (object) new BaseModulo.strSendParam()
        {
          id = int.Parse(this.gridBuscarTecnicos.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString()),
          tipo = "Modificar"
        };
        this.Server.Transfer("~/Certificacion/TecnicosRegistrar.aspx");
      }
      if (e.CommandName.Equals("Ver"))
      {
        this.SendParams = (object) new BaseModulo.strSendParam()
        {
          id = int.Parse(this.gridBuscarTecnicos.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString()),
          tipo = "Ver"
        };
        this.Server.Transfer("~/Certificacion/TecnicosRegistrar.aspx");
      }
      if (!e.CommandName.Equals("Eliminar"))
        return;
      try
      {
        int pageIndex = this.gridBuscarTecnicos.PageIndex;
        int pageSize = this.gridBuscarTecnicos.PageSize;
        int idTecnico = int.Parse(this.gridBuscarTecnicos.DataKeys[int.Parse((string) e.CommandArgument) - pageIndex * pageSize].Value.ToString());
        if (CCertificacion.EliminarTecnico(idTecnico, this.MyDataContext.Connection.ConnectionString) != 0)
          throw new Exception("No se pudo eliminar el técnico");
        this.gridBuscarTecnicos.DataSource = (object) null;
        this.gridBuscarTecnicos.DataBind();
        foreach (DataControlField column in (StateManagedCollection) this.gridBuscarTecnicos.Columns)
        {
          if (column.HeaderText == "Id")
            column.Visible = false;
        }
        CAuditoria.log(EPermiso.EliminarTecnico, idTecnico.ToString(), "", "", "", "", this.Usuario.id);
      }
      catch (Exception ex)
      {
        this.ControlError1.Visible = true;
        this.ControlError1.Show(ex);
      }
    }

    protected void buttonAdicionar_Click(object sender, EventArgs e)
    {
      this.SendParams = (object) new BaseModulo.strSendParam()
      {
        id = 0,
        tipo = "Modificar"
      };
      this.Response.Redirect("~/Certificacion/TecnicosRegistrar.aspx");
    }

    protected void Page_Load(object sender, EventArgs e)
    {
      this.buttonBuscar.Enabled = this.Usuario.permiteOperacion(EPermiso.BuscarTecnico);
      this.buttonAdicionar.Enabled = this.Usuario.permiteOperacion(EPermiso.AdicionarTecnico);
      this.gridBuscarTecnicos.Columns[0].Visible = this.Usuario.permiteOperacion(EPermiso.BuscarTecnico);
      this.gridBuscarTecnicos.Columns[1].Visible = this.Usuario.permiteOperacion(EPermiso.ModificarTecnico);
      this.gridBuscarTecnicos.Columns[2].Visible = this.Usuario.permiteOperacion(EPermiso.EliminarTecnico);
      this.ControlError1.Visible = false;
    }

    protected void buttonBuscar_Click1(object sender, EventArgs e)
    {
      try
      {
        this.tecnicosBuscarDataSource.SelectParameters["documento"].DefaultValue = this.textDocumento.Text != "" ? this.textDocumento.Text : "%";
        this.tecnicosBuscarDataSource.SelectParameters["nombre"].DefaultValue = this.textNombre.Text != "" ? this.textNombre.Text : "%";
      }
      catch (Exception ex)
      {
        this.ControlError1.Visible = true;
        this.ControlError1.Show(ex);
      }
    }
  }
}
