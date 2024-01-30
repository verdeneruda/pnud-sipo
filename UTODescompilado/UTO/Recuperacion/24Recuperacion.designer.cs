// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.psu_PresentacionSustancia
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
  [Table(Name = "Uto.psu_PresentacionSustancia")]
  public class psu_PresentacionSustancia : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _psu_Id;
    private string _psu_Descripcion;
    private string _psu_Arancel;
    private EntitySet<rdt_ReporteUsoDetalle> _rdt_ReporteUsoDetalles;

    public psu_PresentacionSustancia() => this._rdt_ReporteUsoDetalles = new EntitySet<rdt_ReporteUsoDetalle>(new Action<rdt_ReporteUsoDetalle>(this.attach_rdt_ReporteUsoDetalles), new Action<rdt_ReporteUsoDetalle>(this.detach_rdt_ReporteUsoDetalles));

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

    [Association(Name = "psu_PresentacionSustancia_rdt_ReporteUsoDetalle", Storage = "_rdt_ReporteUsoDetalles", ThisKey = "psu_Id", OtherKey = "psu_Id")]
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
      this.PropertyChanging((object) this, psu_PresentacionSustancia.emptyChangingEventArgs);
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
      entity.psu_PresentacionSustancia = this;
    }

    private void detach_rdt_ReporteUsoDetalles(rdt_ReporteUsoDetalle entity)
    {
      this.SendPropertyChanging();
      entity.psu_PresentacionSustancia = (psu_PresentacionSustancia) null;
    }
  }
}
