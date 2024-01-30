// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.dvs_DocumentoVerificarSolicitud
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO.Recuperacion
{
  [Table(Name = "Rrr.dvs_DocumentoVerificarSolicitud")]
  public class dvs_DocumentoVerificarSolicitud : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _seq_Id;
    private int _dve_Id;
    private EntityRef<dve_DocumentoVerificar> _dve_DocumentoVerificar;
    private EntityRef<seq_SolicitudEquipo> _seq_SolicitudEquipo;

    public dvs_DocumentoVerificarSolicitud()
    {
      this._dve_DocumentoVerificar = new EntityRef<dve_DocumentoVerificar>();
      this._seq_SolicitudEquipo = new EntityRef<seq_SolicitudEquipo>();
    }

    [Column(Storage = "_seq_Id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int seq_Id
    {
      get => this._seq_Id;
      set
      {
        if (this._seq_Id == value)
          return;
        if (this._seq_SolicitudEquipo.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._seq_Id = value;
        this.SendPropertyChanged(nameof (seq_Id));
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

    [Association(Name = "dve_DocumentoVerificar_dvs_DocumentoVerificarSolicitud", Storage = "_dve_DocumentoVerificar", ThisKey = "dve_Id", OtherKey = "dve_Id", IsForeignKey = true)]
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
          entity.dvs_DocumentoVerificarSolicituds.Remove(this);
        }
        this._dve_DocumentoVerificar.Entity = value;
        if (value != null)
        {
          value.dvs_DocumentoVerificarSolicituds.Add(this);
          this._dve_Id = value.dve_Id;
        }
        else
          this._dve_Id = 0;
        this.SendPropertyChanged(nameof (dve_DocumentoVerificar));
      }
    }

    [Association(Name = "seq_SolicitudEquipo_dvs_DocumentoVerificarSolicitud", Storage = "_seq_SolicitudEquipo", ThisKey = "seq_Id", OtherKey = "seq_Id", IsForeignKey = true)]
    public seq_SolicitudEquipo seq_SolicitudEquipo
    {
      get => this._seq_SolicitudEquipo.Entity;
      set
      {
        seq_SolicitudEquipo entity = this._seq_SolicitudEquipo.Entity;
        if (entity == value && this._seq_SolicitudEquipo.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._seq_SolicitudEquipo.Entity = (seq_SolicitudEquipo) null;
          entity.dvs_DocumentoVerificarSolicituds.Remove(this);
        }
        this._seq_SolicitudEquipo.Entity = value;
        if (value != null)
        {
          value.dvs_DocumentoVerificarSolicituds.Add(this);
          this._seq_Id = value.seq_Id;
        }
        else
          this._seq_Id = 0;
        this.SendPropertyChanged(nameof (seq_SolicitudEquipo));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, dvs_DocumentoVerificarSolicitud.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
