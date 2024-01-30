// Decompiled with JetBrains decompiler
// Type: UTO.ImportacionExportacion.dex_DeclaracionExportacion
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO.ImportacionExportacion
{
  [Table(Name = "Iye.dex_DeclaracionExportacion")]
  public class dex_DeclaracionExportacion : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _dex_Id;
    private string _dex_NumeroDeclaracion;
    private int _sus_Id;
    private int _dex_NumeroItems;
    private DateTime _dex_FechaDeclaracion;
    private int _dex_Cantidad;
    private Decimal _dex_ValorFOB;
    private double _dex_PesoNeto;
    private string _dex_Nit;
    private string _dex_RazonSocial;
    private string _dex_UnidadMedida;
    private string _dex_Modalidad;
    private string _dex_Usuario;
    private DateTime _dex_Creado;
    private DateTime _dex_Modificado;
    private string _dex_Pais;
    private EntityRef<sus_Sustancia> _sus_Sustancia;

    public dex_DeclaracionExportacion() => this._sus_Sustancia = new EntityRef<sus_Sustancia>();

    [Column(Storage = "_dex_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
    public int dex_Id
    {
      get => this._dex_Id;
      set
      {
        if (this._dex_Id == value)
          return;
        this.SendPropertyChanging();
        this._dex_Id = value;
        this.SendPropertyChanged(nameof (dex_Id));
      }
    }

    [Column(Storage = "_dex_NumeroDeclaracion", DbType = "VarChar(25) NOT NULL", CanBeNull = false)]
    public string dex_NumeroDeclaracion
    {
      get => this._dex_NumeroDeclaracion;
      set
      {
        if (!(this._dex_NumeroDeclaracion != value))
          return;
        this.SendPropertyChanging();
        this._dex_NumeroDeclaracion = value;
        this.SendPropertyChanged(nameof (dex_NumeroDeclaracion));
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
        if (this._sus_Sustancia.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._sus_Id = value;
        this.SendPropertyChanged(nameof (sus_Id));
      }
    }

    [Column(Storage = "_dex_NumeroItems", DbType = "Int NOT NULL")]
    public int dex_NumeroItems
    {
      get => this._dex_NumeroItems;
      set
      {
        if (this._dex_NumeroItems == value)
          return;
        this.SendPropertyChanging();
        this._dex_NumeroItems = value;
        this.SendPropertyChanged(nameof (dex_NumeroItems));
      }
    }

    [Column(Storage = "_dex_FechaDeclaracion", DbType = "DateTime NOT NULL")]
    public DateTime dex_FechaDeclaracion
    {
      get => this._dex_FechaDeclaracion;
      set
      {
        if (!(this._dex_FechaDeclaracion != value))
          return;
        this.SendPropertyChanging();
        this._dex_FechaDeclaracion = value;
        this.SendPropertyChanged(nameof (dex_FechaDeclaracion));
      }
    }

    [Column(Storage = "_dex_Cantidad", DbType = "Int NOT NULL")]
    public int dex_Cantidad
    {
      get => this._dex_Cantidad;
      set
      {
        if (this._dex_Cantidad == value)
          return;
        this.SendPropertyChanging();
        this._dex_Cantidad = value;
        this.SendPropertyChanged(nameof (dex_Cantidad));
      }
    }

    [Column(Storage = "_dex_ValorFOB", DbType = "Money NOT NULL")]
    public Decimal dex_ValorFOB
    {
      get => this._dex_ValorFOB;
      set
      {
        if (!(this._dex_ValorFOB != value))
          return;
        this.SendPropertyChanging();
        this._dex_ValorFOB = value;
        this.SendPropertyChanged(nameof (dex_ValorFOB));
      }
    }

    [Column(Storage = "_dex_PesoNeto", DbType = "Float NOT NULL")]
    public double dex_PesoNeto
    {
      get => this._dex_PesoNeto;
      set
      {
        if (this._dex_PesoNeto == value)
          return;
        this.SendPropertyChanging();
        this._dex_PesoNeto = value;
        this.SendPropertyChanged(nameof (dex_PesoNeto));
      }
    }

    [Column(Storage = "_dex_Nit", DbType = "VarChar(25) NOT NULL", CanBeNull = false)]
    public string dex_Nit
    {
      get => this._dex_Nit;
      set
      {
        if (!(this._dex_Nit != value))
          return;
        this.SendPropertyChanging();
        this._dex_Nit = value;
        this.SendPropertyChanged(nameof (dex_Nit));
      }
    }

    [Column(Storage = "_dex_RazonSocial", DbType = "VarChar(150) NOT NULL", CanBeNull = false)]
    public string dex_RazonSocial
    {
      get => this._dex_RazonSocial;
      set
      {
        if (!(this._dex_RazonSocial != value))
          return;
        this.SendPropertyChanging();
        this._dex_RazonSocial = value;
        this.SendPropertyChanged(nameof (dex_RazonSocial));
      }
    }

    [Column(Storage = "_dex_UnidadMedida", DbType = "VarChar(15) NOT NULL", CanBeNull = false)]
    public string dex_UnidadMedida
    {
      get => this._dex_UnidadMedida;
      set
      {
        if (!(this._dex_UnidadMedida != value))
          return;
        this.SendPropertyChanging();
        this._dex_UnidadMedida = value;
        this.SendPropertyChanged(nameof (dex_UnidadMedida));
      }
    }

    [Column(Storage = "_dex_Modalidad", DbType = "VarChar(MAX) NOT NULL", CanBeNull = false)]
    public string dex_Modalidad
    {
      get => this._dex_Modalidad;
      set
      {
        if (!(this._dex_Modalidad != value))
          return;
        this.SendPropertyChanging();
        this._dex_Modalidad = value;
        this.SendPropertyChanged(nameof (dex_Modalidad));
      }
    }

    [Column(Storage = "_dex_Usuario", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
    public string dex_Usuario
    {
      get => this._dex_Usuario;
      set
      {
        if (!(this._dex_Usuario != value))
          return;
        this.SendPropertyChanging();
        this._dex_Usuario = value;
        this.SendPropertyChanged(nameof (dex_Usuario));
      }
    }

    [Column(Storage = "_dex_Creado", DbType = "DateTime NOT NULL")]
    public DateTime dex_Creado
    {
      get => this._dex_Creado;
      set
      {
        if (!(this._dex_Creado != value))
          return;
        this.SendPropertyChanging();
        this._dex_Creado = value;
        this.SendPropertyChanged(nameof (dex_Creado));
      }
    }

    [Column(Storage = "_dex_Modificado", DbType = "DateTime NOT NULL")]
    public DateTime dex_Modificado
    {
      get => this._dex_Modificado;
      set
      {
        if (!(this._dex_Modificado != value))
          return;
        this.SendPropertyChanging();
        this._dex_Modificado = value;
        this.SendPropertyChanged(nameof (dex_Modificado));
      }
    }

    [Column(Storage = "_dex_Pais", DbType = "VarChar(150)")]
    public string dex_Pais
    {
      get => this._dex_Pais;
      set
      {
        if (!(this._dex_Pais != value))
          return;
        this.SendPropertyChanging();
        this._dex_Pais = value;
        this.SendPropertyChanged(nameof (dex_Pais));
      }
    }

    [Association(Name = "sus_Sustancia_dex_DeclaracionExportacion", Storage = "_sus_Sustancia", ThisKey = "sus_Id", OtherKey = "sus_Id", IsForeignKey = true)]
    public sus_Sustancia sus_Sustancia
    {
      get => this._sus_Sustancia.Entity;
      set
      {
        sus_Sustancia entity = this._sus_Sustancia.Entity;
        if (entity == value && this._sus_Sustancia.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._sus_Sustancia.Entity = (sus_Sustancia) null;
          entity.dex_DeclaracionExportacions.Remove(this);
        }
        this._sus_Sustancia.Entity = value;
        if (value != null)
        {
          value.dex_DeclaracionExportacions.Add(this);
          this._sus_Id = value.sus_Id;
        }
        else
          this._sus_Id = 0;
        this.SendPropertyChanged(nameof (sus_Sustancia));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, dex_DeclaracionExportacion.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
