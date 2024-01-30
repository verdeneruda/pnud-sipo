// Decompiled with JetBrains decompiler
// Type: UTO.RegistrosUso.spConsultaImportadoresResult
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System.Data.Linq.Mapping;

namespace UTO.RegistrosUso
{
  public class spConsultaImportadoresResult
  {
    private int _Año;
    private string _Importador;
    private string _Cliente;
    private string _Sustancia;
    private string _Presentación;
    private int? _Cantidad;
    private string _Aplicación;

    [Column(Storage = "_Año", DbType = "Int NOT NULL")]
    public int Año
    {
      get => this._Año;
      set
      {
        if (this._Año == value)
          return;
        this._Año = value;
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

    [Column(Storage = "_Cliente", DbType = "VarChar(450)")]
    public string Cliente
    {
      get => this._Cliente;
      set
      {
        if (!(this._Cliente != value))
          return;
        this._Cliente = value;
      }
    }

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

    [Column(Storage = "_Presentación", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string Presentación
    {
      get => this._Presentación;
      set
      {
        if (!(this._Presentación != value))
          return;
        this._Presentación = value;
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

    [Column(Storage = "_Aplicación", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string Aplicación
    {
      get => this._Aplicación;
      set
      {
        if (!(this._Aplicación != value))
          return;
        this._Aplicación = value;
      }
    }
  }
}
