// Decompiled with JetBrains decompiler
// Type: UTO.RegistrosUso.spImportadoresBuscarResult
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System.Data.Linq.Mapping;

namespace UTO.RegistrosUso
{
  public class spImportadoresBuscarResult
  {
    private string _Cliente;
    private string _Sustancia;
    private string _Presentacion;
    private int _Cantidad;
    private string _Aplicacion;
    private int _Id;

    [Column(Storage = "_Cliente", DbType = "VarChar(450)")]
    public string Cliente
    {
      get => this._Cliente;
      set
      {
        if (!(this._Cliente != value))
          return;
        this._Cliente = value;
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

    [Column(Storage = "_Presentacion", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string Presentacion
    {
      get => this._Presentacion;
      set
      {
        if (!(this._Presentacion != value))
          return;
        this._Presentacion = value;
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

    [Column(Storage = "_Aplicacion", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string Aplicacion
    {
      get => this._Aplicacion;
      set
      {
        if (!(this._Aplicacion != value))
          return;
        this._Aplicacion = value;
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
