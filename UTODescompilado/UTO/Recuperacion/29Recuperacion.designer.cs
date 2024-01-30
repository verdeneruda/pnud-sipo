// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.cre_ConsultaRecuperacion
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.ComponentModel;
using System.Data.Linq.Mapping;

namespace UTO.Recuperacion
{
  [Table(Name = "Rrr.cre_ConsultaRecuperacion")]
  public class cre_ConsultaRecuperacion : 
    INotifyPropertyChanging,
    INotifyPropertyChanged,
    IComparable<cre_ConsultaRecuperacion>
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _cre_Id;
    private string _cre_Descripcion;

    [Column(Storage = "_cre_Id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int cre_Id
    {
      get => this._cre_Id;
      set
      {
        if (this._cre_Id == value)
          return;
        this.SendPropertyChanging();
        this._cre_Id = value;
        this.SendPropertyChanged(nameof (cre_Id));
      }
    }

    [Column(Storage = "_cre_Descripcion", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string cre_Descripcion
    {
      get => this._cre_Descripcion;
      set
      {
        if (!(this._cre_Descripcion != value))
          return;
        this.SendPropertyChanging();
        this._cre_Descripcion = value;
        this.SendPropertyChanged(nameof (cre_Descripcion));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, cre_ConsultaRecuperacion.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    public int CompareTo(cre_ConsultaRecuperacion other) => this.cre_Descripcion.CompareTo(other.cre_Descripcion);
  }
}
