// Decompiled with JetBrains decompiler
// Type: UTO.ImportacionExportacion.spCertificacionBuscarResult
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.Data.Linq.Mapping;

namespace UTO.ImportacionExportacion
{
  public class spCertificacionBuscarResult
  {
    private string _Número_radicado;
    private DateTime _Fecha_radicado;
    private DateTime _Fecha_certificado;
    private string _Importador;
    private string _Radicado_por;
    private string _Empresa;
    private int _Id;

    [Column(Name = "[Número radicado]", Storage = "_Número_radicado", DbType = "VarChar(25) NOT NULL", CanBeNull = false)]
    public string Número_radicado
    {
      get => this._Número_radicado;
      set
      {
        if (!(this._Número_radicado != value))
          return;
        this._Número_radicado = value;
      }
    }

    [Column(Name = "[Fecha radicado]", Storage = "_Fecha_radicado", DbType = "DateTime NOT NULL")]
    public DateTime Fecha_radicado
    {
      get => this._Fecha_radicado;
      set
      {
        if (!(this._Fecha_radicado != value))
          return;
        this._Fecha_radicado = value;
      }
    }

    [Column(Name = "[Fecha certificado]", Storage = "_Fecha_certificado", DbType = "DateTime NOT NULL")]
    public DateTime Fecha_certificado
    {
      get => this._Fecha_certificado;
      set
      {
        if (!(this._Fecha_certificado != value))
          return;
        this._Fecha_certificado = value;
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

    [Column(Name = "[Radicado por]", Storage = "_Radicado_por", DbType = "VarChar(450)")]
    public string Radicado_por
    {
      get => this._Radicado_por;
      set
      {
        if (!(this._Radicado_por != value))
          return;
        this._Radicado_por = value;
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
