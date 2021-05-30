using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns_Combined_FInal.Composite
{
    public interface IBuildOperations
    {
        void Add(BuildBase build);
        void Remove(BuildBase build);
    }
}
