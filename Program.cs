using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//using LatihanOOP_Abstrak.AbstrackClass;
using LatihanOOP_Abstrak.Interface; 

namespace LatihanOOP_Abstrak
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Makanan Makanan;

            Makanan = new Kentang();
            Makanan.Dimasak();

            Console.WriteLine();
            Makanan = new Kangkung();
            Makanan.Dimasak();*/

            IMakanan Makanan;

            Makanan = new Kentang();
            Makanan.Dimasak();

            Console.WriteLine();
            Makanan = new Kangkung();
            Makanan.Dimasak();

            Console.ReadKey ();
        }
    }
}
