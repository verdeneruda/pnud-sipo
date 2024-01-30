// Decompiled with JetBrains decompiler
// Type: UTO.Comercializacion.spEncuestaEmpresaBuscarResult
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System.Data.Linq.Mapping;

namespace UTO.Comercializacion
{
  public class spEncuestaEmpresaBuscarResult
  {
    private string _Regional;
    private string _Empresa;
    private string _TipoDocumento;
    private string _Documento;
    private string _Direccion;
    private string _Telefono;
    private int _Id;

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
