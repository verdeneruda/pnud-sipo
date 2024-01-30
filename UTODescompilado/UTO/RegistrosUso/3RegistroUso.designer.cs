// Decompiled with JetBrains decompiler
// Type: UTO.RegistrosUso.utf_UsuarioTipoFinal
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
  [Table(Name = "Rus.utf_UsuarioTipoFinal")]
  public class utf_UsuarioTipoFinal : 
    INotifyPropertyChanging,
    INotifyPropertyChanged,
    IComparable<utf_UsuarioTipoFinal>
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _utf_Id;
    private string _utf_Descripcion;
    private EntitySet<ufd_UsuarioFinalDato> _ufd_UsuarioFinalDatos;

    public utf_UsuarioTipoFinal() => this._ufd_UsuarioFinalDatos = new EntitySet<ufd_UsuarioFinalDato>(new Action<ufd_UsuarioFinalDato>(this.attach_ufd_UsuarioFinalDatos), new Action<ufd_UsuarioFinalDato>(this.detach_ufd_UsuarioFinalDatos));

    [Column(Storage = "_utf_Id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int utf_Id
    {
      get => this._utf_Id;
      set
      {
        if (this._utf_Id == value)
          return;
        this.SendPropertyChanging();
        this._utf_Id = value;
        this.SendPropertyChanged(nameof (utf_Id));
      }
    }

    [Column(Storage = "_utf_Descripcion", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string utf_Descripcion
    {
      get => this._utf_Descripcion;
      set
      {
        if (!(this._utf_Descripcion != value))
          return;
        this.SendPropertyChanging();
        this._utf_Descripcion = value;
        this.SendPropertyChanged(nameof (utf_Descripcion));
      }
    }

    [Association(Name = "utf_UsuarioTipoFinal_ufd_UsuarioFinalDato", Storage = "_ufd_UsuarioFinalDatos", ThisKey = "utf_Id", OtherKey = "utf_Id")]
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
      this.PropertyChanging((object) this, utf_UsuarioTipoFinal.emptyChangingEventArgs);
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
      entity.utf_UsuarioTipoFinal = this;
    }

    private void detach_ufd_UsuarioFinalDatos(ufd_UsuarioFinalDato entity)
    {
      this.SendPropertyChanging();
      entity.utf_UsuarioTipoFinal = (utf_UsuarioTipoFinal) null;
    }

    public int CompareTo(utf_UsuarioTipoFinal other) => this.utf_Descripcion.CompareTo(other.utf_Descripcion);
  }
}
