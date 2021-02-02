using System;
using Pedido.Entities.Enum;
using System.Collections.Generic;
using System.Text;

namespace Pedido.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> ItemsList { get; set; } = new List<OrderItem>();

        public Order()
        {

        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItems(OrderItem item)
        {
            ItemsList.Add(item);
        }

        public void RemoveItems(OrderItem item)
        {
            ItemsList.Remove(item);
        }

        public double Total()
        {
            double sum = 0;

            foreach(OrderItem items in ItemsList)
            {
                sum += items.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy"));
            sb.Append("Order Status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.AppendLine(Client.Nome + " " + Client.BirthDate + " - " + Client.Email);
            sb.AppendLine("Order items:");
            foreach(OrderItem items in ItemsList)
            {
                sb.Append(items.Product.Name + ", " );
                sb.Append("Quantity: " + items.Quantity + ", ");
                sb.AppendLine("Subtotal: " + items.SubTotal());
            }
            sb.Append("Total price: " + Total());

            return sb.ToString();

        }
    }
}
