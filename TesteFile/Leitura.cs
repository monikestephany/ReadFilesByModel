using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace TesteFile
{
    public class Leitura
    {
        public List<T> TesteLeitura<T>(List<string> inPut,List<string> models, bool header, bool trailler) where T : class,new()
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
                            if (header && sp.Length > 3 && sp[3] == "H")
                            {
                                item.SetValue(obj, inPut[0].ToString().Substring(int.Parse(sp[0]), int.Parse(sp[1])));
                            }
                            if(trailler && sp.Length > 3 && sp[3] == "T")
                            {
                                item.SetValue(obj, inPut[inPut.Count - 1].ToString().Substring(int.Parse(sp[0]), int.Parse(sp[1])));
                            }

                        }
   

                    }
                }
                if ((header && v == 0) || (trailler && v == inPut.Count - 1))
                {
                    continue;
                }
                else
                {
                    list.Add(obj);
                }
               
            }
            return list;
        }
    }
}
