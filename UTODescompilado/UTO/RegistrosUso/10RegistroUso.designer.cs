// Decompiled with JetBrains decompiler
// Type: UTO.RegistrosUso.ufd_UsuarioFinalDato
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO.RegistrosUso
{
  [Table(Name = "Rus.ufd_UsuarioFinalDatos")]
  public class ufd_UsuarioFinalDato : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _ufd_Id;
    private int _utf_Id;
    private int _sec_Id;
    private int _ter_Id;
    private DateTime _ufd_Fecha;
    private string _dep_Id;
    private string _mun_Id;
    private string _rri_Usuario;
    private DateTime _rri_Creado;
    private DateTime _rri_Modificado;
    private EntitySet<ufe_UsuarioFinalDetalle> _ufe_UsuarioFinalDetalles;
    private EntityRef<dep_Departamento> _dep_Departamento;
    private EntityRef<mun_Municipio> _mun_Municipio;
    private EntityRef<sec_Sector> _sec_Sector;
    private EntityRef<ter_Tercero> _ter_Tercero;
    private EntityRef<utf_UsuarioTipoFinal> _utf_UsuarioTipoFinal;

    public ufd_UsuarioFinalDato()
    {
      this._ufe_UsuarioFinalDetalles = new EntitySet<ufe_UsuarioFinalDetalle>(new Action<ufe_UsuarioFinalDetalle>(this.attach_ufe_UsuarioFinalDetalles), new Action<ufe_UsuarioFinalDetalle>(this.detach_ufe_UsuarioFinalDetalles));
      this._dep_Departamento = new EntityRef<dep_Departamento>();
      this._mun_Municipio = new EntityRef<mun_Municipio>();
      this._sec_Sector = new EntityRef<sec_Sector>();
      this._ter_Tercero = new EntityRef<ter_Tercero>();
      this._utf_UsuarioTipoFinal = new EntityRef<utf_UsuarioTipoFinal>();
    }

    [Column(Storage = "_ufd_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
    public int ufd_Id
    {
      get => this._ufd_Id;
      set
      {
        if (this._ufd_Id == value)
          return;
        this.SendPropertyChanging();
        this._ufd_Id = value;
        this.SendPropertyChanged(nameof (ufd_Id));
      }
    }

    [Column(Storage = "_utf_Id", DbType = "Int NOT NULL")]
    public int utf_Id
    {
      get => this._utf_Id;
      set
      {
        if (this._utf_Id == value)
          return;
        if (this._utf_UsuarioTipoFinal.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._utf_Id = value;
        this.SendPropertyChanged(nameof (utf_Id));
      }
    }

    [Column(Storage = "_sec_Id", DbType = "Int NOT NULL")]
    public int sec_Id
    {
      get => this._sec_Id;
      set
      {
        if (this._sec_Id == value)
          return;
        if (this._sec_Sector.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._sec_Id = value;
        this.SendPropertyChanged(nameof (sec_Id));
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

    [Column(Storage = "_ufd_Fecha", DbType = "DateTime NOT NULL")]
    public DateTime ufd_Fecha
    {
      get => this._ufd_Fecha;
      set
      {
        if (!(this._ufd_Fecha != value))
          return;
        this.SendPropertyChanging();
        this._ufd_Fecha = value;
        this.SendPropertyChanged(nameof (ufd_Fecha));
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

    [Column(Storage = "_rri_Usuario", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
    public string rri_Usuario
    {
      get => this._rri_Usuario;
      set
      {
        if (!(this._rri_Usuario != value))
          return;
        this.SendPropertyChanging();
        this._rri_Usuario = value;
        this.SendPropertyChanged(nameof (rri_Usuario));
      }
    }

    [Column(Storage = "_rri_Creado", DbType = "DateTime NOT NULL")]
    public DateTime rri_Creado
    {
      get => this._rri_Creado;
      set
      {
        if (!(this._rri_Creado != value))
          return;
        this.SendPropertyChanging();
        this._rri_Creado = value;
        this.SendPropertyChanged(nameof (rri_Creado));
      }
    }

    [Column(Storage = "_rri_Modificado", DbType = "DateTime NOT NULL")]
    public DateTime rri_Modificado
    {
      get => this._rri_Modificado;
      set
      {
        if (!(this._rri_Modificado != value))
          return;
        this.SendPropertyChanging();
        this._rri_Modificado = value;
        this.SendPropertyChanged(nameof (rri_Modificado));
      }
    }

    [Association(Name = "ufd_UsuarioFinalDato_ufe_UsuarioFinalDetalle", Storage = "_ufe_UsuarioFinalDetalles", ThisKey = "ufd_Id", OtherKey = "ufd_Id")]
    public EntitySet<ufe_UsuarioFinalDetalle> ufe_UsuarioFinalDetalles
    {
      get => this._ufe_UsuarioFinalDetalles;
      set => this._ufe_UsuarioFinalDetalles.Assign((IEnumerable<ufe_UsuarioFinalDetalle>) value);
    }

    [Association(Name = "dep_Departamento_ufd_UsuarioFinalDato", Storage = "_dep_Departamento", ThisKey = "dep_Id", OtherKey = "dep_Id", IsForeignKey = true)]
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
          entity.ufd_UsuarioFinalDatos.Remove(this);
        }
        this._dep_Departamento.Entity = value;
        if (value != null)
        {
          value.ufd_UsuarioFinalDatos.Add(this);
          this._dep_Id = value.dep_Id;
        }
        else
          this._dep_Id = (string) null;
        this.SendPropertyChanged(nameof (dep_Departamento));
      }
    }

    [Association(Name = "mun_Municipio_ufd_UsuarioFinalDato", Storage = "_mun_Municipio", ThisKey = "mun_Id", OtherKey = "mun_Id", IsForeignKey = true)]
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
          entity.ufd_UsuarioFinalDatos.Remove(this);
        }
        this._mun_Municipio.Entity = value;
        if (value != null)
        {
          value.ufd_UsuarioFinalDatos.Add(this);
          this._mun_Id = value.mun_Id;
        }
        else
          this._mun_Id = (string) null;
        this.SendPropertyChanged(nameof (mun_Municipio));
      }
    }

    [Association(Name = "sec_Sector_ufd_UsuarioFinalDato", Storage = "_sec_Sector", ThisKey = "sec_Id", OtherKey = "sec_Id", IsForeignKey = true)]
    public sec_Sector sec_Sector
    {
      get => this._sec_Sector.Entity;
      set
      {
        sec_Sector entity = this._sec_Sector.Entity;
        if (entity == value && this._sec_Sector.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._sec_Sector.Entity = (sec_Sector) null;
          entity.ufd_UsuarioFinalDatos.Remove(this);
        }
        this._sec_Sector.Entity = value;
        if (value != null)
        {
          value.ufd_UsuarioFinalDatos.Add(this);
          this._sec_Id = value.sec_Id;
        }
        else
          this._sec_Id = 0;
        this.SendPropertyChanged(nameof (sec_Sector));
      }
    }

    [Association(Name = "ter_Tercero_ufd_UsuarioFinalDato", Storage = "_ter_Tercero", ThisKey = "ter_Id", OtherKey = "ter_Id", IsForeignKey = true)]
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
          entity.ufd_UsuarioFinalDatos.Remove(this);
        }
        this._ter_Tercero.Entity = value;
        if (value != null)
        {
          value.ufd_UsuarioFinalDatos.Add(this);
          this._ter_Id = value.ter_Id;
        }
        else
          this._ter_Id = 0;
        this.SendPropertyChanged(nameof (ter_Tercero));
      }
    }

    [Association(Name = "utf_UsuarioTipoFinal_ufd_UsuarioFinalDato", Storage = "_utf_UsuarioTipoFinal", ThisKey = "utf_Id", OtherKey = "utf_Id", IsForeignKey = true)]
    public utf_UsuarioTipoFinal utf_UsuarioTipoFinal
    {
      get => this._utf_UsuarioTipoFinal.Entity;
      set
      {
        utf_UsuarioTipoFinal entity = this._utf_UsuarioTipoFinal.Entity;
        if (entity == value && this._utf_UsuarioTipoFinal.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._utf_UsuarioTipoFinal.Entity = (utf_UsuarioTipoFinal) null;
          entity.ufd_UsuarioFinalDatos.Remove(this);
        }
        this._utf_UsuarioTipoFinal.Entity = value;
        if (value != null)
        {
          value.ufd_UsuarioFinalDatos.Add(this);
          this._utf_Id = value.utf_Id;
        }
        else
          this._utf_Id = 0;
        this.SendPropertyChanged(nameof (utf_UsuarioTipoFinal));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, ufd_UsuarioFinalDato.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void attach_ufe_UsuarioFinalDetalles(ufe_UsuarioFinalDetalle entity)
    {
      this.SendPropertyChanging();
      entity.ufd_UsuarioFinalDato = this;
    }

    private void detach_ufe_UsuarioFinalDetalles(ufe_UsuarioFinalDetalle entity)
    {
      this.SendPropertyChanging();
      entity.ufd_UsuarioFinalDato = (ufd_UsuarioFinalDato) null;
    }
  }
}
