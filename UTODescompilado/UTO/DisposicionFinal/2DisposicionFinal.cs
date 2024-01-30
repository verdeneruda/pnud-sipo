// Decompiled with JetBrains decompiler
// Type: UTO.DisposicionFinal.des_DisposicionEstado
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO.DisposicionFinal
{
  [Table(Name = "Dis.des_DisposicionEstado")]
  public class des_DisposicionEstado : 
    INotifyPropertyChanging,
    INotifyPropertyChanged,
    IComparable<des_DisposicionEstado>
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _des_Id;
    private string _des_Descripcion;
    private EntitySet<ddd_DisposicionDatosDetalle> _ddd_DisposicionDatosDetalles;

    public override string ToString() => this.des_Descripcion;

    public des_DisposicionEstado() => this._ddd_DisposicionDatosDetalles = new EntitySet<ddd_DisposicionDatosDetalle>(new Action<ddd_DisposicionDatosDetalle>(this.attach_ddd_DisposicionDatosDetalles), new Action<ddd_DisposicionDatosDetalle>(this.detach_ddd_DisposicionDatosDetalles));

    [Column(Storage = "_des_Id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int des_Id
    {
      get => this._des_Id;
      set
      {
        if (this._des_Id == value)
          return;
        this.SendPropertyChanging();
        this._des_Id = value;
        this.SendPropertyChanged(nameof (des_Id));
      }
    }

    [Column(Storage = "_des_Descripcion", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string des_Descripcion
    {
      get => this._des_Descripcion;
      set
      {
        if (!(this._des_Descripcion != value))
          return;
        this.SendPropertyChanging();
        this._des_Descripcion = value;
        this.SendPropertyChanged(nameof (des_Descripcion));
      }
    }

    [Association(Name = "des_DisposicionEstado_ddd_DisposicionDatosDetalle", Storage = "_ddd_DisposicionDatosDetalles", ThisKey = "des_Id", OtherKey = "des_Id")]
    public EntitySet<ddd_DisposicionDatosDetalle> ddd_DisposicionDatosDetalles
    {
      get => this._ddd_DisposicionDatosDetalles;
      set => this._ddd_DisposicionDatosDetalles.Assign((IEnumerable<ddd_DisposicionDatosDetalle>) value);
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, des_DisposicionEstado.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void attach_ddd_DisposicionDatosDetalles(ddd_DisposicionDatosDetalle entity)
    {
      this.SendPropertyChanging();
      entity.des_DisposicionEstado = this;
    }

    private void detach_ddd_DisposicionDatosDetalles(ddd_DisposicionDatosDetalle entity)
    {
      this.SendPropertyChanging();
      entity.des_DisposicionEstado = (des_DisposicionEstado) null;
    }

    public int CompareTo(des_DisposicionEstado other) => this.des_Descripcion.CompareTo(other.des_Descripcion);
  }
}
