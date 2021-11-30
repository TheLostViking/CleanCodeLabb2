using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHS_CC_Labb2
{
    public class OrderService
    {
        public void ProcessOrder(Order order)
        {
            bool s = false;

            LogMessage("Attempting to process order with ID " + order.ID);
            if (order.Priority == OrderStatus.Normal)
            {
                s = ProcessOrderNormally(order);
                LogMessage("Succesfully processed order with ID " + order.ID);
                SendNotifictionEmail(order.Email, order.ID);
            }
            else if (order.Priority == OrderStatus.Quick)
            {
                s = ProcessOrderQuickly(order);
                LogMessage("Succesfully processed order with ID " + order.ID);
                SendNotifictionEmail(order.Email, order.ID);
            }
            else if (order.Priority == OrderStatus.LightningSpeed)
            {
                s = ProcessOrderInLigtningSpeed(order);
                LogMessage("Succesfully processed order with ID " + order.ID);
                SendNotifictionEmail(order.Email, order.ID);
            }
            else
            {
                s = false;
            }

            if (!s)
            {
                LogMessage("FAILED ORDER: Could not ship order with ID " + order.ID);
            }
        }

        private void SendNotifictionEmail(string email, Guid ID)
        {
            // Some email sending logic we don't care about
            LogMessage($"Notification sent to email {email} for order {ID}");
        }

        private void LogMessage(string message)
        {
            Console.WriteLine($"{DateTime.Now}: {message}");
        }

        private bool ProcessOrderNormally(Order order)
        {
            // Some logic we don't care about,
            return true;
        }
        private bool ProcessOrderQuickly(Order order)
        {
            // Some logic we don't care about
            return true;
        }
        private bool ProcessOrderInLigtningSpeed(Order order)
        {
            // Some logic we don't care about
            return true;
        }

    }
}
