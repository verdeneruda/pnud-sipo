// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.ndo_NovedadDocumento
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO.Recuperacion
{
  [Table(Name = "Rrr.ndo_NovedadDocumento")]
  public class ndo_NovedadDocumento : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _ndo_Id;
    private int _doc_Id;
    private int _neq_Id;
    private EntityRef<doc_Documento> _doc_Documento;
    private EntityRef<neq_NovedadEquipo> _neq_NovedadEquipo;

    public ndo_NovedadDocumento()
    {
      this._doc_Documento = new EntityRef<doc_Documento>();
      this._neq_NovedadEquipo = new EntityRef<neq_NovedadEquipo>();
    }

    [Column(Storage = "_ndo_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
    public int ndo_Id
    {
      get => this._ndo_Id;
      set
      {
        if (this._ndo_Id == value)
          return;
        this.SendPropertyChanging();
        this._ndo_Id = value;
        this.SendPropertyChanged(nameof (ndo_Id));
      }
    }

    [Column(Storage = "_doc_Id", DbType = "Int NOT NULL")]
    public int doc_Id
    {
      get => this._doc_Id;
      set
      {
        if (this._doc_Id == value)
          return;
        if (this._doc_Documento.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._doc_Id = value;
        this.SendPropertyChanged(nameof (doc_Id));
      }
    }

    [Column(Storage = "_neq_Id", DbType = "Int NOT NULL")]
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

    [Association(Name = "doc_Documento_ndo_NovedadDocumento", Storage = "_doc_Documento", ThisKey = "doc_Id", OtherKey = "doc_Id", IsForeignKey = true)]
    public doc_Documento doc_Documento
    {
      get => this._doc_Documento.Entity;
      set
      {
        doc_Documento entity = this._doc_Documento.Entity;
        if (entity == value && this._doc_Documento.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._doc_Documento.Entity = (doc_Documento) null;
          entity.ndo_NovedadDocumentos.Remove(this);
        }
        this._doc_Documento.Entity = value;
        if (value != null)
        {
          value.ndo_NovedadDocumentos.Add(this);
          this._doc_Id = value.doc_Id;
        }
        else
          this._doc_Id = 0;
        this.SendPropertyChanged(nameof (doc_Documento));
      }
    }

    [Association(Name = "neq_NovedadEquipo_ndo_NovedadDocumento", Storage = "_neq_NovedadEquipo", ThisKey = "neq_Id", OtherKey = "neq_Id", IsForeignKey = true)]
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
          entity.ndo_NovedadDocumentos.Remove(this);
        }
        this._neq_NovedadEquipo.Entity = value;
        if (value != null)
        {
          value.ndo_NovedadDocumentos.Add(this);
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
      this.PropertyChanging((object) this, ndo_NovedadDocumento.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
