// Decompiled with JetBrains decompiler
// Type: UTO.ImportacionExportacion.psu_PresentacionSustancia
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
  [Table(Name = "Uto.psu_PresentacionSustancia")]
  public class psu_PresentacionSustancia : 
    INotifyPropertyChanging,
    INotifyPropertyChanged,
    IComparable<psu_PresentacionSustancia>
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _psu_Id;
    private string _psu_Descripcion;
    private string _psu_Arancel;
    private EntitySet<ris_RegistroImportacionSustancia> _ris_RegistroImportacionSustancias;
    private EntitySet<res_RegistroExportacionSustancia> _res_RegistroExportacionSustancias;

    public psu_PresentacionSustancia()
    {
      this._ris_RegistroImportacionSustancias = new EntitySet<ris_RegistroImportacionSustancia>(new Action<ris_RegistroImportacionSustancia>(this.attach_ris_RegistroImportacionSustancias), new Action<ris_RegistroImportacionSustancia>(this.detach_ris_RegistroImportacionSustancias));
      this._res_RegistroExportacionSustancias = new EntitySet<res_RegistroExportacionSustancia>(new Action<res_RegistroExportacionSustancia>(this.attach_res_RegistroExportacionSustancias), new Action<res_RegistroExportacionSustancia>(this.detach_res_RegistroExportacionSustancias));
    }

    [Column(Storage = "_psu_Id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int psu_Id
    {
      get => this._psu_Id;
      set
      {
        if (this._psu_Id == value)
          return;
        this.SendPropertyChanging();
        this._psu_Id = value;
        this.SendPropertyChanged(nameof (psu_Id));
      }
    }

    [Column(Storage = "_psu_Descripcion", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string psu_Descripcion
    {
      get => this._psu_Descripcion;
      set
      {
        if (!(this._psu_Descripcion != value))
          return;
        this.SendPropertyChanging();
        this._psu_Descripcion = value;
        this.SendPropertyChanged(nameof (psu_Descripcion));
      }
    }

    [Column(Storage = "_psu_Arancel", DbType = "VarChar(50)")]
    public string psu_Arancel
    {
      get => this._psu_Arancel;
      set
      {
        if (!(this._psu_Arancel != value))
          return;
        this.SendPropertyChanging();
        this._psu_Arancel = value;
        this.SendPropertyChanged(nameof (psu_Arancel));
      }
    }

    [Association(Name = "psu_PresentacionSustancia_ris_RegistroImportacionSustancia", Storage = "_ris_RegistroImportacionSustancias", ThisKey = "psu_Id", OtherKey = "psu_Id")]
    public EntitySet<ris_RegistroImportacionSustancia> ris_RegistroImportacionSustancias
    {
      get => this._ris_RegistroImportacionSustancias;
      set => this._ris_RegistroImportacionSustancias.Assign((IEnumerable<ris_RegistroImportacionSustancia>) value);
    }

    [Association(Name = "psu_PresentacionSustancia_res_RegistroExportacionSustancia", Storage = "_res_RegistroExportacionSustancias", ThisKey = "psu_Id", OtherKey = "psu_Id")]
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
      this.PropertyChanging((object) this, psu_PresentacionSustancia.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void attach_ris_RegistroImportacionSustancias(ris_RegistroImportacionSustancia entity)
    {
      this.SendPropertyChanging();
      entity.psu_PresentacionSustancia = this;
    }

    private void detach_ris_RegistroImportacionSustancias(ris_RegistroImportacionSustancia entity)
    {
      this.SendPropertyChanging();
      entity.psu_PresentacionSustancia = (psu_PresentacionSustancia) null;
    }

    private void attach_res_RegistroExportacionSustancias(res_RegistroExportacionSustancia entity)
    {
      this.SendPropertyChanging();
      entity.psu_PresentacionSustancia = this;
    }

    private void detach_res_RegistroExportacionSustancias(res_RegistroExportacionSustancia entity)
    {
      this.SendPropertyChanging();
      entity.psu_PresentacionSustancia = (psu_PresentacionSustancia) null;
    }

    public int CompareTo(psu_PresentacionSustancia other) => this.psu_Descripcion.CompareTo(other.psu_Descripcion);
  }
}
