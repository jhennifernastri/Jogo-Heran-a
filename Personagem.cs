using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoHeranca
{
    internal class Personagem
    {

        public string Nome {  get; set; }
        public string Time { get; set; }

        //private List<Arma> armas; //Inventario

        //private List<Acessorio> acessorios; //Inventario

        private List<ItemInventario> itens;

        public Personagem()
        {

            this.itens = new List<ItemInventario>();
            //this.armas = new List<Arma>();
            //this.acessorios = new List<Acessorio>();

        }

        public void adicionarInventario(ItemInventario itemInventario)
        {
            this.itens.Add(itemInventario);
        }

        //public void adicionarArma(Arma arma)
        //{
        //    this.armas.Add(arma);
        //}

        //public void adicionarAcessorio(Acessorio acessorio)
        //{
        //    this.acessorios.Add(acessorio);
        //}

        //public void adicionarInventario(Arma arma)
        //{
        //    this.armas.Add(arma);
        //}


        //public void adicionarInventario(Acessorio acessorio)
        //{
        //    this.acessorios.Add(acessorio);
        //}


    }
}
