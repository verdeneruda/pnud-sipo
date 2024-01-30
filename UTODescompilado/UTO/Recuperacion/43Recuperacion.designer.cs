// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.seq_SolicitudEquipo
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
  [Table(Name = "Rrr.seq_SolicitudEquipo")]
  public class seq_SolicitudEquipo : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _seq_Id;
    private int _ter_Id;
    private int? _sdo_Id;
    private int _ses_Id;
    private bool _seq_Nacional;
    private Decimal _seq_ValorTotal;
    private DateTime _seq_FechaSolicitud;
    private bool? _seq_TieneCertificacion;
    private DateTime? _seq_FechaElaboracionMinuta;
    private DateTime? _seq_FechaFirmaMinuta;
    private DateTime? _seq_FechaVigenciaPoliza;
    private DateTime? _seq_FechaPlazoPoliza;
    private DateTime? _seq_FechaPublicacion;
    private DateTime? _seq_FechaAprobacionPoliza;
    private string _seq_ObservacionIncial;
    private string _seq_ObservacionEstudioPrevio;
    private string _seq_ObservacionMinuta;
    private string _seq_ObservacionPoliza;
    private string _seq_Comodato;
    private string _seq_Usuario;
    private DateTime _seq_Creado;
    private DateTime? _seq_Modificado;
    private DateTime? _seq_FechaCertificacion;
    private DateTime? _seq_FechaEntrega;
    private string _seq_LugarEntrega;
    private string _seq_NumeroActa;
    private bool? _seq_Activo;
    private bool? _seq_ActaTransferencia;
    private int? _pre_Id;
    private bool? _seq_PorComodato;
    private bool? _seq_Directa;
    private DateTime? _seq_FechaActa;
    private DateTime? _seq_FechaComodato;
    private DateTime? _seq_FechaDirecta;
    private int? _seq_Tipo;
    private EntitySet<ski_SolicitudKit> _ski_SolicitudKits;
    private EntitySet<dvs_DocumentoVerificarSolicitud> _dvs_DocumentoVerificarSolicituds;
    private EntitySet<sdo_SolicitudDocumento> _sdo_SolicitudDocumentos;
    private EntitySet<neq_NovedadEquipo> _neq_NovedadEquipos;
    private EntitySet<sea_SolicitudEquiposAsignado> _sea_SolicitudEquiposAsignados;
    private EntityRef<pre_ProyectoRecuperacion> _pre_ProyectoRecuperacion;
    private EntityRef<ses_SolicitudEstado> _ses_SolicitudEstado;
    private EntityRef<ter_Tercero> _ter_Tercero;

    public seq_SolicitudEquipo()
    {
      this._ski_SolicitudKits = new EntitySet<ski_SolicitudKit>(new Action<ski_SolicitudKit>(this.attach_ski_SolicitudKits), new Action<ski_SolicitudKit>(this.detach_ski_SolicitudKits));
      this._dvs_DocumentoVerificarSolicituds = new EntitySet<dvs_DocumentoVerificarSolicitud>(new Action<dvs_DocumentoVerificarSolicitud>(this.attach_dvs_DocumentoVerificarSolicituds), new Action<dvs_DocumentoVerificarSolicitud>(this.detach_dvs_DocumentoVerificarSolicituds));
      this._sdo_SolicitudDocumentos = new EntitySet<sdo_SolicitudDocumento>(new Action<sdo_SolicitudDocumento>(this.attach_sdo_SolicitudDocumentos), new Action<sdo_SolicitudDocumento>(this.detach_sdo_SolicitudDocumentos));
      this._neq_NovedadEquipos = new EntitySet<neq_NovedadEquipo>(new Action<neq_NovedadEquipo>(this.attach_neq_NovedadEquipos), new Action<neq_NovedadEquipo>(this.detach_neq_NovedadEquipos));
      this._sea_SolicitudEquiposAsignados = new EntitySet<sea_SolicitudEquiposAsignado>(new Action<sea_SolicitudEquiposAsignado>(this.attach_sea_SolicitudEquiposAsignados), new Action<sea_SolicitudEquiposAsignado>(this.detach_sea_SolicitudEquiposAsignados));
      this._pre_ProyectoRecuperacion = new EntityRef<pre_ProyectoRecuperacion>();
      this._ses_SolicitudEstado = new EntityRef<ses_SolicitudEstado>();
      this._ter_Tercero = new EntityRef<ter_Tercero>();
    }

    [Column(Storage = "_seq_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
    public int seq_Id
    {
      get => this._seq_Id;
      set
      {
        if (this._seq_Id == value)
          return;
        this.SendPropertyChanging();
        this._seq_Id = value;
        this.SendPropertyChanged(nameof (seq_Id));
      }
    }

    [Column(Storage = "_ter_Id", DbType = "Int NOT NULL")]
    public int ter_Id
    {
      get => this._ter_Id;
      set
      {
        if (this._ter_Id == value)
          return;
        if (this._ter_Tercero.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._ter_Id = value;
        this.SendPropertyChanged(nameof (ter_Id));
      }
    }

    [Column(Storage = "_sdo_Id", DbType = "Int")]
    public int? sdo_Id
    {
      get => this._sdo_Id;
      set
      {
        int? sdoId = this._sdo_Id;
        int? nullable = value;
        if ((sdoId.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (sdoId.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._sdo_Id = value;
        this.SendPropertyChanged(nameof (sdo_Id));
      }
    }

    [Column(Storage = "_ses_Id", DbType = "Int NOT NULL")]
    public int ses_Id
    {
      get => this._ses_Id;
      set
      {
        if (this._ses_Id == value)
          return;
        if (this._ses_SolicitudEstado.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._ses_Id = value;
        this.SendPropertyChanged(nameof (ses_Id));
      }
    }

    [Column(Storage = "_seq_Nacional", DbType = "Bit NOT NULL")]
    public bool seq_Nacional
    {
      get => this._seq_Nacional;
      set
      {
        if (this._seq_Nacional == value)
          return;
        this.SendPropertyChanging();
        this._seq_Nacional = value;
        this.SendPropertyChanged(nameof (seq_Nacional));
      }
    }

    [Column(Storage = "_seq_ValorTotal", DbType = "Money NOT NULL")]
    public Decimal seq_ValorTotal
    {
      get => this._seq_ValorTotal;
      set
      {
        if (!(this._seq_ValorTotal != value))
          return;
        this.SendPropertyChanging();
        this._seq_ValorTotal = value;
        this.SendPropertyChanged(nameof (seq_ValorTotal));
      }
    }

    [Column(Storage = "_seq_FechaSolicitud", DbType = "DateTime NOT NULL")]
    public DateTime seq_FechaSolicitud
    {
      get => this._seq_FechaSolicitud;
      set
      {
        if (!(this._seq_FechaSolicitud != value))
          return;
        this.SendPropertyChanging();
        this._seq_FechaSolicitud = value;
        this.SendPropertyChanged(nameof (seq_FechaSolicitud));
      }
    }

    [Column(Storage = "_seq_TieneCertificacion", DbType = "Bit")]
    public bool? seq_TieneCertificacion
    {
      get => this._seq_TieneCertificacion;
      set
      {
        bool? tieneCertificacion = this._seq_TieneCertificacion;
        bool? nullable = value;
        if ((tieneCertificacion.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (tieneCertificacion.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._seq_TieneCertificacion = value;
        this.SendPropertyChanged(nameof (seq_TieneCertificacion));
      }
    }

    [Column(Storage = "_seq_FechaElaboracionMinuta", DbType = "DateTime")]
    public DateTime? seq_FechaElaboracionMinuta
    {
      get => this._seq_FechaElaboracionMinuta;
      set
      {
        DateTime? elaboracionMinuta = this._seq_FechaElaboracionMinuta;
        DateTime? nullable = value;
        if ((elaboracionMinuta.HasValue != nullable.HasValue ? 1 : (!elaboracionMinuta.HasValue ? 0 : (elaboracionMinuta.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._seq_FechaElaboracionMinuta = value;
        this.SendPropertyChanged(nameof (seq_FechaElaboracionMinuta));
      }
    }

    [Column(Storage = "_seq_FechaFirmaMinuta", DbType = "DateTime")]
    public DateTime? seq_FechaFirmaMinuta
    {
      get => this._seq_FechaFirmaMinuta;
      set
      {
        DateTime? fechaFirmaMinuta = this._seq_FechaFirmaMinuta;
        DateTime? nullable = value;
        if ((fechaFirmaMinuta.HasValue != nullable.HasValue ? 1 : (!fechaFirmaMinuta.HasValue ? 0 : (fechaFirmaMinuta.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._seq_FechaFirmaMinuta = value;
        this.SendPropertyChanged(nameof (seq_FechaFirmaMinuta));
      }
    }

    [Column(Storage = "_seq_FechaVigenciaPoliza", DbType = "DateTime")]
    public DateTime? seq_FechaVigenciaPoliza
    {
      get => this._seq_FechaVigenciaPoliza;
      set
      {
        DateTime? fechaVigenciaPoliza = this._seq_FechaVigenciaPoliza;
        DateTime? nullable = value;
        if ((fechaVigenciaPoliza.HasValue != nullable.HasValue ? 1 : (!fechaVigenciaPoliza.HasValue ? 0 : (fechaVigenciaPoliza.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._seq_FechaVigenciaPoliza = value;
        this.SendPropertyChanged(nameof (seq_FechaVigenciaPoliza));
      }
    }

    [Column(Storage = "_seq_FechaPlazoPoliza", DbType = "DateTime")]
    public DateTime? seq_FechaPlazoPoliza
    {
      get => this._seq_FechaPlazoPoliza;
      set
      {
        DateTime? fechaPlazoPoliza = this._seq_FechaPlazoPoliza;
        DateTime? nullable = value;
        if ((fechaPlazoPoliza.HasValue != nullable.HasValue ? 1 : (!fechaPlazoPoliza.HasValue ? 0 : (fechaPlazoPoliza.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._seq_FechaPlazoPoliza = value;
        this.SendPropertyChanged(nameof (seq_FechaPlazoPoliza));
      }
    }

    [Column(Storage = "_seq_FechaPublicacion", DbType = "DateTime")]
    public DateTime? seq_FechaPublicacion
    {
      get => this._seq_FechaPublicacion;
      set
      {
        DateTime? fechaPublicacion = this._seq_FechaPublicacion;
        DateTime? nullable = value;
        if ((fechaPublicacion.HasValue != nullable.HasValue ? 1 : (!fechaPublicacion.HasValue ? 0 : (fechaPublicacion.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._seq_FechaPublicacion = value;
        this.SendPropertyChanged(nameof (seq_FechaPublicacion));
      }
    }

    [Column(Storage = "_seq_FechaAprobacionPoliza", DbType = "DateTime")]
    public DateTime? seq_FechaAprobacionPoliza
    {
      get => this._seq_FechaAprobacionPoliza;
      set
      {
        DateTime? aprobacionPoliza = this._seq_FechaAprobacionPoliza;
        DateTime? nullable = value;
        if ((aprobacionPoliza.HasValue != nullable.HasValue ? 1 : (!aprobacionPoliza.HasValue ? 0 : (aprobacionPoliza.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._seq_FechaAprobacionPoliza = value;
        this.SendPropertyChanged(nameof (seq_FechaAprobacionPoliza));
      }
    }

    [Column(Storage = "_seq_ObservacionIncial", DbType = "VarChar(MAX)")]
    public string seq_ObservacionIncial
    {
      get => this._seq_ObservacionIncial;
      set
      {
        if (!(this._seq_ObservacionIncial != value))
          return;
        this.SendPropertyChanging();
        this._seq_ObservacionIncial = value;
        this.SendPropertyChanged(nameof (seq_ObservacionIncial));
      }
    }

    [Column(Storage = "_seq_ObservacionEstudioPrevio", DbType = "VarChar(MAX)")]
    public string seq_ObservacionEstudioPrevio
    {
      get => this._seq_ObservacionEstudioPrevio;
      set
      {
        if (!(this._seq_ObservacionEstudioPrevio != value))
          return;
        this.SendPropertyChanging();
        this._seq_ObservacionEstudioPrevio = value;
        this.SendPropertyChanged(nameof (seq_ObservacionEstudioPrevio));
      }
    }

    [Column(Storage = "_seq_ObservacionMinuta", DbType = "VarChar(MAX)")]
    public string seq_ObservacionMinuta
    {
      get => this._seq_ObservacionMinuta;
      set
      {
        if (!(this._seq_ObservacionMinuta != value))
          return;
        this.SendPropertyChanging();
        this._seq_ObservacionMinuta = value;
        this.SendPropertyChanged(nameof (seq_ObservacionMinuta));
      }
    }

    [Column(Storage = "_seq_ObservacionPoliza", DbType = "VarChar(MAX)")]
    public string seq_ObservacionPoliza
    {
      get => this._seq_ObservacionPoliza;
      set
      {
        if (!(this._seq_ObservacionPoliza != value))
          return;
        this.SendPropertyChanging();
        this._seq_ObservacionPoliza = value;
        this.SendPropertyChanged(nameof (seq_ObservacionPoliza));
      }
    }

    [Column(Storage = "_seq_Comodato", DbType = "VarChar(30)")]
    public string seq_Comodato
    {
      get => this._seq_Comodato;
      set
      {
        if (!(this._seq_Comodato != value))
          return;
        this.SendPropertyChanging();
        this._seq_Comodato = value;
        this.SendPropertyChanged(nameof (seq_Comodato));
      }
    }

    [Column(Storage = "_seq_Usuario", DbType = "VarChar(50)")]
    public string seq_Usuario
    {
      get => this._seq_Usuario;
      set
      {
        if (!(this._seq_Usuario != value))
          return;
        this.SendPropertyChanging();
        this._seq_Usuario = value;
        this.SendPropertyChanged(nameof (seq_Usuario));
      }
    }

    [Column(Storage = "_seq_Creado", DbType = "DateTime NOT NULL")]
    public DateTime seq_Creado
    {
      get => this._seq_Creado;
      set
      {
        if (!(this._seq_Creado != value))
          return;
        this.SendPropertyChanging();
        this._seq_Creado = value;
        this.SendPropertyChanged(nameof (seq_Creado));
      }
    }

    [Column(Storage = "_seq_Modificado", DbType = "DateTime")]
    public DateTime? seq_Modificado
    {
      get => this._seq_Modificado;
      set
      {
        DateTime? seqModificado = this._seq_Modificado;
        DateTime? nullable = value;
        if ((seqModificado.HasValue != nullable.HasValue ? 1 : (!seqModificado.HasValue ? 0 : (seqModificado.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._seq_Modificado = value;
        this.SendPropertyChanged(nameof (seq_Modificado));
      }
    }

    [Column(Storage = "_seq_FechaCertificacion", DbType = "DateTime")]
    public DateTime? seq_FechaCertificacion
    {
      get => this._seq_FechaCertificacion;
      set
      {
        DateTime? fechaCertificacion = this._seq_FechaCertificacion;
        DateTime? nullable = value;
        if ((fechaCertificacion.HasValue != nullable.HasValue ? 1 : (!fechaCertificacion.HasValue ? 0 : (fechaCertificacion.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._seq_FechaCertificacion = value;
        this.SendPropertyChanged(nameof (seq_FechaCertificacion));
      }
    }

    [Column(Storage = "_seq_FechaEntrega", DbType = "DateTime")]
    public DateTime? seq_FechaEntrega
    {
      get => this._seq_FechaEntrega;
      set
      {
        DateTime? seqFechaEntrega = this._seq_FechaEntrega;
        DateTime? nullable = value;
        if ((seqFechaEntrega.HasValue != nullable.HasValue ? 1 : (!seqFechaEntrega.HasValue ? 0 : (seqFechaEntrega.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._seq_FechaEntrega = value;
        this.SendPropertyChanged(nameof (seq_FechaEntrega));
      }
    }

    [Column(Storage = "_seq_LugarEntrega", DbType = "VarChar(MAX)")]
    public string seq_LugarEntrega
    {
      get => this._seq_LugarEntrega;
      set
      {
        if (!(this._seq_LugarEntrega != value))
          return;
        this.SendPropertyChanging();
        this._seq_LugarEntrega = value;
        this.SendPropertyChanged(nameof (seq_LugarEntrega));
      }
    }

    [Column(Storage = "_seq_NumeroActa", DbType = "VarChar(30)")]
    public string seq_NumeroActa
    {
      get => this._seq_NumeroActa;
      set
      {
        if (!(this._seq_NumeroActa != value))
          return;
        this.SendPropertyChanging();
        this._seq_NumeroActa = value;
        this.SendPropertyChanged(nameof (seq_NumeroActa));
      }
    }

    [Column(Storage = "_seq_Activo", DbType = "Bit")]
    public bool? seq_Activo
    {
      get => this._seq_Activo;
      set
      {
        bool? seqActivo = this._seq_Activo;
        bool? nullable = value;
        if ((seqActivo.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (seqActivo.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._seq_Activo = value;
        this.SendPropertyChanged(nameof (seq_Activo));
      }
    }

    [Column(Storage = "_seq_ActaTransferencia", DbType = "Bit")]
    public bool? seq_ActaTransferencia
    {
      get => this._seq_ActaTransferencia;
      set
      {
        bool? actaTransferencia = this._seq_ActaTransferencia;
        bool? nullable = value;
        if ((actaTransferencia.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (actaTransferencia.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._seq_ActaTransferencia = value;
        this.SendPropertyChanged(nameof (seq_ActaTransferencia));
      }
    }

    [Column(Storage = "_pre_Id", DbType = "Int")]
    public int? pre_Id
    {
      get => this._pre_Id;
      set
      {
        int? preId = this._pre_Id;
        int? nullable = value;
        if ((preId.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (preId.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        if (this._pre_ProyectoRecuperacion.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._pre_Id = value;
        this.SendPropertyChanged(nameof (pre_Id));
      }
    }

    [Column(Storage = "_seq_PorComodato", DbType = "Bit")]
    public bool? seq_PorComodato
    {
      get => this._seq_PorComodato;
      set
      {
        bool? seqPorComodato = this._seq_PorComodato;
        bool? nullable = value;
        if ((seqPorComodato.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (seqPorComodato.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._seq_PorComodato = value;
        this.SendPropertyChanged(nameof (seq_PorComodato));
      }
    }

    [Column(Storage = "_seq_Directa", DbType = "Bit")]
    public bool? seq_Directa
    {
      get => this._seq_Directa;
      set
      {
        bool? seqDirecta = this._seq_Directa;
        bool? nullable = value;
        if ((seqDirecta.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (seqDirecta.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._seq_Directa = value;
        this.SendPropertyChanged(nameof (seq_Directa));
      }
    }

    [Column(Storage = "_seq_FechaActa", DbType = "Datetime")]
    public DateTime? seq_FechaActa
    {
      get => this._seq_FechaActa;
      set
      {
        DateTime? seqFechaActa = this._seq_FechaActa;
        DateTime? nullable = value;
        if ((seqFechaActa.HasValue != nullable.HasValue ? 1 : (!seqFechaActa.HasValue ? 0 : (seqFechaActa.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._seq_FechaActa = value;
        this.SendPropertyChanged(nameof (seq_FechaActa));
      }
    }

    [Column(Storage = "_seq_FechaComodato", DbType = "datetime")]
    public DateTime? seq_FechaComodato
    {
      get => this._seq_FechaComodato;
      set
      {
        DateTime? seqFechaComodato = this._seq_FechaComodato;
        DateTime? nullable = value;
        if ((seqFechaComodato.HasValue != nullable.HasValue ? 1 : (!seqFechaComodato.HasValue ? 0 : (seqFechaComodato.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._seq_FechaComodato = value;
        this.SendPropertyChanged(nameof (seq_FechaComodato));
      }
    }

    [Column(Storage = "_seq_FechaDirecta", DbType = "datetime")]
    public DateTime? seq_FechaDirecta
    {
      get => this._seq_FechaDirecta;
      set
      {
        DateTime? seqFechaDirecta = this._seq_FechaDirecta;
        DateTime? nullable = value;
        if ((seqFechaDirecta.HasValue != nullable.HasValue ? 1 : (!seqFechaDirecta.HasValue ? 0 : (seqFechaDirecta.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._seq_FechaDirecta = value;
        this.SendPropertyChanged(nameof (seq_FechaDirecta));
      }
    }

    [Column(Name = "seq_TIpo", Storage = "_seq_Tipo", DbType = "int")]
    public int? seq_Tipo
    {
      get => this._seq_Tipo;
      set
      {
        int? seqTipo = this._seq_Tipo;
        int? nullable = value;
        if ((seqTipo.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (seqTipo.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._seq_Tipo = value;
        this.SendPropertyChanged(nameof (seq_Tipo));
      }
    }

    [Association(Name = "seq_SolicitudEquipo_ski_SolicitudKit", Storage = "_ski_SolicitudKits", ThisKey = "seq_Id", OtherKey = "seq_Id")]
    public EntitySet<ski_SolicitudKit> ski_SolicitudKits
    {
      get => this._ski_SolicitudKits;
      set => this._ski_SolicitudKits.Assign((IEnumerable<ski_SolicitudKit>) value);
    }

    [Association(Name = "seq_SolicitudEquipo_dvs_DocumentoVerificarSolicitud", Storage = "_dvs_DocumentoVerificarSolicituds", ThisKey = "seq_Id", OtherKey = "seq_Id")]
    public EntitySet<dvs_DocumentoVerificarSolicitud> dvs_DocumentoVerificarSolicituds
    {
      get => this._dvs_DocumentoVerificarSolicituds;
      set => this._dvs_DocumentoVerificarSolicituds.Assign((IEnumerable<dvs_DocumentoVerificarSolicitud>) value);
    }

    [Association(Name = "seq_SolicitudEquipo_sdo_SolicitudDocumento", Storage = "_sdo_SolicitudDocumentos", ThisKey = "seq_Id", OtherKey = "seq_Id")]
    public EntitySet<sdo_SolicitudDocumento> sdo_SolicitudDocumentos
    {
      get => this._sdo_SolicitudDocumentos;
      set => this._sdo_SolicitudDocumentos.Assign((IEnumerable<sdo_SolicitudDocumento>) value);
    }

    [Association(Name = "seq_SolicitudEquipo_neq_NovedadEquipo", Storage = "_neq_NovedadEquipos", ThisKey = "seq_Id", OtherKey = "seq_Id")]
    public EntitySet<neq_NovedadEquipo> neq_NovedadEquipos
    {
      get => this._neq_NovedadEquipos;
      set => this._neq_NovedadEquipos.Assign((IEnumerable<neq_NovedadEquipo>) value);
    }

    [Association(Name = "seq_SolicitudEquipo_sea_SolicitudEquiposAsignado", Storage = "_sea_SolicitudEquiposAsignados", ThisKey = "seq_Id", OtherKey = "seq_Id")]
    public EntitySet<sea_SolicitudEquiposAsignado> sea_SolicitudEquiposAsignados
    {
      get => this._sea_SolicitudEquiposAsignados;
      set => this._sea_SolicitudEquiposAsignados.Assign((IEnumerable<sea_SolicitudEquiposAsignado>) value);
    }

    [Association(Name = "pre_ProyectoRecuperacion_seq_SolicitudEquipo", Storage = "_pre_ProyectoRecuperacion", ThisKey = "pre_Id", OtherKey = "pre_Id", IsForeignKey = true)]
    public pre_ProyectoRecuperacion pre_ProyectoRecuperacion
    {
      get => this._pre_ProyectoRecuperacion.Entity;
      set
      {
        pre_ProyectoRecuperacion entity = this._pre_ProyectoRecuperacion.Entity;
        if (entity == value && this._pre_ProyectoRecuperacion.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._pre_ProyectoRecuperacion.Entity = (pre_ProyectoRecuperacion) null;
          entity.seq_SolicitudEquipos.Remove(this);
        }
        this._pre_ProyectoRecuperacion.Entity = value;
        if (value != null)
        {
          value.seq_SolicitudEquipos.Add(this);
          this._pre_Id = new int?(value.pre_Id);
        }
        else
          this._pre_Id = new int?();
        this.SendPropertyChanged(nameof (pre_ProyectoRecuperacion));
      }
    }

    [Association(Name = "ses_SolicitudEstado_seq_SolicitudEquipo", Storage = "_ses_SolicitudEstado", ThisKey = "ses_Id", OtherKey = "ses_Id", IsForeignKey = true)]
    public ses_SolicitudEstado ses_SolicitudEstado
    {
      get => this._ses_SolicitudEstado.Entity;
      set
      {
        ses_SolicitudEstado entity = this._ses_SolicitudEstado.Entity;
        if (entity == value && this._ses_SolicitudEstado.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._ses_SolicitudEstado.Entity = (ses_SolicitudEstado) null;
          entity.seq_SolicitudEquipos.Remove(this);
        }
        this._ses_SolicitudEstado.Entity = value;
        if (value != null)
        {
          value.seq_SolicitudEquipos.Add(this);
          this._ses_Id = value.ses_Id;
        }
        else
          this._ses_Id = 0;
        this.SendPropertyChanged(nameof (ses_SolicitudEstado));
      }
    }

    [Association(Name = "ter_Tercero_seq_SolicitudEquipo", Storage = "_ter_Tercero", ThisKey = "ter_Id", OtherKey = "ter_Id", IsForeignKey = true)]
    public ter_Tercero ter_Tercero
    {
      get => this._ter_Tercero.Entity;
      set
      {
        ter_Tercero entity = this._ter_Tercero.Entity;
        if (entity == value && this._ter_Tercero.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._ter_Tercero.Entity = (ter_Tercero) null;
          entity.seq_SolicitudEquipos.Remove(this);
        }
        this._ter_Tercero.Entity = value;
        if (value != null)
        {
          value.seq_SolicitudEquipos.Add(this);
          this._ter_Id = value.ter_Id;
        }
        else
          this._ter_Id = 0;
        this.SendPropertyChanged(nameof (ter_Tercero));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, seq_SolicitudEquipo.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void attach_ski_SolicitudKits(ski_SolicitudKit entity)
    {
      this.SendPropertyChanging();
      entity.seq_SolicitudEquipo = this;
    }

    private void detach_ski_SolicitudKits(ski_SolicitudKit entity)
    {
      this.SendPropertyChanging();
      entity.seq_SolicitudEquipo = (seq_SolicitudEquipo) null;
    }

    private void attach_dvs_DocumentoVerificarSolicituds(dvs_DocumentoVerificarSolicitud entity)
    {
      this.SendPropertyChanging();
      entity.seq_SolicitudEquipo = this;
    }

    private void detach_dvs_DocumentoVerificarSolicituds(dvs_DocumentoVerificarSolicitud entity)
    {
      this.SendPropertyChanging();
      entity.seq_SolicitudEquipo = (seq_SolicitudEquipo) null;
    }

    private void attach_sdo_SolicitudDocumentos(sdo_SolicitudDocumento entity)
    {
      this.SendPropertyChanging();
      entity.seq_SolicitudEquipo = this;
    }

    private void detach_sdo_SolicitudDocumentos(sdo_SolicitudDocumento entity)
    {
      this.SendPropertyChanging();
      entity.seq_SolicitudEquipo = (seq_SolicitudEquipo) null;
    }

    private void attach_neq_NovedadEquipos(neq_NovedadEquipo entity)
    {
      this.SendPropertyChanging();
      entity.seq_SolicitudEquipo = this;
    }

    private void detach_neq_NovedadEquipos(neq_NovedadEquipo entity)
    {
      this.SendPropertyChanging();
      entity.seq_SolicitudEquipo = (seq_SolicitudEquipo) null;
    }

    private void attach_sea_SolicitudEquiposAsignados(sea_SolicitudEquiposAsignado entity)
    {
      this.SendPropertyChanging();
      entity.seq_SolicitudEquipo = this;
    }

    private void detach_sea_SolicitudEquiposAsignados(sea_SolicitudEquiposAsignado entity)
    {
      this.SendPropertyChanging();
      entity.seq_SolicitudEquipo = (seq_SolicitudEquipo) null;
    }
  }
}
