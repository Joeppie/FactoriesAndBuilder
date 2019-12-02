using Products.Pizzas;
using System;

namespace Factory.Simple
{
    public class SimplePizzaFactory
    {

        public Pizza CreatePizza()
        {
            return new Pizza();
        }

    }
}
