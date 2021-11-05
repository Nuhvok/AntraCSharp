using System;

namespace AssignmentThree
{
    class Program
    {
        static void Main(string[] args)
        {
            //One.Start2();

            //Student st = new Student().

            //Ball ball = new Ball(10, 12, 13, 14, 15);
            //ball.Throw = 1;

            Customer cust = new Customer("john", "doe", "sample@email.com");
            cust.addOrder("keyboard", 2);
            cust.addOrder("mouse", 1);

            foreach(Order order in cust.Orders)
            {
                Console.WriteLine(order.ToString());
            }

            // It is impossible to add a null order
            // It is also impossible to have a duplicate order ID

            cust.Orders[0].OrderDate = cust.Orders[0].OrderDate.AddMonths(1);

            foreach (Order order in cust.Orders)
            {
                Console.WriteLine(order.ToString());
            }


            One.Start3();
        }
    }
}
