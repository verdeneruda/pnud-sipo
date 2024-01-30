// Decompiled with JetBrains decompiler
// Type: UTO.Certificacion.spActividadesBuscarResult
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.Data.Linq.Mapping;

namespace UTO.Certificacion
{
  public class spActividadesBuscarResult
  {
    private DateTime _Fecha;
    private string _Actividad;
    private int _Personas_Impactadas;
    private string _Material_Entregado;
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

    [Column(Storage = "_Actividad", DbType = "VarChar(MAX) NOT NULL", CanBeNull = false)]
    public string Actividad
    {
      get => this._Actividad;
      set
      {
        if (!(this._Actividad != value))
          return;
        this._Actividad = value;
      }
    }

    [Column(Storage = "_Personas_Impactadas", DbType = "Int NOT NULL")]
    public int Personas_Impactadas
    {
      get => this._Personas_Impactadas;
      set
      {
        if (this._Personas_Impactadas == value)
          return;
        this._Personas_Impactadas = value;
      }
    }

    [Column(Storage = "_Material_Entregado", DbType = "VarChar(MAX) NOT NULL", CanBeNull = false)]
    public string Material_Entregado
    {
      get => this._Material_Entregado;
      set
      {
        if (!(this._Material_Entregado != value))
          return;
        this._Material_Entregado = value;
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
