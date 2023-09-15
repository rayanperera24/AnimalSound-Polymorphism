using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animal_soudn_polymorpishm
{

    class animal
    {

        public virtual void animalsound()
        {
            Console.WriteLine("animal Makes a Sound");
        }
    }

    class pig:animal
    {

        public override void animalsound()
        {
            Console.WriteLine("oink....oink");
        }

    }

    class dog:animal
    {
        public override void animalsound()
        {
            Console.WriteLine("woof.....woof");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            animal animal = new animal();
            animal pig = new pig();
            animal dog = new dog();
            pig.animalsound();
            dog.animalsound();




            Console.ReadKey();



        }
    }
}
