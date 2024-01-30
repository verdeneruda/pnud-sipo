// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.sdo_SolicitudDocumento
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO.Recuperacion
{
  [Table(Name = "Rrr.sdo_SolicitudDocumento")]
  public class sdo_SolicitudDocumento : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _sdo_Id;
    private int _seq_Id;
    private int _doc_Id;
    private EntityRef<doc_Documento> _doc_Documento;
    private EntityRef<seq_SolicitudEquipo> _seq_SolicitudEquipo;

    public sdo_SolicitudDocumento()
    {
      this._doc_Documento = new EntityRef<doc_Documento>();
      this._seq_SolicitudEquipo = new EntityRef<seq_SolicitudEquipo>();
    }

    [Column(Storage = "_sdo_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
    public int sdo_Id
    {
      get => this._sdo_Id;
      set
      {
        if (this._sdo_Id == value)
          return;
        this.SendPropertyChanging();
        this._sdo_Id = value;
        this.SendPropertyChanged(nameof (sdo_Id));
      }
    }

    [Column(Storage = "_seq_Id", DbType = "Int NOT NULL")]
    public int seq_Id
    {
      get => this._seq_Id;
      set
      {
        if (this._seq_Id == value)
          return;
        if (this._seq_SolicitudEquipo.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._seq_Id = value;
        this.SendPropertyChanged(nameof (seq_Id));
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

    [Association(Name = "doc_Documento_sdo_SolicitudDocumento", Storage = "_doc_Documento", ThisKey = "doc_Id", OtherKey = "doc_Id", IsForeignKey = true)]
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
          entity.sdo_SolicitudDocumentos.Remove(this);
        }
        this._doc_Documento.Entity = value;
        if (value != null)
        {
          value.sdo_SolicitudDocumentos.Add(this);
          this._doc_Id = value.doc_Id;
        }
        else
          this._doc_Id = 0;
        this.SendPropertyChanged(nameof (doc_Documento));
      }
    }

    [Association(Name = "seq_SolicitudEquipo_sdo_SolicitudDocumento", Storage = "_seq_SolicitudEquipo", ThisKey = "seq_Id", OtherKey = "seq_Id", IsForeignKey = true)]
    public seq_SolicitudEquipo seq_SolicitudEquipo
    {
      get => this._seq_SolicitudEquipo.Entity;
      set
      {
        seq_SolicitudEquipo entity = this._seq_SolicitudEquipo.Entity;
        if (entity == value && this._seq_SolicitudEquipo.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._seq_SolicitudEquipo.Entity = (seq_SolicitudEquipo) null;
          entity.sdo_SolicitudDocumentos.Remove(this);
        }
        this._seq_SolicitudEquipo.Entity = value;
        if (value != null)
        {
          value.sdo_SolicitudDocumentos.Add(this);
          this._seq_Id = value.seq_Id;
        }
        else
          this._seq_Id = 0;
        this.SendPropertyChanged(nameof (seq_SolicitudEquipo));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, sdo_SolicitudDocumento.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
