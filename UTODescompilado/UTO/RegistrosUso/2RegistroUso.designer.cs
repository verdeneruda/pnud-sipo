// Decompiled with JetBrains decompiler
// Type: UTO.RegistrosUso.sec_Sector
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO.RegistrosUso
{
  [Table(Name = "Rus.sec_Sector")]
  public class sec_Sector : INotifyPropertyChanging, INotifyPropertyChanged, IComparable<sec_Sector>
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _sec_Id;
    private string _sec_Descripcion;
    private EntitySet<ufd_UsuarioFinalDato> _ufd_UsuarioFinalDatos;

    public sec_Sector() => this._ufd_UsuarioFinalDatos = new EntitySet<ufd_UsuarioFinalDato>(new Action<ufd_UsuarioFinalDato>(this.attach_ufd_UsuarioFinalDatos), new Action<ufd_UsuarioFinalDato>(this.detach_ufd_UsuarioFinalDatos));

    [Column(Storage = "_sec_Id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int sec_Id
    {
      get => this._sec_Id;
      set
      {
        if (this._sec_Id == value)
          return;
        this.SendPropertyChanging();
        this._sec_Id = value;
        this.SendPropertyChanged(nameof (sec_Id));
      }
    }

    [Column(Storage = "_sec_Descripcion", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string sec_Descripcion
    {
      get => this._sec_Descripcion;
      set
      {
        if (!(this._sec_Descripcion != value))
          return;
        this.SendPropertyChanging();
        this._sec_Descripcion = value;
        this.SendPropertyChanged(nameof (sec_Descripcion));
      }
    }

    [Association(Name = "sec_Sector_ufd_UsuarioFinalDato", Storage = "_ufd_UsuarioFinalDatos", ThisKey = "sec_Id", OtherKey = "sec_Id")]
    public EntitySet<ufd_UsuarioFinalDato> ufd_UsuarioFinalDatos
    {
      get => this._ufd_UsuarioFinalDatos;
      set => this._ufd_UsuarioFinalDatos.Assign((IEnumerable<ufd_UsuarioFinalDato>) value);
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, sec_Sector.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void attach_ufd_UsuarioFinalDatos(ufd_UsuarioFinalDato entity)
    {
      this.SendPropertyChanging();
      entity.sec_Sector = this;
    }

    private void detach_ufd_UsuarioFinalDatos(ufd_UsuarioFinalDato entity)
    {
      this.SendPropertyChanging();
      entity.sec_Sector = (sec_Sector) null;
    }

    public int CompareTo(sec_Sector other) => this.sec_Descripcion.CompareTo(other.sec_Descripcion);
  }
}
