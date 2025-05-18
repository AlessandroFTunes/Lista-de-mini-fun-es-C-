public class ex5VerificarNumero{
    public static void Rodar () {
        VerificarPositivoNegativo();
    }

 static bool VerificarPositivoNegativo(){

        Console.WriteLine (" me fale um numero!");
        int numero = int.Parse(Console.ReadLine());

        if (numero>=0) {
            Console.WriteLine("Positivo");
            return true;
        }
        else {
            Console.WriteLine("negativo");
            return false;
        }
    }
}