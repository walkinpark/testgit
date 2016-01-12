using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Cfg;
using NHibernate;
using FluentNHibernate.Cfg;

namespace ManyToOne {
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
      foreach (Order order in session.CreateQuery("from Order").List()) {
        Console.WriteLine(string.Format("Customer: '{0}'  ShipAddress: '{1}','{2}','{3}'", order.Customer, order.ShipAddress.Address, order.ShipAddress.City, order.ShipAddress.Country.CountryName));
      }

      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("------------------------------------------------------");
      Console.WriteLine("Suppliers:");
      Console.WriteLine("------------------------------------------------------");
      foreach (Supplier supplier in session.CreateQuery("from Supplier").List()) {
        Console.WriteLine(string.Format("Supplier: '{0}'  Address: '{1}','{2}','{3}'", supplier.CompanyName, supplier.Address.Address, supplier.Address.City, supplier.Address.Country.CountryName));
      }

      Console.Read();
    }
  }
}
