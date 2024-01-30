// Decompiled with JetBrains decompiler
// Type: UTO.RegistrosUso.ufe_UsuarioFinalDetalle
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO.RegistrosUso
{
  [Table(Name = "Rus.ufe_UsuarioFinalDetalle")]
  public class ufe_UsuarioFinalDetalle : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _ufe_Id;
    private int _ufd_Id;
    private int _sus_Id;
    private int _ufe_CantidadSustanciaUsada;
    private int _ceq_Id;
    private int _eti_Id;
    private int _ufe_NumeroUnidades;
    private Decimal _ufe_CargaPromedioInstalada;
    private Decimal _ufe_CargaPromedioMantenimiento;
    private Decimal _ufe_ConsumoEnergetico;
    private Decimal _ufe_PotenciaCompresor;
    private int _ufe_VolumenUtil;
    private Decimal _ufe_CapacidadEnfriamiento;
    private string _ufe_Observaciones;
    private string _ufe_Usuario;
    private DateTime _ufe_Creado;
    private DateTime _ufe_Modificado;
    private EntityRef<ceq_CategoriaEquipo> _ceq_CategoriaEquipo;
    private EntityRef<sus_Sustancia> _sus_Sustancia;
    private EntityRef<ufd_UsuarioFinalDato> _ufd_UsuarioFinalDato;
    private EntityRef<eti_EquipoTipo> _eti_EquipoTipo;

    public ufe_UsuarioFinalDetalle()
    {
      this._ceq_CategoriaEquipo = new EntityRef<ceq_CategoriaEquipo>();
      this._sus_Sustancia = new EntityRef<sus_Sustancia>();
      this._ufd_UsuarioFinalDato = new EntityRef<ufd_UsuarioFinalDato>();
      this._eti_EquipoTipo = new EntityRef<eti_EquipoTipo>();
    }

    [Column(Storage = "_ufe_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
    public int ufe_Id
    {
      get => this._ufe_Id;
      set
      {
        if (this._ufe_Id == value)
          return;
        this.SendPropertyChanging();
        this._ufe_Id = value;
        this.SendPropertyChanged(nameof (ufe_Id));
      }
    }

    [Column(Storage = "_ufd_Id", DbType = "Int NOT NULL")]
    public int ufd_Id
    {
      get => this._ufd_Id;
      set
      {
        if (this._ufd_Id == value)
          return;
        if (this._ufd_UsuarioFinalDato.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._ufd_Id = value;
        this.SendPropertyChanged(nameof (ufd_Id));
      }
    }

    [Column(Storage = "_sus_Id", DbType = "Int NOT NULL")]
    public int sus_Id
    {
      get => this._sus_Id;
      set
      {
        if (this._sus_Id == value)
          return;
        if (this._sus_Sustancia.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._sus_Id = value;
        this.SendPropertyChanged(nameof (sus_Id));
      }
    }

    [Column(Storage = "_ufe_CantidadSustanciaUsada", DbType = "Int NOT NULL")]
    public int ufe_CantidadSustanciaUsada
    {
      get => this._ufe_CantidadSustanciaUsada;
      set
      {
        if (this._ufe_CantidadSustanciaUsada == value)
          return;
        this.SendPropertyChanging();
        this._ufe_CantidadSustanciaUsada = value;
        this.SendPropertyChanged(nameof (ufe_CantidadSustanciaUsada));
      }
    }

    [Column(Storage = "_ceq_Id", DbType = "Int NOT NULL")]
    public int ceq_Id
    {
      get => this._ceq_Id;
      set
      {
        if (this._ceq_Id == value)
          return;
        if (this._ceq_CategoriaEquipo.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._ceq_Id = value;
        this.SendPropertyChanged(nameof (ceq_Id));
      }
    }

    [Column(Storage = "_eti_Id", DbType = "Int NOT NULL")]
    public int eti_Id
    {
      get => this._eti_Id;
      set
      {
        if (this._eti_Id == value)
          return;
        if (this._eti_EquipoTipo.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._eti_Id = value;
        this.SendPropertyChanged(nameof (eti_Id));
      }
    }

    [Column(Storage = "_ufe_NumeroUnidades", DbType = "Int NOT NULL")]
    public int ufe_NumeroUnidades
    {
      get => this._ufe_NumeroUnidades;
      set
      {
        if (this._ufe_NumeroUnidades == value)
          return;
        this.SendPropertyChanging();
        this._ufe_NumeroUnidades = value;
        this.SendPropertyChanged(nameof (ufe_NumeroUnidades));
      }
    }

    [Column(Storage = "_ufe_CargaPromedioInstalada", DbType = "Decimal(10,2) NOT NULL")]
    public Decimal ufe_CargaPromedioInstalada
    {
      get => this._ufe_CargaPromedioInstalada;
      set
      {
        if (!(this._ufe_CargaPromedioInstalada != value))
          return;
        this.SendPropertyChanging();
        this._ufe_CargaPromedioInstalada = value;
        this.SendPropertyChanged(nameof (ufe_CargaPromedioInstalada));
      }
    }

    [Column(Storage = "_ufe_CargaPromedioMantenimiento", DbType = "Decimal(10,2) NOT NULL")]
    public Decimal ufe_CargaPromedioMantenimiento
    {
      get => this._ufe_CargaPromedioMantenimiento;
      set
      {
        if (!(this._ufe_CargaPromedioMantenimiento != value))
          return;
        this.SendPropertyChanging();
        this._ufe_CargaPromedioMantenimiento = value;
        this.SendPropertyChanged(nameof (ufe_CargaPromedioMantenimiento));
      }
    }

    [Column(Storage = "_ufe_ConsumoEnergetico", DbType = "Decimal(10,2) NOT NULL")]
    public Decimal ufe_ConsumoEnergetico
    {
      get => this._ufe_ConsumoEnergetico;
      set
      {
        if (!(this._ufe_ConsumoEnergetico != value))
          return;
        this.SendPropertyChanging();
        this._ufe_ConsumoEnergetico = value;
        this.SendPropertyChanged(nameof (ufe_ConsumoEnergetico));
      }
    }

    [Column(Storage = "_ufe_PotenciaCompresor", DbType = "Decimal(10,2) NOT NULL")]
    public Decimal ufe_PotenciaCompresor
    {
      get => this._ufe_PotenciaCompresor;
      set
      {
        if (!(this._ufe_PotenciaCompresor != value))
          return;
        this.SendPropertyChanging();
        this._ufe_PotenciaCompresor = value;
        this.SendPropertyChanged(nameof (ufe_PotenciaCompresor));
      }
    }

    [Column(Storage = "_ufe_VolumenUtil", DbType = "Int NOT NULL")]
    public int ufe_VolumenUtil
    {
      get => this._ufe_VolumenUtil;
      set
      {
        if (this._ufe_VolumenUtil == value)
          return;
        this.SendPropertyChanging();
        this._ufe_VolumenUtil = value;
        this.SendPropertyChanged(nameof (ufe_VolumenUtil));
      }
    }

    [Column(Storage = "_ufe_CapacidadEnfriamiento", DbType = "Decimal(10,2) NOT NULL")]
    public Decimal ufe_CapacidadEnfriamiento
    {
      get => this._ufe_CapacidadEnfriamiento;
      set
      {
        if (!(this._ufe_CapacidadEnfriamiento != value))
          return;
        this.SendPropertyChanging();
        this._ufe_CapacidadEnfriamiento = value;
        this.SendPropertyChanged(nameof (ufe_CapacidadEnfriamiento));
      }
    }

    [Column(Storage = "_ufe_Observaciones", DbType = "VarChar(MAX) NOT NULL", CanBeNull = false)]
    public string ufe_Observaciones
    {
      get => this._ufe_Observaciones;
      set
      {
        if (!(this._ufe_Observaciones != value))
          return;
        this.SendPropertyChanging();
        this._ufe_Observaciones = value;
        this.SendPropertyChanged(nameof (ufe_Observaciones));
      }
    }

    [Column(Storage = "_ufe_Usuario", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
    public string ufe_Usuario
    {
      get => this._ufe_Usuario;
      set
      {
        if (!(this._ufe_Usuario != value))
          return;
        this.SendPropertyChanging();
        this._ufe_Usuario = value;
        this.SendPropertyChanged(nameof (ufe_Usuario));
      }
    }

    [Column(Storage = "_ufe_Creado", DbType = "DateTime NOT NULL")]
    public DateTime ufe_Creado
    {
      get => this._ufe_Creado;
      set
      {
        if (!(this._ufe_Creado != value))
          return;
        this.SendPropertyChanging();
        this._ufe_Creado = value;
        this.SendPropertyChanged(nameof (ufe_Creado));
      }
    }

    [Column(Storage = "_ufe_Modificado", DbType = "DateTime NOT NULL")]
    public DateTime ufe_Modificado
    {
      get => this._ufe_Modificado;
      set
      {
        if (!(this._ufe_Modificado != value))
          return;
        this.SendPropertyChanging();
        this._ufe_Modificado = value;
        this.SendPropertyChanged(nameof (ufe_Modificado));
      }
    }

    [Association(Name = "ceq_CategoriaEquipo_ufe_UsuarioFinalDetalle", Storage = "_ceq_CategoriaEquipo", ThisKey = "ceq_Id", OtherKey = "ceq_Id", IsForeignKey = true)]
    public ceq_CategoriaEquipo ceq_CategoriaEquipo
    {
      get => this._ceq_CategoriaEquipo.Entity;
      set
      {
        ceq_CategoriaEquipo entity = this._ceq_CategoriaEquipo.Entity;
        if (entity == value && this._ceq_CategoriaEquipo.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._ceq_CategoriaEquipo.Entity = (ceq_CategoriaEquipo) null;
          entity.ufe_UsuarioFinalDetalles.Remove(this);
        }
        this._ceq_CategoriaEquipo.Entity = value;
        if (value != null)
        {
          value.ufe_UsuarioFinalDetalles.Add(this);
          this._ceq_Id = value.ceq_Id;
        }
        else
          this._ceq_Id = 0;
        this.SendPropertyChanged(nameof (ceq_CategoriaEquipo));
      }
    }

    [Association(Name = "sus_Sustancia_ufe_UsuarioFinalDetalle", Storage = "_sus_Sustancia", ThisKey = "sus_Id", OtherKey = "sus_Id", IsForeignKey = true)]
    public sus_Sustancia sus_Sustancia
    {
      get => this._sus_Sustancia.Entity;
      set
      {
        sus_Sustancia entity = this._sus_Sustancia.Entity;
        if (entity == value && this._sus_Sustancia.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._sus_Sustancia.Entity = (sus_Sustancia) null;
          entity.ufe_UsuarioFinalDetalles.Remove(this);
        }
        this._sus_Sustancia.Entity = value;
        if (value != null)
        {
          value.ufe_UsuarioFinalDetalles.Add(this);
          this._sus_Id = value.sus_Id;
        }
        else
          this._sus_Id = 0;
        this.SendPropertyChanged(nameof (sus_Sustancia));
      }
    }

    [Association(Name = "ufd_UsuarioFinalDato_ufe_UsuarioFinalDetalle", Storage = "_ufd_UsuarioFinalDato", ThisKey = "ufd_Id", OtherKey = "ufd_Id", IsForeignKey = true)]
    public ufd_UsuarioFinalDato ufd_UsuarioFinalDato
    {
      get => this._ufd_UsuarioFinalDato.Entity;
      set
      {
        ufd_UsuarioFinalDato entity = this._ufd_UsuarioFinalDato.Entity;
        if (entity == value && this._ufd_UsuarioFinalDato.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._ufd_UsuarioFinalDato.Entity = (ufd_UsuarioFinalDato) null;
          entity.ufe_UsuarioFinalDetalles.Remove(this);
        }
        this._ufd_UsuarioFinalDato.Entity = value;
        if (value != null)
        {
          value.ufe_UsuarioFinalDetalles.Add(this);
          this._ufd_Id = value.ufd_Id;
        }
        else
          this._ufd_Id = 0;
        this.SendPropertyChanged(nameof (ufd_UsuarioFinalDato));
      }
    }

    [Association(Name = "eti_EquipoTipo_ufe_UsuarioFinalDetalle", Storage = "_eti_EquipoTipo", ThisKey = "eti_Id", OtherKey = "eti_Id", IsForeignKey = true)]
    public eti_EquipoTipo eti_EquipoTipo
    {
      get => this._eti_EquipoTipo.Entity;
      set
      {
        eti_EquipoTipo entity = this._eti_EquipoTipo.Entity;
        if (entity == value && this._eti_EquipoTipo.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._eti_EquipoTipo.Entity = (eti_EquipoTipo) null;
          entity.ufe_UsuarioFinalDetalles.Remove(this);
        }
        this._eti_EquipoTipo.Entity = value;
        if (value != null)
        {
          value.ufe_UsuarioFinalDetalles.Add(this);
          this._eti_Id = value.eti_Id;
        }
        else
          this._eti_Id = 0;
        this.SendPropertyChanged(nameof (eti_EquipoTipo));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, ufe_UsuarioFinalDetalle.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
