// Decompiled with JetBrains decompiler
// Type: UTO.Proyectos.pyg_ProyectoGrupo
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
  [Table(Name = "Pro.pyg_ProyectoGrupo")]
  public class pyg_ProyectoGrupo : 
    INotifyPropertyChanging,
    INotifyPropertyChanged,
    IComparable<pyg_ProyectoGrupo>
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _pyg_Id;
    private string _pyg_Descripcion;
    private EntitySet<pap_ProyectoAprobado> _pap_ProyectoAprobados;

    public pyg_ProyectoGrupo() => this._pap_ProyectoAprobados = new EntitySet<pap_ProyectoAprobado>(new Action<pap_ProyectoAprobado>(this.attach_pap_ProyectoAprobados), new Action<pap_ProyectoAprobado>(this.detach_pap_ProyectoAprobados));

    [Column(Storage = "_pyg_Id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int pyg_Id
    {
      get => this._pyg_Id;
      set
      {
        if (this._pyg_Id == value)
          return;
        this.SendPropertyChanging();
        this._pyg_Id = value;
        this.SendPropertyChanged(nameof (pyg_Id));
      }
    }

    [Column(Storage = "_pyg_Descripcion", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string pyg_Descripcion
    {
      get => this._pyg_Descripcion;
      set
      {
        if (!(this._pyg_Descripcion != value))
          return;
        this.SendPropertyChanging();
        this._pyg_Descripcion = value;
        this.SendPropertyChanged(nameof (pyg_Descripcion));
      }
    }

    [Association(Name = "pyg_ProyectoGrupo_pap_ProyectoAprobado", Storage = "_pap_ProyectoAprobados", ThisKey = "pyg_Id", OtherKey = "pyg_Id")]
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
      this.PropertyChanging((object) this, pyg_ProyectoGrupo.emptyChangingEventArgs);
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
      entity.pyg_ProyectoGrupo = this;
    }

    private void detach_pap_ProyectoAprobados(pap_ProyectoAprobado entity)
    {
      this.SendPropertyChanging();
      entity.pyg_ProyectoGrupo = (pyg_ProyectoGrupo) null;
    }

    public int CompareTo(pyg_ProyectoGrupo other) => this.pyg_Descripcion.CompareTo(other.pyg_Descripcion);
  }
}
