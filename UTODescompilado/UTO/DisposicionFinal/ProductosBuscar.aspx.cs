// Decompiled with JetBrains decompiler
// Type: UTO.DisposicionFinal.ProductosBuscar
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

namespace UTO.DisposicionFinal
{
  public class ProductosBuscar : BaseModulo
  {
    protected ToolkitScriptManager ToolkitScriptManager1;
    protected Label labelBusquedaPDisposicionFinal;
    protected ControlError ControlError1;
    protected Label labelparametros;
    protected Label labelNit;
    protected TextBox textNit;
    protected Label labelEmpresa;
    protected TextBox textEmpresa;
    protected Label labelFechaIncial;
    protected TextBox textFechaInicial;
    protected CalendarExtender calendarfecha;
    protected Label labelFechaFinal;
    protected TextBox textFechaFinal;
    protected CalendarExtender calendarFechaFinal;
    protected Label labelSustancia;
    protected DropDownList comboSustancia;
    protected Button buttonBuscar;
    protected Button buttonAdicionar;
    protected GridView gridBuscarProductosDisposicionFinal;
    protected SqlDataSource productoBuscarDataSource;

    protected new void Page_Load(object sender, EventArgs e)
    {
      this.buttonBuscar.Enabled = this.Usuario.permiteOperacion(EPermiso.BuscarSustanciasDisposicionFinal);
      this.buttonAdicionar.Enabled = this.Usuario.permiteOperacion(EPermiso.AdicionarSustanciasDisposicionFinal);
      this.gridBuscarProductosDisposicionFinal.Columns[0].Visible = this.Usuario.permiteOperacion(EPermiso.BuscarSustanciasDisposicionFinal);
      this.gridBuscarProductosDisposicionFinal.Columns[1].Visible = this.Usuario.permiteOperacion(EPermiso.ModificarSustanciaDisposicionFinal);
      this.gridBuscarProductosDisposicionFinal.Columns[2].Visible = this.Usuario.permiteOperacion(EPermiso.EliminarSustanciaDisposicionFinal);
      if (this.IsPostBack)
        return;
      this.InitData();
    }

    private void InitData()
    {
      this.comboSustancia.DataSource = (object) CLinq.ListAll<sus_Sustancia>((DataContext) this.MyDataContext);
      this.comboSustancia.DataBind();
      this.comboSustancia.Items.Insert(0, "");
    }

    protected void buttonAdicionar_Click(object sender, EventArgs e)
    {
      this.SendParams = (object) new BaseModulo.strSendParam()
      {
        id = 0,
        tipo = "Modificar"
      };
      this.Response.Redirect("~/DisposicionFinal/ProductosRegistrar.aspx");
    }

    protected void gridBuscarProductosDisposicionFinal_RowCommand(
      object sender,
      GridViewCommandEventArgs e)
    {
      if (e.CommandName.Equals("Modificar"))
      {
        this.SendParams = (object) new BaseModulo.strSendParam()
        {
          id = int.Parse(this.gridBuscarProductosDisposicionFinal.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString()),
          tipo = "Modificar"
        };
        this.Response.Redirect("~/DisposicionFinal/ProductosRegistrar.aspx");
      }
      if (e.CommandName.Equals("Ver"))
      {
        this.SendParams = (object) new BaseModulo.strSendParam()
        {
          id = int.Parse(this.gridBuscarProductosDisposicionFinal.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString()),
          tipo = "Ver"
        };
        this.Response.Redirect("~/DisposicionFinal/ProductosRegistrar.aspx");
      }
      if (!e.CommandName.Equals("Eliminar"))
        return;
      this.ControlError1.Visible = false;
      try
      {
        int pageIndex = this.gridBuscarProductosDisposicionFinal.PageIndex;
        int pageSize = this.gridBuscarProductosDisposicionFinal.PageSize;
        int keyValue = int.Parse(this.gridBuscarProductosDisposicionFinal.DataKeys[int.Parse((string) e.CommandArgument) - pageIndex * pageSize].Value.ToString());
        dfd_DisposicionFinalDato byKey = CLinq.FindByKey<dfd_DisposicionFinalDato>((DataContext) this.MyDataContext, (object) keyValue);
        for (int index = 0; index < byKey.ddd_DisposicionDatosDetalles.Count; ++index)
          this.MyDataContext.ddd_DisposicionDatosDetalles.DeleteOnSubmit(byKey.ddd_DisposicionDatosDetalles[index]);
        this.MyDataContext.dfd_DisposicionFinalDatos.DeleteOnSubmit(byKey);
        this.MyDataContext.SubmitChanges();
        this.gridBuscarProductosDisposicionFinal.DataSource = (object) null;
        this.gridBuscarProductosDisposicionFinal.DataBind();
        CAuditoria.log(EPermiso.EliminarSustanciaDisposicionFinal, keyValue.ToString(), "", "", "", "", this.Usuario.id);
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
      DateTime date1;
      DateTime date2;
      try
      {
        date1 = DateTime.Parse("1/1/1900");
        date2 = DateTime.Parse("1/1/2050");
        if (this.textFechaInicial.Text != "")
          CValidator.isDate(this.textFechaInicial.Text, ref date1);
        if (this.textFechaFinal.Text != "")
          CValidator.isDate(this.textFechaFinal.Text, ref date2);
      }
      catch
      {
        this.ControlError1.Visible = true;
        this.ControlError1.Show(new Exception("Debe ingresar una fecha válida"));
        return;
      }
      try
      {
        this.productoBuscarDataSource.SelectParameters["nit"].DefaultValue = this.textNit.Text != "" ? this.textNit.Text : "%";
        this.productoBuscarDataSource.SelectParameters["idEmpresa"].DefaultValue = this.textEmpresa.Text != "" ? this.textEmpresa.Text : "%";
        this.productoBuscarDataSource.SelectParameters["fechaInicial"].DefaultValue = date1.ToString("yyyy/MM/dd");
        this.productoBuscarDataSource.SelectParameters["fechaFinal"].DefaultValue = date2.ToString("yyyy/MM/dd");
        this.productoBuscarDataSource.SelectParameters["idSustancia"].DefaultValue = this.comboSustancia.SelectedValue != "" ? this.comboSustancia.SelectedValue : "0";
      }
      catch (Exception ex)
      {
        this.ControlError1.Visible = true;
        this.ControlError1.Show(ex);
      }
    }
  }
}
