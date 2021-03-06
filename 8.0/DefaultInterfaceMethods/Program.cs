﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace DefaultInterfaceMethods
{
    public interface ICustomer
    {
        IEnumerable<IOrder> PreviousOrders { get; }

        DateTime DateJoined { get; }
        DateTime? LastOrder { get; }
        string Name { get; }
        IDictionary<DateTime, string> Reminders { get; }

        // Version 2:
        public static void SetLoyaltyThresholds(
            TimeSpan ago,
            int minimumOrders = 10,
            decimal percentageDiscount = 0.10m)
        {
            length = ago;
            orderCount = minimumOrders;
            discountPercent = percentageDiscount;
        }
        private static TimeSpan length = new TimeSpan(365 * 2, 0, 0, 0); // two years
        private static int orderCount = 10;
        private static decimal discountPercent = 0.10m;

        public decimal ComputeLoyaltyDiscount() => DefaultLoyaltyDiscount(this);
        protected static decimal DefaultLoyaltyDiscount(ICustomer c)
        {
            DateTime start = DateTime.Now - length;

            if ((c.DateJoined < start) && (c.PreviousOrders.Count() > orderCount))
            {
                return discountPercent;
            }
            return 0;
        }
    }

    public interface IOrder
    {
        DateTime Purchased { get; }
        decimal Cost { get; }
    }

    public class SampleCustomer : ICustomer
    {
        private List<IOrder> previousOrders;
        private DateTime? lastOrder;

        public SampleCustomer(string name, DateTime dateJoined)
        {
            Name = name;
            DateJoined = dateJoined;
            Reminders = new Dictionary<DateTime, string>();
            previousOrders = new List<IOrder>();
        }

        public IEnumerable<IOrder> PreviousOrders => this.previousOrders;

        public DateTime DateJoined { get; }

        public DateTime? LastOrder => this.lastOrder;

        public string Name { get; }

        public IDictionary<DateTime, string> Reminders { get; }

        public void AddOrder(SampleOrder order)
        {
            this.previousOrders.Add(order);
            this.lastOrder = order.Purchased;
        }
        public decimal ComputeLoyaltyDiscount()
        {
            if (PreviousOrders.Any() == false)
                return 0.50m;
            else
                return ICustomer.DefaultLoyaltyDiscount(this);
        }
    }

    public class SampleOrder : IOrder
    {
        public SampleOrder(DateTime purchased, decimal cost)
        {
            Purchased = purchased;
            Cost = cost;
        }

        public DateTime Purchased { get; }
        public decimal Cost { get; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new SampleCustomer("customer one", new DateTime(2010, 5, 31))
            {
                Reminders =
                {
                    { new DateTime(2010, 08, 12), "childs's birthday" },
                    { new DateTime(1012, 11, 15), "anniversary" }
                }
            };


            SampleOrder o = new SampleOrder(new DateTime(2012, 6, 1), 5m);
            c1.AddOrder(o);

            o = new SampleOrder(new DateTime(2103, 7, 4), 25m);
            c1.AddOrder(o);

            // Check the discount:
            ICustomer theCustomer = c1;
            ICustomer.SetLoyaltyThresholds(new TimeSpan(30, 0, 0, 0), 1, 0.25m);
            Console.WriteLine($"Current discount: {theCustomer.ComputeLoyaltyDiscount()}");
            
            ICustomer c2 = new SampleCustomer("customer one", new DateTime(2010, 5, 31))
            {
                Reminders =
                {
                    { new DateTime(2022, 10, 5), "anniversary" }
                }
            };

            Console.WriteLine($"Current discount for other customer: {c2.ComputeLoyaltyDiscount()}");
        }
    }
}
