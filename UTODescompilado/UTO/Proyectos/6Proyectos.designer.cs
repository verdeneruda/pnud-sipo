// Decompiled with JetBrains decompiler
// Type: UTO.Proyectos.pap_ProyectoAprobado
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO.Proyectos
{
  [Table(Name = "Pro.pap_ProyectoAprobado")]
  public class pap_ProyectoAprobado : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _pap_Id;
    private string _pap_NombreProyecto;
    private int _pti_Id;
    private int _pse_Id;
    private string _pap_AgenciaImplementadora;
    private string _pap_Compania;
    private string _dep_Id;
    private string _mun_Id;
    private Decimal? _pap_AprobadosFMPM;
    private Decimal? _pap_DesembolsadosFMPM;
    private Decimal? _pap_PesosInvertidos;
    private Decimal? _pap_TonPAOAEliminar;
    private Decimal? _pap_TonPAOEliminadas;
    private DateTime? _pap_FechaAprobacion;
    private DateTime? _pap_FechaTerminacion;
    private DateTime? _pap_FechaTerminacionReal;
    private string _pap_Estado;
    private string _pap_Observacion;
    private string _pap_Usuario;
    private DateTime _pap_Creado;
    private DateTime _pap_Modificado;
    private string _pap_Codigo;
    private int? _pyg_Id;
    private EntityRef<dep_Departamento> _dep_Departamento;
    private EntityRef<mun_Municipio> _mun_Municipio;
    private EntityRef<pse_ProyectoSector> _pse_ProyectoSector;
    private EntityRef<pti_ProyectoTipo> _pti_ProyectoTipo;
    private EntityRef<pyg_ProyectoGrupo> _pyg_ProyectoGrupo;

    public pap_ProyectoAprobado()
    {
      this._dep_Departamento = new EntityRef<dep_Departamento>();
      this._mun_Municipio = new EntityRef<mun_Municipio>();
      this._pse_ProyectoSector = new EntityRef<pse_ProyectoSector>();
      this._pti_ProyectoTipo = new EntityRef<pti_ProyectoTipo>();
      this._pyg_ProyectoGrupo = new EntityRef<pyg_ProyectoGrupo>();
    }

    [Column(Storage = "_pap_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
    public int pap_Id
    {
      get => this._pap_Id;
      set
      {
        if (this._pap_Id == value)
          return;
        this.SendPropertyChanging();
        this._pap_Id = value;
        this.SendPropertyChanged(nameof (pap_Id));
      }
    }

    [Column(Storage = "_pap_NombreProyecto", DbType = "VarChar(150) NOT NULL", CanBeNull = false)]
    public string pap_NombreProyecto
    {
      get => this._pap_NombreProyecto;
      set
      {
        if (!(this._pap_NombreProyecto != value))
          return;
        this.SendPropertyChanging();
        this._pap_NombreProyecto = value;
        this.SendPropertyChanged(nameof (pap_NombreProyecto));
      }
    }

    [Column(Storage = "_pti_Id", DbType = "Int NOT NULL")]
    public int pti_Id
    {
      get => this._pti_Id;
      set
      {
        if (this._pti_Id == value)
          return;
        if (this._pti_ProyectoTipo.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._pti_Id = value;
        this.SendPropertyChanged(nameof (pti_Id));
      }
    }

    [Column(Storage = "_pse_Id", DbType = "Int NOT NULL")]
    public int pse_Id
    {
      get => this._pse_Id;
      set
      {
        if (this._pse_Id == value)
          return;
        if (this._pse_ProyectoSector.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._pse_Id = value;
        this.SendPropertyChanged(nameof (pse_Id));
      }
    }

    [Column(Storage = "_pap_AgenciaImplementadora", DbType = "VarChar(150) NOT NULL", CanBeNull = false)]
    public string pap_AgenciaImplementadora
    {
      get => this._pap_AgenciaImplementadora;
      set
      {
        if (!(this._pap_AgenciaImplementadora != value))
          return;
        this.SendPropertyChanging();
        this._pap_AgenciaImplementadora = value;
        this.SendPropertyChanged(nameof (pap_AgenciaImplementadora));
      }
    }

    [Column(Storage = "_pap_Compania", DbType = "VarChar(150)")]
    public string pap_Compania
    {
      get => this._pap_Compania;
      set
      {
        if (!(this._pap_Compania != value))
          return;
        this.SendPropertyChanging();
        this._pap_Compania = value;
        this.SendPropertyChanged(nameof (pap_Compania));
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

    [Column(Storage = "_pap_AprobadosFMPM", DbType = "Money")]
    public Decimal? pap_AprobadosFMPM
    {
      get => this._pap_AprobadosFMPM;
      set
      {
        Decimal? papAprobadosFmpm = this._pap_AprobadosFMPM;
        Decimal? nullable = value;
        if ((papAprobadosFmpm.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (papAprobadosFmpm.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._pap_AprobadosFMPM = value;
        this.SendPropertyChanged(nameof (pap_AprobadosFMPM));
      }
    }

    [Column(Storage = "_pap_DesembolsadosFMPM", DbType = "Money")]
    public Decimal? pap_DesembolsadosFMPM
    {
      get => this._pap_DesembolsadosFMPM;
      set
      {
        Decimal? desembolsadosFmpm = this._pap_DesembolsadosFMPM;
        Decimal? nullable = value;
        if ((desembolsadosFmpm.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (desembolsadosFmpm.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._pap_DesembolsadosFMPM = value;
        this.SendPropertyChanged(nameof (pap_DesembolsadosFMPM));
      }
    }

    [Column(Storage = "_pap_PesosInvertidos", DbType = "Money")]
    public Decimal? pap_PesosInvertidos
    {
      get => this._pap_PesosInvertidos;
      set
      {
        Decimal? papPesosInvertidos = this._pap_PesosInvertidos;
        Decimal? nullable = value;
        if ((papPesosInvertidos.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (papPesosInvertidos.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._pap_PesosInvertidos = value;
        this.SendPropertyChanged(nameof (pap_PesosInvertidos));
      }
    }

    [Column(Storage = "_pap_TonPAOAEliminar", DbType = "Decimal(10,3)")]
    public Decimal? pap_TonPAOAEliminar
    {
      get => this._pap_TonPAOAEliminar;
      set
      {
        Decimal? papTonPaoaEliminar = this._pap_TonPAOAEliminar;
        Decimal? nullable = value;
        if ((papTonPaoaEliminar.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (papTonPaoaEliminar.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._pap_TonPAOAEliminar = value;
        this.SendPropertyChanged(nameof (pap_TonPAOAEliminar));
      }
    }

    [Column(Storage = "_pap_TonPAOEliminadas", DbType = "Decimal(10,3)")]
    public Decimal? pap_TonPAOEliminadas
    {
      get => this._pap_TonPAOEliminadas;
      set
      {
        Decimal? tonPaoEliminadas = this._pap_TonPAOEliminadas;
        Decimal? nullable = value;
        if ((tonPaoEliminadas.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (tonPaoEliminadas.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._pap_TonPAOEliminadas = value;
        this.SendPropertyChanged(nameof (pap_TonPAOEliminadas));
      }
    }

    [Column(Storage = "_pap_FechaAprobacion", DbType = "DateTime")]
    public DateTime? pap_FechaAprobacion
    {
      get => this._pap_FechaAprobacion;
      set
      {
        DateTime? papFechaAprobacion = this._pap_FechaAprobacion;
        DateTime? nullable = value;
        if ((papFechaAprobacion.HasValue != nullable.HasValue ? 1 : (!papFechaAprobacion.HasValue ? 0 : (papFechaAprobacion.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._pap_FechaAprobacion = value;
        this.SendPropertyChanged(nameof (pap_FechaAprobacion));
      }
    }

    [Column(Storage = "_pap_FechaTerminacion", DbType = "DateTime")]
    public DateTime? pap_FechaTerminacion
    {
      get => this._pap_FechaTerminacion;
      set
      {
        DateTime? fechaTerminacion = this._pap_FechaTerminacion;
        DateTime? nullable = value;
        if ((fechaTerminacion.HasValue != nullable.HasValue ? 1 : (!fechaTerminacion.HasValue ? 0 : (fechaTerminacion.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._pap_FechaTerminacion = value;
        this.SendPropertyChanged(nameof (pap_FechaTerminacion));
      }
    }

    [Column(Storage = "_pap_FechaTerminacionReal", DbType = "DateTime")]
    public DateTime? pap_FechaTerminacionReal
    {
      get => this._pap_FechaTerminacionReal;
      set
      {
        DateTime? fechaTerminacionReal = this._pap_FechaTerminacionReal;
        DateTime? nullable = value;
        if ((fechaTerminacionReal.HasValue != nullable.HasValue ? 1 : (!fechaTerminacionReal.HasValue ? 0 : (fechaTerminacionReal.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._pap_FechaTerminacionReal = value;
        this.SendPropertyChanged(nameof (pap_FechaTerminacionReal));
      }
    }

    [Column(Storage = "_pap_Estado", DbType = "VarChar(10)")]
    public string pap_Estado
    {
      get => this._pap_Estado;
      set
      {
        if (!(this._pap_Estado != value))
          return;
        this.SendPropertyChanging();
        this._pap_Estado = value;
        this.SendPropertyChanged(nameof (pap_Estado));
      }
    }

    [Column(Storage = "_pap_Observacion", DbType = "VarChar(MAX)")]
    public string pap_Observacion
    {
      get => this._pap_Observacion;
      set
      {
        if (!(this._pap_Observacion != value))
          return;
        this.SendPropertyChanging();
        this._pap_Observacion = value;
        this.SendPropertyChanged(nameof (pap_Observacion));
      }
    }

    [Column(Storage = "_pap_Usuario", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
    public string pap_Usuario
    {
      get => this._pap_Usuario;
      set
      {
        if (!(this._pap_Usuario != value))
          return;
        this.SendPropertyChanging();
        this._pap_Usuario = value;
        this.SendPropertyChanged(nameof (pap_Usuario));
      }
    }

    [Column(Storage = "_pap_Creado", DbType = "DateTime NOT NULL")]
    public DateTime pap_Creado
    {
      get => this._pap_Creado;
      set
      {
        if (!(this._pap_Creado != value))
          return;
        this.SendPropertyChanging();
        this._pap_Creado = value;
        this.SendPropertyChanged(nameof (pap_Creado));
      }
    }

    [Column(Storage = "_pap_Modificado", DbType = "DateTime NOT NULL")]
    public DateTime pap_Modificado
    {
      get => this._pap_Modificado;
      set
      {
        if (!(this._pap_Modificado != value))
          return;
        this.SendPropertyChanging();
        this._pap_Modificado = value;
        this.SendPropertyChanged(nameof (pap_Modificado));
      }
    }

    [Column(Storage = "_pap_Codigo", DbType = "VarChar(20) NOT NULL", CanBeNull = false)]
    public string pap_Codigo
    {
      get => this._pap_Codigo;
      set
      {
        if (!(this._pap_Codigo != value))
          return;
        this.SendPropertyChanging();
        this._pap_Codigo = value;
        this.SendPropertyChanged(nameof (pap_Codigo));
      }
    }

    [Column(Storage = "_pyg_Id", DbType = "Int")]
    public int? pyg_Id
    {
      get => this._pyg_Id;
      set
      {
        int? pygId = this._pyg_Id;
        int? nullable = value;
        if ((pygId.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (pygId.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        if (this._pyg_ProyectoGrupo.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._pyg_Id = value;
        this.SendPropertyChanged(nameof (pyg_Id));
      }
    }

    [Association(Name = "dep_Departamento_pap_ProyectoAprobado", Storage = "_dep_Departamento", ThisKey = "dep_Id", OtherKey = "dep_Id", IsForeignKey = true)]
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
          entity.pap_ProyectoAprobados.Remove(this);
        }
        this._dep_Departamento.Entity = value;
        if (value != null)
        {
          value.pap_ProyectoAprobados.Add(this);
          this._dep_Id = value.dep_Id;
        }
        else
          this._dep_Id = (string) null;
        this.SendPropertyChanged(nameof (dep_Departamento));
      }
    }

    [Association(Name = "mun_Municipio_pap_ProyectoAprobado", Storage = "_mun_Municipio", ThisKey = "mun_Id", OtherKey = "mun_Id", IsForeignKey = true)]
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
          entity.pap_ProyectoAprobados.Remove(this);
        }
        this._mun_Municipio.Entity = value;
        if (value != null)
        {
          value.pap_ProyectoAprobados.Add(this);
          this._mun_Id = value.mun_Id;
        }
        else
          this._mun_Id = (string) null;
        this.SendPropertyChanged(nameof (mun_Municipio));
      }
    }

    [Association(Name = "pse_ProyectoSector_pap_ProyectoAprobado", Storage = "_pse_ProyectoSector", ThisKey = "pse_Id", OtherKey = "pse_Id", IsForeignKey = true)]
    public pse_ProyectoSector pse_ProyectoSector
    {
      get => this._pse_ProyectoSector.Entity;
      set
      {
        pse_ProyectoSector entity = this._pse_ProyectoSector.Entity;
        if (entity == value && this._pse_ProyectoSector.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._pse_ProyectoSector.Entity = (pse_ProyectoSector) null;
          entity.pap_ProyectoAprobados.Remove(this);
        }
        this._pse_ProyectoSector.Entity = value;
        if (value != null)
        {
          value.pap_ProyectoAprobados.Add(this);
          this._pse_Id = value.pse_Id;
        }
        else
          this._pse_Id = 0;
        this.SendPropertyChanged(nameof (pse_ProyectoSector));
      }
    }

    [Association(Name = "pti_ProyectoTipo_pap_ProyectoAprobado", Storage = "_pti_ProyectoTipo", ThisKey = "pti_Id", OtherKey = "pti_Id", IsForeignKey = true)]
    public pti_ProyectoTipo pti_ProyectoTipo
    {
      get => this._pti_ProyectoTipo.Entity;
      set
      {
        pti_ProyectoTipo entity = this._pti_ProyectoTipo.Entity;
        if (entity == value && this._pti_ProyectoTipo.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._pti_ProyectoTipo.Entity = (pti_ProyectoTipo) null;
          entity.pap_ProyectoAprobados.Remove(this);
        }
        this._pti_ProyectoTipo.Entity = value;
        if (value != null)
        {
          value.pap_ProyectoAprobados.Add(this);
          this._pti_Id = value.pti_Id;
        }
        else
          this._pti_Id = 0;
        this.SendPropertyChanged(nameof (pti_ProyectoTipo));
      }
    }

    [Association(Name = "pyg_ProyectoGrupo_pap_ProyectoAprobado", Storage = "_pyg_ProyectoGrupo", ThisKey = "pyg_Id", OtherKey = "pyg_Id", IsForeignKey = true)]
    public pyg_ProyectoGrupo pyg_ProyectoGrupo
    {
      get => this._pyg_ProyectoGrupo.Entity;
      set
      {
        pyg_ProyectoGrupo entity = this._pyg_ProyectoGrupo.Entity;
        if (entity == value && this._pyg_ProyectoGrupo.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._pyg_ProyectoGrupo.Entity = (pyg_ProyectoGrupo) null;
          entity.pap_ProyectoAprobados.Remove(this);
        }
        this._pyg_ProyectoGrupo.Entity = value;
        if (value != null)
        {
          value.pap_ProyectoAprobados.Add(this);
          this._pyg_Id = new int?(value.pyg_Id);
        }
        else
          this._pyg_Id = new int?();
        this.SendPropertyChanged(nameof (pyg_ProyectoGrupo));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, pap_ProyectoAprobado.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
