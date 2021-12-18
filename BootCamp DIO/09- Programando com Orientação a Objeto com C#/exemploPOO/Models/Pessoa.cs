using System;

namespace exemploPOO.Models
{
    public class Pessoa
    {
        public string nome {get; set;}
        public int idade {get; set;}

        public void apresetar(){
            Console.WriteLine($"Ola meu nome é {nome} e tenho {idade} anos de idade");
        }
    }
}