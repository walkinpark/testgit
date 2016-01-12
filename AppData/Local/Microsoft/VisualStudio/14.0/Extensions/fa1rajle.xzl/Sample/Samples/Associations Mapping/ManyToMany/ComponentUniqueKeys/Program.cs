using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Cfg;
using NHibernate;
using FluentNHibernate.Cfg;

namespace ComponentUniqueKeys {
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
        Console.WriteLine(string.Format("Company: '{0}' {1}  |  Factories count: {2}", company.CompanyKey.Name, company.CompanyKey.Phone, company.Factories.Count));
        foreach (Factory factory in company.Factories)
          Console.WriteLine(string.Format("                   Factory: '{0}'  '{1}'", factory.FactoryKey.Name, factory.FactoryKey.Phone));

      }
      Console.Read();
    }
  }
}
