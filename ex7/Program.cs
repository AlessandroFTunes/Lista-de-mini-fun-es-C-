﻿public class ex7Notas{
    static void Rodar(){
    Aprovacao();
    }

static void Aprovacao(){
double nota =0 , nota_anterior=0;
int i=0;
  do {
    Console.WriteLine("Me fale a nota: ");
    nota = double.Parse(Console.ReadLine());
    
    if (nota >= 6) {
        nota_anterior = nota + nota_anterior;
        ++i;
    }

} while (nota >= 0);

    double media =nota_anterior/i;
    Console.WriteLine($"Foram aprovados {i} alunos" );
    Console.WriteLine("A media das notas foi "+media);
}




}