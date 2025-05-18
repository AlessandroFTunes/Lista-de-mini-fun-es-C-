public class VerificarNumero{
    public static void Rodar() {
        Parametros();
    }

static void Parametros(){
        Console.WriteLine (" me fale o salario: ");
        double salario = double.Parse(Console.ReadLine());
         Console.WriteLine (" me fale o indice: ");
        double indice = double.Parse(Console.ReadLine());
        VerificarPositivoNegativo(salario,indice);
}
 static void VerificarPositivoNegativo(double salario,double indice){
        salario = salario * indice;
        Console.WriteLine("O salario Reajustado é: "+salario);
    }
}