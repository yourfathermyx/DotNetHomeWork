using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService os = new OrderService();

            //新建订单操作
            Order o1 = new Order(1, new OrderDetails("Coke", "Alan", 3));
            Order o2 = new Order(1, new OrderDetails("Coke", "Alan", 3));
            Order o3 = new Order(2, "Milk", "Betty", 20);
            Order o4 = new Order(3, "Fruit", "Chris", 30);
            Order o5 = new Order(4, "Beef", "Chris", 10);


            //添加订单操作
            Console.WriteLine("o1添加成功：" + os.AddOrder(o1));
            Console.WriteLine("o2添加成功：" + os.AddOrder(o2));//重复，返回false
            Console.WriteLine("o4添加成功：" + os.AddOrder(o4));
            Console.WriteLine("o3添加成功：" + os.AddOrder(o3));
            Console.WriteLine("o5添加成功：" + os.AddOrder(o5));
            Console.WriteLine("\n\n原始订单");

            foreach (Order o in os.orders)
            {
                //重写了ToString方法
                Console.WriteLine(o);
            }
            //按订单号对订单排序
            os.SortOrdersByOrderID();
            Console.WriteLine("\n\n按订单号排序后");
            //打印当前所有订单，已按订单号排序
            foreach (Order o in os.orders)
            {
                Console.WriteLine(o);
            }

            //删除订单
            Console.WriteLine("\n\no3删除成功：" + os.DeleteOrder(o3.orderID));
            Console.WriteLine("删除o3后");
            //打印当前所有订单，订单号2的订单已删除
            foreach (Order o in os.orders)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine("\n\n修改o1后");
            //修改订单，将o1的cost改为100，productName改为wine
            os.ModifyOrder(o1.orderID, "Wine", o1.orderDetails.customerName, 100);
            //打印所有订单，此时o1的cost已经变为100,productName已经变为Wine
            foreach (Order o in os.orders)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine("\n\n按姓名查找,且按金额递增排序");
            //按照顾客姓名查找，也可以按照订单号查找，并且返回按照订单金额排序的结果
            var ordersByChris = os.QueryByCustomerName("Chris");
            //打印查找结果
            foreach (Order o in ordersByChris)
            {
                Console.WriteLine(o);
            }

            os.Export("s.xml");
            Console.WriteLine("Exported.");

            os.Import("s.xml");
            Console.WriteLine("Imported.");
            foreach (Order o in os.orders)
            {
                Console.WriteLine(o);
            }
        }

        public class Order
        {
            public OrderDetails orderDetails { get; set; }
            public int orderID { get; set; }
            public Order() { }
            public Order(int orderID, string productNames
                , string consumerName, double orderCost)
            {
                this.orderID = orderID;
                this.orderDetails = new OrderDetails(productNames
                , consumerName, orderCost);
            }
            public Order(int orderID, OrderDetails orderDetails)
            {
                this.orderID = orderID;
                this.orderDetails = orderDetails;
            }
            //重写Equals()
            public override bool Equals(object obj)
            {
                return obj != null && obj is Order o &&
                    o.orderID == this.orderID &&
                    o.orderDetails.Equals(this.orderDetails);
            }
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }
            //重写ToString()
            public override string ToString()
            {
                return $"Order ID:{this.orderID} " + this.orderDetails.ToString();
            }
        }

        public class OrderDetails
        {
            public OrderDetails() { }
            public string productName
            {
                get;
                set;
            }
            public string customerName
            {
                get;
                set;
            }
            public double orderCost
            {
                get;
                set;
            }
            public OrderDetails(string productName
                , string customerName, double orderCost)
            {
                this.productName = productName;
                this.customerName = customerName;
                this.orderCost = orderCost;
            }
            //重写Equals()
            public override bool Equals(Object myobject)
            {
                return myobject != null && myobject is OrderDetails od &&
                    this.customerName.Equals(od.customerName) &&
                    this.productName.Equals(od.productName) &&
                    this.orderCost == od.orderCost;
            }
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }
            //重写ToString()
            public override string ToString()
            {
                return $"Product name:{this.productName} Customer name:{this.customerName} Cost:{this.orderCost}";
            }
        }

        public class OrderNotExistException : Exception
        {
            private int code;
            public int Code { get => code; }
            public OrderNotExistException(String msg, int code) : base(msg)
            {
                this.code = code;
            }
        }
        public class OrderService
        {
            //订单表
            public List<Order> orders = new List<Order>();
            //按ID查询
            public List<Order> QueryByID(int orderID)
            {
                var o = from order in this.orders
                        where order.orderID == orderID
                        orderby order.orderDetails.orderCost
                        select order;
                return o.ToList();
            }
            //按顾客姓名查询，并且金额递增排序
            public List<Order> QueryByCustomerName(string customerName)
            {
                var o = from order in this.orders
                        where order.orderDetails.customerName == customerName
                        orderby order.orderDetails.orderCost
                        select order;
                return o.ToList();
            }
            //添加订单
            public bool AddOrder(Order o)
            {
                if (o == null)
                {
                    throw new ArgumentException();
                }
                if (QueryByID(o.orderID).Count() != 0)
                {
                    return false;
                }
                orders.Add(o);
                return true;
            }
            //删除订单
            public bool DeleteOrder(int orderID)
            {
                List<Order> o = QueryByID(orderID);
                if (o.Count == 0)
                {
                    throw new OrderNotExistException("No such order", 3);
                }
                else
                {
                    foreach (Order order in o)
                    {
                        orders.Remove(order);
                    }
                }
                return true;
            }
            //修改订单
            public void ModifyOrder(int orderID, string productName, string costumerName, double cost)
            {
                List<Order> o = QueryByID(orderID);
                if (o.Count == 0)
                {
                    throw new OrderNotExistException("No such order", 3);
                }
                else
                {
                    orders.Remove(o[0]);
                    this.AddOrder(new Order(orderID, productName, costumerName, cost));
                }
            }
            //对订单按订单号排序
            public void SortOrdersByOrderID()
            {
                var temp = from o in this.orders
                           orderby o.orderID
                           select o;
                this.orders = temp.ToList();
            }

            public void Export(string filePath)
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Order[]));
                using (FileStream fs = new FileStream(filePath, FileMode.Create))
                {
                    xmlSerializer.Serialize(fs, this.orders.ToArray());
                }
            }
            public void Import(string filePath)
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Order[]));
                using (FileStream fs = new FileStream(filePath, FileMode.Open))
                {
                    this.orders = new List<Order>((Order[])xmlSerializer.Deserialize(fs));
                }
            }
        }
    }
}
