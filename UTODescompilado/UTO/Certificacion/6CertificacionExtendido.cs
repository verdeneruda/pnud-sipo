// Decompiled with JetBrains decompiler
// Type: UTO.Certificacion.cem_CategoriaEmpresa
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO.Certificacion
{
  [Table(Name = "Cer.cem_CategoriaEmpresa")]
  public class cem_CategoriaEmpresa : 
    IComparable<cem_CategoriaEmpresa>,
    INotifyPropertyChanging,
    INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _cem_Id;
    private int _ter_Id;
    private string _cem_Descripcion;
    private string _seq_Usuario;
    private DateTime _seq_Creado;
    private DateTime _seq_Modificado;
    private EntityRef<ter_Tercero> _ter_Tercero;

    public int CompareTo(cem_CategoriaEmpresa other) => this.cem_Descripcion.CompareTo(other.cem_Descripcion);

    public cem_CategoriaEmpresa() => this._ter_Tercero = new EntityRef<ter_Tercero>();

    [Column(Storage = "_cem_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
    public int cem_Id
    {
      get => this._cem_Id;
      set
      {
        if (this._cem_Id == value)
          return;
        this.SendPropertyChanging();
        this._cem_Id = value;
        this.SendPropertyChanged(nameof (cem_Id));
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

    [Column(Storage = "_cem_Descripcion", DbType = "VarChar(75) NOT NULL", CanBeNull = false)]
    public string cem_Descripcion
    {
      get => this._cem_Descripcion;
      set
      {
        if (!(this._cem_Descripcion != value))
          return;
        this.SendPropertyChanging();
        this._cem_Descripcion = value;
        this.SendPropertyChanged(nameof (cem_Descripcion));
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

    [Association(Name = "ter_Tercero_cem_CategoriaEmpresa", Storage = "_ter_Tercero", ThisKey = "ter_Id", OtherKey = "ter_Id", IsForeignKey = true)]
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
          entity.cem_CategoriaEmpresas.Remove(this);
        }
        this._ter_Tercero.Entity = value;
        if (value != null)
        {
          value.cem_CategoriaEmpresas.Add(this);
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
      this.PropertyChanging((object) this, cem_CategoriaEmpresa.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
