using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThree
{
    class Order
    {
        private static int? nextGUID;

        private int guid;
        private int quantity;
        private string productName;
        public DateTime orderDate;

        public Order(string productName, int quantity, DateTime orderDate)
        {
            if (nextGUID == null)
            {
                nextGUID = 1;
            }

            this.guid = Convert.ToInt32(nextGUID);
            this.productName = productName;
            this.quantity = quantity;
            this.orderDate = orderDate;
            nextGUID++;
        }

        public int Guid
        {
            get => guid;
        }

        public int Quantity
        {
            get => quantity;
        }

        public string ProductName
        {
            get => productName;
        }

        public DateTime OrderDate
        {
            get => orderDate;
            set
            {
                if((DateTime.Now - value).Seconds > 0)
                {
                    orderDate = value;
                }
            }
        }

        public override string ToString()
        {
            return $"\nGUID:         {Guid}" +
                   $"\nProduct Name: {ProductName}" +
                   $"\nQuantity:     {Quantity}" +
                   $"\nOrder Date:   {OrderDate.ToString()}";
        }
    }
}
