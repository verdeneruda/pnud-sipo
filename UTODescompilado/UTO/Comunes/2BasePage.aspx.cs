// Decompiled with JetBrains decompiler
// Type: UTO.LocalItem
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

namespace UTO
{
  public class LocalItem
  {
    public LocalItem(string itemName, object itemValue)
    {
      this.Name = itemName;
      this.Value = itemValue;
    }

    public string Name { get; set; }

    public object Value { set; get; }
  }
}
