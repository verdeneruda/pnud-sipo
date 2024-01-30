// Decompiled with JetBrains decompiler
// Type: UTO.ImportacionExportacion.ter_Tercero
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
  [Table(Name = "Uto.ter_Tercero")]
  public class ter_Tercero : 
    INotifyPropertyChanging,
    INotifyPropertyChanged,
    IComparable<ter_Tercero>
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _ter_Id;
    private int _dti_Id;
    private string _ter_NumeroDocumento;
    private int _bti_Id;
    private string _ter_NombreCompleto;
    private int? _reg_Id;
    private string _dep_Id;
    private string _mun_Id;
    private string _ter_Tefono;
    private string _ter_Direccion;
    private string _ter_Correo;
    private string _ter_Fax;
    private string _ter_Celular;
    private string _ter_EstablacimientoComercio;
    private string _ter_RepresentanteLegal;
    private int? _dti_IdRepresentante;
    private string _ter_NumeroDocumentoRepresentante;
    private EntitySet<rex_RegistroExportacion> _rex_RegistroExportacions;
    private EntitySet<ttt_TerceroTipoTercero> _ttt_TerceroTipoTerceros;
    private EntitySet<lmd_LicenciaMedioAmbientalDetalle> _lmd_LicenciaMedioAmbientalDetalles;
    private EntitySet<lma_LicenciaMedioAmbiental> _lma_LicenciaMedioAmbientals;
    private EntitySet<cim_CertificacionImportador> _cim_CertificacionImportadors;
    private EntitySet<cim_CertificacionImportador> _cim_CertificacionImportadors1;
    private EntitySet<cim_CertificacionImportador> _cim_CertificacionImportadors2;
    private EntitySet<rim_RegistroImportacion> _rim_RegistroImportacions;
    private EntitySet<rim_RegistroImportacion> _rim_RegistroImportacions1;
    private EntityRef<dep_Departamento> _dep_Departamento;
    private EntityRef<dti_DocumentoTipo> _dti_DocumentoTipo;
    private EntityRef<dti_DocumentoTipo> _dti_DocumentoTipo1;
    private EntityRef<mun_Municipio> _mun_Municipio;

    public ter_Tercero()
    {
      this._rex_RegistroExportacions = new EntitySet<rex_RegistroExportacion>(new Action<rex_RegistroExportacion>(this.attach_rex_RegistroExportacions), new Action<rex_RegistroExportacion>(this.detach_rex_RegistroExportacions));
      this._ttt_TerceroTipoTerceros = new EntitySet<ttt_TerceroTipoTercero>(new Action<ttt_TerceroTipoTercero>(this.attach_ttt_TerceroTipoTerceros), new Action<ttt_TerceroTipoTercero>(this.detach_ttt_TerceroTipoTerceros));
      this._lmd_LicenciaMedioAmbientalDetalles = new EntitySet<lmd_LicenciaMedioAmbientalDetalle>(new Action<lmd_LicenciaMedioAmbientalDetalle>(this.attach_lmd_LicenciaMedioAmbientalDetalles), new Action<lmd_LicenciaMedioAmbientalDetalle>(this.detach_lmd_LicenciaMedioAmbientalDetalles));
      this._lma_LicenciaMedioAmbientals = new EntitySet<lma_LicenciaMedioAmbiental>(new Action<lma_LicenciaMedioAmbiental>(this.attach_lma_LicenciaMedioAmbientals), new Action<lma_LicenciaMedioAmbiental>(this.detach_lma_LicenciaMedioAmbientals));
      this._cim_CertificacionImportadors = new EntitySet<cim_CertificacionImportador>(new Action<cim_CertificacionImportador>(this.attach_cim_CertificacionImportadors), new Action<cim_CertificacionImportador>(this.detach_cim_CertificacionImportadors));
      this._cim_CertificacionImportadors1 = new EntitySet<cim_CertificacionImportador>(new Action<cim_CertificacionImportador>(this.attach_cim_CertificacionImportadors1), new Action<cim_CertificacionImportador>(this.detach_cim_CertificacionImportadors1));
      this._cim_CertificacionImportadors2 = new EntitySet<cim_CertificacionImportador>(new Action<cim_CertificacionImportador>(this.attach_cim_CertificacionImportadors2), new Action<cim_CertificacionImportador>(this.detach_cim_CertificacionImportadors2));
      this._rim_RegistroImportacions = new EntitySet<rim_RegistroImportacion>(new Action<rim_RegistroImportacion>(this.attach_rim_RegistroImportacions), new Action<rim_RegistroImportacion>(this.detach_rim_RegistroImportacions));
      this._rim_RegistroImportacions1 = new EntitySet<rim_RegistroImportacion>(new Action<rim_RegistroImportacion>(this.attach_rim_RegistroImportacions1), new Action<rim_RegistroImportacion>(this.detach_rim_RegistroImportacions1));
      this._dep_Departamento = new EntityRef<dep_Departamento>();
      this._dti_DocumentoTipo = new EntityRef<dti_DocumentoTipo>();
      this._dti_DocumentoTipo1 = new EntityRef<dti_DocumentoTipo>();
      this._mun_Municipio = new EntityRef<mun_Municipio>();
    }

    [Column(Storage = "_ter_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
    public int ter_Id
    {
      get => this._ter_Id;
      set
      {
        if (this._ter_Id == value)
          return;
        this.SendPropertyChanging();
        this._ter_Id = value;
        this.SendPropertyChanged(nameof (ter_Id));
      }
    }

    [Column(Storage = "_dti_Id", DbType = "Int NOT NULL")]
    public int dti_Id
    {
      get => this._dti_Id;
      set
      {
        if (this._dti_Id == value)
          return;
        if (this._dti_DocumentoTipo.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._dti_Id = value;
        this.SendPropertyChanged(nameof (dti_Id));
      }
    }

    [Column(Storage = "_ter_NumeroDocumento", DbType = "VarChar(20) NOT NULL", CanBeNull = false)]
    public string ter_NumeroDocumento
    {
      get => this._ter_NumeroDocumento;
      set
      {
        if (!(this._ter_NumeroDocumento != value))
          return;
        this.SendPropertyChanging();
        this._ter_NumeroDocumento = value;
        this.SendPropertyChanged(nameof (ter_NumeroDocumento));
      }
    }

    [Column(Storage = "_bti_Id", DbType = "Int NOT NULL")]
    public int bti_Id
    {
      get => this._bti_Id;
      set
      {
        if (this._bti_Id == value)
          return;
        this.SendPropertyChanging();
        this._bti_Id = value;
        this.SendPropertyChanged(nameof (bti_Id));
      }
    }

    [Column(Storage = "_ter_NombreCompleto", DbType = "VarChar(450)")]
    public string ter_NombreCompleto
    {
      get => this._ter_NombreCompleto;
      set
      {
        if (!(this._ter_NombreCompleto != value))
          return;
        this.SendPropertyChanging();
        this._ter_NombreCompleto = value;
        this.SendPropertyChanged(nameof (ter_NombreCompleto));
      }
    }

    [Column(Storage = "_reg_Id", DbType = "Int")]
    public int? reg_Id
    {
      get => this._reg_Id;
      set
      {
        int? regId = this._reg_Id;
        int? nullable = value;
        if ((regId.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (regId.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._reg_Id = value;
        this.SendPropertyChanged(nameof (reg_Id));
      }
    }

    [Column(Storage = "_dep_Id", DbType = "VarChar(2) NOT NULL", CanBeNull = false)]
    public string dep_Id
    {
      get => this._dep_Id;
      set
      {
        if (!(this._dep_Id != value))
          return;
        if (this._dep_Departamento.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._dep_Id = value;
        this.SendPropertyChanged(nameof (dep_Id));
      }
    }

    [Column(Storage = "_mun_Id", DbType = "VarChar(5) NOT NULL", CanBeNull = false)]
    public string mun_Id
    {
      get => this._mun_Id;
      set
      {
        if (!(this._mun_Id != value))
          return;
        if (this._mun_Municipio.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._mun_Id = value;
        this.SendPropertyChanged(nameof (mun_Id));
      }
    }

    [Column(Storage = "_ter_Tefono", DbType = "VarChar(50)")]
    public string ter_Tefono
    {
      get => this._ter_Tefono;
      set
      {
        if (!(this._ter_Tefono != value))
          return;
        this.SendPropertyChanging();
        this._ter_Tefono = value;
        this.SendPropertyChanged(nameof (ter_Tefono));
      }
    }

    [Column(Storage = "_ter_Direccion", DbType = "VarChar(128)")]
    public string ter_Direccion
    {
      get => this._ter_Direccion;
      set
      {
        if (!(this._ter_Direccion != value))
          return;
        this.SendPropertyChanging();
        this._ter_Direccion = value;
        this.SendPropertyChanged(nameof (ter_Direccion));
      }
    }

    [Column(Storage = "_ter_Correo", DbType = "VarChar(128)")]
    public string ter_Correo
    {
      get => this._ter_Correo;
      set
      {
        if (!(this._ter_Correo != value))
          return;
        this.SendPropertyChanging();
        this._ter_Correo = value;
        this.SendPropertyChanged(nameof (ter_Correo));
      }
    }

    [Column(Storage = "_ter_Fax", DbType = "VarChar(50)")]
    public string ter_Fax
    {
      get => this._ter_Fax;
      set
      {
        if (!(this._ter_Fax != value))
          return;
        this.SendPropertyChanging();
        this._ter_Fax = value;
        this.SendPropertyChanged(nameof (ter_Fax));
      }
    }

    [Column(Storage = "_ter_Celular", DbType = "VarChar(50)")]
    public string ter_Celular
    {
      get => this._ter_Celular;
      set
      {
        if (!(this._ter_Celular != value))
          return;
        this.SendPropertyChanging();
        this._ter_Celular = value;
        this.SendPropertyChanged(nameof (ter_Celular));
      }
    }

    [Column(Storage = "_ter_EstablacimientoComercio", DbType = "VarChar(255)")]
    public string ter_EstablacimientoComercio
    {
      get => this._ter_EstablacimientoComercio;
      set
      {
        if (!(this._ter_EstablacimientoComercio != value))
          return;
        this.SendPropertyChanging();
        this._ter_EstablacimientoComercio = value;
        this.SendPropertyChanged(nameof (ter_EstablacimientoComercio));
      }
    }

    [Column(Storage = "_ter_RepresentanteLegal", DbType = "VarChar(255)")]
    public string ter_RepresentanteLegal
    {
      get => this._ter_RepresentanteLegal;
      set
      {
        if (!(this._ter_RepresentanteLegal != value))
          return;
        this.SendPropertyChanging();
        this._ter_RepresentanteLegal = value;
        this.SendPropertyChanged(nameof (ter_RepresentanteLegal));
      }
    }

    [Column(Storage = "_dti_IdRepresentante", DbType = "Int")]
    public int? dti_IdRepresentante
    {
      get => this._dti_IdRepresentante;
      set
      {
        int? dtiIdRepresentante = this._dti_IdRepresentante;
        int? nullable = value;
        if ((dtiIdRepresentante.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (dtiIdRepresentante.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        if (this._dti_DocumentoTipo1.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._dti_IdRepresentante = value;
        this.SendPropertyChanged(nameof (dti_IdRepresentante));
      }
    }

    [Column(Storage = "_ter_NumeroDocumentoRepresentante", DbType = "VarChar(20)")]
    public string ter_NumeroDocumentoRepresentante
    {
      get => this._ter_NumeroDocumentoRepresentante;
      set
      {
        if (!(this._ter_NumeroDocumentoRepresentante != value))
          return;
        this.SendPropertyChanging();
        this._ter_NumeroDocumentoRepresentante = value;
        this.SendPropertyChanged(nameof (ter_NumeroDocumentoRepresentante));
      }
    }

    [Association(Name = "ter_Tercero_rex_RegistroExportacion", Storage = "_rex_RegistroExportacions", ThisKey = "ter_Id", OtherKey = "ter_Id")]
    public EntitySet<rex_RegistroExportacion> rex_RegistroExportacions
    {
      get => this._rex_RegistroExportacions;
      set => this._rex_RegistroExportacions.Assign((IEnumerable<rex_RegistroExportacion>) value);
    }

    [Association(Name = "ter_Tercero_ttt_TerceroTipoTercero", Storage = "_ttt_TerceroTipoTerceros", ThisKey = "ter_Id", OtherKey = "ter_Id")]
    public EntitySet<ttt_TerceroTipoTercero> ttt_TerceroTipoTerceros
    {
      get => this._ttt_TerceroTipoTerceros;
      set => this._ttt_TerceroTipoTerceros.Assign((IEnumerable<ttt_TerceroTipoTercero>) value);
    }

    [Association(Name = "ter_Tercero_lmd_LicenciaMedioAmbientalDetalle", Storage = "_lmd_LicenciaMedioAmbientalDetalles", ThisKey = "ter_Id", OtherKey = "ter_IdProveedor")]
    public EntitySet<lmd_LicenciaMedioAmbientalDetalle> lmd_LicenciaMedioAmbientalDetalles
    {
      get => this._lmd_LicenciaMedioAmbientalDetalles;
      set => this._lmd_LicenciaMedioAmbientalDetalles.Assign((IEnumerable<lmd_LicenciaMedioAmbientalDetalle>) value);
    }

    [Association(Name = "ter_Tercero_lma_LicenciaMedioAmbiental", Storage = "_lma_LicenciaMedioAmbientals", ThisKey = "ter_Id", OtherKey = "ter_IdEmpresa")]
    public EntitySet<lma_LicenciaMedioAmbiental> lma_LicenciaMedioAmbientals
    {
      get => this._lma_LicenciaMedioAmbientals;
      set => this._lma_LicenciaMedioAmbientals.Assign((IEnumerable<lma_LicenciaMedioAmbiental>) value);
    }

    [Association(Name = "ter_Tercero_cim_CertificacionImportador", Storage = "_cim_CertificacionImportadors", ThisKey = "ter_Id", OtherKey = "ter_IdEmpresa")]
    public EntitySet<cim_CertificacionImportador> cim_CertificacionImportadors
    {
      get => this._cim_CertificacionImportadors;
      set => this._cim_CertificacionImportadors.Assign((IEnumerable<cim_CertificacionImportador>) value);
    }

    [Association(Name = "ter_Tercero_cim_CertificacionImportador1", Storage = "_cim_CertificacionImportadors1", ThisKey = "ter_Id", OtherKey = "ter_IdImportador")]
    public EntitySet<cim_CertificacionImportador> cim_CertificacionImportadors1
    {
      get => this._cim_CertificacionImportadors1;
      set => this._cim_CertificacionImportadors1.Assign((IEnumerable<cim_CertificacionImportador>) value);
    }

    [Association(Name = "ter_Tercero_cim_CertificacionImportador2", Storage = "_cim_CertificacionImportadors2", ThisKey = "ter_Id", OtherKey = "ter_IdRadicadoPor")]
    public EntitySet<cim_CertificacionImportador> cim_CertificacionImportadors2
    {
      get => this._cim_CertificacionImportadors2;
      set => this._cim_CertificacionImportadors2.Assign((IEnumerable<cim_CertificacionImportador>) value);
    }

    [Association(Name = "ter_Tercero_rim_RegistroImportacion", Storage = "_rim_RegistroImportacions", ThisKey = "ter_Id", OtherKey = "ter_Id")]
    public EntitySet<rim_RegistroImportacion> rim_RegistroImportacions
    {
      get => this._rim_RegistroImportacions;
      set => this._rim_RegistroImportacions.Assign((IEnumerable<rim_RegistroImportacion>) value);
    }

    [Association(Name = "ter_Tercero_rim_RegistroImportacion1", Storage = "_rim_RegistroImportacions1", ThisKey = "ter_Id", OtherKey = "ter_idExportador")]
    public EntitySet<rim_RegistroImportacion> rim_RegistroImportacions1
    {
      get => this._rim_RegistroImportacions1;
      set => this._rim_RegistroImportacions1.Assign((IEnumerable<rim_RegistroImportacion>) value);
    }

    [Association(Name = "dep_Departamento_ter_Tercero", Storage = "_dep_Departamento", ThisKey = "dep_Id", OtherKey = "dep_Id", IsForeignKey = true)]
    public dep_Departamento dep_Departamento
    {
      get => this._dep_Departamento.Entity;
      set
      {
        dep_Departamento entity = this._dep_Departamento.Entity;
        if (entity == value && this._dep_Departamento.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._dep_Departamento.Entity = (dep_Departamento) null;
          entity.ter_Terceros.Remove(this);
        }
        this._dep_Departamento.Entity = value;
        if (value != null)
        {
          value.ter_Terceros.Add(this);
          this._dep_Id = value.dep_Id;
        }
        else
          this._dep_Id = (string) null;
        this.SendPropertyChanged(nameof (dep_Departamento));
      }
    }

    [Association(Name = "dti_DocumentoTipo_ter_Tercero", Storage = "_dti_DocumentoTipo", ThisKey = "dti_Id", OtherKey = "dti_Id", IsForeignKey = true)]
    public dti_DocumentoTipo dti_DocumentoTipo
    {
      get => this._dti_DocumentoTipo.Entity;
      set
      {
        dti_DocumentoTipo entity = this._dti_DocumentoTipo.Entity;
        if (entity == value && this._dti_DocumentoTipo.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._dti_DocumentoTipo.Entity = (dti_DocumentoTipo) null;
          entity.ter_Terceros.Remove(this);
        }
        this._dti_DocumentoTipo.Entity = value;
        if (value != null)
        {
          value.ter_Terceros.Add(this);
          this._dti_Id = value.dti_Id;
        }
        else
          this._dti_Id = 0;
        this.SendPropertyChanged(nameof (dti_DocumentoTipo));
      }
    }

    [Association(Name = "dti_DocumentoTipo_ter_Tercero1", Storage = "_dti_DocumentoTipo1", ThisKey = "dti_IdRepresentante", OtherKey = "dti_Id", IsForeignKey = true)]
    public dti_DocumentoTipo dti_DocumentoTipo1
    {
      get => this._dti_DocumentoTipo1.Entity;
      set
      {
        dti_DocumentoTipo entity = this._dti_DocumentoTipo1.Entity;
        if (entity == value && this._dti_DocumentoTipo1.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._dti_DocumentoTipo1.Entity = (dti_DocumentoTipo) null;
          entity.ter_Terceros1.Remove(this);
        }
        this._dti_DocumentoTipo1.Entity = value;
        if (value != null)
        {
          value.ter_Terceros1.Add(this);
          this._dti_IdRepresentante = new int?(value.dti_Id);
        }
        else
          this._dti_IdRepresentante = new int?();
        this.SendPropertyChanged(nameof (dti_DocumentoTipo1));
      }
    }

    [Association(Name = "mun_Municipio_ter_Tercero", Storage = "_mun_Municipio", ThisKey = "mun_Id", OtherKey = "mun_Id", IsForeignKey = true)]
    public mun_Municipio mun_Municipio
    {
      get => this._mun_Municipio.Entity;
      set
      {
        mun_Municipio entity = this._mun_Municipio.Entity;
        if (entity == value && this._mun_Municipio.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._mun_Municipio.Entity = (mun_Municipio) null;
          entity.ter_Terceros.Remove(this);
        }
        this._mun_Municipio.Entity = value;
        if (value != null)
        {
          value.ter_Terceros.Add(this);
          this._mun_Id = value.mun_Id;
        }
        else
          this._mun_Id = (string) null;
        this.SendPropertyChanged(nameof (mun_Municipio));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, ter_Tercero.emptyChangingEventArgs);
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
      entity.ter_Tercero = this;
    }

    private void detach_rex_RegistroExportacions(rex_RegistroExportacion entity)
    {
      this.SendPropertyChanging();
      entity.ter_Tercero = (ter_Tercero) null;
    }

    private void attach_ttt_TerceroTipoTerceros(ttt_TerceroTipoTercero entity)
    {
      this.SendPropertyChanging();
      entity.ter_Tercero = this;
    }

    private void detach_ttt_TerceroTipoTerceros(ttt_TerceroTipoTercero entity)
    {
      this.SendPropertyChanging();
      entity.ter_Tercero = (ter_Tercero) null;
    }

    private void attach_lmd_LicenciaMedioAmbientalDetalles(lmd_LicenciaMedioAmbientalDetalle entity)
    {
      this.SendPropertyChanging();
      entity.ter_Tercero = this;
    }

    private void detach_lmd_LicenciaMedioAmbientalDetalles(lmd_LicenciaMedioAmbientalDetalle entity)
    {
      this.SendPropertyChanging();
      entity.ter_Tercero = (ter_Tercero) null;
    }

    private void attach_lma_LicenciaMedioAmbientals(lma_LicenciaMedioAmbiental entity)
    {
      this.SendPropertyChanging();
      entity.ter_Tercero = this;
    }

    private void detach_lma_LicenciaMedioAmbientals(lma_LicenciaMedioAmbiental entity)
    {
      this.SendPropertyChanging();
      entity.ter_Tercero = (ter_Tercero) null;
    }

    private void attach_cim_CertificacionImportadors(cim_CertificacionImportador entity)
    {
      this.SendPropertyChanging();
      entity.ter_Tercero = this;
    }

    private void detach_cim_CertificacionImportadors(cim_CertificacionImportador entity)
    {
      this.SendPropertyChanging();
      entity.ter_Tercero = (ter_Tercero) null;
    }

    private void attach_cim_CertificacionImportadors1(cim_CertificacionImportador entity)
    {
      this.SendPropertyChanging();
      entity.ter_Tercero1 = this;
    }

    private void detach_cim_CertificacionImportadors1(cim_CertificacionImportador entity)
    {
      this.SendPropertyChanging();
      entity.ter_Tercero1 = (ter_Tercero) null;
    }

    private void attach_cim_CertificacionImportadors2(cim_CertificacionImportador entity)
    {
      this.SendPropertyChanging();
      entity.ter_Tercero2 = this;
    }

    private void detach_cim_CertificacionImportadors2(cim_CertificacionImportador entity)
    {
      this.SendPropertyChanging();
      entity.ter_Tercero2 = (ter_Tercero) null;
    }

    private void attach_rim_RegistroImportacions(rim_RegistroImportacion entity)
    {
      this.SendPropertyChanging();
      entity.ter_Tercero = this;
    }

    private void detach_rim_RegistroImportacions(rim_RegistroImportacion entity)
    {
      this.SendPropertyChanging();
      entity.ter_Tercero = (ter_Tercero) null;
    }

    private void attach_rim_RegistroImportacions1(rim_RegistroImportacion entity)
    {
      this.SendPropertyChanging();
      entity.ter_Tercero1 = this;
    }

    private void detach_rim_RegistroImportacions1(rim_RegistroImportacion entity)
    {
      this.SendPropertyChanging();
      entity.ter_Tercero1 = (ter_Tercero) null;
    }

    public override string ToString() => this.ter_NumeroDocumento;

    public int CompareTo(ter_Tercero other) => this.ter_NombreCompleto.CompareTo(other.ter_NombreCompleto);
  }
}
