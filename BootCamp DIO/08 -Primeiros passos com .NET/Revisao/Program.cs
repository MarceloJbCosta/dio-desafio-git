using System;

namespace Revisao{
    class Program{

        static void Main(string[] args)
        {

            string opcaoUser = respostaUser();

            while (opcaoUser != "x")
            {
                switch (opcaoUser)
                {
                    case "1":
                    break;

                    case "2":
                    break;

                    case "3":
                    break;

                    default:
                    throw new ArgumentOutOfRangeException();
                }
                opcaoUser = respostaUser();
            }
        }

        private static string respostaUser()
        {
            Console.WriteLine("informe a opção desejada");
            Console.WriteLine();
            Console.WriteLine("1- Inserir novo Aluno");
            Console.WriteLine("2- Listar Aluno");
            Console.WriteLine("3- Calcular Media Geral");
            Console.WriteLine();    
            Console.WriteLine("X- Sair");
            Console.WriteLine();


            string opcaoUser = Console.ReadLine();
            return respostaUser();
        }
    }
}


