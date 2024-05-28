using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoHeranca
{
    internal abstract class Arma:ItemInventario   // abstração referente apenas a arma
    {
        public string Nome { get; set; } //read only, sem set, nao tem como alterar o nome 
        //protected int Dano { get; set; }

        public int Dano { get; set; }

        private static int contador = 0; // estatico -> compartilhado entre instancias, pois ele não pertence a cada instancia, e sim pertence a classe.


        public Arma(string nome) 
        {
            contador++; //nao é possivel utilizr o this. (não temos ref de instancia, não se refere ao objeto, e sim a classe, devido ao static.
            this.Nome = nome;
            this.Dano = 1;
        }

        public void Atirar()
        { 
            Dano++;
        }

        public static int getContador()
        { 
            return contador; 
        }


    }
}
