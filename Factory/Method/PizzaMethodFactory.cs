using Products.Pizzas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public abstract class PizzaMethodFactory
    {
        public Pizza CreatePizza()
        {
            return CookPizza();
        }

        public abstract Pizza CookPizza();
        

    }

    public class PizzaSalamiFactory : PizzaMethodFactory
    {
        public override Pizza CookPizza()
        {
            return new SalamiPizza();
        }
    }

    public class PizzaMargheritaFactory : PizzaMethodFactory
    {
        public override Pizza CookPizza()
        {
            return new MargheritaPizza();
        }
    }

}
