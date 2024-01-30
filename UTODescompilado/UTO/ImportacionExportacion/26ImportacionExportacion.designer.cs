// Decompiled with JetBrains decompiler
// Type: UTO.ImportacionExportacion.ear_EquipoArancel
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO.ImportacionExportacion
{
  [Table(Name = "Uto.ear_EquipoArancel")]
  public class ear_EquipoArancel : 
    INotifyPropertyChanging,
    INotifyPropertyChanged,
    IComparable<ear_EquipoArancel>
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _ear_id;
    private string _ear_Descripcion;
    private EntitySet<rie_RegistroImportacionEquipo> _rie_RegistroImportacionEquipos;

    public ear_EquipoArancel() => this._rie_RegistroImportacionEquipos = new EntitySet<rie_RegistroImportacionEquipo>(new Action<rie_RegistroImportacionEquipo>(this.attach_rie_RegistroImportacionEquipos), new Action<rie_RegistroImportacionEquipo>(this.detach_rie_RegistroImportacionEquipos));

    [Column(Storage = "_ear_id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int ear_id
    {
      get => this._ear_id;
      set
      {
        if (this._ear_id == value)
          return;
        this.SendPropertyChanging();
        this._ear_id = value;
        this.SendPropertyChanged(nameof (ear_id));
      }
    }

    [Column(Storage = "_ear_Descripcion", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
    public string ear_Descripcion
    {
      get => this._ear_Descripcion;
      set
      {
        if (!(this._ear_Descripcion != value))
          return;
        this.SendPropertyChanging();
        this._ear_Descripcion = value;
        this.SendPropertyChanged(nameof (ear_Descripcion));
      }
    }

    [Association(Name = "ear_EquipoArancel_rie_RegistroImportacionEquipo", Storage = "_rie_RegistroImportacionEquipos", ThisKey = "ear_id", OtherKey = "ear_Id")]
    public EntitySet<rie_RegistroImportacionEquipo> rie_RegistroImportacionEquipos
    {
      get => this._rie_RegistroImportacionEquipos;
      set => this._rie_RegistroImportacionEquipos.Assign((IEnumerable<rie_RegistroImportacionEquipo>) value);
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, ear_EquipoArancel.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void attach_rie_RegistroImportacionEquipos(rie_RegistroImportacionEquipo entity)
    {
      this.SendPropertyChanging();
      entity.ear_EquipoArancel = this;
    }

    private void detach_rie_RegistroImportacionEquipos(rie_RegistroImportacionEquipo entity)
    {
      this.SendPropertyChanging();
      entity.ear_EquipoArancel = (ear_EquipoArancel) null;
    }

    public int CompareTo(ear_EquipoArancel other) => this.ear_Descripcion.CompareTo(other.ear_Descripcion);
  }
}
