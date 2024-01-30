// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.neq_NovedadEquipo
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
  [Table(Name = "Rrr.neq_NovedadEquipo")]
  public class neq_NovedadEquipo : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _neq_Id;
    private int _seq_Id;
    private int? _ndo_Id;
    private int _nes_Id;
    private int _nti_Id;
    private DateTime _neq_FechaNovedad;
    private string _neq_Direccion;
    private string _dep_Id;
    private string _mun_Id;
    private string _neq_RazonSocial;
    private string _neq_Otros;
    private string _neq_RepresentanteLegal;
    private int? _dti_Id;
    private string _neq_NumeroDocumento;
    private Decimal? _neq_ValorTotal;
    private DateTime? _neq_FechaElaboracionMinuta;
    private DateTime? _neq_FechaFirmaMinuta;
    private DateTime? _neq_FechaVigenciaPoliza;
    private DateTime? _neq_FechaPlazoPoliza;
    private DateTime? _neq_FechaPublicacion;
    private DateTime? _neq_FechaAprobacionPoliza;
    private string _neq_ObservacionIncial;
    private string _neq_ObservacionEstudioPrevio;
    private string _neq_ObservacionMinuta;
    private string _neq_ObservacionPoliza;
    private string _neq_NumeroOtroSi;
    private string _neq_Usuario;
    private DateTime? _neq_Creado;
    private DateTime? _neq_Modificado;
    private string _neq_MotivoTerminacion;
    private string _neq_LugarEntrega;
    private string _neq_NumeroActa;
    private DateTime? _neq_FechaEntrega;
    private string _neq_Comodato;
    private string _neq_CausaNovedad;
    private EntitySet<nki_NovedadKit> _nki_NovedadKits;
    private EntitySet<nea_NovedadEquiposAsignado> _nea_NovedadEquiposAsignados;
    private EntitySet<ndo_NovedadDocumento> _ndo_NovedadDocumentos;
    private EntitySet<dvn_DocumentoVerificarNovedad> _dvn_DocumentoVerificarNovedads;
    private EntityRef<dti_DocumentoTipo> _dti_DocumentoTipo;
    private EntityRef<mun_Municipio> _mun_Municipio;
    private EntityRef<nes_NovedadEstado> _nes_NovedadEstado;
    private EntityRef<nti_NovedadTipo> _nti_NovedadTipo;
    private EntityRef<dep_Departamento> _dep_Departamento;
    private EntityRef<seq_SolicitudEquipo> _seq_SolicitudEquipo;

    public neq_NovedadEquipo()
    {
      this._nki_NovedadKits = new EntitySet<nki_NovedadKit>(new Action<nki_NovedadKit>(this.attach_nki_NovedadKits), new Action<nki_NovedadKit>(this.detach_nki_NovedadKits));
      this._nea_NovedadEquiposAsignados = new EntitySet<nea_NovedadEquiposAsignado>(new Action<nea_NovedadEquiposAsignado>(this.attach_nea_NovedadEquiposAsignados), new Action<nea_NovedadEquiposAsignado>(this.detach_nea_NovedadEquiposAsignados));
      this._ndo_NovedadDocumentos = new EntitySet<ndo_NovedadDocumento>(new Action<ndo_NovedadDocumento>(this.attach_ndo_NovedadDocumentos), new Action<ndo_NovedadDocumento>(this.detach_ndo_NovedadDocumentos));
      this._dvn_DocumentoVerificarNovedads = new EntitySet<dvn_DocumentoVerificarNovedad>(new Action<dvn_DocumentoVerificarNovedad>(this.attach_dvn_DocumentoVerificarNovedads), new Action<dvn_DocumentoVerificarNovedad>(this.detach_dvn_DocumentoVerificarNovedads));
      this._dti_DocumentoTipo = new EntityRef<dti_DocumentoTipo>();
      this._mun_Municipio = new EntityRef<mun_Municipio>();
      this._nes_NovedadEstado = new EntityRef<nes_NovedadEstado>();
      this._nti_NovedadTipo = new EntityRef<nti_NovedadTipo>();
      this._dep_Departamento = new EntityRef<dep_Departamento>();
      this._seq_SolicitudEquipo = new EntityRef<seq_SolicitudEquipo>();
    }

    [Column(Storage = "_neq_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
    public int neq_Id
    {
      get => this._neq_Id;
      set
      {
        if (this._neq_Id == value)
          return;
        this.SendPropertyChanging();
        this._neq_Id = value;
        this.SendPropertyChanged(nameof (neq_Id));
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

    [Column(Storage = "_ndo_Id", DbType = "Int")]
    public int? ndo_Id
    {
      get => this._ndo_Id;
      set
      {
        int? ndoId = this._ndo_Id;
        int? nullable = value;
        if ((ndoId.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (ndoId.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._ndo_Id = value;
        this.SendPropertyChanged(nameof (ndo_Id));
      }
    }

    [Column(Storage = "_nes_Id", DbType = "Int NOT NULL")]
    public int nes_Id
    {
      get => this._nes_Id;
      set
      {
        if (this._nes_Id == value)
          return;
        if (this._nes_NovedadEstado.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._nes_Id = value;
        this.SendPropertyChanged(nameof (nes_Id));
      }
    }

    [Column(Storage = "_nti_Id", DbType = "Int NOT NULL")]
    public int nti_Id
    {
      get => this._nti_Id;
      set
      {
        if (this._nti_Id == value)
          return;
        if (this._nti_NovedadTipo.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._nti_Id = value;
        this.SendPropertyChanged(nameof (nti_Id));
      }
    }

    [Column(Storage = "_neq_FechaNovedad", DbType = "DateTime NOT NULL")]
    public DateTime neq_FechaNovedad
    {
      get => this._neq_FechaNovedad;
      set
      {
        if (!(this._neq_FechaNovedad != value))
          return;
        this.SendPropertyChanging();
        this._neq_FechaNovedad = value;
        this.SendPropertyChanged(nameof (neq_FechaNovedad));
      }
    }

    [Column(Storage = "_neq_Direccion", DbType = "VarChar(250)")]
    public string neq_Direccion
    {
      get => this._neq_Direccion;
      set
      {
        if (!(this._neq_Direccion != value))
          return;
        this.SendPropertyChanging();
        this._neq_Direccion = value;
        this.SendPropertyChanged(nameof (neq_Direccion));
      }
    }

    [Column(Storage = "_dep_Id", DbType = "VarChar(2)")]
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

    [Column(Storage = "_mun_Id", DbType = "VarChar(5)")]
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

    [Column(Storage = "_neq_RazonSocial", DbType = "VarChar(250)")]
    public string neq_RazonSocial
    {
      get => this._neq_RazonSocial;
      set
      {
        if (!(this._neq_RazonSocial != value))
          return;
        this.SendPropertyChanging();
        this._neq_RazonSocial = value;
        this.SendPropertyChanged(nameof (neq_RazonSocial));
      }
    }

    [Column(Storage = "_neq_Otros", DbType = "VarChar(250)")]
    public string neq_Otros
    {
      get => this._neq_Otros;
      set
      {
        if (!(this._neq_Otros != value))
          return;
        this.SendPropertyChanging();
        this._neq_Otros = value;
        this.SendPropertyChanged(nameof (neq_Otros));
      }
    }

    [Column(Storage = "_neq_RepresentanteLegal", DbType = "VarChar(255)")]
    public string neq_RepresentanteLegal
    {
      get => this._neq_RepresentanteLegal;
      set
      {
        if (!(this._neq_RepresentanteLegal != value))
          return;
        this.SendPropertyChanging();
        this._neq_RepresentanteLegal = value;
        this.SendPropertyChanged(nameof (neq_RepresentanteLegal));
      }
    }

    [Column(Storage = "_dti_Id", DbType = "Int")]
    public int? dti_Id
    {
      get => this._dti_Id;
      set
      {
        int? dtiId = this._dti_Id;
        int? nullable = value;
        if ((dtiId.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (dtiId.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        if (this._dti_DocumentoTipo.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._dti_Id = value;
        this.SendPropertyChanged(nameof (dti_Id));
      }
    }

    [Column(Storage = "_neq_NumeroDocumento", DbType = "VarChar(20)")]
    public string neq_NumeroDocumento
    {
      get => this._neq_NumeroDocumento;
      set
      {
        if (!(this._neq_NumeroDocumento != value))
          return;
        this.SendPropertyChanging();
        this._neq_NumeroDocumento = value;
        this.SendPropertyChanged(nameof (neq_NumeroDocumento));
      }
    }

    [Column(Storage = "_neq_ValorTotal", DbType = "Money")]
    public Decimal? neq_ValorTotal
    {
      get => this._neq_ValorTotal;
      set
      {
        Decimal? neqValorTotal = this._neq_ValorTotal;
        Decimal? nullable = value;
        if ((neqValorTotal.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (neqValorTotal.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._neq_ValorTotal = value;
        this.SendPropertyChanged(nameof (neq_ValorTotal));
      }
    }

    [Column(Storage = "_neq_FechaElaboracionMinuta", DbType = "DateTime")]
    public DateTime? neq_FechaElaboracionMinuta
    {
      get => this._neq_FechaElaboracionMinuta;
      set
      {
        DateTime? elaboracionMinuta = this._neq_FechaElaboracionMinuta;
        DateTime? nullable = value;
        if ((elaboracionMinuta.HasValue != nullable.HasValue ? 1 : (!elaboracionMinuta.HasValue ? 0 : (elaboracionMinuta.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._neq_FechaElaboracionMinuta = value;
        this.SendPropertyChanged(nameof (neq_FechaElaboracionMinuta));
      }
    }

    [Column(Storage = "_neq_FechaFirmaMinuta", DbType = "DateTime")]
    public DateTime? neq_FechaFirmaMinuta
    {
      get => this._neq_FechaFirmaMinuta;
      set
      {
        DateTime? fechaFirmaMinuta = this._neq_FechaFirmaMinuta;
        DateTime? nullable = value;
        if ((fechaFirmaMinuta.HasValue != nullable.HasValue ? 1 : (!fechaFirmaMinuta.HasValue ? 0 : (fechaFirmaMinuta.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._neq_FechaFirmaMinuta = value;
        this.SendPropertyChanged(nameof (neq_FechaFirmaMinuta));
      }
    }

    [Column(Storage = "_neq_FechaVigenciaPoliza", DbType = "DateTime")]
    public DateTime? neq_FechaVigenciaPoliza
    {
      get => this._neq_FechaVigenciaPoliza;
      set
      {
        DateTime? fechaVigenciaPoliza = this._neq_FechaVigenciaPoliza;
        DateTime? nullable = value;
        if ((fechaVigenciaPoliza.HasValue != nullable.HasValue ? 1 : (!fechaVigenciaPoliza.HasValue ? 0 : (fechaVigenciaPoliza.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._neq_FechaVigenciaPoliza = value;
        this.SendPropertyChanged(nameof (neq_FechaVigenciaPoliza));
      }
    }

    [Column(Storage = "_neq_FechaPlazoPoliza", DbType = "DateTime")]
    public DateTime? neq_FechaPlazoPoliza
    {
      get => this._neq_FechaPlazoPoliza;
      set
      {
        DateTime? fechaPlazoPoliza = this._neq_FechaPlazoPoliza;
        DateTime? nullable = value;
        if ((fechaPlazoPoliza.HasValue != nullable.HasValue ? 1 : (!fechaPlazoPoliza.HasValue ? 0 : (fechaPlazoPoliza.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._neq_FechaPlazoPoliza = value;
        this.SendPropertyChanged(nameof (neq_FechaPlazoPoliza));
      }
    }

    [Column(Storage = "_neq_FechaPublicacion", DbType = "DateTime")]
    public DateTime? neq_FechaPublicacion
    {
      get => this._neq_FechaPublicacion;
      set
      {
        DateTime? fechaPublicacion = this._neq_FechaPublicacion;
        DateTime? nullable = value;
        if ((fechaPublicacion.HasValue != nullable.HasValue ? 1 : (!fechaPublicacion.HasValue ? 0 : (fechaPublicacion.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._neq_FechaPublicacion = value;
        this.SendPropertyChanged(nameof (neq_FechaPublicacion));
      }
    }

    [Column(Storage = "_neq_FechaAprobacionPoliza", DbType = "DateTime")]
    public DateTime? neq_FechaAprobacionPoliza
    {
      get => this._neq_FechaAprobacionPoliza;
      set
      {
        DateTime? aprobacionPoliza = this._neq_FechaAprobacionPoliza;
        DateTime? nullable = value;
        if ((aprobacionPoliza.HasValue != nullable.HasValue ? 1 : (!aprobacionPoliza.HasValue ? 0 : (aprobacionPoliza.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._neq_FechaAprobacionPoliza = value;
        this.SendPropertyChanged(nameof (neq_FechaAprobacionPoliza));
      }
    }

    [Column(Storage = "_neq_ObservacionIncial", DbType = "VarChar(MAX)")]
    public string neq_ObservacionIncial
    {
      get => this._neq_ObservacionIncial;
      set
      {
        if (!(this._neq_ObservacionIncial != value))
          return;
        this.SendPropertyChanging();
        this._neq_ObservacionIncial = value;
        this.SendPropertyChanged(nameof (neq_ObservacionIncial));
      }
    }

    [Column(Storage = "_neq_ObservacionEstudioPrevio", DbType = "VarChar(MAX)")]
    public string neq_ObservacionEstudioPrevio
    {
      get => this._neq_ObservacionEstudioPrevio;
      set
      {
        if (!(this._neq_ObservacionEstudioPrevio != value))
          return;
        this.SendPropertyChanging();
        this._neq_ObservacionEstudioPrevio = value;
        this.SendPropertyChanged(nameof (neq_ObservacionEstudioPrevio));
      }
    }

    [Column(Storage = "_neq_ObservacionMinuta", DbType = "VarChar(MAX)")]
    public string neq_ObservacionMinuta
    {
      get => this._neq_ObservacionMinuta;
      set
      {
        if (!(this._neq_ObservacionMinuta != value))
          return;
        this.SendPropertyChanging();
        this._neq_ObservacionMinuta = value;
        this.SendPropertyChanged(nameof (neq_ObservacionMinuta));
      }
    }

    [Column(Storage = "_neq_ObservacionPoliza", DbType = "VarChar(MAX)")]
    public string neq_ObservacionPoliza
    {
      get => this._neq_ObservacionPoliza;
      set
      {
        if (!(this._neq_ObservacionPoliza != value))
          return;
        this.SendPropertyChanging();
        this._neq_ObservacionPoliza = value;
        this.SendPropertyChanged(nameof (neq_ObservacionPoliza));
      }
    }

    [Column(Storage = "_neq_NumeroOtroSi", DbType = "VarChar(30)")]
    public string neq_NumeroOtroSi
    {
      get => this._neq_NumeroOtroSi;
      set
      {
        if (!(this._neq_NumeroOtroSi != value))
          return;
        this.SendPropertyChanging();
        this._neq_NumeroOtroSi = value;
        this.SendPropertyChanged(nameof (neq_NumeroOtroSi));
      }
    }

    [Column(Storage = "_neq_Usuario", DbType = "VarChar(50)")]
    public string neq_Usuario
    {
      get => this._neq_Usuario;
      set
      {
        if (!(this._neq_Usuario != value))
          return;
        this.SendPropertyChanging();
        this._neq_Usuario = value;
        this.SendPropertyChanged(nameof (neq_Usuario));
      }
    }

    [Column(Storage = "_neq_Creado", DbType = "DateTime")]
    public DateTime? neq_Creado
    {
      get => this._neq_Creado;
      set
      {
        DateTime? neqCreado = this._neq_Creado;
        DateTime? nullable = value;
        if ((neqCreado.HasValue != nullable.HasValue ? 1 : (!neqCreado.HasValue ? 0 : (neqCreado.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._neq_Creado = value;
        this.SendPropertyChanged(nameof (neq_Creado));
      }
    }

    [Column(Storage = "_neq_Modificado", DbType = "DateTime")]
    public DateTime? neq_Modificado
    {
      get => this._neq_Modificado;
      set
      {
        DateTime? neqModificado = this._neq_Modificado;
        DateTime? nullable = value;
        if ((neqModificado.HasValue != nullable.HasValue ? 1 : (!neqModificado.HasValue ? 0 : (neqModificado.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._neq_Modificado = value;
        this.SendPropertyChanged(nameof (neq_Modificado));
      }
    }

    [Column(Storage = "_neq_MotivoTerminacion", DbType = "VarChar(MAX)")]
    public string neq_MotivoTerminacion
    {
      get => this._neq_MotivoTerminacion;
      set
      {
        if (!(this._neq_MotivoTerminacion != value))
          return;
        this.SendPropertyChanging();
        this._neq_MotivoTerminacion = value;
        this.SendPropertyChanged(nameof (neq_MotivoTerminacion));
      }
    }

    [Column(Storage = "_neq_LugarEntrega", DbType = "VarChar(30)")]
    public string neq_LugarEntrega
    {
      get => this._neq_LugarEntrega;
      set
      {
        if (!(this._neq_LugarEntrega != value))
          return;
        this.SendPropertyChanging();
        this._neq_LugarEntrega = value;
        this.SendPropertyChanged(nameof (neq_LugarEntrega));
      }
    }

    [Column(Storage = "_neq_NumeroActa", DbType = "VarChar(30)")]
    public string neq_NumeroActa
    {
      get => this._neq_NumeroActa;
      set
      {
        if (!(this._neq_NumeroActa != value))
          return;
        this.SendPropertyChanging();
        this._neq_NumeroActa = value;
        this.SendPropertyChanged(nameof (neq_NumeroActa));
      }
    }

    [Column(Storage = "_neq_FechaEntrega", DbType = "DateTime")]
    public DateTime? neq_FechaEntrega
    {
      get => this._neq_FechaEntrega;
      set
      {
        DateTime? neqFechaEntrega = this._neq_FechaEntrega;
        DateTime? nullable = value;
        if ((neqFechaEntrega.HasValue != nullable.HasValue ? 1 : (!neqFechaEntrega.HasValue ? 0 : (neqFechaEntrega.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._neq_FechaEntrega = value;
        this.SendPropertyChanged(nameof (neq_FechaEntrega));
      }
    }

    [Column(Storage = "_neq_Comodato", DbType = "VarChar(30)")]
    public string neq_Comodato
    {
      get => this._neq_Comodato;
      set
      {
        if (!(this._neq_Comodato != value))
          return;
        this.SendPropertyChanging();
        this._neq_Comodato = value;
        this.SendPropertyChanged(nameof (neq_Comodato));
      }
    }

    [Column(Storage = "_neq_CausaNovedad", DbType = "VarChar(30)")]
    public string neq_CausaNovedad
    {
      get => this._neq_CausaNovedad;
      set
      {
        if (!(this._neq_CausaNovedad != value))
          return;
        this.SendPropertyChanging();
        this._neq_CausaNovedad = value;
        this.SendPropertyChanged(nameof (neq_CausaNovedad));
      }
    }

    [Association(Name = "neq_NovedadEquipo_nki_NovedadKit", Storage = "_nki_NovedadKits", ThisKey = "neq_Id", OtherKey = "neq_Id")]
    public EntitySet<nki_NovedadKit> nki_NovedadKits
    {
      get => this._nki_NovedadKits;
      set => this._nki_NovedadKits.Assign((IEnumerable<nki_NovedadKit>) value);
    }

    [Association(Name = "neq_NovedadEquipo_nea_NovedadEquiposAsignado", Storage = "_nea_NovedadEquiposAsignados", ThisKey = "neq_Id", OtherKey = "neq_Id")]
    public EntitySet<nea_NovedadEquiposAsignado> nea_NovedadEquiposAsignados
    {
      get => this._nea_NovedadEquiposAsignados;
      set => this._nea_NovedadEquiposAsignados.Assign((IEnumerable<nea_NovedadEquiposAsignado>) value);
    }

    [Association(Name = "neq_NovedadEquipo_ndo_NovedadDocumento", Storage = "_ndo_NovedadDocumentos", ThisKey = "neq_Id", OtherKey = "neq_Id")]
    public EntitySet<ndo_NovedadDocumento> ndo_NovedadDocumentos
    {
      get => this._ndo_NovedadDocumentos;
      set => this._ndo_NovedadDocumentos.Assign((IEnumerable<ndo_NovedadDocumento>) value);
    }

    [Association(Name = "neq_NovedadEquipo_dvn_DocumentoVerificarNovedad", Storage = "_dvn_DocumentoVerificarNovedads", ThisKey = "neq_Id", OtherKey = "neq_Id")]
    public EntitySet<dvn_DocumentoVerificarNovedad> dvn_DocumentoVerificarNovedads
    {
      get => this._dvn_DocumentoVerificarNovedads;
      set => this._dvn_DocumentoVerificarNovedads.Assign((IEnumerable<dvn_DocumentoVerificarNovedad>) value);
    }

    [Association(Name = "dti_DocumentoTipo_neq_NovedadEquipo", Storage = "_dti_DocumentoTipo", ThisKey = "dti_Id", OtherKey = "dti_Id", IsForeignKey = true)]
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
          entity.neq_NovedadEquipos.Remove(this);
        }
        this._dti_DocumentoTipo.Entity = value;
        if (value != null)
        {
          value.neq_NovedadEquipos.Add(this);
          this._dti_Id = new int?(value.dti_Id);
        }
        else
          this._dti_Id = new int?();
        this.SendPropertyChanged(nameof (dti_DocumentoTipo));
      }
    }

    [Association(Name = "mun_Municipio_neq_NovedadEquipo", Storage = "_mun_Municipio", ThisKey = "mun_Id", OtherKey = "mun_Id", IsForeignKey = true)]
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
          entity.neq_NovedadEquipos.Remove(this);
        }
        this._mun_Municipio.Entity = value;
        if (value != null)
        {
          value.neq_NovedadEquipos.Add(this);
          this._mun_Id = value.mun_Id;
        }
        else
          this._mun_Id = (string) null;
        this.SendPropertyChanged(nameof (mun_Municipio));
      }
    }

    [Association(Name = "nes_NovedadEstado_neq_NovedadEquipo", Storage = "_nes_NovedadEstado", ThisKey = "nes_Id", OtherKey = "nes_Id", IsForeignKey = true)]
    public nes_NovedadEstado nes_NovedadEstado
    {
      get => this._nes_NovedadEstado.Entity;
      set
      {
        nes_NovedadEstado entity = this._nes_NovedadEstado.Entity;
        if (entity == value && this._nes_NovedadEstado.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._nes_NovedadEstado.Entity = (nes_NovedadEstado) null;
          entity.neq_NovedadEquipos.Remove(this);
        }
        this._nes_NovedadEstado.Entity = value;
        if (value != null)
        {
          value.neq_NovedadEquipos.Add(this);
          this._nes_Id = value.nes_Id;
        }
        else
          this._nes_Id = 0;
        this.SendPropertyChanged(nameof (nes_NovedadEstado));
      }
    }

    [Association(Name = "nti_NovedadTipo_neq_NovedadEquipo", Storage = "_nti_NovedadTipo", ThisKey = "nti_Id", OtherKey = "nti_Id", IsForeignKey = true)]
    public nti_NovedadTipo nti_NovedadTipo
    {
      get => this._nti_NovedadTipo.Entity;
      set
      {
        nti_NovedadTipo entity = this._nti_NovedadTipo.Entity;
        if (entity == value && this._nti_NovedadTipo.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._nti_NovedadTipo.Entity = (nti_NovedadTipo) null;
          entity.neq_NovedadEquipos.Remove(this);
        }
        this._nti_NovedadTipo.Entity = value;
        if (value != null)
        {
          value.neq_NovedadEquipos.Add(this);
          this._nti_Id = value.nti_Id;
        }
        else
          this._nti_Id = 0;
        this.SendPropertyChanged(nameof (nti_NovedadTipo));
      }
    }

    [Association(Name = "dep_Departamento_neq_NovedadEquipo", Storage = "_dep_Departamento", ThisKey = "dep_Id", OtherKey = "dep_Id", IsForeignKey = true)]
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
          entity.neq_NovedadEquipos.Remove(this);
        }
        this._dep_Departamento.Entity = value;
        if (value != null)
        {
          value.neq_NovedadEquipos.Add(this);
          this._dep_Id = value.dep_Id;
        }
        else
          this._dep_Id = (string) null;
        this.SendPropertyChanged(nameof (dep_Departamento));
      }
    }

    [Association(Name = "seq_SolicitudEquipo_neq_NovedadEquipo", Storage = "_seq_SolicitudEquipo", ThisKey = "seq_Id", OtherKey = "seq_Id", IsForeignKey = true)]
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
          entity.neq_NovedadEquipos.Remove(this);
        }
        this._seq_SolicitudEquipo.Entity = value;
        if (value != null)
        {
          value.neq_NovedadEquipos.Add(this);
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
      this.PropertyChanging((object) this, neq_NovedadEquipo.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void attach_nki_NovedadKits(nki_NovedadKit entity)
    {
      this.SendPropertyChanging();
      entity.neq_NovedadEquipo = this;
    }

    private void detach_nki_NovedadKits(nki_NovedadKit entity)
    {
      this.SendPropertyChanging();
      entity.neq_NovedadEquipo = (neq_NovedadEquipo) null;
    }

    private void attach_nea_NovedadEquiposAsignados(nea_NovedadEquiposAsignado entity)
    {
      this.SendPropertyChanging();
      entity.neq_NovedadEquipo = this;
    }

    private void detach_nea_NovedadEquiposAsignados(nea_NovedadEquiposAsignado entity)
    {
      this.SendPropertyChanging();
      entity.neq_NovedadEquipo = (neq_NovedadEquipo) null;
    }

    private void attach_ndo_NovedadDocumentos(ndo_NovedadDocumento entity)
    {
      this.SendPropertyChanging();
      entity.neq_NovedadEquipo = this;
    }

    private void detach_ndo_NovedadDocumentos(ndo_NovedadDocumento entity)
    {
      this.SendPropertyChanging();
      entity.neq_NovedadEquipo = (neq_NovedadEquipo) null;
    }

    private void attach_dvn_DocumentoVerificarNovedads(dvn_DocumentoVerificarNovedad entity)
    {
      this.SendPropertyChanging();
      entity.neq_NovedadEquipo = this;
    }

    private void detach_dvn_DocumentoVerificarNovedads(dvn_DocumentoVerificarNovedad entity)
    {
      this.SendPropertyChanging();
      entity.neq_NovedadEquipo = (neq_NovedadEquipo) null;
    }
  }
}
