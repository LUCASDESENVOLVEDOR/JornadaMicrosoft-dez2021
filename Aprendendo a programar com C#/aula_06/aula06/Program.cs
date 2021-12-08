using ClosedXML.Excel;
using System;
using System.IO; // input e output / entrada e saida de dados;
using System.Linq;
using System.Text; //UTF8;

namespace aula06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LER UM BANCO DE DADOS (EXCEL)

            //ClosedXML biblioteca importada pelo NUGUET.

            //caminho fisico do excel.
            string caminho = @"C:\Users\Lucas - Senai\Desktop\AULA_06\banco_de_dados.xlsx";

            //nova instancia de XLWorkbook abrindo conexao com o excel.
            XLWorkbook xls = new XLWorkbook(caminho);

            //leitura da plan1, primeira aba do excel.
            IXLWorksheet planilha = xls.Worksheets.First(tabela => tabela.Name == "Plan1");

            //total de linhas. ou utilizar Row().Count(); - analisar a diferença.
            int totalLinhas = planilha.RowCount();

            //PERCORRER CADA LINHA
            for (int i = 2; i <= totalLinhas; i++)
            {
                //CONSULTAR A COLUNA A A PARTIR DE CADA LINHA REPRESENTADA PELO I.
                var nome = planilha.Cell($"A{i}").Value.ToString();

                Console.WriteLine(nome);

                //é necessário criar um if para nao percorrer linhas vazias.

            }

            //novo registro ou substituicao de arquivo existinte.
            planilha.Cell("A3").Value = "Bruno";
            planilha.Cell("B3").Value = "30";
            planilha.Cell("C3").Value = "Nova Especialidade.";

            //salvar o excel com as novas alterações.
            xls.SaveAs(caminho);

            //finalizar a comunicação = referente ao close();
            xls.Dispose();
        }


        class Especialidade
        {
            //prop tab tab

            public string Nome { get; set; }  //get (pegar) o que esta na propriedade.
                                              //set (setar) adicionar/colocar um valor na propriedade

            public int Idade { get; set; }

            public string Descricao { get; set; }

        }

        //funcao que vai retornar um objeto do tipo Especialidade e terá como entrada tipo string (linha).
        static Especialidade ConverterStringParaEspecialidade( string linha)
        {         

            //SPLIT = função que vai dividir uma string a partir de um parametro.
            //retornar um array;

            //campos receberá array de string a partir da divisão que nesse caso foi espaço (' ') 
               //poderemos dividir utilizando ',' ou '.' ou algum caractere que faça sentido no split.
            string[] campos = linha.Split(' ');

            //ARRAY AS POSIÇÕES SEMPRE COMECAM COM ZERO.

            //atribuição das variaveis a partir da posição do array;
            string nome = campos[0];
            int idade = int.Parse(campos[1]);
            string descricao = campos[2];

            //instancia de um novo objeto Especialidade
            Especialidade nova_especialidade = new Especialidade();
            nova_especialidade.Nome = nome;
            nova_especialidade.Idade = idade;
            nova_especialidade.Descricao = descricao;

            //retorno da classe com as propriedades preenchidas.
            return nova_especialidade;


        }

        static void EscreverBuffer(byte[] buffer)
        {
            //conversão dos BYTES para STRING, utilizando a conversão UTF8.
            UTF8Encoding utf8 = new UTF8Encoding();

            string texto = utf8.GetString(buffer);

            Console.Write(texto);

        }
        static void LeituraBytes()
        {

            //LER DADOS LOCAIS.


            // para resolver as barra , podemos colocar duas barra ou colocar um @ no inicio;

            string enderecoDoArquivo = @"C:\Users\Lucas - Senai\Desktop\AULA_06\dados.txt";

            //FILE STREAM.
            //o caminho do arquivo,  o que fazer com o arquivo.
            FileStream fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open);


            //representação de um array com 1024 posições.
            byte[] buffer = new byte[1024]; //1KB;

            //leitura do arquivo com a quantidade todal de 1024 posicoes no array, inicia pelo 0 e vai ler até 1024 BYTES.
            fluxoDoArquivo.Read(buffer, 0, 1024);

            //função que nao possui retorno para entendermos como funciona a leitura.
            EscreverBuffer(buffer);

            //encerra a leitura do arquivo.
            fluxoDoArquivo.Close(); 

        }       
        static void LeituraTxt()
        {

            //LER DADOS LOCAIS.


            // para resolver as barra , podemos colocar duas barra ou colocar um @ no inicio;

            string enderecoDoArquivo = @"C:\Users\Lucas - Senai\Desktop\AULA_06\dados.txt";

            //FILE STREAM.
            //o caminho do arquivo,  o que fazer com o arquivo.
            FileStream fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open);

            //leitor da streamfile, facilita nossa vida.
            StreamReader leitor = new StreamReader(fluxoDoArquivo);

            //leitura de uma linha.
            string linha = leitor.ReadLine();

            //classe Especialidade com nome de nova, recebe o retorno da funcao ConverterStringParaEspecialidade
            Especialidade nova = ConverterStringParaEspecialidade(linha);

            //retorno personalizado da classe que possui as propriedades preenchidas;
            string mensagem = ($"Nome:{  nova.Nome}, Idade: {nova.Idade}, Especialidade: {nova.Descricao}");


            //primeira linha.
            Console.WriteLine(mensagem);

            //finalizar a conexao com o arquivo txt.
            fluxoDoArquivo.Close();
        }
    }
}
