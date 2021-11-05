using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThree
{
    class Customer
    {
        private string firstName;
        private string lastName;
        private string email;
        private List<Order> orders;

        public Customer(string firstName, string lastName, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.orders = new List<Order>();
        }

        public string Name
        {
            get => firstName + " " + lastName;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }

        public List<Order> Orders
        {
            get => orders;
        }

        public void addOrder(string productName, int quantity)
        {
            orders.Add(new Order(productName, quantity, DateTime.Now));
        }
    }
}
