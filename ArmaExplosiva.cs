using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoHeranca
{
    internal sealed class ArmaExplosiva:ArmaDeFogo  //sealed é classe final
    {
        public double RaioDeExplosao { get; }

        public ArmaExplosiva(string nome, int alcance, double raioExplosaoM2)
                            :base(nome, alcance)
        {
            this.RaioDeExplosao = raioExplosaoM2;
        }


    }
}
