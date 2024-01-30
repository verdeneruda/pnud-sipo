// Decompiled with JetBrains decompiler
// Type: UTO.ImportacionExportacion.res_RegistroExportacionSustancia
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO.ImportacionExportacion
{
  [Table(Name = "Iye.res_RegistroExportacionSustancia")]
  public class res_RegistroExportacionSustancia : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _res_Id;
    private int _sus_Id;
    private string _res_Arancel;
    private int _mar_Id;
    private int _psu_Id;
    private Decimal? _res_PrecioUnitario;
    private int? _pas_Id;
    private string _res_Usuario;
    private DateTime? _res_Creado;
    private DateTime? _res_Modificado;
    private int? _rex_Id;
    private Decimal? _res_CantidadExportada;
    private int _uni_Id;
    private EntityRef<mar_Marca> _mar_Marca;
    private EntityRef<pas_Pai> _pas_Pai;
    private EntityRef<psu_PresentacionSustancia> _psu_PresentacionSustancia;
    private EntityRef<rex_RegistroExportacion> _rex_RegistroExportacion;
    private EntityRef<sus_Sustancia> _sus_Sustancia;
    private EntityRef<uni_Unidad> _uni_Unidad;

    public res_RegistroExportacionSustancia()
    {
      this._mar_Marca = new EntityRef<mar_Marca>();
      this._pas_Pai = new EntityRef<pas_Pai>();
      this._psu_PresentacionSustancia = new EntityRef<psu_PresentacionSustancia>();
      this._rex_RegistroExportacion = new EntityRef<rex_RegistroExportacion>();
      this._sus_Sustancia = new EntityRef<sus_Sustancia>();
      this._uni_Unidad = new EntityRef<uni_Unidad>();
    }

    [Column(Storage = "_res_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
    public int res_Id
    {
      get => this._res_Id;
      set
      {
        if (this._res_Id == value)
          return;
        this.SendPropertyChanging();
        this._res_Id = value;
        this.SendPropertyChanged(nameof (res_Id));
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

    [Column(Storage = "_res_Arancel", DbType = "VarChar(50)")]
    public string res_Arancel
    {
      get => this._res_Arancel;
      set
      {
        if (!(this._res_Arancel != value))
          return;
        this.SendPropertyChanging();
        this._res_Arancel = value;
        this.SendPropertyChanged(nameof (res_Arancel));
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

    [Column(Storage = "_res_PrecioUnitario", DbType = "Money")]
    public Decimal? res_PrecioUnitario
    {
      get => this._res_PrecioUnitario;
      set
      {
        Decimal? resPrecioUnitario = this._res_PrecioUnitario;
        Decimal? nullable = value;
        if ((resPrecioUnitario.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (resPrecioUnitario.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._res_PrecioUnitario = value;
        this.SendPropertyChanged(nameof (res_PrecioUnitario));
      }
    }

    [Column(Storage = "_pas_Id", DbType = "Int")]
    public int? pas_Id
    {
      get => this._pas_Id;
      set
      {
        int? pasId = this._pas_Id;
        int? nullable = value;
        if ((pasId.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (pasId.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        if (this._pas_Pai.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._pas_Id = value;
        this.SendPropertyChanged(nameof (pas_Id));
      }
    }

    [Column(Storage = "_res_Usuario", DbType = "VarChar(50)")]
    public string res_Usuario
    {
      get => this._res_Usuario;
      set
      {
        if (!(this._res_Usuario != value))
          return;
        this.SendPropertyChanging();
        this._res_Usuario = value;
        this.SendPropertyChanged(nameof (res_Usuario));
      }
    }

    [Column(Storage = "_res_Creado", DbType = "DateTime")]
    public DateTime? res_Creado
    {
      get => this._res_Creado;
      set
      {
        DateTime? resCreado = this._res_Creado;
        DateTime? nullable = value;
        if ((resCreado.HasValue != nullable.HasValue ? 1 : (!resCreado.HasValue ? 0 : (resCreado.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._res_Creado = value;
        this.SendPropertyChanged(nameof (res_Creado));
      }
    }

    [Column(Storage = "_res_Modificado", DbType = "DateTime")]
    public DateTime? res_Modificado
    {
      get => this._res_Modificado;
      set
      {
        DateTime? resModificado = this._res_Modificado;
        DateTime? nullable = value;
        if ((resModificado.HasValue != nullable.HasValue ? 1 : (!resModificado.HasValue ? 0 : (resModificado.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._res_Modificado = value;
        this.SendPropertyChanged(nameof (res_Modificado));
      }
    }

    [Column(Storage = "_rex_Id", DbType = "Int")]
    public int? rex_Id
    {
      get => this._rex_Id;
      set
      {
        int? rexId = this._rex_Id;
        int? nullable = value;
        if ((rexId.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (rexId.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        if (this._rex_RegistroExportacion.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._rex_Id = value;
        this.SendPropertyChanged(nameof (rex_Id));
      }
    }

    [Column(Storage = "_res_CantidadExportada", DbType = "Decimal(10,2)")]
    public Decimal? res_CantidadExportada
    {
      get => this._res_CantidadExportada;
      set
      {
        Decimal? cantidadExportada = this._res_CantidadExportada;
        Decimal? nullable = value;
        if ((cantidadExportada.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (cantidadExportada.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._res_CantidadExportada = value;
        this.SendPropertyChanged(nameof (res_CantidadExportada));
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

    [Association(Name = "mar_Marca_res_RegistroExportacionSustancia", Storage = "_mar_Marca", ThisKey = "mar_Id", OtherKey = "mar_Id", IsForeignKey = true)]
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
          entity.res_RegistroExportacionSustancias.Remove(this);
        }
        this._mar_Marca.Entity = value;
        if (value != null)
        {
          value.res_RegistroExportacionSustancias.Add(this);
          this._mar_Id = value.mar_Id;
        }
        else
          this._mar_Id = 0;
        this.SendPropertyChanged(nameof (mar_Marca));
      }
    }

    [Association(Name = "pas_Pai_res_RegistroExportacionSustancia", Storage = "_pas_Pai", ThisKey = "pas_Id", OtherKey = "pas_Id", IsForeignKey = true)]
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
          entity.res_RegistroExportacionSustancias.Remove(this);
        }
        this._pas_Pai.Entity = value;
        if (value != null)
        {
          value.res_RegistroExportacionSustancias.Add(this);
          this._pas_Id = new int?(value.pas_Id);
        }
        else
          this._pas_Id = new int?();
        this.SendPropertyChanged(nameof (pas_Pai));
      }
    }

    [Association(Name = "psu_PresentacionSustancia_res_RegistroExportacionSustancia", Storage = "_psu_PresentacionSustancia", ThisKey = "psu_Id", OtherKey = "psu_Id", IsForeignKey = true)]
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
          entity.res_RegistroExportacionSustancias.Remove(this);
        }
        this._psu_PresentacionSustancia.Entity = value;
        if (value != null)
        {
          value.res_RegistroExportacionSustancias.Add(this);
          this._psu_Id = value.psu_Id;
        }
        else
          this._psu_Id = 0;
        this.SendPropertyChanged(nameof (psu_PresentacionSustancia));
      }
    }

    [Association(Name = "rex_RegistroExportacion_res_RegistroExportacionSustancia", Storage = "_rex_RegistroExportacion", ThisKey = "rex_Id", OtherKey = "rex_Id", IsForeignKey = true)]
    public rex_RegistroExportacion rex_RegistroExportacion
    {
      get => this._rex_RegistroExportacion.Entity;
      set
      {
        rex_RegistroExportacion entity = this._rex_RegistroExportacion.Entity;
        if (entity == value && this._rex_RegistroExportacion.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._rex_RegistroExportacion.Entity = (rex_RegistroExportacion) null;
          entity.res_RegistroExportacionSustancias.Remove(this);
        }
        this._rex_RegistroExportacion.Entity = value;
        if (value != null)
        {
          value.res_RegistroExportacionSustancias.Add(this);
          this._rex_Id = new int?(value.rex_Id);
        }
        else
          this._rex_Id = new int?();
        this.SendPropertyChanged(nameof (rex_RegistroExportacion));
      }
    }

    [Association(Name = "sus_Sustancia_res_RegistroExportacionSustancia", Storage = "_sus_Sustancia", ThisKey = "sus_Id", OtherKey = "sus_Id", IsForeignKey = true)]
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
          entity.res_RegistroExportacionSustancias.Remove(this);
        }
        this._sus_Sustancia.Entity = value;
        if (value != null)
        {
          value.res_RegistroExportacionSustancias.Add(this);
          this._sus_Id = value.sus_Id;
        }
        else
          this._sus_Id = 0;
        this.SendPropertyChanged(nameof (sus_Sustancia));
      }
    }

    [Association(Name = "uni_Unidad_res_RegistroExportacionSustancia", Storage = "_uni_Unidad", ThisKey = "uni_Id", OtherKey = "uni_Id", IsForeignKey = true)]
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
          entity.res_RegistroExportacionSustancias.Remove(this);
        }
        this._uni_Unidad.Entity = value;
        if (value != null)
        {
          value.res_RegistroExportacionSustancias.Add(this);
          this._uni_Id = value.uni_Id;
        }
        else
          this._uni_Id = 0;
        this.SendPropertyChanged(nameof (uni_Unidad));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, res_RegistroExportacionSustancia.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
