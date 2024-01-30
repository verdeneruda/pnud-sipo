// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.rre_ReporteRegeneracion
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO.Recuperacion
{
  [Table(Name = "Rrr.rre_ReporteRegeneracion")]
  public class rre_ReporteRegeneracion : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _rre_Id;
    private int _cre_Id;
    private DateTime _rre_Fecha;
    private int _gti_Id;
    private int _ter_Id;
    private Decimal _rre_CantidadEntregada;
    private Decimal _rre_CantidadRegenerada;
    private Decimal? _rre_PrecioVenta;
    private int? _rrd_Id;
    private int? _gde_Id;
    private Decimal _rre_CantidadRechazada;
    private int? _rre_Cantidad;
    private Decimal? _rre_Porciento;
    private string _rre_Observacion;
    private EntityRef<cre_CentroRegeneracion> _cre_CentroRegeneracion;
    private EntityRef<gde_GasDestino> _gde_GasDestino;
    private EntityRef<gti_GasTipo> _gti_GasTipo;
    private EntityRef<ter_Tercero> _ter_Tercero;

    public rre_ReporteRegeneracion()
    {
      this._cre_CentroRegeneracion = new EntityRef<cre_CentroRegeneracion>();
      this._gde_GasDestino = new EntityRef<gde_GasDestino>();
      this._gti_GasTipo = new EntityRef<gti_GasTipo>();
      this._ter_Tercero = new EntityRef<ter_Tercero>();
    }

    [Column(Storage = "_rre_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
    public int rre_Id
    {
      get => this._rre_Id;
      set
      {
        if (this._rre_Id == value)
          return;
        this.SendPropertyChanging();
        this._rre_Id = value;
        this.SendPropertyChanged(nameof (rre_Id));
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

    [Column(Storage = "_rre_Fecha", DbType = "DateTime NOT NULL")]
    public DateTime rre_Fecha
    {
      get => this._rre_Fecha;
      set
      {
        if (!(this._rre_Fecha != value))
          return;
        this.SendPropertyChanging();
        this._rre_Fecha = value;
        this.SendPropertyChanged(nameof (rre_Fecha));
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

    [Column(Storage = "_ter_Id", DbType = "Int NOT NULL")]
    public int ter_Id
    {
      get => this._ter_Id;
      set
      {
        if (this._ter_Id == value)
          return;
        if (this._ter_Tercero.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._ter_Id = value;
        this.SendPropertyChanged(nameof (ter_Id));
      }
    }

    [Column(Storage = "_rre_CantidadEntregada", DbType = "Decimal(10,3) NOT NULL")]
    public Decimal rre_CantidadEntregada
    {
      get => this._rre_CantidadEntregada;
      set
      {
        if (!(this._rre_CantidadEntregada != value))
          return;
        this.SendPropertyChanging();
        this._rre_CantidadEntregada = value;
        this.SendPropertyChanged(nameof (rre_CantidadEntregada));
      }
    }

    [Column(Storage = "_rre_CantidadRegenerada", DbType = "Decimal(10,3) NOT NULL")]
    public Decimal rre_CantidadRegenerada
    {
      get => this._rre_CantidadRegenerada;
      set
      {
        if (!(this._rre_CantidadRegenerada != value))
          return;
        this.SendPropertyChanging();
        this._rre_CantidadRegenerada = value;
        this.SendPropertyChanged(nameof (rre_CantidadRegenerada));
      }
    }

    [Column(Storage = "_rre_PrecioVenta", DbType = "Money")]
    public Decimal? rre_PrecioVenta
    {
      get => this._rre_PrecioVenta;
      set
      {
        Decimal? rrePrecioVenta = this._rre_PrecioVenta;
        Decimal? nullable = value;
        if ((rrePrecioVenta.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (rrePrecioVenta.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._rre_PrecioVenta = value;
        this.SendPropertyChanged(nameof (rre_PrecioVenta));
      }
    }

    [Column(Storage = "_rrd_Id", DbType = "Int")]
    public int? rrd_Id
    {
      get => this._rrd_Id;
      set
      {
        int? rrdId = this._rrd_Id;
        int? nullable = value;
        if ((rrdId.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (rrdId.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._rrd_Id = value;
        this.SendPropertyChanged(nameof (rrd_Id));
      }
    }

    [Column(Storage = "_gde_Id", DbType = "Int")]
    public int? gde_Id
    {
      get => this._gde_Id;
      set
      {
        int? gdeId = this._gde_Id;
        int? nullable = value;
        if ((gdeId.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (gdeId.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        if (this._gde_GasDestino.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._gde_Id = value;
        this.SendPropertyChanged(nameof (gde_Id));
      }
    }

    [Column(Storage = "_rre_CantidadRechazada", DbType = "Decimal(10,3) NOT NULL")]
    public Decimal rre_CantidadRechazada
    {
      get => this._rre_CantidadRechazada;
      set
      {
        if (!(this._rre_CantidadRechazada != value))
          return;
        this.SendPropertyChanging();
        this._rre_CantidadRechazada = value;
        this.SendPropertyChanged(nameof (rre_CantidadRechazada));
      }
    }

    [Column(Storage = "_rre_Cantidad", DbType = "Int")]
    public int? rre_Cantidad
    {
      get => this._rre_Cantidad;
      set
      {
        int? rreCantidad = this._rre_Cantidad;
        int? nullable = value;
        if ((rreCantidad.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (rreCantidad.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._rre_Cantidad = value;
        this.SendPropertyChanged(nameof (rre_Cantidad));
      }
    }

    [Column(Storage = "_rre_Porciento", DbType = "Decimal(10,3)")]
    public Decimal? rre_Porciento
    {
      get => this._rre_Porciento;
      set
      {
        Decimal? rrePorciento = this._rre_Porciento;
        Decimal? nullable = value;
        if ((rrePorciento.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (rrePorciento.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._rre_Porciento = value;
        this.SendPropertyChanged(nameof (rre_Porciento));
      }
    }

    [Column(Storage = "_rre_Observacion", DbType = "VarChar(MAX)")]
    public string rre_Observacion
    {
      get => this._rre_Observacion;
      set
      {
        if (!(this._rre_Observacion != value))
          return;
        this.SendPropertyChanging();
        this._rre_Observacion = value;
        this.SendPropertyChanged(nameof (rre_Observacion));
      }
    }

    [Association(Name = "cre_CentroRegeneracion_rre_ReporteRegeneracion", Storage = "_cre_CentroRegeneracion", ThisKey = "cre_Id", OtherKey = "cre_Id", IsForeignKey = true)]
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
          entity.rre_ReporteRegeneracions.Remove(this);
        }
        this._cre_CentroRegeneracion.Entity = value;
        if (value != null)
        {
          value.rre_ReporteRegeneracions.Add(this);
          this._cre_Id = value.cre_Id;
        }
        else
          this._cre_Id = 0;
        this.SendPropertyChanged(nameof (cre_CentroRegeneracion));
      }
    }

    [Association(Name = "gde_GasDestino_rre_ReporteRegeneracion", Storage = "_gde_GasDestino", ThisKey = "gde_Id", OtherKey = "gde_Id", IsForeignKey = true)]
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
          entity.rre_ReporteRegeneracions.Remove(this);
        }
        this._gde_GasDestino.Entity = value;
        if (value != null)
        {
          value.rre_ReporteRegeneracions.Add(this);
          this._gde_Id = new int?(value.gde_Id);
        }
        else
          this._gde_Id = new int?();
        this.SendPropertyChanged(nameof (gde_GasDestino));
      }
    }

    [Association(Name = "gti_GasTipo_rre_ReporteRegeneracion", Storage = "_gti_GasTipo", ThisKey = "gti_Id", OtherKey = "gti_Id", IsForeignKey = true)]
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
          entity.rre_ReporteRegeneracions.Remove(this);
        }
        this._gti_GasTipo.Entity = value;
        if (value != null)
        {
          value.rre_ReporteRegeneracions.Add(this);
          this._gti_Id = value.gti_Id;
        }
        else
          this._gti_Id = 0;
        this.SendPropertyChanged(nameof (gti_GasTipo));
      }
    }

    [Association(Name = "ter_Tercero_rre_ReporteRegeneracion", Storage = "_ter_Tercero", ThisKey = "ter_Id", OtherKey = "ter_Id", IsForeignKey = true)]
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
          entity.rre_ReporteRegeneracions.Remove(this);
        }
        this._ter_Tercero.Entity = value;
        if (value != null)
        {
          value.rre_ReporteRegeneracions.Add(this);
          this._ter_Id = value.ter_Id;
        }
        else
          this._ter_Id = 0;
        this.SendPropertyChanged(nameof (ter_Tercero));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, rre_ReporteRegeneracion.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
