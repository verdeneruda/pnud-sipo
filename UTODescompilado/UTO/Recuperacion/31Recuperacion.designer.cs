// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.tgr_TerceroGrupo
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO.Recuperacion
{
  [Table(Name = "Uto.tgr_TerceroGrupo")]
  public class tgr_TerceroGrupo : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _ter_Id;
    private int _pyg_Id;
    private EntityRef<pyg_ProyectoGrupo> _pyg_ProyectoGrupo;
    private EntityRef<ter_Tercero> _ter_Tercero;

    public tgr_TerceroGrupo()
    {
      this._pyg_ProyectoGrupo = new EntityRef<pyg_ProyectoGrupo>();
      this._ter_Tercero = new EntityRef<ter_Tercero>();
    }

    [Column(Storage = "_ter_Id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
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

    [Column(Storage = "_pyg_Id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int pyg_Id
    {
      get => this._pyg_Id;
      set
      {
        if (this._pyg_Id == value)
          return;
        if (this._pyg_ProyectoGrupo.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._pyg_Id = value;
        this.SendPropertyChanged(nameof (pyg_Id));
      }
    }

    [Association(Name = "pyg_ProyectoGrupo_tgr_TerceroGrupo", Storage = "_pyg_ProyectoGrupo", ThisKey = "pyg_Id", OtherKey = "pyg_Id", IsForeignKey = true)]
    public pyg_ProyectoGrupo pyg_ProyectoGrupo
    {
      get => this._pyg_ProyectoGrupo.Entity;
      set
      {
        pyg_ProyectoGrupo entity = this._pyg_ProyectoGrupo.Entity;
        if (entity == value && this._pyg_ProyectoGrupo.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._pyg_ProyectoGrupo.Entity = (pyg_ProyectoGrupo) null;
          entity.tgr_TerceroGrupos.Remove(this);
        }
        this._pyg_ProyectoGrupo.Entity = value;
        if (value != null)
        {
          value.tgr_TerceroGrupos.Add(this);
          this._pyg_Id = value.pyg_Id;
        }
        else
          this._pyg_Id = 0;
        this.SendPropertyChanged(nameof (pyg_ProyectoGrupo));
      }
    }

    [Association(Name = "ter_Tercero_tgr_TerceroGrupo", Storage = "_ter_Tercero", ThisKey = "ter_Id", OtherKey = "ter_Id", IsForeignKey = true)]
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
          entity.tgr_TerceroGrupos.Remove(this);
        }
        this._ter_Tercero.Entity = value;
        if (value != null)
        {
          value.tgr_TerceroGrupos.Add(this);
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
      this.PropertyChanging((object) this, tgr_TerceroGrupo.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
