// Decompiled with JetBrains decompiler
// Type: UTO.Proyectos.pti_ProyectoTipo
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO.Proyectos
{
  [Table(Name = "Pro.pti_ProyectoTipo")]
  public class pti_ProyectoTipo : 
    INotifyPropertyChanging,
    INotifyPropertyChanged,
    IComparable<pti_ProyectoTipo>
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _pti_Id;
    private string _pti_Descripcion;
    private EntitySet<pap_ProyectoAprobado> _pap_ProyectoAprobados;

    public pti_ProyectoTipo() => this._pap_ProyectoAprobados = new EntitySet<pap_ProyectoAprobado>(new Action<pap_ProyectoAprobado>(this.attach_pap_ProyectoAprobados), new Action<pap_ProyectoAprobado>(this.detach_pap_ProyectoAprobados));

    [Column(Storage = "_pti_Id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int pti_Id
    {
      get => this._pti_Id;
      set
      {
        if (this._pti_Id == value)
          return;
        this.SendPropertyChanging();
        this._pti_Id = value;
        this.SendPropertyChanged(nameof (pti_Id));
      }
    }

    [Column(Storage = "_pti_Descripcion", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string pti_Descripcion
    {
      get => this._pti_Descripcion;
      set
      {
        if (!(this._pti_Descripcion != value))
          return;
        this.SendPropertyChanging();
        this._pti_Descripcion = value;
        this.SendPropertyChanged(nameof (pti_Descripcion));
      }
    }

    [Association(Name = "pti_ProyectoTipo_pap_ProyectoAprobado", Storage = "_pap_ProyectoAprobados", ThisKey = "pti_Id", OtherKey = "pti_Id")]
    public EntitySet<pap_ProyectoAprobado> pap_ProyectoAprobados
    {
      get => this._pap_ProyectoAprobados;
      set => this._pap_ProyectoAprobados.Assign((IEnumerable<pap_ProyectoAprobado>) value);
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, pti_ProyectoTipo.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void attach_pap_ProyectoAprobados(pap_ProyectoAprobado entity)
    {
      this.SendPropertyChanging();
      entity.pti_ProyectoTipo = this;
    }

    private void detach_pap_ProyectoAprobados(pap_ProyectoAprobado entity)
    {
      this.SendPropertyChanging();
      entity.pti_ProyectoTipo = (pti_ProyectoTipo) null;
    }

    public int CompareTo(pti_ProyectoTipo other) => this.pti_Descripcion.CompareTo(other.pti_Descripcion);
  }
}
