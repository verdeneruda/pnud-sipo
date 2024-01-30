// Decompiled with JetBrains decompiler
// Type: UTO.RegistrosUso.CargueImportadores
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using DevExpress.Web;
using NE.CLib;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;

namespace UTO.RegistrosUso
{
  public class CargueImportadores : BaseModulo
  {
    protected System.Web.UI.ScriptManager ScriptManager1;
    protected XmlDataSource xmlArchivos;
    protected Label labelCargueImportadores;
    protected ControlError ControlError1;
    protected Label labelDatosGenerales;
    protected Label labelAño;
    protected TextBox textAño;
    protected Label labelArchivo;
    protected FileUpload FileUpload1;
    protected Button buttonprocesar;
    protected Button buttonDescargar;
    protected ASPxGridView gvResultados;
    protected ASPxGridViewExporter exportGrid;
    protected GridView gridResultado;

    private DataTable TablaConsulta
    {
      get => (DataTable) this.Session["CargueImportadores.Consulta"];
      set => this.Session["CargueImportadores.Consulta"] = (object) value;
    }

    protected new void Page_Load(object sender, EventArgs e)
    {
      this.ControlError1.Hide();
      if (!this.IsPostBack)
        this.buttonDescargar.Enabled = false;
      if (this.TablaConsulta == null)
        return;
      this.gvResultados.DataSource = (object) this.TablaConsulta;
      this.gvResultados.DataBind();
    }

    protected void buttonprocesar_Click(object sender, EventArgs e)
    {
      this.gvResultados.DataSource = (object) null;
      this.gvResultados.DataBind();
      try
      {
        this.Validar();
        string appSetting = ConfigurationSettings.AppSettings["ArchivoBD"];
        this.FileUpload1.SaveAs(appSetting + this.FileUpload1.FileName);
        DataTable dataTable = new DataTable();
        this.EliminaDatosTemporal();
        List<string[]> csv = this.parseCSV(appSetting + this.FileUpload1.FileName);
        for (int index = 1; index <= csv.Count - 1; ++index)
          this.MyDataContext.tri_TemporalRegistroReporteImportadors.InsertOnSubmit(new tri_TemporalRegistroReporteImportador()
          {
            CLIENTE = csv[index][0].ToString(),
            NUMERO = "",
            CIUDAD = csv[index][1].ToString(),
            DIRECCION = csv[index][2].ToString(),
            SUSTANCIA = csv[index][3].ToString(),
            KILOS = csv[index][4].ToString(),
            PROVEEDOR = csv[index][5].ToString(),
            APLICACION = csv[index][6].ToString()
          });
        this.MyDataContext.SubmitChanges();
        this.TablaConsulta = (DataTable) null;
        CRegistroUso.CargueArchivo(int.Parse(this.textAño.Text), this.MyDataContext.Connection.ConnectionString);
        this.TablaConsulta = CRegistroUso.BuscarDatos(this.MyDataContext.Connection.ConnectionString);
        this.gvResultados.DataSource = (object) this.TablaConsulta;
        this.gvResultados.DataBind();
        if (this.TablaConsulta.Rows.Count > 0)
          this.buttonDescargar.Enabled = true;
        else
          this.buttonDescargar.Enabled = false;
      }
      catch (Exception ex)
      {
        this.ControlError1.Visible = true;
        this.ControlError1.Show(ex);
      }
    }

    private void EliminaDatosTemporal()
    {
      SqlConnection sqlConnection = new SqlConnection(this.MyDataContext.Connection.ConnectionString);
      sqlConnection.Open();
      SqlCommand sqlCommand = new SqlCommand();
      sqlCommand.Connection = sqlConnection;
      sqlCommand.CommandType = CommandType.Text;
      sqlCommand.CommandText = "delete from rus.tri_TemporalRegistroReporteImportador";
      sqlCommand.ExecuteNonQuery();
      sqlConnection.Close();
    }

    private void Validar()
    {
      string errStr = "";
      bool flag1 = true;
      double number = 0.0;
      if (this.textAño.Text == "")
      {
        flag1 = false;
        errStr += " Escriba el año. <br />";
      }
      bool flag2 = flag1 & CValidator.isNumeric(this.textAño.Text, ref number, "Escriba un valor válido para el año. <br />", ref errStr);
      if (this.FileUpload1.FileName == "")
      {
        flag2 = false;
        errStr += "Seleccione el archivo que se debe procesar. <br />";
      }
      if (!flag2)
        throw new Exception(errStr);
    }

    public List<string[]> parseCSV(string path)
    {
      List<string[]> csv = new List<string[]>();
      string message = "";
      int num = 0;
      try
      {
        using (StreamReader streamReader = new StreamReader(path, Encoding.Default))
        {
          string str;
          while ((str = streamReader.ReadLine()) != null)
          {
            string[] source = str.Split(';');
            if (((IEnumerable<string>) source).Count<string>() != 7)
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

    protected void gridResultado_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
      this.gridResultado.PageIndex = e.NewPageIndex;
      this.gridResultado.DataSource = (object) CRegistroUso.BuscarDatos(this.MyDataContext.Connection.ConnectionString);
      this.gridResultado.DataBind();
    }

    protected void buttonDescargar_Click(object sender, EventArgs e)
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
  }
}
