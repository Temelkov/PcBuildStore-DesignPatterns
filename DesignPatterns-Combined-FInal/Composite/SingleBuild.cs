using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns_Combined_FInal.Composite
{
    public class SingleBuild : BuildBase
    {
        public SingleBuild(string name, double min_price, double max_price) : base(name, min_price,max_price)
        {

        }

        public override double CalculateMinPrice()
        {
            Console.WriteLine($"{_name} build official price is between {_min_price} and {_max_price}lv.");

            return _min_price;
        }
    }
}
