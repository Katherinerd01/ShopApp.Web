using ShopApp.DAL.Core;

namespace ShopApp.DAL.Entities
{
    public class Shippers : Person
    {
        public int ShipperId { get; set; }
        public string? Name { get; set; }
    }
}
