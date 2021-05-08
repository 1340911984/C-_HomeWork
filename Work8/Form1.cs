using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace HomeWork6
{
    public class Client
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public Client(string ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }
        public override string ToString()
        {
            return "ClientID:" + ID + "," + "ClientName:" + Name;
        }
        public override bool Equals(object obj)
        {
            var client = obj as Client;
            return client != null && this.ID == client.ID;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
    public class Goods
    {
        public string Name { get; set; }
        private double price;
        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("The price is negative");
                }
                price = value;
            }
        }
        public Goods(string Name, double price)
        {
            this.Name = Name;
            this.Price = price;
        }
        public override bool Equals(object obj)
        {
            var goods = obj as Goods;
            return goods != null && this.Name == goods.Name;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return "GoodsName:" + Name + "," + "GoodsPrice:" + Price;
        }
    }
    public class Order
    {
        public string OrderID { get; set; }
        public Client Client { get; set; }
        public List<OrderDetails> Details = new List<OrderDetails>();
        public Order(string orderID, Client client)
        {
            this.OrderID = orderID;
            this.Client = client;
        }
        public void addDetails(OrderDetails orderDetail)
        {
            Details.Add(orderDetail);
        }
        public override bool Equals(object obj)
        {
            var m = obj as Order;
            return m != null && m.OrderID == OrderID;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return "OrderID:" + OrderID + "," + "Client:" + "(" + Client + ")";
        }
    }
    public class OrderDetails
    {
        public Goods Goods { get; set; }
        public int Quantity { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public double Total { get { return Goods.Price * Quantity; } }
        public OrderDetails(Goods goods, int quantity, string address, string phone)
        {
            this.Goods = goods;
            this.Quantity = quantity;
            this.Address = address;
            this.Phone = phone;
        }
        public override bool Equals(object obj)
        {
            OrderDetails m = obj as OrderDetails;
            return m != null && m.Phone == Phone;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return "Goods:" + Goods + "/n" + "Quantity:" + Quantity + "Address:" + Address + "/n" + "Phone:" + Phone;
        }
    }
    public class OrderService
    {
        private List<Order> orderlist = new List<Order>();
        public OrderService()
        {
        }
        public List<Order> showOrder()
        {
            return orderlist;
        }
        public void addOrder(Order order)
        {
            orderlist.Add(order);
        }
        public void deleteOrder(Order order)
        {
            var query = from o in orderlist where o.OrderID == order.OrderID select o;
            if (query == null)
            {
                throw new System.NullReferenceException();
            }
            else
            {
                orderlist.Remove((Order)query);
            }
        }
        public void modifyOrder(Order order, Order newOrder)
        {
            var query = from o in orderlist where o.OrderID == order.OrderID select o;
            if (query == null)
            {
                throw new System.NullReferenceException();
            }
            else
            {
                orderlist.Remove((Order)query);
                orderlist.Add((Order)newOrder);
            }
        }
        public List<Order> findOrder(string property, string finding)
        {
            switch (property)
            {
                case "client":
                    var cquery = from o in orderlist where o.Client.Name == finding orderby o.Details.All(d => d.Total > 0) select o;
                    return cquery.ToList();
                case "goods":
                    var gquery = from o in orderlist where o.Details.Any(d => d.Goods.Name == finding) orderby o.Details.All(d => d.Total > 0) select o;
                    return gquery.ToList();
                case "address":
                    var aquery = from o in orderlist where o.Details.Any(d => d.Address == finding) orderby o.Details.All(d => d.Total > 0) select o;
                    return aquery.ToList();
                case "phone":
                    var pquery = from o in orderlist where o.Details.Any(d => d.Phone == finding) orderby o.Details.All(d => d.Total > 0) select o;
                    return pquery.ToList();
                case "total":
                    var tquery = from o in orderlist where o.Details.Any(d => d.Total == Double.Parse(finding)) orderby o.Details.All(d => d.Total > 0) select o;
                    return tquery.ToList();
                default:
                    var query = from o in orderlist where o.OrderID == finding orderby o.Details.All(d => d.Total > 0) select o;
                    return query.ToList();
            }
        }
        public List<Order> orderOrderlist(string property)
        {
            switch (property)
            {
                case "client":
                    var cquery = from o in orderlist orderby o.Client select o;
                    return cquery.ToList();
                case "goods":
                    var gquery = from o in orderlist orderby o.Details.All(d => d.Goods != null) select o;
                    return gquery.ToList();
                case "address":
                    var aquery = from o in orderlist orderby o.Details.All(d => d.Address != null) select o;
                    return aquery.ToList();
                case "phone":
                    var pquery = from o in orderlist orderby o.Details.All(d => d.Phone != null) select o;
                    return pquery.ToList();

                case "total":
                    var tquery = from o in orderlist orderby o.Details.All(d => d.Total > 0) select o;
                    return tquery.ToList();
                default:
                    var query = from o in orderlist orderby o.OrderID select o;
                    return query.ToList();

            }
        }
        public void orderExport(string filename)
        {
            XmlSerializer xmlserializer = new XmlSerializer(typeof(List<OrderDetails>));
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                xmlserializer.Serialize(fs, orderlist);
            }
        }
        public void orderImport(string filename)
        {
            XmlSerializer xmlserializer = new XmlSerializer(typeof(List<OrderDetails>));
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                List<OrderDetails> xmlorderlist = (List<OrderDetails>)xmlserializer.Deserialize(fs);
            }
        }
    }
}
namespace HomeWork8
{
    public partial class Form1 : Form
    {
        public String property { get; set; }
        public String finding { get; set; }

        internal static List<HomeWork6.Order> orderlist = new List<HomeWork6.Order>();

        internal static HomeWork6.OrderService orderService = new HomeWork6.OrderService();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            findingBox.DataBindings.Add("Text", this, "finding");
            selectProperty.DataBindings.Add("SelectedItem", this, "property");
//            HomeWork6.Client client1 = new HomeWork6.Client("TeacherID", "Teacher");

//            HomeWork6.Goods bread = new HomeWork6.Goods("bread", 10);

//           HomeWork6.Order order1 = new HomeWork6.Order("1", client1);

//            order1.addDetails(new HomeWork6.OrderDetails(bread, 4, "America", "12345"));

//            orderService.addOrder(order1);

        }

        private void goodsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void orderBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void orderDetailsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void clientBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void AddOrderbutton_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }

        private void DeleteOrderbutton_Click(object sender, EventArgs e)
        {
            Form1.orderlist = Form1.orderService.findOrder(property, finding);
            foreach (HomeWork6.Order item in Form1.orderlist) { Form1.orderService.deleteOrder(item); }
            foreach (HomeWork6.Order item in Form1.orderService.showOrder())
            {
                this.clientBindingSource.DataSource = item.Client;
                this.orderBindingSource.DataSource = new HomeWork6.Order(item.OrderID, item.Client);
                foreach (HomeWork6.OrderDetails item2 in item.Details)
                {
                    this.goodsBindingSource.DataSource = item2.Goods;
                    this.orderDetailsBindingSource.DataSource = new HomeWork6.OrderDetails(item2.Goods, item2.Quantity, item2.Address, item2.Phone);
                }
            }
            orderDetailGridView1.Update();
            ClientGridView2.Update();
            GoodsGridView3.Update();
            OrderGridView4.Update();
        }

        private void ModifyOrderbutton1_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }

        private void FindOrderbutton1_Click(object sender, EventArgs e)
        {

        }

        private void OutputOrderbutton1_Click(object sender, EventArgs e)
        {
            orderService.orderExport("export.xml");
        }

        private void InputOrderbutton1_Click(object sender, EventArgs e)
        {
            orderService.orderExport("import.xml");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void selectProperty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void findingBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            orderlist = orderService.findOrder(property, finding);
            foreach (HomeWork6.Order item in Form1.orderlist) 
            {
                this.clientBindingSource.DataSource = item.Client;
                this.orderBindingSource.DataSource = new HomeWork6.Order(item.OrderID, item.Client);
                foreach(HomeWork6.OrderDetails item2 in item.Details)
                {
                    this.goodsBindingSource.DataSource = item2.Goods;
                    this.orderDetailsBindingSource.DataSource = new HomeWork6.OrderDetails(item2.Goods, item2.Quantity, item2.Address, item2.Phone);
                }
            }
            orderDetailGridView1.Update();
            ClientGridView2.Update();
            GoodsGridView3.Update();
            OrderGridView4.Update();
        }

        private void ClientGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OrderGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GoodsGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void orderDetailGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            orderDetailGridView1.Update();
            ClientGridView2.Update();
            GoodsGridView3.Update();
            OrderGridView4.Update();
        }

        private void clientBindingSource_CurrentChanged_1(object sender, EventArgs e)
        {

        }
    }
}
