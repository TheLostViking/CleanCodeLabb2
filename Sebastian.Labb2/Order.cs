
namespace Sebastian.Labb2
{
    public class Order
    {
        public Guid ID { get; set; }
        public int TotalPrce { get; set; }
        public OrderStatus Priority { get; set; }
        public string Email { get; set; }
    }

    public enum OrderStatus
    {
        Normal,
        Quick,
        LightningSpeed
    }
}
