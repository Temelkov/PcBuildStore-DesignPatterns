using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns_Combined_FInal;
using DesignPatterns_Combined_FInal.Builder;
using DesignPatterns_Combined_FInal.Composite;

namespace DesignPatterns_Combined_FInal.Decorator
{
    public abstract class OrderBase
    {
        protected List<BuildedPC> build = new List<BuildedPC>
        {
            new BuildedPC {Name = "Aetheltrith Build", Price = 1900},
            //new BuildedPC {Name = "Aetheltrith Build", Price = 1900},
            //new BuildedPC {Name = "Aetheltrith Build", Price = 1900},
        };

        public abstract double CalculateTotalOrderPrice();
    }
}
