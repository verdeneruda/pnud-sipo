// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.gde_GasDestino
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
  [Table(Name = "Rrr.gde_GasDestino")]
  public class gde_GasDestino : 
    INotifyPropertyChanging,
    INotifyPropertyChanged,
    IComparable<gde_GasDestino>
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _gde_Id;
    private string _gde_Descripcion;
    private EntitySet<rre_ReporteRegeneracion> _rre_ReporteRegeneracions;
    private EntitySet<rcd_ReporteCentroRegeneracionDetalle> _rcd_ReporteCentroRegeneracionDetalles;
    private EntitySet<rad_ReporteCentroAcopioDetalle> _rad_ReporteCentroAcopioDetalles;

    public gde_GasDestino()
    {
      this._rre_ReporteRegeneracions = new EntitySet<rre_ReporteRegeneracion>(new Action<rre_ReporteRegeneracion>(this.attach_rre_ReporteRegeneracions), new Action<rre_ReporteRegeneracion>(this.detach_rre_ReporteRegeneracions));
      this._rcd_ReporteCentroRegeneracionDetalles = new EntitySet<rcd_ReporteCentroRegeneracionDetalle>(new Action<rcd_ReporteCentroRegeneracionDetalle>(this.attach_rcd_ReporteCentroRegeneracionDetalles), new Action<rcd_ReporteCentroRegeneracionDetalle>(this.detach_rcd_ReporteCentroRegeneracionDetalles));
      this._rad_ReporteCentroAcopioDetalles = new EntitySet<rad_ReporteCentroAcopioDetalle>(new Action<rad_ReporteCentroAcopioDetalle>(this.attach_rad_ReporteCentroAcopioDetalles), new Action<rad_ReporteCentroAcopioDetalle>(this.detach_rad_ReporteCentroAcopioDetalles));
    }

    [Column(Storage = "_gde_Id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int gde_Id
    {
      get => this._gde_Id;
      set
      {
        if (this._gde_Id == value)
          return;
        this.SendPropertyChanging();
        this._gde_Id = value;
        this.SendPropertyChanged(nameof (gde_Id));
      }
    }

    [Column(Storage = "_gde_Descripcion", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string gde_Descripcion
    {
      get => this._gde_Descripcion;
      set
      {
        if (!(this._gde_Descripcion != value))
          return;
        this.SendPropertyChanging();
        this._gde_Descripcion = value;
        this.SendPropertyChanged(nameof (gde_Descripcion));
      }
    }

    [Association(Name = "gde_GasDestino_rre_ReporteRegeneracion", Storage = "_rre_ReporteRegeneracions", ThisKey = "gde_Id", OtherKey = "gde_Id")]
    public EntitySet<rre_ReporteRegeneracion> rre_ReporteRegeneracions
    {
      get => this._rre_ReporteRegeneracions;
      set => this._rre_ReporteRegeneracions.Assign((IEnumerable<rre_ReporteRegeneracion>) value);
    }

    [Association(Name = "gde_GasDestino_rcd_ReporteCentroRegeneracionDetalle", Storage = "_rcd_ReporteCentroRegeneracionDetalles", ThisKey = "gde_Id", OtherKey = "gde_Id")]
    public EntitySet<rcd_ReporteCentroRegeneracionDetalle> rcd_ReporteCentroRegeneracionDetalles
    {
      get => this._rcd_ReporteCentroRegeneracionDetalles;
      set => this._rcd_ReporteCentroRegeneracionDetalles.Assign((IEnumerable<rcd_ReporteCentroRegeneracionDetalle>) value);
    }

    [Association(Name = "gde_GasDestino_rad_ReporteCentroAcopioDetalle", Storage = "_rad_ReporteCentroAcopioDetalles", ThisKey = "gde_Id", OtherKey = "gde_Id")]
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
      this.PropertyChanging((object) this, gde_GasDestino.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void attach_rre_ReporteRegeneracions(rre_ReporteRegeneracion entity)
    {
      this.SendPropertyChanging();
      entity.gde_GasDestino = this;
    }

    private void detach_rre_ReporteRegeneracions(rre_ReporteRegeneracion entity)
    {
      this.SendPropertyChanging();
      entity.gde_GasDestino = (gde_GasDestino) null;
    }

    private void attach_rcd_ReporteCentroRegeneracionDetalles(
      rcd_ReporteCentroRegeneracionDetalle entity)
    {
      this.SendPropertyChanging();
      entity.gde_GasDestino = this;
    }

    private void detach_rcd_ReporteCentroRegeneracionDetalles(
      rcd_ReporteCentroRegeneracionDetalle entity)
    {
      this.SendPropertyChanging();
      entity.gde_GasDestino = (gde_GasDestino) null;
    }

    private void attach_rad_ReporteCentroAcopioDetalles(rad_ReporteCentroAcopioDetalle entity)
    {
      this.SendPropertyChanging();
      entity.gde_GasDestino = this;
    }

    private void detach_rad_ReporteCentroAcopioDetalles(rad_ReporteCentroAcopioDetalle entity)
    {
      this.SendPropertyChanging();
      entity.gde_GasDestino = (gde_GasDestino) null;
    }

    public int CompareTo(gde_GasDestino other) => this.gde_Descripcion.CompareTo(other.gde_Descripcion);
  }
}
