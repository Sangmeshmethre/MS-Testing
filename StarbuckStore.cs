using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    public class StarbuckStore
    {
        private readonly IMakeACoffee service;
         public StarbuckStore(IMakeACoffee service)
        {
            this.service = service;
        }
        public string OrderCoffer(int suggerPerspone, int CoffeeCount)
        {
            if(service.CheckIngridentAvalability())
            {
                return service.CoffeeMaking(suggerPerspone, CoffeeCount);
            }
            else
            {
                return " Sorry Coffee Is Not Avalable.";
            }
        }
    }
}
