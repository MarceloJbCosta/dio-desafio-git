using System;

using exemploPOO.Models;

namespace exemploPOO{
    class Program{
        static void Main(string[] args){
            
        Retangulo r = new Retangulo();
        r.DefinirValores(30.00, 40.00);
        System.Console.WriteLine($"Area do Retangulo {r.obterArea()}");



         //Aula Abstracao   
        //     Pessoa p1 = new Pessoa();
        //     p1.nome = "Marcelo Costa";
        //     p1.idade = 33;
        //     p1.apresetar();
        }
    }
}
