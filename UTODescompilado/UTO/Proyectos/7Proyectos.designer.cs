// Decompiled with JetBrains decompiler
// Type: UTO.Proyectos.doc_Documento
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO.Proyectos
{
  [Table(Name = "Uto.doc_Documento")]
  public class doc_Documento : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _doc_Id;
    private DateTime _doc_FechaRadicacion;
    private string _doc_Ruta;
    private Binary _doc_Archivo;
    private string _doc_Asunto;

    [Column(Storage = "_doc_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
    public int doc_Id
    {
      get => this._doc_Id;
      set
      {
        if (this._doc_Id == value)
          return;
        this.SendPropertyChanging();
        this._doc_Id = value;
        this.SendPropertyChanged(nameof (doc_Id));
      }
    }

    [Column(Storage = "_doc_FechaRadicacion", DbType = "DateTime NOT NULL")]
    public DateTime doc_FechaRadicacion
    {
      get => this._doc_FechaRadicacion;
      set
      {
        if (!(this._doc_FechaRadicacion != value))
          return;
        this.SendPropertyChanging();
        this._doc_FechaRadicacion = value;
        this.SendPropertyChanged(nameof (doc_FechaRadicacion));
      }
    }

    [Column(Storage = "_doc_Ruta", DbType = "VarChar(500)")]
    public string doc_Ruta
    {
      get => this._doc_Ruta;
      set
      {
        if (!(this._doc_Ruta != value))
          return;
        this.SendPropertyChanging();
        this._doc_Ruta = value;
        this.SendPropertyChanged(nameof (doc_Ruta));
      }
    }

    [Column(Storage = "_doc_Archivo", DbType = "VarBinary(MAX) NOT NULL", CanBeNull = false, UpdateCheck = UpdateCheck.Never)]
    public Binary doc_Archivo
    {
      get => this._doc_Archivo;
      set
      {
        if (!(this._doc_Archivo != value))
          return;
        this.SendPropertyChanging();
        this._doc_Archivo = value;
        this.SendPropertyChanged(nameof (doc_Archivo));
      }
    }

    [Column(Storage = "_doc_Asunto", DbType = "VarChar(500)")]
    public string doc_Asunto
    {
      get => this._doc_Asunto;
      set
      {
        if (!(this._doc_Asunto != value))
          return;
        this.SendPropertyChanging();
        this._doc_Asunto = value;
        this.SendPropertyChanged(nameof (doc_Asunto));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, doc_Documento.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
