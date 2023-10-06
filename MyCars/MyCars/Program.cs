using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
﻿using Domain;

namespace MyCars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Voiture> mesVoitures;
            string userInput = "";

            do
            {
                Console.WriteLine("Que voulez vous faire");
                Console.WriteLine("1. quitter");
                Console.WriteLine("2. Ajouter une voiture");
                Console.WriteLine("3. Consulter la liste des voitures");                
                userInput = Console.ReadLine();
                
                
                


            } while (!userInput.Equals("1"));

            

        }

        public static Voiture AjouterVoiture()
        {
            string modelleDeVoiture;
            string marqueDeVoiture;
            int prixDeLaVoiture;

            Console.WriteLine("Merci d'indiquer le prix de la voiture");

            while (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Prix incorrect");
            }
            return null;
        }

        public static void EnregistrerVoitures(List<Voiture> voitures)
        {
            string fileName = "listeVoitures.json";
            string jsonString = JsonSerializer.Serialize(voitures);
            File.WriteAllText(fileName, jsonString);
        }
    }
}