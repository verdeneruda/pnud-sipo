// Decompiled with JetBrains decompiler
// Type: UTO.ImportacionExportacion.uni_Unidad
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
  [Table(Name = "Uto.uni_Unidad")]
  public class uni_Unidad : INotifyPropertyChanging, INotifyPropertyChanged, IComparable<uni_Unidad>
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _uni_Id;
    private string _uni_Descripcion;
    private string _uni_Sigla;
    private EntitySet<ris_RegistroImportacionSustancia> _ris_RegistroImportacionSustancias;
    private EntitySet<res_RegistroExportacionSustancia> _res_RegistroExportacionSustancias;

    public uni_Unidad()
    {
      this._ris_RegistroImportacionSustancias = new EntitySet<ris_RegistroImportacionSustancia>(new Action<ris_RegistroImportacionSustancia>(this.attach_ris_RegistroImportacionSustancias), new Action<ris_RegistroImportacionSustancia>(this.detach_ris_RegistroImportacionSustancias));
      this._res_RegistroExportacionSustancias = new EntitySet<res_RegistroExportacionSustancia>(new Action<res_RegistroExportacionSustancia>(this.attach_res_RegistroExportacionSustancias), new Action<res_RegistroExportacionSustancia>(this.detach_res_RegistroExportacionSustancias));
    }

    [Column(Storage = "_uni_Id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int uni_Id
    {
      get => this._uni_Id;
      set
      {
        if (this._uni_Id == value)
          return;
        this.SendPropertyChanging();
        this._uni_Id = value;
        this.SendPropertyChanged(nameof (uni_Id));
      }
    }

    [Column(Storage = "_uni_Descripcion", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
    public string uni_Descripcion
    {
      get => this._uni_Descripcion;
      set
      {
        if (!(this._uni_Descripcion != value))
          return;
        this.SendPropertyChanging();
        this._uni_Descripcion = value;
        this.SendPropertyChanged(nameof (uni_Descripcion));
      }
    }

    [Column(Storage = "_uni_Sigla", DbType = "VarChar(10) NOT NULL", CanBeNull = false)]
    public string uni_Sigla
    {
      get => this._uni_Sigla;
      set
      {
        if (!(this._uni_Sigla != value))
          return;
        this.SendPropertyChanging();
        this._uni_Sigla = value;
        this.SendPropertyChanged(nameof (uni_Sigla));
      }
    }

    [Association(Name = "uni_Unidad_ris_RegistroImportacionSustancia", Storage = "_ris_RegistroImportacionSustancias", ThisKey = "uni_Id", OtherKey = "uni_Id")]
    public EntitySet<ris_RegistroImportacionSustancia> ris_RegistroImportacionSustancias
    {
      get => this._ris_RegistroImportacionSustancias;
      set => this._ris_RegistroImportacionSustancias.Assign((IEnumerable<ris_RegistroImportacionSustancia>) value);
    }

    [Association(Name = "uni_Unidad_res_RegistroExportacionSustancia", Storage = "_res_RegistroExportacionSustancias", ThisKey = "uni_Id", OtherKey = "uni_Id")]
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
      this.PropertyChanging((object) this, uni_Unidad.emptyChangingEventArgs);
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
      entity.uni_Unidad = this;
    }

    private void detach_ris_RegistroImportacionSustancias(ris_RegistroImportacionSustancia entity)
    {
      this.SendPropertyChanging();
      entity.uni_Unidad = (uni_Unidad) null;
    }

    private void attach_res_RegistroExportacionSustancias(res_RegistroExportacionSustancia entity)
    {
      this.SendPropertyChanging();
      entity.uni_Unidad = this;
    }

    private void detach_res_RegistroExportacionSustancias(res_RegistroExportacionSustancia entity)
    {
      this.SendPropertyChanging();
      entity.uni_Unidad = (uni_Unidad) null;
    }

    public int CompareTo(uni_Unidad other) => this.uni_Descripcion.CompareTo(other.uni_Descripcion);
  }
}
