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
        int chances = 8;
        int erra = 0;
        bool acerta = false;
        string[] forca1 = new string[] { @"
 + ------+ 
         |
         |
         |
         |
         |
+--------+", @"
 + ------+
 |       |
         |
         |
         |
         |
+--------+", @"
  + ------+
  |      |
  o      |
         |
         |
         |
+--------+", @"
 + ------+
 |       |
 o       |
 |       |
         |
         |
+--------+", @"
  + ------+
  |      |
  o      |
 /|      |
         |
         |
+--------+", @"
  +------+
  |      |
  o      |
 /|\     |
         |
         |
+--------+ ",@"
  +------+
  |      |
  o      |
 /|\     |
 /       |
         |
+--------+ ", @"
  +------+
  |      |
  o      |
 /|\     |
 / \     |
         |
+--------+ "};
    while (chances > 0 && !acerta)
    {
      console.WriteLine(forca1[erra]);
      console.WriteLine("A palavra da vez é: " + ocultapalavra);
      console.writeLine("Numero de chances: " + chances);
      console.write("Chute uma letra: ");
      char letra = Console.readline();
      letra = char.ToLower(letra);
            string entrada = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(entrada))
            {
                Console.WriteLine("Entrada inválida. Tente novamente.");
                continue;
            }
            char letra = char.ToLower(entrada[0]);

            bool letraCorreta = false;

            for (int i = 0; i < palavra.Length; i++) { }


        } 

        
    }
}