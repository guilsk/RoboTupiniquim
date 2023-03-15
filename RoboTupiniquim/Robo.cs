using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RoboTupiniquim
{
    internal class Robo
    {
        public string nome;
        public int[] posInicial;
        public char orientação;

        public Robo(string nome, int[] posInicial, char orientação)
        {
            this.nome = nome;
            this.posInicial = posInicial;
            this.orientação = orientação;
        }


    }
}
