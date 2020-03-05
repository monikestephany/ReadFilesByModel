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
                BairroEnderecoDadosDoRisco = "444444444444444",
                NumeroContrato = "1111",
                NumeroVersaoContratoFixo = "1111",
                Chave = "1111",
                NumeroDoSub = "1111",
                Certificado = "1111",
                Cnpj_CpfItemSeguradoGlobal = "1111",
                MovimentoFixoIgualI = "1111",
                NomeUsuario = "1111",
                DataContratacao = "1111",
                FimDaVigencia = "1111",
                Cnpj_CpfItemSegurado = "1111",
                Cnpj_CpfItemSegurado2 = "1111",
                DescricaoEndereco = "1111",
                UF_Endereco = "1111",
                CidadeEndereco = "1111",
                BairroEndereco = "1111",
                CepEndereco = "1111",
                TelefoneComDDD = "1111",
                DescricaoEnderecoDadosDoRisco = "1111",
                UF_EnderecoDadosDoRisco = "1111",
                CidadeEnderecoDadosDoRisco = "1111",
                CepEnderecoDadosDoRisco = "1111",
                TelefoneComDDD_DadosDoRisco = "1111",
                PlacaEmBranco = "1111",
                CorEmBranco = "1111",
                ModeloEmBbranco = "1111",
                MarcaEmBranco = "1111",
                DiaCarroParcialEmBbranco = "1111",
                CarroTotalEmBranco = "1111",
                DiaCarroRouboEmBranco = "1111",
                NomeEstipulante = "1111",
                NomeBeneficiario = "1111",
                ValorLimiteRisco = "1111",
                DataNascimento_ChavePrincipal = "1111",
                CodigoEmpresaFixoV = "1111"
            };
        
            var modelo = Util.ReadFile(@"C:\temp\modelouss.txt");
            Escrita escrita = new Escrita();
            var retorno = escrita.WriteFileByModel(new List<Capitalizacao> { cap }, modelo);
            Util.WriteFile(retorno, @"C:\temp\saida.txt");
        }
    }
}
