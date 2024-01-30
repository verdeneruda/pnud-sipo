// Decompiled with JetBrains decompiler
// Type: UTO.RegistrosUso.sus_Sustancia
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
  [Table(Name = "Uto.sus_Sustancia")]
  public class sus_Sustancia : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _sus_Id;
    private string _sus_Arancel;
    private string _sus_Descripcion;
    private EntitySet<ufe_UsuarioFinalDetalle> _ufe_UsuarioFinalDetalles;
    private EntitySet<rid_RegistroImportadorDetalle> _rid_RegistroImportadorDetalles;

    public override string ToString() => this.sus_Descripcion;

    public sus_Sustancia()
    {
      this._ufe_UsuarioFinalDetalles = new EntitySet<ufe_UsuarioFinalDetalle>(new Action<ufe_UsuarioFinalDetalle>(this.attach_ufe_UsuarioFinalDetalles), new Action<ufe_UsuarioFinalDetalle>(this.detach_ufe_UsuarioFinalDetalles));
      this._rid_RegistroImportadorDetalles = new EntitySet<rid_RegistroImportadorDetalle>(new Action<rid_RegistroImportadorDetalle>(this.attach_rid_RegistroImportadorDetalles), new Action<rid_RegistroImportadorDetalle>(this.detach_rid_RegistroImportadorDetalles));
    }

    [Column(Storage = "_sus_Id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int sus_Id
    {
      get => this._sus_Id;
      set
      {
        if (this._sus_Id == value)
          return;
        this.SendPropertyChanging();
        this._sus_Id = value;
        this.SendPropertyChanged(nameof (sus_Id));
      }
    }

    [Column(Storage = "_sus_Arancel", DbType = "VarChar(50)")]
    public string sus_Arancel
    {
      get => this._sus_Arancel;
      set
      {
        if (!(this._sus_Arancel != value))
          return;
        this.SendPropertyChanging();
        this._sus_Arancel = value;
        this.SendPropertyChanged(nameof (sus_Arancel));
      }
    }

    [Column(Storage = "_sus_Descripcion", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string sus_Descripcion
    {
      get => this._sus_Descripcion;
      set
      {
        if (!(this._sus_Descripcion != value))
          return;
        this.SendPropertyChanging();
        this._sus_Descripcion = value;
        this.SendPropertyChanged(nameof (sus_Descripcion));
      }
    }

    [Association(Name = "sus_Sustancia_ufe_UsuarioFinalDetalle", Storage = "_ufe_UsuarioFinalDetalles", ThisKey = "sus_Id", OtherKey = "sus_Id")]
    public EntitySet<ufe_UsuarioFinalDetalle> ufe_UsuarioFinalDetalles
    {
      get => this._ufe_UsuarioFinalDetalles;
      set => this._ufe_UsuarioFinalDetalles.Assign((IEnumerable<ufe_UsuarioFinalDetalle>) value);
    }

    [Association(Name = "sus_Sustancia_rid_RegistroImportadorDetalle", Storage = "_rid_RegistroImportadorDetalles", ThisKey = "sus_Id", OtherKey = "sus_Id")]
    public EntitySet<rid_RegistroImportadorDetalle> rid_RegistroImportadorDetalles
    {
      get => this._rid_RegistroImportadorDetalles;
      set => this._rid_RegistroImportadorDetalles.Assign((IEnumerable<rid_RegistroImportadorDetalle>) value);
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, sus_Sustancia.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void attach_ufe_UsuarioFinalDetalles(ufe_UsuarioFinalDetalle entity)
    {
      this.SendPropertyChanging();
      entity.sus_Sustancia = this;
    }

    private void detach_ufe_UsuarioFinalDetalles(ufe_UsuarioFinalDetalle entity)
    {
      this.SendPropertyChanging();
      entity.sus_Sustancia = (sus_Sustancia) null;
    }

    private void attach_rid_RegistroImportadorDetalles(rid_RegistroImportadorDetalle entity)
    {
      this.SendPropertyChanging();
      entity.sus_Sustancia = this;
    }

    private void detach_rid_RegistroImportadorDetalles(rid_RegistroImportadorDetalle entity)
    {
      this.SendPropertyChanging();
      entity.sus_Sustancia = (sus_Sustancia) null;
    }
  }
}
