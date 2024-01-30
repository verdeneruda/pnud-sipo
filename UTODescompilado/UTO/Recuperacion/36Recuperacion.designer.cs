// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.rdt_ReporteUsoDetalle
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO.Recuperacion
{
  [Table(Name = "Rrr.rdt_ReporteUsoDetalle")]
  public class rdt_ReporteUsoDetalle : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _rdt_Id;
    private int _rdu_Id;
    private int _gti_Id;
    private int _gus_Id;
    private Decimal _rdt_Cantidad;
    private int? _psu_Id;
    private EntityRef<gti_GasTipo> _gti_GasTipo;
    private EntityRef<gus_GasUso> _gus_GasUso;
    private EntityRef<psu_PresentacionSustancia> _psu_PresentacionSustancia;
    private EntityRef<rdu_ReporteUso> _rdu_ReporteUso;

    public rdt_ReporteUsoDetalle()
    {
      this._gti_GasTipo = new EntityRef<gti_GasTipo>();
      this._gus_GasUso = new EntityRef<gus_GasUso>();
      this._psu_PresentacionSustancia = new EntityRef<psu_PresentacionSustancia>();
      this._rdu_ReporteUso = new EntityRef<rdu_ReporteUso>();
    }

    [Column(Storage = "_rdt_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
    public int rdt_Id
    {
      get => this._rdt_Id;
      set
      {
        if (this._rdt_Id == value)
          return;
        this.SendPropertyChanging();
        this._rdt_Id = value;
        this.SendPropertyChanged(nameof (rdt_Id));
      }
    }

    [Column(Storage = "_rdu_Id", DbType = "Int NOT NULL")]
    public int rdu_Id
    {
      get => this._rdu_Id;
      set
      {
        if (this._rdu_Id == value)
          return;
        if (this._rdu_ReporteUso.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._rdu_Id = value;
        this.SendPropertyChanged(nameof (rdu_Id));
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

    [Column(Storage = "_gus_Id", DbType = "Int NOT NULL")]
    public int gus_Id
    {
      get => this._gus_Id;
      set
      {
        if (this._gus_Id == value)
          return;
        if (this._gus_GasUso.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._gus_Id = value;
        this.SendPropertyChanged(nameof (gus_Id));
      }
    }

    [Column(Storage = "_rdt_Cantidad", DbType = "Decimal(10,3) NOT NULL")]
    public Decimal rdt_Cantidad
    {
      get => this._rdt_Cantidad;
      set
      {
        if (!(this._rdt_Cantidad != value))
          return;
        this.SendPropertyChanging();
        this._rdt_Cantidad = value;
        this.SendPropertyChanged(nameof (rdt_Cantidad));
      }
    }

    [Column(Storage = "_psu_Id", DbType = "Int")]
    public int? psu_Id
    {
      get => this._psu_Id;
      set
      {
        int? psuId = this._psu_Id;
        int? nullable = value;
        if ((psuId.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (psuId.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        if (this._psu_PresentacionSustancia.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._psu_Id = value;
        this.SendPropertyChanged(nameof (psu_Id));
      }
    }

    [Association(Name = "gti_GasTipo_rdt_ReporteUsoDetalle", Storage = "_gti_GasTipo", ThisKey = "gti_Id", OtherKey = "gti_Id", IsForeignKey = true)]
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
          entity.rdt_ReporteUsoDetalles.Remove(this);
        }
        this._gti_GasTipo.Entity = value;
        if (value != null)
        {
          value.rdt_ReporteUsoDetalles.Add(this);
          this._gti_Id = value.gti_Id;
        }
        else
          this._gti_Id = 0;
        this.SendPropertyChanged(nameof (gti_GasTipo));
      }
    }

    [Association(Name = "gus_GasUso_rdt_ReporteUsoDetalle", Storage = "_gus_GasUso", ThisKey = "gus_Id", OtherKey = "gus_Id", IsForeignKey = true)]
    public gus_GasUso gus_GasUso
    {
      get => this._gus_GasUso.Entity;
      set
      {
        gus_GasUso entity = this._gus_GasUso.Entity;
        if (entity == value && this._gus_GasUso.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._gus_GasUso.Entity = (gus_GasUso) null;
          entity.rdt_ReporteUsoDetalles.Remove(this);
        }
        this._gus_GasUso.Entity = value;
        if (value != null)
        {
          value.rdt_ReporteUsoDetalles.Add(this);
          this._gus_Id = value.gus_Id;
        }
        else
          this._gus_Id = 0;
        this.SendPropertyChanged(nameof (gus_GasUso));
      }
    }

    [Association(Name = "psu_PresentacionSustancia_rdt_ReporteUsoDetalle", Storage = "_psu_PresentacionSustancia", ThisKey = "psu_Id", OtherKey = "psu_Id", IsForeignKey = true)]
    public psu_PresentacionSustancia psu_PresentacionSustancia
    {
      get => this._psu_PresentacionSustancia.Entity;
      set
      {
        psu_PresentacionSustancia entity = this._psu_PresentacionSustancia.Entity;
        if (entity == value && this._psu_PresentacionSustancia.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._psu_PresentacionSustancia.Entity = (psu_PresentacionSustancia) null;
          entity.rdt_ReporteUsoDetalles.Remove(this);
        }
        this._psu_PresentacionSustancia.Entity = value;
        if (value != null)
        {
          value.rdt_ReporteUsoDetalles.Add(this);
          this._psu_Id = new int?(value.psu_Id);
        }
        else
          this._psu_Id = new int?();
        this.SendPropertyChanged(nameof (psu_PresentacionSustancia));
      }
    }

    [Association(Name = "rdu_ReporteUso_rdt_ReporteUsoDetalle", Storage = "_rdu_ReporteUso", ThisKey = "rdu_Id", OtherKey = "rdu_Id", IsForeignKey = true)]
    public rdu_ReporteUso rdu_ReporteUso
    {
      get => this._rdu_ReporteUso.Entity;
      set
      {
        rdu_ReporteUso entity = this._rdu_ReporteUso.Entity;
        if (entity == value && this._rdu_ReporteUso.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._rdu_ReporteUso.Entity = (rdu_ReporteUso) null;
          entity.rdt_ReporteUsoDetalles.Remove(this);
        }
        this._rdu_ReporteUso.Entity = value;
        if (value != null)
        {
          value.rdt_ReporteUsoDetalles.Add(this);
          this._rdu_Id = value.rdu_Id;
        }
        else
          this._rdu_Id = 0;
        this.SendPropertyChanged(nameof (rdu_ReporteUso));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, rdt_ReporteUsoDetalle.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
