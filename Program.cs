﻿using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>(){
               "Mercury",
               "Mars",
               };

            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");

            List<string> lastPlanets = new List<string>(){
                "Uranus",
                "Neptune"
            };
            List<string> rockyPlanets = new List<string>()
            {

            };
            planetList.GetRange(0, 4).rockyPlanets;

            lastPlanets.Add("Pluto");
            planetList.AddRange(lastPlanets);

            foreach (string planet in planetList)
                Console.WriteLine(planet);
            Console.WriteLine(rockyPlanets);
        }
    }
}
