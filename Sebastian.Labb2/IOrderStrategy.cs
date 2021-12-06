using ITHS_CC_Labb2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sebastian.Labb2
{
    public interface IOrderStrategy
    {
        bool Process(Order order);
    }
}
