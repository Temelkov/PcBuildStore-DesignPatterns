using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns_Combined_FInal.Builder
{
    public class ComputerBuilder : PCBuilder
    {
        public ComputerBuilder()
        {
            pc = new PC("DESK COMPUTER");
        }

        public override void BuildCase()
        {
            pc["case"] = "Thermal Take";
        }

        public override void BuildMotherboard()
        {
            pc["motherboard"] = "ASUS TEK";
        }

        public override void BuildProcessor()
        {
            pc["processor"] = "INTEL CORE I5";
        }

        public override void BuildPS()
        {
            pc["ps"] = "ASUS TEK";
        }

        public override void BuildRam()
        {
            pc["ram"] = "SAMSUNG 2x4GB";
        }

        public override void BuildVideo()
        {
            pc["video"] = "Integrated UHD 620";
        }
    }
}
