// Decompiled with JetBrains decompiler
// Type: UTO.pgr_PermisoGrupo
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO
{
  [Table(Name = "dbo.pgr_PermisoGrupo")]
  public class pgr_PermisoGrupo : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _gru_id;
    private int _ope_id;
    private EntityRef<gru_Grupo> _gru_Grupo;
    private EntityRef<ope_Operacion> _ope_Operacion;

    public pgr_PermisoGrupo()
    {
      this._gru_Grupo = new EntityRef<gru_Grupo>();
      this._ope_Operacion = new EntityRef<ope_Operacion>();
    }

    [Column(Storage = "_gru_id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int gru_id
    {
      get => this._gru_id;
      set
      {
        if (this._gru_id == value)
          return;
        if (this._gru_Grupo.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._gru_id = value;
        this.SendPropertyChanged(nameof (gru_id));
      }
    }

    [Column(Storage = "_ope_id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int ope_id
    {
      get => this._ope_id;
      set
      {
        if (this._ope_id == value)
          return;
        if (this._ope_Operacion.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._ope_id = value;
        this.SendPropertyChanged(nameof (ope_id));
      }
    }

    [Association(Name = "gru_Grupo_pgr_PermisoGrupo", Storage = "_gru_Grupo", ThisKey = "gru_id", OtherKey = "gru_id", IsForeignKey = true)]
    public gru_Grupo gru_Grupo
    {
      get => this._gru_Grupo.Entity;
      set
      {
        gru_Grupo entity = this._gru_Grupo.Entity;
        if (entity == value && this._gru_Grupo.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._gru_Grupo.Entity = (gru_Grupo) null;
          entity.pgr_PermisoGrupos.Remove(this);
        }
        this._gru_Grupo.Entity = value;
        if (value != null)
        {
          value.pgr_PermisoGrupos.Add(this);
          this._gru_id = value.gru_id;
        }
        else
          this._gru_id = 0;
        this.SendPropertyChanged(nameof (gru_Grupo));
      }
    }

    [Association(Name = "ope_Operacion_pgr_PermisoGrupo", Storage = "_ope_Operacion", ThisKey = "ope_id", OtherKey = "ope_id", IsForeignKey = true)]
    public ope_Operacion ope_Operacion
    {
      get => this._ope_Operacion.Entity;
      set
      {
        ope_Operacion entity = this._ope_Operacion.Entity;
        if (entity == value && this._ope_Operacion.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._ope_Operacion.Entity = (ope_Operacion) null;
          entity.pgr_PermisoGrupos.Remove(this);
        }
        this._ope_Operacion.Entity = value;
        if (value != null)
        {
          value.pgr_PermisoGrupos.Add(this);
          this._ope_id = value.ope_id;
        }
        else
          this._ope_id = 0;
        this.SendPropertyChanged(nameof (ope_Operacion));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, pgr_PermisoGrupo.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
