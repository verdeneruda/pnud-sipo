// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.rrd_ReporteRegeneracionDocumento
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO.Recuperacion
{
  [Table(Name = "Rrr.rrd_ReporteRegeneracionDocumento")]
  public class rrd_ReporteRegeneracionDocumento : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _rrd_Id;
    private int _doc_Id;
    private EntityRef<doc_Documento> _doc_Documento;

    public rrd_ReporteRegeneracionDocumento() => this._doc_Documento = new EntityRef<doc_Documento>();

    [Column(Storage = "_rrd_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
    public int rrd_Id
    {
      get => this._rrd_Id;
      set
      {
        if (this._rrd_Id == value)
          return;
        this.SendPropertyChanging();
        this._rrd_Id = value;
        this.SendPropertyChanged(nameof (rrd_Id));
      }
    }

    [Column(Storage = "_doc_Id", DbType = "Int NOT NULL")]
    public int doc_Id
    {
      get => this._doc_Id;
      set
      {
        if (this._doc_Id == value)
          return;
        if (this._doc_Documento.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._doc_Id = value;
        this.SendPropertyChanged(nameof (doc_Id));
      }
    }

    [Association(Name = "doc_Documento_rrd_ReporteRegeneracionDocumento", Storage = "_doc_Documento", ThisKey = "doc_Id", OtherKey = "doc_Id", IsForeignKey = true)]
    public doc_Documento doc_Documento
    {
      get => this._doc_Documento.Entity;
      set
      {
        doc_Documento entity = this._doc_Documento.Entity;
        if (entity == value && this._doc_Documento.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._doc_Documento.Entity = (doc_Documento) null;
          entity.rrd_ReporteRegeneracionDocumentos.Remove(this);
        }
        this._doc_Documento.Entity = value;
        if (value != null)
        {
          value.rrd_ReporteRegeneracionDocumentos.Add(this);
          this._doc_Id = value.doc_Id;
        }
        else
          this._doc_Id = 0;
        this.SendPropertyChanged(nameof (doc_Documento));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, rrd_ReporteRegeneracionDocumento.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
