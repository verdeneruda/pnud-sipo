// Decompiled with JetBrains decompiler
// Type: UTO.ImportacionExportacion.CargueInformacionImportacion
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using AjaxControlToolkit;
using DevExpress.Web;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Web.UI.WebControls;

namespace UTO.ImportacionExportacion
{
  public class CargueInformacionImportacion : BaseModulo
  {
    protected ToolkitScriptManager ToolkitScriptManager1;
    protected Label labelCargueImportacion;
    protected ControlError ControlError1;
    protected Label labelDatosGenerales;
    protected Label labelAño;
    protected TextBox textAno;
    protected Label labelArchivo;
    protected FileUpload FileUpload1;
    protected Button buttonprocesar;
    protected Button buttonExportar;
    protected ASPxGridView gvResultados;
    protected ASPxGridViewExporter exportGrid;
    protected GridView gridResultado;

    private DataTable TablaConsulta
    {
      get => (DataTable) this.Session["CargueInformacionImportacion.Consulta"];
      set => this.Session["CargueInformacionImportacion.Consulta"] = (object) value;
    }

    protected new void Page_Load(object sender, EventArgs e)
    {
      this.ControlError1.Hide();
      if (!this.IsPostBack)
        this.buttonExportar.Enabled = false;
      if (this.TablaConsulta == null)
        return;
      this.gvResultados.DataSource = (object) this.TablaConsulta;
      this.gvResultados.DataBind();
    }

    public void InitData()
    {
    }

    protected void buttonprocesar_Click(object sender, EventArgs e)
    {
      this.gvResultados.DataSource = (object) null;
      this.gvResultados.DataBind();
      CConsultaImportacion.EliminaDatosTemporal(this.MyDataContext.Connection.ConnectionString);
      try
      {
        this.Validar();
        string appSetting = ConfigurationSettings.AppSettings["ArchivoBD"];
        this.FileUpload1.SaveAs(appSetting + this.FileUpload1.FileName);
        DataTable dataTable = new DataTable();
        List<string[]> csv = this.parseCSV(appSetting + this.FileUpload1.FileName);
        for (int index = 1; index <= csv.Count - 1; ++index)
          this.MyDataContext.tdi_TemporalDeclaracionImportacions.InsertOnSubmit(new tdi_TemporalDeclaracionImportacion()
          {
            NumeroDeclaracion = csv[index][0].ToString(),
            Item = csv[index][1].ToString(),
            FechaDeclaracion = csv[index][2].ToString(),
            Cantidad = csv[index][3].ToString(),
            ValorFOB = csv[index][4].ToString(),
            PesoNeto = csv[index][5].ToString(),
            Nit = csv[index][6].ToString(),
            RazonSocial = csv[index][7].ToString(),
            PaisProcedencia = csv[index][8].ToString(),
            UnidadMedidad = csv[index][9].ToString(),
            Modalidad = csv[index][10].ToString(),
            Sustancia = csv[index][11].ToString()
          });
        this.MyDataContext.SubmitChanges();
        CConsultaImportacion.CargueArchivo(int.Parse(this.textAno.Text), this.MyDataContext.Connection.ConnectionString);
        this.TablaConsulta = CConsultaImportacion.BuscarDatos(this.MyDataContext.Connection.ConnectionString);
        if (this.TablaConsulta.Rows.Count > 0)
          this.buttonExportar.Enabled = true;
        this.gvResultados.DataSource = (object) this.TablaConsulta;
        this.gvResultados.DataBind();
      }
      catch (Exception ex)
      {
        this.ControlError1.Visible = true;
        this.ControlError1.Show(ex);
      }
    }

    private void Validar()
    {
      string message = "";
      bool flag = true;
      if (this.textAno.Text == "")
      {
        flag = false;
        message += " El año es un campo obligatorio. </br>";
      }
      else
      {
        try
        {
          int.Parse(this.textAno.Text);
        }
        catch
        {
          flag = false;
          message += " El valor del año debe ser entero. </br>";
        }
      }
      if (this.FileUpload1.FileName == "")
      {
        flag = false;
        message += " Tiene que cargar un archivo para poder procesarlo. </br>";
      }
      if (!flag)
        throw new Exception(message);
    }

    public List<string[]> parseCSV(string path)
    {
      List<string[]> csv = new List<string[]>();
      string message = "";
      int num = 0;
      try
      {
        using (StreamReader streamReader = new StreamReader(path))
        {
          string str;
          while ((str = streamReader.ReadLine()) != null)
          {
            string[] source = str.Split(';');
            if (((IEnumerable<string>) source).Count<string>() != 12)
              message = message + "Número de columnas inválido en la fila " + num.ToString() + "<br/>";
            csv.Add(source);
            ++num;
          }
        }
      }
      catch (Exception ex)
      {
        this.ControlError1.Visible = true;
        this.ControlError1.Show(ex);
      }
      if (message != "")
        throw new Exception(message);
      return csv;
    }

    protected void buttonExportar_Click(object sender, EventArgs e)
    {
      try
      {
        this.gvResultados.DataSource = (object) this.TablaConsulta;
        this.gvResultados.DataBind();
        if (this.gvResultados.Selection.Count == 0)
        {
          this.exportGrid.ExportedRowType = GridViewExportedRowType.All;
          this.exportGrid.FileName = "Resultados" + DateTime.Now.ToString("ddMMyyyyHHmmss");
        }
        this.exportGrid.WriteXlsxToResponse();
      }
      catch (Exception ex)
      {
      }
    }

    protected void gridResultado_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
      this.gridResultado.PageIndex = e.NewPageIndex;
      this.gridResultado.DataSource = (object) CConsultaImportacion.BuscarDatos(this.MyDataContext.Connection.ConnectionString);
      this.gridResultado.DataBind();
    }
  }
}
