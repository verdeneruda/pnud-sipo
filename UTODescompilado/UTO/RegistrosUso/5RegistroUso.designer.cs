// Decompiled with JetBrains decompiler
// Type: UTO.RegistrosUso.dep_Departamento
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO.RegistrosUso
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
    private int _reg_Id;
    private EntitySet<mun_Municipio> _mun_Municipios;
    private EntitySet<ter_Tercero> _ter_Terceros;
    private EntitySet<ufd_UsuarioFinalDato> _ufd_UsuarioFinalDatos;
    private EntitySet<rid_RegistroImportadorDetalle> _rid_RegistroImportadorDetalles;

    public dep_Departamento()
    {
      this._mun_Municipios = new EntitySet<mun_Municipio>(new Action<mun_Municipio>(this.attach_mun_Municipios), new Action<mun_Municipio>(this.detach_mun_Municipios));
      this._ter_Terceros = new EntitySet<ter_Tercero>(new Action<ter_Tercero>(this.attach_ter_Terceros), new Action<ter_Tercero>(this.detach_ter_Terceros));
      this._ufd_UsuarioFinalDatos = new EntitySet<ufd_UsuarioFinalDato>(new Action<ufd_UsuarioFinalDato>(this.attach_ufd_UsuarioFinalDatos), new Action<ufd_UsuarioFinalDato>(this.detach_ufd_UsuarioFinalDatos));
      this._rid_RegistroImportadorDetalles = new EntitySet<rid_RegistroImportadorDetalle>(new Action<rid_RegistroImportadorDetalle>(this.attach_rid_RegistroImportadorDetalles), new Action<rid_RegistroImportadorDetalle>(this.detach_rid_RegistroImportadorDetalles));
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

    [Association(Name = "dep_Departamento_ter_Tercero", Storage = "_ter_Terceros", ThisKey = "dep_Id", OtherKey = "dep_Id")]
    public EntitySet<ter_Tercero> ter_Terceros
    {
      get => this._ter_Terceros;
      set => this._ter_Terceros.Assign((IEnumerable<ter_Tercero>) value);
    }

    [Association(Name = "dep_Departamento_ufd_UsuarioFinalDato", Storage = "_ufd_UsuarioFinalDatos", ThisKey = "dep_Id", OtherKey = "dep_Id")]
    public EntitySet<ufd_UsuarioFinalDato> ufd_UsuarioFinalDatos
    {
      get => this._ufd_UsuarioFinalDatos;
      set => this._ufd_UsuarioFinalDatos.Assign((IEnumerable<ufd_UsuarioFinalDato>) value);
    }

    [Association(Name = "dep_Departamento_rid_RegistroImportadorDetalle", Storage = "_rid_RegistroImportadorDetalles", ThisKey = "dep_Id", OtherKey = "dep_Id")]
    public EntitySet<rid_RegistroImportadorDetalle> rid_RegistroImportadorDetalles
    {
      get => this._rid_RegistroImportadorDetalles;
      set => this._rid_RegistroImportadorDetalles.Assign((IEnumerable<rid_RegistroImportadorDetalle>) value);
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

    private void attach_ufd_UsuarioFinalDatos(ufd_UsuarioFinalDato entity)
    {
      this.SendPropertyChanging();
      entity.dep_Departamento = this;
    }

    private void detach_ufd_UsuarioFinalDatos(ufd_UsuarioFinalDato entity)
    {
      this.SendPropertyChanging();
      entity.dep_Departamento = (dep_Departamento) null;
    }

    private void attach_rid_RegistroImportadorDetalles(rid_RegistroImportadorDetalle entity)
    {
      this.SendPropertyChanging();
      entity.dep_Departamento = this;
    }

    private void detach_rid_RegistroImportadorDetalles(rid_RegistroImportadorDetalle entity)
    {
      this.SendPropertyChanging();
      entity.dep_Departamento = (dep_Departamento) null;
    }

    public int CompareTo(dep_Departamento other) => this.dep_Descripcion.CompareTo(other.dep_Descripcion);
  }
}
