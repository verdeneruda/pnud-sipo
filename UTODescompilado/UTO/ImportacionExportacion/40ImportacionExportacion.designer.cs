// Decompiled with JetBrains decompiler
// Type: UTO.ImportacionExportacion.spCuboImportacionResult
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.Data.Linq.Mapping;

namespace UTO.ImportacionExportacion
{
  public class spCuboImportacionResult
  {
    private string _Importador;
    private string _Exportador;
    private int? _Año_visto_bueno;
    private int? _Año_vigencia;
    private string _Pais;
    private string _Aduana;
    private string _Puerto_de_embargue;
    private string _Equipo;
    private Decimal? _Cantidad_equipo;
    private string _Sustancia;
    private string _Arancel;
    private Decimal? _Cantidad_importada;
    private Decimal? _Precio_unitario_sustancia;

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

    [Column(Storage = "_Exportador", DbType = "VarChar(150) NOT NULL", CanBeNull = false)]
    public string Exportador
    {
      get => this._Exportador;
      set
      {
        if (!(this._Exportador != value))
          return;
        this._Exportador = value;
      }
    }

    [Column(Name = "[Año visto bueno]", Storage = "_Año_visto_bueno", DbType = "Int")]
    public int? Año_visto_bueno
    {
      get => this._Año_visto_bueno;
      set
      {
        int? añoVistoBueno = this._Año_visto_bueno;
        int? nullable = value;
        if ((añoVistoBueno.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (añoVistoBueno.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this._Año_visto_bueno = value;
      }
    }

    [Column(Name = "[Año vigencia]", Storage = "_Año_vigencia", DbType = "Int")]
    public int? Año_vigencia
    {
      get => this._Año_vigencia;
      set
      {
        int? añoVigencia = this._Año_vigencia;
        int? nullable = value;
        if ((añoVigencia.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (añoVigencia.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this._Año_vigencia = value;
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

    [Column(Storage = "_Aduana", DbType = "VarChar(255)")]
    public string Aduana
    {
      get => this._Aduana;
      set
      {
        if (!(this._Aduana != value))
          return;
        this._Aduana = value;
      }
    }

    [Column(Name = "[Puerto de embargue]", Storage = "_Puerto_de_embargue", DbType = "VarChar(150)")]
    public string Puerto_de_embargue
    {
      get => this._Puerto_de_embargue;
      set
      {
        if (!(this._Puerto_de_embargue != value))
          return;
        this._Puerto_de_embargue = value;
      }
    }

    [Column(Storage = "_Equipo", DbType = "VarChar(150)")]
    public string Equipo
    {
      get => this._Equipo;
      set
      {
        if (!(this._Equipo != value))
          return;
        this._Equipo = value;
      }
    }

    [Column(Name = "[Cantidad equipo]", Storage = "_Cantidad_equipo", DbType = "Decimal(0,0)")]
    public Decimal? Cantidad_equipo
    {
      get => this._Cantidad_equipo;
      set
      {
        Decimal? cantidadEquipo = this._Cantidad_equipo;
        Decimal? nullable = value;
        if ((cantidadEquipo.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (cantidadEquipo.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this._Cantidad_equipo = value;
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

    [Column(Name = "[Cantidad importada]", Storage = "_Cantidad_importada", DbType = "Decimal(0,0)")]
    public Decimal? Cantidad_importada
    {
      get => this._Cantidad_importada;
      set
      {
        Decimal? cantidadImportada = this._Cantidad_importada;
        Decimal? nullable = value;
        if ((cantidadImportada.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (cantidadImportada.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this._Cantidad_importada = value;
      }
    }

    [Column(Name = "[Precio unitario sustancia]", Storage = "_Precio_unitario_sustancia", DbType = "Money")]
    public Decimal? Precio_unitario_sustancia
    {
      get => this._Precio_unitario_sustancia;
      set
      {
        Decimal? unitarioSustancia = this._Precio_unitario_sustancia;
        Decimal? nullable = value;
        if ((unitarioSustancia.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (unitarioSustancia.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this._Precio_unitario_sustancia = value;
      }
    }
  }
}
