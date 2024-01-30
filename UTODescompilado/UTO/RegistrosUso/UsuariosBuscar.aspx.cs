// Decompiled with JetBrains decompiler
// Type: UTO.RegistrosUso.UsuariosBuscar
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using NE.CLib.Linq;
using Seguridad.Servicio;
using System;
using System.Data.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UTO.RegistrosUso
{
  public class UsuariosBuscar : BaseModulo
  {
    protected XmlDataSource xmlEmpresa;
    protected XmlDataSource xmlBusqueda;
    protected XmlDataSource xmlCiudad;
    protected XmlDataSource xmlDepartamento;
    protected System.Web.UI.ScriptManager ScriptManager1;
    protected Label labelBusquedaRegistrosUsoUsuarios;
    protected ControlError ControlError1;
    protected Label labelparametros;
    protected Label labelNit;
    protected TextBox textNit;
    protected Label labelEmpresa;
    protected DropDownList ComboEmpresa;
    protected Label labelDepartamento;
    protected DropDownList comboDepartamento;
    protected Label labelCiudad;
    protected UpdatePanel UpdatePanel1;
    protected DropDownList comboCiudad;
    protected Button buttonBuscar;
    protected Button buttonAdicionar;
    protected GridView gridBuscarSustanciasReportadasUsuarios;
    protected SqlDataSource usuariosBuscarDataSource;

    protected new void Page_Load(object sender, EventArgs e)
    {
      this.buttonBuscar.Enabled = this.Usuario.permiteOperacion(EPermiso.BuscarUsuariosFinales);
      this.buttonAdicionar.Enabled = this.Usuario.permiteOperacion(EPermiso.AdicionarUsuariosFinales);
      this.gridBuscarSustanciasReportadasUsuarios.Columns[0].Visible = this.Usuario.permiteOperacion(EPermiso.BuscarUsuariosFinales);
      this.gridBuscarSustanciasReportadasUsuarios.Columns[1].Visible = this.Usuario.permiteOperacion(EPermiso.ModificarUsuariosFinales);
      this.gridBuscarSustanciasReportadasUsuarios.Columns[2].Visible = this.Usuario.permiteOperacion(EPermiso.EliminarUsuariosFinales);
      this.ControlError1.Visible = false;
      if (this.IsPostBack)
        return;
      this.InitData();
    }

    private void InitData()
    {
      this.ComboEmpresa.DataSource = (object) CLinq.ListAll<ter_Tercero>((DataContext) this.MyDataContext);
      this.ComboEmpresa.DataBind();
      this.ComboEmpresa.Items.Insert(0, "");
      this.comboDepartamento.DataSource = (object) CLinq.ListAll<dep_Departamento>((DataContext) this.MyDataContext);
      this.comboDepartamento.DataBind();
      this.comboDepartamento.Items.Insert(0, "");
    }

    protected void gridBuscarSustanciasReportadasUsuarios_RowCommand(
      object sender,
      GridViewCommandEventArgs e)
    {
      if (e.CommandName.Equals("Modificar"))
      {
        this.SendParams = (object) new BaseModulo.strSendParam()
        {
          id = int.Parse(this.gridBuscarSustanciasReportadasUsuarios.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString()),
          tipo = "Modificar"
        };
        this.Response.Redirect("~/RegistrosUso/UsuariosRegistrar.aspx");
      }
      if (e.CommandName.Equals("Eliminar"))
      {
        this.ControlError1.Visible = false;
        try
        {
          int pageIndex = this.gridBuscarSustanciasReportadasUsuarios.PageIndex;
          int pageSize = this.gridBuscarSustanciasReportadasUsuarios.PageSize;
          int index = int.Parse((string) e.CommandArgument) - pageIndex * pageSize;
          CRegistroUso.EliminarActividad(int.Parse(this.gridBuscarSustanciasReportadasUsuarios.DataKeys[index].Value.ToString()), this.MyDataContext.Connection.ConnectionString);
          this.gridBuscarSustanciasReportadasUsuarios.DataSource = (object) null;
          this.gridBuscarSustanciasReportadasUsuarios.DataBind();
          CAuditoria.log(EPermiso.EliminarUsuariosFinales, index.ToString(), "", "", "", "", this.Usuario.id);
        }
        catch (Exception ex)
        {
          this.ControlError1.Visible = true;
          this.ControlError1.Show(ex);
        }
      }
      if (!e.CommandName.Equals("Ver"))
        return;
      this.SendParams = (object) new BaseModulo.strSendParam()
      {
        id = int.Parse(this.gridBuscarSustanciasReportadasUsuarios.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString()),
        tipo = "Ver"
      };
      this.Response.Redirect("~/RegistrosUso/UsuariosRegistrar.aspx");
    }

    protected void buttonAdicionar_Click(object sender, EventArgs e)
    {
      this.SendParams = (object) new BaseModulo.strSendParam()
      {
        id = 0,
        tipo = "Modificar"
      };
      this.Response.Redirect("~/RegistrosUso/UsuariosRegistrar.aspx");
    }

    protected void comboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.comboCiudad.DataSource = (object) CLinq.ListByProperty<mun_Municipio>((DataContext) this.MyDataContext, "dep_id", (object) this.comboDepartamento.SelectedValue);
      this.comboCiudad.DataBind();
      this.comboCiudad.Items.Insert(0, "");
    }

    protected void buttonBuscar_Click(object sender, EventArgs e)
    {
      try
      {
        this.usuariosBuscarDataSource.SelectParameters["nit"].DefaultValue = this.textNit.Text != "" ? this.textNit.Text : "%";
        this.usuariosBuscarDataSource.SelectParameters["idEmpresa"].DefaultValue = this.ComboEmpresa.SelectedValue != "" ? this.ComboEmpresa.SelectedValue : "0";
        this.usuariosBuscarDataSource.SelectParameters["idDepartamento"].DefaultValue = this.comboDepartamento.SelectedValue != "" ? this.comboDepartamento.SelectedValue : "0";
        this.usuariosBuscarDataSource.SelectParameters["idCiudad"].DefaultValue = this.comboCiudad.SelectedValue != "" ? this.comboCiudad.SelectedValue : "0";
      }
      catch (Exception ex)
      {
        this.ControlError1.Visible = true;
        this.ControlError1.Show(ex);
      }
    }
  }
}
