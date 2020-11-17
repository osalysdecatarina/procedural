using System;

namespace jeux_chifumi
{
    class Program
    {
        static void Main(string[] args)
        {
            int nbot;
            int nut;
            int res;
            Console.WriteLine("Jeu du 0-2 \nBot, choisis un nombre entre 0 et 2"); //Intro 
            Random nrand = new Random(); // Déclaration d'une variable aléatoire 
            nbot = nrand.Next(0, 3); // L'ordinateur choisit une variable aléatoire
            Console.WriteLine("Le nombre choisi par le bot est: " + nbot + "\nChoisissez à présent un nombre entre 0 et 2"); // Vérification et demande à l'utilisateur
            nut = int.Parse(Console.ReadLine()); // Définition de la variable "nut" comme le chiffre choisi par l'utilisateur 
            if (nbot < nut)
            {
                res = nut - nbot;
            }
            else if (nut < nbot) 
            {
                res = nbot - nut;
            }

           
            
        }
    }
}
