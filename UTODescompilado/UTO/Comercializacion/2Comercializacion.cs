// Decompiled with JetBrains decompiler
// Type: UTO.Comercializacion.mar_Marca
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO.Comercializacion
{
  [Table(Name = "Uto.mar_Marca")]
  public class mar_Marca : IComparable<mar_Marca>, INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _mar_Id;
    private string _mar_Descripcion;
    private EntitySet<cdd_ComercializacionDatosDetalle> _cdd_ComercializacionDatosDetalles;

    public override string ToString() => this.mar_Descripcion;

    public int CompareTo(mar_Marca other) => this.mar_Descripcion.CompareTo(other.mar_Descripcion);

    public mar_Marca() => this._cdd_ComercializacionDatosDetalles = new EntitySet<cdd_ComercializacionDatosDetalle>(new Action<cdd_ComercializacionDatosDetalle>(this.attach_cdd_ComercializacionDatosDetalles), new Action<cdd_ComercializacionDatosDetalle>(this.detach_cdd_ComercializacionDatosDetalles));

    [Column(Storage = "_mar_Id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int mar_Id
    {
      get => this._mar_Id;
      set
      {
        if (this._mar_Id == value)
          return;
        this.SendPropertyChanging();
        this._mar_Id = value;
        this.SendPropertyChanged(nameof (mar_Id));
      }
    }

    [Column(Storage = "_mar_Descripcion", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string mar_Descripcion
    {
      get => this._mar_Descripcion;
      set
      {
        if (!(this._mar_Descripcion != value))
          return;
        this.SendPropertyChanging();
        this._mar_Descripcion = value;
        this.SendPropertyChanged(nameof (mar_Descripcion));
      }
    }

    [Association(Name = "mar_Marca_cdd_ComercializacionDatosDetalle", Storage = "_cdd_ComercializacionDatosDetalles", ThisKey = "mar_Id", OtherKey = "mar_Id")]
    public EntitySet<cdd_ComercializacionDatosDetalle> cdd_ComercializacionDatosDetalles
    {
      get => this._cdd_ComercializacionDatosDetalles;
      set => this._cdd_ComercializacionDatosDetalles.Assign((IEnumerable<cdd_ComercializacionDatosDetalle>) value);
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, mar_Marca.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void attach_cdd_ComercializacionDatosDetalles(cdd_ComercializacionDatosDetalle entity)
    {
      this.SendPropertyChanging();
      entity.mar_Marca = this;
    }

    private void detach_cdd_ComercializacionDatosDetalles(cdd_ComercializacionDatosDetalle entity)
    {
      this.SendPropertyChanging();
      entity.mar_Marca = (mar_Marca) null;
    }
  }
}
