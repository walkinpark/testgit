using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Cfg;
using NHibernate;
using FluentNHibernate.Cfg;

namespace JoinTables {
  class Program {
    static void Main(string[] args) {

      bool isFluentMapping = false;
      ISessionFactory sessionFactory;
      if (isFluentMapping)
        sessionFactory = Fluently.Configure().Mappings(m => m.FluentMappings.AddFromAssemblyOf<Program>()).BuildSessionFactory();
      else
        sessionFactory = new Configuration().AddAssembly(typeof(Program).Assembly).BuildSessionFactory();

      ISession session = sessionFactory.OpenSession();
     
      Console.WriteLine("");
      Console.WriteLine("------------------------------------------------------");
      Console.WriteLine("Orders:");
      Console.WriteLine("------------------------------------------------------");
      foreach (Order order in session.CreateQuery("from Order").List<Order>()) {
        Console.WriteLine(string.Format("{0}  {1} {2} |  Implementers count: {3}", order.OrderID, order.Company, order.Price, order.OrderImplementers.Count));
        foreach (OrderImplementer implementer in order.OrderImplementers)
          Console.WriteLine(string.Format("    Implementer: {0}", implementer.Name));
      }

      Console.Read();
    }
  }
}
