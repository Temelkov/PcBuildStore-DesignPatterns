using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns_Combined_FInal
{
    public class PC
    {
        private string _pcType;
        private Dictionary<string, string> _components = new Dictionary<string, string>();

        //Construct
        public PC(string pcTpe)
        {
            this._pcType = pcTpe;
        }

        //Index
        public string this[string key]
        {
            get { return _components[key]; }
            set { _components[key]=value; }
        }

        public void Show()
        {
            Console.WriteLine($"Personal computer type: {_pcType}");
            Console.WriteLine("Specifications:");
            Console.WriteLine($"Motherboard: {_components["motherboard"]}");
            Console.WriteLine($"Processor: {_components["processor"]}");
            Console.WriteLine($"RAM: {_components["ram"]}");
            Console.WriteLine($"Video: {_components["video"]}");
            Console.WriteLine($"Power Supplay: {_components["ps"]}");
            Console.WriteLine($"Case: {_components["case"]}");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------");
        }
    }
}
