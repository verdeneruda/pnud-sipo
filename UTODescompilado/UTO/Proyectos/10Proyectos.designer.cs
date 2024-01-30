// Decompiled with JetBrains decompiler
// Type: UTO.Proyectos.spProyectoBuscarResult
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.Data.Linq.Mapping;

namespace UTO.Proyectos
{
  public class spProyectoBuscarResult
  {
    private int _Id;
    private string _Nombre;
    private string _Código;
    private string _Agencia;
    private string _Compañía;
    private string _Departamento;
    private string _Municipio;
    private DateTime? _Fecha_aprobación;
    private DateTime? _Fecha_terminación;
    private DateTime? _Fecha_terminación_real;

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

    [Column(Storage = "_Nombre", DbType = "VarChar(150) NOT NULL", CanBeNull = false)]
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

    [Column(Storage = "_Código", DbType = "VarChar(20) NOT NULL", CanBeNull = false)]
    public string Código
    {
      get => this._Código;
      set
      {
        if (!(this._Código != value))
          return;
        this._Código = value;
      }
    }

    [Column(Storage = "_Agencia", DbType = "VarChar(150) NOT NULL", CanBeNull = false)]
    public string Agencia
    {
      get => this._Agencia;
      set
      {
        if (!(this._Agencia != value))
          return;
        this._Agencia = value;
      }
    }

    [Column(Storage = "_Compañía", DbType = "VarChar(150)")]
    public string Compañía
    {
      get => this._Compañía;
      set
      {
        if (!(this._Compañía != value))
          return;
        this._Compañía = value;
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

    [Column(Storage = "_Municipio", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string Municipio
    {
      get => this._Municipio;
      set
      {
        if (!(this._Municipio != value))
          return;
        this._Municipio = value;
      }
    }

    [Column(Name = "[Fecha aprobación]", Storage = "_Fecha_aprobación", DbType = "DateTime")]
    public DateTime? Fecha_aprobación
    {
      get => this._Fecha_aprobación;
      set
      {
        DateTime? fechaAprobación = this._Fecha_aprobación;
        DateTime? nullable = value;
        if ((fechaAprobación.HasValue != nullable.HasValue ? 1 : (!fechaAprobación.HasValue ? 0 : (fechaAprobación.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this._Fecha_aprobación = value;
      }
    }

    [Column(Name = "[Fecha terminación]", Storage = "_Fecha_terminación", DbType = "DateTime")]
    public DateTime? Fecha_terminación
    {
      get => this._Fecha_terminación;
      set
      {
        DateTime? fechaTerminación = this._Fecha_terminación;
        DateTime? nullable = value;
        if ((fechaTerminación.HasValue != nullable.HasValue ? 1 : (!fechaTerminación.HasValue ? 0 : (fechaTerminación.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this._Fecha_terminación = value;
      }
    }

    [Column(Name = "[Fecha terminación real]", Storage = "_Fecha_terminación_real", DbType = "DateTime")]
    public DateTime? Fecha_terminación_real
    {
      get => this._Fecha_terminación_real;
      set
      {
        DateTime? fechaTerminaciónReal = this._Fecha_terminación_real;
        DateTime? nullable = value;
        if ((fechaTerminaciónReal.HasValue != nullable.HasValue ? 1 : (!fechaTerminaciónReal.HasValue ? 0 : (fechaTerminaciónReal.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this._Fecha_terminación_real = value;
      }
    }
  }
}
