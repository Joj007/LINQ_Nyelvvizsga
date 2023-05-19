using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Nyelv> sikeres = new List<Nyelv>();
            List<Nyelv> sikertelen = new List<Nyelv>();


            //2
            foreach (string s in File.ReadAllLines("sikeres.csv").Skip(1))
            {
                sikeres.Add(new Nyelv(s));
            }

            foreach (string s in File.ReadAllLines("sikertelen.csv").Skip(1))
            {
                sikertelen.Add(new Nyelv(s));
            }




            //3
            int bekertEv;
            do
            {
                bekertEv = int.Parse(Console.ReadLine());
            } while (!(bekertEv<2018&&bekertEv>2008));


            //4
            double arany;
            double legnagyobbArany=0;
            string legnagyobbNyelv="";
            int index = 0;
            foreach (var item in sikeres)
            {
                if (item.Evek[bekertEv - 2009]!=0)
                {
                    arany = sikertelen[index].Evek[bekertEv - 2009] / item.Evek[bekertEv - 2009];
                }
                else
                {
                    arany = 0;
                }

                if (arany > legnagyobbArany) { 
                    legnagyobbArany = arany;
                    legnagyobbNyelv = item.Nev;
                }
                index++;
            }

            Console.WriteLine(legnagyobbNyelv);















            Console.ReadKey();
        }
    }
}
