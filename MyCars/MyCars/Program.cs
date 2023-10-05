using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
﻿using Domain;

namespace MyCars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Voiture> voitures= 
            Console.WriteLine("Hello, World!");

            

        }

        public void EnregistrerVoitures(List<Voiture> voitures)
        {
            string fileName = "listeVoitures.json";
            string jsonString = JsonSerializer.Serialize(voitures);
            File.WriteAllText(fileName, jsonString);
        }
    }
}