using Strategy.Concrete;
using Strategy.Context;
using System;
using System.Collections.Generic;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Simple implementation
            var navigator = new Navigator(new WalkingRoute());
            Console.WriteLine(navigator.AssignRoute("a", "b"));
            Console.WriteLine();

            navigator = new Navigator(new BusRoute());
            Console.WriteLine(navigator.AssignRoute("z", "f"));
            Console.WriteLine();

            navigator = new Navigator(new TaxiRoute());
            Console.WriteLine(navigator.AssignRoute("a", "f"));
            Console.WriteLine();

            Console.ReadLine();
            #endregion
        }
    }
}
