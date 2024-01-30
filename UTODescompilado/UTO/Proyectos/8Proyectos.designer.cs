// Decompiled with JetBrains decompiler
// Type: UTO.Proyectos.pdo_ProyectoDocumento
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System.Data.Linq.Mapping;

namespace UTO.Proyectos
{
  [Table(Name = "Pro.pdo_ProyectoDocumento")]
  public class pdo_ProyectoDocumento
  {
    private int _pap_Id;
    private int _doc_Id;

    [Column(Storage = "_pap_Id", DbType = "Int NOT NULL")]
    public int pap_Id
    {
      get => this._pap_Id;
      set
      {
        if (this._pap_Id == value)
          return;
        this._pap_Id = value;
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
        this._doc_Id = value;
      }
    }
  }
}
