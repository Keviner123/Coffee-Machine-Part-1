using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskine
{
    /// <summary>
    /// The compartment containing the water
    /// </summary>
    public class WaterTank
    {
        private int amount;

        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public WaterTank()
        {
            this.amount = 0;
        }

        public void Fill()
        {
            this.Amount = 100;
        }

    }
}
