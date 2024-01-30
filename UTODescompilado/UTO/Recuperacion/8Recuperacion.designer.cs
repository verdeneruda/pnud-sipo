// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.ses_SolicitudEstado
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
  [Table(Name = "Rrr.ses_SolicitudEstado")]
  public class ses_SolicitudEstado : 
    INotifyPropertyChanging,
    INotifyPropertyChanged,
    IComparable<ses_SolicitudEstado>
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _ses_Id;
    private string _ses_Descripcion;
    private EntitySet<seq_SolicitudEquipo> _seq_SolicitudEquipos;

    public ses_SolicitudEstado() => this._seq_SolicitudEquipos = new EntitySet<seq_SolicitudEquipo>(new Action<seq_SolicitudEquipo>(this.attach_seq_SolicitudEquipos), new Action<seq_SolicitudEquipo>(this.detach_seq_SolicitudEquipos));

    [Column(Storage = "_ses_Id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int ses_Id
    {
      get => this._ses_Id;
      set
      {
        if (this._ses_Id == value)
          return;
        this.SendPropertyChanging();
        this._ses_Id = value;
        this.SendPropertyChanged(nameof (ses_Id));
      }
    }

    [Column(Storage = "_ses_Descripcion", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string ses_Descripcion
    {
      get => this._ses_Descripcion;
      set
      {
        if (!(this._ses_Descripcion != value))
          return;
        this.SendPropertyChanging();
        this._ses_Descripcion = value;
        this.SendPropertyChanged(nameof (ses_Descripcion));
      }
    }

    [Association(Name = "ses_SolicitudEstado_seq_SolicitudEquipo", Storage = "_seq_SolicitudEquipos", ThisKey = "ses_Id", OtherKey = "ses_Id")]
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
      this.PropertyChanging((object) this, ses_SolicitudEstado.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void attach_seq_SolicitudEquipos(seq_SolicitudEquipo entity)
    {
      this.SendPropertyChanging();
      entity.ses_SolicitudEstado = this;
    }

    private void detach_seq_SolicitudEquipos(seq_SolicitudEquipo entity)
    {
      this.SendPropertyChanging();
      entity.ses_SolicitudEstado = (ses_SolicitudEstado) null;
    }

    public int CompareTo(ses_SolicitudEstado other) => this.ses_Descripcion.CompareTo(other.ses_Descripcion);
  }
}
