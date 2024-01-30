// Decompiled with JetBrains decompiler
// Type: UTO.Comercializacion.dep_Departamento
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
  [Table(Name = "Uto.dep_Departamento")]
  public class dep_Departamento : 
    IComparable<dep_Departamento>,
    INotifyPropertyChanging,
    INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private string _dep_Id;
    private string _dep_Descripcion;
    private int _reg_Id;
    private EntitySet<mun_Municipio> _mun_Municipios;
    private EntitySet<cda_ComercializacionDato> _cda_ComercializacionDatos;
    private EntitySet<ter_Tercero> _ter_Terceros;

    public int CompareTo(dep_Departamento other) => this.dep_Descripcion.CompareTo(other.dep_Descripcion);

    public dep_Departamento()
    {
      this._mun_Municipios = new EntitySet<mun_Municipio>(new Action<mun_Municipio>(this.attach_mun_Municipios), new Action<mun_Municipio>(this.detach_mun_Municipios));
      this._cda_ComercializacionDatos = new EntitySet<cda_ComercializacionDato>(new Action<cda_ComercializacionDato>(this.attach_cda_ComercializacionDatos), new Action<cda_ComercializacionDato>(this.detach_cda_ComercializacionDatos));
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

    [Column(Storage = "_reg_Id")]
    public int reg_Id
    {
      get => this._reg_Id;
      set
      {
        if (this._reg_Id == value)
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

    [Association(Name = "dep_Departamento_cda_ComercializacionDato", Storage = "_cda_ComercializacionDatos", ThisKey = "dep_Id", OtherKey = "dep_Id")]
    public EntitySet<cda_ComercializacionDato> cda_ComercializacionDatos
    {
      get => this._cda_ComercializacionDatos;
      set => this._cda_ComercializacionDatos.Assign((IEnumerable<cda_ComercializacionDato>) value);
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

    private void attach_cda_ComercializacionDatos(cda_ComercializacionDato entity)
    {
      this.SendPropertyChanging();
      entity.dep_Departamento = this;
    }

    private void detach_cda_ComercializacionDatos(cda_ComercializacionDato entity)
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
  }
}
