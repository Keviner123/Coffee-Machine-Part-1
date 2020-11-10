using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskine
{

    public class CoffeeMachine
    {

        private WaterTank water;

        public WaterTank Water
        {
            get { return water; }
            set { water = value; }
        }

        private List<Coffee> coffeeCupsAvailable;

        public List<Coffee> CoffeeCupsAvailable
        {
            get { return coffeeCupsAvailable; }
            set { coffeeCupsAvailable = value; }
        }

        private CoffeDepartment department;

        public CoffeDepartment Department
        {
            get { return department; }
            set { department = value; }
        }

        public CoffeeMachine()
        {
            this.Water = new WaterTank();
            this.CoffeeCupsAvailable = new List<Coffee>();
            this.Department = new CoffeDepartment();
        }

        public string MakeCoffee()
        {
            //Check that the machine has the appropriate water level, filter and capacity to brew additional coffee
            if (this.Water.Amount != 0 && this.Department.HasFilter() && this.Department.HasPowder() && CoffeeCupsAvailable.Count == 0)
            {
                //Add brewed coffee
                for (int i = 0; i < 5; i++)
                {
                    this.CoffeeCupsAvailable.Add(new Coffee());

                    //Subtract the amount of water used for the coffee
                    this.water.Amount -= 20;

                    //Check if enough water is available for one more cup
                    if(this.water.Amount < 20)
                    {
                        break;
                    }
                }
                return ("Successfully brewed coffee");
            }
            return ("Error check water, filter and coffepowder");
        }
    }
}
