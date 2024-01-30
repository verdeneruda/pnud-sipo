// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.cti_CorrespondenciaTipo
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.ComponentModel;
using System.Data.Linq.Mapping;

namespace UTO.Recuperacion
{
  [Table(Name = "Rrr.cti_CorrespondenciaTipo")]
  public class cti_CorrespondenciaTipo : 
    INotifyPropertyChanging,
    INotifyPropertyChanged,
    IComparable<cti_CorrespondenciaTipo>
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _cti_Id;
    private string _cti_Descripcion;

    [Column(Storage = "_cti_Id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int cti_Id
    {
      get => this._cti_Id;
      set
      {
        if (this._cti_Id == value)
          return;
        this.SendPropertyChanging();
        this._cti_Id = value;
        this.SendPropertyChanged(nameof (cti_Id));
      }
    }

    [Column(Storage = "_cti_Descripcion", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string cti_Descripcion
    {
      get => this._cti_Descripcion;
      set
      {
        if (!(this._cti_Descripcion != value))
          return;
        this.SendPropertyChanging();
        this._cti_Descripcion = value;
        this.SendPropertyChanged(nameof (cti_Descripcion));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, cti_CorrespondenciaTipo.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    public int CompareTo(cti_CorrespondenciaTipo other) => this.cti_Descripcion.CompareTo(other.cti_Descripcion);
  }
}
