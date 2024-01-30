// Decompiled with JetBrains decompiler
// Type: UTO.Certificacion.tec_Tecnico
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
  [Table(Name = "Cer.tec_Tecnico")]
  public class tec_Tecnico : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _tec_Id;
    private int _ter_Id;
    private int _atr_Id;
    private int _ter_IdEmpresa;
    private string _seq_Usuario;
    private DateTime _seq_Creado;
    private DateTime _seq_Modificado;
    private EntitySet<ted_TecnicoDetalle> _ted_TecnicoDetalles;
    private EntityRef<atr_AreaTrabajo> _atr_AreaTrabajo;
    private EntityRef<ter_Tercero> _ter_Tercero;
    private EntityRef<ter_Tercero> _ter_Tercero1;

    public tec_Tecnico()
    {
      this._ted_TecnicoDetalles = new EntitySet<ted_TecnicoDetalle>(new Action<ted_TecnicoDetalle>(this.attach_ted_TecnicoDetalles), new Action<ted_TecnicoDetalle>(this.detach_ted_TecnicoDetalles));
      this._atr_AreaTrabajo = new EntityRef<atr_AreaTrabajo>();
      this._ter_Tercero = new EntityRef<ter_Tercero>();
      this._ter_Tercero1 = new EntityRef<ter_Tercero>();
    }

    [Column(Storage = "_tec_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
    public int tec_Id
    {
      get => this._tec_Id;
      set
      {
        if (this._tec_Id == value)
          return;
        this.SendPropertyChanging();
        this._tec_Id = value;
        this.SendPropertyChanged(nameof (tec_Id));
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

    [Column(Storage = "_atr_Id", DbType = "Int NOT NULL")]
    public int atr_Id
    {
      get => this._atr_Id;
      set
      {
        if (this._atr_Id == value)
          return;
        if (this._atr_AreaTrabajo.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._atr_Id = value;
        this.SendPropertyChanged(nameof (atr_Id));
      }
    }

    [Column(Storage = "_ter_IdEmpresa", DbType = "Int NOT NULL")]
    public int ter_IdEmpresa
    {
      get => this._ter_IdEmpresa;
      set
      {
        if (this._ter_IdEmpresa == value)
          return;
        if (this._ter_Tercero1.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._ter_IdEmpresa = value;
        this.SendPropertyChanged(nameof (ter_IdEmpresa));
      }
    }

    [Column(Storage = "_seq_Usuario", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
    public string seq_Usuario
    {
      get => this._seq_Usuario;
      set
      {
        if (!(this._seq_Usuario != value))
          return;
        this.SendPropertyChanging();
        this._seq_Usuario = value;
        this.SendPropertyChanged(nameof (seq_Usuario));
      }
    }

    [Column(Storage = "_seq_Creado", DbType = "DateTime NOT NULL")]
    public DateTime seq_Creado
    {
      get => this._seq_Creado;
      set
      {
        if (!(this._seq_Creado != value))
          return;
        this.SendPropertyChanging();
        this._seq_Creado = value;
        this.SendPropertyChanged(nameof (seq_Creado));
      }
    }

    [Column(Storage = "_seq_Modificado", DbType = "DateTime NOT NULL")]
    public DateTime seq_Modificado
    {
      get => this._seq_Modificado;
      set
      {
        if (!(this._seq_Modificado != value))
          return;
        this.SendPropertyChanging();
        this._seq_Modificado = value;
        this.SendPropertyChanged(nameof (seq_Modificado));
      }
    }

    [Association(Name = "tec_Tecnico_ted_TecnicoDetalle", Storage = "_ted_TecnicoDetalles", ThisKey = "tec_Id", OtherKey = "tec_Id")]
    public EntitySet<ted_TecnicoDetalle> ted_TecnicoDetalles
    {
      get => this._ted_TecnicoDetalles;
      set => this._ted_TecnicoDetalles.Assign((IEnumerable<ted_TecnicoDetalle>) value);
    }

    [Association(Name = "atr_AreaTrabajo_tec_Tecnico", Storage = "_atr_AreaTrabajo", ThisKey = "atr_Id", OtherKey = "atr_Id", IsForeignKey = true)]
    public atr_AreaTrabajo atr_AreaTrabajo
    {
      get => this._atr_AreaTrabajo.Entity;
      set
      {
        atr_AreaTrabajo entity = this._atr_AreaTrabajo.Entity;
        if (entity == value && this._atr_AreaTrabajo.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._atr_AreaTrabajo.Entity = (atr_AreaTrabajo) null;
          entity.tec_Tecnicos.Remove(this);
        }
        this._atr_AreaTrabajo.Entity = value;
        if (value != null)
        {
          value.tec_Tecnicos.Add(this);
          this._atr_Id = value.atr_Id;
        }
        else
          this._atr_Id = 0;
        this.SendPropertyChanged(nameof (atr_AreaTrabajo));
      }
    }

    [Association(Name = "ter_Tercero_tec_Tecnico", Storage = "_ter_Tercero", ThisKey = "ter_Id", OtherKey = "ter_Id", IsForeignKey = true)]
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
          entity.tec_Tecnicos.Remove(this);
        }
        this._ter_Tercero.Entity = value;
        if (value != null)
        {
          value.tec_Tecnicos.Add(this);
          this._ter_Id = value.ter_Id;
        }
        else
          this._ter_Id = 0;
        this.SendPropertyChanged(nameof (ter_Tercero));
      }
    }

    [Association(Name = "ter_Tercero_tec_Tecnico1", Storage = "_ter_Tercero1", ThisKey = "ter_IdEmpresa", OtherKey = "ter_Id", IsForeignKey = true)]
    public ter_Tercero ter_Tercero1
    {
      get => this._ter_Tercero1.Entity;
      set
      {
        ter_Tercero entity = this._ter_Tercero1.Entity;
        if (entity == value && this._ter_Tercero1.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._ter_Tercero1.Entity = (ter_Tercero) null;
          entity.tec_Tecnicos1.Remove(this);
        }
        this._ter_Tercero1.Entity = value;
        if (value != null)
        {
          value.tec_Tecnicos1.Add(this);
          this._ter_IdEmpresa = value.ter_Id;
        }
        else
          this._ter_IdEmpresa = 0;
        this.SendPropertyChanged(nameof (ter_Tercero1));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, tec_Tecnico.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void attach_ted_TecnicoDetalles(ted_TecnicoDetalle entity)
    {
      this.SendPropertyChanging();
      entity.tec_Tecnico = this;
    }

    private void detach_ted_TecnicoDetalles(ted_TecnicoDetalle entity)
    {
      this.SendPropertyChanging();
      entity.tec_Tecnico = (tec_Tecnico) null;
    }
  }
}
