// Decompiled with JetBrains decompiler
// Type: UTO.ImportacionExportacion.spConsultaVBDeclaracionImportacionResult
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.Data.Linq.Mapping;

namespace UTO.ImportacionExportacion
{
  public class spConsultaVBDeclaracionImportacionResult
  {
    private int _Id;
    private string _Número_registro;
    private string _Sustancia;
    private DateTime _Fecha_declaración;
    private int _Cantidad;
    private Decimal _Valor_FOB;
    private double _Peso_neto;
    private string _Razón_social;
    private string _Tercero;
    private string _Aduana;

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

    [Column(Name = "[Número registro]", Storage = "_Número_registro", DbType = "VarChar(25) NOT NULL", CanBeNull = false)]
    public string Número_registro
    {
      get => this._Número_registro;
      set
      {
        if (!(this._Número_registro != value))
          return;
        this._Número_registro = value;
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

    [Column(Name = "[Fecha declaración]", Storage = "_Fecha_declaración", DbType = "DateTime NOT NULL")]
    public DateTime Fecha_declaración
    {
      get => this._Fecha_declaración;
      set
      {
        if (!(this._Fecha_declaración != value))
          return;
        this._Fecha_declaración = value;
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

    [Column(Name = "[Valor FOB]", Storage = "_Valor_FOB", DbType = "Money NOT NULL")]
    public Decimal Valor_FOB
    {
      get => this._Valor_FOB;
      set
      {
        if (!(this._Valor_FOB != value))
          return;
        this._Valor_FOB = value;
      }
    }

    [Column(Name = "[Peso neto]", Storage = "_Peso_neto", DbType = "Float NOT NULL")]
    public double Peso_neto
    {
      get => this._Peso_neto;
      set
      {
        if (this._Peso_neto == value)
          return;
        this._Peso_neto = value;
      }
    }

    [Column(Name = "[Razón social]", Storage = "_Razón_social", DbType = "VarChar(150) NOT NULL", CanBeNull = false)]
    public string Razón_social
    {
      get => this._Razón_social;
      set
      {
        if (!(this._Razón_social != value))
          return;
        this._Razón_social = value;
      }
    }

    [Column(Storage = "_Tercero", DbType = "VarChar(450)")]
    public string Tercero
    {
      get => this._Tercero;
      set
      {
        if (!(this._Tercero != value))
          return;
        this._Tercero = value;
      }
    }

    [Column(Storage = "_Aduana", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string Aduana
    {
      get => this._Aduana;
      set
      {
        if (!(this._Aduana != value))
          return;
        this._Aduana = value;
      }
    }
  }
}
