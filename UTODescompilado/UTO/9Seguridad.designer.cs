// Decompiled with JetBrains decompiler
// Type: UTO.ugr_UsuarioGrupo
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System.Data.Linq.Mapping;

namespace UTO
{
  [Table(Name = "dbo.ugr_UsuarioGrupo")]
  public class ugr_UsuarioGrupo
  {
    private int _usu_id;
    private int _gru_id;

    [Column(Storage = "_usu_id", DbType = "Int NOT NULL")]
    public int usu_id
    {
      get => this._usu_id;
      set
      {
        if (this._usu_id == value)
          return;
        this._usu_id = value;
      }
    }

    [Column(Storage = "_gru_id", DbType = "Int NOT NULL")]
    public int gru_id
    {
      get => this._gru_id;
      set
      {
        if (this._gru_id == value)
          return;
        this._gru_id = value;
      }
    }
  }
}
