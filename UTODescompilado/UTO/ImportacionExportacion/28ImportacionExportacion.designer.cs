// Decompiled with JetBrains decompiler
// Type: UTO.ImportacionExportacion.ris_RegistroImportacionSustancia
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO.ImportacionExportacion
{
  [Table(Name = "Iye.ris_RegistroImportacionSustancia")]
  public class ris_RegistroImportacionSustancia : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _ris_Id;
    private int _sus_Id;
    private string _ris_Arancel;
    private Decimal? _ris_CantidadImportada;
    private int _mar_Id;
    private int _psu_Id;
    private Decimal _ris_PrecioUnitario;
    private int _pas_Id;
    private int _rim_Id;
    private int _uni_Id;
    private string _ris_Usuario;
    private DateTime _ris_Creado;
    private DateTime _ris_Modificado;
    private EntityRef<mar_Marca> _mar_Marca;
    private EntityRef<pas_Pai> _pas_Pai;
    private EntityRef<psu_PresentacionSustancia> _psu_PresentacionSustancia;
    private EntityRef<sus_Sustancia> _sus_Sustancia;
    private EntityRef<uni_Unidad> _uni_Unidad;
    private EntityRef<rim_RegistroImportacion> _rim_RegistroImportacion;

    public ris_RegistroImportacionSustancia()
    {
      this._mar_Marca = new EntityRef<mar_Marca>();
      this._pas_Pai = new EntityRef<pas_Pai>();
      this._psu_PresentacionSustancia = new EntityRef<psu_PresentacionSustancia>();
      this._sus_Sustancia = new EntityRef<sus_Sustancia>();
      this._uni_Unidad = new EntityRef<uni_Unidad>();
      this._rim_RegistroImportacion = new EntityRef<rim_RegistroImportacion>();
    }

    [Column(Storage = "_ris_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
    public int ris_Id
    {
      get => this._ris_Id;
      set
      {
        if (this._ris_Id == value)
          return;
        this.SendPropertyChanging();
        this._ris_Id = value;
        this.SendPropertyChanged(nameof (ris_Id));
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

    [Column(Storage = "_ris_Arancel", DbType = "VarChar(50)")]
    public string ris_Arancel
    {
      get => this._ris_Arancel;
      set
      {
        if (!(this._ris_Arancel != value))
          return;
        this.SendPropertyChanging();
        this._ris_Arancel = value;
        this.SendPropertyChanged(nameof (ris_Arancel));
      }
    }

    [Column(Storage = "_ris_CantidadImportada", DbType = "Decimal(10,2)")]
    public Decimal? ris_CantidadImportada
    {
      get => this._ris_CantidadImportada;
      set
      {
        Decimal? cantidadImportada = this._ris_CantidadImportada;
        Decimal? nullable = value;
        if ((cantidadImportada.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (cantidadImportada.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._ris_CantidadImportada = value;
        this.SendPropertyChanged(nameof (ris_CantidadImportada));
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

    [Column(Storage = "_ris_PrecioUnitario", DbType = "Money NOT NULL")]
    public Decimal ris_PrecioUnitario
    {
      get => this._ris_PrecioUnitario;
      set
      {
        if (!(this._ris_PrecioUnitario != value))
          return;
        this.SendPropertyChanging();
        this._ris_PrecioUnitario = value;
        this.SendPropertyChanged(nameof (ris_PrecioUnitario));
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

    [Column(Storage = "_rim_Id", DbType = "Int NOT NULL")]
    public int rim_Id
    {
      get => this._rim_Id;
      set
      {
        if (this._rim_Id == value)
          return;
        if (this._rim_RegistroImportacion.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._rim_Id = value;
        this.SendPropertyChanged(nameof (rim_Id));
      }
    }

    [Column(Storage = "_uni_Id", DbType = "Int NOT NULL")]
    public int uni_Id
    {
      get => this._uni_Id;
      set
      {
        if (this._uni_Id == value)
          return;
        if (this._uni_Unidad.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._uni_Id = value;
        this.SendPropertyChanged(nameof (uni_Id));
      }
    }

    [Column(Storage = "_ris_Usuario", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
    public string ris_Usuario
    {
      get => this._ris_Usuario;
      set
      {
        if (!(this._ris_Usuario != value))
          return;
        this.SendPropertyChanging();
        this._ris_Usuario = value;
        this.SendPropertyChanged(nameof (ris_Usuario));
      }
    }

    [Column(Storage = "_ris_Creado", DbType = "DateTime NOT NULL")]
    public DateTime ris_Creado
    {
      get => this._ris_Creado;
      set
      {
        if (!(this._ris_Creado != value))
          return;
        this.SendPropertyChanging();
        this._ris_Creado = value;
        this.SendPropertyChanged(nameof (ris_Creado));
      }
    }

    [Column(Storage = "_ris_Modificado", DbType = "DateTime NOT NULL")]
    public DateTime ris_Modificado
    {
      get => this._ris_Modificado;
      set
      {
        if (!(this._ris_Modificado != value))
          return;
        this.SendPropertyChanging();
        this._ris_Modificado = value;
        this.SendPropertyChanged(nameof (ris_Modificado));
      }
    }

    [Association(Name = "mar_Marca_ris_RegistroImportacionSustancia", Storage = "_mar_Marca", ThisKey = "mar_Id", OtherKey = "mar_Id", IsForeignKey = true)]
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
          entity.ris_RegistroImportacionSustancias.Remove(this);
        }
        this._mar_Marca.Entity = value;
        if (value != null)
        {
          value.ris_RegistroImportacionSustancias.Add(this);
          this._mar_Id = value.mar_Id;
        }
        else
          this._mar_Id = 0;
        this.SendPropertyChanged(nameof (mar_Marca));
      }
    }

    [Association(Name = "pas_Pai_ris_RegistroImportacionSustancia", Storage = "_pas_Pai", ThisKey = "pas_Id", OtherKey = "pas_Id", IsForeignKey = true)]
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
          entity.ris_RegistroImportacionSustancias.Remove(this);
        }
        this._pas_Pai.Entity = value;
        if (value != null)
        {
          value.ris_RegistroImportacionSustancias.Add(this);
          this._pas_Id = value.pas_Id;
        }
        else
          this._pas_Id = 0;
        this.SendPropertyChanged(nameof (pas_Pai));
      }
    }

    [Association(Name = "psu_PresentacionSustancia_ris_RegistroImportacionSustancia", Storage = "_psu_PresentacionSustancia", ThisKey = "psu_Id", OtherKey = "psu_Id", IsForeignKey = true)]
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
          entity.ris_RegistroImportacionSustancias.Remove(this);
        }
        this._psu_PresentacionSustancia.Entity = value;
        if (value != null)
        {
          value.ris_RegistroImportacionSustancias.Add(this);
          this._psu_Id = value.psu_Id;
        }
        else
          this._psu_Id = 0;
        this.SendPropertyChanged(nameof (psu_PresentacionSustancia));
      }
    }

    [Association(Name = "sus_Sustancia_ris_RegistroImportacionSustancia", Storage = "_sus_Sustancia", ThisKey = "sus_Id", OtherKey = "sus_Id", IsForeignKey = true)]
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
          entity.ris_RegistroImportacionSustancias.Remove(this);
        }
        this._sus_Sustancia.Entity = value;
        if (value != null)
        {
          value.ris_RegistroImportacionSustancias.Add(this);
          this._sus_Id = value.sus_Id;
        }
        else
          this._sus_Id = 0;
        this.SendPropertyChanged(nameof (sus_Sustancia));
      }
    }

    [Association(Name = "uni_Unidad_ris_RegistroImportacionSustancia", Storage = "_uni_Unidad", ThisKey = "uni_Id", OtherKey = "uni_Id", IsForeignKey = true)]
    public uni_Unidad uni_Unidad
    {
      get => this._uni_Unidad.Entity;
      set
      {
        uni_Unidad entity = this._uni_Unidad.Entity;
        if (entity == value && this._uni_Unidad.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._uni_Unidad.Entity = (uni_Unidad) null;
          entity.ris_RegistroImportacionSustancias.Remove(this);
        }
        this._uni_Unidad.Entity = value;
        if (value != null)
        {
          value.ris_RegistroImportacionSustancias.Add(this);
          this._uni_Id = value.uni_Id;
        }
        else
          this._uni_Id = 0;
        this.SendPropertyChanged(nameof (uni_Unidad));
      }
    }

    [Association(Name = "rim_RegistroImportacion_ris_RegistroImportacionSustancia", Storage = "_rim_RegistroImportacion", ThisKey = "rim_Id", OtherKey = "rim_Id", IsForeignKey = true)]
    public rim_RegistroImportacion rim_RegistroImportacion
    {
      get => this._rim_RegistroImportacion.Entity;
      set
      {
        rim_RegistroImportacion entity = this._rim_RegistroImportacion.Entity;
        if (entity == value && this._rim_RegistroImportacion.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._rim_RegistroImportacion.Entity = (rim_RegistroImportacion) null;
          entity.ris_RegistroImportacionSustancias.Remove(this);
        }
        this._rim_RegistroImportacion.Entity = value;
        if (value != null)
        {
          value.ris_RegistroImportacionSustancias.Add(this);
          this._rim_Id = value.rim_Id;
        }
        else
          this._rim_Id = 0;
        this.SendPropertyChanged(nameof (rim_RegistroImportacion));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, ris_RegistroImportacionSustancia.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
