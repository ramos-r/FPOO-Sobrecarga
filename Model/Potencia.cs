namespace CA_Sobrecarga_Potencia.Model
{
    public class Potencia
    {
        public int valor1 { get; set; } 
        public int valor2 { get; set; }

        //Criar 2 métodos para calcular a potência
        //1. Método que recebe 1 parâmetro - (valor1)
        //valor ^ valor

        public double CalcularPot(int valor1)
        {
            return System.Math.Pow(valor1, valor1);
        }

        //2. Método que recebe 2 parâmetros - (valor1, valor2)
        //valor1 ^ valor2

        public double CalcularPot(int valor1, int valor2)
        {
            return System.Math.Pow(valor1, valor2);
        }
    }
}