// Decompiled with JetBrains decompiler
// Type: UTO.ImportacionExportacion.Cubo
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using DevExpress.Web.ASPxPivotGrid;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrintingLinks;
using System;
using System.IO;
using System.Web.UI.WebControls;

namespace UTO.ImportacionExportacion
{
  public class Cubo : System.Web.UI.Page
  {
    protected Label labelConsultas;
    protected Label labelSeleccioneConsultas;
    protected DropDownList comboTipoConsulta;
    protected Panel PanelCuboImportador;
    protected DevExpress.Web.ASPxPivotGrid.ASPxPivotGrid ASPxPivotGrid3;
    protected PivotGridField fieldImportador;
    protected PivotGridField fieldExportador;
    protected PivotGridField fieldAovistobueno;
    protected PivotGridField fieldAovigencia;
    protected PivotGridField fieldPais;
    protected PivotGridField fieldAduana;
    protected PivotGridField fieldPuertodeembargue;
    protected PivotGridField fieldEquipo;
    protected PivotGridField fieldCantidadequipo;
    protected PivotGridField fieldSustancia;
    protected PivotGridField fieldArancel;
    protected PivotGridField fieldCantidadimportada;
    protected PivotGridField fieldPreciounitariosustancia;
    protected SqlDataSource SqlDataCuboImportacion;
    protected Panel PanelCuboExportador;
    protected DevExpress.Web.ASPxPivotGrid.ASPxPivotGrid ASPxPivotGrid1;
    protected PivotGridField fieldImportadorDeclaracion;
    protected PivotGridField fieldAnoDeclaracion;
    protected PivotGridField fieldPaisDeclaracion;
    protected PivotGridField fieldMarcaComercial;
    protected PivotGridField fieldCantidad;
    protected PivotGridField fieldValorFOB;
    protected PivotGridField fieldPesoNeto;
    protected PivotGridField fieldNumeroItems;
    protected PivotGridField fieldSustanciaDeclaracion;
    protected PivotGridField fieldDeclaracion;
    protected SqlDataSource SqlDataDeclaracion;
    protected ASPxPivotGridExporter pivotExport;
    protected ASPxPivotGridExporter pivotExport2;
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
      }
      if (this.comboTipoConsulta.SelectedValue == "1")
      {
        this.PanelCuboImportador.Visible = true;
        this.PanelCuboExportador.Visible = false;
      }
      if (!(this.comboTipoConsulta.SelectedValue == "2"))
        return;
      this.PanelCuboImportador.Visible = false;
      this.PanelCuboExportador.Visible = true;
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
      val.PrintingSystem = printingSystem;
      CompositeLink compositeLink = new CompositeLink();
      if (val != null)
        compositeLink.Links.Add((LinkBase) val);
      compositeLink.PrintingSystem = printingSystem;
      compositeLink.CreateDocument();
      string empty = string.Empty;
      compositeLink.PrintingSystem.ExportOptions.Xls.ExportMode = XlsExportMode.SingleFile;
      string str = "xls";
      using (MemoryStream memoryStream = new MemoryStream())
      {
        compositeLink.PrintingSystem.ExportToXls((Stream) memoryStream);
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
