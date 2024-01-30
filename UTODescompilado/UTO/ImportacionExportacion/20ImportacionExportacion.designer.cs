// Decompiled with JetBrains decompiler
// Type: UTO.ImportacionExportacion.lma_LicenciaMedioAmbiental
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO.ImportacionExportacion
{
  [Table(Name = "Iye.lma_LicenciaMedioAmbiental")]
  public class lma_LicenciaMedioAmbiental : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _lma_Id;
    private string _lma_Resolucion;
    private int _ter_IdEmpresa;
    private DateTime _lma_FechaLicencia;
    private string _lma_Observacion;
    private string _lma_Usuario;
    private DateTime _lma_Creado;
    private DateTime _lma_Modificado;
    private EntitySet<lmd_LicenciaMedioAmbientalDetalle> _lmd_LicenciaMedioAmbientalDetalles;
    private EntityRef<ter_Tercero> _ter_Tercero;

    public lma_LicenciaMedioAmbiental()
    {
      this._lmd_LicenciaMedioAmbientalDetalles = new EntitySet<lmd_LicenciaMedioAmbientalDetalle>(new Action<lmd_LicenciaMedioAmbientalDetalle>(this.attach_lmd_LicenciaMedioAmbientalDetalles), new Action<lmd_LicenciaMedioAmbientalDetalle>(this.detach_lmd_LicenciaMedioAmbientalDetalles));
      this._ter_Tercero = new EntityRef<ter_Tercero>();
    }

    [Column(Storage = "_lma_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
    public int lma_Id
    {
      get => this._lma_Id;
      set
      {
        if (this._lma_Id == value)
          return;
        this.SendPropertyChanging();
        this._lma_Id = value;
        this.SendPropertyChanged(nameof (lma_Id));
      }
    }

    [Column(Storage = "_lma_Resolucion", DbType = "VarChar(25) NOT NULL", CanBeNull = false)]
    public string lma_Resolucion
    {
      get => this._lma_Resolucion;
      set
      {
        if (!(this._lma_Resolucion != value))
          return;
        this.SendPropertyChanging();
        this._lma_Resolucion = value;
        this.SendPropertyChanged(nameof (lma_Resolucion));
      }
    }

    [Column(Storage = "_ter_IdEmpresa", DbType = "Int NOT NULL")]
    public int ter_IdEmpresa
    {
      get => this._ter_IdEmpresa;
      set
      {
        if (this._ter_IdEmpresa == value)
          return;
        if (this._ter_Tercero.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._ter_IdEmpresa = value;
        this.SendPropertyChanged(nameof (ter_IdEmpresa));
      }
    }

    [Column(Storage = "_lma_FechaLicencia", DbType = "DateTime NOT NULL")]
    public DateTime lma_FechaLicencia
    {
      get => this._lma_FechaLicencia;
      set
      {
        if (!(this._lma_FechaLicencia != value))
          return;
        this.SendPropertyChanging();
        this._lma_FechaLicencia = value;
        this.SendPropertyChanged(nameof (lma_FechaLicencia));
      }
    }

    [Column(Storage = "_lma_Observacion", DbType = "VarChar(MAX)")]
    public string lma_Observacion
    {
      get => this._lma_Observacion;
      set
      {
        if (!(this._lma_Observacion != value))
          return;
        this.SendPropertyChanging();
        this._lma_Observacion = value;
        this.SendPropertyChanged(nameof (lma_Observacion));
      }
    }

    [Column(Storage = "_lma_Usuario", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
    public string lma_Usuario
    {
      get => this._lma_Usuario;
      set
      {
        if (!(this._lma_Usuario != value))
          return;
        this.SendPropertyChanging();
        this._lma_Usuario = value;
        this.SendPropertyChanged(nameof (lma_Usuario));
      }
    }

    [Column(Storage = "_lma_Creado", DbType = "DateTime NOT NULL")]
    public DateTime lma_Creado
    {
      get => this._lma_Creado;
      set
      {
        if (!(this._lma_Creado != value))
          return;
        this.SendPropertyChanging();
        this._lma_Creado = value;
        this.SendPropertyChanged(nameof (lma_Creado));
      }
    }

    [Column(Storage = "_lma_Modificado", DbType = "DateTime NOT NULL")]
    public DateTime lma_Modificado
    {
      get => this._lma_Modificado;
      set
      {
        if (!(this._lma_Modificado != value))
          return;
        this.SendPropertyChanging();
        this._lma_Modificado = value;
        this.SendPropertyChanged(nameof (lma_Modificado));
      }
    }

    [Association(Name = "lma_LicenciaMedioAmbiental_lmd_LicenciaMedioAmbientalDetalle", Storage = "_lmd_LicenciaMedioAmbientalDetalles", ThisKey = "lma_Id", OtherKey = "lma_Id")]
    public EntitySet<lmd_LicenciaMedioAmbientalDetalle> lmd_LicenciaMedioAmbientalDetalles
    {
      get => this._lmd_LicenciaMedioAmbientalDetalles;
      set => this._lmd_LicenciaMedioAmbientalDetalles.Assign((IEnumerable<lmd_LicenciaMedioAmbientalDetalle>) value);
    }

    [Association(Name = "ter_Tercero_lma_LicenciaMedioAmbiental", Storage = "_ter_Tercero", ThisKey = "ter_IdEmpresa", OtherKey = "ter_Id", IsForeignKey = true)]
    public ter_Tercero ter_Tercero
    {
      get => this._ter_Tercero.Entity;
      set
      {
        ter_Tercero entity = this._ter_Tercero.Entity;
        if (entity == value && this._ter_Tercero.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._ter_Tercero.Entity = (ter_Tercero) null;
          entity.lma_LicenciaMedioAmbientals.Remove(this);
        }
        this._ter_Tercero.Entity = value;
        if (value != null)
        {
          value.lma_LicenciaMedioAmbientals.Add(this);
          this._ter_IdEmpresa = value.ter_Id;
        }
        else
          this._ter_IdEmpresa = 0;
        this.SendPropertyChanged(nameof (ter_Tercero));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, lma_LicenciaMedioAmbiental.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void attach_lmd_LicenciaMedioAmbientalDetalles(lmd_LicenciaMedioAmbientalDetalle entity)
    {
      this.SendPropertyChanging();
      entity.lma_LicenciaMedioAmbiental = this;
    }

    private void detach_lmd_LicenciaMedioAmbientalDetalles(lmd_LicenciaMedioAmbientalDetalle entity)
    {
      this.SendPropertyChanging();
      entity.lma_LicenciaMedioAmbiental = (lma_LicenciaMedioAmbiental) null;
    }
  }
}
