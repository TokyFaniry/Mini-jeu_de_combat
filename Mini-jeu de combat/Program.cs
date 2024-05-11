// See https://aka.ms/new-console-template for more information
using Mini_jeu_de_combat;
using System;
using System.Security.Cryptography.X509Certificates;


internal class Program
{
    private static void Main(string[] args)
    {
        Guerrier guerrier1 = new Guerrier("Toky",200,300);
        Guerrier guerrier2= new Guerrier("Faniry",200,400);

        guerrier1.Afficher();
        guerrier2.Afficher();

        guerrier1.LancerAttaqueSur(guerrier2);
        guerrier2.ActiverSoin();

        guerrier1.Afficher();
        guerrier2.Afficher();

        guerrier2.LancerAttaqueAvecDefenseSur(guerrier1);
        guerrier2.ActiverSoin();




    }
}

