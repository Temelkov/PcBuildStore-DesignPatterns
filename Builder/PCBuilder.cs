using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns_Combined_FInal
{
    public abstract class PCBuilder
    {
        public PC pc;

        public PC PC
        {
            get { return pc; }
        }

        // Abstract build methods
        public abstract void BuildMotherboard();
        public abstract void BuildProcessor();
        public abstract void BuildRam();
        public abstract void BuildVideo();
        public abstract void BuildPS();
        public abstract void BuildCase();
    }
}
