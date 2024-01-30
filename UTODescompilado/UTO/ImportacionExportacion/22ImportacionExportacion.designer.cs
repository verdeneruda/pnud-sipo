// Decompiled with JetBrains decompiler
// Type: UTO.ImportacionExportacion.meq_MarcaEquipo
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
  [Table(Name = "Uto.meq_MarcaEquipo")]
  public class meq_MarcaEquipo : 
    INotifyPropertyChanging,
    INotifyPropertyChanged,
    IComparable<meq_MarcaEquipo>
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _meq_id;
    private string _meq_Descripcion;
    private EntitySet<cim_CertificacionImportador> _cim_CertificacionImportadors;
    private EntitySet<rie_RegistroImportacionEquipo> _rie_RegistroImportacionEquipos;

    public meq_MarcaEquipo()
    {
      this._cim_CertificacionImportadors = new EntitySet<cim_CertificacionImportador>(new Action<cim_CertificacionImportador>(this.attach_cim_CertificacionImportadors), new Action<cim_CertificacionImportador>(this.detach_cim_CertificacionImportadors));
      this._rie_RegistroImportacionEquipos = new EntitySet<rie_RegistroImportacionEquipo>(new Action<rie_RegistroImportacionEquipo>(this.attach_rie_RegistroImportacionEquipos), new Action<rie_RegistroImportacionEquipo>(this.detach_rie_RegistroImportacionEquipos));
    }

    [Column(Storage = "_meq_id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int meq_id
    {
      get => this._meq_id;
      set
      {
        if (this._meq_id == value)
          return;
        this.SendPropertyChanging();
        this._meq_id = value;
        this.SendPropertyChanged(nameof (meq_id));
      }
    }

    [Column(Storage = "_meq_Descripcion", DbType = "VarChar(100) NOT NULL", CanBeNull = false)]
    public string meq_Descripcion
    {
      get => this._meq_Descripcion;
      set
      {
        if (!(this._meq_Descripcion != value))
          return;
        this.SendPropertyChanging();
        this._meq_Descripcion = value;
        this.SendPropertyChanged(nameof (meq_Descripcion));
      }
    }

    [Association(Name = "meq_MarcaEquipo_cim_CertificacionImportador", Storage = "_cim_CertificacionImportadors", ThisKey = "meq_id", OtherKey = "meq_Id")]
    public EntitySet<cim_CertificacionImportador> cim_CertificacionImportadors
    {
      get => this._cim_CertificacionImportadors;
      set => this._cim_CertificacionImportadors.Assign((IEnumerable<cim_CertificacionImportador>) value);
    }

    [Association(Name = "meq_MarcaEquipo_rie_RegistroImportacionEquipo", Storage = "_rie_RegistroImportacionEquipos", ThisKey = "meq_id", OtherKey = "meq_Id")]
    public EntitySet<rie_RegistroImportacionEquipo> rie_RegistroImportacionEquipos
    {
      get => this._rie_RegistroImportacionEquipos;
      set => this._rie_RegistroImportacionEquipos.Assign((IEnumerable<rie_RegistroImportacionEquipo>) value);
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, meq_MarcaEquipo.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void attach_cim_CertificacionImportadors(cim_CertificacionImportador entity)
    {
      this.SendPropertyChanging();
      entity.meq_MarcaEquipo = this;
    }

    private void detach_cim_CertificacionImportadors(cim_CertificacionImportador entity)
    {
      this.SendPropertyChanging();
      entity.meq_MarcaEquipo = (meq_MarcaEquipo) null;
    }

    private void attach_rie_RegistroImportacionEquipos(rie_RegistroImportacionEquipo entity)
    {
      this.SendPropertyChanging();
      entity.meq_MarcaEquipo = this;
    }

    private void detach_rie_RegistroImportacionEquipos(rie_RegistroImportacionEquipo entity)
    {
      this.SendPropertyChanging();
      entity.meq_MarcaEquipo = (meq_MarcaEquipo) null;
    }

    public int CompareTo(meq_MarcaEquipo other) => this.meq_Descripcion.CompareTo(other.meq_Descripcion);
  }
}
