using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoHeranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArmaBranca faca = new ArmaBranca("Faca");

            faca.Nome = "Metralhadora";
            faca.Atirar();

            

            //ArmaDeFogo pistola = new ArmaDeFogo("P250", 50);
            //pistola.Dano = 5;

            ArmaDeFogo metralhadora = new ArmaDeFogo("M29", 150);
            metralhadora.Dano = 35;

            ArmaExplosiva bomba = new ArmaExplosiva("BomberMan", 5, 3);

            //Console.WriteLine(bomba.getContador()); a classe arma não podria ser static para a bomba poder acessar o getContador();
            Console.WriteLine(Arma.getContador());  

            Personagem p1 = new Personagem();
            p1.Nome = "Persona1";
            p1.Time = "Vilao";
            //p1.adicionarArma(faca);
            p1.adicionarInventario(faca);


            Acessorio A1 = new Acessorio();

            p1.adicionarInventario(bomba);


        }
    }
}
