// Decompiled with JetBrains decompiler
// Type: UTO.DisposicionFinal.mun_Municipio
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO.DisposicionFinal
{
  [Table(Name = "Uto.mun_Municipio")]
  public class mun_Municipio : 
    INotifyPropertyChanging,
    INotifyPropertyChanged,
    IComparable<mun_Municipio>
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private string _mun_Id;
    private string _dep_Id;
    private string _mun_Descripcion;
    private EntitySet<ter_Tercero> _ter_Terceros;
    private EntitySet<dfd_DisposicionFinalDato> _dfd_DisposicionFinalDatos;
    private EntityRef<dep_Departamento> _dep_Departamento;

    public mun_Municipio()
    {
      this._ter_Terceros = new EntitySet<ter_Tercero>(new Action<ter_Tercero>(this.attach_ter_Terceros), new Action<ter_Tercero>(this.detach_ter_Terceros));
      this._dfd_DisposicionFinalDatos = new EntitySet<dfd_DisposicionFinalDato>(new Action<dfd_DisposicionFinalDato>(this.attach_dfd_DisposicionFinalDatos), new Action<dfd_DisposicionFinalDato>(this.detach_dfd_DisposicionFinalDatos));
      this._dep_Departamento = new EntityRef<dep_Departamento>();
    }

    [Column(Storage = "_mun_Id", DbType = "VarChar(5) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
    public string mun_Id
    {
      get => this._mun_Id;
      set
      {
        if (!(this._mun_Id != value))
          return;
        this.SendPropertyChanging();
        this._mun_Id = value;
        this.SendPropertyChanged(nameof (mun_Id));
      }
    }

    [Column(Storage = "_dep_Id", DbType = "VarChar(2) NOT NULL", CanBeNull = false)]
    public string dep_Id
    {
      get => this._dep_Id;
      set
      {
        if (!(this._dep_Id != value))
          return;
        if (this._dep_Departamento.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._dep_Id = value;
        this.SendPropertyChanged(nameof (dep_Id));
      }
    }

    [Column(Storage = "_mun_Descripcion", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string mun_Descripcion
    {
      get => this._mun_Descripcion;
      set
      {
        if (!(this._mun_Descripcion != value))
          return;
        this.SendPropertyChanging();
        this._mun_Descripcion = value;
        this.SendPropertyChanged(nameof (mun_Descripcion));
      }
    }

    [Association(Name = "mun_Municipio_ter_Tercero", Storage = "_ter_Terceros", ThisKey = "mun_Id", OtherKey = "mun_Id")]
    public EntitySet<ter_Tercero> ter_Terceros
    {
      get => this._ter_Terceros;
      set => this._ter_Terceros.Assign((IEnumerable<ter_Tercero>) value);
    }

    [Association(Name = "mun_Municipio_dfd_DisposicionFinalDato", Storage = "_dfd_DisposicionFinalDatos", ThisKey = "mun_Id", OtherKey = "mun_Id")]
    public EntitySet<dfd_DisposicionFinalDato> dfd_DisposicionFinalDatos
    {
      get => this._dfd_DisposicionFinalDatos;
      set => this._dfd_DisposicionFinalDatos.Assign((IEnumerable<dfd_DisposicionFinalDato>) value);
    }

    [Association(Name = "dep_Departamento_mun_Municipio", Storage = "_dep_Departamento", ThisKey = "dep_Id", OtherKey = "dep_Id", IsForeignKey = true)]
    public dep_Departamento dep_Departamento
    {
      get => this._dep_Departamento.Entity;
      set
      {
        dep_Departamento entity = this._dep_Departamento.Entity;
        if (entity == value && this._dep_Departamento.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._dep_Departamento.Entity = (dep_Departamento) null;
          entity.mun_Municipios.Remove(this);
        }
        this._dep_Departamento.Entity = value;
        if (value != null)
        {
          value.mun_Municipios.Add(this);
          this._dep_Id = value.dep_Id;
        }
        else
          this._dep_Id = (string) null;
        this.SendPropertyChanged(nameof (dep_Departamento));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, mun_Municipio.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void attach_ter_Terceros(ter_Tercero entity)
    {
      this.SendPropertyChanging();
      entity.mun_Municipio = this;
    }

    private void detach_ter_Terceros(ter_Tercero entity)
    {
      this.SendPropertyChanging();
      entity.mun_Municipio = (mun_Municipio) null;
    }

    private void attach_dfd_DisposicionFinalDatos(dfd_DisposicionFinalDato entity)
    {
      this.SendPropertyChanging();
      entity.mun_Municipio = this;
    }

    private void detach_dfd_DisposicionFinalDatos(dfd_DisposicionFinalDato entity)
    {
      this.SendPropertyChanging();
      entity.mun_Municipio = (mun_Municipio) null;
    }

    public int CompareTo(mun_Municipio other) => this.mun_Descripcion.CompareTo(other.mun_Descripcion);
  }
}
