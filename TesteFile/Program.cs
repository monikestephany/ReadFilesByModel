using System;
using System.Collections.Generic;
using TesteFile.Dto;

namespace TesteFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var cap = new Capitalizacao
            {
                AnoFabricacaoEmBranco = "1111",
                BairroEndereco = "1111111111111111111111111",
                BairroEnderecoDadosDoRisco = "444444444444444",
                CarroTotalEmBranco = "999999999"
            };
        
            var modelo = Util.ReadFile(@"C:\temp\modelouss.txt");
            Escrita escrita = new Escrita();
            var retorno = escrita.WriteFileByModel(new List<Capitalizacao> { cap }, modelo);
            Util.WriteFile(retorno, "");
        }
    }
}
