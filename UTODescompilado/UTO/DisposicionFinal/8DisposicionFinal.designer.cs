// Decompiled with JetBrains decompiler
// Type: UTO.DisposicionFinal.ddd_DisposicionDatosDetalle
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO.DisposicionFinal
{
  [Table(Name = "Dis.ddd_DisposicionDatosDetalle")]
  public class ddd_DisposicionDatosDetalle : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _ddd_Id;
    private int _dfd_Id;
    private int _sus_Id;
    private int _psu_Id;
    private Decimal _ddd_Cantidad;
    private int _des_Id;
    private string _ddd_Observaciones;
    private string _ddd_Actualizacion;
    private string _ddd_DireccionAlmacenamiento;
    private string _ddd_Usuario;
    private DateTime _ddd_Creado;
    private DateTime _ddd_Modificado;
    private EntityRef<des_DisposicionEstado> _des_DisposicionEstado;
    private EntityRef<dfd_DisposicionFinalDato> _dfd_DisposicionFinalDato;
    private EntityRef<psu_PresentacionSustancia> _psu_PresentacionSustancia;
    private EntityRef<sus_Sustancia> _sus_Sustancia;

    public ddd_DisposicionDatosDetalle()
    {
      this._des_DisposicionEstado = new EntityRef<des_DisposicionEstado>();
      this._dfd_DisposicionFinalDato = new EntityRef<dfd_DisposicionFinalDato>();
      this._psu_PresentacionSustancia = new EntityRef<psu_PresentacionSustancia>();
      this._sus_Sustancia = new EntityRef<sus_Sustancia>();
    }

    [Column(Storage = "_ddd_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
    public int ddd_Id
    {
      get => this._ddd_Id;
      set
      {
        if (this._ddd_Id == value)
          return;
        this.SendPropertyChanging();
        this._ddd_Id = value;
        this.SendPropertyChanged(nameof (ddd_Id));
      }
    }

    [Column(Storage = "_dfd_Id", DbType = "Int NOT NULL")]
    public int dfd_Id
    {
      get => this._dfd_Id;
      set
      {
        if (this._dfd_Id == value)
          return;
        if (this._dfd_DisposicionFinalDato.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._dfd_Id = value;
        this.SendPropertyChanged(nameof (dfd_Id));
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

    [Column(Storage = "_psu_Id", DbType = "Int NOT NULL")]
    public int psu_Id
    {
      get => this._psu_Id;
      set
      {
        if (this._psu_Id == value)
          return;
        if (this._psu_PresentacionSustancia.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._psu_Id = value;
        this.SendPropertyChanged(nameof (psu_Id));
      }
    }

    [Column(Storage = "_ddd_Cantidad", DbType = "Decimal(10,2) NOT NULL")]
    public Decimal ddd_Cantidad
    {
      get => this._ddd_Cantidad;
      set
      {
        if (!(this._ddd_Cantidad != value))
          return;
        this.SendPropertyChanging();
        this._ddd_Cantidad = value;
        this.SendPropertyChanged(nameof (ddd_Cantidad));
      }
    }

    [Column(Storage = "_des_Id", DbType = "Int NOT NULL")]
    public int des_Id
    {
      get => this._des_Id;
      set
      {
        if (this._des_Id == value)
          return;
        if (this._des_DisposicionEstado.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._des_Id = value;
        this.SendPropertyChanged(nameof (des_Id));
      }
    }

    [Column(Storage = "_ddd_Observaciones", DbType = "VarChar(MAX)")]
    public string ddd_Observaciones
    {
      get => this._ddd_Observaciones;
      set
      {
        if (!(this._ddd_Observaciones != value))
          return;
        this.SendPropertyChanging();
        this._ddd_Observaciones = value;
        this.SendPropertyChanged(nameof (ddd_Observaciones));
      }
    }

    [Column(Storage = "_ddd_Actualizacion", DbType = "VarChar(MAX)")]
    public string ddd_Actualizacion
    {
      get => this._ddd_Actualizacion;
      set
      {
        if (!(this._ddd_Actualizacion != value))
          return;
        this.SendPropertyChanging();
        this._ddd_Actualizacion = value;
        this.SendPropertyChanged(nameof (ddd_Actualizacion));
      }
    }

    [Column(Storage = "_ddd_DireccionAlmacenamiento", DbType = "VarChar(MAX)")]
    public string ddd_DireccionAlmacenamiento
    {
      get => this._ddd_DireccionAlmacenamiento;
      set
      {
        if (!(this._ddd_DireccionAlmacenamiento != value))
          return;
        this.SendPropertyChanging();
        this._ddd_DireccionAlmacenamiento = value;
        this.SendPropertyChanged(nameof (ddd_DireccionAlmacenamiento));
      }
    }

    [Column(Storage = "_ddd_Usuario", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
    public string ddd_Usuario
    {
      get => this._ddd_Usuario;
      set
      {
        if (!(this._ddd_Usuario != value))
          return;
        this.SendPropertyChanging();
        this._ddd_Usuario = value;
        this.SendPropertyChanged(nameof (ddd_Usuario));
      }
    }

    [Column(Storage = "_ddd_Creado", DbType = "DateTime NOT NULL")]
    public DateTime ddd_Creado
    {
      get => this._ddd_Creado;
      set
      {
        if (!(this._ddd_Creado != value))
          return;
        this.SendPropertyChanging();
        this._ddd_Creado = value;
        this.SendPropertyChanged(nameof (ddd_Creado));
      }
    }

    [Column(Storage = "_ddd_Modificado", DbType = "DateTime NOT NULL")]
    public DateTime ddd_Modificado
    {
      get => this._ddd_Modificado;
      set
      {
        if (!(this._ddd_Modificado != value))
          return;
        this.SendPropertyChanging();
        this._ddd_Modificado = value;
        this.SendPropertyChanged(nameof (ddd_Modificado));
      }
    }

    [Association(Name = "des_DisposicionEstado_ddd_DisposicionDatosDetalle", Storage = "_des_DisposicionEstado", ThisKey = "des_Id", OtherKey = "des_Id", IsForeignKey = true)]
    public des_DisposicionEstado des_DisposicionEstado
    {
      get => this._des_DisposicionEstado.Entity;
      set
      {
        des_DisposicionEstado entity = this._des_DisposicionEstado.Entity;
        if (entity == value && this._des_DisposicionEstado.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._des_DisposicionEstado.Entity = (des_DisposicionEstado) null;
          entity.ddd_DisposicionDatosDetalles.Remove(this);
        }
        this._des_DisposicionEstado.Entity = value;
        if (value != null)
        {
          value.ddd_DisposicionDatosDetalles.Add(this);
          this._des_Id = value.des_Id;
        }
        else
          this._des_Id = 0;
        this.SendPropertyChanged(nameof (des_DisposicionEstado));
      }
    }

    [Association(Name = "dfd_DisposicionFinalDato_ddd_DisposicionDatosDetalle", Storage = "_dfd_DisposicionFinalDato", ThisKey = "dfd_Id", OtherKey = "dfd_Id", IsForeignKey = true)]
    public dfd_DisposicionFinalDato dfd_DisposicionFinalDato
    {
      get => this._dfd_DisposicionFinalDato.Entity;
      set
      {
        dfd_DisposicionFinalDato entity = this._dfd_DisposicionFinalDato.Entity;
        if (entity == value && this._dfd_DisposicionFinalDato.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._dfd_DisposicionFinalDato.Entity = (dfd_DisposicionFinalDato) null;
          entity.ddd_DisposicionDatosDetalles.Remove(this);
        }
        this._dfd_DisposicionFinalDato.Entity = value;
        if (value != null)
        {
          value.ddd_DisposicionDatosDetalles.Add(this);
          this._dfd_Id = value.dfd_Id;
        }
        else
          this._dfd_Id = 0;
        this.SendPropertyChanged(nameof (dfd_DisposicionFinalDato));
      }
    }

    [Association(Name = "psu_PresentacionSustancia_ddd_DisposicionDatosDetalle", Storage = "_psu_PresentacionSustancia", ThisKey = "psu_Id", OtherKey = "psu_Id", IsForeignKey = true)]
    public psu_PresentacionSustancia psu_PresentacionSustancia
    {
      get => this._psu_PresentacionSustancia.Entity;
      set
      {
        psu_PresentacionSustancia entity = this._psu_PresentacionSustancia.Entity;
        if (entity == value && this._psu_PresentacionSustancia.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._psu_PresentacionSustancia.Entity = (psu_PresentacionSustancia) null;
          entity.ddd_DisposicionDatosDetalles.Remove(this);
        }
        this._psu_PresentacionSustancia.Entity = value;
        if (value != null)
        {
          value.ddd_DisposicionDatosDetalles.Add(this);
          this._psu_Id = value.psu_Id;
        }
        else
          this._psu_Id = 0;
        this.SendPropertyChanged(nameof (psu_PresentacionSustancia));
      }
    }

    [Association(Name = "sus_Sustancia_ddd_DisposicionDatosDetalle", Storage = "_sus_Sustancia", ThisKey = "sus_Id", OtherKey = "sus_Id", IsForeignKey = true)]
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
          entity.ddd_DisposicionDatosDetalles.Remove(this);
        }
        this._sus_Sustancia.Entity = value;
        if (value != null)
        {
          value.ddd_DisposicionDatosDetalles.Add(this);
          this._sus_Id = value.sus_Id;
        }
        else
          this._sus_Id = 0;
        this.SendPropertyChanged(nameof (sus_Sustancia));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, ddd_DisposicionDatosDetalle.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
