using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AcademiaPCD
{
    class Program
    {
        private static readonly Logger _log = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            Console.WriteLine("Academia PCD 2020 - Avanade");            
            Configurar();
            _log.Debug("Debug Academia PCD");
             
            //Declaração de variável numérica
            Console.WriteLine("");
            int inteiro = 2;
            Console.WriteLine("Valor inteiro {0}", inteiro);

            //Declaração de variável text/caracter
            Console.WriteLine("");
            string texto = "Junior é um cara muito legal!";
            Console.WriteLine("Mensagem:" + texto);

            //Operações Matemáticas (Soma/Substração)
            Console.WriteLine("");
            float saldo = 100.20f;
            float saque = 25.20f;
            float deposito = 300.00f;
            Console.WriteLine("Saldo anterior   R$ " + string.Format("{0:#.00}", saldo));
            Console.WriteLine("Valor do saque   R$ " + string.Format("{0:#.00}", saque));
            Console.WriteLine("Saldo atual      R$ " + string.Format("{0:#.00}", (saldo - saque)));
            Console.WriteLine("Depósito         R$ " + string.Format("{0:#.00}", deposito));
            Console.WriteLine("Novo Saldo       R$ " + string.Format("{0:#.00}", ((saldo - saque)+deposito)));

            //Operações de Divisão (Convert DataType)
            Console.WriteLine("");
            float divisor = 22.4f;
            float dividendo = 2.1f;
            int divisao = (int)(divisor / dividendo);
            Console.WriteLine("Divisão:         " + divisao);

            //Operações de Multiplicação (Format DataType)
            Console.WriteLine("");
            decimal operador1 = 3.001m;
            decimal operador2 = 2.050m;
            float resultado = (float)(operador1 * operador2);
            Console.WriteLine("Multiplicação:   " + resultado.ToString("#.000"));


            //Rotina de repetição (FOR)
            Console.WriteLine("\nFOR Loop");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("     Index: {0}", i);
            }

            //Rotina de repetição(WHILE)
            Console.WriteLine("\nWHILE Loop");
            var count = 10;
            while (count >= 0)
            {
                Console.WriteLine("     Counter: {0}", count);
                count--;
            }

            //Rotina de repetição (DO-WHILE)
            Console.WriteLine("\nDO-WHILE Loop");
            Random random = new Random();
            bool flag = true;
            int number1 = 0;
            int number2 = 0;
            int resto = 0;
            do
            {                
                number1 = random.Next(1, 100);
                Console.WriteLine("Number 1   : {0}", number1);                
                number2 = random.Next(1, 100);                
                Console.WriteLine("Number 2   : {0}", number2);
                resto = number1 % number2;
                Console.WriteLine("Resto      : {0}", resto);
                Console.WriteLine("\n");
                flag = (resto == 0) ? false : flag;

            } while (flag.Equals(true));


            //Regra condicional IF
            Console.WriteLine("");
            var texto1 = "";
            string texto2 = "";
            if (texto1.Equals(texto2))
            {
                Console.WriteLine("São iguais");
            }
            else
            {
                Console.WriteLine("São diferentes");
            }

            //Listagem simples
            Console.WriteLine("");
            List<string> listagem = new List<string>();
            listagem.Add("Bruna");
            listagem.Add("Junior");
            listagem.Add("Vinicius");
            listagem.Add("Sergio");
            listagem.Add("Edson");
            listagem.Add("Henrique");
            listagem.Add("Raine");
            listagem.Add("Danilo");
            listagem.Add("Poli");
            foreach (var nome in listagem)
            {
                Console.WriteLine("Nome: {0}", nome);
            }

            //Construção de strings
            StringBuilder builder = new StringBuilder();
            builder.Append("Linha 1 |");
            builder.Append("Linha 2 |");
            builder.Append("Linha 3 |");
            builder.Append("Linha 4 |");
            var result = builder.ToString();
            Console.WriteLine("String Builder = {0}", result);

            //Listagem com classe
            List<Aluno> alunos = new List<Aluno>();
            Aluno aluno1 = new Aluno();
            aluno1.nome = "Bruna";
            aluno1.idade = 10;
            alunos.Add(aluno1); //Exercicio 2

            Aluno aluno2 = new Aluno();
            aluno2.nome = "Junior"; //Exercicio 1
            aluno2.idade = 12;
            alunos.Add(aluno2);

            Aluno aluno3 = new Aluno();
            aluno3.nome = "Danilo";
            aluno3.idade = 14;
            alunos.Add(aluno3);

            foreach (var aluno in alunos) //Exercicio 4
            {
                Console.WriteLine("Nome: {0} e {1} anos", aluno.nome, aluno.idade);
            }

            //alunos.Remove(aluno3); //Exercicio 3

            //Listagem com ordem ascendente (Nome)
            Console.WriteLine("");
            List<Aluno> ordenada = new List<Aluno>();
            for (int i = 1; i < 27; i++)
            {
                int unicode = (i+96);
                char character = (char)unicode;
                string text = character.ToString();
                Aluno aluno = new Aluno();
                aluno.nome = "Aluno "+ text.ToUpper();
                aluno.idade = i;
                ordenada.Add(aluno);
            }

            IEnumerable<Aluno> nomes = ordenada.OrderBy(a => a.nome);
            foreach (var item in nomes)
            {
                Console.WriteLine("Nome: {0}", item.nome);
            }

            //Listagem com ordem descendente (Idade)
            Console.WriteLine("");
            IEnumerable<Aluno> idades = ordenada.OrderByDescending(a => a.idade);
            foreach (var item in idades)
            {
                Console.WriteLine("Idade: {0}", item.idade);
            }

            //Métodos Matemáticos
            Console.WriteLine("");
            int valor_da_soma = Somar(2, 6);
            Console.WriteLine("Método Soma        :{0}", valor_da_soma);

            int valor_da_sub = Subtrair(5, 9);
            Console.WriteLine("Método Subtrair    :{0}", valor_da_sub);

            decimal valor_da_div = Dividir(90, 45);
            Console.WriteLine("Método Dividir     :{0}", valor_da_div);

            decimal valor_da_mult = Multiplicar(101, 41);
            Console.WriteLine("Método Multiplicar :{0}", valor_da_mult);

            //Convertendo variável
            Console.WriteLine("");
            string variavel = "1234";
            int conversao = Convert.ToInt32(variavel);
            Console.WriteLine("Conversão          :{0}", conversao);

            //Tentar converter uma variável
            int number = -1;
            string letras = "ABC";
            //string numeros = "123";

            if (int.TryParse(letras, out number))
            {
                Console.WriteLine("Conversão OK {0}", texto);                
            }
            else
            {
                Console.WriteLine("Conversão ERROR");
                _log.Error("Conversão ERROR");
            }

            //Tratamento de exceção
            Console.WriteLine("");
            try
            {
                int valor1 = 10;
                int valor2 = 0;

                int div = valor1 / valor2;
                Console.WriteLine("Divisão :{0}", div);
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um exceção: {0}", e.Message);
            }

            //Expressões regulares
            var textToTest = "hell0 w0rld";
            var regEx = "\\d"; //Inteiro
                        
            var validacao = Regex.IsMatch(textToTest, regEx, RegexOptions.None);
            if (validacao)
            {
                Console.WriteLine("Achou!");
            }
            else
            {
                Console.WriteLine("Não achou!");
            }

            //Execução de Método
            Calcular(4, 10, 20);

            //Construção do Arrays
            Console.WriteLine("");
            int[] academia_pcd = new int[10];
            for (int i = 0; i < 10; i++)
            {
                academia_pcd[i] = i + 1;
            }
            Console.WriteLine("Posições do array: {0}", academia_pcd.Length);

            //Exibição do Arrays
            Console.WriteLine("");
            for (int i = 0; i < academia_pcd.Length; i++)
            {
                int pos2 = academia_pcd[2];
                Console.WriteLine("Valores do array: {0}", academia_pcd[i]);
            }

            PagarFolha(167);

            List<int> funcionarios = new List<int>();

            funcionarios.Add(10);
            funcionarios.Add(2);
            funcionarios.Add(119);
            PagarFolha(funcionarios);


            //var ex = new NullReferenceException("Ocorreu um exceção de NULL");
            //throw ex;

            Console.ReadKey();                
        }

        public static void Calcular(int tipo, int val1, int val2)
        {
            //Regra condicional SWITCH
            decimal resultado = 0;
            switch (tipo)
            {
                case 1:
                    resultado = Somar(val1, val2);
                    break;
                case 2:
                    resultado = Dividir(val1, val2);
                    break;
                case 3:
                    resultado = Multiplicar(val1, val2);
                    break;
                case 4:
                    resultado = Subtrair(val1, val2);
                    break;
            }

            Console.WriteLine("Tipo escolhido é {0}, e o resutado foi: {1}", tipo, resultado );
        }

        public static int Somar(int valor1, int valor2)
        {
            int resultado = valor1 + valor2; 
            return resultado;
        }

        public static int Subtrair(int valor1, int valor2)
        {
            int resultado = valor1 - valor2;
            return resultado;
        }

        public static decimal Dividir(int valor1, int valor2)
        {
            decimal resultado = (decimal)valor1 / valor2;
            return resultado;
        }

        public static decimal Multiplicar(int valor1, int valor2)
        {
            decimal resultado = (decimal)valor1 * valor2;
            return resultado;
        }

        public static void Configurar()
        {
            var config = new NLog.Config.LoggingConfiguration();
           
            var logfile = new NLog.Targets.FileTarget("logfile") { FileName = "file.txt" };
            var logconsole = new NLog.Targets.ConsoleTarget("logconsole");
            var logerro = new NLog.Targets.FileTarget("logerro") { FileName = "erro.txt" };

            config.AddRule(LogLevel.Info, LogLevel.Fatal, logconsole);
            config.AddRule(LogLevel.Debug, LogLevel.Fatal, logfile);
            config.AddRule(LogLevel.Error, LogLevel.Fatal, logerro);

            LogManager.Configuration = config;

        }

        public static void PagarFolha(int Funcionario)
        {
            Console.WriteLine("Pagamento da Folha {0}", Funcionario);
        }

        public static void PagarFolha(List<int> Funcionario)
        {
            Console.WriteLine("Pagamento da Folha {0}", Funcionario.Count());
        }
    }
}
