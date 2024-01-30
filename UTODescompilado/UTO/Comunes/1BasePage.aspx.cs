// Decompiled with JetBrains decompiler
// Type: UTO.LocalInformation
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System.Collections.Generic;
using System.Data.Linq;

namespace UTO
{
  public class LocalInformation
  {
    public LocalInformation() => this.Data = new List<LocalItem>();

    public DataContext MyDataContext { get; set; }

    public object MyParams { get; set; }

    public List<LocalItem> Data { get; set; }

    public object GetData(string name) => this.findData(name)?.Value;

    public void SetData(string name, object value)
    {
      LocalItem data = this.findData(name);
      if (data == null)
        this.Data.Add(new LocalItem(name, value));
      else
        data.Value = value;
    }

    public void RemoveData(string name) => this.Data.Remove(this.findData(name));

    private LocalItem findData(string name)
    {
      foreach (LocalItem data in this.Data)
      {
        if (data.Name == name)
          return data;
      }
      return (LocalItem) null;
    }
  }
}
