// Decompiled with JetBrains decompiler
// Type: UTO.Certificacion.BuscarTecnicosCertificados
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.Web.UI.WebControls;

namespace UTO.Certificacion
{
  public class BuscarTecnicosCertificados : BaseModulo
  {
    protected XmlDataSource xmlCertificados;
    protected Label labelBusquedaTecnicoCertificados;
    protected Label labelparametros;
    protected Label labelDocumento;
    protected TextBox textDocumento;
    protected Label labelNombre;
    protected TextBox textNombre;
    protected Button buttonBuscar;
    protected Button buttonAdicionar;
    protected GridView gridBuscarCertificados;
    protected SqlDataSource tecnicosCertificadosBuscarDataSource;

    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void buttonAdicionar_Click(object sender, EventArgs e) => this.Response.Redirect("~/Certificacion/TecnicosRegistrar.aspx?mostrar=3");

    protected void gridBuscarTecnicos_RowCommand(object sender, GridViewCommandEventArgs e)
    {
    }

    protected void gridBuscarCertificados_RowCommand(object sender, GridViewCommandEventArgs e)
    {
      if (e.CommandName.Equals("Modificar"))
        this.Response.Redirect("~/Certificacion/TecnicosRegistrar.aspx?mostrar=3");
      if (!e.CommandName.Equals("Eliminar"))
        ;
      if (!e.CommandName.Equals("Ver"))
        return;
      this.Response.Redirect("~/Certificacion/TecnicosCertificadosVer.aspx");
    }
  }
}
