// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.pre_ProyectoRecuperacion
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
  [Table(Name = "Rrr.pre_ProyectoRecuperacion")]
  public class pre_ProyectoRecuperacion : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _pre_Id;
    private string _pre_Descripcion;
    private EntitySet<lco_LicitacionCompra> _lco_LicitacionCompras;
    private EntitySet<seq_SolicitudEquipo> _seq_SolicitudEquipos;

    public pre_ProyectoRecuperacion()
    {
      this._lco_LicitacionCompras = new EntitySet<lco_LicitacionCompra>(new Action<lco_LicitacionCompra>(this.attach_lco_LicitacionCompras), new Action<lco_LicitacionCompra>(this.detach_lco_LicitacionCompras));
      this._seq_SolicitudEquipos = new EntitySet<seq_SolicitudEquipo>(new Action<seq_SolicitudEquipo>(this.attach_seq_SolicitudEquipos), new Action<seq_SolicitudEquipo>(this.detach_seq_SolicitudEquipos));
    }

    [Column(Storage = "_pre_Id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int pre_Id
    {
      get => this._pre_Id;
      set
      {
        if (this._pre_Id == value)
          return;
        this.SendPropertyChanging();
        this._pre_Id = value;
        this.SendPropertyChanged(nameof (pre_Id));
      }
    }

    [Column(Storage = "_pre_Descripcion", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string pre_Descripcion
    {
      get => this._pre_Descripcion;
      set
      {
        if (!(this._pre_Descripcion != value))
          return;
        this.SendPropertyChanging();
        this._pre_Descripcion = value;
        this.SendPropertyChanged(nameof (pre_Descripcion));
      }
    }

    [Association(Name = "pre_ProyectoRecuperacion_lco_LicitacionCompra", Storage = "_lco_LicitacionCompras", ThisKey = "pre_Id", OtherKey = "pre_id")]
    public EntitySet<lco_LicitacionCompra> lco_LicitacionCompras
    {
      get => this._lco_LicitacionCompras;
      set => this._lco_LicitacionCompras.Assign((IEnumerable<lco_LicitacionCompra>) value);
    }

    [Association(Name = "pre_ProyectoRecuperacion_seq_SolicitudEquipo", Storage = "_seq_SolicitudEquipos", ThisKey = "pre_Id", OtherKey = "pre_Id")]
    public EntitySet<seq_SolicitudEquipo> seq_SolicitudEquipos
    {
      get => this._seq_SolicitudEquipos;
      set => this._seq_SolicitudEquipos.Assign((IEnumerable<seq_SolicitudEquipo>) value);
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, pre_ProyectoRecuperacion.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void attach_lco_LicitacionCompras(lco_LicitacionCompra entity)
    {
      this.SendPropertyChanging();
      entity.pre_ProyectoRecuperacion = this;
    }

    private void detach_lco_LicitacionCompras(lco_LicitacionCompra entity)
    {
      this.SendPropertyChanging();
      entity.pre_ProyectoRecuperacion = (pre_ProyectoRecuperacion) null;
    }

    private void attach_seq_SolicitudEquipos(seq_SolicitudEquipo entity)
    {
      this.SendPropertyChanging();
      entity.pre_ProyectoRecuperacion = this;
    }

    private void detach_seq_SolicitudEquipos(seq_SolicitudEquipo entity)
    {
      this.SendPropertyChanging();
      entity.pre_ProyectoRecuperacion = (pre_ProyectoRecuperacion) null;
    }
  }
}
