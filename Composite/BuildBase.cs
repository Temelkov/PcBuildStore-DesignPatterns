using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns_Combined_FInal.Composite
{
    public abstract class BuildBase
    {
        protected string _name;
        protected double _min_price;
        protected double _max_price;

        public BuildBase(string name, double min_price, double max_price)
        {
            this._name = name;
            this._min_price = min_price;
            this._max_price = max_price;
        }

        public abstract double CalculateMinPrice();
    }
}
