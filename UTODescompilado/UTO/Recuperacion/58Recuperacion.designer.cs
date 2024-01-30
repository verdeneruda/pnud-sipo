// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.spSolicitudEquipoBuscarResult
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.Data.Linq.Mapping;

namespace UTO.Recuperacion
{
  public class spSolicitudEquipoBuscarResult
  {
    private int _Id;
    private DateTime _Fecha_solicitud;
    private string _Regional;
    private string _Beneficiario;
    private string _Departamento;
    private string _Municipio;
    private string _Estado;

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

    [Column(Storage = "_Regional", DbType = "VarChar(255)")]
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
  }
}
