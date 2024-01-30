// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.nti_NovedadTipo
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
  [Table(Name = "Rrr.nti_NovedadTipo")]
  public class nti_NovedadTipo : 
    INotifyPropertyChanging,
    INotifyPropertyChanged,
    IComparable<nti_NovedadTipo>
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _nti_Id;
    private string _nti_Descripcion;
    private EntitySet<neq_NovedadEquipo> _neq_NovedadEquipos;

    public nti_NovedadTipo() => this._neq_NovedadEquipos = new EntitySet<neq_NovedadEquipo>(new Action<neq_NovedadEquipo>(this.attach_neq_NovedadEquipos), new Action<neq_NovedadEquipo>(this.detach_neq_NovedadEquipos));

    [Column(Storage = "_nti_Id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int nti_Id
    {
      get => this._nti_Id;
      set
      {
        if (this._nti_Id == value)
          return;
        this.SendPropertyChanging();
        this._nti_Id = value;
        this.SendPropertyChanged(nameof (nti_Id));
      }
    }

    [Column(Storage = "_nti_Descripcion", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string nti_Descripcion
    {
      get => this._nti_Descripcion;
      set
      {
        if (!(this._nti_Descripcion != value))
          return;
        this.SendPropertyChanging();
        this._nti_Descripcion = value;
        this.SendPropertyChanged(nameof (nti_Descripcion));
      }
    }

    [Association(Name = "nti_NovedadTipo_neq_NovedadEquipo", Storage = "_neq_NovedadEquipos", ThisKey = "nti_Id", OtherKey = "nti_Id")]
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
      this.PropertyChanging((object) this, nti_NovedadTipo.emptyChangingEventArgs);
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
      entity.nti_NovedadTipo = this;
    }

    private void detach_neq_NovedadEquipos(neq_NovedadEquipo entity)
    {
      this.SendPropertyChanging();
      entity.nti_NovedadTipo = (nti_NovedadTipo) null;
    }

    public int CompareTo(nti_NovedadTipo other) => this.nti_Descripcion.CompareTo(other.nti_Descripcion);
  }
}
