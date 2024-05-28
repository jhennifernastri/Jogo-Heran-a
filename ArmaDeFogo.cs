using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoHeranca
{
    internal class ArmaDeFogo:Arma // : os : indica que armadefogo herda as caracteristicas e metodos de arma
    {
        //private int alcance;
        public int Alcance {get; } //read only,  nao pode alterar o alcance

        public ArmaDeFogo(string nome, int alcance)
              :base(nome) //caso o construtor arma nao tenha parametro, a base tb não terá, ou seja: base()
        {   
            this.Alcance = alcance;
            this.Dano = 5;
        }

    }
}
