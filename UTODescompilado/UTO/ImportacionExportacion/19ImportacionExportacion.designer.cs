// Decompiled with JetBrains decompiler
// Type: UTO.ImportacionExportacion.lmd_LicenciaMedioAmbientalDetalle
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO.ImportacionExportacion
{
  [Table(Name = "Iye.lmd_LicenciaMedioAmbientalDetalle")]
  public class lmd_LicenciaMedioAmbientalDetalle : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _lmd_Id;
    private int _lma_Id;
    private int _ter_IdProveedor;
    private int _pas_Id;
    private int? _sus_Id;
    private EntityRef<pas_Pai> _pas_Pai;
    private EntityRef<sus_Sustancia> _sus_Sustancia;
    private EntityRef<lma_LicenciaMedioAmbiental> _lma_LicenciaMedioAmbiental;
    private EntityRef<ter_Tercero> _ter_Tercero;

    public lmd_LicenciaMedioAmbientalDetalle()
    {
      this._pas_Pai = new EntityRef<pas_Pai>();
      this._sus_Sustancia = new EntityRef<sus_Sustancia>();
      this._lma_LicenciaMedioAmbiental = new EntityRef<lma_LicenciaMedioAmbiental>();
      this._ter_Tercero = new EntityRef<ter_Tercero>();
    }

    [Column(Storage = "_lmd_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
    public int lmd_Id
    {
      get => this._lmd_Id;
      set
      {
        if (this._lmd_Id == value)
          return;
        this.SendPropertyChanging();
        this._lmd_Id = value;
        this.SendPropertyChanged(nameof (lmd_Id));
      }
    }

    [Column(Storage = "_lma_Id", DbType = "Int NOT NULL")]
    public int lma_Id
    {
      get => this._lma_Id;
      set
      {
        if (this._lma_Id == value)
          return;
        if (this._lma_LicenciaMedioAmbiental.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._lma_Id = value;
        this.SendPropertyChanged(nameof (lma_Id));
      }
    }

    [Column(Storage = "_ter_IdProveedor", DbType = "Int NOT NULL")]
    public int ter_IdProveedor
    {
      get => this._ter_IdProveedor;
      set
      {
        if (this._ter_IdProveedor == value)
          return;
        if (this._ter_Tercero.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._ter_IdProveedor = value;
        this.SendPropertyChanged(nameof (ter_IdProveedor));
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

    [Column(Storage = "_sus_Id", DbType = "Int")]
    public int? sus_Id
    {
      get => this._sus_Id;
      set
      {
        int? susId = this._sus_Id;
        int? nullable = value;
        if ((susId.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (susId.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        if (this._sus_Sustancia.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._sus_Id = value;
        this.SendPropertyChanged(nameof (sus_Id));
      }
    }

    [Association(Name = "pas_Pai_lmd_LicenciaMedioAmbientalDetalle", Storage = "_pas_Pai", ThisKey = "pas_Id", OtherKey = "pas_Id", IsForeignKey = true)]
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
          entity.lmd_LicenciaMedioAmbientalDetalles.Remove(this);
        }
        this._pas_Pai.Entity = value;
        if (value != null)
        {
          value.lmd_LicenciaMedioAmbientalDetalles.Add(this);
          this._pas_Id = value.pas_Id;
        }
        else
          this._pas_Id = 0;
        this.SendPropertyChanged(nameof (pas_Pai));
      }
    }

    [Association(Name = "sus_Sustancia_lmd_LicenciaMedioAmbientalDetalle", Storage = "_sus_Sustancia", ThisKey = "sus_Id", OtherKey = "sus_Id", IsForeignKey = true)]
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
          entity.lmd_LicenciaMedioAmbientalDetalles.Remove(this);
        }
        this._sus_Sustancia.Entity = value;
        if (value != null)
        {
          value.lmd_LicenciaMedioAmbientalDetalles.Add(this);
          this._sus_Id = new int?(value.sus_Id);
        }
        else
          this._sus_Id = new int?();
        this.SendPropertyChanged(nameof (sus_Sustancia));
      }
    }

    [Association(Name = "lma_LicenciaMedioAmbiental_lmd_LicenciaMedioAmbientalDetalle", Storage = "_lma_LicenciaMedioAmbiental", ThisKey = "lma_Id", OtherKey = "lma_Id", IsForeignKey = true)]
    public lma_LicenciaMedioAmbiental lma_LicenciaMedioAmbiental
    {
      get => this._lma_LicenciaMedioAmbiental.Entity;
      set
      {
        lma_LicenciaMedioAmbiental entity = this._lma_LicenciaMedioAmbiental.Entity;
        if (entity == value && this._lma_LicenciaMedioAmbiental.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._lma_LicenciaMedioAmbiental.Entity = (lma_LicenciaMedioAmbiental) null;
          entity.lmd_LicenciaMedioAmbientalDetalles.Remove(this);
        }
        this._lma_LicenciaMedioAmbiental.Entity = value;
        if (value != null)
        {
          value.lmd_LicenciaMedioAmbientalDetalles.Add(this);
          this._lma_Id = value.lma_Id;
        }
        else
          this._lma_Id = 0;
        this.SendPropertyChanged(nameof (lma_LicenciaMedioAmbiental));
      }
    }

    [Association(Name = "ter_Tercero_lmd_LicenciaMedioAmbientalDetalle", Storage = "_ter_Tercero", ThisKey = "ter_IdProveedor", OtherKey = "ter_Id", IsForeignKey = true)]
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
          entity.lmd_LicenciaMedioAmbientalDetalles.Remove(this);
        }
        this._ter_Tercero.Entity = value;
        if (value != null)
        {
          value.lmd_LicenciaMedioAmbientalDetalles.Add(this);
          this._ter_IdProveedor = value.ter_Id;
        }
        else
          this._ter_IdProveedor = 0;
        this.SendPropertyChanged(nameof (ter_Tercero));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, lmd_LicenciaMedioAmbientalDetalle.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
