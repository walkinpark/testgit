using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Cfg;
using NHibernate;
using FluentNHibernate.Cfg;

namespace EmbededComplexTypes {
  class Program {
    static void Main(string[] args) {

      bool isFluentMapping = true;
      ISessionFactory sessionFactory;
      if (isFluentMapping)
        sessionFactory = Fluently.Configure().Mappings(m => m.FluentMappings.AddFromAssemblyOf<Program>()).BuildSessionFactory();
      else
        sessionFactory = new Configuration().AddAssembly(typeof(Program).Assembly).BuildSessionFactory();
      ISession session = sessionFactory.OpenSession();

      IList<Customer> customers = session.CreateQuery("from Customer").List<Customer>();
      Console.WriteLine("");
      Console.WriteLine("------------------------------------------------------");
      Console.WriteLine("Customers:");
      Console.WriteLine("------------------------------------------------------");
      foreach (Customer customer in customers) {
        Console.WriteLine(string.Format("Company: {0}  Contact: {1}: Address: {2} {3} {4} {5} {6} {7} {8}", customer.CompanyName, customer.ContactName, customer.FullAddress.Address, customer.FullAddress.Address.City, customer.FullAddress.Address.Country, customer.FullAddress.Address.Region, customer.FullAddress.Address.PostalCode, customer.FullAddress.Phone, customer.FullAddress.Fax));
      }

      IList<Order> orders = session.CreateQuery("from Order").List<Order>();
      Console.WriteLine("");
      Console.WriteLine("------------------------------------------------------");
      Console.WriteLine("Orders:");
      Console.WriteLine("------------------------------------------------------");
      foreach (Order order in orders) {
        Console.WriteLine(string.Format("Ship: {0}  ShippedDate: {1}: ShipAddress: {2} {3} {4} {5} {6}", order.ShipName, order.ShippedDate, order.ShipAddress.Address, order.ShipAddress.City, order.ShipAddress.Country, order.ShipAddress.Region, order.ShipAddress.PostalCode));
      }

      Console.Read();
    }
  }
}
