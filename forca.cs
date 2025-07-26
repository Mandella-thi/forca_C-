using System; // Importa funcionalidades básicas

class forca // Define a classe principal
{
    static void Main(string[] args) // Método principal, ponto de entrada do programa
    {
        console.WriteLine("Jogo da Forca");
        string[] adivinhar = { "abacaxi", "Banana", "manga", "laranja", "limao" };
        Random permuta = new Random();
        string palavra = adivinhar[permuta.Next(adivinhar.Lenghth)];
        string ocultapalavra = new string('_', palavra.Lenghth);
        int chances = 6;
        bool acerta = false;
        while (chances > 0 && !acerta)
        {
            
         } 

        
    }
}