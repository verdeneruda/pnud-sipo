// Decompiled with JetBrains decompiler
// Type: UTO.Comercializacion.spEncuestaBuscarResult
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.Data.Linq.Mapping;

namespace UTO.Comercializacion
{
  public class spEncuestaBuscarResult
  {
    private DateTime _Fecha;
    private string _Departamento;
    private string _Ciudad;
    private string _Empresa;
    private string _Direccion;
    private string _Contacto;
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

    [Column(Storage = "_Direccion", DbType = "VarChar(50)")]
    public string Direccion
    {
      get => this._Direccion;
      set
      {
        if (!(this._Direccion != value))
          return;
        this._Direccion = value;
      }
    }

    [Column(Storage = "_Contacto", DbType = "VarChar(450) NOT NULL", CanBeNull = false)]
    public string Contacto
    {
      get => this._Contacto;
      set
      {
        if (!(this._Contacto != value))
          return;
        this._Contacto = value;
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
