// Decompiled with JetBrains decompiler
// Type: UTO.RegistrosUso.ImportadoresBuscar
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using NE.CLib;
using NE.CLib.Linq;
using Seguridad.Servicio;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Web.UI.WebControls;

namespace UTO.RegistrosUso
{
  public class ImportadoresBuscar : BaseModulo
  {
    protected XmlDataSource xmlCliente;
    protected XmlDataSource xmlSustancia;
    protected XmlDataSource xmlBusqueda;
    protected Label labelBusquedaRegistrosUsoImportadores;
    protected Label labelparametros;
    protected Label labelcliente;
    protected DropDownList Combocliente;
    protected Label labelSustancia;
    protected DropDownList ComboSustancia;
    protected Label label1;
    protected TextBox textAnno;
    protected Button buttonBuscar;
    protected Button buttonAdicionar;
    protected GridView gridBuscarSustanciasReportadasImportadores;
    protected SqlDataSource importadoresBuscarDataSource;

    protected new void Page_Load(object sender, EventArgs e)
    {
      this.buttonBuscar.Enabled = this.Usuario.permiteOperacion(EPermiso.BuscarRegistrosReportadosPorImportadores);
      this.buttonAdicionar.Enabled = this.Usuario.permiteOperacion(EPermiso.AdicionarregistrosReportadosPorImportadores);
      this.gridBuscarSustanciasReportadasImportadores.Columns[0].Visible = this.Usuario.permiteOperacion(EPermiso.BuscarRegistrosReportadosPorImportadores);
      this.gridBuscarSustanciasReportadasImportadores.Columns[1].Visible = this.Usuario.permiteOperacion(EPermiso.ModificarRegistrosReportadosPorImportadores);
      this.gridBuscarSustanciasReportadasImportadores.Columns[2].Visible = this.Usuario.permiteOperacion(EPermiso.EliminarRegistrosReportadosPorImportadores);
      if (this.IsPostBack)
        return;
      this.InitData();
    }

    private void InitData()
    {
      this.ComboSustancia.DataSource = (object) CLinq.ListAll<sus_Sustancia>((DataContext) this.MyDataContext);
      this.ComboSustancia.DataBind();
      this.ComboSustancia.Items.Insert(0, "");
      List<ter_Tercero> terTerceroList = new List<ter_Tercero>();
      List<ttt_TerceroTipoTercero> terceroTipoTerceroList = CLinq.ListByProperty<ttt_TerceroTipoTercero>((DataContext) this.MyDataContext, "tti_Id", (object) 2);
      for (int index = 0; index <= terceroTipoTerceroList.Count - 1; ++index)
      {
        ter_Tercero byKey = CLinq.FindByKey<ter_Tercero>((DataContext) this.MyDataContext, (object) terceroTipoTerceroList[index].ter_Id);
        terTerceroList.Add(byKey);
      }
      this.Combocliente.DataSource = (object) terTerceroList;
      this.Combocliente.DataBind();
      this.Combocliente.Items.Insert(0, "");
    }

    protected void gridBuscarSustanciasReportadasImportadores_RowCommand(
      object sender,
      GridViewCommandEventArgs e)
    {
      if (e.CommandName.Equals("Modificar"))
      {
        this.SendParams = (object) new BaseModulo.strSendParam()
        {
          id = int.Parse(this.gridBuscarSustanciasReportadasImportadores.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString()),
          tipo = "Modificar"
        };
        this.Response.Redirect("~/RegistrosUso/ImportadoresRegistrar.aspx");
      }
      if (!e.CommandName.Equals("Eliminar"))
        ;
      if (!e.CommandName.Equals("Ver"))
        return;
      this.SendParams = (object) new BaseModulo.strSendParam()
      {
        id = int.Parse(this.gridBuscarSustanciasReportadasImportadores.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString()),
        tipo = "Ver"
      };
      this.Response.Redirect("~/RegistrosUso/ImportadoresRegistrar.aspx");
    }

    protected void buttonAdicionar_Click(object sender, EventArgs e)
    {
      this.SendParams = (object) new BaseModulo.strSendParam()
      {
        id = 0,
        tipo = "Modificar"
      };
      this.Response.Redirect("~/RegistrosUso/ImportadoresRegistrar.aspx");
    }

    protected void buttonBuscar_Click(object sender, EventArgs e)
    {
      int number = 0;
      CValidator.isInteger(this.textAnno.Text, ref number);
      this.importadoresBuscarDataSource.SelectParameters["idEmpresa"].DefaultValue = this.Combocliente.SelectedValue != "" ? this.Combocliente.SelectedValue : "0";
      this.importadoresBuscarDataSource.SelectParameters["idSustancia"].DefaultValue = this.ComboSustancia.SelectedValue != "" ? this.ComboSustancia.SelectedValue : "0";
      this.importadoresBuscarDataSource.SelectParameters["anno"].DefaultValue = number < 1 ? "0" : number.ToString();
    }
  }
}
