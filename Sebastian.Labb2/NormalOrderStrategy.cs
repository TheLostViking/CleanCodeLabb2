
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sebastian.Labb2
{
    public class NormalOrderStrategy : IOrderStrategy
    {
        public bool Process(Order order)
        {
            // Some logic we don't care about
            if (order.Priority == OrderStatus.Normal)
                return true;
            return false;
        }
    }
}
