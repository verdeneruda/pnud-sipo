// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.dvn_DocumentoVerificarNovedad
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO.Recuperacion
{
  [Table(Name = "Rrr.dvn_DocumentoVerificarNovedad")]
  public class dvn_DocumentoVerificarNovedad : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _neq_Id;
    private int _dve_Id;
    private EntityRef<dve_DocumentoVerificar> _dve_DocumentoVerificar;
    private EntityRef<neq_NovedadEquipo> _neq_NovedadEquipo;

    public dvn_DocumentoVerificarNovedad()
    {
      this._dve_DocumentoVerificar = new EntityRef<dve_DocumentoVerificar>();
      this._neq_NovedadEquipo = new EntityRef<neq_NovedadEquipo>();
    }

    [Column(Storage = "_neq_Id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int neq_Id
    {
      get => this._neq_Id;
      set
      {
        if (this._neq_Id == value)
          return;
        if (this._neq_NovedadEquipo.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._neq_Id = value;
        this.SendPropertyChanged(nameof (neq_Id));
      }
    }

    [Column(Storage = "_dve_Id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int dve_Id
    {
      get => this._dve_Id;
      set
      {
        if (this._dve_Id == value)
          return;
        if (this._dve_DocumentoVerificar.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._dve_Id = value;
        this.SendPropertyChanged(nameof (dve_Id));
      }
    }

    [Association(Name = "dve_DocumentoVerificar_dvn_DocumentoVerificarNovedad", Storage = "_dve_DocumentoVerificar", ThisKey = "dve_Id", OtherKey = "dve_Id", IsForeignKey = true)]
    public dve_DocumentoVerificar dve_DocumentoVerificar
    {
      get => this._dve_DocumentoVerificar.Entity;
      set
      {
        dve_DocumentoVerificar entity = this._dve_DocumentoVerificar.Entity;
        if (entity == value && this._dve_DocumentoVerificar.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._dve_DocumentoVerificar.Entity = (dve_DocumentoVerificar) null;
          entity.dvn_DocumentoVerificarNovedads.Remove(this);
        }
        this._dve_DocumentoVerificar.Entity = value;
        if (value != null)
        {
          value.dvn_DocumentoVerificarNovedads.Add(this);
          this._dve_Id = value.dve_Id;
        }
        else
          this._dve_Id = 0;
        this.SendPropertyChanged(nameof (dve_DocumentoVerificar));
      }
    }

    [Association(Name = "neq_NovedadEquipo_dvn_DocumentoVerificarNovedad", Storage = "_neq_NovedadEquipo", ThisKey = "neq_Id", OtherKey = "neq_Id", IsForeignKey = true)]
    public neq_NovedadEquipo neq_NovedadEquipo
    {
      get => this._neq_NovedadEquipo.Entity;
      set
      {
        neq_NovedadEquipo entity = this._neq_NovedadEquipo.Entity;
        if (entity == value && this._neq_NovedadEquipo.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._neq_NovedadEquipo.Entity = (neq_NovedadEquipo) null;
          entity.dvn_DocumentoVerificarNovedads.Remove(this);
        }
        this._neq_NovedadEquipo.Entity = value;
        if (value != null)
        {
          value.dvn_DocumentoVerificarNovedads.Add(this);
          this._neq_Id = value.neq_Id;
        }
        else
          this._neq_Id = 0;
        this.SendPropertyChanged(nameof (neq_NovedadEquipo));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, dvn_DocumentoVerificarNovedad.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
