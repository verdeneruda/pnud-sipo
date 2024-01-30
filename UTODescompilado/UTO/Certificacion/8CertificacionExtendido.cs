// Decompiled with JetBrains decompiler
// Type: UTO.Certificacion.cat_Categoria
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO.Certificacion
{
  [Table(Name = "Cer.cat_Categoria")]
  public class cat_Categoria : 
    IComparable<cat_Categoria>,
    INotifyPropertyChanging,
    INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _cat_Id;
    private string _cat_Descripcion;
    private char _cat_Tipo;
    private EntitySet<tca_TerceroCategoria> _tca_TerceroCategorias;

    public int CompareTo(cat_Categoria other) => this.cat_Descripcion.CompareTo(other.cat_Descripcion);

    public cat_Categoria() => this._tca_TerceroCategorias = new EntitySet<tca_TerceroCategoria>(new Action<tca_TerceroCategoria>(this.attach_tca_TerceroCategorias), new Action<tca_TerceroCategoria>(this.detach_tca_TerceroCategorias));

    [Column(Storage = "_cat_Id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int cat_Id
    {
      get => this._cat_Id;
      set
      {
        if (this._cat_Id == value)
          return;
        this.SendPropertyChanging();
        this._cat_Id = value;
        this.SendPropertyChanged(nameof (cat_Id));
      }
    }

    [Column(Storage = "_cat_Descripcion", DbType = "VarChar(75) NOT NULL", CanBeNull = false)]
    public string cat_Descripcion
    {
      get => this._cat_Descripcion;
      set
      {
        if (!(this._cat_Descripcion != value))
          return;
        this.SendPropertyChanging();
        this._cat_Descripcion = value;
        this.SendPropertyChanged(nameof (cat_Descripcion));
      }
    }

    [Column(Storage = "_cat_Tipo", DbType = "Char(1) NOT NULL")]
    public char cat_Tipo
    {
      get => this._cat_Tipo;
      set
      {
        if ((int) this._cat_Tipo == (int) value)
          return;
        this.SendPropertyChanging();
        this._cat_Tipo = value;
        this.SendPropertyChanged(nameof (cat_Tipo));
      }
    }

    [Association(Name = "cat_Categoria_tca_TerceroCategoria", Storage = "_tca_TerceroCategorias", ThisKey = "cat_Id", OtherKey = "cat_Id")]
    public EntitySet<tca_TerceroCategoria> tca_TerceroCategorias
    {
      get => this._tca_TerceroCategorias;
      set => this._tca_TerceroCategorias.Assign((IEnumerable<tca_TerceroCategoria>) value);
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, cat_Categoria.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void attach_tca_TerceroCategorias(tca_TerceroCategoria entity)
    {
      this.SendPropertyChanging();
      entity.cat_Categoria = this;
    }

    private void detach_tca_TerceroCategorias(tca_TerceroCategoria entity)
    {
      this.SendPropertyChanging();
      entity.cat_Categoria = (cat_Categoria) null;
    }
  }
}
