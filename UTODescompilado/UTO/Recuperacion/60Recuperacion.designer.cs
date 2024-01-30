// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.spReporteCentroConsolidadoBuscarResult
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.Data.Linq.Mapping;

namespace UTO.Recuperacion
{
  public class spReporteCentroConsolidadoBuscarResult
  {
    private int _Id;
    private int _Mes;
    private DateTime _Fecha;

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

    [Column(Storage = "_Mes", DbType = "Int NOT NULL")]
    public int Mes
    {
      get => this._Mes;
      set
      {
        if (this._Mes == value)
          return;
        this._Mes = value;
      }
    }

    [Column(Storage = "_Fecha", DbType = "DateTime NOT NULL")]
    public DateTime Fecha
    {
      get => this._Fecha;
      set
      {
        if (!(this._Fecha != value))
          return;
        this._Fecha = value;
      }
    }
  }
}
