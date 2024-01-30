// Decompiled with JetBrains decompiler
// Type: UTO.DisposicionFinal.dfd_DisposicionFinalDato
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO.DisposicionFinal
{
  [Table(Name = "Dis.dfd_DisposicionFinalDatos")]
  public class dfd_DisposicionFinalDato : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _dfd_Id;
    private DateTime _dfd_Fecha;
    private string _dep_Id;
    private string _mun_Id;
    private int _ter_Id;
    private string _dfd_Usuario;
    private DateTime _dfd_Creado;
    private DateTime _dfd_Modificado;
    private EntitySet<ddd_DisposicionDatosDetalle> _ddd_DisposicionDatosDetalles;
    private EntityRef<dep_Departamento> _dep_Departamento;
    private EntityRef<mun_Municipio> _mun_Municipio;
    private EntityRef<ter_Tercero> _ter_Tercero;

    public dfd_DisposicionFinalDato()
    {
      this._ddd_DisposicionDatosDetalles = new EntitySet<ddd_DisposicionDatosDetalle>(new Action<ddd_DisposicionDatosDetalle>(this.attach_ddd_DisposicionDatosDetalles), new Action<ddd_DisposicionDatosDetalle>(this.detach_ddd_DisposicionDatosDetalles));
      this._dep_Departamento = new EntityRef<dep_Departamento>();
      this._mun_Municipio = new EntityRef<mun_Municipio>();
      this._ter_Tercero = new EntityRef<ter_Tercero>();
    }

    [Column(Storage = "_dfd_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
    public int dfd_Id
    {
      get => this._dfd_Id;
      set
      {
        if (this._dfd_Id == value)
          return;
        this.SendPropertyChanging();
        this._dfd_Id = value;
        this.SendPropertyChanged(nameof (dfd_Id));
      }
    }

    [Column(Storage = "_dfd_Fecha", DbType = "DateTime NOT NULL")]
    public DateTime dfd_Fecha
    {
      get => this._dfd_Fecha;
      set
      {
        if (!(this._dfd_Fecha != value))
          return;
        this.SendPropertyChanging();
        this._dfd_Fecha = value;
        this.SendPropertyChanged(nameof (dfd_Fecha));
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

    [Column(Storage = "_dfd_Usuario", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
    public string dfd_Usuario
    {
      get => this._dfd_Usuario;
      set
      {
        if (!(this._dfd_Usuario != value))
          return;
        this.SendPropertyChanging();
        this._dfd_Usuario = value;
        this.SendPropertyChanged(nameof (dfd_Usuario));
      }
    }

    [Column(Storage = "_dfd_Creado", DbType = "DateTime NOT NULL")]
    public DateTime dfd_Creado
    {
      get => this._dfd_Creado;
      set
      {
        if (!(this._dfd_Creado != value))
          return;
        this.SendPropertyChanging();
        this._dfd_Creado = value;
        this.SendPropertyChanged(nameof (dfd_Creado));
      }
    }

    [Column(Storage = "_dfd_Modificado", DbType = "DateTime NOT NULL")]
    public DateTime dfd_Modificado
    {
      get => this._dfd_Modificado;
      set
      {
        if (!(this._dfd_Modificado != value))
          return;
        this.SendPropertyChanging();
        this._dfd_Modificado = value;
        this.SendPropertyChanged(nameof (dfd_Modificado));
      }
    }

    [Association(Name = "dfd_DisposicionFinalDato_ddd_DisposicionDatosDetalle", Storage = "_ddd_DisposicionDatosDetalles", ThisKey = "dfd_Id", OtherKey = "dfd_Id")]
    public EntitySet<ddd_DisposicionDatosDetalle> ddd_DisposicionDatosDetalles
    {
      get => this._ddd_DisposicionDatosDetalles;
      set => this._ddd_DisposicionDatosDetalles.Assign((IEnumerable<ddd_DisposicionDatosDetalle>) value);
    }

    [Association(Name = "dep_Departamento_dfd_DisposicionFinalDato", Storage = "_dep_Departamento", ThisKey = "dep_Id", OtherKey = "dep_Id", IsForeignKey = true)]
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
          entity.dfd_DisposicionFinalDatos.Remove(this);
        }
        this._dep_Departamento.Entity = value;
        if (value != null)
        {
          value.dfd_DisposicionFinalDatos.Add(this);
          this._dep_Id = value.dep_Id;
        }
        else
          this._dep_Id = (string) null;
        this.SendPropertyChanged(nameof (dep_Departamento));
      }
    }

    [Association(Name = "mun_Municipio_dfd_DisposicionFinalDato", Storage = "_mun_Municipio", ThisKey = "mun_Id", OtherKey = "mun_Id", IsForeignKey = true)]
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
          entity.dfd_DisposicionFinalDatos.Remove(this);
        }
        this._mun_Municipio.Entity = value;
        if (value != null)
        {
          value.dfd_DisposicionFinalDatos.Add(this);
          this._mun_Id = value.mun_Id;
        }
        else
          this._mun_Id = (string) null;
        this.SendPropertyChanged(nameof (mun_Municipio));
      }
    }

    [Association(Name = "ter_Tercero_dfd_DisposicionFinalDato", Storage = "_ter_Tercero", ThisKey = "ter_Id", OtherKey = "ter_Id", IsForeignKey = true)]
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
          entity.dfd_DisposicionFinalDatos.Remove(this);
        }
        this._ter_Tercero.Entity = value;
        if (value != null)
        {
          value.dfd_DisposicionFinalDatos.Add(this);
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
      this.PropertyChanging((object) this, dfd_DisposicionFinalDato.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void attach_ddd_DisposicionDatosDetalles(ddd_DisposicionDatosDetalle entity)
    {
      this.SendPropertyChanging();
      entity.dfd_DisposicionFinalDato = this;
    }

    private void detach_ddd_DisposicionDatosDetalles(ddd_DisposicionDatosDetalle entity)
    {
      this.SendPropertyChanging();
      entity.dfd_DisposicionFinalDato = (dfd_DisposicionFinalDato) null;
    }
  }
}
