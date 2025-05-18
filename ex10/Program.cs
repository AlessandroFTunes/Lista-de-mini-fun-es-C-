public class ex10MediaNota {
    public static void Rodar() {
        Parametros();
    }
    public static void Parametros(){
        int i=1;
        double nota =0;
        do {
                    Console.WriteLine ($" Me informe a nota {i}º: ");
                    nota=double.Parse(Console.ReadLine());
                    Aprovacao(nota);
                    i++ ;
                     if (nota>10){
                        --i;
                    }
         } while(nota > 0);


    }

    public static void Aprovacao(double nota ) {
        if (nota <= 4.9 && nota > 0) {
            Console.WriteLine("Conceito D");
        } 
        else if (nota <= 6.9 && nota > 4.9) {
            Console.WriteLine("Conceito C");
        }
        else if (nota <= 8.9 && nota > 6.9) {
            Console.WriteLine("Conceito B");
        }
        else if (nota <= 10 && nota > 8.9) {
            Console.WriteLine("Conceito A");
        }
        else {
            Console.WriteLine("Nota Invalida");

        }
    }


}