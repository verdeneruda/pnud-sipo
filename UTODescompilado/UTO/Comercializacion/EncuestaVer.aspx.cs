// Decompiled with JetBrains decompiler
// Type: UTO.Comercializacion.EncuestaVer
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.Web.UI.WebControls;

namespace UTO.Comercializacion
{
  public class EncuestaVer : BaseModulo
  {
    protected XmlDataSource XmlCollapsibleSustancia;
    protected Label labelVerEncuesta;
    protected Label labelDatosGenerales;
    protected Label labelfecha;
    protected Label labelDepartamento;
    protected Label labelCiudad;
    protected Label labelEmpresa;
    protected Label labelNit;
    protected Label labelTelefono;
    protected Label labelEMail;
    protected Label labelDireccion;
    protected Label labelContacto;
    protected Label labelCargo;
    protected GridView gridDetSustancias;

    protected new void Page_Load(object sender, EventArgs e)
    {
    }
  }
}
