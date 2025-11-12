using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Countries
{
    class Countries
    {
        private string[] countries;
        private int[] population;
        static void Main(string[] args)
        {
            Countries country = new Countries();
            country.Insert();
            country.SortNames();
            Console.WriteLine("==Sorted Alphabetical==");
            country.print();
            country.SortByPopulation();
            Console.WriteLine("\n==Sorted By Population==");
            country.print();
        }
        
        public void Insert()
        {
            try
            {
                Console.WriteLine("Insert Quantity Of Countries To Add:\n");
                int index = Convert.ToInt32(Console.ReadLine());
                countries = new string[index];
                population = new int[index];
                for (int count = 0; count < countries.Length; count++)
                {
                    Console.WriteLine("Insert Name Of Country\n");
                    countries[count] = Console.ReadLine();
                    Console.WriteLine("Insert exactly number of population\n");
                    population[count] = Convert.ToInt32(Console.ReadLine());
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Insert A Valid Number",ex.Message);
                return;
            }
            
        }

        public void SortNames()
        {
            for (int cont = 0; cont < countries.Length; cont++)
            {
                for (int cont2 = 0; cont2 < countries.Length - 1 - cont; cont2++)
                {
                    if (countries[cont2].CompareTo(countries[cont2 + 1]) > 0)
                    {
                        (countries[cont2], countries[cont2 + 1]) = (countries[cont2 + 1], countries[cont2]);
                        (population[cont2], population[cont2 + 1]) = (population[cont2 + 1], population[cont2]);
                    }
                }
            }
        }

        public void SortByPopulation()
        {
            for (int cont = 0; cont < countries.Length; cont++)
            {
                for (int cont2 = 0; cont2 < countries.Length - 1 - cont; cont2++)
                {
                    if (population[cont2] < population[cont2 + 1])
                    {
                        (countries[cont2], countries[cont2 + 1]) = (countries[cont2 + 1], countries[cont2]);
                        (population[cont2], population[cont2 + 1]) = (population[cont2 + 1], population[cont2]);
                    }
                }
            }
        }
        public void print()
        {
            for (int cont = 0; cont < countries.Length; cont++)
            {
                Console.WriteLine("===>Country: "+countries[cont]+"===>Population: "+population[cont]);
            }
        }
    }
}