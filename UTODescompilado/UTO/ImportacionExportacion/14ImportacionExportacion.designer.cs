// Decompiled with JetBrains decompiler
// Type: UTO.ImportacionExportacion.cai_CargueArchivoImportacion
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System.ComponentModel;
using System.Data.Linq.Mapping;

namespace UTO.ImportacionExportacion
{
  [Table(Name = "Iye.cai_CargueArchivoImportacion")]
  public class cai_CargueArchivoImportacion : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _cai_Id;
    private int _cai_Ano;
    private string _cai_Ruta;

    [Column(Storage = "_cai_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
    public int cai_Id
    {
      get => this._cai_Id;
      set
      {
        if (this._cai_Id == value)
          return;
        this.SendPropertyChanging();
        this._cai_Id = value;
        this.SendPropertyChanged(nameof (cai_Id));
      }
    }

    [Column(Storage = "_cai_Ano", DbType = "Int NOT NULL")]
    public int cai_Ano
    {
      get => this._cai_Ano;
      set
      {
        if (this._cai_Ano == value)
          return;
        this.SendPropertyChanging();
        this._cai_Ano = value;
        this.SendPropertyChanged(nameof (cai_Ano));
      }
    }

    [Column(Storage = "_cai_Ruta", DbType = "VarChar(500) NOT NULL", CanBeNull = false)]
    public string cai_Ruta
    {
      get => this._cai_Ruta;
      set
      {
        if (!(this._cai_Ruta != value))
          return;
        this.SendPropertyChanging();
        this._cai_Ruta = value;
        this.SendPropertyChanged(nameof (cai_Ruta));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, cai_CargueArchivoImportacion.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
