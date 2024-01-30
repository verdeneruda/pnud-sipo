// Decompiled with JetBrains decompiler
// Type: UTO.ImportacionExportacion.spComboAnoResult
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System.Data.Linq.Mapping;

namespace UTO.ImportacionExportacion
{
  public class spComboAnoResult
  {
    private int? _anos;

    [Column(Storage = "_anos", DbType = "Int")]
    public int? anos
    {
      get => this._anos;
      set
      {
        int? anos = this._anos;
        int? nullable = value;
        if ((anos.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (anos.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this._anos = value;
      }
    }
  }
}
