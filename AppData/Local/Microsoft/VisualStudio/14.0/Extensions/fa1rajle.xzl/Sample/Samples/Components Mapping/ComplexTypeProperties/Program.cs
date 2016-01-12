using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Cfg;
using NHibernate;
using FluentNHibernate.Cfg;

namespace ComplexTypeProperties {
  class Program {
    static void Main(string[] args) {

      bool isFluentMapping = false;
      ISessionFactory sessionFactory;
      if (isFluentMapping)
        sessionFactory = Fluently.Configure().Mappings(m => m.FluentMappings.AddFromAssemblyOf<Program>()).BuildSessionFactory();
      else
        sessionFactory = new Configuration().AddAssembly(typeof(Program).Assembly).BuildSessionFactory();
      ISession session = sessionFactory.OpenSession();

      IList<Order> orders = session.CreateQuery("from Order").List<Order>();
      Console.WriteLine("");
      Console.WriteLine("------------------------------------------------------");
      Console.WriteLine("Orders:");
      Console.WriteLine("------------------------------------------------------");
      foreach (Order order in orders) {
        Console.WriteLine(string.Format("Ship: {0}  ShippedDate: {1}: ShipAddress: {2} {3} {4} {5} {6}", order.ShipName, order.ShippedDate, order.ShipAddress.Address, order.ShipAddress.City, order.ShipAddress.Country, order.ShipAddress.Region, order.ShipAddress.PostalCode));
      }


      IList<Customer> customers = session.CreateQuery("from Customer").List<Customer>();
      Console.WriteLine("");
      Console.WriteLine("------------------------------------------------------");
      Console.WriteLine("Customers:");
      Console.WriteLine("------------------------------------------------------");
      foreach (Customer customer in customers) {
        Console.WriteLine(string.Format("Company: {0}  Contact: {1}: Address: {2} {3} {4} {5} {6}", customer.CompanyName, customer.ContactName, customer.Address.Address, customer.Address.City, customer.Address.Country, customer.Address.Region, customer.Address.PostalCode));
      }

      Console.Read();
    }
  }
}
