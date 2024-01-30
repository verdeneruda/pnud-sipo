// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.cea_CentroAcopio
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
  [Table(Name = "Rrr.cea_CentroAcopio")]
  public class cea_CentroAcopio : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _cea_Id;
    private string _cea_Descripcion;
    private EntitySet<rca_ReporteCentroAcopio> _rca_ReporteCentroAcopios;

    public cea_CentroAcopio() => this._rca_ReporteCentroAcopios = new EntitySet<rca_ReporteCentroAcopio>(new Action<rca_ReporteCentroAcopio>(this.attach_rca_ReporteCentroAcopios), new Action<rca_ReporteCentroAcopio>(this.detach_rca_ReporteCentroAcopios));

    [Column(Storage = "_cea_Id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int cea_Id
    {
      get => this._cea_Id;
      set
      {
        if (this._cea_Id == value)
          return;
        this.SendPropertyChanging();
        this._cea_Id = value;
        this.SendPropertyChanged(nameof (cea_Id));
      }
    }

    [Column(Storage = "_cea_Descripcion", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string cea_Descripcion
    {
      get => this._cea_Descripcion;
      set
      {
        if (!(this._cea_Descripcion != value))
          return;
        this.SendPropertyChanging();
        this._cea_Descripcion = value;
        this.SendPropertyChanged(nameof (cea_Descripcion));
      }
    }

    [Association(Name = "cea_CentroAcopio_rca_ReporteCentroAcopio", Storage = "_rca_ReporteCentroAcopios", ThisKey = "cea_Id", OtherKey = "cea_Id")]
    public EntitySet<rca_ReporteCentroAcopio> rca_ReporteCentroAcopios
    {
      get => this._rca_ReporteCentroAcopios;
      set => this._rca_ReporteCentroAcopios.Assign((IEnumerable<rca_ReporteCentroAcopio>) value);
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, cea_CentroAcopio.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void attach_rca_ReporteCentroAcopios(rca_ReporteCentroAcopio entity)
    {
      this.SendPropertyChanging();
      entity.cea_CentroAcopio = this;
    }

    private void detach_rca_ReporteCentroAcopios(rca_ReporteCentroAcopio entity)
    {
      this.SendPropertyChanging();
      entity.cea_CentroAcopio = (cea_CentroAcopio) null;
    }
  }
}
