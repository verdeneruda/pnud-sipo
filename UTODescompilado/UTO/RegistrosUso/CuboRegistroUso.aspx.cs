// Decompiled with JetBrains decompiler
// Type: UTO.RegistrosUso.CuboRegistroUso
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using DevExpress.Web.ASPxPivotGrid;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrintingLinks;
using System;
using System.IO;
using System.Web.UI.WebControls;

namespace UTO.RegistrosUso
{
  public class CuboRegistroUso : System.Web.UI.Page
  {
    protected Label labelConsultas;
    protected DevExpress.Web.ASPxPivotGrid.ASPxPivotGrid ASPxPivotGrid1;
    protected PivotGridField fieldDepartamento;
    protected PivotGridField fieldCiudad;
    protected PivotGridField fieldYeFecha;
    protected PivotGridField fieldSustancia;
    protected PivotGridField fieldCantidad;
    protected PivotGridField PivotGridField1;
    protected PivotGridField PivotGridField2;
    protected PivotGridField PivotGridField3;
    protected ASPxPivotGridExporter pivotExport;
    protected Button ButtonVolver;
    protected Button buttonExportar;
    protected SqlDataSource SqlDataSource1;

    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void ButtonVolver_Click(object sender, EventArgs e) => this.Response.Redirect("~/Default.aspx");

    protected void buttonExportar_Click(object sender, EventArgs e)
    {
      PrintingSystem printingSystem = new PrintingSystem();
      PrintableComponentLink val = new PrintableComponentLink();
      val.Component = (IPrintable) this.pivotExport;
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
        this.Response.AppendHeader("Content-Disposition", string.Format("attachment; filename={0}.{1}", (object) "Cubo", (object) str));
        this.Response.BinaryWrite(memoryStream.GetBuffer());
        this.Response.End();
      }
      printingSystem.Dispose();
    }
  }
}
