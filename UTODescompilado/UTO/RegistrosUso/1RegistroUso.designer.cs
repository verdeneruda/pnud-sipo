// Decompiled with JetBrains decompiler
// Type: UTO.RegistrosUso.rri_RegistroReporteImportador
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
  [Table(Name = "Rus.rri_RegistroReporteImportador")]
  public class rri_RegistroReporteImportador : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _rri_Id;
    private int _ter_Id;
    private int _rri_Ano;
    private string _rri_Usuario;
    private DateTime _rri_Creado;
    private DateTime _rri_Modificado;
    private EntitySet<rid_RegistroImportadorDetalle> _rid_RegistroImportadorDetalles;
    private EntityRef<ter_Tercero> _ter_Tercero;

    public rri_RegistroReporteImportador()
    {
      this._rid_RegistroImportadorDetalles = new EntitySet<rid_RegistroImportadorDetalle>(new Action<rid_RegistroImportadorDetalle>(this.attach_rid_RegistroImportadorDetalles), new Action<rid_RegistroImportadorDetalle>(this.detach_rid_RegistroImportadorDetalles));
      this._ter_Tercero = new EntityRef<ter_Tercero>();
    }

    [Column(Storage = "_rri_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
    public int rri_Id
    {
      get => this._rri_Id;
      set
      {
        if (this._rri_Id == value)
          return;
        this.SendPropertyChanging();
        this._rri_Id = value;
        this.SendPropertyChanged(nameof (rri_Id));
      }
    }

    [Column(Storage = "_ter_Id", DbType = "Int NOT NULL")]
    public int ter_Id
    {
      get => this._ter_Id;
      set
      {
        if (this._ter_Id == value)
          return;
        if (this._ter_Tercero.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._ter_Id = value;
        this.SendPropertyChanged(nameof (ter_Id));
      }
    }

    [Column(Storage = "_rri_Ano", DbType = "Int NOT NULL")]
    public int rri_Ano
    {
      get => this._rri_Ano;
      set
      {
        if (this._rri_Ano == value)
          return;
        this.SendPropertyChanging();
        this._rri_Ano = value;
        this.SendPropertyChanged(nameof (rri_Ano));
      }
    }

    [Column(Storage = "_rri_Usuario", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
    public string rri_Usuario
    {
      get => this._rri_Usuario;
      set
      {
        if (!(this._rri_Usuario != value))
          return;
        this.SendPropertyChanging();
        this._rri_Usuario = value;
        this.SendPropertyChanged(nameof (rri_Usuario));
      }
    }

    [Column(Storage = "_rri_Creado", DbType = "DateTime NOT NULL")]
    public DateTime rri_Creado
    {
      get => this._rri_Creado;
      set
      {
        if (!(this._rri_Creado != value))
          return;
        this.SendPropertyChanging();
        this._rri_Creado = value;
        this.SendPropertyChanged(nameof (rri_Creado));
      }
    }

    [Column(Storage = "_rri_Modificado", DbType = "DateTime NOT NULL")]
    public DateTime rri_Modificado
    {
      get => this._rri_Modificado;
      set
      {
        if (!(this._rri_Modificado != value))
          return;
        this.SendPropertyChanging();
        this._rri_Modificado = value;
        this.SendPropertyChanged(nameof (rri_Modificado));
      }
    }

    [Association(Name = "rri_RegistroReporteImportador_rid_RegistroImportadorDetalle", Storage = "_rid_RegistroImportadorDetalles", ThisKey = "rri_Id", OtherKey = "rri_Id")]
    public EntitySet<rid_RegistroImportadorDetalle> rid_RegistroImportadorDetalles
    {
      get => this._rid_RegistroImportadorDetalles;
      set => this._rid_RegistroImportadorDetalles.Assign((IEnumerable<rid_RegistroImportadorDetalle>) value);
    }

    [Association(Name = "ter_Tercero_rri_RegistroReporteImportador", Storage = "_ter_Tercero", ThisKey = "ter_Id", OtherKey = "ter_Id", IsForeignKey = true)]
    public ter_Tercero ter_Tercero
    {
      get => this._ter_Tercero.Entity;
      set
      {
        ter_Tercero entity = this._ter_Tercero.Entity;
        if (entity == value && this._ter_Tercero.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._ter_Tercero.Entity = (ter_Tercero) null;
          entity.rri_RegistroReporteImportadors.Remove(this);
        }
        this._ter_Tercero.Entity = value;
        if (value != null)
        {
          value.rri_RegistroReporteImportadors.Add(this);
          this._ter_Id = value.ter_Id;
        }
        else
          this._ter_Id = 0;
        this.SendPropertyChanged(nameof (ter_Tercero));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, rri_RegistroReporteImportador.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void attach_rid_RegistroImportadorDetalles(rid_RegistroImportadorDetalle entity)
    {
      this.SendPropertyChanging();
      entity.rri_RegistroReporteImportador = this;
    }

    private void detach_rid_RegistroImportadorDetalles(rid_RegistroImportadorDetalle entity)
    {
      this.SendPropertyChanging();
      entity.rri_RegistroReporteImportador = (rri_RegistroReporteImportador) null;
    }
  }
}
