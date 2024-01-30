// Decompiled with JetBrains decompiler
// Type: UTO.ImportacionExportacion.sus_Sustancia
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO.ImportacionExportacion
{
  [Table(Name = "Uto.sus_Sustancia")]
  public class sus_Sustancia : 
    INotifyPropertyChanging,
    INotifyPropertyChanged,
    IComparable<sus_Sustancia>
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _sus_Id;
    private string _sus_Arancel;
    private string _sus_Descripcion;
    private EntitySet<dim_DeclaracionImportacion> _dim_DeclaracionImportacions;
    private EntitySet<dex_DeclaracionExportacion> _dex_DeclaracionExportacions;
    private EntitySet<lmd_LicenciaMedioAmbientalDetalle> _lmd_LicenciaMedioAmbientalDetalles;
    private EntitySet<ris_RegistroImportacionSustancia> _ris_RegistroImportacionSustancias;
    private EntitySet<res_RegistroExportacionSustancia> _res_RegistroExportacionSustancias;

    public sus_Sustancia()
    {
      this._dim_DeclaracionImportacions = new EntitySet<dim_DeclaracionImportacion>(new Action<dim_DeclaracionImportacion>(this.attach_dim_DeclaracionImportacions), new Action<dim_DeclaracionImportacion>(this.detach_dim_DeclaracionImportacions));
      this._dex_DeclaracionExportacions = new EntitySet<dex_DeclaracionExportacion>(new Action<dex_DeclaracionExportacion>(this.attach_dex_DeclaracionExportacions), new Action<dex_DeclaracionExportacion>(this.detach_dex_DeclaracionExportacions));
      this._lmd_LicenciaMedioAmbientalDetalles = new EntitySet<lmd_LicenciaMedioAmbientalDetalle>(new Action<lmd_LicenciaMedioAmbientalDetalle>(this.attach_lmd_LicenciaMedioAmbientalDetalles), new Action<lmd_LicenciaMedioAmbientalDetalle>(this.detach_lmd_LicenciaMedioAmbientalDetalles));
      this._ris_RegistroImportacionSustancias = new EntitySet<ris_RegistroImportacionSustancia>(new Action<ris_RegistroImportacionSustancia>(this.attach_ris_RegistroImportacionSustancias), new Action<ris_RegistroImportacionSustancia>(this.detach_ris_RegistroImportacionSustancias));
      this._res_RegistroExportacionSustancias = new EntitySet<res_RegistroExportacionSustancia>(new Action<res_RegistroExportacionSustancia>(this.attach_res_RegistroExportacionSustancias), new Action<res_RegistroExportacionSustancia>(this.detach_res_RegistroExportacionSustancias));
    }

    [Column(Storage = "_sus_Id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int sus_Id
    {
      get => this._sus_Id;
      set
      {
        if (this._sus_Id == value)
          return;
        this.SendPropertyChanging();
        this._sus_Id = value;
        this.SendPropertyChanged(nameof (sus_Id));
      }
    }

    [Column(Storage = "_sus_Arancel", DbType = "VarChar(50)")]
    public string sus_Arancel
    {
      get => this._sus_Arancel;
      set
      {
        if (!(this._sus_Arancel != value))
          return;
        this.SendPropertyChanging();
        this._sus_Arancel = value;
        this.SendPropertyChanged(nameof (sus_Arancel));
      }
    }

    [Column(Storage = "_sus_Descripcion", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string sus_Descripcion
    {
      get => this._sus_Descripcion;
      set
      {
        if (!(this._sus_Descripcion != value))
          return;
        this.SendPropertyChanging();
        this._sus_Descripcion = value;
        this.SendPropertyChanged(nameof (sus_Descripcion));
      }
    }

    [Association(Name = "sus_Sustancia_dim_DeclaracionImportacion", Storage = "_dim_DeclaracionImportacions", ThisKey = "sus_Id", OtherKey = "sus_Id")]
    public EntitySet<dim_DeclaracionImportacion> dim_DeclaracionImportacions
    {
      get => this._dim_DeclaracionImportacions;
      set => this._dim_DeclaracionImportacions.Assign((IEnumerable<dim_DeclaracionImportacion>) value);
    }

    [Association(Name = "sus_Sustancia_dex_DeclaracionExportacion", Storage = "_dex_DeclaracionExportacions", ThisKey = "sus_Id", OtherKey = "sus_Id")]
    public EntitySet<dex_DeclaracionExportacion> dex_DeclaracionExportacions
    {
      get => this._dex_DeclaracionExportacions;
      set => this._dex_DeclaracionExportacions.Assign((IEnumerable<dex_DeclaracionExportacion>) value);
    }

    [Association(Name = "sus_Sustancia_lmd_LicenciaMedioAmbientalDetalle", Storage = "_lmd_LicenciaMedioAmbientalDetalles", ThisKey = "sus_Id", OtherKey = "sus_Id")]
    public EntitySet<lmd_LicenciaMedioAmbientalDetalle> lmd_LicenciaMedioAmbientalDetalles
    {
      get => this._lmd_LicenciaMedioAmbientalDetalles;
      set => this._lmd_LicenciaMedioAmbientalDetalles.Assign((IEnumerable<lmd_LicenciaMedioAmbientalDetalle>) value);
    }

    [Association(Name = "sus_Sustancia_ris_RegistroImportacionSustancia", Storage = "_ris_RegistroImportacionSustancias", ThisKey = "sus_Id", OtherKey = "sus_Id")]
    public EntitySet<ris_RegistroImportacionSustancia> ris_RegistroImportacionSustancias
    {
      get => this._ris_RegistroImportacionSustancias;
      set => this._ris_RegistroImportacionSustancias.Assign((IEnumerable<ris_RegistroImportacionSustancia>) value);
    }

    [Association(Name = "sus_Sustancia_res_RegistroExportacionSustancia", Storage = "_res_RegistroExportacionSustancias", ThisKey = "sus_Id", OtherKey = "sus_Id")]
    public EntitySet<res_RegistroExportacionSustancia> res_RegistroExportacionSustancias
    {
      get => this._res_RegistroExportacionSustancias;
      set => this._res_RegistroExportacionSustancias.Assign((IEnumerable<res_RegistroExportacionSustancia>) value);
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, sus_Sustancia.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void attach_dim_DeclaracionImportacions(dim_DeclaracionImportacion entity)
    {
      this.SendPropertyChanging();
      entity.sus_Sustancia = this;
    }

    private void detach_dim_DeclaracionImportacions(dim_DeclaracionImportacion entity)
    {
      this.SendPropertyChanging();
      entity.sus_Sustancia = (sus_Sustancia) null;
    }

    private void attach_dex_DeclaracionExportacions(dex_DeclaracionExportacion entity)
    {
      this.SendPropertyChanging();
      entity.sus_Sustancia = this;
    }

    private void detach_dex_DeclaracionExportacions(dex_DeclaracionExportacion entity)
    {
      this.SendPropertyChanging();
      entity.sus_Sustancia = (sus_Sustancia) null;
    }

    private void attach_lmd_LicenciaMedioAmbientalDetalles(lmd_LicenciaMedioAmbientalDetalle entity)
    {
      this.SendPropertyChanging();
      entity.sus_Sustancia = this;
    }

    private void detach_lmd_LicenciaMedioAmbientalDetalles(lmd_LicenciaMedioAmbientalDetalle entity)
    {
      this.SendPropertyChanging();
      entity.sus_Sustancia = (sus_Sustancia) null;
    }

    private void attach_ris_RegistroImportacionSustancias(ris_RegistroImportacionSustancia entity)
    {
      this.SendPropertyChanging();
      entity.sus_Sustancia = this;
    }

    private void detach_ris_RegistroImportacionSustancias(ris_RegistroImportacionSustancia entity)
    {
      this.SendPropertyChanging();
      entity.sus_Sustancia = (sus_Sustancia) null;
    }

    private void attach_res_RegistroExportacionSustancias(res_RegistroExportacionSustancia entity)
    {
      this.SendPropertyChanging();
      entity.sus_Sustancia = this;
    }

    private void detach_res_RegistroExportacionSustancias(res_RegistroExportacionSustancia entity)
    {
      this.SendPropertyChanging();
      entity.sus_Sustancia = (sus_Sustancia) null;
    }

    public int CompareTo(sus_Sustancia other) => this.sus_Descripcion.CompareTo(other.sus_Descripcion);
  }
}
