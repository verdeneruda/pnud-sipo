// Decompiled with JetBrains decompiler
// Type: UTO.Certificacion.ame_ActividadmaterialEntregado
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO.Certificacion
{
  [Table(Name = "Cer.ame_ActividadmaterialEntregado")]
  public class ame_ActividadmaterialEntregado : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _ame_Id;
    private int _act_Id;
    private int _acm_Id;
    private int _ame_Cantidad;
    private string _ame_Usuario;
    private DateTime _ame_Creado;
    private DateTime _ame_Modificado;
    private EntityRef<acm_ActividadMaterial> _acm_ActividadMaterial;
    private EntityRef<act_Actividad> _act_Actividad;

    public ame_ActividadmaterialEntregado()
    {
      this._acm_ActividadMaterial = new EntityRef<acm_ActividadMaterial>();
      this._act_Actividad = new EntityRef<act_Actividad>();
    }

    [Column(Storage = "_ame_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
    public int ame_Id
    {
      get => this._ame_Id;
      set
      {
        if (this._ame_Id == value)
          return;
        this.SendPropertyChanging();
        this._ame_Id = value;
        this.SendPropertyChanged(nameof (ame_Id));
      }
    }

    [Column(Storage = "_act_Id", DbType = "Int NOT NULL")]
    public int act_Id
    {
      get => this._act_Id;
      set
      {
        if (this._act_Id == value)
          return;
        if (this._act_Actividad.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._act_Id = value;
        this.SendPropertyChanged(nameof (act_Id));
      }
    }

    [Column(Storage = "_acm_Id", DbType = "Int NOT NULL")]
    public int acm_Id
    {
      get => this._acm_Id;
      set
      {
        if (this._acm_Id == value)
          return;
        if (this._acm_ActividadMaterial.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._acm_Id = value;
        this.SendPropertyChanged(nameof (acm_Id));
      }
    }

    [Column(Storage = "_ame_Cantidad", DbType = "Int NOT NULL")]
    public int ame_Cantidad
    {
      get => this._ame_Cantidad;
      set
      {
        if (this._ame_Cantidad == value)
          return;
        this.SendPropertyChanging();
        this._ame_Cantidad = value;
        this.SendPropertyChanged(nameof (ame_Cantidad));
      }
    }

    [Column(Storage = "_ame_Usuario", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
    public string ame_Usuario
    {
      get => this._ame_Usuario;
      set
      {
        if (!(this._ame_Usuario != value))
          return;
        this.SendPropertyChanging();
        this._ame_Usuario = value;
        this.SendPropertyChanged(nameof (ame_Usuario));
      }
    }

    [Column(Storage = "_ame_Creado", DbType = "DateTime NOT NULL")]
    public DateTime ame_Creado
    {
      get => this._ame_Creado;
      set
      {
        if (!(this._ame_Creado != value))
          return;
        this.SendPropertyChanging();
        this._ame_Creado = value;
        this.SendPropertyChanged(nameof (ame_Creado));
      }
    }

    [Column(Storage = "_ame_Modificado", DbType = "DateTime NOT NULL")]
    public DateTime ame_Modificado
    {
      get => this._ame_Modificado;
      set
      {
        if (!(this._ame_Modificado != value))
          return;
        this.SendPropertyChanging();
        this._ame_Modificado = value;
        this.SendPropertyChanged(nameof (ame_Modificado));
      }
    }

    [Association(Name = "acm_ActividadMaterial_ame_ActividadmaterialEntregado", Storage = "_acm_ActividadMaterial", ThisKey = "acm_Id", OtherKey = "acm_Id", IsForeignKey = true)]
    public acm_ActividadMaterial acm_ActividadMaterial
    {
      get => this._acm_ActividadMaterial.Entity;
      set
      {
        acm_ActividadMaterial entity = this._acm_ActividadMaterial.Entity;
        if (entity == value && this._acm_ActividadMaterial.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._acm_ActividadMaterial.Entity = (acm_ActividadMaterial) null;
          entity.ame_ActividadmaterialEntregados.Remove(this);
        }
        this._acm_ActividadMaterial.Entity = value;
        if (value != null)
        {
          value.ame_ActividadmaterialEntregados.Add(this);
          this._acm_Id = value.acm_Id;
        }
        else
          this._acm_Id = 0;
        this.SendPropertyChanged(nameof (acm_ActividadMaterial));
      }
    }

    [Association(Name = "act_Actividad_ame_ActividadmaterialEntregado", Storage = "_act_Actividad", ThisKey = "act_Id", OtherKey = "act_Id", IsForeignKey = true)]
    public act_Actividad act_Actividad
    {
      get => this._act_Actividad.Entity;
      set
      {
        act_Actividad entity = this._act_Actividad.Entity;
        if (entity == value && this._act_Actividad.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._act_Actividad.Entity = (act_Actividad) null;
          entity.ame_ActividadmaterialEntregados.Remove(this);
        }
        this._act_Actividad.Entity = value;
        if (value != null)
        {
          value.ame_ActividadmaterialEntregados.Add(this);
          this._act_Id = value.act_Id;
        }
        else
          this._act_Id = 0;
        this.SendPropertyChanged(nameof (act_Actividad));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, ame_ActividadmaterialEntregado.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
