// Decompiled with JetBrains decompiler
// Type: UTO.Certificacion.spTecnicosBuscarActividadResult
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System.Data.Linq.Mapping;

namespace UTO.Certificacion
{
  public class spTecnicosBuscarActividadResult
  {
    private string _TipoDocumento;
    private string _NumeroDocumento;
    private string _Nombre;
    private int _Id;
    private string _Email;

    [Column(Storage = "_TipoDocumento", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
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

    [Column(Storage = "_NumeroDocumento", DbType = "VarChar(20) NOT NULL", CanBeNull = false)]
    public string NumeroDocumento
    {
      get => this._NumeroDocumento;
      set
      {
        if (!(this._NumeroDocumento != value))
          return;
        this._NumeroDocumento = value;
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
  }
}
