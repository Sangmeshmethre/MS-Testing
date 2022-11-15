using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    public  class FakeStarbucksStore : IMakeACoffee
    {
        public bool CheckIngridentAvalability()
        {
            return true;
        }
        string IMakeACoffee.CoffeeMaking(int suggerPerSpone, int CoffeePark)
        {
            return "Your Order is Recieved:";
        }
    }
}
