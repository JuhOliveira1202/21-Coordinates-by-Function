using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioFunção
{
    public class Mapa
    {
        public static void CriarMapa(int l, int c, int[,] mapa)
        {
            for(int i = 0; i < l; i++)
            {
                for(int j = 0; j < c; j++)
                {
                    mapa[i, j] = 0;
                }
            }
        }

        public static void EscreverMapa(int l, int c, int[,] mapa)
        {
            for(int i =0; i < l; i++)
            {
                for(int j = 0; j < c; j++)
                {
                    Console.Write(mapa[i, j]);
                }
                Console.Write("\n");
            }
        }
    }
}
