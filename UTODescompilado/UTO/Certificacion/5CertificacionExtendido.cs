// Decompiled with JetBrains decompiler
// Type: UTO.Certificacion.reg_Regional
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
  [Table(Name = "Uto.reg_Regional")]
  public class reg_Regional : 
    IComparable<reg_Regional>,
    INotifyPropertyChanging,
    INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _reg_Id;
    private string _reg_Descripcion;
    private EntitySet<dep_Departamento> _dep_Departamentos;
    private EntitySet<ter_Tercero> _ter_Terceros;

    public int CompareTo(reg_Regional other) => this.reg_Descripcion.CompareTo(other.reg_Descripcion);

    public reg_Regional()
    {
      this._dep_Departamentos = new EntitySet<dep_Departamento>(new Action<dep_Departamento>(this.attach_dep_Departamentos), new Action<dep_Departamento>(this.detach_dep_Departamentos));
      this._ter_Terceros = new EntitySet<ter_Tercero>(new Action<ter_Tercero>(this.attach_ter_Terceros), new Action<ter_Tercero>(this.detach_ter_Terceros));
    }

    [Column(Storage = "_reg_Id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
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

    [Column(Storage = "_reg_Descripcion", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string reg_Descripcion
    {
      get => this._reg_Descripcion;
      set
      {
        if (!(this._reg_Descripcion != value))
          return;
        this.SendPropertyChanging();
        this._reg_Descripcion = value;
        this.SendPropertyChanged(nameof (reg_Descripcion));
      }
    }

    [Association(Name = "reg_Regional_dep_Departamento", Storage = "_dep_Departamentos", ThisKey = "reg_Id", OtherKey = "reg_Id")]
    public EntitySet<dep_Departamento> dep_Departamentos
    {
      get => this._dep_Departamentos;
      set => this._dep_Departamentos.Assign((IEnumerable<dep_Departamento>) value);
    }

    [Association(Name = "reg_Regional_ter_Tercero", Storage = "_ter_Terceros", ThisKey = "reg_Id", OtherKey = "reg_Id")]
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
      this.PropertyChanging((object) this, reg_Regional.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void attach_dep_Departamentos(dep_Departamento entity)
    {
      this.SendPropertyChanging();
      entity.reg_Regional = this;
    }

    private void detach_dep_Departamentos(dep_Departamento entity)
    {
      this.SendPropertyChanging();
      entity.reg_Regional = (reg_Regional) null;
    }

    private void attach_ter_Terceros(ter_Tercero entity)
    {
      this.SendPropertyChanging();
      entity.reg_Regional = this;
    }

    private void detach_ter_Terceros(ter_Tercero entity)
    {
      this.SendPropertyChanging();
      entity.reg_Regional = (reg_Regional) null;
    }
  }
}
