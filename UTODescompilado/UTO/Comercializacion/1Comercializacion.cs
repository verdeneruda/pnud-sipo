// Decompiled with JetBrains decompiler
// Type: UTO.Comercializacion.psu_PresentacionSustancia
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
  [Table(Name = "Uto.psu_PresentacionSustancia")]
  public class psu_PresentacionSustancia : 
    IComparable<psu_PresentacionSustancia>,
    INotifyPropertyChanging,
    INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _psu_Id;
    private string _psu_Descripcion;
    private EntitySet<cdd_ComercializacionDatosDetalle> _cdd_ComercializacionDatosDetalles;

    public override string ToString() => this.psu_Descripcion;

    public int CompareTo(psu_PresentacionSustancia other) => this.psu_Descripcion.CompareTo(other.psu_Descripcion);

    public psu_PresentacionSustancia() => this._cdd_ComercializacionDatosDetalles = new EntitySet<cdd_ComercializacionDatosDetalle>(new Action<cdd_ComercializacionDatosDetalle>(this.attach_cdd_ComercializacionDatosDetalles), new Action<cdd_ComercializacionDatosDetalle>(this.detach_cdd_ComercializacionDatosDetalles));

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

    [Association(Name = "psu_PresentacionSustancia_cdd_ComercializacionDatosDetalle", Storage = "_cdd_ComercializacionDatosDetalles", ThisKey = "psu_Id", OtherKey = "psu_Id")]
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
      this.PropertyChanging((object) this, psu_PresentacionSustancia.emptyChangingEventArgs);
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
      entity.psu_PresentacionSustancia = this;
    }

    private void detach_cdd_ComercializacionDatosDetalles(cdd_ComercializacionDatosDetalle entity)
    {
      this.SendPropertyChanging();
      entity.psu_PresentacionSustancia = (psu_PresentacionSustancia) null;
    }
  }
}
