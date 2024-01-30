// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.gti_GasTipo
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
  [Table(Name = "Rrr.gti_GasTipo")]
  public class gti_GasTipo : 
    INotifyPropertyChanging,
    INotifyPropertyChanged,
    IComparable<gti_GasTipo>
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _gti_Id;
    private string _gti_Descripcion;
    private EntitySet<rcd_ReporteConsolidadoDetalle> _rcd_ReporteConsolidadoDetalles;
    private EntitySet<rdt_ReporteUsoDetalle> _rdt_ReporteUsoDetalles;
    private EntitySet<rre_ReporteRegeneracion> _rre_ReporteRegeneracions;
    private EntitySet<rcd_ReporteCentroRegeneracionDetalle> _rcd_ReporteCentroRegeneracionDetalles;
    private EntitySet<rad_ReporteCentroAcopioDetalle> _rad_ReporteCentroAcopioDetalles;

    public gti_GasTipo()
    {
      this._rcd_ReporteConsolidadoDetalles = new EntitySet<rcd_ReporteConsolidadoDetalle>(new Action<rcd_ReporteConsolidadoDetalle>(this.attach_rcd_ReporteConsolidadoDetalles), new Action<rcd_ReporteConsolidadoDetalle>(this.detach_rcd_ReporteConsolidadoDetalles));
      this._rdt_ReporteUsoDetalles = new EntitySet<rdt_ReporteUsoDetalle>(new Action<rdt_ReporteUsoDetalle>(this.attach_rdt_ReporteUsoDetalles), new Action<rdt_ReporteUsoDetalle>(this.detach_rdt_ReporteUsoDetalles));
      this._rre_ReporteRegeneracions = new EntitySet<rre_ReporteRegeneracion>(new Action<rre_ReporteRegeneracion>(this.attach_rre_ReporteRegeneracions), new Action<rre_ReporteRegeneracion>(this.detach_rre_ReporteRegeneracions));
      this._rcd_ReporteCentroRegeneracionDetalles = new EntitySet<rcd_ReporteCentroRegeneracionDetalle>(new Action<rcd_ReporteCentroRegeneracionDetalle>(this.attach_rcd_ReporteCentroRegeneracionDetalles), new Action<rcd_ReporteCentroRegeneracionDetalle>(this.detach_rcd_ReporteCentroRegeneracionDetalles));
      this._rad_ReporteCentroAcopioDetalles = new EntitySet<rad_ReporteCentroAcopioDetalle>(new Action<rad_ReporteCentroAcopioDetalle>(this.attach_rad_ReporteCentroAcopioDetalles), new Action<rad_ReporteCentroAcopioDetalle>(this.detach_rad_ReporteCentroAcopioDetalles));
    }

    [Column(Storage = "_gti_Id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int gti_Id
    {
      get => this._gti_Id;
      set
      {
        if (this._gti_Id == value)
          return;
        this.SendPropertyChanging();
        this._gti_Id = value;
        this.SendPropertyChanged(nameof (gti_Id));
      }
    }

    [Column(Storage = "_gti_Descripcion", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string gti_Descripcion
    {
      get => this._gti_Descripcion;
      set
      {
        if (!(this._gti_Descripcion != value))
          return;
        this.SendPropertyChanging();
        this._gti_Descripcion = value;
        this.SendPropertyChanged(nameof (gti_Descripcion));
      }
    }

    [Association(Name = "gti_GasTipo_rcd_ReporteConsolidadoDetalle", Storage = "_rcd_ReporteConsolidadoDetalles", ThisKey = "gti_Id", OtherKey = "gti_Id")]
    public EntitySet<rcd_ReporteConsolidadoDetalle> rcd_ReporteConsolidadoDetalles
    {
      get => this._rcd_ReporteConsolidadoDetalles;
      set => this._rcd_ReporteConsolidadoDetalles.Assign((IEnumerable<rcd_ReporteConsolidadoDetalle>) value);
    }

    [Association(Name = "gti_GasTipo_rdt_ReporteUsoDetalle", Storage = "_rdt_ReporteUsoDetalles", ThisKey = "gti_Id", OtherKey = "gti_Id")]
    public EntitySet<rdt_ReporteUsoDetalle> rdt_ReporteUsoDetalles
    {
      get => this._rdt_ReporteUsoDetalles;
      set => this._rdt_ReporteUsoDetalles.Assign((IEnumerable<rdt_ReporteUsoDetalle>) value);
    }

    [Association(Name = "gti_GasTipo_rre_ReporteRegeneracion", Storage = "_rre_ReporteRegeneracions", ThisKey = "gti_Id", OtherKey = "gti_Id")]
    public EntitySet<rre_ReporteRegeneracion> rre_ReporteRegeneracions
    {
      get => this._rre_ReporteRegeneracions;
      set => this._rre_ReporteRegeneracions.Assign((IEnumerable<rre_ReporteRegeneracion>) value);
    }

    [Association(Name = "gti_GasTipo_rcd_ReporteCentroRegeneracionDetalle", Storage = "_rcd_ReporteCentroRegeneracionDetalles", ThisKey = "gti_Id", OtherKey = "gti_Id")]
    public EntitySet<rcd_ReporteCentroRegeneracionDetalle> rcd_ReporteCentroRegeneracionDetalles
    {
      get => this._rcd_ReporteCentroRegeneracionDetalles;
      set => this._rcd_ReporteCentroRegeneracionDetalles.Assign((IEnumerable<rcd_ReporteCentroRegeneracionDetalle>) value);
    }

    [Association(Name = "gti_GasTipo_rad_ReporteCentroAcopioDetalle", Storage = "_rad_ReporteCentroAcopioDetalles", ThisKey = "gti_Id", OtherKey = "gti_Id")]
    public EntitySet<rad_ReporteCentroAcopioDetalle> rad_ReporteCentroAcopioDetalles
    {
      get => this._rad_ReporteCentroAcopioDetalles;
      set => this._rad_ReporteCentroAcopioDetalles.Assign((IEnumerable<rad_ReporteCentroAcopioDetalle>) value);
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, gti_GasTipo.emptyChangingEventArgs);
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
      entity.gti_GasTipo = this;
    }

    private void detach_rcd_ReporteConsolidadoDetalles(rcd_ReporteConsolidadoDetalle entity)
    {
      this.SendPropertyChanging();
      entity.gti_GasTipo = (gti_GasTipo) null;
    }

    private void attach_rdt_ReporteUsoDetalles(rdt_ReporteUsoDetalle entity)
    {
      this.SendPropertyChanging();
      entity.gti_GasTipo = this;
    }

    private void detach_rdt_ReporteUsoDetalles(rdt_ReporteUsoDetalle entity)
    {
      this.SendPropertyChanging();
      entity.gti_GasTipo = (gti_GasTipo) null;
    }

    private void attach_rre_ReporteRegeneracions(rre_ReporteRegeneracion entity)
    {
      this.SendPropertyChanging();
      entity.gti_GasTipo = this;
    }

    private void detach_rre_ReporteRegeneracions(rre_ReporteRegeneracion entity)
    {
      this.SendPropertyChanging();
      entity.gti_GasTipo = (gti_GasTipo) null;
    }

    private void attach_rcd_ReporteCentroRegeneracionDetalles(
      rcd_ReporteCentroRegeneracionDetalle entity)
    {
      this.SendPropertyChanging();
      entity.gti_GasTipo = this;
    }

    private void detach_rcd_ReporteCentroRegeneracionDetalles(
      rcd_ReporteCentroRegeneracionDetalle entity)
    {
      this.SendPropertyChanging();
      entity.gti_GasTipo = (gti_GasTipo) null;
    }

    private void attach_rad_ReporteCentroAcopioDetalles(rad_ReporteCentroAcopioDetalle entity)
    {
      this.SendPropertyChanging();
      entity.gti_GasTipo = this;
    }

    private void detach_rad_ReporteCentroAcopioDetalles(rad_ReporteCentroAcopioDetalle entity)
    {
      this.SendPropertyChanging();
      entity.gti_GasTipo = (gti_GasTipo) null;
    }

    public int CompareTo(gti_GasTipo other) => this.gti_Descripcion.CompareTo(other.gti_Descripcion);
  }
}
