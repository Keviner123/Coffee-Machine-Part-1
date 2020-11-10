using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskine
{
    /// <summary>
    /// The department that holds the filter and the coffee powder
    /// </summary>
    public class CoffeDepartment
    {

        private Filter cFilter;

        public Filter CFilter
        {
            get { return cFilter; }
            set { cFilter = value; }
        }

        private CoffeePowder cPowder;

        public CoffeePowder CPowder
        {
            get { return cPowder; }
            set { cPowder = value; }
        }


        public CoffeDepartment()
        {
            CFilter = null;
            cPowder = new CoffeePowder();
        }

        public void Fill()
        {
            this.cPowder.Amount = 100;
            this.cFilter = new Filter();
        }

        public bool HasPowder()
        {
            return (this.cPowder != null);
        }
        public bool HasFilter()
        {
            return (this.cFilter != null);
        }
        
        public void Empty()
        {
            this.cFilter = null;
            this.cPowder = null;
        }
    }
}
