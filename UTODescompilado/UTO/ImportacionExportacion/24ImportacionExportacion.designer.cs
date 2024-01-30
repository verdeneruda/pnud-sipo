// Decompiled with JetBrains decompiler
// Type: UTO.ImportacionExportacion.rit_RegistroImportacionEstado
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
  [Table(Name = "Iye.rit_RegistroImportacionEstado")]
  public class rit_RegistroImportacionEstado : 
    INotifyPropertyChanging,
    INotifyPropertyChanged,
    IComparable<rit_RegistroImportacionEstado>
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _rit_Id;
    private string _rit_Descripcion;
    private EntitySet<rim_RegistroImportacion> _rim_RegistroImportacions;

    public rit_RegistroImportacionEstado() => this._rim_RegistroImportacions = new EntitySet<rim_RegistroImportacion>(new Action<rim_RegistroImportacion>(this.attach_rim_RegistroImportacions), new Action<rim_RegistroImportacion>(this.detach_rim_RegistroImportacions));

    [Column(Storage = "_rit_Id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int rit_Id
    {
      get => this._rit_Id;
      set
      {
        if (this._rit_Id == value)
          return;
        this.SendPropertyChanging();
        this._rit_Id = value;
        this.SendPropertyChanged(nameof (rit_Id));
      }
    }

    [Column(Storage = "_rit_Descripcion", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
    public string rit_Descripcion
    {
      get => this._rit_Descripcion;
      set
      {
        if (!(this._rit_Descripcion != value))
          return;
        this.SendPropertyChanging();
        this._rit_Descripcion = value;
        this.SendPropertyChanged(nameof (rit_Descripcion));
      }
    }

    [Association(Name = "rit_RegistroImportacionEstado_rim_RegistroImportacion", Storage = "_rim_RegistroImportacions", ThisKey = "rit_Id", OtherKey = "rit_Id")]
    public EntitySet<rim_RegistroImportacion> rim_RegistroImportacions
    {
      get => this._rim_RegistroImportacions;
      set => this._rim_RegistroImportacions.Assign((IEnumerable<rim_RegistroImportacion>) value);
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, rit_RegistroImportacionEstado.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void attach_rim_RegistroImportacions(rim_RegistroImportacion entity)
    {
      this.SendPropertyChanging();
      entity.rit_RegistroImportacionEstado = this;
    }

    private void detach_rim_RegistroImportacions(rim_RegistroImportacion entity)
    {
      this.SendPropertyChanging();
      entity.rit_RegistroImportacionEstado = (rit_RegistroImportacionEstado) null;
    }

    public int CompareTo(rit_RegistroImportacionEstado other) => this.rit_Descripcion.CompareTo(other.rit_Descripcion);
  }
}
