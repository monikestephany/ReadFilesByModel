using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TesteFile
{
    public static class Util
    {
        public static string SetLengthString(this string value, int length)
        {
            return value.Length > length ? value.Substring(0, length) : value.PadRight(length, ' ');
        }
        public static List<string> ReadFile(string input)
        {
            string line;
            var file = new StreamReader(input);
            List<string> list = new List<string>();
            while ((line = file.ReadLine()) != null)
            {
                list.Add(line);
            }
            return list;
        }
        public static void WriteFile(List<string> list ,string output)
        {
            var file = new StreamWriter(output);
            foreach (var item in list)
            {
                file.WriteLine(item);
            }
            file.Close();
        }
        public static string InsertString(this string value, int start, string text)
        {
            return value.Length < start ? value.PadRight(start, ' ') + text : value.Insert(start,text);
        }
    }
}
