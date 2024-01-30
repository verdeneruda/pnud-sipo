// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.lco_LicitacionCompra
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
  [Table(Name = "Rrr.lco_LicitacionCompra")]
  public class lco_LicitacionCompra : 
    INotifyPropertyChanging,
    INotifyPropertyChanged,
    IComparable<lco_LicitacionCompra>
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _lco_Id;
    private string _lco_Descripcion;
    private int? _pre_id;
    private EntitySet<kco_KitCompra> _kco_KitCompras;
    private EntityRef<pre_ProyectoRecuperacion> _pre_ProyectoRecuperacion;

    public lco_LicitacionCompra()
    {
      this._kco_KitCompras = new EntitySet<kco_KitCompra>(new Action<kco_KitCompra>(this.attach_kco_KitCompras), new Action<kco_KitCompra>(this.detach_kco_KitCompras));
      this._pre_ProyectoRecuperacion = new EntityRef<pre_ProyectoRecuperacion>();
    }

    [Column(Storage = "_lco_Id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int lco_Id
    {
      get => this._lco_Id;
      set
      {
        if (this._lco_Id == value)
          return;
        this.SendPropertyChanging();
        this._lco_Id = value;
        this.SendPropertyChanged(nameof (lco_Id));
      }
    }

    [Column(Storage = "_lco_Descripcion", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string lco_Descripcion
    {
      get => this._lco_Descripcion;
      set
      {
        if (!(this._lco_Descripcion != value))
          return;
        this.SendPropertyChanging();
        this._lco_Descripcion = value;
        this.SendPropertyChanged(nameof (lco_Descripcion));
      }
    }

    [Column(Storage = "_pre_id", DbType = "Int")]
    public int? pre_id
    {
      get => this._pre_id;
      set
      {
        int? preId = this._pre_id;
        int? nullable = value;
        if ((preId.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (preId.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        if (this._pre_ProyectoRecuperacion.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._pre_id = value;
        this.SendPropertyChanged(nameof (pre_id));
      }
    }

    [Association(Name = "lco_LicitacionCompra_kco_KitCompra", Storage = "_kco_KitCompras", ThisKey = "lco_Id", OtherKey = "lco_Id")]
    public EntitySet<kco_KitCompra> kco_KitCompras
    {
      get => this._kco_KitCompras;
      set => this._kco_KitCompras.Assign((IEnumerable<kco_KitCompra>) value);
    }

    [Association(Name = "pre_ProyectoRecuperacion_lco_LicitacionCompra", Storage = "_pre_ProyectoRecuperacion", ThisKey = "pre_id", OtherKey = "pre_Id", IsForeignKey = true)]
    public pre_ProyectoRecuperacion pre_ProyectoRecuperacion
    {
      get => this._pre_ProyectoRecuperacion.Entity;
      set
      {
        pre_ProyectoRecuperacion entity = this._pre_ProyectoRecuperacion.Entity;
        if (entity == value && this._pre_ProyectoRecuperacion.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._pre_ProyectoRecuperacion.Entity = (pre_ProyectoRecuperacion) null;
          entity.lco_LicitacionCompras.Remove(this);
        }
        this._pre_ProyectoRecuperacion.Entity = value;
        if (value != null)
        {
          value.lco_LicitacionCompras.Add(this);
          this._pre_id = new int?(value.pre_Id);
        }
        else
          this._pre_id = new int?();
        this.SendPropertyChanged(nameof (pre_ProyectoRecuperacion));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, lco_LicitacionCompra.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void attach_kco_KitCompras(kco_KitCompra entity)
    {
      this.SendPropertyChanging();
      entity.lco_LicitacionCompra = this;
    }

    private void detach_kco_KitCompras(kco_KitCompra entity)
    {
      this.SendPropertyChanging();
      entity.lco_LicitacionCompra = (lco_LicitacionCompra) null;
    }

    public int CompareTo(lco_LicitacionCompra other) => this.lco_Descripcion.CompareTo(other.lco_Descripcion);
  }
}
