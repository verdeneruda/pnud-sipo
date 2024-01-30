// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.spReporteCentroBuscarResult
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.Data.Linq.Mapping;

namespace UTO.Recuperacion
{
  public class spReporteCentroBuscarResult
  {
    private int _Id;
    private DateTime _Fecha;
    private string _Beneficiario;
    private string _Tipo_gas;
    private Decimal _Cantidad_entregada;
    private Decimal _Cantidad_regenerada;
    private Decimal _Cantidad_rechazada;

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

    [Column(Storage = "_Beneficiario", DbType = "VarChar(450)")]
    public string Beneficiario
    {
      get => this._Beneficiario;
      set
      {
        if (!(this._Beneficiario != value))
          return;
        this._Beneficiario = value;
      }
    }

    [Column(Name = "[Tipo gas]", Storage = "_Tipo_gas", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string Tipo_gas
    {
      get => this._Tipo_gas;
      set
      {
        if (!(this._Tipo_gas != value))
          return;
        this._Tipo_gas = value;
      }
    }

    [Column(Name = "[Cantidad entregada]", Storage = "_Cantidad_entregada", DbType = "Decimal(0,0) NOT NULL")]
    public Decimal Cantidad_entregada
    {
      get => this._Cantidad_entregada;
      set
      {
        if (!(this._Cantidad_entregada != value))
          return;
        this._Cantidad_entregada = value;
      }
    }

    [Column(Name = "[Cantidad regenerada]", Storage = "_Cantidad_regenerada", DbType = "Decimal(0,0) NOT NULL")]
    public Decimal Cantidad_regenerada
    {
      get => this._Cantidad_regenerada;
      set
      {
        if (!(this._Cantidad_regenerada != value))
          return;
        this._Cantidad_regenerada = value;
      }
    }

    [Column(Name = "[Cantidad rechazada]", Storage = "_Cantidad_rechazada", DbType = "Decimal(0,0) NOT NULL")]
    public Decimal Cantidad_rechazada
    {
      get => this._Cantidad_rechazada;
      set
      {
        if (!(this._Cantidad_rechazada != value))
          return;
        this._Cantidad_rechazada = value;
      }
    }
  }
}
