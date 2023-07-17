using ExercícioFunção;
using System;
class Program
{
    public static void Main(string[] args)
    {
        int[,] m = new int[4, 4];
        Mapa.CriarMapa(4, 4, m);
        Mapa.EscreverMapa(4, 4, m);
    }
}