// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.rco_ReporteConsolidadoDocumento
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO.Recuperacion
{
  [Table(Name = "Rrr.rco_ReporteConsolidadoDocumento")]
  public class rco_ReporteConsolidadoDocumento : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _rco_Id;
    private int _doc_Id;
    private int _rrc_Id;
    private EntityRef<doc_Documento> _doc_Documento;
    private EntityRef<rrc_ReporteRegeneracionConsolidado> _rrc_ReporteRegeneracionConsolidado;

    public rco_ReporteConsolidadoDocumento()
    {
      this._doc_Documento = new EntityRef<doc_Documento>();
      this._rrc_ReporteRegeneracionConsolidado = new EntityRef<rrc_ReporteRegeneracionConsolidado>();
    }

    [Column(Storage = "_rco_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
    public int rco_Id
    {
      get => this._rco_Id;
      set
      {
        if (this._rco_Id == value)
          return;
        this.SendPropertyChanging();
        this._rco_Id = value;
        this.SendPropertyChanged(nameof (rco_Id));
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

    [Column(Storage = "_rrc_Id", DbType = "Int NOT NULL")]
    public int rrc_Id
    {
      get => this._rrc_Id;
      set
      {
        if (this._rrc_Id == value)
          return;
        if (this._rrc_ReporteRegeneracionConsolidado.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._rrc_Id = value;
        this.SendPropertyChanged(nameof (rrc_Id));
      }
    }

    [Association(Name = "doc_Documento_rco_ReporteConsolidadoDocumento", Storage = "_doc_Documento", ThisKey = "doc_Id", OtherKey = "doc_Id", IsForeignKey = true)]
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
          entity.rco_ReporteConsolidadoDocumentos.Remove(this);
        }
        this._doc_Documento.Entity = value;
        if (value != null)
        {
          value.rco_ReporteConsolidadoDocumentos.Add(this);
          this._doc_Id = value.doc_Id;
        }
        else
          this._doc_Id = 0;
        this.SendPropertyChanged(nameof (doc_Documento));
      }
    }

    [Association(Name = "rrc_ReporteRegeneracionConsolidado_rco_ReporteConsolidadoDocumento", Storage = "_rrc_ReporteRegeneracionConsolidado", ThisKey = "rrc_Id", OtherKey = "rrc_Id", IsForeignKey = true)]
    public rrc_ReporteRegeneracionConsolidado rrc_ReporteRegeneracionConsolidado
    {
      get => this._rrc_ReporteRegeneracionConsolidado.Entity;
      set
      {
        rrc_ReporteRegeneracionConsolidado entity = this._rrc_ReporteRegeneracionConsolidado.Entity;
        if (entity == value && this._rrc_ReporteRegeneracionConsolidado.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._rrc_ReporteRegeneracionConsolidado.Entity = (rrc_ReporteRegeneracionConsolidado) null;
          entity.rco_ReporteConsolidadoDocumentos.Remove(this);
        }
        this._rrc_ReporteRegeneracionConsolidado.Entity = value;
        if (value != null)
        {
          value.rco_ReporteConsolidadoDocumentos.Add(this);
          this._rrc_Id = value.rrc_Id;
        }
        else
          this._rrc_Id = 0;
        this.SendPropertyChanged(nameof (rrc_ReporteRegeneracionConsolidado));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, rco_ReporteConsolidadoDocumento.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
