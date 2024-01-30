// Decompiled with JetBrains decompiler
// Type: UTO.RegistrosUso.apl_Aplicacion
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
  [Table(Name = "Rus.apl_Aplicacion")]
  public class apl_Aplicacion : 
    INotifyPropertyChanging,
    INotifyPropertyChanged,
    IComparable<apl_Aplicacion>
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _apl_Id;
    private string _apl_Descripcion;
    private EntitySet<rid_RegistroImportadorDetalle> _rid_RegistroImportadorDetalles;

    public override string ToString() => this.apl_Descripcion;

    public apl_Aplicacion() => this._rid_RegistroImportadorDetalles = new EntitySet<rid_RegistroImportadorDetalle>(new Action<rid_RegistroImportadorDetalle>(this.attach_rid_RegistroImportadorDetalles), new Action<rid_RegistroImportadorDetalle>(this.detach_rid_RegistroImportadorDetalles));

    [Column(Storage = "_apl_Id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int apl_Id
    {
      get => this._apl_Id;
      set
      {
        if (this._apl_Id == value)
          return;
        this.SendPropertyChanging();
        this._apl_Id = value;
        this.SendPropertyChanged(nameof (apl_Id));
      }
    }

    [Column(Storage = "_apl_Descripcion", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string apl_Descripcion
    {
      get => this._apl_Descripcion;
      set
      {
        if (!(this._apl_Descripcion != value))
          return;
        this.SendPropertyChanging();
        this._apl_Descripcion = value;
        this.SendPropertyChanged(nameof (apl_Descripcion));
      }
    }

    [Association(Name = "apl_Aplicacion_rid_RegistroImportadorDetalle", Storage = "_rid_RegistroImportadorDetalles", ThisKey = "apl_Id", OtherKey = "apl_Id")]
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
      this.PropertyChanging((object) this, apl_Aplicacion.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void attach_rid_RegistroImportadorDetalles(rid_RegistroImportadorDetalle entity)
    {
      this.SendPropertyChanging();
      entity.apl_Aplicacion = this;
    }

    private void detach_rid_RegistroImportadorDetalles(rid_RegistroImportadorDetalle entity)
    {
      this.SendPropertyChanging();
      entity.apl_Aplicacion = (apl_Aplicacion) null;
    }

    public int CompareTo(apl_Aplicacion other) => this.apl_Descripcion.CompareTo(other.apl_Descripcion);
  }
}
