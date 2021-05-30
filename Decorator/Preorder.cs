using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns_Combined_FInal.Decorator
{
    public class Preorder : OrderBase
    {
        public override double CalculateTotalOrderPrice()
        {
            Console.WriteLine("Calculating the total price of a preorder build");
            return build.Sum(x => x.Price) * 0.9;
        }
    }
}