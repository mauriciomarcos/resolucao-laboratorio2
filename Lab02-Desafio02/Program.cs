using Lab02_Desafio02.Classes;
using System;
using System.Collections.Generic;

namespace Lab02_Desafio02
{
    class Program
    {
        private static int totalCachorro, totalGato, totalPeixe, totalDesconhecido;

        static void Main()
        {
            var animais = CriarAnimais();
            ComputarAnimais(animais);
            ExibirTotais2();
        }

        private static List<Animal> CriarAnimais()
        {
            return new List<Animal>()
            {
                new Animal("Totó", "Cachorro".ToUpper()),
                new Animal("Miau", "Gato".ToUpper()),
                new Animal("Roar", "Leão".ToUpper()),
                new Animal("Miau2", "Gato".ToUpper()),
                new Animal("Miau3", "Gato".ToUpper()),
                new Animal("Panda", "Urso".ToUpper()),
                new Animal("Panda2", "Urso".ToUpper()),
                new Animal("Nemo", "Peixe".ToUpper()),
                new Animal("Nemo1", "Peixe".ToUpper())
            };
        }

        private static void ComputarAnimais(List<Animal> animais)
        {
            foreach (var animal in animais)
            {
                switch (animal.Tipo)
                {
                    case "CACHORRO":
                        totalCachorro++;
                        break;
                    case "GATO":
                        totalGato++;
                        break;
                    case "PEIXE":
                        totalPeixe++;
                        break;
                    case "LEÃO":
                        totalPeixe++;
                        break;
                    default:
                        totalDesconhecido++;
                        break;
                }
            }
        }

        private static void ExibirTotais2()
        {
            Console.WriteLine($"Total de Cahorros: { totalCachorro }");
            Console.WriteLine($"Total de Gatos: { totalGato }");
            Console.WriteLine($"Total de Animais Desconhecidos: { totalDesconhecido }");
        }
    }
}
