// Decompiled with JetBrains decompiler
// Type: UTO.Comercializacion.tti_terceroTipo
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
  [Table(Name = "Uto.tti_terceroTipo")]
  public class tti_terceroTipo : 
    IComparable<tti_terceroTipo>,
    INotifyPropertyChanging,
    INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _tti_Id;
    private string _tti_Descripcion;
    private EntitySet<ttt_TerceroTipoTercero> _ttt_TerceroTipoTerceros;

    public int CompareTo(tti_terceroTipo other) => this.tti_Descripcion.CompareTo(other.tti_Descripcion);

    public tti_terceroTipo() => this._ttt_TerceroTipoTerceros = new EntitySet<ttt_TerceroTipoTercero>(new Action<ttt_TerceroTipoTercero>(this.attach_ttt_TerceroTipoTerceros), new Action<ttt_TerceroTipoTercero>(this.detach_ttt_TerceroTipoTerceros));

    [Column(Storage = "_tti_Id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int tti_Id
    {
      get => this._tti_Id;
      set
      {
        if (this._tti_Id == value)
          return;
        this.SendPropertyChanging();
        this._tti_Id = value;
        this.SendPropertyChanged(nameof (tti_Id));
      }
    }

    [Column(Storage = "_tti_Descripcion", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string tti_Descripcion
    {
      get => this._tti_Descripcion;
      set
      {
        if (!(this._tti_Descripcion != value))
          return;
        this.SendPropertyChanging();
        this._tti_Descripcion = value;
        this.SendPropertyChanged(nameof (tti_Descripcion));
      }
    }

    [Association(Name = "tti_terceroTipo_ttt_TerceroTipoTercero", Storage = "_ttt_TerceroTipoTerceros", ThisKey = "tti_Id", OtherKey = "tti_Id")]
    public EntitySet<ttt_TerceroTipoTercero> ttt_TerceroTipoTerceros
    {
      get => this._ttt_TerceroTipoTerceros;
      set => this._ttt_TerceroTipoTerceros.Assign((IEnumerable<ttt_TerceroTipoTercero>) value);
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, tti_terceroTipo.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void attach_ttt_TerceroTipoTerceros(ttt_TerceroTipoTercero entity)
    {
      this.SendPropertyChanging();
      entity.tti_terceroTipo = this;
    }

    private void detach_ttt_TerceroTipoTerceros(ttt_TerceroTipoTercero entity)
    {
      this.SendPropertyChanging();
      entity.tti_terceroTipo = (tti_terceroTipo) null;
    }
  }
}
