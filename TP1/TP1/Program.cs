using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Program
    {
        static void Main(string[] args) 
           
        {

            Console.WriteLine("Quelle est votre nom de personnage ?");

            string name;

            name = Console.ReadLine();

          




            int age = 0;

            Console.WriteLine("Quelle est sont Age ?");

            

            while (age <=0) {
                Console.Write("Saisir votre age");
                age = Convert.ToInt32(Console.ReadLine());
            }

            //if (age < 0)
            //{
            //    return;
            //}




            char sexe = (' ');

            Console.WriteLine("Quelle est sont Sexe ?");
            Console.WriteLine("Ecrivez H (pout Homme) ou F (pour Femme)");

//            if(sexe != 'H') {
//                if (sexe != 'F') {
//                    Console.Write("Vous devez saisir H ou F");
//                    return;
//                }
//}
//            }

            while (sexe != 'H' && sexe != 'F')
            {
                Console.WriteLine("Saisir votre sexe");
                sexe = Convert.ToChar(Console.ReadLine());

            }    
            


           
            
            
            




            String race;

            String Elfe;

            String Humain;

            String Orc;

            int pv = 100;

            int res = 100;

            int for_phy = 100;

            int power_magic = 100;


            Console.WriteLine("Quelle est sa Race ?");
            Console.WriteLine("Vous pouvez choisir entre : \n\nElfe : peu de PV et de résistance mais une forte puissance magique !\n\nOrc: Beaucoup de PV et une bonne résistance mais peu offensif\n\nou\n\nHumain: PV et résistance moyenne mais beaucoup de force physique");


            race = Console.ReadLine();
            


           


            if (race == "Elfe")
            {
                pv = pv +50;
                res = res +20;
                for_phy = for_phy +10;
                power_magic = power_magic +200;

            }


            if (race == "Orc")
            {
                pv = pv +400;
                res = res +200;
                for_phy = for_phy +10;
                power_magic = power_magic -30;

            }


            if (race == "Humain")
            {
                pv = pv +100;
                res = res +50;
                for_phy = for_phy +150;
                power_magic = power_magic +50;

            }

            
            if (race == "Elfe")

            {
                Console.WriteLine("-----------------PERSONNAGE---------------\n\nNom : " + name + "\n\nAge : " + age + "\n\nSexe : " + sexe + "\n\nRace : " + race + "\n\nPoint de vie : " + pv + "\n\nResistance : " + res + "\n\nForce Physique : " + for_phy + "\n\nPuissance magique : " + power_magic);

            }
            else if (race == "Orc")
            {
                Console.WriteLine("-----------------PERSONNAGE---------------\n\nNom : " + name + "\n\nAge : " + age + "\n\nSexe : " + sexe + "\n\nRace : " + race + "\n\nPoint de vie : " + pv + "\n\nResistance : " + res + "\n\nForce Physique : " + for_phy + "\n\nPuissance magique : " + power_magic);

            }
            else if (race == "Humain")
            {
                Console.WriteLine("-----------------PERSONNAGE---------------\n\nNom : " + name + "\n\nAge : " + age + "\n\nSexe : " + sexe + "\n\nRace : " + race + "\n\nPoint de vie : " + pv + "\n\nResistance : " + res + "\n\nForce Physique : " + for_phy + "\n\nPuissance magique : " + power_magic);

            }
            else return;



              





































        }
    }
}
