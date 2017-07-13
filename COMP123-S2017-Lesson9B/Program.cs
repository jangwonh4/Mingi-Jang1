using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Tom Tsiliopoulos
 * Date: July 11, 2017
 * Description: Demo for Lesson 9
 * Version: 0.7 - Modified Driver class to implement SuperHero
 */

namespace COMP123_S2017_Lesson9B
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHero superHero = new SuperHero("Super Dude", 20);
            superHero.AddPower("Spider Climbing", 50);
            superHero.AddPower("Webcasting", 40);
            Console.WriteLine(superHero.ToString());

            SuperVillain superVilliain = new SuperVillain("SuperVilliain  Joker", 30);
            superVilliain.AddPower("Poison Gas", 80);
            superVilliain.AddPower("Sleep Gas", 90);

            Console.WriteLine(superVilliain.ToString());
            Console.WriteLine("Malice : {0}", superVilliain.Malice);

        }
    }
}
