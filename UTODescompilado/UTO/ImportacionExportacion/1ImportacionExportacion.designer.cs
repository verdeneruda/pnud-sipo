// Decompiled with JetBrains decompiler
// Type: UTO.ImportacionExportacion.cvb_ConceptoVistoBueno
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
  [Table(Name = "Iye.cvb_ConceptoVistoBueno")]
  public class cvb_ConceptoVistoBueno : 
    INotifyPropertyChanging,
    INotifyPropertyChanged,
    IComparable<cvb_ConceptoVistoBueno>
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _cvb_Id;
    private string _cvb_Descripcion;
    private EntitySet<rex_RegistroExportacion> _rex_RegistroExportacions;
    private EntitySet<rim_RegistroImportacion> _rim_RegistroImportacions;

    public cvb_ConceptoVistoBueno()
    {
      this._rex_RegistroExportacions = new EntitySet<rex_RegistroExportacion>(new Action<rex_RegistroExportacion>(this.attach_rex_RegistroExportacions), new Action<rex_RegistroExportacion>(this.detach_rex_RegistroExportacions));
      this._rim_RegistroImportacions = new EntitySet<rim_RegistroImportacion>(new Action<rim_RegistroImportacion>(this.attach_rim_RegistroImportacions), new Action<rim_RegistroImportacion>(this.detach_rim_RegistroImportacions));
    }

    [Column(Storage = "_cvb_Id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int cvb_Id
    {
      get => this._cvb_Id;
      set
      {
        if (this._cvb_Id == value)
          return;
        this.SendPropertyChanging();
        this._cvb_Id = value;
        this.SendPropertyChanged(nameof (cvb_Id));
      }
    }

    [Column(Storage = "_cvb_Descripcion", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string cvb_Descripcion
    {
      get => this._cvb_Descripcion;
      set
      {
        if (!(this._cvb_Descripcion != value))
          return;
        this.SendPropertyChanging();
        this._cvb_Descripcion = value;
        this.SendPropertyChanged(nameof (cvb_Descripcion));
      }
    }

    [Association(Name = "cvb_ConceptoVistoBueno_rex_RegistroExportacion", Storage = "_rex_RegistroExportacions", ThisKey = "cvb_Id", OtherKey = "cvb_Id")]
    public EntitySet<rex_RegistroExportacion> rex_RegistroExportacions
    {
      get => this._rex_RegistroExportacions;
      set => this._rex_RegistroExportacions.Assign((IEnumerable<rex_RegistroExportacion>) value);
    }

    [Association(Name = "cvb_ConceptoVistoBueno_rim_RegistroImportacion", Storage = "_rim_RegistroImportacions", ThisKey = "cvb_Id", OtherKey = "cvb_Id")]
    public EntitySet<rim_RegistroImportacion> rim_RegistroImportacions
    {
      get => this._rim_RegistroImportacions;
      set => this._rim_RegistroImportacions.Assign((IEnumerable<rim_RegistroImportacion>) value);
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, cvb_ConceptoVistoBueno.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void attach_rex_RegistroExportacions(rex_RegistroExportacion entity)
    {
      this.SendPropertyChanging();
      entity.cvb_ConceptoVistoBueno = this;
    }

    private void detach_rex_RegistroExportacions(rex_RegistroExportacion entity)
    {
      this.SendPropertyChanging();
      entity.cvb_ConceptoVistoBueno = (cvb_ConceptoVistoBueno) null;
    }

    private void attach_rim_RegistroImportacions(rim_RegistroImportacion entity)
    {
      this.SendPropertyChanging();
      entity.cvb_ConceptoVistoBueno = this;
    }

    private void detach_rim_RegistroImportacions(rim_RegistroImportacion entity)
    {
      this.SendPropertyChanging();
      entity.cvb_ConceptoVistoBueno = (cvb_ConceptoVistoBueno) null;
    }

    public int CompareTo(cvb_ConceptoVistoBueno other) => this.cvb_Descripcion.CompareTo(other.cvb_Descripcion);
  }
}
