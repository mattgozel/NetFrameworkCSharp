using FlooringMastery.BLL;
using FlooringMastery.Data;
using FlooringMastery.Models;
using FlooringMastery.Models.Responses;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlooringMastery.Tests
{
    [TestFixture]
    public class OrderTest
    {
        DateTime date = DateTime.Today;

        private static string _filePath = @"C:\data\FlooringData\Orders_06012013.txt";
        private static string _originalData = @"C:\data\FlooringData\Orders_06012013Seed.txt";

        [SetUp]
        public void Setup()
        {
            if (File.Exists(_filePath))
            {
                File.Delete(_filePath);
            }

            File.Copy(_originalData, _filePath);
        }

        [Test]
        public void CanReadDataFromFile()
        {
            OrderViewRepository repo = new OrderViewRepository(_filePath);

            List<Order> orders = repo.ViewOrders(date);

            Assert.AreEqual(1, orders.Count());

            Order check = orders[0];

            Assert.AreEqual(1, check.OrderNumber);
            Assert.AreEqual("Wise", check.CustomerName);
            Assert.AreEqual("OH", check.State);
            Assert.AreEqual(6.25M, check.TaxRate);
            Assert.AreEqual("Wood", check.ProductType);
            Assert.AreEqual(100.00M, check.Area);
            Assert.AreEqual(5.15M, check.CostPerSquareFoot);
            Assert.AreEqual(4.75M, check.LaborCostPerSquareFoot);
            Assert.AreEqual(515.00M, check.MaterialCost);
            Assert.AreEqual(475.00M, check.LaborCost);
            Assert.AreEqual(61.88M, check.Tax);
            Assert.AreEqual(1051.88, check.Total);
        }

        [Test]
        public void CanAddStudentToFile()
        {
            AddOrderRepository repo = new AddOrderRepository(_filePath);
            OrderViewRepository listRepo = new OrderViewRepository(_filePath);

            Order newOrder = new Order();

            newOrder.OrderNumber = 2;
            newOrder.CustomerName = "Humble";
            newOrder.State = "MN";
            newOrder.TaxRate = 7.00M;
            newOrder.ProductType = "Wood";
            newOrder.Area = 200M;
            newOrder.CostPerSquareFoot = 5.15M;
            newOrder.LaborCostPerSquareFoot = 4.75M;
            newOrder.MaterialCost = newOrder.Area * newOrder.CostPerSquareFoot;
            newOrder.LaborCost = newOrder.Area * newOrder.LaborCostPerSquareFoot;
            newOrder.Tax = (newOrder.MaterialCost + newOrder.LaborCost) * (newOrder.TaxRate / 100);
            newOrder.Total = newOrder.MaterialCost + newOrder.LaborCost + newOrder.Tax;

            repo.AddOrder(newOrder, date);

            List<Order> orders = listRepo.ViewOrders(date);

            Assert.AreEqual(2, orders.Count());

            Order check = orders[1];

            Assert.AreEqual(2, check.OrderNumber);
            Assert.AreEqual("Humble", check.CustomerName);
            Assert.AreEqual("MN", check.State);
            Assert.AreEqual(7.00M, check.TaxRate);
            Assert.AreEqual("Wood", check.ProductType);
            Assert.AreEqual(200M, check.Area);
            Assert.AreEqual(5.15M, check.CostPerSquareFoot);
            Assert.AreEqual(4.75M, check.LaborCostPerSquareFoot);
            Assert.AreEqual(1030.00M, check.MaterialCost);
            Assert.AreEqual(950.00M, check.LaborCost);
            Assert.AreEqual(138.6000M, check.Tax);
            Assert.AreEqual(2118.6000, check.Total);
        }

        [Test]
        public void CanDeleteStudent()
        {
            Order newOrder = new Order();            
            DeleteOrderRepository repo = new DeleteOrderRepository(_filePath);
            OrderViewRepository listRepo = new OrderViewRepository(_filePath);

            repo.DeleteOrder(1, date, newOrder);

            List<Order> orders = listRepo.ViewOrders(date);

            Assert.AreEqual(0, orders.Count());
        }

        [Test]
        public void CanEditStudent()
        {
            EditOrderRepository repo = new EditOrderRepository(_filePath);
            OrderViewRepository listRepo = new OrderViewRepository(_filePath);

            List<Order> orders = listRepo.ViewOrders(date);
            Order editedOrder = orders[0];

            editedOrder.CustomerName = "BigBaby";
            editedOrder.State = "WY";
            editedOrder.ProductType = "Tile";
            editedOrder.Area = 500M;

            repo.EditOrder(1, date, editedOrder);

            Assert.AreEqual(1, orders.Count());

            Order check = orders[0];

            Assert.AreEqual("BigBaby", check.CustomerName);
            Assert.AreEqual("WY", check.State);
            Assert.AreEqual("Tile", check.ProductType);
            Assert.AreEqual(500M, check.Area);
        }
    }
}
