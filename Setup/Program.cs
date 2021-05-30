using DesignPatterns_Combined_FInal;
using DesignPatterns_Combined_FInal.Builder;
using DesignPatterns_Combined_FInal.Composite;
using DesignPatterns_Combined_FInal.Decorator;
using System;

namespace Setup
{
    class Program
    {
        static void Main(string[] args)
        {
            //BUILDER PATTERN
            PCBuilder builder;

            Shop shop = new Shop();

            builder = new LaptopBuilder();
            shop.Construct(builder);
            builder.PC.Show();

            //COMPOSITE PATTERN

            //Console.WriteLine("Brands from which you can build your PC:");
            CompositeBuild componetBrands = new CompositeBuild("Hardware brands", 0,0);

            SingleBuild asus = new SingleBuild("Asus", 200, 800);
            SingleBuild asroc = new SingleBuild("Asroc", 500, 600);
            SingleBuild msi = new SingleBuild("MSI", 300, 700);
            SingleBuild gigabyte = new SingleBuild("Gigabyte", 187, 380);
            componetBrands.Add(asus);
            componetBrands.Add(asroc);
            componetBrands.Add(msi);
            componetBrands.Add(gigabyte);
            Console.WriteLine();
            CompositeBuild softwareBrands = new CompositeBuild("Software brands", 0,0);
            SingleBuild ms = new SingleBuild("Microsoft", 200, 680);
            softwareBrands.Add(ms);
            componetBrands.Add(softwareBrands);
            Console.WriteLine($"The minimum price from which you can build PC is: {componetBrands.CalculateMinPrice()}");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine();

            //DECORATOR PATTERN

            Order order = new Order();
            Console.WriteLine(order.CalculateTotalOrderPrice());

            Preorder preorder = new Preorder();
            Console.WriteLine(preorder.CalculateTotalOrderPrice());
        }
    }
}
