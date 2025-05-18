public class ex2MediaSalarial{
    public static void Rodar () {
    media();
    
    }
    public static void media() {
        Console.Write("me fala quantos pessoas existe na sua casa/cidade: ");
        double cidadao=double.Parse(Console.ReadLine());
        double salario_total=0;
    for(double i= cidadao ; i>0 ; --i){
            Console.Write("me fala os salarios: ");
            double salario=double.Parse(Console.ReadLine());
            salario_total=salario+salario;
    }
    double media = salario_total/cidadao;

    Console.WriteLine("A media dos salarios é"+ media);
    }

    }