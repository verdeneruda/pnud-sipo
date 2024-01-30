// Decompiled with JetBrains decompiler
// Type: UTO.RegistrosUso.rid_RegistroImportadorDetalle
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO.RegistrosUso
{
  [Table(Name = "Rus.rid_RegistroImportadorDetalle")]
  public class rid_RegistroImportadorDetalle : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _rid_Id;
    private int _rri_Id;
    private int _ter_Id;
    private int _sus_Id;
    private Decimal _rid_Cantidad;
    private string _dep_Id;
    private string _mun_Id;
    private int _apl_Id;
    private string _rid_Usuario;
    private DateTime _rid_Creado;
    private DateTime _rid_Modificado;
    private EntityRef<apl_Aplicacion> _apl_Aplicacion;
    private EntityRef<dep_Departamento> _dep_Departamento;
    private EntityRef<mun_Municipio> _mun_Municipio;
    private EntityRef<rri_RegistroReporteImportador> _rri_RegistroReporteImportador;
    private EntityRef<sus_Sustancia> _sus_Sustancia;
    private EntityRef<ter_Tercero> _ter_Tercero;

    public rid_RegistroImportadorDetalle()
    {
      this._apl_Aplicacion = new EntityRef<apl_Aplicacion>();
      this._dep_Departamento = new EntityRef<dep_Departamento>();
      this._mun_Municipio = new EntityRef<mun_Municipio>();
      this._rri_RegistroReporteImportador = new EntityRef<rri_RegistroReporteImportador>();
      this._sus_Sustancia = new EntityRef<sus_Sustancia>();
      this._ter_Tercero = new EntityRef<ter_Tercero>();
    }

    [Column(Storage = "_rid_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
    public int rid_Id
    {
      get => this._rid_Id;
      set
      {
        if (this._rid_Id == value)
          return;
        this.SendPropertyChanging();
        this._rid_Id = value;
        this.SendPropertyChanged(nameof (rid_Id));
      }
    }

    [Column(Storage = "_rri_Id", DbType = "Int NOT NULL")]
    public int rri_Id
    {
      get => this._rri_Id;
      set
      {
        if (this._rri_Id == value)
          return;
        if (this._rri_RegistroReporteImportador.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._rri_Id = value;
        this.SendPropertyChanged(nameof (rri_Id));
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

    [Column(Storage = "_rid_Cantidad", DbType = "Decimal(10,2) NOT NULL")]
    public Decimal rid_Cantidad
    {
      get => this._rid_Cantidad;
      set
      {
        if (!(this._rid_Cantidad != value))
          return;
        this.SendPropertyChanging();
        this._rid_Cantidad = value;
        this.SendPropertyChanged(nameof (rid_Cantidad));
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

    [Column(Storage = "_apl_Id", DbType = "Int NOT NULL")]
    public int apl_Id
    {
      get => this._apl_Id;
      set
      {
        if (this._apl_Id == value)
          return;
        if (this._apl_Aplicacion.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._apl_Id = value;
        this.SendPropertyChanged(nameof (apl_Id));
      }
    }

    [Column(Storage = "_rid_Usuario", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
    public string rid_Usuario
    {
      get => this._rid_Usuario;
      set
      {
        if (!(this._rid_Usuario != value))
          return;
        this.SendPropertyChanging();
        this._rid_Usuario = value;
        this.SendPropertyChanged(nameof (rid_Usuario));
      }
    }

    [Column(Storage = "_rid_Creado", DbType = "DateTime NOT NULL")]
    public DateTime rid_Creado
    {
      get => this._rid_Creado;
      set
      {
        if (!(this._rid_Creado != value))
          return;
        this.SendPropertyChanging();
        this._rid_Creado = value;
        this.SendPropertyChanged(nameof (rid_Creado));
      }
    }

    [Column(Storage = "_rid_Modificado", DbType = "DateTime NOT NULL")]
    public DateTime rid_Modificado
    {
      get => this._rid_Modificado;
      set
      {
        if (!(this._rid_Modificado != value))
          return;
        this.SendPropertyChanging();
        this._rid_Modificado = value;
        this.SendPropertyChanged(nameof (rid_Modificado));
      }
    }

    [Association(Name = "apl_Aplicacion_rid_RegistroImportadorDetalle", Storage = "_apl_Aplicacion", ThisKey = "apl_Id", OtherKey = "apl_Id", IsForeignKey = true)]
    public apl_Aplicacion apl_Aplicacion
    {
      get => this._apl_Aplicacion.Entity;
      set
      {
        apl_Aplicacion entity = this._apl_Aplicacion.Entity;
        if (entity == value && this._apl_Aplicacion.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._apl_Aplicacion.Entity = (apl_Aplicacion) null;
          entity.rid_RegistroImportadorDetalles.Remove(this);
        }
        this._apl_Aplicacion.Entity = value;
        if (value != null)
        {
          value.rid_RegistroImportadorDetalles.Add(this);
          this._apl_Id = value.apl_Id;
        }
        else
          this._apl_Id = 0;
        this.SendPropertyChanged(nameof (apl_Aplicacion));
      }
    }

    [Association(Name = "dep_Departamento_rid_RegistroImportadorDetalle", Storage = "_dep_Departamento", ThisKey = "dep_Id", OtherKey = "dep_Id", IsForeignKey = true)]
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
          entity.rid_RegistroImportadorDetalles.Remove(this);
        }
        this._dep_Departamento.Entity = value;
        if (value != null)
        {
          value.rid_RegistroImportadorDetalles.Add(this);
          this._dep_Id = value.dep_Id;
        }
        else
          this._dep_Id = (string) null;
        this.SendPropertyChanged(nameof (dep_Departamento));
      }
    }

    [Association(Name = "mun_Municipio_rid_RegistroImportadorDetalle", Storage = "_mun_Municipio", ThisKey = "mun_Id", OtherKey = "mun_Id", IsForeignKey = true)]
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
          entity.rid_RegistroImportadorDetalles.Remove(this);
        }
        this._mun_Municipio.Entity = value;
        if (value != null)
        {
          value.rid_RegistroImportadorDetalles.Add(this);
          this._mun_Id = value.mun_Id;
        }
        else
          this._mun_Id = (string) null;
        this.SendPropertyChanged(nameof (mun_Municipio));
      }
    }

    [Association(Name = "rri_RegistroReporteImportador_rid_RegistroImportadorDetalle", Storage = "_rri_RegistroReporteImportador", ThisKey = "rri_Id", OtherKey = "rri_Id", IsForeignKey = true)]
    public rri_RegistroReporteImportador rri_RegistroReporteImportador
    {
      get => this._rri_RegistroReporteImportador.Entity;
      set
      {
        rri_RegistroReporteImportador entity = this._rri_RegistroReporteImportador.Entity;
        if (entity == value && this._rri_RegistroReporteImportador.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._rri_RegistroReporteImportador.Entity = (rri_RegistroReporteImportador) null;
          entity.rid_RegistroImportadorDetalles.Remove(this);
        }
        this._rri_RegistroReporteImportador.Entity = value;
        if (value != null)
        {
          value.rid_RegistroImportadorDetalles.Add(this);
          this._rri_Id = value.rri_Id;
        }
        else
          this._rri_Id = 0;
        this.SendPropertyChanged(nameof (rri_RegistroReporteImportador));
      }
    }

    [Association(Name = "sus_Sustancia_rid_RegistroImportadorDetalle", Storage = "_sus_Sustancia", ThisKey = "sus_Id", OtherKey = "sus_Id", IsForeignKey = true)]
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
          entity.rid_RegistroImportadorDetalles.Remove(this);
        }
        this._sus_Sustancia.Entity = value;
        if (value != null)
        {
          value.rid_RegistroImportadorDetalles.Add(this);
          this._sus_Id = value.sus_Id;
        }
        else
          this._sus_Id = 0;
        this.SendPropertyChanged(nameof (sus_Sustancia));
      }
    }

    [Association(Name = "ter_Tercero_rid_RegistroImportadorDetalle", Storage = "_ter_Tercero", ThisKey = "ter_Id", OtherKey = "ter_Id", IsForeignKey = true)]
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
          entity.rid_RegistroImportadorDetalles.Remove(this);
        }
        this._ter_Tercero.Entity = value;
        if (value != null)
        {
          value.rid_RegistroImportadorDetalles.Add(this);
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
      this.PropertyChanging((object) this, rid_RegistroImportadorDetalle.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
