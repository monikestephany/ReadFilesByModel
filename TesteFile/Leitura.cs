using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace TesteFile
{
    public class Leitura
    {
        public List<T> TesteLeitura<T>(List<string> inPut,List<string> models) where T : class,new()
        {
          
            var list = new List<T>();
            for (int v = 0; v < inPut.Count; v++)
            {
                var obj = new T();
                for (int i = 0; i < models.Count; i++)
                {
                    foreach (var item in obj.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
                    {
                        var sp = models[i].Split(';');
                        if (item.Name == sp[2])
                        {
                            item.SetValue(obj, inPut[v].ToString().Substring(int.Parse(sp[0]), int.Parse(sp[1])));
                        }
                    }
                }
                list.Add(obj);
            }
            return list;
        }
    }
}
