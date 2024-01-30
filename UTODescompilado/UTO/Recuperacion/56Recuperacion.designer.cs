// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.spConsultaPolizaResult
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.Data.Linq.Mapping;

namespace UTO.Recuperacion
{
  public class spConsultaPolizaResult
  {
    private int _Id;
    private DateTime _Fecha_solicitud;
    private string _Regional;
    private string _Beneficiario;
    private string _Departamento;
    private string _Municipio;
    private DateTime? _Fecha_aprobación_poliza;
    private DateTime? _Fecha_plazo_poliza;
    private DateTime? _Fecha_vigencia_poliza;

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

    [Column(Name = "[Fecha solicitud]", Storage = "_Fecha_solicitud", DbType = "DateTime NOT NULL")]
    public DateTime Fecha_solicitud
    {
      get => this._Fecha_solicitud;
      set
      {
        if (!(this._Fecha_solicitud != value))
          return;
        this._Fecha_solicitud = value;
      }
    }

    [Column(Storage = "_Regional", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string Regional
    {
      get => this._Regional;
      set
      {
        if (!(this._Regional != value))
          return;
        this._Regional = value;
      }
    }

    [Column(Storage = "_Beneficiario", DbType = "VarChar(450)")]
    public string Beneficiario
    {
      get => this._Beneficiario;
      set
      {
        if (!(this._Beneficiario != value))
          return;
        this._Beneficiario = value;
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

    [Column(Name = "[Fecha aprobación poliza]", Storage = "_Fecha_aprobación_poliza", DbType = "DateTime")]
    public DateTime? Fecha_aprobación_poliza
    {
      get => this._Fecha_aprobación_poliza;
      set
      {
        DateTime? aprobaciónPoliza = this._Fecha_aprobación_poliza;
        DateTime? nullable = value;
        if ((aprobaciónPoliza.HasValue != nullable.HasValue ? 1 : (!aprobaciónPoliza.HasValue ? 0 : (aprobaciónPoliza.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this._Fecha_aprobación_poliza = value;
      }
    }

    [Column(Name = "[Fecha plazo poliza]", Storage = "_Fecha_plazo_poliza", DbType = "DateTime")]
    public DateTime? Fecha_plazo_poliza
    {
      get => this._Fecha_plazo_poliza;
      set
      {
        DateTime? fechaPlazoPoliza = this._Fecha_plazo_poliza;
        DateTime? nullable = value;
        if ((fechaPlazoPoliza.HasValue != nullable.HasValue ? 1 : (!fechaPlazoPoliza.HasValue ? 0 : (fechaPlazoPoliza.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this._Fecha_plazo_poliza = value;
      }
    }

    [Column(Name = "[Fecha vigencia poliza]", Storage = "_Fecha_vigencia_poliza", DbType = "DateTime")]
    public DateTime? Fecha_vigencia_poliza
    {
      get => this._Fecha_vigencia_poliza;
      set
      {
        DateTime? fechaVigenciaPoliza = this._Fecha_vigencia_poliza;
        DateTime? nullable = value;
        if ((fechaVigenciaPoliza.HasValue != nullable.HasValue ? 1 : (!fechaVigenciaPoliza.HasValue ? 0 : (fechaVigenciaPoliza.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this._Fecha_vigencia_poliza = value;
      }
    }
  }
}
