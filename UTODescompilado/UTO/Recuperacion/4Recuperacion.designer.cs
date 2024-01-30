// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.nes_NovedadEstado
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO.Recuperacion
{
  [Table(Name = "Rrr.nes_NovedadEstado")]
  public class nes_NovedadEstado : 
    INotifyPropertyChanging,
    INotifyPropertyChanged,
    IComparable<nes_NovedadEstado>
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _nes_Id;
    private string _nes_Descripcion;
    private EntitySet<neq_NovedadEquipo> _neq_NovedadEquipos;

    public nes_NovedadEstado() => this._neq_NovedadEquipos = new EntitySet<neq_NovedadEquipo>(new Action<neq_NovedadEquipo>(this.attach_neq_NovedadEquipos), new Action<neq_NovedadEquipo>(this.detach_neq_NovedadEquipos));

    [Column(Storage = "_nes_Id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int nes_Id
    {
      get => this._nes_Id;
      set
      {
        if (this._nes_Id == value)
          return;
        this.SendPropertyChanging();
        this._nes_Id = value;
        this.SendPropertyChanged(nameof (nes_Id));
      }
    }

    [Column(Storage = "_nes_Descripcion", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string nes_Descripcion
    {
      get => this._nes_Descripcion;
      set
      {
        if (!(this._nes_Descripcion != value))
          return;
        this.SendPropertyChanging();
        this._nes_Descripcion = value;
        this.SendPropertyChanged(nameof (nes_Descripcion));
      }
    }

    [Association(Name = "nes_NovedadEstado_neq_NovedadEquipo", Storage = "_neq_NovedadEquipos", ThisKey = "nes_Id", OtherKey = "nes_Id")]
    public EntitySet<neq_NovedadEquipo> neq_NovedadEquipos
    {
      get => this._neq_NovedadEquipos;
      set => this._neq_NovedadEquipos.Assign((IEnumerable<neq_NovedadEquipo>) value);
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, nes_NovedadEstado.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void attach_neq_NovedadEquipos(neq_NovedadEquipo entity)
    {
      this.SendPropertyChanging();
      entity.nes_NovedadEstado = this;
    }

    private void detach_neq_NovedadEquipos(neq_NovedadEquipo entity)
    {
      this.SendPropertyChanging();
      entity.nes_NovedadEstado = (nes_NovedadEstado) null;
    }

    public int CompareTo(nes_NovedadEstado other) => this.nes_Descripcion.CompareTo(other.nes_Descripcion);
  }
}
