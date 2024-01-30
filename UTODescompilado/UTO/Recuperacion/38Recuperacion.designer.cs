// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.dep_Departamento
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
  [Table(Name = "Uto.dep_Departamento")]
  public class dep_Departamento : 
    INotifyPropertyChanging,
    INotifyPropertyChanged,
    IComparable<dep_Departamento>
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private string _dep_Id;
    private string _dep_Descripcion;
    private int? _reg_Id;
    private EntitySet<mun_Municipio> _mun_Municipios;
    private EntitySet<pap_ProyectoAprobado> _pap_ProyectoAprobados;
    private EntitySet<neq_NovedadEquipo> _neq_NovedadEquipos;
    private EntitySet<ter_Tercero> _ter_Terceros;

    public dep_Departamento()
    {
      this._mun_Municipios = new EntitySet<mun_Municipio>(new Action<mun_Municipio>(this.attach_mun_Municipios), new Action<mun_Municipio>(this.detach_mun_Municipios));
      this._pap_ProyectoAprobados = new EntitySet<pap_ProyectoAprobado>(new Action<pap_ProyectoAprobado>(this.attach_pap_ProyectoAprobados), new Action<pap_ProyectoAprobado>(this.detach_pap_ProyectoAprobados));
      this._neq_NovedadEquipos = new EntitySet<neq_NovedadEquipo>(new Action<neq_NovedadEquipo>(this.attach_neq_NovedadEquipos), new Action<neq_NovedadEquipo>(this.detach_neq_NovedadEquipos));
      this._ter_Terceros = new EntitySet<ter_Tercero>(new Action<ter_Tercero>(this.attach_ter_Terceros), new Action<ter_Tercero>(this.detach_ter_Terceros));
    }

    [Column(Storage = "_dep_Id", DbType = "VarChar(2) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
    public string dep_Id
    {
      get => this._dep_Id;
      set
      {
        if (!(this._dep_Id != value))
          return;
        this.SendPropertyChanging();
        this._dep_Id = value;
        this.SendPropertyChanged(nameof (dep_Id));
      }
    }

    [Column(Storage = "_dep_Descripcion", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string dep_Descripcion
    {
      get => this._dep_Descripcion;
      set
      {
        if (!(this._dep_Descripcion != value))
          return;
        this.SendPropertyChanging();
        this._dep_Descripcion = value;
        this.SendPropertyChanged(nameof (dep_Descripcion));
      }
    }

    [Column(Storage = "_reg_Id", DbType = "Int")]
    public int? reg_Id
    {
      get => this._reg_Id;
      set
      {
        int? regId = this._reg_Id;
        int? nullable = value;
        if ((regId.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (regId.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._reg_Id = value;
        this.SendPropertyChanged(nameof (reg_Id));
      }
    }

    [Association(Name = "dep_Departamento_mun_Municipio", Storage = "_mun_Municipios", ThisKey = "dep_Id", OtherKey = "dep_Id")]
    public EntitySet<mun_Municipio> mun_Municipios
    {
      get => this._mun_Municipios;
      set => this._mun_Municipios.Assign((IEnumerable<mun_Municipio>) value);
    }

    [Association(Name = "dep_Departamento_pap_ProyectoAprobado", Storage = "_pap_ProyectoAprobados", ThisKey = "dep_Id", OtherKey = "dep_Id")]
    public EntitySet<pap_ProyectoAprobado> pap_ProyectoAprobados
    {
      get => this._pap_ProyectoAprobados;
      set => this._pap_ProyectoAprobados.Assign((IEnumerable<pap_ProyectoAprobado>) value);
    }

    [Association(Name = "dep_Departamento_neq_NovedadEquipo", Storage = "_neq_NovedadEquipos", ThisKey = "dep_Id", OtherKey = "dep_Id")]
    public EntitySet<neq_NovedadEquipo> neq_NovedadEquipos
    {
      get => this._neq_NovedadEquipos;
      set => this._neq_NovedadEquipos.Assign((IEnumerable<neq_NovedadEquipo>) value);
    }

    [Association(Name = "dep_Departamento_ter_Tercero", Storage = "_ter_Terceros", ThisKey = "dep_Id", OtherKey = "dep_Id")]
    public EntitySet<ter_Tercero> ter_Terceros
    {
      get => this._ter_Terceros;
      set => this._ter_Terceros.Assign((IEnumerable<ter_Tercero>) value);
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, dep_Departamento.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void attach_mun_Municipios(mun_Municipio entity)
    {
      this.SendPropertyChanging();
      entity.dep_Departamento = this;
    }

    private void detach_mun_Municipios(mun_Municipio entity)
    {
      this.SendPropertyChanging();
      entity.dep_Departamento = (dep_Departamento) null;
    }

    private void attach_pap_ProyectoAprobados(pap_ProyectoAprobado entity)
    {
      this.SendPropertyChanging();
      entity.dep_Departamento = this;
    }

    private void detach_pap_ProyectoAprobados(pap_ProyectoAprobado entity)
    {
      this.SendPropertyChanging();
      entity.dep_Departamento = (dep_Departamento) null;
    }

    private void attach_neq_NovedadEquipos(neq_NovedadEquipo entity)
    {
      this.SendPropertyChanging();
      entity.dep_Departamento = this;
    }

    private void detach_neq_NovedadEquipos(neq_NovedadEquipo entity)
    {
      this.SendPropertyChanging();
      entity.dep_Departamento = (dep_Departamento) null;
    }

    private void attach_ter_Terceros(ter_Tercero entity)
    {
      this.SendPropertyChanging();
      entity.dep_Departamento = this;
    }

    private void detach_ter_Terceros(ter_Tercero entity)
    {
      this.SendPropertyChanging();
      entity.dep_Departamento = (dep_Departamento) null;
    }

    public int CompareTo(dep_Departamento other) => this.dep_Descripcion.CompareTo(other.dep_Descripcion);
  }
}
