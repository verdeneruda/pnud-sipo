// Decompiled with JetBrains decompiler
// Type: UTO.Certificacion.ate_ActividadTercero
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System.Data.Linq.Mapping;

namespace UTO.Certificacion
{
  [Table(Name = "Cer.ate_ActividadTercero")]
  public class ate_ActividadTercero
  {
    private int _act_Id;
    private int _ter_Id;

    [Column(Storage = "_act_Id", DbType = "Int NOT NULL")]
    public int act_Id
    {
      get => this._act_Id;
      set
      {
        if (this._act_Id == value)
          return;
        this._act_Id = value;
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
        this._ter_Id = value;
      }
    }
  }
}
