using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    public  class Starbucks : IMakeACoffee
    {
        public bool CheckIngridentAvalability()
        {
            return true;
        }
        string IMakeACoffee.CoffeeMaking(int suggerPerSpone, int CoffeePark)
        {
            throw new NotImplementedException();
        }
    }
    ///<Summary>
    ///stub class of class Starbucks.
    ///<summary>
    public class stubstarbucks : IMakeACoffee
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
