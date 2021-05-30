using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns_Combined_FInal
{
    public class Shop
    {
        // Builder uses a complex series of steps

        public void Construct(PCBuilder pcBuilder)
        {
            pcBuilder.BuildMotherboard();
            pcBuilder.BuildProcessor();
            pcBuilder.BuildRam();
            pcBuilder.BuildVideo();
            pcBuilder.BuildPS();
            pcBuilder.BuildCase();
        }
    }
}
