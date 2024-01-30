// Decompiled with JetBrains decompiler
// Type: UTO.RegistrosUso.eti_EquipoTipo
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
  [Table(Name = "Rus.eti_EquipoTipo")]
  public class eti_EquipoTipo : 
    INotifyPropertyChanging,
    INotifyPropertyChanged,
    IComparable<eti_EquipoTipo>
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _eti_Id;
    private int _ceq_Id;
    private string _eti_Descripcion;
    private EntitySet<ufe_UsuarioFinalDetalle> _ufe_UsuarioFinalDetalles;
    private EntityRef<ceq_CategoriaEquipo> _ceq_CategoriaEquipo;

    public override string ToString() => this.eti_Descripcion;

    public eti_EquipoTipo()
    {
      this._ufe_UsuarioFinalDetalles = new EntitySet<ufe_UsuarioFinalDetalle>(new Action<ufe_UsuarioFinalDetalle>(this.attach_ufe_UsuarioFinalDetalles), new Action<ufe_UsuarioFinalDetalle>(this.detach_ufe_UsuarioFinalDetalles));
      this._ceq_CategoriaEquipo = new EntityRef<ceq_CategoriaEquipo>();
    }

    [Column(Storage = "_eti_Id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int eti_Id
    {
      get => this._eti_Id;
      set
      {
        if (this._eti_Id == value)
          return;
        this.SendPropertyChanging();
        this._eti_Id = value;
        this.SendPropertyChanged(nameof (eti_Id));
      }
    }

    [Column(Storage = "_ceq_Id", DbType = "Int NOT NULL")]
    public int ceq_Id
    {
      get => this._ceq_Id;
      set
      {
        if (this._ceq_Id == value)
          return;
        if (this._ceq_CategoriaEquipo.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._ceq_Id = value;
        this.SendPropertyChanged(nameof (ceq_Id));
      }
    }

    [Column(Storage = "_eti_Descripcion", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string eti_Descripcion
    {
      get => this._eti_Descripcion;
      set
      {
        if (!(this._eti_Descripcion != value))
          return;
        this.SendPropertyChanging();
        this._eti_Descripcion = value;
        this.SendPropertyChanged(nameof (eti_Descripcion));
      }
    }

    [Association(Name = "eti_EquipoTipo_ufe_UsuarioFinalDetalle", Storage = "_ufe_UsuarioFinalDetalles", ThisKey = "eti_Id", OtherKey = "eti_Id")]
    public EntitySet<ufe_UsuarioFinalDetalle> ufe_UsuarioFinalDetalles
    {
      get => this._ufe_UsuarioFinalDetalles;
      set => this._ufe_UsuarioFinalDetalles.Assign((IEnumerable<ufe_UsuarioFinalDetalle>) value);
    }

    [Association(Name = "ceq_CategoriaEquipo_eti_EquipoTipo", Storage = "_ceq_CategoriaEquipo", ThisKey = "ceq_Id", OtherKey = "ceq_Id", IsForeignKey = true)]
    public ceq_CategoriaEquipo ceq_CategoriaEquipo
    {
      get => this._ceq_CategoriaEquipo.Entity;
      set
      {
        ceq_CategoriaEquipo entity = this._ceq_CategoriaEquipo.Entity;
        if (entity == value && this._ceq_CategoriaEquipo.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._ceq_CategoriaEquipo.Entity = (ceq_CategoriaEquipo) null;
          entity.eti_EquipoTipos.Remove(this);
        }
        this._ceq_CategoriaEquipo.Entity = value;
        if (value != null)
        {
          value.eti_EquipoTipos.Add(this);
          this._ceq_Id = value.ceq_Id;
        }
        else
          this._ceq_Id = 0;
        this.SendPropertyChanged(nameof (ceq_CategoriaEquipo));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, eti_EquipoTipo.emptyChangingEventArgs);
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
      entity.eti_EquipoTipo = this;
    }

    private void detach_ufe_UsuarioFinalDetalles(ufe_UsuarioFinalDetalle entity)
    {
      this.SendPropertyChanging();
      entity.eti_EquipoTipo = (eti_EquipoTipo) null;
    }

    public int CompareTo(eti_EquipoTipo other) => this.eti_Descripcion.CompareTo(other.eti_Descripcion);
  }
}
