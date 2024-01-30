// Decompiled with JetBrains decompiler
// Type: UTO.Comercializacion.cdd_ComercializacionDatosDetalle
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO.Comercializacion
{
  [Table(Name = "Com.cdd_ComercializacionDatosDetalle")]
  public class cdd_ComercializacionDatosDetalle : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _cdd_Id;
    private int _cda_Id;
    private int _sus_Id;
    private int _ter_IdFabricante;
    private int _psu_Id;
    private int _mar_Id;
    private Decimal _cdd_Precio;
    private string _cdd_Observaciones;
    private string _cdd_Usuario;
    private DateTime _cdd_Creado;
    private DateTime _cdd_Modificado;
    private EntityRef<cda_ComercializacionDato> _cda_ComercializacionDato;
    private EntityRef<mar_Marca> _mar_Marca;
    private EntityRef<psu_PresentacionSustancia> _psu_PresentacionSustancia;
    private EntityRef<sus_Sustancia> _sus_Sustancia;
    private EntityRef<ter_Tercero> _ter_Tercero;

    public cdd_ComercializacionDatosDetalle()
    {
      this._cda_ComercializacionDato = new EntityRef<cda_ComercializacionDato>();
      this._mar_Marca = new EntityRef<mar_Marca>();
      this._psu_PresentacionSustancia = new EntityRef<psu_PresentacionSustancia>();
      this._sus_Sustancia = new EntityRef<sus_Sustancia>();
      this._ter_Tercero = new EntityRef<ter_Tercero>();
    }

    [Column(Storage = "_cdd_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
    public int cdd_Id
    {
      get => this._cdd_Id;
      set
      {
        if (this._cdd_Id == value)
          return;
        this.SendPropertyChanging();
        this._cdd_Id = value;
        this.SendPropertyChanged(nameof (cdd_Id));
      }
    }

    [Column(Storage = "_cda_Id", DbType = "Int NOT NULL")]
    public int cda_Id
    {
      get => this._cda_Id;
      set
      {
        if (this._cda_Id == value)
          return;
        if (this._cda_ComercializacionDato.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._cda_Id = value;
        this.SendPropertyChanged(nameof (cda_Id));
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

    [Column(Storage = "_ter_IdFabricante", DbType = "Int NOT NULL")]
    public int ter_IdFabricante
    {
      get => this._ter_IdFabricante;
      set
      {
        if (this._ter_IdFabricante == value)
          return;
        if (this._ter_Tercero.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._ter_IdFabricante = value;
        this.SendPropertyChanged(nameof (ter_IdFabricante));
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

    [Column(Storage = "_mar_Id", DbType = "Int NOT NULL")]
    public int mar_Id
    {
      get => this._mar_Id;
      set
      {
        if (this._mar_Id == value)
          return;
        if (this._mar_Marca.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._mar_Id = value;
        this.SendPropertyChanged(nameof (mar_Id));
      }
    }

    [Column(Storage = "_cdd_Precio", DbType = "Money NOT NULL")]
    public Decimal cdd_Precio
    {
      get => this._cdd_Precio;
      set
      {
        if (!(this._cdd_Precio != value))
          return;
        this.SendPropertyChanging();
        this._cdd_Precio = value;
        this.SendPropertyChanged(nameof (cdd_Precio));
      }
    }

    [Column(Storage = "_cdd_Observaciones", DbType = "VarChar(MAX)")]
    public string cdd_Observaciones
    {
      get => this._cdd_Observaciones;
      set
      {
        if (!(this._cdd_Observaciones != value))
          return;
        this.SendPropertyChanging();
        this._cdd_Observaciones = value;
        this.SendPropertyChanged(nameof (cdd_Observaciones));
      }
    }

    [Column(Storage = "_cdd_Usuario", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
    public string cdd_Usuario
    {
      get => this._cdd_Usuario;
      set
      {
        if (!(this._cdd_Usuario != value))
          return;
        this.SendPropertyChanging();
        this._cdd_Usuario = value;
        this.SendPropertyChanged(nameof (cdd_Usuario));
      }
    }

    [Column(Storage = "_cdd_Creado", DbType = "DateTime NOT NULL")]
    public DateTime cdd_Creado
    {
      get => this._cdd_Creado;
      set
      {
        if (!(this._cdd_Creado != value))
          return;
        this.SendPropertyChanging();
        this._cdd_Creado = value;
        this.SendPropertyChanged(nameof (cdd_Creado));
      }
    }

    [Column(Storage = "_cdd_Modificado", DbType = "DateTime NOT NULL")]
    public DateTime cdd_Modificado
    {
      get => this._cdd_Modificado;
      set
      {
        if (!(this._cdd_Modificado != value))
          return;
        this.SendPropertyChanging();
        this._cdd_Modificado = value;
        this.SendPropertyChanged(nameof (cdd_Modificado));
      }
    }

    [Association(Name = "cda_ComercializacionDato_cdd_ComercializacionDatosDetalle", Storage = "_cda_ComercializacionDato", ThisKey = "cda_Id", OtherKey = "cda_Id", IsForeignKey = true)]
    public cda_ComercializacionDato cda_ComercializacionDato
    {
      get => this._cda_ComercializacionDato.Entity;
      set
      {
        cda_ComercializacionDato entity = this._cda_ComercializacionDato.Entity;
        if (entity == value && this._cda_ComercializacionDato.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._cda_ComercializacionDato.Entity = (cda_ComercializacionDato) null;
          entity.cdd_ComercializacionDatosDetalles.Remove(this);
        }
        this._cda_ComercializacionDato.Entity = value;
        if (value != null)
        {
          value.cdd_ComercializacionDatosDetalles.Add(this);
          this._cda_Id = value.cda_Id;
        }
        else
          this._cda_Id = 0;
        this.SendPropertyChanged(nameof (cda_ComercializacionDato));
      }
    }

    [Association(Name = "mar_Marca_cdd_ComercializacionDatosDetalle", Storage = "_mar_Marca", ThisKey = "mar_Id", OtherKey = "mar_Id", IsForeignKey = true)]
    public mar_Marca mar_Marca
    {
      get => this._mar_Marca.Entity;
      set
      {
        mar_Marca entity = this._mar_Marca.Entity;
        if (entity == value && this._mar_Marca.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._mar_Marca.Entity = (mar_Marca) null;
          entity.cdd_ComercializacionDatosDetalles.Remove(this);
        }
        this._mar_Marca.Entity = value;
        if (value != null)
        {
          value.cdd_ComercializacionDatosDetalles.Add(this);
          this._mar_Id = value.mar_Id;
        }
        else
          this._mar_Id = 0;
        this.SendPropertyChanged(nameof (mar_Marca));
      }
    }

    [Association(Name = "psu_PresentacionSustancia_cdd_ComercializacionDatosDetalle", Storage = "_psu_PresentacionSustancia", ThisKey = "psu_Id", OtherKey = "psu_Id", IsForeignKey = true)]
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
          entity.cdd_ComercializacionDatosDetalles.Remove(this);
        }
        this._psu_PresentacionSustancia.Entity = value;
        if (value != null)
        {
          value.cdd_ComercializacionDatosDetalles.Add(this);
          this._psu_Id = value.psu_Id;
        }
        else
          this._psu_Id = 0;
        this.SendPropertyChanged(nameof (psu_PresentacionSustancia));
      }
    }

    [Association(Name = "sus_Sustancia_cdd_ComercializacionDatosDetalle", Storage = "_sus_Sustancia", ThisKey = "sus_Id", OtherKey = "sus_Id", IsForeignKey = true)]
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
          entity.cdd_ComercializacionDatosDetalles.Remove(this);
        }
        this._sus_Sustancia.Entity = value;
        if (value != null)
        {
          value.cdd_ComercializacionDatosDetalles.Add(this);
          this._sus_Id = value.sus_Id;
        }
        else
          this._sus_Id = 0;
        this.SendPropertyChanged(nameof (sus_Sustancia));
      }
    }

    [Association(Name = "ter_Tercero_cdd_ComercializacionDatosDetalle", Storage = "_ter_Tercero", ThisKey = "ter_IdFabricante", OtherKey = "ter_Id", IsForeignKey = true)]
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
          entity.cdd_ComercializacionDatosDetalles.Remove(this);
        }
        this._ter_Tercero.Entity = value;
        if (value != null)
        {
          value.cdd_ComercializacionDatosDetalles.Add(this);
          this._ter_IdFabricante = value.ter_Id;
        }
        else
          this._ter_IdFabricante = 0;
        this.SendPropertyChanged(nameof (ter_Tercero));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, cdd_ComercializacionDatosDetalle.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
