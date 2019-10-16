using System;
using System.Collections.Generic;

namespace DefaultInterfaceMethods
{
    public interface ICustomer
    {
        IEnumerable<IOrder> PreviousOrders { get; }

        DateTime DateJoined { get; }
        DateTime? LastOrder { get; }
        string Name { get; }
        IDictionary<DateTime, string> Reminders { get; }
    }

    public interface IOrder
    {
        DateTime Purchased { get; }
        decimal Cost { get; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
