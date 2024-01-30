// Decompiled with JetBrains decompiler
// Type: UTO.RegistrosUso.psu_PresentacionSustancia
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.ComponentModel;
using System.Data.Linq.Mapping;

namespace UTO.RegistrosUso
{
  [Table(Name = "Uto.psu_PresentacionSustancia")]
  public class psu_PresentacionSustancia : 
    INotifyPropertyChanging,
    INotifyPropertyChanged,
    IComparable<psu_PresentacionSustancia>
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _psu_Id;
    private string _psu_Descripcion;

    public override string ToString() => this.psu_Descripcion;

    [Column(Storage = "_psu_Id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int psu_Id
    {
      get => this._psu_Id;
      set
      {
        if (this._psu_Id == value)
          return;
        this.SendPropertyChanging();
        this._psu_Id = value;
        this.SendPropertyChanged(nameof (psu_Id));
      }
    }

    [Column(Storage = "_psu_Descripcion", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string psu_Descripcion
    {
      get => this._psu_Descripcion;
      set
      {
        if (!(this._psu_Descripcion != value))
          return;
        this.SendPropertyChanging();
        this._psu_Descripcion = value;
        this.SendPropertyChanged(nameof (psu_Descripcion));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, psu_PresentacionSustancia.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    public int CompareTo(psu_PresentacionSustancia other) => this.psu_Descripcion.CompareTo(other.psu_Descripcion);
  }
}
