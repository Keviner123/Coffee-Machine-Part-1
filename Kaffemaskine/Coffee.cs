using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskine
{
    public class Coffee
    {
        private int amount;

        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public Coffee()
        {
            this.Amount = 0;
        }
    }
}
