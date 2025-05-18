using System;
public class ex1Potencia{
    public static void Rodar () {
        Pot();
    }

    public static void Pot() {
        Console.Write("fala um num ai");
        double n1 = double.Parse(Console.ReadLine());
                Console.Write("fala um expoente ai");
        double expoente =double.Parse(Console.ReadLine());
        
        double resultado =1;
for(double i = 0 ; expoente>i; ++i ){
   resultado = resultado * n1;
   
}   
Console.Write($" O resultado = { resultado} ");
    }
}



