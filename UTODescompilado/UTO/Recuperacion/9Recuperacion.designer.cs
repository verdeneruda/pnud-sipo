// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.ski_SolicitudKit
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO.Recuperacion
{
  [Table(Name = "Rrr.ski_SolicitudKit")]
  public class ski_SolicitudKit : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _ski_Id;
    private int _seq_Id;
    private int _kco_Id;
    private int _ski_Cantidad;
    private EntityRef<kco_KitCompra> _kco_KitCompra;
    private EntityRef<seq_SolicitudEquipo> _seq_SolicitudEquipo;

    public ski_SolicitudKit()
    {
      this._kco_KitCompra = new EntityRef<kco_KitCompra>();
      this._seq_SolicitudEquipo = new EntityRef<seq_SolicitudEquipo>();
    }

    [Column(Storage = "_ski_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
    public int ski_Id
    {
      get => this._ski_Id;
      set
      {
        if (this._ski_Id == value)
          return;
        this.SendPropertyChanging();
        this._ski_Id = value;
        this.SendPropertyChanged(nameof (ski_Id));
      }
    }

    [Column(Storage = "_seq_Id", DbType = "Int NOT NULL")]
    public int seq_Id
    {
      get => this._seq_Id;
      set
      {
        if (this._seq_Id == value)
          return;
        if (this._seq_SolicitudEquipo.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._seq_Id = value;
        this.SendPropertyChanged(nameof (seq_Id));
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

    [Column(Storage = "_ski_Cantidad", DbType = "Int NOT NULL")]
    public int ski_Cantidad
    {
      get => this._ski_Cantidad;
      set
      {
        if (this._ski_Cantidad == value)
          return;
        this.SendPropertyChanging();
        this._ski_Cantidad = value;
        this.SendPropertyChanged(nameof (ski_Cantidad));
      }
    }

    [Association(Name = "kco_KitCompra_ski_SolicitudKit", Storage = "_kco_KitCompra", ThisKey = "kco_Id", OtherKey = "kco_Id", IsForeignKey = true)]
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
          entity.ski_SolicitudKits.Remove(this);
        }
        this._kco_KitCompra.Entity = value;
        if (value != null)
        {
          value.ski_SolicitudKits.Add(this);
          this._kco_Id = value.kco_Id;
        }
        else
          this._kco_Id = 0;
        this.SendPropertyChanged(nameof (kco_KitCompra));
      }
    }

    [Association(Name = "seq_SolicitudEquipo_ski_SolicitudKit", Storage = "_seq_SolicitudEquipo", ThisKey = "seq_Id", OtherKey = "seq_Id", IsForeignKey = true)]
    public seq_SolicitudEquipo seq_SolicitudEquipo
    {
      get => this._seq_SolicitudEquipo.Entity;
      set
      {
        seq_SolicitudEquipo entity = this._seq_SolicitudEquipo.Entity;
        if (entity == value && this._seq_SolicitudEquipo.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._seq_SolicitudEquipo.Entity = (seq_SolicitudEquipo) null;
          entity.ski_SolicitudKits.Remove(this);
        }
        this._seq_SolicitudEquipo.Entity = value;
        if (value != null)
        {
          value.ski_SolicitudKits.Add(this);
          this._seq_Id = value.seq_Id;
        }
        else
          this._seq_Id = 0;
        this.SendPropertyChanged(nameof (seq_SolicitudEquipo));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, ski_SolicitudKit.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
