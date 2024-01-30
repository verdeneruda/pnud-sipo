// Decompiled with JetBrains decompiler
// Type: UTO.ImportacionExportacion.pas_Pai
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO.ImportacionExportacion
{
  [Table(Name = "Uto.pas_Pais")]
  public class pas_Pai : INotifyPropertyChanging, INotifyPropertyChanged, IComparable<pas_Pai>
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _pas_Id;
    private string _pas_Descripcion;
    private EntitySet<rex_RegistroExportacion> _rex_RegistroExportacions;
    private EntitySet<lmd_LicenciaMedioAmbientalDetalle> _lmd_LicenciaMedioAmbientalDetalles;
    private EntitySet<cim_CertificacionImportador> _cim_CertificacionImportadors;
    private EntitySet<ris_RegistroImportacionSustancia> _ris_RegistroImportacionSustancias;
    private EntitySet<res_RegistroExportacionSustancia> _res_RegistroExportacionSustancias;
    private EntitySet<rim_RegistroImportacion> _rim_RegistroImportacions;

    public pas_Pai()
    {
      this._rex_RegistroExportacions = new EntitySet<rex_RegistroExportacion>(new Action<rex_RegistroExportacion>(this.attach_rex_RegistroExportacions), new Action<rex_RegistroExportacion>(this.detach_rex_RegistroExportacions));
      this._lmd_LicenciaMedioAmbientalDetalles = new EntitySet<lmd_LicenciaMedioAmbientalDetalle>(new Action<lmd_LicenciaMedioAmbientalDetalle>(this.attach_lmd_LicenciaMedioAmbientalDetalles), new Action<lmd_LicenciaMedioAmbientalDetalle>(this.detach_lmd_LicenciaMedioAmbientalDetalles));
      this._cim_CertificacionImportadors = new EntitySet<cim_CertificacionImportador>(new Action<cim_CertificacionImportador>(this.attach_cim_CertificacionImportadors), new Action<cim_CertificacionImportador>(this.detach_cim_CertificacionImportadors));
      this._ris_RegistroImportacionSustancias = new EntitySet<ris_RegistroImportacionSustancia>(new Action<ris_RegistroImportacionSustancia>(this.attach_ris_RegistroImportacionSustancias), new Action<ris_RegistroImportacionSustancia>(this.detach_ris_RegistroImportacionSustancias));
      this._res_RegistroExportacionSustancias = new EntitySet<res_RegistroExportacionSustancia>(new Action<res_RegistroExportacionSustancia>(this.attach_res_RegistroExportacionSustancias), new Action<res_RegistroExportacionSustancia>(this.detach_res_RegistroExportacionSustancias));
      this._rim_RegistroImportacions = new EntitySet<rim_RegistroImportacion>(new Action<rim_RegistroImportacion>(this.attach_rim_RegistroImportacions), new Action<rim_RegistroImportacion>(this.detach_rim_RegistroImportacions));
    }

    [Column(Storage = "_pas_Id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int pas_Id
    {
      get => this._pas_Id;
      set
      {
        if (this._pas_Id == value)
          return;
        this.SendPropertyChanging();
        this._pas_Id = value;
        this.SendPropertyChanged(nameof (pas_Id));
      }
    }

    [Column(Storage = "_pas_Descripcion", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string pas_Descripcion
    {
      get => this._pas_Descripcion;
      set
      {
        if (!(this._pas_Descripcion != value))
          return;
        this.SendPropertyChanging();
        this._pas_Descripcion = value;
        this.SendPropertyChanged(nameof (pas_Descripcion));
      }
    }

    [Association(Name = "pas_Pai_rex_RegistroExportacion", Storage = "_rex_RegistroExportacions", ThisKey = "pas_Id", OtherKey = "pas_Id")]
    public EntitySet<rex_RegistroExportacion> rex_RegistroExportacions
    {
      get => this._rex_RegistroExportacions;
      set => this._rex_RegistroExportacions.Assign((IEnumerable<rex_RegistroExportacion>) value);
    }

    [Association(Name = "pas_Pai_lmd_LicenciaMedioAmbientalDetalle", Storage = "_lmd_LicenciaMedioAmbientalDetalles", ThisKey = "pas_Id", OtherKey = "pas_Id")]
    public EntitySet<lmd_LicenciaMedioAmbientalDetalle> lmd_LicenciaMedioAmbientalDetalles
    {
      get => this._lmd_LicenciaMedioAmbientalDetalles;
      set => this._lmd_LicenciaMedioAmbientalDetalles.Assign((IEnumerable<lmd_LicenciaMedioAmbientalDetalle>) value);
    }

    [Association(Name = "pas_Pai_cim_CertificacionImportador", Storage = "_cim_CertificacionImportadors", ThisKey = "pas_Id", OtherKey = "pas_IdProcedencia")]
    public EntitySet<cim_CertificacionImportador> cim_CertificacionImportadors
    {
      get => this._cim_CertificacionImportadors;
      set => this._cim_CertificacionImportadors.Assign((IEnumerable<cim_CertificacionImportador>) value);
    }

    [Association(Name = "pas_Pai_ris_RegistroImportacionSustancia", Storage = "_ris_RegistroImportacionSustancias", ThisKey = "pas_Id", OtherKey = "pas_Id")]
    public EntitySet<ris_RegistroImportacionSustancia> ris_RegistroImportacionSustancias
    {
      get => this._ris_RegistroImportacionSustancias;
      set => this._ris_RegistroImportacionSustancias.Assign((IEnumerable<ris_RegistroImportacionSustancia>) value);
    }

    [Association(Name = "pas_Pai_res_RegistroExportacionSustancia", Storage = "_res_RegistroExportacionSustancias", ThisKey = "pas_Id", OtherKey = "pas_Id")]
    public EntitySet<res_RegistroExportacionSustancia> res_RegistroExportacionSustancias
    {
      get => this._res_RegistroExportacionSustancias;
      set => this._res_RegistroExportacionSustancias.Assign((IEnumerable<res_RegistroExportacionSustancia>) value);
    }

    [Association(Name = "pas_Pai_rim_RegistroImportacion", Storage = "_rim_RegistroImportacions", ThisKey = "pas_Id", OtherKey = "pas_Id")]
    public EntitySet<rim_RegistroImportacion> rim_RegistroImportacions
    {
      get => this._rim_RegistroImportacions;
      set => this._rim_RegistroImportacions.Assign((IEnumerable<rim_RegistroImportacion>) value);
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, pas_Pai.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void attach_rex_RegistroExportacions(rex_RegistroExportacion entity)
    {
      this.SendPropertyChanging();
      entity.pas_Pai = this;
    }

    private void detach_rex_RegistroExportacions(rex_RegistroExportacion entity)
    {
      this.SendPropertyChanging();
      entity.pas_Pai = (pas_Pai) null;
    }

    private void attach_lmd_LicenciaMedioAmbientalDetalles(lmd_LicenciaMedioAmbientalDetalle entity)
    {
      this.SendPropertyChanging();
      entity.pas_Pai = this;
    }

    private void detach_lmd_LicenciaMedioAmbientalDetalles(lmd_LicenciaMedioAmbientalDetalle entity)
    {
      this.SendPropertyChanging();
      entity.pas_Pai = (pas_Pai) null;
    }

    private void attach_cim_CertificacionImportadors(cim_CertificacionImportador entity)
    {
      this.SendPropertyChanging();
      entity.pas_Pai = this;
    }

    private void detach_cim_CertificacionImportadors(cim_CertificacionImportador entity)
    {
      this.SendPropertyChanging();
      entity.pas_Pai = (pas_Pai) null;
    }

    private void attach_ris_RegistroImportacionSustancias(ris_RegistroImportacionSustancia entity)
    {
      this.SendPropertyChanging();
      entity.pas_Pai = this;
    }

    private void detach_ris_RegistroImportacionSustancias(ris_RegistroImportacionSustancia entity)
    {
      this.SendPropertyChanging();
      entity.pas_Pai = (pas_Pai) null;
    }

    private void attach_res_RegistroExportacionSustancias(res_RegistroExportacionSustancia entity)
    {
      this.SendPropertyChanging();
      entity.pas_Pai = this;
    }

    private void detach_res_RegistroExportacionSustancias(res_RegistroExportacionSustancia entity)
    {
      this.SendPropertyChanging();
      entity.pas_Pai = (pas_Pai) null;
    }

    private void attach_rim_RegistroImportacions(rim_RegistroImportacion entity)
    {
      this.SendPropertyChanging();
      entity.pas_Pai = this;
    }

    private void detach_rim_RegistroImportacions(rim_RegistroImportacion entity)
    {
      this.SendPropertyChanging();
      entity.pas_Pai = (pas_Pai) null;
    }

    public int CompareTo(pas_Pai other) => this.pas_Descripcion.CompareTo(other.pas_Descripcion);
  }
}
