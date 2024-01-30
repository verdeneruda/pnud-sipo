// Decompiled with JetBrains decompiler
// Type: UTO.Comercializacion.spConsultaSustanciaResult
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.Data.Linq.Mapping;

namespace UTO.Comercializacion
{
  public class spConsultaSustanciaResult
  {
    private string _Sustancia;
    private string _presentacion;
    private string _marca;
    private string _Departamento;
    private string _Ciudad;
    private int _cda_Id;
    private DateTime _cda_Fecha;
    private string _dep_Id;
    private string _mun_Id;
    private int _ter_Id;
    private string _cda_Contacto;
    private string _cda_Usuario;
    private DateTime _cda_Creado;
    private DateTime _cda_Modificado;
    private int _cdd_Id;
    private int _cda_Id1;
    private int _ter_IdProveedor;
    private int _sus_Id;
    private int _ter_IdFabricante;
    private int _psu_Id;
    private int _mar_Id;
    private Decimal _cdd_Precio;
    private string _cdd_Observaciones;
    private string _cdd_Usuario;
    private DateTime _cdd_Creado;
    private DateTime _cdd_Modificado;
    private int _sus_Id1;
    private string _sus_Arancel;
    private string _sus_Descripcion;
    private int _psu_Id1;
    private string _psu_Descripcion;
    private string _psu_Arancel;
    private int _mar_Id1;
    private string _mar_Descripcion;
    private string _dep_Id1;
    private string _dep_Descripcion;
    private string _mun_Id1;
    private string _dep_Id2;
    private string _mun_Descripcion;

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

    [Column(Storage = "_presentacion", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string presentacion
    {
      get => this._presentacion;
      set
      {
        if (!(this._presentacion != value))
          return;
        this._presentacion = value;
      }
    }

    [Column(Storage = "_marca", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string marca
    {
      get => this._marca;
      set
      {
        if (!(this._marca != value))
          return;
        this._marca = value;
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

    [Column(Storage = "_cda_Id", DbType = "Int NOT NULL")]
    public int cda_Id
    {
      get => this._cda_Id;
      set
      {
        if (this._cda_Id == value)
          return;
        this._cda_Id = value;
      }
    }

    [Column(Storage = "_cda_Fecha", DbType = "DateTime NOT NULL")]
    public DateTime cda_Fecha
    {
      get => this._cda_Fecha;
      set
      {
        if (!(this._cda_Fecha != value))
          return;
        this._cda_Fecha = value;
      }
    }

    [Column(Storage = "_dep_Id", DbType = "VarChar(2) NOT NULL", CanBeNull = false)]
    public string dep_Id
    {
      get => this._dep_Id;
      set
      {
        if (!(this._dep_Id != value))
          return;
        this._dep_Id = value;
      }
    }

    [Column(Storage = "_mun_Id", DbType = "VarChar(5) NOT NULL", CanBeNull = false)]
    public string mun_Id
    {
      get => this._mun_Id;
      set
      {
        if (!(this._mun_Id != value))
          return;
        this._mun_Id = value;
      }
    }

    [Column(Storage = "_ter_Id", DbType = "Int NOT NULL")]
    public int ter_Id
    {
      get => this._ter_Id;
      set
      {
        if (this._ter_Id == value)
          return;
        this._ter_Id = value;
      }
    }

    [Column(Storage = "_cda_Contacto", DbType = "VarChar(450) NOT NULL", CanBeNull = false)]
    public string cda_Contacto
    {
      get => this._cda_Contacto;
      set
      {
        if (!(this._cda_Contacto != value))
          return;
        this._cda_Contacto = value;
      }
    }

    [Column(Storage = "_cda_Usuario", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
    public string cda_Usuario
    {
      get => this._cda_Usuario;
      set
      {
        if (!(this._cda_Usuario != value))
          return;
        this._cda_Usuario = value;
      }
    }

    [Column(Storage = "_cda_Creado", DbType = "DateTime NOT NULL")]
    public DateTime cda_Creado
    {
      get => this._cda_Creado;
      set
      {
        if (!(this._cda_Creado != value))
          return;
        this._cda_Creado = value;
      }
    }

    [Column(Storage = "_cda_Modificado", DbType = "DateTime NOT NULL")]
    public DateTime cda_Modificado
    {
      get => this._cda_Modificado;
      set
      {
        if (!(this._cda_Modificado != value))
          return;
        this._cda_Modificado = value;
      }
    }

    [Column(Storage = "_cdd_Id", DbType = "Int NOT NULL")]
    public int cdd_Id
    {
      get => this._cdd_Id;
      set
      {
        if (this._cdd_Id == value)
          return;
        this._cdd_Id = value;
      }
    }

    [Column(Storage = "_cda_Id1", DbType = "Int NOT NULL")]
    public int cda_Id1
    {
      get => this._cda_Id1;
      set
      {
        if (this._cda_Id1 == value)
          return;
        this._cda_Id1 = value;
      }
    }

    [Column(Storage = "_ter_IdProveedor", DbType = "Int NOT NULL")]
    public int ter_IdProveedor
    {
      get => this._ter_IdProveedor;
      set
      {
        if (this._ter_IdProveedor == value)
          return;
        this._ter_IdProveedor = value;
      }
    }

    [Column(Storage = "_sus_Id", DbType = "Int NOT NULL")]
    public int sus_Id
    {
      get => this._sus_Id;
      set
      {
        if (this._sus_Id == value)
          return;
        this._sus_Id = value;
      }
    }

    [Column(Storage = "_ter_IdFabricante", DbType = "Int NOT NULL")]
    public int ter_IdFabricante
    {
      get => this._ter_IdFabricante;
      set
      {
        if (this._ter_IdFabricante == value)
          return;
        this._ter_IdFabricante = value;
      }
    }

    [Column(Storage = "_psu_Id", DbType = "Int NOT NULL")]
    public int psu_Id
    {
      get => this._psu_Id;
      set
      {
        if (this._psu_Id == value)
          return;
        this._psu_Id = value;
      }
    }

    [Column(Storage = "_mar_Id", DbType = "Int NOT NULL")]
    public int mar_Id
    {
      get => this._mar_Id;
      set
      {
        if (this._mar_Id == value)
          return;
        this._mar_Id = value;
      }
    }

    [Column(Storage = "_cdd_Precio", DbType = "Money NOT NULL")]
    public Decimal cdd_Precio
    {
      get => this._cdd_Precio;
      set
      {
        if (!(this._cdd_Precio != value))
          return;
        this._cdd_Precio = value;
      }
    }

    [Column(Storage = "_cdd_Observaciones", DbType = "VarChar(MAX)")]
    public string cdd_Observaciones
    {
      get => this._cdd_Observaciones;
      set
      {
        if (!(this._cdd_Observaciones != value))
          return;
        this._cdd_Observaciones = value;
      }
    }

    [Column(Storage = "_cdd_Usuario", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
    public string cdd_Usuario
    {
      get => this._cdd_Usuario;
      set
      {
        if (!(this._cdd_Usuario != value))
          return;
        this._cdd_Usuario = value;
      }
    }

    [Column(Storage = "_cdd_Creado", DbType = "DateTime NOT NULL")]
    public DateTime cdd_Creado
    {
      get => this._cdd_Creado;
      set
      {
        if (!(this._cdd_Creado != value))
          return;
        this._cdd_Creado = value;
      }
    }

    [Column(Storage = "_cdd_Modificado", DbType = "DateTime NOT NULL")]
    public DateTime cdd_Modificado
    {
      get => this._cdd_Modificado;
      set
      {
        if (!(this._cdd_Modificado != value))
          return;
        this._cdd_Modificado = value;
      }
    }

    [Column(Storage = "_sus_Id1", DbType = "Int NOT NULL")]
    public int sus_Id1
    {
      get => this._sus_Id1;
      set
      {
        if (this._sus_Id1 == value)
          return;
        this._sus_Id1 = value;
      }
    }

    [Column(Storage = "_sus_Arancel", DbType = "VarChar(50)")]
    public string sus_Arancel
    {
      get => this._sus_Arancel;
      set
      {
        if (!(this._sus_Arancel != value))
          return;
        this._sus_Arancel = value;
      }
    }

    [Column(Storage = "_sus_Descripcion", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string sus_Descripcion
    {
      get => this._sus_Descripcion;
      set
      {
        if (!(this._sus_Descripcion != value))
          return;
        this._sus_Descripcion = value;
      }
    }

    [Column(Storage = "_psu_Id1", DbType = "Int NOT NULL")]
    public int psu_Id1
    {
      get => this._psu_Id1;
      set
      {
        if (this._psu_Id1 == value)
          return;
        this._psu_Id1 = value;
      }
    }

    [Column(Storage = "_psu_Descripcion", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string psu_Descripcion
    {
      get => this._psu_Descripcion;
      set
      {
        if (!(this._psu_Descripcion != value))
          return;
        this._psu_Descripcion = value;
      }
    }

    [Column(Storage = "_psu_Arancel", DbType = "VarChar(50)")]
    public string psu_Arancel
    {
      get => this._psu_Arancel;
      set
      {
        if (!(this._psu_Arancel != value))
          return;
        this._psu_Arancel = value;
      }
    }

    [Column(Storage = "_mar_Id1", DbType = "Int NOT NULL")]
    public int mar_Id1
    {
      get => this._mar_Id1;
      set
      {
        if (this._mar_Id1 == value)
          return;
        this._mar_Id1 = value;
      }
    }

    [Column(Storage = "_mar_Descripcion", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string mar_Descripcion
    {
      get => this._mar_Descripcion;
      set
      {
        if (!(this._mar_Descripcion != value))
          return;
        this._mar_Descripcion = value;
      }
    }

    [Column(Storage = "_dep_Id1", DbType = "VarChar(2) NOT NULL", CanBeNull = false)]
    public string dep_Id1
    {
      get => this._dep_Id1;
      set
      {
        if (!(this._dep_Id1 != value))
          return;
        this._dep_Id1 = value;
      }
    }

    [Column(Storage = "_dep_Descripcion", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string dep_Descripcion
    {
      get => this._dep_Descripcion;
      set
      {
        if (!(this._dep_Descripcion != value))
          return;
        this._dep_Descripcion = value;
      }
    }

    [Column(Storage = "_mun_Id1", DbType = "VarChar(5) NOT NULL", CanBeNull = false)]
    public string mun_Id1
    {
      get => this._mun_Id1;
      set
      {
        if (!(this._mun_Id1 != value))
          return;
        this._mun_Id1 = value;
      }
    }

    [Column(Storage = "_dep_Id2", DbType = "VarChar(2) NOT NULL", CanBeNull = false)]
    public string dep_Id2
    {
      get => this._dep_Id2;
      set
      {
        if (!(this._dep_Id2 != value))
          return;
        this._dep_Id2 = value;
      }
    }

    [Column(Storage = "_mun_Descripcion", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string mun_Descripcion
    {
      get => this._mun_Descripcion;
      set
      {
        if (!(this._mun_Descripcion != value))
          return;
        this._mun_Descripcion = value;
      }
    }
  }
}
