// Decompiled with JetBrains decompiler
// Type: UTO.Comunes.pas_Pai
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.ComponentModel;
using System.Data.Linq.Mapping;

namespace UTO.Comunes
{
  [Table(Name = "Uto.pas_Pais")]
  public class pas_Pai : IComparable<pas_Pai>, INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _pas_Id;
    private string _pas_Descripcion;

    public int CompareTo(pas_Pai other) => this.pas_Descripcion.CompareTo(other.pas_Descripcion);

    [Column(Storage = "_pas_Id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int pas_Id
    {
      get => this._pas_Id;
      set
      {
        if (this._pas_Id == value)
          return;
        this.SendPropertyChanging();
        this._pas_Id = value;
        this.SendPropertyChanged(nameof (pas_Id));
      }
    }

    [Column(Storage = "_pas_Descripcion", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string pas_Descripcion
    {
      get => this._pas_Descripcion;
      set
      {
        if (!(this._pas_Descripcion != value))
          return;
        this.SendPropertyChanging();
        this._pas_Descripcion = value;
        this.SendPropertyChanged(nameof (pas_Descripcion));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, pas_Pai.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
