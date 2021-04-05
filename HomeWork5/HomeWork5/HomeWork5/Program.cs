using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService orderService = new OrderService();
            int num = 3;//订单总数
            //添加订单
            for (int i = 0; i < num; i++)
            {
                orderService.AddOneOrder();
            }
            //删除订单
            Console.Clear();
            orderService.DeleteOneOrder();
            Console.Clear();
            orderService.DisplayOrders();

            //修改订单
            Console.Clear();
            orderService.ModifyOrder();
            Console.Clear();
            orderService.DisplayOrders();

            //查询订单
            Console.Clear();
            orderService.SearchOrder();
        }
    }

    class Order
    {
        private static int count = 0;

        public string Sender { get; set; }
        public string Receiver { get; set; }
        public DateTime PayTime { get; }
        private double CostSum { get; set; }
        public string SenderAddress { get; set; }
        public string ReceiverAddress { get; set; }
        public int ID { get; }
        public List<OrderDetails> Goods;

        public Order(string sender, string receiver, string senderAddress, string receiveAddress, List<OrderDetails> goods)
        {
            Sender = sender;
            Receiver = receiver;
            SenderAddress = senderAddress;
            ReceiverAddress = receiveAddress;
            PayTime = DateTime.Now;
            count++;
            ID = count;
            Goods = goods;
            foreach (OrderDetails orderDetails in goods)
            {
                CostSum += orderDetails.CostSum;
            }
        }

        public double GetRefreshCostSum()
        {
            CostSum = 0;
            foreach (OrderDetails orderDetails in Goods)
            {
                CostSum += orderDetails.CostSum;
            }
            return CostSum;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append("订单ID：" + ID);
            str.Append('\n');
            str.Append("下单时间：" + PayTime + '\n');
            str.Append("用户：" + Sender + "-------->" + Receiver + '\n');
            str.Append("地址：" + SenderAddress + "-------->" + ReceiverAddress + '\n');
            str.Append("订单明细：" + '\n');
            foreach (OrderDetails orderDetails in Goods)
            {
                str.Append(orderDetails.ToString());
            }
            str.Append("总价为：" + GetRefreshCostSum() + '\n');
            str.Append('\n');
            return str.ToString();
        }

    }

    class OrderDetails
    {
        public string GoodName { get; set; }
        public double CostPerGood { get; set; }
        private int numOfGood;
        public int NumOfGood
        {
            get { return numOfGood; }
            set
            {
                numOfGood = value < 0 ? 0 : value;

            }
        }

        public double CostSum { get { return CostPerGood * NumOfGood; } }

        public OrderDetails(string name, double price, int num)
        {
            GoodName = name;
            CostPerGood = price;
            NumOfGood = num;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(GoodName + "  " + CostPerGood + "元/个  " + NumOfGood + "个" + '\n');
            return str.ToString();

        }


    }

    class OrderService
    {
        private List<Order> orders = new List<Order>();

        public void AddOneOrder()
        {
            List<OrderDetails> orderDetails = new List<OrderDetails>();
            Console.WriteLine("请输入发货人姓名：");
            string sender = Console.ReadLine();
            Console.WriteLine("请输入收货人姓名：");
            string receiver = Console.ReadLine();
            Console.WriteLine("请输入发货地址：");
            string senderAddress = Console.ReadLine();
            Console.WriteLine("请输入收货地址：");
            string receiveAddress = Console.ReadLine();
            Console.WriteLine("请输入要添加的商品种数");
            int numOfGoods = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < numOfGoods; i++)
            {
                OrderDetails orderDetailsTemp = null;
                AddOneGood(ref orderDetailsTemp);
                orderDetails.Add(orderDetailsTemp);
            }
            orders.Add(new Order(sender, receiver, senderAddress, receiveAddress, orderDetails));

        }

        private void AddOneGood(ref OrderDetails orderDetailsTemp)
        {
            Console.WriteLine("请输入商品名称：");
            string name = Console.ReadLine();
            Console.WriteLine("请输入商品单价：");
            double price = Double.Parse(Console.ReadLine());
            Console.WriteLine("请输入购买的商品数量：");
            int num = Int32.Parse(Console.ReadLine());
            orderDetailsTemp = new OrderDetails(name, price, num);

        }
        public void DisplayOrders()
        {
            for (int i = 0; i < orders.Count; i++)
            {
                Console.WriteLine(orders[i].ToString());
            }
        }
        public void DeleteOneOrder()
        {
            DisplayOrders();
            Console.WriteLine("请输入你要删除的订单ID：");
            int IDDelete = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < orders.Count; i++)
            {
                if (orders[i].ID == IDDelete)
                {
                    orders.Remove(orders[i]);
                    return;
                }
            }
            throw new ArgumentException("不存在该ID的订单");
        }

        public void ModifyOrder()
        {
            DisplayOrders();
            Console.WriteLine("请输入你要修改的订单ID：");
            int IDModify = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < orders.Count; i++)
            {
                if (orders[i].ID == IDModify)
                {
                    Console.WriteLine("请输入要修改的项目：(A、GoodName B、CostPerGood C、NumOfGood)");
                    char ModifyProject = Char.Parse(Console.ReadLine());
                    Console.WriteLine("请问您想要修改第几条订单明细？");
                    int num = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("您要修改为：");
                    string ValueAfterModify = Console.ReadLine();
                    switch (ModifyProject)
                    {
                        case 'A':
                            orders[i].Goods[num - 1].GoodName = ValueAfterModify;
                            break;
                        case 'B':
                            orders[i].Goods[num - 1].CostPerGood = Double.Parse(ValueAfterModify);
                            break;
                        case 'C':
                            orders[i].Goods[num - 1].NumOfGood = Int32.Parse(ValueAfterModify);
                            break;
                        default:
                            throw new ArgumentException("不存在该项目");
                    }
                    return;
                }
            }
            throw new ArgumentException("不存在该ID的订单");
        }

        public void SearchOrder()
        {
            Console.WriteLine("请问根据什么查询订单？");
            Console.WriteLine("A.订单号  B.商品名称  C.发件人  D.订单金额");
            char choice = Char.Parse(Console.ReadLine());
            switch (choice)
            {
                case 'A':
                    Console.WriteLine("输入要查询的订单号：");
                    int searchID = Int32.Parse(Console.ReadLine());
                    var query1 = from o in orders
                                 where o.ID == searchID
                                 orderby o.GetRefreshCostSum()
                                 select o;
                    foreach (var orderDisp in query1)
                    {
                        Console.WriteLine(orderDisp.ToString());
                    }
                    break;

                case 'B':
                    Console.WriteLine("请输入要查询的商品名称：");
                    string searchGoodName = Console.ReadLine();
                    var query2 = from o in orders
                                 from o2 in o.Goods
                                 where o2.GoodName == searchGoodName
                                 orderby o.GetRefreshCostSum()
                                 select o;
                    foreach (var orderDisp in query2)
                    {
                        Console.WriteLine(orderDisp.ToString());
                    }
                    break;
                case 'C':
                    Console.WriteLine("请输入要查询的发件人姓名：");
                    string searchSenderName = Console.ReadLine();
                    var query3 = from o in orders
                                 where o.Sender == searchSenderName
                                 orderby o.GetRefreshCostSum()
                                 select o;
                    foreach (var orderDisp in query3)
                    {
                        Console.WriteLine(orderDisp.ToString());
                    }
                    break;
                case 'D':
                    var query4 = from o in orders
                                 orderby o.GetRefreshCostSum()
                                 select o;
                    foreach (var orderDisp in query4)
                    {
                        Console.WriteLine(orderDisp.ToString());
                    }
                    break;
            }
        }


        public void Sort()
        {
            for (int i = 0; i < orders.Count - 1; i++)
            {
                for (int j = 0; j < orders.Count - i - 1; j++)
                {
                    if (orders[j].ID > orders[j + 1].ID)
                    {
                        Order orderTemp = orders[j];
                        orders[j] = orders[j + 1];
                        orders[j + 1] = orderTemp;
                    }
                }
            }
        }
    }
}