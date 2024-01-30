// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.rad_ReporteCentroAcopioDetalle
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO.Recuperacion
{
  [Table(Name = "Rrr.rad_ReporteCentroAcopioDetalle")]
  public class rad_ReporteCentroAcopioDetalle : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _rad_Id;
    private int _rca_Id;
    private int _gde_Id;
    private int _gti_Id;
    private Decimal _rad_Cantidad;
    private DateTime _rad_Fecha;
    private string _rad_Tercero;
    private EntityRef<gde_GasDestino> _gde_GasDestino;
    private EntityRef<gti_GasTipo> _gti_GasTipo;
    private EntityRef<rca_ReporteCentroAcopio> _rca_ReporteCentroAcopio;

    public rad_ReporteCentroAcopioDetalle()
    {
      this._gde_GasDestino = new EntityRef<gde_GasDestino>();
      this._gti_GasTipo = new EntityRef<gti_GasTipo>();
      this._rca_ReporteCentroAcopio = new EntityRef<rca_ReporteCentroAcopio>();
    }

    [Column(Storage = "_rad_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
    public int rad_Id
    {
      get => this._rad_Id;
      set
      {
        if (this._rad_Id == value)
          return;
        this.SendPropertyChanging();
        this._rad_Id = value;
        this.SendPropertyChanged(nameof (rad_Id));
      }
    }

    [Column(Storage = "_rca_Id", DbType = "Int NOT NULL")]
    public int rca_Id
    {
      get => this._rca_Id;
      set
      {
        if (this._rca_Id == value)
          return;
        if (this._rca_ReporteCentroAcopio.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._rca_Id = value;
        this.SendPropertyChanged(nameof (rca_Id));
      }
    }

    [Column(Storage = "_gde_Id", DbType = "Int NOT NULL")]
    public int gde_Id
    {
      get => this._gde_Id;
      set
      {
        if (this._gde_Id == value)
          return;
        if (this._gde_GasDestino.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._gde_Id = value;
        this.SendPropertyChanged(nameof (gde_Id));
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

    [Column(Storage = "_rad_Cantidad", DbType = "Decimal(10,3) NOT NULL")]
    public Decimal rad_Cantidad
    {
      get => this._rad_Cantidad;
      set
      {
        if (!(this._rad_Cantidad != value))
          return;
        this.SendPropertyChanging();
        this._rad_Cantidad = value;
        this.SendPropertyChanged(nameof (rad_Cantidad));
      }
    }

    [Column(Storage = "_rad_Fecha", DbType = "DateTime NOT NULL")]
    public DateTime rad_Fecha
    {
      get => this._rad_Fecha;
      set
      {
        if (!(this._rad_Fecha != value))
          return;
        this.SendPropertyChanging();
        this._rad_Fecha = value;
        this.SendPropertyChanged(nameof (rad_Fecha));
      }
    }

    [Column(Storage = "_rad_Tercero", DbType = "VarChar(250) NOT NULL")]
    public string rad_Tercero
    {
      get => this._rad_Tercero;
      set
      {
        if (!(this._rad_Tercero != value))
          return;
        this.SendPropertyChanging();
        this._rad_Tercero = value;
        this.SendPropertyChanged(nameof (rad_Tercero));
      }
    }

    [Association(Name = "gde_GasDestino_rad_ReporteCentroAcopioDetalle", Storage = "_gde_GasDestino", ThisKey = "gde_Id", OtherKey = "gde_Id", IsForeignKey = true)]
    public gde_GasDestino gde_GasDestino
    {
      get => this._gde_GasDestino.Entity;
      set
      {
        gde_GasDestino entity = this._gde_GasDestino.Entity;
        if (entity == value && this._gde_GasDestino.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._gde_GasDestino.Entity = (gde_GasDestino) null;
          entity.rad_ReporteCentroAcopioDetalles.Remove(this);
        }
        this._gde_GasDestino.Entity = value;
        if (value != null)
        {
          value.rad_ReporteCentroAcopioDetalles.Add(this);
          this._gde_Id = value.gde_Id;
        }
        else
          this._gde_Id = 0;
        this.SendPropertyChanged(nameof (gde_GasDestino));
      }
    }

    [Association(Name = "gti_GasTipo_rad_ReporteCentroAcopioDetalle", Storage = "_gti_GasTipo", ThisKey = "gti_Id", OtherKey = "gti_Id", IsForeignKey = true)]
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
          entity.rad_ReporteCentroAcopioDetalles.Remove(this);
        }
        this._gti_GasTipo.Entity = value;
        if (value != null)
        {
          value.rad_ReporteCentroAcopioDetalles.Add(this);
          this._gti_Id = value.gti_Id;
        }
        else
          this._gti_Id = 0;
        this.SendPropertyChanged(nameof (gti_GasTipo));
      }
    }

    [Association(Name = "rca_ReporteCentroAcopio_rad_ReporteCentroAcopioDetalle", Storage = "_rca_ReporteCentroAcopio", ThisKey = "rca_Id", OtherKey = "rca_Id", IsForeignKey = true)]
    public rca_ReporteCentroAcopio rca_ReporteCentroAcopio
    {
      get => this._rca_ReporteCentroAcopio.Entity;
      set
      {
        rca_ReporteCentroAcopio entity = this._rca_ReporteCentroAcopio.Entity;
        if (entity == value && this._rca_ReporteCentroAcopio.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._rca_ReporteCentroAcopio.Entity = (rca_ReporteCentroAcopio) null;
          entity.rad_ReporteCentroAcopioDetalles.Remove(this);
        }
        this._rca_ReporteCentroAcopio.Entity = value;
        if (value != null)
        {
          value.rad_ReporteCentroAcopioDetalles.Add(this);
          this._rca_Id = value.rca_Id;
        }
        else
          this._rca_Id = 0;
        this.SendPropertyChanged(nameof (rca_ReporteCentroAcopio));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, rad_ReporteCentroAcopioDetalle.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
