// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.ReporteUsoBuscar
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using AjaxControlToolkit;
using NE.CLib.Linq;
using Seguridad.Servicio;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Web.UI.WebControls;

namespace UTO.Recuperacion
{
  public class ReporteUsoBuscar : BaseModulo
  {
    protected ToolkitScriptManager ToolkitScriptManager1;
    protected Label labelBusquedaSolicitudesEquipos;
    protected ControlError ControlError1;
    protected Label labelparametros;
    protected Label labelDepartamento;
    protected DropDownList comboDepartamento;
    protected Label labelCiudad;
    protected DropDownList comboCiudad;
    protected Label labelRegional;
    protected DropDownList comboRegional;
    protected Label labelNombreBeneficiario;
    protected TextBox textNombreBeneficiario;
    protected Label label3;
    protected DropDownList comboTipoDocumentoBuscar;
    protected Label labelNumeroDocumento;
    protected TextBox textNumeroDocumnetoBuscar;
    protected Button buttonBuscar;
    protected Button buttonAdicionar;
    protected GridView gridBuscarReporteUso;
    protected SqlDataSource reporteUsoBuscarDataSource;

    private int proyectoId
    {
      get => Convert.ToInt32(this.ViewState["SolicitudEquipo.Tipo"] ?? (object) 0);
      set => this.ViewState["SolicitudEquipo.Tipo"] = (object) value;
    }

    protected new void Page_Load(object sender, EventArgs e)
    {
      if (!this.IsPostBack)
      {
        this.proyectoId = this.Request.QueryString["tipo"] == null ? 1 : Convert.ToInt32(this.Request.QueryString["tipo"]);
        this.InitData();
      }
      switch (this.proyectoId)
      {
        case 0:
          this.labelBusquedaSolicitudesEquipos.Text = "Proyectos de dotación de equipos y herramientas  para el sector de refrigeración y aire acondicionado - Kit de barrido y limpieza con nitrógeno y filtros de alto rendimiento - Eliminación del R-141b en Actividades de Limpieza - Buscar Reporte Usos";
          break;
        case 1:
          this.labelBusquedaSolicitudesEquipos.Text = "Proyectos de dotación de equipos y herramientas  para el sector de refrigeración y aire acondicionado - Recuperación, reciclaje y regeneración de gases refrigerantes - Buscar Reporte Uso";
          break;
      }
    }

    public void InitData()
    {
      this.comboDepartamento.DataSource = (object) CLinq.ListAll<dep_Departamento>((DataContext) this.MyDataContext);
      this.comboDepartamento.DataBind();
      this.comboDepartamento.Items.Insert(0, "");
      this.comboRegional.DataSource = (object) CLinq.ListAll<reg_Regional>((DataContext) this.MyDataContext);
      this.comboRegional.DataBind();
      this.comboRegional.Items.Insert(0, "");
      this.comboTipoDocumentoBuscar.DataSource = (object) CLinq.ListAll<dti_DocumentoTipo>((DataContext) this.MyDataContext);
      this.comboTipoDocumentoBuscar.DataBind();
      this.comboTipoDocumentoBuscar.Items.Insert(0, "");
    }

    protected void buttonBuscar_Click(object sender, EventArgs e)
    {
      this.reporteUsoBuscarDataSource.SelectParameters["departamento"].DefaultValue = this.comboDepartamento.SelectedValue != "" ? this.comboDepartamento.SelectedValue : "0";
      this.reporteUsoBuscarDataSource.SelectParameters["municipio"].DefaultValue = this.comboCiudad.SelectedValue != "" ? this.comboCiudad.SelectedValue : "0";
      this.reporteUsoBuscarDataSource.SelectParameters["regional"].DefaultValue = this.comboRegional.SelectedValue != "" ? this.comboRegional.SelectedValue : "0";
      this.reporteUsoBuscarDataSource.SelectParameters["beneficiario"].DefaultValue = this.textNombreBeneficiario.Text != "" ? this.textNombreBeneficiario.Text : "%";
      this.reporteUsoBuscarDataSource.SelectParameters["tipo"].DefaultValue = this.proyectoId.ToString();
      this.reporteUsoBuscarDataSource.SelectParameters["tipoDoc"].DefaultValue = this.comboTipoDocumentoBuscar.SelectedValue != "" ? this.comboTipoDocumentoBuscar.SelectedValue : "0";
      this.reporteUsoBuscarDataSource.SelectParameters["numDoc"].DefaultValue = this.textNumeroDocumnetoBuscar.Text != "" ? this.textNumeroDocumnetoBuscar.Text : "%";
    }

    protected void buttonAdicionar_Click(object sender, EventArgs e)
    {
      this.SendParams = (object) new BaseModulo.strSendParam()
      {
        id = 0,
        tipo = ""
      };
      if (this.proyectoId != 0)
        this.Response.Redirect("~/Recuperacion/ReporteUsoRegistrar.aspx");
      else
        this.Response.Redirect("~/Recuperacion/ReporteUsoBarridoRegistrar.aspx");
    }

    protected void gridBuscarReporteUso_RowCommand(object sender, GridViewCommandEventArgs e)
    {
      if (e.CommandName.Equals("Modificar"))
      {
        this.SendParams = (object) new BaseModulo.strSendParam()
        {
          id = int.Parse(this.gridBuscarReporteUso.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString()),
          tipo = "Modificar"
        };
        if (this.proyectoId != 0)
          this.Response.Redirect("~/Recuperacion/ReporteUsoRegistrar.aspx");
        else
          this.Response.Redirect("~/Recuperacion/ReporteUsoBarridoRegistrar.aspx");
      }
      if (e.CommandName.Equals("Ver"))
      {
        this.SendParams = (object) new BaseModulo.strSendParam()
        {
          id = int.Parse(this.gridBuscarReporteUso.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString()),
          tipo = "Ver"
        };
        if (this.proyectoId != 0)
          this.Response.Redirect("~/Recuperacion/ReporteUsoRegistrar.aspx");
        else
          this.Response.Redirect("~/Recuperacion/ReporteUsoBarridoRegistrar.aspx");
      }
      int num1;
      if (e.CommandName.Equals("Eliminar") && this.proyectoId != 0)
      {
        num1 = 0;
        int num2 = int.Parse(this.gridBuscarReporteUso.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString());
        List<rud_ReporteUsoDocumento> reporteUsoDocumentoList = CLinq.ListByProperty<rud_ReporteUsoDocumento>((DataContext) this.MyDataContext, "rdu_Id", (object) num2);
        for (int index = 0; index <= reporteUsoDocumentoList.Count - 1; ++index)
          this.MyDataContext.rud_ReporteUsoDocumentos.DeleteOnSubmit(reporteUsoDocumentoList[index]);
        List<rdt_ReporteUsoDetalle> reporteUsoDetalleList = CLinq.ListByProperty<rdt_ReporteUsoDetalle>((DataContext) this.MyDataContext, "rdu_Id", (object) num2);
        for (int index = 0; index <= reporteUsoDetalleList.Count - 1; ++index)
          this.MyDataContext.rdt_ReporteUsoDetalles.DeleteOnSubmit(reporteUsoDetalleList[index]);
        rdu_ReporteUso byKey = CLinq.FindByKey<rdu_ReporteUso>((DataContext) this.MyDataContext, (object) num2);
        try
        {
          this.MyDataContext.rdu_ReporteUsos.DeleteOnSubmit(byKey);
          this.MyDataContext.SubmitChanges();
          this.gridBuscarReporteUso.DataSource = (object) null;
          this.gridBuscarReporteUso.DataBind();
          CAuditoria.log(EPermiso.EliminarReporteDeUso, num2.ToString(), "", "", "", "", this.Usuario.id);
        }
        catch (Exception ex)
        {
          this.ControlError1.Visible = true;
          this.ControlError1.Show(ex);
        }
      }
      if (!e.CommandName.Equals("Eliminar") || this.proyectoId != 0)
        return;
      num1 = 0;
      int num3 = int.Parse(this.gridBuscarReporteUso.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString());
      List<rbd_ReporteUsoBarridoDocumento> barridoDocumentoList = CLinq.ListByProperty<rbd_ReporteUsoBarridoDocumento>((DataContext) this.MyDataContext, "rdb_Id", (object) num3);
      for (int index = 0; index <= barridoDocumentoList.Count - 1; ++index)
        this.MyDataContext.rbd_ReporteUsoBarridoDocumentos.DeleteOnSubmit(barridoDocumentoList[index]);
      rdb_ReporteUsoBarrido byKey1 = CLinq.FindByKey<rdb_ReporteUsoBarrido>((DataContext) this.MyDataContext, (object) num3);
      try
      {
        this.MyDataContext.rdb_ReporteUsoBarridos.DeleteOnSubmit(byKey1);
        this.MyDataContext.SubmitChanges();
        this.gridBuscarReporteUso.DataSource = (object) null;
        this.gridBuscarReporteUso.DataBind();
        CAuditoria.log(EPermiso.EliminarReporteDeUso, num3.ToString(), "", "", "", "", this.Usuario.id);
      }
      catch (Exception ex)
      {
        this.ControlError1.Visible = true;
        this.ControlError1.Show(ex);
      }
    }

    protected void comboDepartamento_SelectedIndexChanged(object sender, EventArgs e) => this.listarMunicipio(this.comboDepartamento.SelectedValue);

    protected void listarMunicipio(string departamento)
    {
      List<mun_Municipio> munMunicipioList = CLinq.ListByProperty<mun_Municipio>((DataContext) this.MyDataContext, "dep_Id", (object) departamento);
      this.comboCiudad.SelectedValue = (string) null;
      if (munMunicipioList.Count > 0)
      {
        this.comboCiudad.DataSource = (object) munMunicipioList;
        this.comboCiudad.DataBind();
        this.comboCiudad.Items.Insert(0, "");
      }
      else
        this.comboCiudad.Items.Insert(0, "");
    }
  }
}
