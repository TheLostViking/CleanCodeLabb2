using ITHS_CC_Labb2;

OrderService orderService = new OrderService();

Order slowOrder = new Order
{
    ID = Guid.NewGuid(),
    Email = "slowEmail@example.com",
    Priority = OrderStatus.Normal,
    TotalPrce = 100,
};

orderService.ProcessOrder(slowOrder);  