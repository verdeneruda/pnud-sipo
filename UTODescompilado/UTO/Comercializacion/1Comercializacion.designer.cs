// Decompiled with JetBrains decompiler
// Type: UTO.Comercializacion.cda_ComercializacionDato
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO.Comercializacion
{
  [Table(Name = "Com.cda_ComercializacionDatos")]
  public class cda_ComercializacionDato : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _cda_Id;
    private DateTime _cda_Fecha;
    private string _dep_Id;
    private string _mun_Id;
    private int _ter_Id;
    private string _cda_Contacto;
    private string _cda_Usuario;
    private DateTime _cda_Creado;
    private DateTime _cda_Modificado;
    private string _cda_Direccion;
    private string _cda_Telefono;
    private EntitySet<cdd_ComercializacionDatosDetalle> _cdd_ComercializacionDatosDetalles;
    private EntitySet<cpr_ComercializacionProveedor> _cpr_ComercializacionProveedors;
    private EntityRef<dep_Departamento> _dep_Departamento;
    private EntityRef<mun_Municipio> _mun_Municipio;
    private EntityRef<ter_Tercero> _ter_Tercero;

    public cda_ComercializacionDato()
    {
      this._cdd_ComercializacionDatosDetalles = new EntitySet<cdd_ComercializacionDatosDetalle>(new Action<cdd_ComercializacionDatosDetalle>(this.attach_cdd_ComercializacionDatosDetalles), new Action<cdd_ComercializacionDatosDetalle>(this.detach_cdd_ComercializacionDatosDetalles));
      this._cpr_ComercializacionProveedors = new EntitySet<cpr_ComercializacionProveedor>(new Action<cpr_ComercializacionProveedor>(this.attach_cpr_ComercializacionProveedors), new Action<cpr_ComercializacionProveedor>(this.detach_cpr_ComercializacionProveedors));
      this._dep_Departamento = new EntityRef<dep_Departamento>();
      this._mun_Municipio = new EntityRef<mun_Municipio>();
      this._ter_Tercero = new EntityRef<ter_Tercero>();
    }

    [Column(Storage = "_cda_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
    public int cda_Id
    {
      get => this._cda_Id;
      set
      {
        if (this._cda_Id == value)
          return;
        this.SendPropertyChanging();
        this._cda_Id = value;
        this.SendPropertyChanged(nameof (cda_Id));
      }
    }

    [Column(Storage = "_cda_Fecha", DbType = "DateTime NOT NULL")]
    public DateTime cda_Fecha
    {
      get => this._cda_Fecha;
      set
      {
        if (!(this._cda_Fecha != value))
          return;
        this.SendPropertyChanging();
        this._cda_Fecha = value;
        this.SendPropertyChanged(nameof (cda_Fecha));
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

    [Column(Storage = "_cda_Contacto", DbType = "VarChar(450) NOT NULL", CanBeNull = false)]
    public string cda_Contacto
    {
      get => this._cda_Contacto;
      set
      {
        if (!(this._cda_Contacto != value))
          return;
        this.SendPropertyChanging();
        this._cda_Contacto = value;
        this.SendPropertyChanged(nameof (cda_Contacto));
      }
    }

    [Column(Storage = "_cda_Usuario", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
    public string cda_Usuario
    {
      get => this._cda_Usuario;
      set
      {
        if (!(this._cda_Usuario != value))
          return;
        this.SendPropertyChanging();
        this._cda_Usuario = value;
        this.SendPropertyChanged(nameof (cda_Usuario));
      }
    }

    [Column(Storage = "_cda_Creado", DbType = "DateTime NOT NULL")]
    public DateTime cda_Creado
    {
      get => this._cda_Creado;
      set
      {
        if (!(this._cda_Creado != value))
          return;
        this.SendPropertyChanging();
        this._cda_Creado = value;
        this.SendPropertyChanged(nameof (cda_Creado));
      }
    }

    [Column(Storage = "_cda_Modificado", DbType = "DateTime NOT NULL")]
    public DateTime cda_Modificado
    {
      get => this._cda_Modificado;
      set
      {
        if (!(this._cda_Modificado != value))
          return;
        this.SendPropertyChanging();
        this._cda_Modificado = value;
        this.SendPropertyChanged(nameof (cda_Modificado));
      }
    }

    [Column(Storage = "_cda_Direccion", CanBeNull = false)]
    public string cda_Direccion
    {
      get => this._cda_Direccion;
      set
      {
        if (!(this._cda_Direccion != value))
          return;
        this.SendPropertyChanging();
        this._cda_Direccion = value;
        this.SendPropertyChanged(nameof (cda_Direccion));
      }
    }

    [Column(Storage = "_cda_Telefono", CanBeNull = false)]
    public string cda_Telefono
    {
      get => this._cda_Telefono;
      set
      {
        if (!(this._cda_Telefono != value))
          return;
        this.SendPropertyChanging();
        this._cda_Telefono = value;
        this.SendPropertyChanged(nameof (cda_Telefono));
      }
    }

    [Association(Name = "cda_ComercializacionDato_cdd_ComercializacionDatosDetalle", Storage = "_cdd_ComercializacionDatosDetalles", ThisKey = "cda_Id", OtherKey = "cda_Id")]
    public EntitySet<cdd_ComercializacionDatosDetalle> cdd_ComercializacionDatosDetalles
    {
      get => this._cdd_ComercializacionDatosDetalles;
      set => this._cdd_ComercializacionDatosDetalles.Assign((IEnumerable<cdd_ComercializacionDatosDetalle>) value);
    }

    [Association(Name = "cda_ComercializacionDato_cpr_ComercializacionProveedor", Storage = "_cpr_ComercializacionProveedors", ThisKey = "cda_Id", OtherKey = "cda_Id")]
    public EntitySet<cpr_ComercializacionProveedor> cpr_ComercializacionProveedors
    {
      get => this._cpr_ComercializacionProveedors;
      set => this._cpr_ComercializacionProveedors.Assign((IEnumerable<cpr_ComercializacionProveedor>) value);
    }

    [Association(Name = "dep_Departamento_cda_ComercializacionDato", Storage = "_dep_Departamento", ThisKey = "dep_Id", OtherKey = "dep_Id", IsForeignKey = true)]
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
          entity.cda_ComercializacionDatos.Remove(this);
        }
        this._dep_Departamento.Entity = value;
        if (value != null)
        {
          value.cda_ComercializacionDatos.Add(this);
          this._dep_Id = value.dep_Id;
        }
        else
          this._dep_Id = (string) null;
        this.SendPropertyChanged(nameof (dep_Departamento));
      }
    }

    [Association(Name = "mun_Municipio_cda_ComercializacionDato", Storage = "_mun_Municipio", ThisKey = "mun_Id", OtherKey = "mun_Id", IsForeignKey = true)]
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
          entity.cda_ComercializacionDatos.Remove(this);
        }
        this._mun_Municipio.Entity = value;
        if (value != null)
        {
          value.cda_ComercializacionDatos.Add(this);
          this._mun_Id = value.mun_Id;
        }
        else
          this._mun_Id = (string) null;
        this.SendPropertyChanged(nameof (mun_Municipio));
      }
    }

    [Association(Name = "ter_Tercero_cda_ComercializacionDato", Storage = "_ter_Tercero", ThisKey = "ter_Id", OtherKey = "ter_Id", IsForeignKey = true)]
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
          entity.cda_ComercializacionDatos.Remove(this);
        }
        this._ter_Tercero.Entity = value;
        if (value != null)
        {
          value.cda_ComercializacionDatos.Add(this);
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
      this.PropertyChanging((object) this, cda_ComercializacionDato.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void attach_cdd_ComercializacionDatosDetalles(cdd_ComercializacionDatosDetalle entity)
    {
      this.SendPropertyChanging();
      entity.cda_ComercializacionDato = this;
    }

    private void detach_cdd_ComercializacionDatosDetalles(cdd_ComercializacionDatosDetalle entity)
    {
      this.SendPropertyChanging();
      entity.cda_ComercializacionDato = (cda_ComercializacionDato) null;
    }

    private void attach_cpr_ComercializacionProveedors(cpr_ComercializacionProveedor entity)
    {
      this.SendPropertyChanging();
      entity.cda_ComercializacionDato = this;
    }

    private void detach_cpr_ComercializacionProveedors(cpr_ComercializacionProveedor entity)
    {
      this.SendPropertyChanging();
      entity.cda_ComercializacionDato = (cda_ComercializacionDato) null;
    }
  }
}
