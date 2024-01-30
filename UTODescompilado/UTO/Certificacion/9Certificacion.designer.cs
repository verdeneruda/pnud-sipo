// Decompiled with JetBrains decompiler
// Type: UTO.Certificacion.spTecnicosBuscarResult
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.Data.Linq.Mapping;

namespace UTO.Certificacion
{
  public class spTecnicosBuscarResult
  {
    private string _CTG;
    private string _TipoDocumento;
    private string _Documento;
    private string _Nombre;
    private string _Departamento;
    private string _Ciudad;
    private string _Direccion;
    private string _Telefono;
    private string _Celular;
    private string _Email;
    private string _Empresa;
    private string _AreaTrabajo;
    private DateTime _Fecha;
    private DateTime _Vigencia;
    private int _Id;

    [Column(Storage = "_CTG", DbType = "VarChar(75) NOT NULL", CanBeNull = false)]
    public string CTG
    {
      get => this._CTG;
      set
      {
        if (!(this._CTG != value))
          return;
        this._CTG = value;
      }
    }

    [Column(Storage = "_TipoDocumento", DbType = "VarChar(255)")]
    public string TipoDocumento
    {
      get => this._TipoDocumento;
      set
      {
        if (!(this._TipoDocumento != value))
          return;
        this._TipoDocumento = value;
      }
    }

    [Column(Storage = "_Documento", DbType = "VarChar(20) NOT NULL", CanBeNull = false)]
    public string Documento
    {
      get => this._Documento;
      set
      {
        if (!(this._Documento != value))
          return;
        this._Documento = value;
      }
    }

    [Column(Storage = "_Nombre", DbType = "VarChar(450)")]
    public string Nombre
    {
      get => this._Nombre;
      set
      {
        if (!(this._Nombre != value))
          return;
        this._Nombre = value;
      }
    }

    [Column(Storage = "_Departamento", DbType = "VarChar(255)")]
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

    [Column(Storage = "_Ciudad", DbType = "VarChar(255)")]
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

    [Column(Storage = "_Telefono", DbType = "VarChar(15)")]
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

    [Column(Storage = "_Celular", DbType = "VarChar(15)")]
    public string Celular
    {
      get => this._Celular;
      set
      {
        if (!(this._Celular != value))
          return;
        this._Celular = value;
      }
    }

    [Column(Storage = "_Email", DbType = "VarChar(50)")]
    public string Email
    {
      get => this._Email;
      set
      {
        if (!(this._Email != value))
          return;
        this._Email = value;
      }
    }

    [Column(Storage = "_Empresa", DbType = "VarChar(450) NOT NULL", CanBeNull = false)]
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

    [Column(Storage = "_AreaTrabajo", DbType = "VarChar(70) NOT NULL", CanBeNull = false)]
    public string AreaTrabajo
    {
      get => this._AreaTrabajo;
      set
      {
        if (!(this._AreaTrabajo != value))
          return;
        this._AreaTrabajo = value;
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

    [Column(Storage = "_Vigencia", DbType = "DateTime NOT NULL")]
    public DateTime Vigencia
    {
      get => this._Vigencia;
      set
      {
        if (!(this._Vigencia != value))
          return;
        this._Vigencia = value;
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
