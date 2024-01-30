// Decompiled with JetBrains decompiler
// Type: UTO.ImportacionExportacion.tde_TemporalDeclaracionExportacion
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System.ComponentModel;
using System.Data.Linq.Mapping;

namespace UTO.ImportacionExportacion
{
  [Table(Name = "Iye.tde_TemporalDeclaracionExportacion")]
  public class tde_TemporalDeclaracionExportacion : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _Id;
    private string _NumeroDeclaracion;
    private string _Item;
    private string _FechaDeclaracion;
    private string _Cantidad;
    private string _ValorFOB;
    private string _PesoNeto;
    private string _Nit;
    private string _RazonSocial;
    private string _PaisProcedencia;
    private string _UnidadMedidad;
    private string _Modalidad;
    private string _Sustancia;
    private string _IdSustancia;
    private string _Error;

    [Column(Storage = "_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
    public int Id
    {
      get => this._Id;
      set
      {
        if (this._Id == value)
          return;
        this.SendPropertyChanging();
        this._Id = value;
        this.SendPropertyChanged(nameof (Id));
      }
    }

    [Column(Storage = "_NumeroDeclaracion", DbType = "VarChar(25)")]
    public string NumeroDeclaracion
    {
      get => this._NumeroDeclaracion;
      set
      {
        if (!(this._NumeroDeclaracion != value))
          return;
        this.SendPropertyChanging();
        this._NumeroDeclaracion = value;
        this.SendPropertyChanged(nameof (NumeroDeclaracion));
      }
    }

    [Column(Storage = "_Item", DbType = "VarChar(25)")]
    public string Item
    {
      get => this._Item;
      set
      {
        if (!(this._Item != value))
          return;
        this.SendPropertyChanging();
        this._Item = value;
        this.SendPropertyChanged(nameof (Item));
      }
    }

    [Column(Storage = "_FechaDeclaracion", DbType = "VarChar(25)")]
    public string FechaDeclaracion
    {
      get => this._FechaDeclaracion;
      set
      {
        if (!(this._FechaDeclaracion != value))
          return;
        this.SendPropertyChanging();
        this._FechaDeclaracion = value;
        this.SendPropertyChanged(nameof (FechaDeclaracion));
      }
    }

    [Column(Storage = "_Cantidad", DbType = "VarChar(255)")]
    public string Cantidad
    {
      get => this._Cantidad;
      set
      {
        if (!(this._Cantidad != value))
          return;
        this.SendPropertyChanging();
        this._Cantidad = value;
        this.SendPropertyChanged(nameof (Cantidad));
      }
    }

    [Column(Storage = "_ValorFOB", DbType = "VarChar(255)")]
    public string ValorFOB
    {
      get => this._ValorFOB;
      set
      {
        if (!(this._ValorFOB != value))
          return;
        this.SendPropertyChanging();
        this._ValorFOB = value;
        this.SendPropertyChanged(nameof (ValorFOB));
      }
    }

    [Column(Storage = "_PesoNeto", DbType = "VarChar(255)")]
    public string PesoNeto
    {
      get => this._PesoNeto;
      set
      {
        if (!(this._PesoNeto != value))
          return;
        this.SendPropertyChanging();
        this._PesoNeto = value;
        this.SendPropertyChanged(nameof (PesoNeto));
      }
    }

    [Column(Storage = "_Nit", DbType = "VarChar(25)")]
    public string Nit
    {
      get => this._Nit;
      set
      {
        if (!(this._Nit != value))
          return;
        this.SendPropertyChanging();
        this._Nit = value;
        this.SendPropertyChanged(nameof (Nit));
      }
    }

    [Column(Storage = "_RazonSocial", DbType = "VarChar(150)")]
    public string RazonSocial
    {
      get => this._RazonSocial;
      set
      {
        if (!(this._RazonSocial != value))
          return;
        this.SendPropertyChanging();
        this._RazonSocial = value;
        this.SendPropertyChanged(nameof (RazonSocial));
      }
    }

    [Column(Storage = "_PaisProcedencia", DbType = "VarChar(255)")]
    public string PaisProcedencia
    {
      get => this._PaisProcedencia;
      set
      {
        if (!(this._PaisProcedencia != value))
          return;
        this.SendPropertyChanging();
        this._PaisProcedencia = value;
        this.SendPropertyChanged(nameof (PaisProcedencia));
      }
    }

    [Column(Storage = "_UnidadMedidad", DbType = "VarChar(15)")]
    public string UnidadMedidad
    {
      get => this._UnidadMedidad;
      set
      {
        if (!(this._UnidadMedidad != value))
          return;
        this.SendPropertyChanging();
        this._UnidadMedidad = value;
        this.SendPropertyChanged(nameof (UnidadMedidad));
      }
    }

    [Column(Storage = "_Modalidad", DbType = "VarChar(MAX)")]
    public string Modalidad
    {
      get => this._Modalidad;
      set
      {
        if (!(this._Modalidad != value))
          return;
        this.SendPropertyChanging();
        this._Modalidad = value;
        this.SendPropertyChanged(nameof (Modalidad));
      }
    }

    [Column(Storage = "_Sustancia", DbType = "VarChar(255)")]
    public string Sustancia
    {
      get => this._Sustancia;
      set
      {
        if (!(this._Sustancia != value))
          return;
        this.SendPropertyChanging();
        this._Sustancia = value;
        this.SendPropertyChanged(nameof (Sustancia));
      }
    }

    [Column(Storage = "_IdSustancia", DbType = "VarChar(25)")]
    public string IdSustancia
    {
      get => this._IdSustancia;
      set
      {
        if (!(this._IdSustancia != value))
          return;
        this.SendPropertyChanging();
        this._IdSustancia = value;
        this.SendPropertyChanged(nameof (IdSustancia));
      }
    }

    [Column(Storage = "_Error", DbType = "VarChar(255)")]
    public string Error
    {
      get => this._Error;
      set
      {
        if (!(this._Error != value))
          return;
        this.SendPropertyChanging();
        this._Error = value;
        this.SendPropertyChanged(nameof (Error));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, tde_TemporalDeclaracionExportacion.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
