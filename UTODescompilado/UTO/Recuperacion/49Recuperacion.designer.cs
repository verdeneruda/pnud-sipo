// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.rca_ReporteCentroAcopio
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO.Recuperacion
{
  [Table(Name = "Rrr.rca_ReporteCentroAcopio")]
  public class rca_ReporteCentroAcopio : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _rca_Id;
    private int _cea_Id;
    private int _rca_Ano;
    private int _rca_Periodo;
    private EntitySet<rad_ReporteCentroAcopioDetalle> _rad_ReporteCentroAcopioDetalles;
    private EntityRef<cea_CentroAcopio> _cea_CentroAcopio;

    public rca_ReporteCentroAcopio()
    {
      this._rad_ReporteCentroAcopioDetalles = new EntitySet<rad_ReporteCentroAcopioDetalle>(new Action<rad_ReporteCentroAcopioDetalle>(this.attach_rad_ReporteCentroAcopioDetalles), new Action<rad_ReporteCentroAcopioDetalle>(this.detach_rad_ReporteCentroAcopioDetalles));
      this._cea_CentroAcopio = new EntityRef<cea_CentroAcopio>();
    }

    [Column(Storage = "_rca_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
    public int rca_Id
    {
      get => this._rca_Id;
      set
      {
        if (this._rca_Id == value)
          return;
        this.SendPropertyChanging();
        this._rca_Id = value;
        this.SendPropertyChanged(nameof (rca_Id));
      }
    }

    [Column(Storage = "_cea_Id", DbType = "Int NOT NULL")]
    public int cea_Id
    {
      get => this._cea_Id;
      set
      {
        if (this._cea_Id == value)
          return;
        if (this._cea_CentroAcopio.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._cea_Id = value;
        this.SendPropertyChanged(nameof (cea_Id));
      }
    }

    [Column(Storage = "_rca_Ano", DbType = "Int NOT NULL")]
    public int rca_Ano
    {
      get => this._rca_Ano;
      set
      {
        if (this._rca_Ano == value)
          return;
        this.SendPropertyChanging();
        this._rca_Ano = value;
        this.SendPropertyChanged(nameof (rca_Ano));
      }
    }

    [Column(Storage = "_rca_Periodo", DbType = "Int NOT NULL")]
    public int rca_Periodo
    {
      get => this._rca_Periodo;
      set
      {
        if (this._rca_Periodo == value)
          return;
        this.SendPropertyChanging();
        this._rca_Periodo = value;
        this.SendPropertyChanged(nameof (rca_Periodo));
      }
    }

    [Association(Name = "rca_ReporteCentroAcopio_rad_ReporteCentroAcopioDetalle", Storage = "_rad_ReporteCentroAcopioDetalles", ThisKey = "rca_Id", OtherKey = "rca_Id")]
    public EntitySet<rad_ReporteCentroAcopioDetalle> rad_ReporteCentroAcopioDetalles
    {
      get => this._rad_ReporteCentroAcopioDetalles;
      set => this._rad_ReporteCentroAcopioDetalles.Assign((IEnumerable<rad_ReporteCentroAcopioDetalle>) value);
    }

    [Association(Name = "cea_CentroAcopio_rca_ReporteCentroAcopio", Storage = "_cea_CentroAcopio", ThisKey = "cea_Id", OtherKey = "cea_Id", IsForeignKey = true)]
    public cea_CentroAcopio cea_CentroAcopio
    {
      get => this._cea_CentroAcopio.Entity;
      set
      {
        cea_CentroAcopio entity = this._cea_CentroAcopio.Entity;
        if (entity == value && this._cea_CentroAcopio.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._cea_CentroAcopio.Entity = (cea_CentroAcopio) null;
          entity.rca_ReporteCentroAcopios.Remove(this);
        }
        this._cea_CentroAcopio.Entity = value;
        if (value != null)
        {
          value.rca_ReporteCentroAcopios.Add(this);
          this._cea_Id = value.cea_Id;
        }
        else
          this._cea_Id = 0;
        this.SendPropertyChanged(nameof (cea_CentroAcopio));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, rca_ReporteCentroAcopio.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void attach_rad_ReporteCentroAcopioDetalles(rad_ReporteCentroAcopioDetalle entity)
    {
      this.SendPropertyChanging();
      entity.rca_ReporteCentroAcopio = this;
    }

    private void detach_rad_ReporteCentroAcopioDetalles(rad_ReporteCentroAcopioDetalle entity)
    {
      this.SendPropertyChanging();
      entity.rca_ReporteCentroAcopio = (rca_ReporteCentroAcopio) null;
    }
  }
}
