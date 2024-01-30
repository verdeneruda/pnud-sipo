// Decompiled with JetBrains decompiler
// Type: UTO.ImportacionExportacion.LicAmbientalesBuscar
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using AjaxControlToolkit;
using NE.CLib.Linq;
using NE.CLib.Web;
using Seguridad.Servicio;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UTO.ImportacionExportacion
{
  public class LicAmbientalesBuscar : BaseModulo
  {
    protected ToolkitScriptManager ToolkitScriptManager1;
    protected Label labelBuscarLicenciasAmbientales;
    protected ControlError ControlError1;
    protected Label labelparametros;
    protected Label labelEmpresa;
    protected TextBox textEmpresa;
    protected Label labelNumeroResolucion;
    protected TextBox textnumeroRadicacion;
    protected Label labelSustancia;
    protected DropDownList comboSustancia;
    protected Button buttonBuscar;
    protected Button buttonAdicionar;
    protected GridView gridBuscarLicenciasAmbientales;
    protected SqlDataSource licAmbientalesBuscarDataSource;

    protected new void Page_Load(object sender, EventArgs e)
    {
      this.ControlError1.Hide();
      if (this.IsPostBack)
        return;
      this.buttonBuscar.Enabled = this.Usuario.permiteOperacion(EPermiso.BuscarLicenciasMedioAmbientales);
      this.buttonAdicionar.Enabled = this.Usuario.permiteOperacion(EPermiso.AdicionarLicenciasMedioAmbientales);
      this.gridBuscarLicenciasAmbientales.Columns[0].Visible = this.Usuario.permiteOperacion(EPermiso.BuscarLicenciasMedioAmbientales);
      this.gridBuscarLicenciasAmbientales.Columns[1].Visible = this.Usuario.permiteOperacion(EPermiso.ModificarLicenciasMedioAmbientales);
      this.gridBuscarLicenciasAmbientales.Columns[2].Visible = this.Usuario.permiteOperacion(EPermiso.EliminarLicenciasMedioAmbientales);
      this.InitData();
    }

    public void InitData()
    {
      this.comboSustancia.DataSource = (object) CLinq.ListAll<sus_Sustancia>((DataContext) this.MyDataContext);
      this.comboSustancia.DataBind();
      this.comboSustancia.Items.Insert(0, "");
    }

    protected void gridBuscarLicenciasAmbientales_RowCommand(
      object sender,
      GridViewCommandEventArgs e)
    {
      if (e.CommandName.Equals("Modificar"))
      {
        this.SendParams = (object) new BaseModulo.strSendParam()
        {
          id = int.Parse(this.gridBuscarLicenciasAmbientales.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString()),
          tipo = "Modificar"
        };
        this.Server.Transfer("~/ImportacionExportacion/LicAmbientalesRegistrar.aspx");
      }
      if (e.CommandName.Equals("Ver"))
      {
        this.SendParams = (object) new BaseModulo.strSendParam()
        {
          id = int.Parse(this.gridBuscarLicenciasAmbientales.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString()),
          tipo = "Ver"
        };
        this.Server.Transfer("~/ImportacionExportacion/LicAmbientalesRegistrar.aspx");
      }
      if (!e.CommandName.Equals("Eliminar"))
        return;
      this.ControlError1.Visible = false;
      try
      {
        int pageIndex = this.gridBuscarLicenciasAmbientales.PageIndex;
        int pageSize = this.gridBuscarLicenciasAmbientales.PageSize;
        int num = int.Parse(this.gridBuscarLicenciasAmbientales.DataKeys[int.Parse((string) e.CommandArgument) - pageIndex * pageSize].Value.ToString());
        List<lmd_LicenciaMedioAmbientalDetalle> ambientalDetalleList = CLinq.ListByProperty<lmd_LicenciaMedioAmbientalDetalle>((DataContext) this.MyDataContext, "lma_Id", (object) num);
        for (int index = 0; index <= ambientalDetalleList.Count - 1; ++index)
          this.MyDataContext.lmd_LicenciaMedioAmbientalDetalles.DeleteOnSubmit(ambientalDetalleList[index]);
        this.MyDataContext.lma_LicenciaMedioAmbientals.DeleteOnSubmit(CLinq.FindByKey<lma_LicenciaMedioAmbiental>((DataContext) this.MyDataContext, (object) num));
        this.MyDataContext.SubmitChanges();
        this.gridBuscarLicenciasAmbientales.DataSource = (object) null;
        this.gridBuscarLicenciasAmbientales.DataBind();
        foreach (DataControlField column in (StateManagedCollection) this.gridBuscarLicenciasAmbientales.Columns)
        {
          if (column.HeaderText == "Id")
            column.Visible = false;
        }
        CAuditoria.log(EPermiso.EliminarLicenciasMedioAmbientales, num.ToString(), "", "", "", "", this.Usuario.id);
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
        tipo = ""
      };
      this.Server.Transfer("~/ImportacionExportacion/LicAmbientalesRegistrar.aspx");
    }

    protected void buttonBuscar_Click(object sender, EventArgs e)
    {
      this.ControlError1.Visible = false;
      try
      {
        this.licAmbientalesBuscarDataSource.SelectParameters["resolucion"].DefaultValue = this.textnumeroRadicacion.Text != "" ? this.textnumeroRadicacion.Text : "%";
        this.licAmbientalesBuscarDataSource.SelectParameters["empresa"].DefaultValue = this.textEmpresa.Text != "" ? this.textEmpresa.Text : "%";
        this.licAmbientalesBuscarDataSource.SelectParameters["sustancia"].DefaultValue = this.comboSustancia.SelectedValue != "" ? this.comboSustancia.Text : "0";
        CGridView.ColByField(this.gridBuscarLicenciasAmbientales, "Id").Visible = false;
      }
      catch (Exception ex)
      {
        this.ControlError1.Visible = true;
        this.ControlError1.Show(ex);
      }
    }
  }
}
