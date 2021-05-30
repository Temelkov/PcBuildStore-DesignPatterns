using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns_Combined_FInal.Composite
{
    public class CompositeBuild : BuildBase, IBuildOperations
    {
        private List<BuildBase> _builds;

        public CompositeBuild(string name, double min_price, double max_price) : base(name, min_price, max_price)
        {
            _builds = new List<BuildBase>();
        }

        public void Add(BuildBase build)
        {
            _builds.Add(build);
        }

        public void Remove(BuildBase build)
        {
            _builds.Remove(build);
        }
       
        public override double CalculateMinPrice()
        {
            double total = 0.00;

            Console.WriteLine($"{_name} and price range from which you can choose:");

            foreach (var build in _builds)
            {
                total += build.CalculateMinPrice();
            }
            
            return total;
        }
    }
}
