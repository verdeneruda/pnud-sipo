// Decompiled with JetBrains decompiler
// Type: UTO.Proyectos.pse_ProyectoSector
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
  [Table(Name = "Pro.pse_ProyectoSector")]
  public class pse_ProyectoSector : 
    INotifyPropertyChanging,
    INotifyPropertyChanged,
    IComparable<pse_ProyectoSector>
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _pse_Id;
    private string _pse_Descripcion;
    private EntitySet<pap_ProyectoAprobado> _pap_ProyectoAprobados;

    public pse_ProyectoSector() => this._pap_ProyectoAprobados = new EntitySet<pap_ProyectoAprobado>(new Action<pap_ProyectoAprobado>(this.attach_pap_ProyectoAprobados), new Action<pap_ProyectoAprobado>(this.detach_pap_ProyectoAprobados));

    [Column(Storage = "_pse_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
    public int pse_Id
    {
      get => this._pse_Id;
      set
      {
        if (this._pse_Id == value)
          return;
        this.SendPropertyChanging();
        this._pse_Id = value;
        this.SendPropertyChanged(nameof (pse_Id));
      }
    }

    [Column(Storage = "_pse_Descripcion", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string pse_Descripcion
    {
      get => this._pse_Descripcion;
      set
      {
        if (!(this._pse_Descripcion != value))
          return;
        this.SendPropertyChanging();
        this._pse_Descripcion = value;
        this.SendPropertyChanged(nameof (pse_Descripcion));
      }
    }

    [Association(Name = "pse_ProyectoSector_pap_ProyectoAprobado", Storage = "_pap_ProyectoAprobados", ThisKey = "pse_Id", OtherKey = "pse_Id")]
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
      this.PropertyChanging((object) this, pse_ProyectoSector.emptyChangingEventArgs);
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
      entity.pse_ProyectoSector = this;
    }

    private void detach_pap_ProyectoAprobados(pap_ProyectoAprobado entity)
    {
      this.SendPropertyChanging();
      entity.pse_ProyectoSector = (pse_ProyectoSector) null;
    }

    public int CompareTo(pse_ProyectoSector other) => this.pse_Descripcion.CompareTo(other.pse_Descripcion);
  }
}
