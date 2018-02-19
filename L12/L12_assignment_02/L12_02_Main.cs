///@author Hannu Oksman
///@version 2018-02-19
///<summary>
///Toteuta sovellus, jolla voit hallita ostoskärryn sisältöä.Ostettavalta tuotteelta riittää käsitellä nimi ja hinta.
///Toteuta Product-luokka ja lisää pääohjelmassa esimerkiksi List-tietorakenteeseen muutamia Product-luokan oliota. 
///Tulosta lopuksi kokoelman sisältö.
/// </summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L12_assignment_02
{
    class L12_02_Main
    {
        static void Main(string[] args)
        {
            //creating collection
            List<Product> cart = new List<Product>();
            cart.Add(new Product("Milk", 1.4));
            cart.Add(new Product("Beer", 2.2));
            cart.Add(new Product("Butter", 3.2));
            cart.Add(new Product("Cheese", 4.2));

            //printing collection
            Console.WriteLine("All products in collection:");
            foreach (Product p in cart)
            {
                string s = p.PrintProduct();
                Console.WriteLine("- product : {0}", s);
            }
        }
    }
}
/*
 * prints
 * All products in collection:
 * - product : Milk 1,4 e
 * - product : Beer 2,2 e
 * - product : Butter 3,2 e
 * - product : Cheese 4,2 e
*/
