// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.dve_DocumentoVerificar
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO.Recuperacion
{
  [Table(Name = "Rrr.dve_DocumentoVerificar")]
  public class dve_DocumentoVerificar : 
    INotifyPropertyChanging,
    INotifyPropertyChanged,
    IComparable<dve_DocumentoVerificar>
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _dve_Id;
    private string _dve_Descripcion;
    private int _dve_Estado;
    private EntitySet<dvs_DocumentoVerificarSolicitud> _dvs_DocumentoVerificarSolicituds;
    private EntitySet<dvn_DocumentoVerificarNovedad> _dvn_DocumentoVerificarNovedads;

    public dve_DocumentoVerificar()
    {
      this._dvs_DocumentoVerificarSolicituds = new EntitySet<dvs_DocumentoVerificarSolicitud>(new Action<dvs_DocumentoVerificarSolicitud>(this.attach_dvs_DocumentoVerificarSolicituds), new Action<dvs_DocumentoVerificarSolicitud>(this.detach_dvs_DocumentoVerificarSolicituds));
      this._dvn_DocumentoVerificarNovedads = new EntitySet<dvn_DocumentoVerificarNovedad>(new Action<dvn_DocumentoVerificarNovedad>(this.attach_dvn_DocumentoVerificarNovedads), new Action<dvn_DocumentoVerificarNovedad>(this.detach_dvn_DocumentoVerificarNovedads));
    }

    [Column(Storage = "_dve_Id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int dve_Id
    {
      get => this._dve_Id;
      set
      {
        if (this._dve_Id == value)
          return;
        this.SendPropertyChanging();
        this._dve_Id = value;
        this.SendPropertyChanged(nameof (dve_Id));
      }
    }

    [Column(Storage = "_dve_Descripcion", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string dve_Descripcion
    {
      get => this._dve_Descripcion;
      set
      {
        if (!(this._dve_Descripcion != value))
          return;
        this.SendPropertyChanging();
        this._dve_Descripcion = value;
        this.SendPropertyChanged(nameof (dve_Descripcion));
      }
    }

    [Column(Storage = "_dve_Estado", DbType = "Int NOT NULL")]
    public int dve_Estado
    {
      get => this._dve_Estado;
      set
      {
        if (this._dve_Estado == value)
          return;
        this.SendPropertyChanging();
        this._dve_Estado = value;
        this.SendPropertyChanged(nameof (dve_Estado));
      }
    }

    [Association(Name = "dve_DocumentoVerificar_dvs_DocumentoVerificarSolicitud", Storage = "_dvs_DocumentoVerificarSolicituds", ThisKey = "dve_Id", OtherKey = "dve_Id")]
    public EntitySet<dvs_DocumentoVerificarSolicitud> dvs_DocumentoVerificarSolicituds
    {
      get => this._dvs_DocumentoVerificarSolicituds;
      set => this._dvs_DocumentoVerificarSolicituds.Assign((IEnumerable<dvs_DocumentoVerificarSolicitud>) value);
    }

    [Association(Name = "dve_DocumentoVerificar_dvn_DocumentoVerificarNovedad", Storage = "_dvn_DocumentoVerificarNovedads", ThisKey = "dve_Id", OtherKey = "dve_Id")]
    public EntitySet<dvn_DocumentoVerificarNovedad> dvn_DocumentoVerificarNovedads
    {
      get => this._dvn_DocumentoVerificarNovedads;
      set => this._dvn_DocumentoVerificarNovedads.Assign((IEnumerable<dvn_DocumentoVerificarNovedad>) value);
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, dve_DocumentoVerificar.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void attach_dvs_DocumentoVerificarSolicituds(dvs_DocumentoVerificarSolicitud entity)
    {
      this.SendPropertyChanging();
      entity.dve_DocumentoVerificar = this;
    }

    private void detach_dvs_DocumentoVerificarSolicituds(dvs_DocumentoVerificarSolicitud entity)
    {
      this.SendPropertyChanging();
      entity.dve_DocumentoVerificar = (dve_DocumentoVerificar) null;
    }

    private void attach_dvn_DocumentoVerificarNovedads(dvn_DocumentoVerificarNovedad entity)
    {
      this.SendPropertyChanging();
      entity.dve_DocumentoVerificar = this;
    }

    private void detach_dvn_DocumentoVerificarNovedads(dvn_DocumentoVerificarNovedad entity)
    {
      this.SendPropertyChanging();
      entity.dve_DocumentoVerificar = (dve_DocumentoVerificar) null;
    }

    public int CompareTo(dve_DocumentoVerificar other) => this.dve_Descripcion.CompareTo(other.dve_Descripcion);
  }
}
