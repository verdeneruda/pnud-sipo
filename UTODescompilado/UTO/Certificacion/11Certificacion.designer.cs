// Decompiled with JetBrains decompiler
// Type: UTO.Certificacion.spEmpresaBuscarResult
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System.Data.Linq.Mapping;

namespace UTO.Certificacion
{
  public class spEmpresaBuscarResult
  {
    private string _Nit;
    private string _RazonSocial;
    private string _Departamento;
    private string _Ciudad;
    private string _Direccion;
    private string _Telefono;
    private string _Fax;
    private string _Email;
    private int _Id;

    [Column(Storage = "_Nit", DbType = "VarChar(20) NOT NULL", CanBeNull = false)]
    public string Nit
    {
      get => this._Nit;
      set
      {
        if (!(this._Nit != value))
          return;
        this._Nit = value;
      }
    }

    [Column(Storage = "_RazonSocial", DbType = "VarChar(450)")]
    public string RazonSocial
    {
      get => this._RazonSocial;
      set
      {
        if (!(this._RazonSocial != value))
          return;
        this._RazonSocial = value;
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

    [Column(Storage = "_Ciudad", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string Ciudad
    {
      get => this._Ciudad;
      set
      {
        if (!(this._Ciudad != value))
          return;
        this._Ciudad = value;
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

    [Column(Storage = "_Fax", DbType = "VarChar(15)")]
    public string Fax
    {
      get => this._Fax;
      set
      {
        if (!(this._Fax != value))
          return;
        this._Fax = value;
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
