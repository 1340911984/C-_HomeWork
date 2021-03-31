using System;
using System.Collections.Generic;
using System.Linq;



namespace OrderControl
{
    class MyException : Exception
    {
        public MyException(string message) : base(message)
        {
        }
    }
    class Order
    {
        public int Onum { get; set; }
        public int Omoney { get; set; }
        public OrderDetails detail = new OrderDetails();
        public bool Equals(Order order)
        {
            //this非空，obj如果为空，则返回false
            if (ReferenceEquals(null, order)) return false;

            //如果为同一对象，必然相等
            if (ReferenceEquals(this, order)) return true;

            //对比各个字段值
            if (this.GetHashCode() != order.GetHashCode())
                return false;

            //如果基类不是从Object继承，需要调用base.Equals(other)
            //如果从Object继承，直接返回true
            return true;
        }
        public override bool Equals(object obj)
        {
            //this非空，obj如果为空，则返回false
            if (ReferenceEquals(null, obj)) return false;

            //如果为同一对象，必然相等
            if (ReferenceEquals(this, obj)) return true;

            //如果类型不同，则必然不相等
            if (obj.GetType() != this.GetType()) return false;

            //调用强类型对比
            return Equals((Order)obj);
        }
        //实现Equals重写同时，必须重写GetHashCode
        public override int GetHashCode()
        {
            return (this.Onum);
        }
        public override string ToString()
        {
            string i = " Ordernum is:" + Onum.ToString();
            i += " Whole money is:" + Omoney.ToString();
            i += detail.ToString();
            return i;
        }
    }
    class OrderDetails
    {
        public string Oname { get; set; }
        public string Obuyer { get; set; }
        public bool Equals(OrderDetails order)
        {
            //this非空，obj如果为空，则返回false
            if (ReferenceEquals(null, order)) return false;

            //如果为同一对象，必然相等
            if (ReferenceEquals(this, order)) return true;

            //对比各个字段值
            if (this.GetHashCode() != order.GetHashCode())
                return false;

            //如果基类不是从Object继承，需要调用base.Equals(other)
            //如果从Object继承，直接返回true
            return true;
        }
        public override bool Equals(object obj)
        {
            //this非空，obj如果为空，则返回false
            if (ReferenceEquals(null, obj)) return false;

            //如果为同一对象，必然相等
            if (ReferenceEquals(this, obj)) return true;

            //如果类型不同，则必然不相等
            if (obj.GetType() != this.GetType()) return false;

            //调用强类型对比
            return Equals((OrderDetails)obj);
        }
        public override int GetHashCode()
        {
            return ((Oname + Obuyer) != null ? StringComparer.InvariantCulture.GetHashCode((Oname + Obuyer)) : 0);
        }
        public override string ToString()
        {
            string i = " Good name is:" + Oname;
            i += "  Guest is:" + Obuyer;
            return i;
        }
    }
    class OrderService
    {
        static List<Order> list = new List<Order>();
        static public void Add(int num, int money, string name, string buyer)
        {
            OrderDetails detail = new OrderDetails();
            detail.Oname = name;
            detail.Obuyer = buyer;
            Order order = new Order();
            order.Omoney = money;
            order.Onum = num;
            order.detail = detail;
            foreach (Order i in list)
            {
                if (order.Equals(i))
                {
                    throw new MyException("Order  repeat");
                    return;
                }
                if (i.detail.Equals(order.detail))
                {
                    throw new MyException("Detail  repeat");
                    return;
                }
            }
            list.Add(order);
        }
        static public void Modify(int num, int i)
        {
            Order res = null;
            foreach (Order ans in list)
            {
                if (ans.Onum == num)
                {
                    res = ans;
                }
            }
            if (i == 1)
            {
                Console.Write("请输入你要修改的订单价格");
                try
                {
                    int money = int.Parse(Console.ReadLine());
                    res.Omoney = money;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }
            else if (i == 2)
            {
                Console.Write("请输入你要修改的商品名字");
                try
                {
                    string name = Console.ReadLine();
                    res.detail.Oname = name;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else if (i == 3)
            {
                Console.Write("请输入你要修改的客户名字");
                try
                {
                    string buyer = Console.ReadLine();
                    res.detail.Obuyer = buyer;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        static public void Delete(int num)
        {
            try
            {
                foreach (Order i in list)
                {
                    if (i.Onum == num)
                    {
                        list.Remove(i);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static public List<Order> Select(int num)
        {
            var query = from order in list
                        where order.Onum == num
                        orderby order.Onum descending
                        select order;  // 按ID降序
            return query.ToList<Order>();
        }
        static public List<Order> Select(string name)
        {
            var query = from order in list
                        where order.detail.Obuyer == name
                        orderby order.detail.Obuyer descending
                        select order;  // 按名字降序
            return query.ToList<Order>();
        }
        static public void Print()
        {
            foreach (Order i in list)
            {
                Console.WriteLine(i.ToString());
            }
        }
        static public void PrintOnum()
        {
            foreach (Order i in list)
            {
                Console.WriteLine(i.Onum);
            }
        }
    }
    class Program
    {
        class Winform
        {
            public void show()
            {
                OrderService.Add(1123, 28, "香蕉", "小吴");
                OrderService.Add(1123, 28, "苹果", "大物");//重复
                OrderService.Add(8888, 22, "苹果", "高数");
                OrderService.Add(6666, 28, "香蕉", "小吴");//重复
                OrderService.Add(1243, 12, "榴莲", "肥沃");
                OrderService.Add(5623, 66, "大炮", "瘦高");
                try
                {
                    while (true)
                    {

                        Console.WriteLine("******************************");
                        Console.WriteLine("    按1 进入修改商品价格");
                        Console.WriteLine("    按2 进入修改商品名称");
                        Console.WriteLine("    按3 进入修改客户名字");
                        Console.WriteLine("    按4 自动排序所有数据");
                        Console.WriteLine("    按5 进入选择删除界面");
                        Console.WriteLine("    其他数字显示所有数据");
                        Console.WriteLine("   全程输入非数字都会退出");
                        Console.WriteLine("*******************************");

                        Console.Write("请输入：");
                        Console.Write("");
                        int type = int.Parse(Console.ReadLine());
                        switch (type)
                        {
                            case 1:
                                OrderService.PrintOnum();
                                Console.Write("请输入修改的订单号：");
                                int num = int.Parse(Console.ReadLine());
                                OrderService.Modify(num, type);
                                Console.WriteLine("已完成");
                                break;
                            case 2:
                                OrderService.PrintOnum();
                                Console.Write("请输入修改的订单号：");
                                num = int.Parse(Console.ReadLine());
                                OrderService.Modify(num, type);
                                Console.WriteLine("已完成");
                                break;
                            case 3:
                                OrderService.PrintOnum();
                                Console.Write("请输入修改的订单号：");
                                num = int.Parse(Console.ReadLine());
                                OrderService.Modify(num, type);
                                Console.WriteLine("已完成");
                                break;
                            case 4:
                                OrderService.PrintOnum();
                                OrderService.OrderBy();
                                Console.WriteLine("已完成");
                                break;
                            case 5:
                                OrderService.PrintOnum();
                                Console.Write("请输入删除的订单号：");
                                num = int.Parse(Console.ReadLine());
                                OrderService.Delete(num);
                                Console.WriteLine("已完成");
                                break;
                            default:
                                OrderService.Print();
                                break;
                        }




                    }
                    OrderService.Print();
                }
                catch
                {
                    Console.WriteLine("已退出");
                }
            }
        }
        static void Main(string[] args)
        {
            Winform window = new Winform();
            window.show();
        }
    }
}
