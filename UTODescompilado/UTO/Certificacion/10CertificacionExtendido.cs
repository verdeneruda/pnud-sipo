// Decompiled with JetBrains decompiler
// Type: UTO.Certificacion.ati_ActividadTipo
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
  [Table(Name = "Cer.ati_ActividadTipo")]
  public class ati_ActividadTipo : 
    IComparable<ati_ActividadTipo>,
    INotifyPropertyChanging,
    INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _ati_Id;
    private string _ati_Descripcion;
    private EntitySet<act_Actividad> _act_Actividads;

    public int CompareTo(ati_ActividadTipo other) => this.ati_Descripcion.CompareTo(other.ati_Descripcion);

    public ati_ActividadTipo() => this._act_Actividads = new EntitySet<act_Actividad>(new Action<act_Actividad>(this.attach_act_Actividads), new Action<act_Actividad>(this.detach_act_Actividads));

    [Column(Storage = "_ati_Id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int ati_Id
    {
      get => this._ati_Id;
      set
      {
        if (this._ati_Id == value)
          return;
        this.SendPropertyChanging();
        this._ati_Id = value;
        this.SendPropertyChanged(nameof (ati_Id));
      }
    }

    [Column(Storage = "_ati_Descripcion", DbType = "VarChar(75) NOT NULL", CanBeNull = false)]
    public string ati_Descripcion
    {
      get => this._ati_Descripcion;
      set
      {
        if (!(this._ati_Descripcion != value))
          return;
        this.SendPropertyChanging();
        this._ati_Descripcion = value;
        this.SendPropertyChanged(nameof (ati_Descripcion));
      }
    }

    [Association(Name = "ati_ActividadTipo_act_Actividad", Storage = "_act_Actividads", ThisKey = "ati_Id", OtherKey = "ati_Id")]
    public EntitySet<act_Actividad> act_Actividads
    {
      get => this._act_Actividads;
      set => this._act_Actividads.Assign((IEnumerable<act_Actividad>) value);
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, ati_ActividadTipo.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void attach_act_Actividads(act_Actividad entity)
    {
      this.SendPropertyChanging();
      entity.ati_ActividadTipo = this;
    }

    private void detach_act_Actividads(act_Actividad entity)
    {
      this.SendPropertyChanging();
      entity.ati_ActividadTipo = (ati_ActividadTipo) null;
    }
  }
}
