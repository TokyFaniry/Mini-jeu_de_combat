using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_jeu_de_combat
{
    internal class Guerrier
    {
        public string Nom { get; set; }
        public int Attaque { get; set; }
        public int Defense { get; set; }
        public int Sante { get; set; }
        public int Mana { get; set; }

        public Guerrier(string nom, int attaque, int defense, int sante)
        {
            Nom = nom;
            Attaque = attaque;
            Defense = defense;
            Sante = sante;
            Mana = 100;
        }
        public Guerrier ( string nom, int attaque , int defense)
        {
            Nom=nom; 
            Attaque=attaque; 
            Defense=defense; 
            Sante=1000; 
            Mana=100;
        }

        public Guerrier() { }

        public void LancerAttaqueSur(Guerrier g2)
        {
            Console.WriteLine(this.Nom + " Attaque...");
            g2.Sante = g2.Sante - this.Attaque;
            Console.WriteLine(" Attaquant: " + this.Nom + " Sante : " + this.Sante);
            Console.WriteLine(" Defense: " + g2.Nom + " Sante : " + g2.Sante);
        }

        public void LancerAttaqueAvecDefenseSur(Guerrier g2)
        {
            Console.WriteLine(this.Nom + " Attaque...");
            if (this.Attaque>g2.Defense)
            {
                g2.Sante = g2.Sante-this.Attaque;
                Console.WriteLine(" Attaque...");
            }
            else
            {
                this.Sante = this.Sante- (g2.Defense - this.Attaque);
                Console.WriteLine(" Attaque echouer");
            }
            Console.WriteLine(" Attaquant: " + this.Nom + " Sante : " + this.Sante);
            Console.WriteLine(" Defense: " + g2.Nom + " Sante : " + g2.Sante);
        } 
        public void ActiverSoin()
        {
            if (this.Mana > 10)
            {
                Console.WriteLine(this.Nom + " Soin...");
                this.Sante = this.Sante + 10;
                this.Mana = this.Mana - 10;
            }
            else
            {
                Console.WriteLine("Vous n'avez pas assez de Mana");
            }
            Console.WriteLine(this.Nom + " Sante: " + this. Sante);
        }
        public void Afficher()
        {
            Console.WriteLine("Nom: "+this.Nom
                +" Attaque: "+this.Attaque+
                " Defense: "+this.Defense+
                " Sante: "+this.Sante);
        }


    }      
}
