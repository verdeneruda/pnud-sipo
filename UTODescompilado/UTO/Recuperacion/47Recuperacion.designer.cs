// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.rcd_ReporteCentroRegeneracionDetalle
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO.Recuperacion
{
  [Table(Name = "Rrr.rcd_ReporteCentroRegeneracionDetalle")]
  public class rcd_ReporteCentroRegeneracionDetalle : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _rcd_Id;
    private int _rcr_Id;
    private int _gde_Id;
    private int _gti_Id;
    private Decimal _rcd_Cantidad;
    private DateTime _rcd_Fecha;
    private string _rcd_Tercero;
    private EntityRef<gde_GasDestino> _gde_GasDestino;
    private EntityRef<rcr_ReporteCentroRegeneracion> _rcr_ReporteCentroRegeneracion;
    private EntityRef<gti_GasTipo> _gti_GasTipo;

    public rcd_ReporteCentroRegeneracionDetalle()
    {
      this._gde_GasDestino = new EntityRef<gde_GasDestino>();
      this._rcr_ReporteCentroRegeneracion = new EntityRef<rcr_ReporteCentroRegeneracion>();
      this._gti_GasTipo = new EntityRef<gti_GasTipo>();
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

    [Column(Storage = "_rcr_Id", DbType = "Int NOT NULL")]
    public int rcr_Id
    {
      get => this._rcr_Id;
      set
      {
        if (this._rcr_Id == value)
          return;
        if (this._rcr_ReporteCentroRegeneracion.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._rcr_Id = value;
        this.SendPropertyChanged(nameof (rcr_Id));
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

    [Column(Storage = "_rcd_Cantidad", DbType = "Decimal(10,3) NOT NULL")]
    public Decimal rcd_Cantidad
    {
      get => this._rcd_Cantidad;
      set
      {
        if (!(this._rcd_Cantidad != value))
          return;
        this.SendPropertyChanging();
        this._rcd_Cantidad = value;
        this.SendPropertyChanged(nameof (rcd_Cantidad));
      }
    }

    [Column(Storage = "_rcd_Fecha", DbType = "DateTime NOT NULL")]
    public DateTime rcd_Fecha
    {
      get => this._rcd_Fecha;
      set
      {
        if (!(this._rcd_Fecha != value))
          return;
        this.SendPropertyChanging();
        this._rcd_Fecha = value;
        this.SendPropertyChanged(nameof (rcd_Fecha));
      }
    }

    [Column(Storage = "_rcd_Tercero", DbType = "VarChar(250) NOT NULL")]
    public string rcd_Tercero
    {
      get => this._rcd_Tercero;
      set
      {
        if (!(this._rcd_Tercero != value))
          return;
        this.SendPropertyChanging();
        this._rcd_Tercero = value;
        this.SendPropertyChanged(nameof (rcd_Tercero));
      }
    }

    [Association(Name = "gde_GasDestino_rcd_ReporteCentroRegeneracionDetalle", Storage = "_gde_GasDestino", ThisKey = "gde_Id", OtherKey = "gde_Id", IsForeignKey = true)]
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
          entity.rcd_ReporteCentroRegeneracionDetalles.Remove(this);
        }
        this._gde_GasDestino.Entity = value;
        if (value != null)
        {
          value.rcd_ReporteCentroRegeneracionDetalles.Add(this);
          this._gde_Id = value.gde_Id;
        }
        else
          this._gde_Id = 0;
        this.SendPropertyChanged(nameof (gde_GasDestino));
      }
    }

    [Association(Name = "rcr_ReporteCentroRegeneracion_rcd_ReporteCentroRegeneracionDetalle", Storage = "_rcr_ReporteCentroRegeneracion", ThisKey = "rcr_Id", OtherKey = "rcr_Id", IsForeignKey = true)]
    public rcr_ReporteCentroRegeneracion rcr_ReporteCentroRegeneracion
    {
      get => this._rcr_ReporteCentroRegeneracion.Entity;
      set
      {
        rcr_ReporteCentroRegeneracion entity = this._rcr_ReporteCentroRegeneracion.Entity;
        if (entity == value && this._rcr_ReporteCentroRegeneracion.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._rcr_ReporteCentroRegeneracion.Entity = (rcr_ReporteCentroRegeneracion) null;
          entity.rcd_ReporteCentroRegeneracionDetalles.Remove(this);
        }
        this._rcr_ReporteCentroRegeneracion.Entity = value;
        if (value != null)
        {
          value.rcd_ReporteCentroRegeneracionDetalles.Add(this);
          this._rcr_Id = value.rcr_Id;
        }
        else
          this._rcr_Id = 0;
        this.SendPropertyChanged(nameof (rcr_ReporteCentroRegeneracion));
      }
    }

    [Association(Name = "gti_GasTipo_rcd_ReporteCentroRegeneracionDetalle", Storage = "_gti_GasTipo", ThisKey = "gti_Id", OtherKey = "gti_Id", IsForeignKey = true)]
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
          entity.rcd_ReporteCentroRegeneracionDetalles.Remove(this);
        }
        this._gti_GasTipo.Entity = value;
        if (value != null)
        {
          value.rcd_ReporteCentroRegeneracionDetalles.Add(this);
          this._gti_Id = value.gti_Id;
        }
        else
          this._gti_Id = 0;
        this.SendPropertyChanged(nameof (gti_GasTipo));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, rcd_ReporteCentroRegeneracionDetalle.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
