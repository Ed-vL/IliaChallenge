using System;

namespace IliaStore.Models
{
    public class Order
    {
        public int Id { get; set; }

        public int Price {get; set;}

        public DateTime CreatedAt {get; set;}

        public enum Status {
            Approved,
            Shipping,
            Delivered
        };
    }
}