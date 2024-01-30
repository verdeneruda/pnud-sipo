// Decompiled with JetBrains decompiler
// Type: UTO.Comercializacion.EncuestaBuscar
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using AjaxControlToolkit;
using NE.CLib;
using NE.CLib.Linq;
using Seguridad.Servicio;
using System;
using System.Data.Linq;
using System.Web.UI.WebControls;

namespace UTO.Comercializacion
{
  public class EncuestaBuscar : BaseModulo
  {
    protected ToolkitScriptManager ToolkitScriptManager1;
    protected Label labelBusquedaEmpresas;
    protected ControlError ControlError1;
    protected Label labelparametros;
    protected Label labelNit;
    protected TextBox textNit;
    protected Label labelEmpresa;
    protected TextBox textEmpresa;
    protected Label labelFechaInicial;
    protected TextBox textfechaInicial;
    protected CalendarExtender calendarfechaInicial;
    protected Label labelFechaFinal;
    protected TextBox textFechaFinal;
    protected CalendarExtender calendarfechaFinal;
    protected Label labelDepartamento;
    protected DropDownList comboDepartamento;
    protected Label labelCiudad;
    protected DropDownList comboCiudad;
    protected Label labelResultado;
    protected Button buttonBuscar;
    protected Button buttonAdicionar;
    protected GridView gridBuscarEncuestaComercializacion;
    protected SqlDataSource EncuestaBuscarDataSource;

    protected new void Page_Load(object sender, EventArgs e)
    {
      this.ControlError1.Visible = false;
      this.buttonBuscar.Enabled = this.Usuario.permiteOperacion(EPermiso.BuscarDatosDeComercializacion);
      this.buttonAdicionar.Enabled = this.Usuario.permiteOperacion(EPermiso.AdicionarDatosDeComercializacion);
      this.gridBuscarEncuestaComercializacion.Columns[0].Visible = this.Usuario.permiteOperacion(EPermiso.BuscarDatosDeComercializacion);
      this.gridBuscarEncuestaComercializacion.Columns[1].Visible = this.Usuario.permiteOperacion(EPermiso.ModificarDatosDeComercializacion);
      this.gridBuscarEncuestaComercializacion.Columns[2].Visible = this.Usuario.permiteOperacion(EPermiso.EliminarDatosDeComercializacion);
      if (this.IsPostBack)
        return;
      this.InitData();
    }

    private void InitData()
    {
      this.comboDepartamento.DataSource = (object) CLinq.ListAll<dep_Departamento>((DataContext) this.MyDataContext);
      this.comboDepartamento.DataBind();
      this.comboDepartamento.Items.Insert(0, "");
    }

    protected void buttonAdicionar_Click(object sender, EventArgs e)
    {
      this.SendParams = (object) new BaseModulo.strSendParam()
      {
        id = 0,
        tipo = "Modificar"
      };
      this.Response.Redirect("~/Comercializacion/Encuestaregistro.aspx");
    }

    protected void gridBuscarEncuestaComercializacion_RowCommand(
      object sender,
      GridViewCommandEventArgs e)
    {
      if (e.CommandName.Equals("Eliminar"))
      {
        this.Session["entrada"] = (object) "Eliminar";
        try
        {
          int pageIndex = this.gridBuscarEncuestaComercializacion.PageIndex;
          int pageSize = this.gridBuscarEncuestaComercializacion.PageSize;
          int index = int.Parse((string) e.CommandArgument) - pageIndex * pageSize;
          CComercializacion.EliminarEncuesta(int.Parse(this.gridBuscarEncuestaComercializacion.DataKeys[index].Value.ToString()), this.MyDataContext.Connection.ConnectionString);
          this.gridBuscarEncuestaComercializacion.DataSource = (object) null;
          this.gridBuscarEncuestaComercializacion.DataBind();
          CAuditoria.log(EPermiso.EliminarDatosDeComercializacion, index.ToString(), "", "", "", "", this.Usuario.id);
        }
        catch (Exception ex)
        {
          this.ControlError1.Visible = true;
          this.ControlError1.Show(ex);
        }
      }
      BaseModulo.strSendParam strSendParam;
      if (e.CommandName.Equals("Ver"))
      {
        this.Session["entrada"] = (object) "Ver";
        strSendParam = new BaseModulo.strSendParam();
        strSendParam.id = int.Parse(this.gridBuscarEncuestaComercializacion.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString());
        strSendParam.tipo = "Ver";
        this.SendParams = (object) strSendParam;
        this.Response.Redirect("~/Comercializacion/Encuestaregistro.aspx");
      }
      if (!e.CommandName.Equals("Modificar"))
        return;
      this.Session["entrada"] = (object) "Modificar";
      strSendParam = new BaseModulo.strSendParam();
      strSendParam.id = int.Parse(this.gridBuscarEncuestaComercializacion.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString());
      strSendParam.tipo = "Modificar";
      this.SendParams = (object) strSendParam;
      this.Response.Redirect("~/Comercializacion/Encuestaregistro.aspx");
    }

    protected void buttonBuscar_Click(object sender, EventArgs e)
    {
      try
      {
        this.Validar();
        DateTime date1 = DateTime.Parse("1/1/1900");
        DateTime date2 = DateTime.Parse("1/1/2050");
        if (this.textfechaInicial.Text != "")
          CValidator.isDate(this.textfechaInicial.Text, ref date1);
        if (this.textFechaFinal.Text != "")
          CValidator.isDate(this.textFechaFinal.Text, ref date2);
        this.EncuestaBuscarDataSource.SelectParameters["nit"].DefaultValue = this.textNit.Text != "" ? this.textNit.Text : "%";
        this.EncuestaBuscarDataSource.SelectParameters["idEmpresa"].DefaultValue = this.textEmpresa.Text != "" ? this.textEmpresa.Text : "%";
        this.EncuestaBuscarDataSource.SelectParameters["fechaInicial"].DefaultValue = date1.ToString("yyyy/MM/dd");
        this.EncuestaBuscarDataSource.SelectParameters["fechaFinal"].DefaultValue = date2.ToString("yyyy/MM/dd");
        this.EncuestaBuscarDataSource.SelectParameters["departamento"].DefaultValue = this.comboDepartamento.SelectedValue != "" ? this.comboDepartamento.SelectedValue : "0";
        this.EncuestaBuscarDataSource.SelectParameters["municipio"].DefaultValue = this.comboCiudad.SelectedValue != "" ? this.comboCiudad.SelectedValue : "0";
        this.labelResultado.Text = "";
        if (this.gridBuscarEncuestaComercializacion.Rows.Count != 0)
          return;
        this.labelResultado.Text = "La búsqueda no arrojó resultados.";
      }
      catch (Exception ex)
      {
        this.ControlError1.Visible = true;
        this.ControlError1.Show(ex);
      }
    }

    protected void comboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.comboCiudad.DataSource = (object) CLinq.ListByProperty<mun_Municipio>((DataContext) this.MyDataContext, "dep_id", (object) this.comboDepartamento.SelectedValue);
      this.comboCiudad.DataBind();
      this.comboCiudad.Items.Insert(0, "");
    }

    private void Validar()
    {
      string message = "";
      bool flag1 = true;
      bool flag2 = true;
      bool flag3 = true;
      DateTime date = DateTime.Parse("1/1/1900");
      if (CValidaEspeciales.VRequerido(this.textfechaInicial.Text))
        flag2 = false;
      if (CValidaEspeciales.VRequerido(this.textFechaFinal.Text))
        flag3 = false;
      if (!flag2 && !CValidator.isDate(this.textfechaInicial.Text, ref date))
      {
        message = "La fecha inicial no tiene un formato válido <br/>";
        flag1 = false;
      }
      if (!flag3 && !CValidator.isDate(this.textFechaFinal.Text, ref date))
      {
        message += "La fecha final no tiene un formato válido <br/>";
        flag1 = false;
      }
      if (!flag1)
        throw new Exception(message);
    }
  }
}
