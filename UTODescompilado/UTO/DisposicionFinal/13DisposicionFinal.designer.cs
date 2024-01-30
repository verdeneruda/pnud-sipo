// Decompiled with JetBrains decompiler
// Type: UTO.DisposicionFinal.spConsultaNacionalPublicoResult
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System.Data.Linq.Mapping;

namespace UTO.DisposicionFinal
{
  public class spConsultaNacionalPublicoResult
  {
    private string _Sustancia;
    private int? _Cantidad;
    private string _Estado;
    private string _Departamento;
    private string _Ciudad;

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

    [Column(Storage = "_Estado", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string Estado
    {
      get => this._Estado;
      set
      {
        if (!(this._Estado != value))
          return;
        this._Estado = value;
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
  }
}
