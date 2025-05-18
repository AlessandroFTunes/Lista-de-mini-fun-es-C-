public class Ex8 {
    static void Rodar (){
        Parametros();
    }
static void Parametros(){
        
        Console.WriteLine (" A hora que iniciou o jogo: ");
        int horaInicio = int.Parse(Console.ReadLine());
        Console.WriteLine (" O minuto que iniciou o jogo: ");
        int minutoInicio = int.Parse(Console.ReadLine());
        Console.WriteLine (" A hora que terminou o jogo: ");
        int horaFim = int.Parse(Console.ReadLine());
        Console.WriteLine (" O minuto que terminou o jogo: ");
        int minutoFim = int.Parse(Console.ReadLine());
        Tempo(horaInicio,minutoInicio,horaFim,minutoFim);
}
    static void Tempo(int iniciohr, int iniciomin, int fimhr, int fimmin) {
        // Calcula o tempo total em minutos
        int inicioTotal = iniciohr * 60 + iniciomin;
        int fimTotal = fimhr * 60 + fimmin;

        int duracao;
        if (fimTotal >= inicioTotal) {
            duracao = fimTotal - inicioTotal;
        } else {
            // jogo passou da meia-noite
            duracao = (24 * 60 - inicioTotal) + fimTotal;
        }

        int horas = duracao / 60;
        int minutos = duracao % 60;

        Console.WriteLine($"O jogo durou {horas} hora(s) e {minutos} minuto(s).");
    }


}