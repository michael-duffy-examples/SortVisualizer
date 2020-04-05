using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortVisualizer
{
    public interface ISortEngine
    {
        void NextStep();
        bool IsSorted();

        void ReDraw();
    }
}
