using System;

namespace informações_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            bool resposta = false;
            do
            {
                Console.WriteLine("Escreva seu nome: ");
                string respostaNome = Console.ReadLine();

                if (respostaNome == "")
                {
                    Console.WriteLine("Por favor, insira um nome existente");
                    respostaNome = Console.ReadLine();
                }
                else
                {
                    resposta = true;
                }

            } while (resposta == false);

            bool idadee = false;
            do
            {
                Console.WriteLine("Insira sua Idade: ");
                int idade = int.Parse(Console.ReadLine());

                if (idade >= 150)
                {
                    Console.WriteLine("Idade incorreta!!!");
                }
                else
                {
                    idadee = true;
                }

            } while (idadee == false);

            bool salario = false;
            do
            {
                Console.WriteLine("Insira seu salário: ");
                int dinheiro = int.Parse(Console.ReadLine());

                if (dinheiro <= 0)
                {
                    Console.WriteLine("Salário incorreto");
                    Console.WriteLine("Insira um salário maior que R$0: ");
                }
                else
                {
                    salario = true;
                }

            } while (salario == false);

            Console.WriteLine("Digite seu estado civil s(solteiro(a)), c(casado(a)), v(viuvo(a)), d(divorciado(a)): ");
            estadoCivil = Console.ReadLine();
            estadoCivilV = false;

            while (estadoCivil == "s" || estadoCivil == "S")
            {
                estadoCivilV = true;
            }
        }
    }
}
