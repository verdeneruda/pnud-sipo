// Decompiled with JetBrains decompiler
// Type: UTO.Comercializacion.cpr_ComercializacionProveedor
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO.Comercializacion
{
  [Table(Name = "Com.cpr_ComercializacionProveedor")]
  public class cpr_ComercializacionProveedor : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _cda_Id;
    private int _ter_Id;
    private EntityRef<cda_ComercializacionDato> _cda_ComercializacionDato;
    private EntityRef<ter_Tercero> _ter_Tercero;

    public cpr_ComercializacionProveedor()
    {
      this._cda_ComercializacionDato = new EntityRef<cda_ComercializacionDato>();
      this._ter_Tercero = new EntityRef<ter_Tercero>();
    }

    [Column(Storage = "_cda_Id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int cda_Id
    {
      get => this._cda_Id;
      set
      {
        if (this._cda_Id == value)
          return;
        if (this._cda_ComercializacionDato.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._cda_Id = value;
        this.SendPropertyChanged(nameof (cda_Id));
      }
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

    [Association(Name = "cda_ComercializacionDato_cpr_ComercializacionProveedor", Storage = "_cda_ComercializacionDato", ThisKey = "cda_Id", OtherKey = "cda_Id", IsForeignKey = true)]
    public cda_ComercializacionDato cda_ComercializacionDato
    {
      get => this._cda_ComercializacionDato.Entity;
      set
      {
        cda_ComercializacionDato entity = this._cda_ComercializacionDato.Entity;
        if (entity == value && this._cda_ComercializacionDato.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._cda_ComercializacionDato.Entity = (cda_ComercializacionDato) null;
          entity.cpr_ComercializacionProveedors.Remove(this);
        }
        this._cda_ComercializacionDato.Entity = value;
        if (value != null)
        {
          value.cpr_ComercializacionProveedors.Add(this);
          this._cda_Id = value.cda_Id;
        }
        else
          this._cda_Id = 0;
        this.SendPropertyChanged(nameof (cda_ComercializacionDato));
      }
    }

    [Association(Name = "ter_Tercero_cpr_ComercializacionProveedor", Storage = "_ter_Tercero", ThisKey = "ter_Id", OtherKey = "ter_Id", IsForeignKey = true)]
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
          entity.cpr_ComercializacionProveedors.Remove(this);
        }
        this._ter_Tercero.Entity = value;
        if (value != null)
        {
          value.cpr_ComercializacionProveedors.Add(this);
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
      this.PropertyChanging((object) this, cpr_ComercializacionProveedor.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
