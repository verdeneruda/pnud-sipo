// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.bti_beneficiarioTipo
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
  [Table(Name = "Uto.bti_beneficiarioTipo")]
  public class bti_beneficiarioTipo : 
    INotifyPropertyChanging,
    INotifyPropertyChanged,
    IComparable<bti_beneficiarioTipo>
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _bti_Id;
    private string _bti_Descripcion;
    private EntitySet<ter_Tercero> _ter_Terceros;

    public bti_beneficiarioTipo() => this._ter_Terceros = new EntitySet<ter_Tercero>(new Action<ter_Tercero>(this.attach_ter_Terceros), new Action<ter_Tercero>(this.detach_ter_Terceros));

    [Column(Storage = "_bti_Id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int bti_Id
    {
      get => this._bti_Id;
      set
      {
        if (this._bti_Id == value)
          return;
        this.SendPropertyChanging();
        this._bti_Id = value;
        this.SendPropertyChanged(nameof (bti_Id));
      }
    }

    [Column(Storage = "_bti_Descripcion", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string bti_Descripcion
    {
      get => this._bti_Descripcion;
      set
      {
        if (!(this._bti_Descripcion != value))
          return;
        this.SendPropertyChanging();
        this._bti_Descripcion = value;
        this.SendPropertyChanged(nameof (bti_Descripcion));
      }
    }

    [Association(Name = "bti_beneficiarioTipo_ter_Tercero", Storage = "_ter_Terceros", ThisKey = "bti_Id", OtherKey = "bti_Id")]
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
      this.PropertyChanging((object) this, bti_beneficiarioTipo.emptyChangingEventArgs);
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
      entity.bti_beneficiarioTipo = this;
    }

    private void detach_ter_Terceros(ter_Tercero entity)
    {
      this.SendPropertyChanging();
      entity.bti_beneficiarioTipo = (bti_beneficiarioTipo) null;
    }

    public int CompareTo(bti_beneficiarioTipo other) => this.bti_Descripcion.CompareTo(other.bti_Descripcion);
  }
}
