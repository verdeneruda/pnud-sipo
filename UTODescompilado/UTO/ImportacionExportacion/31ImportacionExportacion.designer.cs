// Decompiled with JetBrains decompiler
// Type: UTO.ImportacionExportacion.rim_RegistroImportacion
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
  [Table(Name = "Iye.rim_RegistroImportacion")]
  public class rim_RegistroImportacion : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _rim_Id;
    private string _rim_NumeroRegistro;
    private int _pas_Id;
    private string _rim_Tipo;
    private string _rim_PuertoEmbargue;
    private int? _adu_Id;
    private int _ter_idExportador;
    private int _cvb_Id;
    private DateTime? _rim_FechaVigencia;
    private string _rim_NumeroVistoBueno;
    private DateTime? _rim_FechaVistoBueno;
    private DateTime? _rim_FechaSolicitudRequerimiento;
    private DateTime? _rim_FechaRequerimiento;
    private int _ter_Id;
    private DateTime? _rim_FechaInicio;
    private int _rit_Id;
    private string _rim_Usuario;
    private DateTime _rim_Creado;
    private DateTime _rim_Modificado;
    private EntitySet<ris_RegistroImportacionSustancia> _ris_RegistroImportacionSustancias;
    private EntitySet<rie_RegistroImportacionEquipo> _rie_RegistroImportacionEquipos;
    private EntityRef<adu_Aduana> _adu_Aduana;
    private EntityRef<cvb_ConceptoVistoBueno> _cvb_ConceptoVistoBueno;
    private EntityRef<pas_Pai> _pas_Pai;
    private EntityRef<rit_RegistroImportacionEstado> _rit_RegistroImportacionEstado;
    private EntityRef<ter_Tercero> _ter_Tercero;
    private EntityRef<ter_Tercero> _ter_Tercero1;

    public rim_RegistroImportacion()
    {
      this._ris_RegistroImportacionSustancias = new EntitySet<ris_RegistroImportacionSustancia>(new Action<ris_RegistroImportacionSustancia>(this.attach_ris_RegistroImportacionSustancias), new Action<ris_RegistroImportacionSustancia>(this.detach_ris_RegistroImportacionSustancias));
      this._rie_RegistroImportacionEquipos = new EntitySet<rie_RegistroImportacionEquipo>(new Action<rie_RegistroImportacionEquipo>(this.attach_rie_RegistroImportacionEquipos), new Action<rie_RegistroImportacionEquipo>(this.detach_rie_RegistroImportacionEquipos));
      this._adu_Aduana = new EntityRef<adu_Aduana>();
      this._cvb_ConceptoVistoBueno = new EntityRef<cvb_ConceptoVistoBueno>();
      this._pas_Pai = new EntityRef<pas_Pai>();
      this._rit_RegistroImportacionEstado = new EntityRef<rit_RegistroImportacionEstado>();
      this._ter_Tercero = new EntityRef<ter_Tercero>();
      this._ter_Tercero1 = new EntityRef<ter_Tercero>();
    }

    [Column(Storage = "_rim_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
    public int rim_Id
    {
      get => this._rim_Id;
      set
      {
        if (this._rim_Id == value)
          return;
        this.SendPropertyChanging();
        this._rim_Id = value;
        this.SendPropertyChanged(nameof (rim_Id));
      }
    }

    [Column(Storage = "_rim_NumeroRegistro", DbType = "VarChar(25) NOT NULL", CanBeNull = false)]
    public string rim_NumeroRegistro
    {
      get => this._rim_NumeroRegistro;
      set
      {
        if (!(this._rim_NumeroRegistro != value))
          return;
        this.SendPropertyChanging();
        this._rim_NumeroRegistro = value;
        this.SendPropertyChanged(nameof (rim_NumeroRegistro));
      }
    }

    [Column(Storage = "_pas_Id", DbType = "Int NOT NULL")]
    public int pas_Id
    {
      get => this._pas_Id;
      set
      {
        if (this._pas_Id == value)
          return;
        if (this._pas_Pai.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._pas_Id = value;
        this.SendPropertyChanged(nameof (pas_Id));
      }
    }

    [Column(Storage = "_rim_Tipo", DbType = "VarChar(25)")]
    public string rim_Tipo
    {
      get => this._rim_Tipo;
      set
      {
        if (!(this._rim_Tipo != value))
          return;
        this.SendPropertyChanging();
        this._rim_Tipo = value;
        this.SendPropertyChanged(nameof (rim_Tipo));
      }
    }

    [Column(Storage = "_rim_PuertoEmbargue", DbType = "VarChar(150)")]
    public string rim_PuertoEmbargue
    {
      get => this._rim_PuertoEmbargue;
      set
      {
        if (!(this._rim_PuertoEmbargue != value))
          return;
        this.SendPropertyChanging();
        this._rim_PuertoEmbargue = value;
        this.SendPropertyChanged(nameof (rim_PuertoEmbargue));
      }
    }

    [Column(Storage = "_adu_Id", DbType = "Int")]
    public int? adu_Id
    {
      get => this._adu_Id;
      set
      {
        int? aduId = this._adu_Id;
        int? nullable = value;
        if ((aduId.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (aduId.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        if (this._adu_Aduana.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._adu_Id = value;
        this.SendPropertyChanged(nameof (adu_Id));
      }
    }

    [Column(Storage = "_ter_idExportador", DbType = "Int NOT NULL")]
    public int ter_idExportador
    {
      get => this._ter_idExportador;
      set
      {
        if (this._ter_idExportador == value)
          return;
        if (this._ter_Tercero1.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._ter_idExportador = value;
        this.SendPropertyChanged(nameof (ter_idExportador));
      }
    }

    [Column(Storage = "_cvb_Id", DbType = "Int NOT NULL")]
    public int cvb_Id
    {
      get => this._cvb_Id;
      set
      {
        if (this._cvb_Id == value)
          return;
        if (this._cvb_ConceptoVistoBueno.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._cvb_Id = value;
        this.SendPropertyChanged(nameof (cvb_Id));
      }
    }

    [Column(Storage = "_rim_FechaVigencia", DbType = "DateTime")]
    public DateTime? rim_FechaVigencia
    {
      get => this._rim_FechaVigencia;
      set
      {
        DateTime? rimFechaVigencia = this._rim_FechaVigencia;
        DateTime? nullable = value;
        if ((rimFechaVigencia.HasValue != nullable.HasValue ? 1 : (!rimFechaVigencia.HasValue ? 0 : (rimFechaVigencia.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._rim_FechaVigencia = value;
        this.SendPropertyChanged(nameof (rim_FechaVigencia));
      }
    }

    [Column(Storage = "_rim_NumeroVistoBueno", DbType = "VarChar(150)")]
    public string rim_NumeroVistoBueno
    {
      get => this._rim_NumeroVistoBueno;
      set
      {
        if (!(this._rim_NumeroVistoBueno != value))
          return;
        this.SendPropertyChanging();
        this._rim_NumeroVistoBueno = value;
        this.SendPropertyChanged(nameof (rim_NumeroVistoBueno));
      }
    }

    [Column(Storage = "_rim_FechaVistoBueno", DbType = "DateTime")]
    public DateTime? rim_FechaVistoBueno
    {
      get => this._rim_FechaVistoBueno;
      set
      {
        DateTime? rimFechaVistoBueno = this._rim_FechaVistoBueno;
        DateTime? nullable = value;
        if ((rimFechaVistoBueno.HasValue != nullable.HasValue ? 1 : (!rimFechaVistoBueno.HasValue ? 0 : (rimFechaVistoBueno.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._rim_FechaVistoBueno = value;
        this.SendPropertyChanged(nameof (rim_FechaVistoBueno));
      }
    }

    [Column(Storage = "_rim_FechaSolicitudRequerimiento", DbType = "DateTime")]
    public DateTime? rim_FechaSolicitudRequerimiento
    {
      get => this._rim_FechaSolicitudRequerimiento;
      set
      {
        DateTime? solicitudRequerimiento = this._rim_FechaSolicitudRequerimiento;
        DateTime? nullable = value;
        if ((solicitudRequerimiento.HasValue != nullable.HasValue ? 1 : (!solicitudRequerimiento.HasValue ? 0 : (solicitudRequerimiento.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._rim_FechaSolicitudRequerimiento = value;
        this.SendPropertyChanged(nameof (rim_FechaSolicitudRequerimiento));
      }
    }

    [Column(Storage = "_rim_FechaRequerimiento", DbType = "DateTime")]
    public DateTime? rim_FechaRequerimiento
    {
      get => this._rim_FechaRequerimiento;
      set
      {
        DateTime? fechaRequerimiento = this._rim_FechaRequerimiento;
        DateTime? nullable = value;
        if ((fechaRequerimiento.HasValue != nullable.HasValue ? 1 : (!fechaRequerimiento.HasValue ? 0 : (fechaRequerimiento.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._rim_FechaRequerimiento = value;
        this.SendPropertyChanged(nameof (rim_FechaRequerimiento));
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

    [Column(Storage = "_rim_FechaInicio", DbType = "DateTime")]
    public DateTime? rim_FechaInicio
    {
      get => this._rim_FechaInicio;
      set
      {
        DateTime? rimFechaInicio = this._rim_FechaInicio;
        DateTime? nullable = value;
        if ((rimFechaInicio.HasValue != nullable.HasValue ? 1 : (!rimFechaInicio.HasValue ? 0 : (rimFechaInicio.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._rim_FechaInicio = value;
        this.SendPropertyChanged(nameof (rim_FechaInicio));
      }
    }

    [Column(Storage = "_rit_Id", DbType = "Int NOT NULL")]
    public int rit_Id
    {
      get => this._rit_Id;
      set
      {
        if (this._rit_Id == value)
          return;
        if (this._rit_RegistroImportacionEstado.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._rit_Id = value;
        this.SendPropertyChanged(nameof (rit_Id));
      }
    }

    [Column(Storage = "_rim_Usuario", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
    public string rim_Usuario
    {
      get => this._rim_Usuario;
      set
      {
        if (!(this._rim_Usuario != value))
          return;
        this.SendPropertyChanging();
        this._rim_Usuario = value;
        this.SendPropertyChanged(nameof (rim_Usuario));
      }
    }

    [Column(Storage = "_rim_Creado", DbType = "DateTime NOT NULL")]
    public DateTime rim_Creado
    {
      get => this._rim_Creado;
      set
      {
        if (!(this._rim_Creado != value))
          return;
        this.SendPropertyChanging();
        this._rim_Creado = value;
        this.SendPropertyChanged(nameof (rim_Creado));
      }
    }

    [Column(Storage = "_rim_Modificado", DbType = "DateTime NOT NULL")]
    public DateTime rim_Modificado
    {
      get => this._rim_Modificado;
      set
      {
        if (!(this._rim_Modificado != value))
          return;
        this.SendPropertyChanging();
        this._rim_Modificado = value;
        this.SendPropertyChanged(nameof (rim_Modificado));
      }
    }

    [Association(Name = "rim_RegistroImportacion_ris_RegistroImportacionSustancia", Storage = "_ris_RegistroImportacionSustancias", ThisKey = "rim_Id", OtherKey = "rim_Id")]
    public EntitySet<ris_RegistroImportacionSustancia> ris_RegistroImportacionSustancias
    {
      get => this._ris_RegistroImportacionSustancias;
      set => this._ris_RegistroImportacionSustancias.Assign((IEnumerable<ris_RegistroImportacionSustancia>) value);
    }

    [Association(Name = "rim_RegistroImportacion_rie_RegistroImportacionEquipo", Storage = "_rie_RegistroImportacionEquipos", ThisKey = "rim_Id", OtherKey = "rim_Id")]
    public EntitySet<rie_RegistroImportacionEquipo> rie_RegistroImportacionEquipos
    {
      get => this._rie_RegistroImportacionEquipos;
      set => this._rie_RegistroImportacionEquipos.Assign((IEnumerable<rie_RegistroImportacionEquipo>) value);
    }

    [Association(Name = "adu_Aduana_rim_RegistroImportacion", Storage = "_adu_Aduana", ThisKey = "adu_Id", OtherKey = "adu_Id", IsForeignKey = true)]
    public adu_Aduana adu_Aduana
    {
      get => this._adu_Aduana.Entity;
      set
      {
        adu_Aduana entity = this._adu_Aduana.Entity;
        if (entity == value && this._adu_Aduana.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._adu_Aduana.Entity = (adu_Aduana) null;
          entity.rim_RegistroImportacions.Remove(this);
        }
        this._adu_Aduana.Entity = value;
        if (value != null)
        {
          value.rim_RegistroImportacions.Add(this);
          this._adu_Id = new int?(value.adu_Id);
        }
        else
          this._adu_Id = new int?();
        this.SendPropertyChanged(nameof (adu_Aduana));
      }
    }

    [Association(Name = "cvb_ConceptoVistoBueno_rim_RegistroImportacion", Storage = "_cvb_ConceptoVistoBueno", ThisKey = "cvb_Id", OtherKey = "cvb_Id", IsForeignKey = true)]
    public cvb_ConceptoVistoBueno cvb_ConceptoVistoBueno
    {
      get => this._cvb_ConceptoVistoBueno.Entity;
      set
      {
        cvb_ConceptoVistoBueno entity = this._cvb_ConceptoVistoBueno.Entity;
        if (entity == value && this._cvb_ConceptoVistoBueno.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._cvb_ConceptoVistoBueno.Entity = (cvb_ConceptoVistoBueno) null;
          entity.rim_RegistroImportacions.Remove(this);
        }
        this._cvb_ConceptoVistoBueno.Entity = value;
        if (value != null)
        {
          value.rim_RegistroImportacions.Add(this);
          this._cvb_Id = value.cvb_Id;
        }
        else
          this._cvb_Id = 0;
        this.SendPropertyChanged(nameof (cvb_ConceptoVistoBueno));
      }
    }

    [Association(Name = "pas_Pai_rim_RegistroImportacion", Storage = "_pas_Pai", ThisKey = "pas_Id", OtherKey = "pas_Id", IsForeignKey = true)]
    public pas_Pai pas_Pai
    {
      get => this._pas_Pai.Entity;
      set
      {
        pas_Pai entity = this._pas_Pai.Entity;
        if (entity == value && this._pas_Pai.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._pas_Pai.Entity = (pas_Pai) null;
          entity.rim_RegistroImportacions.Remove(this);
        }
        this._pas_Pai.Entity = value;
        if (value != null)
        {
          value.rim_RegistroImportacions.Add(this);
          this._pas_Id = value.pas_Id;
        }
        else
          this._pas_Id = 0;
        this.SendPropertyChanged(nameof (pas_Pai));
      }
    }

    [Association(Name = "rit_RegistroImportacionEstado_rim_RegistroImportacion", Storage = "_rit_RegistroImportacionEstado", ThisKey = "rit_Id", OtherKey = "rit_Id", IsForeignKey = true)]
    public rit_RegistroImportacionEstado rit_RegistroImportacionEstado
    {
      get => this._rit_RegistroImportacionEstado.Entity;
      set
      {
        rit_RegistroImportacionEstado entity = this._rit_RegistroImportacionEstado.Entity;
        if (entity == value && this._rit_RegistroImportacionEstado.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._rit_RegistroImportacionEstado.Entity = (rit_RegistroImportacionEstado) null;
          entity.rim_RegistroImportacions.Remove(this);
        }
        this._rit_RegistroImportacionEstado.Entity = value;
        if (value != null)
        {
          value.rim_RegistroImportacions.Add(this);
          this._rit_Id = value.rit_Id;
        }
        else
          this._rit_Id = 0;
        this.SendPropertyChanged(nameof (rit_RegistroImportacionEstado));
      }
    }

    [Association(Name = "ter_Tercero_rim_RegistroImportacion", Storage = "_ter_Tercero", ThisKey = "ter_Id", OtherKey = "ter_Id", IsForeignKey = true)]
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
          entity.rim_RegistroImportacions.Remove(this);
        }
        this._ter_Tercero.Entity = value;
        if (value != null)
        {
          value.rim_RegistroImportacions.Add(this);
          this._ter_Id = value.ter_Id;
        }
        else
          this._ter_Id = 0;
        this.SendPropertyChanged(nameof (ter_Tercero));
      }
    }

    [Association(Name = "ter_Tercero_rim_RegistroImportacion1", Storage = "_ter_Tercero1", ThisKey = "ter_idExportador", OtherKey = "ter_Id", IsForeignKey = true)]
    public ter_Tercero ter_Tercero1
    {
      get => this._ter_Tercero1.Entity;
      set
      {
        ter_Tercero entity = this._ter_Tercero1.Entity;
        if (entity == value && this._ter_Tercero1.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._ter_Tercero1.Entity = (ter_Tercero) null;
          entity.rim_RegistroImportacions1.Remove(this);
        }
        this._ter_Tercero1.Entity = value;
        if (value != null)
        {
          value.rim_RegistroImportacions1.Add(this);
          this._ter_idExportador = value.ter_Id;
        }
        else
          this._ter_idExportador = 0;
        this.SendPropertyChanged(nameof (ter_Tercero1));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, rim_RegistroImportacion.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void attach_ris_RegistroImportacionSustancias(ris_RegistroImportacionSustancia entity)
    {
      this.SendPropertyChanging();
      entity.rim_RegistroImportacion = this;
    }

    private void detach_ris_RegistroImportacionSustancias(ris_RegistroImportacionSustancia entity)
    {
      this.SendPropertyChanging();
      entity.rim_RegistroImportacion = (rim_RegistroImportacion) null;
    }

    private void attach_rie_RegistroImportacionEquipos(rie_RegistroImportacionEquipo entity)
    {
      this.SendPropertyChanging();
      entity.rim_RegistroImportacion = this;
    }

    private void detach_rie_RegistroImportacionEquipos(rie_RegistroImportacionEquipo entity)
    {
      this.SendPropertyChanging();
      entity.rim_RegistroImportacion = (rim_RegistroImportacion) null;
    }
  }
}
