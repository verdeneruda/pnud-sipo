// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.tim_TipoMantenimiento
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
  [Table(Name = "Rrr.tim_TipoMantenimiento")]
  public class tim_TipoMantenimiento : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _tim_Id;
    private string _tim_Descripcion;
    private int _tim_Tipo;
    private EntitySet<rdb_ReporteUsoBarrido> _rdb_ReporteUsoBarridos;
    private EntitySet<rdb_ReporteUsoBarrido> _rdb_ReporteUsoBarridos1;
    private EntitySet<rdb_ReporteUsoBarrido> _rdb_ReporteUsoBarridos2;

    public tim_TipoMantenimiento()
    {
      this._rdb_ReporteUsoBarridos = new EntitySet<rdb_ReporteUsoBarrido>(new Action<rdb_ReporteUsoBarrido>(this.attach_rdb_ReporteUsoBarridos), new Action<rdb_ReporteUsoBarrido>(this.detach_rdb_ReporteUsoBarridos));
      this._rdb_ReporteUsoBarridos1 = new EntitySet<rdb_ReporteUsoBarrido>(new Action<rdb_ReporteUsoBarrido>(this.attach_rdb_ReporteUsoBarridos1), new Action<rdb_ReporteUsoBarrido>(this.detach_rdb_ReporteUsoBarridos1));
      this._rdb_ReporteUsoBarridos2 = new EntitySet<rdb_ReporteUsoBarrido>(new Action<rdb_ReporteUsoBarrido>(this.attach_rdb_ReporteUsoBarridos2), new Action<rdb_ReporteUsoBarrido>(this.detach_rdb_ReporteUsoBarridos2));
    }

    [Column(Storage = "_tim_Id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int tim_Id
    {
      get => this._tim_Id;
      set
      {
        if (this._tim_Id == value)
          return;
        this.SendPropertyChanging();
        this._tim_Id = value;
        this.SendPropertyChanged(nameof (tim_Id));
      }
    }

    [Column(Storage = "_tim_Descripcion", DbType = "VarChar(250) NOT NULL", CanBeNull = false)]
    public string tim_Descripcion
    {
      get => this._tim_Descripcion;
      set
      {
        if (!(this._tim_Descripcion != value))
          return;
        this.SendPropertyChanging();
        this._tim_Descripcion = value;
        this.SendPropertyChanged(nameof (tim_Descripcion));
      }
    }

    [Column(Storage = "_tim_Tipo", DbType = "Int NOT NULL")]
    public int tim_Tipo
    {
      get => this._tim_Tipo;
      set
      {
        if (this._tim_Tipo == value)
          return;
        this.SendPropertyChanging();
        this._tim_Tipo = value;
        this.SendPropertyChanged(nameof (tim_Tipo));
      }
    }

    [Association(Name = "tim_TipoMantenimiento_rdb_ReporteUsoBarrido", Storage = "_rdb_ReporteUsoBarridos", ThisKey = "tim_Id", OtherKey = "tim_IdAcidez")]
    public EntitySet<rdb_ReporteUsoBarrido> rdb_ReporteUsoBarridos
    {
      get => this._rdb_ReporteUsoBarridos;
      set => this._rdb_ReporteUsoBarridos.Assign((IEnumerable<rdb_ReporteUsoBarrido>) value);
    }

    [Association(Name = "tim_TipoMantenimiento_rdb_ReporteUsoBarrido1", Storage = "_rdb_ReporteUsoBarridos1", ThisKey = "tim_Id", OtherKey = "tim_IdFiltro")]
    public EntitySet<rdb_ReporteUsoBarrido> rdb_ReporteUsoBarridos1
    {
      get => this._rdb_ReporteUsoBarridos1;
      set => this._rdb_ReporteUsoBarridos1.Assign((IEnumerable<rdb_ReporteUsoBarrido>) value);
    }

    [Association(Name = "tim_TipoMantenimiento_rdb_ReporteUsoBarrido2", Storage = "_rdb_ReporteUsoBarridos2", ThisKey = "tim_Id", OtherKey = "tim_IdNitrogeno")]
    public EntitySet<rdb_ReporteUsoBarrido> rdb_ReporteUsoBarridos2
    {
      get => this._rdb_ReporteUsoBarridos2;
      set => this._rdb_ReporteUsoBarridos2.Assign((IEnumerable<rdb_ReporteUsoBarrido>) value);
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, tim_TipoMantenimiento.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void attach_rdb_ReporteUsoBarridos(rdb_ReporteUsoBarrido entity)
    {
      this.SendPropertyChanging();
      entity.tim_TipoMantenimiento = this;
    }

    private void detach_rdb_ReporteUsoBarridos(rdb_ReporteUsoBarrido entity)
    {
      this.SendPropertyChanging();
      entity.tim_TipoMantenimiento = (tim_TipoMantenimiento) null;
    }

    private void attach_rdb_ReporteUsoBarridos1(rdb_ReporteUsoBarrido entity)
    {
      this.SendPropertyChanging();
      entity.tim_TipoMantenimiento1 = this;
    }

    private void detach_rdb_ReporteUsoBarridos1(rdb_ReporteUsoBarrido entity)
    {
      this.SendPropertyChanging();
      entity.tim_TipoMantenimiento1 = (tim_TipoMantenimiento) null;
    }

    private void attach_rdb_ReporteUsoBarridos2(rdb_ReporteUsoBarrido entity)
    {
      this.SendPropertyChanging();
      entity.tim_TipoMantenimiento2 = this;
    }

    private void detach_rdb_ReporteUsoBarridos2(rdb_ReporteUsoBarrido entity)
    {
      this.SendPropertyChanging();
      entity.tim_TipoMantenimiento2 = (tim_TipoMantenimiento) null;
    }
  }
}
