// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.gus_GasUso
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
  [Table(Name = "Rrr.gus_GasUso")]
  public class gus_GasUso : INotifyPropertyChanging, INotifyPropertyChanged, IComparable<gus_GasUso>
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _gus_Id;
    private string _gus_Descripcion;
    private EntitySet<rdt_ReporteUsoDetalle> _rdt_ReporteUsoDetalles;

    public gus_GasUso() => this._rdt_ReporteUsoDetalles = new EntitySet<rdt_ReporteUsoDetalle>(new Action<rdt_ReporteUsoDetalle>(this.attach_rdt_ReporteUsoDetalles), new Action<rdt_ReporteUsoDetalle>(this.detach_rdt_ReporteUsoDetalles));

    [Column(Storage = "_gus_Id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int gus_Id
    {
      get => this._gus_Id;
      set
      {
        if (this._gus_Id == value)
          return;
        this.SendPropertyChanging();
        this._gus_Id = value;
        this.SendPropertyChanged(nameof (gus_Id));
      }
    }

    [Column(Storage = "_gus_Descripcion", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string gus_Descripcion
    {
      get => this._gus_Descripcion;
      set
      {
        if (!(this._gus_Descripcion != value))
          return;
        this.SendPropertyChanging();
        this._gus_Descripcion = value;
        this.SendPropertyChanged(nameof (gus_Descripcion));
      }
    }

    [Association(Name = "gus_GasUso_rdt_ReporteUsoDetalle", Storage = "_rdt_ReporteUsoDetalles", ThisKey = "gus_Id", OtherKey = "gus_Id")]
    public EntitySet<rdt_ReporteUsoDetalle> rdt_ReporteUsoDetalles
    {
      get => this._rdt_ReporteUsoDetalles;
      set => this._rdt_ReporteUsoDetalles.Assign((IEnumerable<rdt_ReporteUsoDetalle>) value);
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, gus_GasUso.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void attach_rdt_ReporteUsoDetalles(rdt_ReporteUsoDetalle entity)
    {
      this.SendPropertyChanging();
      entity.gus_GasUso = this;
    }

    private void detach_rdt_ReporteUsoDetalles(rdt_ReporteUsoDetalle entity)
    {
      this.SendPropertyChanging();
      entity.gus_GasUso = (gus_GasUso) null;
    }

    public int CompareTo(gus_GasUso other) => this.gus_Descripcion.CompareTo(other.gus_Descripcion);
  }
}
