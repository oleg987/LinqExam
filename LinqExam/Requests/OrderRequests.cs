using LinqExam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LinqExam.Requests
{
    public class OrderRequests
    {
        private static readonly IEnumerable<Order> _orders;
        private static readonly IEnumerable<Product> _products;
        private static readonly IEnumerable<Customer> _customers;

        public static readonly IEnumerable<CustomerOrder> _customerOrders;

        static OrderRequests()
        {
            using var ordersFile = new FileStream("orders.json", FileMode.Open);
            _orders = JsonSerializer.Deserialize<IEnumerable<Order>>(ordersFile)!;

            using var productsFile = new FileStream("products.json", FileMode.Open);
            _products = JsonSerializer.Deserialize<IEnumerable<Product>>(productsFile)!;

            using var customersFile = new FileStream("customers.json", FileMode.Open);
            _customers = JsonSerializer.Deserialize<IEnumerable<Customer>>(customersFile)!;

            _customerOrders = MapCustomerOrders();
        }

        private static IEnumerable<CustomerOrder> MapCustomerOrders()
        {
            throw new NotImplementedException();
        }       
    }
}
