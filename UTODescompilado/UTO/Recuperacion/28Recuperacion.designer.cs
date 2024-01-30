// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.doc_Documento
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO.Recuperacion
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
    private EntitySet<rrd_ReporteRegeneracionDocumento> _rrd_ReporteRegeneracionDocumentos;
    private EntitySet<sdo_SolicitudDocumento> _sdo_SolicitudDocumentos;
    private EntitySet<ndo_NovedadDocumento> _ndo_NovedadDocumentos;
    private EntitySet<rud_ReporteUsoDocumento> _rud_ReporteUsoDocumentos;
    private EntitySet<rco_ReporteConsolidadoDocumento> _rco_ReporteConsolidadoDocumentos;
    private EntitySet<rbd_ReporteUsoBarridoDocumento> _rbd_ReporteUsoBarridoDocumentos;

    public doc_Documento()
    {
      this._rrd_ReporteRegeneracionDocumentos = new EntitySet<rrd_ReporteRegeneracionDocumento>(new Action<rrd_ReporteRegeneracionDocumento>(this.attach_rrd_ReporteRegeneracionDocumentos), new Action<rrd_ReporteRegeneracionDocumento>(this.detach_rrd_ReporteRegeneracionDocumentos));
      this._sdo_SolicitudDocumentos = new EntitySet<sdo_SolicitudDocumento>(new Action<sdo_SolicitudDocumento>(this.attach_sdo_SolicitudDocumentos), new Action<sdo_SolicitudDocumento>(this.detach_sdo_SolicitudDocumentos));
      this._ndo_NovedadDocumentos = new EntitySet<ndo_NovedadDocumento>(new Action<ndo_NovedadDocumento>(this.attach_ndo_NovedadDocumentos), new Action<ndo_NovedadDocumento>(this.detach_ndo_NovedadDocumentos));
      this._rud_ReporteUsoDocumentos = new EntitySet<rud_ReporteUsoDocumento>(new Action<rud_ReporteUsoDocumento>(this.attach_rud_ReporteUsoDocumentos), new Action<rud_ReporteUsoDocumento>(this.detach_rud_ReporteUsoDocumentos));
      this._rco_ReporteConsolidadoDocumentos = new EntitySet<rco_ReporteConsolidadoDocumento>(new Action<rco_ReporteConsolidadoDocumento>(this.attach_rco_ReporteConsolidadoDocumentos), new Action<rco_ReporteConsolidadoDocumento>(this.detach_rco_ReporteConsolidadoDocumentos));
      this._rbd_ReporteUsoBarridoDocumentos = new EntitySet<rbd_ReporteUsoBarridoDocumento>(new Action<rbd_ReporteUsoBarridoDocumento>(this.attach_rbd_ReporteUsoBarridoDocumentos), new Action<rbd_ReporteUsoBarridoDocumento>(this.detach_rbd_ReporteUsoBarridoDocumentos));
    }

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

    [Association(Name = "doc_Documento_rrd_ReporteRegeneracionDocumento", Storage = "_rrd_ReporteRegeneracionDocumentos", ThisKey = "doc_Id", OtherKey = "doc_Id")]
    public EntitySet<rrd_ReporteRegeneracionDocumento> rrd_ReporteRegeneracionDocumentos
    {
      get => this._rrd_ReporteRegeneracionDocumentos;
      set => this._rrd_ReporteRegeneracionDocumentos.Assign((IEnumerable<rrd_ReporteRegeneracionDocumento>) value);
    }

    [Association(Name = "doc_Documento_sdo_SolicitudDocumento", Storage = "_sdo_SolicitudDocumentos", ThisKey = "doc_Id", OtherKey = "doc_Id")]
    public EntitySet<sdo_SolicitudDocumento> sdo_SolicitudDocumentos
    {
      get => this._sdo_SolicitudDocumentos;
      set => this._sdo_SolicitudDocumentos.Assign((IEnumerable<sdo_SolicitudDocumento>) value);
    }

    [Association(Name = "doc_Documento_ndo_NovedadDocumento", Storage = "_ndo_NovedadDocumentos", ThisKey = "doc_Id", OtherKey = "doc_Id")]
    public EntitySet<ndo_NovedadDocumento> ndo_NovedadDocumentos
    {
      get => this._ndo_NovedadDocumentos;
      set => this._ndo_NovedadDocumentos.Assign((IEnumerable<ndo_NovedadDocumento>) value);
    }

    [Association(Name = "doc_Documento_rud_ReporteUsoDocumento", Storage = "_rud_ReporteUsoDocumentos", ThisKey = "doc_Id", OtherKey = "doc_Id")]
    public EntitySet<rud_ReporteUsoDocumento> rud_ReporteUsoDocumentos
    {
      get => this._rud_ReporteUsoDocumentos;
      set => this._rud_ReporteUsoDocumentos.Assign((IEnumerable<rud_ReporteUsoDocumento>) value);
    }

    [Association(Name = "doc_Documento_rco_ReporteConsolidadoDocumento", Storage = "_rco_ReporteConsolidadoDocumentos", ThisKey = "doc_Id", OtherKey = "doc_Id")]
    public EntitySet<rco_ReporteConsolidadoDocumento> rco_ReporteConsolidadoDocumentos
    {
      get => this._rco_ReporteConsolidadoDocumentos;
      set => this._rco_ReporteConsolidadoDocumentos.Assign((IEnumerable<rco_ReporteConsolidadoDocumento>) value);
    }

    [Association(Name = "doc_Documento_rbd_ReporteUsoBarridoDocumento", Storage = "_rbd_ReporteUsoBarridoDocumentos", ThisKey = "doc_Id", OtherKey = "doc_Id")]
    public EntitySet<rbd_ReporteUsoBarridoDocumento> rbd_ReporteUsoBarridoDocumentos
    {
      get => this._rbd_ReporteUsoBarridoDocumentos;
      set => this._rbd_ReporteUsoBarridoDocumentos.Assign((IEnumerable<rbd_ReporteUsoBarridoDocumento>) value);
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

    private void attach_rrd_ReporteRegeneracionDocumentos(rrd_ReporteRegeneracionDocumento entity)
    {
      this.SendPropertyChanging();
      entity.doc_Documento = this;
    }

    private void detach_rrd_ReporteRegeneracionDocumentos(rrd_ReporteRegeneracionDocumento entity)
    {
      this.SendPropertyChanging();
      entity.doc_Documento = (doc_Documento) null;
    }

    private void attach_sdo_SolicitudDocumentos(sdo_SolicitudDocumento entity)
    {
      this.SendPropertyChanging();
      entity.doc_Documento = this;
    }

    private void detach_sdo_SolicitudDocumentos(sdo_SolicitudDocumento entity)
    {
      this.SendPropertyChanging();
      entity.doc_Documento = (doc_Documento) null;
    }

    private void attach_ndo_NovedadDocumentos(ndo_NovedadDocumento entity)
    {
      this.SendPropertyChanging();
      entity.doc_Documento = this;
    }

    private void detach_ndo_NovedadDocumentos(ndo_NovedadDocumento entity)
    {
      this.SendPropertyChanging();
      entity.doc_Documento = (doc_Documento) null;
    }

    private void attach_rud_ReporteUsoDocumentos(rud_ReporteUsoDocumento entity)
    {
      this.SendPropertyChanging();
      entity.doc_Documento = this;
    }

    private void detach_rud_ReporteUsoDocumentos(rud_ReporteUsoDocumento entity)
    {
      this.SendPropertyChanging();
      entity.doc_Documento = (doc_Documento) null;
    }

    private void attach_rco_ReporteConsolidadoDocumentos(rco_ReporteConsolidadoDocumento entity)
    {
      this.SendPropertyChanging();
      entity.doc_Documento = this;
    }

    private void detach_rco_ReporteConsolidadoDocumentos(rco_ReporteConsolidadoDocumento entity)
    {
      this.SendPropertyChanging();
      entity.doc_Documento = (doc_Documento) null;
    }

    private void attach_rbd_ReporteUsoBarridoDocumentos(rbd_ReporteUsoBarridoDocumento entity)
    {
      this.SendPropertyChanging();
      entity.doc_Documento = this;
    }

    private void detach_rbd_ReporteUsoBarridoDocumentos(rbd_ReporteUsoBarridoDocumento entity)
    {
      this.SendPropertyChanging();
      entity.doc_Documento = (doc_Documento) null;
    }
  }
}
