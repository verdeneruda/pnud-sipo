// Decompiled with JetBrains decompiler
// Type: UTO.ImportacionExportacion.mar_Marca
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
  [Table(Name = "Uto.mar_Marca")]
  public class mar_Marca : INotifyPropertyChanging, INotifyPropertyChanged, IComparable<mar_Marca>
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _mar_Id;
    private string _mar_Descripcion;
    private EntitySet<ris_RegistroImportacionSustancia> _ris_RegistroImportacionSustancias;
    private EntitySet<res_RegistroExportacionSustancia> _res_RegistroExportacionSustancias;

    public mar_Marca()
    {
      this._ris_RegistroImportacionSustancias = new EntitySet<ris_RegistroImportacionSustancia>(new Action<ris_RegistroImportacionSustancia>(this.attach_ris_RegistroImportacionSustancias), new Action<ris_RegistroImportacionSustancia>(this.detach_ris_RegistroImportacionSustancias));
      this._res_RegistroExportacionSustancias = new EntitySet<res_RegistroExportacionSustancia>(new Action<res_RegistroExportacionSustancia>(this.attach_res_RegistroExportacionSustancias), new Action<res_RegistroExportacionSustancia>(this.detach_res_RegistroExportacionSustancias));
    }

    [Column(Storage = "_mar_Id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int mar_Id
    {
      get => this._mar_Id;
      set
      {
        if (this._mar_Id == value)
          return;
        this.SendPropertyChanging();
        this._mar_Id = value;
        this.SendPropertyChanged(nameof (mar_Id));
      }
    }

    [Column(Storage = "_mar_Descripcion", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string mar_Descripcion
    {
      get => this._mar_Descripcion;
      set
      {
        if (!(this._mar_Descripcion != value))
          return;
        this.SendPropertyChanging();
        this._mar_Descripcion = value;
        this.SendPropertyChanged(nameof (mar_Descripcion));
      }
    }

    [Association(Name = "mar_Marca_ris_RegistroImportacionSustancia", Storage = "_ris_RegistroImportacionSustancias", ThisKey = "mar_Id", OtherKey = "mar_Id")]
    public EntitySet<ris_RegistroImportacionSustancia> ris_RegistroImportacionSustancias
    {
      get => this._ris_RegistroImportacionSustancias;
      set => this._ris_RegistroImportacionSustancias.Assign((IEnumerable<ris_RegistroImportacionSustancia>) value);
    }

    [Association(Name = "mar_Marca_res_RegistroExportacionSustancia", Storage = "_res_RegistroExportacionSustancias", ThisKey = "mar_Id", OtherKey = "mar_Id")]
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
      this.PropertyChanging((object) this, mar_Marca.emptyChangingEventArgs);
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
      entity.mar_Marca = this;
    }

    private void detach_ris_RegistroImportacionSustancias(ris_RegistroImportacionSustancia entity)
    {
      this.SendPropertyChanging();
      entity.mar_Marca = (mar_Marca) null;
    }

    private void attach_res_RegistroExportacionSustancias(res_RegistroExportacionSustancia entity)
    {
      this.SendPropertyChanging();
      entity.mar_Marca = this;
    }

    private void detach_res_RegistroExportacionSustancias(res_RegistroExportacionSustancia entity)
    {
      this.SendPropertyChanging();
      entity.mar_Marca = (mar_Marca) null;
    }

    public int CompareTo(mar_Marca other) => this.mar_Descripcion.CompareTo(other.mar_Descripcion);
  }
}
