// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.nki_NovedadKit
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO.Recuperacion
{
  [Table(Name = "Rrr.nki_NovedadKit")]
  public class nki_NovedadKit : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _nki_Id;
    private int _neq_Id;
    private int _kco_Id;
    private int _nki_Cantidad;
    private EntityRef<kco_KitCompra> _kco_KitCompra;
    private EntityRef<neq_NovedadEquipo> _neq_NovedadEquipo;

    public nki_NovedadKit()
    {
      this._kco_KitCompra = new EntityRef<kco_KitCompra>();
      this._neq_NovedadEquipo = new EntityRef<neq_NovedadEquipo>();
    }

    [Column(Storage = "_nki_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
    public int nki_Id
    {
      get => this._nki_Id;
      set
      {
        if (this._nki_Id == value)
          return;
        this.SendPropertyChanging();
        this._nki_Id = value;
        this.SendPropertyChanged(nameof (nki_Id));
      }
    }

    [Column(Storage = "_neq_Id", DbType = "Int NOT NULL")]
    public int neq_Id
    {
      get => this._neq_Id;
      set
      {
        if (this._neq_Id == value)
          return;
        if (this._neq_NovedadEquipo.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._neq_Id = value;
        this.SendPropertyChanged(nameof (neq_Id));
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

    [Column(Storage = "_nki_Cantidad", DbType = "Int NOT NULL")]
    public int nki_Cantidad
    {
      get => this._nki_Cantidad;
      set
      {
        if (this._nki_Cantidad == value)
          return;
        this.SendPropertyChanging();
        this._nki_Cantidad = value;
        this.SendPropertyChanged(nameof (nki_Cantidad));
      }
    }

    [Association(Name = "kco_KitCompra_nki_NovedadKit", Storage = "_kco_KitCompra", ThisKey = "kco_Id", OtherKey = "kco_Id", IsForeignKey = true)]
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
          entity.nki_NovedadKits.Remove(this);
        }
        this._kco_KitCompra.Entity = value;
        if (value != null)
        {
          value.nki_NovedadKits.Add(this);
          this._kco_Id = value.kco_Id;
        }
        else
          this._kco_Id = 0;
        this.SendPropertyChanged(nameof (kco_KitCompra));
      }
    }

    [Association(Name = "neq_NovedadEquipo_nki_NovedadKit", Storage = "_neq_NovedadEquipo", ThisKey = "neq_Id", OtherKey = "neq_Id", IsForeignKey = true)]
    public neq_NovedadEquipo neq_NovedadEquipo
    {
      get => this._neq_NovedadEquipo.Entity;
      set
      {
        neq_NovedadEquipo entity = this._neq_NovedadEquipo.Entity;
        if (entity == value && this._neq_NovedadEquipo.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._neq_NovedadEquipo.Entity = (neq_NovedadEquipo) null;
          entity.nki_NovedadKits.Remove(this);
        }
        this._neq_NovedadEquipo.Entity = value;
        if (value != null)
        {
          value.nki_NovedadKits.Add(this);
          this._neq_Id = value.neq_Id;
        }
        else
          this._neq_Id = 0;
        this.SendPropertyChanged(nameof (neq_NovedadEquipo));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, nki_NovedadKit.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
