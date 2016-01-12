using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Cfg;
using NHibernate;

namespace IndexManyToMany {
  class Program {
    static void Main(string[] args) {

      ISessionFactory sessionFactory = new Configuration().AddAssembly(typeof(Program).Assembly).BuildSessionFactory();
      ISession session = sessionFactory.OpenSession();

      Console.WriteLine("");
      Console.WriteLine("------------------------------------------------------");
      Console.WriteLine("Company:");
      Console.WriteLine("------------------------------------------------------");
      foreach (Company company in session.CreateQuery("from Company").List<Company>().Where(c => c.Contractors.Count > 0)) {
        Console.WriteLine(string.Format("Company: '{0}'  |  Contractors count: {1}", company.CompanyName, company.Contractors.Count));
        foreach (KeyValuePair<Company, Factory> contractor in company.Contractors)
          Console.WriteLine(string.Format("                   Contractor comapany: '{0}'.  Factory: '{1}'", contractor.Key.CompanyName, contractor.Value.FactoryName));
      }
      Console.Read();
    }
  }
}
