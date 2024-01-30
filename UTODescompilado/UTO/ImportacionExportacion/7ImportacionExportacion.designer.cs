// Decompiled with JetBrains decompiler
// Type: UTO.ImportacionExportacion.cip_ConsultaImportacion
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.ComponentModel;
using System.Data.Linq.Mapping;

namespace UTO.ImportacionExportacion
{
  [Table(Name = "Iye.cip_ConsultaImportacion")]
  public class cip_ConsultaImportacion : 
    INotifyPropertyChanging,
    INotifyPropertyChanged,
    IComparable<cip_ConsultaImportacion>
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _cip_Id;
    private string _cip_Descripcion;

    [Column(Storage = "_cip_Id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int cip_Id
    {
      get => this._cip_Id;
      set
      {
        if (this._cip_Id == value)
          return;
        this.SendPropertyChanging();
        this._cip_Id = value;
        this.SendPropertyChanged(nameof (cip_Id));
      }
    }

    [Column(Storage = "_cip_Descripcion", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string cip_Descripcion
    {
      get => this._cip_Descripcion;
      set
      {
        if (!(this._cip_Descripcion != value))
          return;
        this.SendPropertyChanging();
        this._cip_Descripcion = value;
        this.SendPropertyChanged(nameof (cip_Descripcion));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, cip_ConsultaImportacion.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    public int CompareTo(cip_ConsultaImportacion other) => this.cip_Descripcion.CompareTo(other.cip_Descripcion);
  }
}
