// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.Cubo
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using DevExpress.Web.ASPxPivotGrid;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrintingLinks;
using System;
using System.IO;
using System.Web.UI.WebControls;

namespace UTO.Recuperacion
{
  public class Cubo : System.Web.UI.Page
  {
    protected Label labelConsultas;
    protected Label labelSeleccioneConsultas;
    protected DropDownList comboTipoConsulta;
    protected Panel PanelCuboImportador;
    protected DevExpress.Web.ASPxPivotGrid.ASPxPivotGrid ASPxPivotGrid3;
    protected PivotGridField fieldRegional;
    protected PivotGridField fieldBeneficiario;
    protected PivotGridField fieldDepartamento;
    protected PivotGridField fieldMunicipio;
    protected PivotGridField fieldCantidadEquipo;
    protected PivotGridField fieldEquipo;
    protected PivotGridField fieldCostoEquipo;
    protected PivotGridField fieldValorTotalAsignado;
    protected PivotGridField fieldTipoGas;
    protected PivotGridField fieldUsoGas;
    protected PivotGridField fieldCantidadGas;
    protected SqlDataSource SqlDataCuboImportacion;
    protected Panel PanelCuboExportador;
    protected DevExpress.Web.ASPxPivotGrid.ASPxPivotGrid ASPxPivotGrid1;
    protected PivotGridField fieldNombre;
    protected PivotGridField fieldRUDepartamento;
    protected PivotGridField fieldRUMunicipio;
    protected PivotGridField fieldPeriodo;
    protected PivotGridField fieldSustancia;
    protected PivotGridField fieldUso;
    protected PivotGridField fieldRUCantidad;
    protected SqlDataSource SqlDataDeclaracion;
    protected ASPxPivotGridExporter pivotExport;
    protected ASPxPivotGridExporter pivotExport2;
    protected ASPxPivotGridExporter pivotExport3;
    protected Panel PanelCuboEquipos;
    protected DevExpress.Web.ASPxPivotGrid.ASPxPivotGrid ASPxPivotGrid2;
    protected PivotGridField PivotGridField1;
    protected PivotGridField fieldCompra;
    protected PivotGridField fieldTipo;
    protected PivotGridField PivotGridField2;
    protected PivotGridField fieldCantidad;
    protected PivotGridField fieldEstado;
    protected PivotGridField fieldTercero;
    protected PivotGridField PivotGridField4;
    protected PivotGridField PivotGridField5;
    protected SqlDataSource SqlDataCuboEquipos;
    protected Button ButtonVolver;
    protected Button buttonExportar;

    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void comboTipoConsulta_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.comboTipoConsulta.SelectedValue == "-1")
      {
        this.PanelCuboImportador.Visible = false;
        this.PanelCuboExportador.Visible = false;
        this.PanelCuboEquipos.Visible = false;
      }
      if (this.comboTipoConsulta.SelectedValue == "1")
      {
        this.PanelCuboImportador.Visible = true;
        this.PanelCuboExportador.Visible = false;
        this.PanelCuboEquipos.Visible = false;
      }
      if (this.comboTipoConsulta.SelectedValue == "2")
      {
        this.PanelCuboImportador.Visible = false;
        this.PanelCuboExportador.Visible = true;
        this.PanelCuboEquipos.Visible = false;
      }
      if (!(this.comboTipoConsulta.SelectedValue == "3"))
        return;
      this.PanelCuboImportador.Visible = false;
      this.PanelCuboExportador.Visible = false;
      this.PanelCuboEquipos.Visible = true;
    }

    protected void ButtonVolver_Click(object sender, EventArgs e) => this.Response.Redirect("~/Default.aspx");

    protected void buttonExportar_Click(object sender, EventArgs e)
    {
      if (!(this.comboTipoConsulta.SelectedValue != "-1"))
        return;
      PrintingSystem printingSystem = new PrintingSystem();
      PrintableComponentLink val = new PrintableComponentLink();
      if (this.comboTipoConsulta.SelectedValue == "1")
        val.Component = (IPrintable) this.pivotExport;
      if (this.comboTipoConsulta.SelectedValue == "2")
        val.Component = (IPrintable) this.pivotExport2;
      if (this.comboTipoConsulta.SelectedValue == "3")
        val.Component = (IPrintable) this.pivotExport3;
      val.PrintingSystem = printingSystem;
      CompositeLink compositeLink = new CompositeLink();
      if (val != null)
        compositeLink.Links.Add((LinkBase) val);
      compositeLink.PrintingSystem = printingSystem;
      compositeLink.CreateDocument();
      string empty = string.Empty;
      compositeLink.PrintingSystem.ExportOptions.Xlsx.ExportMode = XlsxExportMode.SingleFile;
      string str = "xlsx";
      using (MemoryStream memoryStream = new MemoryStream())
      {
        compositeLink.PrintingSystem.ExportToXlsx((Stream) memoryStream);
        this.Response.Clear();
        this.Response.Buffer = false;
        this.Response.AppendHeader("Content-Type", string.Format("application/{0}", (object) str));
        this.Response.AppendHeader("Content-Transfer-Encoding", "binary");
        this.Response.AppendHeader("Content-Disposition", string.Format("attachment; filename={0}.{1}", (object) nameof (Cubo), (object) str));
        this.Response.BinaryWrite(memoryStream.GetBuffer());
        this.Response.End();
      }
      printingSystem.Dispose();
    }
  }
}
