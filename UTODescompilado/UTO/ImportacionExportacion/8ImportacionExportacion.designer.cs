// Decompiled with JetBrains decompiler
// Type: UTO.ImportacionExportacion.cae_CargueArchivoExportacion
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System.ComponentModel;
using System.Data.Linq.Mapping;

namespace UTO.ImportacionExportacion
{
  [Table(Name = "Iye.cae_CargueArchivoExportacion")]
  public class cae_CargueArchivoExportacion : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _cae_Id;
    private int _cae_Ano;
    private string _cae_Ruta;

    [Column(Storage = "_cae_Id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int cae_Id
    {
      get => this._cae_Id;
      set
      {
        if (this._cae_Id == value)
          return;
        this.SendPropertyChanging();
        this._cae_Id = value;
        this.SendPropertyChanged(nameof (cae_Id));
      }
    }

    [Column(Storage = "_cae_Ano", DbType = "Int NOT NULL")]
    public int cae_Ano
    {
      get => this._cae_Ano;
      set
      {
        if (this._cae_Ano == value)
          return;
        this.SendPropertyChanging();
        this._cae_Ano = value;
        this.SendPropertyChanged(nameof (cae_Ano));
      }
    }

    [Column(Storage = "_cae_Ruta", DbType = "VarChar(500) NOT NULL", CanBeNull = false)]
    public string cae_Ruta
    {
      get => this._cae_Ruta;
      set
      {
        if (!(this._cae_Ruta != value))
          return;
        this.SendPropertyChanging();
        this._cae_Ruta = value;
        this.SendPropertyChanged(nameof (cae_Ruta));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, cae_CargueArchivoExportacion.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
