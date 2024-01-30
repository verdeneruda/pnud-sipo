// Decompiled with JetBrains decompiler
// Type: UTO.ImportacionExportacion.dim_DeclaracionImportacion
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO.ImportacionExportacion
{
  [Table(Name = "Iye.dim_DeclaracionImportacion")]
  public class dim_DeclaracionImportacion : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _dim_Id;
    private string _dim_NumeroDeclaracion;
    private int? _sus_Id;
    private int? _dim_NumeroItems;
    private DateTime? _dim_FechaDeclaracion;
    private Decimal? _dim_Cantidad;
    private Decimal? _dim_ValorFOB;
    private Decimal? _dim_PesoNeto;
    private string _dim_Nit;
    private string _dim_RazonSocial;
    private string _dim_UnidadMedida;
    private string _dim_Modalidad;
    private string _dim_Usuario;
    private DateTime? _dim_Creado;
    private DateTime? _dim_Modificado;
    private string _dim_MarcaComercial;
    private string _dim_Pais;
    private EntityRef<sus_Sustancia> _sus_Sustancia;

    public dim_DeclaracionImportacion() => this._sus_Sustancia = new EntityRef<sus_Sustancia>();

    [Column(Storage = "_dim_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
    public int dim_Id
    {
      get => this._dim_Id;
      set
      {
        if (this._dim_Id == value)
          return;
        this.SendPropertyChanging();
        this._dim_Id = value;
        this.SendPropertyChanged(nameof (dim_Id));
      }
    }

    [Column(Storage = "_dim_NumeroDeclaracion", DbType = "VarChar(25)")]
    public string dim_NumeroDeclaracion
    {
      get => this._dim_NumeroDeclaracion;
      set
      {
        if (!(this._dim_NumeroDeclaracion != value))
          return;
        this.SendPropertyChanging();
        this._dim_NumeroDeclaracion = value;
        this.SendPropertyChanged(nameof (dim_NumeroDeclaracion));
      }
    }

    [Column(Storage = "_sus_Id", DbType = "Int")]
    public int? sus_Id
    {
      get => this._sus_Id;
      set
      {
        int? susId = this._sus_Id;
        int? nullable = value;
        if ((susId.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (susId.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        if (this._sus_Sustancia.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._sus_Id = value;
        this.SendPropertyChanged(nameof (sus_Id));
      }
    }

    [Column(Storage = "_dim_NumeroItems", DbType = "Int")]
    public int? dim_NumeroItems
    {
      get => this._dim_NumeroItems;
      set
      {
        int? dimNumeroItems = this._dim_NumeroItems;
        int? nullable = value;
        if ((dimNumeroItems.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (dimNumeroItems.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._dim_NumeroItems = value;
        this.SendPropertyChanged(nameof (dim_NumeroItems));
      }
    }

    [Column(Storage = "_dim_FechaDeclaracion", DbType = "DateTime")]
    public DateTime? dim_FechaDeclaracion
    {
      get => this._dim_FechaDeclaracion;
      set
      {
        DateTime? fechaDeclaracion = this._dim_FechaDeclaracion;
        DateTime? nullable = value;
        if ((fechaDeclaracion.HasValue != nullable.HasValue ? 1 : (!fechaDeclaracion.HasValue ? 0 : (fechaDeclaracion.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._dim_FechaDeclaracion = value;
        this.SendPropertyChanged(nameof (dim_FechaDeclaracion));
      }
    }

    [Column(Storage = "_dim_Cantidad", DbType = "Decimal(10,2)")]
    public Decimal? dim_Cantidad
    {
      get => this._dim_Cantidad;
      set
      {
        Decimal? dimCantidad = this._dim_Cantidad;
        Decimal? nullable = value;
        if ((dimCantidad.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (dimCantidad.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._dim_Cantidad = value;
        this.SendPropertyChanged(nameof (dim_Cantidad));
      }
    }

    [Column(Storage = "_dim_ValorFOB", DbType = "Money")]
    public Decimal? dim_ValorFOB
    {
      get => this._dim_ValorFOB;
      set
      {
        Decimal? dimValorFob = this._dim_ValorFOB;
        Decimal? nullable = value;
        if ((dimValorFob.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (dimValorFob.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._dim_ValorFOB = value;
        this.SendPropertyChanged(nameof (dim_ValorFOB));
      }
    }

    [Column(Storage = "_dim_PesoNeto", DbType = "Decimal(10,3)")]
    public Decimal? dim_PesoNeto
    {
      get => this._dim_PesoNeto;
      set
      {
        Decimal? dimPesoNeto = this._dim_PesoNeto;
        Decimal? nullable = value;
        if ((dimPesoNeto.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (dimPesoNeto.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._dim_PesoNeto = value;
        this.SendPropertyChanged(nameof (dim_PesoNeto));
      }
    }

    [Column(Storage = "_dim_Nit", DbType = "VarChar(25)")]
    public string dim_Nit
    {
      get => this._dim_Nit;
      set
      {
        if (!(this._dim_Nit != value))
          return;
        this.SendPropertyChanging();
        this._dim_Nit = value;
        this.SendPropertyChanged(nameof (dim_Nit));
      }
    }

    [Column(Storage = "_dim_RazonSocial", DbType = "VarChar(150)")]
    public string dim_RazonSocial
    {
      get => this._dim_RazonSocial;
      set
      {
        if (!(this._dim_RazonSocial != value))
          return;
        this.SendPropertyChanging();
        this._dim_RazonSocial = value;
        this.SendPropertyChanged(nameof (dim_RazonSocial));
      }
    }

    [Column(Storage = "_dim_UnidadMedida", DbType = "VarChar(15)")]
    public string dim_UnidadMedida
    {
      get => this._dim_UnidadMedida;
      set
      {
        if (!(this._dim_UnidadMedida != value))
          return;
        this.SendPropertyChanging();
        this._dim_UnidadMedida = value;
        this.SendPropertyChanged(nameof (dim_UnidadMedida));
      }
    }

    [Column(Storage = "_dim_Modalidad", DbType = "VarChar(MAX)")]
    public string dim_Modalidad
    {
      get => this._dim_Modalidad;
      set
      {
        if (!(this._dim_Modalidad != value))
          return;
        this.SendPropertyChanging();
        this._dim_Modalidad = value;
        this.SendPropertyChanged(nameof (dim_Modalidad));
      }
    }

    [Column(Storage = "_dim_Usuario", DbType = "VarChar(50)")]
    public string dim_Usuario
    {
      get => this._dim_Usuario;
      set
      {
        if (!(this._dim_Usuario != value))
          return;
        this.SendPropertyChanging();
        this._dim_Usuario = value;
        this.SendPropertyChanged(nameof (dim_Usuario));
      }
    }

    [Column(Storage = "_dim_Creado", DbType = "DateTime")]
    public DateTime? dim_Creado
    {
      get => this._dim_Creado;
      set
      {
        DateTime? dimCreado = this._dim_Creado;
        DateTime? nullable = value;
        if ((dimCreado.HasValue != nullable.HasValue ? 1 : (!dimCreado.HasValue ? 0 : (dimCreado.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._dim_Creado = value;
        this.SendPropertyChanged(nameof (dim_Creado));
      }
    }

    [Column(Storage = "_dim_Modificado", DbType = "DateTime")]
    public DateTime? dim_Modificado
    {
      get => this._dim_Modificado;
      set
      {
        DateTime? dimModificado = this._dim_Modificado;
        DateTime? nullable = value;
        if ((dimModificado.HasValue != nullable.HasValue ? 1 : (!dimModificado.HasValue ? 0 : (dimModificado.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._dim_Modificado = value;
        this.SendPropertyChanged(nameof (dim_Modificado));
      }
    }

    [Column(Storage = "_dim_MarcaComercial", DbType = "VarChar(150)")]
    public string dim_MarcaComercial
    {
      get => this._dim_MarcaComercial;
      set
      {
        if (!(this._dim_MarcaComercial != value))
          return;
        this.SendPropertyChanging();
        this._dim_MarcaComercial = value;
        this.SendPropertyChanged(nameof (dim_MarcaComercial));
      }
    }

    [Column(Storage = "_dim_Pais", DbType = "VarChar(150)")]
    public string dim_Pais
    {
      get => this._dim_Pais;
      set
      {
        if (!(this._dim_Pais != value))
          return;
        this.SendPropertyChanging();
        this._dim_Pais = value;
        this.SendPropertyChanged(nameof (dim_Pais));
      }
    }

    [Association(Name = "sus_Sustancia_dim_DeclaracionImportacion", Storage = "_sus_Sustancia", ThisKey = "sus_Id", OtherKey = "sus_Id", IsForeignKey = true)]
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
          entity.dim_DeclaracionImportacions.Remove(this);
        }
        this._sus_Sustancia.Entity = value;
        if (value != null)
        {
          value.dim_DeclaracionImportacions.Add(this);
          this._sus_Id = new int?(value.sus_Id);
        }
        else
          this._sus_Id = new int?();
        this.SendPropertyChanged(nameof (sus_Sustancia));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, dim_DeclaracionImportacion.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
