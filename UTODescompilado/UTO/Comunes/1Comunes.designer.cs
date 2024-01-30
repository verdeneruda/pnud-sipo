// Decompiled with JetBrains decompiler
// Type: UTO.Comunes.tpr_TerceroProyecto
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO.Comunes
{
  [Table(Name = "Uto.tpr_TerceroProyecto")]
  public class tpr_TerceroProyecto : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _ter_Id;
    private int _pap_Id;
    private EntityRef<ter_Tercero> _ter_Tercero;

    public tpr_TerceroProyecto() => this._ter_Tercero = new EntityRef<ter_Tercero>();

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

    [Column(Storage = "_pap_Id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int pap_Id
    {
      get => this._pap_Id;
      set
      {
        if (this._pap_Id == value)
          return;
        this.SendPropertyChanging();
        this._pap_Id = value;
        this.SendPropertyChanged(nameof (pap_Id));
      }
    }

    [Association(Name = "ter_Tercero_tpr_TerceroProyecto", Storage = "_ter_Tercero", ThisKey = "ter_Id", OtherKey = "ter_Id", IsForeignKey = true)]
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
          entity.tpr_TerceroProyectos.Remove(this);
        }
        this._ter_Tercero.Entity = value;
        if (value != null)
        {
          value.tpr_TerceroProyectos.Add(this);
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
      this.PropertyChanging((object) this, tpr_TerceroProyecto.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
