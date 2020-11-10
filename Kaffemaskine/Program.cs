using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskine
{
    class Program
    {
        static void Main(string[] args)
        {
            //We create a new coffemachine 
            CoffeeMachine MyCoffeeMachine = new CoffeeMachine();

            //We fill both compartments up
            MyCoffeeMachine.Water.Fill();
            MyCoffeeMachine.Department.Fill();

            //We brew the coffee and check the status
            Console.WriteLine(MyCoffeeMachine.MakeCoffee());

            //Then we go ahead and check how many cups are brewed
            Console.WriteLine("Cups in the machine: "+ MyCoffeeMachine.CoffeeCupsAvailable.Count);

            //Then we empty the machine
            Console.WriteLine("Emptying the filter");
            MyCoffeeMachine.Department.Empty();

            //And check if we can brew a cup more
            Console.WriteLine(MyCoffeeMachine.MakeCoffee());
            Console.ReadKey();
        }
    }
}
