using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Cfg;
using NHibernate;
using FluentNHibernate.Cfg;

namespace UniqueKeys {
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
      Console.WriteLine("Company:");
      Console.WriteLine("------------------------------------------------------");
      foreach (Company company in session.CreateQuery("from Company").List<Company>()) {
        Console.WriteLine(string.Format("Company: '{0}'  |  Factories count: {1}", company.CompanyName, company.Factories.Count));
        foreach (Factory factory in company.Factories)
          Console.WriteLine(string.Format("                   Factory: '{0}'", factory.FactoryName));

      }
      Console.Read();
    }
  }
}
