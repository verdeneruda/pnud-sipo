// Decompiled with JetBrains decompiler
// Type: UTO.Comunes.sus_Sustancia
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.ComponentModel;
using System.Data.Linq.Mapping;

namespace UTO.Comunes
{
  [Table(Name = "Uto.sus_Sustancia")]
  public class sus_Sustancia : 
    IComparable<sus_Sustancia>,
    INotifyPropertyChanging,
    INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _sus_Id;
    private string _sus_Arancel;
    private string _sus_Descripcion;

    public int CompareTo(sus_Sustancia other) => this.sus_Descripcion.CompareTo(other.sus_Descripcion);

    [Column(Storage = "_sus_Id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int sus_Id
    {
      get => this._sus_Id;
      set
      {
        if (this._sus_Id == value)
          return;
        this.SendPropertyChanging();
        this._sus_Id = value;
        this.SendPropertyChanged(nameof (sus_Id));
      }
    }

    [Column(Storage = "_sus_Arancel", DbType = "VarChar(50)")]
    public string sus_Arancel
    {
      get => this._sus_Arancel;
      set
      {
        if (!(this._sus_Arancel != value))
          return;
        this.SendPropertyChanging();
        this._sus_Arancel = value;
        this.SendPropertyChanged(nameof (sus_Arancel));
      }
    }

    [Column(Storage = "_sus_Descripcion", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string sus_Descripcion
    {
      get => this._sus_Descripcion;
      set
      {
        if (!(this._sus_Descripcion != value))
          return;
        this.SendPropertyChanging();
        this._sus_Descripcion = value;
        this.SendPropertyChanged(nameof (sus_Descripcion));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, sus_Sustancia.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
