using Sebastian.Labb2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHS_CC_Labb2
{
    public class OrderService
    {
        private readonly List<IOrderStrategy> _strategies = new();
        private readonly IEmailService _emailService;
        private readonly ILogger _logger;

        public OrderService(IEmailService emailService, ILogger logger)
        {
            _strategies.Add(new NormalOrderStrategy());
            _strategies.Add(new QuickOrderStrategy());
            _strategies.Add(new LightningOrderStrategy());
            _emailService = emailService;
            _logger = logger;
        }
        public void ProcessOrder(Order order)
        {
            var strategyToRun = _strategies.FirstOrDefault(x => x.Process(order) == true);

            _logger.LogMessage("Attempting to process order with ID " + order.ID);
            if (strategyToRun.Process(order) == true)
            {
                _logger.LogMessage("Succesfully processed order with ID " + order.ID);
                _emailService.SendEmail(order.Email, order.ID);
            }
            else
                _logger.LogMessage("FAILED ORDER: Could not ship order with ID " + order.ID);
        }
    }
}
