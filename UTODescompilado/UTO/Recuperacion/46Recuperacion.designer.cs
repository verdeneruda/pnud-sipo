// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.rcr_ReporteCentroRegeneracion
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
  [Table(Name = "Rrr.rcr_ReporteCentroRegeneracion")]
  public class rcr_ReporteCentroRegeneracion : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _rcr_Id;
    private int _cre_Id;
    private int _rcr_Ano;
    private int _rcr_Periodo;
    private EntitySet<rcd_ReporteCentroRegeneracionDetalle> _rcd_ReporteCentroRegeneracionDetalles;
    private EntityRef<cre_CentroRegeneracion> _cre_CentroRegeneracion;

    public rcr_ReporteCentroRegeneracion()
    {
      this._rcd_ReporteCentroRegeneracionDetalles = new EntitySet<rcd_ReporteCentroRegeneracionDetalle>(new Action<rcd_ReporteCentroRegeneracionDetalle>(this.attach_rcd_ReporteCentroRegeneracionDetalles), new Action<rcd_ReporteCentroRegeneracionDetalle>(this.detach_rcd_ReporteCentroRegeneracionDetalles));
      this._cre_CentroRegeneracion = new EntityRef<cre_CentroRegeneracion>();
    }

    [Column(Storage = "_rcr_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
    public int rcr_Id
    {
      get => this._rcr_Id;
      set
      {
        if (this._rcr_Id == value)
          return;
        this.SendPropertyChanging();
        this._rcr_Id = value;
        this.SendPropertyChanged(nameof (rcr_Id));
      }
    }

    [Column(Storage = "_cre_Id", DbType = "Int NOT NULL")]
    public int cre_Id
    {
      get => this._cre_Id;
      set
      {
        if (this._cre_Id == value)
          return;
        if (this._cre_CentroRegeneracion.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._cre_Id = value;
        this.SendPropertyChanged(nameof (cre_Id));
      }
    }

    [Column(Storage = "_rcr_Ano", DbType = "Int NOT NULL")]
    public int rcr_Ano
    {
      get => this._rcr_Ano;
      set
      {
        if (this._rcr_Ano == value)
          return;
        this.SendPropertyChanging();
        this._rcr_Ano = value;
        this.SendPropertyChanged(nameof (rcr_Ano));
      }
    }

    [Column(Storage = "_rcr_Periodo", DbType = "Int NOT NULL")]
    public int rcr_Periodo
    {
      get => this._rcr_Periodo;
      set
      {
        if (this._rcr_Periodo == value)
          return;
        this.SendPropertyChanging();
        this._rcr_Periodo = value;
        this.SendPropertyChanged(nameof (rcr_Periodo));
      }
    }

    [Association(Name = "rcr_ReporteCentroRegeneracion_rcd_ReporteCentroRegeneracionDetalle", Storage = "_rcd_ReporteCentroRegeneracionDetalles", ThisKey = "rcr_Id", OtherKey = "rcr_Id")]
    public EntitySet<rcd_ReporteCentroRegeneracionDetalle> rcd_ReporteCentroRegeneracionDetalles
    {
      get => this._rcd_ReporteCentroRegeneracionDetalles;
      set => this._rcd_ReporteCentroRegeneracionDetalles.Assign((IEnumerable<rcd_ReporteCentroRegeneracionDetalle>) value);
    }

    [Association(Name = "cre_CentroRegeneracion_rcr_ReporteCentroRegeneracion", Storage = "_cre_CentroRegeneracion", ThisKey = "cre_Id", OtherKey = "cre_Id", IsForeignKey = true)]
    public cre_CentroRegeneracion cre_CentroRegeneracion
    {
      get => this._cre_CentroRegeneracion.Entity;
      set
      {
        cre_CentroRegeneracion entity = this._cre_CentroRegeneracion.Entity;
        if (entity == value && this._cre_CentroRegeneracion.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._cre_CentroRegeneracion.Entity = (cre_CentroRegeneracion) null;
          entity.rcr_ReporteCentroRegeneracions.Remove(this);
        }
        this._cre_CentroRegeneracion.Entity = value;
        if (value != null)
        {
          value.rcr_ReporteCentroRegeneracions.Add(this);
          this._cre_Id = value.cre_Id;
        }
        else
          this._cre_Id = 0;
        this.SendPropertyChanged(nameof (cre_CentroRegeneracion));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, rcr_ReporteCentroRegeneracion.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void attach_rcd_ReporteCentroRegeneracionDetalles(
      rcd_ReporteCentroRegeneracionDetalle entity)
    {
      this.SendPropertyChanging();
      entity.rcr_ReporteCentroRegeneracion = this;
    }

    private void detach_rcd_ReporteCentroRegeneracionDetalles(
      rcd_ReporteCentroRegeneracionDetalle entity)
    {
      this.SendPropertyChanging();
      entity.rcr_ReporteCentroRegeneracion = (rcr_ReporteCentroRegeneracion) null;
    }
  }
}
