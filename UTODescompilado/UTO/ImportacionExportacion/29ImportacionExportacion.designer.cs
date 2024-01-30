// Decompiled with JetBrains decompiler
// Type: UTO.ImportacionExportacion.rie_RegistroImportacionEquipo
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO.ImportacionExportacion
{
  [Table(Name = "Iye.rie_RegistroImportacionEquipo")]
  public class rie_RegistroImportacionEquipo : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _rie_Id;
    private int _meq_Id;
    private Decimal? _rie_CantidadImportada;
    private string _rie_Referencia;
    private int _rim_Id;
    private int _ear_Id;
    private string _rie_Usuario;
    private DateTime _rie_Creado;
    private DateTime _rie_Modificado;
    private EntityRef<ear_EquipoArancel> _ear_EquipoArancel;
    private EntityRef<meq_MarcaEquipo> _meq_MarcaEquipo;
    private EntityRef<rim_RegistroImportacion> _rim_RegistroImportacion;

    public rie_RegistroImportacionEquipo()
    {
      this._ear_EquipoArancel = new EntityRef<ear_EquipoArancel>();
      this._meq_MarcaEquipo = new EntityRef<meq_MarcaEquipo>();
      this._rim_RegistroImportacion = new EntityRef<rim_RegistroImportacion>();
    }

    [Column(Storage = "_rie_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
    public int rie_Id
    {
      get => this._rie_Id;
      set
      {
        if (this._rie_Id == value)
          return;
        this.SendPropertyChanging();
        this._rie_Id = value;
        this.SendPropertyChanged(nameof (rie_Id));
      }
    }

    [Column(Storage = "_meq_Id", DbType = "Int NOT NULL")]
    public int meq_Id
    {
      get => this._meq_Id;
      set
      {
        if (this._meq_Id == value)
          return;
        if (this._meq_MarcaEquipo.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._meq_Id = value;
        this.SendPropertyChanged(nameof (meq_Id));
      }
    }

    [Column(Storage = "_rie_CantidadImportada", DbType = "Decimal(10,2)")]
    public Decimal? rie_CantidadImportada
    {
      get => this._rie_CantidadImportada;
      set
      {
        Decimal? cantidadImportada = this._rie_CantidadImportada;
        Decimal? nullable = value;
        if ((cantidadImportada.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (cantidadImportada.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._rie_CantidadImportada = value;
        this.SendPropertyChanged(nameof (rie_CantidadImportada));
      }
    }

    [Column(Storage = "_rie_Referencia", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string rie_Referencia
    {
      get => this._rie_Referencia;
      set
      {
        if (!(this._rie_Referencia != value))
          return;
        this.SendPropertyChanging();
        this._rie_Referencia = value;
        this.SendPropertyChanged(nameof (rie_Referencia));
      }
    }

    [Column(Storage = "_rim_Id", DbType = "Int NOT NULL")]
    public int rim_Id
    {
      get => this._rim_Id;
      set
      {
        if (this._rim_Id == value)
          return;
        if (this._rim_RegistroImportacion.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._rim_Id = value;
        this.SendPropertyChanged(nameof (rim_Id));
      }
    }

    [Column(Storage = "_ear_Id", DbType = "Int NOT NULL")]
    public int ear_Id
    {
      get => this._ear_Id;
      set
      {
        if (this._ear_Id == value)
          return;
        if (this._ear_EquipoArancel.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._ear_Id = value;
        this.SendPropertyChanged(nameof (ear_Id));
      }
    }

    [Column(Storage = "_rie_Usuario", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
    public string rie_Usuario
    {
      get => this._rie_Usuario;
      set
      {
        if (!(this._rie_Usuario != value))
          return;
        this.SendPropertyChanging();
        this._rie_Usuario = value;
        this.SendPropertyChanged(nameof (rie_Usuario));
      }
    }

    [Column(Storage = "_rie_Creado", DbType = "DateTime NOT NULL")]
    public DateTime rie_Creado
    {
      get => this._rie_Creado;
      set
      {
        if (!(this._rie_Creado != value))
          return;
        this.SendPropertyChanging();
        this._rie_Creado = value;
        this.SendPropertyChanged(nameof (rie_Creado));
      }
    }

    [Column(Storage = "_rie_Modificado", DbType = "DateTime NOT NULL")]
    public DateTime rie_Modificado
    {
      get => this._rie_Modificado;
      set
      {
        if (!(this._rie_Modificado != value))
          return;
        this.SendPropertyChanging();
        this._rie_Modificado = value;
        this.SendPropertyChanged(nameof (rie_Modificado));
      }
    }

    [Association(Name = "ear_EquipoArancel_rie_RegistroImportacionEquipo", Storage = "_ear_EquipoArancel", ThisKey = "ear_Id", OtherKey = "ear_id", IsForeignKey = true)]
    public ear_EquipoArancel ear_EquipoArancel
    {
      get => this._ear_EquipoArancel.Entity;
      set
      {
        ear_EquipoArancel entity = this._ear_EquipoArancel.Entity;
        if (entity == value && this._ear_EquipoArancel.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._ear_EquipoArancel.Entity = (ear_EquipoArancel) null;
          entity.rie_RegistroImportacionEquipos.Remove(this);
        }
        this._ear_EquipoArancel.Entity = value;
        if (value != null)
        {
          value.rie_RegistroImportacionEquipos.Add(this);
          this._ear_Id = value.ear_id;
        }
        else
          this._ear_Id = 0;
        this.SendPropertyChanged(nameof (ear_EquipoArancel));
      }
    }

    [Association(Name = "meq_MarcaEquipo_rie_RegistroImportacionEquipo", Storage = "_meq_MarcaEquipo", ThisKey = "meq_Id", OtherKey = "meq_id", IsForeignKey = true)]
    public meq_MarcaEquipo meq_MarcaEquipo
    {
      get => this._meq_MarcaEquipo.Entity;
      set
      {
        meq_MarcaEquipo entity = this._meq_MarcaEquipo.Entity;
        if (entity == value && this._meq_MarcaEquipo.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._meq_MarcaEquipo.Entity = (meq_MarcaEquipo) null;
          entity.rie_RegistroImportacionEquipos.Remove(this);
        }
        this._meq_MarcaEquipo.Entity = value;
        if (value != null)
        {
          value.rie_RegistroImportacionEquipos.Add(this);
          this._meq_Id = value.meq_id;
        }
        else
          this._meq_Id = 0;
        this.SendPropertyChanged(nameof (meq_MarcaEquipo));
      }
    }

    [Association(Name = "rim_RegistroImportacion_rie_RegistroImportacionEquipo", Storage = "_rim_RegistroImportacion", ThisKey = "rim_Id", OtherKey = "rim_Id", IsForeignKey = true)]
    public rim_RegistroImportacion rim_RegistroImportacion
    {
      get => this._rim_RegistroImportacion.Entity;
      set
      {
        rim_RegistroImportacion entity = this._rim_RegistroImportacion.Entity;
        if (entity == value && this._rim_RegistroImportacion.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._rim_RegistroImportacion.Entity = (rim_RegistroImportacion) null;
          entity.rie_RegistroImportacionEquipos.Remove(this);
        }
        this._rim_RegistroImportacion.Entity = value;
        if (value != null)
        {
          value.rie_RegistroImportacionEquipos.Add(this);
          this._rim_Id = value.rim_Id;
        }
        else
          this._rim_Id = 0;
        this.SendPropertyChanged(nameof (rim_RegistroImportacion));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, rie_RegistroImportacionEquipo.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
