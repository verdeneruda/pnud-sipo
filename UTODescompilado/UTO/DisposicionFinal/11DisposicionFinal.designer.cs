// Decompiled with JetBrains decompiler
// Type: UTO.DisposicionFinal.spSustanciaBuscarResult
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.Data.Linq.Mapping;

namespace UTO.DisposicionFinal
{
  public class spSustanciaBuscarResult
  {
    private DateTime _Fecha;
    private string _Empresa;
    private string _DireccionAlmacenamiento;
    private string _Telefono;
    private string _Departamento;
    private string _Ciudad;
    private int _Id;

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

    [Column(Storage = "_DireccionAlmacenamiento", DbType = "VarChar(MAX)")]
    public string DireccionAlmacenamiento
    {
      get => this._DireccionAlmacenamiento;
      set
      {
        if (!(this._DireccionAlmacenamiento != value))
          return;
        this._DireccionAlmacenamiento = value;
      }
    }

    [Column(Storage = "_Telefono", DbType = "VarChar(20) NOT NULL", CanBeNull = false)]
    public string Telefono
    {
      get => this._Telefono;
      set
      {
        if (!(this._Telefono != value))
          return;
        this._Telefono = value;
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
