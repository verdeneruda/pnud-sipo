// Decompiled with JetBrains decompiler
// Type: UTO.RegistrosUso.ceq_CategoriaEquipo
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
  [Table(Name = "Rus.ceq_CategoriaEquipo")]
  public class ceq_CategoriaEquipo : 
    INotifyPropertyChanging,
    INotifyPropertyChanged,
    IComparable<ceq_CategoriaEquipo>
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _ceq_Id;
    private string _ceq_Descripcion;
    private EntitySet<ufe_UsuarioFinalDetalle> _ufe_UsuarioFinalDetalles;
    private EntitySet<eti_EquipoTipo> _eti_EquipoTipos;

    public override string ToString() => this.ceq_Descripcion;

    public ceq_CategoriaEquipo()
    {
      this._ufe_UsuarioFinalDetalles = new EntitySet<ufe_UsuarioFinalDetalle>(new Action<ufe_UsuarioFinalDetalle>(this.attach_ufe_UsuarioFinalDetalles), new Action<ufe_UsuarioFinalDetalle>(this.detach_ufe_UsuarioFinalDetalles));
      this._eti_EquipoTipos = new EntitySet<eti_EquipoTipo>(new Action<eti_EquipoTipo>(this.attach_eti_EquipoTipos), new Action<eti_EquipoTipo>(this.detach_eti_EquipoTipos));
    }

    [Column(Storage = "_ceq_Id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int ceq_Id
    {
      get => this._ceq_Id;
      set
      {
        if (this._ceq_Id == value)
          return;
        this.SendPropertyChanging();
        this._ceq_Id = value;
        this.SendPropertyChanged(nameof (ceq_Id));
      }
    }

    [Column(Storage = "_ceq_Descripcion", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string ceq_Descripcion
    {
      get => this._ceq_Descripcion;
      set
      {
        if (!(this._ceq_Descripcion != value))
          return;
        this.SendPropertyChanging();
        this._ceq_Descripcion = value;
        this.SendPropertyChanged(nameof (ceq_Descripcion));
      }
    }

    [Association(Name = "ceq_CategoriaEquipo_ufe_UsuarioFinalDetalle", Storage = "_ufe_UsuarioFinalDetalles", ThisKey = "ceq_Id", OtherKey = "ceq_Id")]
    public EntitySet<ufe_UsuarioFinalDetalle> ufe_UsuarioFinalDetalles
    {
      get => this._ufe_UsuarioFinalDetalles;
      set => this._ufe_UsuarioFinalDetalles.Assign((IEnumerable<ufe_UsuarioFinalDetalle>) value);
    }

    [Association(Name = "ceq_CategoriaEquipo_eti_EquipoTipo", Storage = "_eti_EquipoTipos", ThisKey = "ceq_Id", OtherKey = "ceq_Id")]
    public EntitySet<eti_EquipoTipo> eti_EquipoTipos
    {
      get => this._eti_EquipoTipos;
      set => this._eti_EquipoTipos.Assign((IEnumerable<eti_EquipoTipo>) value);
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, ceq_CategoriaEquipo.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void attach_ufe_UsuarioFinalDetalles(ufe_UsuarioFinalDetalle entity)
    {
      this.SendPropertyChanging();
      entity.ceq_CategoriaEquipo = this;
    }

    private void detach_ufe_UsuarioFinalDetalles(ufe_UsuarioFinalDetalle entity)
    {
      this.SendPropertyChanging();
      entity.ceq_CategoriaEquipo = (ceq_CategoriaEquipo) null;
    }

    private void attach_eti_EquipoTipos(eti_EquipoTipo entity)
    {
      this.SendPropertyChanging();
      entity.ceq_CategoriaEquipo = this;
    }

    private void detach_eti_EquipoTipos(eti_EquipoTipo entity)
    {
      this.SendPropertyChanging();
      entity.ceq_CategoriaEquipo = (ceq_CategoriaEquipo) null;
    }

    public int CompareTo(ceq_CategoriaEquipo other) => this.ceq_Descripcion.CompareTo(other.ceq_Descripcion);
  }
}
