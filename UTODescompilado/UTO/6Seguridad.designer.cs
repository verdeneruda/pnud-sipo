// Decompiled with JetBrains decompiler
// Type: UTO.mod_Modulo
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO
{
  [Table(Name = "dbo.mod_Modulo")]
  public class mod_Modulo : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _mod_id;
    private string _mod_nombre;
    private EntitySet<ope_Operacion> _ope_Operacions;

    public mod_Modulo() => this._ope_Operacions = new EntitySet<ope_Operacion>(new Action<ope_Operacion>(this.attach_ope_Operacions), new Action<ope_Operacion>(this.detach_ope_Operacions));

    [Column(Storage = "_mod_id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int mod_id
    {
      get => this._mod_id;
      set
      {
        if (this._mod_id == value)
          return;
        this.SendPropertyChanging();
        this._mod_id = value;
        this.SendPropertyChanged(nameof (mod_id));
      }
    }

    [Column(Storage = "_mod_nombre", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
    public string mod_nombre
    {
      get => this._mod_nombre;
      set
      {
        if (!(this._mod_nombre != value))
          return;
        this.SendPropertyChanging();
        this._mod_nombre = value;
        this.SendPropertyChanged(nameof (mod_nombre));
      }
    }

    [Association(Name = "mod_Modulo_ope_Operacion", Storage = "_ope_Operacions", ThisKey = "mod_id", OtherKey = "mod_id")]
    public EntitySet<ope_Operacion> ope_Operacions
    {
      get => this._ope_Operacions;
      set => this._ope_Operacions.Assign((IEnumerable<ope_Operacion>) value);
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, mod_Modulo.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void attach_ope_Operacions(ope_Operacion entity)
    {
      this.SendPropertyChanging();
      entity.mod_Modulo = this;
    }

    private void detach_ope_Operacions(ope_Operacion entity)
    {
      this.SendPropertyChanging();
      entity.mod_Modulo = (mod_Modulo) null;
    }
  }
}
