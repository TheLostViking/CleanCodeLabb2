using Sebastian.Labb2;

OrderService orderService = new OrderService(new EmailService(), new Logger());

Order slowOrder = new Order
{
    ID = Guid.NewGuid(),
    Email = "slowEmail@example.com",
    Priority = OrderStatus.Normal,
    TotalPrce = 100,
};

orderService.ProcessOrder(slowOrder);