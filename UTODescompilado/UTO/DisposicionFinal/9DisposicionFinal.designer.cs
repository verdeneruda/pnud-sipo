// Decompiled with JetBrains decompiler
// Type: UTO.DisposicionFinal.dti_DocumentoTipo
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
  [Table(Name = "Uto.dti_DocumentoTipo")]
  public class dti_DocumentoTipo : 
    INotifyPropertyChanging,
    INotifyPropertyChanged,
    IComparable<dti_DocumentoTipo>
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _dti_Id;
    private string _dti_Descripcion;
    private EntitySet<ter_Tercero> _ter_Terceros;

    public dti_DocumentoTipo() => this._ter_Terceros = new EntitySet<ter_Tercero>(new Action<ter_Tercero>(this.attach_ter_Terceros), new Action<ter_Tercero>(this.detach_ter_Terceros));

    [Column(Storage = "_dti_Id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int dti_Id
    {
      get => this._dti_Id;
      set
      {
        if (this._dti_Id == value)
          return;
        this.SendPropertyChanging();
        this._dti_Id = value;
        this.SendPropertyChanged(nameof (dti_Id));
      }
    }

    [Column(Storage = "_dti_Descripcion", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string dti_Descripcion
    {
      get => this._dti_Descripcion;
      set
      {
        if (!(this._dti_Descripcion != value))
          return;
        this.SendPropertyChanging();
        this._dti_Descripcion = value;
        this.SendPropertyChanged(nameof (dti_Descripcion));
      }
    }

    [Association(Name = "dti_DocumentoTipo_ter_Tercero", Storage = "_ter_Terceros", ThisKey = "dti_Id", OtherKey = "dti_Id")]
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
      this.PropertyChanging((object) this, dti_DocumentoTipo.emptyChangingEventArgs);
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
      entity.dti_DocumentoTipo = this;
    }

    private void detach_ter_Terceros(ter_Tercero entity)
    {
      this.SendPropertyChanging();
      entity.dti_DocumentoTipo = (dti_DocumentoTipo) null;
    }

    public int CompareTo(dti_DocumentoTipo other) => this.dti_Descripcion.CompareTo(other.dti_Descripcion);
  }
}
