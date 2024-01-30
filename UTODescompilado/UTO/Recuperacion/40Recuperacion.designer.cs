// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.eki_EquipoKit
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
  [Table(Name = "Rrr.eki_EquipoKit")]
  public class eki_EquipoKit : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _eki_Id;
    private int _kco_Id;
    private string _eki_Tipo;
    private string _eki_Nombre;
    private string _eki_Descripcion;
    private int? _eki_Disponible;
    private Decimal? _eki_costo;
    private EntitySet<nea_NovedadEquiposAsignado> _nea_NovedadEquiposAsignados;
    private EntitySet<sea_SolicitudEquiposAsignado> _sea_SolicitudEquiposAsignados;
    private EntityRef<kco_KitCompra> _kco_KitCompra;

    public eki_EquipoKit()
    {
      this._nea_NovedadEquiposAsignados = new EntitySet<nea_NovedadEquiposAsignado>(new Action<nea_NovedadEquiposAsignado>(this.attach_nea_NovedadEquiposAsignados), new Action<nea_NovedadEquiposAsignado>(this.detach_nea_NovedadEquiposAsignados));
      this._sea_SolicitudEquiposAsignados = new EntitySet<sea_SolicitudEquiposAsignado>(new Action<sea_SolicitudEquiposAsignado>(this.attach_sea_SolicitudEquiposAsignados), new Action<sea_SolicitudEquiposAsignado>(this.detach_sea_SolicitudEquiposAsignados));
      this._kco_KitCompra = new EntityRef<kco_KitCompra>();
    }

    [Column(Storage = "_eki_Id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int eki_Id
    {
      get => this._eki_Id;
      set
      {
        if (this._eki_Id == value)
          return;
        this.SendPropertyChanging();
        this._eki_Id = value;
        this.SendPropertyChanged(nameof (eki_Id));
      }
    }

    [Column(Storage = "_kco_Id", DbType = "Int NOT NULL")]
    public int kco_Id
    {
      get => this._kco_Id;
      set
      {
        if (this._kco_Id == value)
          return;
        if (this._kco_KitCompra.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._kco_Id = value;
        this.SendPropertyChanged(nameof (kco_Id));
      }
    }

    [Column(Storage = "_eki_Tipo", DbType = "VarChar(100)")]
    public string eki_Tipo
    {
      get => this._eki_Tipo;
      set
      {
        if (!(this._eki_Tipo != value))
          return;
        this.SendPropertyChanging();
        this._eki_Tipo = value;
        this.SendPropertyChanged(nameof (eki_Tipo));
      }
    }

    [Column(Storage = "_eki_Nombre", DbType = "VarChar(250)")]
    public string eki_Nombre
    {
      get => this._eki_Nombre;
      set
      {
        if (!(this._eki_Nombre != value))
          return;
        this.SendPropertyChanging();
        this._eki_Nombre = value;
        this.SendPropertyChanged(nameof (eki_Nombre));
      }
    }

    [Column(Storage = "_eki_Descripcion", DbType = "VarChar(4000) NOT NULL", CanBeNull = false)]
    public string eki_Descripcion
    {
      get => this._eki_Descripcion;
      set
      {
        if (!(this._eki_Descripcion != value))
          return;
        this.SendPropertyChanging();
        this._eki_Descripcion = value;
        this.SendPropertyChanged(nameof (eki_Descripcion));
      }
    }

    [Column(Storage = "_eki_Disponible", DbType = "Int")]
    public int? eki_Disponible
    {
      get => this._eki_Disponible;
      set
      {
        int? ekiDisponible = this._eki_Disponible;
        int? nullable = value;
        if ((ekiDisponible.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (ekiDisponible.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._eki_Disponible = value;
        this.SendPropertyChanged(nameof (eki_Disponible));
      }
    }

    [Column(Storage = "_eki_costo", DbType = "Money")]
    public Decimal? eki_costo
    {
      get => this._eki_costo;
      set
      {
        Decimal? ekiCosto = this._eki_costo;
        Decimal? nullable = value;
        if ((ekiCosto.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (ekiCosto.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._eki_costo = value;
        this.SendPropertyChanged(nameof (eki_costo));
      }
    }

    [Association(Name = "eki_EquipoKit_nea_NovedadEquiposAsignado", Storage = "_nea_NovedadEquiposAsignados", ThisKey = "eki_Id", OtherKey = "eki_Id")]
    public EntitySet<nea_NovedadEquiposAsignado> nea_NovedadEquiposAsignados
    {
      get => this._nea_NovedadEquiposAsignados;
      set => this._nea_NovedadEquiposAsignados.Assign((IEnumerable<nea_NovedadEquiposAsignado>) value);
    }

    [Association(Name = "eki_EquipoKit_sea_SolicitudEquiposAsignado", Storage = "_sea_SolicitudEquiposAsignados", ThisKey = "eki_Id", OtherKey = "eki_Id")]
    public EntitySet<sea_SolicitudEquiposAsignado> sea_SolicitudEquiposAsignados
    {
      get => this._sea_SolicitudEquiposAsignados;
      set => this._sea_SolicitudEquiposAsignados.Assign((IEnumerable<sea_SolicitudEquiposAsignado>) value);
    }

    [Association(Name = "kco_KitCompra_eki_EquipoKit", Storage = "_kco_KitCompra", ThisKey = "kco_Id", OtherKey = "kco_Id", IsForeignKey = true)]
    public kco_KitCompra kco_KitCompra
    {
      get => this._kco_KitCompra.Entity;
      set
      {
        kco_KitCompra entity = this._kco_KitCompra.Entity;
        if (entity == value && this._kco_KitCompra.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._kco_KitCompra.Entity = (kco_KitCompra) null;
          entity.eki_EquipoKits.Remove(this);
        }
        this._kco_KitCompra.Entity = value;
        if (value != null)
        {
          value.eki_EquipoKits.Add(this);
          this._kco_Id = value.kco_Id;
        }
        else
          this._kco_Id = 0;
        this.SendPropertyChanged(nameof (kco_KitCompra));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, eki_EquipoKit.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void attach_nea_NovedadEquiposAsignados(nea_NovedadEquiposAsignado entity)
    {
      this.SendPropertyChanging();
      entity.eki_EquipoKit = this;
    }

    private void detach_nea_NovedadEquiposAsignados(nea_NovedadEquiposAsignado entity)
    {
      this.SendPropertyChanging();
      entity.eki_EquipoKit = (eki_EquipoKit) null;
    }

    private void attach_sea_SolicitudEquiposAsignados(sea_SolicitudEquiposAsignado entity)
    {
      this.SendPropertyChanging();
      entity.eki_EquipoKit = this;
    }

    private void detach_sea_SolicitudEquiposAsignados(sea_SolicitudEquiposAsignado entity)
    {
      this.SendPropertyChanging();
      entity.eki_EquipoKit = (eki_EquipoKit) null;
    }
  }
}
