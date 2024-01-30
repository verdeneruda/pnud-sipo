// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.rbd_ReporteUsoBarridoDocumento
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO.Recuperacion
{
  [Table(Name = "Rrr.rbd_ReporteUsoBarridoDocumento")]
  public class rbd_ReporteUsoBarridoDocumento : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _rbd_Id;
    private int _doc_Id;
    private int _rdb_Id;
    private EntityRef<doc_Documento> _doc_Documento;
    private EntityRef<rdb_ReporteUsoBarrido> _rdb_ReporteUsoBarrido;

    public rbd_ReporteUsoBarridoDocumento()
    {
      this._doc_Documento = new EntityRef<doc_Documento>();
      this._rdb_ReporteUsoBarrido = new EntityRef<rdb_ReporteUsoBarrido>();
    }

    [Column(Storage = "_rbd_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
    public int rbd_Id
    {
      get => this._rbd_Id;
      set
      {
        if (this._rbd_Id == value)
          return;
        this.SendPropertyChanging();
        this._rbd_Id = value;
        this.SendPropertyChanged(nameof (rbd_Id));
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

    [Column(Storage = "_rdb_Id", DbType = "Int NOT NULL")]
    public int rdb_Id
    {
      get => this._rdb_Id;
      set
      {
        if (this._rdb_Id == value)
          return;
        if (this._rdb_ReporteUsoBarrido.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._rdb_Id = value;
        this.SendPropertyChanged(nameof (rdb_Id));
      }
    }

    [Association(Name = "doc_Documento_rbd_ReporteUsoBarridoDocumento", Storage = "_doc_Documento", ThisKey = "doc_Id", OtherKey = "doc_Id", IsForeignKey = true)]
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
          entity.rbd_ReporteUsoBarridoDocumentos.Remove(this);
        }
        this._doc_Documento.Entity = value;
        if (value != null)
        {
          value.rbd_ReporteUsoBarridoDocumentos.Add(this);
          this._doc_Id = value.doc_Id;
        }
        else
          this._doc_Id = 0;
        this.SendPropertyChanged(nameof (doc_Documento));
      }
    }

    [Association(Name = "rdb_ReporteUsoBarrido_rbd_ReporteUsoBarridoDocumento", Storage = "_rdb_ReporteUsoBarrido", ThisKey = "rdb_Id", OtherKey = "rdb_Id", IsForeignKey = true)]
    public rdb_ReporteUsoBarrido rdb_ReporteUsoBarrido
    {
      get => this._rdb_ReporteUsoBarrido.Entity;
      set
      {
        rdb_ReporteUsoBarrido entity = this._rdb_ReporteUsoBarrido.Entity;
        if (entity == value && this._rdb_ReporteUsoBarrido.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._rdb_ReporteUsoBarrido.Entity = (rdb_ReporteUsoBarrido) null;
          entity.rbd_ReporteUsoBarridoDocumentos.Remove(this);
        }
        this._rdb_ReporteUsoBarrido.Entity = value;
        if (value != null)
        {
          value.rbd_ReporteUsoBarridoDocumentos.Add(this);
          this._rdb_Id = value.rdb_Id;
        }
        else
          this._rdb_Id = 0;
        this.SendPropertyChanged(nameof (rdb_ReporteUsoBarrido));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, rbd_ReporteUsoBarridoDocumento.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
