using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace TesteFile
{
    public class Escrita
    {
        public List<string> WriteFileByModel<T>(List<T> input, List<string> models,bool headerB,bool traillerB)
        {
            List<string> outPut = new List<string>();
            if (headerB)
            {
                string header = "";
                for (int i = 0; i < models.Count; i++)
                {
                    foreach (var item in input[0].GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
                    {
                        var sp = models[i].Split(';');
                        if (sp[3] == "H" && item.Name == sp[2])
                        {
                            header = header.InsertString(int.Parse(sp[0]), item.GetValue(input[0]).ToString().SetLengthString(int.Parse(sp[1])));

                        }
                    }
                }
                outPut.Add(header);
            }

            for (int q = 0; q < input.Count; q++)
            {
                string linha = "";
               
                for (int i = 0; i < models.Count; i++)
                {
                    foreach (var item in input[q].GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
                    {
                        var sp = models[i].Split(';');

                        if (item.Name == sp[2] && sp[3] != "H" && sp[3] != "T")
                        {
                            linha = linha.InsertString(int.Parse(sp[0]), item.GetValue(input[q]).ToString().SetLengthString(int.Parse(sp[1])));                   
                        }
                    }

                }
                outPut.Add(linha);
            }
            if (traillerB)
            {
                string trailer = "";
                for (int i = 0; i < models.Count; i++)
                {
                    foreach (var item in input[0].GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
                    {
                        var sp = models[i].Split(';');
                        if (sp[3] == "T" && item.Name == sp[2])
                        {
                            trailer = trailer.InsertString(int.Parse(sp[0]), item.GetValue(input[0]).ToString().SetLengthString(int.Parse(sp[1])));

                        }
                    }
                }
                outPut.Add(trailer);
            }
            return outPut;
        }
    }
}
