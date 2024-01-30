// Decompiled with JetBrains decompiler
// Type: UTO.Certificacion.act_Actividad
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
  [Table(Name = "Cer.act_Actividad")]
  public class act_Actividad : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _act_Id;
    private DateTime _act_Fecha;
    private string _act_Actividad1;
    private string _act_EntidadesIvolucradas;
    private int _act_PersonasImpactadas;
    private string _mun_Id;
    private int _ati_Id;
    private string _seq_Usuario;
    private DateTime _seq_Creado;
    private DateTime _seq_Modificado;
    private EntitySet<ame_ActividadmaterialEntregado> _ame_ActividadmaterialEntregados;
    private EntityRef<ati_ActividadTipo> _ati_ActividadTipo;
    private EntityRef<mun_Municipio> _mun_Municipio;

    public act_Actividad()
    {
      this._ame_ActividadmaterialEntregados = new EntitySet<ame_ActividadmaterialEntregado>(new Action<ame_ActividadmaterialEntregado>(this.attach_ame_ActividadmaterialEntregados), new Action<ame_ActividadmaterialEntregado>(this.detach_ame_ActividadmaterialEntregados));
      this._ati_ActividadTipo = new EntityRef<ati_ActividadTipo>();
      this._mun_Municipio = new EntityRef<mun_Municipio>();
    }

    [Column(Storage = "_act_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
    public int act_Id
    {
      get => this._act_Id;
      set
      {
        if (this._act_Id == value)
          return;
        this.SendPropertyChanging();
        this._act_Id = value;
        this.SendPropertyChanged(nameof (act_Id));
      }
    }

    [Column(Storage = "_act_Fecha", DbType = "DateTime NOT NULL")]
    public DateTime act_Fecha
    {
      get => this._act_Fecha;
      set
      {
        if (!(this._act_Fecha != value))
          return;
        this.SendPropertyChanging();
        this._act_Fecha = value;
        this.SendPropertyChanged(nameof (act_Fecha));
      }
    }

    [Column(Name = "act_Actividad", Storage = "_act_Actividad1", DbType = "VarChar(MAX) NOT NULL", CanBeNull = false)]
    public string act_Actividad1
    {
      get => this._act_Actividad1;
      set
      {
        if (!(this._act_Actividad1 != value))
          return;
        this.SendPropertyChanging();
        this._act_Actividad1 = value;
        this.SendPropertyChanged(nameof (act_Actividad1));
      }
    }

    [Column(Storage = "_act_EntidadesIvolucradas", DbType = "VarChar(MAX) NOT NULL", CanBeNull = false)]
    public string act_EntidadesIvolucradas
    {
      get => this._act_EntidadesIvolucradas;
      set
      {
        if (!(this._act_EntidadesIvolucradas != value))
          return;
        this.SendPropertyChanging();
        this._act_EntidadesIvolucradas = value;
        this.SendPropertyChanged(nameof (act_EntidadesIvolucradas));
      }
    }

    [Column(Storage = "_act_PersonasImpactadas", DbType = "Int NOT NULL")]
    public int act_PersonasImpactadas
    {
      get => this._act_PersonasImpactadas;
      set
      {
        if (this._act_PersonasImpactadas == value)
          return;
        this.SendPropertyChanging();
        this._act_PersonasImpactadas = value;
        this.SendPropertyChanged(nameof (act_PersonasImpactadas));
      }
    }

    [Column(Storage = "_mun_Id", DbType = "VarChar(5) NOT NULL", CanBeNull = false)]
    public string mun_Id
    {
      get => this._mun_Id;
      set
      {
        if (!(this._mun_Id != value))
          return;
        if (this._mun_Municipio.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._mun_Id = value;
        this.SendPropertyChanged(nameof (mun_Id));
      }
    }

    [Column(Storage = "_ati_Id", DbType = "Int NOT NULL")]
    public int ati_Id
    {
      get => this._ati_Id;
      set
      {
        if (this._ati_Id == value)
          return;
        if (this._ati_ActividadTipo.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._ati_Id = value;
        this.SendPropertyChanged(nameof (ati_Id));
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

    [Association(Name = "act_Actividad_ame_ActividadmaterialEntregado", Storage = "_ame_ActividadmaterialEntregados", ThisKey = "act_Id", OtherKey = "act_Id")]
    public EntitySet<ame_ActividadmaterialEntregado> ame_ActividadmaterialEntregados
    {
      get => this._ame_ActividadmaterialEntregados;
      set => this._ame_ActividadmaterialEntregados.Assign((IEnumerable<ame_ActividadmaterialEntregado>) value);
    }

    [Association(Name = "ati_ActividadTipo_act_Actividad", Storage = "_ati_ActividadTipo", ThisKey = "ati_Id", OtherKey = "ati_Id", IsForeignKey = true)]
    public ati_ActividadTipo ati_ActividadTipo
    {
      get => this._ati_ActividadTipo.Entity;
      set
      {
        ati_ActividadTipo entity = this._ati_ActividadTipo.Entity;
        if (entity == value && this._ati_ActividadTipo.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._ati_ActividadTipo.Entity = (ati_ActividadTipo) null;
          entity.act_Actividads.Remove(this);
        }
        this._ati_ActividadTipo.Entity = value;
        if (value != null)
        {
          value.act_Actividads.Add(this);
          this._ati_Id = value.ati_Id;
        }
        else
          this._ati_Id = 0;
        this.SendPropertyChanged(nameof (ati_ActividadTipo));
      }
    }

    [Association(Name = "mun_Municipio_act_Actividad", Storage = "_mun_Municipio", ThisKey = "mun_Id", OtherKey = "mun_Id", IsForeignKey = true)]
    public mun_Municipio mun_Municipio
    {
      get => this._mun_Municipio.Entity;
      set
      {
        mun_Municipio entity = this._mun_Municipio.Entity;
        if (entity == value && this._mun_Municipio.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._mun_Municipio.Entity = (mun_Municipio) null;
          entity.act_Actividads.Remove(this);
        }
        this._mun_Municipio.Entity = value;
        if (value != null)
        {
          value.act_Actividads.Add(this);
          this._mun_Id = value.mun_Id;
        }
        else
          this._mun_Id = (string) null;
        this.SendPropertyChanged(nameof (mun_Municipio));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, act_Actividad.emptyChangingEventArgs);
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
      entity.act_Actividad = this;
    }

    private void detach_ame_ActividadmaterialEntregados(ame_ActividadmaterialEntregado entity)
    {
      this.SendPropertyChanging();
      entity.act_Actividad = (act_Actividad) null;
    }
  }
}
