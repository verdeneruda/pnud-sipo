// Decompiled with JetBrains decompiler
// Type: UTO.Certificacion.VerActividades
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using NE.CLib.Linq;
using System;
using System.Configuration;
using System.Data;
using System.Data.Linq;
using System.IO;
using System.Web.UI.WebControls;

namespace UTO.Certificacion
{
  public class VerActividades : BaseModulo
  {
    protected Label labelRegistarActividades;
    protected Button buttonVolver;
    protected Label labelDatosGenerales;
    protected Label labelFechaActividad;
    protected Literal LiteralFechaActividad;
    protected Label labelActividad;
    protected Literal LiteralActividad;
    protected Label labelEntidad;
    protected Literal LiteralPersonas;
    protected Label labelNumeroPersonasimpactadas;
    protected Literal LiteralEntidades;
    protected Label labelMaterialEntregado;
    protected Literal LiteralDepartamento;
    protected Label label1;
    protected Literal LiteralCiudad;
    protected Label label3;
    protected Literal LiteralMaterial;
    protected Label label2;
    protected Repeater ListaEnlaces;
    protected Label lblEmptyData;

    protected void Page_Load(object sender, EventArgs e)
    {
      if (this.IsPostBack)
        return;
      this.InitData();
    }

    private void InitData()
    {
      string str = "";
      this.LocalInfo.SetData("idActividad", (object) ((BaseModulo.strSendParam) this.LocalInfo.MyParams).id);
      act_Actividad byKey = CLinq.FindByKey<act_Actividad>((DataContext) this.MyDataContext, (object) (int) this.LocalInfo.GetData("idActividad"));
      this.LiteralActividad.Text = byKey.act_Actividad1;
      this.LiteralFechaActividad.Text = byKey.act_Fecha.ToShortDateString();
      this.LiteralEntidades.Text = byKey.act_EntidadesIvolucradas;
      this.LiteralPersonas.Text = byKey.act_PersonasImpactadas.ToString();
      this.LiteralDepartamento.Text = byKey.mun_Municipio.dep_Departamento.dep_Descripcion;
      this.LiteralCiudad.Text = byKey.mun_Municipio.mun_Descripcion;
      for (int index = 0; index < byKey.ame_ActividadmaterialEntregados.Count; ++index)
        str = str + "<li>" + byKey.ame_ActividadmaterialEntregados[index].acm_ActividadMaterial.acm_Descripcion + " (" + byKey.ame_ActividadmaterialEntregados[index].ame_Cantidad.ToString() + ")";
      this.LiteralMaterial.Text = str;
      this.ListaEnlaces.DataSource = (object) CCertificacion.BuscaDocActividad((int) this.LocalInfo.GetData("idActividad"), this.MyDataContext.Connection.ConnectionString);
      this.ListaEnlaces.DataBind();
    }

    protected void buttonDescargaDocumento_Click(object sender, EventArgs e)
    {
      try
      {
        DataTable fileById = CDocumento.FindFileById(Convert.ToInt32((sender as Button).CommandArgument).ToString(), this.MyDataContext.Connection.ConnectionString);
        byte[] buffer = (byte[]) fileById.Rows[0]["Documento"];
        string str1 = (string) fileById.Rows[0]["Nombre"];
        string str2 = ConfigurationSettings.AppSettings["DirectorioArchivosDescarga"].ToString();
        FileStream output = new FileStream(str2 + str1, FileMode.Create, FileAccess.Write);
        BinaryWriter binaryWriter = new BinaryWriter((Stream) output);
        binaryWriter.Write(buffer);
        binaryWriter.Close();
        output.Close();
        FileInfo fileInfo = new FileInfo(str2 + str1);
        if (!fileInfo.Exists)
          return;
        this.Response.Clear();
        this.Response.AddHeader("Content-Disposition", "attachment; filename=" + fileInfo.Name);
        this.Response.AddHeader("Content-Length", fileInfo.Length.ToString());
        this.Response.ContentType = "application/octet-stream";
        this.Response.WriteFile(fileInfo.FullName);
        this.Response.End();
      }
      catch (Exception ex)
      {
      }
    }

    protected void buttonVolver_Click(object sender, EventArgs e) => this.Response.Redirect("ActividadesBuscar.aspx");

    protected void ListaEnlaces_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
      if (this.ListaEnlaces.Items.Count < 1)
      {
        this.lblEmptyData.Visible = true;
        this.ListaEnlaces.Visible = false;
      }
      else
      {
        this.lblEmptyData.Visible = false;
        this.ListaEnlaces.Visible = true;
      }
    }
  }
}
