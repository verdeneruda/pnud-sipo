// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.spBeneficiarioBuscarResult
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System.Data.Linq.Mapping;

namespace UTO.Recuperacion
{
  public class spBeneficiarioBuscarResult
  {
    private int _ter_id;
    private string _TipoDocumento;
    private string _ter_NumeroDocumento;
    private string _ter_NombreCompleto;
    private string _reg_descripcion;
    private string _dep_descripcion;
    private string _mun_descripcion;
    private string _ter_Tefono;
    private string _ter_Direccion;
    private string _ter_Correo;
    private string _ter_Celular;
    private string _tpj_EstablecimientoComercio;
    private string _tpj_RepresentanteLegal;
    private string _tpj_NumeroDocumento;

    [Column(Storage = "_ter_id", DbType = "Int NOT NULL")]
    public int ter_id
    {
      get => this._ter_id;
      set
      {
        if (this._ter_id == value)
          return;
        this._ter_id = value;
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

    [Column(Storage = "_ter_NumeroDocumento", DbType = "VarChar(20) NOT NULL", CanBeNull = false)]
    public string ter_NumeroDocumento
    {
      get => this._ter_NumeroDocumento;
      set
      {
        if (!(this._ter_NumeroDocumento != value))
          return;
        this._ter_NumeroDocumento = value;
      }
    }

    [Column(Storage = "_ter_NombreCompleto", DbType = "VarChar(450)")]
    public string ter_NombreCompleto
    {
      get => this._ter_NombreCompleto;
      set
      {
        if (!(this._ter_NombreCompleto != value))
          return;
        this._ter_NombreCompleto = value;
      }
    }

    [Column(Storage = "_reg_descripcion", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string reg_descripcion
    {
      get => this._reg_descripcion;
      set
      {
        if (!(this._reg_descripcion != value))
          return;
        this._reg_descripcion = value;
      }
    }

    [Column(Storage = "_dep_descripcion", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string dep_descripcion
    {
      get => this._dep_descripcion;
      set
      {
        if (!(this._dep_descripcion != value))
          return;
        this._dep_descripcion = value;
      }
    }

    [Column(Storage = "_mun_descripcion", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string mun_descripcion
    {
      get => this._mun_descripcion;
      set
      {
        if (!(this._mun_descripcion != value))
          return;
        this._mun_descripcion = value;
      }
    }

    [Column(Storage = "_ter_Tefono", DbType = "VarChar(15)")]
    public string ter_Tefono
    {
      get => this._ter_Tefono;
      set
      {
        if (!(this._ter_Tefono != value))
          return;
        this._ter_Tefono = value;
      }
    }

    [Column(Storage = "_ter_Direccion", DbType = "VarChar(50)")]
    public string ter_Direccion
    {
      get => this._ter_Direccion;
      set
      {
        if (!(this._ter_Direccion != value))
          return;
        this._ter_Direccion = value;
      }
    }

    [Column(Storage = "_ter_Correo", DbType = "VarChar(50)")]
    public string ter_Correo
    {
      get => this._ter_Correo;
      set
      {
        if (!(this._ter_Correo != value))
          return;
        this._ter_Correo = value;
      }
    }

    [Column(Storage = "_ter_Celular", DbType = "VarChar(15)")]
    public string ter_Celular
    {
      get => this._ter_Celular;
      set
      {
        if (!(this._ter_Celular != value))
          return;
        this._ter_Celular = value;
      }
    }

    [Column(Storage = "_tpj_EstablecimientoComercio", DbType = "VarChar(255)")]
    public string tpj_EstablecimientoComercio
    {
      get => this._tpj_EstablecimientoComercio;
      set
      {
        if (!(this._tpj_EstablecimientoComercio != value))
          return;
        this._tpj_EstablecimientoComercio = value;
      }
    }

    [Column(Storage = "_tpj_RepresentanteLegal", DbType = "VarChar(255)")]
    public string tpj_RepresentanteLegal
    {
      get => this._tpj_RepresentanteLegal;
      set
      {
        if (!(this._tpj_RepresentanteLegal != value))
          return;
        this._tpj_RepresentanteLegal = value;
      }
    }

    [Column(Storage = "_tpj_NumeroDocumento", DbType = "VarChar(20)")]
    public string tpj_NumeroDocumento
    {
      get => this._tpj_NumeroDocumento;
      set
      {
        if (!(this._tpj_NumeroDocumento != value))
          return;
        this._tpj_NumeroDocumento = value;
      }
    }
  }
}
