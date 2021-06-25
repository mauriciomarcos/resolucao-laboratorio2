using System.Linq;

namespace Lab02_Desafio02.Classes
{
    public class Animal
    {
        private string[] tiposValidos = {"CACHORRO", "GATO", "PEIXE"};
        private string tipo;

        public Animal(string nome, string tipo)
        {
            Nome = nome;
            Tipo = tipo;
        }

        //public string Nome { get; private set; }

        public string Tipo 
        {
            get 
            {
                return this.tipo;
            }
            set 
            {
                if (tiposValidos.Contains(value))
                    this.tipo = value;
                else
                    this.tipo = "Animal não identificado";
            } 
        }

        //public string Especie { get; set; }
    }
}
