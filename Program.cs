using System;
using System.Collections.Generic;

namespace AcademiaPCD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Academia PCD 2020 - Avanade");

            //int valor = 2;
            //Console.WriteLine("Valor inteiro {0}", valor);

            //string texto = "Junior é um cara muito legal!";
            //Console.WriteLine("Mensagem:"+ texto);

            //float saque = 3.4f;
            //Console.WriteLine("Valor do saque:" + saque);
            //Console.WriteLine("Valor Total:" + (saque + valor));

            //float divisor = 22.4f;
            //float dividendo = 2.1f;
            //int resultado = (int)(divisor / dividendo);
            //Console.WriteLine("Valor Divisão:" + resultado);

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("Valor do índice: {0}", i);
            //}

            //while (true)
            //{

            //}

            //do
            //{

            //} while (true);

            //var texto1 = "";
            //string texto2 = "";

            //if (texto1.Equals(texto2))
            //{
            //    Console.WriteLine("São iguais");
            //} else
            //{
            //    Console.WriteLine("São diferentes");
            //}


            //List<string> listagem = new List<string>();
            //listagem.Add("Bruna");
            //listagem.Add("Junior");
            //listagem.Add("Vinicius");
            //listagem.Add("Sergio");
            //listagem.Add("Edson");
            //listagem.Add("Henrique");
            //listagem.Add("Raine");
            //listagem.Add("Danilo");
            //listagem.Add("Poli");            

            //foreach (var nome in listagem)
            //{
            //    Console.WriteLine("Nome: {0}", nome);
            //}

            List<Aluno> alunos = new List<Aluno>();


            Aluno aluno1 = new Aluno();
            aluno1.nome = "Bruna";
            aluno1.idade = 10;
            alunos.Add(aluno1); // Exercicio 2

            Aluno aluno2 = new Aluno();
            aluno2.nome = "Junior"; // Exercicio1 aluno2.nome = "Mamedes";
            aluno2.idade = 12;
            alunos.Add(aluno2);

            Aluno aluno3 = new Aluno();
            aluno3.nome = "Danilo";
            aluno3.idade = 14;
            alunos.Add(aluno3);

            alunos.Remove(aluno3); // Exercicio3
            //IEnumerable<Aluno> lista1 = alunos.OrderBy(a => a.nome);
            //IEnumerable<Aluno> lista2 = alunos.OrderBy(a => a.idade);

            foreach (var aluno in alunos) // Exercicio4
            {
                Console.WriteLine("Nome: {0} e {1} anos", aluno.nome, aluno.idade);
            }
            int valor_da_soma = Somar(1, 2);
            Console.WriteLine("Soma :{0}", valor_da_soma);

            //int valor_da_sub = Subtrair(1, 2);
            //Console.WriteLine("Subtração :{0}", valor_da_sub);

            //decimal valor_da_div = Dividir(1, 2);
            //Console.WriteLine("Divisão :{0}", valor_da_div);

            //decimal valor_da_mult = Multiplicar(1, 2);
            //Console.WriteLine("Multiplicação :{0}", valor_da_mult);

            //string valor_texto = "1234";
            //int cout = Convert.ToInt32(valor_texto);
            //cout++;
            //Console.WriteLine("Count :{0}", cout);


            //try
            //{
            //    int valor1 = 10;
            //    int valor2 = 0;

            //    int div = valor1 / valor2;
            //    Console.WriteLine("Divisão :{0}", div);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Exceção: {0}", e.Message);
            //}

            //int number = 0;
            //string texto = "ABC";

            //if (int.TryParse(texto, out number)) {
            //    Console.WriteLine("Conversão OK {0}", texto);
            //} else
            //{
            //    Console.WriteLine("Conversão ERROR");
            //}

            //StringBuilder str = new StringBuilder();
            //str.Append("Linha 1");
            //str.Append("Linha 2");
            //str.Append("Linha 3");
            //str.Append("Linha 4");

            //var text = str.ToString();
            //Console.WriteLine("String Builder = {0}", text);


            //var textToTest = "hello w0rld";
            //var regularExpression = "\\d";

            //var result = Regex.IsMatch(textToTest, regularExpression, RegexOptions.None);
            //if (result)
            //{
            //    Console.WriteLine("Achou!");
            //} else
            //{
            //    Console.WriteLine("Não achou!");
            //}


            //MetodoMatematico(4, 10, 20);


            //int[] academia_pcd = new int[10];

            //for (int i = 0; i < 10; i++)
            //{
            //    academia_pcd[i] = i + 1;
            //}

            //for (int i = 0; i < academia_pcd.Length; i++)
            //{
            //    int pos2 = academia_pcd[2];
            //    Console.WriteLine("Valores do array: {0}", academia_pcd[i]);               
            //}




            Console.ReadKey();                
        }

        public static void MetodoMatematico(int tipo, int val1, int val2)
        {
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

    }
}
