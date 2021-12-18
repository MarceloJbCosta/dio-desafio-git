namespace exemploPOO.Models
{
    public class Retangulo
    {
        private double  comprimento;
        private double largura;

        public void DefinirValores(double comprimento, double largura){
            if(comprimento > 0 && largura > 0){
            this.comprimento = comprimento;
            this.largura = largura; 
            }
            else{
                System.Console.WriteLine("Digite um valor Valido");
            }
        }

        public double obterArea(){
            return comprimento * largura;
        }
    }
}