using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Cfg;
using NHibernate;

namespace IdBag {
  class Program {
    static void Main(string[] args) {

      ISessionFactory sessionFactory = new Configuration().AddAssembly(typeof(Program).Assembly).BuildSessionFactory();
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
