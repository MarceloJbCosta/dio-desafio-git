using System; 

class DIO   {

    static void Main(string[] args) { 

    int x = int.Parse(Console.ReadLine());
            
      if(x % 2 == 0 ){
        System.Console.WriteLine($"Proximo numero Par será: {x +2}");
      }else{
       System.Console.WriteLine($"Proximo numero Par será: {x +1}");
      }

    }

}

