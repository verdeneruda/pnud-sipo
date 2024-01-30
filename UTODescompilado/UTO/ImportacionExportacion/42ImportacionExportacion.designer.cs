// Decompiled with JetBrains decompiler
// Type: UTO.ImportacionExportacion.spLicenciaBuscarResult
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.Data.Linq.Mapping;

namespace UTO.ImportacionExportacion
{
  public class spLicenciaBuscarResult
  {
    private int _Id;
    private string _Resolucion;
    private DateTime _Fecha_licencia;
    private string _Empresa;

    [Column(Storage = "_Id", DbType = "Int NOT NULL")]
    public int Id
    {
      get => this._Id;
      set
      {
        if (this._Id == value)
          return;
        this._Id = value;
      }
    }

    [Column(Storage = "_Resolucion", DbType = "VarChar(25) NOT NULL", CanBeNull = false)]
    public string Resolucion
    {
      get => this._Resolucion;
      set
      {
        if (!(this._Resolucion != value))
          return;
        this._Resolucion = value;
      }
    }

    [Column(Name = "[Fecha licencia]", Storage = "_Fecha_licencia", DbType = "DateTime NOT NULL")]
    public DateTime Fecha_licencia
    {
      get => this._Fecha_licencia;
      set
      {
        if (!(this._Fecha_licencia != value))
          return;
        this._Fecha_licencia = value;
      }
    }

    [Column(Storage = "_Empresa", DbType = "VarChar(450)")]
    public string Empresa
    {
      get => this._Empresa;
      set
      {
        if (!(this._Empresa != value))
          return;
        this._Empresa = value;
      }
    }
  }
}
