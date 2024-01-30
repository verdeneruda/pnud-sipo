// Decompiled with JetBrains decompiler
// Type: UTO.ImportacionExportacion.spCuboDeclaracionResult
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.Data.Linq.Mapping;

namespace UTO.ImportacionExportacion
{
  public class spCuboDeclaracionResult
  {
    private string _Importador;
    private int? _Año_declaración;
    private string _Pais;
    private string _Marca_comercial;
    private Decimal? _Cantidad;
    private Decimal? _ValorFOB;
    private Decimal? _Peso_neto;
    private int? _Número_items;
    private string _Sustancia;
    private string _Arancel;

    [Column(Storage = "_Importador", DbType = "VarChar(450)")]
    public string Importador
    {
      get => this._Importador;
      set
      {
        if (!(this._Importador != value))
          return;
        this._Importador = value;
      }
    }

    [Column(Name = "[Año declaración]", Storage = "_Año_declaración", DbType = "Int")]
    public int? Año_declaración
    {
      get => this._Año_declaración;
      set
      {
        int? añoDeclaración = this._Año_declaración;
        int? nullable = value;
        if ((añoDeclaración.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (añoDeclaración.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this._Año_declaración = value;
      }
    }

    [Column(Storage = "_Pais", DbType = "VarChar(255)")]
    public string Pais
    {
      get => this._Pais;
      set
      {
        if (!(this._Pais != value))
          return;
        this._Pais = value;
      }
    }

    [Column(Name = "[Marca comercial]", Storage = "_Marca_comercial", DbType = "VarChar(150)")]
    public string Marca_comercial
    {
      get => this._Marca_comercial;
      set
      {
        if (!(this._Marca_comercial != value))
          return;
        this._Marca_comercial = value;
      }
    }

    [Column(Storage = "_Cantidad", DbType = "Decimal(0,0)")]
    public Decimal? Cantidad
    {
      get => this._Cantidad;
      set
      {
        Decimal? cantidad = this._Cantidad;
        Decimal? nullable = value;
        if ((cantidad.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (cantidad.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this._Cantidad = value;
      }
    }

    [Column(Storage = "_ValorFOB", DbType = "Money")]
    public Decimal? ValorFOB
    {
      get => this._ValorFOB;
      set
      {
        Decimal? valorFob = this._ValorFOB;
        Decimal? nullable = value;
        if ((valorFob.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (valorFob.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this._ValorFOB = value;
      }
    }

    [Column(Name = "[Peso neto]", Storage = "_Peso_neto", DbType = "Decimal(0,0)")]
    public Decimal? Peso_neto
    {
      get => this._Peso_neto;
      set
      {
        Decimal? pesoNeto = this._Peso_neto;
        Decimal? nullable = value;
        if ((pesoNeto.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (pesoNeto.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this._Peso_neto = value;
      }
    }

    [Column(Name = "[Número items]", Storage = "_Número_items", DbType = "Int")]
    public int? Número_items
    {
      get => this._Número_items;
      set
      {
        int? númeroItems = this._Número_items;
        int? nullable = value;
        if ((númeroItems.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (númeroItems.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this._Número_items = value;
      }
    }

    [Column(Storage = "_Sustancia", DbType = "VarChar(255)")]
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

    [Column(Storage = "_Arancel", DbType = "VarChar(50)")]
    public string Arancel
    {
      get => this._Arancel;
      set
      {
        if (!(this._Arancel != value))
          return;
        this._Arancel = value;
      }
    }
  }
}
