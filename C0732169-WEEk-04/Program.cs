using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0732169_WEEk_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Countryside c = new Countryside();
            c.run();
            c.Travel();
            Console.ReadLine();
        }
    }

    class Village
    {
        public bool isAstrilde = false;
        public Village nextVillage;
        public Village prevVillage;
        public string villageName;
    }

    class Countryside
    {
        Village Toronto, Ajax, Maple;

        public Village CurrentVillage { get; private set; }

        public void run()
        {
            Maple = new Village();
            Maple.villageName = "Maple";
            Toronto = new Village();
            Toronto.villageName = "Toronto";
            Ajax = new Village();
            Ajax.isAstrilde = true;
            Ajax.villageName = "Ajax";

            Maple.nextVillage = Toronto;
            Toronto.nextVillage = Ajax;
            Ajax.nextVillage = null;
        }

        public void Travel()
        {
            CurrentVillage = Toronto;
            while (true)
            {
                if (CurrentVillage.isAstrilde)
                    Console.WriteLine("Astrilde is in : " + CurrentVillage.villageName);
                else
                    CurrentVillage = CurrentVillage.nextVillage;
            }
        }
    }
}