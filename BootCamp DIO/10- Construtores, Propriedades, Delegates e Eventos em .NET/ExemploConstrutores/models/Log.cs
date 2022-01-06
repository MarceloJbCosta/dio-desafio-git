namespace ExemploConstrutores.models
{
    public class Log
    {
        private static Log _log;
        private Log()
        {
            
        }
        public static log GetInstance()
        {
            if(_log == null){
                _log = new Log();
            }
            return _log;

        }
    }
}



using System;
using ExemploConstrutores.models;

namespace ExemploConstrutores
{
    class Program
    {
        static void Main(String[] args)
        {   
            log log = Log.GetInstance(); 
            //Pessoa p1 =  new Pessoa("Marcelo", "Costa");
            //p1.Apresentar();

        
            
        }

    }
}