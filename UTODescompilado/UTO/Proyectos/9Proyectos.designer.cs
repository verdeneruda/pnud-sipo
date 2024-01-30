// Decompiled with JetBrains decompiler
// Type: UTO.Proyectos.spProyectoConsultaResult
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.Data.Linq.Mapping;

namespace UTO.Proyectos
{
  public class spProyectoConsultaResult
  {
    private int _Id;
    private string _Sector;
    private string _Tipo;
    private string _Agencia;
    private string _Compañía;
    private string _Nombre_del_proyecto;
    private string _Código;
    private Decimal? _Aprobados_FMPM__US__;
    private Decimal? _Desembolsados_FMPM__US__;
    private Decimal? _US__invertidos;
    private string _Departamento;
    private string _Municipio;
    private Decimal? _ODP_a_eliminar;
    private Decimal? _ODP_eliminadas;
    private DateTime? _Fecha_aprobación;
    private DateTime? _Fecha_terminación;
    private DateTime? _Fecha_terminación_real;
    private string _Estado_actual;
    private string _Observaciones_del_proyecto;

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

    [Column(Storage = "_Tipo", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string Tipo
    {
      get => this._Tipo;
      set
      {
        if (!(this._Tipo != value))
          return;
        this._Tipo = value;
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

    [Column(Name = "[Nombre del proyecto]", Storage = "_Nombre_del_proyecto", DbType = "VarChar(150) NOT NULL", CanBeNull = false)]
    public string Nombre_del_proyecto
    {
      get => this._Nombre_del_proyecto;
      set
      {
        if (!(this._Nombre_del_proyecto != value))
          return;
        this._Nombre_del_proyecto = value;
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

    [Column(Name = "[Aprobados FMPM (US$)]", Storage = "_Aprobados_FMPM__US__", DbType = "Money")]
    public Decimal? Aprobados_FMPM__US__
    {
      get => this._Aprobados_FMPM__US__;
      set
      {
        Decimal? aprobadosFmpmUs = this._Aprobados_FMPM__US__;
        Decimal? nullable = value;
        if ((aprobadosFmpmUs.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (aprobadosFmpmUs.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this._Aprobados_FMPM__US__ = value;
      }
    }

    [Column(Name = "[Desembolsados FMPM (US$)]", Storage = "_Desembolsados_FMPM__US__", DbType = "Money")]
    public Decimal? Desembolsados_FMPM__US__
    {
      get => this._Desembolsados_FMPM__US__;
      set
      {
        Decimal? desembolsadosFmpmUs = this._Desembolsados_FMPM__US__;
        Decimal? nullable = value;
        if ((desembolsadosFmpmUs.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (desembolsadosFmpmUs.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this._Desembolsados_FMPM__US__ = value;
      }
    }

    [Column(Name = "[US$ invertidos]", Storage = "_US__invertidos", DbType = "Money")]
    public Decimal? US__invertidos
    {
      get => this._US__invertidos;
      set
      {
        Decimal? usInvertidos = this._US__invertidos;
        Decimal? nullable = value;
        if ((usInvertidos.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (usInvertidos.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this._US__invertidos = value;
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

    [Column(Name = "[ODP a eliminar]", Storage = "_ODP_a_eliminar", DbType = "Decimal(0,0)")]
    public Decimal? ODP_a_eliminar
    {
      get => this._ODP_a_eliminar;
      set
      {
        Decimal? odpAEliminar = this._ODP_a_eliminar;
        Decimal? nullable = value;
        if ((odpAEliminar.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (odpAEliminar.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this._ODP_a_eliminar = value;
      }
    }

    [Column(Name = "[ODP eliminadas]", Storage = "_ODP_eliminadas", DbType = "Decimal(0,0)")]
    public Decimal? ODP_eliminadas
    {
      get => this._ODP_eliminadas;
      set
      {
        Decimal? odpEliminadas = this._ODP_eliminadas;
        Decimal? nullable = value;
        if ((odpEliminadas.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (odpEliminadas.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this._ODP_eliminadas = value;
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

    [Column(Name = "[Estado actual]", Storage = "_Estado_actual", DbType = "VarChar(10)")]
    public string Estado_actual
    {
      get => this._Estado_actual;
      set
      {
        if (!(this._Estado_actual != value))
          return;
        this._Estado_actual = value;
      }
    }

    [Column(Name = "[Observaciones del proyecto]", Storage = "_Observaciones_del_proyecto", DbType = "VarChar(MAX)")]
    public string Observaciones_del_proyecto
    {
      get => this._Observaciones_del_proyecto;
      set
      {
        if (!(this._Observaciones_del_proyecto != value))
          return;
        this._Observaciones_del_proyecto = value;
      }
    }
  }
}
