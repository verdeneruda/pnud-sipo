// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.kco_KitCompra
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
  [Table(Name = "Rrr.kco_KitCompra")]
  public class kco_KitCompra : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _kco_Id;
    private int _lco_Id;
    private string _kco_Descripcion;
    private Decimal? _kco_costo;
    private int? _kco_Disponible;
    private EntitySet<nki_NovedadKit> _nki_NovedadKits;
    private EntitySet<ski_SolicitudKit> _ski_SolicitudKits;
    private EntitySet<eki_EquipoKit> _eki_EquipoKits;
    private EntityRef<lco_LicitacionCompra> _lco_LicitacionCompra;

    public kco_KitCompra()
    {
      this._nki_NovedadKits = new EntitySet<nki_NovedadKit>(new Action<nki_NovedadKit>(this.attach_nki_NovedadKits), new Action<nki_NovedadKit>(this.detach_nki_NovedadKits));
      this._ski_SolicitudKits = new EntitySet<ski_SolicitudKit>(new Action<ski_SolicitudKit>(this.attach_ski_SolicitudKits), new Action<ski_SolicitudKit>(this.detach_ski_SolicitudKits));
      this._eki_EquipoKits = new EntitySet<eki_EquipoKit>(new Action<eki_EquipoKit>(this.attach_eki_EquipoKits), new Action<eki_EquipoKit>(this.detach_eki_EquipoKits));
      this._lco_LicitacionCompra = new EntityRef<lco_LicitacionCompra>();
    }

    [Column(Storage = "_kco_Id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int kco_Id
    {
      get => this._kco_Id;
      set
      {
        if (this._kco_Id == value)
          return;
        this.SendPropertyChanging();
        this._kco_Id = value;
        this.SendPropertyChanged(nameof (kco_Id));
      }
    }

    [Column(Storage = "_lco_Id", DbType = "Int NOT NULL")]
    public int lco_Id
    {
      get => this._lco_Id;
      set
      {
        if (this._lco_Id == value)
          return;
        if (this._lco_LicitacionCompra.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._lco_Id = value;
        this.SendPropertyChanged(nameof (lco_Id));
      }
    }

    [Column(Storage = "_kco_Descripcion", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string kco_Descripcion
    {
      get => this._kco_Descripcion;
      set
      {
        if (!(this._kco_Descripcion != value))
          return;
        this.SendPropertyChanging();
        this._kco_Descripcion = value;
        this.SendPropertyChanged(nameof (kco_Descripcion));
      }
    }

    [Column(Storage = "_kco_costo", DbType = "Money")]
    public Decimal? kco_costo
    {
      get => this._kco_costo;
      set
      {
        Decimal? kcoCosto = this._kco_costo;
        Decimal? nullable = value;
        if ((kcoCosto.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (kcoCosto.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._kco_costo = value;
        this.SendPropertyChanged(nameof (kco_costo));
      }
    }

    [Column(Storage = "_kco_Disponible", DbType = "Int")]
    public int? kco_Disponible
    {
      get => this._kco_Disponible;
      set
      {
        int? kcoDisponible = this._kco_Disponible;
        int? nullable = value;
        if ((kcoDisponible.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (kcoDisponible.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._kco_Disponible = value;
        this.SendPropertyChanged(nameof (kco_Disponible));
      }
    }

    [Association(Name = "kco_KitCompra_nki_NovedadKit", Storage = "_nki_NovedadKits", ThisKey = "kco_Id", OtherKey = "kco_Id")]
    public EntitySet<nki_NovedadKit> nki_NovedadKits
    {
      get => this._nki_NovedadKits;
      set => this._nki_NovedadKits.Assign((IEnumerable<nki_NovedadKit>) value);
    }

    [Association(Name = "kco_KitCompra_ski_SolicitudKit", Storage = "_ski_SolicitudKits", ThisKey = "kco_Id", OtherKey = "kco_Id")]
    public EntitySet<ski_SolicitudKit> ski_SolicitudKits
    {
      get => this._ski_SolicitudKits;
      set => this._ski_SolicitudKits.Assign((IEnumerable<ski_SolicitudKit>) value);
    }

    [Association(Name = "kco_KitCompra_eki_EquipoKit", Storage = "_eki_EquipoKits", ThisKey = "kco_Id", OtherKey = "kco_Id")]
    public EntitySet<eki_EquipoKit> eki_EquipoKits
    {
      get => this._eki_EquipoKits;
      set => this._eki_EquipoKits.Assign((IEnumerable<eki_EquipoKit>) value);
    }

    [Association(Name = "lco_LicitacionCompra_kco_KitCompra", Storage = "_lco_LicitacionCompra", ThisKey = "lco_Id", OtherKey = "lco_Id", IsForeignKey = true)]
    public lco_LicitacionCompra lco_LicitacionCompra
    {
      get => this._lco_LicitacionCompra.Entity;
      set
      {
        lco_LicitacionCompra entity = this._lco_LicitacionCompra.Entity;
        if (entity == value && this._lco_LicitacionCompra.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._lco_LicitacionCompra.Entity = (lco_LicitacionCompra) null;
          entity.kco_KitCompras.Remove(this);
        }
        this._lco_LicitacionCompra.Entity = value;
        if (value != null)
        {
          value.kco_KitCompras.Add(this);
          this._lco_Id = value.lco_Id;
        }
        else
          this._lco_Id = 0;
        this.SendPropertyChanged(nameof (lco_LicitacionCompra));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, kco_KitCompra.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void attach_nki_NovedadKits(nki_NovedadKit entity)
    {
      this.SendPropertyChanging();
      entity.kco_KitCompra = this;
    }

    private void detach_nki_NovedadKits(nki_NovedadKit entity)
    {
      this.SendPropertyChanging();
      entity.kco_KitCompra = (kco_KitCompra) null;
    }

    private void attach_ski_SolicitudKits(ski_SolicitudKit entity)
    {
      this.SendPropertyChanging();
      entity.kco_KitCompra = this;
    }

    private void detach_ski_SolicitudKits(ski_SolicitudKit entity)
    {
      this.SendPropertyChanging();
      entity.kco_KitCompra = (kco_KitCompra) null;
    }

    private void attach_eki_EquipoKits(eki_EquipoKit entity)
    {
      this.SendPropertyChanging();
      entity.kco_KitCompra = this;
    }

    private void detach_eki_EquipoKits(eki_EquipoKit entity)
    {
      this.SendPropertyChanging();
      entity.kco_KitCompra = (kco_KitCompra) null;
    }
  }
}
