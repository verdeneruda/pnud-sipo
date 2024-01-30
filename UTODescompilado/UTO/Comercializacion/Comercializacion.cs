// Decompiled with JetBrains decompiler
// Type: UTO.Comercializacion.sus_Sustancia
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
  [Table(Name = "Uto.sus_Sustancia")]
  public class sus_Sustancia : 
    IComparable<sus_Sustancia>,
    INotifyPropertyChanging,
    INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _sus_Id;
    private string _sus_Arancel;
    private string _sus_Descripcion;
    private EntitySet<cdd_ComercializacionDatosDetalle> _cdd_ComercializacionDatosDetalles;

    public override string ToString() => this.sus_Descripcion;

    public int CompareTo(sus_Sustancia other) => this.sus_Descripcion.CompareTo(other.sus_Descripcion);

    public sus_Sustancia() => this._cdd_ComercializacionDatosDetalles = new EntitySet<cdd_ComercializacionDatosDetalle>(new Action<cdd_ComercializacionDatosDetalle>(this.attach_cdd_ComercializacionDatosDetalles), new Action<cdd_ComercializacionDatosDetalle>(this.detach_cdd_ComercializacionDatosDetalles));

    [Column(Storage = "_sus_Id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int sus_Id
    {
      get => this._sus_Id;
      set
      {
        if (this._sus_Id == value)
          return;
        this.SendPropertyChanging();
        this._sus_Id = value;
        this.SendPropertyChanged(nameof (sus_Id));
      }
    }

    [Column(Storage = "_sus_Arancel", DbType = "VarChar(50)")]
    public string sus_Arancel
    {
      get => this._sus_Arancel;
      set
      {
        if (!(this._sus_Arancel != value))
          return;
        this.SendPropertyChanging();
        this._sus_Arancel = value;
        this.SendPropertyChanged(nameof (sus_Arancel));
      }
    }

    [Column(Storage = "_sus_Descripcion", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string sus_Descripcion
    {
      get => this._sus_Descripcion;
      set
      {
        if (!(this._sus_Descripcion != value))
          return;
        this.SendPropertyChanging();
        this._sus_Descripcion = value;
        this.SendPropertyChanged(nameof (sus_Descripcion));
      }
    }

    [Association(Name = "sus_Sustancia_cdd_ComercializacionDatosDetalle", Storage = "_cdd_ComercializacionDatosDetalles", ThisKey = "sus_Id", OtherKey = "sus_Id")]
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
      this.PropertyChanging((object) this, sus_Sustancia.emptyChangingEventArgs);
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
      entity.sus_Sustancia = this;
    }

    private void detach_cdd_ComercializacionDatosDetalles(cdd_ComercializacionDatosDetalle entity)
    {
      this.SendPropertyChanging();
      entity.sus_Sustancia = (sus_Sustancia) null;
    }
  }
}
