﻿// Decompiled with JetBrains decompiler
// Type: UTO.Comercializacion.ttt_TerceroTipoTercero
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO.Comercializacion
{
  [Table(Name = "Uto.ttt_TerceroTipoTercero")]
  public class ttt_TerceroTipoTercero : 
    IComparable<ttt_TerceroTipoTercero>,
    INotifyPropertyChanging,
    INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _ter_Id;
    private int _tti_Id;
    private EntityRef<ter_Tercero> _ter_Tercero;
    private EntityRef<tti_terceroTipo> _tti_terceroTipo;

    public override string ToString() => this._ter_Tercero.ToString();

    public int CompareTo(ttt_TerceroTipoTercero other) => this.ter_Tercero.CompareTo(other.ter_Tercero);

    public ttt_TerceroTipoTercero()
    {
      this._ter_Tercero = new EntityRef<ter_Tercero>();
      this._tti_terceroTipo = new EntityRef<tti_terceroTipo>();
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

    [Column(Storage = "_tti_Id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int tti_Id
    {
      get => this._tti_Id;
      set
      {
        if (this._tti_Id == value)
          return;
        if (this._tti_terceroTipo.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._tti_Id = value;
        this.SendPropertyChanged(nameof (tti_Id));
      }
    }

    [Association(Name = "ter_Tercero_ttt_TerceroTipoTercero", Storage = "_ter_Tercero", ThisKey = "ter_Id", OtherKey = "ter_Id", IsForeignKey = true)]
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
          entity.ttt_TerceroTipoTerceros.Remove(this);
        }
        this._ter_Tercero.Entity = value;
        if (value != null)
        {
          value.ttt_TerceroTipoTerceros.Add(this);
          this._ter_Id = value.ter_Id;
        }
        else
          this._ter_Id = 0;
        this.SendPropertyChanged(nameof (ter_Tercero));
      }
    }

    [Association(Name = "tti_terceroTipo_ttt_TerceroTipoTercero", Storage = "_tti_terceroTipo", ThisKey = "tti_Id", OtherKey = "tti_Id", IsForeignKey = true)]
    public tti_terceroTipo tti_terceroTipo
    {
      get => this._tti_terceroTipo.Entity;
      set
      {
        tti_terceroTipo entity = this._tti_terceroTipo.Entity;
        if (entity == value && this._tti_terceroTipo.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._tti_terceroTipo.Entity = (tti_terceroTipo) null;
          entity.ttt_TerceroTipoTerceros.Remove(this);
        }
        this._tti_terceroTipo.Entity = value;
        if (value != null)
        {
          value.ttt_TerceroTipoTerceros.Add(this);
          this._tti_Id = value.tti_Id;
        }
        else
          this._tti_Id = 0;
        this.SendPropertyChanged(nameof (tti_terceroTipo));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, ttt_TerceroTipoTercero.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
