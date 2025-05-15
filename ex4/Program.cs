 public class Branco{
 public static void Main () {
    double vagneris = Negao();
    Console.WriteLine("" + vagneris);
 }

 public static double Negao (){
double maior_numero = 434;
double menor_numero =152;

double resto = maior_numero % menor_numero;
while (resto !=0)
        {
            menor_numero = menor_numero % resto;
            
            if (menor_numero < resto)
            {
                maior_numero = resto;
                resto = menor_numero;
                menor_numero = maior_numero;

            }

            
        }
        return menor_numero;

 }
 }