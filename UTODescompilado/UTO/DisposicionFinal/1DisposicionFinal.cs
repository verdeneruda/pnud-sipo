// Decompiled with JetBrains decompiler
// Type: UTO.DisposicionFinal.psu_PresentacionSustancia
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
  [Table(Name = "Uto.psu_PresentacionSustancia")]
  public class psu_PresentacionSustancia : 
    INotifyPropertyChanging,
    INotifyPropertyChanged,
    IComparable<psu_PresentacionSustancia>
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _psu_Id;
    private string _psu_Descripcion;
    private EntitySet<ddd_DisposicionDatosDetalle> _ddd_DisposicionDatosDetalles;

    public override string ToString() => this.psu_Descripcion;

    public psu_PresentacionSustancia() => this._ddd_DisposicionDatosDetalles = new EntitySet<ddd_DisposicionDatosDetalle>(new Action<ddd_DisposicionDatosDetalle>(this.attach_ddd_DisposicionDatosDetalles), new Action<ddd_DisposicionDatosDetalle>(this.detach_ddd_DisposicionDatosDetalles));

    [Column(Storage = "_psu_Id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int psu_Id
    {
      get => this._psu_Id;
      set
      {
        if (this._psu_Id == value)
          return;
        this.SendPropertyChanging();
        this._psu_Id = value;
        this.SendPropertyChanged(nameof (psu_Id));
      }
    }

    [Column(Storage = "_psu_Descripcion", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string psu_Descripcion
    {
      get => this._psu_Descripcion;
      set
      {
        if (!(this._psu_Descripcion != value))
          return;
        this.SendPropertyChanging();
        this._psu_Descripcion = value;
        this.SendPropertyChanged(nameof (psu_Descripcion));
      }
    }

    [Association(Name = "psu_PresentacionSustancia_ddd_DisposicionDatosDetalle", Storage = "_ddd_DisposicionDatosDetalles", ThisKey = "psu_Id", OtherKey = "psu_Id")]
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
      this.PropertyChanging((object) this, psu_PresentacionSustancia.emptyChangingEventArgs);
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
      entity.psu_PresentacionSustancia = this;
    }

    private void detach_ddd_DisposicionDatosDetalles(ddd_DisposicionDatosDetalle entity)
    {
      this.SendPropertyChanging();
      entity.psu_PresentacionSustancia = (psu_PresentacionSustancia) null;
    }

    public int CompareTo(psu_PresentacionSustancia other) => this.psu_Descripcion.CompareTo(other.psu_Descripcion);
  }
}
