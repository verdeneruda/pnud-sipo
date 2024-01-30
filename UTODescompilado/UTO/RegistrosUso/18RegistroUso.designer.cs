// Decompiled with JetBrains decompiler
// Type: UTO.RegistrosUso.spConsultaUsuarioFinalResult
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System.Data.Linq.Mapping;

namespace UTO.RegistrosUso
{
  public class spConsultaUsuarioFinalResult
  {
    private string _TipoUsuario;
    private string _Sector;
    private string _Empresa;
    private int? _Cantidad;
    private string _Sustancia;
    private string _CategoriaEquipo;
    private string _TipoEquipo;

    [Column(Storage = "_TipoUsuario", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string TipoUsuario
    {
      get => this._TipoUsuario;
      set
      {
        if (!(this._TipoUsuario != value))
          return;
        this._TipoUsuario = value;
      }
    }

    [Column(Storage = "_Sector", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string Sector
    {
      get => this._Sector;
      set
      {
        if (!(this._Sector != value))
          return;
        this._Sector = value;
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

    [Column(Storage = "_CategoriaEquipo", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string CategoriaEquipo
    {
      get => this._CategoriaEquipo;
      set
      {
        if (!(this._CategoriaEquipo != value))
          return;
        this._CategoriaEquipo = value;
      }
    }

    [Column(Storage = "_TipoEquipo", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string TipoEquipo
    {
      get => this._TipoEquipo;
      set
      {
        if (!(this._TipoEquipo != value))
          return;
        this._TipoEquipo = value;
      }
    }
  }
}
