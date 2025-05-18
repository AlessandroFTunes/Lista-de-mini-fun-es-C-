public class Ex8 {
    static void Rodar (){
        Parametros();
    }
static void Parametros(){
        Console.WriteLine (" me fale o numero: ");
        double numero = double.Parse(Console.ReadLine());
        Primo(numero);
}
    public static bool Primo( double numero){

        if (numero <= 1)
        {
            Console.WriteLine("Não é primo");
            return false;
        }

        for (int i = 2; i < numero; i++)
        {
            if (numero % i == 0)
            {
                Console.WriteLine("Não é primo");
                return false;
            }
        }

        Console.WriteLine("É primo");
        return true;

}
}