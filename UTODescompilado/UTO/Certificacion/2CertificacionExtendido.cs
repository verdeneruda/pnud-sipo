// Decompiled with JetBrains decompiler
// Type: UTO.Certificacion.atr_AreaTrabajo
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO.Certificacion
{
  [Table(Name = "Cer.atr_AreaTrabajo")]
  public class atr_AreaTrabajo : 
    IComparable<atr_AreaTrabajo>,
    INotifyPropertyChanging,
    INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _atr_Id;
    private string _atr_Des;
    private EntitySet<tec_Tecnico> _tec_Tecnicos;

    public int CompareTo(atr_AreaTrabajo other) => this.atr_Des.CompareTo(other.atr_Des);

    public atr_AreaTrabajo() => this._tec_Tecnicos = new EntitySet<tec_Tecnico>(new Action<tec_Tecnico>(this.attach_tec_Tecnicos), new Action<tec_Tecnico>(this.detach_tec_Tecnicos));

    [Column(Storage = "_atr_Id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int atr_Id
    {
      get => this._atr_Id;
      set
      {
        if (this._atr_Id == value)
          return;
        this.SendPropertyChanging();
        this._atr_Id = value;
        this.SendPropertyChanged(nameof (atr_Id));
      }
    }

    [Column(Storage = "_atr_Des", DbType = "VarChar(70) NOT NULL", CanBeNull = false)]
    public string atr_Des
    {
      get => this._atr_Des;
      set
      {
        if (!(this._atr_Des != value))
          return;
        this.SendPropertyChanging();
        this._atr_Des = value;
        this.SendPropertyChanged(nameof (atr_Des));
      }
    }

    [Association(Name = "atr_AreaTrabajo_tec_Tecnico", Storage = "_tec_Tecnicos", ThisKey = "atr_Id", OtherKey = "atr_Id")]
    public EntitySet<tec_Tecnico> tec_Tecnicos
    {
      get => this._tec_Tecnicos;
      set => this._tec_Tecnicos.Assign((IEnumerable<tec_Tecnico>) value);
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, atr_AreaTrabajo.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void attach_tec_Tecnicos(tec_Tecnico entity)
    {
      this.SendPropertyChanging();
      entity.atr_AreaTrabajo = this;
    }

    private void detach_tec_Tecnicos(tec_Tecnico entity)
    {
      this.SendPropertyChanging();
      entity.atr_AreaTrabajo = (atr_AreaTrabajo) null;
    }
  }
}
