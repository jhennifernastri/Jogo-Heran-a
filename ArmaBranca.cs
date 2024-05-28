using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoHeranca
{
    internal sealed class ArmaBranca:Arma
    {
        public ArmaBranca(string nome)               //2 pontos é a notação para referenciar herança
                        :base(nome)                  //a base é para referenciar o atributo da classe mae
        {

        }


    }
}
