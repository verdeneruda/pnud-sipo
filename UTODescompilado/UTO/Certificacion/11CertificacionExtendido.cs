// Decompiled with JetBrains decompiler
// Type: UTO.Certificacion.acm_ActividadMaterial
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
  [Table(Name = "Cer.acm_ActividadMaterial")]
  public class acm_ActividadMaterial : 
    IComparable<acm_ActividadMaterial>,
    INotifyPropertyChanging,
    INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _acm_Id;
    private string _acm_Descripcion;
    private EntitySet<ame_ActividadmaterialEntregado> _ame_ActividadmaterialEntregados;

    public int CompareTo(acm_ActividadMaterial other) => this.acm_Descripcion.CompareTo(other.acm_Descripcion);

    public acm_ActividadMaterial() => this._ame_ActividadmaterialEntregados = new EntitySet<ame_ActividadmaterialEntregado>(new Action<ame_ActividadmaterialEntregado>(this.attach_ame_ActividadmaterialEntregados), new Action<ame_ActividadmaterialEntregado>(this.detach_ame_ActividadmaterialEntregados));

    [Column(Storage = "_acm_Id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int acm_Id
    {
      get => this._acm_Id;
      set
      {
        if (this._acm_Id == value)
          return;
        this.SendPropertyChanging();
        this._acm_Id = value;
        this.SendPropertyChanged(nameof (acm_Id));
      }
    }

    [Column(Storage = "_acm_Descripcion", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string acm_Descripcion
    {
      get => this._acm_Descripcion;
      set
      {
        if (!(this._acm_Descripcion != value))
          return;
        this.SendPropertyChanging();
        this._acm_Descripcion = value;
        this.SendPropertyChanged(nameof (acm_Descripcion));
      }
    }

    [Association(Name = "acm_ActividadMaterial_ame_ActividadmaterialEntregado", Storage = "_ame_ActividadmaterialEntregados", ThisKey = "acm_Id", OtherKey = "acm_Id")]
    public EntitySet<ame_ActividadmaterialEntregado> ame_ActividadmaterialEntregados
    {
      get => this._ame_ActividadmaterialEntregados;
      set => this._ame_ActividadmaterialEntregados.Assign((IEnumerable<ame_ActividadmaterialEntregado>) value);
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, acm_ActividadMaterial.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void attach_ame_ActividadmaterialEntregados(ame_ActividadmaterialEntregado entity)
    {
      this.SendPropertyChanging();
      entity.acm_ActividadMaterial = this;
    }

    private void detach_ame_ActividadmaterialEntregados(ame_ActividadmaterialEntregado entity)
    {
      this.SendPropertyChanging();
      entity.acm_ActividadMaterial = (acm_ActividadMaterial) null;
    }
  }
}
