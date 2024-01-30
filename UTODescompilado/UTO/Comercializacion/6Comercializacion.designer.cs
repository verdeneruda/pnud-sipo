// Decompiled with JetBrains decompiler
// Type: UTO.Comercializacion.spConsultaPromedioResult
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.Data.Linq.Mapping;

namespace UTO.Comercializacion
{
  public class spConsultaPromedioResult
  {
    private string _Sustancia;
    private string _Presentacion;
    private string _Departamento;
    private string _Ciudad;
    private DateTime? _FechaInicial;
    private DateTime? _FechaFinal;
    private Decimal? _PrecioPromedio;

    [Column(Storage = "_Sustancia", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string Sustancia
    {
      get => this._Sustancia;
      set
      {
        if (!(this._Sustancia != value))
          return;
        this._Sustancia = value;
      }
    }

    [Column(Storage = "_Presentacion", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string Presentacion
    {
      get => this._Presentacion;
      set
      {
        if (!(this._Presentacion != value))
          return;
        this._Presentacion = value;
      }
    }

    [Column(Storage = "_Departamento", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string Departamento
    {
      get => this._Departamento;
      set
      {
        if (!(this._Departamento != value))
          return;
        this._Departamento = value;
      }
    }

    [Column(Storage = "_Ciudad", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string Ciudad
    {
      get => this._Ciudad;
      set
      {
        if (!(this._Ciudad != value))
          return;
        this._Ciudad = value;
      }
    }

    [Column(Storage = "_FechaInicial", DbType = "DateTime")]
    public DateTime? FechaInicial
    {
      get => this._FechaInicial;
      set
      {
        DateTime? fechaInicial = this._FechaInicial;
        DateTime? nullable = value;
        if ((fechaInicial.HasValue != nullable.HasValue ? 1 : (!fechaInicial.HasValue ? 0 : (fechaInicial.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this._FechaInicial = value;
      }
    }

    [Column(Storage = "_FechaFinal", DbType = "DateTime")]
    public DateTime? FechaFinal
    {
      get => this._FechaFinal;
      set
      {
        DateTime? fechaFinal = this._FechaFinal;
        DateTime? nullable = value;
        if ((fechaFinal.HasValue != nullable.HasValue ? 1 : (!fechaFinal.HasValue ? 0 : (fechaFinal.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this._FechaFinal = value;
      }
    }

    [Column(Storage = "_PrecioPromedio", DbType = "Money")]
    public Decimal? PrecioPromedio
    {
      get => this._PrecioPromedio;
      set
      {
        Decimal? precioPromedio = this._PrecioPromedio;
        Decimal? nullable = value;
        if ((precioPromedio.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (precioPromedio.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this._PrecioPromedio = value;
      }
    }
  }
}
