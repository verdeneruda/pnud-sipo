// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.CuboCentroRegeneracion
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
  public class CuboCentroRegeneracion : System.Web.UI.Page
  {
    protected Label labelConsultas;
    protected Label labelSeleccioneConsultas;
    protected DropDownList comboTipoConsulta;
    protected Panel PanelUso;
    protected DevExpress.Web.ASPxPivotGrid.ASPxPivotGrid ASPxPivotGrid2;
    protected PivotGridField PeriodoField;
    protected PivotGridField CentroField;
    protected PivotGridField SustanciaField;
    protected PivotGridField DestinoField;
    protected PivotGridField fieldCantidad;
    protected ASPxPivotGridExporter pivotExport3;
    protected SqlDataSource SqlDataCuboEquipos;
    protected Panel PanelCuboEquipos;
    protected DevExpress.Web.ASPxPivotGrid.ASPxPivotGrid ASPxPivotGrid1;
    protected PivotGridField PivotGridField12;
    protected PivotGridField fieldCompra;
    protected PivotGridField fieldTipo;
    protected PivotGridField PivotGridField13;
    protected PivotGridField PivotGridField14;
    protected PivotGridField fieldEstado;
    protected PivotGridField fieldTercero;
    protected PivotGridField PivotGridField4;
    protected PivotGridField PivotGridField5;
    protected ASPxPivotGridExporter pivotExport1;
    protected SqlDataSource SqlDataEquipos;
    protected Button ButtonVolver;
    protected Button buttonExportar;

    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void ButtonVolver_Click(object sender, EventArgs e) => this.Response.Redirect("~/Default.aspx");

    protected void buttonExportar_Click(object sender, EventArgs e)
    {
      if (!(this.comboTipoConsulta.SelectedValue != "-1"))
        return;
      PrintingSystem printingSystem = new PrintingSystem();
      PrintableComponentLink val = new PrintableComponentLink();
      if (this.comboTipoConsulta.SelectedValue == "2")
        val.Component = (IPrintable) this.pivotExport3;
      if (this.comboTipoConsulta.SelectedValue == "3")
        val.Component = (IPrintable) this.pivotExport1;
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
        this.Response.AppendHeader("Content-Disposition", string.Format("attachment; filename={0}.{1}", (object) "Cubo", (object) str));
        this.Response.BinaryWrite(memoryStream.GetBuffer());
        this.Response.End();
      }
      printingSystem.Dispose();
    }

    protected void comboTipoConsulta_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.comboTipoConsulta.SelectedValue == "-1")
      {
        this.PanelCuboEquipos.Visible = false;
        this.PanelUso.Visible = false;
      }
      if (this.comboTipoConsulta.SelectedValue == "2")
      {
        this.PanelCuboEquipos.Visible = false;
        this.PanelUso.Visible = true;
      }
      if (!(this.comboTipoConsulta.SelectedValue == "3"))
        return;
      this.PanelCuboEquipos.Visible = true;
      this.PanelUso.Visible = false;
    }
  }
}
