using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Cfg;
using NHibernate;
using FluentNHibernate.Cfg;

namespace ManyToMany {
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
      Console.WriteLine("Factories:");
      Console.WriteLine("------------------------------------------------------");
      foreach (Factory factory in session.CreateQuery("from Factory").List<Factory>()) {
        Console.WriteLine(string.Format("Factory: '{0}'; WorkersCount:{1}; Address:'{2}' |  Partners count: {3}", factory.FactoryDescription.Name, factory.WorkersCount, factory.FactoryDescription.Address, factory.FactoryDescription.Partners.Count));
        foreach (Company company in factory.FactoryDescription.Partners)
          Console.WriteLine(string.Format("             Partner company: '{0}'", company.CompanyName));
      }


      Console.WriteLine("");
      Console.WriteLine("------------------------------------------------------");
      Console.WriteLine("Shops:");
      Console.WriteLine("------------------------------------------------------");
      foreach (Shop shop in session.CreateQuery("from Shop").List<Shop>()) {
        Console.WriteLine(string.Format("Shop: '{0}'; Address:'{1}' |  Partners count: {2}", shop.ShopDescription.Name, shop.ShopDescription.Address, shop.ShopDescription.Partners.Count));
        foreach (Company company in shop.ShopDescription.Partners)
          Console.WriteLine(string.Format("             Partner company: '{0}'", company.CompanyName));
      }

      Console.Read();
    }
  }
}
