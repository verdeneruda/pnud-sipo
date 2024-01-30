// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.rcd_ReporteConsolidadoDetalle
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO.Recuperacion
{
  [Table(Name = "Rrr.rcd_ReporteConsolidadoDetalle")]
  public class rcd_ReporteConsolidadoDetalle : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _rcd_Id;
    private int _rrc_Id;
    private int _gti_Id;
    private Decimal _rcd_CantidadVendida;
    private Decimal _rcd_PrecioPromedio;
    private EntityRef<gti_GasTipo> _gti_GasTipo;
    private EntityRef<rrc_ReporteRegeneracionConsolidado> _rrc_ReporteRegeneracionConsolidado;

    public rcd_ReporteConsolidadoDetalle()
    {
      this._gti_GasTipo = new EntityRef<gti_GasTipo>();
      this._rrc_ReporteRegeneracionConsolidado = new EntityRef<rrc_ReporteRegeneracionConsolidado>();
    }

    [Column(Storage = "_rcd_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
    public int rcd_Id
    {
      get => this._rcd_Id;
      set
      {
        if (this._rcd_Id == value)
          return;
        this.SendPropertyChanging();
        this._rcd_Id = value;
        this.SendPropertyChanged(nameof (rcd_Id));
      }
    }

    [Column(Storage = "_rrc_Id", DbType = "Int NOT NULL")]
    public int rrc_Id
    {
      get => this._rrc_Id;
      set
      {
        if (this._rrc_Id == value)
          return;
        if (this._rrc_ReporteRegeneracionConsolidado.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._rrc_Id = value;
        this.SendPropertyChanged(nameof (rrc_Id));
      }
    }

    [Column(Storage = "_gti_Id", DbType = "Int NOT NULL")]
    public int gti_Id
    {
      get => this._gti_Id;
      set
      {
        if (this._gti_Id == value)
          return;
        if (this._gti_GasTipo.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._gti_Id = value;
        this.SendPropertyChanged(nameof (gti_Id));
      }
    }

    [Column(Storage = "_rcd_CantidadVendida", DbType = "Decimal(10,3) NOT NULL")]
    public Decimal rcd_CantidadVendida
    {
      get => this._rcd_CantidadVendida;
      set
      {
        if (!(this._rcd_CantidadVendida != value))
          return;
        this.SendPropertyChanging();
        this._rcd_CantidadVendida = value;
        this.SendPropertyChanged(nameof (rcd_CantidadVendida));
      }
    }

    [Column(Storage = "_rcd_PrecioPromedio", DbType = "Money NOT NULL")]
    public Decimal rcd_PrecioPromedio
    {
      get => this._rcd_PrecioPromedio;
      set
      {
        if (!(this._rcd_PrecioPromedio != value))
          return;
        this.SendPropertyChanging();
        this._rcd_PrecioPromedio = value;
        this.SendPropertyChanged(nameof (rcd_PrecioPromedio));
      }
    }

    [Association(Name = "gti_GasTipo_rcd_ReporteConsolidadoDetalle", Storage = "_gti_GasTipo", ThisKey = "gti_Id", OtherKey = "gti_Id", IsForeignKey = true)]
    public gti_GasTipo gti_GasTipo
    {
      get => this._gti_GasTipo.Entity;
      set
      {
        gti_GasTipo entity = this._gti_GasTipo.Entity;
        if (entity == value && this._gti_GasTipo.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._gti_GasTipo.Entity = (gti_GasTipo) null;
          entity.rcd_ReporteConsolidadoDetalles.Remove(this);
        }
        this._gti_GasTipo.Entity = value;
        if (value != null)
        {
          value.rcd_ReporteConsolidadoDetalles.Add(this);
          this._gti_Id = value.gti_Id;
        }
        else
          this._gti_Id = 0;
        this.SendPropertyChanged(nameof (gti_GasTipo));
      }
    }

    [Association(Name = "rrc_ReporteRegeneracionConsolidado_rcd_ReporteConsolidadoDetalle", Storage = "_rrc_ReporteRegeneracionConsolidado", ThisKey = "rrc_Id", OtherKey = "rrc_Id", IsForeignKey = true)]
    public rrc_ReporteRegeneracionConsolidado rrc_ReporteRegeneracionConsolidado
    {
      get => this._rrc_ReporteRegeneracionConsolidado.Entity;
      set
      {
        rrc_ReporteRegeneracionConsolidado entity = this._rrc_ReporteRegeneracionConsolidado.Entity;
        if (entity == value && this._rrc_ReporteRegeneracionConsolidado.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._rrc_ReporteRegeneracionConsolidado.Entity = (rrc_ReporteRegeneracionConsolidado) null;
          entity.rcd_ReporteConsolidadoDetalles.Remove(this);
        }
        this._rrc_ReporteRegeneracionConsolidado.Entity = value;
        if (value != null)
        {
          value.rcd_ReporteConsolidadoDetalles.Add(this);
          this._rrc_Id = value.rrc_Id;
        }
        else
          this._rrc_Id = 0;
        this.SendPropertyChanged(nameof (rrc_ReporteRegeneracionConsolidado));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, rcd_ReporteConsolidadoDetalle.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
