// Decompiled with JetBrains decompiler
// Type: UTO.RegistrosUso.spUsuariosBuscarResult
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.Data.Linq.Mapping;

namespace UTO.RegistrosUso
{
  public class spUsuariosBuscarResult
  {
    private string _Empresa;
    private string _TipoUsuario;
    private string _Sector;
    private DateTime _Fecha;
    private string _Departamento;
    private string _Ciudad;
    private string _Sustancia;
    private int _Cantidad;
    private int _Id;

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

    [Column(Storage = "_Cantidad", DbType = "Int NOT NULL")]
    public int Cantidad
    {
      get => this._Cantidad;
      set
      {
        if (this._Cantidad == value)
          return;
        this._Cantidad = value;
      }
    }

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
  }
}
