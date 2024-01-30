// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.rud_ReporteUsoDocumento
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO.Recuperacion
{
  [Table(Name = "Rrr.rud_ReporteUsoDocumento")]
  public class rud_ReporteUsoDocumento : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _rud_Id;
    private int _doc_Id;
    private int _rdu_Id;
    private EntityRef<doc_Documento> _doc_Documento;
    private EntityRef<rdu_ReporteUso> _rdu_ReporteUso;

    public rud_ReporteUsoDocumento()
    {
      this._doc_Documento = new EntityRef<doc_Documento>();
      this._rdu_ReporteUso = new EntityRef<rdu_ReporteUso>();
    }

    [Column(Storage = "_rud_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
    public int rud_Id
    {
      get => this._rud_Id;
      set
      {
        if (this._rud_Id == value)
          return;
        this.SendPropertyChanging();
        this._rud_Id = value;
        this.SendPropertyChanged(nameof (rud_Id));
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

    [Column(Storage = "_rdu_Id", DbType = "Int NOT NULL")]
    public int rdu_Id
    {
      get => this._rdu_Id;
      set
      {
        if (this._rdu_Id == value)
          return;
        if (this._rdu_ReporteUso.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._rdu_Id = value;
        this.SendPropertyChanged(nameof (rdu_Id));
      }
    }

    [Association(Name = "doc_Documento_rud_ReporteUsoDocumento", Storage = "_doc_Documento", ThisKey = "doc_Id", OtherKey = "doc_Id", IsForeignKey = true)]
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
          entity.rud_ReporteUsoDocumentos.Remove(this);
        }
        this._doc_Documento.Entity = value;
        if (value != null)
        {
          value.rud_ReporteUsoDocumentos.Add(this);
          this._doc_Id = value.doc_Id;
        }
        else
          this._doc_Id = 0;
        this.SendPropertyChanged(nameof (doc_Documento));
      }
    }

    [Association(Name = "rdu_ReporteUso_rud_ReporteUsoDocumento", Storage = "_rdu_ReporteUso", ThisKey = "rdu_Id", OtherKey = "rdu_Id", IsForeignKey = true)]
    public rdu_ReporteUso rdu_ReporteUso
    {
      get => this._rdu_ReporteUso.Entity;
      set
      {
        rdu_ReporteUso entity = this._rdu_ReporteUso.Entity;
        if (entity == value && this._rdu_ReporteUso.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._rdu_ReporteUso.Entity = (rdu_ReporteUso) null;
          entity.rud_ReporteUsoDocumentos.Remove(this);
        }
        this._rdu_ReporteUso.Entity = value;
        if (value != null)
        {
          value.rud_ReporteUsoDocumentos.Add(this);
          this._rdu_Id = value.rdu_Id;
        }
        else
          this._rdu_Id = 0;
        this.SendPropertyChanged(nameof (rdu_ReporteUso));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, rud_ReporteUsoDocumento.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
