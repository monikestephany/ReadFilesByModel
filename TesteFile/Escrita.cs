using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace TesteFile
{
    public class Escrita
    {
        public List<string> WriteFileByModel<T>(List<T> input,List<string> models)
        {
            List<string> outPut = new List<string>();

            foreach (var f in input)
            {
                string linha = "";
                linha = linha.PadRight(909, ' ');
                for (int i = 0; i < models.Count; i++)
                {
                    foreach (var item in f.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
                    {
                        var sp = models[i].Split(';');
                        if (item.Name == sp[2])
                        {
                            linha = linha.Insert(int.Parse(sp[0]), item.GetValue(f).ToString().SetLengthString(int.Parse(sp[1])));
                          
                        }
                    }
                }
                outPut.Add(linha);
            }
            return outPut;
        }     
    }
}
