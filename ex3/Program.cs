 public class ex3LadodoTriangulo{
    public static void Rodar () {
    ladodoTriangulo();
    
    }
      static void ladodoTriangulo() {
   {
        double primeiro_lado = 0, segundo_lado = 0, terceiro_lado = 0;

        do
        {
            Console.Write("Me fale o primeiro lado: ");
            primeiro_lado = double.Parse(Console.ReadLine());

            Console.Write("Me fale o segundo lado: ");
            segundo_lado = double.Parse(Console.ReadLine());

            Console.Write("Me fale o terceiro lado: ");
            terceiro_lado = double.Parse(Console.ReadLine());

                       if (primeiro_lado > 0 && segundo_lado > 0 && terceiro_lado > 0)
            {
                VerificarLado(primeiro_lado, segundo_lado, terceiro_lado);
            }
            else
            {
                Console.WriteLine("Lados inválidos. Encerrando o programa.");
            }

           

        } while (primeiro_lado > 0 && segundo_lado > 0 && terceiro_lado > 0);
    }}
    static void VerificarLado(double lado1, double lado2, double lado3) {

    Console.WriteLine("Iniciando teste");
if (lado1 == lado2 && lado2 == lado3) {
    Console.WriteLine("O triângulo é Equilátero");
}
else if (
    (lado1 == lado2 && lado1 != lado3) ||
    (lado1 == lado3 && lado1 != lado2) ||
    (lado2 == lado3 && lado2 != lado1)
) {
    Console.WriteLine("O triângulo é Isósceles");
}
else if (lado1 != lado2 && lado2 != lado3 && lado1 != lado3) {
    Console.WriteLine("O triângulo existe mas não possui classificação específica");
}
else {
    Console.WriteLine("O triângulo não existe");
}
    }}


    /*static void VerificarLado ( double primeiro_lado,double segundo_lado,double terceiro_lado ) {
        var (primeiro_lado, segundo_lado, terceiro_lado) = ladodoTriangulo();

    if (primero_lado == segundo_lado && segundo_lado == terceiro_lado){
        Console.WriteLine(" o triangulo é Equilátero");
    }
    else if (
  (primeiro_lado == segundo_lado && primeiro_lado != terceiro_lado) ||
  (primeiro_lado == terceiro_lado && primeiro_lado != segundo_lado) ||
  (segundo_lado == terceiro_lado && segundo_lado != primeiro_lado)
) {
        Console.WriteLine(" o triangulo é Isósceles");
    }
    else if (primero_lado != segundo_lado && segundo_lado != terceiro_lado){
        Console.WriteLine(" o triangulo existe mas não possui classificação");
    }
    else {
        Console.WriteLine(" o triangulo não existe");
    }
    }
 }*/