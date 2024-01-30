// Decompiled with JetBrains decompiler
// Type: UTO.Certificacion.tca_TerceroCategoria
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO.Certificacion
{
  [Table(Name = "Cer.tca_TerceroCategoria")]
  public class tca_TerceroCategoria : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _ter_Id;
    private int _cat_Id;
    private DateTime _tca_Fecha;
    private EntityRef<cat_Categoria> _cat_Categoria;
    private EntityRef<ter_Tercero> _ter_Tercero;

    public tca_TerceroCategoria()
    {
      this._cat_Categoria = new EntityRef<cat_Categoria>();
      this._ter_Tercero = new EntityRef<ter_Tercero>();
    }

    [Column(Storage = "_ter_Id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
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

    [Column(Storage = "_cat_Id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int cat_Id
    {
      get => this._cat_Id;
      set
      {
        if (this._cat_Id == value)
          return;
        if (this._cat_Categoria.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._cat_Id = value;
        this.SendPropertyChanged(nameof (cat_Id));
      }
    }

    [Column(Storage = "_tca_Fecha", DbType = "DateTime NOT NULL")]
    public DateTime tca_Fecha
    {
      get => this._tca_Fecha;
      set
      {
        if (!(this._tca_Fecha != value))
          return;
        this.SendPropertyChanging();
        this._tca_Fecha = value;
        this.SendPropertyChanged(nameof (tca_Fecha));
      }
    }

    [Association(Name = "cat_Categoria_tca_TerceroCategoria", Storage = "_cat_Categoria", ThisKey = "cat_Id", OtherKey = "cat_Id", IsForeignKey = true)]
    public cat_Categoria cat_Categoria
    {
      get => this._cat_Categoria.Entity;
      set
      {
        cat_Categoria entity = this._cat_Categoria.Entity;
        if (entity == value && this._cat_Categoria.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._cat_Categoria.Entity = (cat_Categoria) null;
          entity.tca_TerceroCategorias.Remove(this);
        }
        this._cat_Categoria.Entity = value;
        if (value != null)
        {
          value.tca_TerceroCategorias.Add(this);
          this._cat_Id = value.cat_Id;
        }
        else
          this._cat_Id = 0;
        this.SendPropertyChanged(nameof (cat_Categoria));
      }
    }

    [Association(Name = "ter_Tercero_tca_TerceroCategoria", Storage = "_ter_Tercero", ThisKey = "ter_Id", OtherKey = "ter_Id", IsForeignKey = true)]
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
          entity.tca_TerceroCategorias.Remove(this);
        }
        this._ter_Tercero.Entity = value;
        if (value != null)
        {
          value.tca_TerceroCategorias.Add(this);
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
      this.PropertyChanging((object) this, tca_TerceroCategoria.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
