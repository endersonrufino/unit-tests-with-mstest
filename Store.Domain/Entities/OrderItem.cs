using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flunt.Notifications;
using Flunt.Validations;

namespace Store.Domain.Entities
{
    public class OrderItem : Notifiable
    {
        public OrderItem(Product product, int quantity)
        {
            AddNotifications(
                new Contract()
                .Requires()
                .IsNotNull(product, "Product", "Produto inválido")
                .IsGreaterThan(quantity, 0, "Quantity", "A quantidade de produtos deve ser maior que zero")
            );

            Product = product;
            Price = Product != null ? Product.Price : 0;
            Quantity = quantity;
        }

        public Product? Product { get; private set; }
        public decimal Price { get; private set; }
        public int Quantity { get; private set; }

        public decimal Total()
        {
            return Price * Quantity;
        }
    }
}