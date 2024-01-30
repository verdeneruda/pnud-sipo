// Decompiled with JetBrains decompiler
// Type: UTO.Comunes.DocumentosVarios
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using AjaxControlToolkit;
using NE.CLib;
using System;
using System.Configuration;
using System.Data;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UTO.Comunes
{
  public class DocumentosVarios : UserControl
  {
    protected Label labelError;
    protected Label labelAsuntoDocumento;
    protected TextBox TextAsunto;
    protected Label labelFechaDocumento;
    protected TextBox textFecha;
    protected CalendarExtender calendarfecha;
    protected FileUpload FileUpload1;
    protected Button buttonAdicionar;
    protected GridView gridDocumentos;

    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void buttonAdicionar_Click(object sender, EventArgs e)
    {
      this.labelError.Text = "";
      if (this.FileUpload1.PostedFile != null && this.FileUpload1.PostedFile.ContentLength > 0)
      {
        DateTime today = DateTime.Today;
        HttpPostedFile postedFile = this.FileUpload1.PostedFile;
        byte[] numArray = new byte[postedFile.ContentLength];
        postedFile.InputStream.Read(numArray, 0, postedFile.ContentLength);
        string fileName = Path.GetFileName(this.FileUpload1.PostedFile.FileName);
        if (!CValidator.isDate(this.textFecha.Text, ref today))
          this.labelError.Text = "Error al almacenar un documento:\n Debe ingresar una fecha válida.";
        try
        {
          CDocumento.UpLoadFile((string) this.ViewState["relationTable"], (string) this.ViewState["relationField"], (string) this.ViewState["relationId"], numArray, fileName, this.TextAsunto.Text, this.textFecha.Text, (string) this.ViewState["connectionString"]);
          this.gridDocumentos.DataSource = (object) CDocumento.FindFiles((string) this.ViewState["relationTable"], (string) this.ViewState["relationField"], (string) this.ViewState["relationId"], (string) this.ViewState["connectionString"]);
          this.gridDocumentos.DataBind();
          this.labelError.Text = "";
        }
        catch (Exception ex)
        {
          this.labelError.Text = "Error al almacenar un documento:\n" + (object) ex.InnerException;
        }
      }
      else
        this.labelError.Text = "Error al almacenar un documento\n";
    }

    public void Init(
      string relationTable,
      string relationField,
      string relationId,
      string connectionString)
    {
      this.ViewState[nameof (relationTable)] = (object) relationTable;
      this.ViewState[nameof (relationField)] = (object) relationField;
      this.ViewState[nameof (relationId)] = (object) relationId;
      this.ViewState[nameof (connectionString)] = (object) connectionString;
      this.textFecha.Text = DateTime.Today.ToShortDateString();
      try
      {
        this.gridDocumentos.DataSource = this.FindFiles(relationTable, relationField, relationId, connectionString);
        this.gridDocumentos.DataBind();
      }
      catch (Exception ex)
      {
        throw new Exception("Error al cargar los documentos anexos:\n", ex.InnerException);
      }
    }

    private object FindFiles(
      string relationTable,
      string relationField,
      string relationId,
      string connectionString)
    {
      return (object) CDocumento.FindFiles(relationTable, relationField, relationId, connectionString);
    }

    protected void gridDocumentos_RowCommand(object sender, GridViewCommandEventArgs e)
    {
      Exception exception;
      if (e.CommandName.Equals("Eliminar"))
      {
        try
        {
          CDocumento.DeleteFile((string) this.ViewState["relationTable"], (string) this.ViewState["relationField"], (string) this.ViewState["relationId"], this.gridDocumentos.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString(), (string) this.ViewState["connectionString"]);
          this.gridDocumentos.DataSource = (object) CDocumento.FindFiles((string) this.ViewState["relationTable"], (string) this.ViewState["relationField"], (string) this.ViewState["relationId"], (string) this.ViewState["connectionString"]);
          this.gridDocumentos.DataBind();
        }
        catch (Exception ex)
        {
          exception = ex;
        }
      }
      if (!e.CommandName.Equals("Ver"))
        return;
      try
      {
        try
        {
          DataTable fileById = CDocumento.FindFileById(this.gridDocumentos.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString(), (string) this.ViewState["connectionString"]);
          byte[] buffer = (byte[]) fileById.Rows[0]["Documento"];
          string str1 = (string) fileById.Rows[0]["Nombre"];
          string str2 = ConfigurationSettings.AppSettings["DirectorioArchivosDescarga"].ToString();
          FileStream output = new FileStream(str2 + str1, FileMode.Create, FileAccess.Write);
          BinaryWriter binaryWriter = new BinaryWriter((Stream) output);
          binaryWriter.Write(buffer);
          binaryWriter.Close();
          output.Close();
          FileInfo fileInfo = new FileInfo(str2 + str1);
          if (fileInfo.Exists)
          {
            this.Response.Clear();
            this.Response.AddHeader("Content-Disposition", "attachment; filename=" + fileInfo.Name);
            this.Response.AddHeader("Content-Length", fileInfo.Length.ToString());
            this.Response.ContentType = "application/octet-stream";
            this.Response.WriteFile(fileInfo.FullName);
            this.Response.End();
          }
        }
        catch (Exception ex)
        {
          exception = ex;
        }
      }
      catch (Exception ex)
      {
        exception = ex;
      }
    }
  }
}
