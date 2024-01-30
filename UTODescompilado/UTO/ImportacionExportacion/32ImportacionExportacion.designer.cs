// Decompiled with JetBrains decompiler
// Type: UTO.ImportacionExportacion.spRegistroImportacionBuscarResult
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.Data.Linq.Mapping;

namespace UTO.ImportacionExportacion
{
  public class spRegistroImportacionBuscarResult
  {
    private int _Id;
    private string _Número_registro;
    private string _Visto_bueno;
    private DateTime? _Fecha_vigencia;
    private string _Importador;
    private string _Exportador;
    private string _Puerto_de_embargue;
    private string _Aduana;

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

    [Column(Name = "[Número registro]", Storage = "_Número_registro", DbType = "VarChar(25)")]
    public string Número_registro
    {
      get => this._Número_registro;
      set
      {
        if (!(this._Número_registro != value))
          return;
        this._Número_registro = value;
      }
    }

    [Column(Name = "[Visto bueno]", Storage = "_Visto_bueno", DbType = "VarChar(150)")]
    public string Visto_bueno
    {
      get => this._Visto_bueno;
      set
      {
        if (!(this._Visto_bueno != value))
          return;
        this._Visto_bueno = value;
      }
    }

    [Column(Name = "[Fecha vigencia]", Storage = "_Fecha_vigencia", DbType = "DateTime")]
    public DateTime? Fecha_vigencia
    {
      get => this._Fecha_vigencia;
      set
      {
        DateTime? fechaVigencia = this._Fecha_vigencia;
        DateTime? nullable = value;
        if ((fechaVigencia.HasValue != nullable.HasValue ? 1 : (!fechaVigencia.HasValue ? 0 : (fechaVigencia.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this._Fecha_vigencia = value;
      }
    }

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

    [Column(Storage = "_Aduana", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
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
  }
}
