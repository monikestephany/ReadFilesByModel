using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace TesteFile
{
    public class Escrita
    {
        public List<string> WriteFileByModel<T>(List<T> input, List<string> models)
        {
            List<string> outPut = new List<string>();

            for (int q = 0; q < input.Count; q++)
            {
                string linha = "";
                string header = "";
                string trailer = "";
                trailer = trailer.SetLengthString(909);
                for (int i = 0; i < models.Count; i++)
                {
                    foreach (var item in input[q].GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
                    {
                        var sp = models[i].Split(';');

                        if (item.Name == sp[2])
                        {
                            if (sp[3] == "H" && q == 0)
                            {
                                header = header.InsertString(int.Parse(sp[0]), item.GetValue(input[q]).ToString().SetLengthString(int.Parse(sp[1])));

                            }
                            else if (sp[3] == "T" && q == (input.Count - 1))
                            {
                                trailer = trailer.InsertString(int.Parse(sp[0]), item.GetValue(input[q]).ToString().SetLengthString(int.Parse(sp[1])));
                            }
                            else
                            {
                                linha = linha.InsertString(int.Parse(sp[0]), item.GetValue(input[q]).ToString().SetLengthString(int.Parse(sp[1])));
                            }
                        }
                    }

                }
                if (q == 0)
                {
                    outPut.Add(header);                 
                }
                outPut.Add(linha);
                if (q == (input.Count - 1))
                {
                    outPut.Add(trailer);
                }
                
               
            }
            return outPut;
        }
    }
}
