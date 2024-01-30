// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.spConsultaReporteRegeneracionResult
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.Data.Linq.Mapping;

namespace UTO.Recuperacion
{
  public class spConsultaReporteRegeneracionResult
  {
    private string _Beneficiario;
    private string _tipoGas;
    private int? _Cantidad;
    private Decimal? _Entregada;
    private Decimal? _Regenerada;
    private Decimal? _Rechazada;

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

    [Column(Storage = "_tipoGas", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string tipoGas
    {
      get => this._tipoGas;
      set
      {
        if (!(this._tipoGas != value))
          return;
        this._tipoGas = value;
      }
    }

    [Column(Storage = "_Cantidad", DbType = "Int")]
    public int? Cantidad
    {
      get => this._Cantidad;
      set
      {
        int? cantidad = this._Cantidad;
        int? nullable = value;
        if ((cantidad.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (cantidad.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this._Cantidad = value;
      }
    }

    [Column(Storage = "_Entregada", DbType = "Decimal(0,0)")]
    public Decimal? Entregada
    {
      get => this._Entregada;
      set
      {
        Decimal? entregada = this._Entregada;
        Decimal? nullable = value;
        if ((entregada.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (entregada.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this._Entregada = value;
      }
    }

    [Column(Storage = "_Regenerada", DbType = "Decimal(0,0)")]
    public Decimal? Regenerada
    {
      get => this._Regenerada;
      set
      {
        Decimal? regenerada = this._Regenerada;
        Decimal? nullable = value;
        if ((regenerada.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (regenerada.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this._Regenerada = value;
      }
    }

    [Column(Storage = "_Rechazada", DbType = "Decimal(0,0)")]
    public Decimal? Rechazada
    {
      get => this._Rechazada;
      set
      {
        Decimal? rechazada = this._Rechazada;
        Decimal? nullable = value;
        if ((rechazada.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (rechazada.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this._Rechazada = value;
      }
    }
  }
}
