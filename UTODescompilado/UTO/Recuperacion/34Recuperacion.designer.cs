// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.rrc_ReporteRegeneracionConsolidado
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
  [Table(Name = "Rrr.rrc_ReporteRegeneracionConsolidado")]
  public class rrc_ReporteRegeneracionConsolidado : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _rrc_Id;
    private int _cre_Id;
    private DateTime _rrc_Fecha;
    private int _rrc_Mes;
    private EntitySet<rcd_ReporteConsolidadoDetalle> _rcd_ReporteConsolidadoDetalles;
    private EntitySet<rco_ReporteConsolidadoDocumento> _rco_ReporteConsolidadoDocumentos;
    private EntityRef<cre_CentroRegeneracion> _cre_CentroRegeneracion;

    public rrc_ReporteRegeneracionConsolidado()
    {
      this._rcd_ReporteConsolidadoDetalles = new EntitySet<rcd_ReporteConsolidadoDetalle>(new Action<rcd_ReporteConsolidadoDetalle>(this.attach_rcd_ReporteConsolidadoDetalles), new Action<rcd_ReporteConsolidadoDetalle>(this.detach_rcd_ReporteConsolidadoDetalles));
      this._rco_ReporteConsolidadoDocumentos = new EntitySet<rco_ReporteConsolidadoDocumento>(new Action<rco_ReporteConsolidadoDocumento>(this.attach_rco_ReporteConsolidadoDocumentos), new Action<rco_ReporteConsolidadoDocumento>(this.detach_rco_ReporteConsolidadoDocumentos));
      this._cre_CentroRegeneracion = new EntityRef<cre_CentroRegeneracion>();
    }

    [Column(Storage = "_rrc_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
    public int rrc_Id
    {
      get => this._rrc_Id;
      set
      {
        if (this._rrc_Id == value)
          return;
        this.SendPropertyChanging();
        this._rrc_Id = value;
        this.SendPropertyChanged(nameof (rrc_Id));
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

    [Column(Storage = "_rrc_Fecha", DbType = "DateTime NOT NULL")]
    public DateTime rrc_Fecha
    {
      get => this._rrc_Fecha;
      set
      {
        if (!(this._rrc_Fecha != value))
          return;
        this.SendPropertyChanging();
        this._rrc_Fecha = value;
        this.SendPropertyChanged(nameof (rrc_Fecha));
      }
    }

    [Column(Storage = "_rrc_Mes", DbType = "Int NOT NULL")]
    public int rrc_Mes
    {
      get => this._rrc_Mes;
      set
      {
        if (this._rrc_Mes == value)
          return;
        this.SendPropertyChanging();
        this._rrc_Mes = value;
        this.SendPropertyChanged(nameof (rrc_Mes));
      }
    }

    [Association(Name = "rrc_ReporteRegeneracionConsolidado_rcd_ReporteConsolidadoDetalle", Storage = "_rcd_ReporteConsolidadoDetalles", ThisKey = "rrc_Id", OtherKey = "rrc_Id")]
    public EntitySet<rcd_ReporteConsolidadoDetalle> rcd_ReporteConsolidadoDetalles
    {
      get => this._rcd_ReporteConsolidadoDetalles;
      set => this._rcd_ReporteConsolidadoDetalles.Assign((IEnumerable<rcd_ReporteConsolidadoDetalle>) value);
    }

    [Association(Name = "rrc_ReporteRegeneracionConsolidado_rco_ReporteConsolidadoDocumento", Storage = "_rco_ReporteConsolidadoDocumentos", ThisKey = "rrc_Id", OtherKey = "rrc_Id")]
    public EntitySet<rco_ReporteConsolidadoDocumento> rco_ReporteConsolidadoDocumentos
    {
      get => this._rco_ReporteConsolidadoDocumentos;
      set => this._rco_ReporteConsolidadoDocumentos.Assign((IEnumerable<rco_ReporteConsolidadoDocumento>) value);
    }

    [Association(Name = "cre_CentroRegeneracion_rrc_ReporteRegeneracionConsolidado", Storage = "_cre_CentroRegeneracion", ThisKey = "cre_Id", OtherKey = "cre_Id", IsForeignKey = true)]
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
          entity.rrc_ReporteRegeneracionConsolidados.Remove(this);
        }
        this._cre_CentroRegeneracion.Entity = value;
        if (value != null)
        {
          value.rrc_ReporteRegeneracionConsolidados.Add(this);
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
      this.PropertyChanging((object) this, rrc_ReporteRegeneracionConsolidado.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void attach_rcd_ReporteConsolidadoDetalles(rcd_ReporteConsolidadoDetalle entity)
    {
      this.SendPropertyChanging();
      entity.rrc_ReporteRegeneracionConsolidado = this;
    }

    private void detach_rcd_ReporteConsolidadoDetalles(rcd_ReporteConsolidadoDetalle entity)
    {
      this.SendPropertyChanging();
      entity.rrc_ReporteRegeneracionConsolidado = (rrc_ReporteRegeneracionConsolidado) null;
    }

    private void attach_rco_ReporteConsolidadoDocumentos(rco_ReporteConsolidadoDocumento entity)
    {
      this.SendPropertyChanging();
      entity.rrc_ReporteRegeneracionConsolidado = this;
    }

    private void detach_rco_ReporteConsolidadoDocumentos(rco_ReporteConsolidadoDocumento entity)
    {
      this.SendPropertyChanging();
      entity.rrc_ReporteRegeneracionConsolidado = (rrc_ReporteRegeneracionConsolidado) null;
    }
  }
}
